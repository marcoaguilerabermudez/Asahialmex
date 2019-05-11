<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRecuperar = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.DgvExportar = New System.Windows.Forms.DataGridView()
        Me.idFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diasCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabFacturas = New System.Windows.Forms.TabPage()
        Me.TabDetalles = New System.Windows.Forms.TabPage()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.idDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFacturaDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ivaTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmbSucursal = New System.Windows.Forms.ComboBox()
        CType(Me.DgvExportar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabFacturas.SuspendLayout()
        Me.TabDetalles.SuspendLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(213, 15)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(97, 20)
        Me.DtpFecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha"
        '
        'BtnRecuperar
        '
        Me.BtnRecuperar.Location = New System.Drawing.Point(4, 3)
        Me.BtnRecuperar.Name = "BtnRecuperar"
        Me.BtnRecuperar.Size = New System.Drawing.Size(66, 36)
        Me.BtnRecuperar.TabIndex = 2
        Me.BtnRecuperar.Text = "Recuperar"
        Me.BtnRecuperar.UseVisualStyleBackColor = True
        '
        'BtnExportar
        '
        Me.BtnExportar.Location = New System.Drawing.Point(76, 3)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(66, 36)
        Me.BtnExportar.TabIndex = 3
        Me.BtnExportar.Text = "Exportar"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'DgvExportar
        '
        Me.DgvExportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvExportar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idFactura, Me.idCliente, Me.rfc, Me.nombreCliente, Me.diasCredito, Me.subtotal, Me.iva, Me.total})
        Me.DgvExportar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvExportar.Location = New System.Drawing.Point(3, 3)
        Me.DgvExportar.Name = "DgvExportar"
        Me.DgvExportar.Size = New System.Drawing.Size(648, 331)
        Me.DgvExportar.TabIndex = 6
        '
        'idFactura
        '
        Me.idFactura.HeaderText = "Folio"
        Me.idFactura.Name = "idFactura"
        Me.idFactura.ReadOnly = True
        Me.idFactura.Width = 60
        '
        'idCliente
        '
        Me.idCliente.HeaderText = "Id Cte"
        Me.idCliente.Name = "idCliente"
        Me.idCliente.ReadOnly = True
        Me.idCliente.Width = 40
        '
        'rfc
        '
        Me.rfc.HeaderText = "RFC"
        Me.rfc.Name = "rfc"
        Me.rfc.ReadOnly = True
        Me.rfc.Width = 80
        '
        'nombreCliente
        '
        Me.nombreCliente.HeaderText = "Nombre Cliente"
        Me.nombreCliente.Name = "nombreCliente"
        Me.nombreCliente.ReadOnly = True
        Me.nombreCliente.Width = 150
        '
        'diasCredito
        '
        Me.diasCredito.HeaderText = "Credito"
        Me.diasCredito.Name = "diasCredito"
        Me.diasCredito.ReadOnly = True
        Me.diasCredito.Width = 30
        '
        'subtotal
        '
        DataGridViewCellStyle1.Format = "c2"
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 90
        '
        'iva
        '
        DataGridViewCellStyle2.Format = "c2"
        Me.iva.DefaultCellStyle = DataGridViewCellStyle2
        Me.iva.HeaderText = "Iva"
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        Me.iva.Width = 80
        '
        'total
        '
        DataGridViewCellStyle3.Format = "C2"
        Me.total.DefaultCellStyle = DataGridViewCellStyle3
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 90
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabFacturas)
        Me.TabControl1.Controls.Add(Me.TabDetalles)
        Me.TabControl1.Location = New System.Drawing.Point(4, 45)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(662, 363)
        Me.TabControl1.TabIndex = 7
        '
        'TabFacturas
        '
        Me.TabFacturas.Controls.Add(Me.DgvExportar)
        Me.TabFacturas.Location = New System.Drawing.Point(4, 22)
        Me.TabFacturas.Name = "TabFacturas"
        Me.TabFacturas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFacturas.Size = New System.Drawing.Size(654, 337)
        Me.TabFacturas.TabIndex = 0
        Me.TabFacturas.Text = "Facturas"
        Me.TabFacturas.UseVisualStyleBackColor = True
        '
        'TabDetalles
        '
        Me.TabDetalles.Controls.Add(Me.DgvDetalle)
        Me.TabDetalles.Location = New System.Drawing.Point(4, 22)
        Me.TabDetalles.Name = "TabDetalles"
        Me.TabDetalles.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetalles.Size = New System.Drawing.Size(654, 337)
        Me.TabDetalles.TabIndex = 1
        Me.TabDetalles.Text = "Detalles"
        Me.TabDetalles.UseVisualStyleBackColor = True
        '
        'DgvDetalle
        '
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idDetalle, Me.idFacturaDetalle, Me.codigo, Me.cantidad, Me.precio, Me.precioTotal, Me.ivaTotal, Me.SubtotalD})
        Me.DgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvDetalle.Location = New System.Drawing.Point(3, 3)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.Size = New System.Drawing.Size(648, 331)
        Me.DgvDetalle.TabIndex = 0
        '
        'idDetalle
        '
        Me.idDetalle.HeaderText = "idDetalle"
        Me.idDetalle.Name = "idDetalle"
        Me.idDetalle.ReadOnly = True
        Me.idDetalle.Visible = False
        '
        'idFacturaDetalle
        '
        Me.idFacturaDetalle.HeaderText = "Factura"
        Me.idFacturaDetalle.Name = "idFacturaDetalle"
        Me.idFacturaDetalle.ReadOnly = True
        Me.idFacturaDetalle.Width = 80
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 90
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cant"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 50
        '
        'precio
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.precio.DefaultCellStyle = DataGridViewCellStyle4
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 90
        '
        'precioTotal
        '
        DataGridViewCellStyle5.Format = "c2"
        Me.precioTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.precioTotal.HeaderText = "Precio Total"
        Me.precioTotal.Name = "precioTotal"
        Me.precioTotal.ReadOnly = True
        '
        'ivaTotal
        '
        DataGridViewCellStyle6.Format = "C2"
        Me.ivaTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.ivaTotal.HeaderText = "Iva Total"
        Me.ivaTotal.Name = "ivaTotal"
        Me.ivaTotal.ReadOnly = True
        Me.ivaTotal.Width = 90
        '
        'SubtotalD
        '
        DataGridViewCellStyle7.Format = "C2"
        Me.SubtotalD.DefaultCellStyle = DataGridViewCellStyle7
        Me.SubtotalD.HeaderText = "Subtotal"
        Me.SubtotalD.Name = "SubtotalD"
        Me.SubtotalD.ReadOnly = True
        '
        'CmbSucursal
        '
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(496, 14)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(163, 21)
        Me.CmbSucursal.TabIndex = 8
        '
        'FrmExportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 414)
        Me.Controls.Add(Me.CmbSucursal)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.BtnRecuperar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpFecha)
        Me.Name = "FrmExportar"
        Me.Text = "Exportar"
        CType(Me.DgvExportar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabFacturas.ResumeLayout(False)
        Me.TabDetalles.ResumeLayout(False)
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtpFecha As Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents BtnRecuperar As Windows.Forms.Button
    Friend WithEvents BtnExportar As Windows.Forms.Button
    Friend WithEvents DgvExportar As Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabFacturas As Windows.Forms.TabPage
    Friend WithEvents TabDetalles As Windows.Forms.TabPage
    Friend WithEvents DgvDetalle As Windows.Forms.DataGridView
    Friend WithEvents idFactura As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idCliente As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rfc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreCliente As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diasCredito As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iva As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idDetalle As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idFacturaDetalle As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioTotal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ivaTotal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtotalD As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmbSucursal As Windows.Forms.ComboBox
End Class
