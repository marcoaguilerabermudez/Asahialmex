Public Class ContenedorReporteEntradaSalidaTE
    Public id As Integer
    Public Tipo As Integer
    Public motivo As Integer
    Public retardo As Integer
    Private Sub ContenedorReporteEntradaSalidaTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet4.Sp_reporteincidencia' table. You can move, or remove it, as needed.
        DataSet4.EnforceConstraints = False
        Me.Sp_reporteincidenciaTableAdapter.Fill(Me.DataSet4.Sp_reporteincidencia, id, Tipo, motivo, retardo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class