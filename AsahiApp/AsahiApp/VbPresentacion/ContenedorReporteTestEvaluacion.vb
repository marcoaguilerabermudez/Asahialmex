Public Class ContenedorReporteTestEvaluacion
    Public teval As String
    Public id_evaluaciones As Integer



    Private Sub ContenedorReporteTestEvaluacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Sp_reporteTestEvaluacionTableAdapter.Fill(Me.DataSet5.Sp_reporteTestEvaluacion, teval, id_evaluaciones)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class