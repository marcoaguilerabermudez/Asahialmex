<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ConceptoPoliza
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
        Me.Txt_Po = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Prov = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Familia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Proveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_SegNeg = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Guardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(482, 31)
        Me.ToolStrip1.TabIndex = 0
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
        'Txt_Po
        '
        Me.Txt_Po.BackColor = System.Drawing.Color.Gainsboro
        Me.Txt_Po.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Po.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Po.Location = New System.Drawing.Point(15, 84)
        Me.Txt_Po.Name = "Txt_Po"
        Me.Txt_Po.Size = New System.Drawing.Size(52, 23)
        Me.Txt_Po.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CONCEPTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PROVISIÓN"
        '
        'Txt_Prov
        '
        Me.Txt_Prov.BackColor = System.Drawing.Color.Gainsboro
        Me.Txt_Prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Prov.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Prov.Location = New System.Drawing.Point(70, 84)
        Me.Txt_Prov.Name = "Txt_Prov"
        Me.Txt_Prov.Size = New System.Drawing.Size(129, 23)
        Me.Txt_Prov.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(205, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "FAMILIA"
        '
        'Txt_Familia
        '
        Me.Txt_Familia.BackColor = System.Drawing.Color.Gainsboro
        Me.Txt_Familia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Familia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Familia.Location = New System.Drawing.Point(205, 84)
        Me.Txt_Familia.Name = "Txt_Familia"
        Me.Txt_Familia.Size = New System.Drawing.Size(265, 23)
        Me.Txt_Familia.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PROVEEDOR"
        '
        'Txt_Proveedor
        '
        Me.Txt_Proveedor.BackColor = System.Drawing.Color.Gainsboro
        Me.Txt_Proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Proveedor.Location = New System.Drawing.Point(12, 133)
        Me.Txt_Proveedor.Name = "Txt_Proveedor"
        Me.Txt_Proveedor.Size = New System.Drawing.Size(266, 23)
        Me.Txt_Proveedor.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(282, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "SEG NEG"
        '
        'Txt_SegNeg
        '
        Me.Txt_SegNeg.BackColor = System.Drawing.Color.Gainsboro
        Me.Txt_SegNeg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_SegNeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SegNeg.Location = New System.Drawing.Point(282, 133)
        Me.Txt_SegNeg.Name = "Txt_SegNeg"
        Me.Txt_SegNeg.Size = New System.Drawing.Size(61, 23)
        Me.Txt_SegNeg.TabIndex = 10
        '
        'Frm_ConceptoPoliza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 177)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txt_SegNeg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_Proveedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_Familia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_Prov)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Po)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ConceptoPoliza"
        Me.Text = "Frm_ConceptoPoliza"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btn_Guardar As ToolStripButton
    Friend WithEvents Txt_Po As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Prov As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Familia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Proveedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_SegNeg As TextBox
End Class
