<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Requerimientos_crear
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requerimientos_crear))
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.gbx_tipo = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rbt_retardo = New System.Windows.Forms.RadioButton()
        Me.rbt_falta = New System.Windows.Forms.RadioButton()
        Me.lbl_txtfiltro = New System.Windows.Forms.Label()
        Me.txt_código = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_liga = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_descr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_familia = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbx_area = New System.Windows.Forms.ComboBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_umed_com = New System.Windows.Forms.Label()
        Me.lbl_umed_con = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lbl_numpart = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_producto = New System.Windows.Forms.Label()
        Me.txt_proveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtgv_2 = New System.Windows.Forms.DataGridView()
        Me.c_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comentario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quitar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btn_selec = New System.Windows.Forms.Button()
        Me.btn_doc = New System.Windows.Forms.Button()
        Me.txt_comentarios = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_tipo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgv_2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle2.Format = "0.00"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgvp.Location = New System.Drawing.Point(8, 112)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(457, 303)
        Me.dtgvp.TabIndex = 268
        '
        'gbx_tipo
        '
        Me.gbx_tipo.Controls.Add(Me.RadioButton1)
        Me.gbx_tipo.Controls.Add(Me.rbt_retardo)
        Me.gbx_tipo.Controls.Add(Me.rbt_falta)
        Me.gbx_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbx_tipo.Location = New System.Drawing.Point(23, 6)
        Me.gbx_tipo.Name = "gbx_tipo"
        Me.gbx_tipo.Size = New System.Drawing.Size(360, 50)
        Me.gbx_tipo.TabIndex = 271
        Me.gbx_tipo.TabStop = False
        Me.gbx_tipo.Text = "Buscar por"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton1.Location = New System.Drawing.Point(242, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton1.TabIndex = 178
        Me.RadioButton1.Text = "No. Parte"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rbt_retardo
        '
        Me.rbt_retardo.AutoSize = True
        Me.rbt_retardo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbt_retardo.Location = New System.Drawing.Point(148, 22)
        Me.rbt_retardo.Name = "rbt_retardo"
        Me.rbt_retardo.Size = New System.Drawing.Size(64, 17)
        Me.rbt_retardo.TabIndex = 177
        Me.rbt_retardo.Text = "Familia"
        Me.rbt_retardo.UseVisualStyleBackColor = True
        '
        'rbt_falta
        '
        Me.rbt_falta.AutoSize = True
        Me.rbt_falta.Checked = True
        Me.rbt_falta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbt_falta.Location = New System.Drawing.Point(9, 22)
        Me.rbt_falta.Name = "rbt_falta"
        Me.rbt_falta.Size = New System.Drawing.Size(121, 17)
        Me.rbt_falta.TabIndex = 176
        Me.rbt_falta.TabStop = True
        Me.rbt_falta.Text = "Código / Nombre"
        Me.rbt_falta.UseVisualStyleBackColor = True
        '
        'lbl_txtfiltro
        '
        Me.lbl_txtfiltro.AutoSize = True
        Me.lbl_txtfiltro.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_txtfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_txtfiltro.ForeColor = System.Drawing.Color.Black
        Me.lbl_txtfiltro.Location = New System.Drawing.Point(6, 68)
        Me.lbl_txtfiltro.Name = "lbl_txtfiltro"
        Me.lbl_txtfiltro.Size = New System.Drawing.Size(103, 13)
        Me.lbl_txtfiltro.TabIndex = 270
        Me.lbl_txtfiltro.Text = "Código / Nombre"
        '
        'txt_código
        '
        Me.txt_código.BackColor = System.Drawing.SystemColors.Control
        Me.txt_código.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_código.Location = New System.Drawing.Point(5, 85)
        Me.txt_código.Name = "txt_código"
        Me.txt_código.Size = New System.Drawing.Size(464, 20)
        Me.txt_código.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_liga)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.dtp1)
        Me.Panel1.Controls.Add(Me.btn_guardar)
        Me.Panel1.Controls.Add(Me.txt_descr)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lbl_familia)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cbx_area)
        Me.Panel1.Controls.Add(Me.txt_cantidad)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_precio)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbl_umed_com)
        Me.Panel1.Controls.Add(Me.lbl_umed_con)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Lbl_numpart)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.lbl_codigo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_producto)
        Me.Panel1.Controls.Add(Me.txt_proveedor)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(475, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 414)
        Me.Panel1.TabIndex = 305
        Me.Panel1.Visible = False
        '
        'txt_liga
        '
        Me.txt_liga.BackColor = System.Drawing.SystemColors.Control
        Me.txt_liga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_liga.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_liga.Location = New System.Drawing.Point(409, 328)
        Me.txt_liga.MaxLength = 99
        Me.txt_liga.Name = "txt_liga"
        Me.txt_liga.Size = New System.Drawing.Size(53, 20)
        Me.txt_liga.TabIndex = 428
        Me.txt_liga.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(4, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 13)
        Me.Label11.TabIndex = 427
        Me.Label11.Text = "Fecha en que se requiere"
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(175, 7)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 1
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.Presentacion.My.Resources.Resources.prenomina
        Me.btn_guardar.Location = New System.Drawing.Point(359, 352)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(124, 57)
        Me.btn_guardar.TabIndex = 6
        Me.btn_guardar.Text = "Agregar Item"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_descr
        '
        Me.txt_descr.BackColor = System.Drawing.SystemColors.Control
        Me.txt_descr.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_descr.Location = New System.Drawing.Point(8, 352)
        Me.txt_descr.MaxLength = 149
        Me.txt_descr.Multiline = True
        Me.txt_descr.Name = "txt_descr"
        Me.txt_descr.Size = New System.Drawing.Size(303, 56)
        Me.txt_descr.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(5, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 424
        Me.Label7.Text = "Descripción"
        '
        'lbl_familia
        '
        Me.lbl_familia.AutoSize = True
        Me.lbl_familia.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_familia.ForeColor = System.Drawing.Color.Black
        Me.lbl_familia.Location = New System.Drawing.Point(5, 158)
        Me.lbl_familia.Name = "lbl_familia"
        Me.lbl_familia.Size = New System.Drawing.Size(39, 13)
        Me.lbl_familia.TabIndex = 421
        Me.lbl_familia.Text = "Familia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 420
        Me.Label8.Text = "Familia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(42, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 419
        Me.Label6.Text = "Área"
        '
        'cbx_area
        '
        Me.cbx_area.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_area.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_area.FormattingEnabled = True
        Me.cbx_area.Items.AddRange(New Object() {"ASEGURAMIENTO DE CALIDAD F1", "ASUNTOS GENERALES", "ATENCIÓN AL CLIENTE", "COMPRAS", "CONTABILIDAD", "CONTROL DE MANUFACTURA", "CONTROL DE PRODUCCION", "MOLDES", "SEGURIDAD", "SISTEMAS IT", "INGENIERÍA MAQUINADO", "INGENIERÍA FUNDICIÓN", "INSPECCION PRODUCCION", "FUNDICION 1", "FUNDICION 2", "ACABADO", "ACABADO 2", "CONTROL DE CLIENTES", "MANTENIMIENTO DE PLANTA", "MANTENIMIENTO FUNDICION", "MANTENIMIENTO MAQUINADO", "MAQUINADO F2", "INSPECCIÓN FUNDICION", "INSPECCIÓN MAQUINADO", "MAQUINADO F1", "FUSION", "ASEGURAMIENTO DE CALIDAD F2", "REPARACION DE MOLDES", "PRODUCCIÓN"})
        Me.cbx_area.Location = New System.Drawing.Point(97, 309)
        Me.cbx_area.Name = "cbx_area"
        Me.cbx_area.Size = New System.Drawing.Size(306, 21)
        Me.cbx_area.TabIndex = 418
        '
        'txt_cantidad
        '
        Me.txt_cantidad.BackColor = System.Drawing.SystemColors.Control
        Me.txt_cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cantidad.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_cantidad.Location = New System.Drawing.Point(10, 277)
        Me.txt_cantidad.MaxLength = 99
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(124, 20)
        Me.txt_cantidad.TabIndex = 3
        Me.txt_cantidad.Text = "0.0"
        Me.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(42, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 325
        Me.Label5.Text = "Cantidad"
        '
        'txt_precio
        '
        Me.txt_precio.BackColor = System.Drawing.SystemColors.Control
        Me.txt_precio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_precio.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_precio.Location = New System.Drawing.Point(279, 277)
        Me.txt_precio.MaxLength = 99
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(124, 20)
        Me.txt_precio.TabIndex = 4
        Me.txt_precio.Text = "0.00"
        Me.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(311, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 323
        Me.Label4.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 13)
        Me.Label3.TabIndex = 317
        Me.Label3.Text = "Unidad de medida (compra)"
        '
        'lbl_umed_com
        '
        Me.lbl_umed_com.AutoSize = True
        Me.lbl_umed_com.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_umed_com.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_umed_com.ForeColor = System.Drawing.Color.Black
        Me.lbl_umed_com.Location = New System.Drawing.Point(6, 194)
        Me.lbl_umed_com.Name = "lbl_umed_com"
        Me.lbl_umed_com.Size = New System.Drawing.Size(93, 13)
        Me.lbl_umed_com.TabIndex = 318
        Me.lbl_umed_com.Text = "Unidad de medida"
        '
        'lbl_umed_con
        '
        Me.lbl_umed_con.AutoSize = True
        Me.lbl_umed_con.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_umed_con.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_umed_con.ForeColor = System.Drawing.Color.Black
        Me.lbl_umed_con.Location = New System.Drawing.Point(252, 193)
        Me.lbl_umed_con.Name = "lbl_umed_con"
        Me.lbl_umed_con.Size = New System.Drawing.Size(93, 13)
        Me.lbl_umed_con.TabIndex = 322
        Me.lbl_umed_con.Text = "Unidad de medida"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(252, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 13)
        Me.Label10.TabIndex = 321
        Me.Label10.Text = "Unidad de medida (consumo)"
        '
        'Lbl_numpart
        '
        Me.Lbl_numpart.AutoSize = True
        Me.Lbl_numpart.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_numpart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_numpart.ForeColor = System.Drawing.Color.Black
        Me.Lbl_numpart.Location = New System.Drawing.Point(4, 126)
        Me.Lbl_numpart.Name = "Lbl_numpart"
        Me.Lbl_numpart.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_numpart.TabIndex = 320
        Me.Lbl_numpart.Text = "Número de parte"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(4, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 319
        Me.Label9.Text = "Número de parte"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(3, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 309
        Me.Label17.Text = "Código"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.ForeColor = System.Drawing.Color.Black
        Me.lbl_codigo.Location = New System.Drawing.Point(6, 55)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(40, 13)
        Me.lbl_codigo.TabIndex = 310
        Me.lbl_codigo.Text = "Código"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 307
        Me.Label1.Text = "Producto"
        '
        'lbl_producto
        '
        Me.lbl_producto.AutoSize = True
        Me.lbl_producto.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_producto.ForeColor = System.Drawing.Color.Black
        Me.lbl_producto.Location = New System.Drawing.Point(4, 90)
        Me.lbl_producto.Name = "lbl_producto"
        Me.lbl_producto.Size = New System.Drawing.Size(50, 13)
        Me.lbl_producto.TabIndex = 308
        Me.lbl_producto.Text = "Producto"
        '
        'txt_proveedor
        '
        Me.txt_proveedor.BackColor = System.Drawing.SystemColors.Control
        Me.txt_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_proveedor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_proveedor.Location = New System.Drawing.Point(6, 234)
        Me.txt_proveedor.MaxLength = 99
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Size = New System.Drawing.Size(477, 20)
        Me.txt_proveedor.TabIndex = 2
        Me.txt_proveedor.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 305
        Me.Label2.Text = "Proveedor"
        '
        'dtgv_2
        '
        Me.dtgv_2.AllowUserToAddRows = False
        Me.dtgv_2.AllowUserToDeleteRows = False
        Me.dtgv_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgv_2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgv_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgv_2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_1, Me.N_2, Me.Cantidad, Me.Precio, Me.Proveedor, Me.area, Me.fecha, Me.comentario, Me.Quitar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv_2.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv_2.Location = New System.Drawing.Point(12, 426)
        Me.dtgv_2.Name = "dtgv_2"
        Me.dtgv_2.RowHeadersVisible = False
        Me.dtgv_2.Size = New System.Drawing.Size(839, 246)
        Me.dtgv_2.TabIndex = 306
        Me.dtgv_2.Visible = False
        '
        'c_1
        '
        Me.c_1.HeaderText = "Codigo"
        Me.c_1.Name = "c_1"
        Me.c_1.Visible = False
        Me.c_1.Width = 65
        '
        'N_2
        '
        Me.N_2.HeaderText = "Nombre"
        Me.N_2.Name = "N_2"
        Me.N_2.ReadOnly = True
        Me.N_2.Width = 69
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 74
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 62
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Width = 81
        '
        'area
        '
        Me.area.HeaderText = "area"
        Me.area.Name = "area"
        Me.area.Visible = False
        Me.area.Width = 53
        '
        'fecha
        '
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.Width = 59
        '
        'comentario
        '
        Me.comentario.HeaderText = "comentario"
        Me.comentario.Name = "comentario"
        Me.comentario.Visible = False
        Me.comentario.Width = 84
        '
        'Quitar
        '
        Me.Quitar.HeaderText = "Quitar"
        Me.Quitar.Name = "Quitar"
        Me.Quitar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Quitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Quitar.Text = "Quitar"
        Me.Quitar.ToolTipText = "Quitar"
        Me.Quitar.UseColumnTextForButtonValue = True
        Me.Quitar.Width = 60
        '
        'btn_selec
        '
        Me.btn_selec.ForeColor = System.Drawing.Color.Black
        Me.btn_selec.Location = New System.Drawing.Point(857, 609)
        Me.btn_selec.Name = "btn_selec"
        Me.btn_selec.Size = New System.Drawing.Size(114, 63)
        Me.btn_selec.TabIndex = 328
        Me.btn_selec.Text = "Cerrar Requerimiento"
        Me.btn_selec.UseVisualStyleBackColor = False
        Me.btn_selec.Visible = False
        '
        'btn_doc
        '
        Me.btn_doc.ForeColor = System.Drawing.Color.Black
        Me.btn_doc.Image = Global.Presentacion.My.Resources.Resources.report
        Me.btn_doc.Location = New System.Drawing.Point(857, 550)
        Me.btn_doc.Name = "btn_doc"
        Me.btn_doc.Size = New System.Drawing.Size(114, 55)
        Me.btn_doc.TabIndex = 327
        Me.btn_doc.Text = "Carga Documento"
        Me.btn_doc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_doc.UseVisualStyleBackColor = False
        Me.btn_doc.Visible = False
        '
        'txt_comentarios
        '
        Me.txt_comentarios.BackColor = System.Drawing.SystemColors.Control
        Me.txt_comentarios.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_comentarios.Location = New System.Drawing.Point(857, 444)
        Me.txt_comentarios.MaxLength = 99
        Me.txt_comentarios.Multiline = True
        Me.txt_comentarios.Name = "txt_comentarios"
        Me.txt_comentarios.Size = New System.Drawing.Size(115, 100)
        Me.txt_comentarios.TabIndex = 329
        Me.txt_comentarios.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(874, 428)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 425
        Me.Label12.Text = "Comentarios"
        Me.Label12.Visible = False
        '
        'Requerimientos_crear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 680)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_comentarios)
        Me.Controls.Add(Me.btn_selec)
        Me.Controls.Add(Me.dtgv_2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbx_tipo)
        Me.Controls.Add(Me.lbl_txtfiltro)
        Me.Controls.Add(Me.txt_código)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.btn_doc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Requerimientos_crear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Requerimiento"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_tipo.ResumeLayout(False)
        Me.gbx_tipo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgv_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents gbx_tipo As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents rbt_retardo As RadioButton
    Friend WithEvents rbt_falta As RadioButton
    Friend WithEvents lbl_txtfiltro As Label
    Friend WithEvents txt_código As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_producto As Label
    Friend WithEvents txt_proveedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_umed_com As Label
    Friend WithEvents lbl_umed_con As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Lbl_numpart As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_doc As Button
    Friend WithEvents lbl_familia As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbx_area As ComboBox
    Friend WithEvents txt_descr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents dtgv_2 As DataGridView
    Friend WithEvents btn_selec As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents txt_liga As TextBox
    Friend WithEvents c_1 As DataGridViewTextBoxColumn
    Friend WithEvents N_2 As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents area As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents comentario As DataGridViewTextBoxColumn
    Friend WithEvents Quitar As DataGridViewButtonColumn
    Friend WithEvents txt_comentarios As TextBox
    Friend WithEvents Label12 As Label
End Class
