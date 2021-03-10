Public Class ContenedorReporteKardexIncidencias

    Public clave As Integer
    Public año As Integer

    Private Sub ContenedorReporteKardexIncidencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11.Sp_muestrakardexempleado' table. You can move, or remove it, as needed.
        Me.Sp_muestrakardexempleadoTableAdapter.Fill(Me.DataSet11.Sp_muestrakardexempleado, clave, año)

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class