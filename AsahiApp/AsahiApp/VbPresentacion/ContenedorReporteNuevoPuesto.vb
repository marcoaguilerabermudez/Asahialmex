Public Class ContenedorReporteNuevoPuesto
    Public id As Integer
    Public Tipo As Integer
    Public motivo As Integer
    Public retardo As Integer


    Private Sub ContenedorReporteNuevoPuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet3.Sp_reporteincidencia' Puede moverla o quitarla según sea necesario.
        ''ReportViewer1.LocalReport.EnableExternalImages = True
        DataSet3.EnforceConstraints = False
        Me.Sp_reporteincidenciaTableAdapter.Fill(Me.DataSet3.Sp_reporteincidencia, id, Tipo, motivo, retardo)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class