Imports System.Data.SqlClient
Imports Negocio
Imports Clases
Imports System.IO
Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms
Public Class Frm_GlobalPrenomina
#Region "Variables de clase"
    Dim cadConex As SqlConnection
    Dim conex As New conexion
    Dim cadenaConex As String
    Dim open As Boolean
    Dim userName As String
    Dim ruta As String
    Dim archivo As String
    Dim fuente As New ReportDataSource
    Dim emp As New Empleado
    Dim ip As String = Strings.Left(Me.conex.getIp(), 6)
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
    Sub New(ByVal cadConex As SqlConnection, ByVal cadenaConex As String, ByVal emp As Empleado)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadConex = cadConex
        Me.cadenaConex = cadenaConex
        Me.emp = emp
    End Sub
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_GlobalPrenomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_año.Text = Format(DateTime.Now, "yyyy")
        Dim lst As New LIncidencias(), NPre As New NPrenomina(), conex As New conexion()
        Dim cadenaConex As String = conex.conexionCont
        RellenaCmbSemanas()
        ModificarDiaInicio()
    End Sub
    Private Sub Dtp_FechaInicioSemana_TextChanged(sender As Object, e As EventArgs) Handles Dtp_FechaInicioSemana.TextChanged
        If Dtp_FechaInicioSemana.Value < DateTime.Now Or Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyy") = Format(DateTime.Now, "dd/MM/yyy") Then

            Dim conex As New conexion
            Dim cadenaConexContpaq  'Conexion a la BD de contpaq solo se va a usar para traer las fechas que corresponden la semana que se manda
            Dim cadenaConex As String
            Dim fechaI As Date = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            Dim NPre As New NPrenomina(), lst As New LIncidencias(), hrs As New Horarios()
            Dim sem As Integer
            Dim type As String

            If Me.ip = "172.16" Then
                cadenaConexContpaq = conex.conexionContpaq 'Conexion a la BD de contpaq solo se va a usar para traer las fechas que corresponden la semana que se manda
                cadenaConex = conex.conexionCont
            Else
                cadenaConexContpaq = conex.conexionContpaqFor 'Conexion a la BD de contpaq solo se va a usar para traer las fechas que corresponden la semana que se manda
                cadenaConex = conex.conexionContFor
            End If

            Lbl_año.Text = Format(fechaI, "yyyy")
            'nWeek = CInt(DatePart(DateInterval.WeekOfYear, fechaI, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)) + 1 'En base a la fecha seleccionada se pone el numero de semana

            hrs = NPre.RecuperarDiasSemana(cadenaConexContpaq, fechaI)

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
            Btn_Incidencias.Visible = False
            Btn_PDO.Visible = False
            Btn_Excel.Visible = False
            Btn_Reporte.Visible = False
            Txt_FiltroId.Enabled = False
            Txt_FiltroId.Text = ""
            Lbl_Inc.Visible = False
            Lbl_PDO.Visible = False
            Dgv_Prenomina_Global.DataSource = Nothing
            Dgv_Prenomina_Global.Refresh()
            open = True

            lst = NPre.VerificarBitacora(cadenaConex, Cmb_Semanas.Text, Lbl_año.Text)
            If lst.Count > 0 Then
                For Each item In lst
                    If item.Tipo = 1 Then
                        'Btn_Incidencias.Enabled = False
                        If lst.Count = 1 Then Btn_PDO.Enabled = True
                    ElseIf item.Tipo = 2 Then
                        Btn_PDO.Enabled = False
                        If lst.Count = 1 Then Btn_Incidencias.Enabled = True
                    End If
                Next
            Else
                Btn_Incidencias.Enabled = True
                Btn_PDO.Enabled = True
            End If
        Else
            Dim conex As New conexion
            Dim cadenaConex As String  'Conexion a la BD de contpaq solo se va a usar para traer las fechas que corresponden la semana que se manda
            Dim NPre As New NPrenomina(), lst As New LIncidencias()

            If Me.ip = "172.16" Then
                cadenaConex = conex.conexionCont
            Else
                cadenaConex = conex.conexionContFor
            End If

            Dgv_Prenomina_Global.Enabled = False
            MsgBox("Tienes que ingresar una fecha menor a la actual")
            ModificarDiaInicio()
            Dgv_Prenomina_Global.DataSource = Nothing
            Dgv_Prenomina_Global.Refresh()

            lst = NPre.VerificarBitacora(cadenaConex, Cmb_Semanas.Text, Lbl_año.Text)
            If lst.Count > 0 Then
                For Each item In lst
                    If item.Tipo = 1 Then
                        Btn_Incidencias.Enabled = False
                        If lst.Count = 1 Then Btn_PDO.Enabled = True
                    ElseIf item.Tipo = 2 Then
                        Btn_PDO.Enabled = False
                        If lst.Count = 1 Then Btn_Incidencias.Enabled = True
                    End If
                Next
            Else
                Btn_Incidencias.Enabled = True
                Btn_PDO.Enabled = True
            End If
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
    Private Sub Btn_Incidencias_Click(sender As Object, e As EventArgs) Handles Btn_Incidencias.Click
        'Dgv_Lista.Visible = True
        Dim res As Integer
        res = MsgBox("¿Está Seguro que desea registrar las incidencias?.", vbYesNo + vbExclamation + vbDefaultButton2, "¡Se van a registrar las incidencias!")

        If res = vbYes Then
            ProcesoInsertaIncidenciasNomina()
            Btn_Incidencias.Enabled = False
        End If
        'CrearArchivo()
        'EscribirArchivo()
        'LeerArchivo()
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
    Private Sub Btn_Reporte_Click(sender As Object, e As EventArgs) Handles Btn_Reporte.Click
        Almacenar()
        llamarReporte()
    End Sub
    Private Sub Btn_PDO_Click(sender As Object, e As EventArgs) Handles Btn_PDO.Click
        'CrearTxtPDO()
        'EscribirArchivoPDO()
        Dim res As Integer
        res = MsgBox("¿Está Seguro que desea registrar el bono?.", vbYesNo + vbExclamation + vbDefaultButton2, "¡Se va a registrar el bono!")

        If res = vbYes Then
            ProcesoInsertaBonoNomina()
            Btn_PDO.Enabled = False
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
        Dim cadConex As String 'Conexion a la BD de asahi16 de la instancia sql2008

        If Me.ip = "172.16" Then
            cadConex = conex.conexion2008
        Else
            cadConex = conex.conexion2008For
        End If

        Dim semana As Integer = Cmb_Semanas.Text, año As Integer = Lbl_año.Text

        Return NPre.EmpleadoGlobalRecuperar(cadConex, fecha, semana, año)
    End Function
    Private Sub RecuperarIncidencias(ByVal dgv As Boolean)
        Dim lstAus As New LAusentismo(), lstVac As New LVacaciones(), lstInc As New LIncapacidad(), lstHE As New LHorasExtra(), lstBja As New LBaja(),
            lstCom As New LComedor(), lstTxt As New LTxtNominas()
        Dim NPre As New NPrenomina()
        Dim fechaI As Date
        Dim fechaF As Date
        Dim conex As New conexion
        Dim cadConex As String

        If Me.ip = "172.16" Then
            cadConex = conex.conexion2008
        Else
            cadConex = conex.conexion2008For
        End If

        fechaI = Lbl_SemaI.Text '(Lbl_Dia1.Text & "/" & Lbl_año.Text)
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
            If item.Bono = True Then
                Dgv_Prenomina_Global.Rows(fila).Cells("bono").Value = "SI"
                Dgv_Prenomina_Global.Rows(fila).Cells("bono").Style.BackColor = Color.White
            ElseIf item.Bono = False Then
                Dgv_Prenomina_Global.Rows(fila).Cells("bono").Value = "NO"
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
                .Cells("homeOffice").Value = 0
                .Cells("empleadoVulnerable").Value = 0
                .Cells("consultaSospecha").Value = 0
                .Cells("sospechaEnfermedad").Value = 0
                .Cells("confirmado").Value = 0
                .Cells("permisoMaternidad").Value = 0
                .Cells("incapacidad").Value = 0
                .Cells("vacaciones").Value = 0
                .Cells("shutdown").Value = 0
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
        Dim fecha As Date = Format((Lbl_SemaI.Text)) 'Format((Lbl_Dia1.Text + "/" + Lbl_año.Text))
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
                    Case "H"
                        yy = "homeOffice"
                        inc = "HO"
                        cb = Color.GreenYellow
                        cf = Color.Navy
                    Case "D"
                        yy = "empleadoVulnerable"
                        inc = "VUL"
                        cb = Color.GreenYellow
                        cf = Color.Black
                    Case "K"
                        yy = "consultaSospecha"
                        inc = "CC"
                        cb = Color.GreenYellow
                        cf = Color.OrangeRed
                    Case "O"
                        yy = "sospechaEnfermedad"
                        inc = "SO"
                        cb = Color.GreenYellow
                        cf = Color.OrangeRed
                    Case "J"
                        yy = "confirmado"
                        inc = "CF"
                        cb = Color.GreenYellow
                        cf = Color.Red
                    Case "Z", "Z "
                        yy = "shutdown"
                        inc = "SHU"
                        cb = Color.Yellow
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

                    If colum = 5 Then
                        If tu = 7 Or tu = 8 Then
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

                    ElseIf colum = 6 Then
                        If tu = 7 Or tu = 8 Or tu = 10 Then
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
                        If tu = 7 Or tu = 8 Or tu = 10 Then
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
        Dim fila As Integer = 0, dur As Integer
        Dim fechaI As Date, fechaF As Date, fecI As Date, fecF As Date
        Dim idEmp As Integer, idExt As Integer
        Dim tp As String, tip As String, inc As String
        Dim hr
        Dgv_Lista.DataSource = Nothing
        Dgv_Lista.Rows.Clear()

        Dim te = 0
        For Each item In lstTxt
            If item.Tabla = 1 Then
                Dgv_Lista.Rows.Add()
                idEmp = item.IdEmpleado
                idExt = item.IdExt
                hr = item.Autorizado
                fechaI = item.Fecha
                tp = item.Tipo

                With Dgv_Lista.Rows(fila)
                    .Cells("idEmp").Value = idEmp
                    .Cells("idExt").Value = idExt
                    .Cells("tiempo").Value = hr
                    .Cells("fecha").Value = fechaI
                    .Cells("turno").Value = item.Turno

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
                idExt = item.IdExt
                fechaI = item.Fecha
                fechaF = item.FechaF
                dur = item.Duracion

                For f = 1 To dur
                    Dgv_Lista.Rows.Add()
                    With Dgv_Lista.Rows(fila)
                        .Cells("idEmp").Value = idEmp
                        .Cells("idExt").Value = idExt
                        .Cells("fecha").Value = fechaI
                        .Cells("turno").Value = item.Turno
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
                                'Case "H", "H "
                                '    inc = "HO"
                                Case "D", "D "
                                    inc = "PCV"
                                Case "K", "K "
                                    inc = "PCV"
                                Case "O", "O "
                                    inc = "PCV"
                                Case "J", "J "
                                    inc = "PCV"
                                Case "Z", "Z "
                                    inc = "SHU"
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
#Region "Rellena Objetos"
    Private Function RellenaObjetoBono() As LBono
        Dim lstBono As New LBono()
        Dim fila As Integer, totalFilas As Integer = Dgv_Prenomina_Global.Rows.Count()
        For fila = 0 To totalFilas - 2
            Dim objBono As New Bono()
            With Dgv_Prenomina_Global.Rows(fila)
                Dim ab As Object = .Cells("bono").Value
                objBono.IdEmpleado = .Cells("idEmpleado").Value
                objBono.Semana = Cmb_Semanas.Text
                objBono.Año = Lbl_año.Text
                If ab = "SI" Then
                    objBono.ImporteBono = "219.00"
                ElseIf ab = "NO" Then
                    objBono.ImporteBono = "0.00"
                End If
                lstBono.Add(objBono)
            End With
        Next
        Return lstBono
    End Function
    Private Function RellenaObjetoIncidencias() As LIncidencias
        Dim lstInc As New LIncidencias(), NPre As New NPrenomina(), conex As New conexion()
        Dim cadenaConex As String
        Dim fila As Integer, e As Integer, id As Integer, idX As Integer = 0, sema As Integer = Cmb_Semanas.Text
        Dim inc As String, val As String
        Dim VV As Double, VV3 As Double, HH As Double
        Dim totalFilas As Integer = Dgv_Lista.Rows.Count

        If Me.ip = "172.16" Then
            cadenaConex = conex.conexionCont
        Else
            cadenaConex = conex.conexionContFor
        End If

        Try
            For e = 1 To 7000
                Dim V = 0, V2 = 0, H = 0, H2 = 0, H3 = 0, HE = 0, HS = 0, turno, dia
                'Dim objInci As New Incidencias
                For fila = 0 To totalFilas - 2
                    Dim objInci As New Incidencias
                    id = Dgv_Lista.Rows(fila).Cells("idEmp").Value
                    If id = e Then
                        With Dgv_Lista.Rows(fila)
                            If .Cells("fecha").Value >= "01/07/2021" Then
                                objInci.IdEmpleado = id
                                objInci.Semana = sema
                                objInci.Año = Lbl_año.Text
                                inc = .Cells("inc").Value

                                If inc = "HE" Or inc = "R" Or inc = "F" Or inc = "PCS" Or inc = "PSS" Or inc = "SUS" Or inc = "FJ" Or inc = "DF" Or inc = "DT" Or inc = "PCV" Or inc = "SHU" Then
                                    Select Case inc
                                        Case "HE"
                                            V = .Cells("hrsAprobadas").Value
                                            dia = Convert.ToDateTime(.Cells("fecha").Value).DayOfWeek
                                            turno = .Cells("turno").Value
                                            If dia > 0 And dia < 5 Or (dia = 5 And turno = 10) Then
                                                If V > 180 Then
                                                    H2 = 180
                                                    H3 = V - 180
                                                    If (H + H2) > 540 Then
                                                        If H >= 540 Then
                                                            VV = Format(Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666)), "0.00")

                                                            objInci.Incidencia = 3
                                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                            objInci.Valor = VV
                                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                        ElseIf H < 540 Then
                                                            HH = 540 - H
                                                            HS = H2 - HH
                                                            H3 = H3 + HS
                                                            H2 = HH
                                                            VV = Format(Int(H2 / 60) + (((H2 / 60 - Int(H2 / 60)) / 1.666)), "0.00")
                                                            VV3 = Format(Int(H3 / 60) + (((H3 / 60 - Int(H3 / 60)) / 1.666)), "0.00")
                                                            Dim objInci2 As New Incidencias

                                                            objInci2.IdEmpleado = id
                                                            objInci2.Semana = sema
                                                            objInci2.Año = Lbl_año.Text
                                                            objInci2.Incidencia = 2
                                                            objInci2.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                            objInci2.Valor = VV
                                                            objInci2.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                            lstInc.Add(objInci2)

                                                            objInci.Incidencia = 3
                                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                            objInci.Valor = VV3
                                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                        End If
                                                    ElseIf (H + H2) <= 540 Then
                                                        VV = Format(Int(H2 / 60) + (((H2 / 60 - Int(H2 / 60)) / 1.666)), "0.00")
                                                        VV3 = Format(Int(H3 / 60) + (((H3 / 60 - Int(H3 / 60)) / 1.666)), "0.00")
                                                        Dim objInci2 As New Incidencias

                                                        objInci2.IdEmpleado = id
                                                        objInci2.Semana = sema
                                                        objInci2.Año = Lbl_año.Text
                                                        objInci2.Incidencia = 2
                                                        objInci2.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                        objInci2.Valor = VV
                                                        objInci2.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                        lstInc.Add(objInci2)

                                                        objInci.Incidencia = 3
                                                        objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                        objInci.Valor = VV3
                                                        objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                    End If
                                                ElseIf V <= 180 Then
                                                    H2 = V
                                                    If (H + H2) > 540 Then
                                                        If H >= 540 Then
                                                            VV = Format(Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666)), "0.00")

                                                            objInci.Incidencia = 3
                                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                            objInci.Valor = VV
                                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                        ElseIf H < 540 Then
                                                            HH = 540 - H
                                                            H2 = HH
                                                            H3 = V - HH
                                                            VV = Format(Int(H2 / 60) + (((H2 / 60 - Int(H2 / 60)) / 1.666)), "0.00")
                                                            VV3 = Format(Int(H3 / 60) + (((H3 / 60 - Int(H3 / 60)) / 1.666)), "0.00")
                                                            Dim objInci2 As New Incidencias

                                                            objInci2.IdEmpleado = id
                                                            objInci2.Semana = sema
                                                            objInci2.Año = Lbl_año.Text
                                                            objInci2.Incidencia = 2
                                                            objInci2.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                            objInci2.Valor = VV
                                                            objInci2.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                            lstInc.Add(objInci2)

                                                            objInci.Incidencia = 3
                                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                            objInci.Valor = VV3
                                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                        End If
                                                    ElseIf (H + H2) <= 540 Then
                                                        VV = Format(Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666)), "0.00")

                                                        objInci.Incidencia = 2
                                                        objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                        objInci.Valor = VV
                                                        objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                    End If
                                                End If
                                                H = H2 + H
                                            ElseIf dia >= 6 Or dia = 0 Or (dia = 5 And turno < 10) Then
                                                ' If dia = 6 And turno = 10 Then
                                                '   If V > 540 Then
                                                If H >= 540 Then
                                                    H3 = V

                                                    VV3 = Format(Int(H3 / 60) + (((H3 / 60 - Int(H3 / 60)) / 1.666)), "0.00")
                                                    Dim objInci2 As New Incidencias

                                                    objInci.Incidencia = 3
                                                    objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                    objInci.Valor = VV3
                                                    objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                ElseIf (H + V) <= 540 Then

                                                    H2 = V

                                                    VV = Format(Int(H2 / 60) + (((H2 / 60 - Int(H2 / 60)) / 1.666)), "0.00")
                                                    ' VV3 = Format(Int(H3 / 60) + (((H3 / 60 - Int(H3 / 60)) / 1.666)), "0.00")
                                                    '  Dim objInci2 As New Incidencias

                                                    'objInci2.IdEmpleado = id
                                                    'objInci2.Semana = sema
                                                    'objInci2.Año = Lbl_año.Text
                                                    objInci.Incidencia = 2
                                                    objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                    objInci.Valor = VV
                                                    objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                    'lstInc.Add(objInci2)

                                                    'objInci.Incidencia = 3
                                                    'objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                    'objInci.Valor = VV3
                                                    'objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")

                                                ElseIf (H + V) > 540 Then
                                                    HH = 540 - H
                                                    HS = V - HH
                                                    H3 = HS
                                                    H2 = HH
                                                    VV = Format(Int(H2 / 60) + (((H2 / 60 - Int(H2 / 60)) / 1.666)), "0.00")
                                                    VV3 = Format(Int(H3 / 60) + (((H3 / 60 - Int(H3 / 60)) / 1.666)), "0.00")
                                                    Dim objInci2 As New Incidencias

                                                    objInci2.IdEmpleado = id
                                                    objInci2.Semana = sema
                                                    objInci2.Año = Lbl_año.Text
                                                    objInci2.Incidencia = 2
                                                    objInci2.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                    objInci2.Valor = VV
                                                    objInci2.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                    lstInc.Add(objInci2)

                                                    objInci.Incidencia = 3
                                                    objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                    objInci.Valor = VV3
                                                    objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                                End If


                                            ElseIf dia = 0 Then
                                                VV = Format(Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666)), "0.00")

                                                objInci.Incidencia = 2
                                                objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                                objInci.Valor = VV
                                                objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                            End If
                                           ' End If
