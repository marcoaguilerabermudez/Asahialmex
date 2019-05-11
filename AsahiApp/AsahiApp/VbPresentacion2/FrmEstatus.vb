Imports System.Windows.Forms
Imports System.Configuration
Imports Clases
Imports Negocio

Public Class FrmEstatus
#Region "Variables de Clase"
    Dim cadenaConex As String
    Dim orig As SByte 'pedidos=1,facturas=2
    Dim usuario As New Usuario
    Dim permisoFactu As Integer
    Private idAgente As Integer
    Private nombreAgente As String
    Dim idSuc As Integer
    Dim inicio As String
    Dim final As String
    Dim idCte As Integer
    Dim idVen As Integer
    Dim edoFact As Boolean
    Dim edotimb As Boolean
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal usuario As Usuario, ByVal idSuc As Integer, ByVal origen As SByte, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
        Me.usuario = usuario
        Me.idSuc = idSuc
        Me.orig = origen
    End Sub
#End Region
#Region "Acciones de formulario"
    Private Sub FrmStatusFacturacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtFechaIn.Text = Format(DateTime.Now, "dd/MM/yyyy")
        TxtFechaFin.Text = Format(DateTime.Now, "dd/MM/yyyy")
        PermisoFactura()
        LlenarDgv()
        If orig = 1 Then
            LblTipo.Text = "Pedido"
            If permisoFactu = 1 Then BtnFacturar.Visible = True
        ElseIf orig = 2 Then
            LblTipo.Text = "Factura"
        End If
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        LlenarDgv()
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If orig = 1 Then
            If FormularioAbierto(FrmPedidos) = False Then
                If BuscarIdAgente() = False Then
                    FrmPedidos.Close()
                Else
                    Dim pedido As New FrmPedidos(usuario, Me.cadenaConex) 'se manda idagente y nombreagente en el constructor
                    pedido.Show()
                End If
            End If
        ElseIf orig = 2 Then
            Dim Factura As New FrmFactura(usuario, idSuc, 0, 0, Me.cadenaConex)
            Me.Close()
            Factura.Show()
        End If
    End Sub
    Private Sub BtnFiltrado_Click(sender As Object, e As EventArgs) Handles BtnFiltrado.Click
        Dim Filtrado As New FrmFiltro(orig, Me.cadenaConex)
        'Filtrado.Show()
        If Filtrado.ShowDialog() = DialogResult.OK Then
            If orig = 1 Then
                Dim pedido As New Pedido
                Dim lst As New LPedido
                Me.inicio = Filtrado.inicio
                Me.final = Filtrado.final
                pedido = Filtrado.pedidos
                If pedido.Estado = "" Then
                    MsgBox("Debes selecionar un estado")
                Else
                    lst = obtenerPedidoEstatus(inicio, final, pedido)
                    DgvEstatus.DataSource = lst
                    HabilitarColumnasPedido()
                End If

            ElseIf orig = 2 Then
                Dim objFactura As New Factura
                Me.inicio = Filtrado.inicio
                Me.final = Filtrado.final
                Me.idCte = Filtrado.idCte
                Me.idVen = Filtrado.idVen
                Me.edoFact = Filtrado.edoFact
                Me.edotimb = Filtrado.edotimb
                RellenaObjFactura(objFactura)
                ObtenerFacturasFiltro(objFactura)
            End If
        End If
    End Sub
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If orig = 1 Then
            Dim idPedido As Integer
            idPedido = RecuperaIdBusqueda()
            Dim Pedido As New FrmPedidos(usuario, idPedido, cadenaConex)
            'Me.Dispose()
            Pedido.Show()

        ElseIf orig = 2 Then
            Dim idFactura As Integer
            idFactura = RecuperaIdBusqueda()
            Dim factura As New FrmFactura(usuario, idSuc, idFactura, 0, cadenaConex)
            ' Me.Dispose()
            factura.Show()
        End If

    End Sub
    Private Sub DgvFacturacion_DoubleClick(sender As Object, e As EventArgs) Handles DgvEstatus.DoubleClick
        If orig = 1 Then
            Dim idPedido As Integer
            idPedido = RecuperaIdBusqueda()

            Dim Pedido As New FrmPedidos(usuario, idPedido, cadenaConex)
            '  Me.Dispose()
            Pedido.Show()

        ElseIf orig = 2 Then
            Dim idFactura As Integer
            idFactura = RecuperaIdBusqueda()

            Dim factura As New FrmFactura(usuario, idSuc, idFactura, 0, cadenaConex)
            ' Me.Dispose()
            factura.Show()
        End If
    End Sub
    Private Sub TxtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFolio.KeyDown
        If e.KeyCode = Keys.Enter Then
            If orig = 1 Then
                Dim pedido As New LPedido
                pedido = obtenerPedidoId()
                DgvEstatus.DataSource = pedido
                HabilitarColumnasPedido()
            ElseIf orig = 2 Then
                Dim objLFactu As New LFactura
                objLFactu = ObtenerInfoStatusUnitario()
                DgvEstatus.DataSource = objLFactu
                OcultarColumnas()
                FormatoDgvStatus()
            End If

        End If
    End Sub
    Private Sub FrmFacturar_Click(sender As Object, e As EventArgs) Handles BtnFacturar.Click
        Dim idPedido As Integer
        Dim idFactura As Integer
        Dim totalFirmas As Integer
        Dim nPedido As New NPedido
        idPedido = RecuperaIdBusqueda()
        totalFirmas = nPedido.ComprobarFirmas(cadenaConex, totalFirmas, idPedido)
        idFactura = nPedido.ComprobarPedidoYaFacturado(cadenaConex, idFactura, idPedido)
        If totalFirmas = 3 Then
            If idFactura = 0 Then
                Dim factura As New FrmFactura(usuario, idSuc, 0, idPedido, cadenaConex)
                factura.Show()
            Else
                MsgBox("Al pedido #" & idPedido & " ya esta facturado. No. Factura: #" & idFactura & "")
            End If
        Else
                MsgBox("Al pedido #" & idPedido & " le faltan firmas para poder facturar ")
        End If
    End Sub
