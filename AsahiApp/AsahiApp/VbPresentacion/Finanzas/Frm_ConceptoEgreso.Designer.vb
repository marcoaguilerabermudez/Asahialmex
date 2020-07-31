<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ConceptoEgreso
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btn_Guardar = New System.Windows.Forms.ToolStripButton()
        Me.Txt_Persona = New System.Windows.Forms.TextBox()
        Me.Txt_Concepto = New System.Windows.Forms.TextBox()
        Me.Gpb_Concepto = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_CuentaBanco = New System.Windows.Forms.Label()
        Me.Lbl_Banco = New System.Windows.Forms.Label()
        Me.Cmb_BancoSalida = New System.Windows.Forms.ComboBox()
        Me.Txt_IdPersona = New System.Windows.Forms.TextBox()
        Me.Lbl_Persona = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Gpb_Concepto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Guardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(522, 31)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Guardar.Image = Global.Presentacion.My.Resources.Resources.save
        Me.Btn_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(28, 28)
        Me.Btn_Guardar.Text = "ToolStripButton1"
        '
        'Txt_Persona
        '
        Me.Txt_Persona.BackColor = System.Drawing.Color.Gainsboro
        Me.Txt_Persona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Persona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Persona.Location = New System.Drawing.Point(2, 46)
        Me.Txt_Persona.Multiline = True
        Me.Txt_Persona.Name = "Txt_Persona"
        Me.Txt_Persona.ReadOnly = True
        Me.Txt_Persona.Size = New System.Drawing.Size(218, 20)
        Me.Txt_Persona.TabIndex = 2
        '
        'Txt_Concepto
        '
        Me.Txt_Concepto.BackColor = System.Drawing.Color.Gainsboro
        Me.Txt_Concepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Concepto.Dock = System.Windows.Forms.DockStyle.Right
        Me.Txt_Concepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Concepto.Location = New System.Drawing.Point(232, 22)
        Me.Txt_Concepto.Multiline = True
        Me.Txt_Concepto.Name = "Txt_Concepto"
        Me.Txt_Concepto.Size = New System.Drawing.Size(287, 172)
        Me.Txt_Concepto.TabIndex = 3
        '
        'Gpb_Concepto
        '
        Me.Gpb_Concepto.Controls.Add(Me.Panel1)
        Me.Gpb_Concepto.Controls.Add(Me.Txt_Concepto)
        Me.Gpb_Concepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gpb_Concepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gpb_Concepto.Location = New System.Drawing.Point(0, 31)
        Me.Gpb_Concepto.Name = "Gpb_Concepto"
        Me.Gpb_Concepto.Size = New System.Drawing.Size(522, 197)
        Me.Gpb_Concepto.TabIndex = 4
        Me.Gpb_Concepto.TabStop = False
        Me.Gpb_Concepto.Text = "Concepto"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Lbl_CuentaBanco)
        Me.Panel1.Controls.Add(Me.Lbl_Banco)
        Me.Panel1.Controls.Add(Me.Cmb_BancoSalida)
        Me.Panel1.Controls.Add(Me.Txt_IdPersona)
        Me.Panel1.Controls.Add(Me.Lbl_Persona)
        Me.Panel1.Controls.Add(Me.Txt_Persona)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 172)
        Me.Panel1.TabIndex = 4
        '
        'Lbl_CuentaBanco
        '
        Me.Lbl_CuentaBanco.AutoSize = True
        Me.Lbl_CuentaBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CuentaBanco.Location = New System.Drawing.Point(100, 94)
        Me.Lbl_CuentaBanco.Name = "Lbl_CuentaBanco"
        Me.Lbl_CuentaBanco.Size = New System.Drawing.Size(0, 16)
        Me.Lbl_CuentaBanco.TabIndex = 7
        '
        'Lbl_Banco
        '
        Me.Lbl_Banco.AutoSize = True
        Me.Lbl_Banco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Banco.Location = New System.Drawing.Point(3, 74)
        Me.Lbl_Banco.Name = "Lbl_Banco"
        Me.Lbl_Banco.Size = New System.Drawing.Size(47, 16)
        Me.Lbl_Banco.TabIndex = 6
        Me.Lbl_Banco.Text = "Banco"
        '
        'Cmb_BancoSalida
        '
        Me.Cmb_BancoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_BancoSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_BancoSalida.FormattingEnabled = True
        Me.Cmb_BancoSalida.Location = New System.Drawing.Point(62, 70)
        Me.Cmb_BancoSalida.Name = "Cmb_BancoSalida"
        Me.Cmb_BancoSalida.Size = New System.Drawing.Size(158, 21)
        Me.Cmb_BancoSalida.TabIndex = 5
        '
        'Txt_IdPersona
        '
        Me.Txt_IdPersona.BackColor = System.Drawing.Color.Gainsboro
        Me.Txt_IdPersona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_IdPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IdPersona.Location = New System.Drawing.Point(3, 22)
        Me.Txt_IdPersona.Name = "Txt_IdPersona"
        Me.Txt_IdPersona.ReadOnly = True
        Me.Txt_IdPersona.Size = New System.Drawing.Size(47, 20)
        Me.Txt_IdPersona.TabIndex = 4
        '
        'Lbl_Persona
        '
        Me.Lbl_Persona.AutoSize = True
        Me.Lbl_Persona.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Persona.Location = New System.Drawing.Point(4, 4)
        Me.Lbl_Persona.Name = "Lbl_Persona"
        Me.Lbl_Persona.Size = New System.Drawing.Size(74, 17)
        Me.Lbl_Persona.TabIndex = 3
        Me.Lbl_Persona.Text = "Proveedor"
        '
        'Frm_ConceptoEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 228)
        Me.Controls.Add(Me.Gpb_Concepto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ConceptoEgreso"
        Me.Text = "Concepto de Egreso"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Gpb_Concepto.ResumeLayout(False)
        Me.Gpb_Concepto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btn_Guardar As ToolStripButton
    Friend WithEvents Txt_Persona As TextBox
    Friend WithEvents Txt_Concepto As TextBox
    Friend WithEvents Gpb_Concepto As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txt_IdPersona As TextBox
    Friend WithEvents Lbl_Persona As Label
    Friend WithEvents Lbl_CuentaBanco As Label
    Friend WithEvents Lbl_Banco As Label
    Friend WithEvents Cmb_BancoSalida As ComboBox
End Class
