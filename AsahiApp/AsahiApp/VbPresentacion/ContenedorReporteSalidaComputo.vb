Public Class ContenedorReporteSalidaComputo
    Public id_solicitud As Integer


    Private Sub ContenedorReporteSalidaComputo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatasetEquipoComputo.Sp_imprimeReporteSalidaComputo' table. You can move, or remove it, as needed.
        Me.Sp_imprimeReporteSalidaComputoTableAdapter.Fill(Me.DatasetEquipoComputo.Sp_imprimeReporteSalidaComputo, id_solicitud)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class