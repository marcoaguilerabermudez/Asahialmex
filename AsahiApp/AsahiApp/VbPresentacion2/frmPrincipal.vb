Imports System.Windows.Forms
Imports Clases
Imports System.Configuration
Imports Negocio

Public Class FrmPrincipal
    Public usuario As New Usuario
    Public cadenaConex As String
    Public idSuc As Integer
    Private idAgente As Integer
    Private nombreAgente As String
    Private pedidoAgente As String

    Sub New()

        InitializeComponent()

        '=====>>>>Esta es una prueba de fusion de la Ramma Dorian<<<<=//////==

    End Sub
    Sub New(ByVal objusuario As Usuario)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.usuario = objusuario
    End Sub

    Sub New(ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.cadenaConex = cadenaConex
    End Sub
    'Formulario de Ciudad
    Private Sub CiudadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CiudadToolStripMenuItem1.Click
        Dim ciudad As New frmCiudad(1, Me.cadenaConex)
        ciudad.MdiParent = Me
        ciudad.Show()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load

        DesactivarMenu()
        Dim FrmLogin As New FrmLogin()
        FrmLogin.MdiParent = Me
        FrmLogin.Show()
    End Sub
    ''' <summary>
    ''' Deshabilita Los menus del contenedor
    ''' </summary>
    Private Sub DesactivarMenu()
        ConfiguracionToolStripMenuItem.Enabled = False
        VentasToolStripMenuItem.Enabled = False
        AlmacenToolStripMenuItem.Enabled = False
        CatalogosToolStripMenuItem1.Enabled = False
        UtileriasToolStripMenuItem.Enabled = False
        AyudaToolStripMenuItem.Enabled = False

    End Sub
    ''' <summary>
    ''' habilita Los menus del contenedor
    ''' </summary>
    Public Sub ActivarMenu()
        ConfiguracionToolStripMenuItem.Enabled = True
        VentasToolStripMenuItem.Enabled = True
        AlmacenToolStripMenuItem.Enabled = True
        CatalogosToolStripMenuItem1.Enabled = True
        UtileriasToolStripMenuItem.Enabled = True
        AyudaToolStripMenuItem.Enabled = True
    End Sub
    Private Sub PedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem.Click
        Dim estatus As New FrmEstatus(Me.usuario, Me.idSuc, 1, Me.cadenaConex) 'se manda idagente y nombreagente en el constructor
        estatus.MdiParent = Me
        estatus.Show()
    End Sub

    Public Function FormularioAbierto(formulario As Form) As Boolean
        Dim r As Boolean
        For Each f As Form In Application.OpenForms
            If f.Name = formulario.Name Then
                r = True
            End If
        Next
        Return r
    End Function
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim acerca As New FrmAcercaDe(1, Me.cadenaConex)
        acerca.MdiParent = Me
        If FormularioAbierto(FrmAcercaDe) = False Then
            acerca.Show()
        End If
    End Sub
    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim usuarios As New FrmUsuarios(1, Me.cadenaConex)
        usuarios.MdiParent = Me
        If FormularioAbierto(FrmUsuarios) = False Then
            usuarios.Show()
        End If
    End Sub

    Private Sub MarcaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MarcaToolStripMenuItem.Click
        Dim Marca As New FrmMarcas(1, Me.cadenaConex)
        Marca.MdiParent = Me
        Marca.Show()
    End Sub


    Private Sub PaqueteriasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PaqueteriasToolStripMenuItem1.Click
        Dim Paq As New FrmPaqueterias(1, Me.cadenaConex)
        Paq.MdiParent = Me
        Paq.Show()
    End Sub


    Private Sub ProductosSATToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosSATToolStripMenuItem1.Click
        Dim CodigoSat As New FrmCodigosSat(1, Me.cadenaConex)
        CodigoSat.MdiParent = Me
        CodigoSat.Show()
    End Sub

    Private Sub TicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketToolStripMenuItem.Click
        Dim Soporte As New FrmSoporte(Me.usuario, Me.cadenaConex)
        Soporte.Show()

    End Sub

    Private Sub StatusDeTicketsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusDeTicketsToolStripMenuItem.Click
        Dim statusTicket As New FrmStatusSoporte(Me.usuario, Me.cadenaConex)
        statusTicket.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim cliente As New FrmCliente(1, Me.cadenaConex)
        cliente.MdiParent = Me
        If FormularioAbierto(FrmUsuarios) = False Then
            cliente.Show()
        End If
    End Sub
    Private Sub ClasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClasesToolStripMenuItem.Click
        Dim Clases As New FrmClase(1, Me.cadenaConex)
        Clases.MdiParent = Me
        Clases.Show()
    End Sub

    Private Sub AgentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgentesToolStripMenuItem.Click
        Dim Agente As New FrmAgentes(1, Me.cadenaConex)
        Agente.MdiParent = Me
        Agente.Show()
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcasToolStripMenuItem.Click
        Dim Marca As New FrmMarcas(1, Me.cadenaConex)
        Marca.MdiParent = Me
        Marca.Show()
    End Sub

    Private Sub TipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoToolStripMenuItem.Click
        Dim tipo As New FrmTipo(1, Me.cadenaConex)
        tipo.MdiParent = Me
        tipo.Show()
    End Sub

    Private Sub ProductosSatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoSatToolStripMenuItem.Click
        Dim CodigoSat As New FrmCodigosSat(1, Me.cadenaConex)
        CodigoSat.MdiParent = Me
        CodigoSat.Show()
    End Sub
    Private Sub PaqueteriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaqueteriasToolStripMenuItem.Click
        Dim Paq As New FrmPaqueterias(1, Me.cadenaConex)
        Paq.MdiParent = Me
        Paq.Show()
    End Sub

    Private Sub CodigosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodigosToolStripMenuItem.Click
        Dim Codigos As New FrmCodigos(1, Me.cadenaConex)
        Codigos.MdiParent = Me
        If FormularioAbierto(FrmUsuarios) = False Then
            Codigos.Show()
        End If
    End Sub

    Private Sub CiudadToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CiudadToolStripMenuItem.Click
        Dim ciudad As New frmCiudad(1, Me.cadenaConex)
        ciudad.MdiParent = Me
        ciudad.Show()
    End Sub
    Private Sub FacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem.Click
        Dim estatus As New FrmEstatus(Me.usuario, Me.idSuc, 2, Me.cadenaConex)
        estatus.MdiParent = Me
        estatus.Show()

    End Sub

    Private Sub ConfiguracionGralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionGralToolStripMenuItem.Click
        Dim Configuracion As New FrmConfiguracionGral(usuario.Id, idSuc, Me.cadenaConex)
        Configuracion.MdiParent = Me
        Configuracion.Show()
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        Dim FrmSucursales As New FrmSucursales(Me.usuario)
        FrmSucursales.MdiParent = Me
        FrmSucursales.Show()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CatalogosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CatalogosToolStripMenuItem1.Click

    End Sub

    Private Sub CodigosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CodigosToolStripMenuItem1.Click
        Dim codigos As New FrmCodigos(Me.usuario.Id, cadenaConex)
        codigos.MdiParent = Me
        codigos.Show()
    End Sub
End Class


