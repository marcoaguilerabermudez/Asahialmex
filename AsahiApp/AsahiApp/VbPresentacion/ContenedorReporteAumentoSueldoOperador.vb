Public Class ContenedorReporteAumentoSueldoOperador
    Public mes As Integer
    Public año As Integer
    Private Sub ContenedorReporteAumentoSueldoOperador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet26.Sp_AumentoSueldoOperadoresMensualReporte' Puede moverla o quitarla según sea necesario.
        Me.Sp_AumentoSueldoOperadoresMensualReporteTableAdapter.Fill(Me.DataSet26.Sp_AumentoSueldoOperadoresMensualReporte, mes, año)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class