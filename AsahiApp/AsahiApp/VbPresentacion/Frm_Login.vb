Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Negocio

Public Class Frm_Login
    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cadConex As SqlConnection
    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New conexion()
        Me.cadenaConex = conexion.cadenaConex
        Me.cadConex = conexion.conexion
        Me.cadenaCExpress = conexion.cadenaConexExpress
    End Sub
    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click
        Dim principal As New Frm_Principal(cadConex, cadenaConex)
        Dim NEmple As New NEmpleado()
        Dim res As Integer
        If Txt_NombreUsuario.Text <> "" And Txt_Contraseña.Text <> "" Then
            res = NEmple.EmpleadoLogin(cadenaCExpress, Txt_NombreUsuario.Text, Txt_Contraseña.Text)
            If res = 2 Then
                principal.Show()
                Me.Close()
            ElseIf res = 0 Then
                MsgBox("Usuario Erroneo")
                Txt_NombreUsuario.Text = ""
                Txt_Contraseña.Text = ""
            ElseIf res = 1 Then
                MsgBox("Contraseña Erronea")
                Txt_NombreUsuario.Text = ""
                Txt_Contraseña.Text = ""
            End If
        Else
            MsgBox("Tienes que ingresar usuario y contraseña")
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class
