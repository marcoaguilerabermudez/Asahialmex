Imports System.Data.SqlClient
Imports Negocio
Imports Clases
Public Class Frm_GlobalPrenomina
#Region "Variables de clase"
    Dim cadConex As SqlConnection
    Dim cadenaConex As String
    Dim open As Boolean
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal cadConex As SqlConnection, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadConex = cadConex
        Me.cadenaConex = cadenaConex
    End Sub
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_GlobalPrenomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_año.Text = Format(DateTime.Now, "yyyy")

        RellenaCmbSemanas()
        ModificarDiaInicio()
    End Sub
    Private Sub Dtp_FechaInicioSemana_TextChanged(sender As Object, e As EventArgs) Handles Dtp_FechaInicioSemana.TextChanged
        If Dtp_FechaInicioSemana.Value < DateTime.Now Or Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyy") = Format(DateTime.Now, "dd/MM/yyy") Then

            Dim conex As New conexion
            Dim cadenaConexContpaq = conex.conexionContpaq 'Conexion a la BD de contpaq solo se va a usar para traer las fechas que corresponden la semana que se manda
            Dim fechaI As Date = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            Dim NPrenomina As New NPrenomina()
            Dim hrs As New Horarios()
            Dim sem As Integer
            Dim type As String

            Lbl_año.Text = Format(fechaI, "yyyy")
            'nWeek = CInt(DatePart(DateInterval.WeekOfYear, fechaI, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)) + 1 'En base a la fecha seleccionada se pone el numero de semana

            hrs = NPrenomina.RecuperarDiasSemana(cadenaConexContpaq, fechaI)

            type = CmbSemanas.Text.GetType.ToString
            If type = "System.String" Then
                sem = 0
            Else
                sem = CmbSemanas.Text
            End If

            Lbl_año.Text = hrs.Año
            Lbl_Dia1.Text = Format(hrs.FechaI, "dd/MM")
            Lbl_Dia2.Text = Format(DateAdd(DateInterval.Day, 1, hrs.FechaI), "dd/MM")
            Lbl_Dia3.Text = Format(DateAdd(DateInterval.Day, 2, hrs.FechaI), "dd/MM")
            Lbl_Dia4.Text = Format(DateAdd(DateInterval.Day, 3, hrs.FechaI), "dd/MM")
            Lbl_Dia5.Text = Format(DateAdd(DateInterval.Day, 4, hrs.FechaI), "dd/MM")
            lbl_Dia6.Text = Format(DateAdd(DateInterval.Day, 5, hrs.FechaI), "dd/MM")
            lbl_Dia7.Text = Format(hrs.FechaF, "dd/MM")
            If sem <> hrs.Semana Then CmbSemanas.SelectedItem = hrs.Semana
            open = True

        Else
            Dgv_Prenomina_Global.Enabled = False
            MsgBox("Tienes que ingresar una fecha menor a la actual")
            Dgv_Prenomina_Global.DataSource = Nothing
            Dgv_Prenomina_Global.Refresh()
        End If
    End Sub
    Private Sub CmbSemanas_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbSemanas.SelectedValueChanged
        If open = True Then
            Dim fecha As Date
            Dim lstEmp As New LEmpleado

            'ModificarDiaInicio()
            fecha = Lbl_Dia1.Text & "/" & Lbl_año.Text
            'ProcesoPrenominaGlobal(lstEmp, fecha)
        End If
    End Sub
    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click
        If open = True Then
            Dim fecha As Date
            Dim lstEmp As New LEmpleado

            'ModificarDiaInicio()
            fecha = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            ProcesoPrenominaGlobal(lstEmp, fecha)
        End If
    End Sub
#End Region
#Region "Rellena cmb"
    Private Sub RellenaCmbSemanas()
        For i = 1 To 52
            CmbSemanas.Items.Add(i)
        Next
    End Sub
