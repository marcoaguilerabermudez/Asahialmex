<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFirma
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
        Me.TxtPassFirma = New System.Windows.Forms.TextBox()
        Me.TxtComenFirma = New System.Windows.Forms.TextBox()
        Me.BtnAceptado = New System.Windows.Forms.Button()
        Me.BtnRechazado = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtPassFirma
        '
        Me.TxtPassFirma.Location = New System.Drawing.Point(79, 23)
        Me.TxtPassFirma.Name = "TxtPassFirma"
        Me.TxtPassFirma.Size = New System.Drawing.Size(154, 20)
        Me.TxtPassFirma.TabIndex = 1
        Me.TxtPassFirma.UseSystemPasswordChar = True
        '
        'TxtComenFirma
        '
        Me.TxtComenFirma.Location = New System.Drawing.Point(12, 58)
        Me.TxtComenFirma.Multiline = True
        Me.TxtComenFirma.Name = "TxtComenFirma"
        Me.TxtComenFirma.Size = New System.Drawing.Size(221, 97)
        Me.TxtComenFirma.TabIndex = 3
        '
        'BtnAceptado
        '
        Me.BtnAceptado.Location = New System.Drawing.Point(12, 161)
        Me.BtnAceptado.Name = "BtnAceptado"
        Me.BtnAceptado.Size = New System.Drawing.Size(75, 32)
        Me.BtnAceptado.TabIndex = 5
        Me.BtnAceptado.Text = "Aceptado"
        Me.BtnAceptado.UseVisualStyleBackColor = True
        '
        'BtnRechazado
        '
        Me.BtnRechazado.Location = New System.Drawing.Point(158, 161)
        Me.BtnRechazado.Name = "BtnRechazado"
        Me.BtnRechazado.Size = New System.Drawing.Size(75, 32)
        Me.BtnRechazado.TabIndex = 6
        Me.BtnRechazado.Text = "Rechazado"
        Me.BtnRechazado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Contraseña"
        '
        'FrmFirma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 205)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRechazado)
        Me.Controls.Add(Me.BtnAceptado)
        Me.Controls.Add(Me.TxtComenFirma)
        Me.Controls.Add(Me.TxtPassFirma)
        Me.Name = "FrmFirma"
        Me.Text = "Firma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPassFirma As Windows.Forms.TextBox
    Friend WithEvents TxtComenFirma As Windows.Forms.TextBox
    Friend WithEvents BtnAceptado As Windows.Forms.Button
    Friend WithEvents BtnRechazado As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
