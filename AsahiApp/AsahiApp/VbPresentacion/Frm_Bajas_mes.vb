Public Class Frm_Bajas_mes
    Private Sub Frm_Bajas_mes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_año.Text = Today.Year
    End Sub

    Private Sub btn_anteriores_Click(sender As Object, e As EventArgs) Handles btn_anteriores.Click
        ContenedorReporteBajasMes.año = cbx_año.Text
        ContenedorReporteBajasMes.Show()
    End Sub
End Class