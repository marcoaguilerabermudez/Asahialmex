Public Class ContenedorReporteSolicitudTe
    Public depto As String
    Public fecha As String
    Private Sub ContenedorReporteSolicitudTe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet27.Sp_MuestraReporteSolicitudTe' Puede moverla o quitarla según sea necesario.
        DataSet27.EnforceConstraints = False
        Me.Sp_MuestraReporteSolicitudTeTableAdapter.Fill(Me.DataSet27.Sp_MuestraReporteSolicitudTe, depto, fecha)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class