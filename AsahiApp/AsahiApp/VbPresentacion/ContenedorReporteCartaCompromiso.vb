Public Class ContenedorReporteCartaCompromiso
    Public clave As Integer
    Public año As Integer

    Private Sub ContenedorReporteCartaCompromiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet16.Sp_reportecartacompromiso' Puede moverla o quitarla según sea necesario.
        Me.Sp_reportecartacompromisoTableAdapter.Fill(Me.DataSet16.Sp_reportecartacompromiso, clave, año)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class