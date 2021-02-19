Imports System.Data.SqlClient

Public Class EligeEvaluación

    Dim id As Integer
    Dim id_eval As Integer
    Dim tipo As String
    Dim estado As Integer
    Dim depto As String
    Dim permiso As Integer
    Dim a As String
    Dim mes As Integer
    Dim id_puesto As Integer
    Dim Cn As New SqlConnection("data source =GIRO\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word")

    Sub New(id As Integer, depto As String, permiso As Integer, id_puesto As Integer)
        InitializeComponent()
        Me.id = id
        Me.depto = depto
        Me.permiso = permiso
        Me.id_puesto = id_puesto

    End Sub


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim Principaleva As New EvaluacionesPrincipal(id, depto, permiso)
        Principaleva.Show()
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Principalevaindi As New EvaluacionPrincipalIndirecto(id, depto, permiso, id_puesto)
        Principalevaindi.Show()
        Me.Dispose()
        Me.Close()

    End Sub
End Class