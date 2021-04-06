Public Class ContenedorReporteSemanalPrincipal
    Public mes As Integer
    Public año As Integer
    Public inicio As String
    Public fin As String
    Public semana As Integer


    Private Sub ContenedorReporteSemanalPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet14.Sp_MuestraReporteSemanalEmpleados' table. You can move, or remove it, as needed.
        Me.Sp_MuestraReporteSemanalEmpleadosTableAdapter.Fill(Me.DataSet14.Sp_MuestraReporteSemanalEmpleados, mes, año, inicio, fin, semana)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class