Imports Negocio
Imports Clases
Imports System.Windows.Forms

Public Class FrmFiltro
#Region "Variables"
    Public pedidos As New Pedido
    Private idrecuperado As String
    Private cadenaConex As String
    Dim orig As SByte 'pedidos=1,facturas=2
    Public inicio As String
    Public final As String
    Public idCte As Integer
    Public idVen As Integer
    Public edoFact As Boolean
    Public edotimb As Boolean
#End Region
#Region "Constructores"
    Sub New(ByVal origen As SByte, cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.orig = origen
        Me.cadenaConex = cadenaConex
    End Sub
    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
#End Region
#Region "Rellenar"
    Private Function RellenarFiltro()
        Dim value As Object = CmbVendedor.SelectedValue
        Me.inicio = TxtFechaInicio.Text
        Me.final = TxtFechaFinal.Text
        If TxtCliente.Text <> Nothing Then
            pedidos.IdCliente = TxtCliente.Text
            pedidos.Cliente = Agente.Text
        End If
        If CmbVendedor.Text <> Nothing Then
            pedidos.Agente = CmbVendedor.Text
            pedidos.IdAgente = Convert.ToString(value)
        End If

        If RdCancelados.Checked = True Then
            pedidos.Estado = "Cancelado"
        ElseIf RdFacturados.Checked = True Then
            pedidos.Estado = "Facturado"
        ElseIf RdTodos.Checked = True Then
            pedidos.Estado = "Todo"
        ElseIf RdPendientes.Checked = True Then
            pedidos.Estado = "Pendiente"
        End If
        Return pedidos
    End Function
    Private Sub RellenaVariables()
        Me.inicio = TxtFechaInicio.Text
        Me.final = TxtFechaFinal.Text
        If TxtCliente.Text = "" Then
            Me.idCte = 0
        Else
            Me.idCte = TxtCliente.Text
        End If
        If CmbVendedor.SelectedItem Is Nothing Then
            Me.idVen = 0
        Else
            Me.idVen = CmbVendedor.SelectedItem.IdAgente
        End If
        Me.edoFact = RdFacturasCanceladas.Checked
        Me.edotimb = RdFacturasTimbradas.Checked
    End Sub
#End Region
#Region "Acciones del Formulario"
    Private Sub FrmFiltro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFechaFinal.Text = Format(DateTime.Now, "dd/MM/yyyy")
        TxtFechaInicio.Text = Format(DateTime.Now, "dd/MM/yyyy")
        BtnF3.Visible = False
        RellenarAgentes()
        MostrarElementos()
    End Sub
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim objFactura As New Factura()
        Dim objNFactura As New NFactura()
        If orig = 1 Then
            RellenarFiltro()
        Else
            RellenaVariables()
        End If
        DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub
    Private Sub BtnF3_Click(sender As Object, e As EventArgs) Handles BtnF3.Click
        Dim frmBuscar As New FrmBuscador(1, 1, cadenaConex)
        If frmBuscar.ShowDialog() = DialogResult.OK Then
            idrecuperado = frmBuscar.Id
            TxtCliente.Text = frmBuscar.Id
            Agente.Text = frmBuscar.Agente
        End If
    End Sub
    Private Sub TxtCliente_Click(sender As Object, e As EventArgs) Handles TxtCliente.Click
        BtnF3.Visible = True
    End Sub
#End Region
#Region "Rellena Cmb"
    Private Sub RellenarAgentes()
        Dim lista As New LAgente
        lista = ObtenerAgentes()
        With CmbVendedor
            .DataSource = lista
            .DisplayMember = "NombreAgente"
            .ValueMember = "IdAgente"
            .SelectedValue = ""
        End With
    End Sub
#End Region
    Private Sub MostrarElementos()
        If orig = 1 Then
            RdCancelados.Visible = True
            RdFacturados.Visible = True
            RdPendientes.Visible = True
            RdTodos.Visible = True
        Else
            RdFacturasCanceladas.Visible = True
            RdFacturasTimbradas.Visible = True
        End If
    End Sub
    Private Function ObtenerAgentes()
        Dim negocio As New NAgente
        Dim lista As New LAgente
        lista = negocio.ObtenerAgentes(cadenaConex)
        Return lista
    End Function


End Class