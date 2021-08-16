Imports System.Data.SqlClient

Public Class ReporteMedidas

    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection

    Public cadenagi As String
    Public cadenaCgiro As String
    Public cnn2 As SqlConnection

    Dim tipo As Integer
    Dim estado As Integer


    Private Sub ReporteMedidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New conexion()
        If Strings.Left(conexion.getIp(), 6) = "172.16" Then
            Me.cadenaConex = conexion.cadenaConex
            Me.cnn = conexion.cadenaConexExpress1
            Me.cadenaCExpress = conexion.cadenaConexExpress

            Me.cnn2 = conexion.cadenagiro


        Else
            Me.cadenaConex = conexion.cadenaConexFor
            Me.cnn = conexion.conexionExpressFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor


            Me.cnn2 = conexion.cadenagirofor

        End If

        tipo = 0
        estado = 0

    End Sub

    Private Sub cbx_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tipo.SelectedIndexChanged
        cbx_tipo.DropDownStyle = ComboBoxStyle.DropDownList

        If cbx_tipo.Text = "Todos" Then
            tipo = 0
        ElseIf cbx_tipo.Text = "Por ausentismo" Then
            tipo = 2
        ElseIf cbx_tipo.Text = "Varios" Then
            tipo = 1
        End If
    End Sub

    Private Sub cbx_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_estado.SelectedIndexChanged
        cbx_estado.DropDownStyle = ComboBoxStyle.DropDownList

        If cbx_estado.Text = "Todas" Then
            tipo = 0
        ElseIf cbx_estado.Text = "Creada" Then
            tipo = 1
        ElseIf cbx_estado.Text = "Aplicada" Then
            tipo = 2
        ElseIf cbx_estado.Text = "Cancelada" Then
            tipo = 3
        ElseIf cbx_estado.Text = "Creada y Aplicada" Then
            tipo = 4
        End If


        'Creada
        'Aplicada
        'Cancelada
        'Creada y Aplicada

    End Sub
End Class