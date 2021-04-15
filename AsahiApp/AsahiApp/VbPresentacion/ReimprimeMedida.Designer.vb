<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReimprimeMedida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReimprimeMedida))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.btn_aplicar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.txt_antecedente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_faltacometida = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_articuloinfracionado = New System.Windows.Forms.TextBox()
        Me.cbx_tipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_articulo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(22, 47)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(34, 13)
        Me.lbl1.TabIndex = 138
        Me.lbl1.Text = "Clave"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.SystemColors.Control
        Me.lbl2.Enabled = False
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(14, 74)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(44, 13)
        Me.lbl2.TabIndex = 139
        Me.lbl2.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_nombre.Location = New System.Drawing.Point(82, 71)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(281, 20)
        Me.txt_nombre.TabIndex = 137
        '
        'txt_clave
        '
        Me.txt_clave.BackColor = System.Drawing.SystemColors.Control
        Me.txt_clave.Enabled = False
        Me.txt_clave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_clave.Location = New System.Drawing.Point(81, 44)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(98, 20)
        Me.txt_clave.TabIndex = 136
        Me.txt_clave.Tag = "0"
        '
        'btn_aplicar
        '
        Me.btn_aplicar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_aplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aplicar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_aplicar.Location = New System.Drawing.Point(695, 37)
        Me.btn_aplicar.Name = "btn_aplicar"
        Me.btn_aplicar.Size = New System.Drawing.Size(120, 35)
        Me.btn_aplicar.TabIndex = 174
        Me.btn_aplicar.Text = "Aplicar"
        Me.btn_aplicar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.IndianRed
        Me.btn_cancelar.Location = New System.Drawing.Point(695, 224)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(120, 35)
        Me.btn_cancelar.TabIndex = 175
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_imprimir.Location = New System.Drawing.Point(695, 387)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(120, 35)
        Me.btn_imprimir.TabIndex = 176
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Folio"
        '
        'txt_folio
        '
        Me.txt_folio.BackColor = System.Drawing.SystemColors.Control
        Me.txt_folio.Enabled = False
        Me.txt_folio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_folio.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_folio.Location = New System.Drawing.Point(81, 15)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(98, 20)
        Me.txt_folio.TabIndex = 177
        Me.txt_folio.Tag = "0"
        '
        'txt_antecedente
        '
        Me.txt_antecedente.BackColor = System.Drawing.SystemColors.Control
        Me.txt_antecedente.Enabled = False
        Me.txt_antecedente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_antecedente.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_antecedente.Location = New System.Drawing.Point(12, 351)
        Me.txt_antecedente.MaxLength = 200
        Me.txt_antecedente.Multiline = True
        Me.txt_antecedente.Name = "txt_antecedente"
        Me.txt_antecedente.Size = New System.Drawing.Size(608, 49)
        Me.txt_antecedente.TabIndex = 187
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 186
        Me.Label7.Text = "Antecedentes"
        '
        'txt_faltacometida
        '
        Me.txt_faltacometida.BackColor = System.Drawing.SystemColors.Control
        Me.txt_faltacometida.Enabled = False
        Me.txt_faltacometida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_faltacometida.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_faltacometida.Location = New System.Drawing.Point(12, 268)
        Me.txt_faltacometida.MaxLength = 200
        Me.txt_faltacometida.Multiline = True
        Me.txt_faltacometida.Name = "txt_faltacometida"
        Me.txt_faltacometida.Size = New System.Drawing.Size(608, 53)
        Me.txt_faltacometida.TabIndex = 185
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 184
        Me.Label6.Text = "Falta Cometida"
        '
        'txt_articuloinfracionado
        '
        Me.txt_articuloinfracionado.BackColor = System.Drawing.SystemColors.Control
        Me.txt_articuloinfracionado.Enabled = False
        Me.txt_articuloinfracionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_articuloinfracionado.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_articuloinfracionado.Location = New System.Drawing.Point(12, 161)
        Me.txt_articuloinfracionado.Multiline = True
        Me.txt_articuloinfracionado.Name = "txt_articuloinfracionado"
        Me.txt_articuloinfracionado.Size = New System.Drawing.Size(608, 80)
        Me.txt_articuloinfracionado.TabIndex = 183
        '
        'cbx_tipo
        '
        Me.cbx_tipo.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_tipo.Enabled = False
        Me.cbx_tipo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbx_tipo.FormattingEnabled = True
        Me.cbx_tipo.Location = New System.Drawing.Point(12, 133)
        Me.cbx_tipo.Name = "cbx_tipo"
        Me.cbx_tipo.Size = New System.Drawing.Size(195, 21)
        Me.cbx_tipo.TabIndex = 182
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(79, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(245, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 180
        Me.Label4.Text = "Artículo Infracionado"
        '
        'txt_articulo
        '
        Me.txt_articulo.BackColor = System.Drawing.SystemColors.Control
        Me.txt_articulo.Enabled = False
        Me.txt_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_articulo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_articulo.Location = New System.Drawing.Point(258, 133)
        Me.txt_articulo.Name = "txt_articulo"
        Me.txt_articulo.Size = New System.Drawing.Size(98, 20)
        Me.txt_articulo.TabIndex = 179
        Me.txt_articulo.Tag = "0"
        Me.txt_articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ReimprimeMedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 450)
        Me.Controls.Add(Me.txt_antecedente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_faltacometida)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_articuloinfracionado)
        Me.Controls.Add(Me.cbx_tipo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_articulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aplicar)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_clave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReimprimeMedida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReimprimeMedida"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents btn_aplicar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_imprimir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_folio As TextBox
    Friend WithEvents txt_antecedente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_faltacometida As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_articuloinfracionado As TextBox
    Friend WithEvents cbx_tipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_articulo As TextBox
End Class
