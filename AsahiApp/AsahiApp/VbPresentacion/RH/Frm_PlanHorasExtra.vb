Imports System.Data.SqlClient
Imports Negocio
Imports Clases

Public Class Frm_PlanHorasExtra
#Region "Variables de Clase"
    Dim conex As New conexion()
    Dim cadenaConex As String = conex.conexion2008
    Dim cadConex As String = conex.cadenaConexExpress
    Dim columna As String
    Dim fila As Integer, semana As Integer, idioma As Integer
#End Region
#Region "Acciones del Formulario"
    Private Sub Frm_PlanHorasExtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_año.Text = Format(DateTime.Now, "yyyy")
        Rdb_Esp.Checked = True
        Dim hrs As New Horarios, NPre As New NPrenomina()
        RellenaCmbSemanas()
        RellenaCmbDepartamento()
        hrs = NPre.RecuperarDiasSemana(Me.conex.conexionContpaq, DateTime.Now)
        Cmb_Semanas.SelectedIndex = hrs.Semana - 1
        Me.semana = hrs.Semana
        Cmb_Semanas_SelectionChangeCommitted(sender, e)
        BuscarDiasFestivo()
        FormatoLabelsSumas()
    End Sub
    Private Sub Cmb_Semanas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Semanas.SelectionChangeCommitted
        Dim NHrsEx As New NHorasExtra()
        Dim objHrsEx As New HorasExtra()
        Dim año As Integer = Lbl_año.Text
        Dim semana As Integer = Cmb_Semanas.SelectedIndex

        semana += 1
        objHrsEx = NHrsEx.ObtenerFechasSemana(Me.cadenaConex, año, semana)
        Lbl_Dia1.Text = Format(objHrsEx.FechaI, "dd/MM")
        Lbl_Dia2.Text = Format(DateAdd(DateInterval.Day, 1, objHrsEx.FechaI), "dd/MM")
        Lbl_Dia3.Text = Format(DateAdd(DateInterval.Day, 2, objHrsEx.FechaI), "dd/MM")
        Lbl_Dia4.Text = Format(DateAdd(DateInterval.Day, 3, objHrsEx.FechaI), "dd/MM")
        Lbl_Dia5.Text = Format(DateAdd(DateInterval.Day, 4, objHrsEx.FechaI), "dd/MM")
        Lbl_Dia6.Text = Format(DateAdd(DateInterval.Day, 5, objHrsEx.FechaI), "dd/MM")
        Lbl_Dia7.Text = Format(objHrsEx.FechaF, "dd/MM")
        Select Case objHrsEx.Mes
            Case 1 : Lbl_Mes.Text = "Enero"
            Case 2 : Lbl_Mes.Text = "Febrero"
            Case 3 : Lbl_Mes.Text = "Marzo"
            Case 4 : Lbl_Mes.Text = "Abril"
            Case 5 : Lbl_Mes.Text = "Mayo"
            Case 6 : Lbl_Mes.Text = "Junio"
            Case 7 : Lbl_Mes.Text = "Julio"
            Case 8 : Lbl_Mes.Text = "Agosto"
            Case 9 : Lbl_Mes.Text = "Septiembre"
            Case 10 : Lbl_Mes.Text = "Octubre"
            Case 11 : Lbl_Mes.Text = "Noviembre"
            Case 12 : Lbl_Mes.Text = "Diciembre"
        End Select
        Dgv_HorasExtra.DataSource = Nothing
        Dgv_HorasExtra.Rows.Clear()
        Btn_Guardar.Enabled = False
        'Cmb_Departamento.SelectedValue = 0
        FormatoLabelsSumas()
        BuscarDiasFestivo()
        If Not Cmb_Departamento.Text = "" Then
            Dim idDep As Integer ', semana As Integer, año As Integer
            Dim fecha As Date
            Dgv_HorasExtra.DataSource = Nothing
            Dgv_HorasExtra.Rows.Clear()
            idDep = Cmb_Departamento.SelectedValue
            fecha = Format(DateTime.Now, "dd/MM/yyyy")
            semana = Cmb_Semanas.Text
            año = Lbl_año.Text
            If Me.semana <= Cmb_Semanas.Text Then
                Dgv_HorasExtra.Enabled = True
            Else
                Dgv_HorasExtra.Enabled = False
            End If
            RecuperarEmpleado(idDep, fecha, semana, año)
            Btn_Guardar.Enabled = False
        End If
    End Sub
    Private Sub Cmb_Departamento_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Departamento.SelectionChangeCommitted
        Dim idDep As Integer, semana As Integer, año As Integer
        Dim fecha As Date
        FormatoLabelsSumas()
        Dgv_HorasExtra.DataSource = Nothing
        Dgv_HorasExtra.Rows.Clear()
        idDep = Cmb_Departamento.SelectedValue
        fecha = Format(DateTime.Now, "dd/MM/yyyy")
        semana = Cmb_Semanas.Text
        año = Lbl_año.Text
        If Me.semana <= Cmb_Semanas.Text Then
            Dgv_HorasExtra.Enabled = True
        Else
            Dgv_HorasExtra.Enabled = False
        End If
        RecuperarEmpleado(idDep, fecha, semana, año)
        Btn_Guardar.Enabled = False
        Btn_ObtenerReportes.Enabled = True
    End Sub
    Private Sub Dgv_HorasExtra_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_HorasExtra.CellEndEdit
        Dim fila As Integer, turno As Integer, totalFilas As Integer = Dgv_HorasExtra.Rows.Count, f As Integer
        Dim dobles As Double = 0, triples As Double = 0, total As Double, sueldoXHoraB As Double = 0, sueldoXHoraN As Double = 0, sn As Double = 0, sb As Double = 0,
            totalDia As Double = 0, d As Double = 0, t As Double = 0, thd As Double = 0, tht As Double = 0, b As Double = 0, n As Double = 0, descLaborado As Double,
            tdt As Double, dt As Double, domingo As String(), dld As Double, ted As Double = 0, totalDiaDom As Double = 0
        Dim label As New Label()
        Dim columna As String
        Dim Emp As New Empleado()
        fila = Dgv_HorasExtra.CurrentRow.Index
        columna = Dgv_HorasExtra.Columns(e.ColumnIndex).Name
        If columna = "lunes" Or columna = "martes" Or columna = "miercoles" Or columna = "jueves" Or columna = "viernes" Or
                columna = "sabado" Or columna = "domingo" Then

            If columna = "domingo" Then 'columna = "sabado" Or
                If Dgv_HorasExtra.Rows(fila).Cells(columna).Value = "," Then
                    Dgv_HorasExtra.Rows(fila).Cells(columna).Value = "0,0"
                End If
                domingo = Dgv_HorasExtra.Rows(fila).Cells(columna).Value.Split(New Char() {","c})
                dld = domingo(0)
                If domingo.Count = 2 Then
                    If domingo(1) <> "" Then ted = domingo(1)
                End If
                If Dgv_HorasExtra.Rows(fila).Cells("idTurno").Value >= 4 Then
                    If dld >= 1 Then 'Dgv_HorasExtra.Rows(fila).Cells(columna).Value
                        Dgv_HorasExtra.Rows(fila).Cells(columna).Value = 1 & "," & ted
                    End If
                ElseIf Dgv_HorasExtra.Rows(fila).Cells("idTurno").Value < 4 Then 'And columna = "domingo"
                    If dld >= 1 Then
                        Dgv_HorasExtra.Rows(fila).Cells(columna).Value = 1 & "," & ted
                    End If
                End If
                'If domingo.Count <> 2 Then Dgv_HorasExtra.Rows(fila).Cells(columna).Value = 1 & "," & ted
            End If

            With Dgv_HorasExtra.Rows(fila)
                Select Case columna
                    Case "lunes" : If Lbl_Dia1.BackColor = Color.DarkViolet And .Cells(columna).Value >= 1 Then .Cells(columna).Value = 1
                    Case "martes" : If Lbl_Dia2.BackColor = Color.DarkViolet And .Cells(columna).Value >= 1 Then .Cells(columna).Value = 1
                    Case "miercoles" : If Lbl_Dia3.BackColor = Color.DarkViolet And .Cells(columna).Value >= 1 Then .Cells(columna).Value = 1
                    Case "jueves" : If Lbl_Dia4.BackColor = Color.DarkViolet And .Cells(columna).Value >= 1 Then .Cells(columna).Value = 1
                    Case "viernes" : If Lbl_Dia5.BackColor = Color.DarkViolet And .Cells(columna).Value >= 1 Then .Cells(columna).Value = 1
                    Case "sabado" : If Lbl_Dia6.BackColor = Color.DarkViolet And .Cells(columna).Value >= 1 Then .Cells(columna).Value = 1
                    Case "domingo" : If Lbl_Dia7.BackColor = Color.DarkViolet And .Cells(columna).Value <> 0 Then .Cells(columna).Value = 1
                End Select
            End With

            For f = 0 To totalFilas - 1
                With Dgv_HorasExtra.Rows(f)
                    If Not columna = "domingo" Then
                        If Convert.ToDouble(.Cells(columna).Value) > 0.5 Then totalDia = (Convert.ToDouble(.Cells(columna).Value) + totalDia)
                    Else
                        dld = 0
                        ted = 0
                        If .Cells(columna).Value > 0 Then
                            domingo = .Cells(columna).Value.Split(New Char() {","c})
                            dld = domingo(0)
                            If domingo.Count = 2 Then
                                If domingo(1) <> "" Then ted = domingo(1)
                            End If
                        End If

                        totalDia = dld + totalDia
                        totalDiaDom = ted + totalDiaDom
                    End If
                End With
            Next

            Select Case columna
                Case "lunes" : Lbl_SumLunes.Text = Convert.ToDouble(totalDia)
                Case "martes" : Lbl_SumMartes.Text = Convert.ToDouble(totalDia)
                Case "miercoles" : Lbl_SumMiercoles.Text = Convert.ToDouble(totalDia)
                Case "jueves" : Lbl_SumJueves.Text = Convert.ToDouble(totalDia)
                Case "viernes" : Lbl_SumViernes.Text = Convert.ToDouble(totalDia)
                Case "sabado" : Lbl_SumSabado.Text = Convert.ToDouble(totalDia)
                Case "domingo" : Lbl_SumDomingo.Text = totalDia & "," & totalDiaDom
            End Select

            With Dgv_HorasExtra.Rows(fila)
                dld = 0
                ted = 0
                If .Cells("domingo").Value > 0 Then
                    domingo = .Cells(columna).Value.Split(New Char() {","c})
                    dld = domingo(0)
                    If domingo.Count = 2 Then
                        If domingo(1) <> "" Then ted = domingo(1)
                    End If
                End If
                If .Cells("idTurno").Value >= 4 Then
                    If Convert.ToDouble(.Cells("lunes").Value) > 0.5 And Lbl_Dia1.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("lunes").Value) + total)
                    If Convert.ToDouble(.Cells("martes").Value) > 0.5 And Lbl_Dia2.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("martes").Value) + total)
                    If Convert.ToDouble(.Cells("miercoles").Value) > 0.5 And Lbl_Dia3.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("miercoles").Value) + total)
                    If Convert.ToDouble(.Cells("jueves").Value) > 0.5 And Lbl_Dia4.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("jueves").Value) + total)
                    If Convert.ToDouble(.Cells("viernes").Value) > 0.5 And Lbl_Dia5.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("viernes").Value) + total)
                    If Convert.ToDouble(.Cells("sabado").Value) > 0.5 And Lbl_Dia6.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("sabado").Value) + total)
                    If Convert.ToDouble(ted) > 0.5 And Lbl_Dia7.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(ted) + total)
                    If Convert.ToDouble(dld) > 0.5 And Lbl_Dia7.BackColor <> Color.DarkViolet Then descLaborado = (Convert.ToDouble(dld) + descLaborado)
                Else
                    If Convert.ToDouble(.Cells("lunes").Value) > 0.5 And Lbl_Dia1.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("lunes").Value) + total)
                    If Convert.ToDouble(.Cells("martes").Value) > 0.5 And Lbl_Dia2.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("martes").Value) + total)
                    If Convert.ToDouble(.Cells("miercoles").Value) > 0.5 And Lbl_Dia3.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("miercoles").Value) + total)
                    If Convert.ToDouble(.Cells("jueves").Value) > 0.5 And Lbl_Dia4.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("jueves").Value) + total)
                    If Convert.ToDouble(.Cells("viernes").Value) > 0.5 And Lbl_Dia5.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("viernes").Value) + total)
                    If Convert.ToDouble(.Cells("sabado").Value) > 0.5 And Lbl_Dia6.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(.Cells("sabado").Value) + total)
                    If Convert.ToDouble(ted) > 0.5 And Lbl_Dia7.BackColor <> Color.DarkViolet Then total = (Convert.ToDouble(ted) + total)
                    If Convert.ToDouble(dld) > 0.5 And Lbl_Dia7.BackColor <> Color.DarkViolet Then descLaborado = (Convert.ToDouble(dld) + descLaborado)
                End If

                If .Cells("idTurno").Value >= 4 Then
                    If Lbl_Dia1.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("lunes").Value) + descLaborado)
                    If Lbl_Dia2.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("martes").Value) + descLaborado)
                    If Lbl_Dia3.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("miercoles").Value) + descLaborado)
                    If Lbl_Dia4.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("jueves").Value) + descLaborado)
                    If Lbl_Dia5.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("viernes").Value) + descLaborado)
                    If Lbl_Dia6.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("sabado").Value) + descLaborado)
                Else
                    If Lbl_Dia1.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("lunes").Value) + descLaborado)
                    If Lbl_Dia2.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("martes").Value) + descLaborado)
                    If Lbl_Dia3.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("miercoles").Value) + descLaborado)
                    If Lbl_Dia4.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("jueves").Value) + descLaborado)
                    If Lbl_Dia5.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("viernes").Value) + descLaborado)
                    If Lbl_Dia6.BackColor = Color.DarkViolet Then descLaborado = (Convert.ToDouble(.Cells("sabado").Value) + descLaborado)
                End If

                If .Cells("idTurno").Value = 3 Then
                    sueldoXHoraB = (Convert.ToDouble(.Cells("sueldoBruto").Value) / 7)
                    sueldoXHoraN = (Convert.ToDouble(.Cells("sueldoNeto").Value) / 7)
                ElseIf .Cells("idTurno").Value = 2 Then
                    sueldoXHoraB = (Convert.ToDouble(.Cells("sueldoBruto").Value) / 7.5)
                    sueldoXHoraN = (Convert.ToDouble(.Cells("sueldoNeto").Value) / 7.5)
                Else
                    sueldoXHoraB = (Convert.ToDouble(.Cells("sueldoBruto").Value) / 8)
                    sueldoXHoraN = (Convert.ToDouble(.Cells("sueldoNeto").Value) / 8)
                End If
                sn = Convert.ToDouble(.Cells("sueldoNeto").Value)
                turno = .Cells("idTurno").Value
                If (total <= 9 And total > 0.5) Or (descLaborado > 0 And total = 0) Then
                    dobles = total
                    .Cells("dobles").Value = dobles
                    .Cells("triples").Value = 0
                    .Cells("descansoLaborado").Value = descLaborado
                    .Cells("totalDobles").Value = Format(dobles * (sueldoXHoraN * 2), "$0.00")
                    .Cells("totalTriples").Value = Format(0, "$0.00")
                    .Cells("totalDescLaborado").Value = Format(((descLaborado * 8) * (sueldoXHoraN * 3)), "$0.00")
                    Emp = ObtenerSueldos(sn, turno, total, descLaborado)
                    .Cells("totalBruto").Value = Format(Emp.SueldoBruto, "$0.00")
                    .Cells("totalNeto").Value = Format(Emp.SueldoNeto, "$0.00")
                    .Cells("triples").Style.BackColor = Color.LightGray
                    .Cells("triples").Style.ForeColor = Color.White
                    .Cells("totalTriples").Style.BackColor = Color.LightGray
                    .Cells("totalTriples").Style.ForeColor = Color.White
                    .Cells("descansoLaborado").Style.BackColor = Color.White
                    .Cells("descansoLaborado").Style.ForeColor = Color.Black
                    .Cells("totalDescLaborado").Style.BackColor = Color.White
                    .Cells("totalDescLaborado").Style.ForeColor = Color.Black
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.BackColor = Color.LightGray
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.ForeColor = Color.White
                    If .Cells("totalDescLaborado").Value = 0 Then .Cells("totalDescLaborado").Style.BackColor = Color.LightGray
                    If .Cells("totalDescLaborado").Value = 0 Then .Cells("totalDescLaborado").Style.ForeColor = Color.White
                ElseIf total > 9 Or (descLaborado > 0 And total = 0) Then
                    dobles = 9
                    triples = total - dobles
                    .Cells("dobles").Value = dobles
                    .Cells("triples").Value = triples
                    .Cells("descansoLaborado").Value = descLaborado
                    .Cells("totalDobles").Value = Format(dobles * (sueldoXHoraN * 2), "$0.00")
                    .Cells("totalTriples").Value = Format(triples * (sueldoXHoraN * 3), "$0.00")
                    .Cells("totalDescLaborado").Value = Format(((descLaborado * 8) * (sueldoXHoraN * 3)), "$0.00")
                    Emp = ObtenerSueldos(sn, turno, total, descLaborado)
                    .Cells("totalBruto").Value = Format(Emp.SueldoBruto, "$0.00")
                    .Cells("totalNeto").Value = Format(Emp.SueldoNeto, "$0.00")
                    .Cells("triples").Style.BackColor = Color.White
                    .Cells("triples").Style.ForeColor = Color.Black
                    .Cells("totalTriples").Style.BackColor = Color.White
                    .Cells("totalTriples").Style.ForeColor = Color.Black
                    .Cells("descansoLaborado").Style.BackColor = Color.White
                    .Cells("descansoLaborado").Style.ForeColor = Color.Black
                    .Cells("totalDescLaborado").Style.BackColor = Color.White
                    .Cells("totalDescLaborado").Style.ForeColor = Color.Black
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.BackColor = Color.LightGray
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.ForeColor = Color.White
                    If .Cells("totalDescLaborado").Value = 0 Then .Cells("totalDescLaborado").Style.BackColor = Color.LightGray
                    If .Cells("totalDescLaborado").Value = 0 Then .Cells("totalDescLaborado").Style.ForeColor = Color.White
                Else
                    .Cells("dobles").Value = 0
                    .Cells("triples").Value = 0
                    .Cells("descansoLaborado").Value = 0
                    .Cells("totalDobles").Value = Format(0, "$0.00")
                    .Cells("totalTriples").Value = Format(0, "$0.00")
                    .Cells("totalDescLaborado").Value = Format(0, "$0.00")
                    .Cells("totalBruto").Value = Format(0, "$0.00")
                    .Cells("totalNeto").Value = Format(0, "$0.00")
                    .Cells("triples").Style.BackColor = Color.LightGray
                    .Cells("triples").Style.ForeColor = Color.White
                    .Cells("totalTriples").Style.BackColor = Color.LightGray
                    .Cells("totalTriples").Style.ForeColor = Color.White
                    .Cells("descansoLaborado").Style.BackColor = Color.LightGray
                    .Cells("descansoLaborado").Style.ForeColor = Color.White
                    .Cells("totalDescLaborado").Style.BackColor = Color.LightGray
                    .Cells("totalDescLaborado").Style.ForeColor = Color.White
                End If

            End With
            For f = 0 To totalFilas - 1
                With Dgv_HorasExtra.Rows(f)
                    thd = (Convert.ToDouble(.Cells("dobles").Value) + thd)
                    tht = (Convert.ToDouble(.Cells("triples").Value) + tht)
                    tdt = (Convert.ToDouble(.Cells("descansoLaborado").Value) + tdt)
                    d = (.Cells("totalDobles").Value + d)
                    t = (.Cells("totalTriples").Value + t)
                    dt = (.Cells("totalDescLaborado").Value + dt)
                    b = (.Cells("totalBruto").Value + b)
                    n = (.Cells("totalNeto").Value + n)
                End With
            Next
            Lbl_HrsDoblesSum.Text = thd
            Lbl_HrsTriplesSum.Text = tht
            Lbl_DescLaborado.Text = tdt
            Lbl_TotalDoblesSum.Text = Format(d, "$0.00")
            Lbl_TotalTriplesSum.Text = Format(t, "$0.00")
            Lbl_TotalDescLabSuma.Text = Format(dt, "$0.00")
            Lbl_SueldoBrutoSuma.Text = Format(b, "$0.00")
            Lbl_SueldoNetoSuma.Text = Format(n, "$0.00")

            Btn_Guardar.Enabled = True
        End If
    End Sub
    Private Sub Dgv_HorasExtra_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Dgv_HorasExtra.EditingControlShowing
        ' referencia a la celda 
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress 
        AddHandler validar.KeyPress, AddressOf Dgv_HorasExtra_KeyPress
    End Sub
    Private Sub Dgv_HorasExtra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Dgv_HorasExtra.KeyPress
        ' obtener indice de la columna 
        Dim columna As Integer = Dgv_HorasExtra.CurrentCell.ColumnIndex

        If columna = 6 Or columna = 7 Or columna = 8 Or columna = 9 Or columna = 10 Or columna = 11 Or columna = 12 Then
            Dim caracter As Char = e.KeyChar
            ' referencia a la celda 
            Dim txt As TextBox = CType(sender, TextBox)
            ' comprobar si es un nmero con isNumber, si es el backspace, si el caracter 
            ' es el separador decimal, y que no contiene ya el separador 
            If (Char.IsNumber(caracter)) Or
            (caracter = ChrW(Keys.Back)) Or
            (caracter = ".") And
            (txt.Text.Contains(".") = False) Or
            (columna = 12 And (caracter = ",") And (txt.Text.Contains(",") = False)) Then

                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Dgv_HorasExtra_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_HorasExtra.CellEnter
        Me.fila = Dgv_HorasExtra.CurrentRow.Index
        Me.columna = Dgv_HorasExtra.Columns(e.ColumnIndex).Name
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim conex As New conexion(), lstHrxEx As New LHorasExtra(), NHrsEx As New NHorasExtra()
        Dim cadConex As String = conex.cadenaConexExpress
        lstHrxEx = RellenaObjetoLHrsExtra()
        NHrsEx.InsertarPlanHrsExtra(cadConex, lstHrxEx)
        Btn_Guardar.Enabled = False
    End Sub
    Private Sub Btn_ObtenerReportes_Click(sender As Object, e As EventArgs) Handles Btn_ObtenerReportes.Click
        Dim idDpto As Integer = Cmb_Departamento.SelectedValue, mes As Integer = obtenerMes(), año As Integer = Lbl_año.Text, semana As Integer = Cmb_Semanas.Text
        Dim reps As New Frm_OpcionesReportes(idDpto, mes, año, semana, 1)
        reps.Show()
    End Sub
    Private Sub Rdb_Esp_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Esp.CheckedChanged
        RellenaCmbDepartamento()
        Me.idioma = 1
        CambioDeIdioma()
        Dgv_HorasExtra.DataSource = Nothing
        Dgv_HorasExtra.Rows.Clear()
    End Sub
    Private Sub Rdb_Jpn_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Jpn.CheckedChanged
        RellenaCmbDepartamento()
        Me.idioma = 2
        CambioDeIdioma()
        Dgv_HorasExtra.DataSource = Nothing
        Dgv_HorasExtra.Rows.Clear()
    End Sub
