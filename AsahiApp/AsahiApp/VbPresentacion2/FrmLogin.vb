Imports System.Windows.Forms
Imports Negocio
Imports Clases
Imports System.Configuration

Public Class FrmLogin
    Private cadenaConex As String
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cadenaConex = ConfigurationManager.ConnectionStrings("leal").ConnectionString
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim objN As New NUsuario()
        Dim objUsuario As New Usuario()
        objUsuario.Nombre = TxtUsuario.Text
        objUsuario.Pass = TxtPassword.Text
        objUsuario = objN.Login(cadenaConex, objUsuario)

        If objUsuario.Acceso Then
            Me.Hide()
            FrmPrincipal.usuario = objUsuario  'envia el objUsuario a formulario sucursales
            Dim FrmSucursales As New FrmSucursales(objUsuario)

            FrmSucursales.Show()
            Me.Close()
        Else
            Me.Close()
            FrmPrincipal.Close()
        End If
    End Sub
    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter And TxtUsuario.Text <> "" And TxtPassword.Text <> "" Then
            BtnAceptar_Click(Me, New EventArgs)
        End If
    End Sub
End Class