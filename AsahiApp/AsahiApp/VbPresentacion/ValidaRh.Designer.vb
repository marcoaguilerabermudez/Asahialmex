<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidaRh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ValidaRh))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_desma = New System.Windows.Forms.Button()
        Me.btn_selec = New System.Windows.Forms.Button()
        Me.cbx_depto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.x = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.panel1.SuspendLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.panel1.Controls.Add(Me.btn_guardar)
        Me.panel1.Controls.Add(Me.btn_desma)
        Me.panel1.Controls.Add(Me.btn_selec)
        Me.panel1.Controls.Add(Me.cbx_depto)
        Me.panel1.Controls.Add(Me.Label2)
        Me.panel1.Controls.Add(Me.dtp1)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Location = New System.Drawing.Point(2, 2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(829, 94)
        Me.panel1.TabIndex = 145
        '
        'btn_guardar
        '
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.Color.LawnGreen
        Me.btn_guardar.Location = New System.Drawing.Point(651, 52)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(78, 35)
        Me.btn_guardar.TabIndex = 153
        Me.btn_guardar.Text = "Aceptar"
        Me.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_desma
        '
        Me.btn_desma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_desma.Location = New System.Drawing.Point(707, 11)
        Me.btn_desma.Name = "btn_desma"
        Me.btn_desma.Size = New System.Drawing.Size(78, 35)
        Me.btn_desma.TabIndex = 152
        Me.btn_desma.Text = "Desmarcar"
        Me.btn_desma.UseVisualStyleBackColor = False
        '
        'btn_selec
        '
        Me.btn_selec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_selec.Location = New System.Drawing.Point(604, 10)
        Me.btn_selec.Name = "btn_selec"
        Me.btn_selec.Size = New System.Drawing.Size(74, 35)
        Me.btn_selec.TabIndex = 151
        Me.btn_selec.Text = "Seleccionar"
        Me.btn_selec.UseVisualStyleBackColor = False
        '
        'cbx_depto
        '
        Me.cbx_depto.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbx_depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_depto.ForeColor = System.Drawing.SystemColors.Menu
        Me.cbx_depto.FormattingEnabled = True
        Me.cbx_depto.Items.AddRange(New Object() {"Permiso con goce de sueldo", "Permiso sin goce de sueldo", "Falta o retardo injustificado y sin goce de sueldo", "Falta o retardo JUSTIFICADO y sin goce de sueldo (No solicitado anticipadamente)", "Vacaciones", "Registro en reloj checador"})
        Me.cbx_depto.Location = New System.Drawing.Point(134, 46)
        Me.cbx_depto.Name = "cbx_depto"
        Me.cbx_depto.Size = New System.Drawing.Size(260, 21)
        Me.cbx_depto.TabIndex = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Departamento:"
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(144, 11)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 137
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Fecha a validar:"
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToDeleteRows = False
        Me.dtgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.x})
        Me.dtgvp.Location = New System.Drawing.Point(4, 102)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(824, 365)
        Me.dtgvp.TabIndex = 151
        '
        'x
        '
        Me.x.HeaderText = "x"
        Me.x.Name = "x"
        Me.x.Width = 18
        '
        'ValidaRh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 479)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ValidaRh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validación de Tiempo Extra"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_depto As ComboBox
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents x As DataGridViewCheckBoxColumn
    Friend WithEvents btn_desma As Button
    Friend WithEvents btn_selec As Button
    Friend WithEvents btn_guardar As Button
End Class
