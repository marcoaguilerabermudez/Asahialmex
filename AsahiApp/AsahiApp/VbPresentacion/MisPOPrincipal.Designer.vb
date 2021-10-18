<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MisPOPrincipal
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MisPOPrincipal))
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.lbl_req = New System.Windows.Forms.Label()
        Me.btn_solicitar = New System.Windows.Forms.Button()
        Me.btn_pdf = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.lbl_impuestos = New System.Windows.Forms.Label()
        Me.lbl_retenciones = New System.Windows.Forms.Label()
        Me.lbl_descuentos = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_fechaE = New System.Windows.Forms.Label()
        Me.lbl_fechaS = New System.Windows.Forms.Label()
        Me.lbl_fechaC = New System.Windows.Forms.Label()
        Me.lbl_tc = New System.Windows.Forms.Label()
        Me.lbl_moneda = New System.Windows.Forms.Label()
        Me.TC = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_comen = New System.Windows.Forms.TextBox()
        Me.lbl_comprador = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.btn_fil2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbx_serie = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_po = New System.Windows.Forms.Label()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgvp.Location = New System.Drawing.Point(12, 131)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.ReadOnly = True
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(630, 548)
        Me.dtgvp.TabIndex = 428
        '
        'lbl_req
        '
        Me.lbl_req.AutoSize = True
        Me.lbl_req.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_req.ForeColor = System.Drawing.Color.Black
        Me.lbl_req.Location = New System.Drawing.Point(930, 94)
        Me.lbl_req.Name = "lbl_req"
        Me.lbl_req.Size = New System.Drawing.Size(38, 13)
        Me.lbl_req.TabIndex = 437
        Me.lbl_req.Text = "Desde"
        Me.lbl_req.Visible = False
        '
        'btn_solicitar
        '
        Me.btn_solicitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_solicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_solicitar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_solicitar.Location = New System.Drawing.Point(74, 68)
        Me.btn_solicitar.Name = "btn_solicitar"
        Me.btn_solicitar.Size = New System.Drawing.Size(120, 35)
        Me.btn_solicitar.TabIndex = 436
        Me.btn_solicitar.Text = "Filtrar"
        Me.btn_solicitar.UseVisualStyleBackColor = False
        '
        'btn_pdf
        '
        Me.btn_pdf.ForeColor = System.Drawing.Color.Black
        Me.btn_pdf.Image = CType(resources.GetObject("btn_pdf.Image"), System.Drawing.Image)
        Me.btn_pdf.Location = New System.Drawing.Point(924, 16)
        Me.btn_pdf.Name = "btn_pdf"
        Me.btn_pdf.Size = New System.Drawing.Size(68, 71)
        Me.btn_pdf.TabIndex = 435
        Me.btn_pdf.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_pdf.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(172, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 434
        Me.Label1.Text = "Hasta"
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(142, 35)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(100, 20)
        Me.dtp2.TabIndex = 433
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(53, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 432
        Me.Label4.Text = "Desde"
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(23, 35)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 431
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(64, 49)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 13)
        Me.Label25.TabIndex = 460
        Me.Label25.Text = "Subtotal"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(64, 156)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 453
        Me.Label19.Text = "Total PO"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(44, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 13)
        Me.Label21.TabIndex = 452
        Me.Label21.Text = "Descuentos"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label22.Location = New System.Drawing.Point(40, 101)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 13)
        Me.Label22.TabIndex = 451
        Me.Label22.Text = "Retenciones"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(54, 76)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 13)
        Me.Label23.TabIndex = 450
        Me.Label23.Text = "Impuestos"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_subtotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_subtotal.Location = New System.Drawing.Point(133, 50)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(0, 13)
        Me.lbl_subtotal.TabIndex = 461
        '
        'lbl_impuestos
        '
        Me.lbl_impuestos.AutoSize = True
        Me.lbl_impuestos.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_impuestos.ForeColor = System.Drawing.Color.Black
        Me.lbl_impuestos.Location = New System.Drawing.Point(133, 76)
        Me.lbl_impuestos.Name = "lbl_impuestos"
        Me.lbl_impuestos.Size = New System.Drawing.Size(0, 13)
        Me.lbl_impuestos.TabIndex = 462
        '
        'lbl_retenciones
        '
        Me.lbl_retenciones.AutoSize = True
        Me.lbl_retenciones.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_retenciones.ForeColor = System.Drawing.Color.Black
        Me.lbl_retenciones.Location = New System.Drawing.Point(133, 101)
        Me.lbl_retenciones.Name = "lbl_retenciones"
        Me.lbl_retenciones.Size = New System.Drawing.Size(0, 13)
        Me.lbl_retenciones.TabIndex = 463
        '
        'lbl_descuentos
        '
        Me.lbl_descuentos.AutoSize = True
        Me.lbl_descuentos.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_descuentos.ForeColor = System.Drawing.Color.Black
        Me.lbl_descuentos.Location = New System.Drawing.Point(133, 128)
        Me.lbl_descuentos.Name = "lbl_descuentos"
        Me.lbl_descuentos.Size = New System.Drawing.Size(0, 13)
        Me.lbl_descuentos.TabIndex = 464
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(133, 156)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(0, 13)
        Me.lbl_total.TabIndex = 465
        '
        'lbl_fechaE
        '
        Me.lbl_fechaE.AutoSize = True
        Me.lbl_fechaE.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_fechaE.ForeColor = System.Drawing.Color.Black
        Me.lbl_fechaE.Location = New System.Drawing.Point(133, 309)
        Me.lbl_fechaE.Name = "lbl_fechaE"
        Me.lbl_fechaE.Size = New System.Drawing.Size(0, 13)
        Me.lbl_fechaE.TabIndex = 475
        '
        'lbl_fechaS
        '
        Me.lbl_fechaS.AutoSize = True
        Me.lbl_fechaS.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_fechaS.ForeColor = System.Drawing.Color.Black
        Me.lbl_fechaS.Location = New System.Drawing.Point(133, 281)
        Me.lbl_fechaS.Name = "lbl_fechaS"
        Me.lbl_fechaS.Size = New System.Drawing.Size(0, 13)
        Me.lbl_fechaS.TabIndex = 474
        '
        'lbl_fechaC
        '
        Me.lbl_fechaC.AutoSize = True
        Me.lbl_fechaC.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_fechaC.ForeColor = System.Drawing.Color.Black
        Me.lbl_fechaC.Location = New System.Drawing.Point(133, 254)
        Me.lbl_fechaC.Name = "lbl_fechaC"
        Me.lbl_fechaC.Size = New System.Drawing.Size(0, 13)
        Me.lbl_fechaC.TabIndex = 473
        '
        'lbl_tc
        '
        Me.lbl_tc.AutoSize = True
        Me.lbl_tc.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_tc.ForeColor = System.Drawing.Color.Black
        Me.lbl_tc.Location = New System.Drawing.Point(133, 207)
        Me.lbl_tc.Name = "lbl_tc"
        Me.lbl_tc.Size = New System.Drawing.Size(0, 13)
        Me.lbl_tc.TabIndex = 472
        '
        'lbl_moneda
        '
        Me.lbl_moneda.AutoSize = True
        Me.lbl_moneda.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_moneda.ForeColor = System.Drawing.Color.Black
        Me.lbl_moneda.Location = New System.Drawing.Point(133, 181)
        Me.lbl_moneda.Name = "lbl_moneda"
        Me.lbl_moneda.Size = New System.Drawing.Size(0, 13)
        Me.lbl_moneda.TabIndex = 471
        '
        'TC
        '
        Me.TC.AutoSize = True
        Me.TC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TC.Location = New System.Drawing.Point(93, 207)
        Me.TC.Name = "TC"
        Me.TC.Size = New System.Drawing.Size(23, 13)
        Me.TC.TabIndex = 466
        Me.TC.Text = "TC"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(8, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 467
        Me.Label9.Text = "Fecha de creación"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(10, 281)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 468
        Me.Label10.Text = "Fecha de solicitud"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(11, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 469
        Me.Label11.Text = "Fecha de entrega"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(69, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 470
        Me.Label12.Text = "Moneda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(8, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 476
        Me.Label2.Text = "Observaciones"
        '
        'txt_comen
        '
        Me.txt_comen.BackColor = System.Drawing.SystemColors.Control
        Me.txt_comen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_comen.Enabled = False
        Me.txt_comen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_comen.Location = New System.Drawing.Point(11, 362)
        Me.txt_comen.MaxLength = 100
        Me.txt_comen.Multiline = True
        Me.txt_comen.Name = "txt_comen"
        Me.txt_comen.Size = New System.Drawing.Size(322, 61)
        Me.txt_comen.TabIndex = 477
        '
        'lbl_comprador
        '
        Me.lbl_comprador.AutoSize = True
        Me.lbl_comprador.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_comprador.ForeColor = System.Drawing.Color.Black
        Me.lbl_comprador.Location = New System.Drawing.Point(131, 458)
        Me.lbl_comprador.Name = "lbl_comprador"
        Me.lbl_comprador.Size = New System.Drawing.Size(0, 13)
        Me.lbl_comprador.TabIndex = 479
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(51, 457)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 478
        Me.Label5.Text = "Comprador"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label37.Location = New System.Drawing.Point(761, 6)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(67, 13)
        Me.Label37.TabIndex = 481
        Me.Label37.Text = "Buscar PO"
        '
        'txt_no
        '
        Me.txt_no.BackColor = System.Drawing.SystemColors.Control
        Me.txt_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_no.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_no.Location = New System.Drawing.Point(715, 35)
        Me.txt_no.MaxLength = 99
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(62, 20)
        Me.txt_no.TabIndex = 480
        Me.txt_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_fil2
        '
        Me.btn_fil2.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_fil2.Enabled = False
        Me.btn_fil2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fil2.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_fil2.Location = New System.Drawing.Point(746, 68)
        Me.btn_fil2.Name = "btn_fil2"
        Me.btn_fil2.Size = New System.Drawing.Size(120, 35)
        Me.btn_fil2.TabIndex = 482
        Me.btn_fil2.Text = "Filtrar"
        Me.btn_fil2.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(833, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 485
        Me.Label13.Text = "Serie"
        '
        'cbx_serie
        '
        Me.cbx_serie.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_serie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_serie.FormattingEnabled = True
        Me.cbx_serie.Items.AddRange(New Object() {"A", "N"})
        Me.cbx_serie.Location = New System.Drawing.Point(829, 34)
        Me.cbx_serie.Name = "cbx_serie"
        Me.cbx_serie.Size = New System.Drawing.Size(47, 21)
        Me.cbx_serie.TabIndex = 484
        Me.cbx_serie.Text = "A"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(732, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 483
        Me.Label8.Text = "No"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lbl_po)
        Me.Panel2.Controls.Add(Me.lbl_proveedor)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txt_comen)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.lbl_comprador)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.lbl_fechaE)
        Me.Panel2.Controls.Add(Me.lbl_subtotal)
        Me.Panel2.Controls.Add(Me.lbl_fechaS)
        Me.Panel2.Controls.Add(Me.lbl_impuestos)
        Me.Panel2.Controls.Add(Me.lbl_fechaC)
        Me.Panel2.Controls.Add(Me.lbl_retenciones)
        Me.Panel2.Controls.Add(Me.lbl_tc)
        Me.Panel2.Controls.Add(Me.lbl_descuentos)
        Me.Panel2.Controls.Add(Me.lbl_moneda)
        Me.Panel2.Controls.Add(Me.lbl_total)
        Me.Panel2.Controls.Add(Me.TC)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(648, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(344, 493)
        Me.Panel2.TabIndex = 484
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(92, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 482
        Me.Label7.Text = "PO"
        '
        'lbl_po
        '
        Me.lbl_po.AutoSize = True
        Me.lbl_po.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_po.ForeColor = System.Drawing.Color.Black
        Me.lbl_po.Location = New System.Drawing.Point(133, 26)
        Me.lbl_po.Name = "lbl_po"
        Me.lbl_po.Size = New System.Drawing.Size(0, 13)
        Me.lbl_po.TabIndex = 483
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_proveedor.Location = New System.Drawing.Point(133, 231)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(0, 13)
        Me.lbl_proveedor.TabIndex = 481
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(53, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 480
        Me.Label6.Text = "Proveedor"
        '
        'MisPOPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 691)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cbx_serie)
        Me.Controls.Add(Me.lbl_req)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.btn_fil2)
        Me.Controls.Add(Me.btn_solicitar)
        Me.Controls.Add(Me.txt_no)
        Me.Controls.Add(Me.btn_pdf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.dtgvp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MisPOPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mis PO"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents lbl_req As Label
    Friend WithEvents btn_solicitar As Button
    Friend WithEvents btn_pdf As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents lbl_impuestos As Label
    Friend WithEvents lbl_retenciones As Label
    Friend WithEvents lbl_descuentos As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_fechaE As Label
    Friend WithEvents lbl_fechaS As Label
    Friend WithEvents lbl_fechaC As Label
    Friend WithEvents lbl_tc As Label
    Friend WithEvents lbl_moneda As Label
    Friend WithEvents TC As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_comen As TextBox
    Friend WithEvents lbl_comprador As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents txt_no As TextBox
    Friend WithEvents btn_fil2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_po As Label
    Friend WithEvents lbl_proveedor As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbx_serie As ComboBox
End Class
