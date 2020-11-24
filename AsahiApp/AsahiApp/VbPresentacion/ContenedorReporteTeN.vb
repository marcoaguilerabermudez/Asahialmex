Public Class ContenedorReporteTeN
    Public depto As String
    Public fecha As String


    Private Sub ContenedorReporteTeN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.Sp_MuestraReporteTeN' Puede moverla o quitarla según sea necesario.
        DataSet1.EnforceConstraints = False
        Me.Sp_MuestraReporteTeNTableAdapter.Fill(Me.DataSet1.Sp_MuestraReporteTeN, depto, fecha)

        Me.ReportViewer1.RefreshReport()

    End Sub


End Class