#Region "Coment"
                                            'If V <= 540 Then
                                            '    If H <= 540 Then
                                            '        HE2 = HE2 + V
                                            '        VV = Format(Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666)), "0.00")

                                            '        objInci.Incidencia = 2
                                            '        objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            '        objInci.Valor = VV
                                            '        objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")

                                            '    ElseIf H >= 540 Then
                                            '        If HE2 >= 540 Then
                                            '            HE3 = HE3 + V
                                            '            Dim V3 = Format((Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666))), "0.00")

                                            '            objInci.Incidencia = 3
                                            '            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            '            objInci.Valor = V3
                                            '            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                            '        Else
                                            '            V2 = 540 - HE2
                                            '            HE3 = H - 540
                                            '            HE2 = 540
                                            '            Dim vh2 = Format((Int(V2 / 60) + (((V2 / 60 - Int(V2 / 60)) / 1.666))), "0.00")
                                            '            Dim vh3 = Format((Int(HE3 / 60) + (((HE3 / 60 - Int(HE3 / 60)) / 1.666))), "0.00")
                                            '            Dim objInci2 As New Incidencias
                                            '            objInci2.IdEmpleado = id
                                            '            objInci2.Semana = sema
                                            '            objInci2.Año = Lbl_año.Text
                                            '            objInci2.Incidencia = 2
                                            '            objInci2.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            '            objInci2.Valor = vh2
                                            '            objInci2.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                            '            lstInc.Add(objInci2)
                                            '            '--------------------------------------
                                            '            objInci.Incidencia = 3
                                            '            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            '            objInci.Valor = vh3
                                            '            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                            '        End If
                                            '    End If
                                            'Else
                                            '    V2 = 540 - HE2
                                            '    HE3 = H - 540
                                            '    HE2 = 540
                                            '    Dim vh2 = Format((Int(V2 / 60) + (((V2 / 60 - Int(V2 / 60)) / 1.666))), "0.00")
                                            '    Dim vh3 = Format((Int(HE3 / 60) + (((HE3 / 60 - Int(HE3 / 60)) / 1.666))), "0.00")
                                            '    If V2 > 0 Then
                                            '        Dim objInci2 As New Incidencias
                                            '        objInci2.IdEmpleado = id
                                            '        objInci2.Semana = sema
                                            '        objInci2.Año = Lbl_año.Text
                                            '        objInci2.Incidencia = 2
                                            '        objInci2.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            '        objInci2.Valor = vh2
                                            '        objInci2.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                            '        lstInc.Add(objInci2)
                                            '    End If
                                            '    objInci.Incidencia = 3
                                            '    objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            '    objInci.Valor = vh3
                                            '    objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                            'End If