#End Region
#Region "Recuperar"
    Private Function RecuperarEmpleados(ByVal fecha As Date) As LEmpleado
        Dim NPre As New NPrenomina()
        Dim conex As New conexion
        Dim cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008

        Return NPre.EmpleadoGlobalRecuperar(cadConex, fecha)
    End Function
    Private Sub RecuperarIncidencias()
        Dim lstAus As New LAusentismo(), lstVac As New LVacaciones(), lstInc As New LIncapacidad(), lstHE As New LHorasExtra(), lstBja As New LBaja(),
            lstCom As New LComedor()
        Dim NPre As New NPrenomina()
        Dim fechaI As Date
        Dim fechaF As Date
        Dim conex As New conexion
        Dim cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008

        fechaI = (Lbl_Dia1.Text & "/" & Lbl_año.Text)
        fechaF = Format(DateAdd(DateInterval.Day, 6, fechaI), "dd/MM/yyyy")

        lstAus = NPre.RecuperarAusentismo(cadConex, fechaI, fechaF)
        lstVac = NPre.RecuperarVacaciones(cadConex, DateAdd(DateInterval.Day, -10, fechaI), DateAdd(DateInterval.Day, 10, fechaF))
        lstInc = NPre.RecuperarIncapacidades(cadConex)
        lstHE = NPre.RecuperarHorasExtra(cadConex, fechaI, fechaF)
        lstBja = NPre.RecuperarBajas(cadConex, fechaI, fechaF)
        lstCom = NPre.RecuperarComedor(cadConex, fechaI, fechaF)
        RellenaIncidenciasDgvPrenomina(lstAus, lstVac, lstInc, lstHE, lstBja, lstCom)
    End Sub
