Public Class ContenedorReporteCambioPuestoxMes

    Public mes As Integer
    Public año As Integer
    Private Sub ContenedorReporteCambioPuestoxMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet21.Sp_reportecambiodepuestoxmes' Puede moverla o quitarla según sea necesario.
        Me.Sp_reportecambiodepuestoxmesTableAdapter.Fill(Me.DataSet21.Sp_reportecambiodepuestoxmes, mes, año)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class