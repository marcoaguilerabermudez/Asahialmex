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
    Dim valor As String
    Dim mes As Integer
    Dim rec As Boolean = False
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

            Btn_Acumulado.Visible = False
            Dgv_BonoMensual.DataSource = Nothing
            Dgv_BonoMensual.Rows.Clear()

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
            Dim lstEmp As New LEmpleado(), NPre As New NPrenomina(), conex As New conexion()
            Dim cadConex = conex.conexion2008

            Me.mes = NPre.VerificarUltimoMesCalculado(cadConex)
            fecha = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
            ProcesoBonoMensual(lstEmp, fecha)
            If rec = False Then
                Btn_Acumulado.Visible = True
                Btn_Acumulado.Enabled = True
            End If
        End If
    End Sub
    Private Sub Dgv_BonoMensual_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_BonoMensual.CellEnter
        Dim fila As Integer
        Dim columna As String
        fila = Dgv_BonoMensual.CurrentRow.Index
        columna = Dgv_BonoMensual.Columns(e.ColumnIndex).Name
        If columna = "premio" Then
            'If Dgv_BonoMensual.Rows(fila).Cells(columna).Value <> "SI" And Dgv_BonoMensual.Rows(fila).Cells(columna).Value <> "NO" Then
            Me.valor = Dgv_BonoMensual.Rows(fila).Cells(columna).Value
            'End If
        End If
    End Sub
    Private Sub Dgv_BonoMensual_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_BonoMensual.CellEndEdit
        Dim fila As Integer
        Dim columna As String
        fila = Dgv_BonoMensual.CurrentRow.Index
        columna = Dgv_BonoMensual.Columns(e.ColumnIndex).Name
        If columna = "premio" Then
            With Dgv_BonoMensual.Rows(fila)
                .Cells(columna).Value = UCase(.Cells(columna).Value)
                If .Cells(columna).Value = "SI" Then
                    .Cells(columna).Style.BackColor = Color.White
                    .Cells("bono").Value = "O"
                    .Cells("bono").Style.BackColor = Color.LawnGreen
                ElseIf .Cells(columna).Value = "NO" Then
                    .Cells(columna).Style.BackColor = Color.LightGray
                    .Cells("bono").Value = "X"
                    .Cells("bono").Style.BackColor = Color.White
                Else
                    .Cells(columna).Value = Me.valor
                End If
            End With
        End If
    End Sub
    Private Sub Btn_Acumulado_Click(sender As Object, e As EventArgs) Handles Btn_Acumulado.Click
        ProcesoAcumulado()
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
                .Cells("turno").Value = item.IdTurno
                .Cells("turno").Style.BackColor = Color.White

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

                .Cells("retardo").Value = 0
                .Cells("falta").Value = 0
                .Cells("faltaJustificada").Value = 0
                .Cells("suspension").Value = 0
                .Cells("permisoSinSueldo").Value = 0
                .Cells("permisoConSueldo").Value = 0
                .Cells("permisoMatrimonio").Value = 0
                .Cells("incapacidad").Value = 0
                .Cells("vacaciones").Value = 0
                .Cells("x").Value = 0
                .Cells("rtt").Value = 0
            End With
            fila += 1
        Next
    End Sub
    Private Sub RellenaIncidencias(ByVal lstAus As LAusentismo, ByVal lstVac As LVacaciones, ByVal lstInc As LIncapacidad, ByVal lstHE As LHorasExtra,
                                   ByVal lstCH As LHorarios)
        Dim fecha As Date = Format(DateSerial(Year(Dtp_FechaInicioSemana.Value), Month(Dtp_FechaInicioSemana.Value), 1), "dd/MM/yyyy") 'Dtp_FechaInicioSemana.Value
        Dim totalFilas As Integer = Dgv_BonoMensual.Rows.Count()

        RellenaIncapacidad(lstInc, fecha, totalFilas)
        RellenaVacaciones(lstVac, fecha, totalFilas)
        RellenaAusentismo(lstAus, fecha, totalFilas)
        RellenarHrsExtraDTRet(lstHE, fecha, totalFilas)
        RellenaDescanso(fecha, totalFilas)
        RellenaHoras(lstCH, fecha, totalFilas)
        CalcularBono(totalFilas)
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
                            tm = item.Autorizado
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
                                .Cells("retardo").Value = tmc + tm
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
                                tmc = .Cells("retardo").Value
                                .Cells("retardo").Value = tmc + tm
                                .Cells("retardo").Style.BackColor = Color.White
                            End If
                        End If
                    End With
                Next
            End If
        Next
    End Sub
    Private Sub RellenaDescanso(ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim util As New conexion()
        Dim fila As Integer, tur As Integer, idEmp As Integer, colum As Integer
        Dim diaSem As String
        Dim fe As Date, fechaC As Date, fechaFM As Date

        fechaFM = Format(Dtp_FechaInicioSemana.Value, "dd/MM/yyyy")
        For fila = 0 To totalFilas - 2
            Dgv_BonoMensual.Columns("x").DefaultCellStyle.Format = "N2"
            With Dgv_BonoMensual.Rows(fila)
                fe = .Cells("fechaIngreso").Value
                tur = .Cells("turno").Value
                .Cells("x").Value = .Cells("falta").Value + .Cells("faltaJustificada").Value + .Cells("suspension").Value + .Cells("permisoMatrimonio").Value + .Cells("incapacidad").Value + .Cells("permisoSinSueldo").Value + (.Cells("retardo").Value / 1440) + .Cells("rtt").Value
                If .Cells("x").Value <> 0.00 Then .Cells("x").Style.BackColor = Color.White
                If .Cells("x").Value <> 0.00 Then .Cells("x").Style.ForeColor = Color.Red

                If fe >= DateAdd(DateInterval.Day, 10, fecha) Then
                    .Cells("x").Value = 100 + .Cells("x").Value
                End If

                idEmp = .Cells("idEmpleado").Value
                For colum = 1 To Me.da
                    fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                    If fechaC = Nothing Then
                        diaSem = "9"
                    Else
                        diaSem = WeekdayName(Weekday(fechaC))
                    End If

                    If fechaC = "12:00:00 am" Then
                    Else
                        If diaSem = "sábado" And tur = 4 Then
                            Dim ce As String = "entrada" & colum
                            Dim cs As String = "salida" & colum
                            If .Cells(ce).Value = "" Then
                                .Cells(ce).Value = "D"
                                .Cells(ce).Style.BackColor = Color.Black
                                .Cells(ce).Style.ForeColor = Color.White
                            End If
                            If .Cells(cs).Value = "" Then
                                .Cells(cs).Value = "D"
                                .Cells(cs).Style.BackColor = Color.Black
                                .Cells(cs).Style.ForeColor = Color.White
                            End If
                        ElseIf diaSem = "domingo" Then
                            Dim ce As String = "entrada" & colum
                            Dim cs As String = "salida" & colum
                            If .Cells(ce).Value = "" Then
                                .Cells(ce).Value = "D"
                                .Cells(ce).Style.BackColor = Color.Black
                                .Cells(ce).Style.ForeColor = Color.White
                            End If
                            If .Cells(cs).Value = "" Then
                                .Cells(cs).Value = "D"
                                .Cells(cs).Style.BackColor = Color.Black
                                .Cells(cs).Style.ForeColor = Color.White
                            End If
                        End If
                    End If
                Next
            End With
        Next
        For fila = 0 To totalFilas - 1
            With Dgv_BonoMensual.Rows(fila)
                If .Cells("retardo").Value <> 0 Then .Cells("retardo").Value = util.ConvertirMinutosAHoras(.Cells("retardo").Value)
            End With
        Next
    End Sub
    Private Sub RellenaHoras(ByVal lstCH As LHorarios, ByVal fecha As Date, ByVal totalFilas As Integer)
        Dim fila As Integer, idEmp As Integer, colum As Integer, tur As Integer, nota As Integer, valor As Integer, año As Integer, mes As Integer, dia As Integer
        Dim er As Date, sr As Date, e As Date, s As Date, f As Date, fec As Date, fechaC As Date
        Dim m As String
        Dim NPren As New NPrenomina, conex As New conexion
        Dim cadConex = conex.conexion2008


        For fila = 0 To totalFilas - 1
            With Dgv_BonoMensual.Rows(fila)
                idEmp = .Cells("idEmpleado").Value
                For Each item In lstCH
                    If idEmp = item.IdEmpleado Then
                        tur = item.IdTurno
                        e = Format(Convert.ToDateTime(item.HoraEntrada), "HH:mm:ss")
                        er = Format(Convert.ToDateTime(item.HoraEntradaReal0), "HH:mm:ss")
                        s = Format(Convert.ToDateTime(item.HoraSalida), "HH:mm:ss")
                        sr = Format(Convert.ToDateTime(item.HoraSalidaReal0), "HH:mm:ss")

                        f = Format(Convert.ToDateTime(item.Fecha), "dd/MM/yyyy")
                        fec = Format(f, "dd/MM/yyyy")
                        año = Year(fec)
                        mes = Month(fec)
                        dia = Convert.ToInt16(Format(fec, "dd"))

                        nota = item.Nota0
                        m = item.TipoRegistro0
                        If tur = 3 Then fec = DateAdd(DateInterval.Day, 1, fec)

                        If er > e Or sr < s Or (er = "1/1/0001 12:00:00 AM" Or sr = "1/1/0001 12:00:00 AM") Then 'Then '
                            For colum = 1 To Me.da
                                fechaC = Format(DateAdd(DateInterval.Day, (colum - 1), fecha), "dd/MM/yyyy")
                                If fechaC = fec Then
                                    Dim ce As String = "entrada" & colum
                                    Dim cs As String = "salida" & colum
                                    If .Cells(ce).Value = "" Then
                                        er = Format(er, "HH:mm")
                                        sr = Format(sr, "HH:mm")
                                        If er <> "1/1/0001 12:00:00 AM" And sr <> "1/1/0001 12:00:00 AM" Then
                                            Select Case tur
                                                Case 4 'Administrativo
                                                    If er > "08:01" Or sr < "16:59" Then
                                                        valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, idEmp)
                                                        .Cells(ce).Value = Format(er, "HH:mm")
                                                        .Cells(cs).Value = Format(sr, "HH:mm")
                                                        If ((item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0) And (er > "08:03") Then .Cells("rtt").Value = .Cells("rtt").Value + 1
                                                        .Cells(ce).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                        .Cells(cs).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                        If ((item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0) And (er > "08:03") Then .Cells("rtt").Style.BackColor = Color.White
                                                    End If
                                                    If er > "08:01" Then
                                                        .Cells(ce).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                    If sr < "16:59" Then
                                                        .Cells(cs).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                Case 1 'Mañana
                                                    If er > "06:56" Or sr < "15:24" Then
                                                        valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, idEmp)
                                                        .Cells(ce).Value = Format(er, "HH:mm")
                                                        .Cells(cs).Value = Format(sr, "HH:mm")
                                                        If ((item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0) And (er > "06:58") Then .Cells("rtt").Value = .Cells("rtt").Value + 1
                                                        .Cells(ce).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                        .Cells(cs).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                        If ((item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0) And (er > "06:58") Then .Cells("rtt").Style.BackColor = Color.White
                                                    End If
                                                    If er > "06:56" Then
                                                        .Cells(ce).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                    If sr < "15:24" Then
                                                        .Cells(cs).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                Case 2 'Tarde
                                                    If er > "15:26" Or sr < "23:25" Then
                                                        valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, idEmp)
                                                        .Cells(ce).Value = Format(er, "HH:mm")
                                                        .Cells(cs).Value = Format(sr, "HH:mm")
                                                        If ((item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0) And (er > "15:28") Then .Cells("rtt").Value = .Cells("rtt").Value + 1
                                                        .Cells(ce).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                        .Cells(cs).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                        If ((item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0) And (er > "15:28") Then .Cells("rtt").Style.BackColor = Color.White
                                                    End If
                                                    If er > "15:26" Then
                                                        .Cells(ce).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                    If sr < "23:25" Then
                                                        .Cells(cs).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                Case 3 'Noche
                                                    If er > "23:26" Or sr < "06:54" Then
                                                        valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, idEmp)
                                                        .Cells(ce).Value = Format(er, "HH:mm")
                                                        .Cells(cs).Value = Format(sr, "HH:mm")
                                                        If ((item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0) And (er > "15:28") Then .Cells("rtt").Value = .Cells("rtt").Value + 1
                                                        .Cells(ce).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                        .Cells(cs).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                        If ((item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0) And (er > "15:28") Then .Cells("rtt").Style.BackColor = Color.White
                                                    End If
                                                    If er > "23:26" Then
                                                        .Cells(ce).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                    If sr < "06:54" Then
                                                        .Cells(cs).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                Case 5 'Mazda Día
                                                    valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, idEmp)
                                                    .Cells(ce).Value = Format(er, "HH:mm")
                                                    .Cells(cs).Value = Format(sr, "HH:mm")
                                                    If (item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0 Then .Cells("rtt").Value = .Cells("rtt").Value + 1
                                                    .Cells(ce).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                    .Cells(cs).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                    If (item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0 Then .Cells("rtt").Style.BackColor = Color.White
                                                    If er > "06:01" Then
                                                        .Cells(ce).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                    If sr < "17:59" Then
                                                        .Cells(cs).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                Case 6 'Mazda Noche
                                                    valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, idEmp)
                                                    .Cells(ce).Value = Format(er, "HH:mm")
                                                    .Cells(cs).Value = Format(sr, "HH:mm")
                                                    If (item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0 Then .Cells("rtt").Value = .Cells("rtt").Value + 1
                                                    .Cells(ce).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                    .Cells(cs).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                    If (item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0 Then .Cells("rtt").Style.BackColor = Color.White
                                                    If er > "18:01" Then
                                                        .Cells(ce).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                    If sr < "05:59" Then
                                                        .Cells(cs).Style.ForeColor = Color.FromArgb(0, 51, 102)
                                                    End If
                                                Case Else
                                                    valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, idEmp)
                                                    .Cells(ce).Value = Format(er, "HH:mm")
                                                    .Cells(cs).Value = Format(sr, "HH:mm")
                                                    If (item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0 Then .Cells("rtt").Value = .Cells("rtt").Value + 1
                                                    .Cells(ce).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                    .Cells(cs).Style.BackColor = Color.FromArgb(192, 192, 192)
                                                    If (item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0 Then .Cells("rtt").Style.BackColor = Color.White
                                            End Select
                                        ElseIf er = "1/1/0001 12:00:00 AM" Or sr = "1/1/0001 12:00:00 AM" Then
                                            valor = NPren.VerificarDiaHabil(cadConex, año, mes, dia, idEmp)
                                            If er <> "1/1/0001 12:00:00 AM" Then .Cells(ce).Value = Format(er, "HH:mm")
                                            If sr <> "1/1/0001 12:00:00 AM" Then .Cells(cs).Value = Format(sr, "HH:mm")
                                            .Cells(ce).Style.BackColor = Color.FromArgb(192, 192, 192)
                                            .Cells(cs).Style.BackColor = Color.FromArgb(192, 192, 192)
                                            If (item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0 Then .Cells("rtt").Value = .Cells("rtt").Value + 1
                                            If (item.TipoRegistro0 = "" And item.Nota0 = 0) And valor = 0 Then .Cells("rtt").Style.BackColor = Color.White
                                        End If
                                    End If
                                End If
                            Next
                        End If
                    End If
                Next
            End With
        Next
    End Sub
    Private Sub RellenaCalculaBono(ByVal lstBono As LBono, ByVal totalFilas As Integer)
        Dim fila As Integer, idEmp As Integer
        Dim premio As String
        Dim fechalim As Date, f As Date
        fechalim = Convert.ToDateTime(Dtp_FechaInicioSemana.Value)

        For fila = 0 To totalFilas - 2
            With Dgv_BonoMensual.Rows(fila)
                f = Convert.ToDateTime(.Cells("fechaIngreso").Value)
                idEmp = .Cells("idEmpleado").Value
                premio = .Cells("bono").Value
                If premio = "O" Then
                    For Each item In lstBono
                        If idEmp = item.IdEmpleado Then
                            If f < fechalim Then
                                If item.AcumulaMes < 950 Then
                                    If item.AcumulaMes = 0 Then
                                        .Cells("totalBono").Value = 400
                                        Exit For
                                    Else
                                        .Cells("totalBono").Value = item.AcumulaMes + 50
                                        Exit For
                                    End If
                                ElseIf item.AcumulaMes = 950 Then
                                    .Cells("totalBono").Value = 950
                                    Exit For
                                End If
                            End If
                        End If
                    Next
                ElseIf premio = "X" Then
                    If f < fechalim Then
                        .Cells("totalBono").Value = 0
                    End If
                End If
                .Cells("totalBono").Style.BackColor = Color.White
            End With
        Next
    End Sub
    Private Sub RellenaBonoRecuperado(ByVal lstBono As LBono, ByVal totalFilas As Integer)
        Dim fila As Integer, idEmp As Integer
        Dim fechalim As Date
        fechalim = Convert.ToDateTime(Dtp_FechaInicioSemana.Value)

        For fila = 0 To totalFilas - 2
            With Dgv_BonoMensual.Rows(fila)
                idEmp = .Cells("idEmpleado").Value
                For Each item In lstBono
                    If idEmp = item.IdEmpleado Then
                        .Cells("totalBono").Value = item.AcumulaMes
                        Exit For
                    End If
                Next
                .Cells("totalBono").Style.BackColor = Color.White
            End With
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
        Dim lstAus As New LAusentismo(), lstVac As New LVacaciones(), lstInc As New LIncapacidad(), lstHE As New LHorasExtra(), lstCH As New LHorarios()
        Dim NPre As New NPrenomina()
        Dim fechaI As Date, fechaF As Date, fi As Date, ff As Date
        Dim conex As New conexion
        Dim cadConex = conex.conexion2008 'Conexion a la BD de asahi16 de la instancia sql2008

        fechaF = Dtp_FechaInicioSemana.Value
        fechaI = Format(DateSerial(Year(fechaF), Month(fechaF), 1), "dd/MM/yyyy")
        fi = Format(DateSerial(Year(fechaI), Month(fechaI) - 0, 0), "dd/MM/yyyy")
        ff = Format(DateSerial(Year(DateAdd(DateInterval.Month, 1, fechaF)), Month(DateAdd(DateInterval.Month, 1, fechaF)), 1), "dd/MM/yyyy")

        lstAus = NPre.RecuperarAusentismo(cadConex, fechaI, fechaF)
        lstVac = NPre.RecuperarVacaciones(cadConex, DateAdd(DateInterval.Day, -10, fechaI), DateAdd(DateInterval.Day, 10, fechaF))
        lstInc = NPre.RecuperarIncapacidades(cadConex)
        lstHE = NPre.RecuperarHorasExtra(cadConex, fechaI, fechaF)
        lstCH = NPre.RecuperarChecadas(cadConex, fi, ff)
        RellenaIncidencias(lstAus, lstVac, lstInc, lstHE, lstCH)
    End Sub
    Private Function RecuperaAcumulado() As LBono
        Dim NPre As New NPrenomina(), conex As New conexion()
        Dim mes As String
        Dim año As Integer
        Dim cadConex = conex.conexion2008

        If Me.rec = False Then
            mes = Format(DateAdd(DateInterval.Month, -1, Dtp_FechaInicioSemana.Value), "MM")
        Else
            mes = Format(Dtp_FechaInicioSemana.Value, "MM")
        End If

        Select Case mes
            Case "01" : mes = "ENE"
            Case "02" : mes = "FEB"
            Case "03" : mes = "MAR"
            Case "04" : mes = "ABR"
            Case "05" : mes = "MAY"
            Case "06" : mes = "JUN"
            Case "07" : mes = "JUL"
            Case "08" : mes = "AGO"
            Case "09" : mes = "SEP"
            Case "10" : mes = "OCT"
            Case "11" : mes = "NOV"
            Case "12" : mes = "DIC"
        End Select

        año = Lbl_año.Text

        Return NPre.RecuperaAcumulado(cadConex, mes, año)
    End Function
#End Region
#Region "Rellena Objetos"
    Private Function RellenaObjetoBono() As LBono
        Dim lstBono As New LBono()
        Dim fila As Integer
        Dim totalFilas As Integer = Dgv_BonoMensual.Rows.Count()

        For fila = 0 To totalFilas - 2
            With Dgv_BonoMensual.Rows(fila)
                Dim objBono As New Bono()
                objBono.IdEmpleado = .Cells("idEmpleado").Value
                objBono.AcumulaMes = .Cells("totalBono").Value
                objBono.Año = Lbl_año.Text
                lstBono.Add(objBono)
            End With
        Next
        Return lstBono
    End Function
#End Region
#Region "Procesos Varios"
    Private Sub ProcesoBonoMensual(ByVal lstEmp As LEmpleado, ByVal fecha As Date)
        Dim m As Integer


        lstEmp = RecuperarEmpleados(fecha)
        If lstEmp(0).Err = False Then
            m = Month(Dtp_FechaInicioSemana.Value)
            RellenaChecadasDgvGlobalPrenomina(lstEmp)
            RecuperarIncidencias()
            If m <= Me.mes Then
                Me.rec = True
                ProcesoAcumulado()
            Else
                Me.rec = False
            End If
        End If
    End Sub
    Private Sub ProcesoAcumulado()
        Dim lstBono As New LBono()
        Dim totalFilas As Integer = Dgv_BonoMensual.Rows.Count()
        Dim NPre As New NPrenomina()
        Dim conex As New conexion()
        Dim cadConex As String = conex.conexion2008
        Dim mes As Integer = Month(Dtp_FechaInicioSemana.Value)

        lstBono = RecuperaAcumulado()
        If rec = False Then
            RellenaCalculaBono(lstBono, totalFilas)
            lstBono = RellenaObjetoBono()
            NPre.InsertarAcumulado(cadConex, lstBono, mes)
        Else
            RellenaBonoRecuperado(lstBono, totalFilas)
        End If
        Btn_Acumulado.Enabled = False
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
    Private Sub CalcularBono(ByVal totalFilas As Integer)
        Dim fila As Integer, rtt As Integer
        Dim x As String ',
        For fila = 0 To totalFilas - 2
            With Dgv_BonoMensual.Rows(fila)
                x = .Cells("x").Value
                rtt = .Cells("rtt").Value
                If (x = "0" And rtt = "0") Then
                    .Cells("premio").Value = "SI"
                    .Cells("bono").Value = "O"
                    .Cells("premio").Style.BackColor = Color.White
                    .Cells("bono").Style.BackColor = Color.LawnGreen
                Else
                    .Cells("premio").Value = "NO"
                    .Cells("bono").Value = "X"
                    .Cells("bono").Style.BackColor = Color.White
                End If
            End With
        Next
    End Sub
#End Region
End Class