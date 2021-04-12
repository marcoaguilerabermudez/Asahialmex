Public Class ContenedorReportePersonal2
    Public mes As Integer
    Public año As Integer
    Public variable As Integer
    Public inicio As String
    Public fin As String
    Public semana As Integer
    Private Sub ContenedorReportePersonal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet10.Sp_reporteEvaluacionIndirecto' Puede moverla o quitarla según sea necesario.
        Me.Sp_reportesemanalempleadosTableAdapter.Fill(Me.DataSet14.Sp_reportesemanalempleados, mes, año, variable, inicio, fin, semana)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class