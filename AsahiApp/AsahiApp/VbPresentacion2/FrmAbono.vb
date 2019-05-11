Imports System.Windows.Forms
Imports Clases
Imports Negocio
Public Class FrmAbono
#Region "Variables de Clase"
    Private cadenaConex As String
    Private usuario As New Usuario
    Private Suc As Integer
    Private Abonos As New Abono 'Si viene lleno=directo de factura(abono a 1 factura) , Vacio=desde menu(abono a varias facturas)
    Private idRecuperado As String 'id recuperado del buscador
    Private tabla As SByte 'clientes=1, productos=2
    Private idAbono As Integer
    Private NumCta As Boolean
    Private NumCtaCte As Boolean
#End Region
#Region "Constructores"
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    ''' <summary>
    ''' Llamado desde una factura en concreto
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="suc"></param>
    ''' <param name="cadenaConex"></param>
    ''' <param name="Abono">Info de la factura en cuestion</param>
    Sub New(ByVal usuario As Usuario, ByVal suc As Integer, ByVal cadenaConex As String, ByVal Abono As Abono)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
        Me.usuario = usuario
        Me.Suc = suc
        Me.Abonos = Abono
    End Sub
    ''' <summary>
    ''' Llamado desde el Menú: Un Abono para una o varias Facturas
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="suc"></param>
    ''' <param name="cadenaConex"></param>
    Sub New(ByVal usuario As Usuario, ByVal suc As Integer, ByVal cadenaConex As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
        Me.usuario = usuario
        Me.Suc = suc
    End Sub
    Sub New(ByVal usuario As Usuario, ByVal suc As Integer, ByVal cadenaConex As String, ByVal idAbono As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.cadenaConex = cadenaConex
        Me.usuario = usuario
        Me.Suc = suc
        Me.idAbono = idAbono
    End Sub
#End Region
#Region "Procesos Iniciales"
    Private Sub FrmAbono_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Cliente As New Cliente()

        ControlesOrigenFactura(False)
        RbArgo.Checked = True
        RellenaCmbTipoAbono()
        RellenarComboBox()

        If Me.Abonos.IdCliente <> 0 Then 'Si viene de una factura en especifico
            DgvFacturas.Columns("idFactura").ReadOnly = True
            Cliente.IdCliente = Me.Abonos.IdCliente
            'RecuperaCuentaBancaria
            RellenaCliente(Cliente)
            RellenaDGV(Me.Abonos)
            BloquearControles()
        Else 'Si se abre desde el Menú

            If Me.idAbono > 0 Then 'Si se recupera un abono
                Dim Abono As New Abono()
                TxtFolio.Text = Me.idAbono
                Abono.IdAbono = Me.idAbono
                Abono = RecuperaAbono(Abono)
                RellenaInfoAbono(Abono)
                RecuperaInfoAbono(Abono)
                CalculaTotales()
            End If
        End If
    End Sub
    Private Sub BloquearControles()
        TxtIdCte.ReadOnly = True
        TxtNombreCte.ReadOnly = True
    End Sub

#End Region
#Region "Eventos Especiales en controles"
    Private Sub TxtCantidad_Leave(sender As Object, e As EventArgs) Handles TxtCantidad.Leave
        If TxtCantidad.Text <> "" Then
            TxtCantidad.Text = String.Format("{0:C2}", Convert.ToDecimal(TxtCantidad.Text))
        End If
    End Sub
    Private Sub TxtFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFolio.KeyDown
        If e.KeyCode = Keys.Enter And TxtFolio.Text <> "" Then
            Dim Abono As New Abono
            Abono.IdAbono = TxtFolio.Text
            Abono = RecuperaAbono(Abono)
            RellenaInfoAbono(Abono)
            RecuperaInfoAbono(Abono)
            CalculaTotales()
        End If
    End Sub

    Private Sub ControlesOrigenFactura(ByVal origen As Boolean)
        If origen = True Then 'AdminPAQ
            DgvFacturas.Columns("Total").ReadOnly = False
            DgvFacturas.Columns("Fecha").ReadOnly = False
            DgvFacturas.Columns("FolioFiscal").Visible = True
            DgvFacturas.Columns("FolioFiscal").ReadOnly = False
        Else 'Argo
            DgvFacturas.Columns("FolioFiscal").Visible = False
            DgvFacturas.Columns("FolioFiscal").ReadOnly = True
        End If
    End Sub

#End Region
#Region "ToolTip"
    Private Sub TxtNOperacion_MouseHover(sender As Object, e As EventArgs) Handles TxtNOperacion.MouseHover
        ToolTip1.SetToolTip(TxtNOperacion, "Numero de cheque" & vbCrLf & "Numero de Autorizacion" & vbCrLf & "Clave de Rastreo" & vbCrLf & "Linea de Captura")
        ToolTip1.ToolTipTitle = "Numero de Operacion"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
#End Region
#Region "Boton F3"
    Private Sub TxtCuenta_GotFocus(sender As Object, e As EventArgs) Handles TxtCuenta.GotFocus
        btnF3.Visible = True
        btnF3.Parent = Me.GbBeneficiario
        btnF3.Location = New Drawing.Point(143, 36)
    End Sub
    Private Sub TxtIdCte_GotFocus(sender As Object, e As EventArgs) Handles TxtIdCte.GotFocus
        If Me.Abonos.IdCliente = 0 Then 'Si No tiene idCliente es abierto desde el Menú
            btnF3.Visible = True
            btnF3.Parent = Me.GbCliente
            btnF3.BringToFront()
            btnF3.Location = New Drawing.Point(65, 32)
        End If
    End Sub
    Private Sub TxtCuentaCliente_GotFocus(sender As Object, e As EventArgs) Handles TxtCuentaCliente.GotFocus
        btnF3.Visible = True
        btnF3.Parent = Me.GbCliente
        btnF3.Location = New Drawing.Point(143, 72)
    End Sub
    Private Sub btnF3_Click(sender As Object, e As EventArgs) Handles btnF3.Click
        Select Case btnF3.Location.X
            Case 65 And btnF3.Location.Y = 32 'codCliente desde factura y pedido
                Dim frm As New FrmBuscador(1, 1, cadenaConex)
                If frm.ShowDialog() = DialogResult.OK Then
                    idRecuperado = frm.Id
                    tabla = 1 'clientes
                    CargaId()
                End If
            Case 143 And btnF3.Location.Y = 72 'Cuenta Cliente
                Dim frm As New FrmBuscadorCuenta(cadenaConex, "cliente", TxtIdCte.Text, TxtNombreCte.Text)
                If frm.ShowDialog() = DialogResult.OK Then
                    TxtCuentaCliente.Tag = frm.idCuentaBanco
                    TxtCuentaCliente.Text = frm.cuenta
                    LblBancoE.Text = frm.nom
                    LblRFCBancoE.Text = frm.rfcBanco
                End If
            Case 143 And btnF3.Location.Y = 36 'Cuenta Destinatario
                Dim frm As New FrmBuscadorCuenta(cadenaConex, Nothing, 0, Nothing)
                If frm.ShowDialog() = DialogResult.OK Then
                    TxtCuenta.Tag = frm.idCuentaBanco
                    TxtCuenta.Text = frm.cuenta
                    LblBancoD.Text = frm.nom
                    LblRFCBancoD.Text = frm.rfcBanco
                End If
                btnF3.Visible = False
        End Select

    End Sub
    Private Sub CargaId()
        Select Case tabla
            Case 1 'cliente
                Dim Cliente As New Cliente()
                Cliente.IdCliente = idRecuperado
                RellenaCliente(Cliente)
        End Select
    End Sub
#End Region
#Region "Botones"
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If LblTimbrado.Text <> "TIMBRADO" And LblTimbrado.Text <> "CANCELADO" Then
            If RevisarCampos() Then
                Dim Abono As New Abono()
                Dim lst As New LAbono()
                Dim NAbono As New NAbono()

                Abono = RellenaObjAbono(Abono)
                lst = RellenaLstAbono(lst)

                If RevisarDGV(lst) Then

                    If TxtFolio.Text = "" Then 'Insertar
                        lst = NAbono.InsertaAbono(Me.cadenaConex, Abono, lst)
                        If lst.Item(0).IdAbono > 0 Then
                            TxtFolio.Text = lst.Item(0).IdAbono
                            RellenaIdAbonoFactura(lst)
                        End If
                        FormatoTimbrado()
                    Else 'Modificar
                        Dim resultado As MsgBoxResult
                        resultado = MsgBox("¿Desea Modificar el Abono?", vbYesNo + vbQuestion, "Advertencia")
                        If resultado = vbYes Then
                            lst = NAbono.ModificaAbono(Me.cadenaConex, Abono, lst)
                            If lst.Item(0).IdAbono > 0 Then
                                TxtFolio.Text = lst.Item(0).IdAbono
                                RellenaIdAbonoFactura(lst)
                            End If
                        End If
                    End If
                Else
                    MsgBox("Los Abonos a Factura del AminPAQ requieren indicar el FolioFiscal", vbOK = MsgBoxStyle.Exclamation, "No se puede Guardar/Modificar")
                End If

            End If
        Else
            MsgBox("No se pueden Modificar Abonos Cancelados o Timbrados", vbOK = MsgBoxStyle.Exclamation, "No se puede modificar")
        End If
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
    Private Sub BtnTimbrar_Click(sender As Object, e As EventArgs) Handles BtnTimbrar.Click
        Timbrar()
    End Sub
    Private Sub btnMostrarPDF_Click(sender As Object, e As EventArgs) Handles btnMostrarPDF.Click
        Dim Abono As New Abono() : Dim NTimbrar As New NTimbrar()
        Dim Sucursal As New Sucursales()
        Dim Documento As New Documento

        Documento.IdDocumento = 2 'Pago

        Sucursal.IdSuc = Me.Suc
        Abono = RellenaObjAbono(Abono)
        NTimbrar.FormatoCFDI(cadenaConex, "Abono", Abono, Sucursal, Documento)
    End Sub
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        If LblTimbrado.Text = "TIMBRADO" Then
            Dim confirmacion As Integer
            Dim NAbono As New NAbono

            confirmacion = MsgBox("¿Desea enviar el REP N°" & TxtFolio.Text & "", vbYesNo + vbQuestion + vbDefaultButton2, "Enviar REP")
            If confirmacion = vbYes Then
                Dim util As New NUtilerias()
                Dim Cliente As New Cliente() : Cliente.IdCliente = TxtIdCte.Text
                Dim Suc As New Sucursales() : Suc.IdSuc = Me.Suc
                Dim Doc As New Documento() : Doc.IdDocumento = 2 'Abono

                util.EnviarDocumento(True, cadenaConex, Suc, Doc, TxtFolio.Text, Cliente)

            End If
        Else
            MsgBox("No se puede enviar si aún no se ha timbrado")
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Cancelar()
    End Sub
#End Region
#Region "Rellena Controles"
    Private Function RecuperaAbono(ByVal Abono As Abono) As Abono
        'Dim Abono As New Abono()
        Dim NAbono As New NAbono()

        'Abono.IdAbono = TxtFolio.Text
        Return NAbono.RecuperarCabecera(cadenaConex, Abono)
    End Function
    Private Sub RecuperaInfoAbono(ByVal Abono As Abono)
        Dim Cliente As New Cliente()
        Dim lst As New LAbono()
        Dim lstB As New LBanco()
        Dim NAbono As New NAbono()

        'Cliente
        Cliente.IdCliente = Abono.IdCliente

        RellenaCliente(Cliente)
        'Cuentas Bancarias
        lstB = NAbono.RecuperarCuentas(cadenaConex, Abono)
        RellenaInfoCuentas(lstB)
        'Facturas (Detalle)

        lst = NAbono.RecuperarDetalles(cadenaConex, Abono)
        If lst.Item(0).IdFacturaAdmin > 0 Then RbAdminPAQ.Checked = True

        RellenaDGV(lst)
        FormatoTimbrado()
    End Sub
    Private Sub RellenaInfoCuentas(ByVal lstB As LBanco)
        Dim i As Byte

        For Each item In lstB
            If i = 0 Then 'InfoCuentas Clientes
                If lstB.Item(i).IdCuentaBancaria > 0 Then
                    TxtCuentaCliente.Tag = lstB.Item(i).IdCuentaBancaria
                    TxtCuentaCliente.Text = lstB.Item(i).NoCuentaBanco
                    LblBancoE.Text = lstB.Item(i).Nombre
                    LblRFCBancoE.Text = lstB.Item(i).Rfc
                End If
                TxtReferencia.Text = lstB.Item(i).Referencia
                TxtNOperacion.Text = lstB.Item(i).NumeroOperacion
            ElseIf i = 1 Then 'InfoCuentas Destinatario
                If lstB.Item(i).IdCuentaBancaria Then
                    TxtCuenta.Tag = lstB.Item(i).IdCuentaBancaria
                    TxtCuenta.Text = lstB.Item(i).NoCuentaBanco
                    LblBancoD.Text = lstB.Item(i).Nombre
                    LblRFCBancoD.Text = lstB.Item(i).Rfc
                End If
            End If
                i = +1
        Next
    End Sub
    Private Sub RellenaInfoAbono(ByVal A As Abono)
        'If A.Fiscal Then
        '    CmbTipoAbono.SelectedIndex = 1
        'Else
        '    CmbTipoAbono.SelectedIndex = 0
        'End If
        DtpFecha.Value = Format(A.FechaAbono, "dd/MM/yyyy")
        TxtCantidad.Text = String.Format("{0:C2}", Convert.ToDecimal(A.Total))
        CmbFormaPago.SelectedValue = A.IdFormaPago
        CmbMoneda.SelectedValue = A.IdMoneda
        TxtObservaciones.Text = A.Observaciones
        LblUUID.Text = A.FolioFiscal
        If A.Timbrado And A.Cancelado = False Then
            LblTimbrado.Text = "TIMBRADO"
        ElseIf A.Timbrado = False And A.Cancelado = False Then
            LblTimbrado.Text = ""
        ElseIf A.Cancelado = True Then
            LblTimbrado.Text = "CANCELADO"
        End If
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
        'If Cliente.IdFormaPago <> 0 Then CmbFormaPago.SelectedValue = Cliente.IdFormaPago
        If Cliente.IdMoneda <> 0 Then CmbMoneda.SelectedValue = Cliente.IdMoneda
    End Sub
    Private Sub RellenarComboBox()
        CargaCmbFormaPago()
        CargaMoneda()
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
    Private Sub RellenaCmbTipoRelacion()
        With CmbTipoAbono
            .Items.Add("Factura")
            .Items.Add("Sustitucion de los CFDIs Previos")
        End With
    End Sub
    Private Sub RellenaCmbTipoAbono()
        With CmbTipoAbono
            '.Items.Add("Pago del Cliente")
            .Items.Add("Pago del Cliente CFDI (REP)")
            .SelectedIndex = 0
        End With
    End Sub
#End Region
#Region "Rellena Objetos"
    Private Function RellenaObjAbono(ByVal A As Abono) As Abono
        Dim util As New Numalet()
        If TxtFolio.Text <> "" Then A.IdAbono = TxtFolio.Text
        A.ConceptoAbono = CmbTipoAbono.Text
        A.Fecha = Today
        A.FechaAbono = DtpFecha.Value
        A.IdCuenta = TxtCuenta.Tag
        A.Total = TxtTAbonos.Text
        A.TotalLetras = UCase(util.ToCustomCardinal(A.Total))
        A.IdCliente = TxtIdCte.Text
        A.IdCuentaCliente = TxtCuentaCliente.Tag
        A.Referencia = TxtReferencia.Text
        A.IdMoneda = CmbMoneda.SelectedItem.idMoneda
        A.IdFormaPago = CmbFormaPago.SelectedItem.idFormaPago
        A.NumeroOperacion = TxtNOperacion.Text
        A.Observaciones = TxtObservaciones.Text
        If CmbTipoAbono.Text = "Pago del Cliente CFDI (REP)" Then
            A.Fiscal = True
        ElseIf CmbTipoAbono.Text = "Pago del Cliente" Then
            A.Fiscal = False
        End If
        If LblTimbrado.Text = "TIMBRADO" Then A.Timbrado = True
        Return A
    End Function
    Private Function RellenaLstAbono(ByVal lstAbono) As LAbono
        Dim i As Byte


        For i = 0 To DgvFacturas.Rows.Count - 1
            With DgvFacturas.Rows(i)
                'If .Cells("idFactura").Value IsNot DBNull.Value Then 'IsNot Nothing Then
                Dim A As New Abono()
                A.IdAbonoFactura = .Cells("idAbonoFactura").Value
                A.FolioFiscal = .Cells("FolioFiscal").Value
                If RbArgo.Checked = True Then A.IdFactura = .Cells("idFactura").Value
                If RbAdminPAQ.Checked = True Then A.IdFacturaAdmin = .Cells("idFactura").Value
                A.Total = .Cells("Abono").Value
                A.SaldoAnterior = .Cells("SaldoAnterior").Value
                A.SaldoActual = .Cells("SaldoActual").Value
                If A.IdFactura > 0 Or A.IdFacturaAdmin > 0 Then lstAbono.Add(A)
                'End If
            End With
        Next

        Return lstAbono
    End Function
    Private Sub EliminarFilasVacias()
        For X = 0 To Me.DgvFacturas.Rows.Count - 1
            If Me.DgvFacturas.Rows(X).Cells(1).Value = Nothing Then
                If Not (Me.DgvFacturas.Rows(X).IsNewRow) Then
                    Me.DgvFacturas.Rows.Remove(Me.DgvFacturas.Rows(X))
                End If
            End If
        Next
    End Sub
    Private Function RellenaLstCuentas(ByVal lstCtas As LBanco) As LBanco
        Dim cuentaD As New Banco()
        Dim cuentaE As New Banco()
        'Destinatario
        'If TxtCuenta.Text IsNot Nothing And TxtCuenta.Text <> "" Then
        cuentaD.IdCuentaBancaria = TxtCuenta.Tag
        If Me.NumCta = False Then cuentaD.NoCuentaBanco = TxtCuenta.Text
        cuentaD.Nombre = LblBancoD.Text
        cuentaD.Rfc = LblRFCBancoD.Text
        lstCtas.Add(cuentaD)
        'End If

        'Emisor
        'If TxtCuentaCliente.Text IsNot Nothing And TxtCuenta.Text <> "" Then
        cuentaE.IdCuentaBancaria = TxtCuentaCliente.Tag
        If Me.NumCtaCte = False Then cuentaE.NoCuentaBanco = TxtCuentaCliente.Text
        cuentaE.Nombre = LblBancoE.Text
        cuentaE.Rfc = LblRFCBancoE.Text
        lstCtas.Add(cuentaE)
        'End If
        Return lstCtas
    End Function

#End Region
#Region "Procesos de Verificacion"
    Private Function RevisarDGV(ByVal lst As LAbono) As Boolean
        For Each item In lst
            If item.FolioFiscal = "" And RbAdminPAQ.Checked = True Then
                Return False
            End If
            Return True
        Next
    End Function
    Private Function RevisarCuentas() As Boolean
        If CmbFormaPago.SelectedValue = 2 Then 'cheque
            Return CuentasCheque()
        ElseIf CmbFormaPago.SelectedValue = 3 Then 'transferencia
            Return CuentasTransferencia()
        ElseIf CmbFormaPago.SelectedValue = 4 Or CmbFormaPago.SelectedValue = 28 Then
        End If
        Return False
    End Function
    Private Function CuentasCheque() As Boolean
        Dim resultado As Boolean = False
        Dim veredicto As Boolean = False

        If Len(TxtCuentaCliente.Text) = 11 Or Len(TxtCuentaCliente.Text) = 18 Then
            GoTo beneficiario
        Else
            resultado = MsgBox("El Numero de cuenta del Cliente debe tener 11 o 18 digitos" &
                                    vbCrLf & "Si Acepta Continuar el numero de cuenta NO se verá reflejado en el XML" &
                                    vbCrLf & "¿Desea Continuar?", vbYesNo + vbQuestion, "Advertencia")
            If resultado = True Then
                Me.NumCtaCte = True 'Borra la cuenta
beneficiario:
                If Len(TxtCuenta.Text) = 10 Or Len(TxtCuenta.Text) = 11 Or Len(TxtCuenta.Text) = 15 Or Len(TxtCuenta.Text) = 16 Or Len(TxtCuenta.Text) = 18 Then
                    veredicto = True
                Else
                    resultado = MsgBox("El Numero de cuenta de la sucursal (Beneficiario) debe tener 10,11,15,16 o 18 digitos" &
                                    vbCrLf & "Si Acepta Continuar el numero de cuenta NO se verá reflejado en el XML" &
                                    vbCrLf & "¿Desea Continuar?", vbYesNo + vbQuestion, "Advertencia")
                    If resultado = True Then
                        Me.NumCta = True 'Borra la cuenta
                        veredicto = True
                    End If
                End If
            End If
        End If
        Return veredicto
    End Function
    Private Function CuentasTransferencia() As Boolean
        Dim resultado As Boolean = False
        Dim veredicto As Boolean = False

        If Len(TxtCuentaCliente.Text) = 10 Or Len(TxtCuentaCliente.Text) = 16 Or Len(TxtCuentaCliente.Text) = 18 Then
            GoTo beneficiario
        Else
            resultado = MsgBox("El Numero de cuenta del Cliente debe tener 10,16 o 18 digitos" &
                                    vbCrLf & "Si Acepta Continuar el numero de cuenta NO se verá reflejado en el XML" &
                                    vbCrLf & "¿Desea Continuar?", vbYesNo + vbQuestion, "Advertencia")
            If resultado = True Then
                Me.NumCtaCte = True 'Borra la cuenta
beneficiario:
                If Len(TxtCuenta.Text) = 10 Or Len(TxtCuenta.Text) = 18 Then
                    veredicto = True
                Else
                    resultado = MsgBox("El Numero de cuenta de la sucursal (Beneficiario) debe tener 10 o 18 digitos" &
                                    vbCrLf & "Si Acepta Continuar el numero de cuenta NO se verá reflejado en el XML" &
                                    vbCrLf & "¿Desea Continuar?", vbYesNo + vbQuestion, "Advertencia")
                    If resultado = True Then
                        Me.NumCta = True 'Borra la cuenta
                        veredicto = True
                    End If
                End If
            End If
        End If
        Return veredicto
    End Function
    Private Function CuentasTarjetas() As Boolean
        Dim resultado As Boolean = False
        Dim veredicto As Boolean = False

        If Len(TxtCuentaCliente.Text) = 16 Then
            GoTo beneficiario
        Else
            resultado = MsgBox("El Numero de cuenta del Cliente debe tener 16 digitos" &
                                    vbCrLf & "Si Acepta Continuar el numero de cuenta NO se verá reflejado en el XML" &
                                    vbCrLf & "¿Desea Continuar?", vbYesNo + vbQuestion, "Advertencia")
            If resultado = True Then
                Me.NumCtaCte = True 'Borra la cuenta
beneficiario:
                If Len(TxtCuenta.Text) = 10 Or Len(TxtCuenta.Text) = 11 Or Len(TxtCuenta.Text) = 15 Or Len(TxtCuenta.Text) = 16 Or Len(TxtCuenta.Text) = 18 Then
                    veredicto = True
                Else
                    resultado = MsgBox("El Numero de cuenta de la sucursal (Beneficiario) debe tener 10,11,15,16 o 18 digitos" &
                                    vbCrLf & "Si Acepta Continuar el numero de cuenta NO se verá reflejado en el XML" &
                                    vbCrLf & "¿Desea Continuar?", vbYesNo + vbQuestion, "Advertencia")
                    If resultado = True Then
                        Me.NumCta = True 'Borra la cuenta
                        veredicto = True
                    End If
                End If
            End If
        End If
        Return veredicto
    End Function
    Private Function RevisarCampos() As Boolean
        If CmbTipoAbono.Text <> "" Then
            If TxtIdCte.Text <> "" Then
                If TxtCantidad.Text <> "" Then
                    If CmbFormaPago.Text <> "" Then
                        If CmbMoneda.Text <> "" Then
                            If TxtCantidad.Text = TxtTAbonos.Text Then
                                Return True
                            Else
                                MsgBox("La cantidad de Abonos tiene que ser igual al total de los abonos" & vbCrLf &
                                   "Ingrese Saldo Anterior y Abono en la(s) factura(s) seleccionada(s)", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
                            End If
                        Else
                            MsgBox("Es necesario seleccionar una Moneda", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
                        End If
                    Else
                        MsgBox("Es necesario seleccionar una Forma de Pago", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
                    End If
                Else
                    MsgBox("Es necesario especificar la Cantidad del Abono", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
                End If
            Else
                MsgBox("Es necesario seleccionar un Cliente", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
            End If
        Else
            MsgBox("Es necesario seleccionar un Tipo de Abono", MsgBoxStyle.Exclamation, "Llenar campos") : Return False
        End If
        Return False
    End Function
#End Region
#Region "DataGridView"
    Private Sub DgvFacturas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFacturas.CellEndEdit
        Dim row As DataGridViewRow = DgvFacturas.Rows(e.RowIndex)

        If DgvFacturas.Columns(e.ColumnIndex).Name = "Abono" Then
            CalculaSaldoActual(row)
            CalculaTotales()
            DgvFacturas.CurrentRow.Cells("Abono").Value = Convert.ToDecimal(DgvFacturas.CurrentRow.Cells("Abono").Value)
        ElseIf DgvFacturas.Columns(e.ColumnIndex).Name = "Total" Then
            CalculaSaldoActual(row)
        ElseIf DgvFacturas.Columns(e.ColumnIndex).Name = "SaldoAnterior" Then
            DgvFacturas.CurrentRow.Cells("SaldoAnterior").Value = Convert.ToDecimal(DgvFacturas.CurrentRow.Cells("SaldoAnterior").Value)
            CalculaSaldoActual(row)
        ElseIf DgvFacturas.Columns(e.ColumnIndex).Name = "idFactura" And RbArgo.Checked = True Then
            Dim Factura As New Factura
            Factura.IdFactura = DgvFacturas.Rows(e.RowIndex).Cells("idFactura").Value
            Factura = RecuperaFactura(Factura)

            If TxtIdCte.Text <> "" Then ' si pertenece al mismo cliente seleccionado
                If TxtIdCte.Text = Factura.IdCliente Then
cliente:
                    RellenaInfoFacturas(Factura, e.RowIndex)
                    TxtIdCte.Text = Factura.IdCliente

                    Dim cliente As New Cliente
                    cliente.IdCliente = Factura.IdCliente
                    RellenaCliente(cliente)
                Else
                    DgvFacturas.Rows(e.RowIndex).Cells("idFactura").Value = ""
                    MsgBox("La factura seleccionada debe pertenecer al mismo cliente", vbOKOnly = MsgBoxStyle.Critical, "Error de Cliente")
                End If
            Else
                GoTo cliente
            End If


        End If
    End Sub
    Private Function RecuperaFactura(ByVal Factura As Factura) As Factura
        Dim NFactura As New NFactura()
        Return NFactura.RecuperaFacturaCxc(cadenaConex, Factura)
    End Function
    Private Sub RellenaInfoFacturas(ByVal Factura As Factura, ByVal i As Byte)
        DgvFacturas.Rows(i).Cells("Fecha").Value = Factura.Fecha
        DgvFacturas.Rows(i).Cells("Total").Value = Factura.Total
        DgvFacturas.Rows(i).Cells("saldoAnterior").Value = Factura.Saldo
    End Sub
    Private Sub CalculaSaldoActual(row As DataGridViewRow)
        Dim saldoAnterior As Double
        Dim Abono As Double

        If DgvFacturas.Rows(row.Index).Cells("SaldoAnterior").Value <> 0 Then
            saldoAnterior = DgvFacturas.Rows(row.Index).Cells("SaldoAnterior").Value
            Abono = DgvFacturas.Rows(row.Index).Cells("Abono").Value

            DgvFacturas.Rows(row.Index).Cells("SaldoActual").Value = saldoAnterior - Abono

        Else
            MsgBox("Es necesario especificar el saldo anterior" & vbCrLf &
                   "Si no lo especifica no se podrá guardar el Abono", MsgBoxStyle.Exclamation, "Llenar campos")
        End If

    End Sub
    Private Sub CalculaTotales()
        Dim i As Byte
        Dim total As Double
        Dim cantidad As Double

        If TxtCantidad.Text <> "" Then
            cantidad = TxtCantidad.Text

            For i = 0 To DgvFacturas.Rows.Count - 1
                With DgvFacturas.Rows(i)
                    total = total + .Cells("Abono").Value
                End With
            Next i

            TxtTAbonos.Text = Format(CType(total, Decimal), "$#,##0.00")
            TxtPorAplicar.Text = Format(CType(cantidad - total, Decimal), "$#,##0.00")
        Else
            MsgBox("Es necesario especificar la Cantidad del Abono" & vbCrLf &
                  "Si no lo especifica no se podrá guardar el Abono", MsgBoxStyle.Exclamation, "Llenar campos")
        End If
    End Sub
    ''' <summary>
    ''' Rellenar DGV con una factura
    ''' </summary>
    ''' <param name="a"></param>
    Private Sub RellenaDGV(ByVal a As Abono)
        With DgvFacturas
            .Rows(0).Cells("Fecha").Value = a.FechaFactura
            .Rows(0).Cells("IdFactura").Value = a.IdFactura
            .Rows(0).Cells("Total").Value = a.TotalFactura
            If a.IdAbonoFactura > 0 Then .Rows(0).Cells("idAbonoFactura").Value = a.IdAbonoFactura
            'If a.SaldoAnterior > 0 Then .Rows(0).Cells("saldoAnterior").Value = a.SaldoAnterior
            If a.FolioFiscal <> "" Then .Rows(0).Cells("FolioFiscal").Value = a.FolioFiscal
        End With
    End Sub
    ''' <summary>
    ''' Rellenar DGV con MAS de una Factura
    ''' </summary>
    ''' <param name="lst"></param>
    Private Sub RellenaDGV(ByVal lst As LAbono)
        Dim i As Byte
        Dim filas As Byte
        Dim x As Byte

        filas = lst.Count

        If filas > 1 Then
            For x = 1 To filas - 1
                DgvFacturas.Rows.Add()
            Next
        End If

        With DgvFacturas
            For Each item In lst
                .Rows(i).Cells("Fecha").Value = lst.Item(i).FechaFactura
                If lst.Item(i).IdFactura > 0 Then .Rows(i).Cells("IdFactura").Value = lst.Item(i).IdFactura
                If lst.Item(i).IdFacturaAdmin > 0 Then .Rows(i).Cells("IdFactura").Value = lst.Item(i).IdFacturaAdmin
                .Rows(i).Cells("Total").Value = lst.Item(i).TotalFactura
                .Rows(i).Cells("Abono").Value = lst.Item(i).Total
                .Rows(i).Cells("idAbonoFactura").Value = lst.Item(i).IdAbonoFactura
                .Rows(i).Cells("FolioFiscal").Value = lst.Item(i).FolioFiscal
                .Rows(i).Cells("saldoActual").Value = lst.Item(i).TotalFactura - lst.Item(i).Total
                i = i + 1
            Next

        End With
    End Sub
    Private Sub RellenaIdAbonoFactura(ByVal lst As LAbono)
        'DgvFacturas.Rows.Clear()
        Dim iLst As Byte
        Dim iDgv As Byte

        For iDgv = 0 To DgvFacturas.Rows.Count - 1
            For Each item In lst
                If RbArgo.Checked = True Then
                    If DgvFacturas.Rows(iDgv).Cells("idFactura").Value = lst.Item(iLst).IdFactura And
                    DgvFacturas.Rows(iDgv).Cells("Abono").Value = lst.Item(iLst).Total Then
                        DgvFacturas.Rows(iDgv).Cells("idAbonoFactura").Value = lst.Item(iLst).IdAbonoFactura
                    End If
                ElseIf RbAdminPAQ.Checked = True Then
                    If DgvFacturas.Rows(iDgv).Cells("idFactura").Value = lst.Item(iLst).IdFacturaAdmin And
                   DgvFacturas.Rows(iDgv).Cells("Abono").Value = lst.Item(iLst).Total Then
                        DgvFacturas.Rows(iDgv).Cells("idAbonoFactura").Value = lst.Item(iLst).IdAbonoFactura
                    End If
                End If
                iLst = iLst + 1
            Next
            iDgv = iDgv + 1
        Next
    End Sub

#End Region
#Region "Limpiar"
    Private Sub Limpiar()
        Dim Utilerias As New PUtilerias()
        Utilerias.LimpiarComboBox(Me, False, False, False, True, True, False)
        Utilerias.LimpiarTextBox(Me)
        DgvFacturas.Rows.Clear()
        LimpiarLabels()


        DtpFecha.Text = Format(DateTime.Now, "dd/MM/yyyy")
        CmbMoneda.SelectedValue = 2
        Utilerias.HabilitarBotones(Me)
    End Sub
    Private Sub LimpiarLabels()
        LblBancoD.Text = Nothing
        LblRFCBancoD.Text = Nothing
        LblBancoE.Text = Nothing
        LblRFCBancoE.Text = Nothing
    End Sub


#End Region
#Region "Timbrado"
    Private Sub Timbrar()
        If TxtFolio.Text <> "" Then
            If RevisarCuentas() Then
                Dim A As New Abono() : Dim NA As New NAbono() : Dim Suc As New Sucursales() : Dim Doc As New Documento()
                Dim Moneda As New Moneda() : Dim Timbre As New Timbre() : Dim lst As New LAbono() : Dim lstCtas As New LBanco()

                Suc.IdSuc = Me.Suc
                A = RellenaObjAbono(A)
                lst = RellenaLstAbono(lst)
                Doc.IdDocumento = 2 'Pago
                Moneda.Id = A.IdMoneda
                If A.Timbrado = False Then

                    lst = NA.ModificaAbono(Me.cadenaConex, A, lst) 'Guarda Nuevamente antes de timbrar
                    lstCtas = RellenaLstCuentas(lstCtas)

                    Timbre = NA.Timbrar(cadenaConex, A, Suc, Doc, Moneda, lst, lstCtas)

                    If Timbre.CadenaOriginal <> "" Then 'Si fué timbrada
                        LblTimbrado.Text = "TIMBRADO"
                        LblUUID.Text = Timbre.UUID
                        'RellenaDatosCFDI(Timbre)
                        btnMostrarPDF_Click(Nothing, Nothing)
                        FormatoTimbrado()
                    End If

                Else
                    MsgBox("EL Pago ya ha sido timbrado", vbExclamation, "Error")
                End If
            End If
        Else
                MsgBox("Para timbrar es necesario Guardar la factura primero", vbExclamation, "No se puede timbrar")
            End If

    End Sub
    Private Sub FormatoTimbrado()
        If LblTimbrado.Text = "TIMBRADO" Then
            BtnTimbrar.Enabled = False
            BtnGuardar.Enabled = False
            BtnCancelar.Enabled = True
            BtnEnviar.Enabled = True
            btnMostrarPDF.Enabled = True
        ElseIf LblTimbrado.Text = Nothing Then
            BtnTimbrar.Enabled = True
            BtnGuardar.Enabled = True
            BtnCancelar.Enabled = True
            btnMostrarPDF.Enabled = False
            BtnEnviar.Enabled = False
        ElseIf LblTimbrado.Text = "CANCELADO" Then
            BtnTimbrar.Enabled = False
            BtnGuardar.Enabled = False
            BtnCancelar.Enabled = False
            BtnEnviar.Enabled = True
            btnMostrarPDF.Enabled = True
        End If

    End Sub
    Private Sub Cancelar()
        If LblTimbrado.Text <> "CANCELADO" Then
            Dim Abono As New Abono() : Dim NAbono As New NAbono()
            Abono.IdAbono = TxtFolio.Text

            If LblTimbrado.Text = "TIMBRADO" Then
                Dim Suc As New Sucursales()
                Dim UUIDS As New List(Of String)
                Dim Doc As New Documento

                Suc.IdSuc = Me.Suc
                Doc.IdDocumento = 2 'Pagos
                UUIDS.Add(LblUUID.Text)

                If NAbono.CancelarCFDI(Suc, UUIDS, Me.cadenaConex, Doc, Abono) Then
                    LblTimbrado.Text = "CANCELADO"
                End If
            Else 'Si no ha sido timbrado
                Abono.FechaCancelacion = Today
                NAbono.CancelarAbono(cadenaConex, Abono)
                LblTimbrado.Text = "CANCELADO"
            End If
        Else
            MsgBox("El Abono ya está Cancelado", vbOKOnly = MsgBoxStyle.Critical, "Cancelado")
        End If
    End Sub

    Private Sub RbArgo_CheckedChanged(sender As Object, e As EventArgs) Handles RbArgo.CheckedChanged
        If RbArgo.Enabled = True Then
            ControlesOrigenFactura(False)
        End If
    End Sub

    Private Sub RbAdminPAQ_CheckedChanged(sender As Object, e As EventArgs) Handles RbAdminPAQ.CheckedChanged
        If RbAdminPAQ.Enabled = True Then
            ControlesOrigenFactura(True)
        End If
    End Sub







#End Region

End Class