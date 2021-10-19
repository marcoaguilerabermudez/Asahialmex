<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requerimientos_rechazo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requerimientos_rechazo))
        Me.txt_comen = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_comen
        '
        Me.txt_comen.BackColor = System.Drawing.SystemColors.Control
        Me.txt_comen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_comen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_comen.Location = New System.Drawing.Point(12, 12)
        Me.txt_comen.MaxLength = 99
        Me.txt_comen.Multiline = True
        Me.txt_comen.Name = "txt_comen"
        Me.txt_comen.Size = New System.Drawing.Size(313, 108)
        Me.txt_comen.TabIndex = 295
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_cancelar.Location = New System.Drawing.Point(102, 128)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(120, 35)
        Me.btn_cancelar.TabIndex = 450
        Me.btn_cancelar.Text = "Rechazar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Requerimientos_rechazo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 174)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.txt_comen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Requerimientos_rechazo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rechazar Requerimiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_comen As TextBox
    Friend WithEvents btn_cancelar As Button
End Class
