<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnomaliaDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnomaliaDetalle))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lbl_pieza = New System.Windows.Forms.Label()
        Me.cbx_pieza = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbx_maquina = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_proceso = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_depto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.lbl_folio = New System.Windows.Forms.Label()
        Me.lbl_folio2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.panel1.Controls.Add(Me.Button2)
        Me.panel1.Controls.Add(Me.lbl_folio2)
        Me.panel1.Controls.Add(Me.lbl_folio)
        Me.panel1.Controls.Add(Me.lbl1)
        Me.panel1.Controls.Add(Me.txt_clave)
        Me.panel1.Controls.Add(Me.cbx_depto)
        Me.panel1.Controls.Add(Me.Label3)
        Me.panel1.Controls.Add(Me.Label5)
        Me.panel1.Controls.Add(Me.DateTimePicker1)
        Me.panel1.Controls.Add(Me.cbx_proceso)
        Me.panel1.Controls.Add(Me.Label2)
        Me.panel1.Controls.Add(Me.cbx_maquina)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Controls.Add(Me.cbx_pieza)
        Me.panel1.Controls.Add(Me.lbl_pieza)
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1127, 98)
        Me.panel1.TabIndex = 162
        '
        'lbl_pieza
        '
        Me.lbl_pieza.AutoSize = True
        Me.lbl_pieza.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_pieza.Location = New System.Drawing.Point(13, 52)
        Me.lbl_pieza.Name = "lbl_pieza"
        Me.lbl_pieza.Size = New System.Drawing.Size(86, 13)
        Me.lbl_pieza.TabIndex = 12
        Me.lbl_pieza.Text = "Número de parte"
        '
        'cbx_pieza
        '
        Me.cbx_pieza.FormattingEnabled = True
        Me.cbx_pieza.Items.AddRange(New Object() {"11410-5R7A-0200", "31848-X421A", "31848-X420B", "31848-28X0A", "6H86030100", "6H86030400", "342511-31060", "342515-31020", "342511-32021-04", "342515-32021", "BJS7-39-011", "F2R5-25-740", "PEAR-15-17Z", "PEDD-10-121", "PEDD-10-131", "PEDD-10-141", "PEDD-10-161", "PEDD-14-311", "PEDD-15-17Z", "P54J-10-121", "P54G-10-141", "P54G-14-311", "BJS9-3908Y", "35652-TBG030", "35652-TBG040", "35621-TBG030", "35621-TBG040", "1094-375-032C", "49015-8010", "49015-8011", "11022-0044A", "11022-0045A", "11022-0046A", "11022-0047A", "11022-0048A", "31395-X421A", "6A7A", "6L59", "6L60", "6L61", "6L64", "6L66", "49015-8014", "6H4103000", "6H41030400", "31848-AB50A", "PEP9-10-190", "31395-X425A", "G2R5-25-740-C", "P5PW-10-190", "PEDD-10-190", "P54J-10-190", "P5", "PE", "197954-2220  (G2)"})
        Me.cbx_pieza.Location = New System.Drawing.Point(13, 69)
        Me.cbx_pieza.Name = "cbx_pieza"
        Me.cbx_pieza.Size = New System.Drawing.Size(186, 21)
        Me.cbx_pieza.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(217, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Máquina"
        '
        'cbx_maquina
        '
        Me.cbx_maquina.FormattingEnabled = True
        Me.cbx_maquina.Items.AddRange(New Object() {"XY", "CV", "NTC 2"})
        Me.cbx_maquina.Location = New System.Drawing.Point(215, 68)
        Me.cbx_maquina.Name = "cbx_maquina"
        Me.cbx_maquina.Size = New System.Drawing.Size(212, 21)
        Me.cbx_maquina.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(478, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Proceso al que pertenece la anormalidad"
        '
        'cbx_proceso
        '
        Me.cbx_proceso.FormattingEnabled = True
        Me.cbx_proceso.Items.AddRange(New Object() {"FUNDICION", "MAQUINADO", "LEAKTEST", "ENSAMBLE"})
        Me.cbx_proceso.Location = New System.Drawing.Point(481, 23)
        Me.cbx_proceso.Name = "cbx_proceso"
        Me.cbx_proceso.Size = New System.Drawing.Size(197, 21)
        Me.cbx_proceso.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(12, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Fecha"
        '
        'cbx_depto
        '
        Me.cbx_depto.FormattingEnabled = True
        Me.cbx_depto.Items.AddRange(New Object() {"XY", "CV", "NTC 2"})
        Me.cbx_depto.Location = New System.Drawing.Point(215, 23)
        Me.cbx_depto.Name = "cbx_depto"
        Me.cbx_depto.Size = New System.Drawing.Size(212, 21)
        Me.cbx_depto.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(217, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Departamento que detecta"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(542, 55)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(74, 13)
        Me.lbl1.TabIndex = 128
        Me.lbl1.Text = "Quién detecta"
        '
        'txt_clave
        '
        Me.txt_clave.BackColor = System.Drawing.Color.SteelBlue
        Me.txt_clave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txt_clave.Location = New System.Drawing.Point(528, 71)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(98, 20)
        Me.txt_clave.TabIndex = 127
        '
        'lbl_folio
        '
        Me.lbl_folio.AutoSize = True
        Me.lbl_folio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_folio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_folio.Location = New System.Drawing.Point(778, 35)
        Me.lbl_folio.Name = "lbl_folio"
        Me.lbl_folio.Size = New System.Drawing.Size(34, 15)
        Me.lbl_folio.TabIndex = 129
        Me.lbl_folio.Text = "Folio"
        '
        'lbl_folio2
        '
        Me.lbl_folio2.AutoSize = True
        Me.lbl_folio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_folio2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_folio2.Location = New System.Drawing.Point(771, 8)
        Me.lbl_folio2.Name = "lbl_folio2"
        Me.lbl_folio2.Size = New System.Drawing.Size(48, 20)
        Me.lbl_folio2.TabIndex = 130
        Me.lbl_folio2.Text = "Folio"
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Image = Global.Presentacion.My.Resources.Resources.report
        Me.Button2.Location = New System.Drawing.Point(1015, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 71)
        Me.Button2.TabIndex = 168
        Me.Button2.Text = "Generar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(0, 100)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1127, 495)
        Me.TabControl1.TabIndex = 163
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1119, 469)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Etapa 1: Contenido de anormalidad"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1119, 469)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Etapa 2: Resultado de revisión y confirmación"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1119, 469)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Etapa 3: Instrucción de calidad"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1119, 469)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Etapa 4: Departamento de producción"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1119, 469)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Etapa 5: Tratamiento, resultado, confirmación"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'AnomaliaDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 598)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AnomaliaDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura y seguimiento de anomalías"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Friend WithEvents cbx_depto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbx_proceso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_maquina As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_pieza As ComboBox
    Friend WithEvents lbl_pieza As Label
    Friend WithEvents lbl_folio2 As Label
    Friend WithEvents lbl_folio As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
End Class