#End Region
#Region "Obtener"
    Private Function ObtenerInfoStatusGral() As LFactura
        Dim objLFactu As New LFactura
        Dim objNFactu As New NFactura
        Dim inicio As Date
        Dim final As Date

        inicio = TxtFechaIn.Text
        final = TxtFechaFin.Text
        objLFactu = objNFactu.RecuperarFacturasStatus(cadenaConex, inicio, final)
        Return objLFactu
    End Function
    Private Function ObtenerInfoStatusUnitario() As LFactura
        Dim objLFactu As New LFactura
        Dim objNFactu As New NFactura
        Dim factura As Integer

        factura = TxtFolio.Text
        objLFactu = objNFactu.RecuperarFacturasStatusFactura(cadenaConex, factura)
        Return objLFactu
    End Function
    Private Sub ObtenerFacturasFiltro(objFactura As Factura)
        Dim objLFactu As New LFactura
        Dim objNFactura As New NFactura
        TxtFechaIn.Text = Me.inicio
        TxtFechaFin.Text = Me.final
        objLFactu = objNFactura.RecuperarFacturasStatusFiltro(cadenaConex, Me.inicio, Me.final, objFactura)
        DgvEstatus.DataSource = objLFactu
        OcultarColumnas()
        FormatoDgvStatus()
    End Sub
    Public Function obtenerPedidoEstatus(ByVal inicio As String, ByVal final As String, ByVal pedido As Pedido) As LPedido
        Dim negocio As New NPedido
        Dim lista As New LPedido
        TxtFechaIn.Text = Me.inicio
        TxtFechaFin.Text = Me.final
        lista = negocio.PedidosEstatus(cadenaConex, inicio, final, pedido)
        Return lista
    End Function
    Private Function obtenerPedidoId() As LPedido
        Dim negocio As New NPedido
        Dim pedido As New LPedido
        pedido = negocio.PedidoBuscar(cadenaConex, TxtFolio.Text)
        Return pedido
    End Function
#End Region
#Region "Referente a recuperar"
    Private Function RecuperaIdBusqueda() As Integer
        Dim fila As Integer
        Dim id As Integer

        If orig = 1 Then
            'si no hay celda seleccionada se toma la primera del dgv
            If DgvEstatus.CurrentRow IsNot Nothing Then
                fila = DgvEstatus.CurrentRow.Index
            Else
                fila = 0
            End If

        ElseIf orig = 2 Then
            'si no hay celda seleccionada se toma la primera del dgv
            If DgvEstatus.CurrentRow IsNot Nothing Then
                fila = DgvEstatus.CurrentRow.Index
            Else
                fila = 0
            End If
        End If
        id = DgvEstatus.Rows(fila).Cells(0).Value
        DialogResult = DialogResult.OK
        Return id


    End Function
    Private Function RellenaObjFactura(objFactura As Factura)
        With objFactura
            .IdCliente = Me.idCte
            .IdAgente = Me.idVen
            .Cancelada = Me.edoFact
            .Timbrada = Me.edotimb
        End With
        Return objFactura
    End Function
    Private Function Actualizar()
        Dim negocio As New NPedido
        Return negocio.PedidoEstatusActulizar(cadenaConex, TxtFechaIn.Text, TxtFechaFin.Text)
    End Function
