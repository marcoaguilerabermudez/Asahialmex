Imports System.Windows.Forms
Imports System.Configuration
Imports Negocio
Imports Clases

Public Class FrmSucursales

    Private cadenaConex As String
    Private sucursal As String
    Private cadenaConexGrl As String
    Private objUsuario As New Usuario
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Sub New(usuario As Usuario)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.objUsuario = usuario
    End Sub
    ''' <summary>
    ''' este proceso recibe el nombre de la sucursal
    ''' realiza la conexión
    ''' </summary>
    ''' <param name="suc"></param>
    Public Sub FindCadena(ByVal suc As String)
        Me.cadenaConex = ConfigurationManager.ConnectionStrings(suc).ConnectionString
    End Sub

    ''' <summary>
    ''' Esta función envia la lista de sucursales
    ''' declara un objeto tipo negocios
    ''' envia la función obtener suc la cadena de conexión
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Function ObtenerSucursales() As LSucursales
        Dim negocio As New NSucursales

        Me.cadenaConexGrl = ConfigurationManager.ConnectionStrings("Leal").ConnectionString
        Return negocio.ObtenerSuc(cadenaConexGrl, Me.objUsuario.Id)
    End Function
    ''' <summary>
    ''' Proceso rellena el datagridview
    ''' llama un objeto tipo clase de la lista heredada
    ''' obtiene la información 
    ''' lo rellena
    ''' realiza ajustes en las columnas
    ''' tamaño por columna
    ''' </summary>
    Private Sub RellenarDgvSucursal()
        Dim lst As New LSucursales
        lst = ObtenerSucursales() 'OBTINE INFORMACIÓN 
        If lst.Count > 0 Then
            DgvSucursales.DataSource = lst
            DgvSucursales.RowHeadersVisible = False
            DgvSucursales.Columns(0).Width = 45
            DgvSucursales.Columns(1).Width = 150
            FrmPrincipal.Show()
        Else
            MsgBox("No tiene permiso para accesar a ninguna sucursal" & vbCrLf &
            "consulte con el administrador del sistema", vbCritical, "Sin Acceso")
            FrmPrincipal.Close()
        End If

    End Sub
    ''' <summary>
    ''' proceso que recibe la sucursal
    ''' al seleccionarlo 
    ''' llama al formulario principal 
    ''' envia la sucursal seleccionada
    ''' </summary>
    Private Function recibiid()
        Dim usuario As New FrmLogin
        Return usuario
    End Function
    ''' <summary>
    '''  Carga la variable Suc  con el dataGridview seleccionado
    '''  llama a la funcion Findcadena y envia la sucursal
    '''  se envia la cadena de conexiona al formulario principal 
    '''  y llama al proceso ActivaMenu
    '''  cierra el formulario sucursales
    ''' </summary>
    Private Sub enviaSuc()
        Dim suc As String
        suc = DgvSucursales.CurrentRow.Cells("Sucursal").Value
        FindCadena(suc)
        FrmPrincipal.cadenaConex = Me.cadenaConex
        FrmPrincipal.idSuc = DgvSucursales.CurrentRow.Cells("IdSuc").Value
        FrmPrincipal.ActivarMenu()
        Me.Close()
    End Sub
    ''' <summary>
    ''' Al abrir el Formulario Sucursales
    ''' carga el datagridview 
    ''' con la lista de sucursales
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FrmSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarDgvSucursal()
    End Sub
    ''' <summary>
    ''' al seleccionar la sucursal
    ''' con doble click
    ''' llama al formulario principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvSucursales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSucursales.CellDoubleClick
        enviaSuc()
    End Sub
    ''' <summary>
    '''  Llama al  formulario Principal 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnAbrir_Click(sender As Object, e As EventArgs) Handles BtnAbrir.Click
        enviaSuc()
    End Sub
    Private Sub DgvSucursales_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvSucursales.KeyDown
        If e.KeyCode = Keys.Enter Then
            enviaSuc()
        End If
    End Sub
End Class