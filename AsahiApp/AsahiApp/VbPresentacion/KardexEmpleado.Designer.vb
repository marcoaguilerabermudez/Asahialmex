<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KardexEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KardexEmpleado))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_textra = New System.Windows.Forms.ComboBox()
        Me.btn_evaluar = New System.Windows.Forms.Button()
        Me.pbx = New System.Windows.Forms.PictureBox()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(78, 22)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(34, 13)
        Me.lbl1.TabIndex = 197
        Me.lbl1.Text = "Clave"
        '
        'txt_clave
        '
        Me.txt_clave.BackColor = System.Drawing.SystemColors.Control
        Me.txt_clave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_clave.Location = New System.Drawing.Point(62, 49)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(71, 20)
        Me.txt_clave.TabIndex = 196
        Me.txt_clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(78, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "Año"
        '
        'cbx_textra
        '
        Me.cbx_textra.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbx_textra.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbx_textra.FormattingEnabled = True
        Me.cbx_textra.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "--TODO--"})
        Me.cbx_textra.Location = New System.Drawing.Point(54, 130)
        Me.cbx_textra.Name = "cbx_textra"
        Me.cbx_textra.Size = New System.Drawing.Size(79, 21)
        Me.cbx_textra.TabIndex = 198
        '
        'btn_evaluar
        '
        Me.btn_evaluar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_evaluar.Enabled = False
        Me.btn_evaluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_evaluar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_evaluar.Location = New System.Drawing.Point(216, 171)
        Me.btn_evaluar.Name = "btn_evaluar"
        Me.btn_evaluar.Size = New System.Drawing.Size(88, 42)
        Me.btn_evaluar.TabIndex = 256
        Me.btn_evaluar.Text = "Imprimir"
        Me.btn_evaluar.UseVisualStyleBackColor = False
        '
        'pbx
        '
        Me.pbx.ErrorImage = CType(resources.GetObject("pbx.ErrorImage"), System.Drawing.Image)
        Me.pbx.Location = New System.Drawing.Point(330, 12)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(132, 138)
        Me.pbx.TabIndex = 195
        Me.pbx.TabStop = False
        '
        'KardexEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 235)
        Me.Controls.Add(Me.btn_evaluar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbx_textra)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.pbx)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KardexEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kárdex de Incidencias"
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbx As PictureBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_textra As ComboBox
    Friend WithEvents btn_evaluar As Button
End Class