#End Region
                                        Case "R"
                                            val = .Cells("tiempo").Value
                                            Dim Vr = Format((Int(val / 60) + (((val / 60 - Int(val / 60)) / 1.666))), "0.00")
                                            objInci.Incidencia = 17
                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy") '27/0
                                            objInci.Valor = Vr
                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                        Case "F", "FJ"
                                            val = 1
                                            objInci.Incidencia = 15
                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            objInci.Valor = val
                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                        Case "PCS"
                                            val = 1
                                            objInci.Incidencia = 7
                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            objInci.Valor = val
                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                        Case "PSS"
                                            val = 1
                                            objInci.Incidencia = 8
                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            objInci.Valor = val
                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                        Case "SUS"
                                            val = 1
                                            objInci.Incidencia = 16
                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            objInci.Valor = val
                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                        Case "DF", "DT"
                                            val = 1
                                            objInci.Incidencia = 19
                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            objInci.Valor = val
                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                        Case "PCV"
                                            val = 1
                                            objInci.Incidencia = 22
                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            objInci.Valor = val
                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                        Case "SHU"
                                            val = 1
                                            objInci.Incidencia = 27
                                            objInci.FechaInc = Format(.Cells("fecha").Value, "dd/MM/yyyy")
                                            objInci.Valor = val
                                            objInci.FechaActual = Format(Date.Now, "dd/MM/yyyy HH:mm:ss")
                                    End Select
                                    lstInc.Add(objInci)
                                End If
                            End If
                        End With
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return lstInc
    End Function
