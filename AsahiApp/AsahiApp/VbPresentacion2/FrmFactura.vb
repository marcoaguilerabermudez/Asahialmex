Imports Clases
Imports Negocio
Imports System.Windows.Forms
Imports System.Net
Imports System.Net.Mail
Imports System.Drawing.Printing
Imports System.Drawing

Public Class FrmFactura
#Region "Variables de Clase"
    Private idSucursal As Integer
    Private idUsuario As Integer
    Private cadenaConex As String
    Private usuario As New Usuario


    Dim idFactura As Integer
    Dim idPedido As Integer
    Private idRecuperado As String 'id recuperado del buscador
    Private Const xCodigo As Integer = 224 'posicion X para buscarxcodigo
    Private Const xPrecio As Integer = 599 'posicion X para buscarxprecio
    Private Const yDgv As Integer = 149 'posicion y de la primera fila del Dgv
    Private tabla As SByte 'clientes=1, productos=2
    Private Const cantidadFilas As Byte = 20 'Filas para pedidos
    Private Const iva As Double = 0.16 'iva
    Private Const LugarExpedicion As String = "37450"
    Private cambios As Boolean 'guardar si existen cambios o no en el Frm
    'Info del Cliente Recuperado
    Private saldo As Double
    Private plazo As Integer
    Private bloqueo As Boolean
    Private tipoCte As Integer
    Private limiteCredito As Integer
