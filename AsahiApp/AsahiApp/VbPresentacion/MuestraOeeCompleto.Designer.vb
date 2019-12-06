<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MuestraOeeCompleto
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MuestraOeeCompleto))
        Me.dtgv = New System.Windows.Forms.DataGridView()
        Me.dtgv2 = New System.Windows.Forms.DataGridView()
        Me.btn_actualiza = New System.Windows.Forms.Button()
        Me.lbl_oee = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_jap = New System.Windows.Forms.RadioButton()
        Me.btn_esp = New System.Windows.Forms.RadioButton()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_momento = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgv
        '
        Me.dtgv.AllowUserToAddRows = False
        Me.dtgv.AllowUserToDeleteRows = False
        Me.dtgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Format = "n0"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv.Location = New System.Drawing.Point(12, 86)
        Me.dtgv.Name = "dtgv"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv.RowHeadersVisible = False
        Me.dtgv.RowTemplate.Height = 36
        Me.dtgv.RowTemplate.ReadOnly = True
        Me.dtgv.Size = New System.Drawing.Size(820, 532)
        Me.dtgv.TabIndex = 483
        '
        'dtgv2
        '
        Me.dtgv2.AllowUserToAddRows = False
        Me.dtgv2.AllowUserToDeleteRows = False
        Me.dtgv2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtgv2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.dtgv2.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.Format = "n0"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv2.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtgv2.Location = New System.Drawing.Point(965, 86)
        Me.dtgv2.Name = "dtgv2"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgv2.RowHeadersVisible = False
        Me.dtgv2.RowTemplate.Height = 36
        Me.dtgv2.RowTemplate.ReadOnly = True
        Me.dtgv2.Size = New System.Drawing.Size(820, 532)
        Me.dtgv2.TabIndex = 484
        '
        'btn_actualiza
        '
        Me.btn_actualiza.Image = Global.Presentacion.My.Resources.Resources._1486504328_bullet_list_menu_lines_points_items_options_81334
        Me.btn_actualiza.Location = New System.Drawing.Point(838, 310)
        Me.btn_actualiza.Name = "btn_actualiza"
        Me.btn_actualiza.Size = New System.Drawing.Size(121, 76)
        Me.btn_actualiza.TabIndex = 485
        Me.btn_actualiza.Text = "Actualizar"
        Me.btn_actualiza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_actualiza.UseVisualStyleBackColor = True
        '
        'lbl_oee
        '
        Me.lbl_oee.AutoSize = True
        Me.lbl_oee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_oee.Location = New System.Drawing.Point(161, 7)
        Me.lbl_oee.Name = "lbl_oee"
        Me.lbl_oee.Size = New System.Drawing.Size(136, 20)
        Me.lbl_oee.TabIndex = 486
        Me.lbl_oee.Text = "OEE MENSUAL"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.btn_jap)
        Me.Panel5.Controls.Add(Me.btn_esp)
        Me.Panel5.Location = New System.Drawing.Point(3, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(106, 76)
        Me.Panel5.TabIndex = 504
        '
        'btn_jap
        '
        Me.btn_jap.AutoSize = True
        Me.btn_jap.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_jap.Location = New System.Drawing.Point(3, 52)
        Me.btn_jap.Name = "btn_jap"
        Me.btn_jap.Size = New System.Drawing.Size(61, 17)
        Me.btn_jap.TabIndex = 1
        Me.btn_jap.Text = "日本語"
        Me.btn_jap.UseVisualStyleBackColor = True
        '
        'btn_esp
        '
        Me.btn_esp.AutoSize = True
        Me.btn_esp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_esp.Location = New System.Drawing.Point(5, 2)
        Me.btn_esp.Name = "btn_esp"
        Me.btn_esp.Size = New System.Drawing.Size(63, 17)
        Me.btn_esp.TabIndex = 0
        Me.btn_esp.Text = "Español"
        Me.btn_esp.UseVisualStyleBackColor = True
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(162, 37)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(115, 16)
        Me.lbl_fecha.TabIndex = 505
        Me.lbl_fecha.Text = "OEE MENSUAL"
        '
        'lbl_momento
        '
        Me.lbl_momento.AutoSize = True
        Me.lbl_momento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_momento.Location = New System.Drawing.Point(382, 37)
        Me.lbl_momento.Name = "lbl_momento"
        Me.lbl_momento.Size = New System.Drawing.Size(115, 16)
        Me.lbl_momento.TabIndex = 507
        Me.lbl_momento.Text = "OEE MENSUAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 20)
        Me.Label2.TabIndex = 506
        Me.Label2.Text = "Última actualización"
        '
        'MuestraOeeCompleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 630)
        Me.Controls.Add(Me.lbl_momento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.lbl_oee)
        Me.Controls.Add(Me.btn_actualiza)
        Me.Controls.Add(Me.dtgv2)
        Me.Controls.Add(Me.dtgv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MuestraOeeCompleto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Muestra Oee Mensual"
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgv As DataGridView
    Friend WithEvents dtgv2 As DataGridView
    Friend WithEvents btn_actualiza As Button
    Friend WithEvents lbl_oee As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_jap As RadioButton
    Friend WithEvents btn_esp As RadioButton
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_momento As Label
    Friend WithEvents Label2 As Label
End Class
