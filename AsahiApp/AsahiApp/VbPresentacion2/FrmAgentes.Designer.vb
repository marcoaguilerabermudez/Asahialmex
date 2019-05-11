<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgentes
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
        Me.DgvAgentes = New System.Windows.Forms.DataGridView()
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.TxtAgente = New System.Windows.Forms.TextBox()
        Me.LblAgente = New System.Windows.Forms.Label()
        CType(Me.DgvAgentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvAgentes
        '
        Me.DgvAgentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAgentes.Location = New System.Drawing.Point(12, 110)
        Me.DgvAgentes.Name = "DgvAgentes"
        Me.DgvAgentes.Size = New System.Drawing.Size(291, 188)
        Me.DgvAgentes.TabIndex = 1
        '
        'BtnAlta
        '
        Me.BtnAlta.Location = New System.Drawing.Point(12, 10)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(70, 30)
        Me.BtnAlta.TabIndex = 3
        Me.BtnAlta.Text = "Nuevo"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(158, 10)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(70, 30)
        Me.BtnEliminar.TabIndex = 5
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(85, 10)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(70, 30)
        Me.BtnModificar.TabIndex = 7
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'TxtAgente
        '
        Me.TxtAgente.Location = New System.Drawing.Point(62, 71)
        Me.TxtAgente.Name = "TxtAgente"
        Me.TxtAgente.Size = New System.Drawing.Size(241, 20)
        Me.TxtAgente.TabIndex = 9
        '
        'LblAgente
        '
        Me.LblAgente.AutoSize = True
        Me.LblAgente.Location = New System.Drawing.Point(12, 74)
        Me.LblAgente.Name = "LblAgente"
        Me.LblAgente.Size = New System.Drawing.Size(44, 13)
        Me.LblAgente.TabIndex = 11
        Me.LblAgente.Text = "Agente:"
        '
        'FrmAgentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 312)
        Me.Controls.Add(Me.LblAgente)
        Me.Controls.Add(Me.TxtAgente)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAlta)
        Me.Controls.Add(Me.DgvAgentes)
        Me.Name = "FrmAgentes"
        Me.Text = "Agentes"
        CType(Me.DgvAgentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvAgentes As Windows.Forms.DataGridView
    Friend WithEvents BtnAlta As Windows.Forms.Button
    Friend WithEvents BtnEliminar As Windows.Forms.Button
    Friend WithEvents BtnModificar As Windows.Forms.Button
    Friend WithEvents TxtAgente As Windows.Forms.TextBox
    Friend WithEvents LblAgente As Windows.Forms.Label
End Class