#End Region

    Sub New(ByVal usuario As Usuario, ByVal idSuc As Integer, ByVal idFactura As Integer, ByVal idPedido As Integer, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
        Me.idSucursal = idSuc
        Me.idUsuario = usuario.Id
        Me.idFactura = idFactura
        Me.idPedido = idPedido
        Me.usuario = usuario
    End Sub
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxtLugarExpedicion.Text = LugarExpedicion
        TxtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        TxtIdCte.Select()
        CargarComboBox()
        Dim PUtilerias As New PUtilerias()
        PUtilerias.AgregarEventoCambiosFormulario(Me, "TxtFolio")
        'Esta es prueba se puede borrar'
        If Me.idFactura > 0 And Me.idPedido = 0 Then
            TxtFolio.Text = Me.idFactura
            RecuperaFactura()
            TabFirmas.Parent = TabFactura 'si el pedido es recuperado desde el Estatus
        ElseIf Me.idPedido > 0 And Me.idFactura = 0 Then
            TxtPedido.Text = Me.idPedido
            RecuperarPedido()
            TabFirmas.Parent = Nothing 'oculta la pestaña firmas
        Else
            TabFirmas.Parent = Nothing 'oculta la pestaña firmas
        End If
    End Sub
    Private Sub CargarComboBox()
        CargaCmbFormaPago()
        CargaCmbMetodoPago()
        CargaCmbDiasCredito()
        CargaCmbUsoCfdi()
        CargaMoneda()
        CargaAgente()
    End Sub

    Private Sub CargaCmbFormaPago()
        Dim NSat As New NSat()
        Dim lst As New LSat()
        lst = NSat.ObtenerFormaPagoLista(cadenaConex)
        With CmbFormaPago
            .DataSource = lst
            .ValueMember = "idFormaPago"
            .DisplayMember = "FormaPago"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub CargaCmbMetodoPago()
        Dim NSat As New NSat()
        Dim lst As New LSat()
        lst = NSat.ObtenerMetodoPagoLista(cadenaConex)
        With CmbMetodoPago
            .DataSource = lst
            .ValueMember = "idMetodoPago"
            .DisplayMember = "MetodoPago"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub CargaCmbDiasCredito()
        CmbDiasCred.Items.Add("2")
        CmbDiasCred.Items.Add("15")
        CmbDiasCred.Items.Add("30")
        CmbDiasCred.Items.Add("45")
        CmbDiasCred.Items.Add("60")
        CmbDiasCred.Items.Add("90")
    End Sub
    Private Sub CargaCmbUsoCfdi()
        Dim NSat As New NSat()
        Dim lst As New LSat()
        lst = NSat.ObtenerUsoCfdiLista(cadenaConex)
        With CmbUsoCfdi
            .DataSource = lst
            .ValueMember = "idUsoCfdi"
            .DisplayMember = "UsoCfdi"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub CargaMoneda()
        Dim NSat As New NSat()
        Dim lst As New LSat()
        lst = NSat.ObtenerMonedaLista(cadenaConex)
        With CmbMoneda
            .DataSource = lst
            .ValueMember = "idMoneda"
            .DisplayMember = "moneda"
            .SelectedValue = 2 'Pesos
        End With
    End Sub
    Private Sub CargaAgente()
        Dim Agente As New Agente()
        Dim lst As New LAgente()
        Dim NAgente As New NAgente()

        lst = NAgente.ObtenerAgentes(cadenaConex)
        With CmbAgente
            .DataSource = lst
            .ValueMember = "idAgente"
            .DisplayMember = "NombreAgente"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub CargaTipoRelacion()
        Dim NSat As New NSat()
        Dim lst As New LSat()
        lst = NSat.ObtenerTipoRelacionLista(cadenaConex)
        With CmbTipoRelacion
            .DataSource = lst
            .ValueMember = "idTipoRelacion"
            .DisplayMember = "tipoRelacion"
            .SelectedItem = Nothing
        End With
    End Sub
    ''' <summary>
    ''' Obtiene Informacion del cliente y la rellena en el Formulario
    ''' </summary>
    ''' <param name="Cliente">Obj Cliente con el Id</param>
    Private Sub RellenaCliente(ByVal Cliente As Cliente)
        Dim NCliente As New NCliente()
        Cliente = NCliente.ObtenerClienteFactura(cadenaConex, Cliente)
        TxtIdCte.Text = Cliente.IdCliente
        TxtNombreCte.Text = Cliente.Nombre
        If Cliente.IdAgente <> 0 Then CmbAgente.SelectedValue = Cliente.IdAgente
        If Cliente.IdMetodoPago <> "" Then CmbMetodoPago.SelectedValue = Cliente.IdMetodoPago
        If Cliente.IdFormaPago <> 0 Then CmbFormaPago.SelectedValue = Cliente.IdFormaPago
        If Cliente.IdUsoCfdi <> "" Then CmbUsoCfdi.SelectedValue = Cliente.IdUsoCfdi
        If Cliente.IdMoneda <> 0 Then CmbMoneda.SelectedValue = Cliente.IdMoneda
    End Sub
    ''' <summary>
    ''' Descarga la cabecera de la factura en los controles correspondientes
    ''' </summary>
    ''' <param name="Factura">Informacion de la cabecera</param>
    ''' <param name="Cliente">Nombre y Condiciones de Credito del Cliente</param>
    Private Sub RellenaControlesCabecera(ByVal Factura As Factura, ByVal Cliente As Cliente)
        TxtFechaEmision.Text = Factura.Fecha
        TxtIdCte.Text = Factura.IdCliente
        CmbMetodoPago.SelectedValue = Factura.IdMetodoPago
        CmbDiasCred.SelectedItem = Factura.DiasCredito.ToString()
        CmbFormaPago.SelectedValue = Factura.IdFormaPago
        CmbUsoCfdi.SelectedValue = Factura.IdUsoCfdi
        CmbMoneda.SelectedValue = Factura.IdMoneda
        CmbAgente.SelectedValue = Factura.IdAgente
        TxtSubtotal.Text = Factura.Subtotal
        TxtIva.Text = Factura.Iva
        txtTotal.Text = Factura.Total
        TxtUtilidad.Text = Factura.Utilidad
        LblLetras.Text = Factura.TotalLetras

        TxtNombreCte.Text = Cliente.Nombre
        CargaCreditoCliente(Cliente)

        TxtLugarExpedicion.Text = LugarExpedicion
        If Factura.Timbrada Then BtnTimbrar.Enabled = False
        VerificarCancelada(Factura)
    End Sub
    Private Sub RecuperarFirmas(ByVal cadenaConex As String, ByVal objFactura As Factura, ByVal objCliente As Cliente)
        Dim NFirma As New NFirma
        Dim objFirma As New Firma

        objFirma = NFirma.ObtenerFirmasFacturas(cadenaConex, objFactura)
        RellenaClienteFirma(objCliente)
        RellenaFirmas(objFirma)
    End Sub
    Private Sub RellenaClienteFirma(ByVal objCliente As Cliente)
        Dim tipoClienFirma As String

        Me.tipoCte = objCliente.IdTipoCliente
        Select Case Me.tipoCte
            Case 1
                tipoClienFirma = "Prospecto"
            Case 2
                tipoClienFirma = "Usuario"
            Case 3
                tipoClienFirma = "Distribuidor"
        End Select

        TxtClienteFirma.Text = TxtNombreCte.Text
        TxtAgenteFirma.Text = CmbAgente.Text
        TxtUtilFirma.Text = TxtUtilidad.Text
        TxtTotalFirma.Text = txtTotal.Text
        TxtDiasCredFirma.Text = CmbDiasCred.Text
        TxtMetoPagoFirma.Text = CmbMetodoPago.Text
        TxtOrdComFirma.Text = TxtOc.Text
        TxtTipoCliente.Text = tipoClienFirma
        TxtLimCredFirma.Text = Me.limiteCredito
        TxtSaldoFirma.Text = Me.saldo


        If objCliente.FechaAlta = "1/1/1900" Then
            TxtUltimoMov.Text = ""
        Else
            TxtFechaAlta.Text = objCliente.FechaAlta
        End If

        If objCliente.UltimoMov = "1/1/1900" Then
            TxtUltimoMov.Text = ""
        Else
            TxtUltimoMov.Text = objCliente.UltimoMov
        End If

        TxtObservaciones.Text = objCliente.Observacion
        TxtLimCredFirma.Text = Format(CType(TxtLimCredFirma.Text, Decimal), "$ #,##0.00")
        TxtSaldoFirma.Text = Format(CType(TxtSaldoFirma.Text, Decimal), "$ #,##0.00")
    End Sub
    Private Sub RellenaFirmas(ByVal objFirma As Firma)
        If objFirma.FechaVtas = "1/1/1900 12:00:00 AM" Or objFirma.FechaVtas = "1/1/0001 12:00:00 AM" Then
            LblFirmaVtas.Text = ""
            LblComenVta.Text = ""
        Else
            LblFirmaVtas.Text = objFirma.FirmaVtas
            LblComenVta.Text = objFirma.FechaVtas + " " + objFirma.HoraVtas + " " + objFirma.ComentVtas
            LblFirmaVtas.Visible = True
            LblComenVta.Visible = True
        End If

        If objFirma.FechaCxc = "1/1/1900 12:00:00 AM" Or objFirma.FechaCxc = "1/1/0001 12:00:00 AM" Then
            LblFirmaCxc.Text = ""
            'LblComenAlmacen.Text = ""
        Else
            LblFirmaCxc.Text = objFirma.FirmaCxc
            LblComentCxc.Text = objFirma.FechaCxc + " " + objFirma.HoraCxc + " " + objFirma.ComentCxc
            LblFirmaCxc.Visible = True
            LblComentCxc.Visible = True
        End If
    End Sub
#Region "Eventos relacionados con el DataGridView"
    ''' <summary>
    ''' Descarga la lista de productos en el DGV
    ''' </summary>
    ''' <param name="Detalle">Lista de Productos</param>
    Private Sub RellenaDgvDetalle(ByVal Detalle As LProducto)
        Dim fila As Byte = 0 'contador para fila del DGV

        For Each item In Detalle
            DgvFactura.Rows.Add()
            DgvFactura.Rows(fila).Cells("IdDetalle").Value = item.IdDetalle
            DgvFactura.Rows(fila).Cells("Cantidad").Value = item.Cantidad
            DgvFactura.Rows(fila).Cells("Unidad").Value = item.IdUnidad
            DgvFactura.Rows(fila).Cells("Codigo").Value = item.Codigo
            DgvFactura.Rows(fila).Cells("CodigoSat").Value = item.IdCodigoSat
            DgvFactura.Rows(fila).Cells("Descripcion").Value = item.Descripcion
            DgvFactura.Rows(fila).Cells("Precio").Value = item.Precio
            DgvFactura.Rows(fila).Cells("PrecioTotal").Value = item.PrecioTotal
            DgvFactura.Rows(fila).Cells("DgvIva").Value = item.IvaTotal
            DgvFactura.Rows(fila).Cells("Subtotal").Value = item.Subtotal
            DgvFactura.Rows(fila).Cells("Costo").Value = item.Costo
            DgvFactura.Rows(fila).Cells("Exist").Value = item.Existencia
            DgvFactura.Rows(fila).Cells("Disp").Value = item.Disponible
            fila += 1
        Next

    End Sub
    ''' <summary>
    ''' Limita la cantidad de filas
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvFactura_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DgvFactura.UserAddedRow
        DgvFactura.AllowUserToAddRows = DgvFactura.RowCount <= cantidadFilas
    End Sub
    ''' <summary>
    ''' Mueve el Boton F3 en txtCodCte, y en el Dgv(Codigo,Precio) 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvFactura_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFactura.CellEnter
        Dim x As Integer, y As Integer, fila As Byte

        If DgvFactura.CurrentCell.ColumnIndex = 3 Or DgvFactura.CurrentCell.ColumnIndex = 6 Then
            fila = DgvFactura.CurrentCell.RowIndex
            y = yDgv + (fila * 21)

            Select Case DgvFactura.CurrentCell.ColumnIndex
                Case 3 : x = xCodigo
                Case 6 : x = xPrecio
            End Select

            btnF3.SetBounds(x, y, 28, 21) ' x, y)
            btnF3.Visible = True
        Else
            If btnF3.Visible = True Then btnF3.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' Rellena los Labels de Existencia y Disponible al seleccionar un codigo en el DGV
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvFactura_SelectionChanged(sender As Object, e As EventArgs) Handles DgvFactura.SelectionChanged
        Dim fila As Byte
        If DgvFactura.Rows.Count > 0 And DgvFactura.Rows(fila).Cells("Codigo").Value <> "" Then
            fila = DgvFactura.CurrentCell.RowIndex
            LblExist.Text = DgvFactura.Rows(fila).Cells("Exist").Value
            LblDisponible.Text = DgvFactura.Rows(fila).Cells("Disp").Value
        End If
    End Sub
    ''' <summary>
    ''' Proceso para Recuperar informacion de un codigo al presionar Enter en el DGV
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvFactura_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFactura.CellEndEdit
        'calcula numeros a menos que se modifique cantidad o precio
        If DgvFactura.CurrentCell.ColumnIndex = 1 Or DgvFactura.CurrentCell.ColumnIndex = 6 Then
            Dim row As DataGridViewRow = DgvFactura.Rows(e.RowIndex)
            CalculaNumeros(row)
        End If
        'recupera informacion del producto si se edita la columna de producto
        If DgvFactura.CurrentCell.ColumnIndex = 3 And DgvFactura.Rows(e.RowIndex).Cells("Codigo").Value <> "" Then
            Dim Producto As New Producto()
            Producto.Codigo = DgvFactura.Rows(e.RowIndex).Cells("Codigo").Value
            RellenaProducto(Producto)
        End If
    End Sub
    ''' <summary>
    ''' Forzar a escribir en mayuscula el codigo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DgvFactura_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DgvFactura.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub
    Private Sub DgvFactura_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DgvFactura.UserDeletingRow
        e.Cancel = True 'cancelo la eliminacion
        DgvFactura.CurrentRow.Cells("Cantidad").Value = 0 'modifico la cantidad a cero
        DgvFactura.CurrentRow.Visible = False 'oculto celda

    End Sub
    ''' <summary>
    ''' AL presionar enter el focus es hacia la derecha y no hacia abajo
    ''' </summary>
    ''' <param name="msg"></param>
    ''' <param name="keyData"></param>
    ''' <returns></returns>
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        ' Si el control DataGridView no tiene el foco, y
        ' si la celda actual no está siendo editada,
        ' abandonamos el procedimiento.
        '
        If ((Not DgvFactura.Focused) AndAlso
            (Not DgvFactura.IsCurrentCellInEditMode)) Then _
             Return MyBase.ProcessCmdKey(msg, keyData)

        ' Si la tecla presionada es distinta de la tecla Enter,
        ' abandonamos el procedimiento.
        '
        If (keyData <> Keys.Return) Then _
           Return MyBase.ProcessCmdKey(msg, keyData)

        ' Obtenemos la celda actual
        '
        Dim cell As DataGridViewCell = DgvFactura.CurrentCell

        ' Índice de la columna.
        '
        Dim columnIndex As Int32 = cell.ColumnIndex

        ' Índice de la fila.
        '
        Dim rowIndex As Int32 = cell.RowIndex

        If (columnIndex = DgvFactura.Columns.Count - 1) Then
            If (rowIndex = DgvFactura.Rows.Count - 1) Then
                ' Seleccionamos la primera columna de la primera fila.
                '
                cell = DgvFactura.Rows(0).Cells(0)
            Else
                ' Selecionamos la primera columna de la siguiente fila.
                '
                cell = DgvFactura.Rows(rowIndex + 1).Cells(0)
            End If

        Else
            ' Seleccionamos la celda de la derecha de la celda actual.
            '
            cell = DgvFactura.Rows(rowIndex).Cells(columnIndex + 1)
        End If

        DgvFactura.CurrentCell = cell

        Return True

    End Function
    ''' <summary>
    ''' Obtiene la informacion del producto y la plasma en el Dgv
    ''' </summary>
    ''' <param name="Producto">objeto Producto con el Id</param>
    Private Sub RellenaProducto(ByVal Producto As Producto)
        Dim NProducto As New NProducto()
        Dim fila As Byte
        Producto = NProducto.ObtenerProductoFactura(cadenaConex, Producto)

        fila = DgvFactura.CurrentCell.RowIndex
        DgvFactura.Rows(fila).Cells("Unidad").Value = Producto.IdUnidad
        DgvFactura.Rows(fila).Cells("Codigo").Value = Producto.Codigo
        DgvFactura.Rows(fila).Cells("CodigoSat").Value = Producto.IdCodigoSat
        DgvFactura.Rows(fila).Cells("Descripcion").Value = Producto.Descripcion
        DgvFactura.Rows(fila).Cells("Costo").Value = Producto.Costo
        DgvFactura.Rows(fila).Cells("Exist").Value = Producto.Existencia
        DgvFactura.Rows(fila).Cells("Disp").Value = Producto.Disponible
        DgvFactura.Rows(fila).Cells("Marca").Value = Producto.Marca
        DgvFactura.Rows(fila).Cells("Precio2").Value = Producto.Formula2
        DgvFactura.Rows(fila).Cells("Precio3").Value = Producto.Formula3

        'Rellena Labels
        LblExist.Text = DgvFactura.Rows(fila).Cells("Exist").Value
        LblDisponible.Text = DgvFactura.Rows(fila).Cells("Disp").Value
    End Sub
    Private Sub RellenarPrecio()
        Dim fila As Byte

        fila = DgvFactura.CurrentCell.RowIndex
        DgvFactura.Rows(fila).Cells("Precio").Value = idRecuperado
        CalculaNumeros(DgvFactura.CurrentRow)
    End Sub
#End Region

#Region "Eventos Botones"
    Private Sub btnF3_Click(sender As Object, e As EventArgs) Handles btnF3.Click
        Select Case btnF3.Location.X
            Case 110 'codCliente desde factura y pedido
                Dim frm As New FrmBuscador(1, 1, cadenaConex)
                If frm.ShowDialog() = DialogResult.OK Then
                    idRecuperado = frm.Id
                    tabla = 1 'clientes
                    CargaId()
                End If
            Case xCodigo 'codigo producto
                Dim frm As New FrmBuscador(2, 1, cadenaConex)
                If frm.ShowDialog() = DialogResult.OK Then
                    idRecuperado = frm.Id
                    tabla = 2
                    CargaId()
                End If
            Case xPrecio 'precios desde factura
                If DgvFactura.CurrentRow.Cells("Codigo").Value <> "" Then
                    Dim frm As New FrmBuscador(3, DgvFactura.CurrentRow.Cells("Codigo").Value, 1, cadenaConex)
                    If frm.ShowDialog() = DialogResult.OK Then
                        idRecuperado = frm.Id
                        RellenarPrecio()
                    End If
                End If
            Case 831 'Buscar Factura

        End Select
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim NFactura As New NFactura()
        Dim Factura As New Factura()
        Dim lst As New LProducto()
        Dim ObjCliente As New Cliente()

        If CamposNecesarios() Then
            Dim resultado As String
            If TxtFolio.Text = "" Then
                'Insertar la factura
                Factura.Cancelada = False
                Factura.Timbrada = False
                Factura = RellenaObjetoFactura(Factura)
                lst = RellenaListaProductos(lst)
                ObjCliente = RellenaObjetoCliente(ObjCliente)
                Factura = NFactura.InsertaFactura(cadenaConex, Factura, lst, ObjCliente)
                TxtFolio.Text = Factura.IdFactura
                Limpiar()
            Else
                resultado = MsgBox("¿Desea Modificar la Factura?", vbYesNo + vbQuestion, "Advertencia")
                If resultado = vbYes Then
                    'Modificar factura
                    Factura.Cancelada = False
                    Factura.Timbrada = False
                    Factura = RellenaObjetoFactura(Factura)
                    lst = RellenaListaProductos(lst)
                    NFactura.ModificaFactura(cadenaConex, Factura, lst)
                    TxtFolio.Text = Factura.IdFactura
                    Limpiar()
                End If
            End If
        End If
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim resultado As String

        resultado = MsgBox("¿Desea Borrar toda las informacion?" & vbCrLf & "Si no ha guardado se perderá el documento", vbYesNo + vbQuestion, "Advertencia")
        If resultado = vbYes Then
            Limpiar()
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim resultado As String
        resultado = MsgBox("¿Desea Cancelar la Factura?", vbYesNo + vbQuestion, "Advertencia")
        If resultado = vbYes Then
            Cancelar()
        End If
    End Sub
    Private Sub BtnTimbrar_Click(sender As Object, e As EventArgs) Handles BtnTimbrar.Click
        Timbrar()
    End Sub
    Private Sub BtnFirma_Click(sender As Object, e As EventArgs) Handles BtnFirma.Click
        Dim frm As New FrmFirma()
        Dim NFirma As New NFirma
        Dim objFactura As New Factura
        Dim lst As New LProducto
        Dim objNPedido As New NPedido

        If frm.ShowDialog() = DialogResult.OK Then
            Me.usuario.IdGrupo = usuario.IdGrupo
            Me.usuario.Id = usuario.Id
            objFactura.IdFactura = TxtFolio.Text
            frm.firmaGral = frm.firmaGral

            If usuario.IdGrupo = 2 Or usuario.IdGrupo = 3 Then 'firma ventas y cxc
                NFirma.InsertaFirmaFactura(cadenaConex, frm.firmaGral, objFactura, usuario)
                If frm.firmaGral.Password <> False Then 'si la contraseña no coincide
                    If usuario.IdGrupo = 2 Then 'ventas
                        LblFirmaVtas.Text = frm.firmaGral.Firma
                        LblComenVta.Text = frm.firmaGral.Fecha + " " + frm.firmaGral.Hora + " " + frm.firmaGral.Comentario
                        LblFirmaVtas.Visible = True
                        LblComenVta.Visible = True
                    Else
                        If usuario.IdGrupo = 3 Then 'cxc
                            LblFirmaCxc.Text = frm.firmaGral.Firma
                            LblComentCxc.Text = frm.firmaGral.Fecha + " " + frm.firmaGral.Hora + " " + frm.firmaGral.Comentario
                            LblFirmaCxc.Visible = True
                            LblComentCxc.Visible = True
                        Else
                        End If
                    End If
                End If
            End If
        End If
        If (LblFirmaCxc.Text = "False" Or LblFirmaCxc.Text = "") Or (LblFirmaVtas.Text = "False" Or LblFirmaVtas.Text = "") Then
            BtnTimbrar.Enabled = False
        Else
            BtnTimbrar.Enabled = True
        End If
    End Sub
#End Region

#Region "Calculos"
    ''' <summary>
    ''' Hace todos los calculos de los numeros, impuestos, subtotales, totales, etc
    ''' </summary>
    ''' <param name="row">fila dentro del DGV</param>
    Private Sub CalculaNumeros(ByVal row As DataGridViewRow)
        CalculaPrecioTotal(row)
        CalculaIva(row)
        CalculaSubtotal(row)
        CalculaTotales()
        CalcularUtilidad()
        If CType(txtTotal.Text, Double) > 0 Then NumerosALetras()
    End Sub
    Private Sub CalculaPrecioTotal(row As DataGridViewRow)
        If row.Cells("Codigo").Value IsNot Nothing Then
            row.Cells("PrecioTotal").Value = row.Cells("Precio").Value * row.Cells("Cantidad").Value
        End If
    End Sub
    Private Sub CalculaSubtotal(row As DataGridViewRow)
        If row.Cells("Codigo").Value IsNot Nothing And row.Cells("DgvIva").Value <> 0 Then
            row.Cells("Subtotal").Value = row.Cells("PrecioTotal").Value + row.Cells("DgvIva").Value
        End If
    End Sub
    Private Sub CalculaIva(row As DataGridViewRow)
        row.Cells("DgvIva").Value = row.Cells("PrecioTotal").Value * iva
    End Sub
    Private Sub CalculaTotales()
        Dim total As Double, ivaT As Double, bruto As Double

        For Each fila As DataGridViewRow In DgvFactura.Rows
            total = total + fila.Cells("Subtotal").Value
            ivaT = ivaT + fila.Cells("DgvIva").Value
            bruto = bruto + fila.Cells("PrecioTotal").Value
        Next

        txtTotal.Text = Format(CType(total, Decimal), "$#,##0.00")
        TxtIva.Text = Format(CType(ivaT, Decimal), "$#,##0.00")
        TxtSubtotal.Text = Format(CType(bruto, Decimal), "$#,##0.00")
    End Sub
    Private Sub CalcularUtilidad()
        Dim tprecio As Double, tcosto As Double, util As Double

        For Each fila As DataGridViewRow In DgvFactura.Rows
            tprecio = tprecio + fila.Cells("Precio").Value
            tcosto = tcosto + fila.Cells("Costo").Value
        Next
        If tcosto <> 0 And tprecio <> 0 Then
            util = ((tprecio - tcosto) / tprecio) * 100
            TxtUtilidad.Text = Format(CType(util, Decimal), "#,##0.00")
        End If
    End Sub
#End Region

#Region "Carga de objetos"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Factura"></param>
    ''' <returns></returns>
    Private Function RellenaObjetoFactura(ByVal Factura As Factura) As Factura
        If TxtFolio.Text <> "" Then Factura.IdFactura = CType(TxtFolio.Text, Integer)
        Factura.Fecha = TxtFecha.Text
        Factura.Hora = Now.ToString("HH:mm:ss.fff") 'Factura.Fecha.ToString("hh:mm:ss.fff")
        Factura.IdCliente = TxtIdCte.Text
        Factura.LugarExpedicion = LugarExpedicion
        Factura.IdMetodoPago = CmbMetodoPago.SelectedItem.IdMetodoPago
        Factura.DiasCredito = CmbDiasCred.SelectedItem
        Factura.IdFormaPago = CmbFormaPago.SelectedItem.IdFormaPago
        Factura.IdUsoCfdi = CmbUsoCfdi.SelectedItem.IdUsoCfdi
        Factura.IdMoneda = CmbMoneda.SelectedItem.IdMoneda
        If TxtUtilidad.Text <> "" Then Factura.Utilidad = TxtUtilidad.Text
        Factura.Subtotal = TxtSubtotal.Text
        Factura.Iva = TxtIva.Text
        Factura.Total = txtTotal.Text
        Factura.IdAgente = CmbAgente.SelectedItem.IdAgente
        Factura.Oc = TxtOc.Text
        If TxtPedido.Text <> "" Then Factura.Pedido = TxtPedido.Text
        Factura.Comentario = TxtComentario.Text
        Factura.TotalLetras = LblLetras.Text
        Factura.FolioFiscalUUID = "SF" 'Temporal
        Factura.XmlPago = False
        If Factura.DiasCredito = 2 Then
            Factura.CondicionPago = "CONTADO"
        Else
            Factura.CondicionPago = "CREDITO"
        End If
        Return Factura
    End Function
    ''' <summary>
    ''' Creas una lista de productos contenida en el DGV
    ''' </summary>
    ''' <param name="lst">Lista de productos</param>
    ''' <returns>Lista de productos</returns>
    Private Function RellenaListaProductos(ByVal lst As LProducto) As LProducto
        Dim i As Byte

        For i = 0 To DgvFactura.Rows.Count - 1
            With DgvFactura.Rows(i)
                If .Cells("Cantidad").Value IsNot Nothing And .Cells("Codigo").Value <> "" Then
                    Dim Producto As New Producto()
                    Producto.IdDetalle = .Cells("IdDetalle").Value
                    Producto.Cantidad = .Cells("Cantidad").Value
                    Producto.Codigo = .Cells("Codigo").Value
                    Producto.CodigoSat = .Cells("CodigoSat").Value
                    Producto.Precio = .Cells("Precio").Value
                    Producto.PrecioTotal = .Cells("PrecioTotal").Value 'total antes de iva
                    Producto.IvaTotal = .Cells("DgvIva").Value
                    Producto.Subtotal = .Cells("PrecioTotal").Value + .Cells("DgvIva").Value
                    Producto.Costo = .Cells("Costo").Value * .Cells("cantidad").Value 'costo total
                    Producto.Formula2 = .Cells("Precio2").Value
                    Producto.Formula3 = .Cells("Precio3").Value
                    Producto.Marca = .Cells("Marca").Value
                    lst.Add(Producto)
                End If
            End With
        Next
        Return lst
    End Function
    Private Function RellenaObjetoCliente(ByVal ObjCliente As Cliente) As Cliente
        ObjCliente.IdCliente = TxtIdCte.Text
        ObjCliente.Plazo = plazo
        ObjCliente.LimCred = limiteCredito
        ObjCliente.Bloqueo = bloqueo
        ObjCliente.Saldo = saldo
        ObjCliente.IdTipoCliente = tipoCte
        Return ObjCliente
    End Function
#End Region

#Region "Limpiar"
    Private Sub Limpiar()
        Dim Utilerias As New PUtilerias()
        Utilerias.LimpiarComboBox(Me, False, False, False, True, True, False)
        Utilerias.LimpiarTextBox(Me)
        DgvFactura.Rows.Clear()
        LimpiarLabels()


        TxtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        TxtIdCte.Select()
        CmbMoneda.SelectedValue = 2
        Me.cambios = False
        Utilerias.HabilitarBotones(Me)
        TxtLugarExpedicion.Text = LugarExpedicion
    End Sub
    ''' <summary>
    ''' Limpiar Labels de la parte inferior
    ''' </summary>
    Private Sub LimpiarLabels()
        LblExist.Text = Nothing
        LblDisponible.Text = Nothing
        LblLetras.Text = Nothing
    End Sub
#End Region

#Region "Procesos de Verificacion"
    ''' <summary>
    ''' Campos necesarios para Insertar y/o Modificar
    ''' </summary>
    ''' <returns>True o False</returns>
    Private Function CamposNecesarios() As Boolean
        If TxtIdCte.Text <> "" Then
            If TxtLugarExpedicion.Text <> "" Then
                If CmbMetodoPago.Text <> "" Then
                    If CmbDiasCred.Text <> "" Then
                        If CmbFormaPago.Text <> "" Then
                            If CmbUsoCfdi.Text <> "" Then
                                If CmbMoneda.Text <> "" Then
                                    If CmbAgente.Text <> "" Then
                                        If txtTotal.Text IsNot Nothing And DgvFactura.Rows(0).Cells("Codigo").Value IsNot Nothing Then
                                            Return True
                                        Else
                                            MsgBox("Es necesario agregar por lo menos un producto", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
                                        End If
                                    Else
                                        MsgBox("Es necesario seleccionar un Agente", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
                                    End If
                                Else
                                    MsgBox("Es necesario seleccionar una Moneda", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
                                End If
                            Else
                                MsgBox("Es necesario seleccionar el Uso del CFDI", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
                            End If
                        Else
                            MsgBox("Es necesario seleccionar una Forma de Pago", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
                        End If
                    Else
                        MsgBox("Es necesario seleccionar los Dias de Credito", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
                    End If
                Else
                    MsgBox("Es necesario seleccionar el Metodo de Pago", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
                End If
            Else
                MsgBox("Es necesario indicar un Lugar de Expedicion", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
            End If
        Else
            MsgBox("Es necesario seleccionar un Cliente", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
        End If
        Return False
    End Function
    ''' <summary>
    ''' Al obtener los registros de una factura revisa si está cancelada
    ''' </summary>
    Private Sub VerificarCancelada(ByVal factura As Factura)
        If factura.Cancelada Then
            MsgBox("La factura está Cancelada" & vbLf & "Por lo tanto No se podrá timbrar", vbYes + vbExclamation, "Advertencia")
            BtnCancelar.Enabled = False
            BtnTimbrar.Enabled = False
            BtnCancelarCfdi.Enabled = False
        End If
    End Sub
#End Region

#Region "Eventos Varios de controles"
    ''' <summary>
    ''' Focus en el Textbox del ID del Cliente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtIdCte_GotFocus(sender As Object, e As EventArgs) Handles TxtIdCte.GotFocus
        btnF3.Visible = True
        'btnF3.SetBounds(110, 11, 27, 23, 1)
        btnF3.Location = New Drawing.Point(110, 11)

        'TxtNombreCte.Select()
    End Sub
    Private Sub CmbTipoRelacion_Click(sender As Object, e As EventArgs) Handles CmbTipoRelacion.Click
        CargaTipoRelacion()
    End Sub
    ''' <summary>
    ''' Al presionar el boton F3 se dirige al evento click de ese mismo boton
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TabFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles TabFactura.KeyDown
        If e.KeyData = Keys.F3 Then
            btnF3_Click(Nothing, Nothing)
        End If
    End Sub
    ''' <summary>
    ''' Recupera la informacion de un cliente al dar enter en el txtIdCliente
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TxtIdCte_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtIdCte.KeyDown
        If e.KeyCode = Keys.Enter And TxtIdCte.Text <> "" Then
            Dim Cliente As New Cliente()
            Cliente.IdCliente = TxtIdCte.Text
            RellenaCliente(Cliente)
            tipoCte = Cliente.IdTipoCliente
            plazo = Cliente.Plazo
            limiteCredito = Cliente.LimCred
            saldo = Cliente.Saldo
            CmbMetodoPago.Select()
        End If
    End Sub
    Private Sub TxtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFolio.KeyDown
        If e.KeyCode = Keys.Enter And TxtFolio.Text <> "" Then
            RecuperaFactura()
        End If
    End Sub
#End Region

#Region "Procesos Varios"
    ''' <summary>
    ''' Evento creado desde el Load para detectar los cambios de cualquier control dentro del frm
    ''' </summary> 
    ''' <param name="e"></param>
    Public Sub Cambios_Formulario(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cambios = True
    End Sub
    Private Sub RecuperaFactura()
        Dim Cabecera As New Factura()
        Dim Cliente As New Cliente()
        Dim NFactura As New NFactura()
        Dim NCliente As New NCliente()
        Dim Detalle As New LProducto()

        Cabecera.IdFactura = TxtFolio.Text
        Cabecera = NFactura.RecuperaFacturaCabecera(cadenaConex, Cabecera)
        Cliente.IdCliente = Cabecera.IdCliente
        Cliente = NCliente.ObtenerClienteFactura(cadenaConex, Cliente)
        CargaCreditoCliente(Cliente)
        Detalle = NFactura.RecuperaFacturaDetalle(cadenaConex, Cabecera)

        RellenaControlesCabecera(Cabecera, Cliente)
        RellenaDgvDetalle(Detalle)

        If usuario.IdGrupo = 2 Or usuario.IdGrupo = 3 Or usuario.IdGrupo = 4 Then 'solo ventas, cxc y cxcplus
            TabFirmas.Parent = TabFactura 'se muestra pestaña de firmas
            RecuperarFirmas(cadenaConex, Cabecera, Cliente)

            If (LblFirmaCxc.Text = "False" Or LblFirmaCxc.Text = "") Or (LblFirmaVtas.Text = "False" Or LblFirmaVtas.Text = "") Then
                BtnTimbrar.Enabled = False
            Else
                BtnTimbrar.Enabled = True
            End If
        End If
    End Sub
    Private Sub RecuperarPedido()
        Dim Cabecera As New Pedido()
        Dim Cliente As New Cliente()
        Dim NPedido As New NPedido()
        Dim NCliente As New NCliente()
        Dim Detalle As New LProducto()

        Cabecera.IdPedido = TxtPedido.Text
        Cabecera = NPedido.RecuperaPedidoCabecera(cadenaConex, Cabecera)
        Cabecera = NPedido.RecuperaComentariosFirmas(cadenaConex, Cabecera)
        Cliente.IdCliente = Cabecera.IdCliente
        Cliente = NCliente.ObtenerClientePedidos(cadenaConex, Cliente)
        CargaCreditoCliente(Cliente)
        Detalle = NPedido.RecuperaDetallePedido(cadenaConex, Usuario, Cabecera)

        RellenaControlesCabeceraFromPed(Cabecera, Cliente)
        RellenaDgvDetalle(Detalle)


    End Sub
    Private Sub RellenaControlesCabeceraFromPed(ByVal Pedido As Pedido, ByVal Cliente As Cliente)
        TxtIdCte.Text = Pedido.IdCliente
        CmbMetodoPago.SelectedValue = Pedido.IdMetodoPago
        CmbDiasCred.SelectedItem = Pedido.DiasCredito.ToString()
        CmbFormaPago.SelectedValue = Pedido.IdFormaPago
        CmbAgente.SelectedValue = Pedido.IdAgente
        TxtSubtotal.Text = Pedido.Subtotal
        TxtIva.Text = Pedido.Iva
        txtTotal.Text = Pedido.Total
        TxtUtilidad.Text = Pedido.Utilidad
        TxtComentario.Text = Pedido.Observacion

        TxtNombreCte.Text = Cliente.Nombre
        CargaCreditoCliente(Cliente)

        TxtLugarExpedicion.Text = LugarExpedicion
    End Sub

    Private Sub CargaId()
        Select Case tabla
            Case 1 'cliente
                Dim Cliente As New Cliente()
                Cliente.IdCliente = idRecuperado
                RellenaCliente(Cliente)
                tipoCte = Cliente.IdTipoCliente
                plazo = Cliente.Plazo
                limiteCredito = Cliente.LimCred
                saldo = Cliente.Saldo
            Case 2
                Dim Producto As New Producto()
                Producto.Codigo = idRecuperado
                RellenaProducto(Producto)
        End Select
    End Sub
    ''' <summary>
    ''' Guarda informacion del credito del cliente que se recupera para
    ''' despues utilizarla y poder timbrarla sólo si las condiciones son
    ''' las correctas
    ''' </summary>
    ''' <param name="Cliente">Objeto Cliente cargado con la informacion crediticia</param>
    Private Sub CargaCreditoCliente(Cliente As Cliente)
        Me.saldo = Cliente.Saldo
        Me.plazo = Cliente.Plazo
        Me.limiteCredito = Cliente.LimCred
    End Sub
    Private Sub Cancelar()
        Dim NFactura As New NFactura()
        Dim Factura As New Factura()

        Factura.IdFactura = TxtFolio.Text
        NFactura.Cancelar(cadenaConex, Factura)
    End Sub
    Private Sub NumerosALetras()
        Dim letra As New Numalet()
        letra.SeparadorDecimalSalida = "pesos"
        letra.MascaraSalidaDecimal = "00/100 M.N."
        'sin esta propiedad queda "veintiuno pesos" en vez de "veintiún pesos":
        letra.ApocoparUnoParteEntera = True
        letra.LetraCapital = True
        LblLetras.Text = letra.ToCustomCardinal(CType(txtTotal.Text, Double))
    End Sub
#End Region

#Region "Timbrado"
    Private Sub Timbrar()
        Dim Factura As New Factura() : Dim NFactura As New NFactura()
        Dim Sucursal As New Sucursales()
        Dim Documento As New Documento
        Dim Moneda As New Moneda()
        Sucursal.IdSuc = Me.idSucursal
        Factura = RellenaObjetoFactura(Factura)
        Documento.IdDocumento = 1 'Factura
        Moneda.Id = Factura.IdMoneda

        If Factura.Timbrada = False Then
            NFactura.Timbrar(cadenaConex, Factura, Sucursal, Documento, Moneda)
        Else
            MsgBox("La Factura ya ha sido timbrada", vbExclamation, "Error")
        End If
    End Sub
    Private Sub BttEnviar_Click(sender As Object, e As EventArgs) Handles BttEnviar.Click
        Dim Factura As New Factura
        Dim Configuracion As New Configuracion
        Dim Cliente As New Cliente
        Dim negocio As New NFactura

        Cliente = obtenerCliente()
        Configuracion = obtenerConfiguracion()
        Factura = obtenerTimbrada()
        negocio.procesoCorreo(Cliente, Configuracion, Factura)
    End Sub
#End Region
    Private Function obtenerTimbrada()
        Dim negocio As New NFactura
        Return negocio.FacturaTimbre(cadenaConex, Me.idFactura)
    End Function
    Private Function obtenerConfiguracion() As Configuracion
        Dim negocio As New NConfiguracion
        Dim sucursales As New Sucursales
        sucursales.IdSuc = Me.idSucursal
        Return negocio.ObtenerConfiguracionTimbrar(cadenaConex, sucursales)
    End Function
    Private Function obtenerCliente()
        Dim negocio As New NCliente
        Return negocio.ObtenerCorreoCliente(cadenaConex, TxtIdCte.Text)
    End Function
End Class