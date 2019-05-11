<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaqueterias
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
        Me.DgvPaqueteria = New System.Windows.Forms.DataGridView()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnModifica = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TextNombreC = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TexTelf1 = New System.Windows.Forms.TextBox()
        Me.TexTelf2 = New System.Windows.Forms.TextBox()
        Me.TextContac = New System.Windows.Forms.TextBox()
        Me.TextConvenio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DgvPaqueteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvPaqueteria
        '
        Me.DgvPaqueteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPaqueteria.Location = New System.Drawing.Point(12, 180)
        Me.DgvPaqueteria.Name = "DgvPaqueteria"
        Me.DgvPaqueteria.Size = New System.Drawing.Size(410, 174)
        Me.DgvPaqueteria.TabIndex = 0
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(15, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 35)
        Me.BtnNuevo.TabIndex = 1
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModifica
        '
        Me.BtnModifica.Location = New System.Drawing.Point(96, 12)
        Me.BtnModifica.Name = "BtnModifica"
        Me.BtnModifica.Size = New System.Drawing.Size(75, 35)
        Me.BtnModifica.TabIndex = 2
        Me.BtnModifica.Text = "Modificar "
        Me.BtnModifica.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(177, 12)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 35)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TextNombreC
        '
        Me.TextNombreC.Location = New System.Drawing.Point(81, 97)
        Me.TextNombreC.Name = "TextNombreC"
        Me.TextNombreC.Size = New System.Drawing.Size(135, 20)
        Me.TextNombreC.TabIndex = 4
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(81, 68)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(341, 20)
        Me.TextNombre.TabIndex = 5
        '
        'TexTelf1
        '
        Me.TexTelf1.Location = New System.Drawing.Point(81, 149)
        Me.TexTelf1.Name = "TexTelf1"
        Me.TexTelf1.Size = New System.Drawing.Size(135, 20)
        Me.TexTelf1.TabIndex = 6
        '
        'TexTelf2
        '
        Me.TexTelf2.Location = New System.Drawing.Point(289, 149)
        Me.TexTelf2.Name = "TexTelf2"
        Me.TexTelf2.Size = New System.Drawing.Size(133, 20)
        Me.TexTelf2.TabIndex = 7
        '
        'TextContac
        '
        Me.TextContac.Location = New System.Drawing.Point(81, 124)
        Me.TextContac.Name = "TextContac"
        Me.TextContac.Size = New System.Drawing.Size(341, 20)
        Me.TextContac.TabIndex = 8
        '
        'TextConvenio
        '
        Me.TextConvenio.Location = New System.Drawing.Point(289, 97)
        Me.TextConvenio.Name = "TextConvenio"
        Me.TextConvenio.Size = New System.Drawing.Size(133, 20)
        Me.TextConvenio.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre Corto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nombre :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Telefono 1 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Telefono 2 :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Contacto :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(222, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "N° Covenio "
        '
        'FrmPaqueterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 356)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextConvenio)
        Me.Controls.Add(Me.TextContac)
        Me.Controls.Add(Me.TexTelf2)
        Me.Controls.Add(Me.TexTelf1)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.TextNombreC)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModifica)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DgvPaqueteria)
        Me.Name = "FrmPaqueterias"
        Me.Text = "Paqueterias"
        CType(Me.DgvPaqueteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvPaqueteria As Windows.Forms.DataGridView
    Friend WithEvents BtnNuevo As Windows.Forms.Button
    Friend WithEvents BtnModifica As Windows.Forms.Button
    Friend WithEvents BtnEliminar As Windows.Forms.Button
    Friend WithEvents TextNombreC As Windows.Forms.TextBox
    Friend WithEvents TextNombre As Windows.Forms.TextBox
    Friend WithEvents TexTelf1 As Windows.Forms.TextBox
    Friend WithEvents TexTelf2 As Windows.Forms.TextBox
    Friend WithEvents TextContac As Windows.Forms.TextBox
    Friend WithEvents TextConvenio As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
End Class
