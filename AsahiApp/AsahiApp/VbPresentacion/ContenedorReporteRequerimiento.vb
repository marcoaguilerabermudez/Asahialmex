Public Class ContenedorReporteRequerimiento
    Private Sub ContenedorReporteRequerimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id As Integer
        'TODO: esta línea de código carga datos en la tabla 'DataSet35.Sp_ReporteComprasRequerimiento' Puede moverla o quitarla según sea necesario.
        DataSet35.EnforceConstraints = False
        Me.Sp_ReporteComprasRequerimientoTableAdapter.Fill(Me.DataSet35.Sp_ReporteComprasRequerimiento, id)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class