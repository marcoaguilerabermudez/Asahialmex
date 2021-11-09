<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requerimientos_CargaXML
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requerimientos_CargaXML))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_subtotal = New System.Windows.Forms.Label()
        Me.btn_fil2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_provi = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_rfc = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.lbl_totalfact = New System.Windows.Forms.TextBox()
        Me.lbl_subtotalfact = New System.Windows.Forms.TextBox()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_doc = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_foliofact = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_uuid = New System.Windows.Forms.Label()
        Me.gbx_tipo = New System.Windows.Forms.GroupBox()
        Me.rbt_retardo = New System.Windows.Forms.RadioButton()
        Me.rbt_falta = New System.Windows.Forms.RadioButton()
        Me.lbl_txtfiltro = New System.Windows.Forms.Label()
        Me.txt_busca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_moneda = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gbx_tipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbl_moneda)
        Me.Panel1.Controls.Add(Me.btn_quitar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_total)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbl_subtotal)
        Me.Panel1.Controls.Add(Me.btn_fil2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_provi)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbl_rfc)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lbl_proveedor)
        Me.Panel1.Controls.Add(Me.lbl_totalfact)
        Me.Panel1.Controls.Add(Me.lbl_subtotalfact)
        Me.Panel1.Controls.Add(Me.dtp2)
        Me.Panel1.Controls.Add(Me.dtp1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.btn_doc)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbl_foliofact)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lbl_uuid)
        Me.Panel1.Controls.Add(Me.gbx_tipo)
        Me.Panel1.Controls.Add(Me.lbl_txtfiltro)
        Me.Panel1.Controls.Add(Me.txt_busca)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 401)
        Me.Panel1.TabIndex = 520
        '
        'btn_quitar
        '
        Me.btn_quitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_quitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitar.ForeColor = System.Drawing.Color.Goldenrod
        Me.btn_quitar.Location = New System.Drawing.Point(383, 351)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(120, 35)
        Me.btn_quitar.TabIndex = 553
        Me.btn_quitar.Text = "Quitar"
        Me.btn_quitar.UseVisualStyleBackColor = False
        Me.btn_quitar.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(36, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 551
        Me.Label2.Text = "Total"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(86, 93)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(0, 13)
        Me.lbl_total.TabIndex = 552
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(19, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 549
        Me.Label4.Text = "Subtotal"
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.AutoSize = True
        Me.lbl_subtotal.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_subtotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_subtotal.Location = New System.Drawing.Point(86, 71)
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Size = New System.Drawing.Size(0, 13)
        Me.lbl_subtotal.TabIndex = 550
        '
        'btn_fil2
        '
        Me.btn_fil2.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_fil2.Enabled = False
        Me.btn_fil2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fil2.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_fil2.Location = New System.Drawing.Point(43, 352)
        Me.btn_fil2.Name = "btn_fil2"
        Me.btn_fil2.Size = New System.Drawing.Size(120, 35)
        Me.btn_fil2.TabIndex = 548
        Me.btn_fil2.Text = "Guardar"
        Me.btn_fil2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(15, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 546
        Me.Label1.Text = "Provisión"
        '
        'lbl_provi
        '
        Me.lbl_provi.AutoSize = True
        Me.lbl_provi.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_provi.ForeColor = System.Drawing.Color.Black
        Me.lbl_provi.Location = New System.Drawing.Point(86, 7)
        Me.lbl_provi.Name = "lbl_provi"
        Me.lbl_provi.Size = New System.Drawing.Size(0, 13)
        Me.lbl_provi.TabIndex = 547
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(40, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 544
        Me.Label5.Text = "RFC"
        '
        'lbl_rfc
        '
        Me.lbl_rfc.AutoSize = True
        Me.lbl_rfc.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_rfc.ForeColor = System.Drawing.Color.Black
        Me.lbl_rfc.Location = New System.Drawing.Point(86, 52)
        Me.lbl_rfc.Name = "lbl_rfc"
        Me.lbl_rfc.Size = New System.Drawing.Size(0, 13)
        Me.lbl_rfc.TabIndex = 545
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(10, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 542
        Me.Label6.Text = "Proveedor"
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_proveedor.Location = New System.Drawing.Point(86, 30)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(0, 13)
        Me.lbl_proveedor.TabIndex = 543
        '
        'lbl_totalfact
        '
        Me.lbl_totalfact.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_totalfact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_totalfact.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_totalfact.Location = New System.Drawing.Point(409, 320)
        Me.lbl_totalfact.MaxLength = 99
        Me.lbl_totalfact.Name = "lbl_totalfact"
        Me.lbl_totalfact.Size = New System.Drawing.Size(127, 20)
        Me.lbl_totalfact.TabIndex = 541
        Me.lbl_totalfact.Text = "0"
        Me.lbl_totalfact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_subtotalfact
        '
        Me.lbl_subtotalfact.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_subtotalfact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_subtotalfact.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_subtotalfact.Location = New System.Drawing.Point(409, 290)
        Me.lbl_subtotalfact.MaxLength = 99
        Me.lbl_subtotalfact.Name = "lbl_subtotalfact"
        Me.lbl_subtotalfact.Size = New System.Drawing.Size(127, 20)
        Me.lbl_subtotalfact.TabIndex = 540
        Me.lbl_subtotalfact.Text = "0"
        Me.lbl_subtotalfact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(102, 311)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(100, 20)
        Me.dtp2.TabIndex = 539
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(103, 282)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 538
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(10, 285)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 537
        Me.Label15.Text = "Fecha factura"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(21, 313)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 536
        Me.Label16.Text = "Fecha Pago"
        '
        'btn_doc
        '
        Me.btn_doc.Enabled = False
        Me.btn_doc.ForeColor = System.Drawing.Color.Black
        Me.btn_doc.Image = Global.Presentacion.My.Resources.Resources.report
        Me.btn_doc.Location = New System.Drawing.Point(352, 198)
        Me.btn_doc.Name = "btn_doc"
        Me.btn_doc.Size = New System.Drawing.Size(42, 40)
        Me.btn_doc.TabIndex = 535
        Me.btn_doc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_doc.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(308, 321)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 16)
        Me.Label10.TabIndex = 532
        Me.Label10.Text = "Total factura"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(338, 291)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 16)
        Me.Label17.TabIndex = 534
        Me.Label17.Text = "Subtotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(64, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 529
        Me.Label9.Text = "Folio"
        '
        'lbl_foliofact
        '
        Me.lbl_foliofact.AutoSize = True
        Me.lbl_foliofact.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_foliofact.ForeColor = System.Drawing.Color.Black
        Me.lbl_foliofact.Location = New System.Drawing.Point(104, 235)
        Me.lbl_foliofact.Name = "lbl_foliofact"
        Me.lbl_foliofact.Size = New System.Drawing.Size(0, 13)
        Me.lbl_foliofact.TabIndex = 530
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(59, 262)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 527
        Me.Label11.Text = "UUID"
        '
        'lbl_uuid
        '
        Me.lbl_uuid.AutoSize = True
        Me.lbl_uuid.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_uuid.ForeColor = System.Drawing.Color.Black
        Me.lbl_uuid.Location = New System.Drawing.Point(104, 262)
        Me.lbl_uuid.Name = "lbl_uuid"
        Me.lbl_uuid.Size = New System.Drawing.Size(0, 13)
        Me.lbl_uuid.TabIndex = 528
        '
        'gbx_tipo
        '
        Me.gbx_tipo.Controls.Add(Me.rbt_retardo)
        Me.gbx_tipo.Controls.Add(Me.rbt_falta)
        Me.gbx_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbx_tipo.Location = New System.Drawing.Point(7, 146)
        Me.gbx_tipo.Name = "gbx_tipo"
        Me.gbx_tipo.Size = New System.Drawing.Size(140, 37)
        Me.gbx_tipo.TabIndex = 526
        Me.gbx_tipo.TabStop = False
        Me.gbx_tipo.Text = "Buscar por"
        '
        'rbt_retardo
        '
        Me.rbt_retardo.AutoSize = True
        Me.rbt_retardo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbt_retardo.Location = New System.Drawing.Point(79, 17)
        Me.rbt_retardo.Name = "rbt_retardo"
        Me.rbt_retardo.Size = New System.Drawing.Size(52, 17)
        Me.rbt_retardo.TabIndex = 177
        Me.rbt_retardo.Text = "Folio"
        Me.rbt_retardo.UseVisualStyleBackColor = True
        '
        'rbt_falta
        '
        Me.rbt_falta.AutoSize = True
        Me.rbt_falta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbt_falta.Location = New System.Drawing.Point(9, 17)
        Me.rbt_falta.Name = "rbt_falta"
        Me.rbt_falta.Size = New System.Drawing.Size(56, 17)
        Me.rbt_falta.TabIndex = 176
        Me.rbt_falta.Text = "UUID"
        Me.rbt_falta.UseVisualStyleBackColor = True
        '
        'lbl_txtfiltro
        '
        Me.lbl_txtfiltro.AutoSize = True
        Me.lbl_txtfiltro.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_txtfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_txtfiltro.ForeColor = System.Drawing.Color.Black
        Me.lbl_txtfiltro.Location = New System.Drawing.Point(13, 193)
        Me.lbl_txtfiltro.Name = "lbl_txtfiltro"
        Me.lbl_txtfiltro.Size = New System.Drawing.Size(38, 13)
        Me.lbl_txtfiltro.TabIndex = 525
        Me.lbl_txtfiltro.Text = "UUID"
        '
        'txt_busca
        '
        Me.txt_busca.BackColor = System.Drawing.SystemColors.Control
        Me.txt_busca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_busca.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_busca.Location = New System.Drawing.Point(12, 209)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(315, 20)
        Me.txt_busca.TabIndex = 524
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(18, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 554
        Me.Label3.Text = "Moneda"
        '
        'lbl_moneda
        '
        Me.lbl_moneda.AutoSize = True
        Me.lbl_moneda.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_moneda.ForeColor = System.Drawing.Color.Black
        Me.lbl_moneda.Location = New System.Drawing.Point(86, 119)
        Me.lbl_moneda.Name = "lbl_moneda"
        Me.lbl_moneda.Size = New System.Drawing.Size(0, 13)
        Me.lbl_moneda.TabIndex = 555
        '
        'Requerimientos_CargaXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 425)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Requerimientos_CargaXML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga XML"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbx_tipo.ResumeLayout(False)
        Me.gbx_tipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_totalfact As TextBox
    Friend WithEvents lbl_subtotalfact As TextBox
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_doc As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_foliofact As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_uuid As Label
    Friend WithEvents gbx_tipo As GroupBox
    Friend WithEvents rbt_retardo As RadioButton
    Friend WithEvents rbt_falta As RadioButton
    Friend WithEvents lbl_txtfiltro As Label
    Friend WithEvents txt_busca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_provi As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_rfc As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_proveedor As Label
    Friend WithEvents btn_fil2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_subtotal As Label
    Friend WithEvents btn_quitar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_moneda As Label
End Class
