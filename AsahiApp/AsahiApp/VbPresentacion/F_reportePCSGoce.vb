Public Class F_reportePCSGoce

    Public id As Integer
    Public Tipo As Integer
    Public motivo As Integer
    Public retardo As Integer

    Private Sub F_reportePCSGoce_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Sp_reporteincidenciaTableAdapter.Fill(Me.DatasetRh_Reportes.Sp_reporteincidencia, id, Tipo, motivo, retardo)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class