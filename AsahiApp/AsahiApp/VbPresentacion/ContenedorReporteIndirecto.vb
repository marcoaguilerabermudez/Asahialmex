Public Class ContenedorReporteIndirecto

    Public id_evaluacion As Integer

    Public fecha As String

    Private Sub ContenedorReporteIndirecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the 'DataSet10.Sp_reporteEvaluacionIndirecto' table. You can move, or remove it, as needed.
        Me.Sp_reporteEvaluacionIndirectoTableAdapter.Fill(Me.DataSet10.Sp_reporteEvaluacionIndirecto, id_evaluacion, fecha)

        ReportViewer1.LocalReport.EnableExternalImages = True

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class