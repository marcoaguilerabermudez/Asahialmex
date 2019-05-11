<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcas
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
        Me.DgvMarcas = New System.Windows.Forms.DataGridView()
        Me.BtnInserta = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModifica = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextMarca = New System.Windows.Forms.TextBox()
        CType(Me.DgvMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvMarcas
        '
        Me.DgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMarcas.Location = New System.Drawing.Point(12, 66)
        Me.DgvMarcas.Name = "DgvMarcas"
        Me.DgvMarcas.Size = New System.Drawing.Size(371, 203)
        Me.DgvMarcas.TabIndex = 0
        '
        'BtnInserta
        '
        Me.BtnInserta.Location = New System.Drawing.Point(12, 8)
        Me.BtnInserta.Name = "BtnInserta"
        Me.BtnInserta.Size = New System.Drawing.Size(75, 23)
        Me.BtnInserta.TabIndex = 1
        Me.BtnInserta.Text = "Nuevo"
        Me.BtnInserta.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(174, 8)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModifica
        '
        Me.BtnModifica.Location = New System.Drawing.Point(93, 8)
        Me.BtnModifica.Name = "BtnModifica"
        Me.BtnModifica.Size = New System.Drawing.Size(75, 23)
        Me.BtnModifica.TabIndex = 3
        Me.BtnModifica.Text = "Modifica"
        Me.BtnModifica.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Marca"
        '
        'TextMarca
        '
        Me.TextMarca.Location = New System.Drawing.Point(55, 40)
        Me.TextMarca.Name = "TextMarca"
        Me.TextMarca.Size = New System.Drawing.Size(331, 20)
        Me.TextMarca.TabIndex = 5
        Me.TextMarca.TabStop = False
        '
        'FrmMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 278)
        Me.Controls.Add(Me.TextMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnModifica)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnInserta)
        Me.Controls.Add(Me.DgvMarcas)
        Me.Name = "FrmMarcas"
        Me.Text = "Marcas "
        CType(Me.DgvMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvMarcas As Windows.Forms.DataGridView
    Friend WithEvents BtnInserta As Windows.Forms.Button
    Friend WithEvents BtnEliminar As Windows.Forms.Button
    Friend WithEvents BtnModifica As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TextMarca As Windows.Forms.TextBox
End Class
