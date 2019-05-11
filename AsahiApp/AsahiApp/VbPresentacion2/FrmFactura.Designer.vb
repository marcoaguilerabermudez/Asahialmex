<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TabFactura = New System.Windows.Forms.TabControl()
        Me.TabPrincipal = New System.Windows.Forms.TabPage()
        Me.LblLetras = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtUtilidad = New System.Windows.Forms.TextBox()
        Me.LblDisponible = New System.Windows.Forms.Label()
        Me.LblExist = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LblIva = New System.Windows.Forms.Label()
        Me.TxtIva = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.CmbAgente = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnF3 = New System.Windows.Forms.Button()
        Me.TxtLugarExpedicion = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CmbMoneda = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbUsoCfdi = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbDiasCred = New System.Windows.Forms.ComboBox()
        Me.LblDiasCred = New System.Windows.Forms.Label()
        Me.CmbMetodoPago = New System.Windows.Forms.ComboBox()
        Me.LblMetodoPago = New System.Windows.Forms.Label()
        Me.DgvFactura = New System.Windows.Forms.DataGridView()
        Me.IdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoSat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtNombreCte = New System.Windows.Forms.TextBox()
        Me.LblCte = New System.Windows.Forms.Label()
        Me.TxtIdCte = New System.Windows.Forms.TextBox()
        Me.TabCfdi = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtCadenaSat = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSelloSat = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtFCertificacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtFolioFiscal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCadenaOriginal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSelloDigital = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFechaEmision = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNumCertificado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabRelaciones = New System.Windows.Forms.TabPage()
        Me.BtnEliminaRelacion = New System.Windows.Forms.Button()
        Me.BtnAgregaRelacion = New System.Windows.Forms.Button()
        Me.DgvRelacionados = New System.Windows.Forms.DataGridView()
        Me.Serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtUuid = New System.Windows.Forms.TextBox()
        Me.CmbTipoRelacion = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabAdicional = New System.Windows.Forms.TabPage()
        Me.TxtPedido = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtOc = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtComentario = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabFirmas = New System.Windows.Forms.TabPage()
        Me.LblAgenteFirma = New System.Windows.Forms.Label()
        Me.LblcomentAgente = New System.Windows.Forms.Label()
        Me.LblComentCxc = New System.Windows.Forms.Label()
        Me.LblComenVta = New System.Windows.Forms.Label()
        Me.LblFirmaVtas = New System.Windows.Forms.Label()
        Me.LblFirmaCxc = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.BtnFirma = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtUltimoMov = New System.Windows.Forms.TextBox()
        Me.TxtFechaAlta = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TxtOrdComFirma = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TxtDiasCredFirma = New System.Windows.Forms.TextBox()
        Me.TxtMetoPagoFirma = New System.Windows.Forms.TextBox()
        Me.TxtLimCredFirma = New System.Windows.Forms.TextBox()
        Me.TxtTipoCliente = New System.Windows.Forms.TextBox()
        Me.TxtSaldoFirma = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TxtUtilFirma = New System.Windows.Forms.TextBox()
        Me.TxtTotalFirma = New System.Windows.Forms.TextBox()
        Me.TxtAgenteFirma = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.TxtClienteFirma = New System.Windows.Forms.TextBox()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.BtnTimbrar = New System.Windows.Forms.Button()
        Me.BtnCancelarCfdi = New System.Windows.Forms.Button()
        Me.BtnPdf = New System.Windows.Forms.Button()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.BttEnviar = New System.Windows.Forms.Button()
        Me.TabFactura.SuspendLayout()
        Me.TabPrincipal.SuspendLayout()
        CType(Me.DgvFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCfdi.SuspendLayout()
        Me.TabRelaciones.SuspendLayout()
        CType(Me.DgvRelacionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAdicional.SuspendLayout()
        Me.TabFirmas.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(394, 8)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(57, 30)
        Me.btnLimpiar.TabIndex = 48
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(64, 8)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(57, 30)
        Me.BtnCancelar.TabIndex = 47
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(6, 8)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(57, 30)
        Me.BtnGuardar.TabIndex = 46
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TabFactura
        '
        Me.TabFactura.Controls.Add(Me.TabPrincipal)
        Me.TabFactura.Controls.Add(Me.TabCfdi)
        Me.TabFactura.Controls.Add(Me.TabRelaciones)
        Me.TabFactura.Controls.Add(Me.TabAdicional)
        Me.TabFactura.Controls.Add(Me.TabFirmas)
        Me.TabFactura.Location = New System.Drawing.Point(6, 45)
        Me.TabFactura.Name = "TabFactura"
        Me.TabFactura.SelectedIndex = 0
        Me.TabFactura.Size = New System.Drawing.Size(856, 609)
        Me.TabFactura.TabIndex = 49
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Controls.Add(Me.LblLetras)
        Me.TabPrincipal.Controls.Add(Me.Label26)
        Me.TabPrincipal.Controls.Add(Me.TxtSubtotal)
        Me.TabPrincipal.Controls.Add(Me.Label23)
        Me.TabPrincipal.Controls.Add(Me.TxtUtilidad)
        Me.TabPrincipal.Controls.Add(Me.LblDisponible)
        Me.TabPrincipal.Controls.Add(Me.LblExist)
        Me.TabPrincipal.Controls.Add(Me.Label22)
        Me.TabPrincipal.Controls.Add(Me.Label21)
        Me.TabPrincipal.Controls.Add(Me.LblIva)
        Me.TabPrincipal.Controls.Add(Me.TxtIva)
        Me.TabPrincipal.Controls.Add(Me.LblTotal)
        Me.TabPrincipal.Controls.Add(Me.txtTotal)
        Me.TabPrincipal.Controls.Add(Me.CmbAgente)
        Me.TabPrincipal.Controls.Add(Me.Label25)
        Me.TabPrincipal.Controls.Add(Me.btnF3)
        Me.TabPrincipal.Controls.Add(Me.TxtLugarExpedicion)
        Me.TabPrincipal.Controls.Add(Me.Label20)
        Me.TabPrincipal.Controls.Add(Me.CmbMoneda)
        Me.TabPrincipal.Controls.Add(Me.Label3)
        Me.TabPrincipal.Controls.Add(Me.CmbUsoCfdi)
        Me.TabPrincipal.Controls.Add(Me.Label2)
        Me.TabPrincipal.Controls.Add(Me.CmbFormaPago)
        Me.TabPrincipal.Controls.Add(Me.Label1)
        Me.TabPrincipal.Controls.Add(Me.CmbDiasCred)
        Me.TabPrincipal.Controls.Add(Me.LblDiasCred)
        Me.TabPrincipal.Controls.Add(Me.CmbMetodoPago)
        Me.TabPrincipal.Controls.Add(Me.LblMetodoPago)
        Me.TabPrincipal.Controls.Add(Me.DgvFactura)
        Me.TabPrincipal.Controls.Add(Me.TxtNombreCte)
        Me.TabPrincipal.Controls.Add(Me.LblCte)
        Me.TabPrincipal.Controls.Add(Me.TxtIdCte)
        Me.TabPrincipal.Location = New System.Drawing.Point(4, 22)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPrincipal.Size = New System.Drawing.Size(848, 583)
        Me.TabPrincipal.TabIndex = 0
        Me.TabPrincipal.Text = "Principal"
        Me.TabPrincipal.UseVisualStyleBackColor = True
        '
        'LblLetras
        '
        Me.LblLetras.AutoSize = True
        Me.LblLetras.Location = New System.Drawing.Point(8, 514)
        Me.LblLetras.Name = "LblLetras"
        Me.LblLetras.Size = New System.Drawing.Size(0, 13)
        Me.LblLetras.TabIndex = 78
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(689, 514)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 13)
        Me.Label26.TabIndex = 77
        Me.Label26.Text = "Subtotal"
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Location = New System.Drawing.Point(741, 511)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.ReadOnly = True
        Me.TxtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtSubtotal.TabIndex = 76
        Me.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(555, 553)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 13)
        Me.Label23.TabIndex = 75
        Me.Label23.Text = "% Utilidad"
        '
        'TxtUtilidad
        '
        Me.TxtUtilidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUtilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUtilidad.Location = New System.Drawing.Point(614, 550)
        Me.TxtUtilidad.Name = "TxtUtilidad"
        Me.TxtUtilidad.ReadOnly = True
        Me.TxtUtilidad.Size = New System.Drawing.Size(51, 20)
        Me.TxtUtilidad.TabIndex = 74
        Me.TxtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblDisponible
        '
        Me.LblDisponible.AutoSize = True
        Me.LblDisponible.Location = New System.Drawing.Point(194, 553)
        Me.LblDisponible.Name = "LblDisponible"
        Me.LblDisponible.Size = New System.Drawing.Size(13, 13)
        Me.LblDisponible.TabIndex = 73
        Me.LblDisponible.Text = "0"
        '
        'LblExist
        '
        Me.LblExist.AutoSize = True
        Me.LblExist.Location = New System.Drawing.Point(69, 553)
        Me.LblExist.Name = "LblExist"
        Me.LblExist.Size = New System.Drawing.Size(13, 13)
        Me.LblExist.TabIndex = 72
        Me.LblExist.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(133, 553)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 71
        Me.Label22.Text = "Disponible"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 553)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 13)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "Existencia"
        '
        'LblIva
        '
        Me.LblIva.AutoSize = True
        Me.LblIva.Location = New System.Drawing.Point(713, 537)
        Me.LblIva.Name = "LblIva"
        Me.LblIva.Size = New System.Drawing.Size(22, 13)
        Me.LblIva.TabIndex = 69
        Me.LblIva.Text = "Iva"
        '
        'TxtIva
        '
        Me.TxtIva.Location = New System.Drawing.Point(741, 534)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.ReadOnly = True
        Me.TxtIva.Size = New System.Drawing.Size(100, 20)
        Me.TxtIva.TabIndex = 68
        Me.TxtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(704, 559)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 67
        Me.LblTotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(741, 556)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 66
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbAgente
        '
        Me.CmbAgente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAgente.FormattingEnabled = True
        Me.CmbAgente.Location = New System.Drawing.Point(7, 101)
        Me.CmbAgente.Name = "CmbAgente"
        Me.CmbAgente.Size = New System.Drawing.Size(184, 21)
        Me.CmbAgente.TabIndex = 6
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 85)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 13)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "Agente"
        '
        'btnF3
        '
        Me.btnF3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF3.Location = New System.Drawing.Point(110, 13)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(27, 20)
        Me.btnF3.TabIndex = 56
        Me.btnF3.Text = "F3"
        Me.btnF3.UseVisualStyleBackColor = True
        Me.btnF3.Visible = False
        '
        'TxtLugarExpedicion
        '
        Me.TxtLugarExpedicion.Location = New System.Drawing.Point(728, 13)
        Me.TxtLugarExpedicion.Name = "TxtLugarExpedicion"
        Me.TxtLugarExpedicion.Size = New System.Drawing.Size(112, 20)
        Me.TxtLugarExpedicion.TabIndex = 55
        Me.TxtLugarExpedicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(638, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 13)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Lugar Expedicion"
        '
        'CmbMoneda
        '
        Me.CmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMoneda.FormattingEnabled = True
        Me.CmbMoneda.Location = New System.Drawing.Point(732, 57)
        Me.CmbMoneda.Name = "CmbMoneda"
        Me.CmbMoneda.Size = New System.Drawing.Size(107, 21)
        Me.CmbMoneda.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(729, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Moneda"
        '
        'CmbUsoCfdi
        '
        Me.CmbUsoCfdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUsoCfdi.FormattingEnabled = True
        Me.CmbUsoCfdi.Location = New System.Drawing.Point(469, 57)
        Me.CmbUsoCfdi.Name = "CmbUsoCfdi"
        Me.CmbUsoCfdi.Size = New System.Drawing.Size(257, 21)
        Me.CmbUsoCfdi.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(466, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Uso del CFDI"
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Location = New System.Drawing.Point(263, 57)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(200, 21)
        Me.CmbFormaPago.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Forma de Pago"
        '
        'CmbDiasCred
        '
        Me.CmbDiasCred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDiasCred.FormattingEnabled = True
        Me.CmbDiasCred.Location = New System.Drawing.Point(196, 57)
        Me.CmbDiasCred.Name = "CmbDiasCred"
        Me.CmbDiasCred.Size = New System.Drawing.Size(61, 21)
        Me.CmbDiasCred.TabIndex = 2
        '
        'LblDiasCred
        '
        Me.LblDiasCred.AutoSize = True
        Me.LblDiasCred.Location = New System.Drawing.Point(198, 41)
        Me.LblDiasCred.Name = "LblDiasCred"
        Me.LblDiasCred.Size = New System.Drawing.Size(64, 13)
        Me.LblDiasCred.TabIndex = 42
        Me.LblDiasCred.Text = "Dias Credito"
        '
        'CmbMetodoPago
        '
        Me.CmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMetodoPago.FormattingEnabled = True
        Me.CmbMetodoPago.Location = New System.Drawing.Point(6, 57)
        Me.CmbMetodoPago.Name = "CmbMetodoPago"
        Me.CmbMetodoPago.Size = New System.Drawing.Size(184, 21)
        Me.CmbMetodoPago.TabIndex = 1
        '
        'LblMetodoPago
        '
        Me.LblMetodoPago.AutoSize = True
        Me.LblMetodoPago.Location = New System.Drawing.Point(3, 41)
        Me.LblMetodoPago.Name = "LblMetodoPago"
        Me.LblMetodoPago.Size = New System.Drawing.Size(71, 13)
        Me.LblMetodoPago.TabIndex = 40
        Me.LblMetodoPago.Text = "Metodo Pago"
        '
        'DgvFactura
        '
        Me.DgvFactura.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalle, Me.Cantidad, Me.Unidad, Me.Codigo, Me.CodigoSat, Me.Descripcion, Me.Precio, Me.PrecioTotal, Me.DgvIva, Me.Subtotal, Me.Costo, Me.Exist, Me.Disp, Me.Precio2, Me.Precio3, Me.Marca})
        Me.DgvFactura.Location = New System.Drawing.Point(7, 128)
        Me.DgvFactura.Name = "DgvFactura"
        Me.DgvFactura.Size = New System.Drawing.Size(833, 377)
        Me.DgvFactura.StandardTab = True
        Me.DgvFactura.TabIndex = 7
        '
        'IdDetalle
        '
        Me.IdDetalle.HeaderText = "IdDetalle"
        Me.IdDetalle.Name = "IdDetalle"
        Me.IdDetalle.ReadOnly = True
        Me.IdDetalle.Visible = False
        Me.IdDetalle.Width = 40
        '
        'Cantidad
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle9
        Me.Cantidad.HeaderText = "Cant"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 45
        '
        'Unidad
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Unidad.DefaultCellStyle = DataGridViewCellStyle10
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        Me.Unidad.Width = 50
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 80
        '
        'CodigoSat
        '
        Me.CodigoSat.HeaderText = "CodigoSat"
        Me.CodigoSat.Name = "CodigoSat"
        Me.CodigoSat.ReadOnly = True
        Me.CodigoSat.Width = 60
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 255
        '
        'Precio
        '
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle11
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 60
        '
        'PrecioTotal
        '
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.PrecioTotal.DefaultCellStyle = DataGridViewCellStyle12
        Me.PrecioTotal.HeaderText = "PrecioTotal"
        Me.PrecioTotal.Name = "PrecioTotal"
        Me.PrecioTotal.ReadOnly = True
        Me.PrecioTotal.Width = 80
        '
        'DgvIva
        '
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.DgvIva.DefaultCellStyle = DataGridViewCellStyle13
        Me.DgvIva.HeaderText = "Iva"
        Me.DgvIva.Name = "DgvIva"
        Me.DgvIva.ReadOnly = True
        Me.DgvIva.Width = 70
        '
        'Subtotal
        '
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = "0"
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle14
        Me.Subtotal.HeaderText = "Total"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 90
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Visible = False
        '
        'Exist
        '
        Me.Exist.HeaderText = "Exist"
        Me.Exist.Name = "Exist"
        Me.Exist.ReadOnly = True
        Me.Exist.Visible = False
        '
        'Disp
        '
        Me.Disp.HeaderText = "Disp"
        Me.Disp.Name = "Disp"
        Me.Disp.ReadOnly = True
        Me.Disp.Visible = False
        '
        'Precio2
        '
        Me.Precio2.HeaderText = "Precio2"
        Me.Precio2.Name = "Precio2"
        Me.Precio2.Visible = False
        '
        'Precio3
        '
        Me.Precio3.HeaderText = "Precio3"
        Me.Precio3.Name = "Precio3"
        Me.Precio3.Visible = False
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.Visible = False
        '
        'TxtNombreCte
        '
        Me.TxtNombreCte.Location = New System.Drawing.Point(110, 13)
        Me.TxtNombreCte.Name = "TxtNombreCte"
        Me.TxtNombreCte.Size = New System.Drawing.Size(525, 20)
        Me.TxtNombreCte.TabIndex = 0
        '
        'LblCte
        '
        Me.LblCte.AutoSize = True
        Me.LblCte.Location = New System.Drawing.Point(7, 16)
        Me.LblCte.Name = "LblCte"
        Me.LblCte.Size = New System.Drawing.Size(39, 13)
        Me.LblCte.TabIndex = 3
        Me.LblCte.Text = "Cliente"
        '
        'TxtIdCte
        '
        Me.TxtIdCte.Location = New System.Drawing.Point(54, 13)
        Me.TxtIdCte.Name = "TxtIdCte"
        Me.TxtIdCte.Size = New System.Drawing.Size(59, 20)
        Me.TxtIdCte.TabIndex = 0
        Me.TxtIdCte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabCfdi
        '
        Me.TabCfdi.Controls.Add(Me.Label14)
        Me.TabCfdi.Controls.Add(Me.Label13)
        Me.TabCfdi.Controls.Add(Me.TxtCadenaSat)
        Me.TabCfdi.Controls.Add(Me.Label12)
        Me.TabCfdi.Controls.Add(Me.TxtSelloSat)
        Me.TabCfdi.Controls.Add(Me.Label11)
        Me.TabCfdi.Controls.Add(Me.TextBox1)
        Me.TabCfdi.Controls.Add(Me.Label10)
        Me.TabCfdi.Controls.Add(Me.TxtFCertificacion)
        Me.TabCfdi.Controls.Add(Me.Label8)
        Me.TabCfdi.Controls.Add(Me.TxtFolioFiscal)
        Me.TabCfdi.Controls.Add(Me.Label9)
        Me.TabCfdi.Controls.Add(Me.TxtCadenaOriginal)
        Me.TabCfdi.Controls.Add(Me.Label7)
        Me.TabCfdi.Controls.Add(Me.TxtSelloDigital)
        Me.TabCfdi.Controls.Add(Me.Label6)
        Me.TabCfdi.Controls.Add(Me.TxtFechaEmision)
        Me.TabCfdi.Controls.Add(Me.Label5)
        Me.TabCfdi.Controls.Add(Me.TxtNumCertificado)
        Me.TabCfdi.Controls.Add(Me.Label4)
        Me.TabCfdi.Location = New System.Drawing.Point(4, 22)
        Me.TabCfdi.Name = "TabCfdi"
        Me.TabCfdi.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCfdi.Size = New System.Drawing.Size(848, 583)
        Me.TabCfdi.TabIndex = 1
        Me.TabCfdi.Text = "Datos CFDI"
        Me.TabCfdi.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(90, 416)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "PENDIENTE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 416)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "STATUS"
        '
        'TxtCadenaSat
        '
        Me.TxtCadenaSat.Location = New System.Drawing.Point(93, 340)
        Me.TxtCadenaSat.Multiline = True
        Me.TxtCadenaSat.Name = "TxtCadenaSat"
        Me.TxtCadenaSat.Size = New System.Drawing.Size(740, 58)
        Me.TxtCadenaSat.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 343)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Cadena SAT"
        '
        'TxtSelloSat
        '
        Me.TxtSelloSat.Location = New System.Drawing.Point(93, 276)
        Me.TxtSelloSat.Multiline = True
        Me.TxtSelloSat.Name = "TxtSelloSat"
        Me.TxtSelloSat.Size = New System.Drawing.Size(740, 58)
        Me.TxtSelloSat.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 279)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Sello SAT"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(649, 250)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 20)
        Me.TextBox1.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(571, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Num Cer SAT"
        '
        'TxtFCertificacion
        '
        Me.TxtFCertificacion.Location = New System.Drawing.Point(454, 250)
        Me.TxtFCertificacion.Name = "TxtFCertificacion"
        Me.TxtFCertificacion.Size = New System.Drawing.Size(111, 20)
        Me.TxtFCertificacion.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(358, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Fecha Certificacion"
        '
        'TxtFolioFiscal
        '
        Me.TxtFolioFiscal.Location = New System.Drawing.Point(93, 250)
        Me.TxtFolioFiscal.Name = "TxtFolioFiscal"
        Me.TxtFolioFiscal.Size = New System.Drawing.Size(264, 20)
        Me.TxtFolioFiscal.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Folio Fiscal"
        '
        'TxtCadenaOriginal
        '
        Me.TxtCadenaOriginal.Location = New System.Drawing.Point(93, 110)
        Me.TxtCadenaOriginal.Multiline = True
        Me.TxtCadenaOriginal.Name = "TxtCadenaOriginal"
        Me.TxtCadenaOriginal.Size = New System.Drawing.Size(740, 58)
        Me.TxtCadenaOriginal.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cadena Original"
        '
        'TxtSelloDigital
        '
        Me.TxtSelloDigital.Location = New System.Drawing.Point(93, 46)
        Me.TxtSelloDigital.Multiline = True
        Me.TxtSelloDigital.Name = "TxtSelloDigital"
        Me.TxtSelloDigital.Size = New System.Drawing.Size(740, 58)
        Me.TxtSelloDigital.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Sello Digital"
        '
        'TxtFechaEmision
        '
        Me.TxtFechaEmision.Location = New System.Drawing.Point(463, 20)
        Me.TxtFechaEmision.Name = "TxtFechaEmision"
        Me.TxtFechaEmision.Size = New System.Drawing.Size(264, 20)
        Me.TxtFechaEmision.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha Emision"
        '
        'TxtNumCertificado
        '
        Me.TxtNumCertificado.Location = New System.Drawing.Point(93, 20)
        Me.TxtNumCertificado.Name = "TxtNumCertificado"
        Me.TxtNumCertificado.Size = New System.Drawing.Size(264, 20)
        Me.TxtNumCertificado.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Num certificado"
        '
        'TabRelaciones
        '
        Me.TabRelaciones.Controls.Add(Me.BtnEliminaRelacion)
        Me.TabRelaciones.Controls.Add(Me.BtnAgregaRelacion)
        Me.TabRelaciones.Controls.Add(Me.DgvRelacionados)
        Me.TabRelaciones.Controls.Add(Me.Label17)
        Me.TabRelaciones.Controls.Add(Me.TxtUuid)
        Me.TabRelaciones.Controls.Add(Me.CmbTipoRelacion)
        Me.TabRelaciones.Controls.Add(Me.Label16)
        Me.TabRelaciones.Location = New System.Drawing.Point(4, 22)
        Me.TabRelaciones.Name = "TabRelaciones"
        Me.TabRelaciones.Size = New System.Drawing.Size(848, 583)
        Me.TabRelaciones.TabIndex = 2
        Me.TabRelaciones.Text = "Documentos Relacionados"
        Me.TabRelaciones.UseVisualStyleBackColor = True
        '
        'BtnEliminaRelacion
        '
        Me.BtnEliminaRelacion.Location = New System.Drawing.Point(761, 37)
        Me.BtnEliminaRelacion.Name = "BtnEliminaRelacion"
        Me.BtnEliminaRelacion.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminaRelacion.TabIndex = 6
        Me.BtnEliminaRelacion.Text = "Eliminar"
        Me.BtnEliminaRelacion.UseVisualStyleBackColor = True
        '
        'BtnAgregaRelacion
        '
        Me.BtnAgregaRelacion.Location = New System.Drawing.Point(761, 8)
        Me.BtnAgregaRelacion.Name = "BtnAgregaRelacion"
        Me.BtnAgregaRelacion.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregaRelacion.TabIndex = 5
        Me.BtnAgregaRelacion.Text = "Agregar"
        Me.BtnAgregaRelacion.UseVisualStyleBackColor = True
        '
        'DgvRelacionados
        '
        Me.DgvRelacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRelacionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Serie, Me.Folio, Me.UUID, Me.Fecha, Me.Importe})
        Me.DgvRelacionados.Location = New System.Drawing.Point(11, 74)
        Me.DgvRelacionados.Name = "DgvRelacionados"
        Me.DgvRelacionados.Size = New System.Drawing.Size(825, 395)
        Me.DgvRelacionados.TabIndex = 4
        '
        'Serie
        '
        Me.Serie.HeaderText = "Serie"
        Me.Serie.Name = "Serie"
        Me.Serie.ReadOnly = True
        '
        'Folio
        '
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        Me.Folio.ReadOnly = True
        '
        'UUID
        '
        Me.UUID.HeaderText = "UUID"
        Me.UUID.Name = "UUID"
        Me.UUID.ReadOnly = True
        Me.UUID.Width = 300
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(290, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "UUID"
        '
        'TxtUuid
        '
        Me.TxtUuid.Location = New System.Drawing.Point(293, 35)
        Me.TxtUuid.Name = "TxtUuid"
        Me.TxtUuid.Size = New System.Drawing.Size(462, 20)
        Me.TxtUuid.TabIndex = 2
        '
        'CmbTipoRelacion
        '
        Me.CmbTipoRelacion.FormattingEnabled = True
        Me.CmbTipoRelacion.Location = New System.Drawing.Point(11, 35)
        Me.CmbTipoRelacion.Name = "CmbTipoRelacion"
        Me.CmbTipoRelacion.Size = New System.Drawing.Size(275, 21)
        Me.CmbTipoRelacion.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Tipo Relacion"
        '
        'TabAdicional
        '
        Me.TabAdicional.Controls.Add(Me.TxtPedido)
        Me.TabAdicional.Controls.Add(Me.Label19)
        Me.TabAdicional.Controls.Add(Me.TxtOc)
        Me.TabAdicional.Controls.Add(Me.Label15)
        Me.TabAdicional.Controls.Add(Me.TxtComentario)
        Me.TabAdicional.Controls.Add(Me.Label18)
        Me.TabAdicional.Location = New System.Drawing.Point(4, 22)
        Me.TabAdicional.Name = "TabAdicional"
        Me.TabAdicional.Size = New System.Drawing.Size(848, 583)
        Me.TabAdicional.TabIndex = 3
        Me.TabAdicional.Text = "Info Adicional"
        Me.TabAdicional.UseVisualStyleBackColor = True
        '
        'TxtPedido
        '
        Me.TxtPedido.Location = New System.Drawing.Point(87, 48)
        Me.TxtPedido.Name = "TxtPedido"
        Me.TxtPedido.Size = New System.Drawing.Size(136, 20)
        Me.TxtPedido.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Pedido"
        '
        'TxtOc
        '
        Me.TxtOc.Location = New System.Drawing.Point(87, 22)
        Me.TxtOc.Name = "TxtOc"
        Me.TxtOc.Size = New System.Drawing.Size(136, 20)
        Me.TxtOc.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Orden Compra"
        '
        'TxtComentario
        '
        Me.TxtComentario.Location = New System.Drawing.Point(87, 338)
        Me.TxtComentario.Multiline = True
        Me.TxtComentario.Name = "TxtComentario"
        Me.TxtComentario.Size = New System.Drawing.Size(749, 159)
        Me.TxtComentario.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(20, 338)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Comentario"
        '
        'TabFirmas
        '
        Me.TabFirmas.Controls.Add(Me.LblAgenteFirma)
        Me.TabFirmas.Controls.Add(Me.LblcomentAgente)
        Me.TabFirmas.Controls.Add(Me.LblComentCxc)
        Me.TabFirmas.Controls.Add(Me.LblComenVta)
        Me.TabFirmas.Controls.Add(Me.LblFirmaVtas)
        Me.TabFirmas.Controls.Add(Me.LblFirmaCxc)
        Me.TabFirmas.Controls.Add(Me.Label27)
        Me.TabFirmas.Controls.Add(Me.Label28)
        Me.TabFirmas.Controls.Add(Me.Label29)
        Me.TabFirmas.Controls.Add(Me.Label30)
        Me.TabFirmas.Controls.Add(Me.Label32)
        Me.TabFirmas.Controls.Add(Me.BtnFirma)
        Me.TabFirmas.Controls.Add(Me.Label33)
        Me.TabFirmas.Controls.Add(Me.TxtObservaciones)
        Me.TabFirmas.Controls.Add(Me.Label34)
        Me.TabFirmas.Controls.Add(Me.Label35)
        Me.TabFirmas.Controls.Add(Me.TxtUltimoMov)
        Me.TabFirmas.Controls.Add(Me.TxtFechaAlta)
        Me.TabFirmas.Controls.Add(Me.Label36)
        Me.TabFirmas.Controls.Add(Me.TxtOrdComFirma)
        Me.TabFirmas.Controls.Add(Me.Label37)
        Me.TabFirmas.Controls.Add(Me.TxtDiasCredFirma)
        Me.TabFirmas.Controls.Add(Me.TxtMetoPagoFirma)
        Me.TabFirmas.Controls.Add(Me.TxtLimCredFirma)
        Me.TabFirmas.Controls.Add(Me.TxtTipoCliente)
        Me.TabFirmas.Controls.Add(Me.TxtSaldoFirma)
        Me.TabFirmas.Controls.Add(Me.Label38)
        Me.TabFirmas.Controls.Add(Me.Label39)
        Me.TabFirmas.Controls.Add(Me.Label40)
        Me.TabFirmas.Controls.Add(Me.Label41)
        Me.TabFirmas.Controls.Add(Me.Label42)
        Me.TabFirmas.Controls.Add(Me.Label43)
        Me.TabFirmas.Controls.Add(Me.TxtUtilFirma)
        Me.TabFirmas.Controls.Add(Me.TxtTotalFirma)
        Me.TabFirmas.Controls.Add(Me.TxtAgenteFirma)
        Me.TabFirmas.Controls.Add(Me.Label44)
        Me.TabFirmas.Controls.Add(Me.LblCliente)
        Me.TabFirmas.Controls.Add(Me.TxtClienteFirma)
        Me.TabFirmas.Location = New System.Drawing.Point(4, 22)
        Me.TabFirmas.Name = "TabFirmas"
        Me.TabFirmas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFirmas.Size = New System.Drawing.Size(848, 583)
        Me.TabFirmas.TabIndex = 5
        Me.TabFirmas.Text = "Firmas"
        Me.TabFirmas.UseVisualStyleBackColor = True
        '
        'LblAgenteFirma
        '
        Me.LblAgenteFirma.AutoSize = True
        Me.LblAgenteFirma.Location = New System.Drawing.Point(24, 382)
        Me.LblAgenteFirma.Name = "LblAgenteFirma"
        Me.LblAgenteFirma.Size = New System.Drawing.Size(40, 17)
        Me.LblAgenteFirma.TabIndex = 45
        Me.LblAgenteFirma.Text = "Agente"
        Me.LblAgenteFirma.UseCompatibleTextRendering = True
        '
        'LblcomentAgente
        '
        Me.LblcomentAgente.AutoSize = True
        Me.LblcomentAgente.Location = New System.Drawing.Point(256, 382)
        Me.LblcomentAgente.Name = "LblcomentAgente"
        Me.LblcomentAgente.Size = New System.Drawing.Size(74, 13)
        Me.LblcomentAgente.TabIndex = 44
        Me.LblcomentAgente.Text = "ComenAgente"
        Me.LblcomentAgente.Visible = False
        '
        'LblComentCxc
        '
        Me.LblComentCxc.AutoSize = True
        Me.LblComentCxc.Location = New System.Drawing.Point(256, 451)
        Me.LblComentCxc.Name = "LblComentCxc"
        Me.LblComentCxc.Size = New System.Drawing.Size(58, 13)
        Me.LblComentCxc.TabIndex = 42
        Me.LblComentCxc.Text = "ComenCxc"
        Me.LblComentCxc.Visible = False
        '
        'LblComenVta
        '
        Me.LblComenVta.AutoSize = True
        Me.LblComenVta.Location = New System.Drawing.Point(256, 416)
        Me.LblComenVta.Name = "LblComenVta"
        Me.LblComenVta.Size = New System.Drawing.Size(56, 13)
        Me.LblComenVta.TabIndex = 41
        Me.LblComenVta.Text = "ComenVta"
        Me.LblComenVta.Visible = False
        '
        'LblFirmaVtas
        '
        Me.LblFirmaVtas.AutoSize = True
        Me.LblFirmaVtas.Location = New System.Drawing.Point(166, 416)
        Me.LblFirmaVtas.Name = "LblFirmaVtas"
        Me.LblFirmaVtas.Size = New System.Drawing.Size(45, 13)
        Me.LblFirmaVtas.TabIndex = 40
        Me.LblFirmaVtas.Text = "firmaVta"
        Me.LblFirmaVtas.Visible = False
        '
        'LblFirmaCxc
        '
        Me.LblFirmaCxc.AutoSize = True
        Me.LblFirmaCxc.Location = New System.Drawing.Point(167, 451)
        Me.LblFirmaCxc.Name = "LblFirmaCxc"
        Me.LblFirmaCxc.Size = New System.Drawing.Size(50, 13)
        Me.LblFirmaCxc.TabIndex = 39
        Me.LblFirmaCxc.Text = "FirmaCxc"
        Me.LblFirmaCxc.Visible = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(256, 350)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 13)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "Comentario"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(172, 350)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(32, 13)
        Me.Label28.TabIndex = 36
        Me.Label28.Text = "Firma"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(26, 416)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 13)
        Me.Label29.TabIndex = 35
        Me.Label29.Text = "Ventas"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(26, 451)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(88, 13)
        Me.Label30.TabIndex = 34
        Me.Label30.Text = "Cuentas x Cobrar"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(26, 350)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(74, 13)
        Me.Label32.TabIndex = 32
        Me.Label32.Text = "Departamento"
        '
        'BtnFirma
        '
        Me.BtnFirma.Location = New System.Drawing.Point(19, 12)
        Me.BtnFirma.Name = "BtnFirma"
        Me.BtnFirma.Size = New System.Drawing.Size(75, 36)
        Me.BtnFirma.TabIndex = 31
        Me.BtnFirma.Text = "Firma"
        Me.BtnFirma.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(26, 247)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(78, 13)
        Me.Label33.TabIndex = 29
        Me.Label33.Text = "Observaciones"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(24, 264)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ReadOnly = True
        Me.TxtObservaciones.Size = New System.Drawing.Size(775, 37)
        Me.TxtObservaciones.TabIndex = 28
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(342, 199)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(58, 13)
        Me.Label34.TabIndex = 26
        Me.Label34.Text = "Fecha Alta"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(502, 199)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(60, 13)
        Me.Label35.TabIndex = 25
        Me.Label35.Text = "Ultimo Mov"
        '
        'TxtUltimoMov
        '
        Me.TxtUltimoMov.Location = New System.Drawing.Point(503, 214)
        Me.TxtUltimoMov.Name = "TxtUltimoMov"
        Me.TxtUltimoMov.ReadOnly = True
        Me.TxtUltimoMov.Size = New System.Drawing.Size(145, 20)
        Me.TxtUltimoMov.TabIndex = 24
        Me.TxtUltimoMov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtFechaAlta
        '
        Me.TxtFechaAlta.Location = New System.Drawing.Point(343, 214)
        Me.TxtFechaAlta.Name = "TxtFechaAlta"
        Me.TxtFechaAlta.ReadOnly = True
        Me.TxtFechaAlta.Size = New System.Drawing.Size(145, 20)
        Me.TxtFechaAlta.TabIndex = 23
        Me.TxtFechaAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(462, 141)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(63, 13)
        Me.Label36.TabIndex = 22
        Me.Label36.Text = "Tipo Cliente"
        '
        'TxtOrdComFirma
        '
        Me.TxtOrdComFirma.Location = New System.Drawing.Point(306, 156)
        Me.TxtOrdComFirma.Name = "TxtOrdComFirma"
        Me.TxtOrdComFirma.ReadOnly = True
        Me.TxtOrdComFirma.Size = New System.Drawing.Size(145, 20)
        Me.TxtOrdComFirma.TabIndex = 21
        Me.TxtOrdComFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(183, 198)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(34, 13)
        Me.Label37.TabIndex = 20
        Me.Label37.Text = "Saldo"
        '
        'TxtDiasCredFirma
        '
        Me.TxtDiasCredFirma.Location = New System.Drawing.Point(24, 156)
        Me.TxtDiasCredFirma.Name = "TxtDiasCredFirma"
        Me.TxtDiasCredFirma.ReadOnly = True
        Me.TxtDiasCredFirma.Size = New System.Drawing.Size(74, 20)
        Me.TxtDiasCredFirma.TabIndex = 19
        Me.TxtDiasCredFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtMetoPagoFirma
        '
        Me.TxtMetoPagoFirma.Location = New System.Drawing.Point(107, 156)
        Me.TxtMetoPagoFirma.Name = "TxtMetoPagoFirma"
        Me.TxtMetoPagoFirma.ReadOnly = True
        Me.TxtMetoPagoFirma.Size = New System.Drawing.Size(183, 20)
        Me.TxtMetoPagoFirma.TabIndex = 18
        Me.TxtMetoPagoFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLimCredFirma
        '
        Me.TxtLimCredFirma.Location = New System.Drawing.Point(24, 214)
        Me.TxtLimCredFirma.Name = "TxtLimCredFirma"
        Me.TxtLimCredFirma.ReadOnly = True
        Me.TxtLimCredFirma.Size = New System.Drawing.Size(145, 20)
        Me.TxtLimCredFirma.TabIndex = 17
        Me.TxtLimCredFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTipoCliente
        '
        Me.TxtTipoCliente.Location = New System.Drawing.Point(465, 157)
        Me.TxtTipoCliente.Name = "TxtTipoCliente"
        Me.TxtTipoCliente.ReadOnly = True
        Me.TxtTipoCliente.Size = New System.Drawing.Size(183, 20)
        Me.TxtTipoCliente.TabIndex = 16
        Me.TxtTipoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSaldoFirma
        '
        Me.TxtSaldoFirma.Location = New System.Drawing.Point(184, 214)
        Me.TxtSaldoFirma.Name = "TxtSaldoFirma"
        Me.TxtSaldoFirma.ReadOnly = True
        Me.TxtSaldoFirma.Size = New System.Drawing.Size(145, 20)
        Me.TxtSaldoFirma.TabIndex = 15
        Me.TxtSaldoFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(21, 140)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(64, 13)
        Me.Label38.TabIndex = 14
        Me.Label38.Text = "Dias Credito"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(110, 140)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(71, 13)
        Me.Label39.TabIndex = 13
        Me.Label39.Text = "Metodo Pago"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(24, 198)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(70, 13)
        Me.Label40.TabIndex = 12
        Me.Label40.Text = "Limite Credito"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(306, 140)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(75, 13)
        Me.Label41.TabIndex = 11
        Me.Label41.Text = "Orden Compra"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(713, 12)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(31, 13)
        Me.Label42.TabIndex = 10
        Me.Label42.Text = "Total"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(616, 12)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(53, 13)
        Me.Label43.TabIndex = 9
        Me.Label43.Text = "Utilidad %"
        '
        'TxtUtilFirma
        '
        Me.TxtUtilFirma.Location = New System.Drawing.Point(617, 28)
        Me.TxtUtilFirma.Name = "TxtUtilFirma"
        Me.TxtUtilFirma.ReadOnly = True
        Me.TxtUtilFirma.Size = New System.Drawing.Size(88, 20)
        Me.TxtUtilFirma.TabIndex = 8
        Me.TxtUtilFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTotalFirma
        '
        Me.TxtTotalFirma.Location = New System.Drawing.Point(711, 28)
        Me.TxtTotalFirma.Name = "TxtTotalFirma"
        Me.TxtTotalFirma.ReadOnly = True
        Me.TxtTotalFirma.Size = New System.Drawing.Size(88, 20)
        Me.TxtTotalFirma.TabIndex = 7
        Me.TxtTotalFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtAgenteFirma
        '
        Me.TxtAgenteFirma.Location = New System.Drawing.Point(371, 83)
        Me.TxtAgenteFirma.Name = "TxtAgenteFirma"
        Me.TxtAgenteFirma.ReadOnly = True
        Me.TxtAgenteFirma.Size = New System.Drawing.Size(177, 20)
        Me.TxtAgenteFirma.TabIndex = 6
        Me.TxtAgenteFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(368, 67)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(41, 13)
        Me.Label44.TabIndex = 5
        Me.Label44.Text = "Agente"
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(21, 67)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(39, 13)
        Me.LblCliente.TabIndex = 4
        Me.LblCliente.Text = "Cliente"
        '
        'TxtClienteFirma
        '
        Me.TxtClienteFirma.Location = New System.Drawing.Point(24, 83)
        Me.TxtClienteFirma.Name = "TxtClienteFirma"
        Me.TxtClienteFirma.ReadOnly = True
        Me.TxtClienteFirma.Size = New System.Drawing.Size(341, 20)
        Me.TxtClienteFirma.TabIndex = 2
        Me.TxtClienteFirma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(755, 8)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(43, 13)
        Me.lblFolio.TabIndex = 50
        Me.lblFolio.Text = "Factura"
        '
        'TxtFolio
        '
        Me.TxtFolio.Location = New System.Drawing.Point(758, 24)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(100, 20)
        Me.TxtFolio.TabIndex = 51
        Me.TxtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnTimbrar
        '
        Me.BtnTimbrar.Location = New System.Drawing.Point(141, 8)
        Me.BtnTimbrar.Name = "BtnTimbrar"
        Me.BtnTimbrar.Size = New System.Drawing.Size(57, 30)
        Me.BtnTimbrar.TabIndex = 52
        Me.BtnTimbrar.Text = "Timbrar"
        Me.BtnTimbrar.UseVisualStyleBackColor = True
        '
        'BtnCancelarCfdi
        '
        Me.BtnCancelarCfdi.Location = New System.Drawing.Point(199, 8)
        Me.BtnCancelarCfdi.Name = "BtnCancelarCfdi"
        Me.BtnCancelarCfdi.Size = New System.Drawing.Size(84, 30)
        Me.BtnCancelarCfdi.TabIndex = 53
        Me.BtnCancelarCfdi.Text = "Cancelar CFDI"
        Me.BtnCancelarCfdi.UseVisualStyleBackColor = True
        '
        'BtnPdf
        '
        Me.BtnPdf.Location = New System.Drawing.Point(283, 8)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.Size = New System.Drawing.Size(84, 30)
        Me.BtnPdf.TabIndex = 54
        Me.BtnPdf.Text = "Mostrar PDF"
        Me.BtnPdf.UseVisualStyleBackColor = True
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(669, 24)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(69, 20)
        Me.TxtFecha.TabIndex = 62
        Me.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(666, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 13)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "Fecha"
        '
        'BttEnviar
        '
        Me.BttEnviar.Location = New System.Drawing.Point(457, 8)
        Me.BttEnviar.Name = "BttEnviar"
        Me.BttEnviar.Size = New System.Drawing.Size(69, 30)
        Me.BttEnviar.TabIndex = 63
        Me.BttEnviar.Text = "Enviar"
        Me.BttEnviar.UseVisualStyleBackColor = True
        '
        'FrmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 656)
        Me.Controls.Add(Me.BttEnviar)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.BtnPdf)
        Me.Controls.Add(Me.BtnCancelarCfdi)
        Me.Controls.Add(Me.BtnTimbrar)
        Me.Controls.Add(Me.TxtFolio)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.TabFactura)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.MaximizeBox = False
        Me.Name = "FrmFactura"
        Me.Text = "Factura"
        Me.TabFactura.ResumeLayout(False)
        Me.TabPrincipal.ResumeLayout(False)
        Me.TabPrincipal.PerformLayout()
        CType(Me.DgvFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCfdi.ResumeLayout(False)
        Me.TabCfdi.PerformLayout()
        Me.TabRelaciones.ResumeLayout(False)
        Me.TabRelaciones.PerformLayout()
        CType(Me.DgvRelacionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAdicional.ResumeLayout(False)
        Me.TabAdicional.PerformLayout()
        Me.TabFirmas.ResumeLayout(False)
        Me.TabFirmas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Windows.Forms.Button
    Friend WithEvents BtnCancelar As Windows.Forms.Button
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents TabFactura As Windows.Forms.TabControl
    Friend WithEvents TabPrincipal As Windows.Forms.TabPage
    Friend WithEvents TabCfdi As Windows.Forms.TabPage
    Friend WithEvents TxtNombreCte As Windows.Forms.TextBox
    Friend WithEvents LblCte As Windows.Forms.Label
    Friend WithEvents TxtIdCte As Windows.Forms.TextBox
    Friend WithEvents lblFolio As Windows.Forms.Label
    Friend WithEvents TxtFolio As Windows.Forms.TextBox
    Friend WithEvents DgvFactura As Windows.Forms.DataGridView
    Friend WithEvents CmbDiasCred As Windows.Forms.ComboBox
    Friend WithEvents LblDiasCred As Windows.Forms.Label
    Friend WithEvents CmbMetodoPago As Windows.Forms.ComboBox
    Friend WithEvents LblMetodoPago As Windows.Forms.Label
    Friend WithEvents CmbUsoCfdi As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents CmbFormaPago As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents BtnTimbrar As Windows.Forms.Button
    Friend WithEvents BtnCancelarCfdi As Windows.Forms.Button
    Friend WithEvents BtnPdf As Windows.Forms.Button
    Friend WithEvents CmbMoneda As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtNumCertificado As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents TabRelaciones As Windows.Forms.TabPage
    Friend WithEvents TabAdicional As Windows.Forms.TabPage
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents TxtFCertificacion As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents TxtFolioFiscal As Windows.Forms.TextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TxtCadenaOriginal As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TxtSelloDigital As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents TxtFechaEmision As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents TxtCadenaSat As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents TxtSelloSat As Windows.Forms.TextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents TxtLugarExpedicion As Windows.Forms.TextBox
    Friend WithEvents Label20 As Windows.Forms.Label
    Friend WithEvents BtnEliminaRelacion As Windows.Forms.Button
    Friend WithEvents BtnAgregaRelacion As Windows.Forms.Button
    Friend WithEvents DgvRelacionados As Windows.Forms.DataGridView
    Friend WithEvents Serie As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Folio As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UUID As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents TxtUuid As Windows.Forms.TextBox
    Friend WithEvents CmbTipoRelacion As Windows.Forms.ComboBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents TxtPedido As Windows.Forms.TextBox
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents TxtOc As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents TxtComentario As Windows.Forms.TextBox
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents btnF3 As Windows.Forms.Button
    Friend WithEvents TxtFecha As Windows.Forms.TextBox
    Friend WithEvents Label24 As Windows.Forms.Label
    Friend WithEvents CmbAgente As Windows.Forms.ComboBox
    Friend WithEvents Label25 As Windows.Forms.Label
    Friend WithEvents Label26 As Windows.Forms.Label
    Friend WithEvents TxtSubtotal As Windows.Forms.TextBox
    Friend WithEvents Label23 As Windows.Forms.Label
    Friend WithEvents TxtUtilidad As Windows.Forms.TextBox
    Friend WithEvents LblDisponible As Windows.Forms.Label
    Friend WithEvents LblExist As Windows.Forms.Label
    Friend WithEvents Label22 As Windows.Forms.Label
    Friend WithEvents Label21 As Windows.Forms.Label
    Friend WithEvents LblIva As Windows.Forms.Label
    Friend WithEvents TxtIva As Windows.Forms.TextBox
    Friend WithEvents LblTotal As Windows.Forms.Label
    Friend WithEvents txtTotal As Windows.Forms.TextBox
    Friend WithEvents LblLetras As Windows.Forms.Label
    Friend WithEvents IdDetalle As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoSat As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgvIva As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Exist As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Disp As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BttEnviar As Windows.Forms.Button
    Friend WithEvents Precio2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabFirmas As Windows.Forms.TabPage
    Friend WithEvents LblAgenteFirma As Windows.Forms.Label
    Friend WithEvents LblcomentAgente As Windows.Forms.Label
    Friend WithEvents LblComentCxc As Windows.Forms.Label
    Friend WithEvents LblComenVta As Windows.Forms.Label
    Friend WithEvents LblFirmaVtas As Windows.Forms.Label
    Friend WithEvents LblFirmaCxc As Windows.Forms.Label
    Friend WithEvents Label27 As Windows.Forms.Label
    Friend WithEvents Label28 As Windows.Forms.Label
    Friend WithEvents Label29 As Windows.Forms.Label
    Friend WithEvents Label30 As Windows.Forms.Label
    Friend WithEvents Label32 As Windows.Forms.Label
    Friend WithEvents BtnFirma As Windows.Forms.Button
    Friend WithEvents Label33 As Windows.Forms.Label
    Friend WithEvents TxtObservaciones As Windows.Forms.TextBox
    Friend WithEvents Label34 As Windows.Forms.Label
    Friend WithEvents Label35 As Windows.Forms.Label
    Friend WithEvents TxtUltimoMov As Windows.Forms.TextBox
    Friend WithEvents TxtFechaAlta As Windows.Forms.TextBox
    Friend WithEvents Label36 As Windows.Forms.Label
    Friend WithEvents TxtOrdComFirma As Windows.Forms.TextBox
    Friend WithEvents Label37 As Windows.Forms.Label
    Friend WithEvents TxtDiasCredFirma As Windows.Forms.TextBox
    Friend WithEvents TxtMetoPagoFirma As Windows.Forms.TextBox
    Friend WithEvents TxtLimCredFirma As Windows.Forms.TextBox
    Friend WithEvents TxtTipoCliente As Windows.Forms.TextBox
    Friend WithEvents TxtSaldoFirma As Windows.Forms.TextBox
    Friend WithEvents Label38 As Windows.Forms.Label
    Friend WithEvents Label39 As Windows.Forms.Label
    Friend WithEvents Label40 As Windows.Forms.Label
    Friend WithEvents Label41 As Windows.Forms.Label
    Friend WithEvents Label42 As Windows.Forms.Label
    Friend WithEvents Label43 As Windows.Forms.Label
    Friend WithEvents TxtUtilFirma As Windows.Forms.TextBox
    Friend WithEvents TxtTotalFirma As Windows.Forms.TextBox
    Friend WithEvents TxtAgenteFirma As Windows.Forms.TextBox
    Friend WithEvents Label44 As Windows.Forms.Label
    Friend WithEvents LblCliente As Windows.Forms.Label
    Friend WithEvents TxtClienteFirma As Windows.Forms.TextBox
End Class
