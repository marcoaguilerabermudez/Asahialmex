Public Class ContenedorCambioTurno
    Private Sub ContenedorCambioTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet34.Sp_ReporteCambioTurno' Puede moverla o quitarla según sea necesario.
        DataSet34.EnforceConstraints = False


        Me.Sp_ReporteCambioTurnoTableAdapter.Fill(Me.DataSet34.Sp_ReporteCambioTurno)

        Me.ReportViewer1.RefreshReport()
    End Sub





End Class