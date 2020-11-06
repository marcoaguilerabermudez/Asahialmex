Public Class ReporteTest
    Public departamento As Integer
    Public fecha As String
    Private Sub ReporteTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtstReporteTest.Sp_Valeboxluch' Puede moverla o quitarla según sea necesario.




        Me.Sp_ValeboxluchTableAdapter.Fill(Me.DtstReporteTest.Sp_Valeboxluch, departamento, fecha)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class