﻿Public Class Fr_reportefaltajusinj
    Public id As Integer
    Public Tipo As Integer
    Public motivo As Integer
    Public retardo As Integer

    Private Sub Fr_reportefaltajusinj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetRh_Reportes.Sp_reporteincidencia' Puede moverla o quitarla según sea necesario.
        Me.Sp_reporteincidenciaTableAdapter.Fill(Me.DatasetRh_Reportes.Sp_reporteincidencia, id, Tipo, motivo, retardo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class