#End Region
#Region "Procesos Varios"
    Private Sub ProcesoPrenominaGlobal(ByVal lstEmp As LEmpleado, ByVal fecha As Date)
        lstEmp = RecuperarEmpleados(fecha)
        If lstEmp(0).Err = False Then
            RellenaChecadasDgvGlobalPrenomina(lstEmp)
            RecuperarIncidencias(1)
            Btn_Excel.Visible = True
            Txt_FiltroId.Enabled = True
            Btn_Incidencias.Visible = True
            Btn_PDO.Visible = True
            Btn_Reporte.Visible = True
            Lbl_Inc.Visible = True
            Lbl_PDO.Visible = True
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
        Dim VV As Double, fgg As Double, VV3 As Double, HH As Double
        Dim totalFilas As Integer = Dgv_Lista.Rows.Count
        Try
            For e = 1 To 7000
                Dim V = 0, V2 = 0, V3 = 0, H = 0, H2 = 0, H3 = 0, HE = 0, HS = 0, turno, dia

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
                            'If id = 135 Then
                            '    MsgBox("Aquí es")
                            'End If
                            inc = .Cells("inc").Value
                            If inc = "HE" Or inc = "R" Or inc = "F" Or inc = "PCS" Or inc = "PSS" Or inc = "SUS" Or inc = "FJ" Or inc = "DF" Or inc = "SHU" Then
                                Select Case inc
                                    Case "HE"
                                        V = .Cells("hrsAprobadas").Value
                                        dia = Convert.ToDateTime(.Cells("fecha").Value).DayOfWeek
                                        turno = .Cells("turno").Value
                                        If dia <> 6 And dia <> 0 Or (dia = 6 And turno <> 4) Then
                                            If V > 180 Then
                                                H2 = 180
                                                H3 = V - 180
                                                If (H + H2) > 540 Then
                                                    If H >= 540 Then
                                                        VV = Format(Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666)), "0.00")

                                                        tx.Write("D")
                                                        tx.Write(" Semanal")
                                                        tx.Write("                 ")
                                                        tx.Write(String.Format("{0:00}", semana))
                                                        tx.Write(" 2                   ")
                                                        tx.Write("Horas extras 3                               ")
                                                        tx.Write(Format(VV, "#0.00"))
                                                        tx.Write(" ")
                                                        tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                        tx.Write(",00:0 ")
                                                        tx.Write(Lbl_año.Text)
                                                        tx.Write("                            ")
                                                    ElseIf H < 540 Then
                                                        HH = 540 - H
                                                        HS = H2 - HH
                                                        H3 = H3 + HS
                                                        H2 = HH
                                                        VV = Format(Int(H2 / 60) + (((H2 / 60 - Int(H2 / 60)) / 1.666)), "0.00")
                                                        VV3 = Format(Int(H3 / 60) + (((H3 / 60 - Int(H3 / 60)) / 1.666)), "0.00")

                                                        tx.Write("D")
                                                        tx.Write(" Semanal")
                                                        tx.Write("                 ")
                                                        tx.Write(String.Format("{0:00}", semana))
                                                        tx.Write(" 2                   ")
                                                        tx.Write("Horas extras 2                               ")
                                                        tx.Write(Format(VV, "#0.00"))
                                                        tx.Write(" ")
                                                        tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                        tx.Write(",00:0 ")
                                                        tx.Write(Lbl_año.Text)
                                                        tx.Write("                            ")
                                                        tx.WriteLine()

                                                        tx.Write("D")
                                                        tx.Write(" Semanal")
                                                        tx.Write("                 ")
                                                        tx.Write(String.Format("{0:00}", semana))
                                                        tx.Write(" 2                   ")
                                                        tx.Write("Horas extras 3                               ")
                                                        tx.Write(Format(VV3, "#0.00"))
                                                        tx.Write(" ")
                                                        tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                        tx.Write(",00:0 ")
                                                        tx.Write(Lbl_año.Text)
                                                        tx.Write("                            ")
                                                    End If
                                                ElseIf (H + H2) <= 540 Then
                                                    VV = Format(Int(H2 / 60) + (((H2 / 60 - Int(H2 / 60)) / 1.666)), "0.00")
                                                    VV3 = Format(Int(H3 / 60) + (((H3 / 60 - Int(H3 / 60)) / 1.666)), "0.00")

                                                    tx.Write("D")
                                                    tx.Write(" Semanal")
                                                    tx.Write("                 ")
                                                    tx.Write(String.Format("{0:00}", semana))
                                                    tx.Write(" 2                   ")
                                                    tx.Write("Horas extras 2                               ")
                                                    tx.Write(Format(VV, "#0.00"))
                                                    tx.Write(" ")
                                                    tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    tx.Write(",00:0 ")
                                                    tx.Write(Lbl_año.Text)
                                                    tx.Write("                            ")
                                                    tx.WriteLine()

                                                    tx.Write("D")
                                                    tx.Write(" Semanal")
                                                    tx.Write("                 ")
                                                    tx.Write(String.Format("{0:00}", semana))
                                                    tx.Write(" 2                   ")
                                                    tx.Write("Horas extras 3                               ")
                                                    tx.Write(Format(VV3, "#0.00"))
                                                    tx.Write(" ")
                                                    tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    tx.Write(",00:0 ")
                                                    tx.Write(Lbl_año.Text)
                                                    tx.Write("                            ")
                                                End If
                                            ElseIf V <= 180 Then
                                                H2 = V
                                                If (H + H2) > 540 Then
                                                    If H >= 540 Then
                                                        VV = Format(Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666)), "0.00")

                                                        tx.Write("D")
                                                        tx.Write(" Semanal")
                                                        tx.Write("                 ")
                                                        tx.Write(String.Format("{0:00}", semana))
                                                        tx.Write(" 2                   ")
                                                        tx.Write("Horas extras 3                               ")
                                                        tx.Write(Format(VV, "#0.00"))
                                                        tx.Write(" ")
                                                        tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                        tx.Write(",00:0 ")
                                                        tx.Write(Lbl_año.Text)
                                                        tx.Write("                            ")
                                                    ElseIf H < 540 Then
                                                        HH = 540 - H
                                                        H2 = HH
                                                        H3 = V - HH
                                                        VV = Format(Int(H2 / 60) + (((H2 / 60 - Int(H2 / 60)) / 1.666)), "0.00")
                                                        VV3 = Format(Int(H3 / 60) + (((H3 / 60 - Int(H3 / 60)) / 1.666)), "0.00")

                                                        tx.Write("D")
                                                        tx.Write(" Semanal")
                                                        tx.Write("                 ")
                                                        tx.Write(String.Format("{0:00}", semana))
                                                        tx.Write(" 2                   ")
                                                        tx.Write("Horas extras 2                               ")
                                                        tx.Write(Format(VV, "#0.00"))
                                                        tx.Write(" ")
                                                        tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                        tx.Write(",00:0 ")
                                                        tx.Write(Lbl_año.Text)
                                                        tx.Write("                            ")
                                                        tx.WriteLine()

                                                        tx.Write("D")
                                                        tx.Write(" Semanal")
                                                        tx.Write("                 ")
                                                        tx.Write(String.Format("{0:00}", semana))
                                                        tx.Write(" 2                   ")
                                                        tx.Write("Horas extras 3                               ")
                                                        tx.Write(Format(VV3, "#0.00"))
                                                        tx.Write(" ")
                                                        tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                        tx.Write(",00:0 ")
                                                        tx.Write(Lbl_año.Text)
                                                        tx.Write("                            ")
                                                    End If
                                                ElseIf (H + H2) <= 540 Then
                                                    VV = Format(Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666)), "0.00")

                                                    tx.Write("D")
                                                    tx.Write(" Semanal")
                                                    tx.Write("                 ")
                                                    tx.Write(String.Format("{0:00}", semana))
                                                    tx.Write(" 2                   ")
                                                    tx.Write("Horas extras 2                               ")
                                                    tx.Write(Format(VV, "#0.00"))
                                                    tx.Write(" ")
                                                    tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    tx.Write(",00:0 ")
                                                    tx.Write(Lbl_año.Text)
                                                    tx.Write("                            ")
                                                End If
                                            End If
                                            H = H2 + H
                                        ElseIf dia = 6 Or dia = 0 Then
                                            If dia = 6 And turno = 4 Then
                                                If H >= 540 Then
                                                    '   H2 = 540
                                                    H3 = V '- 540
                                                    '   VV = Format(Int(H2 / 60) + (((H2 / 60 - Int(H2 / 60)) / 1.666)), "0.00")
                                                    VV3 = Format(Int(H3 / 60) + (((H3 / 60 - Int(H3 / 60)) / 1.666)), "0.00")

                                                    'tx.Write("D")
                                                    'tx.Write(" Semanal")
                                                    'tx.Write("                 ")
                                                    'tx.Write(String.Format("{0:00}", semana))
                                                    'tx.Write(" 2                   ")
                                                    'tx.Write("Horas extras 2                               ")
                                                    'tx.Write(Format(VV, "#0.00"))
                                                    'tx.Write(" ")
                                                    'tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    'tx.Write(",00:0 ")
                                                    'tx.Write(Lbl_año.Text)
                                                    'tx.Write("                            ")
                                                    'tx.WriteLine()

                                                    tx.Write("D")
                                                    tx.Write(" Semanal")
                                                    tx.Write("                 ")
                                                    tx.Write(String.Format("{0:00}", semana))
                                                    tx.Write(" 2                   ")
                                                    tx.Write("Horas extras 3                               ")
                                                    tx.Write(Format(VV3, "#0.00"))
                                                    tx.Write(" ")
                                                    tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    tx.Write(",00:0 ")
                                                    tx.Write(Lbl_año.Text)
                                                    tx.Write("                            ")
                                                ElseIf (H + V) <= 540 Then
                                                    H2 = V
                                                    VV = Format(Int(H2 / 60) + (((H2 / 60 - Int(H2 / 60)) / 1.666)), "0.00")

                                                    tx.Write("D")
                                                    tx.Write(" Semanal")
                                                    tx.Write("                 ")
                                                    tx.Write(String.Format("{0:00}", semana))
                                                    tx.Write(" 2                   ")
                                                    tx.Write("Horas extras 2                               ")
                                                    tx.Write(Format(VV, "#0.00"))
                                                    tx.Write(" ")
                                                    tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    tx.Write(",00:0 ")
                                                    tx.Write(Lbl_año.Text)
                                                    tx.Write("                            ")
                                                ElseIf (H + V) >= 540 Then
                                                    HH = 540 - H
                                                    HS = V - HH
                                                    H3 = HS
                                                    H2 = HH
                                                    VV = Format(Int(H2 / 60) + (((H2 / 60 - Int(H2 / 60)) / 1.666)), "0.00")
                                                    VV3 = Format(Int(H3 / 60) + (((H3 / 60 - Int(H3 / 60)) / 1.666)), "0.00")
                                                    tx.Write("D")
                                                    tx.Write(" Semanal")
                                                    tx.Write("                 ")
                                                    tx.Write(String.Format("{0:00}", semana))
                                                    tx.Write(" 2                   ")
                                                    tx.Write("Horas extras 2                               ")
                                                    tx.Write(Format(VV, "#0.00"))
                                                    tx.Write(" ")
                                                    tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    tx.Write(",00:0 ")
                                                    tx.Write(Lbl_año.Text)
                                                    tx.Write("                            ")
                                                    tx.WriteLine()

                                                    tx.Write("D")
                                                    tx.Write(" Semanal")
                                                    tx.Write("                 ")
                                                    tx.Write(String.Format("{0:00}", semana))
                                                    tx.Write(" 2                   ")
                                                    tx.Write("Horas extras 3                               ")
                                                    tx.Write(Format(VV3, "#0.00"))
                                                    tx.Write(" ")
                                                    tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    tx.Write(",00:0 ")
                                                    tx.Write(Lbl_año.Text)
                                                    tx.Write("                            ")

                                                End If
                                            Else
                                                If dia = 0 Then
                                                    VV = Format(Int(V / 60) + (((V / 60 - Int(V / 60)) / 1.666)), "0.00")

                                                    tx.Write("D")
                                                    tx.Write(" Semanal")
                                                    tx.Write("                 ")
                                                    tx.Write(String.Format("{0:00}", semana))
                                                    tx.Write(" 2                   ")
                                                    tx.Write("Horas extras 2                               ")
                                                    tx.Write(Format(VV, "#0.00"))
                                                    tx.Write(" ")
                                                    tx.Write(Format(.Cells("fecha").Value), "dd/MM/yyyy")
                                                    tx.Write(",00:0 ")
                                                    tx.Write(Lbl_año.Text)
                                                    tx.Write("                            ")
                                                End If
                                            End If
                                        End If
                                    Case "R"
                                        tx.Write("D")
                                        tx.Write(" Semanal")
                                        tx.Write("                 ")
                                        tx.Write(String.Format("{0:00}", semana))
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
                                        tx.Write(String.Format("{0:00}", semana))
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
                                        tx.Write(String.Format("{0:00}", semana))
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
                                        tx.Write(String.Format("{0:00}", semana))
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
                                        tx.Write(String.Format("{0:00}", semana))
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
                                    Case "SHU"
                                        tx.Write("D")
                                        tx.Write(" Semanal")
                                        tx.Write("                 ")
                                        tx.Write(String.Format("{0:00}", semana))
                                        tx.Write(" 2                   ")
                                        texto = "Paro Tecnico (Shutdown)                      "
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
    Function GridAExcel(ByVal dgv As DataGridView) As Boolean

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try

            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            Dim NCol As Integer = dgv.ColumnCount
            Dim NRow As Integer = dgv.RowCount

            For i As Integer = 1 To NCol
                If dgv.Columns(i - 1).Visible = True Then
                    exHoja.Cells.Item(1, i) = dgv.Columns(i - 1).HeaderText.ToString
                End If
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = dgv.Rows(Fila).Cells(Col).Value
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
    Private Sub Almacenar()
        Try
            Dim ds As New Dts_PrenominaGlobal
            Dim dtw As DataRow

            For i As Integer = 0 To Dgv_Prenomina_Global.Rows.Count - 2
                dtw = ds.Dtb_PrenominaGlobal.NewRow()
                If Dgv_Prenomina_Global.Rows(i).Visible = True Then
                    dtw("Id") = Dgv_Prenomina_Global.Rows(i).Cells("idEmpleado").Value
                    dtw("Nombre") = Dgv_Prenomina_Global.Rows(i).Cells("nombreEmpleado").Value
                    dtw("Lun") = Dgv_Prenomina_Global.Rows(i).Cells("lun").Value
                    dtw("TE1") = Dgv_Prenomina_Global.Rows(i).Cells("te1").Value
                    dtw("CM1") = Dgv_Prenomina_Global.Rows(i).Cells("cm1").Value
                    dtw("Mar") = Dgv_Prenomina_Global.Rows(i).Cells("mar").Value
                    dtw("TE2") = Dgv_Prenomina_Global.Rows(i).Cells("te2").Value
                    dtw("CM2") = Dgv_Prenomina_Global.Rows(i).Cells("cm2").Value
                    dtw("Mie") = Dgv_Prenomina_Global.Rows(i).Cells("mie").Value
                    dtw("TE3") = Dgv_Prenomina_Global.Rows(i).Cells("te3").Value
                    dtw("CM3") = Dgv_Prenomina_Global.Rows(i).Cells("cm3").Value
                    dtw("Jue") = Dgv_Prenomina_Global.Rows(i).Cells("jue").Value
                    dtw("TE4") = Dgv_Prenomina_Global.Rows(i).Cells("te4").Value
                    dtw("CM4") = Dgv_Prenomina_Global.Rows(i).Cells("cm4").Value
                    dtw("Vie") = Dgv_Prenomina_Global.Rows(i).Cells("vie").Value
                    dtw("TE5") = Dgv_Prenomina_Global.Rows(i).Cells("te5").Value
                    dtw("CM5") = Dgv_Prenomina_Global.Rows(i).Cells("cm5").Value
                    dtw("Sab") = Dgv_Prenomina_Global.Rows(i).Cells("sab").Value
                    dtw("TE6") = Dgv_Prenomina_Global.Rows(i).Cells("te6").Value
                    dtw("CM6") = Dgv_Prenomina_Global.Rows(i).Cells("cm6").Value
                    dtw("Dom") = Dgv_Prenomina_Global.Rows(i).Cells("dom").Value
                    dtw("TE7") = Dgv_Prenomina_Global.Rows(i).Cells("te7").Value
                    dtw("CM7") = Dgv_Prenomina_Global.Rows(i).Cells("cm7").Value
                    dtw("TE") = Dgv_Prenomina_Global.Rows(i).Cells("te").Value
                    dtw("COM") = Dgv_Prenomina_Global.Rows(i).Cells("com").Value
                    dtw("CM") = Dgv_Prenomina_Global.Rows(i).Cells("cm").Value
                    dtw("SP") = Dgv_Prenomina_Global.Rows(i).Cells("sp").Value
                    dtw("SPBono") = Dgv_Prenomina_Global.Rows(i).Cells("spBono").Value
                    dtw("Depto") = Dgv_Prenomina_Global.Rows(i).Cells("departamentoEmpleado").Value
                    dtw("Turno") = Dgv_Prenomina_Global.Rows(i).Cells("turnoEmpleado").Value
                    dtw("IdTurno") = Dgv_Prenomina_Global.Rows(i).Cells("idTurnoEmpleado").Value
                    dtw("R") = Dgv_Prenomina_Global.Rows(i).Cells("retardo").Value
                    dtw("PS") = Dgv_Prenomina_Global.Rows(i).Cells("permisoSalida").Value
                    dtw("F") = Dgv_Prenomina_Global.Rows(i).Cells("falta").Value
                    dtw("FJ") = Dgv_Prenomina_Global.Rows(i).Cells("faltaJustificada").Value
                    dtw("SUS") = Dgv_Prenomina_Global.Rows(i).Cells("suspension").Value
                    dtw("PSS") = Dgv_Prenomina_Global.Rows(i).Cells("permisoSinSueldo").Value
                    dtw("PCS") = Dgv_Prenomina_Global.Rows(i).Cells("permisoConSueldo").Value
                    dtw("PM") = Dgv_Prenomina_Global.Rows(i).Cells("permisoMaternidad").Value
                    dtw("INC") = Dgv_Prenomina_Global.Rows(i).Cells("incapacidad").Value
                    dtw("VAC") = Dgv_Prenomina_Global.Rows(i).Cells("vacaciones").Value
                    dtw("SHU") = Dgv_Prenomina_Global.Rows(i).Cells("shutdown").Value
                    dtw("Jp") = Dgv_Prenomina_Global.Rows(i).Cells("ujap").Value
                    dtw("DJ") = Dgv_Prenomina_Global.Rows(i).Cells("dJap").Value
                    dtw("Mx") = Dgv_Prenomina_Global.Rows(i).Cells("umex").Value
                    dtw("DM") = Dgv_Prenomina_Global.Rows(i).Cells("dMex").Value
                    dtw("UJUM") = Dgv_Prenomina_Global.Rows(i).Cells("jpMx").Value
                    dtw("UMUJ") = Dgv_Prenomina_Global.Rows(i).Cells("mxJp").Value
                    dtw("Sum") = Dgv_Prenomina_Global.Rows(i).Cells("suma").Value
                    dtw("Dif") = Dgv_Prenomina_Global.Rows(i).Cells("diferencia").Value
                    dtw("G") = Dgv_Prenomina_Global.Rows(i).Cells("grupo").Value
                    dtw("Lunes") = Lbl_Dia1.Text
                    dtw("Martes") = Lbl_Dia2.Text
                    dtw("Miercoles") = Lbl_Dia3.Text
                    dtw("Jueves") = Lbl_Dia4.Text
                    dtw("Viernes") = Lbl_Dia5.Text
                    dtw("Sabado") = lbl_Dia6.Text
                    dtw("Domingo") = lbl_Dia7.Text
                    ds.Dtb_PrenominaGlobal.Rows.Add(dtw)
                End If
            Next
            ''---------------------PREPARAR REPORTE--------------------
            Me.fuente.Name = "DataSet1" ' Nombre identico al que le di al dataset del report en tiempo de diseño
            Me.fuente.Value = ds.Tables(0)
            ''---------------------PREPARAR REPORTE------------------
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub llamarReporte()
        Frm_ReportePrenominaGlobal.ReportViewer1.LocalReport.DataSources.Clear()
        Frm_ReportePrenominaGlobal.ReportViewer1.LocalReport.DataSources.Add(fuente)
        Frm_ReportePrenominaGlobal.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Rpt_PrenominaGlobal.rdlc" 'exactamente como se llaman el proyecto y reporte
        Frm_ReportePrenominaGlobal.Show()
    End Sub
    Private Sub CrearTxtPDO()
        Me.userName = Environment.UserName
        Me.ruta = "C:\Users\" & Me.userName & "\Desktop\NominaSAAM\"
        Me.archivo = "PDO_Semanal_W" & Cmb_Semanas.Text & ".txt"
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
                'MsgBox("Archivo creado correctamente", MsgBoxStyle.Information, "")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
            fs.Close()
        End Try
    End Sub
    Private Sub EscribirArchivoPDO()
        Dim tx As New StreamWriter(Me.ruta & Me.archivo)
        Dim fila As Integer, idX As Integer = 0, e As Integer, totalFilas As Integer = Dgv_Prenomina_Global.Rows.Count
        Dim folio As String = ""
        Dim NPol As New NPolizas(), pol As New Polizas()
        Try
            'fecha = Dgv_Prenomina_Global.Rows(0).Cells("fechaFact").Value
            'e = pol.FolioPoliza
            For fila = 0 To totalFilas - 2
                Dim cargo As Integer = 0
                With Dgv_Prenomina_Global.Rows(fila)
                    folio = String.Format("{0:0000}", .Cells("idEmpleado").Value)
                    If .Cells("Bono").Value = "SI" Then
                        tx.Write(String.Format("{0,-8}", "E"))
                        tx.Write(String.Format("{0,-7}", folio))
                        tx.Write(String.Format("{0,-88}", ""))
                        tx.WriteLine()
                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "15") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "219.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()
                        '----------------------------------------------------------------------------------------------------------------------------
