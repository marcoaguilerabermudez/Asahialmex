Imports System.Data.SqlClient
Imports Negocio
Imports Clases
Imports System.IO
Imports System.ComponentModel
Public Class Frm_GlobalPrenomina
#Region "Variables de clase"
    Dim cadConex As SqlConnection
    Dim cadenaConex As String
    Dim open As Boolean
    Dim userName As String
    Dim ruta As String
    Dim archivo As String
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

            type = Cmb_Semanas.Text.GetType.ToString
            If type = "System.String" Then
                sem = 0
            Else
                sem = Cmb_Semanas.Text
            End If

            Lbl_año.Text = hrs.Año
            Lbl_Dia1.Text = Format(hrs.FechaI, "dd/MM")
            Lbl_Dia2.Text = Format(DateAdd(DateInterval.Day, 1, hrs.FechaI), "dd/MM")
            Lbl_Dia3.Text = Format(DateAdd(DateInterval.Day, 2, hrs.FechaI), "dd/MM")
            Lbl_Dia4.Text = Format(DateAdd(DateInterval.Day, 3, hrs.FechaI), "dd/MM")
            Lbl_Dia5.Text = Format(DateAdd(DateInterval.Day, 4, hrs.FechaI), "dd/MM")
            lbl_Dia6.Text = Format(DateAdd(DateInterval.Day, 5, hrs.FechaI), "dd/MM")
            lbl_Dia7.Text = Format(hrs.FechaF, "dd/MM")
            Lbl_SemaI.Text = Format(hrs.FechaI, "dd/MM/yyyy")
            Lbl_SemaF.Text = Format(hrs.FechaF, "dd/MM/yyyy")
            If sem <> hrs.Semana Then Cmb_Semanas.SelectedItem = hrs.Semana
            Btn_Txt.Visible = False
            Btn_Excel.Visible = False
            Txt_FiltroId.Enabled = False
            Txt_FiltroId.Text = ""
            open = True

        Else
            Dgv_Prenomina_Global.Enabled = False
            MsgBox("Tienes que ingresar una fecha menor a la actual")
            ModificarDiaInicio()
            Dgv_Prenomina_Global.DataSource = Nothing
            Dgv_Prenomina_Global.Refresh()
        End If
    End Sub
    Private Sub CmbSemanas_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_Semanas.SelectedValueChanged
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
    Private Sub Btn_Txt_Click(sender As Object, e As EventArgs) Handles Btn_Txt.Click
        'Dgv_Lista.Visible = True
        RecuperarIncidencias(0)
        CrearArchivo()
        EscribirArchivo()
        LeerArchivo()
    End Sub
    Private Sub Btn_Excel_Click(sender As Object, e As EventArgs) Handles Btn_Excel.Click
        GridAExcel(Dgv_Prenomina_Global)
    End Sub
    Private Sub Txt_FiltroId_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroId.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_Prenomina_Global.Rows.Count, idEmp As Integer
        If Txt_FiltroId.Text <> "" Then
            For fila = 0 To totalFilas - 1
                With Dgv_Prenomina_Global.Rows(fila)
                    .Visible = True
                End With
            Next
            For fila = 0 To totalFilas - 1
                With Dgv_Prenomina_Global.Rows(fila)
                    idEmp = .Cells("idEmpleado").Value
                    If Not (idEmp Like Txt_FiltroId.Text) And idEmp <> 0 Then
                        .Visible = True
                    End If
                    If Not (idEmp Like Txt_FiltroId.Text) And idEmp <> 0 Then
                        .Visible = False
                    End If
                End With
            Next
        Else
            For fila = 0 To totalFilas - 1
                With Dgv_Prenomina_Global.Rows(fila)
                    .Visible = True
                End With
            Next
        End If
    End Sub
