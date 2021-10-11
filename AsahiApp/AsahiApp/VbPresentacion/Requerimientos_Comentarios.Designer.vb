<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Requerimientos_Comentarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Requerimientos_Comentarios))
        Me.txt_descr = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_descr
        '
        Me.txt_descr.BackColor = System.Drawing.SystemColors.Control
        Me.txt_descr.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_descr.Location = New System.Drawing.Point(6, 10)
        Me.txt_descr.MaxLength = 100
        Me.txt_descr.Multiline = True
        Me.txt_descr.Name = "txt_descr"
        Me.txt_descr.Size = New System.Drawing.Size(303, 96)
        Me.txt_descr.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = Global.Presentacion.My.Resources.Resources.prueba_de_educacion
        Me.Button1.Location = New System.Drawing.Point(93, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 55)
        Me.Button1.TabIndex = 330
        Me.Button1.Text = "Comentarios"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Requerimientos_Comentarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 202)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_descr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Requerimientos_Comentarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comentarios Generales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_descr As TextBox
    Friend WithEvents Button1 As Button
End Class
