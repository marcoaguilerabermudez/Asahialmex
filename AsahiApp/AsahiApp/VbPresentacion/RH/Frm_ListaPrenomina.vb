Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports Clases
Imports Negocio
Imports Excel = Microsoft.Office.Interop.Excel 'hola
Imports Microsoft.ReportingServices.Rendering.ExcelRenderer

Public Class Frm_ListaPrenomina
#Region "Variables de Clase"
    Dim cadConex As SqlConnection
    Dim con As New conexion()
    Dim cadenaConex As String
    Dim cadenaConexExp As String
    Dim open As Boolean
    Dim colum
    'Dim bd As New BindingSource
    'Dim super As Thread
    Dim valor, rangoPermiso
    Dim fin = 0
    Dim fuente As New ReportDataSource
    Dim idEmp As String, rec As String = "N"
    Dim ip As String = Strings.Left(Me.con.getIp(), 6)
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
    Sub New(ByVal cadConex As SqlConnection, ByVal cadenaConex As String, ByVal cadenaConexExp As String, ByVal idEmp As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadConex = cadConex
        Me.cadenaConex = cadenaConex
        Me.cadenaConexExp = cadenaConexExp
        Me.idEmp = idEmp
    End Sub
#End Region
#Region "Eventos del fomulario"
    Private Sub Frm_Prenomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NEmp As New NEmpleado(), conex As New conexion()
        Dim cadenaConex As String = conex.cadenaConexExpress
        Me.rangoPermiso = NEmp.RevisarRangoPermisos(Me.cadenaConexExp, Me.idEmp, "PreNominaListadoToolStripMenuItem")
        Lbl_año.Text = Format(DateTime.Now, "yyyy")
        RellenaCmbSemanas()
        ModificarDiaInicio()
        If Me.rangoPermiso = 2 Then
            Btn_GuardarBono.Visible = False
            Dgv_ListaPrenomina.Columns("comentarios").ReadOnly = True
            Dgv_ListaPrenomina.Columns("comentariosExt").ReadOnly = True
            Dgv_ListaPrenomina.Columns("aplicaBono").ReadOnly = True
        ElseIf Me.rangoPermiso = 3 Then
            Dgv_ListaPrenomina.Columns("entrada1").ReadOnly = True
            Dgv_ListaPrenomina.Columns("salida1").ReadOnly = True
            Dgv_ListaPrenomina.Columns("entrada2").ReadOnly = True
            Dgv_ListaPrenomina.Columns("salida2").ReadOnly = True
            Dgv_ListaPrenomina.Columns("entrada3").ReadOnly = True
            Dgv_ListaPrenomina.Columns("salida3").ReadOnly = True
            Dgv_ListaPrenomina.Columns("entrada4").ReadOnly = True
            Dgv_ListaPrenomina.Columns("salida4").ReadOnly = True
            Dgv_ListaPrenomina.Columns("entrada5").ReadOnly = True
            Dgv_ListaPrenomina.Columns("salida5").ReadOnly = True
            Dgv_ListaPrenomina.Columns("entrada6").ReadOnly = True
            Dgv_ListaPrenomina.Columns("salida6").ReadOnly = True
            Dgv_ListaPrenomina.Columns("entrada7").ReadOnly = True
            Dgv_ListaPrenomina.Columns("salida7").ReadOnly = True
            Dgv_ListaPrenomina.Columns("aplicaBono").ReadOnly = False
            Btn_Excel.Visible = False
            Btn_Reporte.Visible = False
            Btn_Guardar.Visible = False
        ElseIf Me.rangoPermiso = 4 Then
            Btn_Mostrar.Visible = False
            Btn_Reporte.Visible = False
            Btn_Guardar.Visible = False
            Btn_GuardarBono.Visible = False
        End If
    End Sub
    Private Sub Dtp_FechaInicioSemana_TextChanged(sender As Object, e As EventArgs) Handles Dtp_FechaInicioSemana.TextChanged
        If Dtp_FechaInicioSemana.Value < DateTime.Now Or Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyy") = Format(DateTime.Now, "dd/MM/yyy") Then

            Dim conex As New conexion
            Dim cadenaConexContpaq As New SqlConnection() 'As String 'Conexion a la BD de contpaq solo se va a usar para traer las fechas que corresponden la semana que se manda
            Dim fechaI As Date = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            Dim NPrenomina As New NPrenomina()
            Dim hrs As New Horarios()
            Dim sem As Integer
            Dim type As String

            If Me.ip = "172.16" Then
                cadenaConexContpaq = conex.conexionContpaq
            Else
                cadenaConexContpaq = conex.conexionContpaqFor
            End If

            Dgv_ListaPrenomina.DataSource = Nothing
            Dgv_ListaPrenomina.Rows.Clear()

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

            Dim fi As Date = lbl_Dia7.Text & "/" & Lbl_año.Text
            Dim fh As Date = DateTime.Now.ToString("dd/MM/yyyy")
            If fi >= fh Then
                Dgv_ListaPrenomina.Columns("aplicaBono").Visible = False
                Btn_GuardarBono.Visible = False
            Else
                Dgv_ListaPrenomina.Columns("aplicaBono").Visible = True
                If Me.rangoPermiso = 1 Or Me.rangoPermiso = 3 Then Btn_GuardarBono.Visible = True
            End If

            If sem <> hrs.Semana Then Cmb_Semanas.SelectedItem = hrs.Semana
            'Btn_Excel.Visible = False
            Txt_FiltroId.Enabled = False
            Txt_FiltroId.Text = ""
            Txt_FiltroNombre.Enabled = False
            Txt_FiltroNombre.Text = ""
            Txt_FiltroHorario.Enabled = False
            Txt_FiltroHorario.Text = ""
            Txt_FiltroDpto.Enabled = False
            Txt_FiltroDpto.Text = ""
            open = True
            Btn_GuardarBono.Enabled = False
            Cmb_FiltoIncidecias.Enabled = False
        Else
            Dgv_ListaPrenomina.Enabled = False
            MsgBox("Tienes que ingresar una fecha menor a la actual")
            ModificarDiaInicio()
            Dgv_ListaPrenomina.DataSource = Nothing
            Dgv_ListaPrenomina.Refresh()
        End If
    End Sub
    Private Sub Cmb_Semanas_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_Semanas.SelectedValueChanged
        If open = True Then
            Dim fecha As Date
            Dim lstEmp As New LEmpleado

            'ModificarDiaInicio()
            fecha = Lbl_Dia1.Text & "/" & Lbl_año.Text
            'ProcesoPrenomina(lstEmp, fecha)
        End If
    End Sub
    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click
        'Cursor = Cursors.WaitCursor
        'Timer1.Start()
        frm_wait.Show()
        Frmwait.Show()
        If open = True Then
            Dim fecha As Date
            Dim año As Integer, semana As Integer
            Dim lstEmp As New LEmpleado

            Me.fin = 0
            'ModificarDiaInicio()
            fecha = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            año = Lbl_año.Text
            semana = Cmb_Semanas.Text
            ProcesoPrenomina(lstEmp, fecha, semana, año)
            Cmb_FiltoIncidecias.Text = " "
            Cmb_FiltoIncidecias.Enabled = True
            Cmb_FiltroComen.Text = " "
            Cmb_FiltroComen.Enabled = True
            If Me.rangoPermiso = 1 Or Me.rangoPermiso = 2 Then Btn_Reporte.Visible = True
            Me.fin = 1
        End If
        frm_wait.Close()
        Frmwait.Close()
    End Sub
    Private Sub Bgw_HiloSegundoPlano_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Bgw_HiloSegundoPlano.DoWork

    End Sub
    Private Sub Dgv_ListaPrenomina_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListaPrenomina.CellEndEdit
        Dim fila As Integer
        Dim columna As String, colum As String
        Dim val As Object
        fila = Dgv_ListaPrenomina.CurrentRow.Index
        columna = Dgv_ListaPrenomina.Columns(e.ColumnIndex).Name
        If columna = "entrada1" Or columna = "entrada2" Or columna = "entrada3" Or columna = "entrada4" Or columna = "entrada5" Or columna = "entrada6" Or
           columna = "entrada7" Or columna = "salida1" Or columna = "salida2" Or columna = "salida3" Or columna = "salida4" Or columna = "salida5" Or
           columna = "salida6" Or columna = "salida7" Then
            Dgv_ListaPrenomina.Rows(fila).Cells(columna).Value = UCase(Dgv_ListaPrenomina.Rows(fila).Cells(columna).Value)
            val = Dgv_ListaPrenomina.Rows(fila).Cells(columna).Value
            colum = Mid(columna, Len(columna))
            colum = "manual" + colum + ""
            If Me.valor <> val Then
                If val <> "VAC" And val <> "INC" And val <> "BAJA" Then
                    colum = Mid(columna, Len(columna))
                    colum = "manual" + colum + ""
                    Dgv_ListaPrenomina.Rows(fila).Cells("manual").Value = "M"
                    Dgv_ListaPrenomina.Rows(fila).Cells(colum).Value = "M"
                    Btn_Guardar.Visible = True
                    ColorearCeldas(val, fila, columna)
                Else
                    MsgBox("No puedes ingresar vacaciones, incapacidades o bajas de manera manual")
                    Dgv_ListaPrenomina.Rows(fila).Cells(columna).Value = ""
                    Dgv_ListaPrenomina.Rows(fila).Cells(columna).Style.BackColor = Color.Gray
                    Dgv_ListaPrenomina.Rows(fila).Cells(columna).Style.ForeColor = Color.Black
                End If
            End If
        End If
    End Sub
    Private Sub Dgv_ListaPrenomina_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListaPrenomina.CellEnter
        Dim fila As Integer
        Dim columna As String
        fila = Dgv_ListaPrenomina.CurrentRow.Index
        columna = Dgv_ListaPrenomina.Columns(e.ColumnIndex).Name
        Me.colum = columna
        Me.valor = Dgv_ListaPrenomina.Rows(fila).Cells(columna).Value
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim lstEmp As New LEmpleado()
        Dim NPren As New NPrenomina()
        lstEmp = RellenaObjetoEmpleado()
        If lstEmp(0).Err = False Then
            Dim fechaI As Date
            Dim fechaF As Date
            Dim conex As New conexion
            Dim cadConex As String

            If Me.ip = "172.16" Then
                cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008
            Else
                cadConex = conex.conexion2008For
            End If
            fechaI = (Lbl_Dia1.Text + "/" + Lbl_año.Text)
            fechaF = DateAdd(DateInterval.Day, 6, fechaI)
            NPren.InsertarModificacionesIncidencias(Me.cadenaConex, lstEmp, Cmb_Semanas.Text)
            lstEmp = NPren.RecuperarInc(Me.cadenaConex, "A", Cmb_Semanas.Text, fechaI, fechaF)
            If lstEmp.Item(0).Err = Nothing Then
                lstEmp = CambiarTipoIncidenciaA(lstEmp)
                NPren.InsertarModificacionesAusentismo(cadConex, lstEmp)
            End If
            lstEmp = NPren.RecuperarInc(Me.cadenaConex, "HE", Cmb_Semanas.Text, fechaI, fechaF)
            If lstEmp.Item(0).Err = Nothing Then
                lstEmp = CambiarTipoIncidenciaHE(lstEmp)
                NPren.InsertarModificacionesHE(cadConex, lstEmp)
            End If
            lstEmp = NPren.RecuperarInc(Me.cadenaConex, "CH", Cmb_Semanas.Text, fechaI, fechaF)
            If lstEmp.Item(0).Err = False Then
                NPren.InsertarModificacionesChecadas(cadConex, lstEmp)
            End If
        Else
            MsgBox("No hubo ningún cambio")
        End If
    End Sub
    Private Sub Dgv_ListaPrenomina_DoubleClick(sender As Object, e As EventArgs) Handles Dgv_ListaPrenomina.DoubleClick

        If Me.colum = "entrada1" Or Me.colum = "entrada2" Or Me.colum = "entrada3" Or Me.colum = "entrada4" Or Me.colum = "entrada5" Or
            Me.colum = "entrada6" Or Me.colum = "entrada7" Or Me.colum = "salida1" Or Me.colum = "salida2" Or Me.colum = "salida3" Or
            Me.colum = "salida4" Or Me.colum = "salida5" Or Me.colum = "salida6" Or Me.colum = "salida7" Then
            Dim emp As New Empleado()
            Dim fila As Integer
            Dim c As String, u As String, idMotivo As String
            u = Strings.Right(Me.colum, 1)
            c = "b" & u
            fila = Dgv_ListaPrenomina.CurrentRow.Index

            If Dgv_ListaPrenomina.Rows(fila).Cells(c).Value = "0" Then
                emp.IdEmpleado = Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Value
                emp.NombreCompleto = Dgv_ListaPrenomina.Rows(fila).Cells("nombreEmpleado").Value
                emp.IdTurno = Dgv_ListaPrenomina.Rows(fila).Cells("idTurno").Value
                emp.Turno = Dgv_ListaPrenomina.Rows(fila).Cells("horarioEmpleado").Value
                emp.Horario = Dgv_ListaPrenomina.Rows(fila).Cells(Me.colum).Value
                Dim apBono As New Frm_AplicaBono(cadConex, cadenaConex, emp)

                If apBono.ShowDialog() = DialogResult.OK Then
                    Dim NPre As New NPrenomina()
                    Dim conex As New conexion()
                    Dim cadConex2008 As String

                    If Me.ip = "172.16" Then
                        cadConex2008 = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008
                    Else
                        cadConex2008 = conex.conexion2008For
                    End If
                    idMotivo = apBono.idMotivo
                    Dgv_ListaPrenomina.Rows(fila).Cells(c).Value = idMotivo
                    CalcularBonoIndividual(fila)
                    emp = RellenaObjetoEmpleadoMotivoRetardo(fila, c, u)
                    NPre.InsertarMotivoRetardoChecadas(cadConex2008, emp)
                    Dgv_ListaPrenomina.Rows(fila).Cells(Me.colum).Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells(Me.colum).Style.BackColor = Color.Green
                End If
            Else
                MsgBox("Registro ya modificado")
            End If
        End If
    End Sub
    Private Sub Btn_Excel_Click(sender As Object, e As EventArgs) Handles Btn_Excel.Click
        'GridAExcel(Dgv_ListaPrenomina)
        CrearExcel()
    End Sub
    Private Sub Txt_FiltroId_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroId.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_ListaPrenomina.Rows.Count, idEmp As Integer
        If Txt_FiltroId.Text <> "" Then
            For fila = 0 To totalFilas - 1
                With Dgv_ListaPrenomina.Rows(fila)
                    .Visible = True
                End With
            Next
            For fila = 0 To totalFilas - 1
                With Dgv_ListaPrenomina.Rows(fila)
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
                With Dgv_ListaPrenomina.Rows(fila)
                    .Visible = True
                End With
            Next
        End If
    End Sub
    Private Sub Btn_Reporte_Click(sender As Object, e As EventArgs) Handles Btn_Reporte.Click
        Almacenar()
        llamarReporte()
    End Sub
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Timer1.Start()
    '    Cursor = Cursors.Default
    'End Sub
    Private Sub Txt_FiltroHorario_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroHorario.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_ListaPrenomina.Rows.Count, horario As String
        If Len(Txt_FiltroHorario.Text) > 8 Or Len(Txt_FiltroHorario.Text) = 0 Then
            Txt_FiltroId.Text = ""
            Txt_FiltroNombre.Text = ""
            Txt_FiltroDpto.Text = ""
            If Txt_FiltroHorario.Text <> "" Then
                For fila = 0 To totalFilas - 1
                    With Dgv_ListaPrenomina.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_ListaPrenomina.Rows(fila)
                        horario = .Cells("horarioEmpleado").Value
                        If Not (horario Like Txt_FiltroHorario.Text) And horario <> "" Then
                            .Visible = True
                        End If
                        If Not (horario Like Txt_FiltroHorario.Text) And horario <> "" Then
                            .Visible = False
                        End If
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_ListaPrenomina.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        End If
    End Sub
    Private Sub Txt_FiltroDpto_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroDpto.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_ListaPrenomina.Rows.Count, dpto As String
        If Len(Txt_FiltroDpto.Text) > 6 Or Len(Txt_FiltroDpto.Text) = 0 Then
            Txt_FiltroId.Text = ""
            Txt_FiltroNombre.Text = ""
            Txt_FiltroHorario.Text = ""
            If Txt_FiltroDpto.Text <> "" Then
                For fila = 0 To totalFilas - 1
                    With Dgv_ListaPrenomina.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_ListaPrenomina.Rows(fila)
                        dpto = .Cells("departamentoEmpleado").Value
                        If Not (dpto Like Txt_FiltroDpto.Text) And dpto <> "" Then
                            .Visible = True
                        End If
                        If Not (dpto Like Txt_FiltroDpto.Text) And dpto <> "" Then
                            .Visible = False
                        End If
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_ListaPrenomina.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        End If
    End Sub
    Private Sub Txt_FiltroNombre_TextChanged(sender As Object, e As EventArgs) Handles Txt_FiltroNombre.TextChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_ListaPrenomina.Rows.Count, nombre As String
        If Len(Txt_FiltroNombre.Text) > 10 Or Len(Txt_FiltroNombre.Text) = 0 Then
            Txt_FiltroId.Text = ""
            Txt_FiltroHorario.Text = ""
            Txt_FiltroDpto.Text = ""
            If Txt_FiltroNombre.Text <> "" Then
                For fila = 0 To totalFilas - 1
                    With Dgv_ListaPrenomina.Rows(fila)
                        .Visible = True
                    End With
                Next
                For fila = 0 To totalFilas - 1
                    With Dgv_ListaPrenomina.Rows(fila)
                        nombre = .Cells("nombreEmpleado").Value
                        If Not (nombre Like Txt_FiltroNombre.Text) And nombre <> "" Then
                            .Visible = True
                        End If
                        If Not (nombre Like Txt_FiltroNombre.Text) And nombre <> "" Then
                            .Visible = False
                        End If
                    End With
                Next
            Else
                For fila = 0 To totalFilas - 1
                    With Dgv_ListaPrenomina.Rows(fila)
                        .Visible = True
                    End With
                Next
            End If
        End If
    End Sub
    Private Sub Btn_GuardarBono_Click(sender As Object, e As EventArgs) Handles Btn_GuardarBono.Click
        ProcesoGuardarBono()
        Btn_GuardarBono.Enabled = False
    End Sub
    Private Sub Dgv_ListaPrenomina_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListaPrenomina.CellContentClick
        Dim fila As Integer
        Dim columna As String
        columna = Dgv_ListaPrenomina.Columns(e.ColumnIndex).Name
        If (columna = "aplicaBono" Or columna = "comentarios") And Me.rec = "M" Then
            fila = Dgv_ListaPrenomina.CurrentRow.Index
            With Dgv_ListaPrenomina.Rows(fila)
                .Cells("modificaBono").Value = "M"
                .Cells("IdmodificaBono").Value = Me.idEmp
                Btn_GuardarBono.Enabled = True
            End With
        End If
    End Sub
    Private Sub Cmb_FiltoIncidecias_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_FiltoIncidecias.SelectedValueChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_ListaPrenomina.Rows.Count, inc As String, incColE As String, incColS As String, columna As Integer
        Txt_FiltroId.Text = ""
        Txt_FiltroNombre.Text = ""
        Txt_FiltroHorario.Text = ""
        Txt_FiltroDpto.Text = ""
        If Cmb_FiltoIncidecias.Text <> " " Then
            Cmb_FiltroComen.Text = ""
            inc = RecuperarDatoInc(Cmb_FiltoIncidecias.Text)
            For fila = 0 To totalFilas - 1
                With Dgv_ListaPrenomina.Rows(fila)
                    .Visible = True
                End With
            Next
            For columna = 1 To 6
                Dim ce As String = "entrada" & columna
                Dim cs As String = "salida" & columna
                For fila = 0 To totalFilas - 2
                    With Dgv_ListaPrenomina.Rows(fila)
                        incColE = .Cells(ce).Value
                        incColS = .Cells(cs).Value
                        Select Case inc
                            Case "F"
                                If (incColE = inc Or incColS = inc) Or (incColE = "F/B" Or incColS = "F/B") Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If
                            Case "FJ"
                                If (incColE = inc Or incColS = inc) Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If
                            Case "SUS"
                                If (incColE = inc Or incColS = inc) Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If
                            Case "R"
                                If incColE = inc Or incColE = "M-R" Or incColE = "M-M-R" Or incColE = "M-M-M-R" Or incColE = "M-M-M-M-R" Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf .Cells(ce).Style.BackColor = Color.White And .Cells(ce).Style.ForeColor = Color.Red Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If
                            Case "PS"
                                If incColS = inc Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf .Cells(cs).Style.BackColor = Color.White And .Cells(cs).Style.ForeColor = Color.Red Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If
                            Case "SC"
                                If (incColE = "" Or incColS = "") Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If
                            Case "PSS"
                                If (incColE = inc Or incColS = inc) Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If
                            Case "PCS"
                                If (incColE = inc Or incColS = inc) Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If
                            Case "INC"
                                If (incColE = inc Or incColS = inc) Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If
                            Case "BAJA"
                                If (incColE = inc Or incColS = inc) Or (incColE = "F/B" Or incColS = "F/B") Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If
                            Case "SHU"
                                If (incColE = inc Or incColS = inc) Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If
                            Case "OMI"
                                If (incColE = inc Or incColS = inc) Then
                                    If .Visible = False Then
                                        .Visible = True
                                    End If
                                ElseIf columna = 1 Then
                                    If .Visible = True Then
                                        .Visible = False
                                    End If
                                End If


                        End Select
                    End With
                Next
            Next
        ElseIf Cmb_FiltoIncidecias.Text = " " Then
            For fila = 0 To totalFilas - 1
                With Dgv_ListaPrenomina.Rows(fila)
                    .Visible = True
                End With
            Next
        End If
    End Sub
    Private Sub Cmb_FiltroComen_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_FiltroComen.SelectedValueChanged
        Dim fila As Integer, totalFilas As Integer = Dgv_ListaPrenomina.Rows.Count, comen As String
        Txt_FiltroId.Text = ""
        Txt_FiltroNombre.Text = ""
        Txt_FiltroHorario.Text = ""
        Txt_FiltroDpto.Text = ""
        If Cmb_FiltroComen.Text <> " " Then
            Cmb_FiltoIncidecias.Text = ""
            For fila = 0 To totalFilas - 1
                With Dgv_ListaPrenomina.Rows(fila)
                    .Visible = True
                End With
            Next
            For fila = 0 To totalFilas - 2
                With Dgv_ListaPrenomina.Rows(fila)
                    comen = .Cells("comentarios").Value
                    If (comen = Cmb_FiltroComen.Text) Or ((comen = "" Or comen = " ") And Cmb_FiltroComen.Text = "VACIO") Then
                        .Visible = True
                    ElseIf (comen <> Cmb_FiltroComen.Text) Then
                        .Visible = False
                    End If
                End With
            Next
        ElseIf Cmb_FiltroComen.Text = " " Then
            For fila = 0 To totalFilas - 1
                With Dgv_ListaPrenomina.Rows(fila)
                    .Visible = True
                End With
            Next
        End If
    End Sub
    Private Sub Dgv_ListaPrenomina_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_ListaPrenomina.CellValueChanged
        Dim fila As Integer
        Dim columna As String
        If Me.fin = 1 Then
            fila = Dgv_ListaPrenomina.CurrentRow.Index
            columna = Dgv_ListaPrenomina.Columns(e.ColumnIndex).Name
            If columna = "comentarios" And Me.rec = "M" Then
                fila = Dgv_ListaPrenomina.CurrentRow.Index
                With Dgv_ListaPrenomina.Rows(fila)
                    .Cells("modificaBono").Value = "M"
                    .Cells("IdmodificaBono").Value = Me.idEmp
                    Btn_GuardarBono.Enabled = True
                End With
            End If
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
    Private Function RecuperarEmpleados(ByVal fecha As Date, ByVal semana As Integer, ByVal año As Integer) As LEmpleado
        Dim NPre As New NPrenomina
        Dim conex As New conexion
        Dim cadConex As String
        If Me.ip = "172.16" Then
            cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008
        Else
            cadConex = conex.conexion2008For
        End If

        Return NPre.EmpleadosRecuperar(cadConex, fecha, semana, año)
    End Function
    Private Sub RecuperarIncidencias()
        Dim lstAus As New LAusentismo(), lstVac As New LVacaciones(), lstInc As New LIncapacidad(), lstHE As New LHorasExtra(), lstBja As New LBaja(),
            lstCom As New LComedor()
        Dim NPre As New NPrenomina()
        Dim fechaI As Date
        Dim fechaF As Date
        Dim conex As New conexion
        Dim cadConex As String

        If Me.ip = "172.16" Then
            cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008
        Else
            cadConex = conex.conexion2008For
        End If

        fechaI = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
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
#Region "Rellena formulario"
    Private Sub RellenaChecadasDgvPrenomina(ByVal lstEmp As LEmpleado)
        Dim fila As Integer = 0
        Dgv_ListaPrenomina.DataSource = Nothing
        Dgv_ListaPrenomina.Rows.Clear()

        For Each item In lstEmp
            Dgv_ListaPrenomina.Rows.Add()
            Dgv_ListaPrenomina.RowsDefaultCellStyle.BackColor = Color.Gray
            Dgv_ListaPrenomina.Rows(fila).Height = 30
            Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Value = item.IdEmpleado
            Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Style.BackColor = Color.White
            item.NombreCompleto = item.Nombres
            If item.ApellidoPaterno <> "x" Or item.ApellidoPaterno <> "X" Or item.ApellidoPaterno <> "" Then item.NombreCompleto = item.NombreCompleto & " " & item.ApellidoPaterno
            If item.ApellidoMaterno <> "x" Or item.ApellidoMaterno <> "X" Or item.ApellidoMaterno <> "" Then item.NombreCompleto = item.NombreCompleto & " " & item.ApellidoMaterno
            Dgv_ListaPrenomina.Rows(fila).Cells("nombreEmpleado").Value = item.NombreCompleto
            Dgv_ListaPrenomina.Rows(fila).Cells("nombreEmpleado").Style.BackColor = Color.White
            Dgv_ListaPrenomina.Rows(fila).Cells("horarioEmpleado").Value = item.Turno
            Dgv_ListaPrenomina.Rows(fila).Cells("horarioEmpleado").Style.BackColor = Color.White
            Dgv_ListaPrenomina.Rows(fila).Cells("departamentoEmpleado").Value = item.Departamento
            Dgv_ListaPrenomina.Rows(fila).Cells("departamentoEmpleado").Style.BackColor = Color.White
            Dgv_ListaPrenomina.Rows(fila).Cells("ingreso").Value = item.FechaIngreso
            Dgv_ListaPrenomina.Rows(fila).Cells("E").Value = item.HoraEntrada
            Dgv_ListaPrenomina.Rows(fila).Cells("S").Value = item.HoraSalida
            Dgv_ListaPrenomina.Rows(fila).Cells("comentarios").Value = item.ComenBono
            Dgv_ListaPrenomina.Rows(fila).Cells("comentariosExt").Value = item.ComenBonoExt
            Dgv_ListaPrenomina.Rows(fila).Cells("comentarios").Style.BackColor = Color.White
            Dgv_ListaPrenomina.Rows(fila).Cells("comentariosExt").Style.BackColor = Color.White
            Dgv_ListaPrenomina.Rows(fila).Cells("aplicaBono").Style.BackColor = Color.White
            item.HoraEntrada = Horarios(item.IdTurno, "Entrada")
            item.HoraSalida = Horarios(item.IdTurno, "Salida")

            If item.HoraEntradaReal1 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Value = Format(item.HoraEntradaReal1, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").ReadOnly = True
                If (DateAdd(DateInterval.Minute, 1, Convert.ToDateTime(item.HoraEntrada))) < item.HoraEntradaReal1 Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal1 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Value = Format(item.HoraSalidaReal1, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida1").ReadOnly = True
                If item.HoraSalida > item.HoraSalidaReal1 Then Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal2 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Value = Format(item.HoraEntradaReal2, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").ReadOnly = True
                If (DateAdd(DateInterval.Minute, 1, Convert.ToDateTime(item.HoraEntrada))) < item.HoraEntradaReal2 Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal2 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Value = Format(item.HoraSalidaReal2, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida2").ReadOnly = True
                If item.HoraSalida > item.HoraSalidaReal2 Then Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal3 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Value = Format(item.HoraEntradaReal3, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").ReadOnly = True
                If (DateAdd(DateInterval.Minute, 1, Convert.ToDateTime(item.HoraEntrada))) < item.HoraEntradaReal3 Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal3 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Value = Format(item.HoraSalidaReal3, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida3").ReadOnly = True
                If item.HoraSalida > item.HoraSalidaReal3 Then Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal4 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Value = Format(item.HoraEntradaReal4, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").ReadOnly = True
                If (DateAdd(DateInterval.Minute, 1, Convert.ToDateTime(item.HoraEntrada))) < item.HoraEntradaReal4 Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal4 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Value = Format(item.HoraSalidaReal4, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida4").ReadOnly = True
                If item.HoraSalida > item.HoraSalidaReal4 Then Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal5 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Value = Format(item.HoraEntradaReal5, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").ReadOnly = True
                If (DateAdd(DateInterval.Minute, 1, Convert.ToDateTime(item.HoraEntrada))) < item.HoraEntradaReal5 And (item.IdTurno <> 8 Or item.IdTurno <> 7) Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal5 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Value = Format(item.HoraSalidaReal5, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida5").ReadOnly = True
                If item.HoraSalida > item.HoraSalidaReal5 And (item.IdTurno <> 8 Or item.IdTurno <> 7) Then Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal6 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Value = Format(item.HoraEntradaReal6, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").ReadOnly = True
                If (DateAdd(DateInterval.Minute, 1, Convert.ToDateTime(item.HoraEntrada))) < item.HoraEntradaReal6 And (item.IdTurno <> 8 Or item.IdTurno <> 7 Or item.IdTurno <> 4) Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal6 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Value = Format(item.HoraSalidaReal6, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida6").ReadOnly = True
                If (item.HoraSalida > item.HoraSalidaReal6) And (item.IdTurno <> 8 Or item.IdTurno <> 7 Or item.IdTurno <> 4) Then Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal7 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Value = Format(item.HoraEntradaReal7, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").ReadOnly = True
                If (DateAdd(DateInterval.Minute, 1, Convert.ToDateTime(item.HoraEntrada))) < item.HoraEntradaReal7 And (item.IdTurno <> 8 Or item.IdTurno <> 7 Or item.IdTurno <> 4) Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal7 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Value = Format(item.HoraSalidaReal7, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.BackColor = Color.White
                If Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Value <> "0" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida7").ReadOnly = True
                If (item.HoraSalida > item.HoraSalidaReal7) And (item.IdTurno <> 8 Or item.IdTurno <> 7 Or item.IdTurno <> 4) Then Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.ForeColor = Color.Red
            End If
            Dgv_ListaPrenomina.Rows(fila).Cells("b1").Value = item.Nota1
            Dgv_ListaPrenomina.Rows(fila).Cells("b2").Value = item.Nota2
            Dgv_ListaPrenomina.Rows(fila).Cells("b3").Value = item.Nota3
            Dgv_ListaPrenomina.Rows(fila).Cells("b4").Value = item.Nota4
            Dgv_ListaPrenomina.Rows(fila).Cells("b5").Value = item.Nota5
            Dgv_ListaPrenomina.Rows(fila).Cells("b6").Value = item.Nota6
            Dgv_ListaPrenomina.Rows(fila).Cells("b7").Value = item.Nota7

            If item.IdTurno <> 3 Then
                If item.TipoRegistro1 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl1").Value = item.TipoRegistro1
                End If
                If item.TipoRegistro2 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl2").Value = item.TipoRegistro2
                End If
                If item.TipoRegistro3 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl3").Value = item.TipoRegistro3
                End If
                If item.TipoRegistro4 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl4").Value = item.TipoRegistro4
                End If
                If item.TipoRegistro5 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl5").Value = item.TipoRegistro5
                End If
                If item.TipoRegistro6 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl6").Value = item.TipoRegistro6
                End If
                If item.TipoRegistro7 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl7").Value = item.TipoRegistro7
                End If

            ElseIf item.IdTurno = 3 Then

                If item.TipoRegistro0 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl1").Value = item.TipoRegistro0
                End If
                If item.TipoRegistro1 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl2").Value = item.TipoRegistro1
                End If
                If item.TipoRegistro2 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl3").Value = item.TipoRegistro2
                End If
                If item.TipoRegistro3 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl4").Value = item.TipoRegistro3
                End If
                If item.TipoRegistro4 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl5").Value = item.TipoRegistro4
                End If
                If item.TipoRegistro5 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl6").Value = item.TipoRegistro5
                End If
                If item.TipoRegistro6 = "M" Then
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.BackColor = Color.Green
                    Dgv_ListaPrenomina.Rows(fila).Cells("mnl7").Value = item.TipoRegistro6
                End If
                Dgv_ListaPrenomina.Rows(fila).Cells("b1").Value = item.Nota0
                Dgv_ListaPrenomina.Rows(fila).Cells("b2").Value = item.Nota1
                Dgv_ListaPrenomina.Rows(fila).Cells("b3").Value = item.Nota2
                Dgv_ListaPrenomina.Rows(fila).Cells("b4").Value = item.Nota3
                Dgv_ListaPrenomina.Rows(fila).Cells("b5").Value = item.Nota4
                Dgv_ListaPrenomina.Rows(fila).Cells("b6").Value = item.Nota5
                Dgv_ListaPrenomina.Rows(fila).Cells("b7").Value = item.Nota6
            End If

            Dgv_ListaPrenomina.Rows(fila).Cells("aplicaBono").Value = item.Bono
            Dgv_ListaPrenomina.Rows(fila).Cells("idTurno").Value = item.IdTurno
            Dgv_ListaPrenomina.Rows(fila).Cells("nacional").Value = item.Nacional
            Dgv_ListaPrenomina.Rows(fila).Cells("puesto").Value = item.Puesto
            fila += 1
        Next
        Dgv_ListaPrenomina.Enabled = True
    End Sub
    Private Sub RellenaIncidenciasDgvPrenomina(ByVal lstAus As LAusentismo, ByVal lstVac As LVacaciones, ByVal lstInc As LIncapacidad, ByVal lstHE As LHorasExtra,
                                               ByVal lstBja As LBaja, ByVal lstCom As LComedor)
        Dim fecha As Date = Format((Lbl_Dia1.Text + "/" + Lbl_año.Text))
        Dim totalFilas As Integer = Dgv_ListaPrenomina.Rows.Count()

        RellenaBajas(lstBja, fecha, totalFilas)
        RellenaIncapacidad(lstInc, fecha, totalFilas)
        RellenaVacaciones(lstVac, fecha, totalFilas)
        RellenarHrsExtraDTFeriadoRet(lstHE, fecha, totalFilas)
        RellenaAusentismo(lstAus, fecha, totalFilas)
        RellenaComedor(lstCom, fecha, totalFilas)
        RellenaDescanso(totalFilas)
    End Sub
    Private Sub RellenaBajas(ByVal lstBja As LBaja, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim fila As Integer
        Dim inc As String = "BAJA"
        For fila = 0 To totalFilas - 1
            For Each item In lstBja
                If Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Value = item.IdEmpleado Then
                    Dim colum As Integer = 0
                    Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Style.BackColor = Color.FromArgb(64, 64, 0)
                    Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Style.ForeColor = Color.White
                    Dgv_ListaPrenomina.Rows(fila).Cells("nombreEmpleado").Style.BackColor = Color.FromArgb(64, 64, 0)
                    Dgv_ListaPrenomina.Rows(fila).Cells("nombreEmpleado").Style.ForeColor = Color.White
                    Select Case Format(item.Fecha, "dd/MM/yyyy")
                        Case Format(fecha, "dd/MM/yyyy")
                            For colum = 1 To 7
                                Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                End If
                            Next
                        Case Format(DateAdd(DateInterval.Day, 1, fecha), "dd/MM/yyyy")
                            For colum = 2 To 7
                                Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                End If
                            Next
                        Case Format(DateAdd(DateInterval.Day, 2, fecha), "dd/MM/yyyy")
                            For colum = 3 To 7
                                Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                End If
                            Next
                        Case Format(DateAdd(DateInterval.Day, 3, fecha), "dd/MM/yyyy")
                            For colum = 4 To 7
                                Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                End If
                            Next
                        Case Format(DateAdd(DateInterval.Day, 4, fecha), "dd/MM/yyyy")
                            For colum = 5 To 7
                                Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                End If
                            Next
                        Case Format(DateAdd(DateInterval.Day, 5, fecha), "dd/MM/yyyy")
                            For colum = 6 To 7
                                Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                End If
                            Next
                        Case Format(DateAdd(DateInterval.Day, 6, fecha), "dd/MM/yyyy")
                            If Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Value = "" Then
                                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Value = inc
                                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.BackColor = Color.FromArgb(64, 64, 0)
                                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.ForeColor = Color.White
                                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").ReadOnly = True
                            Else
                                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.BackColor = Color.FromArgb(64, 64, 0)
                                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.ForeColor = Color.White
                            End If
                            If Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Value = "" Then
                                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Value = inc
                                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.BackColor = Color.FromArgb(64, 64, 0)
                                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.ForeColor = Color.White
                                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").ReadOnly = True
                            Else
                                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.BackColor = Color.FromArgb(64, 64, 0)
                                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.ForeColor = Color.White
                            End If
                    End Select
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
        For Each item In lstInc
            For fila = 0 To totalFilas - 1
                If Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Value = item.IdEmpleado Then
                    Dim colum As Integer
                    fechaI = item.FechaI
                    For dur = 1 To item.Duracion
                        fechaF = lbl_Dia7.Text + "/" + Lbl_año.Text
                        For colum = 1 To 7
                            fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                            If item.FechaI <= fechaF Then
                                If fechaI = fechaC Then
                                    Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                    Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                    If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.SteelBlue
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                    Else
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.SteelBlue
                                    End If
                                    If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.SteelBlue
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                                    Else
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.SteelBlue
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

        For Each item In lstVac
            For fila = 0 To totalFilas - 1
                If Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Value = item.IdEmpleado Then
                    Dim colum As Integer
                    fechaI = item.FechaI
                    For dur = 1 To item.Duracion
                        fechaF = lbl_Dia7.Text + "/" + Lbl_año.Text
                        For colum = 1 To 7
                            fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                            If item.FechaI <= fechaF Then
                                If fechaI = fechaC Then
                                    Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                    Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                    If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.DodgerBlue
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                    Else
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.DodgerBlue
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                    End If
                                    If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.DodgerBlue
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                                    Else
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.DodgerBlue
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
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
    Private Sub RellenarHrsExtraDTFeriadoRet(ByVal lstHE As LHorasExtra, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim fila As Integer
        Dim fechaI As Date
        Dim fechaF As Date
        Dim inc As String
        For Each item In lstHE
            For fila = 0 To totalFilas - 1
                If Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Value = item.IdEmpleado Then
                    Dim colum As Integer
                    inc = item.Tipo
                    fechaF = lbl_Dia7.Text + "/" + Lbl_año.Text
                    If inc = "DT" Then
                        fechaI = fecha
                        For colum = 1 To 7
                            If item.Fecha = fechaI Then
                                Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.LightSlateGray
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.LightSlateGray
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                            End If
                            fechaI = Format(DateAdd(DateInterval.Day, 1, fechaI), "dd/MM/yyyy")
                        Next
                    ElseIf inc = "F" Then
                        inc = "FL"
                        fechaI = fecha
                        For colum = 1 To 7
                            If item.Fecha = fechaI Then
                                Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.Plum
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.Plum
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.Black
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.Black
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                            End If
                            fechaI = Format(DateAdd(DateInterval.Day, 1, fechaI), "dd/MM/yyyy")
                        Next
                    ElseIf item.Tipo = "R" Then
                        Select Case item.TipoPermiso
                            Case "" : inc = "Ret"
                            Case 4 : inc = "RT"
                        End Select
                        fechaI = fecha
                        For colum = 1 To 7
                            If item.Fecha = fechaI Then
                                Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.Red
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.Red
                                End If
                            End If
                            fechaI = Format(DateAdd(DateInterval.Day, 1, fechaI), "dd/MM/yyyy")
                        Next
                    ElseIf item.Tipo = "P" Then
                        fechaI = fecha
                        inc = "PS"
                        For colum = 1 To 7
                            If item.Fecha = fechaI Then
                                Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.Red
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.Red
                                End If
                            End If
                            fechaI = Format(DateAdd(DateInterval.Day, 1, fechaI), "dd/MM/yyyy")
                        Next
                    End If
                End If
            Next
        Next
    End Sub
    Private Sub RellenaAusentismo(ByVal lstAus As LAusentismo, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim fila As Integer
        Dim dur As Integer
        Dim fechaI As Date
        Dim fechaF As Date
        Dim fechaC As Date
        Dim inc As String
        Dim cb As Color
        Dim cf As Color
        For Each item In lstAus
            For fila = 0 To totalFilas - 1
                If Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Value = item.IdEmpleado Then
                    Dim colum As Integer
                    inc = item.TipoAusentismo
                    fechaI = item.FechaI
                    'dur = item.Duracion
                    If item.Duracion = 0 Then item.Duracion = 1
                    Select Case inc
                        Case "B"
                            inc = "PM"
                            cb = Color.SteelBlue
                            cf = Color.Black
                        Case "F"
                            inc = "F"
                            cb = Color.Red
                            cf = Color.Black
                        Case "G"
                            inc = "PCS"
                            cb = Color.Yellow
                            cf = Color.Black
                        Case "P"
                            inc = "PSS"
                            cb = Color.Yellow
                            cf = Color.Red
                        Case "U"
                            inc = "FJ"
                            cb = Color.Red
                            cf = Color.Orange
                        Case "N"
                            inc = "SUS"
                            cb = Color.Red
                            cf = Color.Orange
                        Case "H"
                            inc = "HO"
                            cb = Color.GreenYellow
                            cf = Color.Navy
                        Case "D"
                            inc = "VUL"
                            cb = Color.GreenYellow
                            cf = Color.Black
                        Case "K"
                            inc = "CC"
                            cb = Color.GreenYellow
                            cf = Color.OrangeRed
                        Case "O"
                            inc = "SO"
                            cb = Color.GreenYellow
                            cf = Color.OrangeRed
                        Case "J"
                            inc = "CF"
                            cb = Color.GreenYellow
                            cf = Color.Red
                        Case "Z"
                            inc = "SHU"
                            cb = Color.Yellow
                            cf = Color.Black
                        Case "I"
                            inc = "OMI"
                            cb = Color.Beige
                            cf = Color.Black
                        Case Else
                            inc = "error"
                    End Select
                    For dur = 1 To item.Duracion
                        fechaF = lbl_Dia7.Text + "/" + Lbl_año.Text
                        For colum = 1 To 7
                            fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                            If item.FechaI <= fechaF Then
                                If fechaI = fechaC Then
                                    Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                    Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                    If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = cb
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = cf
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                    ElseIf Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "BAJA" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "F/B"
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.Red
                                    Else
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.Orange
                                    End If
                                    If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = cb
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = cf
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                                    ElseIf Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "BAJA" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "F/B"
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.Red
                                    Else
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.Orange
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
        Dim fechaI As Date
        Dim inc As String
        For Each item In lstCom
            For fila = 0 To totalFilas - 1
                If Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Value = item.IdEmpleado Then
                    Dim colum As Integer
                    Select Case item.TipoComida
                        Case 0 : inc = "M-"
                        Case 1 : inc = "J-"
                        Case Else : inc = "ERROR"
                    End Select
                    fechaI = fecha
                    For colum = 1 To 7
                        If item.FechaComedor = fechaI Then
                            Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                            Dim cs As String = "salida" + Convert.ToString(colum) + ""
                            If Not IsDate(Dgv_ListaPrenomina.Rows(fila).Cells(ce).FormattedValue) And
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value <> "" Then
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = inc + Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.Orange
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                            End If
                            If Not IsDate(Dgv_ListaPrenomina.Rows(fila).Cells(cs).FormattedValue) And
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value <> "" Then
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc + Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.Orange
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                            End If
                        End If
                        fechaI = Format(DateAdd(DateInterval.Day, 1, fechaI), "dd/MM/yyyy")
                    Next
                End If
            Next
        Next
    End Sub
    Private Sub RellenaDescanso(ByVal totalFilas As Integer)
        Dim fila As Integer, colum As Integer, idTurno As Integer
        For fila = 0 To totalFilas - 2
            idTurno = Dgv_ListaPrenomina.Rows(fila).Cells("idTurno").Value
            If idTurno > 6 Then 'Se cambia < de 7 a > 6 para los nuevos turnos.
                For colum = 4 To 7
                    If colum > 4 Then
                        If idTurno < 10 Then
                            Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                            Dim cs As String = "salida" + Convert.ToString(colum) + ""
                            If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "D"
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.Black
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                            End If
                            If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "D"
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.Black
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                            End If
                        ElseIf colum > 5 Then
                            If idTurno = 10 Then
                                Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                                Dim cs As String = "salida" + Convert.ToString(colum) + ""
                                If Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "D"
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.Black
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).ReadOnly = True
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "D"
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.Black
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).ReadOnly = True
                                End If
                            End If
                        End If
                    End If
                Next
            End If

        Next
    End Sub
    Private Sub RellenaChecadasExpatriadosMazda()
        Dim fila As Integer, totalFilas As Integer = Dgv_ListaPrenomina.Rows.Count()
        Dim d1 As Date = Format(Convert.ToDateTime(Lbl_Dia1.Text & "/" & Lbl_año.Text), "dd/MM/yyyy"),
            d2 As Date = Format(Convert.ToDateTime(Lbl_Dia2.Text & "/" & Lbl_año.Text), "dd/MM/yyyy"),
            d3 As Date = Format(Convert.ToDateTime(Lbl_Dia3.Text & "/" & Lbl_año.Text), "dd/MM/yyyy"),
            d4 As Date = Format(Convert.ToDateTime(Lbl_Dia4.Text & "/" & Lbl_año.Text), "dd/MM/yyyy"),
            d5 As Date = Format(Convert.ToDateTime(Lbl_Dia5.Text & "/" & Lbl_año.Text), "dd/MM/yyyy")

        For fila = 0 To totalFilas - 2
            With Dgv_ListaPrenomina.Rows(fila)
                Dim idTurno As Integer = .Cells("idTurno").Value
                Dim nac As Boolean = .Cells("nacional").Value
                Dim pues As String = .Cells("puesto").Value
                If nac = True And (pues = "007" Or pues = "003") Then
                    If .Cells("entrada1").Value = "" Then 'And ((d1 < Format(Convert.ToDateTime("01/02/2020"), "dd/MM/yyyy")) Or (pues = "007" Or pues = "003")) Then
                        .Cells("entrada1").Value = "08:00"
                        .Cells("manual").Value = "M"
                        .Cells("manual1").Value = "M"
                        .Cells("b1").Value = "1"
                        .Cells("entrada1").Style.BackColor = Color.Green
                        .Cells("entrada1").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida1").Value = "" Then 'And ((d1 < Format(Convert.ToDateTime("01/02/2020"), "dd/MM/yyyy")) Or (pues = "007" Or pues = "003")) Then
                        .Cells("salida1").Value = "17:00"
                        .Cells("manual").Value = "M"
                        .Cells("manual1").Value = "M"
                        .Cells("b1").Value = "1"
                        .Cells("salida1").Style.BackColor = Color.Green
                        .Cells("salida1").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada2").Value = "" Then 'And ((d2 < Format(Convert.ToDateTime("01/02/2020"), "dd/MM/yyyy")) Or (pues = "007" Or pues = "003")) Then
                        .Cells("entrada2").Value = "08:00"
                        .Cells("manual").Value = "M"
                        .Cells("manual2").Value = "M"
                        .Cells("b2").Value = "1"
                        .Cells("entrada2").Style.BackColor = Color.Green
                        .Cells("entrada2").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida2").Value = "" Then 'And ((d2 < Format(Convert.ToDateTime("01/02/2020"), "dd/MM/yyyy")) Or (pues = "007" Or pues = "003")) Then
                        .Cells("salida2").Value = "17:00"
                        .Cells("manual").Value = "M"
                        .Cells("manual2").Value = "M"
                        .Cells("b2").Value = "1"
                        .Cells("salida2").Style.BackColor = Color.Green
                        .Cells("salida2").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada3").Value = "" Then 'And ((d3 < Format(Convert.ToDateTime("01/02/2020"), "dd/MM/yyyy")) Or (pues = "007" Or pues = "003")) Then
                        .Cells("entrada3").Value = "08:00"
                        .Cells("manual").Value = "M"
                        .Cells("manual3").Value = "M"
                        .Cells("b3").Value = "1"
                        .Cells("entrada3").Style.BackColor = Color.Green
                        .Cells("entrada3").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida3").Value = "" Then 'And ((d3 < Format(Convert.ToDateTime("01/02/2020"), "dd/MM/yyyy")) Or (pues = "007" Or pues = "003")) Then
                        .Cells("salida3").Value = "17:00"
                        .Cells("manual").Value = "M"
                        .Cells("manual3").Value = "M"
                        .Cells("b3").Value = "1"
                        .Cells("salida3").Style.BackColor = Color.Green
                        .Cells("salida3").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada4").Value = "" Then 'And ((d4 < Format(Convert.ToDateTime("01/02/2020"), "dd/MM/yyyy")) Or (pues = "007" Or pues = "003")) Then
                        .Cells("entrada4").Value = "08:00"
                        .Cells("manual").Value = "M"
                        .Cells("manual4").Value = "M"
                        .Cells("b4").Value = "1"
                        .Cells("entrada4").Style.BackColor = Color.Green
                        .Cells("entrada4").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida4").Value = "" Then 'And ((d4 < Format(Convert.ToDateTime("01/02/2020"), "dd/MM/yyyy")) Or (pues = "007" Or pues = "003")) Then
                        .Cells("salida4").Value = "17:00"
                        .Cells("manual").Value = "M"
                        .Cells("manual4").Value = "M"
                        .Cells("b4").Value = "1"
                        .Cells("salida4").Style.BackColor = Color.Green
                        .Cells("salida4").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada5").Value = "" Then 'And ((d5 < Format(Convert.ToDateTime("01/02/2020"), "dd/MM/yyyy")) Or (pues = "007" Or pues = "003")) Then
                        .Cells("entrada5").Value = "08:00"
                        .Cells("manual").Value = "M"
                        .Cells("manual5").Value = "M"
                        .Cells("b5").Value = "1"
                        .Cells("entrada5").Style.BackColor = Color.Green
                        .Cells("entrada5").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida5").Value = "" Then 'And ((d5 < Format(Convert.ToDateTime("01/02/2020"), "dd/MM/yyyy")) Or (pues = "007" Or pues = "003")) Then
                        .Cells("salida5").Value = "17:00"
                        .Cells("manual").Value = "M"
                        .Cells("manual5").Value = "M"
                        .Cells("b5").Value = "1"
                        .Cells("salida5").Style.BackColor = Color.Green
                        .Cells("salida5").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                ElseIf idTurno = 5 Then
                    If .Cells("entrada1").Value = "" Then
                        .Cells("entrada1").Value = "07:44"
                        .Cells("manual").Value = "M"
                        .Cells("manual1").Value = "M"
                        .Cells("b1").Value = "1"
                        .Cells("entrada1").Style.BackColor = Color.Green
                        .Cells("entrada1").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida1").Value = "" Then
                        .Cells("salida1").Value = "18:21"
                        .Cells("manual").Value = "M"
                        .Cells("manual1").Value = "M"
                        .Cells("b1").Value = "1"
                        .Cells("salida1").Style.BackColor = Color.Green
                        .Cells("salida1").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada2").Value = "" Then
                        .Cells("entrada2").Value = "07:44"
                        .Cells("manual").Value = "M"
                        .Cells("manual2").Value = "M"
                        .Cells("b2").Value = "1"
                        .Cells("entrada2").Style.BackColor = Color.Green
                        .Cells("entrada2").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida2").Value = "" Then
                        .Cells("salida2").Value = "18:21"
                        .Cells("manual").Value = "M"
                        .Cells("manual2").Value = "M"
                        .Cells("b2").Value = "1"
                        .Cells("salida2").Style.BackColor = Color.Green
                        .Cells("salida2").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada3").Value = "" Then
                        .Cells("entrada3").Value = "07:44"
                        .Cells("manual").Value = "M"
                        .Cells("manual3").Value = "M"
                        .Cells("b3").Value = "1"
                        .Cells("entrada3").Style.BackColor = Color.Green
                        .Cells("entrada3").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida3").Value = "" Then
                        .Cells("salida3").Value = "18:21"
                        .Cells("manual").Value = "M"
                        .Cells("manual3").Value = "M"
                        .Cells("b3").Value = "1"
                        .Cells("salida3").Style.BackColor = Color.Green
                        .Cells("salida3").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada4").Value = "" Then
                        .Cells("entrada4").Value = "07:44"
                        .Cells("manual").Value = "M"
                        .Cells("manual4").Value = "M"
                        .Cells("b4").Value = "1"
                        .Cells("entrada4").Style.BackColor = Color.Green
                        .Cells("entrada4").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida4").Value = "" Then
                        .Cells("salida4").Value = "18:21"
                        .Cells("manual").Value = "M"
                        .Cells("manual4").Value = "M"
                        .Cells("b4").Value = "1"
                        .Cells("salida4").Style.BackColor = Color.Green
                        .Cells("salida4").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada5").Value = "" Then
                        .Cells("entrada5").Value = "07:44"
                        .Cells("manual").Value = "M"
                        .Cells("manual5").Value = "M"
                        .Cells("b5").Value = "1"
                        .Cells("entrada5").Style.BackColor = Color.Green
                        .Cells("entrada5").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida5").Value = "" Then
                        .Cells("salida5").Value = "18:21"
                        .Cells("manual").Value = "M"
                        .Cells("manual5").Value = "M"
                        .Cells("b5").Value = "1"
                        .Cells("salida5").Style.BackColor = Color.Green
                        .Cells("salida5").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                ElseIf idTurno = 6 Then
                    If .Cells("entrada1").Value = "" Then
                        .Cells("entrada1").Value = "20:20"
                        .Cells("manual").Value = "M"
                        .Cells("manual1").Value = "M"
                        .Cells("b1").Value = "1"
                        .Cells("entrada1").Style.BackColor = Color.Green
                        .Cells("entrada1").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida1").Value = "" Then
                        .Cells("salida1").Value = "06:21"
                        .Cells("manual").Value = "M"
                        .Cells("manual1").Value = "M"
                        .Cells("b1").Value = "1"
                        .Cells("salida1").Style.BackColor = Color.Green
                        .Cells("salida1").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada2").Value = "" Then
                        .Cells("entrada2").Value = "20:20"
                        .Cells("manual").Value = "M"
                        .Cells("manual2").Value = "M"
                        .Cells("b2").Value = "1"
                        .Cells("entrada2").Style.BackColor = Color.Green
                        .Cells("entrada2").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida2").Value = "" Then
                        .Cells("salida2").Value = "06:21"
                        .Cells("manual").Value = "M"
                        .Cells("manual2").Value = "M"
                        .Cells("b2").Value = "1"
                        .Cells("salida2").Style.BackColor = Color.Green
                        .Cells("salida2").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada3").Value = "" Then
                        .Cells("entrada3").Value = "20:20"
                        .Cells("manual").Value = "M"
                        .Cells("manual3").Value = "M"
                        .Cells("b3").Value = "1"
                        .Cells("entrada3").Style.BackColor = Color.Green
                        .Cells("entrada3").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida3").Value = "" Then
                        .Cells("salida3").Value = "06:21"
                        .Cells("manual").Value = "M"
                        .Cells("manual3").Value = "M"
                        .Cells("b3").Value = "1"
                        .Cells("salida3").Style.BackColor = Color.Green
                        .Cells("salida3").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada4").Value = "" Then
                        .Cells("entrada4").Value = "20:20"
                        .Cells("manual").Value = "M"
                        .Cells("manual4").Value = "M"
                        .Cells("b4").Value = "1"
                        .Cells("entrada4").Style.BackColor = Color.Green
                        .Cells("entrada4").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida4").Value = "" Then
                        .Cells("salida4").Value = "06:21"
                        .Cells("manual").Value = "M"
                        .Cells("manual4").Value = "M"
                        .Cells("b4").Value = "1"
                        .Cells("salida4").Style.BackColor = Color.Green
                        .Cells("salida4").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("entrada5").Value = "" Then
                        .Cells("entrada5").Value = "20:20"
                        .Cells("manual").Value = "M"
                        .Cells("manual5").Value = "M"
                        .Cells("b5").Value = "1"
                        .Cells("entrada5").Style.BackColor = Color.Green
                        .Cells("entrada5").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                    If .Cells("salida5").Value = "" Then
                        .Cells("salida5").Value = "06:21"
                        .Cells("manual").Value = "M"
                        .Cells("manual5").Value = "M"
                        .Cells("b5").Value = "1"
                        .Cells("salida5").Style.BackColor = Color.Green
                        .Cells("salida5").Style.ForeColor = Color.White
                        Btn_Guardar.Visible = True
                    End If
                End If
            End With
        Next
    End Sub
    Private Sub RellenarTxtHorario()
        Dim lstEmp As New LEmpleado()
        Dim NEmp As New NEmpleado()
        Dim emp As New Empleado()
        'Dim fi As Date = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")

        lstEmp = NEmp.HorariosRecuperar(Me.cadenaConex)
        emp.Horario = ""
        lstEmp.Add(emp)
        For Each item In lstEmp
            Txt_FiltroHorario.AutoCompleteCustomSource.Add(item.Horario)
        Next
    End Sub
    Private Sub RellenarTxtDptos()
        Dim lstEmp As New LEmpleado()
        Dim NEmp As New NEmpleado()
        Dim emp As New Empleado()
        Dim fi As Date = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
        Dim conex As New conexion
        Dim cadConex As String

        If Me.ip = "172.16" Then
            cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008
        Else
            cadConex = conex.conexion2008For
        End If

        lstEmp = NEmp.DptosRecuperar(cadConex, fi)
        emp.Departamento = ""
        lstEmp.Add(emp)
        For Each item In lstEmp
            Txt_FiltroDpto.AutoCompleteCustomSource.Add(item.Departamento)
        Next
    End Sub
    Private Sub RellenarTxtEmpl(ByVal lstEmp As LEmpleado)
        For Each item In lstEmp
            Txt_FiltroNombre.AutoCompleteCustomSource.Add(item.NombreCompleto)
        Next
    End Sub
#End Region
#Region "Rellena objetos"
    Private Function RellenaObjetoEmpleado() As LEmpleado
        Dim lstEmp As New LEmpleado()
        Dim fila As Integer, coun As Integer = 0, colum As Integer
        Dim fecha As Date
        Dim c As String
        Dim totalFilas As Integer = Dgv_ListaPrenomina.Rows.Count()
        For fila = 0 To totalFilas - 1
            With Dgv_ListaPrenomina.Rows(fila)
                Dim modif As Object = .Cells("manual").Value
                fecha = Lbl_Dia1.Text + "/" + Lbl_año.Text
                If modif = "M" Then
                    For colum = 1 To 7
                        c = "manual" + Convert.ToString(colum) + ""
                        If .Cells(c).Value = "M" Then
                            Dim objEmp As New Empleado()
                            Dim ce As String = "entrada" + Convert.ToString(colum) + ""
                            Dim cs As String = "salida" + Convert.ToString(colum) + ""
                            objEmp.IdEmpleado = .Cells("idEmpleado").Value
                            objEmp.Incidencia1 = .Cells(ce).Value
                            Select Case objEmp.Incidencia1
                                Case "FL"
                                    objEmp.TipoIncidencia1 = "HE"
                                Case "RET"
                                    objEmp.TipoIncidencia1 = "HE"
                                Case "RT"
                                    objEmp.TipoIncidencia1 = "HE"
                                Case "PS"
                                    objEmp.TipoIncidencia1 = "HE"
                                Case "PM"
                                    objEmp.TipoIncidencia1 = "A"
                                Case "F"
                                    objEmp.TipoIncidencia1 = "A"
                                Case "PCS"
                                    objEmp.TipoIncidencia1 = "A"
                                Case "PSS"
                                    objEmp.TipoIncidencia1 = "A"
                                Case "FJ"
                                    objEmp.TipoIncidencia1 = "A"
                                Case "SUS"
                                    objEmp.TipoIncidencia1 = "A"
                                Case "SHU"
                                    objEmp.TipoIncidencia1 = "A"
                                Case "OMI"
                                    objEmp.TipoIncidencia1 = "A"
                                Case "DT"
                                    objEmp.TipoIncidencia1 = "HE"
                                Case Else
                                    objEmp.TipoIncidencia1 = "CH"
                            End Select
                            objEmp.Incidencia2 = .Cells(cs).Value
                            Select Case objEmp.Incidencia2
                                Case "FL"
                                    objEmp.TipoIncidencia2 = "HE"
                                Case "RET"
                                    objEmp.TipoIncidencia2 = "HE"
                                Case "RT"
                                    objEmp.TipoIncidencia2 = "HE"
                                Case "PS"
                                    objEmp.TipoIncidencia2 = "HE"
                                Case "PM"
                                    objEmp.TipoIncidencia2 = "A"
                                Case "F"
                                    objEmp.TipoIncidencia2 = "A"
                                Case "PCS"
                                    objEmp.TipoIncidencia2 = "A"
                                Case "PSS"
                                    objEmp.TipoIncidencia2 = "A"
                                Case "FJ"
                                    objEmp.TipoIncidencia2 = "A"
                                Case "SUS"
                                    objEmp.TipoIncidencia2 = "A"
                                Case "SHU"
                                    objEmp.TipoIncidencia1 = "A"
                                Case "OMI"
                                    objEmp.TipoIncidencia1 = "A"
                                Case "DT"
                                    objEmp.TipoIncidencia2 = "HE"
                                Case Else
                                    objEmp.TipoIncidencia2 = "CH"
                            End Select
                            objEmp.Fecha1 = DateAdd(DateInterval.Day, colum - 1, fecha)
                            objEmp.HoraEntrada = .Cells("E").Value
                            objEmp.HoraSalida = .Cells("S").Value
                            objEmp.IdTurno = .Cells("idTurno").Value
                            coun = coun + 1
                            lstEmp.Add(objEmp)
                        End If
                    Next
                End If
            End With
        Next
        Return lstEmp
    End Function
    Private Function RellenaObjetoEmpleadoMotivoRetardo(ByVal fila As Integer, ByVal colum As String, ByVal u As Integer) As Empleado
        Dim fecha As Date
        Dim objEmp As New Empleado()
        With Dgv_ListaPrenomina.Rows(fila)
            Dim modif As Object = .Cells("manual").Value
            fecha = Lbl_Dia1.Text + "/" + Lbl_año.Text

            objEmp.IdEmpleado = .Cells("idEmpleado").Value
            objEmp.Fecha1 = DateAdd(DateInterval.Day, u - 1, fecha)
            objEmp.Nota0 = .Cells(colum).Value
            objEmp.IdTurno = .Cells("idTurno").Value
        End With
        Return objEmp
    End Function
    Private Function RellenaObjetoBono() As LBono
        Dim lstBono As New LBono()
        Dim fila As Integer, totalFilas As Integer = Dgv_ListaPrenomina.Rows.Count()
        For fila = 0 To totalFilas - 2
            With Dgv_ListaPrenomina.Rows(fila)
                Dim modif As Object = .Cells("modificaBono").Value
                If modif = "M" Then
                    Dim objBono As New Bono()
                    objBono.IdEmpleado = .Cells("idEmpleado").Value
                    objBono.Semana = Cmb_Semanas.Text
                    objBono.Año = Lbl_año.Text
                    objBono.Comentario = .Cells("comentarios").Value
                    objBono.ComentarioExt = .Cells("comentariosExt").Value
                    objBono.Bono = .Cells("aplicaBono").Value
                    objBono.IdModif = .Cells("idModificaBono").Value
                    lstBono.Add(objBono)
                End If
            End With
        Next
        Return lstBono
    End Function
#End Region
#Region "Otros Procesos"
    Private Sub ProcesoPrenomina(ByVal lstEmp As LEmpleado, ByVal fecha As Date, ByVal semana As Integer, ByVal año As Integer)
        lstEmp = RecuperarEmpleados(fecha, semana, año)
        If lstEmp(0).Err = False Then
            RellenaChecadasDgvPrenomina(lstEmp)
            RecuperarIncidencias()
            RellenaChecadasExpatriadosMazda()
            If lstEmp(0).Año = 0 And lstEmp(0).Semana = 0 Then
                CalcularBono()
            End If
            Me.rec = "M"
            'Btn_Excel.Visible = True
            Txt_FiltroId.Enabled = True
            Txt_FiltroNombre.Enabled = True
            Txt_FiltroHorario.Enabled = True
            Txt_FiltroDpto.Enabled = True
            RellenarTxtEmpl(lstEmp)
            RellenarTxtHorario()
            RellenarTxtDptos()
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
    Private Sub ColorearCeldas(ByVal valor As Object, ByVal fila As Integer, ByVal columna As String)
        Dim cb As Color
        Dim cf As Color
        Select Case valor
            Case "BAJA"
                cb = Color.FromArgb(64, 64, 0)
                cf = Color.White
            Case "DT"
                cb = Color.LightSlateGray
                cf = Color.White
            Case "FL"
                cb = Color.Plum
                cf = Color.Black
            Case "Ret"
                cb = Color.White
                cf = Color.Red
            Case "RT"
                cb = Color.White
                cf = Color.Red
            Case "PS"
                cb = Color.White
                cf = Color.Red
            Case "PM"
                cb = Color.SteelBlue
                cf = Color.Black
            Case "F"
                cb = Color.Red
                cf = Color.Black
            Case "PCS"
                cb = Color.Yellow
                cf = Color.Black
            Case "PSS"
                cb = Color.Yellow
                cf = Color.Red
            Case "FJ"
                cb = Color.Red
                cf = Color.Orange
            Case "SUS"
                cb = Color.Red
                cf = Color.Orange
            Case "D"
                cb = Color.Black
                cf = Color.White
            Case "HO"
                cb = Color.GreenYellow
                cf = Color.Navy
            Case "VUL"
                cb = Color.GreenYellow
                cf = Color.Black
            Case "CC"
                cb = Color.GreenYellow
                cf = Color.OrangeRed
            Case "SO"
                cb = Color.GreenYellow
                cf = Color.OrangeRed
            Case "CF"
                cb = Color.GreenYellow
                cf = Color.Red
            Case "SHU"
                cb = Color.Yellow
                cf = Color.Black
            Case "OMI"
                cb = Color.Beige
                cf = Color.Black
            Case ""
                cb = Color.Gray
                cf = Color.Black
            Case Else
                cb = Color.Green
                cf = Color.White
        End Select

        Dgv_ListaPrenomina.Rows(fila).Cells(columna).Style.BackColor = cb
        Dgv_ListaPrenomina.Rows(fila).Cells(columna).Style.ForeColor = cf
    End Sub
    Private Function CambiarTipoIncidenciaA(ByVal lstEmp As LEmpleado) As LEmpleado
        For Each item In lstEmp
            Select Case item.Incidencia1
                Case "PM"
                    item.Incidencia1 = "B"
                Case "F"
                    item.Incidencia1 = "F"
                Case "PCS"
                    item.Incidencia1 = "G"
                Case "PSS"
                    item.Incidencia1 = "P"
                Case "FJ"
                    item.Incidencia1 = "U"
                Case "SUS"
                    item.Incidencia1 = "N"
                Case "HO"
                    item.Incidencia1 = "H"
                Case "VUL"
                    item.Incidencia1 = "D"
                Case "CC"
                    item.Incidencia1 = "K"
                Case "SO"
                    item.Incidencia1 = "O"
                Case "CF"
                    item.Incidencia1 = "J"
                Case "SHU"
                    item.Incidencia1 = "Z"
                Case "OMI"
                    item.Incidencia1 = "I"
            End Select
            Select Case item.Incidencia2
                Case "PM"
                    item.Incidencia1 = "B"
                Case "F"
                    item.Incidencia1 = "F"
                Case "PCS"
                    item.Incidencia1 = "G"
                Case "PSS"
                    item.Incidencia1 = "P"
                Case "FJ"
                    item.Incidencia1 = "U"
                Case "SUS"
                    item.Incidencia1 = "N"
                Case "HO"
                    item.Incidencia1 = "H"
                Case "VUL"
                    item.Incidencia1 = "D"
                Case "CC"
                    item.Incidencia1 = "K"
                Case "SO"
                    item.Incidencia1 = "O"
                Case "CF"
                    item.Incidencia1 = "J"
                Case "SHU"
                    item.Incidencia1 = "Z"
                Case "OMI"
                    item.Incidencia1 = "I"
            End Select
        Next
        Return lstEmp
    End Function
    Private Function CambiarTipoIncidenciaHE(ByVal lstEmp As LEmpleado) As LEmpleado
        For Each item In lstEmp
            Select Case item.Incidencia1
                Case "PS"
                    item.Incidencia1 = "P"
                Case "RT"
                    item.Incidencia1 = "R"
                Case "RET"
                    item.Incidencia1 = "R"
                Case "FL"
                    item.Incidencia1 = "F"
            End Select
            Select Case item.Incidencia2
                Case "PS"
                    item.Incidencia1 = "P"
                Case "RT"
                    item.Incidencia1 = "R"
                Case "RET"
                    item.Incidencia1 = "R"
                Case "FL"
                    item.Incidencia1 = "F"
            End Select
        Next
        Return lstEmp
    End Function
    Private Sub CalcularBono()
        Dim fila As Integer
        Dim totalFila As Integer = Dgv_ListaPrenomina.Rows.Count()
        Dim tof As Integer
        Dim fi As Date = Lbl_Dia1.Text & "/" & Lbl_año.Text, ff As Date = Lbl_Dia5.Text & "/" & Lbl_año.Text, f As Date = fi
        For fila = 0 To totalFila - 1
            Dim bono As Integer = 0
            With Dgv_ListaPrenomina.Rows(fila)
                If .Cells("idTurno").Value = 4 Or .Cells("idTurno").Value = 5 Or .Cells("idTurno").Value = 6 Then tof = 5
                If .Cells("idTurno").Value = 1 Or .Cells("idTurno").Value = 2 Or .Cells("idTurno").Value = 3 Then tof = 6
                For column = 1 To tof
                    Dim ce As String = "entrada" + Convert.ToString(column) + ""
                    Dim cs As String = "salida" + Convert.ToString(column) + ""
                    Dim valorE = (.Cells(ce).Value)
                    Dim valorS = (.Cells(cs).Value)
                    Dim valorEO = Format(DateAdd(DateInterval.Minute, 3, .Cells("E").Value), "HH:mm")
                    Dim valorSO = Format(Convert.ToDateTime(.Cells("S").Value), "HH:mm")
                    Dim b As String = "b" & column 'Aquí se guarda la justifiación de retardo o falta
                    Dim mr As String = .Cells(b).Value 'Movimiento de justificación de retardo o falta
                    Dim valor As Integer
                    Dim fIng As Date = .Cells("ingreso").Value
                    .Cells("modificaBono").Value = "M"
                    .Cells("idModificaBono").Value = "0"
                    valor = BuscarDiasFestivo(column, .Cells("idEmpleado").Value)
                    f = DateAdd(DateInterval.Day, (column - 1), fi)
                    If valor = 1 Then
                        bono += 1
                    Else
                        If (valorE IsNot Nothing And valorS IsNot Nothing) And (IsDate(.Cells(ce).FormattedValue) And IsDate(.Cells(cs).FormattedValue)) Then
                            If ((valorE <= valorEO) Or (f = fIng)) And (valorS >= valorSO) Then
                                bono += 1
                            Else
                                If mr = "1" Or mr = "2" Or mr = "3" Or mr = "4" Then
                                    bono += 1
                                End If
                            End If
                        Else
                            If (valorE IsNot Nothing And valorS IsNot Nothing) And
                                ((valorE = "D" Or valorE = "DT" Or valorE = "PM" Or valorE = "PCS" Or valorE Like "M-DT" Or valorE Like "J-DT" Or
                                valorE = "VAC" Or valorE = "HO") Or
                                (valorS = "D" Or valorS = "DT" Or valorS = "PM" Or valorS = "PCS" Or valorS Like "M-DT" Or valorS Like "J-DT" Or
                                valorS = "VAC" Or valorS = "HO")) Then
                                bono += 1
                            ElseIf (valorE Is Nothing Or valorS Is Nothing) Or
                                ((valorE = "F" Or valorE = "FJ" Or valorE = "PSS" Or valorE Like "M-SUS" Or valorE Like "PS" Or valorE = "RET" Or
                                valorE = "RT" Or valorE = "VUL" Or valorE = "CC" Or valorE = "SO" Or valorE = "CF") Or
                                (valorS = "F" Or valorS = "FJ" Or valorS = "PSS" Or valorS Like "M-SUS" Or valorS Like "PS" Or valorS = "RET" Or
                                valorE = "RT" Or valorS = "VUL" Or valorS = "CC" Or valorS = "SO" Or valorS = "CF")) Or ((fi >= fIng) Or (ff <= fIng)) Then
                                If (mr = "1" Or mr = "2" Or mr = "3" Or mr = "4") Then
                                    bono += 1
                                ElseIf ((((fIng >= fi) And (fIng <= ff)) And (f <= fIng)) And
                                ((valorE <> "F" And valorE <> "FJ" And valorE <> "PSS" And valorE <> "M-SUS" And valorE <> "PS" And valorE <> "RET" And
                                valorE <> "RT" Or valorE <> "VUL" Or valorE <> "CC" Or valorE <> "SO" Or valorE <> "CF") And
                                (valorS <> "F" And valorS <> "FJ" And valorS <> "PSS" And valorS <> "M-SUS" And valorS <> "PS" And valorS <> "RET" And
                                valorE <> "RT" Or valorS <> "VUL" Or valorS <> "CC" Or valorS <> "SO" Or valorS = "CF"))) Then
                                    bono += 1
                                End If
                            End If
                        End If
                    End If
                Next
                If .Cells("idTurno").Value = 4 Or .Cells("idTurno").Value = 5 Or .Cells("idTurno").Value = 6 Then
                    If bono = 5 Then .Cells("aplicaBono").Value = True
                ElseIf .Cells("idTurno").Value = 1 Or .Cells("idTurno").Value = 2 Or .Cells("idTurno").Value = 3 Then
                    If bono = 6 Then .Cells("aplicaBono").Value = True
                Else
                    If bono = 6 Or bono = 5 Then .Cells("aplicaBono").Value = True
                End If
            End With
        Next
        Btn_GuardarBono.Enabled = True
    End Sub
    Private Sub CalcularBonoIndividual(ByVal fila As Integer)
        Dim totalFila As Integer = Dgv_ListaPrenomina.Rows.Count()
        Dim tof As Integer
        Dim bono As Integer = 0

        With Dgv_ListaPrenomina.Rows(fila)
            If .Cells("idTurno").Value = 4 Or .Cells("idTurno").Value = 5 Or .Cells("idTurno").Value = 6 Or .Cells("idTurno").Value = 10 Then tof = 5
            If .Cells("idTurno").Value = 1 Or .Cells("idTurno").Value = 2 Or .Cells("idTurno").Value = 3 Then tof = 6
            If .Cells("idTurno").Value = 7 Or .Cells("idTurno").Value = 8 Then tof = 4
            For column = 1 To tof
                Dim ce As String = "entrada" + Convert.ToString(column) + ""
                Dim cs As String = "salida" + Convert.ToString(column) + ""
                Dim valorE = (.Cells(ce).Value)
                Dim valorS = (.Cells(cs).Value)
                Dim valorEO = Format(DateAdd(DateInterval.Minute, 3, .Cells("E").Value), "HH:mm")
                Dim valorSO = Format(Convert.ToDateTime(.Cells("S").Value), "HH:mm")
                Dim b As String = "b" & column
                Dim mr As String = .Cells(b).Value
                .Cells("modificaBono").Value = "M"
                .Cells("idModificaBono").Value = "0"
                If (valorE IsNot Nothing And valorS IsNot Nothing) And (IsDate(.Cells(ce).FormattedValue) And IsDate(.Cells(cs).FormattedValue)) Then
                    If (valorE <= valorEO) And (valorS >= valorSO) Then
                        bono += 1
                    Else
                        If mr = "1" Or mr = "2" Or mr = "3" Or mr = "4" Then
                            bono += 1
                        End If
                    End If
                Else
                    If (valorE IsNot Nothing And valorS IsNot Nothing) And
                            ((valorE = "D" Or valorE = "DT" Or valorE = "PM" Or valorE Like "M-DT" Or valorE Like "J-DT" Or valorE = "VAC") Or
                            (valorS = "D" Or valorS = "DT" Or valorS = "PM" Or valorS Like "M-DT" Or valorS Like "J-DT" Or valorS = "VAC")) Then
                        bono += 1
                    ElseIf (valorE Is Nothing Or valorS Is Nothing) Or
                            ((valorE = "F" Or valorE = "FJ" Or valorE = "PCS" Or valorE = "PSS" Or valorE Like "M-SUS" Or valorE Like "PS" Or valorE = "RET" Or
                            valorE = "RT") Or
                            (valorS = "F" Or valorS = "FJ" Or valorS = "PCS" Or valorS = "PSS" Or valorS Like "M-SUS" Or valorS Like "PS" Or valorS = "RET" Or
                            valorE = "RT")) Then
                        If mr = "1" Or mr = "2" Or mr = "3" Or mr = "4" Then
                            bono += 1
                        End If
                    End If
                End If
            Next
            If .Cells("idTurno").Value = 4 Or .Cells("idTurno").Value = 5 Or .Cells("idTurno").Value = 6 Then
                If bono = 5 Then .Cells("aplicaBono").Value = True
            ElseIf .Cells("idTurno").Value = 1 Or .Cells("idTurno").Value = 2 Or .Cells("idTurno").Value = 3 Then
                If bono = 6 Then .Cells("aplicaBono").Value = True
            End If
        End With
        Btn_GuardarBono.Enabled = True
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
    Private Sub CrearExcel()
        'Me.Cursor = Cursors.WaitCursor
        Try
            ' Creamos todo lo necesario para un excel
            Dim appXL As Excel.Application
            Dim wbXl As Excel.Workbook
            Dim shXL As Excel.Worksheet
            Dim f As Integer = 2
            Dim lstEmp As New LEmpleado()
            Dim NEmp As New NEmpleado()
            Dim conex As New conexion()
            Dim cadenaConex
            Dim cadConex As String

            If Me.ip = "172.16" Then
                cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008
            Else
                cadConex = conex.conexion2008For
            End If
            appXL = CreateObject("Excel.Application")
            appXL.Visible = False 'Para que no se muestre mientras se crea
            wbXl = appXL.Workbooks.Add
            shXL = wbXl.ActiveSheet
            ' Añadimos las cabeceras de las columnas con formato en negrita
            'Dim formatRange As Excel.Range
            'formatRange = shXL.Range("a1       formatRange.EntireRow.Font.Bold = True")
            shXL.Cells(1, 1).Value = "Código"
            shXL.Cells(1, 2).Value = "Fecha de alta"
            shXL.Cells(1, 3).Value = "Fecha de baja"
            shXL.Cells(1, 4).Value = "Fecha de reingreso"
            shXL.Cells(1, 5).Value = "Tipo de contrato"
            shXL.Cells(1, 6).Value = "Apellido paterno"
            shXL.Cells(1, 7).Value = "Apellido materno"
            shXL.Cells(1, 8).Value = "Nombre"
            shXL.Cells(1, 9).Value = "Tipo de periodo"
            shXL.Cells(1, 10).Value = "Salario diario"
            shXL.Cells(1, 11).Value = "SBC parte fija"
            shXL.Cells(1, 12).Value = "Base de cotización"
            shXL.Cells(1, 13).Value = "Estatus empleado"
            shXL.Cells(1, 14).Value = "Departamento"
            shXL.Cells(1, 15).Value = "Sindicalizado"
            shXL.Cells(1, 16).Value = "Base de pago"
            shXL.Cells(1, 17).Value = "Método de pago"
            shXL.Cells(1, 18).Value = "Turno de trabajo"
            shXL.Cells(1, 19).Value = "Zona de salario"
            shXL.Cells(1, 20).Value = "Campo extra 1"
            shXL.Cells(1, 21).Value = "Campo extra 2"
            shXL.Cells(1, 22).Value = "Campo extra 3"
            shXL.Cells(1, 23).Value = "Afore"
            shXL.Cells(1, 24).Value = "Expediente"
            shXL.Cells(1, 25).Value = "Num seguridad social"
            shXL.Cells(1, 26).Value = "RFC"
            shXL.Cells(1, 27).Value = "CURP"
            shXL.Cells(1, 28).Value = "Sexo"
            shXL.Cells(1, 29).Value = "Ciudad de nacimiento"
            shXL.Cells(1, 30).Value = "Fecha de nacimiento"
            shXL.Cells(1, 31).Value = "UMF"
            shXL.Cells(1, 32).Value = "Nombre del padre"
            shXL.Cells(1, 33).Value = "Nombre de la madre"
            shXL.Cells(1, 34).Value = "Dirección"
            shXL.Cells(1, 35).Value = "Puesto"
            shXL.Cells(1, 36).Value = "Población"
            shXL.Cells(1, 37).Value = "Entidad federativa de domicilio"
            shXL.Cells(1, 38).Value = "CP"
            shXL.Cells(1, 39).Value = "Estado Civil"
            shXL.Cells(1, 40).Value = "Teléfono"
            shXL.Cells(1, 41).Value = "Aviso pendiente modificación SBC"
            shXL.Cells(1, 42).Value = "Aviso pendiente reingreso IMSS"
            shXL.Cells(1, 43).Value = "Aviso pendiente baja IMSS"
            shXL.Cells(1, 44).Value = "Aviso pendiente cambio base cotización"
            shXL.Cells(1, 45).Value = "Fecha del salario diario"
            shXL.Cells(1, 46).Value = "Fecha SBC parte fija"
            shXL.Cells(1, 47).Value = "Salario variable"
            shXL.Cells(1, 48).Value = "Fecha salario variable"
            shXL.Cells(1, 49).Value = "Salario promedio"
            shXL.Cells(1, 50).Value = "Fecha salario promedio"
            shXL.Cells(1, 51).Value = "Salario base liquidación"
            shXL.Cells(1, 52).Value = "Saldo del ajuste al neto"
            shXL.Cells(1, 53).Value = "Cálculo PTU"
            shXL.Cells(1, 54).Value = "Cálculo aguinaldo"
            shXL.Cells(1, 55).Value = "Banco para pago electrónico"
            shXL.Cells(1, 56).Value = "Numero de cuenta para pago electrónico"
            shXL.Cells(1, 57).Value = "Sucursal para pago electrónico"
            shXL.Cells(1, 58).Value = "Causa de la última baja"
            shXL.Cells(1, 59).Value = "Campo extra numérico 1"
            shXL.Cells(1, 60).Value = "Campo extra numérico 2"
            shXL.Cells(1, 61).Value = "Campo extra numérico 3"
            shXL.Cells(1, 62).Value = "Campo extra numérico 4"
            shXL.Cells(1, 63).Value = "Campo extra numérico 5"
            shXL.Cells(1, 64).Value = "Fecha salario mixto"
            shXL.Cells(1, 65).Value = "Salario mixto"
            shXL.Cells(1, 66).Value = "Registro patronal del IMSS"
            shXL.Cells(1, 67).Value = "Número FONACOT"
            shXL.Cells(1, 68).Value = "Correo electrónico"
            shXL.Cells(1, 69).Value = "Tipo de régimen"
            shXL.Cells(1, 70).Value = "CLABE interbancaria"
            shXL.Cells(1, 71).Value = "Entidad federativa de nacimiento"
            shXL.Cells(1, 72).Value = "Tipo de prestación"
            shXL.Cells(1, 73).Value = "Extranjero sin CURP"
            lstEmp = NEmp.RecuperarEmpleadosExportar(cadConex, (Lbl_Dia1.Text & "/" & Lbl_año.Text), (lbl_Dia7.Text & "/" & Lbl_año.Text))

            If lstEmp.Count > 0 Then
                For Each item In lstEmp
                    shXL.Cells(f, 1).Value = "'" & item.IdEmpleado
                    shXL.Cells(f, 2).Value = "'" & Format(item.Fecha1, "dd/MM/yyyy")
                    shXL.Cells(f, 3).Value = "30/12/1899"
                    shXL.Cells(f, 4).Value = "30/12/1899"
                    shXL.Cells(f, 5).Value = "'03"
                    shXL.Cells(f, 6).Value = item.ApellidoPaterno
                    shXL.Cells(f, 7).Value = item.ApellidoMaterno
                    shXL.Cells(f, 8).Value = item.Nombres
                    shXL.Cells(f, 9).Value = "Semanal"
                    shXL.Cells(f, 10).Value = item.SueldoDiario
                    shXL.Cells(f, 11).Value = item.SueldoBase
                    shXL.Cells(f, 12).Value = "M"
                    shXL.Cells(f, 13).Value = "A"
                    shXL.Cells(f, 14).Value = item.Departamento '"Departamento"
                    shXL.Cells(f, 15).Value = item.EdoSindical '"Sindicalizado"
                    shXL.Cells(f, 16).Value = "S"
                    shXL.Cells(f, 17).Value = "'03"
                    shXL.Cells(f, 18).Value = item.Turno '"Matutino"
                    shXL.Cells(f, 19).Value = "B"
                    shXL.Cells(f, 20).Value = ""
                    shXL.Cells(f, 21).Value = ""
                    shXL.Cells(f, 22).Value = ""
                    shXL.Cells(f, 23).Value = ""
                    shXL.Cells(f, 24).Value = ""
                    shXL.Cells(f, 25).Value = "'" & item.Nss '"Num seguridad social"
                    shXL.Cells(f, 26).Value = item.Rfc '"RFC"
                    shXL.Cells(f, 27).Value = item.Curp '"CURP"
                    shXL.Cells(f, 28).Value = item.Sexo '"Sexo"
                    shXL.Cells(f, 29).Value = item.Ciudad '"Ciudad de nacimiento"
                    shXL.Cells(f, 30).Value = "'" & Format(item.FechaNac, "dd/MM/yyyy") '"Fecha de nacimiento"
                    shXL.Cells(f, 31).Value = "'0"
                    shXL.Cells(f, 32).Value = item.Padre '"Nombre del padre"
                    shXL.Cells(f, 33).Value = item.Madre '"Nombre de la madre"
                    shXL.Cells(f, 34).Value = item.Domicilio '"Dirección"
                    shXL.Cells(f, 35).Value = item.Puesto '"Puesto"
                    shXL.Cells(f, 36).Value = item.Municipio '"Población"
                    shXL.Cells(f, 37).Value = item.EntidadFed '"Entidad federativa de domicilio"
                    shXL.Cells(f, 38).Value = item.CodigoPostal '"CP"
                    shXL.Cells(f, 39).Value = item.EdoCivil '"Estado Civil"
                    shXL.Cells(f, 40).Value = item.Telefono '"Teléfono"
                    shXL.Cells(f, 41).Value = "'0"
                    shXL.Cells(f, 42).Value = "1"
                    shXL.Cells(f, 43).Value = "'0"
                    shXL.Cells(f, 44).Value = "'0"
                    shXL.Cells(f, 45).Value = "'" & Format(item.Fecha1, "dd/MM/yyyy") '"Fecha del salario diario"
                    shXL.Cells(f, 46).Value = "'" & Format(item.Fecha1, "dd/MM/yyyy") '"Fecha SBC parte fija"
                    shXL.Cells(f, 47).Value = "'0"
                    shXL.Cells(f, 48).Value = "'" & Format(item.Fecha1, "dd/MM/yyyy") '"Fecha salario variable"
                    shXL.Cells(f, 49).Value = "'0"
                    shXL.Cells(f, 50).Value = "'" & Format(item.Fecha1, "dd/MM/yyyy") '"Fecha salario promedio"
                    shXL.Cells(f, 51).Value = "'0"
                    shXL.Cells(f, 52).Value = "'0"
                    shXL.Cells(f, 53).Value = "1"
                    shXL.Cells(f, 54).Value = "1"
                    shXL.Cells(f, 55).Value = "'072"
                    shXL.Cells(f, 56).Value = ""
                    shXL.Cells(f, 57).Value = "7004"
                    shXL.Cells(f, 58).Value = ""
                    shXL.Cells(f, 59).Value = "'0"
                    shXL.Cells(f, 60).Value = "'0"
                    shXL.Cells(f, 61).Value = "'0"
                    shXL.Cells(f, 62).Value = "'0"
                    shXL.Cells(f, 63).Value = "'" & item.Extras '"Campo extra numérico 5"
                    shXL.Cells(f, 64).Value = "'" & Format(item.Fecha1, "dd/MM/yyyy") '"Fecha salario mixto"
                    shXL.Cells(f, 65).Value = "'0"
                    shXL.Cells(f, 66).Value = "B5717519108"
                    shXL.Cells(f, 67).Value = "'0"
                    shXL.Cells(f, 68).Value = item.EMail '"Correo electrónico"
                    shXL.Cells(f, 69).Value = "'02"
                    shXL.Cells(f, 70).Value = "'000000000000000000"
                    shXL.Cells(f, 71).Value = item.EntidadFedNac '"Entidad federativa de nacimiento"
                    shXL.Cells(f, 72).Value = "Confianza"
                    shXL.Cells(f, 73).Value = "'0"
                    f += 1
                Next
                ' Mostramos un dialog para que el usuario indique donde quiere guardar el excel
                Dim saveFileDialog1 As New SaveFileDialog()
                saveFileDialog1.Title = "Guardar documento Excel"
                saveFileDialog1.Filter = "Excel File|*.xlsx"
                saveFileDialog1.FileName = "Empleados"
                saveFileDialog1.ShowDialog()
                ' Guardamos el excel en la ruta que ha especificado el usuario
                wbXl.SaveAs(saveFileDialog1.FileName)
                ' Cerramos el workbook
                appXL.Workbooks.Close()
            Else
                MsgBox("No hay registros nuevos")
            End If
            ' Eliminamos el objeto excel
            appXL.Quit()

        Catch ex As Exception
            MessageBox.Show("Errorxportar los datos a excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Me.Cursor = Cursors.Arrow
        End Try
    End Sub
    Private Sub Almacenar()
        Try
            'Dim mes As String = mesLetra()
            Dim ds As New Dts_PrenominaLista
            Dim dtw As DataRow

            For i As Integer = 0 To Dgv_ListaPrenomina.Rows.Count - 2
                dtw = ds.Dtb_PrenominaListado.NewRow()
                If Dgv_ListaPrenomina.Rows(i).Visible = True Then
                    'dtw("Id") = Dgv_ListaPrenomina.Item(0, i).Value
                    dtw("Id") = Dgv_ListaPrenomina.Rows(i).Cells("idEmpleado").Value
                    dtw("Nombre") = Dgv_ListaPrenomina.Rows(i).Cells("nombreEmpleado").Value
                    dtw("Horario") = Dgv_ListaPrenomina.Rows(i).Cells("horarioEmpleado").Value
                    dtw("Departamento") = Dgv_ListaPrenomina.Rows(i).Cells("departamentoEmpleado").Value
                    dtw("E1") = Dgv_ListaPrenomina.Rows(i).Cells("entrada1").Value
                    dtw("S1") = Dgv_ListaPrenomina.Rows(i).Cells("salida1").Value
                    dtw("M1") = Dgv_ListaPrenomina.Rows(i).Cells("mnl1").Value
                    dtw("E2") = Dgv_ListaPrenomina.Rows(i).Cells("entrada2").Value
                    dtw("S2") = Dgv_ListaPrenomina.Rows(i).Cells("salida2").Value
                    dtw("M2") = Dgv_ListaPrenomina.Rows(i).Cells("mnl2").Value
                    dtw("E3") = Dgv_ListaPrenomina.Rows(i).Cells("entrada3").Value
                    dtw("S3") = Dgv_ListaPrenomina.Rows(i).Cells("salida3").Value
                    dtw("M3") = Dgv_ListaPrenomina.Rows(i).Cells("mnl3").Value
                    dtw("E4") = Dgv_ListaPrenomina.Rows(i).Cells("entrada4").Value
                    dtw("S4") = Dgv_ListaPrenomina.Rows(i).Cells("salida4").Value
                    dtw("M4") = Dgv_ListaPrenomina.Rows(i).Cells("mnl4").Value
                    dtw("E5") = Dgv_ListaPrenomina.Rows(i).Cells("entrada5").Value
                    dtw("S5") = Dgv_ListaPrenomina.Rows(i).Cells("salida5").Value
                    dtw("M5") = Dgv_ListaPrenomina.Rows(i).Cells("mnl5").Value
                    dtw("E6") = Dgv_ListaPrenomina.Rows(i).Cells("entrada6").Value
                    dtw("S6") = Dgv_ListaPrenomina.Rows(i).Cells("salida6").Value
                    dtw("M6") = Dgv_ListaPrenomina.Rows(i).Cells("mnl6").Value
                    dtw("E7") = Dgv_ListaPrenomina.Rows(i).Cells("entrada7").Value
                    dtw("S7") = Dgv_ListaPrenomina.Rows(i).Cells("salida7").Value
                    dtw("M7") = Dgv_ListaPrenomina.Rows(i).Cells("mnl7").Value
                    dtw("Comentarios") = Dgv_ListaPrenomina.Rows(i).Cells("comentarios").Value
                    dtw("AplicaBono") = Dgv_ListaPrenomina.Rows(i).Cells("aplicaBono").Value
                    dtw("Lun") = Lbl_Dia1.Text
                    dtw("Mar") = Lbl_Dia2.Text
                    dtw("Mier") = Lbl_Dia3.Text
                    dtw("Jue") = Lbl_Dia4.Text
                    dtw("Vie") = Lbl_Dia5.Text
                    dtw("Sab") = lbl_Dia6.Text
                    dtw("Dom") = lbl_Dia7.Text
                    'dtw("TP") = Dgv_ListaPrenomina.Rows(i).Cells("tp").Value
                    ds.Dtb_PrenominaListado.Rows.Add(dtw)
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
        Frm_ReportePrenominaLista.ReportViewer1.LocalReport.DataSources.Clear()
        Frm_ReportePrenominaLista.ReportViewer1.LocalReport.DataSources.Add(fuente)
        Frm_ReportePrenominaLista.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Rpt_PrenominaListado.rdlc" 'exactamente como se llaman el proyecto y reporte
        Frm_ReportePrenominaLista.Show()
    End Sub
    Private Sub ProcesoGuardarBono()
        Dim NPre As New NPrenomina()
        Dim lstBono As New LBono()
        Dim cadConex As String
        Dim conex As New conexion()


        If Me.ip = "172.16" Then
            cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008
        Else
            cadConex = conex.conexion2008For
        End If
        lstBono = RellenaObjetoBono()
        NPre.InsertarBonoPuntualidad(cadConex, lstBono)
    End Sub
    Private Function BuscarDiasFestivo(ByVal vuelta As Integer, ByVal idEmp As Integer) As Integer
        Dim fecha As Date
        Dim dia As Integer, mes As Integer, año As Integer, valor As Integer
        Dim NPren As New NPrenomina()
        Dim conex As New conexion()
        Dim cadConex As String

        If Me.ip = "172.16" Then
            cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008
        Else
            cadConex = conex.conexion2008For
        End If
        Select Case vuelta
            Case 1
                fecha = Lbl_Dia1.Text
                año = Lbl_año.Text
                mes = Month(fecha)
                dia = Convert.ToInt16(Format(fecha, "dd"))
                valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, 1, 2)
                Return valor
            Case 2
                fecha = Lbl_Dia2.Text
                año = Lbl_año.Text
                mes = Month(fecha)
                dia = Convert.ToInt16(Format(fecha, "dd"))
                valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, 1, 2)
                Return valor
            Case 3
                fecha = Lbl_Dia3.Text
                año = Lbl_año.Text
                mes = Month(fecha)
                dia = Convert.ToInt16(Format(fecha, "dd"))
                valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, 1, 2)
                Return valor
            Case 4
                fecha = Lbl_Dia4.Text
                año = Lbl_año.Text
                mes = Month(fecha)
                dia = Convert.ToInt16(Format(fecha, "dd"))
                valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, 1, 2)
                Return valor
            Case 5
                fecha = Lbl_Dia5.Text
                año = Lbl_año.Text
                mes = Month(fecha)
                dia = Convert.ToInt16(Format(fecha, "dd"))
                valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, 1, 2)
                Return valor
            Case 6
                fecha = lbl_Dia6.Text
                año = Lbl_año.Text
                mes = Month(fecha)
                dia = Convert.ToInt16(Format(fecha, "dd"))
                valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, 1, 2)
                Return valor
            Case 7
                fecha = lbl_Dia7.Text
                año = Lbl_año.Text
                mes = Month(fecha)
                dia = Convert.ToInt16(Format(fecha, "dd"))
                valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, 1, 2)
                Return valor
            Case Else
                Return valor = 0
        End Select
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub


    Private Function RecuperarDatoInc(ByVal dato As String) As String
        Select Case dato
            Case "FALTA" : Return "F"
            Case "FALTA JUSTIFICADA" : Return "FJ"
            Case "SUSPENCIÓN" : Return "SUS"
            Case "RETARDO" : Return "R"
            Case "SALIDA ANTICIPADA" : Return "PS"
            Case "SIN CHECADAS" : Return "SC"
            Case "PERMISO SIN GOCE" : Return "PSS"
            Case "PERMISO CON GOCE" : Return "PCS"
            Case "INCAPACIDAD" : Return "INC"
            Case "BAJA" : Return "BAJA"
            Case "HOME OFFICE" : Return "HO"
            Case "EMPLEADO VULNERABLE" : Return "VUL"
            Case "CONSULTA SOSPECHA" : Return "CC"
            Case "SOSPECHOSO ENFERMEDAD" : Return "SO"
            Case "CONFIRMADO" : Return "CF"
            Case "SHUTDOWN" : Return "SHU"
            Case "SIN CHECADA" : Return "OMI"
            Case Else : Return ""
        End Select
    End Function
    Private Function Horarios(ByVal turno As Integer, ByVal evento As String) As Date
        Select Case evento
            Case "Entrada"
                Select Case turno
                    Case 1 : Return "06:55:00"
                    Case 2 : Return "15:25:00"
                    Case 3 : Return "23:25:00"
                    Case 4 : Return "08:00:00"
                    Case 5 : Return "07:44:00"
                    Case 6 : Return "20:20:00"
                    Case 7 : Return "07:00:00"
                    Case 8 : Return "19:00:00"
                    Case 10 : Return "07:00:00"
                    Case Else : Return "00:00:00"
                End Select
            Case "Salida"
                Select Case turno
                    Case 1 : Return "15:25:00"
                    Case 2 : Return "23:25:00"
                    Case 3 : Return "07:00:00"
                    Case 4 : Return "17:00:00"
                    Case 5 : Return "18:21:00"
                    Case 6 : Return "06:21:00"
                    Case 7 : Return "19:15:00"
                    Case 8 : Return "07:15:00"
                    Case 10 : Return "16:00:00"

                    Case Else : Return "00:00:00"
                End Select
            Case Else : Return "00:00:00"
        End Select
    End Function
#End Region
End Class