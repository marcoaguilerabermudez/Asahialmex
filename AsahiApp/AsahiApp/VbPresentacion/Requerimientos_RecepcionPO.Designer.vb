<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Requerimientos_RecepcionPO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requerimientos_RecepcionPO))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbx_serie = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.btn_fil2 = New System.Windows.Forms.Button()
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_tc = New System.Windows.Forms.Label()
        Me.lbl_moneda = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.TC = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_subtotalpo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_po = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_desma = New System.Windows.Forms.Button()
        Me.btn_selec = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_rfc = New System.Windows.Forms.Label()
        Me.lbl_foliofact = New System.Windows.Forms.TextBox()
        Me.lbl_neto = New System.Windows.Forms.TextBox()
        Me.lbl_t = New System.Windows.Forms.TextBox()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbx_tipo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(27, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 489
        Me.Label8.Text = "No"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(177, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 491
        Me.Label13.Text = "Serie"
        '
        'cbx_serie
        '
        Me.cbx_serie.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_serie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_serie.FormattingEnabled = True
        Me.cbx_serie.Items.AddRange(New Object() {"A", "N"})
        Me.cbx_serie.Location = New System.Drawing.Point(173, 36)
        Me.cbx_serie.Name = "cbx_serie"
        Me.cbx_serie.Size = New System.Drawing.Size(47, 21)
        Me.cbx_serie.TabIndex = 490
        Me.cbx_serie.Text = "A"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label37.Location = New System.Drawing.Point(79, 5)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(67, 13)
        Me.Label37.TabIndex = 487
        Me.Label37.Text = "Buscar PO"
        '
        'btn_fil2
        '
        Me.btn_fil2.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_fil2.Enabled = False
        Me.btn_fil2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fil2.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_fil2.Location = New System.Drawing.Point(259, 24)
        Me.btn_fil2.Name = "btn_fil2"
        Me.btn_fil2.Size = New System.Drawing.Size(120, 35)
        Me.btn_fil2.TabIndex = 488
        Me.btn_fil2.Text = "Buscar"
        Me.btn_fil2.UseVisualStyleBackColor = False
        '
        'txt_no
        '
        Me.txt_no.BackColor = System.Drawing.SystemColors.Control
        Me.txt_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_no.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_no.Location = New System.Drawing.Point(10, 36)
        Me.txt_no.MaxLength = 99
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(62, 20)
        Me.txt_no.TabIndex = 486
        Me.txt_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.dtgvp.Location = New System.Drawing.Point(12, 221)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(921, 358)
        Me.dtgvp.TabIndex = 492
        Me.dtgvp.Visible = False
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_proveedor.Location = New System.Drawing.Point(88, 23)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(0, 13)
        Me.lbl_proveedor.TabIndex = 500
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(12, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 499
        Me.Label6.Text = "Proveedor"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(21, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 501
        Me.Label19.Text = "Total PO"
        '
        'lbl_tc
        '
        Me.lbl_tc.AutoSize = True
        Me.lbl_tc.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_tc.ForeColor = System.Drawing.Color.Black
        Me.lbl_tc.Location = New System.Drawing.Point(90, 128)
        Me.lbl_tc.Name = "lbl_tc"
        Me.lbl_tc.Size = New System.Drawing.Size(0, 13)
        Me.lbl_tc.TabIndex = 506
        '
        'lbl_moneda
        '
        Me.lbl_moneda.AutoSize = True
        Me.lbl_moneda.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_moneda.ForeColor = System.Drawing.Color.Black
        Me.lbl_moneda.Location = New System.Drawing.Point(90, 108)
        Me.lbl_moneda.Name = "lbl_moneda"
        Me.lbl_moneda.Size = New System.Drawing.Size(0, 13)
        Me.lbl_moneda.TabIndex = 505
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(90, 88)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(0, 13)
        Me.lbl_total.TabIndex = 502
        '
        'TC
        '
        Me.TC.AutoSize = True
        Me.TC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TC.Location = New System.Drawing.Point(50, 128)
        Me.TC.Name = "TC"
        Me.TC.Size = New System.Drawing.Size(23, 13)
        Me.TC.TabIndex = 503
        Me.TC.Text = "TC"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(26, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 504
        Me.Label12.Text = "Moneda"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(2, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 516
        Me.Label3.Text = "Subtotal PO"
        '
        'lbl_subtotalpo
        '
        Me.lbl_subtotalpo.AutoSize = True
        Me.lbl_subtotalpo.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_subtotalpo.ForeColor = System.Drawing.Color.Black
        Me.lbl_subtotalpo.Location = New System.Drawing.Point(87, 67)
        Me.lbl_subtotalpo.Name = "lbl_subtotalpo"
        Me.lbl_subtotalpo.Size = New System.Drawing.Size(0, 13)
        Me.lbl_subtotalpo.TabIndex = 517
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
        Me.Panel1.Location = New System.Drawing.Point(385, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 210)
        Me.Panel1.TabIndex = 519
        Me.Panel1.Visible = False
        '
        'lbl_totalfact
        '
        Me.lbl_totalfact.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_totalfact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_totalfact.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_totalfact.Location = New System.Drawing.Point(409, 177)
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
        Me.lbl_subtotalfact.Location = New System.Drawing.Point(409, 147)
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
        Me.dtp2.Location = New System.Drawing.Point(102, 173)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(100, 20)
        Me.dtp2.TabIndex = 539
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(103, 144)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 538
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(10, 147)
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
        Me.Label16.Location = New System.Drawing.Point(21, 175)
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
        Me.btn_doc.Location = New System.Drawing.Point(352, 55)
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
        Me.Label10.Location = New System.Drawing.Point(308, 178)
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
        Me.Label17.Location = New System.Drawing.Point(338, 148)
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
        Me.Label9.Location = New System.Drawing.Point(64, 95)
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
        Me.Label11.Location = New System.Drawing.Point(59, 121)
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
        Me.lbl_uuid.Location = New System.Drawing.Point(104, 121)
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
        Me.gbx_tipo.Location = New System.Drawing.Point(7, 10)
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
        Me.lbl_txtfiltro.Location = New System.Drawing.Point(13, 50)
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
        Me.txt_busca.Location = New System.Drawing.Point(12, 66)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(315, 20)
        Me.txt_busca.TabIndex = 524
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.Location = New System.Drawing.Point(193, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(32, 13)
        Me.Panel4.TabIndex = 521
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(193, 8)
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
        Me.Label1.Location = New System.Drawing.Point(226, 32)
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
        Me.Label4.Location = New System.Drawing.Point(226, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 9)
        Me.Label4.TabIndex = 518
        Me.Label4.Text = "PENDIENTE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(49, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 522
        Me.Label7.Text = "PO"
        '
        'lbl_po
        '
        Me.lbl_po.AutoSize = True
        Me.lbl_po.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_po.ForeColor = System.Drawing.Color.Black
        Me.lbl_po.Location = New System.Drawing.Point(90, 6)
        Me.lbl_po.Name = "lbl_po"
        Me.lbl_po.Size = New System.Drawing.Size(0, 13)
        Me.lbl_po.TabIndex = 523
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_t)
        Me.Panel2.Controls.Add(Me.lbl_neto)
        Me.Panel2.Controls.Add(Me.btn_desma)
        Me.Panel2.Controls.Add(Me.btn_selec)
        Me.Panel2.Controls.Add(Me.btn_calcular)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.btn_cargar)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 583)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(921, 57)
        Me.Panel2.TabIndex = 520
        Me.Panel2.Visible = False
        '
        'btn_desma
        '
        Me.btn_desma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_desma.Location = New System.Drawing.Point(7, 19)
        Me.btn_desma.Name = "btn_desma"
        Me.btn_desma.Size = New System.Drawing.Size(90, 32)
        Me.btn_desma.TabIndex = 516
        Me.btn_desma.Text = "Desmarcar"
        Me.btn_desma.UseVisualStyleBackColor = False
        '
        'btn_selec
        '
        Me.btn_selec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_selec.Location = New System.Drawing.Point(111, 19)
        Me.btn_selec.Name = "btn_selec"
        Me.btn_selec.Size = New System.Drawing.Size(90, 32)
        Me.btn_selec.TabIndex = 515
        Me.btn_selec.Text = "Seleccionar"
        Me.btn_selec.UseVisualStyleBackColor = False
        '
        'btn_calcular
        '
        Me.btn_calcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_calcular.Location = New System.Drawing.Point(277, 19)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(90, 32)
        Me.btn_calcular.TabIndex = 518
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = False
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
        Me.btn_cargar.Location = New System.Drawing.Point(373, 19)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(90, 32)
        Me.btn_cargar.TabIndex = 515
        Me.btn_cargar.Text = "Recibir"
        Me.btn_cargar.UseVisualStyleBackColor = False
        Me.btn_cargar.Visible = False
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
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.lbl_rfc)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.lbl_tc)
        Me.Panel5.Controls.Add(Me.lbl_moneda)
        Me.Panel5.Controls.Add(Me.lbl_po)
        Me.Panel5.Controls.Add(Me.lbl_total)
        Me.Panel5.Controls.Add(Me.TC)
        Me.Panel5.Controls.Add(Me.lbl_subtotalpo)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.lbl_proveedor)
        Me.Panel5.Location = New System.Drawing.Point(-2, 65)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(381, 150)
        Me.Panel5.TabIndex = 521
        Me.Panel5.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(42, 45)
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
        Me.lbl_rfc.Location = New System.Drawing.Point(88, 45)
        Me.lbl_rfc.Name = "lbl_rfc"
        Me.lbl_rfc.Size = New System.Drawing.Size(0, 13)
        Me.lbl_rfc.TabIndex = 525
        '
        'lbl_foliofact
        '
        Me.lbl_foliofact.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_foliofact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_foliofact.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_foliofact.Location = New System.Drawing.Point(102, 91)
        Me.lbl_foliofact.MaxLength = 99
        Me.lbl_foliofact.Name = "lbl_foliofact"
        Me.lbl_foliofact.Size = New System.Drawing.Size(127, 20)
        Me.lbl_foliofact.TabIndex = 542
        '
        'lbl_neto
        '
        Me.lbl_neto.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_neto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_neto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_neto.Location = New System.Drawing.Point(602, 5)
        Me.lbl_neto.MaxLength = 99
        Me.lbl_neto.Name = "lbl_neto"
        Me.lbl_neto.Size = New System.Drawing.Size(138, 20)
        Me.lbl_neto.TabIndex = 541
        Me.lbl_neto.Text = "0"
        Me.lbl_neto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_t
        '
        Me.lbl_t.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_t.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_t.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_t.Location = New System.Drawing.Point(602, 31)
        Me.lbl_t.MaxLength = 99
        Me.lbl_t.Name = "lbl_t"
        Me.lbl_t.Size = New System.Drawing.Size(138, 20)
        Me.lbl_t.TabIndex = 542
        Me.lbl_t.Text = "0"
        Me.lbl_t.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Requerimientos_RecepcionPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 645)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbx_serie)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.btn_fil2)
        Me.Controls.Add(Me.txt_no)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Requerimientos_RecepcionPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepciones con PO"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbx_tipo.ResumeLayout(False)
        Me.gbx_tipo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbx_serie As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents btn_fil2 As Button
    Friend WithEvents txt_no As TextBox
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents lbl_proveedor As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_tc As Label
    Friend WithEvents lbl_moneda As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents TC As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_subtotalpo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_desma As Button
    Friend WithEvents btn_selec As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_cargar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_po As Label
    Friend WithEvents gbx_tipo As GroupBox
    Friend WithEvents rbt_retardo As RadioButton
    Friend WithEvents rbt_falta As RadioButton
    Friend WithEvents lbl_txtfiltro As Label
    Friend WithEvents txt_busca As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_rfc As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_uuid As Label
    Friend WithEvents btn_doc As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl_totalfact As TextBox
    Friend WithEvents lbl_subtotalfact As TextBox
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents lbl_foliofact As TextBox
    Friend WithEvents lbl_t As TextBox
    Friend WithEvents lbl_neto As TextBox
End Class
