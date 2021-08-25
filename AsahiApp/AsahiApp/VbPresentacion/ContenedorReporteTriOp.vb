Public Class ContenedorReporteTriOp

    Public mes As Integer
    Public año As Integer
    Private Sub ContenedorReporteTriOp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet33.Sp_AumentoSueldoOperadoresMensualReporte' Puede moverla o quitarla según sea necesario.
        Me.Sp_AumentoSueldoOperadoresMensualReporteTableAdapter.Fill(Me.DataSet33.Sp_AumentoSueldoOperadoresMensualReporte, mes, año)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class