<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_valesprincipal
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_valesprincipal))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtgv_2 = New System.Windows.Forms.DataGridView()
        Me.c_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_cobro = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Quitar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.gbx_terminar = New System.Windows.Forms.GroupBox()
        Me.lbl_persona = New System.Windows.Forms.Label()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.txt_empleado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.btn_selec = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtgv_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_terminar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(1, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1050, 57)
        Me.Panel3.TabIndex = 181
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_usuario)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(642, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 46)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usuario"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lbl_usuario.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lbl_usuario.Location = New System.Drawing.Point(16, 17)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(248, 18)
        Me.lbl_usuario.TabIndex = 6
        Me.lbl_usuario.Text = "Asahi Aluminium México S.A. de C.V."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Elaboración de Vales"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.gbx_terminar)
        Me.GroupBox3.Controls.Add(Me.dtgv_2)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 402)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1034, 278)
        Me.GroupBox3.TabIndex = 184
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cantidades"
        '
        'dtgv_2
        '
        Me.dtgv_2.AllowUserToAddRows = False
        Me.dtgv_2.AllowUserToDeleteRows = False
        Me.dtgv_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgv_2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgv_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgv_2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_1, Me.N_2, Me.C_3, Me.stock, Me.c_cobro, Me.Quitar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv_2.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv_2.Location = New System.Drawing.Point(7, 23)
        Me.dtgv_2.Name = "dtgv_2"
        Me.dtgv_2.RowHeadersVisible = False
        Me.dtgv_2.Size = New System.Drawing.Size(762, 246)
        Me.dtgv_2.TabIndex = 182
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
        'C_3
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.C_3.DefaultCellStyle = DataGridViewCellStyle1
        Me.C_3.HeaderText = "Cantidad"
        Me.C_3.Name = "C_3"
        Me.C_3.Width = 74
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.Visible = False
        Me.stock.Width = 60
        '
        'c_cobro
        '
        Me.c_cobro.HeaderText = "Cobro"
        Me.c_cobro.Items.AddRange(New Object() {"Sí", "No"})
        Me.c_cobro.Name = "c_cobro"
        Me.c_cobro.Width = 41
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
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.txt_nombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_nombre.Location = New System.Drawing.Point(71, 76)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(281, 20)
        Me.txt_nombre.TabIndex = 1
        Me.txt_nombre.Tag = "1"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.SystemColors.Control
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(23, 79)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(44, 13)
        Me.lbl2.TabIndex = 197
        Me.lbl2.Text = "Nombre"
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
        DataGridViewCellStyle4.Format = "0.00"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgvp.Location = New System.Drawing.Point(8, 108)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(740, 264)
        Me.dtgvp.TabIndex = 258
        '
        'pbx
        '
        Me.pbx.ErrorImage = Global.Presentacion.My.Resources.Resources.Logo
        Me.pbx.Location = New System.Drawing.Point(835, 146)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(174, 172)
        Me.pbx.TabIndex = 195
        Me.pbx.TabStop = False
        '
        'gbx_terminar
        '
        Me.gbx_terminar.Controls.Add(Me.lbl_persona)
        Me.gbx_terminar.Controls.Add(Me.lbl_empleado)
        Me.gbx_terminar.Controls.Add(Me.txt_empleado)
        Me.gbx_terminar.Controls.Add(Me.Label5)
        Me.gbx_terminar.Controls.Add(Me.txt_comentario)
        Me.gbx_terminar.Controls.Add(Me.btn_selec)
        Me.gbx_terminar.Location = New System.Drawing.Point(785, 12)
        Me.gbx_terminar.Name = "gbx_terminar"
        Me.gbx_terminar.Size = New System.Drawing.Size(253, 260)
        Me.gbx_terminar.TabIndex = 259
        Me.gbx_terminar.TabStop = False
        Me.gbx_terminar.Text = "Terminar"
        Me.gbx_terminar.Visible = False
        '
        'lbl_persona
        '
        Me.lbl_persona.AutoSize = True
        Me.lbl_persona.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_persona.ForeColor = System.Drawing.Color.Black
        Me.lbl_persona.Location = New System.Drawing.Point(18, 158)
        Me.lbl_persona.Name = "lbl_persona"
        Me.lbl_persona.Size = New System.Drawing.Size(0, 13)
        Me.lbl_persona.TabIndex = 205
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_empleado.ForeColor = System.Drawing.Color.Black
        Me.lbl_empleado.Location = New System.Drawing.Point(18, 112)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(57, 13)
        Me.lbl_empleado.TabIndex = 204
        Me.lbl_empleado.Text = "Supervisor"
        '
        'txt_empleado
        '
        Me.txt_empleado.BackColor = System.Drawing.SystemColors.Control
        Me.txt_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empleado.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_empleado.Location = New System.Drawing.Point(16, 128)
        Me.txt_empleado.Name = "txt_empleado"
        Me.txt_empleado.Size = New System.Drawing.Size(79, 18)
        Me.txt_empleado.TabIndex = 203
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 202
        Me.Label5.Text = "Comentario"
        '
        'txt_comentario
        '
        Me.txt_comentario.BackColor = System.Drawing.SystemColors.Control
        Me.txt_comentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comentario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_comentario.Location = New System.Drawing.Point(9, 35)
        Me.txt_comentario.Multiline = True
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(232, 52)
        Me.txt_comentario.TabIndex = 201
        '
        'btn_selec
        '
        Me.btn_selec.ForeColor = System.Drawing.Color.Black
        Me.btn_selec.Location = New System.Drawing.Point(94, 211)
        Me.btn_selec.Name = "btn_selec"
        Me.btn_selec.Size = New System.Drawing.Size(74, 35)
        Me.btn_selec.TabIndex = 200
        Me.btn_selec.Text = "Terminar Vale"
        Me.btn_selec.UseVisualStyleBackColor = False
        '
        'Frm_valesprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 692)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.pbx)
        Me.Controls.Add(Me.txt_nombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_valesprincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elaboración de Vales"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtgv_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_terminar.ResumeLayout(False)
        Me.gbx_terminar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtgv_2 As DataGridView
    Friend WithEvents pbx As PictureBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents c_1 As DataGridViewTextBoxColumn
    Friend WithEvents N_2 As DataGridViewTextBoxColumn
    Friend WithEvents C_3 As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents c_cobro As DataGridViewComboBoxColumn
    Friend WithEvents Quitar As DataGridViewButtonColumn
    Friend WithEvents gbx_terminar As GroupBox
    Friend WithEvents lbl_persona As Label
    Friend WithEvents lbl_empleado As Label
    Friend WithEvents txt_empleado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_comentario As TextBox
    Friend WithEvents btn_selec As Button
End Class
