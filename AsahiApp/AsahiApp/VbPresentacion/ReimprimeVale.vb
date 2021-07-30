Imports System.Data.SqlClient

Public Class ReimprimeVale
    Dim depto As String
    Dim permiso As Integer
    Dim id As Integer
    Dim nombre As String
    Dim p_vales As Integer
    Dim Cantidad_Requerida As Double
    Dim Ruta As String

    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cnn As SqlConnection
    Public cnn2 As SqlConnection

    Dim y As Integer


    Sub New(id As Integer, depto As String, permiso As Integer, nombre As String, p_vales As Integer)

        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.nombre = nombre
        Me.p_vales = p_vales

    End Sub
    Private Sub ReimprimeVale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



End Class