#End Region
#Region "Rellena cmb"
    Private Sub RellenaCmbSemanas()
        For i = 1 To 52
            Cmb_Semanas.Items.Add(i)
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
    Private Sub RecuperarIncidencias(ByVal dgv As Boolean)
        Dim lstAus As New LAusentismo(), lstVac As New LVacaciones(), lstInc As New LIncapacidad(), lstHE As New LHorasExtra(), lstBja As New LBaja(),
            lstCom As New LComedor(), lstTxt As New LTxtNominas()
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
        lstTxt = NPre.RecuperarTxtNominas(cadConex, fechaI, fechaF)
        If dgv Then
            RellenaIncidenciasDgvPrenomina(lstAus, lstVac, lstInc, lstHE, lstBja, lstCom)
        Else

            RellenaIncidenciasDgvLista(lstTxt)
        End If
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

            With Dgv_Prenomina_Global.Rows(fila)
                .Cells("te").Value = "0:00"
                .Cells("com").Value = 0
                .Cells("cm").Value = 0
                .Cells("sp").Value = 0
                .Cells("spBono").Value = 0

                .Cells("retardo").Value = 0
                .Cells("permisoSalida").Value = 0
                .Cells("falta").Value = 0
                .Cells("faltaJustificada").Value = 0
                .Cells("suspension").Value = 0
                .Cells("permisoSinSueldo").Value = 0
                .Cells("permisoConSueldo").Value = 0
                .Cells("permisoMaternidad").Value = 0
                .Cells("incapacidad").Value = 0
                .Cells("vacaciones").Value = 0
                .Cells("ujap").Value = 0
                .Cells("dJap").Value = 0
                .Cells("umex").Value = 0
                .Cells("dMEx").Value = 0
                .Cells("jpMx").Value = 0
                .Cells("mxJp").Value = 0
                .Cells("suma").Value = 0
                .Cells("diferencia").Value = 0
            End With

            fila += 1
        Next
        Dgv_Prenomina_Global.Columns("nombreEmpleado").Frozen = True
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
        RellenarHrsExtraDTRet(lstHE, fecha, totalFilas)
        RellenaAusentismo(lstAus, fecha, totalFilas)
        RellenaDescansoAsistencias(totalFilas, fecha)
    End Sub
    Private Sub RellenaIncidenciasDgvLista(ByVal lstTxt As LTxtNominas)

        RellenarHrsExtraDTRetLista(lstTxt)
        Dgv_Lista.Sort(Dgv_Lista.Columns("idEmp"), ListSortDirection.Ascending)
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
                                    Dim ccInc = Dgv_Prenomina_Global.Rows(fila).Cells("incapacidad").Value
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
                                    Dgv_Prenomina_Global.Rows(fila).Cells("incapacidad").Value = ccInc + 1
                                    If Dgv_Prenomina_Global.Rows(fila).Cells("incapacidad").Value <> 0 Then Dgv_Prenomina_Global.Rows(fila).Cells("incapacidad").Style.BackColor = Color.White
                                    Exit For
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
                                    Dim ccVac = Dgv_Prenomina_Global.Rows(fila).Cells("vacaciones").Value
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
                                    Dgv_Prenomina_Global.Rows(fila).Cells("vacaciones").Value = ccVac + 1
                                    If Dgv_Prenomina_Global.Rows(fila).Cells("vacaciones").Value <> 0 Then Dgv_Prenomina_Global.Rows(fila).Cells("vacaciones").Style.BackColor = Color.White
                                    Exit For
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
                                        Dgv_Prenomina_Global.Rows(fila).Cells("ujap").Value = Dgv_Prenomina_Global.Rows(fila).Cells("ujap").Value + 1
                                        Dgv_Prenomina_Global.Rows(fila).Cells("ujap").Style.BackColor = Color.White
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1M" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1M, 1J"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                        Dgv_Prenomina_Global.Rows(fila).Cells("mxJp").Value = Dgv_Prenomina_Global.Rows(fila).Cells("mxJp").Value + 1
                                        Dgv_Prenomina_Global.Rows(fila).Cells("mxJp").Style.BackColor = Color.White
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "2M" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "2M, 1J"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1J" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "2J"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                        Dgv_Prenomina_Global.Rows(fila).Cells("dJap").Value = Dgv_Prenomina_Global.Rows(fila).Cells("dJap").Value + 1
                                        Dgv_Prenomina_Global.Rows(fila).Cells("dJap").Style.BackColor = Color.White
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
                                        Dgv_Prenomina_Global.Rows(fila).Cells("umex").Value = Dgv_Prenomina_Global.Rows(fila).Cells("umex").Value + 1
                                        Dgv_Prenomina_Global.Rows(fila).Cells("umex").Style.BackColor = Color.White
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1M" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "2M"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                        Dgv_Prenomina_Global.Rows(fila).Cells("dMex").Value = Dgv_Prenomina_Global.Rows(fila).Cells("dMex").Value + 1
                                        Dgv_Prenomina_Global.Rows(fila).Cells("dMex").Style.BackColor = Color.White
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "2M" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "3M"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White

                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1J" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "1J, 1M"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.White
                                        Dgv_Prenomina_Global.Rows(fila).Cells("jpMx").Value = Dgv_Prenomina_Global.Rows(fila).Cells("jpMx").Value + 1
                                        Dgv_Prenomina_Global.Rows(fila).Cells("jpMx").Style.BackColor = Color.White
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
            With Dgv_Prenomina_Global.Rows(fila)
                .Cells("suma").Value = .Cells("ujap").Value + .Cells("dJap").Value + .Cells("umex").Value + .Cells("dMex").Value + .Cells("jpMx").Value + .Cells("mxJp").Value
                If .Cells("suma").Value <> 0 Then .Cells("suma").Style.BackColor = Color.White
                .Cells("diferencia").Value = .Cells("suma").Value - .Cells("COM").Value
                If .Cells("diferencia").Value <> 0 Then .Cells("diferencia").Style.BackColor = Color.White
            End With
        Next
    End Sub
    Private Sub RellenarHrsExtraDTRet(ByVal lstHE As LHorasExtra, ByVal fecha As Date, ByVal totalFilas As Integer)
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
                                Dim cc_r = Dgv_Prenomina_Global.Rows(fila).Cells("retardo").Value
                                Dim incc As String
                                If item.TipoPermiso = 4 Then
                                    incc = "RT"
                                Else
                                    incc = "R"
                                End If
                                Dim d As String = RetornarDia(colum)
                                Dim ti As String = "TE" & colum

                                If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = incc
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(128, 0, 0)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.FromArgb(255, 255, 153)
                                Else
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = Dgv_Prenomina_Global.Rows(fila).Cells(ti).Value & hr
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(128, 0, 0)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.FromArgb(255, 255, 153)
                                End If
                                Dgv_Prenomina_Global.Rows(fila).Cells("retardo").Value = cc_r + 1
                                If Dgv_Prenomina_Global.Rows(fila).Cells("retardo").Value <> 0 Then Dgv_Prenomina_Global.Rows(fila).Cells("retardo").Style.BackColor = Color.White
                                Exit For
                            ElseIf tp = "P" Or tp = "P " Or tp = " P" Then
                                Dim cc_ps = Dgv_Prenomina_Global.Rows(fila).Cells("permisoSalida").Value
                                Dim d As String = RetornarDia(colum)
                                Dim ti As String = "TE" & colum
                                If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "" Then
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "PS"
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(128, 0, 0)
                                    Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.FromArgb(255, 255, 153)
                                Else
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "INC" Or Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "VAC" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = Dgv_Prenomina_Global.Rows(fila).Cells(d).Value & "PS"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(255, 255, 153)
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(255, 102, 0)
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(ti).Value = "INC" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "PS"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(255, 255, 153)
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(255, 102, 0)
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = Dgv_Prenomina_Global.Rows(fila).Cells(ti).Value & hr
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(128, 0, 0)
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.FromArgb(255, 255, 153)
                                    End If
                                End If
                                Dgv_Prenomina_Global.Rows(fila).Cells("permisoSalida").Value = cc_ps + 1
                                If Dgv_Prenomina_Global.Rows(fila).Cells("permisoSalida").Value <> 0 Then Dgv_Prenomina_Global.Rows(fila).Cells("permisoSalida").Style.BackColor = Color.White
                                Exit For
                            End If
                        End If
                    Next
                    Dgv_Prenomina_Global.Rows(fila).Cells("te").Value = con.ConvertirMinutosAHoras(te)
                    If Dgv_Prenomina_Global.Rows(fila).Cells("te").Value <> "0:00" Then Dgv_Prenomina_Global.Rows(fila).Cells("te").Style.BackColor = Color.White
                End If
            Next
        Next
    End Sub
    Private Sub RellenaAusentismo(ByVal lstAus As LAusentismo, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim fila As Integer, dur As Integer, idEmp As Integer, mx As Integer
        Dim fechaI As Date, fecI As Date, fechaF As Date, fecF As Date, fechaC As Date, fifi As Date
        Dim inc As String, tip As String, yy As String
        Dim cb As Color, cf As Color
        fecI = Lbl_Dia1.Text & "/" & Lbl_año.Text
        fecF = lbl_Dia6.Text & "/" & Lbl_año.Text
        For Each item In lstAus
            fechaI = item.FechaI
            fechaF = item.FechaF

            If (fechaF >= fecF And fechaI <= fecF) Or (fechaF <= fecF And fechaI >= fecI) Then
                tip = item.TipoAusentismo
                Select Case tip
                    Case "B", "B "
                        yy = "permisoMaternidad"
                        inc = "PM"
                        cb = Color.FromArgb(0, 102, 204)
                        cf = Color.Black
                    Case "F", "F "
                        yy = "falta"
                        inc = "F"
                        cb = Color.Red
                        cf = Color.Black
                    Case "G", "G "
                        yy = "permisoConSueldo"
                        inc = "PCS"
                        cb = Color.Yellow
                        cf = Color.Black
                    Case "P", "P "
                        yy = "permisoSinSueldo"
                        inc = "PSS"
                        cb = Color.Yellow
                        cf = Color.Red
                    Case "U", "U "
                        yy = "faltaJustificada"
                        inc = "FJ"
                        cb = Color.Red
                        cf = Color.Black
                    Case "N", "N "
                        yy = "suspension"
                        inc = "SUS"
                        cb = Color.Red
                        cf = Color.Black
                    Case Else
                        yy = ""
                        inc = "FF"
                        cb = Color.Red
                        cf = Color.Black
                End Select

                For fila = 0 To totalFilas - 1
                    idEmp = Dgv_Prenomina_Global.Rows(fila).Cells("idEmpleado").Value
                    If idEmp = item.IdEmpleado Then
                        For dur = 1 To item.Duracion
                            fifi = fecF
                            For colum = 1 To 7
                                fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                                If fechaI = fechaC Then
                                    mx = Dgv_Prenomina_Global.Rows(fila).Cells(yy).Value
                                    Dim d As String = RetornarDia(colum)
                                    Dim t As String = "TE" & colum
                                    Dim c As String = "CM" & colum
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = inc
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.BackColor = cb
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.ForeColor = cf
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "BAJA" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "F/B"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.BackColor = Color.FromArgb(51, 51, 0)
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.ForeColor = Color.Red
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.BackColor = cb
                                        Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.ForeColor = cf
                                    End If

                                    If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = inc
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = cb
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = cf
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "BAJA" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "F/B"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.FromArgb(51, 51, 0)
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.Red
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = cb
                                        Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = cf
                                    End If

                                    If Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = inc
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = cb
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = cf
                                    ElseIf Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "BAJA" Then
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "F/B"
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.FromArgb(51, 51, 0)
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.Red
                                    Else
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = cb
                                        Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = cf
                                    End If
                                    Dgv_Prenomina_Global.Rows(fila).Cells(yy).Value = mx + 1
                                    If Dgv_Prenomina_Global.Rows(fila).Cells(yy).Value <> 0 Then Dgv_Prenomina_Global.Rows(fila).Cells(yy).Style.BackColor = Color.White
                                    Exit For
                                End If
                            Next
                            fechaI = (DateAdd(DateInterval.Day, 1, fechaI))
                        Next
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub RellenaDescansoAsistencias(ByVal totalFilas As Integer, ByVal fecha As Date)
        Dim fila As Integer, colum As Integer
        For fila = 0 To totalFilas - 2
            With Dgv_Prenomina_Global.Rows(fila)
                For colum = 1 To 7
                    Dim tu = .Cells("idTurnoEmpleado").Value
                    Dim g = .Cells("grupo").Value
                    Dim fec = Format((DateAdd(DateInterval.Day, (colum - 1), fecha)), "dd/MM/yyyy")
                    Dim d As String = RetornarDia(colum)
                    Dim t As String = "TE" & colum
                    Dim c As String = "CM" & colum

                    If colum = 6 Then
                        If tu = 4 Or tu = 5 Or tu = 6 Then
                            If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "" Then
                                Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "D"
                                Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.Black
                                Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.White
                            End If
                            If Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "" Then
                                Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "D"
                                Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.BackColor = Color.Black
                                Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.ForeColor = Color.White
                            End If
                            If Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "" Then
                                Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "D"
                                Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.Black
                                Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.White
                            End If
                        Else
                            If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "" Then
                                Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "A"
                                Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.Green
                                Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.White
                            End If
                        End If
                    ElseIf colum = 7 Then
                        If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "" Then
                            Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "D"
                            Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.Black
                            Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.White
                        End If
                        If Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "" Then
                            Dgv_Prenomina_Global.Rows(fila).Cells(t).Value = "D"
                            Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.BackColor = Color.Black
                            Dgv_Prenomina_Global.Rows(fila).Cells(t).Style.ForeColor = Color.White
                        End If
                        If Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "" Then
                            Dgv_Prenomina_Global.Rows(fila).Cells(c).Value = "D"
                            Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.BackColor = Color.Black
                            Dgv_Prenomina_Global.Rows(fila).Cells(c).Style.ForeColor = Color.White
                        End If
                    Else
                        If Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "" Then
                            Dgv_Prenomina_Global.Rows(fila).Cells(d).Value = "A"
                            Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.BackColor = Color.Green
                            Dgv_Prenomina_Global.Rows(fila).Cells(d).Style.ForeColor = Color.White
                        End If
                    End If
                Next
            End With
        Next
    End Sub

    Private Sub RellenarHrsExtraDTRetLista(ByVal lstTxt As LTxtNominas)
        Dim con As New conexion()
        Dim fila As Integer = 0, dur As Integer
        Dim fechaI As Date, fechaF As Date, fecI As Date, fecF As Date
        Dim idEmp As Integer
        Dim tp As String, tip As String, inc As String
        Dim hr
        Dgv_Lista.DataSource = Nothing
        Dgv_Lista.Rows.Clear()

        Dim te = 0
        For Each item In lstTxt
            If item.Tabla = 1 Then
                Dgv_Lista.Rows.Add()
                idEmp = item.IdEmpleado
                hr = item.Autorizado
                fechaI = item.Fecha
                tp = item.Tipo

                With Dgv_Lista.Rows(fila)
                    .Cells("idEmp").Value = idEmp
                    .Cells("tiempo").Value = hr
                    .Cells("fecha").Value = fechaI

                    If tp = "H" Or tp = "H " Or tp = " H" Then
                        te = hr + te
                        .Cells("inc").Value = "HE"
                        .Cells("hrsAprobadas").Value = hr
                    ElseIf tp = "DT" Or tp = "DT " Or tp = " DT" Then
                        .Cells("inc").Value = "DT"
                    ElseIf tp = "F" Or tp = "F " Or tp = " F" Then
                        .Cells("inc").Value = "DF"
                    ElseIf tp = "R" Or tp = "R " Or tp = " R" Then
                        .Cells("inc").Value = "R"
                    ElseIf tp = "P" Or tp = "P " Or tp = " P" Then
                        .Cells("inc").Value = "R"
                    End If

                End With
                fila += 1

            ElseIf item.Tabla = 2 Then

                fecI = Lbl_Dia1.Text & "/" & Lbl_año.Text
                fecF = lbl_Dia6.Text & "/" & Lbl_año.Text

                idEmp = item.IdEmpleado
                fechaI = item.Fecha
                fechaF = item.FechaF
                dur = item.Duracion

                For f = 1 To dur
                    Dgv_Lista.Rows.Add()
                    With Dgv_Lista.Rows(fila)
                        .Cells("idEmp").Value = idEmp
                        .Cells("fecha").Value = fechaI
                        If (fechaF >= fecF And fechaI <= fecF) Or (fechaF <= fecF And fechaF >= fecI) Then
                            tip = item.Tipo
                            Select Case tip
                                Case "B", "B "
                                    inc = "PM"
                                Case "F", "F "
                                    inc = "F"
                                Case "G", "G "
                                    inc = "PCS"
                                Case "P", "P "
                                    inc = "PSS"
                                Case "U", "U "
                                    inc = "FJ"
                                Case "N", "N "
                                    inc = "SUS"
                                Case Else
                                    inc = "xx"
                            End Select
                            .Cells("inc").Value = inc
                        End If
                    End With
                    fechaI = (DateAdd(DateInterval.Day, 1, fechaI))
                    fila += 1
                Next
            End If
        Next


    End Sub
#End Region
#Region "Procesos Varios"
    Private Sub ProcesoPrenominaGlobal(ByVal lstEmp As LEmpleado, ByVal fecha As Date)
        lstEmp = RecuperarEmpleados(fecha)
        If lstEmp(0).Err = False Then
            RellenaChecadasDgvGlobalPrenomina(lstEmp)
            RecuperarIncidencias(1)
            Btn_Excel.Visible = True
            Txt_FiltroId.Enabled = True
            Btn_Txt.Visible = True
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
    Private Sub CrearArchivo()
        Me.userName = Environment.UserName
        Me.ruta = "C:\Users\" & Me.userName & "\Desktop\NominaSAAM\"
        Me.archivo = "Incidencias_W" & Cmb_Semanas.Text & ".txt"
        Dim fs As FileStream

        'Validamos si la carpeta de ruta existe, si no existe la creamos
        Try
            If File.Exists(ruta) Then

                'Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & archivo)
                fs.Close()
                MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, "")
            Else

                'Si la carpeta no existe la creamos
                Directory.CreateDirectory(ruta)

                'Una vez creada la carpeta creamos o sobreescribios el archivo txt
                fs = File.Create(ruta & archivo)
                fs.Close()
                MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, "")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try
    End Sub
    Private Sub EscribirArchivo()
        Dim tx As New StreamWriter(Me.ruta & Me.archivo)
        Dim fila As Integer, e As Integer, id As Integer, idX As Integer = 0, semana As Integer = Cmb_Semanas.Text
        Dim inc As String, texto As String, val As String
        Dim VV As Double, fgg As Double
        Dim totalFilas As Integer = Dgv_Lista.Rows.Count
        Try
            For e = 1 To 7000
                Dim V = 0, V2 = 0, H = 0, HE = 0, HE2 = 0, HE3 = 0

                For fila = 0 To totalFilas - 2
                    id = Dgv_Lista.Rows(fila).Cells("idEmp").Value
                    If id = e Then
                        With Dgv_Lista.Rows(fila)
                            If idX <> id Then
                                'Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
                                tx.Write("E       ")
                                tx.Write(String.Format("{0:0000}", id))
                                tx.Write("                                                                                           ")
                                tx.WriteLine()
                            End If

                            inc = .Cells("inc").Value
                            If inc = "HE" Or inc = "R" Or inc = "F" Or inc = "PCS" Or inc = "PSS" Or inc = "SUS" Or inc = "FJ" Then
                                Select Case inc
                                    Case "HE"
                                        V = .Cells("hrsAprobadas").Value
                                        H = V + H
                                        If V <= 540 Then
                                            If H <= 540 Then
                                                HE2 = HE2 + V
                                                VV = Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666))

                                                tx.Write("D")
                                                tx.Write(" Semanal")
                                                tx.Write("                 ")
                                                tx.Write(semana)
                                                tx.Write(" 2                   ")
                                                tx.Write("Horas extras 2                               ")
                                                tx.Write(Format(VV, "#0.00"))
                                                tx.Write(" ")
                                                tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                tx.Write(",00:0 ")
                                                tx.Write(Lbl_año.Text)
                                                tx.Write("                            ")

                                            ElseIf H >= 540 Then
                                                If HE2 >= 540 Then
                                                    HE3 = HE3 + V
                                                    tx.Write("D")
                                                    tx.Write(" Semanal")
                                                    tx.Write("                 ")
                                                    tx.Write(semana)
                                                    tx.Write(" 2                   ")
                                                    tx.Write("Horas extras 3                              ")
                                                    If (Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666))) < 10 Then
                                                        tx.Write(" ")
                                                    End If
                                                    tx.Write(Format((Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666))), "#0.00"))
                                                    tx.Write(" ")
                                                    tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    tx.Write(",00:0 ")
                                                    tx.Write(Lbl_año.Text)
                                                    tx.Write("                            ")
                                                Else
                                                    V2 = 540 - HE2
                                                    HE3 = H - 540
                                                    HE2 = 540

                                                    tx.Write("D")
                                                    tx.Write(" Semanal")
                                                    tx.Write("                 ")
                                                    tx.Write(semana)
                                                    tx.Write(" 2                   ")
                                                    tx.Write("Horas extras 2                               ")
                                                    tx.Write(Format((Int(V2 / 60) + (((V2 / 60 - Int(V2 / 60)) / 1.666))), "#0.00"))
                                                    tx.Write(" ")
                                                    tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    tx.Write(",00:0 ")
                                                    tx.Write(Lbl_año.Text)
                                                    tx.Write("                            ")
                                                    '--------------------------------------
                                                    tx.WriteLine()
                                                    tx.Write("D")
                                                    tx.Write(" Semanal")
                                                    tx.Write("                 ")
                                                    tx.Write(semana)
                                                    tx.Write(" 2                   ")
                                                    tx.Write("Horas extras 3                              ")
                                                    If (Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666))) < 10 Then
                                                        tx.Write(" ")
                                                    End If
                                                    tx.Write(Format((Int(HE3 / 60) + (((HE3 / 60 - Int(HE3 / 60)) / 1.666))), "#0.00"))
                                                    tx.Write(" ")
                                                    tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    tx.Write(",00:0 ")
                                                    tx.Write(Lbl_año.Text)
                                                    tx.Write("                            ")
                                                End If
                                            End If
                                        Else
                                            V2 = 540 - HE2
                                            HE3 = H - 540
                                            HE2 = 540
                                            If V2 > 0 Then
                                                tx.Write("D")
                                                tx.Write(" Semanal")
                                                tx.Write("                 ")
                                                tx.Write(semana)
                                                tx.Write(" 2                   ")
                                                tx.Write("Horas extras 2                               ")
                                                tx.Write(Format((Int(V2 / 60) + (((V2 / 60 - Int(V2 / 60)) / 1.666))), "#0.00"))
                                                tx.Write(" ")
                                                tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                tx.Write(",00:0 ")
                                                tx.Write(Lbl_año.Text)
                                                tx.Write("                            ")
                                                tx.WriteLine()
                                            End If
                                            tx.Write("D")
                                            tx.Write(" Semanal")
                                            tx.Write("                 ")
                                            tx.Write(semana)
                                            tx.Write(" 2                   ")
                                            fgg = (Int(HE3 / 60) + (((HE3 / 60 - Int(HE3 / 60)) / 1.666)))
                                            If fgg >= 10 Then
                                                tx.Write("Horas extras 3                              ")
                                            Else
                                                tx.Write("Horas extras 3                               ")
                                            End If
                                            tx.Write(Format(fgg, "#0.00"))
                                            tx.Write(" ")
                                            tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                            tx.Write(",00:0 ")
                                            tx.Write(Lbl_año.Text)
                                            tx.Write("                            ")
                                        End If
                                    Case "R"
                                        tx.Write("D")
                                        tx.Write(" Semanal")
                                        tx.Write("                 ")
                                        tx.Write(semana)
                                        tx.Write(" 2                   ")
                                        texto = "Retardos                                     "
                                        val = .Cells("tiempo").Value
                                        tx.Write(texto)
                                        tx.Write(Format((Int(val / 60) + (((val / 60 - Int(val / 60)) / 1.666))), "#0.00"))
                                        tx.Write(" ")
                                        tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                        tx.Write(",00:0 ")
                                        tx.Write(Lbl_año.Text)
                                        tx.Write("                            ")
                                    Case "F", "FJ"
                                        tx.Write("D")
                                        tx.Write(" Semanal")
                                        tx.Write("                 ")
                                        tx.Write(semana)
                                        tx.Write(" 2                   ")
                                        texto = "Faltas injustificadas                        "
                                        val = 1
                                        tx.Write(texto)
                                        tx.Write(val & ".00")
                                        tx.Write(" ")
                                        tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                        tx.Write(",00:0 ")
                                        tx.Write(Lbl_año.Text)
                                        tx.Write("                            ")
                                    Case "PCS"
                                        tx.Write("D")
                                        tx.Write(" Semanal")
                                        tx.Write("                 ")
                                        tx.Write(semana)
                                        tx.Write(" 2                   ")
                                        texto = "Permisos con goce de sueldo                  "
                                        val = 1
                                        tx.Write(texto)
                                        tx.Write("1.00")
                                        tx.Write(" ")
                                        tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                        tx.Write(",00:0 ")
                                        tx.Write(Lbl_año.Text)
                                        tx.Write("                            ")
                                    Case "PSS"
                                        tx.Write("D")
                                        tx.Write(" Semanal")
                                        tx.Write("                 ")
                                        tx.Write(semana)
                                        tx.Write(" 2                   ")
                                        texto = "Permisos sin goce de sueldo                  "
                                        val = 1
                                        tx.Write(texto)
                                        tx.Write("1.00")
                                        tx.Write(" ")
                                        tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                        tx.Write(",00:0 ")
                                        tx.Write(Lbl_año.Text)
                                        tx.Write("                            ")
                                    Case "SUS"
                                        tx.Write("D")
                                        tx.Write(" Semanal")
                                        tx.Write("                 ")
                                        tx.Write(semana)
                                        tx.Write(" 2                   ")
                                        texto = "Días de castigo                              "
                                        val = 1
                                        tx.Write(texto)
                                        tx.Write("1.00")
                                        tx.Write(" ")
                                        tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                        tx.Write(",00:0 ")
                                        tx.Write(Lbl_año.Text)
                                        tx.Write("                            ")
                                End Select
                                tx.WriteLine()
                            End If
                        End With
                    End If
                    idX = id
                Next
            Next
            MsgBox("Registro guardado correctamente", MsgBoxStyle.Information, "")
            tx.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try
    End Sub
    Sub LeerArchivo()
        ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
        Dim leer As New StreamReader(ruta & archivo)

        ':::Limpiamos nuestro ListBox
        'ListBoxClientes.Items.Clear()

        Try
            ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
            While leer.Peek <> -1
                ':::Leemos cada linea del archivo TXT
                Dim linea As String = leer.ReadLine()
                ':::Validamos que la linea no este vacia
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                ':::Agregramos los registros encontrados
                'ListBoxClientes.Items.Add(linea)
            End While

            leer.Close()
            ':::Total de registros cargados al ListBox
            'LblTotal.Text = ListBoxClientes.Items.Count
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub
    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try

            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            For i As Integer = 1 To NCol
                If ElGrid.Columns(i - 1).Visible = True Then
                    exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText.ToString
                End If
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next

            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
#End Region
End Class