#End Region
#Region "Referente al Dgv"
    Public Sub LlenarDgv()
        If orig = 1 Then
            Dim lst As New LPedido
            lst = Actualizar()
            DgvEstatus.DataSource = lst
            HabilitarColumnasPedido()
        ElseIf orig = 2 Then
            Dim objLFactu As New LFactura
            objLFactu = ObtenerInfoStatusGral()
            DgvEstatus.DataSource = objLFactu
            OcultarColumnas()
            FormatoDgvStatus()
        End If
    End Sub
    Private Sub OcultarColumnas()
        DgvEstatus.Columns("IdCliente").Visible = False
        DgvEstatus.Columns("IdAgente").Visible = False
        DgvEstatus.Columns("DiasCredito").Visible = False
        DgvEstatus.Columns("Oc").Visible = False
        DgvEstatus.Columns("Comentario").Visible = False
        DgvEstatus.Columns("Utilidad").Visible = False
        DgvEstatus.Columns("IdCondEnvio").Visible = False
        DgvEstatus.Columns("IdGuia").Visible = False
        DgvEstatus.Columns("Xml").Visible = False
        DgvEstatus.Columns("LugarExpedicion").Visible = False
        DgvEstatus.Columns("TotalLetras").Visible = False
        DgvEstatus.Columns("Serie").Visible = False
        DgvEstatus.Columns("XmlPago").Visible = False
        DgvEstatus.Columns("CondicionPago").Visible = False
        DgvEstatus.Columns("IdMetodoPago").Visible = False
        DgvEstatus.Columns("MetodoPago").Visible = False
        DgvEstatus.Columns("IdFormaPago").Visible = False
        DgvEstatus.Columns("FormaPago").Visible = False
        DgvEstatus.Columns("IdUsoCfdi").Visible = False
        DgvEstatus.Columns("UsoCfdi").Visible = False
        DgvEstatus.Columns("IdCodigoSat").Visible = False
        DgvEstatus.Columns("CodigoSat").Visible = False
        DgvEstatus.Columns("IdUnidadMedida").Visible = False
        DgvEstatus.Columns("UnidadMedida").Visible = False
        DgvEstatus.Columns("IdMoneda").Visible = False
        DgvEstatus.Columns("Moneda").Visible = False
        DgvEstatus.Columns("TipoCambio").Visible = False
        DgvEstatus.Columns("IdTipoRelacion").Visible = False
        DgvEstatus.Columns("TipoRelacion").Visible = False
        DgvEstatus.Columns("TipoCfd").Visible = False
        DgvEstatus.Columns("FolioFiscalUUID").Visible = False
    End Sub
    Private Sub FormatoDgvStatus()
        With DgvEstatus
            .Columns("IdFactura").DisplayIndex = 0
            .Columns(0).HeaderText = "Factura"
            .Columns(0).Width = 70
            .Columns("Pedido").DisplayIndex = 1
            .Columns("Pedido").Width = 70
            .Columns("Fecha").DisplayIndex = 2
            .Columns("Fecha").Width = 90
            .Columns("Hora").DisplayIndex = 3
            .Columns("Hora").Width = 115
            .Columns("Cliente").DisplayIndex = 4
            .Columns("Cliente").Width = 470
            .Columns("Subtotal").DisplayIndex = 5
            .Columns("Subtotal").Width = 100
            .Columns("Iva").DisplayIndex = 7
            .Columns("Iva").Width = 100
            .Columns("Total").DisplayIndex = 8
            .Columns("Total").Width = 100
            .Columns("Cancelada").DisplayIndex = 11
            .Columns("Cancelada").Width = 135
            .Columns("Timbrada").DisplayIndex = 12
            .Columns("Timbrada").Width = 135
        End With
    End Sub
    Private Sub HabilitarColumnasPedido()

        For i = 0 To DgvEstatus.Columns.Count - 1
            DgvEstatus.Columns(i).Visible = False
        Next
        '''' Tamaño de la columna
        DgvEstatus.Columns(2).Width = 300
        '''' columnas que solo se muestran
        DgvEstatus.Columns(0).Visible = True
        DgvEstatus.Columns(1).Visible = True
        DgvEstatus.Columns(2).Visible = True
        DgvEstatus.Columns(3).Visible = True
        DgvEstatus.Columns(4).Visible = True
        DgvEstatus.Columns(5).Visible = True
        DgvEstatus.Columns(13).Visible = True
        DgvEstatus.Columns(26).Visible = True
        DgvEstatus.Columns(27).Visible = True
        DgvEstatus.Columns(28).Visible = True
        DgvEstatus.Columns(29).Visible = True
        DgvEstatus.Columns(30).Visible = True
    End Sub
#End Region
    Public Function FormularioAbierto(formulario As Form) As Boolean
        Dim r As Boolean
        For Each f As Form In Application.OpenForms
            If f.Name = formulario.Name Then
                r = True
            End If
        Next
        Return r
    End Function
    Private Function BuscarIdAgente()
        Dim agente As New Agente
        Dim obtenerIdAgente As New NAgente
        Dim resultado As Boolean
        agente.IdAgente = Me.usuario.IdAgente
        agente = obtenerIdAgente.ObtenerAgente(cadenaConex, agente)
        If agente.IdAgente = 0 Then
            MsgBox("Este usuario no tiene un agente asignado" & Chr(13) & "y no puede realizar pedidos")
            resultado = False
        Else
            usuario.NombreAgente = agente.NombreAgente
            resultado = True
        End If
        Return resultado
    End Function
    Private Sub PermisoFactura()
        Dim nUsuario As New NUsuario
        permisoFactu = nUsuario.PermisoFactura(cadenaConex, usuario)
    End Sub
End Class