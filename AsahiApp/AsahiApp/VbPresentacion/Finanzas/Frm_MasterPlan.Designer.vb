<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MasterPlan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_Año = New System.Windows.Forms.Label()
        Me.Cmb_Años = New System.Windows.Forms.ComboBox()
        Me.Lbl_Depto = New System.Windows.Forms.Label()
        Me.Lbl_Mes = New System.Windows.Forms.Label()
        Me.Cmb_Depto = New System.Windows.Forms.ComboBox()
        Me.Cmb_Meses = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Rdb_Español = New System.Windows.Forms.RadioButton()
        Me.Rdb_Japones = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Lbl_Año)
        Me.Panel1.Controls.Add(Me.Cmb_Años)
        Me.Panel1.Controls.Add(Me.Lbl_Depto)
        Me.Panel1.Controls.Add(Me.Lbl_Mes)
        Me.Panel1.Controls.Add(Me.Cmb_Depto)
        Me.Panel1.Controls.Add(Me.Cmb_Meses)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 54)
        Me.Panel1.TabIndex = 0
        '
        'Lbl_Año
        '
        Me.Lbl_Año.AutoSize = True
        Me.Lbl_Año.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Año.Location = New System.Drawing.Point(155, 5)
        Me.Lbl_Año.Name = "Lbl_Año"
        Me.Lbl_Año.Size = New System.Drawing.Size(26, 13)
        Me.Lbl_Año.TabIndex = 5
        Me.Lbl_Año.Text = "Año"
        '
        'Cmb_Años
        '
        Me.Cmb_Años.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Años.FormattingEnabled = True
        Me.Cmb_Años.Location = New System.Drawing.Point(155, 23)
        Me.Cmb_Años.Name = "Cmb_Años"
        Me.Cmb_Años.Size = New System.Drawing.Size(112, 21)
        Me.Cmb_Años.TabIndex = 4
        '
        'Lbl_Depto
        '
        Me.Lbl_Depto.AutoSize = True
        Me.Lbl_Depto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Depto.Location = New System.Drawing.Point(292, 5)
        Me.Lbl_Depto.Name = "Lbl_Depto"
        Me.Lbl_Depto.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Depto.TabIndex = 3
        Me.Lbl_Depto.Text = "Departamento"
        '
        'Lbl_Mes
        '
        Me.Lbl_Mes.AutoSize = True
        Me.Lbl_Mes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Mes.Location = New System.Drawing.Point(19, 5)
        Me.Lbl_Mes.Name = "Lbl_Mes"
        Me.Lbl_Mes.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_Mes.TabIndex = 2
        Me.Lbl_Mes.Text = "Mes"
        '
        'Cmb_Depto
        '
        Me.Cmb_Depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Depto.FormattingEnabled = True
        Me.Cmb_Depto.Location = New System.Drawing.Point(295, 23)
        Me.Cmb_Depto.Name = "Cmb_Depto"
        Me.Cmb_Depto.Size = New System.Drawing.Size(170, 21)
        Me.Cmb_Depto.TabIndex = 1
        '
        'Cmb_Meses
        '
        Me.Cmb_Meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Meses.FormattingEnabled = True
        Me.Cmb_Meses.Location = New System.Drawing.Point(19, 23)
        Me.Cmb_Meses.Name = "Cmb_Meses"
        Me.Cmb_Meses.Size = New System.Drawing.Size(112, 21)
        Me.Cmb_Meses.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1256, 455)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1256, 429)
        Me.Panel4.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1256, 419)
        Me.Panel6.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 419)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1256, 10)
        Me.Panel5.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1256, 26)
        Me.Panel3.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.DataGridView1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(615, 419)
        Me.Panel7.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.DataGridView2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(641, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(615, 419)
        Me.Panel8.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(615, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(26, 419)
        Me.Panel9.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(615, 419)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(615, 419)
        Me.DataGridView2.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Rdb_Japones)
        Me.Panel10.Controls.Add(Me.Rdb_Español)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(1121, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(135, 54)
        Me.Panel10.TabIndex = 6
        '
        'Rdb_Español
        '
        Me.Rdb_Español.AutoSize = True
        Me.Rdb_Español.ForeColor = System.Drawing.Color.White
        Me.Rdb_Español.Location = New System.Drawing.Point(20, 5)
        Me.Rdb_Español.Name = "Rdb_Español"
        Me.Rdb_Español.Size = New System.Drawing.Size(63, 17)
        Me.Rdb_Español.TabIndex = 0
        Me.Rdb_Español.TabStop = True
        Me.Rdb_Español.Text = "Español"
        Me.Rdb_Español.UseVisualStyleBackColor = True
        '
        'Rdb_Japones
        '
        Me.Rdb_Japones.AutoSize = True
        Me.Rdb_Japones.ForeColor = System.Drawing.Color.White
        Me.Rdb_Japones.Location = New System.Drawing.Point(20, 28)
        Me.Rdb_Japones.Name = "Rdb_Japones"
        Me.Rdb_Japones.Size = New System.Drawing.Size(61, 17)
        Me.Rdb_Japones.TabIndex = 1
        Me.Rdb_Japones.TabStop = True
        Me.Rdb_Japones.Text = "日本語"
        Me.Rdb_Japones.UseVisualStyleBackColor = True
        '
        'Frm_MasterPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 509)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_MasterPlan"
        Me.ShowIcon = False
        Me.Text = "Master Plan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lbl_Depto As Label
    Friend WithEvents Lbl_Mes As Label
    Friend WithEvents Cmb_Depto As ComboBox
    Friend WithEvents Cmb_Meses As ComboBox
    Friend WithEvents Lbl_Año As Label
    Friend WithEvents Cmb_Años As ComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Rdb_Japones As RadioButton
    Friend WithEvents Rdb_Español As RadioButton
End Class
