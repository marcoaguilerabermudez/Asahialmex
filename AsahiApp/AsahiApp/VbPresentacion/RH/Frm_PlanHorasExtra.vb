Imports System.Data.SqlClient
Imports Negocio
Imports Clases

Public Class Frm_PlanHorasExtra
#Region "Variables de Clase"
    Dim conex As New conexion()
    Dim cadenaConex As String = conex.conexion2008
#End Region
#Region "Acciones del Formulario"
    Private Sub Frm_PlanHorasExtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_año.Text = Format(DateTime.Now, "yyyy")
        Dim hrs As New Horarios, NPre As New NPrenomina()
        RellenaCmbSemanas()
        RellenaCmbDepartamento()
        hrs = NPre.RecuperarDiasSemana(Me.conex.conexionContpaq, DateTime.Now)
        Cmb_Semanas.SelectedIndex = hrs.Semana - 1
        Cmb_Semanas_SelectionChangeCommitted(sender, e)
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
        Btn_Guardar.Visible = False
        Cmb_Departamento.SelectedValue = 0
    End Sub
    Private Sub Cmb_Departamento_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cmb_Departamento.SelectionChangeCommitted
        Dim idDep As Integer, semana As Integer, año As Integer
        Dim fecha As Date
        Dgv_HorasExtra.DataSource = Nothing
        Dgv_HorasExtra.Rows.Clear()
        idDep = Cmb_Departamento.SelectedValue
        fecha = Format(DateTime.Now, "dd/MM/yyyy")
        semana = Cmb_Semanas.Text
        año = Lbl_año.Text
        Btn_Guardar.Visible = False
        RecuperarEmpleado(idDep, fecha, semana, año)
    End Sub
    Private Sub Dgv_HorasExtra_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_HorasExtra.CellEndEdit
        Dim fila As Integer
        Dim dobles As Double = 0, triples As Double = 0, total As Double, sueldoXHoraB As Double = 0, sueldoXHoraN As Double = 0
        Dim columna As String
        fila = Dgv_HorasExtra.CurrentRow.Index
        columna = Dgv_HorasExtra.Columns(e.ColumnIndex).Name
        If columna = "lunes" Or columna = "martes" Or columna = "miercoles" Or columna = "jueves" Or columna = "viernes" Or
                columna = "sabado" Or columna = "domingo" Then
            With Dgv_HorasExtra.Rows(fila)
                If Convert.ToDouble(.Cells("lunes").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("lunes").Value) + total)
                If Convert.ToDouble(.Cells("martes").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("martes").Value) + total)
                If Convert.ToDouble(.Cells("miercoles").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("miercoles").Value) + total)
                If Convert.ToDouble(.Cells("jueves").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("jueves").Value) + total)
                If Convert.ToDouble(.Cells("viernes").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("viernes").Value) + total)
                If Convert.ToDouble(.Cells("sabado").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("sabado").Value) + total)
                If Convert.ToDouble(.Cells("domingo").Value) > 0.5 Then total = (Convert.ToDouble(.Cells("domingo").Value) + total)

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

                If total <= 9 And total > 0.5 Then
                    dobles = total
                    .Cells("dobles").Value = dobles
                    .Cells("triples").Value = 0
                    .Cells("totalDobles").Value = Format(dobles * (sueldoXHoraB * 2), "$0.00")
                    .Cells("totalTriples").Value = Format(0, "$0.00")
                    .Cells("totalBruto").Value = Format(dobles * (sueldoXHoraB * 2), "$0.00")
                    .Cells("totalNeto").Value = Format(dobles * (sueldoXHoraN * 2), "$0.00")
                    .Cells("triples").Style.BackColor = Color.LightGray
                    .Cells("triples").Style.ForeColor = Color.White
                    .Cells("totalTriples").Style.BackColor = Color.LightGray
                    .Cells("totalTriples").Style.ForeColor = Color.White
                ElseIf total > 9 Then
                    dobles = 9
                    triples = total - dobles
                    .Cells("dobles").Value = dobles
                    .Cells("triples").Value = triples
                    .Cells("totalDobles").Value = Format(dobles * (sueldoXHoraB * 2), "$0.00")
                    .Cells("totalTriples").Value = Format(triples * (sueldoXHoraB * 3), "$0.00")
                    .Cells("totalBruto").Value = Format((dobles * (sueldoXHoraB * 2) + triples * (sueldoXHoraB * 3)), "$0.00")
                    .Cells("totalNeto").Value = Format((dobles * (sueldoXHoraN * 2) + triples * (sueldoXHoraN * 3)), "$0.00")
                    .Cells("triples").Style.BackColor = Color.White
                    .Cells("triples").Style.ForeColor = Color.Black
                    .Cells("totalTriples").Style.BackColor = Color.White
                    .Cells("totalTriples").Style.ForeColor = Color.Black
                Else
                    .Cells("dobles").Value = 0
                    .Cells("totalDobles").Value = Format(0, "$0.00")
                    .Cells("triples").Value = 0
                    .Cells("totalTriples").Value = Format(0, "$0.00")
                    .Cells("totalBruto").Value = Format(0, "$0.00")
                    .Cells("totalNeto").Value = Format(0, "$0.00")
                    .Cells("triples").Style.BackColor = Color.White
                    .Cells("triples").Style.ForeColor = Color.Black
                    .Cells("totalTriples").Style.BackColor = Color.White
                    .Cells("totalTriples").Style.ForeColor = Color.Black
                End If
            End With
            Btn_Guardar.Visible = True
        End If
    End Sub
    Private Sub Dgv_HorasExtra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Dgv_HorasExtra.KeyPress

    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Dim conex As New conexion(), lstHrxEx As New LHorasExtra(), NHrsEx As New NHorasExtra()
        Dim cadConex As String = conex.cadenaConexExpress
        lstHrxEx = RellenaObjetoLHrsExtra()
        NHrsEx.InsertarPlanHrsExtra(cadConex, lstHrxEx)
        Btn_Guardar.Visible = False
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
        Dim dobles As Double = 0, triples As Double = 0, total As Double
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
                .Cells("martes").Value = item.Martes
                .Cells("miercoles").Value = item.Miercoles
                .Cells("jueves").Value = item.Jueves
                .Cells("viernes").Value = item.Viernes
                .Cells("sabado").Value = item.Sabado
                .Cells("domingo").Value = item.Domingo

                .Cells("totalDobles").Value = Format(item.TotalDobles, "$0.00")
                .Cells("totalTriples").Value = Format(item.TotalTriples, "$0.00")
                .Cells("totalBruto").Value = Format(item.Bruto, "$0.00")
                .Cells("totalNeto").Value = Format(item.Neto, "$0.00")

                total = (item.Lunes + item.Martes + item.Miercoles + item.Jueves + item.Viernes + item.Sabado + item.Domingo)

                If total <= 9 Then
                    dobles = total
                    .Cells("dobles").Value = dobles
                    .Cells("triples").Value = 0
                    .Cells("triples").Style.BackColor = Color.LightGray
                    .Cells("triples").Style.ForeColor = Color.White
                    .Cells("totalTriples").Style.BackColor = Color.LightGray
                    .Cells("totalTriples").Style.ForeColor = Color.White
                ElseIf total > 9 Then
                    dobles = 9
                    triples = total - dobles
                    .Cells("dobles").Value = dobles
                    .Cells("triples").Value = triples
                    .Cells("triples").Style.BackColor = Color.White
                    .Cells("triples").Style.ForeColor = Color.Black
                    .Cells("totalTriples").Style.BackColor = Color.White
                    .Cells("totalTriples").Style.ForeColor = Color.Black
                Else
                    .Cells("dobles").Value = 0
                    .Cells("triples").Value = 0
                    .Cells("triples").Style.BackColor = Color.White
                    .Cells("triples").Style.ForeColor = Color.Black
                    .Cells("totalTriples").Style.BackColor = Color.White
                    .Cells("totalTriples").Style.ForeColor = Color.Black
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
        Dgv_HorasExtra.Enabled = True
        'Dgv_HorasExtra.Rows.Remove(Dgv_HorasExtra.Rows(fila))
    End Sub
#End Region
#Region "Rellenar Objetos"
    Private Function RellenaObjetoLHrsExtra() As LHorasExtra
        Dim lstHrsEx As New LHorasExtra()
        Dim fila As Integer, totalFilas As Integer = Dgv_HorasExtra.Rows.Count()
        For fila = 0 To totalFilas - 2
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
End Class