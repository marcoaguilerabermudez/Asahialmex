Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Clases
Imports Negocio
Imports CsPresentacion
Public Class Frm_ListaPrenomina
#Region "Variables de Clase"
    Dim cadenaConex As SqlConnection
    Dim open As Boolean
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal cadenaConex As SqlConnection)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
    End Sub
#End Region
#Region "Eventos del fomulario"
    Private Sub Frm_Prenomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dgv_ListaPrenomina.Enabled = False
            MsgBox("Tienes que ingresar una fecha menor a la actual")
            Dgv_ListaPrenomina.DataSource = Nothing
            Dgv_ListaPrenomina.Refresh()
        End If
    End Sub
    Private Sub CmbSemanas_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbSemanas.SelectedValueChanged
        If open = True Then
            Dim fecha As Date
            Dim lstEmp As New LEmpleado

            ModificarDiaInicio()
            fecha = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            lstEmp = RecuperarEmpleados(fecha)

            RellenaDgvPrenomina(lstEmp)
            Btn_Mostrar.Visible = False
        End If
    End Sub
    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click
        If open = True Then
            Dim fecha As Date
            Dim lstEmp As New LEmpleado

            ModificarDiaInicio()
            fecha = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            lstEmp = RecuperarEmpleados(fecha)

            RellenaDgvPrenomina(lstEmp)
            Btn_Mostrar.Visible = False
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
        Dim NPre As New NPrenomina
        Dim conex As New conexion
        Dim oCon = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008

        Return NPre.EmpleadosRecuperar(oCon, fecha)
    End Function
#End Region
#Region "Rellena formulario"
    Private Sub RellenaDgvPrenomina(ByVal lstEmp As LEmpleado)
        Dim fila As Integer = 0
        Dgv_ListaPrenomina.DataSource = Nothing
        Dgv_ListaPrenomina.Refresh()
        For Each item In lstEmp
            Dgv_ListaPrenomina.Rows.Add()
            Dgv_ListaPrenomina.Rows(fila).Cells("idEmpleado").Value = item.IdEmpleado
            item.NombreCompleto = item.Nombres
            If item.ApellidoPaterno <> "x" Or item.ApellidoPaterno <> "X" Or item.ApellidoPaterno <> "" Then item.NombreCompleto = item.NombreCompleto & " " & item.ApellidoPaterno
            If item.ApellidoMaterno <> "x" Or item.ApellidoMaterno <> "X" Or item.ApellidoMaterno <> "" Then item.NombreCompleto = item.NombreCompleto & " " & item.ApellidoMaterno
            Dgv_ListaPrenomina.Rows(fila).Cells("nombreEmpleado").Value = item.NombreCompleto
            Dgv_ListaPrenomina.Rows(fila).Cells("horarioEmpleado").Value = item.Turno
            Dgv_ListaPrenomina.Rows(fila).Cells("departamentoEmpleado").Value = item.Departamento
            If item.HoraEntradaReal1 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Value = Format(item.HoraEntradaReal1, "hh:mm")
            If item.HoraSalidaReal1 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Value = Format(item.HoraSalidaReal1, "hh:mm")
            If item.HoraEntradaReal2 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Value = Format(item.HoraEntradaReal2, "hh:mm")
            If item.HoraSalidaReal2 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Value = Format(item.HoraSalidaReal2, "hh:mm")
            If item.HoraEntradaReal3 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Value = Format(item.HoraEntradaReal3, "hh:mm")
            If item.HoraSalidaReal3 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Value = Format(item.HoraSalidaReal3, "hh:mm")
            If item.HoraEntradaReal4 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Value = Format(item.HoraEntradaReal4, "hh:mm")
            If item.HoraSalidaReal4 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Value = Format(item.HoraSalidaReal4, "hh:mm")
            If item.HoraEntradaReal5 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Value = Format(item.HoraEntradaReal5, "hh:mm")
            If item.HoraSalidaReal5 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Value = Format(item.HoraSalidaReal5, "hh:mm")
            If item.HoraEntradaReal6 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Value = Format(item.HoraEntradaReal6, "hh:mm")
            If item.HoraSalidaReal6 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Value = Format(item.HoraSalidaReal6, "hh:mm")
            If item.HoraEntradaReal7 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Value = Format(item.HoraEntradaReal7, "hh:mm")
            If item.HoraSalidaReal7 <> "1/1/1900 12:00:00 AM" Then Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Value = Format(item.HoraSalidaReal7, "hh:mm")
            If item.TipoRegistro1 = "M" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Style.BackColor = Color.Green
                Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Style.BackColor = Color.Green
            End If
            If item.TipoRegistro2 = "M" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Style.BackColor = Color.Green
                Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Style.BackColor = Color.Green
            End If
            If item.TipoRegistro3 = "M" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Style.BackColor = Color.Green
                Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Style.BackColor = Color.Green
            End If
            If item.TipoRegistro4 = "M" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Style.BackColor = Color.Green
                Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Style.BackColor = Color.Green
            End If
            If item.TipoRegistro5 = "M" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Style.BackColor = Color.Green
                Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Style.BackColor = Color.Green
            End If
            If item.TipoRegistro6 = "M" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Style.BackColor = Color.Green
                Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Style.BackColor = Color.Green
            End If
            If item.TipoRegistro7 = "M" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.BackColor = Color.Green
                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.ForeColor = Color.White
                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.BackColor = Color.Green
            End If
            fila += 1
        Next
        Dgv_ListaPrenomina.Enabled = True
    End Sub
#End Region
#Region "Otros Procesos"
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
#End Region
End Class