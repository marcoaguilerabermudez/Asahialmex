<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.BtnPreNomina = New System.Windows.Forms.Button()
        Me.BtnControlProduc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPreNomina
        '
        Me.BtnPreNomina.Location = New System.Drawing.Point(118, 84)
        Me.BtnPreNomina.Name = "BtnPreNomina"
        Me.BtnPreNomina.Size = New System.Drawing.Size(89, 55)
        Me.BtnPreNomina.TabIndex = 0
        Me.BtnPreNomina.Text = "Pre nomina"
        Me.BtnPreNomina.UseVisualStyleBackColor = True
        '
        'BtnControlProduc
        '
        Me.BtnControlProduc.Location = New System.Drawing.Point(479, 84)
        Me.BtnControlProduc.Name = "BtnControlProduc"
        Me.BtnControlProduc.Size = New System.Drawing.Size(89, 55)
        Me.BtnControlProduc.TabIndex = 1
        Me.BtnControlProduc.Text = "Control de Producción"
        Me.BtnControlProduc.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 501)
        Me.Controls.Add(Me.BtnControlProduc)
        Me.Controls.Add(Me.BtnPreNomina)
        Me.Name = "FrmPrincipal"
        Me.Text = "AsahiApp"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPreNomina As Button
    Friend WithEvents BtnControlProduc As Button
End Class