#End Region
#Region "Rellena Formulario"
    Private Sub RellenaChecadasDgvGlobalPrenomina(ByVal lstEmp As LEmpleado)
        Dim fila As Integer = 0
        Dim ff As Date = lbl_Dia7.Text & "/" & Lbl_año.Text
        Dgv_Prenomina_Global.DataSource = Nothing
        Dgv_Prenomina_Global.Rows.Clear()
        For Each item In lstEmp
            Dgv_Prenomina_Global.Rows.Add()
            Dgv_Prenomina_Global.RowsDefaultCellStyle.BackColor = Color.LightGray
            Dgv_Prenomina_Global.Rows(fila).Height = 30
            Dgv_Prenomina_Global.Rows(fila).Cells("idEmpleado").Value = item.IdEmpleado
            Dgv_Prenomina_Global.Rows(fila).Cells("idEmpleado").Style.BackColor = Color.White
            item.NombreCompleto = item.Nombres
            If item.ApellidoPaterno <> "x" Or item.ApellidoPaterno <> "X" Or item.ApellidoPaterno <> "" Then item.NombreCompleto = item.NombreCompleto & " " & item.ApellidoPaterno
            If item.ApellidoMaterno <> "x" Or item.ApellidoMaterno <> "X" Or item.ApellidoMaterno <> "" Then item.NombreCompleto = item.NombreCompleto & " " & item.ApellidoMaterno

            Dgv_Prenomina_Global.Rows(fila).Cells("nombreEmpleado").Value = item.NombreCompleto
            Dgv_Prenomina_Global.Rows(fila).Cells("nombreEmpleado").Style.BackColor = Color.White
            Dgv_Prenomina_Global.Rows(fila).Cells("departamentoEmpleado").Value = item.Departamento
            Dgv_Prenomina_Global.Rows(fila).Cells("departamentoEmpleado").Style.BackColor = Color.White
            Dgv_Prenomina_Global.Rows(fila).Cells("turnoEmpleado").Value = item.Turno
            Dgv_Prenomina_Global.Rows(fila).Cells("turnoEmpleado").Style.BackColor = Color.White
            Dgv_Prenomina_Global.Rows(fila).Cells("idTurnoEmpleado").Value = item.IdTurno
            Dgv_Prenomina_Global.Rows(fila).Cells("idTurnoEmpleado").Style.BackColor = Color.White

            If item.TP = "B" And item.FechaBaja <= ff Then
                Dgv_Prenomina_Global.Rows(fila).Cells("idEmpleado").Style.BackColor = Color.FromArgb(64, 64, 0)
                Dgv_Prenomina_Global.Rows(fila).Cells("idEmpleado").Style.ForeColor = Color.White
                Dgv_Prenomina_Global.Rows(fila).Cells("nombreEmpleado").Style.BackColor = Color.FromArgb(64, 64, 0)
                Dgv_Prenomina_Global.Rows(fila).Cells("nombreEmpleado").Style.ForeColor = Color.White
            End If

            fila += 1
        Next
        Dgv_Prenomina_Global.Enabled = True
    End Sub
    Private Sub RellenaIncidenciasDgvPrenomina(ByVal lstAus As LAusentismo, ByVal lstVac As LVacaciones, ByVal lstInc As LIncapacidad, ByVal lstHE As LHorasExtra,
                                               ByVal lstBja As LBaja, ByVal lstCom As LComedor)
        Dim fecha As Date = Format((Lbl_Dia1.Text + "/" + Lbl_año.Text))
        Dim totalFilas As Integer = Dgv_Prenomina_Global.Rows.Count()

        RellenaBajas(lstBja, fecha, totalFilas)
        RellenaIncapacidad(lstInc, fecha, totalFilas)
        RellenaVacaciones(lstVac, fecha, totalFilas)
        RellenaComedor(lstCom, fecha, totalFilas)
        RellenarHrsExtraDTFeriadoRet(lstHE, fecha, totalFilas)
        'RellenaAusentismo(lstAus, fecha, totalFilas)
        'RellenaDescanso(totalFilas)
    End Sub
    Private Sub RellenaBajas(ByVal lstBja As LBaja, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim fila As Integer
        Dim inc As String = "BAJA"
        For Each item In lstBja
            For fila = 0 To totalFilas - 1
                Dim idEmp As Integer = Dgv_Prenomina_Global.Rows(fila).Cells("idEmpleado").Value
                If idEmp = item.IdEmpleado Then
                    Dim fb As Date = item.Fecha '(Lbl_Dia1.Text + "/" + Lbl_año.Text)
                    Dim fc As Date = fecha
                    For x = 1 To 7
                        If fb = fc Then
                            For colum = x To 7
                                Dim d As String = RetornarDia(colum)
                                Dim t As String = "TE" & colum
                                Dim c As String = "CM" & colum
                                Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = inc
                                Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(64, 64, 0)
                                Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.White
                                Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = inc
                                Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.BackColor = Color.FromArgb(64, 64, 0)
                                Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.ForeColor = Color.White
                                Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = inc
                                Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.FromArgb(64, 64, 0)
                                Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.White
                            Next
                        End If
                        fc = DateAdd(DateInterval.Day, 1, fc)
                    Next
                End If
            Next
        Next
    End Sub
    Private Sub RellenaIncapacidad(ByVal lstInc As LIncapacidad, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim fila As Integer
        Dim dur As Integer
        Dim fechaF As Date
        Dim fechaC As Date
        Dim fechaI As Date
        Dim inc As String = "INC"
        Dim idEmp As Integer
        For Each item In lstInc
            For fila = 0 To totalFilas - 1
                idEmp = Dgv_Prenomina_Global.Rows(fila).Cells("idEmpleado").Value
                If item.IdEmpleado = idEmp Then
                    Dim colum As Integer
                    fechaI = item.FechaI
                    For dur = 1 To item.Duracion
                        fechaF = lbl_Dia7.Text + "/" + Lbl_año.Text
                        For colum = 1 To 7
                            fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                            If item.FechaI <= fechaF Then
                                If fechaI = fechaC Then
                                    Dim d As String = RetornarDia(colum)
                                    Dim t As String = "TE" & colum
                                    Dim c As String = "CM" & colum
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = inc
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.SteelBlue
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.SteelBlue
                                    End If
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = inc
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.BackColor = Color.SteelBlue
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.BackColor = Color.SteelBlue
                                    End If
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = inc
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.SteelBlue
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.SteelBlue
                                    End If
                                End If
                            End If
                        Next
                        fechaI = Format(DateAdd(DateInterval.Day, 1, fechaI), "dd/MM/yyyy")
                    Next
                End If
            Next
        Next
    End Sub
    Private Sub RellenaVacaciones(ByVal lstVac As LVacaciones, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim fila As Integer
        Dim dur As Integer
        Dim fechaF As Date
        Dim fechaC As Date
        Dim fechaI As Date
        Dim inc As String = "VAC"
        Dim idEmp As Integer

        For Each item In lstVac
            For fila = 0 To totalFilas - 1
                idEmp = Dgv_Prenomina_Global.Rows(fila).Cells("idEmpleado").Value
                If idEmp = item.IdEmpleado Then
                    Dim colum As Integer
                    fechaI = item.FechaI
                    For dur = 1 To item.Duracion
                        fechaF = lbl_Dia7.Text + "/" + Lbl_año.Text
                        For colum = 1 To 7
                            fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                            If item.FechaI <= fechaF Then
                                If fechaI = fechaC Then
                                    Dim d As String = RetornarDia(colum)
                                    Dim t As String = "TE" & colum
                                    Dim c As String = "CM" & colum
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = inc
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.DodgerBlue
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.White
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.DodgerBlue
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.White
                                    End If
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = inc
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.BackColor = Color.DodgerBlue
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.ForeColor = Color.White
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.BackColor = Color.DodgerBlue
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.ForeColor = Color.White
                                    End If
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = inc
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.DodgerBlue
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.White
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.DodgerBlue
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.White
                                    End If
                                End If
                            End If
                        Next
                        fechaI = Format(DateAdd(DateInterval.Day, 1, fechaI), "dd/MM/yyyy")
                    Next
                End If
            Next
        Next
    End Sub
    Private Sub RellenaComedor(ByVal lstCom As LComedor, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim fila As Integer
        Dim fechaC As Date
        Dim inc As String
        Dim tp As Integer
        Dim idEmp As Integer
        Dim colum As Integer

        For fila = 0 To totalFilas - 1
            Dim ccm As Integer = 0
            Dim ccj As Integer = 0
            idEmp = Dgv_Prenomina_Global.Rows(fila).Cells("idEmpleado").Value
            For Each item In lstCom
                If idEmp = item.IdEmpleado Then
                    tp = item.TipoComida
                    fechaC = fecha
                    For colum = 0 To 7
                        fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                        If item.FechaComedor = fechaC Then
                            Dim c As String = "CM" & colum
                            Select Case tp
                                Case 1, 2
                                    ccj = ccj + 1
                                    inc = "1J"
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.Red
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1J"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1M" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1M, 1J"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "2M" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "2M, 1J"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1J" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "2J"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = Dgv_Prenomina_Global.Rows(fila).Cells(c).Value + inc
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.Black
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.Red
                                    End If
                                    colum = 7
                                    Exit For
                                Case Else
                                    ccm = ccm + 1
                                    inc = "1M"
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1M"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1M" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "2M"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "2M" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "3M"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White

                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1J" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1J, 1M"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = Dgv_Prenomina_Global.Rows(fila).Cells(c).Value + inc
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.Black
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.Red
                                    End If
                                    colum = 7
                                    Exit For
                            End Select
                        End If
                    Next
                    Dgv_Prenomina_Global.Rows(fila).Cells("COM").Value = ccm + ccj
                    If Dgv_Prenomina_Global.Rows(fila).Cells("COM").Value > 0 Then Dgv_Prenomina_Global.Rows(fila).Cells("COM").Style.BackColor = Color.White
                    Dgv_Prenomina_Global.Rows(fila).Cells("CM").Value = ccm
                    If Dgv_Prenomina_Global.Rows(fila).Cells("CM").Value > 0 Then Dgv_Prenomina_Global.Rows(fila).Cells("CM").Style.BackColor = Color.White
                    Dgv_Prenomina_Global.Rows(fila).Cells("sp").Value = (ccm + ccj) * 16
                    If Dgv_Prenomina_Global.Rows(fila).Cells("sp").Value > 0 Then Dgv_Prenomina_Global.Rows(fila).Cells("sp").Style.BackColor = Color.White
                    Dgv_Prenomina_Global.Rows(fila).Cells("spBono").Value = ccm * 8
                    If Dgv_Prenomina_Global.Rows(fila).Cells("spBono").Value > 0 Then Dgv_Prenomina_Global.Rows(fila).Cells("spBono").Style.BackColor = Color.White
                End If
            Next
        Next
    End Sub
    Private Sub RellenarHrsExtraDTFeriadoRet(ByVal lstHE As LHorasExtra, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim con As New conexion()
        Dim fila As Integer
        Dim fechaI As Date
        Dim fechaC As Date
        Dim inc As String
        Dim idEmp As Integer
        Dim colum As Integer
        Dim tp As String
        Dim hr
        For fila = 0 To totalFilas - 1
            Dim te = 0
            idEmp = Dgv_Prenomina_Global.Rows(fila).Cells("idEmpleado").Value
            For Each item In lstHE
                If idEmp = item.IdEmpleado Then
                    inc = "DT"
                    fechaI = item.Fecha
                    hr = item.Autorizado
                    tp = item.Tipo
                    For colum = 0 To 7
                        fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                        If fechaI = fechaC Then
                            Dim t As String = "TE" & colum
                            If tp = "H" Or tp = "H " Or tp = " H" Then
                                te = hr + te
                                If Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.BackColor = Color.White
                                    Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = con.ConvertirMinutosAHoras(hr)
                                Else
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "DT" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = con.ConvertirMinutosAHoras(hr)
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.ForeColor = Color.DarkRed
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "BAJA" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = con.ConvertirMinutosAHoras(hr)
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.ForeColor = Color.DarkRed
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = Dgv_Prenomina_Global.Rows(fila).Cells(t).Value + con.ConvertirMinutosAHoras(hr)
                                    End If
                                End If
                                Exit For
                            ElseIf tp = "DT" Or tp = "DT " Or tp = " DT" Then
                                Dim d As String = RetornarDia(colum)
                                Dim ti As String = "TE" & colum
                                Dim c As String = "CM" & colum
                                If Dgv_Prenomina_Global.Rows(fila).Cells(ti).Value = "" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Value = inc
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Style.BackColor = Color.FromArgb(51, 51, 51)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Style.ForeColor = Color.LightBlue
                                ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(ti).Value = "1M" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Style.BackColor = Color.FromArgb(51, 51, 51)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Style.ForeColor = Color.LightBlue
                                Else
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Style.BackColor = Color.FromArgb(102, 0, 102)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Style.ForeColor = Color.Black
                                End If

                                If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = inc
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(51, 51, 51)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.LightBlue
                                ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "1M" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(51, 51, 51)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.LightBlue
                                Else
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(102, 0, 102)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.Black
                                End If

                                If Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = inc
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.FromArgb(51, 51, 51)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.LightBlue
                                ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1M" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.FromArgb(51, 51, 51)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.LightBlue
                                Else
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.FromArgb(102, 0, 102)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.Black
                                End If
                                Exit For
                            ElseIf tp = "F" Or tp = "F " Or tp = " F" Then
                                Dim cc_r
                                Dim d As String = RetornarDia(colum)
                                Dim ti As String = "TE" & colum
                                Dim c As String = "CM" & colum
                                If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "FL"
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(204, 204, 255)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.White
                                Else
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(204, 204, 255)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.Black
                                End If

                                If Dgv_Prenomina_Global.Rows(fila).Cells(ti).Value = "" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Value = "FL"
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Style.BackColor = Color.FromArgb(204, 204, 255)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Style.ForeColor = Color.White
                                Else
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Style.BackColor = Color.FromArgb(204, 204, 255)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(ti).Style.ForeColor = Color.Black
                                End If

                                If Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "FL"
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.FromArgb(204, 204, 255)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.White
                                Else
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.FromArgb(204, 204, 255)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.Black
                                End If
                                Exit For
                            ElseIf tp = "R" Or tp = "R " Or tp = " R" Then

                                Exit For
                            End If
                        End If
                    Next
                End If
            Next
        Next
    End Sub
#End Region
#Region "Procesos Varios"
    Private Sub ProcesoPrenominaGlobal(ByVal lstEmp As LEmpleado, ByVal fecha As Date)
        lstEmp = RecuperarEmpleados(fecha)
        If lstEmp(0).Err = False Then
            RellenaChecadasDgvGlobalPrenomina(lstEmp)
            RecuperarIncidencias()
        End If
    End Sub
    Private Sub ModificarDiaInicio()
        Dim fecha As Date
        Dim res As Integer
        Dim dia As String

        dia = WeekdayName(Weekday(Format(DateTime.Now(), "dd/MM/yyyy")))

        Select Case dia
            Case "lunes" : res = -7
            Case "martes" : res = -8
            Case "miércoles" : res = -9
            Case "jueves" : res = -10
            Case "viernes" : res = -11
            Case "sábado" : res = -12
            Case "domingo" : res = -13
        End Select

        fecha = Format(DateAdd(DateInterval.Day, res, DateTime.Now()), "dd/MM/yyyy")

        Dtp_FechaInicioSemana.Value = fecha
    End Sub
    Private Function RetornarDia(ByVal colum As Integer)
        Select Case colum
            Case 1 : Return "Lun"
            Case 2 : Return "Mar"
            Case 3 : Return "Mie"
            Case 4 : Return "Jue"
            Case 5 : Return "Vie"
            Case 6 : Return "Sab"
            Case 7 : Return "Dom"
            Case Else : Return "Err"
        End Select
    End Function
#End Region
End Class