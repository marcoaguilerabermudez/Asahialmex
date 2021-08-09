Public Class ContenedorReporteSolicitudTeSel
    Public fecha As String
    Private Sub ContenedorReporteSolicitudTeSel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet29.Sp_MuestraReporteSolicitudSeleccion' Puede moverla o quitarla según sea necesario.
        DataSet29.EnforceConstraints = False

        Me.Sp_MuestraReporteSolicitudSeleccionTableAdapter.Fill(Me.DataSet29.Sp_MuestraReporteSolicitudSeleccion, fecha)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class