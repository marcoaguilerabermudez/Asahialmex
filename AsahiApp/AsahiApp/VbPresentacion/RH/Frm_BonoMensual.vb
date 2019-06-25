Imports System.Data.SqlClient
Imports Negocio
Imports Clases
Public Class Frm_BonoMensual
#Region "Variables de clase"
    Dim cadConex As SqlConnection
    Dim cadenaConex As String
    Dim open As Boolean
    Dim ud As Integer
    Dim da As String
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_BonoMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_año.Text = Format(DateTime.Now, "yyyy")
        Dgv_BonoMensual.Columns("nombreEmpleado").Frozen = True
        ModificarDiaInicio()
    End Sub
    Private Sub Dtp_FechaInicioSemana_TextChanged(sender As Object, e As EventArgs) Handles Dtp_FechaInicioSemana.TextChanged
        If Dtp_FechaInicioSemana.Value < DateTime.Now Or Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyy") = Format(DateTime.Now, "dd/MM/yyy") Then

            Dim conex As New conexion
            Dim cadenaConexContpaq = conex.conexionContpaq 'Conexion a la BD de contpaq solo se va a usar para traer las fechas que corresponden la semana que se manda
            Dim fechaI As Date = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            Dim NPrenomina As New NPrenomina()
            Dim hrs As New Horarios()
            Dim fecha As Date

            Lbl_año.Text = Format(fechaI, "yyyy")

            hrs = NPrenomina.RecuperarDiasSemana(cadenaConexContpaq, fechaI)
            If Me.ud > 0 Then
                Dtp_FechaInicioSemana.Value = Format(DateSerial(Year(Dtp_FechaInicioSemana.Value), Month(Dtp_FechaInicioSemana.Value) + 1, 0), "dd/MM/yyyy")
                fecha = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
                Me.da = Format(fecha, "dd")
                Me.ud = Convert.ToInt32(Me.da)
                If Me.ud < 31 Then
                    If Me.ud >= 28 Then
                        For r = Me.ud To 31
                            If r > Me.ud Then
                                Dim ce As String = "entrada" & r
                                Dim cs As String = "salida" & r
                                Dgv_BonoMensual.Columns(ce).Visible = False
                                Dgv_BonoMensual.Columns(cs).Visible = False
                            End If
                        Next
                    End If
                ElseIf Me.ud <= 31 And Dgv_BonoMensual.Columns("entrada31").Visible = False Then
                    If Me.ud >= 28 Then
                        For r = Me.ud To 31
                            If r <= Me.ud Then
                                If Dgv_BonoMensual.Columns("entrada29").Visible = False And Dgv_BonoMensual.Columns("entrada30").Visible = False Then r = 29
                                If Dgv_BonoMensual.Columns("entrada29").Visible = True And Dgv_BonoMensual.Columns("entrada30").Visible = False And r <> 30 Then r = 30
                                Dim ce As String = "entrada" & r
                                Dim cs As String = "salida" & r
                                Dgv_BonoMensual.Columns(ce).Visible = True
                                Dgv_BonoMensual.Columns(cs).Visible = True
                            End If
                        Next
                    End If
                End If
            End If
            Me.ud = 1
            Me.open = True
        Else
            MsgBox("Tienes que ingresar una fecha menor a la actual")
            ModificarDiaInicio()
            Dgv_BonoMensual.DataSource = Nothing
            Dgv_BonoMensual.Refresh()
        End If
    End Sub
    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click
        If open = True Then
            Dim fecha As Date
            Dim lstEmp As New LEmpleado

            fecha = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            ProcesoBonoMensual(lstEmp, fecha)
        End If
    End Sub