#End Region
#Region "Recuperar"
    Private Sub RecuperarEmpleado(ByVal idDep As Integer, ByVal fecha As Date, ByVal semana As Integer, ByVal año As Integer)
        Dim NEmp As New NEmpleado(), lstEmp As New LEmpleado()

        lstEmp = NEmp.RecuperarEmpleadosDepto(Me.cadenaConex, idDep, fecha, semana, año)
        RellenaDgvEmpleados(lstEmp)
    End Sub
#End Region
#Region "Rellenar Fomulario"
    Private Sub RellenaDgvEmpleados(ByVal lstEmp As LEmpleado)
        Dim fila As Integer = 0
        Dim dobles As Double = 0, triples As Double = 0, total As Double, descLaborado As Double = 0, tted As Double, tdld As Double
        Dim domingo As String()
        Dgv_HorasExtra.DataSource = Nothing
        Dgv_HorasExtra.Rows.Clear()
        For Each item In lstEmp
            Dgv_HorasExtra.Rows.Add()
            With Dgv_HorasExtra.Rows(fila)
                .Cells("clave").Value = item.IdEmpleado
                item.NombreCompleto = item.Nombres
                If item.ApellidoPaterno <> "x" Or item.ApellidoPaterno <> "X" Or item.ApellidoPaterno <> "" Then item.NombreCompleto = item.NombreCompleto & " " & item.ApellidoPaterno
                If item.ApellidoMaterno <> "x" Or item.ApellidoMaterno <> "X" Or item.ApellidoMaterno <> "" Then item.NombreCompleto = item.NombreCompleto & " " & item.ApellidoMaterno

                .Cells("nombre").Value = item.NombreCompleto
                If Me.idioma = 1 Then .Cells("departamento").Value = item.Departamento
                If Me.idioma = 2 Then .Cells("departamento").Value = Cmb_Departamento.Text
                .Cells("idTurno").Value = item.IdTurno
                .Cells("sueldoBruto").Value = item.SueldoBruto
                .Cells("sueldoNeto").Value = item.SueldoNeto

                .Cells("lunes").Value = item.Lunes
                Lbl_SumLunes.Text = Lbl_SumLunes.Text + .Cells("lunes").Value
                If Lbl_Dia1.BackColor = Color.DarkViolet Then
                    .Cells("lunes").Style.BackColor = Color.DarkViolet
                    .Cells("lunes").Style.ForeColor = Color.White
                End If
                .Cells("martes").Value = item.Martes
                Lbl_SumMartes.Text = Lbl_SumMartes.Text + .Cells("martes").Value
                If Lbl_Dia2.BackColor = Color.DarkViolet Then
                    .Cells("martes").Style.BackColor = Color.DarkViolet
                    .Cells("martes").Style.ForeColor = Color.White
                End If
                .Cells("miercoles").Value = item.Miercoles
                Lbl_SumMiercoles.Text = Lbl_SumMiercoles.Text + .Cells("miercoles").Value
                If Lbl_Dia3.BackColor = Color.DarkViolet Then
                    .Cells("miercoles").Style.BackColor = Color.DarkViolet
                    .Cells("miercoles").Style.ForeColor = Color.White
                End If
                .Cells("jueves").Value = item.Jueves
                Lbl_SumJueves.Text = Lbl_SumJueves.Text + .Cells("jueves").Value
                If Lbl_Dia4.BackColor = Color.DarkViolet Then
                    .Cells("jueves").Style.BackColor = Color.DarkViolet
                    .Cells("jueves").Style.ForeColor = Color.White
                End If
                .Cells("viernes").Value = item.Viernes
                Lbl_SumViernes.Text = Lbl_SumViernes.Text + .Cells("viernes").Value
                If Lbl_Dia5.BackColor = Color.DarkViolet Then
                    .Cells("viernes").Style.BackColor = Color.DarkViolet
                    .Cells("viernes").Style.ForeColor = Color.White
                End If
                .Cells("sabado").Value = item.Sabado
                Lbl_SumSabado.Text = Lbl_SumSabado.Text + .Cells("sabado").Value
                If Lbl_Dia6.BackColor = Color.DarkViolet Then
                    .Cells("sabado").Style.BackColor = Color.DarkViolet
                    .Cells("sabado").Style.ForeColor = Color.White
                End If
                'If item.Sabado > 0 Then
                '    .Cells("sabado").Value = 1
                'Else
                '    .Cells("sabado").Value = 0
                'End If
                If item.Domingo > 0 Then
                    .Cells("domingo").Value = 1 & "," & item.DomingoHrsEx
                Else
                    .Cells("domingo").Value = 0 & "," & item.DomingoHrsEx
                End If
                Dim dld = 0
                Dim ted = 0
                If .Cells("domingo").Value > 0 Then
                    domingo = .Cells("domingo").Value.Split(New Char() {","c})
                    dld = domingo(0)
                    If domingo.Count = 2 Then
                        If domingo(1) <> "" Then ted = domingo(1)
                    End If
                End If
                tted = tted + ted
                tdld = tdld + dld
                Lbl_SumDomingo.Text = (tdld) & "," & (tted)

                .Cells("totalDobles").Value = Format(item.TotalDobles, "$0.00")
                Lbl_TotalDoblesSum.Text = Format((Lbl_TotalDoblesSum.Text + item.TotalDobles), "$0.00")
                .Cells("totalTriples").Value = Format(item.TotalTriples, "$0.00")
                Lbl_TotalTriplesSum.Text = Format((Lbl_TotalTriplesSum.Text + item.TotalTriples), "$0.00")
                .Cells("totalDescLaborado").Value = Format(item.TotalDescLab, "$0.00")
                Lbl_TotalDescLabSuma.Text = Format((Lbl_TotalDescLabSuma.Text + item.TotalDescLab), "$0.00")
                .Cells("totalBruto").Value = Format(item.Bruto, "$0.00")
                Lbl_SueldoBrutoSuma.Text = Format((Lbl_SueldoBrutoSuma.Text + item.Bruto), "$0.00")
                .Cells("totalNeto").Value = Format(item.Neto, "$0.00")
                Lbl_SueldoNetoSuma.Text = Format((Lbl_SueldoNetoSuma.Text + item.Neto), "$0.00")

                If item.IdTurno >= 4 Then
                    total = 0
                    descLaborado = 0
                    dld = 0
                    ted = 0
                    If .Cells("domingo").Value > 0 Then
                        domingo = .Cells("domingo").Value.Split(New Char() {","c})
                        dld = domingo(0)
                        If domingo.Count = 2 Then
                            If domingo(1) <> "" Then ted = domingo(1)
                        End If
                    End If
                    If .Cells("lunes").Style.BackColor <> Color.DarkViolet Then total = total + item.Lunes
                    If .Cells("martes").Style.BackColor <> Color.DarkViolet Then total = total + item.Martes
                    If .Cells("miercoles").Style.BackColor <> Color.DarkViolet Then total = total + item.Miercoles
                    If .Cells("jueves").Style.BackColor <> Color.DarkViolet Then total = total + item.Jueves
                    If .Cells("viernes").Style.BackColor <> Color.DarkViolet Then total = total + item.Viernes
                    If .Cells("sabado").Style.BackColor <> Color.DarkViolet Then total = total + item.Sabado
                    total = total + ted
                    If .Cells("lunes").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Lunes
                    If .Cells("martes").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Martes
                    If .Cells("miercoles").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Miercoles
                    If .Cells("jueves").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Jueves
                    If .Cells("viernes").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Viernes
                    If .Cells("sabado").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Sabado
                    descLaborado = descLaborado + dld
                Else
                    total = 0
                    descLaborado = 0
                    dld = 0
                    ted = 0
                    If .Cells("domingo").Value > 0 Then
                        domingo = .Cells("domingo").Value.Split(New Char() {","c})
                        dld = domingo(0)
                        If domingo.Count = 2 Then
                            If domingo(1) <> "" Then ted = domingo(1)
                        End If
                    End If
                    If .Cells("lunes").Style.BackColor <> Color.DarkViolet Then total = total + item.Lunes
                    If .Cells("martes").Style.BackColor <> Color.DarkViolet Then total = total + item.Martes
                    If .Cells("miercoles").Style.BackColor <> Color.DarkViolet Then total = total + item.Miercoles
                    If .Cells("jueves").Style.BackColor <> Color.DarkViolet Then total = total + item.Jueves
                    If .Cells("viernes").Style.BackColor <> Color.DarkViolet Then total = total + item.Viernes
                    If .Cells("sabado").Style.BackColor <> Color.DarkViolet Then total = total + item.Sabado
                    total = total + ted
                    If .Cells("lunes").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Lunes
                    If .Cells("martes").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Martes
                    If .Cells("miercoles").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Miercoles
                    If .Cells("jueves").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Jueves
                    If .Cells("viernes").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Viernes
                    If .Cells("sabado").Style.BackColor = Color.DarkViolet Then descLaborado = descLaborado + item.Sabado
                    descLaborado = descLaborado + dld
                End If
                If total <= 9 Then
                    dobles = total
                    .Cells("dobles").Value = dobles
                    Lbl_HrsDoblesSum.Text = Lbl_HrsDoblesSum.Text + .Cells("dobles").Value
                    .Cells("triples").Value = 0
                    Lbl_HrsTriplesSum.Text = Lbl_HrsTriplesSum.Text + .Cells("triples").Value
                    .Cells("descansoLaborado").Value = descLaborado
                    Lbl_DescLaborado.Text = Lbl_DescLaborado.Text + .Cells("descansoLaborado").Value
                    .Cells("triples").Style.BackColor = Color.LightGray
                    .Cells("triples").Style.ForeColor = Color.White
                    .Cells("totalTriples").Style.BackColor = Color.LightGray
                    .Cells("totalTriples").Style.ForeColor = Color.White
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.BackColor = Color.LightGray
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.ForeColor = Color.White
                    If .Cells("totalDescLaborado").Value = 0 Then .Cells("totalDescLaborado").Style.BackColor = Color.LightGray
                    If .Cells("totalDescLaborado").Value = 0 Then .Cells("totalDescLaborado").Style.ForeColor = Color.White
                ElseIf total > 9 Then
                    dobles = 9
                    triples = total - dobles
                    .Cells("dobles").Value = dobles
                    Lbl_HrsDoblesSum.Text = Lbl_HrsDoblesSum.Text + .Cells("dobles").Value
                    .Cells("triples").Value = triples
                    Lbl_HrsTriplesSum.Text = Lbl_HrsTriplesSum.Text + .Cells("triples").Value
                    .Cells("descansoLaborado").Value = descLaborado
                    Lbl_DescLaborado.Text = Lbl_DescLaborado.Text + .Cells("descansoLaborado").Value
                    .Cells("triples").Style.BackColor = Color.White
                    .Cells("triples").Style.ForeColor = Color.Black
                    .Cells("totalTriples").Style.BackColor = Color.White
                    .Cells("totalTriples").Style.ForeColor = Color.Black
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.BackColor = Color.LightGray
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.ForeColor = Color.White
                    If .Cells("totalDescLaborado").Value = 0 Then .Cells("totalDescLaborado").Style.BackColor = Color.LightGray
                    If .Cells("totalDescLaborado").Value = 0 Then .Cells("totalDescLaborado").Style.ForeColor = Color.White
                Else
                    .Cells("dobles").Value = 0
                    Lbl_HrsDoblesSum.Text = 0
                    .Cells("triples").Value = 0
                    Lbl_HrsTriplesSum.Text = 0
                    .Cells("descansoLaborado").Value = 0
                    Lbl_DescLaborado.Text = 0
                    .Cells("triples").Style.BackColor = Color.White
                    .Cells("triples").Style.ForeColor = Color.Black
                    .Cells("totalTriples").Style.BackColor = Color.White
                    .Cells("totalTriples").Style.ForeColor = Color.Black
                    .Cells("descansoLaborado").Style.BackColor = Color.LightGray
                    .Cells("descansoLaborado").Style.ForeColor = Color.White
                End If

                If item.IdTurno < 4 Then
                    If Lbl_Dia6.BackColor = Color.DarkViolet Then
                        .Cells("sabado").Style.BackColor = Color.DarkViolet
                        .Cells("sabado").Style.ForeColor = Color.White
                    End If
                    .Cells("domingo").Style.BackColor = Color.LightBlue
                ElseIf item.IdTurno = 4 Then
                    .Cells("sabado").Style.BackColor = Color.LightBlue
                    .Cells("domingo").Style.BackColor = Color.LightBlue
                End If
            End With
            fila += 1
        Next
        If Me.semana <= Cmb_Semanas.Text Then
            Dgv_HorasExtra.Enabled = True
        Else
            Dgv_HorasExtra.Enabled = False
        End If
        'Dgv_HorasExtra.Rows.Remove(Dgv_HorasExtra.Rows(fila))
    End Sub
