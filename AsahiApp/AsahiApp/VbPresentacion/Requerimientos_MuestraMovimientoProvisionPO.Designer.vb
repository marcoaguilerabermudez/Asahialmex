<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requerimientos_MuestraMovimientoProvisionPO
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requerimientos_MuestraMovimientoProvisionPO))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_provision = New System.Windows.Forms.Label()
        Me.lbl_totalfact = New System.Windows.Forms.TextBox()
        Me.lbl_subtotalfact = New System.Windows.Forms.TextBox()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_foliofact = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_uuid = New System.Windows.Forms.Label()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.DS_Ausentismos_Fecha1 = New CsPresentacion.DS_Ausentismos_Fecha()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Ausentismos_Fecha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_provision)
        Me.Panel1.Controls.Add(Me.lbl_totalfact)
        Me.Panel1.Controls.Add(Me.lbl_subtotalfact)
        Me.Panel1.Controls.Add(Me.dtp2)
        Me.Panel1.Controls.Add(Me.dtp1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lbl_foliofact)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lbl_uuid)
        Me.Panel1.Location = New System.Drawing.Point(5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 151)
        Me.Panel1.TabIndex = 520
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(37, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 542
        Me.Label1.Text = "Provisión"
        '
        'lbl_provision
        '
        Me.lbl_provision.AutoSize = True
        Me.lbl_provision.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_provision.ForeColor = System.Drawing.Color.Black
        Me.lbl_provision.Location = New System.Drawing.Point(103, 66)
        Me.lbl_provision.Name = "lbl_provision"
        Me.lbl_provision.Size = New System.Drawing.Size(0, 13)
        Me.lbl_provision.TabIndex = 543
        '
        'lbl_totalfact
        '
        Me.lbl_totalfact.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_totalfact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lbl_totalfact.Enabled = False
        Me.lbl_totalfact.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_totalfact.Location = New System.Drawing.Point(409, 123)
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
        Me.lbl_subtotalfact.Enabled = False
        Me.lbl_subtotalfact.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_subtotalfact.Location = New System.Drawing.Point(409, 93)
        Me.lbl_subtotalfact.MaxLength = 99
        Me.lbl_subtotalfact.Name = "lbl_subtotalfact"
        Me.lbl_subtotalfact.Size = New System.Drawing.Size(127, 20)
        Me.lbl_subtotalfact.TabIndex = 540
        Me.lbl_subtotalfact.Text = "0"
        Me.lbl_subtotalfact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtp2
        '
        Me.dtp2.Enabled = False
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(102, 121)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(100, 20)
        Me.dtp2.TabIndex = 539
        '
        'dtp1
        '
        Me.dtp1.Enabled = False
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(103, 92)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 538
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(10, 95)
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
        Me.Label16.Location = New System.Drawing.Point(21, 123)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 536
        Me.Label16.Text = "Fecha Pago"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(308, 124)
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
        Me.Label17.Location = New System.Drawing.Point(338, 94)
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
        Me.Label9.Location = New System.Drawing.Point(64, 12)
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
        Me.lbl_foliofact.Location = New System.Drawing.Point(104, 14)
        Me.lbl_foliofact.Name = "lbl_foliofact"
        Me.lbl_foliofact.Size = New System.Drawing.Size(0, 13)
        Me.lbl_foliofact.TabIndex = 530
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(59, 38)
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
        Me.lbl_uuid.Location = New System.Drawing.Point(104, 38)
        Me.lbl_uuid.Name = "lbl_uuid"
        Me.lbl_uuid.Size = New System.Drawing.Size(0, 13)
        Me.lbl_uuid.TabIndex = 528
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToDeleteRows = False
        Me.dtgvp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgvp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgvp.Location = New System.Drawing.Point(12, 180)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(764, 370)
        Me.dtgvp.TabIndex = 548
        Me.dtgvp.Visible = False
        '
        'DS_Ausentismos_Fecha1
        '
        Me.DS_Ausentismos_Fecha1.DataSetName = "DS_Ausentismos_Fecha"
        Me.DS_Ausentismos_Fecha1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Requerimientos_MuestraMovimientoProvisionPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 562)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Requerimientos_MuestraMovimientoProvisionPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Ausentismos_Fecha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_totalfact As TextBox
    Friend WithEvents lbl_subtotalfact As TextBox
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_foliofact As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_uuid As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_provision As Label
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents DS_Ausentismos_Fecha1 As CsPresentacion.DS_Ausentismos_Fecha
End Class