#End Region
#Region "Rellena Formulario"
    Private Sub RellenaChecadasDgvGlobalPrenomina(ByVal lstEmp As LEmpleado)
        Dim fila As Integer = 0
        Dgv_BonoMensual.DataSource = Nothing
        Dgv_BonoMensual.Rows.Clear()
        For Each item In lstEmp
            Dgv_BonoMensual.Rows.Add()
            Dgv_BonoMensual.RowsDefaultCellStyle.BackColor = Color.LightGray
            With Dgv_BonoMensual.Rows(fila)
                .Height = 30
                .Cells("idEmpleado").Value = item.IdEmpleado
                .Cells("idEmpleado").Style.BackColor = Color.White
                item.NombreCompleto = item.Nombres
                If item.ApellidoPaterno <> "x" Or item.ApellidoPaterno <> "X" Or item.ApellidoPaterno <> "" Then item.NombreCompleto = item.NombreCompleto & " " & item.ApellidoPaterno
                If item.ApellidoMaterno <> "x" Or item.ApellidoMaterno <> "X" Or item.ApellidoMaterno <> "" Then item.NombreCompleto = item.NombreCompleto & " " & item.ApellidoMaterno
                .Cells("nombreEmpleado").Value = item.NombreCompleto
                .Cells("nombreEmpleado").Style.BackColor = Color.White
                .Cells("fechaIngreso").Value = Format(item.FechaIngreso, "dd/MM/yyyy")
                .Cells("fechaIngreso").Style.BackColor = Color.White
                .Cells("departamento").Value = item.Departamento
                .Cells("departamento").Style.BackColor = Color.White
                .Cells("puesto").Value = item.Puesto
                .Cells("puesto").Style.BackColor = Color.White

                If item.TP = "B" Then
                    .Cells("idEmpleado").Style.BackColor = Color.FromArgb(64, 64, 0)
                    .Cells("idEmpleado").Style.ForeColor = Color.White
                    .Cells("nombreEmpleado").Style.BackColor = Color.FromArgb(64, 64, 0)
                    .Cells("nombreEmpleado").Style.ForeColor = Color.White
                    .Cells("fechaIngreso").Style.BackColor = Color.FromArgb(64, 64, 0)
                    .Cells("fechaIngreso").Style.ForeColor = Color.White
                    .Cells("departamento").Style.BackColor = Color.FromArgb(64, 64, 0)
                    .Cells("departamento").Style.ForeColor = Color.White
                    .Cells("puesto").Style.BackColor = Color.FromArgb(64, 64, 0)
                    .Cells("puesto").Style.ForeColor = Color.White
                End If

                .Cells("retardo").Value = "00:00"
                .Cells("falta").Value = 0
                .Cells("faltaJustificada").Value = 0
                .Cells("suspension").Value = 0
                .Cells("permisoSinSueldo").Value = 0
                .Cells("permisoConSueldo").Value = 0
                .Cells("permisoMatrimonio").Value = 0
                .Cells("incapacidad").Value = 0
                .Cells("vacaciones").Value = 0
            End With
            fila += 1
        Next
    End Sub
    Private Sub RellenaIncidencias(ByVal lstAus As LAusentismo, ByVal lstVac As LVacaciones, ByVal lstInc As LIncapacidad, ByVal lstHE As LHorasExtra)
        Dim fecha As Date = Format(DateSerial(Year(Dtp_FechaInicioSemana.Value), Month(Dtp_FechaInicioSemana.Value), 1), "dd/MM/yyyy") 'Dtp_FechaInicioSemana.Value
        Dim totalFilas As Integer = Dgv_BonoMensual.Rows.Count()

        RellenaIncapacidad(lstInc, fecha, totalFilas)
        RellenaVacaciones(lstVac, fecha, totalFilas)
        RellenaAusentismo(lstAus, fecha, totalFilas)
        RellenarHrsExtraDTRet(lstHE, fecha, totalFilas)
        'RellenaDescanso(totalFilas, fecha)
    End Sub
    Private Sub RellenaIncapacidad(ByVal lstInc As LIncapacidad, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim fila As Integer, dur As Integer, idEmp As Integer, colum As Integer
        Dim fechaI As Date, fechaF As Date, fechaIM As Date, fechaFM As Date, fi As Date, fechaC As Date
        Dim inc As String = "INC"

        fechaIM = fecha
        fechaFM = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
        For Each item In lstInc
            fechaI = item.FechaI
            fechaF = item.FechaF
            If fechaF >= fechaIM And fechaI <= fechaFM Then
                For fila = 0 To totalFilas - 1
                    idEmp = Dgv_BonoMensual.Rows(fila).Cells("idEmpleado").Value
                    If item.IdEmpleado = idEmp Then
                        fi = fechaI
                        For dur = 1 To item.Duracion
                            For colum = 1 To Me.da
                                fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                                If fechaI <= fechaFM Then
                                    If fi = fechaC Then
                                        Dim ce As String = "entrada" & colum
                                        Dim cs As String = "salida" & colum
                                        With Dgv_BonoMensual.Rows(fila)
                                            .Cells(ce).Value = inc
                                            .Cells(ce).Style.BackColor = Color.SteelBlue
                                            .Cells(ce).Style.ForeColor = Color.White

                                            .Cells(cs).Value = inc
                                            .Cells(cs).Style.BackColor = Color.SteelBlue
                                            .Cells(cs).Style.ForeColor = Color.White

                                            .Cells("incapacidad").Value = .Cells("incapacidad").Value + 1
                                            .Cells("incapacidad").Style.BackColor = Color.White
                                        End With
                                    End If
                                End If
                            Next
                            fi = Format(DateAdd(DateInterval.Day, 1, fi), "dd/MM/yyyy")
                        Next
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub RellenaVacaciones(ByVal lstVac As LVacaciones, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim fila As Integer, dur As Integer, idEmp As Integer, colum As Integer
        Dim fechaI As Date, fechaF As Date, fechaIM As Date, fechaFM As Date, fi As Date, fechaC As Date
        Dim inc As String = "VAC"

        fechaIM = fecha
        fechaFM = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
        For Each item In lstVac
            fechaI = item.FechaI
            fechaF = item.FechaF
            If fechaF >= fechaIM And fechaI <= fechaFM Then
                For fila = 0 To totalFilas - 1
                    idEmp = Dgv_BonoMensual.Rows(fila).Cells("idEmpleado").Value
                    If item.IdEmpleado = idEmp Then
                        fi = fechaI
                        For dur = 1 To item.Duracion
                            For colum = 1 To Me.da
                                fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                                If fechaI <= fechaFM Then
                                    If fi = fechaC Then
                                        Dim ce As String = "entrada" & colum
                                        Dim cs As String = "salida" & colum
                                        With Dgv_BonoMensual.Rows(fila)
                                            .Cells(ce).Value = inc
                                            .Cells(ce).Style.BackColor = Color.DodgerBlue
                                            .Cells(ce).Style.ForeColor = Color.White

                                            .Cells(cs).Value = inc
                                            .Cells(cs).Style.BackColor = Color.DodgerBlue
                                            .Cells(cs).Style.ForeColor = Color.White

                                            .Cells("vacaciones").Value = .Cells("vacaciones").Value + 1
                                            .Cells("vacaciones").Style.BackColor = Color.White
                                        End With
                                    End If
                                End If
                            Next
                            fi = Format(DateAdd(DateInterval.Day, 1, fi), "dd/MM/yyyy")
                        Next
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub RellenaAusentismo(ByVal lstAus As LAusentismo, ByVal fecha As Date, ByVal totalfilas As Integer)
        Dim fila As Integer, dur As Integer, idEmp As Integer, colum As Integer
        Dim fechaI As Date, fechaF As Date, fechaIM As Date, fechaFM As Date, fi As Date, fechaC As Date
        Dim inc As String, tip As String, yy As String
        Dim cb As Color, cf As Color

        fechaIM = fecha
        fechaFM = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
        For Each item In lstAus
            For fila = 0 To totalfilas - 1
                idEmp = Dgv_BonoMensual.Rows(fila).Cells("idEmpleado").Value
                If item.IdEmpleado = idEmp Then
                    fechaI = item.FechaI
                    fechaF = item.FechaF
                    tip = item.TipoAusentismo

                    Select Case tip
                        Case "B", "B "
                            yy = "permisoMatrimonio"
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
                    fi = fechaI
                    For dur = 1 To item.Duracion
                        For colum = 1 To Me.da
                            fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                            If fechaI <= fechaFM Then
                                If fi = fechaC Then
                                    Dim ce As String = "entrada" & colum
                                    Dim cs As String = "salida" & colum
                                    With Dgv_BonoMensual.Rows(fila)
                                        .Cells(ce).Value = inc
                                        .Cells(ce).Style.BackColor = cb
                                        .Cells(ce).Style.ForeColor = cf

                                        .Cells(cs).Value = inc
                                        .Cells(cs).Style.BackColor = cb
                                        .Cells(cs).Style.ForeColor = cf

                                        .Cells(yy).Value = .Cells(yy).Value + 1
                                        .Cells(yy).Style.BackColor = Color.White
                                    End With
                                End If
                            End If
                        Next
                        fi = Format(DateAdd(DateInterval.Day, 1, fi), "dd/MM/yyyy")
                    Next
                End If
            Next
        Next
    End Sub
    Private Sub RellenarHrsExtraDTRet(ByVal lstHE As LHorasExtra, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim util As New conexion()
        Dim fila As Integer, idEmp As Integer, colum As Integer
        Dim fechaI As Date, fechaC As Date
        Dim inc As String, tp As String
        Dim tm, tmc
        For Each item In lstHE
            tp = item.TipoPermiso
            If tp <> "4" Then
                For fila = 0 To totalFilas - 1
                    With Dgv_BonoMensual.Rows(fila)
                        idEmp = .Cells("idEmpleado").Value
                        If item.IdEmpleado = idEmp Then
                            inc = item.Tipo
                            fechaI = item.Fecha
                            tm = util.ConvertirMinutosAHoras(item.Autorizado)
                            If inc = "R" Then
                                inc = "Ret"
                                For colum = 1 To Me.da
                                    fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                                    If fechaI = fechaC Then
                                        Dim ce As String = "entrada" & colum
                                        Dim cs As String = "salida" & colum
                                        If .Cells(ce).Value = "" Then
                                            .Cells(ce).Value = inc
                                            .Cells(ce).Style.ForeColor = Color.Red
                                            .Cells(ce).Style.BackColor = Color.White
                                        Else
                                            .Cells(ce).Style.ForeColor = Color.Red
                                        End If
                                    End If
                                Next
                                tmc = .Cells("retardo").Value
                                .Cells("retardo").Value = Convert.ToDateTime(Format(tmc, "HH:mm")) + Convert.ToDateTime(Format(tm, "HH:mm"))
                                .Cells("retardo").Style.BackColor = Color.White
                            ElseIf inc = "PS" Then
                                inc = "PS"
                                For colum = 1 To Me.da
                                    fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                                    If fechaI = fechaC Then
                                        Dim ce As String = "entrada" & colum
                                        Dim cs As String = "salida" & colum
                                        If .Cells(cs).Value = "" Then
                                            .Cells(cs).Value = inc
                                            .Cells(cs).Style.ForeColor = Color.Red
                                            .Cells(cs).Style.BackColor = Color.White
                                        Else
                                            .Cells(cs).Style.ForeColor = Color.Red
                                        End If
                                    End If
                                Next
                                tmc = Convert.ToDateTime(Format(.Cells("retardo").Value, "HH:mm"))
                                .Cells("retardo").Value = Convert.ToDateTime(Format(tmc, "HH:mm")) + Convert.ToDateTime(Format(tm, "HH:mm"))
                                .Cells("retardo").Style.BackColor = Color.White
                            End If
                        End If
                    End With
                Next
            End If
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
        Dim lstAus As New LAusentismo(), lstVac As New LVacaciones(), lstInc As New LIncapacidad(), lstHE As New LHorasExtra()
        Dim NPre As New NPrenomina()
        Dim fechaI As Date
        Dim fechaF As Date
        Dim conex As New conexion
        Dim cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008

        fechaF = Dtp_FechaInicioSemana.Value
        fechaI = Format(DateSerial(Year(fechaF), Month(fechaF), 1), "dd/MM/yyyy")

        lstAus = NPre.RecuperarAusentismo(cadConex, fechaI, fechaF)
        lstVac = NPre.RecuperarVacaciones(cadConex, DateAdd(DateInterval.Day, -10, fechaI), DateAdd(DateInterval.Day, 10, fechaF))
        lstInc = NPre.RecuperarIncapacidades(cadConex)
        lstHE = NPre.RecuperarHorasExtra(cadConex, fechaI, fechaF)
        RellenaIncidencias(lstAus, lstVac, lstInc, lstHE)
    End Sub
#End Region
#Region "Procesos Varios"
    Private Sub ProcesoBonoMensual(ByVal lstEmp As LEmpleado, ByVal fecha As Date)
        lstEmp = RecuperarEmpleados(fecha)
        If lstEmp(0).Err = False Then
            RellenaChecadasDgvGlobalPrenomina(lstEmp)
            RecuperarIncidencias()
        End If
    End Sub
    Private Sub ModificarDiaInicio()
        Dim fecha As Date
        Dim dia As String

        dia = DateTime.Now

        fecha = Format(DateSerial(Year(dia), Month(dia) + 0, 0), "dd/MM/yyyy")
        Me.da = Format(fecha, "dd")
        Me.ud = 0
        Dtp_FechaInicioSemana.Value = fecha
    End Sub
#End Region
End Class