<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PlanGastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PlanGastos))
        Me.Pnl_Menu = New System.Windows.Forms.Panel()
        Me.Cmb_Depto = New System.Windows.Forms.ComboBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Rdb_Japones = New System.Windows.Forms.RadioButton()
        Me.Rdb_Español = New System.Windows.Forms.RadioButton()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Lbl_Año = New System.Windows.Forms.Label()
        Me.Cmb_Años = New System.Windows.Forms.ComboBox()
        Me.Lbl_Depto = New System.Windows.Forms.Label()
        Me.Lbl_Mes = New System.Windows.Forms.Label()
        Me.Cmb_Meses = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dgv_Principal = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Dgv_Datos = New System.Windows.Forms.DataGridView()
        Me.codigo2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.planActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nuevoPlan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modificados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Pnl_Menu.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dgv_Principal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Dgv_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl_Menu
        '
        Me.Pnl_Menu.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_Menu.Controls.Add(Me.Cmb_Depto)
        Me.Pnl_Menu.Controls.Add(Me.Panel10)
        Me.Pnl_Menu.Controls.Add(Me.Btn_Guardar)
        Me.Pnl_Menu.Controls.Add(Me.Lbl_Año)
        Me.Pnl_Menu.Controls.Add(Me.Cmb_Años)
        Me.Pnl_Menu.Controls.Add(Me.Lbl_Depto)
        Me.Pnl_Menu.Controls.Add(Me.Lbl_Mes)
        Me.Pnl_Menu.Controls.Add(Me.Cmb_Meses)
        Me.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Menu.Name = "Pnl_Menu"
        Me.Pnl_Menu.Size = New System.Drawing.Size(1072, 54)
        Me.Pnl_Menu.TabIndex = 0
        '
        'Cmb_Depto
        '
        Me.Cmb_Depto.BackColor = System.Drawing.SystemColors.Window
        Me.Cmb_Depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Depto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Depto.FormattingEnabled = True
        Me.Cmb_Depto.Location = New System.Drawing.Point(6, 26)
        Me.Cmb_Depto.Name = "Cmb_Depto"
        Me.Cmb_Depto.Size = New System.Drawing.Size(182, 21)
        Me.Cmb_Depto.TabIndex = 16
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Rdb_Japones)
        Me.Panel10.Controls.Add(Me.Rdb_Español)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(937, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(135, 54)
        Me.Panel10.TabIndex = 15
        '
        'Rdb_Japones
        '
        Me.Rdb_Japones.AutoSize = True
        Me.Rdb_Japones.ForeColor = System.Drawing.Color.White
        Me.Rdb_Japones.Location = New System.Drawing.Point(20, 27)
        Me.Rdb_Japones.Name = "Rdb_Japones"
        Me.Rdb_Japones.Size = New System.Drawing.Size(61, 17)
        Me.Rdb_Japones.TabIndex = 1
        Me.Rdb_Japones.TabStop = True
        Me.Rdb_Japones.Text = "日本語"
        Me.Rdb_Japones.UseVisualStyleBackColor = True
        '
        'Rdb_Español
        '
        Me.Rdb_Español.AutoSize = True
        Me.Rdb_Español.ForeColor = System.Drawing.Color.White
        Me.Rdb_Español.Location = New System.Drawing.Point(20, 4)
        Me.Rdb_Español.Name = "Rdb_Español"
        Me.Rdb_Español.Size = New System.Drawing.Size(63, 17)
        Me.Rdb_Español.TabIndex = 0
        Me.Rdb_Español.TabStop = True
        Me.Rdb_Español.Text = "Español"
        Me.Rdb_Español.UseVisualStyleBackColor = True
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.Btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guardar.Image = Global.Presentacion.My.Resources.Resources.save
        Me.Btn_Guardar.Location = New System.Drawing.Point(449, 14)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(30, 30)
        Me.Btn_Guardar.TabIndex = 14
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Lbl_Año
        '
        Me.Lbl_Año.AutoSize = True
        Me.Lbl_Año.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Año.Location = New System.Drawing.Point(343, 9)
        Me.Lbl_Año.Name = "Lbl_Año"
        Me.Lbl_Año.Size = New System.Drawing.Size(26, 13)
        Me.Lbl_Año.TabIndex = 11
        Me.Lbl_Año.Text = "Año"
        '
        'Cmb_Años
        '
        Me.Cmb_Años.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Años.FormattingEnabled = True
        Me.Cmb_Años.Location = New System.Drawing.Point(343, 27)
        Me.Cmb_Años.Name = "Cmb_Años"
        Me.Cmb_Años.Size = New System.Drawing.Size(82, 21)
        Me.Cmb_Años.TabIndex = 10
        '
        'Lbl_Depto
        '
        Me.Lbl_Depto.AutoSize = True
        Me.Lbl_Depto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Depto.Location = New System.Drawing.Point(3, 8)
        Me.Lbl_Depto.Name = "Lbl_Depto"
        Me.Lbl_Depto.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Depto.TabIndex = 9
        Me.Lbl_Depto.Text = "Departamento"
        '
        'Lbl_Mes
        '
        Me.Lbl_Mes.AutoSize = True
        Me.Lbl_Mes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Mes.Location = New System.Drawing.Point(207, 9)
        Me.Lbl_Mes.Name = "Lbl_Mes"
        Me.Lbl_Mes.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_Mes.TabIndex = 8
        Me.Lbl_Mes.Text = "Mes"
        '
        'Cmb_Meses
        '
        Me.Cmb_Meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Meses.FormattingEnabled = True
        Me.Cmb_Meses.Location = New System.Drawing.Point(207, 27)
        Me.Cmb_Meses.Name = "Cmb_Meses"
        Me.Cmb_Meses.Size = New System.Drawing.Size(112, 21)
        Me.Cmb_Meses.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 54)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1072, 39)
        Me.Panel4.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(660, 39)
        Me.Panel6.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Presentacion.My.Resources.Resources._1492533500_arrow_41_83313
        Me.Button1.Location = New System.Drawing.Point(603, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1072, 436)
        Me.Panel1.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(453, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(85, 413)
        Me.Panel5.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Dgv_Principal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(453, 413)
        Me.Panel2.TabIndex = 9
        '
        'Dgv_Principal
        '
        Me.Dgv_Principal.AllowUserToAddRows = False
        Me.Dgv_Principal.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.Dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Principal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombre, Me.acum})
        Me.Dgv_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Principal.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_Principal.Name = "Dgv_Principal"
        Me.Dgv_Principal.RowHeadersVisible = False
        Me.Dgv_Principal.Size = New System.Drawing.Size(453, 413)
        Me.Dgv_Principal.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 75
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 250
        '
        'acum
        '
        Me.acum.HeaderText = "Acumulado"
        Me.acum.Name = "acum"
        Me.acum.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Dgv_Datos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(538, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(534, 413)
        Me.Panel3.TabIndex = 8
        '
        'Dgv_Datos
        '
        Me.Dgv_Datos.AllowUserToAddRows = False
        Me.Dgv_Datos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.Dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo2, Me.cuenta, Me.planActual, Me.nuevoPlan, Me.modificados})
        Me.Dgv_Datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Datos.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_Datos.Name = "Dgv_Datos"
        Me.Dgv_Datos.RowHeadersVisible = False
        Me.Dgv_Datos.Size = New System.Drawing.Size(534, 413)
        Me.Dgv_Datos.TabIndex = 0
        '
        'codigo2
        '
        Me.codigo2.HeaderText = "Código"
        Me.codigo2.Name = "codigo2"
        Me.codigo2.ReadOnly = True
        Me.codigo2.Width = 70
        '
        'cuenta
        '
        Me.cuenta.HeaderText = "Cuenta"
        Me.cuenta.Name = "cuenta"
        Me.cuenta.ReadOnly = True
        Me.cuenta.Width = 260
        '
        'planActual
        '
        Me.planActual.HeaderText = "Plan Actual"
        Me.planActual.Name = "planActual"
        Me.planActual.ReadOnly = True
        Me.planActual.Width = 90
        '
        'nuevoPlan
        '
        Me.nuevoPlan.HeaderText = "Nuevo Plan"
        Me.nuevoPlan.Name = "nuevoPlan"
        Me.nuevoPlan.Width = 90
        '
        'modificados
        '
        Me.modificados.HeaderText = "Modificados"
        Me.modificados.Name = "modificados"
        Me.modificados.ReadOnly = True
        Me.modificados.Visible = False
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 413)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1072, 23)
        Me.Panel7.TabIndex = 0
        '
        'Frm_PlanGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1072, 529)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Pnl_Menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_PlanGastos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan Gastos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Pnl_Menu.ResumeLayout(False)
        Me.Pnl_Menu.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Dgv_Principal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Dgv_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_Menu As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Lbl_Año As Label
    Friend WithEvents Cmb_Años As ComboBox
    Friend WithEvents Lbl_Depto As Label
    Friend WithEvents Lbl_Mes As Label
    Friend WithEvents Cmb_Meses As ComboBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Rdb_Japones As RadioButton
    Friend WithEvents Rdb_Español As RadioButton
    Friend WithEvents Cmb_Depto As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dgv_Principal As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents acum As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Dgv_Datos As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents codigo2 As DataGridViewTextBoxColumn
    Friend WithEvents cuenta As DataGridViewTextBoxColumn
    Friend WithEvents planActual As DataGridViewTextBoxColumn
    Friend WithEvents nuevoPlan As DataGridViewTextBoxColumn
    Friend WithEvents modificados As DataGridViewTextBoxColumn
End Class
