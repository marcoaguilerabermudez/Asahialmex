<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnomaliaPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnomaliaPrincipal))
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbx_proceso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_maquina = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_pieza = New System.Windows.Forms.ComboBox()
        Me.lbl_pieza = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvp.Location = New System.Drawing.Point(12, 105)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(827, 455)
        Me.dtgvp.TabIndex = 160
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.panel1.Controls.Add(Me.Panel6)
        Me.panel1.Controls.Add(Me.Label9)
        Me.panel1.Controls.Add(Me.Panel5)
        Me.panel1.Controls.Add(Me.Label7)
        Me.panel1.Controls.Add(Me.Panel4)
        Me.panel1.Controls.Add(Me.Label3)
        Me.panel1.Controls.Add(Me.Panel2)
        Me.panel1.Controls.Add(Me.Label4)
        Me.panel1.Controls.Add(Me.Panel3)
        Me.panel1.Controls.Add(Me.Label6)
        Me.panel1.Controls.Add(Me.Label5)
        Me.panel1.Controls.Add(Me.DateTimePicker1)
        Me.panel1.Controls.Add(Me.cbx_proceso)
        Me.panel1.Controls.Add(Me.Label2)
        Me.panel1.Controls.Add(Me.cbx_maquina)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Controls.Add(Me.cbx_pieza)
        Me.panel1.Controls.Add(Me.lbl_pieza)
        Me.panel1.Location = New System.Drawing.Point(0, -2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(976, 98)
        Me.panel1.TabIndex = 161
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(12, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'cbx_proceso
        '
        Me.cbx_proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_proceso.FormattingEnabled = True
        Me.cbx_proceso.Items.AddRange(New Object() {"FUNDICION", "MAQUINADO", "LEAKTEST", "ENSAMBLE"})
        Me.cbx_proceso.Location = New System.Drawing.Point(12, 68)
        Me.cbx_proceso.Name = "cbx_proceso"
        Me.cbx_proceso.Size = New System.Drawing.Size(118, 21)
        Me.cbx_proceso.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Proceso"
        '
        'cbx_maquina
        '
        Me.cbx_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_maquina.FormattingEnabled = True
        Me.cbx_maquina.Items.AddRange(New Object() {"XY", "CV", "NTC 2"})
        Me.cbx_maquina.Location = New System.Drawing.Point(149, 24)
        Me.cbx_maquina.Name = "cbx_maquina"
        Me.cbx_maquina.Size = New System.Drawing.Size(158, 21)
        Me.cbx_maquina.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(151, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Máquina"
        '
        'cbx_pieza
        '
        Me.cbx_pieza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_pieza.FormattingEnabled = True
        Me.cbx_pieza.Items.AddRange(New Object() {"11410-5R7A-0200", "31848-X421A", "31848-X420B", "31848-28X0A", "6H86030100", "6H86030400", "342511-31060", "342515-31020", "342511-32021-04", "342515-32021", "BJS7-39-011", "F2R5-25-740", "PEAR-15-17Z", "PEDD-10-121", "PEDD-10-131", "PEDD-10-141", "PEDD-10-161", "PEDD-14-311", "PEDD-15-17Z", "P54J-10-121", "P54G-10-141", "P54G-14-311", "BJS9-3908Y", "35652-TBG030", "35652-TBG040", "35621-TBG030", "35621-TBG040", "1094-375-032C", "49015-8010", "49015-8011", "11022-0044A", "11022-0045A", "11022-0046A", "11022-0047A", "11022-0048A", "31395-X421A", "6A7A", "6L59", "6L60", "6L61", "6L64", "6L66", "49015-8014", "6H4103000", "6H41030400", "31848-AB50A", "PEP9-10-190", "31395-X425A", "G2R5-25-740-C", "P5PW-10-190", "PEDD-10-190", "P54J-10-190", "P5", "PE", "197954-2220  (G2)"})
        Me.cbx_pieza.Location = New System.Drawing.Point(151, 69)
        Me.cbx_pieza.Name = "cbx_pieza"
        Me.cbx_pieza.Size = New System.Drawing.Size(156, 21)
        Me.cbx_pieza.TabIndex = 18
        '
        'lbl_pieza
        '
        Me.lbl_pieza.AutoSize = True
        Me.lbl_pieza.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_pieza.Location = New System.Drawing.Point(151, 52)
        Me.lbl_pieza.Name = "lbl_pieza"
        Me.lbl_pieza.Size = New System.Drawing.Size(33, 13)
        Me.lbl_pieza.TabIndex = 12
        Me.lbl_pieza.Text = "Pieza"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Pink
        Me.Panel6.Location = New System.Drawing.Point(737, 47)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(33, 10)
        Me.Panel6.TabIndex = 206
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(771, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 12)
        Me.Label9.TabIndex = 205
        Me.Label9.Text = "Etapa 3: Instrucción de calidad"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gold
        Me.Panel5.Location = New System.Drawing.Point(737, 29)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(33, 10)
        Me.Panel5.TabIndex = 204
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(771, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 12)
        Me.Label7.TabIndex = 203
        Me.Label7.Text = "Etapa 2: Resultado de revisión y confirmación"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Linen
        Me.Panel4.Location = New System.Drawing.Point(737, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(33, 10)
        Me.Panel4.TabIndex = 202
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(771, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 12)
        Me.Label3.TabIndex = 201
        Me.Label3.Text = "Etapa 1: Contenido de Anormalidad"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGreen
        Me.Panel2.Location = New System.Drawing.Point(737, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(32, 10)
        Me.Panel2.TabIndex = 200
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(771, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 12)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "Etapa 5: Tratamiento, resultado, confirmación"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightBlue
        Me.Panel3.Location = New System.Drawing.Point(737, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(33, 10)
        Me.Panel3.TabIndex = 198
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(771, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 12)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "Etapa 4: Departamento de Producción"
        '
        'Button2
        '
        Me.Button2.Image = Global.Presentacion.My.Resources.Resources._1486504328_bullet_list_menu_lines_points_items_options_81334
        Me.Button2.Location = New System.Drawing.Point(868, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 71)
        Me.Button2.TabIndex = 167
        Me.Button2.Text = "Nuevo"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AnomaliaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 571)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.dtgvp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AnomaliaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tratamiento de Anomalías"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgvp As DataGridView
    Private WithEvents panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbx_proceso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_maquina As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_pieza As ComboBox
    Friend WithEvents lbl_pieza As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
End Class