#End Region
#Region "Rellenar Objetos"
    Private Function RellenaObjetoLHrsExtra() As LHorasExtra
        Dim lstHrsEx As New LHorasExtra()
        Dim fila As Integer, totalFilas As Integer = Dgv_HorasExtra.Rows.Count()
        Dim domingo As String()
        For fila = 0 To totalFilas - 1
            With Dgv_HorasExtra.Rows(fila)
                If .Cells("totalNeto").Value > 0 Then
                    Dim dld = 0
                    Dim ted = 0
                    If .Cells("domingo").Value > 0 Then
                        domingo = Convert.ToString(.Cells(columna).Value).Split(New Char() {","c})
                        dld = domingo(0)
                        If domingo.Count = 2 Then
                            If domingo(1) <> "" Then ted = domingo(1)
                        End If
                    End If
                    Dim objHE As New HorasExtra()
                    objHE.IdEmpleado = .Cells("Clave").Value
                    objHE.Lunes = .Cells("lunes").Value
                    objHE.Martes = .Cells("martes").Value
                    objHE.Miercoles = .Cells("miercoles").Value
                    objHE.Jueves = .Cells("jueves").Value
                    objHE.Viernes = .Cells("viernes").Value
                    objHE.Sabado = .Cells("sabado").Value
                    objHE.Domingo = dld
                    objHE.DomingoHrsEx = ted
                    objHE.Semana = Cmb_Semanas.Text
                    objHE.Año = Lbl_año.Text
                    objHE.TotalDobles = .Cells("totalDobles").Value
                    objHE.TotalTriples = .Cells("totalTriples").Value
                    objHE.TotalDescLab = .Cells("totalDescLaborado").Value
                    objHE.Bruto = .Cells("totalBruto").Value
                    objHE.Neto = .Cells("totalNeto").Value
                    lstHrsEx.Add(objHE)
                End If
            End With
        Next
        Return lstHrsEx
    End Function
