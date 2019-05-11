<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSolicitudTraspasos
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
        Me.DgvProdSolicitud = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPedidoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSolicitudTraspaso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RbnASucursal = New System.Windows.Forms.RadioButton()
        Me.RbnACliente = New System.Windows.Forms.RadioButton()
        Me.CmbSucSolicitar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCteSuc = New System.Windows.Forms.TextBox()
        Me.TxtCodCteSuc = New System.Windows.Forms.TextBox()
        Me.LblCteSuc = New System.Windows.Forms.Label()
        Me.BtnSolicitar = New System.Windows.Forms.Button()
        Me.BtnImportar = New System.Windows.Forms.Button()
        Me.BtnF3 = New System.Windows.Forms.Button()
        Me.RbnFactura = New System.Windows.Forms.RadioButton()
        Me.RbnPedido = New System.Windows.Forms.RadioButton()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.GpbPedidoFactura = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        CType(Me.DgvProdSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpbPedidoFactura.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvProdSolicitud
        '
        Me.DgvProdSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProdSolicitud.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Cantidad, Me.Costo, Me.Precio, Me.IdPedidoFactura, Me.IdSolicitudTraspaso})
        Me.DgvProdSolicitud.Location = New System.Drawing.Point(5, 125)
        Me.DgvProdSolicitud.Name = "DgvProdSolicitud"
        Me.DgvProdSolicitud.RowHeadersWidth = 25
        Me.DgvProdSolicitud.Size = New System.Drawing.Size(567, 246)
        Me.DgvProdSolicitud.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 80
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 190
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 60
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Costo.Width = 70
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 70
        '
        'IdPedidoFactura
        '
        Me.IdPedidoFactura.HeaderText = "Pedido/ Factura"
        Me.IdPedidoFactura.Name = "IdPedidoFactura"
        Me.IdPedidoFactura.ReadOnly = True
        Me.IdPedidoFactura.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdPedidoFactura.Width = 70
        '
        'IdSolicitudTraspaso
        '
        Me.IdSolicitudTraspaso.HeaderText = "IdSolicitudTraspaso"
        Me.IdSolicitudTraspaso.Name = "IdSolicitudTraspaso"
        Me.IdSolicitudTraspaso.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdSolicitudTraspaso.Visible = False
        '
        'RbnASucursal
        '
        Me.RbnASucursal.AutoSize = True
        Me.RbnASucursal.Location = New System.Drawing.Point(373, 63)
        Me.RbnASucursal.Name = "RbnASucursal"
        Me.RbnASucursal.Size = New System.Drawing.Size(74, 17)
        Me.RbnASucursal.TabIndex = 18
        Me.RbnASucursal.Text = "A sucursal"
        Me.RbnASucursal.UseVisualStyleBackColor = True
        '
        'RbnACliente
        '
        Me.RbnACliente.AutoSize = True
        Me.RbnACliente.Checked = True
        Me.RbnACliente.Location = New System.Drawing.Point(275, 63)
        Me.RbnACliente.Name = "RbnACliente"
        Me.RbnACliente.Size = New System.Drawing.Size(66, 17)
        Me.RbnACliente.TabIndex = 17
        Me.RbnACliente.TabStop = True
        Me.RbnACliente.Text = "A cliente"
        Me.RbnACliente.UseVisualStyleBackColor = True
        '
        'CmbSucSolicitar
        '
        Me.CmbSucSolicitar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSucSolicitar.FormattingEnabled = True
        Me.CmbSucSolicitar.Location = New System.Drawing.Point(95, 61)
        Me.CmbSucSolicitar.Name = "CmbSucSolicitar"
        Me.CmbSucSolicitar.Size = New System.Drawing.Size(142, 21)
        Me.CmbSucSolicitar.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Solicitar a:"
        '
        'TxtCteSuc
        '
        Me.TxtCteSuc.Location = New System.Drawing.Point(128, 93)
        Me.TxtCteSuc.Name = "TxtCteSuc"
        Me.TxtCteSuc.ReadOnly = True
        Me.TxtCteSuc.Size = New System.Drawing.Size(402, 20)
        Me.TxtCteSuc.TabIndex = 16
        '
        'TxtCodCteSuc
        '
        Me.TxtCodCteSuc.Location = New System.Drawing.Point(72, 93)
        Me.TxtCodCteSuc.Name = "TxtCodCteSuc"
        Me.TxtCodCteSuc.ReadOnly = True
        Me.TxtCodCteSuc.Size = New System.Drawing.Size(55, 20)
        Me.TxtCodCteSuc.TabIndex = 15
        '
        'LblCteSuc
        '
        Me.LblCteSuc.AutoSize = True
        Me.LblCteSuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCteSuc.Location = New System.Drawing.Point(15, 93)
        Me.LblCteSuc.Name = "LblCteSuc"
        Me.LblCteSuc.Size = New System.Drawing.Size(45, 15)
        Me.LblCteSuc.TabIndex = 14
        Me.LblCteSuc.Text = "Cliente"
        '
        'BtnSolicitar
        '
        Me.BtnSolicitar.Location = New System.Drawing.Point(18, 12)
        Me.BtnSolicitar.Name = "BtnSolicitar"
        Me.BtnSolicitar.Size = New System.Drawing.Size(68, 35)
        Me.BtnSolicitar.TabIndex = 19
        Me.BtnSolicitar.Text = "Solicitar"
        Me.BtnSolicitar.UseVisualStyleBackColor = True
        '
        'BtnImportar
        '
        Me.BtnImportar.Location = New System.Drawing.Point(92, 12)
        Me.BtnImportar.Name = "BtnImportar"
        Me.BtnImportar.Size = New System.Drawing.Size(68, 35)
        Me.BtnImportar.TabIndex = 20
        Me.BtnImportar.Text = "Importar Artículos"
        Me.BtnImportar.UseVisualStyleBackColor = True
        '
        'BtnF3
        '
        Me.BtnF3.Location = New System.Drawing.Point(502, 227)
        Me.BtnF3.Name = "BtnF3"
        Me.BtnF3.Size = New System.Drawing.Size(29, 23)
        Me.BtnF3.TabIndex = 21
        Me.BtnF3.Text = "F3"
        Me.BtnF3.UseVisualStyleBackColor = True
        Me.BtnF3.Visible = False
        '
        'RbnFactura
        '
        Me.RbnFactura.AutoSize = True
        Me.RbnFactura.Location = New System.Drawing.Point(111, 12)
        Me.RbnFactura.Name = "RbnFactura"
        Me.RbnFactura.Size = New System.Drawing.Size(61, 17)
        Me.RbnFactura.TabIndex = 23
        Me.RbnFactura.Text = "Factura"
        Me.RbnFactura.UseVisualStyleBackColor = True
        '
        'RbnPedido
        '
        Me.RbnPedido.AutoSize = True
        Me.RbnPedido.Checked = True
        Me.RbnPedido.Location = New System.Drawing.Point(14, 12)
        Me.RbnPedido.Name = "RbnPedido"
        Me.RbnPedido.Size = New System.Drawing.Size(58, 17)
        Me.RbnPedido.TabIndex = 22
        Me.RbnPedido.TabStop = True
        Me.RbnPedido.Text = "Pedido"
        Me.RbnPedido.UseVisualStyleBackColor = True
        '
        'TxtFolio
        '
        Me.TxtFolio.Location = New System.Drawing.Point(449, 22)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(81, 20)
        Me.TxtFolio.TabIndex = 24
        '
        'GpbPedidoFactura
        '
        Me.GpbPedidoFactura.Controls.Add(Me.RbnFactura)
        Me.GpbPedidoFactura.Controls.Add(Me.RbnPedido)
        Me.GpbPedidoFactura.Location = New System.Drawing.Point(262, 12)
        Me.GpbPedidoFactura.Name = "GpbPedidoFactura"
        Me.GpbPedidoFactura.Size = New System.Drawing.Size(180, 35)
        Me.GpbPedidoFactura.TabIndex = 25
        Me.GpbPedidoFactura.TabStop = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(166, 12)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(68, 35)
        Me.BtnLimpiar.TabIndex = 26
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'FrmSolicitudTraspasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 375)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GpbPedidoFactura)
        Me.Controls.Add(Me.TxtFolio)
        Me.Controls.Add(Me.BtnF3)
        Me.Controls.Add(Me.BtnImportar)
        Me.Controls.Add(Me.BtnSolicitar)
        Me.Controls.Add(Me.RbnASucursal)
        Me.Controls.Add(Me.RbnACliente)
        Me.Controls.Add(Me.CmbSucSolicitar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCteSuc)
        Me.Controls.Add(Me.TxtCodCteSuc)
        Me.Controls.Add(Me.LblCteSuc)
        Me.Controls.Add(Me.DgvProdSolicitud)
        Me.Name = "FrmSolicitudTraspasos"
        Me.Text = "Solicitud de traspasos"
        CType(Me.DgvProdSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpbPedidoFactura.ResumeLayout(False)
        Me.GpbPedidoFactura.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvProdSolicitud As Windows.Forms.DataGridView
    Friend WithEvents RbnASucursal As Windows.Forms.RadioButton
    Friend WithEvents RbnACliente As Windows.Forms.RadioButton
    Friend WithEvents CmbSucSolicitar As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtCteSuc As Windows.Forms.TextBox
    Friend WithEvents TxtCodCteSuc As Windows.Forms.TextBox
    Friend WithEvents LblCteSuc As Windows.Forms.Label
    Friend WithEvents BtnSolicitar As Windows.Forms.Button
    Friend WithEvents BtnImportar As Windows.Forms.Button
    Friend WithEvents BtnF3 As Windows.Forms.Button
    Friend WithEvents Codigo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPedidoFactura As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSolicitudTraspaso As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RbnFactura As Windows.Forms.RadioButton
    Friend WithEvents RbnPedido As Windows.Forms.RadioButton
    Friend WithEvents TxtFolio As Windows.Forms.TextBox
    Friend WithEvents GpbPedidoFactura As Windows.Forms.GroupBox
    Friend WithEvents BtnLimpiar As Windows.Forms.Button
End Class
