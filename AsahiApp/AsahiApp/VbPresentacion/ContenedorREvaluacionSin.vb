Public Class ContenedorREvaluacionSin
    Public teval As String
    Public id_evaluaciones As Integer
    Public fecha As String


    Private Sub ContenedorREvaluacionSin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet6.Sp_reporteTestEvaluacion' table. You can move, or remove it, as needed.
        DataSet6.EnforceConstraints = False
        Try
            Me.Sp_reporteTestEvaluacionTableAdapter.Fill(Me.DataSet6.Sp_reporteTestEvaluacion, teval, id_evaluaciones, fecha)
            ReportViewer1.LocalReport.EnableExternalImages = True
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub


End Class