#End Region
#Region "RellenaCmb"
    Private Sub RellenaCmbSemanas()
        Dim hrsEx As New HorasExtra()
        Dim lstHrsEx As New LHorasExtra()
        Dim NHrsEx As New NHorasExtra()

        lstHrsEx = NHrsEx.ObtenerSemanas(Me.cadenaConex, Lbl_año.Text)
        With Cmb_Semanas
            .DataSource = lstHrsEx
            .ValueMember = "Mes"
            .DisplayMember = "Semanas"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub RellenaCmbDepartamento()
        Dim lstDep As New LEmpleado()
        Dim NEmp As New NEmpleado()

        If Rdb_Esp.Checked = True Then
            Me.idioma = 1
        ElseIf Rdb_Jpn.Checked = True Then
            Me.idioma = 2
        End If
        lstDep = NEmp.RecuperarDepartamentos(Me.cadenaConex, Me.idioma)
        With Cmb_Departamento
            .DataSource = lstDep
            .ValueMember = "IdDepartamento"
            .DisplayMember = "Departamento"
            .SelectedItem = Nothing
        End With
    End Sub
#End Region
#Region "Otros Procesos"
    Private Function ObtenerSueldos(ByVal sueldo As Double, ByVal turno As Integer, ByVal hrsExtra As Double, ByVal descLaborado As Double) As Empleado
        Dim emp As New Empleado(), imp As New Impuestos(), NImp As New NImpuestos()
        Dim sueldoXHora As Double, sueldoDia As Double, sueldoSem As Double, sueldoMes As Double, hrsDExentas As Double, hrsDGrabables As Double, hrsTriples As Double,
            dobles As Double, triples As Double, exedente As Double, cobroEx As Double, exedMensual As Double, exedSemanal As Double, sueSem As Double, h2 As Double,
            dl As Double, p As Double, d As Double

        p = ((sueldo * 6) * 0.27)
        d = ((sueldo * 6) * 0.1)

        If turno = 2 Then
            sueldoXHora = (sueldo / 7.5)
            dl = (7.5 * descLaborado)
        ElseIf turno = 3 Then
            sueldoXHora = (sueldo / 7)
            dl = (7 * descLaborado)
        Else
            sueldoXHora = (sueldo / 8)
            dl = (8 * descLaborado)
        End If
        If (hrsExtra <= 9 And hrsExtra > 0.5) Or (descLaborado > 0) Then
            dobles = hrsExtra
            hrsDExentas = (dobles * sueldoXHora)
            hrsDGrabables = (dobles * sueldoXHora)
            hrsTriples = ((triples + dl) * sueldoXHora) * 3
        ElseIf hrsExtra > 9 Or (descLaborado > 0) Then
            dobles = 9
            triples = hrsExtra - dobles
            hrsDExentas = (dobles * sueldoXHora)
            hrsDGrabables = ((dobles + dl) * sueldoXHora)
            hrsTriples = ((triples + dl) * sueldoXHora) * 3
        End If

        sueldoSem = (sueldo * 7) + (hrsDGrabables + hrsTriples + p)
        sueldoDia = (sueldoSem / 7)
        sueldoMes = (sueldoDia * 30.4)
        'sb = (sueldoSem + (hrsDExentas + hrsDGrabables +))
        emp.SueldoBruto = sueldoSem

        imp = NImp.RecuperarIsr(Me.cadConex, sueldoMes)
        imp.PorcentajeEx = Format(imp.PorcentajeEx / 100, "0.0000")

        exedente = (sueldoMes - imp.LimiteInf)
        cobroEx = (exedente * imp.PorcentajeEx)
        exedMensual = (cobroEx + imp.CuotaFija)
        exedSemanal = (exedMensual / 30.4) * 7

        h2 = hrsDExentas + hrsDGrabables
        sueSem = sueldo * 7

        emp.SueldoNeto = ((sueSem + h2 + hrsTriples + p) - (exedSemanal + d))
        Return emp
    End Function
    Private Sub FormatoLabelsSumas()
        Lbl_SumLunes.Text = 0
        Lbl_SumMartes.Text = 0
        Lbl_SumMiercoles.Text = 0
        Lbl_SumJueves.Text = 0
        Lbl_SumViernes.Text = 0
        Lbl_SumSabado.Text = 0
        Lbl_SumDomingo.Text = 0
        Lbl_HrsDoblesSum.Text = 0
        Lbl_HrsTriplesSum.Text = 0
        Lbl_DescLaborado.Text = 0
        Lbl_TotalDoblesSum.Text = Format(0, "$0.00")
        Lbl_TotalTriplesSum.Text = Format(0, "$0.00")
        Lbl_TotalDescLabSuma.Text = Format(0, "$0.00")
        Lbl_SueldoBrutoSuma.Text = Format(0, "$0.00")
        Lbl_SueldoNetoSuma.Text = Format(0, "$0.00")
    End Sub
    Private Sub CambioDeIdioma()
        If Me.idioma = 1 Then
            Lbl_Semana.Text = "Semana"
            Lbl_Depto.Text = "Departamento"
            Btn_Guardar.Text = "Guardar"
            Lbl_Totales.Text = "TOTALES:"
            Dgv_HorasExtra.Columns("clave").HeaderText = "Clave"
            Dgv_HorasExtra.Columns("nombre").HeaderText = "Nombre"
            Dgv_HorasExtra.Columns("departamento").HeaderText = "Departamento"
            Dgv_HorasExtra.Columns("lunes").HeaderText = "Lun"
            Dgv_HorasExtra.Columns("martes").HeaderText = "Mar"
            Dgv_HorasExtra.Columns("miercoles").HeaderText = "Mié"
            Dgv_HorasExtra.Columns("jueves").HeaderText = "Jue"
            Dgv_HorasExtra.Columns("viernes").HeaderText = "Vie"
            Dgv_HorasExtra.Columns("sabado").HeaderText = "Sáb"
            Dgv_HorasExtra.Columns("domingo").HeaderText = "Dom"
            Dgv_HorasExtra.Columns("dobles").HeaderText = "Horas Dobles"
            Dgv_HorasExtra.Columns("triples").HeaderText = "Horas Triples"
            Dgv_HorasExtra.Columns("descansoLaborado").HeaderText = "Descanso Laborado"
            Dgv_HorasExtra.Columns("totalDobles").HeaderText = "Total Dobles"
            Dgv_HorasExtra.Columns("totalTriples").HeaderText = "Total Triples"
            Dgv_HorasExtra.Columns("totalDescLaborado").HeaderText = "Total Desc Laborado"
            Dgv_HorasExtra.Columns("totalBruto").HeaderText = "Bruto"
            Dgv_HorasExtra.Columns("totalNeto").HeaderText = "Neto"
        ElseIf Me.idioma = 2 Then
            Lbl_Semana.Text = "週"
            Lbl_Depto.Text = "課"
            Btn_Guardar.Text = "保存"
            Lbl_Totales.Text = "合計:"
            Dgv_HorasExtra.Columns("clave").HeaderText = "社員番号"
            Dgv_HorasExtra.Columns("nombre").HeaderText = "氏名"
            Dgv_HorasExtra.Columns("departamento").HeaderText = "課"
            Dgv_HorasExtra.Columns("lunes").HeaderText = "月"
            Dgv_HorasExtra.Columns("martes").HeaderText = "火"
            Dgv_HorasExtra.Columns("miercoles").HeaderText = "水"
            Dgv_HorasExtra.Columns("jueves").HeaderText = "木"
            Dgv_HorasExtra.Columns("viernes").HeaderText = "金"
            Dgv_HorasExtra.Columns("sabado").HeaderText = "土"
            Dgv_HorasExtra.Columns("domingo").HeaderText = "日"
            Dgv_HorasExtra.Columns("dobles").HeaderText = "2倍
