﻿Public Class ContenedorReporteComision
    Public id As Integer
    Public Tipo As Integer
    Public motivo As Integer
    Public retardo As Integer
    Private Sub ContenedorReporteComision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet18.Sp_reporteincidencia' Puede moverla o quitarla según sea necesario.
        Me.Sp_reporteincidenciaTableAdapter.Fill(Me.DataSet18.Sp_reporteincidencia, id, Tipo, motivo, retardo)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class