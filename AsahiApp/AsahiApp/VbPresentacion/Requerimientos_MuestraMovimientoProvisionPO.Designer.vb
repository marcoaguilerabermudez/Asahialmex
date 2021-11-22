<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requerimientos_MuestraMovimientoProvisionPO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requerimientos_MuestraMovimientoProvisionPO))
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.DS_Ausentismos_Fecha1 = New CsPresentacion.DS_Ausentismos_Fecha()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_foliofact = New System.Windows.Forms.TextBox()
        Me.lbl_totalfact = New System.Windows.Forms.TextBox()
        Me.lbl_subtotalfact = New System.Windows.Forms.TextBox()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_doc = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_uuid = New System.Windows.Forms.Label()
        Me.gbx_tipo = New System.Windows.Forms.GroupBox()
        Me.rbt_retardo = New System.Windows.Forms.RadioButton()
        Me.rbt_falta = New System.Windows.Forms.RadioButton()
        Me.lbl_txtfiltro = New System.Windows.Forms.Label()
        Me.txt_busca = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_prov = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_rfc = New System.Windows.Forms.Label()
        Me.lbl_moneda = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_t = New System.Windows.Forms.TextBox()
        Me.lbl_neto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Ausentismos_Fecha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbx_tipo.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToDeleteRows = False
        Me.dtgvp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgvp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
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
        Me.dtgvp.Location = New System.Drawing.Point(12, 206)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(918, 286)
        Me.dtgvp.TabIndex = 548
        Me.dtgvp.Visible = False
        '
        'DS_Ausentismos_Fecha1
        '
        Me.DS_Ausentismos_Fecha1.DataSetName = "DS_Ausentismos_Fecha"
        Me.DS_Ausentismos_Fecha1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_foliofact)
        Me.Panel1.Controls.Add(Me.lbl_totalfact)
        Me.Panel1.Controls.Add(Me.lbl_subtotalfact)
        Me.Panel1.Controls.Add(Me.dtp2)
        Me.Panel1.Controls.Add(Me.dtp1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.btn_doc)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lbl_uuid)
        Me.Panel1.Controls.Add(Me.gbx_tipo)
        Me.Panel1.Controls.Add(Me.lbl_txtfiltro)
        Me.Panel1.Controls.Add(Me.txt_busca)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(390, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 196)
        Me.Panel1.TabIndex = 549
        Me.Panel1.Visible = False
        '
        'lbl_foliofact
        '
        Me.lbl_foliofact.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_foliofact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_foliofact.Enabled = False
        Me.lbl_foliofact.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_foliofact.Location = New System.Drawing.Point(102, 89)
        Me.lbl_foliofact.MaxLength = 99
        Me.lbl_foliofact.Name = "lbl_foliofact"
        Me.lbl_foliofact.Size = New System.Drawing.Size(225, 20)
        Me.lbl_foliofact.TabIndex = 542
        '
        'lbl_totalfact
        '
        Me.lbl_totalfact.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_totalfact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_totalfact.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_totalfact.Location = New System.Drawing.Point(409, 172)
        Me.lbl_totalfact.MaxLength = 99
        Me.lbl_totalfact.Name = "lbl_totalfact"
        Me.lbl_totalfact.Size = New System.Drawing.Size(127, 20)
        Me.lbl_totalfact.TabIndex = 541
        Me.lbl_totalfact.Text = "0"
        Me.lbl_totalfact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_subtotalfact
        '
        Me.lbl_subtotalfact.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_subtotalfact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_subtotalfact.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_subtotalfact.Location = New System.Drawing.Point(409, 142)
        Me.lbl_subtotalfact.MaxLength = 99
        Me.lbl_subtotalfact.Name = "lbl_subtotalfact"
        Me.lbl_subtotalfact.Size = New System.Drawing.Size(127, 20)
        Me.lbl_subtotalfact.TabIndex = 540
        Me.lbl_subtotalfact.Text = "0"
        Me.lbl_subtotalfact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(102, 168)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(100, 20)
        Me.dtp2.TabIndex = 539
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(103, 139)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 538
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(10, 142)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 537
        Me.Label15.Text = "Fecha factura"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(21, 170)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 536
        Me.Label16.Text = "Fecha Pago"
        '
        'btn_doc
        '
        Me.btn_doc.Enabled = False
        Me.btn_doc.ForeColor = System.Drawing.Color.Black
        Me.btn_doc.Image = Global.Presentacion.My.Resources.Resources.report
        Me.btn_doc.Location = New System.Drawing.Point(351, 64)
        Me.btn_doc.Name = "btn_doc"
        Me.btn_doc.Size = New System.Drawing.Size(42, 40)
        Me.btn_doc.TabIndex = 535
        Me.btn_doc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_doc.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(308, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 16)
        Me.Label10.TabIndex = 532
        Me.Label10.Text = "Total factura"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(338, 143)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 16)
        Me.Label17.TabIndex = 534
        Me.Label17.Text = "Subtotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(64, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 529
        Me.Label9.Text = "Folio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(59, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 527
        Me.Label11.Text = "UUID"
        '
        'lbl_uuid
        '
        Me.lbl_uuid.AutoSize = True
        Me.lbl_uuid.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_uuid.ForeColor = System.Drawing.Color.Black
        Me.lbl_uuid.Location = New System.Drawing.Point(104, 119)
        Me.lbl_uuid.Name = "lbl_uuid"
        Me.lbl_uuid.Size = New System.Drawing.Size(0, 13)
        Me.lbl_uuid.TabIndex = 528
        '
        'gbx_tipo
        '
        Me.gbx_tipo.Controls.Add(Me.rbt_retardo)
        Me.gbx_tipo.Controls.Add(Me.rbt_falta)
        Me.gbx_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbx_tipo.Location = New System.Drawing.Point(7, 7)
        Me.gbx_tipo.Name = "gbx_tipo"
        Me.gbx_tipo.Size = New System.Drawing.Size(140, 37)
        Me.gbx_tipo.TabIndex = 526
        Me.gbx_tipo.TabStop = False
        Me.gbx_tipo.Text = "Buscar por"
        '
        'rbt_retardo
        '
        Me.rbt_retardo.AutoSize = True
        Me.rbt_retardo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbt_retardo.Location = New System.Drawing.Point(79, 17)
        Me.rbt_retardo.Name = "rbt_retardo"
        Me.rbt_retardo.Size = New System.Drawing.Size(52, 17)
        Me.rbt_retardo.TabIndex = 177
        Me.rbt_retardo.Text = "Folio"
        Me.rbt_retardo.UseVisualStyleBackColor = True
        '
        'rbt_falta
        '
        Me.rbt_falta.AutoSize = True
        Me.rbt_falta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbt_falta.Location = New System.Drawing.Point(9, 17)
        Me.rbt_falta.Name = "rbt_falta"
        Me.rbt_falta.Size = New System.Drawing.Size(56, 17)
        Me.rbt_falta.TabIndex = 176
        Me.rbt_falta.Text = "UUID"
        Me.rbt_falta.UseVisualStyleBackColor = True
        '
        'lbl_txtfiltro
        '
        Me.lbl_txtfiltro.AutoSize = True
        Me.lbl_txtfiltro.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_txtfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_txtfiltro.ForeColor = System.Drawing.Color.Black
        Me.lbl_txtfiltro.Location = New System.Drawing.Point(13, 48)
        Me.lbl_txtfiltro.Name = "lbl_txtfiltro"
        Me.lbl_txtfiltro.Size = New System.Drawing.Size(38, 13)
        Me.lbl_txtfiltro.TabIndex = 525
        Me.lbl_txtfiltro.Text = "UUID"
        '
        'txt_busca
        '
        Me.txt_busca.BackColor = System.Drawing.SystemColors.Control
        Me.txt_busca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_busca.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_busca.Location = New System.Drawing.Point(12, 64)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(315, 20)
        Me.txt_busca.TabIndex = 524
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.Location = New System.Drawing.Point(409, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(32, 13)
        Me.Panel4.TabIndex = 521
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(409, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(32, 13)
        Me.Panel3.TabIndex = 520
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(442, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 9)
        Me.Label1.TabIndex = 519
        Me.Label1.Text = "RECEPCIÓN COMPLETA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(442, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 9)
        Me.Label4.TabIndex = 518
        Me.Label4.Text = "PENDIENTE"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbl_prov)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.lbl_rfc)
        Me.Panel5.Controls.Add(Me.lbl_moneda)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.lbl_proveedor)
        Me.Panel5.Location = New System.Drawing.Point(4, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(381, 192)
        Me.Panel5.TabIndex = 550
        '
        'lbl_prov
        '
        Me.lbl_prov.AutoSize = True
        Me.lbl_prov.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_prov.ForeColor = System.Drawing.Color.Black
        Me.lbl_prov.Location = New System.Drawing.Point(89, 160)
        Me.lbl_prov.Name = "lbl_prov"
        Me.lbl_prov.Size = New System.Drawing.Size(0, 13)
        Me.lbl_prov.TabIndex = 527
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(15, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 526
        Me.Label8.Text = "Provisión"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(42, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 524
        Me.Label5.Text = "RFC"
        '
        'lbl_rfc
        '
        Me.lbl_rfc.AutoSize = True
        Me.lbl_rfc.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_rfc.ForeColor = System.Drawing.Color.Black
        Me.lbl_rfc.Location = New System.Drawing.Point(88, 57)
        Me.lbl_rfc.Name = "lbl_rfc"
        Me.lbl_rfc.Size = New System.Drawing.Size(0, 13)
        Me.lbl_rfc.TabIndex = 525
        '
        'lbl_moneda
        '
        Me.lbl_moneda.AutoSize = True
        Me.lbl_moneda.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_moneda.ForeColor = System.Drawing.Color.Black
        Me.lbl_moneda.Location = New System.Drawing.Point(90, 106)
        Me.lbl_moneda.Name = "lbl_moneda"
        Me.lbl_moneda.Size = New System.Drawing.Size(0, 13)
        Me.lbl_moneda.TabIndex = 505
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(26, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 504
        Me.Label12.Text = "Moneda"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(12, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 499
        Me.Label6.Text = "Proveedor"
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_proveedor.Location = New System.Drawing.Point(88, 7)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(0, 13)
        Me.lbl_proveedor.TabIndex = 500
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_t)
        Me.Panel2.Controls.Add(Me.lbl_neto)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.btn_cargar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(13, 499)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(921, 57)
        Me.Panel2.TabIndex = 551
        Me.Panel2.Visible = False
        '
        'lbl_t
        '
        Me.lbl_t.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_t.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_t.Enabled = False
        Me.lbl_t.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_t.Location = New System.Drawing.Point(602, 31)
        Me.lbl_t.MaxLength = 99
        Me.lbl_t.Name = "lbl_t"
        Me.lbl_t.Size = New System.Drawing.Size(138, 20)
        Me.lbl_t.TabIndex = 542
        Me.lbl_t.Text = "0"
        Me.lbl_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_neto
        '
        Me.lbl_neto.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_neto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_neto.Enabled = False
        Me.lbl_neto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_neto.Location = New System.Drawing.Point(602, 5)
        Me.lbl_neto.MaxLength = 99
        Me.lbl_neto.Name = "lbl_neto"
        Me.lbl_neto.Size = New System.Drawing.Size(138, 20)
        Me.lbl_neto.TabIndex = 541
        Me.lbl_neto.Text = "0"
        Me.lbl_neto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(493, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 16)
        Me.Label14.TabIndex = 508
        Me.Label14.Text = "Total a recibir"
        '
        'btn_cargar
        '
        Me.btn_cargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_cargar.Location = New System.Drawing.Point(821, 15)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(90, 32)
        Me.btn_cargar.TabIndex = 515
        Me.btn_cargar.Text = "Recibir"
        Me.btn_cargar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(533, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 512
        Me.Label2.Text = "Subtotal"
        '
        'Requerimientos_MuestraMovimientoProvisionPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 562)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtgvp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Requerimientos_MuestraMovimientoProvisionPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Ausentismos_Fecha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbx_tipo.ResumeLayout(False)
        Me.gbx_tipo.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents DS_Ausentismos_Fecha1 As CsPresentacion.DS_Ausentismos_Fecha
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_foliofact As TextBox
    Friend WithEvents lbl_totalfact As TextBox
    Friend WithEvents lbl_subtotalfact As TextBox
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_doc As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_uuid As Label
    Friend WithEvents gbx_tipo As GroupBox
    Friend WithEvents rbt_retardo As RadioButton
    Friend WithEvents rbt_falta As RadioButton
    Friend WithEvents lbl_txtfiltro As Label
    Friend WithEvents txt_busca As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_rfc As Label
    Friend WithEvents lbl_moneda As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_proveedor As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_t As TextBox
    Friend WithEvents lbl_neto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_cargar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_prov As Label
    Friend WithEvents Label8 As Label
End Class
