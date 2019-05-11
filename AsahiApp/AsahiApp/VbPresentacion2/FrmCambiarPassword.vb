Imports Clases
Imports Negocio
Imports System.Configuration

Public Class FrmCambiarPassword
    Dim objusuario As New Usuario
    Dim cadenaConex As String
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal objusuario As Usuario)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.objusuario = objusuario
        Me.cadenaConex = ConfigurationManager.ConnectionStrings("leal").ConnectionString
    End Sub

    Private Function CompararPassword() As Boolean
        If (TxtNueva1.Text = TxtNueva2.Text) Then
            Return True
        Else
            MsgBox("Las contraseñas no coinciden entre sí")
            Return False
        End If
    End Function
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtNueva1.Text = "" Or TxtNueva2.Text = "" Then 'si no ha escrito la contraseña nueva
            MsgBox("Falta poner la contraseña nueva y confirmarla")
        Else
            If CompararPassword() = True Then
                Me.objusuario.Pass = TxtActual.Text
                Me.objusuario.PassNuevo = TxtNueva2.Text
                Dim Negocios As New NUsuario()
                Negocios.CambiarPassword(Me.cadenaConex, Me.objusuario)
                MsgBox("Contraseña cambiada correctamente")
                TxtActual.Text = Nothing
                TxtNueva1.Text = Nothing
                TxtNueva2.Text = Nothing
            End If
        End If
    End Sub

    Private Sub FrmCambiarPassword_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtNueva2.Enabled = False
        TxtNueva1.Enabled = False
    End Sub

    Private Sub TxtActual_TextChanged(sender As Object, e As EventArgs) Handles TxtActual.TextChanged
        If TxtActual.Text = "" Then
            TxtNueva1.Enabled = False
            TxtNueva2.Enabled = False
        Else
            TxtNueva1.Enabled = True
            TxtNueva2.Enabled = True
        End If
    End Sub
End Class
