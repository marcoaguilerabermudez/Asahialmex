Imports System.IO

Public Class ContenedorReportePO

    Public codigo As Integer
    Public serie As String
    Private Sub ContenedorReportePO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet36.Sp_ReportePO' Puede moverla o quitarla según sea necesario.
        DataSet36.EnforceConstraints = False
        Me.Sp_ReportePOTableAdapter.Fill(Me.DataSet36.Sp_ReportePO, serie, codigo)

        Me.ReportViewer1.RefreshReport()



        Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "*PDF files (*.pdf)|*.pdf"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        Dim newFile As New FileStream("V:\" & codigo & ".pdf", FileMode.Create)
        newFile.Write(byteViewer, 0, byteViewer.Length)
        newFile.Close()

    End Sub
End Class
