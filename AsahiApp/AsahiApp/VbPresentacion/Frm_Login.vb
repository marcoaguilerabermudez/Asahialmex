Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Clases
Imports Negocio

Public Class Frm_Login
    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cadConex As SqlConnection
    Dim count As Integer = 0
    Public uss As String

    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New conexion()
        If Strings.Left(conexion.getIp(), 6) = "172.16" Then
            Me.cadenaConex = conexion.cadenaConex
            Me.cadConex = conexion.conexion
            Me.cadenaCExpress = conexion.cadenaConexExpress
        Else
            Me.cadenaConex = conexion.cadenaConexFor
            Me.cadConex = conexion.conexionFor
            Me.cadenaCExpress = conexion.cadenaConexExpressFor
        End If
    End Sub
    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click
        Dim NEmple As New NEmpleado()
        Dim emp As New Empleado()


        If Txt_NombreUsuario.Text <> "" And Txt_Contrase�a.Text <> "" Then
            emp = NEmple.EmpleadoLogin(cadenaCExpress, Txt_NombreUsuario.Text, Txt_Contrase�a.Text)
            If emp.Respuesta = 2 Then
                Dim principal As New Frm_Principal(cadConex, cadenaConex, Me.cadenaCExpress, emp)



                principal.Show()

                Me.Close()
            ElseIf emp.Respuesta = 0 Then
                MsgBox("Usuario Erroneo")
                Txt_NombreUsuario.Text = ""
                Txt_Contrase�a.Text = ""
                Txt_NombreUsuario.Select()
                Me.count += 1
            ElseIf emp.Respuesta = 1 Then
                MsgBox("Contrase�a Erronea")
                Txt_Contrase�a.Text = ""
                Txt_Contrase�a.Select()
                Me.count += 1
            End If
        Else
            MsgBox("Tienes que ingresar usuario y contrase�a")
        End If
        If Me.count = 3 Then

            Me.Close()
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class
