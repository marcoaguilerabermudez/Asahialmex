Imports System.Windows.Forms
Imports System.Configuration
Imports Clases
Imports Negocio

Public Class FrmCotizaciones
#Region "Variables de Clase"
    Private cadenaConex As String
    Dim orig As SByte 'prospecto=1,cliente=2
    Dim usuarios As New Usuario
    Dim idCte As Integer
    Public agente As String
    Private idRecuperado As String
    Private tabla As SByte 'clientes=1, productos=2
    Private Const cantidadFilas As Byte = 20 'Filas para pedidos
    Private Const iva As Double = 0.16 'iva
    Private plazo As Integer
    Private limiteCredito As Double
    Private saldo As Double
    Private bloqueo As Boolean
    Private tipoCte As Integer
    Private idagente As New Integer
    Private nombreAgente As String
    Private idPedido As Integer
    Private prospecto As Integer
    Private nombreUsuario As String
    Private idCotizacion As Integer
    Private idSuc As Integer
    Dim idgrupoEstatus As Integer 'idgrupoEstatus viene del estatus de ventas
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal usuario As Usuario, ByVal origen As SByte, ByVal cadenaConex As String, ByVal idSuc As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
        Me.usuarios = usuario
        Me.orig = origen
        Me.idSuc = idSuc
    End Sub

    Sub New(ByVal usuarios As Usuario, ByVal cadenaConex As String, ByVal idSuc As Integer, ByVal idCotizacion As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
        Me.idCotizacion = idCotizacion
        Me.usuarios = usuarios
        Me.idSuc = idSuc

    End Sub


    Private Sub DgvPedidos_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DgvPedidos.UserDeletingRow
        e.Cancel = True 'cancelo la eliminacion
        DgvPedidos.CurrentRow.Cells("Cantidad").Value = 0 'modifico la cantidad a cero
        DgvPedidos.CurrentRow.Visible = False 'oculto celda

    End Sub
#End Region
#Region "Acciones del Formulario"
    Private Sub FrmCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        RellenaDiasCredito()
        RellenaFormaPago()


        If orig = 1 Then
            Me.Text = "Cotizaciones"
            LblPedido.Text = "Cotizaciones"
        ElseIf orig = 2 Then
            Me.Text = "Prospectos"
            LblPedido.Text = "Prospectos"
        End If

        If Me.idCotizacion <> Nothing Then
            TxtFolio.Text = Me.idCotizacion
            RecuperarCotizadorCabecera()
            RecuperacionCotizacionDetalle()
            BtnPdf.Visible = True
            BtnEnviar.Visible = True
        End If
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim ObjN As New NCotizacion()
        Dim ObjCotizacion As New Cotizacion()
        Dim lst As New LProducto()
        Dim ObjCliente As New Cliente()
        Dim confirmacion As Integer
        If validar() = True Then
            If TxtFolio.Text = "" Then 'cotizacion nuevo
                ObjCotizacion = RellenaObjetoCotizacion(ObjCotizacion)
                lst = RellenaListaProductos(lst)
                ObjCliente = RellenaObjetoCliente(ObjCliente)
                ObjN.InsertaCotizacion(cadenaConex, ObjCotizacion, lst)
                LimpiarCotizador()
                ' TxtPedido.Text = ObjCotizacion.IdCotizacion
            Else
                confirmacion = MsgBox("¿Deseas modificar la cotización  " & TxtFolio.Text & "?", vbYesNo + vbQuestion + vbDefaultButton2, "Modificar Cotizacion")
                If confirmacion = vbYes Then
                    ObjCotizacion = RellenaObjetoCotizacion(ObjCotizacion)
                    lst = RellenaListaProductos(lst)
                    ObjCliente = RellenaObjetoCliente(ObjCliente)
                    ObjN.ModificarCotizacion(cadenaConex, ObjCotizacion, lst)
                    LimpiarCotizador()
                End If

            End If
        End If
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        LimpiarCotizador()
    End Sub
    ''' <summary>
    ''' muestra los formularios dependiendo la poscion que se encuentra el boton F3
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnF3_Click(sender As Object, e As EventArgs) Handles btnF3.Click
        Select Case btnF3.Location.X
            Case 116
                Dim frm As New FrmBuscador(1, 1, cadenaConex)
                If frm.ShowDialog() = DialogResult.OK Then
                    idRecuperado = frm.Id
                    tabla = 1 'cliente
                    prospecto = frm.Prospecto
                    CargaId()
                End If

            Case 214
                Dim frm As New FrmBuscador(2, 1, cadenaConex) 'codigo
                If frm.ShowDialog() = DialogResult.OK Then
                    idRecuperado = frm.Id
                    tabla = 2
                    CargaId()
                End If

            Case 603
                If DgvPedidos.CurrentRow.Cells("Codigo").Value <> "" Then 'precios
                    Dim frm As New FrmBuscador(3, DgvPedidos.CurrentRow.Cells("Codigo").Value, 1, cadenaConex)
                    If frm.ShowDialog() = DialogResult.OK Then
                        idRecuperado = frm.Id
                        RellenarPrecio()
                    End If
                End If
        End Select
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dim FrmProspecto As New FrmProspecto(Me.cadenaConex)
        FrmProspecto.Show()
    End Sub

    Private Sub DgvPedidos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPedidos.CellEnter
        Dim x As Integer, y As Integer, fila As Byte

        If DgvPedidos.CurrentCell.ColumnIndex = 4 Or DgvPedidos.CurrentCell.ColumnIndex = 7 Then
            fila = DgvPedidos.CurrentCell.RowIndex
            y = 160 + (fila * 19) 'poscion

            Select Case DgvPedidos.CurrentCell.ColumnIndex
                Case 4 : x = 214'codigo
                Case 7 : x = 603 'precio
            End Select

            btnF3.SetBounds(x, y, 33, 21) ' x, y)
            btnF3.Visible = True
        Else
            If btnF3.Visible = True Then btnF3.Visible = False
        End If
    End Sub
    Private Sub TxtCodCte_GotFocus(sender As Object, e As EventArgs) Handles TxtCodCte.GotFocus
        btnF3.SetBounds(116, 64, 33, 21) 'y=108, x=15
        btnF3.Visible = True
    End Sub
    Private Sub TxtCodCte_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodCte.KeyDown
        If e.KeyCode = Keys.Enter Then
            tabla = 1
            idRecuperado = TxtCodCte.Text
            CargaId()

        End If
    End Sub

    Private Sub DgvPedido_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DgvPedidos.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If
    End Sub
    Private Sub dgvPedidos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPedidos.CellEndEdit
        Dim row As DataGridViewRow = DgvPedidos.Rows(e.RowIndex)
        If DgvPedidos.Columns(e.ColumnIndex).Name = "Codigo" Then
            If DgvPedidos.Rows(e.RowIndex).Cells(4).Value <> Nothing Then
                Dim Producto As New Producto()
                Producto.Codigo = DgvPedidos.Rows(e.RowIndex).Cells(4).Value
                Producto = ObtenerProducto(Producto)
                RellenaDgvPedidos(Producto, row)
            End If
        ElseIf DgvPedidos.Columns(e.ColumnIndex).Name = "Cantidad" Or DgvPedidos.Columns(e.ColumnIndex).Name = "Precio" Then
            CalculaNumeros(DgvPedidos.CurrentRow)
        End If
    End Sub
    Private Sub TxtPedido_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFolio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cabeceraCotizacion As New Cotizacion
            cabeceraCotizacion.IdCotizacion = TxtFolio.Text
            If TxtCodCte.Text <> Nothing Then
                Limpiar()
                TxtFolio.Text = cabeceraCotizacion.IdCotizacion
                RecuperarCotizadorCabecera()
                BtnEnviar.Visible = True
                BtnPdf.Visible = True
            Else
                RecuperarCotizadorCabecera()
                BtnEnviar.Visible = True
                BtnPdf.Visible = True
            End If
        End If
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
        If ((Not DgvPedidos.Focused) AndAlso
            (Not DgvPedidos.IsCurrentCellInEditMode)) Then _
             Return MyBase.ProcessCmdKey(msg, keyData)

        ' Si la tecla presionada es distinta de la tecla Enter,
        ' abandonamos el procedimiento.
        '
        If (keyData <> Keys.Return) Then _
           Return MyBase.ProcessCmdKey(msg, keyData)

        ' Obtenemos la celda actual
        '
        Dim cell As DataGridViewCell = DgvPedidos.CurrentCell

        ' Índice de la columna.
        '
        Dim columnIndex As Int32 = cell.ColumnIndex

        ' Índice de la fila.
        '
        Dim rowIndex As Int32 = cell.RowIndex

        If (columnIndex = DgvPedidos.Columns.Count - 1) Then
            If (rowIndex = DgvPedidos.Rows.Count - 1) Then
                ' Seleccionamos la primera columna de la primera fila.
                '
                cell = DgvPedidos.Rows(0).Cells(0)
            Else
                ' Selecionamos la primera columna de la siguiente fila.
                '
                cell = DgvPedidos.Rows(rowIndex + 1).Cells(0)
            End If

        Else
            ' Seleccionamos la celda de la derecha de la celda actual.
            '
            cell = DgvPedidos.Rows(rowIndex).Cells(columnIndex + 1)
        End If

        '  DgvPedidos.CurrentCell = cell
        Return True
    End Function

    Private Sub NumerosALetras()
        Dim letra As New Numalet()
        letra.SeparadorDecimalSalida = "pesos"
        letra.MascaraSalidaDecimal = "00/100 M.N."
        'sin esta propiedad queda "veintiuno pesos" en vez de "veintiún pesos":
        letra.ApocoparUnoParteEntera = True
        letra.LetraCapital = True
        LnumLetra.Text = letra.ToCustomCardinal(CType(TxtTotal.Text, Double))
    End Sub
#End Region
#Region "Rellenar"
    Private Function RellenaObjetoCotizacion(ObjCotizacion As Cotizacion) As Cotizacion
        If TxtFolio.Text <> "" Then 'si es modificacion
            ObjCotizacion.IdCotizacion = TxtFolio.Text
        End If
        ObjCotizacion.Fecha = TxtFecha.Text
        ObjCotizacion.Hora = Now.ToString("HH:mm:ss.fff")
        ObjCotizacion.IdUsuario = Me.usuarios.Id
        ObjCotizacion.IdAgente = usuarios.IdAgente
        ObjCotizacion.IdFormaPago = CmbFormaPago.SelectedItem.IdFormaPago
        If TxtTipoCte.Text = "Distribuidor" Then
            ObjCotizacion.TipoCliente = 1
            ObjCotizacion.IdCliente = TxtCodCte.Text
        ElseIf TxtTipoCte.Text = "Usuario" Then
            ObjCotizacion.TipoCliente = 2
            ObjCotizacion.IdCliente = TxtCodCte.Text
        ElseIf TxtTipoCte.Text = "Prospecto" Then
            ObjCotizacion.TipoCliente = 3
            ObjCotizacion.IdProspecto = TxtCodCte.Text
        End If
        ObjCotizacion.DiasCredito = CmbDiasCred.Text
        ObjCotizacion.Ordeno = TxtContacto.Text
        ObjCotizacion.Observacion = RTxtComenta.Text
        ObjCotizacion.Subtotal = TxtSubtotal.Text
        ObjCotizacion.Iva = TxtIva.Text
        ObjCotizacion.Total = TxtTotal.Text

        ObjCotizacion.NumLetra = LnumLetra.Text
        If TxtFolio.Text <> Nothing Then
            ObjCotizacion.IdProspecto = TxtFolio.Text
        End If
        If TxtFolio.Text <> Nothing Then
            ObjCotizacion.IdCotizacion = TxtFolio.Text
        End If

        Return ObjCotizacion
    End Function
    Private Function RellenaObjetoCliente(ByVal ObjCliente As Cliente) As Cliente
        ObjCliente.IdCliente = TxtCodCte.Text
        ObjCliente.Plazo = plazo
        ObjCliente.LimCred = limiteCredito
        ObjCliente.Bloqueo = bloqueo
        ObjCliente.Saldo = saldo
        ObjCliente.IdTipoCliente = tipoCte
        Return ObjCliente
    End Function
    Private Function RellenaListaProductos(lst As LProducto) As LProducto
        Dim i As Byte

        For i = 0 To DgvPedidos.Rows.Count - 1
            With DgvPedidos.Rows(i)
                If .Cells("Cantidad").Value IsNot Nothing And .Cells("Codigo").Value <> "" Then
                    Dim ObjProd As New Producto()
                    If TxtFolio.Text <> "" Then 'si es modificacion
                        ObjProd.IdCotizacion = TxtFolio.Text
                    End If
                    ObjProd.IdDetalle = .Cells("IdDetalle").Value
                    ObjProd.Cantidad = .Cells("Cantidad").Value
                    ObjProd.Codigo = .Cells("Codigo").Value
                    ObjProd.Existencia = .Cells("Existencia").Value
                    ObjProd.Precio = .Cells("Precio").Value
                    ObjProd.PrecioTotal = .Cells("precioTotal").Value
                    ObjProd.Costo = .Cells("Costo").Value * .Cells("cantidad").Value
                    ObjProd.Formula2 = .Cells("Precio2").Value
                    ObjProd.Formula3 = .Cells("Precio3").Value
                    ObjProd.Marca = .Cells("Marca").Value
                    ObjProd.IvaTotal = .Cells("ColumnaIva").Value
                    ObjProd.Subtotal = .Cells("Subtotal").Value
                    'ObjProd.Total = .Cells("Total").Value
                    lst.Add(ObjProd)
                End If
            End With
        Next
        Return lst
    End Function
    Private Sub RellenaCliente(ByVal objCliente As Cliente)
        TxtCodCte.Text = objCliente.IdCliente
        TxtNombreCte.Text = objCliente.Nombre
        If objCliente.IdFormaPago <> 0 Then CmbFormaPago.SelectedValue = objCliente.IdFormaPago
        If objCliente.Plazo <> 0 Then CmbDiasCred.Text = objCliente.Plazo
        Select Case objCliente.IdTipoCliente
            Case 1
                TxtTipoCte.Text = "Distribuidor"
            Case 2
                TxtTipoCte.Text = "Usuario"
            Case 3
                TxtTipoCte.Text = "Prospecto"
        End Select
    End Sub
    Private Sub RellenaProspecto(ByVal objprospecto As Prospecto)
        TxtCodCte.Text = objprospecto.IdProspecto
        TxtNombreCte.Text = objprospecto.Nombre
        If objprospecto.FormaPagos <> 0 Then CmbFormaPago.SelectedValue = objprospecto.FormaPagos
        If objprospecto.DiasCredito <> 0 Then CmbDiasCred.Text = objprospecto.DiasCredito
        TxtTipoCte.Text = "Prospecto"
    End Sub
    Private Sub RellenarPrecio()
        Dim fila As Byte
        fila = DgvPedidos.CurrentCell.RowIndex
        DgvPedidos.Rows(fila).Cells("Precio").Value = idRecuperado
        CalculaNumeros(DgvPedidos.CurrentRow)
    End Sub
    Private Sub RellenaDgvPedidos(ByVal Producto As Producto, row As DataGridViewRow)
        Dim fila As Integer
        fila = row.Index
        DgvPedidos.Rows(fila).Cells("Unidad").Value = Producto.IdUnidad
        DgvPedidos.Rows(fila).Cells("codigoSat").Value = Producto.IdCodigoSat
        DgvPedidos.Rows(fila).Cells("Descripcion").Value = Producto.Descripcion
        DgvPedidos.Rows(fila).Cells("Precio").Value = Producto.Precio
        DgvPedidos.Rows(fila).Cells("Costo").Value = Producto.Costo
        DgvPedidos.Rows(fila).Cells("Existencia").Value = Producto.Existencia
        DgvPedidos.Rows(fila).Cells("Disponible").Value = Producto.Disponible
        DgvPedidos.Rows(fila).Cells("Marca").Value = Producto.Marca
        DgvPedidos.Rows(fila).Cells("Precio2").Value = Producto.Formula2
        DgvPedidos.Rows(fila).Cells("Precio3").Value = Producto.Formula3
        LblExist.Text = DgvPedidos.Rows(fila).Cells("Existencia").Value
        LblDispo.Text = DgvPedidos.Rows(fila).Cells("Disponible").Value
    End Sub
    Private Sub RellenarProducto(objProducto As Producto)
        Dim fila As Byte
        fila = DgvPedidos.CurrentCell.RowIndex
        DgvPedidos.Rows(fila).Cells("Codigo").Value = objProducto.Codigo
        DgvPedidos.Rows(fila).Cells("Descripcion").Value = objProducto.Descripcion
        DgvPedidos.Rows(fila).Cells("Existencia").Value = objProducto.Existencia 'exist
        DgvPedidos.Rows(fila).Cells("Costo").Value = objProducto.Costo 'costo
    End Sub
    Private Sub RellenaCotizadorCabecera(cabeceracotizacion As Cotizacion)
        If cabeceracotizacion.IdCliente = 0 Then
            TxtCodCte.Text = cabeceracotizacion.IdProspecto
        Else
            TxtCodCte.Text = cabeceracotizacion.IdCliente
        End If
        TxtFolio.Text = cabeceracotizacion.IdCotizacion
        CmbDiasCred.Text = cabeceracotizacion.DiasCredito
        TxtContacto.Text = cabeceracotizacion.Ordeno
        If cabeceracotizacion.TipoCliente = 1 Then
            TxtTipoCte.Text = "Distribuidor"
        ElseIf cabeceracotizacion.TipoCliente = 2 Then
            TxtTipoCte.Text = "Usuario"
        ElseIf cabeceracotizacion.TipoCliente = 3 Then
            TxtTipoCte.Text = "Prospecto"
        End If
        CmbFormaPago.SelectedValue = cabeceracotizacion.IdFormaPago
        If cabeceracotizacion.Cliente <> Nothing Then
            TxtNombreCte.Text = cabeceracotizacion.Cliente
        Else
            TxtNombreCte.Text = cabeceracotizacion.Prospecto
        End If
        TxtTotal.Text = Format(CType(cabeceracotizacion.Total, Decimal), "$ #,##0.00")
        TxtIva.Text = Format(CType(cabeceracotizacion.Iva, Decimal), "$ #,##0.00")
        TxtSubtotal.Text = Format(CType(cabeceracotizacion.Subtotal, Decimal), "$ #,##0.00")
        LnumLetra.Text = cabeceracotizacion.NumLetra
        RTxtComenta.Text = cabeceracotizacion.Observacion
        'TxtNombreCte.Text = cabeceracotizacion.Cliente
        TxtCodCte.Tag = cabeceracotizacion.IdAgente
    End Sub
    Private Sub RellarCotizadorDetalle(detalleCotizador As LProducto)
        Dim fila As Byte = 0
        Dim LPedido As New LPedido
        Dim NPedido As New NPedido
        Dim colPrecio As Double, colCosto As Double, colUtil As Double

        For Each item In detalleCotizador
            DgvPedidos.Rows.Add()
            DgvPedidos.Rows(fila).Cells("IdDetalle").Value = item.IdDetalle
            DgvPedidos.Rows(fila).Cells("Cantidad").Value = item.Cantidad
            DgvPedidos.Rows(fila).Cells("Unidad").Value = item.IdUnidad
            DgvPedidos.Rows(fila).Cells("Codigo").Value = item.Codigo
            DgvPedidos.Rows(fila).Cells("codigoSat").Value = item.IdCodigoSat
            DgvPedidos.Rows(fila).Cells("Descripcion").Value = item.Descripcion
            DgvPedidos.Rows(fila).Cells("Precio").Value = item.Precio
            DgvPedidos.Rows(fila).Cells("Preciototal").Value = item.PrecioTotal
            DgvPedidos.Rows(fila).Cells("Costo").Value = item.Costo
            DgvPedidos.Rows(fila).Cells("Subtotal").Value = item.Subtotal
            DgvPedidos.Rows(fila).Cells("ColumnaIva").Value = item.IvaTotal
            DgvPedidos.Rows(fila).Cells("Existencia").Value = item.Existencia '
            DgvPedidos.Rows(fila).Cells("Disponible").Value = item.Disponible '
            DgvPedidos.Rows(fila).Cells("Marca").Value = item.Marca
            DgvPedidos.Rows(fila).Cells("Precio3").Value = item.Formula3


            DgvPedidos.Rows(fila).Cells("CantSurtida").Value = item.CantidadSurtida
            DgvPedidos.Rows(fila).Cells("IdDetalle").Value = item.IdDetalle


            'formula de utilidad
            colPrecio = DgvPedidos.Rows(fila).Cells("Precio").Value
            colCosto = DgvPedidos.Rows(fila).Cells("Costo").Value
            colUtil = ((colPrecio + colCosto) / colPrecio) * 100
            DgvPedidos.Rows(fila).Cells("Utilidad").Value = colUtil

            'pone el formato en pesos
            DgvPedidos.Columns("precio").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvPedidos.Columns("precioTotal").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvPedidos.Columns("ColumnaIva").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvPedidos.Columns("SubTotal").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvPedidos.Columns("Costo").DefaultCellStyle.Format = "$ ##,##0.00"
            DgvPedidos.Columns("Precio3").DefaultCellStyle.Format = "$ ##,##0.00"
            fila += 1

        Next
        CalculaNumeros(DgvPedidos.CurrentRow)
    End Sub
#End Region
#Region "procesos del formulario"
    Private Function validar()
        If TxtCodCte.Text = "" Then
            MsgBox("Debes selecciona el Cliente o Prospecto")
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub LimpiarCotizador()
        TxtCodCte.Text = ""
        TxtNombreCte.Text = ""
        CmbFormaPago.Text = Nothing
        CmbDiasCred.Text = Nothing
        TxtTipoCte.Text = ""
        TxtContacto.Text = ""
        TxtFolio.Text = ""
        TxtSubtotal.Text = ""
        RTxtComenta.Text = ""
        TxtIva.Text = ""
        TxtTotal.Text = ""
        Limpiar()
        LnumLetra.Text = ""
    End Sub
    ''' <summary>
    ''' proceso principal para llenar el formulario de pedidos, el cual llama a tres procesos, pero solo la de las direcciones es funcionaal para verificar si tiene direccion fiscal
    ''' en caso de que el cliente no tenga direccion fiscal, arroja un mensaje al usuario
    ''' </summary>
    Private Sub CargaId()
        Select Case tabla
            Case 1 'cliente
                Dim objCliente As New Cliente()
                Dim objprospecto As New Prospecto
                Dim objDireccion As New Direccion
                Limpiar()
                If prospecto <> Nothing Then
                    objprospecto = RecuperarProspecto()
                    RellenaProspecto(objprospecto) 'rellena info cliente
                Else
                    objCliente = RecuperarCliente()
                    RellenaCliente(objCliente) 'rellena info cliente
                    objDireccion = RecuperaDireccion() 'recupera direccion
                    tipoCte = objCliente.IdTipoCliente
                    plazo = objCliente.Plazo
                    limiteCredito = objCliente.LimCred
                    saldo = objCliente.Saldo
                End If

            Case 2
                Dim objProducto As New Producto()
                objProducto = RecuperarProducto()
                RellenarProducto(objProducto)
        End Select
    End Sub
    Private Sub Limpiar()
        Dim Utilerias As New PUtilerias
        Utilerias.LimpiarComboBox(Me, False, False, False, True, True, False)
        Utilerias.LimpiarTextBox(Me)
        DgvPedidos.Rows.Clear()
        TxtFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        BtnGuardar.Enabled = True
        LnumLetra.Text = ""
        DgvPedidos.Columns("CantSurtida").Visible = False
    End Sub
#End Region
#Region "Rellanar cmb"
    Private Sub RellenaFormaPago()
        Dim NSat As New NSat()
        Dim lst As New LSat()

        lst = NSat.ObtenerFormaPagoLista(cadenaConex)
        With CmbFormaPago
            .DataSource = lst
            .DisplayMember = "FormaPago"
            .ValueMember = "idFormaPago"
            .SelectedItem = Nothing
        End With
    End Sub
    Private Sub RellenaDiasCredito()
        CmbDiasCred.Items.Add("2")
        CmbDiasCred.Items.Add("15")
        CmbDiasCred.Items.Add("30")
        CmbDiasCred.Items.Add("45")
        CmbDiasCred.Items.Add("60")
        CmbDiasCred.Items.Add("90")
    End Sub
#End Region
#Region "Recuperar"
    Private Function RecuperarCliente() As Cliente
        Dim objCliente As New Cliente()
        Dim objN As New NCliente()

        objCliente.IdCliente = idRecuperado
        Return objN.ObtenerClientePedidos(cadenaConex, objCliente)
    End Function
    Private Function RecuperarProspecto() As Prospecto
        Dim objprospectos As New Prospecto()
        Dim objN As New NProspectos()

        objprospectos.IdProspecto = idRecuperado
        Return objN.ProspectorRecuperar(cadenaConex, objprospectos)
    End Function
    Private Function RecuperaDireccion() As Direccion
        Dim direccion As New Direccion
        Dim ObteDireccion As New NDireccion
        direccion.IdCliente = idRecuperado
        Return ObteDireccion.ObtenerDireccion(cadenaConex, direccion)
    End Function

    Private Function RecuperarProducto() As Producto
        Dim objProducto As New Producto()
        Dim objN As New NProducto
        objProducto.Codigo = idRecuperado
        Return objN.ObtenerProductoPedidos(cadenaConex, objProducto)

    End Function
    Private Sub RecuperarCotizadorCabecera()
        Dim cabeceraCotizacion As New Cotizacion
        Dim ncotizacion As New NCotizacion
        cabeceraCotizacion.IdCotizacion = TxtFolio.Text
        cabeceraCotizacion.IdUsuario = Me.usuarios.Id
        cabeceraCotizacion = ncotizacion.obtenerCotizacionCabecera(cadenaConex, cabeceraCotizacion)
        If cabeceraCotizacion.IdCliente = 0 Then 'no exite cotizacion
            If cabeceraCotizacion.IdProspecto = 0 Then
                MsgBox("Esa Cotización no ha sido creado", MsgBoxStyle.Exclamation, "Cotización no existente")
                Limpiar()
                TxtFolio.Text = cabeceraCotizacion.IdCotizacion
            Else
                RellenaCotizadorCabecera(cabeceraCotizacion)
                RecuperacionCotizacionDetalle()
                CalculaNumeros(DgvPedidos.CurrentRow)
            End If
        Else
            RellenaCotizadorCabecera(cabeceraCotizacion)
            RecuperacionCotizacionDetalle()
            CalculaNumeros(DgvPedidos.CurrentRow)
        End If
    End Sub
    Private Sub RecuperacionCotizacionDetalle()
        Dim CotizacionDetalle As New Cotizacion
        Dim detallePedido As New LProducto
        Dim ncotizacion As New NCotizacion
        CotizacionDetalle.IdCotizacion = TxtFolio.Text
        detallePedido = ncotizacion.obtenerCotizacionDetalle(cadenaConex, CotizacionDetalle)
        RellarCotizadorDetalle(detallePedido)
    End Sub
    Private Function ObtenerProducto(producto As Producto)
        Dim obtenerInfo As New NProducto
        Return obtenerInfo.ObtenerProductoPedidos(cadenaConex, producto)
    End Function
#End Region
#Region "Formulario"
    Private Sub CalculaNumeros(ByVal row As DataGridViewRow)
        CalculaPrecioTotal(row)
        CalculaIva(row)
        CalculaSubtotal(row)
        CalculaTotales()
        CalcularTotal(row)
        NumerosALetras()
    End Sub

    Private Sub CalculaPrecioTotal(row As DataGridViewRow)
        If row.Cells("Codigo").Value IsNot Nothing Then
            row.Cells("precioTotal").Value = row.Cells("Precio").Value * row.Cells("Cantidad").Value
            DgvPedidos.Columns("precioTotal").DefaultCellStyle.Format = "$ ##,##0.00"
        End If
    End Sub
    Private Sub CalculaSubtotal(row As DataGridViewRow)
        If row.Cells("Codigo").Value IsNot Nothing And row.Cells("ColumnaIva").Value <> 0 Then
            row.Cells("Subtotal").Value = row.Cells("precioTotal").Value + row.Cells("ColumnaIva").Value
            DgvPedidos.Columns("Subtotal").DefaultCellStyle.Format = "$ ##,##0.00"
        End If
    End Sub
    Private Sub CalculaIva(row As DataGridViewRow)
        row.Cells("ColumnaIva").Value = row.Cells("PrecioTotal").Value * iva
        DgvPedidos.Columns("ColumnaIva").DefaultCellStyle.Format = "$ ##,##0.00"
    End Sub
    Private Sub CalculaTotales()
        Dim total As Double, ivaT As Double, bruto As Double
        For Each fila As DataGridViewRow In DgvPedidos.Rows
            total = total + fila.Cells("Subtotal").Value
            ivaT = ivaT + fila.Cells("ColumnaIva").Value
            bruto = bruto + fila.Cells("precioTotal").Value
        Next

        TxtTotal.Text = Format(CType(total, Decimal), "$#,##0.00")
        TxtIva.Text = Format(CType(ivaT, Decimal), "$#,##0.00")
        TxtSubtotal.Text = Format(CType(bruto, Decimal), "$#,##0.00")
    End Sub
    Private Sub CalcularTotal(row As DataGridViewRow)
        If row.Cells("Codigo").Value IsNot Nothing Then
            'row.Cells("Total").Value = row.Cells("Subtotal").Value
            DgvPedidos.Columns("Subtotal").DefaultCellStyle.Format = "$ ##,##0.00"
        End If
    End Sub

    Private Sub TabCotizacion_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvPedidos.KeyDown
        If e.KeyData = Keys.F3 Then
            btnF3_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub BtnPdf_Click(sender As Object, e As EventArgs) Handles BtnPdf.Click
        Dim url As String
        url = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim Cotizacion As New Cotizacion() : Dim NCotizacion As New NCotizacion()
        Dim Sucursal As New Sucursales()
        Dim Documento As New Documento
        Sucursal = obtenerInforSuc()
        Sucursal.IdSuc = Me.idSuc
        Cotizacion = RellenaObjetoCotizacion(Cotizacion)
        NCotizacion.FormatoCotizacion(cadenaConex, "Cotizacion", Cotizacion, Sucursal, url)
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        Dim confirmacion As Integer
        confirmacion = MsgBox("¿Desea enviar la Cotización N°" & Me.idCotizacion & "", vbYesNo + vbQuestion + vbDefaultButton2, "Enviar Cotización Leal")
        If confirmacion = vbYes Then
            Dim url As String
            Dim util As New NUtilerias()
            Dim Suc As New Sucursales()
            Dim Doc As New Documento()
            Dim Cliente As New Cliente()
            Dim correo As String
            Dim PasswordCorreo As String

            Suc.IdSuc = Me.idSuc
            Doc.IdDocumento = 4 'cotizacion
            Cliente.IdCliente = TxtCodCte.Text
            url = My.Computer.FileSystem.SpecialDirectories.Temp & "\Cotizacion " & TxtFolio.Text & ".pdf"
            correo = Me.usuarios.Email
            PasswordCorreo = Me.usuarios.PasswordCorreo

            util.EnviarDocumento(False, cadenaConex, Suc, Doc, TxtFolio.Text, Cliente, url, correo, PasswordCorreo)

        End If
    End Sub
    Private Function obtenerCliente()
        Dim negocio As New NCliente
        If TxtCodCte.Text <> Nothing Then
            Return negocio.ObtenerCorreoCliente(cadenaConex, TxtCodCte.Text)
        End If
    End Function
    Private Function obtenerInforSuc() As Sucursales
        Dim Sucursal As New Sucursales()
        Dim nsucursal As New NSucursales
        Sucursal.IdSuc = Me.usuarios.IdSucursal
        Return nsucursal.ObtenerInformacionTimbrar(cadenaConex, Sucursal)
    End Function

    Private Function obtenerConfiguracion() As Configuracion
        Dim negocio As New NConfiguracion
        Dim sucursales As New Sucursales
        sucursales.IdSuc = Me.usuarios.IdSucursal
        Return negocio.ObtenerConfiguracionTimbrar(cadenaConex, sucursales)
    End Function

    Private Sub BtnLimpiar_Click_1(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub
#End Region
End Class
