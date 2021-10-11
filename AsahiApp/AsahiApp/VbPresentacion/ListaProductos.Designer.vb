<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaProductos))
        Me.lbl_txtfiltro = New System.Windows.Forms.Label()
        Me.txt_código = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbx_tipo = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rbt_retardo = New System.Windows.Forms.RadioButton()
        Me.rbt_falta = New System.Windows.Forms.RadioButton()
        Me.lbl_ulsol = New System.Windows.Forms.Label()
        Me.lbl_ulpro = New System.Windows.Forms.Label()
        Me.lbl_ulfec = New System.Windows.Forms.Label()
        Me.lbl_ulpred = New System.Windows.Forms.Label()
        Me.lbl_umed_com = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_cod = New System.Windows.Forms.Label()
        Me.Lbl_numpart = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_umed_con = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_fam = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_almacen = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_inv = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.lbl_nivel = New System.Windows.Forms.Label()
        Me.lbl_anaquel = New System.Windows.Forms.Label()
        Me.lbl_pasillo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbx_tipo.SuspendLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_txtfiltro
        '
        Me.lbl_txtfiltro.AutoSize = True
        Me.lbl_txtfiltro.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_txtfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_txtfiltro.ForeColor = System.Drawing.Color.Black
        Me.lbl_txtfiltro.Location = New System.Drawing.Point(9, 70)
        Me.lbl_txtfiltro.Name = "lbl_txtfiltro"
        Me.lbl_txtfiltro.Size = New System.Drawing.Size(103, 13)
        Me.lbl_txtfiltro.TabIndex = 128
        Me.lbl_txtfiltro.Text = "Código / Nombre"
        '
        'txt_código
        '
        Me.txt_código.BackColor = System.Drawing.SystemColors.Control
        Me.txt_código.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_código.Location = New System.Drawing.Point(8, 87)
        Me.txt_código.Name = "txt_código"
        Me.txt_código.Size = New System.Drawing.Size(429, 20)
        Me.txt_código.TabIndex = 127
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 13)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Unidad de medida (compra)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "Último precio de compra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(258, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Última fecha de compra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 13)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "Último proveedor para compra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(258, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Último solicitante"
        '
        'gbx_tipo
        '
        Me.gbx_tipo.Controls.Add(Me.RadioButton1)
        Me.gbx_tipo.Controls.Add(Me.rbt_retardo)
        Me.gbx_tipo.Controls.Add(Me.rbt_falta)
        Me.gbx_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbx_tipo.Location = New System.Drawing.Point(12, 8)
        Me.gbx_tipo.Name = "gbx_tipo"
        Me.gbx_tipo.Size = New System.Drawing.Size(360, 50)
        Me.gbx_tipo.TabIndex = 177
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
        'lbl_ulsol
        '
        Me.lbl_ulsol.AutoSize = True
        Me.lbl_ulsol.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_ulsol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ulsol.ForeColor = System.Drawing.Color.Black
        Me.lbl_ulsol.Location = New System.Drawing.Point(258, 300)
        Me.lbl_ulsol.Name = "lbl_ulsol"
        Me.lbl_ulsol.Size = New System.Drawing.Size(86, 13)
        Me.lbl_ulsol.TabIndex = 184
        Me.lbl_ulsol.Text = "Último solicitante"
        '
        'lbl_ulpro
        '
        Me.lbl_ulpro.AutoSize = True
        Me.lbl_ulpro.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_ulpro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ulpro.ForeColor = System.Drawing.Color.Black
        Me.lbl_ulpro.Location = New System.Drawing.Point(12, 300)
        Me.lbl_ulpro.Name = "lbl_ulpro"
        Me.lbl_ulpro.Size = New System.Drawing.Size(149, 13)
        Me.lbl_ulpro.TabIndex = 183
        Me.lbl_ulpro.Text = "Último proveedor para compra"
        '
        'lbl_ulfec
        '
        Me.lbl_ulfec.AutoSize = True
        Me.lbl_ulfec.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_ulfec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ulfec.ForeColor = System.Drawing.Color.Black
        Me.lbl_ulfec.Location = New System.Drawing.Point(258, 249)
        Me.lbl_ulfec.Name = "lbl_ulfec"
        Me.lbl_ulfec.Size = New System.Drawing.Size(119, 13)
        Me.lbl_ulfec.TabIndex = 182
        Me.lbl_ulfec.Text = "Última fecha de compra"
        '
        'lbl_ulpred
        '
        Me.lbl_ulpred.AutoSize = True
        Me.lbl_ulpred.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_ulpred.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ulpred.ForeColor = System.Drawing.Color.Black
        Me.lbl_ulpred.Location = New System.Drawing.Point(12, 251)
        Me.lbl_ulpred.Name = "lbl_ulpred"
        Me.lbl_ulpred.Size = New System.Drawing.Size(121, 13)
        Me.lbl_ulpred.TabIndex = 181
        Me.lbl_ulpred.Text = "Último precio de compra"
        '
        'lbl_umed_com
        '
        Me.lbl_umed_com.AutoSize = True
        Me.lbl_umed_com.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_umed_com.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_umed_com.ForeColor = System.Drawing.Color.Black
        Me.lbl_umed_com.Location = New System.Drawing.Point(12, 159)
        Me.lbl_umed_com.Name = "lbl_umed_com"
        Me.lbl_umed_com.Size = New System.Drawing.Size(93, 13)
        Me.lbl_umed_com.TabIndex = 180
        Me.lbl_umed_com.Text = "Unidad de medida"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.ForeColor = System.Drawing.Color.Black
        Me.lbl_nom.Location = New System.Drawing.Point(12, 75)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nom.TabIndex = 179
        Me.lbl_nom.Text = "Nombre"
        '
        'lbl_cod
        '
        Me.lbl_cod.AutoSize = True
        Me.lbl_cod.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cod.ForeColor = System.Drawing.Color.Black
        Me.lbl_cod.Location = New System.Drawing.Point(12, 34)
        Me.lbl_cod.Name = "lbl_cod"
        Me.lbl_cod.Size = New System.Drawing.Size(40, 13)
        Me.lbl_cod.TabIndex = 178
        Me.lbl_cod.Text = "Código"
        '
        'Lbl_numpart
        '
        Me.Lbl_numpart.AutoSize = True
        Me.Lbl_numpart.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_numpart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_numpart.ForeColor = System.Drawing.Color.Black
        Me.Lbl_numpart.Location = New System.Drawing.Point(12, 115)
        Me.Lbl_numpart.Name = "Lbl_numpart"
        Me.Lbl_numpart.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_numpart.TabIndex = 186
        Me.Lbl_numpart.Text = "Número de parte"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 185
        Me.Label9.Text = "Número de parte"
        '
        'lbl_umed_con
        '
        Me.lbl_umed_con.AutoSize = True
        Me.lbl_umed_con.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_umed_con.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_umed_con.ForeColor = System.Drawing.Color.Black
        Me.lbl_umed_con.Location = New System.Drawing.Point(258, 159)
        Me.lbl_umed_con.Name = "lbl_umed_con"
        Me.lbl_umed_con.Size = New System.Drawing.Size(93, 13)
        Me.lbl_umed_con.TabIndex = 188
        Me.lbl_umed_con.Text = "Unidad de medida"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(258, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 13)
        Me.Label10.TabIndex = 187
        Me.Label10.Text = "Unidad de medida (consumo)"
        '
        'lbl_fam
        '
        Me.lbl_fam.AutoSize = True
        Me.lbl_fam.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_fam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fam.ForeColor = System.Drawing.Color.Black
        Me.lbl_fam.Location = New System.Drawing.Point(12, 203)
        Me.lbl_fam.Name = "lbl_fam"
        Me.lbl_fam.Size = New System.Drawing.Size(39, 13)
        Me.lbl_fam.TabIndex = 190
        Me.lbl_fam.Text = "Familia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 189
        Me.Label11.Text = "Familia"
        '
        'lbl_almacen
        '
        Me.lbl_almacen.AutoSize = True
        Me.lbl_almacen.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_almacen.ForeColor = System.Drawing.Color.Black
        Me.lbl_almacen.Location = New System.Drawing.Point(14, 351)
        Me.lbl_almacen.Name = "lbl_almacen"
        Me.lbl_almacen.Size = New System.Drawing.Size(48, 13)
        Me.lbl_almacen.TabIndex = 192
        Me.lbl_almacen.Text = "Almacén"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(12, 330)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 191
        Me.Label12.Text = "Ubicación"
        '
        'lbl_inv
        '
        Me.lbl_inv.AutoSize = True
        Me.lbl_inv.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inv.ForeColor = System.Drawing.Color.Black
        Me.lbl_inv.Location = New System.Drawing.Point(258, 203)
        Me.lbl_inv.Name = "lbl_inv"
        Me.lbl_inv.Size = New System.Drawing.Size(54, 13)
        Me.lbl_inv.TabIndex = 194
        Me.lbl_inv.Text = "Inventario"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(258, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 13)
        Me.Label13.TabIndex = 193
        Me.Label13.Text = "Es artículo de inventario"
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
        Me.dtgvp.Location = New System.Drawing.Point(8, 123)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(532, 405)
        Me.dtgvp.TabIndex = 259
        '
        'lbl_nivel
        '
        Me.lbl_nivel.AutoSize = True
        Me.lbl_nivel.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_nivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nivel.ForeColor = System.Drawing.Color.Black
        Me.lbl_nivel.Location = New System.Drawing.Point(15, 441)
        Me.lbl_nivel.Name = "lbl_nivel"
        Me.lbl_nivel.Size = New System.Drawing.Size(31, 13)
        Me.lbl_nivel.TabIndex = 260
        Me.lbl_nivel.Text = "Nivel"
        '
        'lbl_anaquel
        '
        Me.lbl_anaquel.AutoSize = True
        Me.lbl_anaquel.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_anaquel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_anaquel.ForeColor = System.Drawing.Color.Black
        Me.lbl_anaquel.Location = New System.Drawing.Point(15, 411)
        Me.lbl_anaquel.Name = "lbl_anaquel"
        Me.lbl_anaquel.Size = New System.Drawing.Size(46, 13)
        Me.lbl_anaquel.TabIndex = 262
        Me.lbl_anaquel.Text = "Anaquel"
        '
        'lbl_pasillo
        '
        Me.lbl_pasillo.AutoSize = True
        Me.lbl_pasillo.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_pasillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pasillo.ForeColor = System.Drawing.Color.Black
        Me.lbl_pasillo.Location = New System.Drawing.Point(15, 379)
        Me.lbl_pasillo.Name = "lbl_pasillo"
        Me.lbl_pasillo.Size = New System.Drawing.Size(37, 13)
        Me.lbl_pasillo.TabIndex = 261
        Me.lbl_pasillo.Text = "Pasillo"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_anaquel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_pasillo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbl_nivel)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbl_inv)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lbl_almacen)
        Me.Panel1.Controls.Add(Me.lbl_cod)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lbl_nom)
        Me.Panel1.Controls.Add(Me.lbl_fam)
        Me.Panel1.Controls.Add(Me.lbl_umed_com)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lbl_ulpred)
        Me.Panel1.Controls.Add(Me.lbl_umed_con)
        Me.Panel1.Controls.Add(Me.lbl_ulfec)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lbl_ulpro)
        Me.Panel1.Controls.Add(Me.Lbl_numpart)
        Me.Panel1.Controls.Add(Me.lbl_ulsol)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(557, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 520)
        Me.Panel1.TabIndex = 263
        '
        'ListaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 540)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.gbx_tipo)
        Me.Controls.Add(Me.lbl_txtfiltro)
        Me.Controls.Add(Me.txt_código)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ListaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Productos"
        Me.gbx_tipo.ResumeLayout(False)
        Me.gbx_tipo.PerformLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_txtfiltro As Label
    Friend WithEvents txt_código As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gbx_tipo As GroupBox
    Friend WithEvents rbt_retardo As RadioButton
    Friend WithEvents rbt_falta As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lbl_ulsol As Label
    Friend WithEvents lbl_ulpro As Label
    Friend WithEvents lbl_ulfec As Label
    Friend WithEvents lbl_ulpred As Label
    Friend WithEvents lbl_umed_com As Label
    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_cod As Label
    Friend WithEvents Lbl_numpart As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_umed_con As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_fam As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_almacen As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_inv As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents lbl_nivel As Label
    Friend WithEvents lbl_anaquel As Label
    Friend WithEvents lbl_pasillo As Label
    Friend WithEvents Panel1 As Panel
End Class
