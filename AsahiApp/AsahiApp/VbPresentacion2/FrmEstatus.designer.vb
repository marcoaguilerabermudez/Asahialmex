<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstatus
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
        Me.DgvEstatus = New System.Windows.Forms.DataGridView()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFechaIn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFechaFin = New System.Windows.Forms.TextBox()
        Me.BtnFiltrado = New System.Windows.Forms.Button()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.BtnFacturar = New System.Windows.Forms.Button()
        CType(Me.DgvEstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvEstatus
        '
        Me.DgvEstatus.AllowUserToOrderColumns = True
        Me.DgvEstatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEstatus.Location = New System.Drawing.Point(9, 50)
        Me.DgvEstatus.Name = "DgvEstatus"
        Me.DgvEstatus.ReadOnly = True
        Me.DgvEstatus.Size = New System.Drawing.Size(1428, 699)
        Me.DgvEstatus.TabIndex = 0
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(10, 13)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(47, 30)
        Me.BtnNuevo.TabIndex = 1
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(63, 12)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(61, 30)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(130, 12)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(61, 30)
        Me.BtnActualizar.TabIndex = 3
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha"
        '
        'TxtFechaIn
        '
        Me.TxtFechaIn.Location = New System.Drawing.Point(240, 19)
        Me.TxtFechaIn.Name = "TxtFechaIn"
        Me.TxtFechaIn.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaIn.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(347, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "A"
        '
        'TxtFechaFin
        '
        Me.TxtFechaFin.Location = New System.Drawing.Point(366, 18)
        Me.TxtFechaFin.Name = "TxtFechaFin"
        Me.TxtFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaFin.TabIndex = 7
        '
        'BtnFiltrado
        '
        Me.BtnFiltrado.Location = New System.Drawing.Point(595, 13)
        Me.BtnFiltrado.Name = "BtnFiltrado"
        Me.BtnFiltrado.Size = New System.Drawing.Size(50, 30)
        Me.BtnFiltrado.TabIndex = 8
        Me.BtnFiltrado.Text = "Filtrado"
        Me.BtnFiltrado.UseVisualStyleBackColor = True
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(472, 22)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(43, 13)
        Me.LblTipo.TabIndex = 9
        Me.LblTipo.Text = "Factura"
        '
        'TxtFolio
        '
        Me.TxtFolio.Location = New System.Drawing.Point(521, 19)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(68, 20)
        Me.TxtFolio.TabIndex = 10
        '
        'BtnFacturar
        '
        Me.BtnFacturar.Location = New System.Drawing.Point(745, 12)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.BtnFacturar.Size = New System.Drawing.Size(56, 30)
        Me.BtnFacturar.TabIndex = 11
        Me.BtnFacturar.Text = "Facturar"
        Me.BtnFacturar.UseVisualStyleBackColor = True
        Me.BtnFacturar.Visible = False
        '
        'FrmEstatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1449, 761)
        Me.Controls.Add(Me.BtnFacturar)
        Me.Controls.Add(Me.TxtFolio)
        Me.Controls.Add(Me.LblTipo)
        Me.Controls.Add(Me.BtnFiltrado)
        Me.Controls.Add(Me.TxtFechaFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtFechaIn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DgvEstatus)
        Me.Name = "FrmEstatus"
        Me.Text = "Estatus"
        CType(Me.DgvEstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnNuevo As Windows.Forms.Button
    Friend WithEvents BtnModificar As Windows.Forms.Button
    Friend WithEvents BtnActualizar As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtFechaIn As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtFechaFin As Windows.Forms.TextBox
    Friend WithEvents BtnFiltrado As Windows.Forms.Button
    Friend WithEvents LblTipo As Windows.Forms.Label
    Friend WithEvents TxtFolio As Windows.Forms.TextBox
    Friend WithEvents DgvEstatus As Windows.Forms.DataGridView
    Friend WithEvents BtnFacturar As Windows.Forms.Button
End Class
