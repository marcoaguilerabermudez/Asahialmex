Imports Clases
Imports Negocio

Public Class Frm_ValidarConta
#Region "Varianbles de clase"
    Dim cadenaConex As String
    Dim cadConex As String
#End Region
#Region "Acciones del formulario"
    Private Sub Frm_ValidarConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conex As New conexion()
        Me.cadenaConex = conex.cadenaConexExpress
        Me.cadConex = conex.conexion2008

    End Sub
#End Region
End Class