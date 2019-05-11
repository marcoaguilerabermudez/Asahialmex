<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFiltro
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
        Me.TxtFechaInicio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFechaFinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GrbEstado = New System.Windows.Forms.GroupBox()
        Me.RdFacturados = New System.Windows.Forms.RadioButton()
        Me.RdPendientes = New System.Windows.Forms.RadioButton()
        Me.RdCancelados = New System.Windows.Forms.RadioButton()
        Me.RdTodos = New System.Windows.Forms.RadioButton()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Agente = New System.Windows.Forms.Label()
        Me.CmbVendedor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnF3 = New System.Windows.Forms.Button()
        Me.RdFacturasCanceladas = New System.Windows.Forms.RadioButton()
        Me.RdFacturasTimbradas = New System.Windows.Forms.RadioButton()
        Me.GrbEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtFechaInicio
        '
        Me.TxtFechaInicio.Location = New System.Drawing.Point(21, 82)
        Me.TxtFechaInicio.Name = "TxtFechaInicio"
        Me.TxtFechaInicio.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaInicio.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Final"
        '
        'TxtFechaFinal
        '
        Me.TxtFechaFinal.Location = New System.Drawing.Point(158, 82)
        Me.TxtFechaFinal.Name = "TxtFechaFinal"
        Me.TxtFechaFinal.Size = New System.Drawing.Size(100, 20)
        Me.TxtFechaFinal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cliente :"
        '
        'GrbEstado
        '
        Me.GrbEstado.Controls.Add(Me.RdFacturasTimbradas)
        Me.GrbEstado.Controls.Add(Me.RdFacturasCanceladas)
        Me.GrbEstado.Controls.Add(Me.RdFacturados)
        Me.GrbEstado.Controls.Add(Me.RdPendientes)
        Me.GrbEstado.Controls.Add(Me.RdCancelados)
        Me.GrbEstado.Controls.Add(Me.RdTodos)
        Me.GrbEstado.Location = New System.Drawing.Point(15, 221)
        Me.GrbEstado.Name = "GrbEstado"
        Me.GrbEstado.Size = New System.Drawing.Size(265, 96)
        Me.GrbEstado.TabIndex = 13
        Me.GrbEstado.TabStop = False
        Me.GrbEstado.Text = "Estado"
        '
        'RdFacturados
        '
        Me.RdFacturados.AutoSize = True
        Me.RdFacturados.Location = New System.Drawing.Point(140, 70)
        Me.RdFacturados.Name = "RdFacturados"
        Me.RdFacturados.Size = New System.Drawing.Size(78, 17)
        Me.RdFacturados.TabIndex = 3
        Me.RdFacturados.TabStop = True
        Me.RdFacturados.Text = "Facturados"
        Me.RdFacturados.UseVisualStyleBackColor = True
        Me.RdFacturados.Visible = False
        '
        'RdPendientes
        '
        Me.RdPendientes.AutoSize = True
        Me.RdPendientes.Location = New System.Drawing.Point(29, 70)
        Me.RdPendientes.Name = "RdPendientes"
        Me.RdPendientes.Size = New System.Drawing.Size(78, 17)
        Me.RdPendientes.TabIndex = 2
        Me.RdPendientes.TabStop = True
        Me.RdPendientes.Text = "Pendientes"
        Me.RdPendientes.UseVisualStyleBackColor = True
        Me.RdPendientes.Visible = False
        '
        'RdCancelados
        '
        Me.RdCancelados.AutoSize = True
        Me.RdCancelados.Location = New System.Drawing.Point(140, 24)
        Me.RdCancelados.Name = "RdCancelados"
        Me.RdCancelados.Size = New System.Drawing.Size(81, 17)
        Me.RdCancelados.TabIndex = 1
        Me.RdCancelados.TabStop = True
        Me.RdCancelados.Text = "Cancelados"
        Me.RdCancelados.UseVisualStyleBackColor = True
        Me.RdCancelados.Visible = False
        '
        'RdTodos
        '
        Me.RdTodos.AutoSize = True
        Me.RdTodos.Location = New System.Drawing.Point(29, 24)
        Me.RdTodos.Name = "RdTodos"
        Me.RdTodos.Size = New System.Drawing.Size(55, 17)
        Me.RdTodos.TabIndex = 0
        Me.RdTodos.TabStop = True
        Me.RdTodos.Text = "Todos"
        Me.RdTodos.UseVisualStyleBackColor = True
        Me.RdTodos.Visible = False
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(18, 142)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(53, 20)
        Me.TxtCliente.TabIndex = 14
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(15, 12)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(84, 31)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'Agente
        '
        Me.Agente.AutoSize = True
        Me.Agente.Location = New System.Drawing.Point(77, 145)
        Me.Agente.Name = "Agente"
        Me.Agente.Size = New System.Drawing.Size(79, 13)
        Me.Agente.TabIndex = 15
        Me.Agente.Text = "Nombre Cliente"
        '
        'CmbVendedor
        '
        Me.CmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVendedor.FormattingEnabled = True
        Me.CmbVendedor.Location = New System.Drawing.Point(18, 194)
        Me.CmbVendedor.Name = "CmbVendedor"
        Me.CmbVendedor.Size = New System.Drawing.Size(259, 21)
        Me.CmbVendedor.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Vendedor"
        '
        'BtnF3
        '
        Me.BtnF3.Location = New System.Drawing.Point(44, 142)
        Me.BtnF3.Name = "BtnF3"
        Me.BtnF3.Size = New System.Drawing.Size(27, 19)
        Me.BtnF3.TabIndex = 17
        Me.BtnF3.Text = "F3"
        Me.BtnF3.UseVisualStyleBackColor = True
        '
        'RdFacturasCanceladas
        '
        Me.RdFacturasCanceladas.AutoSize = True
        Me.RdFacturasCanceladas.Location = New System.Drawing.Point(29, 47)
        Me.RdFacturasCanceladas.Name = "RdFacturasCanceladas"
        Me.RdFacturasCanceladas.Size = New System.Drawing.Size(81, 17)
        Me.RdFacturasCanceladas.TabIndex = 4
        Me.RdFacturasCanceladas.TabStop = True
        Me.RdFacturasCanceladas.Text = "Canceladas"
        Me.RdFacturasCanceladas.UseVisualStyleBackColor = True
        Me.RdFacturasCanceladas.Visible = False
        '
        'RdFacturasTimbradas
        '
        Me.RdFacturasTimbradas.AutoSize = True
        Me.RdFacturasTimbradas.Location = New System.Drawing.Point(140, 47)
        Me.RdFacturasTimbradas.Name = "RdFacturasTimbradas"
        Me.RdFacturasTimbradas.Size = New System.Drawing.Size(74, 17)
        Me.RdFacturasTimbradas.TabIndex = 5
        Me.RdFacturasTimbradas.TabStop = True
        Me.RdFacturasTimbradas.Text = "Timbradas"
        Me.RdFacturasTimbradas.UseVisualStyleBackColor = True
        Me.RdFacturasTimbradas.Visible = False
        '
        'FrmFiltro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 322)
        Me.Controls.Add(Me.BtnF3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmbVendedor)
        Me.Controls.Add(Me.Agente)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.GrbEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtFechaFinal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFechaInicio)
        Me.Name = "FrmFiltro"
        Me.Text = "Filtro"
        Me.GrbEstado.ResumeLayout(False)
        Me.GrbEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtFechaInicio As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtFechaFinal As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents GrbEstado As Windows.Forms.GroupBox
    Friend WithEvents RdFacturados As Windows.Forms.RadioButton
    Friend WithEvents RdPendientes As Windows.Forms.RadioButton
    Friend WithEvents RdCancelados As Windows.Forms.RadioButton
    Friend WithEvents RdTodos As Windows.Forms.RadioButton
    Friend WithEvents TxtCliente As Windows.Forms.TextBox
    Friend WithEvents BtnAceptar As Windows.Forms.Button
    Friend WithEvents ColorDialog1 As Windows.Forms.ColorDialog
    Friend WithEvents Agente As Windows.Forms.Label
    Friend WithEvents CmbVendedor As Windows.Forms.ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents BtnF3 As Windows.Forms.Button
    Friend WithEvents RdFacturasTimbradas As Windows.Forms.RadioButton
    Friend WithEvents RdFacturasCanceladas As Windows.Forms.RadioButton
End Class
