<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Requerimientos_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requerimientos_principal))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.btn_solicitar = New System.Windows.Forms.Button()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.lbl_req = New System.Windows.Forms.Label()
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.cbx_area = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(63, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Desde"
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(33, 28)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 164
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(182, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Hasta"
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(152, 28)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(100, 20)
        Me.dtp2.TabIndex = 166
        '
        'btn_solicitar
        '
        Me.btn_solicitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_solicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_solicitar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_solicitar.Location = New System.Drawing.Point(305, 64)
        Me.btn_solicitar.Name = "btn_solicitar"
        Me.btn_solicitar.Size = New System.Drawing.Size(120, 35)
        Me.btn_solicitar.TabIndex = 426
        Me.btn_solicitar.Text = "Filtrar"
        Me.btn_solicitar.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
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
        Me.dtgvp.Location = New System.Drawing.Point(12, 105)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.ReadOnly = True
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(753, 518)
        Me.dtgvp.TabIndex = 427
        '
        'lbl_req
        '
        Me.lbl_req.AutoSize = True
        Me.lbl_req.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_req.ForeColor = System.Drawing.Color.Black
        Me.lbl_req.Location = New System.Drawing.Point(685, 83)
        Me.lbl_req.Name = "lbl_req"
        Me.lbl_req.Size = New System.Drawing.Size(38, 13)
        Me.lbl_req.TabIndex = 428
        Me.lbl_req.Text = "Desde"
        Me.lbl_req.Visible = False
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_area.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_area.ForeColor = System.Drawing.Color.Black
        Me.lbl_area.Location = New System.Drawing.Point(481, 12)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(33, 13)
        Me.lbl_area.TabIndex = 430
        Me.lbl_area.Text = "Área"
        '
        'cbx_area
        '
        Me.cbx_area.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_area.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_area.FormattingEnabled = True
        Me.cbx_area.Items.AddRange(New Object() {"ASEGURAMIENTO DE CALIDAD F1", "ASUNTOS GENERALES", "ATENCIÓN AL CLIENTE", "COMPRAS", "CONTABILIDAD", "CONTROL DE MANUFACTURA", "CONTROL DE PRODUCCION", "MOLDES", "SEGURIDAD", "SISTEMAS IT", "INGENIERÍA MAQUINADO", "INGENIERÍA FUNDICIÓN", "INSPECCION PRODUCCION", "FUNDICION 1", "FUNDICION 2", "ACABADO", "ACABADO 2", "CONTROL DE CLIENTES", "MANTENIMIENTO DE PLANTA", "MANTENIMIENTO FUNDICION", "MANTENIMIENTO MAQUINADO", "MAQUINADO F2", "INSPECCIÓN FUNDICION", "INSPECCIÓN MAQUINADO", "MAQUINADO F1", "FUSION", "ASEGURAMIENTO DE CALIDAD F2", "REPARACION DE MOLDES", "PRODUCCIÓN"})
        Me.cbx_area.Location = New System.Drawing.Point(348, 31)
        Me.cbx_area.Name = "cbx_area"
        Me.cbx_area.Size = New System.Drawing.Size(306, 21)
        Me.cbx_area.TabIndex = 429
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(706, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 71)
        Me.Button2.TabIndex = 268
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Requerimientos_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 635)
        Me.Controls.Add(Me.lbl_area)
        Me.Controls.Add(Me.cbx_area)
        Me.Controls.Add(Me.lbl_req)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.btn_solicitar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Requerimientos_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mis requerimientos"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_solicitar As Button
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents lbl_req As Label
    Friend WithEvents lbl_area As Label
    Friend WithEvents cbx_area As ComboBox
End Class
