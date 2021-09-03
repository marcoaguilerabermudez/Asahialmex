<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cambiodeturno
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cambiodeturno))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_cambiarturno = New System.Windows.Forms.Button()
        Me.btn_desma = New System.Windows.Forms.Button()
        Me.btn_selec = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_turno = New System.Windows.Forms.ComboBox()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.x = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtgv_2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cambiain = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_puesto = New System.Windows.Forms.Label()
        Me.cbx_indi = New System.Windows.Forms.ComboBox()
        Me.lbl_dpto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbx_filtro = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgv_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1087, 669)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cbx_filtro)
        Me.TabPage1.Controls.Add(Me.btn_cambiarturno)
        Me.TabPage1.Controls.Add(Me.btn_desma)
        Me.TabPage1.Controls.Add(Me.btn_selec)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.cbx_turno)
        Me.TabPage1.Controls.Add(Me.dtp1)
        Me.TabPage1.Controls.Add(Me.dtgvp)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1079, 643)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Departamento Completo"
        '
        'btn_cambiarturno
        '
        Me.btn_cambiarturno.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cambiarturno.Enabled = False
        Me.btn_cambiarturno.ForeColor = System.Drawing.Color.DarkGreen
        Me.btn_cambiarturno.Location = New System.Drawing.Point(882, 19)
        Me.btn_cambiarturno.Name = "btn_cambiarturno"
        Me.btn_cambiarturno.Size = New System.Drawing.Size(100, 35)
        Me.btn_cambiarturno.TabIndex = 167
        Me.btn_cambiarturno.Text = "Cambiar Turno"
        Me.btn_cambiarturno.UseVisualStyleBackColor = False
        '
        'btn_desma
        '
        Me.btn_desma.BackColor = System.Drawing.SystemColors.Control
        Me.btn_desma.ForeColor = System.Drawing.Color.Black
        Me.btn_desma.Location = New System.Drawing.Point(752, 18)
        Me.btn_desma.Name = "btn_desma"
        Me.btn_desma.Size = New System.Drawing.Size(78, 35)
        Me.btn_desma.TabIndex = 166
        Me.btn_desma.Text = "Desmarcar"
        Me.btn_desma.UseVisualStyleBackColor = False
        '
        'btn_selec
        '
        Me.btn_selec.BackColor = System.Drawing.SystemColors.Control
        Me.btn_selec.ForeColor = System.Drawing.Color.Black
        Me.btn_selec.Location = New System.Drawing.Point(649, 17)
        Me.btn_selec.Name = "btn_selec"
        Me.btn_selec.Size = New System.Drawing.Size(74, 35)
        Me.btn_selec.TabIndex = 165
        Me.btn_selec.Text = "Seleccionar"
        Me.btn_selec.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(469, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Nuevo Turno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(283, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "Aplica a partir de"
        '
        'cbx_turno
        '
        Me.cbx_turno.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbx_turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_turno.ForeColor = System.Drawing.SystemColors.Menu
        Me.cbx_turno.FormattingEnabled = True
        Me.cbx_turno.Items.AddRange(New Object() {"Matutino", "Vespertino", "Nocturno", "Administrativo"})
        Me.cbx_turno.Location = New System.Drawing.Point(435, 33)
        Me.cbx_turno.Name = "cbx_turno"
        Me.cbx_turno.Size = New System.Drawing.Size(142, 21)
        Me.cbx_turno.TabIndex = 162
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(277, 32)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 161
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToOrderColumns = True
        Me.dtgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.x})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvp.Location = New System.Drawing.Point(6, 76)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(1067, 552)
        Me.dtgvp.TabIndex = 160
        '
        'x
        '
        Me.x.HeaderText = "x"
        Me.x.Name = "x"
        Me.x.Width = 18
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.dtgv_2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1079, 643)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Individual"
        '
        'dtgv_2
        '
        Me.dtgv_2.AllowUserToAddRows = False
        Me.dtgv_2.AllowUserToDeleteRows = False
        Me.dtgv_2.AllowUserToOrderColumns = True
        Me.dtgv_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgv_2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgv_2.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv_2.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv_2.Location = New System.Drawing.Point(429, 23)
        Me.dtgv_2.Name = "dtgv_2"
        Me.dtgv_2.ReadOnly = True
        Me.dtgv_2.RowHeadersVisible = False
        Me.dtgv_2.Size = New System.Drawing.Size(454, 568)
        Me.dtgv_2.TabIndex = 195
        Me.dtgv_2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cambiain)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtp_1)
        Me.GroupBox1.Controls.Add(Me.txt_clave)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_puesto)
        Me.GroupBox1.Controls.Add(Me.cbx_indi)
        Me.GroupBox1.Controls.Add(Me.lbl_dpto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_clave)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 447)
        Me.GroupBox1.TabIndex = 194
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambio de turno individual"
        '
        'btn_cambiain
        '
        Me.btn_cambiain.BackColor = System.Drawing.SystemColors.Control
        Me.btn_cambiain.Enabled = False
        Me.btn_cambiain.ForeColor = System.Drawing.Color.DarkGreen
        Me.btn_cambiain.Location = New System.Drawing.Point(113, 315)
        Me.btn_cambiain.Name = "btn_cambiain"
        Me.btn_cambiain.Size = New System.Drawing.Size(100, 35)
        Me.btn_cambiain.TabIndex = 194
        Me.btn_cambiain.Text = "Cambiar Turno"
        Me.btn_cambiain.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "Clave"
        '
        'dtp_1
        '
        Me.dtp_1.Enabled = False
        Me.dtp_1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_1.Location = New System.Drawing.Point(20, 216)
        Me.dtp_1.Name = "dtp_1"
        Me.dtp_1.Size = New System.Drawing.Size(100, 20)
        Me.dtp_1.TabIndex = 164
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(45, 24)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(92, 20)
        Me.txt_clave.TabIndex = 192
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Aplica a partir de"
        '
        'lbl_puesto
        '
        Me.lbl_puesto.AutoSize = True
        Me.lbl_puesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_puesto.ForeColor = System.Drawing.Color.Black
        Me.lbl_puesto.Location = New System.Drawing.Point(6, 119)
        Me.lbl_puesto.Name = "lbl_puesto"
        Me.lbl_puesto.Size = New System.Drawing.Size(56, 16)
        Me.lbl_puesto.TabIndex = 189
        Me.lbl_puesto.Text = "Puesto"
        '
        'cbx_indi
        '
        Me.cbx_indi.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbx_indi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_indi.Enabled = False
        Me.cbx_indi.ForeColor = System.Drawing.SystemColors.Menu
        Me.cbx_indi.FormattingEnabled = True
        Me.cbx_indi.Items.AddRange(New Object() {"Matutino", "Vespertino", "Nocturno", "Administrativo"})
        Me.cbx_indi.Location = New System.Drawing.Point(174, 214)
        Me.cbx_indi.Name = "cbx_indi"
        Me.cbx_indi.Size = New System.Drawing.Size(142, 21)
        Me.cbx_indi.TabIndex = 166
        '
        'lbl_dpto
        '
        Me.lbl_dpto.AutoSize = True
        Me.lbl_dpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dpto.ForeColor = System.Drawing.Color.Black
        Me.lbl_dpto.Location = New System.Drawing.Point(6, 97)
        Me.lbl_dpto.Name = "lbl_dpto"
        Me.lbl_dpto.Size = New System.Drawing.Size(106, 16)
        Me.lbl_dpto.TabIndex = 188
        Me.lbl_dpto.Text = "Departamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(208, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Nuevo Turno"
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clave.ForeColor = System.Drawing.Color.Black
        Me.lbl_clave.Location = New System.Drawing.Point(6, 78)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(48, 16)
        Me.lbl_clave.TabIndex = 187
        Me.lbl_clave.Text = "Clave"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_nombre.Location = New System.Drawing.Point(6, 58)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(63, 16)
        Me.lbl_nombre.TabIndex = 186
        Me.lbl_nombre.Text = "Nombre"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(51, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 169
        Me.Label6.Text = "Filtrar Turno"
        '
        'cbx_filtro
        '
        Me.cbx_filtro.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbx_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_filtro.ForeColor = System.Drawing.SystemColors.Menu
        Me.cbx_filtro.FormattingEnabled = True
        Me.cbx_filtro.Items.AddRange(New Object() {"Matutino", "Vespertino", "Nocturno", "Administrativo"})
        Me.cbx_filtro.Location = New System.Drawing.Point(17, 32)
        Me.cbx_filtro.Name = "cbx_filtro"
        Me.cbx_filtro.Size = New System.Drawing.Size(142, 21)
        Me.cbx_filtro.TabIndex = 168
        '
        'Frm_cambiodeturno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 677)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_cambiodeturno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Turno"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtgv_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents x As DataGridViewCheckBoxColumn
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents cbx_turno As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_desma As Button
    Friend WithEvents btn_selec As Button
    Friend WithEvents btn_cambiarturno As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbx_indi As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_1 As DateTimePicker
    Friend WithEvents lbl_puesto As Label
    Friend WithEvents lbl_dpto As Label
    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cambiain As Button
    Friend WithEvents dtgv_2 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents cbx_filtro As ComboBox
End Class
