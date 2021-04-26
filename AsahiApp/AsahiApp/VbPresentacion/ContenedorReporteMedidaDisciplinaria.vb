Public Class ContenedorReporteMedidaDisciplinaria

    Public clave As Integer
    Public id As Integer
    Private Sub ContenedorReporteMedidaDisciplinaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet17.Sp_ReporteMedidaDisciplinaria' Puede moverla o quitarla según sea necesario.
        Me.Sp_ReporteMedidaDisciplinariaTableAdapter.Fill(Me.DataSet17.Sp_ReporteMedidaDisciplinaria, id, clave)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class