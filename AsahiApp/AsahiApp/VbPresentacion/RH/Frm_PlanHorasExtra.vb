Imports System.Data.SqlClient
Imports Negocio
Imports Clases

Public Class Frm_PlanHorasExtra
#Region "Variables de Clase"
    Dim conex As New conexion()
    Dim cadenaConex As String = conex.conexion2008
    Dim cadConex As String = conex.cadenaConexExpress
    Dim columna As String
    Dim fila As Integer, semana As Integer
#End Region
#Region "Acciones del Formulario"
    Private Sub Frm_PlanHorasExtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_año.Text = Format(DateTime.Now, "yyyy")
        Dim hrs As New Horarios, NPre As New NPrenomina()
        RellenaCmbSemanas()
        RellenaCmbDepartamento()
        hrs = NPre.RecuperarDiasSemana(Me.conex.conexionContpaq, DateTime.Now)
        Cmb_Semanas.SelectedIndex = hrs.Semana - 1
        Me.semana = hrs.Semana
        Cmb_Semanas_SelectionChangeCommitted(sender, e)
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
        lbl_Dia6.Text = Format(DateAdd(DateInterval.Day, 5, objHrsEx.FechaI), "dd/MM")
        lbl_Dia7.Text = Format(objHrsEx.FechaF, "dd/MM")
        Dgv_HorasExtra.DataSource = Nothing
        Dgv_HorasExtra.Rows.Clear()
        Btn_Guardar.Enabled = False
        Cmb_Departamento.SelectedValue = 0
        FormatoLabelsSumas()
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
    End Sub
    Private Sub Dgv_HorasExtra_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_HorasExtra.CellEndEdit
        Dim fila As Integer, turno As Integer, totalFilas As Integer = Dgv_HorasExtra.Rows.Count, f As Integer
        Dim dobles As Double = 0, triples As Double = 0, total As Double, sueldoXHoraB As Double = 0, sueldoXHoraN As Double = 0, sn As Double = 0, sb As Double = 0,
            totalDia As Double = 0, d As Double = 0, t As Double = 0, thd As Double = 0, tht As Double = 0, b As Double = 0, n As Double = 0, descLaborado As Double
        Dim label As New Label()
        Dim columna As String
        Dim Emp As New Empleado()
        fila = Dgv_HorasExtra.CurrentRow.Index
        columna = Dgv_HorasExtra.Columns(e.ColumnIndex).Name
        If columna = "lunes" Or columna = "martes" Or columna = "miercoles" Or columna = "jueves" Or columna = "viernes" Or
                columna = "sabado" Or columna = "domingo" Then
            For f = 0 To totalFilas - 1
                With Dgv_HorasExtra.Rows(f)
                    If Convert.ToDouble(.Cells(columna).Value) > 0.5 Then totalDia = (Convert.ToDouble(.Cells(columna).Value) + totalDia)
                End With
            Next
            Select Case columna
                Case "lunes" : Lbl_SumLunes.Text = Convert.ToDouble(totalDia)
                Case "martes" : Lbl_SumMartes.Text = Convert.ToDouble(totalDia)
                Case "miercoles" : Lbl_SumMiercoles.Text = Convert.ToDouble(totalDia)
                Case "jueves" : Lbl_SumJueves.Text = Convert.ToDouble(totalDia)
                Case "viernes" : Lbl_SumViernes.Text = Convert.ToDouble(totalDia)
                Case "sabado" : Lbl_SumSabado.Text = Convert.ToDouble(totalDia)
                Case "domingo" : Lbl_SumDomingo.Text = Convert.ToDouble(totalDia)
            End Select


            With Dgv_HorasExtra.Rows(fila)
                If .Cells("idTurno").Value >= 4 Then
                    If Convert.ToDouble(.Cells("lunes").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("lunes").Value) + total)
                    If Convert.ToDouble(.Cells("martes").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("martes").Value) + total)
                    If Convert.ToDouble(.Cells("miercoles").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("miercoles").Value) + total)
                    If Convert.ToDouble(.Cells("jueves").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("jueves").Value) + total)
                    If Convert.ToDouble(.Cells("viernes").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("viernes").Value) + total)
                    If Convert.ToDouble(.Cells("sabado").Value) > 0.5 Then descLaborado = (Convert.ToDouble(.Cells("sabado").Value) + descLaborado)
                    If Convert.ToDouble(.Cells("domingo").Value) > 0.5 Then descLaborado = (Convert.ToDouble(.Cells("domingo").Value) + descLaborado)
                Else
                    If Convert.ToDouble(.Cells("lunes").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("lunes").Value) + total)
                    If Convert.ToDouble(.Cells("martes").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("martes").Value) + total)
                    If Convert.ToDouble(.Cells("miercoles").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("miercoles").Value) + total)
                    If Convert.ToDouble(.Cells("jueves").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("jueves").Value) + total)
                    If Convert.ToDouble(.Cells("viernes").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("viernes").Value) + total)
                    If Convert.ToDouble(.Cells("sabado").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("sabado").Value) + total)
                    If Convert.ToDouble(.Cells("domingo").Value) > 0.5 Then descLaborado = (Convert.ToDouble(.Cells("domingo").Value) + descLaborado)
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
                If total <= 9 And total > 0.5 Then
                    dobles = total
                    .Cells("dobles").Value = dobles
                    .Cells("triples").Value = 0
                    .Cells("totalDobles").Value = Format(dobles * (sueldoXHoraN * 2), "$0.00")
                    .Cells("totalTriples").Value = Format(0, "$0.00")
                    .Cells("descansoLaborado").Value = descLaborado
                    Emp = ObtenerSueldos(sn, turno, total)
                    .Cells("totalBruto").Value = Format(Emp.SueldoBruto, "$0.00")
                    .Cells("totalNeto").Value = Format(Emp.SueldoNeto, "$0.00")
                    .Cells("triples").Style.BackColor = Color.LightGray
                    .Cells("triples").Style.ForeColor = Color.White
                    .Cells("totalTriples").Style.BackColor = Color.LightGray
                    .Cells("totalTriples").Style.ForeColor = Color.White
                    .Cells("descansoLaborado").Style.BackColor = Color.White
                    .Cells("descansoLaborado").Style.ForeColor = Color.Black
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.BackColor = Color.LightGray
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.ForeColor = Color.White
                ElseIf total > 9 Then
                    dobles = 9
                    triples = total - dobles
                    .Cells("dobles").Value = dobles
                    .Cells("triples").Value = triples
                    .Cells("totalDobles").Value = Format(dobles * (sueldoXHoraN * 2), "$0.00")
                    .Cells("totalTriples").Value = Format(triples * (sueldoXHoraN * 3), "$0.00")
                    .Cells("descansoLaborado").Value = descLaborado
                    Emp = ObtenerSueldos(sn, turno, total)
                    .Cells("totalBruto").Value = Format(Emp.SueldoBruto, "$0.00")
                    .Cells("totalNeto").Value = Format(Emp.SueldoNeto, "$0.00")
                    .Cells("triples").Style.BackColor = Color.White
                    .Cells("triples").Style.ForeColor = Color.Black
                    .Cells("totalTriples").Style.BackColor = Color.White
                    .Cells("totalTriples").Style.ForeColor = Color.Black
                    .Cells("descansoLaborado").Style.BackColor = Color.White
                    .Cells("descansoLaborado").Style.ForeColor = Color.Black
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.BackColor = Color.LightGray
                    If .Cells("descansoLaborado").Value = 0 Then .Cells("descansoLaborado").Style.ForeColor = Color.White
                Else
                    .Cells("dobles").Value = 0
                    .Cells("totalDobles").Value = Format(0, "$0.00")
                    .Cells("triples").Value = 0
                    .Cells("totalTriples").Value = Format(0, "$0.00")
                    .Cells("descansoLaborado").Value = 0
                    .Cells("totalBruto").Value = Format(0, "$0.00")
                    .Cells("totalNeto").Value = Format(0, "$0.00")
                    .Cells("triples").Style.BackColor = Color.LightGray
                    .Cells("triples").Style.ForeColor = Color.White
                    .Cells("totalTriples").Style.BackColor = Color.LightGray
                    .Cells("totalTriples").Style.ForeColor = Color.White
                    .Cells("descansoLaborado").Style.BackColor = Color.LightGray
                    .Cells("descansoLaborado").Style.ForeColor = Color.White
                End If

            End With
            For f = 0 To totalFilas - 1
                With Dgv_HorasExtra.Rows(f)
                    thd = (Convert.ToDouble(.Cells("dobles").Value) + thd)
                    tht = (Convert.ToDouble(.Cells("triples").Value) + tht)
                    d = (.Cells("totalDobles").Value + d)
                    t = (.Cells("totalTriples").Value + t)
                    b = (.Cells("totalBruto").Value + b)
                    n = (.Cells("totalNeto").Value + n)
                End With
            Next
            Lbl_HrsDoblesSum.Text = thd
            Lbl_HrsTriplesSum.Text = tht
            Lbl_TotalDoblesSum.Text = Format(d, "$0.00")
            Lbl_TotalTriplesSum.Text = Format(t, "$0.00")
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
            (txt.Text.Contains(".") = False) Then

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
        Dim dobles As Double = 0, triples As Double = 0, total As Double, descLaborado As Double = 0
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
                .Cells("departamento").Value = item.Departamento
                .Cells("idTurno").Value = item.IdTurno
                .Cells("sueldoBruto").Value = item.SueldoBruto
                .Cells("sueldoNeto").Value = item.SueldoNeto

                .Cells("lunes").Value = item.Lunes
                Lbl_SumLunes.Text = Lbl_SumLunes.Text + .Cells("lunes").Value
                .Cells("martes").Value = item.Martes
                Lbl_SumMartes.Text = Lbl_SumMartes.Text + .Cells("martes").Value
                .Cells("miercoles").Value = item.Miercoles
                Lbl_SumMiercoles.Text = Lbl_SumMiercoles.Text + .Cells("miercoles").Value
                .Cells("jueves").Value = item.Jueves
                Lbl_SumJueves.Text = Lbl_SumJueves.Text + .Cells("jueves").Value
                .Cells("viernes").Value = item.Viernes
                Lbl_SumViernes.Text = Lbl_SumViernes.Text + .Cells("viernes").Value
                If item.Sabado > 0 Then
                    .Cells("sabado").Value = 1
                Else
                    .Cells("sabado").Value = 0
                End If
                Lbl_SumSabado.Text = Lbl_SumSabado.Text + .Cells("sabado").Value
                If item.Domingo > 0 Then
                    .Cells("domingo").Value = 1
                Else
                    .Cells("domingo").Value = 0
                End If
                Lbl_SumDomingo.Text = Lbl_SumDomingo.Text + .Cells("domingo").Value

                .Cells("totalDobles").Value = Format(item.TotalDobles, "$0.00")
                Lbl_TotalDoblesSum.Text = Format((Lbl_TotalDoblesSum.Text + item.TotalDobles), "$0.00")
                .Cells("totalTriples").Value = Format(item.TotalTriples, "$0.00")
                Lbl_TotalTriplesSum.Text = Format((Lbl_TotalTriplesSum.Text + item.TotalTriples), "$0.00")
                .Cells("totalBruto").Value = Format(item.Bruto, "$0.00")
                Lbl_SueldoBrutoSuma.Text = Format((Lbl_SueldoBrutoSuma.Text + item.Bruto), "$0.00")
                .Cells("totalNeto").Value = Format(item.Neto, "$0.00")
                Lbl_SueldoNetoSuma.Text = Format((Lbl_SueldoNetoSuma.Text + item.Neto), "$0.00")

                If item.IdTurno >= 4 Then
                    total = (item.Lunes + item.Martes + item.Miercoles + item.Jueves + item.Viernes)
                    descLaborado = (.Cells("sabado").Value + .Cells("domingo").Value)
                Else
                    total = (item.Lunes + item.Martes + item.Miercoles + item.Jueves + item.Viernes + item.Sabado)
                    descLaborado = .Cells("domingo").Value
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
        For fila = 0 To totalFilas - 1
            With Dgv_HorasExtra.Rows(fila)
                If .Cells("totalNeto").Value > 0 Then
                    Dim objHE As New HorasExtra()
                    objHE.IdEmpleado = .Cells("Clave").Value
                    objHE.Lunes = .Cells("lunes").Value
                    objHE.Martes = .Cells("martes").Value
                    objHE.Miercoles = .Cells("miercoles").Value
                    objHE.Jueves = .Cells("jueves").Value
                    objHE.Viernes = .Cells("viernes").Value
                    objHE.Sabado = .Cells("sabado").Value
                    objHE.Domingo = .Cells("domingo").Value
                    objHE.Semana = Cmb_Semanas.Text
                    objHE.Año = Lbl_año.Text
                    objHE.TotalDobles = .Cells("totalDobles").Value
                    objHE.TotalTriples = .Cells("totalTriples").Value
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
            .DisplayMember = "Semanas"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub RellenaCmbDepartamento()
        Dim lstDep As New LEmpleado()
        Dim NEmp As New NEmpleado()

        lstDep = NEmp.RecuperarDepartamentos(Me.cadenaConex)
        With Cmb_Departamento
            .DataSource = lstDep
            .ValueMember = "IdDepartamento"
            .DisplayMember = "Departamento"
            .SelectedItem = Nothing
        End With
    End Sub
