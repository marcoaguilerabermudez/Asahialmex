Public Class ContenedorReporteBajasMes

    Public año As Integer
    Private Sub ContenedorReporteBajasMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet7.Sp_reporte_bajas_mes' table. You can move, or remove it, as needed.
        Me.Sp_reporte_bajas_mesTableAdapter.Fill(Me.DataSet7.Sp_reporte_bajas_mes, año)


        Me.ReportViewer1.RefreshReport()

    End Sub
End Class