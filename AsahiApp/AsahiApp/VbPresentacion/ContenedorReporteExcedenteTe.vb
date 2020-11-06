Public Class ContenedorReporteExcedenteTe

    Public clave As String
    Public fecha As String
    Public Turno As String

    Private Sub ContenedorReporteExcedenteTe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet2.Sp_reporteExcedidoTE' Puede moverla o quitarla según sea necesario.

        Me.Sp_reporteExcedidoTETableAdapter.Fill(Me.DataSet2.Sp_reporteExcedidoTE, clave, fecha, Turno)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class