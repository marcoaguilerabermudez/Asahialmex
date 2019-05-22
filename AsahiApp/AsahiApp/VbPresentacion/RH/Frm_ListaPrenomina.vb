Imports System.Windows.Forms
Imports System.Data.SqlClient
'Imports System.Threading
Imports System.Diagnostics
'Imports System.ComponentModel
Imports Clases
Imports Negocio
Imports CsPresentacion
Public Class Frm_ListaPrenomina
#Region "Variables de Clase"
    Dim cadenaConex As SqlConnection
    Dim open As Boolean
    'Dim super As Thread
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

            'ModificarDiaInicio()
            fecha = Lbl_Dia1.Text & "/" & Lbl_año.Text
            ProcesoPrenomina(lstEmp, fecha)
        End If
    End Sub
    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click
        If open = True Then
            Dim fecha As Date
            Dim lstEmp As New LEmpleado

            ModificarDiaInicio()
            fecha = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            ProcesoPrenomina(lstEmp, fecha)
        End If
    End Sub
    Private Sub Bgw_HiloSeundoPlano_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Bgw_HiloSeundoPlano.DoWork

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
        Dim cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008

        Return NPre.EmpleadosRecuperar(cadConex, fecha)
    End Function
    Private Sub RecuperarIncidencias()
        Dim lstAus As New LAusentismo, lstVac As New LVacaciones, lstInc As New LIncapacidad, lstHE As New LHorasExtra, lstBja As New LBaja
        Dim fechaI As Date
        Dim fechaF As Date
        Dim conex As New conexion
        Dim cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008

        fechaI = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
        fechaF = Format(DateAdd(DateInterval.Day, 6, fechaI), "dd/MM/yyyy")

        lstAus = RecuperarAusentismo(cadConex, fechaI, fechaF)
        lstVac = RecuperarVacaciones(cadConex, DateAdd(DateInterval.Day, -10, fechaI), DateAdd(DateInterval.Day, 10, fechaF))
        lstInc = RecuperarIncapacidades(cadConex)
        lstHE = RecuperarHorasExtra(cadConex, fechaI, fechaF)
        lstBja = RecuperarBajas(cadConex, fechaI, fechaF)
        RellenaIncidenciasDgvPrenomina(lstAus, lstVac, lstInc, lstHE, lstBja)
    End Sub
    Private Function RecuperarAusentismo(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LAusentismo
        Dim NPre As New NPrenomina()
        Return NPre.RecuperarAusentismo(cadConex, fechaI, fechaF)
    End Function
    Private Function RecuperarVacaciones(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LVacaciones
        Dim NPre As New NPrenomina()
        Return NPre.RecuperarVacaciones(cadConex, fechaI, fechaF)
    End Function
    Private Function RecuperarIncapacidades(ByVal cadConex As String) As LIncapacidad
        Dim NPre As New NPrenomina()
        Return NPre.RecuperarIncapacidades(cadConex)
    End Function
    Public Function RecuperarHorasExtra(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LHorasExtra
        Dim NPre As New NPrenomina()
        Return NPre.RecuperarHorasExtra(cadConex, fechaI, fechaF)
    End Function
    Public Function RecuperarBajas(ByVal cadConex As String, ByVal fechaI As Date, ByVal fechaF As Date) As LBaja
        Dim NPre As New NPrenomina()
        Return NPre.RecuperarBajas(cadConex, fechaI, fechaF)
    End Function
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
            If item.HoraEntradaReal1 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Value = Format(item.HoraEntradaReal1, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Style.BackColor = Color.White
                If item.HoraEntrada < item.HoraEntradaReal1 Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada1").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal1 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Value = Format(item.HoraSalidaReal1, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Style.BackColor = Color.White
                If item.HoraSalida > item.HoraSalidaReal1 Then Dgv_ListaPrenomina.Rows(fila).Cells("salida1").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal2 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Value = Format(item.HoraEntradaReal2, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Style.BackColor = Color.White
                If item.HoraEntrada < item.HoraEntradaReal2 Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada2").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal2 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Value = Format(item.HoraSalidaReal2, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Style.BackColor = Color.White
                If item.HoraSalida > item.HoraSalidaReal2 Then Dgv_ListaPrenomina.Rows(fila).Cells("salida2").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal3 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Value = Format(item.HoraEntradaReal3, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Style.BackColor = Color.White
                If item.HoraEntrada < item.HoraEntradaReal3 Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada3").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal3 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Value = Format(item.HoraSalidaReal3, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Style.BackColor = Color.White
                If item.HoraSalida > item.HoraSalidaReal3 Then Dgv_ListaPrenomina.Rows(fila).Cells("salida3").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal4 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Value = Format(item.HoraEntradaReal4, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Style.BackColor = Color.White
                If item.HoraEntrada < item.HoraEntradaReal4 Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada4").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal4 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Value = Format(item.HoraSalidaReal4, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Style.BackColor = Color.White
                If item.HoraSalida > item.HoraSalidaReal4 Then Dgv_ListaPrenomina.Rows(fila).Cells("salida4").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal5 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Value = Format(item.HoraEntradaReal5, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Style.BackColor = Color.White
                If item.HoraEntrada < item.HoraEntradaReal5 Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada5").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal5 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Value = Format(item.HoraSalidaReal5, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Style.BackColor = Color.White
                If item.HoraSalida > item.HoraSalidaReal5 Then Dgv_ListaPrenomina.Rows(fila).Cells("salida5").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal6 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Value = Format(item.HoraEntradaReal6, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Style.BackColor = Color.White
                If (item.HoraEntrada < item.HoraEntradaReal6) And item.IdTurno <> 4 Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada6").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal6 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Value = Format(item.HoraSalidaReal6, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Style.BackColor = Color.White
                If (item.HoraSalida > item.HoraSalidaReal6) And item.IdTurno <> 4 Then Dgv_ListaPrenomina.Rows(fila).Cells("salida6").Style.ForeColor = Color.Red
            End If
            If item.HoraEntradaReal7 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Value = Format(item.HoraEntradaReal7, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.BackColor = Color.White
                If (item.HoraEntrada < item.HoraEntradaReal7) And item.IdTurno <> 4 Then Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.ForeColor = Color.Red
            End If
            If item.HoraSalidaReal7 <> "1/1/1900 12:00:00 AM" Then
                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Value = Format(item.HoraSalidaReal7, "HH:mm")
                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.BackColor = Color.White
                If (item.HoraSalida > item.HoraSalidaReal7) And item.IdTurno <> 4 Then Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.ForeColor = Color.Red
            End If
            Dgv_ListaPrenomina.Rows(fila).Cells("comentarios").Style.BackColor = Color.White
            Dgv_ListaPrenomina.Rows(fila).Cells("bonoEmpleado").Style.BackColor = Color.White
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
    Private Sub RellenaIncidenciasDgvPrenomina(ByVal lstAus As LAusentismo, ByVal lstVac As LVacaciones, ByVal lstInc As LIncapacidad,
                                               ByVal lstHE As LHorasExtra, lstBja As LBaja)

        Dim fecha As Date = Format((Lbl_Dia1.Text + "/" + Lbl_año.Text))
        Dim totalFilas As Integer = Dgv_ListaPrenomina.Rows.Count()

        RellenaBajas(lstBja, fecha, totalFilas)
        RellenaIncapacidad(lstInc, fecha, totalFilas)
        RellenaVacaciones(lstVac, fecha, totalFilas)
        RellenarHrsExtraDTFeriadoRet(lstHE, fecha, totalFilas)
        RellenaAusentismo(lstAus, fecha, totalFilas)
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
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
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
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
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
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
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
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
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
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
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
                                Else
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                End If
                                If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.FromArgb(64, 64, 0)
                                    Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
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
                            Else
                                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.BackColor = Color.FromArgb(64, 64, 0)
                                Dgv_ListaPrenomina.Rows(fila).Cells("entrada7").Style.ForeColor = Color.White
                            End If
                            If Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Value = "" Then
                                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Value = inc
                                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.BackColor = Color.FromArgb(64, 64, 0)
                                Dgv_ListaPrenomina.Rows(fila).Cells("salida7").Style.ForeColor = Color.White
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
                                    Else
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.SteelBlue
                                    End If
                                    If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.SteelBlue
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
                                    Else
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.DodgerBlue
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.ForeColor = Color.White
                                    End If
                                    If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.DodgerBlue
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = Color.White
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
                                    ElseIf Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "BAJA" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Value = "F/B"
                                    Else
                                        Dgv_ListaPrenomina.Rows(fila).Cells(ce).Style.BackColor = Color.Orange
                                    End If
                                    If Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = inc
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = cb
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.ForeColor = cf
                                    ElseIf Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "BAJA" Then
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Value = "F/B"
                                    Else
                                        Dgv_ListaPrenomina.Rows(fila).Cells(cs).Style.BackColor = Color.Orange
                                    End If
                                End If
                            End If
                        Next
                    Next
                End If
            Next
        Next
    End Sub
#End Region
#Region "Otros Procesos"
    Private Sub ProcesoPrenomina(ByVal lstEmp As LEmpleado, ByVal fecha As Date)
        lstEmp = RecuperarEmpleados(fecha)
        If lstEmp(0).Err = False Then
            RellenaChecadasDgvPrenomina(lstEmp)
            RecuperarIncidencias()
            Btn_Mostrar.Visible = False
        ElseIf lstEmp(0).Err = True Then
            If Btn_Mostrar.Visible = False Then Btn_Mostrar.Visible = True
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
#End Region
End Class