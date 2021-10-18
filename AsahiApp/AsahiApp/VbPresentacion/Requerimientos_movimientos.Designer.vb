<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Requerimientos_movimientos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requerimientos_movimientos))
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_proveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_producto = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_fecharecep = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_impuestos = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_retenciones = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_descuento = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_comen = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_oc = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_comprador = New System.Windows.Forms.Label()
        Me.btn_solicitar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbx_area = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_nparte = New System.Windows.Forms.Label()
        Me.btn_desma = New System.Windows.Forms.Button()
        Me.btn_selec = New System.Windows.Forms.Button()
        Me.dtp_fecharecep = New System.Windows.Forms.DateTimePicker()
        Me.lbl_moneda = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_autoriza = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btn_pdf = New System.Windows.Forms.Button()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToOrderColumns = True
        Me.dtgvp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgvp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgvp.Location = New System.Drawing.Point(12, 12)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(524, 508)
        Me.dtgvp.TabIndex = 268
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(542, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 269
        Me.Label2.Text = "Proveedor"
        '
        'txt_proveedor
        '
        Me.txt_proveedor.BackColor = System.Drawing.SystemColors.Control
        Me.txt_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_proveedor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_proveedor.Location = New System.Drawing.Point(545, 292)
        Me.txt_proveedor.MaxLength = 99
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Size = New System.Drawing.Size(477, 20)
        Me.txt_proveedor.TabIndex = 270
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(542, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 271
        Me.Label1.Text = "Producto"
        '
        'lbl_producto
        '
        Me.lbl_producto.AutoSize = True
        Me.lbl_producto.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_producto.ForeColor = System.Drawing.Color.Black
        Me.lbl_producto.Location = New System.Drawing.Point(543, 132)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(50, 13)
        Me.lbl_producto.TabIndex = 272
        Me.lbl_producto.Text = "Producto"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.BackColor = System.Drawing.SystemColors.Control
        Me.txt_cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cantidad.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_cantidad.Location = New System.Drawing.Point(545, 338)
        Me.txt_cantidad.MaxLength = 99
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(79, 20)
        Me.txt_cantidad.TabIndex = 273
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(553, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 274
        Me.Label3.Text = "Cantidad"
        '
        'txt_precio
        '
        Me.txt_precio.BackColor = System.Drawing.SystemColors.Control
        Me.txt_precio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_precio.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_precio.Location = New System.Drawing.Point(647, 338)
        Me.txt_precio.MaxLength = 99
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(75, 20)
        Me.txt_precio.TabIndex = 275
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(639, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 276
        Me.Label4.Text = "Precio Unitario"
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(756, 338)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 277
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(761, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 278
        Me.Label5.Text = "Fecha Solicitud"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(891, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "Fecha de recepción"
        '
        'lbl_fecharecep
        '
        Me.lbl_fecharecep.AutoSize = True
        Me.lbl_fecharecep.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_fecharecep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecharecep.ForeColor = System.Drawing.Color.Black
        Me.lbl_fecharecep.Location = New System.Drawing.Point(900, 341)
        Me.lbl_fecharecep.Name = "lbl_fecharecep"
        Me.lbl_fecharecep.Size = New System.Drawing.Size(102, 13)
        Me.lbl_fecharecep.TabIndex = 280
        Me.lbl_fecharecep.Text = "Fecha de recepción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(542, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 281
        Me.Label7.Text = "Moneda"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(540, 474)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 283
        Me.Label8.Text = "Subtotal"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_subtotal.Location = New System.Drawing.Point(542, 493)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(46, 13)
        Me.lbl_subtotal.TabIndex = 284
        Me.lbl_subtotal.Text = "Subtotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(652, 474)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 285
        Me.Label9.Text = "Impuestos"
        '
        'lbl_impuestos
        '
        Me.lbl_impuestos.AutoSize = True
        Me.lbl_impuestos.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_impuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_impuestos.ForeColor = System.Drawing.Color.Black
        Me.lbl_impuestos.Location = New System.Drawing.Point(654, 493)
        Me.lbl_impuestos.Name = "lbl_impuestos"
        Me.lbl_impuestos.Size = New System.Drawing.Size(55, 13)
        Me.lbl_impuestos.TabIndex = 286
        Me.lbl_impuestos.Text = "Impuestos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(791, 474)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 287
        Me.Label10.Text = "Retenciones"
        '
        'lbl_retenciones
        '
        Me.lbl_retenciones.AutoSize = True
        Me.lbl_retenciones.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_retenciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_retenciones.ForeColor = System.Drawing.Color.Black
        Me.lbl_retenciones.Location = New System.Drawing.Point(793, 493)
        Me.lbl_retenciones.Name = "lbl_retenciones"
        Me.lbl_retenciones.Size = New System.Drawing.Size(67, 13)
        Me.lbl_retenciones.TabIndex = 288
        Me.lbl_retenciones.Text = "Retenciones"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(926, 474)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 289
        Me.Label11.Text = "Descuentos"
        '
        'lbl_descuento
        '
        Me.lbl_descuento.AutoSize = True
        Me.lbl_descuento.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descuento.ForeColor = System.Drawing.Color.Black
        Me.lbl_descuento.Location = New System.Drawing.Point(928, 493)
        Me.lbl_descuento.Name = "lbl_descuento"
        Me.lbl_descuento.Size = New System.Drawing.Size(64, 13)
        Me.lbl_descuento.TabIndex = 290
        Me.lbl_descuento.Text = "Descuentos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(654, 515)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 16)
        Me.Label13.TabIndex = 291
        Me.Label13.Text = "Total"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(721, 515)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(39, 16)
        Me.lbl_total.TabIndex = 292
        Me.lbl_total.Text = "Total"
        '
        'txt_comen
        '
        Me.txt_comen.BackColor = System.Drawing.SystemColors.Control
        Me.txt_comen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_comen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_comen.Location = New System.Drawing.Point(618, 409)
        Me.txt_comen.MaxLength = 99
        Me.txt_comen.Multiline = True
        Me.txt_comen.Name = "txt_comen"
        Me.txt_comen.Size = New System.Drawing.Size(404, 57)
        Me.txt_comen.TabIndex = 294
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(776, 388)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 293
        Me.Label15.Text = "Comentarios"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(575, 539)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 16)
        Me.Label16.TabIndex = 295
        Me.Label16.Text = "Orden de compra"
        '
        'lbl_oc
        '
        Me.lbl_oc.AutoSize = True
        Me.lbl_oc.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_oc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_oc.ForeColor = System.Drawing.Color.Black
        Me.lbl_oc.Location = New System.Drawing.Point(723, 539)
        Me.lbl_oc.Name = "lbl_oc"
        Me.lbl_oc.Size = New System.Drawing.Size(113, 16)
        Me.lbl_oc.TabIndex = 296
        Me.lbl_oc.Text = "Orden de compra"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(542, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 13)
        Me.Label17.TabIndex = 297
        Me.Label17.Text = "Comprador"
        '
        'lbl_comprador
        '
        Me.lbl_comprador.AutoSize = True
        Me.lbl_comprador.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_comprador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_comprador.ForeColor = System.Drawing.Color.Black
        Me.lbl_comprador.Location = New System.Drawing.Point(543, 97)
        Me.lbl_comprador.Name = "lbl_comprador"
        Me.lbl_comprador.Size = New System.Drawing.Size(58, 13)
        Me.lbl_comprador.TabIndex = 298
        Me.lbl_comprador.Text = "Comprador"
        '
        'btn_solicitar
        '
        Me.btn_solicitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_solicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_solicitar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_solicitar.Location = New System.Drawing.Point(556, 578)
        Me.btn_solicitar.Name = "btn_solicitar"
        Me.btn_solicitar.Size = New System.Drawing.Size(120, 35)
        Me.btn_solicitar.TabIndex = 427
        Me.btn_solicitar.Text = "Guardar"
        Me.btn_solicitar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_eliminar.Location = New System.Drawing.Point(902, 578)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(120, 35)
        Me.btn_eliminar.TabIndex = 428
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(545, 226)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 430
        Me.Label18.Text = "Área"
        '
        'cbx_area
        '
        Me.cbx_area.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_area.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_area.FormattingEnabled = True
        Me.cbx_area.Items.AddRange(New Object() {"ASEGURAMIENTO DE CALIDAD F1", "ASUNTOS GENERALES", "ATENCIÓN AL CLIENTE", "COMPRAS", "CONTABILIDAD", "CONTROL DE MANUFACTURA", "CONTROL DE PRODUCCION", "MOLDES", "SEGURIDAD", "SISTEMAS IT", "INGENIERÍA MAQUINADO", "INGENIERÍA FUNDICIÓN", "INSPECCION PRODUCCION", "FUNDICION 1", "FUNDICION 2", "ACABADO", "ACABADO 2", "CONTROL DE CLIENTES", "MANTENIMIENTO DE PLANTA", "MANTENIMIENTO FUNDICION", "MANTENIMIENTO MAQUINADO", "MAQUINADO F2", "INSPECCIÓN FUNDICION", "INSPECCIÓN MAQUINADO", "MAQUINADO F1", "FUSION", "ASEGURAMIENTO DE CALIDAD F2", "REPARACION DE MOLDES", "PRODUCCIÓN"})
        Me.cbx_area.Location = New System.Drawing.Point(546, 246)
        Me.cbx_area.Name = "cbx_area"
        Me.cbx_area.Size = New System.Drawing.Size(306, 21)
        Me.cbx_area.TabIndex = 429
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(542, 150)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 13)
        Me.Label19.TabIndex = 433
        Me.Label19.Text = "Código"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.ForeColor = System.Drawing.Color.Black
        Me.lbl_codigo.Location = New System.Drawing.Point(543, 167)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(40, 13)
        Me.lbl_codigo.TabIndex = 434
        Me.lbl_codigo.Text = "Código"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(542, 184)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 13)
        Me.Label21.TabIndex = 431
        Me.Label21.Text = "Número de parte"
        '
        'lbl_nparte
        '
        Me.lbl_nparte.AutoSize = True
        Me.lbl_nparte.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_nparte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nparte.ForeColor = System.Drawing.Color.Black
        Me.lbl_nparte.Location = New System.Drawing.Point(543, 202)
        Me.lbl_nparte.Name = "lbl_nparte"
        Me.lbl_nparte.Size = New System.Drawing.Size(86, 13)
        Me.lbl_nparte.TabIndex = 432
        Me.lbl_nparte.Text = "Número de parte"
        '
        'btn_desma
        '
        Me.btn_desma.ForeColor = System.Drawing.Color.Black
        Me.btn_desma.Location = New System.Drawing.Point(193, 547)
        Me.btn_desma.Name = "btn_desma"
        Me.btn_desma.Size = New System.Drawing.Size(78, 35)
        Me.btn_desma.TabIndex = 437
        Me.btn_desma.Text = "Desmarcar"
        Me.btn_desma.UseVisualStyleBackColor = False
        Me.btn_desma.Visible = False
        '
        'btn_selec
        '
        Me.btn_selec.ForeColor = System.Drawing.Color.Black
        Me.btn_selec.Location = New System.Drawing.Point(85, 546)
        Me.btn_selec.Name = "btn_selec"
        Me.btn_selec.Size = New System.Drawing.Size(74, 35)
        Me.btn_selec.TabIndex = 436
        Me.btn_selec.Text = "Seleccionar"
        Me.btn_selec.UseVisualStyleBackColor = False
        Me.btn_selec.Visible = False
        '
        'dtp_fecharecep
        '
        Me.dtp_fecharecep.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecharecep.Location = New System.Drawing.Point(901, 360)
        Me.dtp_fecharecep.Name = "dtp_fecharecep"
        Me.dtp_fecharecep.Size = New System.Drawing.Size(100, 20)
        Me.dtp_fecharecep.TabIndex = 438
        '
        'lbl_moneda
        '
        Me.lbl_moneda.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lbl_moneda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_moneda.FormattingEnabled = True
        Me.lbl_moneda.Items.AddRange(New Object() {"N/A", "MEX", "USD", "YEN"})
        Me.lbl_moneda.Location = New System.Drawing.Point(541, 409)
        Me.lbl_moneda.Name = "lbl_moneda"
        Me.lbl_moneda.Size = New System.Drawing.Size(64, 21)
        Me.lbl_moneda.TabIndex = 439
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.Location = New System.Drawing.Point(552, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(32, 13)
        Me.Panel4.TabIndex = 443
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(552, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(32, 13)
        Me.Panel3.TabIndex = 442
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(585, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 9)
        Me.Label12.TabIndex = 441
        Me.Label12.Text = "COTIZADO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(585, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 9)
        Me.Label14.TabIndex = 440
        Me.Label14.Text = "CREADO"
        '
        'btn_autoriza
        '
        Me.btn_autoriza.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_autoriza.Enabled = False
        Me.btn_autoriza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_autoriza.ForeColor = System.Drawing.Color.Green
        Me.btn_autoriza.Location = New System.Drawing.Point(111, 588)
        Me.btn_autoriza.Name = "btn_autoriza"
        Me.btn_autoriza.Size = New System.Drawing.Size(120, 35)
        Me.btn_autoriza.TabIndex = 444
        Me.btn_autoriza.Text = "Autorizar"
        Me.btn_autoriza.UseVisualStyleBackColor = False
        Me.btn_autoriza.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Location = New System.Drawing.Point(552, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(32, 13)
        Me.Panel1.TabIndex = 446
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(585, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 9)
        Me.Label20.TabIndex = 445
        Me.Label20.Text = "AUTORIZADO"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Thistle
        Me.Panel2.Location = New System.Drawing.Point(671, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(32, 13)
        Me.Panel2.TabIndex = 448
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(704, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(16, 9)
        Me.Label22.TabIndex = 447
        Me.Label22.Text = "PO"
        '
        'btn_pdf
        '
        Me.btn_pdf.ForeColor = System.Drawing.Color.Black
        Me.btn_pdf.Image = CType(resources.GetObject("btn_pdf.Image"), System.Drawing.Image)
        Me.btn_pdf.Location = New System.Drawing.Point(317, 542)
        Me.btn_pdf.Name = "btn_pdf"
        Me.btn_pdf.Size = New System.Drawing.Size(68, 71)
        Me.btn_pdf.TabIndex = 435
        Me.btn_pdf.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_pdf.UseVisualStyleBackColor = False
        Me.btn_pdf.Visible = False
        '
        'Requerimientos_movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 625)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btn_autoriza)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lbl_moneda)
        Me.Controls.Add(Me.dtp_fecharecep)
        Me.Controls.Add(Me.btn_desma)
        Me.Controls.Add(Me.btn_selec)
        Me.Controls.Add(Me.btn_pdf)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lbl_nparte)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cbx_area)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_solicitar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lbl_comprador)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbl_oc)
        Me.Controls.Add(Me.txt_comen)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_descuento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_retenciones)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_impuestos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_subtotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_fecharecep)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_producto)
        Me.Controls.Add(Me.txt_proveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgvp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Requerimientos_movimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_proveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_producto As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_fecharecep As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_impuestos As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_retenciones As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_descuento As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents txt_comen As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl_oc As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_comprador As Label
    Friend WithEvents btn_solicitar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents cbx_area As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lbl_nparte As Label
    Friend WithEvents btn_pdf As Button
    Friend WithEvents btn_desma As Button
    Friend WithEvents btn_selec As Button
    Friend WithEvents dtp_fecharecep As DateTimePicker
    Friend WithEvents lbl_moneda As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_autoriza As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label22 As Label
End Class
