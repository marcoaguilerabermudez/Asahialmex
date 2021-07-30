Public Class ContenedorReporteVale1
    Public folio
    Private Sub ContenedorReporteVale1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet28.Sp_muestravale' Puede moverla o quitarla según sea necesario.
        DataSet28.EnforceConstraints = False
        Me.Sp_muestravaleTableAdapter.Fill(Me.DataSet28.Sp_muestravale, folio)
        ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class