残業
時間"
            Dgv_HorasExtra.Columns("triples").HeaderText = "3倍
残業
時間"
            Dgv_HorasExtra.Columns("descansoLaborado").HeaderText = "休日出勤"
            Dgv_HorasExtra.Columns("totalDobles").HeaderText = "2倍
残業
時間
金額"
            Dgv_HorasExtra.Columns("totalTriples").HeaderText = "3倍
残業
時間
金額"
            Dgv_HorasExtra.Columns("totalDescLaborado").HeaderText = "休日
出勤
金額"
            Dgv_HorasExtra.Columns("totalBruto").HeaderText = "税抜"
            Dgv_HorasExtra.Columns("totalNeto").HeaderText = "税込"
        End If
    End Sub
    Private Sub BuscarDiasFestivo()
        Dim fecha As Date
        Dim vuelta As Integer, dia As Integer, mes As Integer, año As Integer, valor As Integer
        Dim NPren As New NPrenomina()
        For vuelta = 1 To 7
            Select Case vuelta
                Case 1
                    fecha = Lbl_Dia1.Text
                    año = Lbl_año.Text
                    mes = Month(fecha)
                    dia = Convert.ToInt16(Format(fecha, "dd"))
                    valor = NPren.VerificarDiaHabil(cadenaConex, año, mes, dia, 1)
                    If valor = 1 Then
                        Lbl_Dia1.BackColor = Color.DarkViolet
                        Lbl_Dia1.ForeColor = Color.White
                    Else
                        Lbl_Dia1.BackColor = Color.Empty
                        Lbl_Dia1.ForeColor = Color.Black
                    End If
                Case 2 : fecha = Lbl_Dia2.Text
                    fecha = Lbl_Dia2.Text
                    año = Lbl_año.Text
                    mes = Month(fecha)
                    dia = Convert.ToInt16(Format(fecha, "dd"))
                    valor = NPren.VerificarDiaHabil(cadenaConex, año, mes, dia, 1)
                    If valor = 1 Then
                        Lbl_Dia2.BackColor = Color.DarkViolet
                        Lbl_Dia2.ForeColor = Color.White
                    Else
                        Lbl_Dia2.BackColor = Color.Empty
                        Lbl_Dia2.ForeColor = Color.Black
                    End If
                Case 3 : fecha = Lbl_Dia3.Text
                    fecha = Lbl_Dia3.Text
                    año = Lbl_año.Text
                    mes = Month(fecha)
                    dia = Convert.ToInt16(Format(fecha, "dd"))
                    valor = NPren.VerificarDiaHabil(cadenaConex, año, mes, dia, 1)
                    If valor = 1 Then
                        Lbl_Dia3.BackColor = Color.DarkViolet
                        Lbl_Dia3.ForeColor = Color.White
                    Else
                        Lbl_Dia3.BackColor = Color.Empty
                        Lbl_Dia3.ForeColor = Color.Black
                    End If
                Case 4 : fecha = Lbl_Dia4.Text
                    fecha = Lbl_Dia4.Text
                    año = Lbl_año.Text
                    mes = Month(fecha)
                    dia = Convert.ToInt16(Format(fecha, "dd"))
                    valor = NPren.VerificarDiaHabil(cadenaConex, año, mes, dia, 1)
                    If valor = 1 Then
                        Lbl_Dia4.BackColor = Color.DarkViolet
                        Lbl_Dia4.ForeColor = Color.White
                    Else
                        Lbl_Dia4.BackColor = Color.Empty
                        Lbl_Dia4.ForeColor = Color.Black
                    End If
                Case 5 : fecha = Lbl_Dia5.Text
                    fecha = Lbl_Dia5.Text
                    año = Lbl_año.Text
                    mes = Month(fecha)
                    dia = Convert.ToInt16(Format(fecha, "dd"))
                    valor = NPren.VerificarDiaHabil(cadenaConex, año, mes, dia, 1)
                    If valor = 1 Then
                        Lbl_Dia5.BackColor = Color.DarkViolet
                        Lbl_Dia5.ForeColor = Color.White
                    Else
                        Lbl_Dia5.BackColor = Color.Empty
                        Lbl_Dia5.ForeColor = Color.Black
                    End If
                Case 6 : fecha = Lbl_Dia6.Text
                    fecha = Lbl_Dia6.Text
                    año = Lbl_año.Text
                    mes = Month(fecha)
                    dia = Convert.ToInt16(Format(fecha, "dd"))
                    valor = NPren.VerificarDiaHabil(cadenaConex, año, mes, dia, 1)
                    If valor = 1 Then
                        Lbl_Dia6.BackColor = Color.DarkViolet
                        Lbl_Dia6.ForeColor = Color.White
                    Else
                        Lbl_Dia6.BackColor = Color.Empty
                        Lbl_Dia6.ForeColor = Color.Black
                    End If
                Case 7 : fecha = Lbl_Dia7.Text
                    fecha = Lbl_Dia7.Text
                    año = Lbl_año.Text
                    mes = Month(fecha)
                    dia = Convert.ToInt16(Format(fecha, "dd"))
                    valor = NPren.VerificarDiaHabil(cadenaConex, año, mes, dia, 1)
                    If valor = 1 Then
                        Lbl_Dia7.BackColor = Color.DarkViolet
                        Lbl_Dia7.ForeColor = Color.White
                    Else
                        Lbl_Dia7.BackColor = Color.Empty
                        Lbl_Dia7.ForeColor = Color.Black
                    End If
            End Select
        Next
    End Sub
    Private Function obtenerMes() As Integer
        Dim mes As Integer
        Select Case Lbl_Mes.Text
            Case "Enero" : mes = 1
            Case "Febrero" : mes = 2
            Case "Marzo" : mes = 3
            Case "Abril" : mes = 4
            Case "Mayo" : mes = 5
            Case "Junio" : mes = 6
            Case "Julio" : mes = 7
            Case "Agosto" : mes = 8
            Case "Septiembre" : mes = 9
            Case "Octubre" : mes = 10
            Case "Noviembre" : mes = 11
            Case "Diciembre" : mes = 12
        End Select
        Return mes
    End Function
#End Region
End Class