#Region "ceros"
                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "6") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("0 ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()

                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "11") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("0 ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()

                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "12") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("0 ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()

                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "13") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("0 ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()

                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "16") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("0 ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()

                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "19") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("0 ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()

                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "21") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("0 ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()

                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "22") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("0 ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()

                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "24") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("0 ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()

                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "135") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("0 ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()

                        tx.Write("P ")
                        tx.Write(String.Format("{0,-22}", "Semanal") & " ")
                        tx.Write(String.Format("{0,3}", Cmb_Semanas.Text) & " ")
                        tx.Write("2")
                        tx.Write(String.Format("{0,3}", "136") & " ")
                        tx.Write(String.Format("{0,32}", "") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write(String.Format("{0,15}", "0.00") & " ")
                        tx.Write("P ")
                        tx.Write(String.Format("{0,4}", Lbl_año.Text) & " ")
                        tx.Write("0 ")
                        tx.Write("1 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write("0 ")
                        tx.Write(" ")
                        tx.WriteLine()
#End Region
                        '----------------------------------------------------------------------------------------------------------------------------
                    End If
                End With
            Next
            MsgBox("Registro guardado correctamente", MsgBoxStyle.Information, "")
            tx.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
            tx.Close()
        End Try
    End Sub
    Private Sub ProcesoInsertaIncidenciasNomina()
        Dim lstInci As New LIncidencias(), NPren As New NPrenomina(), conex As New conexion()
        Dim cadenaConex As String

        If Me.ip = "172.16" Then
            cadenaConex = conex.conexionCont
        Else
            cadenaConex = conex.conexionContFor
        End If

        RecuperarIncidencias(0)
        lstInci = RellenaObjetoIncidencias()
        NPren.InsertarIncidenciasNomina(cadenaConex, lstInci)
        NPren.BitacoraInsertar(cadenaConex, Cmb_Semanas.Text, Lbl_año.Text, Me.emp.IdEmpleado, Date.Now(), 1)
    End Sub
    Private Sub ProcesoInsertaBonoNomina()
        Dim lstBono As New LBono(), NPren As New NPrenomina(), conex As New conexion()
        Dim cadenaConex As String = conex.conexionCont
        lstBono = RellenaObjetoBono()
        NPren.InsertarBonoNomina(cadenaConex, lstBono)
        NPren.BitacoraInsertar(cadenaConex, Cmb_Semanas.Text, Lbl_año.Text, Me.emp.IdEmpleado, Format(Date.Now(), "dd/MM/yyyy"), 2)
    End Sub
#End Region
End Class