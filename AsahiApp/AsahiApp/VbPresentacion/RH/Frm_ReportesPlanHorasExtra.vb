Imports Clases
Imports Negocio
Public Class Frm_ReportesPlanHorasExtra
    Dim cadenaConex As String
    Dim cadConex As String
    Private Sub Frm_ReportesPlanHorasExtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conex As New conexion
        Me.cadenaConex = conex.cadenaConexExpress
        Me.cadConex = conex.conexion2008
        RellenaCmbDepartamento()
        RellenaCmbMeses()
        RellenaCmbAño()
    End Sub
    Private Sub RellenaCmbDepartamento()
        Dim lstDep As New LEmpleado()
        Dim NEmp As New NEmpleado()

        lstDep = NEmp.RecuperarDepartamentos(Me.cadConex)
        With Cmb_Departamento
            .DataSource = lstDep
            .ValueMember = "IdDepartamento"
            .DisplayMember = "Departamento"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub RellenaCmbMeses()
        With Cmb_Meses
            .Items.Add("ENERO")
            .Items.Add("FEBRERO")
            .Items.Add("MARZO")
            .Items.Add("ABRIL")
            .Items.Add("MAYO")
            .Items.Add("JUNIO")
            .Items.Add("JULIO")
            .Items.Add("AGOSTO")
            .Items.Add("SEPTIEMBRE")
            .Items.Add("OCTUBRE")
            .Items.Add("NOVIEMBRE")
            .Items.Add("DICIEMBRE")
        End With
    End Sub
    Private Sub RellenaCmbAño()
        Dim lstaño As New LHorarios()
        Dim NHor As New NHorasExtra()

        lstaño = NHor.RecuperarAños(Me.cadConex)
        With Cmb_Año
            .DataSource = lstaño
            .DisplayMember = "Año"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub Btn_Obtener_Click(sender As Object, e As EventArgs) Handles Btn_Obtener.Click
        Dim tSemanas As Integer, mes As Integer, año As Integer, depto As Integer
        Dim NHrsEx As New NHorasExtra()

        Try
            mes = RecuperarNoMes()
            año = Cmb_Año.Text
            depto = Cmb_Departamento.SelectedValue
            If Not (mes = 0 And año = 0 And depto = 0) Then
                tSemanas = NHrsEx.RecuperarTotalSemanas(Me.cadConex, mes, año)
                If tSemanas = 4 Then
                    Dim Rep4 As New Frm_RepPlanHrsExtra4(mes, depto, año)
                    Rep4.Show()
                ElseIf tSemanas = 5 Then
                    Dim Rep5 As New Frm_RepPlanHrsExtra5(mes, depto, año)
                    Rep5.Show()
                End If
            Else
                MsgBox("Debe seleccionar Mes, Año y Departamento")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " 
Debe seleccionar Mes, Año y Departamento")
        End Try
    End Sub
    Private Function RecuperarNoMes() As Integer
        Select Case Cmb_Meses.SelectedItem
            Case "ENERO"
                Return 1
            Case "FEBRERO"
                Return 2
            Case "MARZO"
                Return 3
            Case "ABRIL"
                Return 4
            Case "MAYO"
                Return 5
            Case "JUNIO"
                Return 6
            Case "JULIO"
                Return 7
            Case "AGOSTO"
                Return 8
            Case "SEPTIEMBRE"
                Return 9
            Case "OCTUBRE"
                Return 10
            Case "NOVIEMBRE"
                Return 11
            Case "DICIEMBRE"
                Return 12
            Case Else
                Return 0
        End Select
    End Function
End Class