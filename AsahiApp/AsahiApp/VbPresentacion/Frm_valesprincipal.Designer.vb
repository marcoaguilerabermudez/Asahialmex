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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_valesprincipal))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_selec = New System.Windows.Forms.Button()
        Me.dtgv_2 = New System.Windows.Forms.DataGridView()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.c_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_cobro = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Quitar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtgv_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(1, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(875, 57)
        Me.Panel3.TabIndex = 181
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_usuario)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(471, 3)
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
        Me.GroupBox3.Controls.Add(Me.btn_selec)
        Me.GroupBox3.Controls.Add(Me.dtgv_2)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 402)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(855, 278)
        Me.GroupBox3.TabIndex = 184
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cantidades"
        '
        'btn_selec
        '
        Me.btn_selec.ForeColor = System.Drawing.Color.Black
        Me.btn_selec.Location = New System.Drawing.Point(775, 139)
        Me.btn_selec.Name = "btn_selec"
        Me.btn_selec.Size = New System.Drawing.Size(74, 35)
        Me.btn_selec.TabIndex = 194
        Me.btn_selec.Text = "Terminar Vale"
        Me.btn_selec.UseVisualStyleBackColor = False
        Me.btn_selec.Visible = False
        '
        'dtgv_2
        '
        Me.dtgv_2.AllowUserToAddRows = False
        Me.dtgv_2.AllowUserToDeleteRows = False
        Me.dtgv_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgv_2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgv_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgv_2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_1, Me.N_2, Me.C_3, Me.c_cobro, Me.Quitar})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv_2.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgv_2.Location = New System.Drawing.Point(7, 23)
        Me.dtgv_2.Name = "dtgv_2"
        Me.dtgv_2.RowHeadersVisible = False
        Me.dtgv_2.Size = New System.Drawing.Size(746, 246)
        Me.dtgv_2.TabIndex = 182
        '
        'pbx
        '
        Me.pbx.ErrorImage = CType(resources.GetObject("pbx.ErrorImage"), System.Drawing.Image)
        Me.pbx.Location = New System.Drawing.Point(731, 153)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(132, 138)
        Me.pbx.TabIndex = 195
        Me.pbx.TabStop = False
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.txt_nombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_nombre.Location = New System.Drawing.Point(71, 76)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(281, 20)
        Me.txt_nombre.TabIndex = 196
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dtgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.Format = "0.00"
        DataGridViewCellStyle8.NullValue = Nothing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle8
        Me.dtgvp.Location = New System.Drawing.Point(8, 108)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(707, 264)
        Me.dtgvp.TabIndex = 258
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
        Me.N_2.Width = 69
        '
        'C_3
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.C_3.DefaultCellStyle = DataGridViewCellStyle5
        Me.C_3.HeaderText = "Cantidad"
        Me.C_3.Name = "C_3"
        Me.C_3.Width = 74
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
        'Frm_valesprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 692)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.pbx)
        Me.Controls.Add(Me.txt_nombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Frm_valesprincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elaboración de Vales"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtgv_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtgv_2 As DataGridView
    Friend WithEvents btn_selec As Button
    Friend WithEvents pbx As PictureBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents c_1 As DataGridViewTextBoxColumn
    Friend WithEvents N_2 As DataGridViewTextBoxColumn
    Friend WithEvents C_3 As DataGridViewTextBoxColumn
    Friend WithEvents c_cobro As DataGridViewComboBoxColumn
    Friend WithEvents Quitar As DataGridViewButtonColumn
End Class
