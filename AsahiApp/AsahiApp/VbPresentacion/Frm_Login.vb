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
    'Private _path As String
    'Private _filterAttribute As String
    'Private _descripcion As String

    'Public Sub New()

    '    ' Esta llamada es exigida por el diseñador.
    '    InitializeComponent()

    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    'End Sub
    'Public Sub New(ByVal path As String)
    '    _path = path
    'End Sub
    'Public ReadOnly Property isDisplayName() As Integer
    '    Get
    '        Return _descripcion
    '    End Get
    'End Property
    'Public Function Devuelve_Propiedad(ByVal Domain As String, ByVal username As String, ByVal pwd As String, ByVal Propiedad As String) As String
    '    Dim domainAndUsername As String = (Domain & "\") + username
    '    Dim entry As New DirectoryEntry(_path, domainAndUsername, pwd)

    '    Try
    '        Dim search As New DirectorySearcher(entry)
    '        search.Filter = "(&(objectClass=user)(anr=" + username + "))"
    '        Dim resEnt As SearchResult = search.FindOne()
    '        Dim de As DirectoryEntry = resEnt.GetDirectoryEntry()

    '        _descripcion = de.Properties(Propiedad).Value.ToString

    '        entry.Close()
    '    Catch ex As Exception
    '        Return "Error al traer la informacion"
    '    End Try

    '    Return _descripcion
    'End Function
    'Public Function IsAuthenticated(ByVal Domain As String, ByVal username As String, ByVal pwd As String) As Boolean
    '    Dim Success As Boolean = False
    '    Dim Entry As New System.DirectoryServices.DirectoryEntry("LDAP://" & Domain, username, pwd)
    '    Dim Searcher As New System.DirectoryServices.DirectorySearcher(Entry)
    '    Searcher.SearchScope = DirectoryServices.SearchScope.OneLevel
    '    Try
    '        Dim Results As System.DirectoryServices.SearchResult = Searcher.FindOne
    '        Success = Not (Results Is Nothing)
    '    Catch
    '        Success = False
    '    End Try
    '    Return Success
    'End Function
    'Public Function GetGroups() As String
    '    Dim search As New DirectorySearcher(_path)
    '    search.Filter = "(cn=" & _filterAttribute & ")"
    '    search.PropertiesToLoad.Add("memberOf")
    '    Dim groupNames As New StringBuilder()

    '    Try
    '        Dim result As SearchResult = search.FindOne()

    '        Dim propertyCount As Integer = result.Properties("memberOf").Count

    '        Dim dn As String
    '        Dim equalsIndex As Integer, commaIndex As Integer

    '        For propertyCounter As Integer = 0 To propertyCount - 1
    '            dn = DirectCast(result.Properties("memberOf")(propertyCounter), String)

    '            equalsIndex = dn.IndexOf("=", 1)
    '            commaIndex = dn.IndexOf(",", 1)
    '            If -1 = equalsIndex Then
    '                Return Nothing
    '            End If

    '            groupNames.Append(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1))
    '            groupNames.Append("|")

    '        Next
    '    Catch ex As Exception
    '        Throw New Exception("Error obtaining group names. " & ex.Message)
    '    End Try
    '    Return groupNames.ToString()
    'End Function


    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.
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
        If up <> "" Then
            Txt_NombreUsuario.Text = up
            Txt_Contraseña.Select()
        End If
    End Sub


    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click
        Dim NEmple As New NEmpleado()
        Dim emp As New Empleado()


        If Txt_NombreUsuario.Text <> "" And Txt_Contraseña.Text <> "" Then


            If Txt_NombreUsuario.Text <> "x" Then
                Dim context As New PrincipalContext(ContextType.Domain)
                If Not IsNothing(context.ConnectedServer) Or context.ConnectedServer <> "Servidor.asahialmex.local" Then
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
