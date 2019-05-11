<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClase
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
        Me.DgvClases = New System.Windows.Forms.DataGridView()
        Me.TxtClase = New System.Windows.Forms.TextBox()
        Me.LblClase = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        CType(Me.DgvClases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvClases
        '
        Me.DgvClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClases.Location = New System.Drawing.Point(12, 116)
        Me.DgvClases.Name = "DgvClases"
        Me.DgvClases.Size = New System.Drawing.Size(229, 185)
        Me.DgvClases.TabIndex = 1
        '
        'TxtClase
        '
        Me.TxtClase.Location = New System.Drawing.Point(51, 74)
        Me.TxtClase.Name = "TxtClase"
        Me.TxtClase.Size = New System.Drawing.Size(190, 20)
        Me.TxtClase.TabIndex = 3
        '
        'LblClase
        '
        Me.LblClase.AutoSize = True
        Me.LblClase.Location = New System.Drawing.Point(12, 77)
        Me.LblClase.Name = "LblClase"
        Me.LblClase.Size = New System.Drawing.Size(36, 13)
        Me.LblClase.TabIndex = 5
        Me.LblClase.Text = "Clase:"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(14, 9)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(70, 30)
        Me.BtnNuevo.TabIndex = 7
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(89, 9)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(70, 30)
        Me.BtnModificar.TabIndex = 8
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(164, 9)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(70, 30)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FrmClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 313)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.LblClase)
        Me.Controls.Add(Me.TxtClase)
        Me.Controls.Add(Me.DgvClases)
        Me.Name = "FrmClase"
        Me.Text = "Clases"
        CType(Me.DgvClases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvClases As Windows.Forms.DataGridView
    Friend WithEvents TxtClase As Windows.Forms.TextBox
    Friend WithEvents LblClase As Windows.Forms.Label
    Friend WithEvents BtnNuevo As Windows.Forms.Button
    Friend WithEvents BtnModificar As Windows.Forms.Button
    Friend WithEvents BtnEliminar As Windows.Forms.Button
End Class
