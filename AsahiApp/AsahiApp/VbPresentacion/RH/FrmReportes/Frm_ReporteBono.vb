Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class Frm_ReporteBono
    Private Sub Frm_ReporteBono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
    End Sub
End Class