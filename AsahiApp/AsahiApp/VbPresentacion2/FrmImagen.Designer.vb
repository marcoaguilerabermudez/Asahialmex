<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImagen
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
        Me.PictCaptura = New System.Windows.Forms.PictureBox()
        CType(Me.PictCaptura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictCaptura
        '
        Me.PictCaptura.Location = New System.Drawing.Point(-2, 0)
        Me.PictCaptura.Name = "PictCaptura"
        Me.PictCaptura.Size = New System.Drawing.Size(266, 209)
        Me.PictCaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictCaptura.TabIndex = 0
        Me.PictCaptura.TabStop = False
        '
        'FrmCaptura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(264, 211)
        Me.Controls.Add(Me.PictCaptura)
        Me.Name = "FrmCaptura"
        Me.Text = "Captura"
        CType(Me.PictCaptura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictCaptura As Windows.Forms.PictureBox
End Class
