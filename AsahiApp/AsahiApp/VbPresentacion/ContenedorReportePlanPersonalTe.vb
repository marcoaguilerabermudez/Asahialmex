Public Class ContenedorReportePlanPersonalTe

    Public depto As String
    Public mes As Integer
    Public año As Integer
    Private Sub ContenedorReportePlanPersonalTe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet19.Sp_reportePlanPersonalTiempo' Puede moverla o quitarla según sea necesario.
        Me.Sp_reportePlanPersonalTiempoTableAdapter.Fill(Me.DataSet19.Sp_reportePlanPersonalTiempo, depto, mes, año)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class