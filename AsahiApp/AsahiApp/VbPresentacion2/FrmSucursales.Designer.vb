<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSucursales
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DgvSucursales = New System.Windows.Forms.DataGridView()
        Me.BtnAbrir = New System.Windows.Forms.Button()
        CType(Me.DgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 21)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 10
        '
        'DgvSucursales
        '
        Me.DgvSucursales.AllowUserToAddRows = False
        Me.DgvSucursales.AllowUserToDeleteRows = False
        Me.DgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSucursales.Location = New System.Drawing.Point(0, 36)
        Me.DgvSucursales.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvSucursales.Name = "DgvSucursales"
        Me.DgvSucursales.ReadOnly = True
        Me.DgvSucursales.RowTemplate.Height = 24
        Me.DgvSucursales.Size = New System.Drawing.Size(198, 220)
        Me.DgvSucursales.TabIndex = 23
        '
        'BtnAbrir
        '
        Me.BtnAbrir.Location = New System.Drawing.Point(0, 8)
        Me.BtnAbrir.Name = "BtnAbrir"
        Me.BtnAbrir.Size = New System.Drawing.Size(75, 23)
        Me.BtnAbrir.TabIndex = 24
        Me.BtnAbrir.Text = "Abrir"
        Me.BtnAbrir.UseVisualStyleBackColor = True
        '
        'FrmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 256)
        Me.Controls.Add(Me.BtnAbrir)
        Me.Controls.Add(Me.DgvSucursales)
        Me.Controls.Add(Me.Label11)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmSucursales"
        Me.Text = "Sucursal"
        CType(Me.DgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents DgvSucursales As Windows.Forms.DataGridView
    Friend WithEvents BtnAbrir As Windows.Forms.Button
End Class
