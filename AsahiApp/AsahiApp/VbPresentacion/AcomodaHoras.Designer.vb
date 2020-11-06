<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcomodaHoras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AcomodaHoras))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.btn_solicitar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_textra = New System.Windows.Forms.ComboBox()
        Me.Check_entrada = New System.Windows.Forms.RadioButton()
        Me.Check_salida = New System.Windows.Forms.RadioButton()
        Me.lbl_fechahora = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(21, 73)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(34, 13)
        Me.lbl1.TabIndex = 128
        Me.lbl1.Text = "Clave"
        '
        'txt_clave
        '
        Me.txt_clave.BackColor = System.Drawing.SystemColors.Control
        Me.txt_clave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_clave.Location = New System.Drawing.Point(62, 70)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(98, 20)
        Me.txt_clave.TabIndex = 127
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.panel1.Controls.Add(Me.dtp1)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Location = New System.Drawing.Point(1, 2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(797, 41)
        Me.panel1.TabIndex = 145
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(70, 10)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 135
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Fecha:"
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToOrderColumns = True
        Me.dtgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvp.Location = New System.Drawing.Point(24, 143)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(205, 276)
        Me.dtgvp.TabIndex = 160
        '
        'btn_solicitar
        '
        Me.btn_solicitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_solicitar.ForeColor = System.Drawing.Color.Green
        Me.btn_solicitar.Location = New System.Drawing.Point(461, 244)
        Me.btn_solicitar.Name = "btn_solicitar"
        Me.btn_solicitar.Size = New System.Drawing.Size(90, 35)
        Me.btn_solicitar.TabIndex = 161
        Me.btn_solicitar.Text = "Aceptar"
        Me.btn_solicitar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(312, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "Turno Extra"
        '
        'cbx_textra
        '
        Me.cbx_textra.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbx_textra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_textra.ForeColor = System.Drawing.SystemColors.Menu
        Me.cbx_textra.FormattingEnabled = True
        Me.cbx_textra.Items.AddRange(New Object() {"Matutino", "Vespertino", "Nocturno", "Administrativo"})
        Me.cbx_textra.Location = New System.Drawing.Point(279, 73)
        Me.cbx_textra.Name = "cbx_textra"
        Me.cbx_textra.Size = New System.Drawing.Size(142, 21)
        Me.cbx_textra.TabIndex = 162
        '
        'Check_entrada
        '
        Me.Check_entrada.AutoSize = True
        Me.Check_entrada.Checked = True
        Me.Check_entrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Check_entrada.Location = New System.Drawing.Point(258, 255)
        Me.Check_entrada.Name = "Check_entrada"
        Me.Check_entrada.Size = New System.Drawing.Size(62, 17)
        Me.Check_entrada.TabIndex = 177
        Me.Check_entrada.TabStop = True
        Me.Check_entrada.Text = "Entrada"
        Me.Check_entrada.UseVisualStyleBackColor = True
        '
        'Check_salida
        '
        Me.Check_salida.AutoSize = True
        Me.Check_salida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Check_salida.Location = New System.Drawing.Point(258, 278)
        Me.Check_salida.Name = "Check_salida"
        Me.Check_salida.Size = New System.Drawing.Size(54, 17)
        Me.Check_salida.TabIndex = 178
        Me.Check_salida.Text = "Salida"
        Me.Check_salida.UseVisualStyleBackColor = True
        '
        'lbl_fechahora
        '
        Me.lbl_fechahora.AutoSize = True
        Me.lbl_fechahora.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_fechahora.ForeColor = System.Drawing.Color.Black
        Me.lbl_fechahora.Location = New System.Drawing.Point(247, 213)
        Me.lbl_fechahora.Name = "lbl_fechahora"
        Me.lbl_fechahora.Size = New System.Drawing.Size(71, 13)
        Me.lbl_fechahora.TabIndex = 179
        Me.lbl_fechahora.Text = "Hora y Fecha"
        '
        'AcomodaHoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 450)
        Me.Controls.Add(Me.lbl_fechahora)
        Me.Controls.Add(Me.Check_entrada)
        Me.Controls.Add(Me.Check_salida)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbx_textra)
        Me.Controls.Add(Me.btn_solicitar)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txt_clave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AcomodaHoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acomoda Horario"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents txt_clave As TextBox
    Private WithEvents panel1 As Panel
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents btn_solicitar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_textra As ComboBox
    Friend WithEvents Check_entrada As RadioButton
    Friend WithEvents Check_salida As RadioButton
    Friend WithEvents lbl_fechahora As Label
End Class