#End Region
#Region "Otros Procesos"
    Private Function ObtenerSueldos(ByVal sueldo As Double, ByVal turno As Integer, ByVal hrsExtra As Double) As Empleado
        Dim emp As New Empleado(), imp As New Impuestos(), NImp As New NImpuestos()
        Dim sueldoXHora As Double, sueldoDia As Double, sueldoSem As Double, sueldoMes As Double, hrsDExentas As Double, hrsDGrabables As Double, hrsTriples As Double,
            dobles As Double, triples As Double, exedente As Double, cobroEx As Double, exedMensual As Double, exedSemanal As Double, sueSem As Double, h2 As Double

        If turno = 2 Then
            sueldoXHora = (sueldo / 7.5)
        ElseIf turno = 3 Then
            sueldoXHora = (sueldo / 7)
        Else
            sueldoXHora = (sueldo / 8)
        End If

        If hrsExtra <= 9 And hrsExtra > 0.5 Then
            dobles = hrsExtra
            hrsDExentas = (dobles * sueldoXHora)
            hrsDGrabables = (dobles * sueldoXHora)
        ElseIf hrsExtra > 9 Then
            dobles = 9
            triples = hrsExtra - dobles
            hrsDExentas = (dobles * sueldoXHora)
            hrsDGrabables = (dobles * sueldoXHora)
            hrsTriples = (triples * sueldoXHora) * 3
        End If

        sueldoSem = (sueldo * 7) + (hrsDExentas + hrsDGrabables + hrsTriples)
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

        emp.SueldoNeto = ((sueSem + h2 + hrsTriples) - exedSemanal)
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
        Lbl_SueldoBrutoSuma.Text = Format(0, "$0.00")
        Lbl_SueldoNetoSuma.Text = Format(0, "$0.00")
    End Sub
#End Region
End Class