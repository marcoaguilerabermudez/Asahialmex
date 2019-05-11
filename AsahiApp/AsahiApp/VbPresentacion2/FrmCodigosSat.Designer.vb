<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCodigosSat
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbDivision = New System.Windows.Forms.ComboBox()
        Me.CmbSubDivision = New System.Windows.Forms.ComboBox()
        Me.DgvCodigoSat = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RbCodigo = New System.Windows.Forms.RadioButton()
        Me.RbDescripcion = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.DgvCodigoSat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Divisiones SAT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sub divisiones SAT"
        '
        'CmbDivision
        '
        Me.CmbDivision.FormattingEnabled = True
        Me.CmbDivision.Location = New System.Drawing.Point(118, 9)
        Me.CmbDivision.Name = "CmbDivision"
        Me.CmbDivision.Size = New System.Drawing.Size(346, 21)
        Me.CmbDivision.TabIndex = 2
        '
        'CmbSubDivision
        '
        Me.CmbSubDivision.FormattingEnabled = True
        Me.CmbSubDivision.Location = New System.Drawing.Point(118, 36)
        Me.CmbSubDivision.Name = "CmbSubDivision"
        Me.CmbSubDivision.Size = New System.Drawing.Size(346, 21)
        Me.CmbSubDivision.TabIndex = 3
        '
        'DgvCodigoSat
        '
        Me.DgvCodigoSat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DgvCodigoSat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCodigoSat.Location = New System.Drawing.Point(9, 114)
        Me.DgvCodigoSat.Name = "DgvCodigoSat"
        Me.DgvCodigoSat.RowHeadersVisible = False
        Me.DgvCodigoSat.Size = New System.Drawing.Size(455, 461)
        Me.DgvCodigoSat.TabIndex = 4
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(118, 88)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(258, 20)
        Me.txtBuscar.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Buscar Producto"
        '
        'RbCodigo
        '
        Me.RbCodigo.AutoSize = True
        Me.RbCodigo.Location = New System.Drawing.Point(118, 64)
        Me.RbCodigo.Name = "RbCodigo"
        Me.RbCodigo.Size = New System.Drawing.Size(77, 17)
        Me.RbCodigo.TabIndex = 7
        Me.RbCodigo.TabStop = True
        Me.RbCodigo.Text = "Por Codigo"
        Me.RbCodigo.UseVisualStyleBackColor = True
        '
        'RbDescripcion
        '
        Me.RbDescripcion.AutoSize = True
        Me.RbDescripcion.Location = New System.Drawing.Point(214, 65)
        Me.RbDescripcion.Name = "RbDescripcion"
        Me.RbDescripcion.Size = New System.Drawing.Size(100, 17)
        Me.RbDescripcion.TabIndex = 8
        Me.RbDescripcion.TabStop = True
        Me.RbDescripcion.Text = "Por Descripcion"
        Me.RbDescripcion.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(389, 79)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 29)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FrmCodigosSat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(476, 585)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.RbDescripcion)
        Me.Controls.Add(Me.RbCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.DgvCodigoSat)
        Me.Controls.Add(Me.CmbSubDivision)
        Me.Controls.Add(Me.CmbDivision)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FrmCodigosSat"
        Me.Text = "Busqueda de Codigos del SAT"
        CType(Me.DgvCodigoSat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents CmbDivision As Windows.Forms.ComboBox
    Friend WithEvents CmbSubDivision As Windows.Forms.ComboBox
    Friend WithEvents DgvCodigoSat As Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents RbCodigo As Windows.Forms.RadioButton
    Friend WithEvents RbDescripcion As Windows.Forms.RadioButton
    Friend WithEvents btnBuscar As Windows.Forms.Button
End Class
