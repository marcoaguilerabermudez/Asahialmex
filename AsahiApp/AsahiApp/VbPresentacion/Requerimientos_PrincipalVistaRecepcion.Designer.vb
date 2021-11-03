<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Requerimientos_PrincipalVistaRecepcion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requerimientos_PrincipalVistaRecepcion))
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_fecharecep = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_uuid = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_modificado = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_cancelado = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_factura = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_depto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_po = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgvp.Location = New System.Drawing.Point(12, 163)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(978, 440)
        Me.dtgvp.TabIndex = 493
        Me.dtgvp.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbl_fecharecep)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.lbl_uuid)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.lbl_modificado)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.lbl_cancelado)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.lbl_tipo)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.lbl_factura)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.lbl_depto)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lbl_po)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.lbl_proveedor)
        Me.Panel5.Location = New System.Drawing.Point(12, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(727, 152)
        Me.Panel5.TabIndex = 522
        Me.Panel5.Visible = False
        '
        'lbl_fecharecep
        '
        Me.lbl_fecharecep.Enabled = False
        Me.lbl_fecharecep.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.lbl_fecharecep.Location = New System.Drawing.Point(102, 99)
        Me.lbl_fecharecep.Name = "lbl_fecharecep"
        Me.lbl_fecharecep.Size = New System.Drawing.Size(96, 20)
        Me.lbl_fecharecep.TabIndex = 538
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(48, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 536
        Me.Label3.Text = "UUID"
        '
        'lbl_uuid
        '
        Me.lbl_uuid.AutoSize = True
        Me.lbl_uuid.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_uuid.ForeColor = System.Drawing.Color.Black
        Me.lbl_uuid.Location = New System.Drawing.Point(103, 77)
        Me.lbl_uuid.Name = "lbl_uuid"
        Me.lbl_uuid.Size = New System.Drawing.Size(12, 13)
        Me.lbl_uuid.TabIndex = 537
        Me.lbl_uuid.Text = "x"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(468, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 534
        Me.Label13.Text = "Modificado"
        '
        'lbl_modificado
        '
        Me.lbl_modificado.AutoSize = True
        Me.lbl_modificado.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_modificado.ForeColor = System.Drawing.Color.Black
        Me.lbl_modificado.Location = New System.Drawing.Point(553, 32)
        Me.lbl_modificado.Name = "lbl_modificado"
        Me.lbl_modificado.Size = New System.Drawing.Size(12, 13)
        Me.lbl_modificado.TabIndex = 535
        Me.lbl_modificado.Text = "x"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(470, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 532
        Me.Label15.Text = "Cancelado"
        '
        'lbl_cancelado
        '
        Me.lbl_cancelado.AutoSize = True
        Me.lbl_cancelado.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_cancelado.ForeColor = System.Drawing.Color.Black
        Me.lbl_cancelado.Location = New System.Drawing.Point(553, 6)
        Me.lbl_cancelado.Name = "lbl_cancelado"
        Me.lbl_cancelado.Size = New System.Drawing.Size(12, 13)
        Me.lbl_cancelado.TabIndex = 533
        Me.lbl_cancelado.Text = "x"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(13, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 530
        Me.Label9.Text = "F Recepción"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(505, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 528
        Me.Label11.Text = "Tipo"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_tipo.ForeColor = System.Drawing.Color.Black
        Me.lbl_tipo.Location = New System.Drawing.Point(553, 57)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(12, 13)
        Me.lbl_tipo.TabIndex = 529
        Me.lbl_tipo.Text = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(41, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 526
        Me.Label2.Text = "Factura"
        '
        'lbl_factura
        '
        Me.lbl_factura.AutoSize = True
        Me.lbl_factura.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_factura.ForeColor = System.Drawing.Color.Black
        Me.lbl_factura.Location = New System.Drawing.Point(104, 53)
        Me.lbl_factura.Name = "lbl_factura"
        Me.lbl_factura.Size = New System.Drawing.Size(12, 13)
        Me.lbl_factura.TabIndex = 527
        Me.lbl_factura.Text = "x"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(7, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 524
        Me.Label5.Text = "Departamento"
        '
        'lbl_depto
        '
        Me.lbl_depto.AutoSize = True
        Me.lbl_depto.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_depto.ForeColor = System.Drawing.Color.Black
        Me.lbl_depto.Location = New System.Drawing.Point(103, 127)
        Me.lbl_depto.Name = "lbl_depto"
        Me.lbl_depto.Size = New System.Drawing.Size(12, 13)
        Me.lbl_depto.TabIndex = 525
        Me.lbl_depto.Text = "x"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(65, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 522
        Me.Label7.Text = "PO"
        '
        'lbl_po
        '
        Me.lbl_po.AutoSize = True
        Me.lbl_po.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_po.ForeColor = System.Drawing.Color.Black
        Me.lbl_po.Location = New System.Drawing.Point(104, 6)
        Me.lbl_po.Name = "lbl_po"
        Me.lbl_po.Size = New System.Drawing.Size(12, 13)
        Me.lbl_po.TabIndex = 523
        Me.lbl_po.Text = "x"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(28, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 499
        Me.Label6.Text = "Proveedor"
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_proveedor.ForeColor = System.Drawing.Color.Black
        Me.lbl_proveedor.Location = New System.Drawing.Point(104, 29)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(12, 13)
        Me.lbl_proveedor.TabIndex = 500
        Me.lbl_proveedor.Text = "x"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.Location = New System.Drawing.Point(767, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(32, 13)
        Me.Panel4.TabIndex = 526
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(800, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 9)
        Me.Label1.TabIndex = 524
        Me.Label1.Text = "CON FACTURA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Pink
        Me.Panel1.Location = New System.Drawing.Point(767, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(32, 13)
        Me.Panel1.TabIndex = 528
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(802, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 9)
        Me.Label8.TabIndex = 527
        Me.Label8.Text = "PENDIENTE FACTURA"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Location = New System.Drawing.Point(767, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(32, 13)
        Me.Panel2.TabIndex = 530
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(803, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 9)
        Me.Label4.TabIndex = 529
        Me.Label4.Text = "FACTURA N/A"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGreen
        Me.Panel3.Location = New System.Drawing.Point(767, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(32, 13)
        Me.Panel3.TabIndex = 532
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(803, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 9)
        Me.Label10.TabIndex = 531
        Me.Label10.Text = "APROBADO POR CONTABILIDAD"
        '
        'Requerimientos_PrincipalVistaRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 615)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.dtgvp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Requerimientos_PrincipalVistaRecepcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepciones"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_po As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_proveedor As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_factura As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_depto As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_modificado As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_cancelado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_uuid As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_fecharecep As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
End Class
