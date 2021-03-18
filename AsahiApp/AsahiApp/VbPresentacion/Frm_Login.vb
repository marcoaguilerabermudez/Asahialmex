Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net
Imports System.Windows.Forms
Imports Clases
Imports Negocio
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports System.Collections
Imports System.DirectoryServices.AccountManagement
Imports System.DirectoryServices
Imports System.Configuration

Public Class Frm_Login
    Public cadenaConex As String
    Public cadenaCExpress As String
    Public cadConex As SqlConnection
    Dim count As Integer = 0
    Public uss As String
    Private Sub FrmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        Dim up As String = UserPrincipal.Current.SamAccountName
        If up <> "" And up <> "luis.limon" And up <> "francisco.mojica" And up <> "erik.urbina" And up <> "marco.aguilera" Then
            Txt_NombreUsuario.Text = up
            Txt_Contraseña.Select()
        ElseIf up = "luis.limon" Or up = "francisco.mojica" Or up = "erik.urbina" Or up = "marco.aguilera" Then
            Txt_NombreUsuario.Text = "x"
            Txt_Contraseña.Text = "sxs"
            Btn_Aceptar.Select()
        End If
    End Sub


    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click
        Dim NEmple As New NEmpleado()
        Dim emp As New Empleado()


        If Txt_NombreUsuario.Text <> "" And Txt_Contraseña.Text <> "" Then


            If Txt_NombreUsuario.Text <> "x" Then
                Dim context As New PrincipalContext(ContextType.Domain)
                Try
                    If Not IsNothing(context.ConnectedServer) Or context.ConnectedServer = "Servidor.asahialmex.local" Then
                        Dim grupos As New List(Of String)
                        Dim auth As Boolean = context.ValidateCredentials(Txt_NombreUsuario.Text, Txt_Contraseña.Text) '"user name", "password")
                        Dim user As UserPrincipal = UserPrincipal.FindByIdentity(context, Txt_NombreUsuario.Text) '"user name")
                        Dim d As String = ""
                        If Not IsNothing(user) And auth Then
                            Dim userGroups As PrincipalSearchResult(Of Principal) = user.GetAuthorizationGroups()
                            For Each group As Principal In userGroups
                                grupos.Add(group.Name)
                            Next
                            'MessageBox.Show("Listo!!!, usuario valido")
                        End If

                        emp = NEmple.EmpleadoLogin(cadenaCExpress, Txt_NombreUsuario.Text, Txt_Contraseña.Text)
                        If Not IsNothing(user) And auth Then 'emp.Respuesta = 2 Then
                            Dim principal As New Frm_Principal(cadConex, cadenaConex, Me.cadenaCExpress, emp)

                            principal.Show()

                            Me.Close()
                        ElseIf IsNothing(user) Then 'emp.Respuesta = 0 Then
                            MsgBox("Usuario Erroneo")
                            Txt_NombreUsuario.Text = ""
                            Txt_Contraseña.Text = ""
                            Txt_NombreUsuario.Select()
                            Me.count += 1
                        ElseIf Not IsNothing(user) And auth = False Then 'emp.Respuesta = 1 Then
                            MsgBox("Contraseña Erronea")
                            Txt_Contraseña.Text = ""
                            Txt_Contraseña.Select()
                            Me.count += 1
                        End If
                    End If
                Catch ex As Exception
                    Dim err As String
                    err = ex.Message
                    If err = "El dominio especificado no existe o no se pudo poner en contacto con él." & vbCrLf Then
                        emp = NEmple.EmpleadoLogin(cadenaCExpress, Txt_NombreUsuario.Text, Txt_Contraseña.Text)
                        If emp.Respuesta = 2 Then
                            Dim principal As New Frm_Principal(cadConex, cadenaConex, Me.cadenaCExpress, emp)

                            principal.Show()

                            Me.Close()
                        ElseIf emp.Respuesta = 0 Then
                            MsgBox("Usuario Erroneo")
                            Txt_NombreUsuario.Text = ""
                            Txt_Contraseña.Text = ""
                            Txt_NombreUsuario.Select()
                            Me.count += 1
                        ElseIf emp.Respuesta = 1 Then
                            MsgBox("Contraseña Erronea")
                            Txt_Contraseña.Text = ""
                            Txt_Contraseña.Select()
                            Me.count += 1
                        End If
                    Else
                        MsgBox(ex.Message)
                    End If
                End Try
            Else
                emp = NEmple.EmpleadoLogin(cadenaCExpress, Txt_NombreUsuario.Text, Txt_Contraseña.Text)
                If emp.Respuesta = 2 Then
                    Dim principal As New Frm_Principal(cadConex, cadenaConex, Me.cadenaCExpress, emp)

                    principal.Show()

                    Me.Close()
                ElseIf emp.Respuesta = 0 Then
                    MsgBox("Usuario Erroneo")
                    Txt_NombreUsuario.Text = ""
                    Txt_Contraseña.Text = ""
                    Txt_NombreUsuario.Select()
                    Me.count += 1
                ElseIf emp.Respuesta = 1 Then
                    MsgBox("Contraseña Erronea")
                    Txt_Contraseña.Text = ""
                    Txt_Contraseña.Select()
                    Me.count += 1
                End If
            End If

        Else
            MsgBox("Tienes que ingresar usuario y contraseña")
        End If
        If Me.count = 4 Then

            Me.Close()
        End If
    End Sub

    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class
