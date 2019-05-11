<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReembolso
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.DgvReembolso = New System.Windows.Forms.DataGridView()
        Me.TxtCheque = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTotales = New System.Windows.Forms.Label()
        Me.TxtTotalSubtotal = New System.Windows.Forms.TextBox()
        Me.TxtTotalOtros = New System.Windows.Forms.TextBox()
        Me.TxtTotalIva = New System.Windows.Forms.TextBox()
        Me.TxtTotalRetenIva = New System.Windows.Forms.TextBox()
        Me.TxtTotalRetenIsr = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtTotalNeto = New System.Windows.Forms.TextBox()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnF3 = New System.Windows.Forms.Button()
        Me.GrpBoxAlta = New System.Windows.Forms.GroupBox()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Otros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetenIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetenISR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idReembolso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvReembolso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxAlta.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(8, 14)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(62, 32)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(71, 14)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(62, 32)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(135, 14)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(62, 32)
        Me.BtnLimpiar.TabIndex = 2
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'TxtProveedor
        '
        Me.TxtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProveedor.Location = New System.Drawing.Point(22, 26)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(332, 20)
        Me.TxtProveedor.TabIndex = 3
        '
        'DgvReembolso
        '
        Me.DgvReembolso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReembolso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Factura, Me.Nombre, Me.Subtotal, Me.Otros, Me.Iva, Me.RetenIVA, Me.RetenISR, Me.Total, Me.TotalNeto, Me.idProveedor, Me.idReembolso})
        Me.DgvReembolso.Location = New System.Drawing.Point(8, 84)
        Me.DgvReembolso.Name = "DgvReembolso"
        Me.DgvReembolso.Size = New System.Drawing.Size(853, 234)
        Me.DgvReembolso.TabIndex = 5
        '
        'TxtCheque
        '
        Me.TxtCheque.Location = New System.Drawing.Point(666, 29)
        Me.TxtCheque.Name = "TxtCheque"
        Me.TxtCheque.Size = New System.Drawing.Size(79, 20)
        Me.TxtCheque.TabIndex = 6
        Me.TxtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(761, 29)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.ReadOnly = True
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 7
        Me.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(665, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "No. Cheque"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(760, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fecha"
        '
        'LblTotales
        '
        Me.LblTotales.AutoSize = True
        Me.LblTotales.Location = New System.Drawing.Point(290, 326)
        Me.LblTotales.Name = "LblTotales"
        Me.LblTotales.Size = New System.Drawing.Size(42, 13)
        Me.LblTotales.TabIndex = 10
        Me.LblTotales.Text = "Totales"
        '
        'TxtTotalSubtotal
        '
        Me.TxtTotalSubtotal.Location = New System.Drawing.Point(337, 324)
        Me.TxtTotalSubtotal.Name = "TxtTotalSubtotal"
        Me.TxtTotalSubtotal.ReadOnly = True
        Me.TxtTotalSubtotal.Size = New System.Drawing.Size(75, 20)
        Me.TxtTotalSubtotal.TabIndex = 11
        Me.TxtTotalSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTotalOtros
        '
        Me.TxtTotalOtros.Location = New System.Drawing.Point(414, 324)
        Me.TxtTotalOtros.Name = "TxtTotalOtros"
        Me.TxtTotalOtros.ReadOnly = True
        Me.TxtTotalOtros.Size = New System.Drawing.Size(77, 20)
        Me.TxtTotalOtros.TabIndex = 12
        Me.TxtTotalOtros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTotalIva
        '
        Me.TxtTotalIva.Location = New System.Drawing.Point(493, 324)
        Me.TxtTotalIva.Name = "TxtTotalIva"
        Me.TxtTotalIva.ReadOnly = True
        Me.TxtTotalIva.Size = New System.Drawing.Size(71, 20)
        Me.TxtTotalIva.TabIndex = 13
        Me.TxtTotalIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTotalRetenIva
        '
        Me.TxtTotalRetenIva.Location = New System.Drawing.Point(566, 324)
        Me.TxtTotalRetenIva.Name = "TxtTotalRetenIva"
        Me.TxtTotalRetenIva.ReadOnly = True
        Me.TxtTotalRetenIva.Size = New System.Drawing.Size(74, 20)
        Me.TxtTotalRetenIva.TabIndex = 14
        Me.TxtTotalRetenIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTotalRetenIsr
        '
        Me.TxtTotalRetenIsr.Location = New System.Drawing.Point(642, 324)
        Me.TxtTotalRetenIsr.Name = "TxtTotalRetenIsr"
        Me.TxtTotalRetenIsr.ReadOnly = True
        Me.TxtTotalRetenIsr.Size = New System.Drawing.Size(72, 20)
        Me.TxtTotalRetenIsr.TabIndex = 15
        Me.TxtTotalRetenIsr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(716, 324)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(67, 20)
        Me.TxtTotal.TabIndex = 16
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTotalNeto
        '
        Me.TxtTotalNeto.Location = New System.Drawing.Point(785, 324)
        Me.TxtTotalNeto.Name = "TxtTotalNeto"
        Me.TxtTotalNeto.ReadOnly = True
        Me.TxtTotalNeto.Size = New System.Drawing.Size(76, 20)
        Me.TxtTotalNeto.TabIndex = 17
        Me.TxtTotalNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(354, 24)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(49, 23)
        Me.BtnNew.TabIndex = 18
        Me.BtnNew.Text = "Nuevo"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnF3
        '
        Me.BtnF3.Location = New System.Drawing.Point(339, 105)
        Me.BtnF3.Name = "BtnF3"
        Me.BtnF3.Size = New System.Drawing.Size(27, 23)
        Me.BtnF3.TabIndex = 19
        Me.BtnF3.Text = "F3"
        Me.BtnF3.UseVisualStyleBackColor = True
        '
        'GrpBoxAlta
        '
        Me.GrpBoxAlta.Controls.Add(Me.TxtProveedor)
        Me.GrpBoxAlta.Controls.Add(Me.BtnNew)
        Me.GrpBoxAlta.Location = New System.Drawing.Point(222, 12)
        Me.GrpBoxAlta.Name = "GrpBoxAlta"
        Me.GrpBoxAlta.Size = New System.Drawing.Size(418, 66)
        Me.GrpBoxAlta.TabIndex = 20
        Me.GrpBoxAlta.TabStop = False
        Me.GrpBoxAlta.Text = " Alta Proveedor"
        '
        'Factura
        '
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.Width = 90
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'Subtotal
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Width = 75
        '
        'Otros
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Otros.DefaultCellStyle = DataGridViewCellStyle2
        Me.Otros.HeaderText = "Otros"
        Me.Otros.Name = "Otros"
        Me.Otros.Width = 75
        '
        'Iva
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Iva.DefaultCellStyle = DataGridViewCellStyle3
        Me.Iva.HeaderText = "Iva"
        Me.Iva.Name = "Iva"
        Me.Iva.Width = 70
        '
        'RetenIVA
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.RetenIVA.DefaultCellStyle = DataGridViewCellStyle4
        Me.RetenIVA.HeaderText = "RetenIVA"
        Me.RetenIVA.Name = "RetenIVA"
        Me.RetenIVA.Width = 75
        '
        'RetenISR
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.RetenISR.DefaultCellStyle = DataGridViewCellStyle5
        Me.RetenISR.HeaderText = "RetenISR"
        Me.RetenISR.Name = "RetenISR"
        Me.RetenISR.Width = 75
        '
        'Total
        '
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle6
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 75
        '
        'TotalNeto
        '
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.TotalNeto.DefaultCellStyle = DataGridViewCellStyle7
        Me.TotalNeto.HeaderText = "TotalNeto"
        Me.TotalNeto.Name = "TotalNeto"
        Me.TotalNeto.ReadOnly = True
        Me.TotalNeto.Width = 75
        '
        'idProveedor
        '
        Me.idProveedor.HeaderText = "idProveedor"
        Me.idProveedor.Name = "idProveedor"
        Me.idProveedor.Visible = False
        '
        'idReembolso
        '
        Me.idReembolso.HeaderText = "idReembolso"
        Me.idReembolso.Name = "idReembolso"
        Me.idReembolso.Visible = False
        '
        'FrmReembolso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 360)
        Me.Controls.Add(Me.GrpBoxAlta)
        Me.Controls.Add(Me.BtnF3)
        Me.Controls.Add(Me.TxtTotalNeto)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtTotalRetenIsr)
        Me.Controls.Add(Me.TxtTotalRetenIva)
        Me.Controls.Add(Me.TxtTotalIva)
        Me.Controls.Add(Me.TxtTotalOtros)
        Me.Controls.Add(Me.TxtTotalSubtotal)
        Me.Controls.Add(Me.LblTotales)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtCheque)
        Me.Controls.Add(Me.DgvReembolso)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "FrmReembolso"
        Me.Text = "Reembolso"
        CType(Me.DgvReembolso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxAlta.ResumeLayout(False)
        Me.GrpBoxAlta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents BtnCancelar As Windows.Forms.Button
    Friend WithEvents BtnLimpiar As Windows.Forms.Button
    Friend WithEvents TxtProveedor As Windows.Forms.TextBox
    Friend WithEvents DgvReembolso As Windows.Forms.DataGridView
    Friend WithEvents TxtCheque As Windows.Forms.TextBox
    Friend WithEvents TxtFecha As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents LblTotales As Windows.Forms.Label
    Friend WithEvents TxtTotalSubtotal As Windows.Forms.TextBox
    Friend WithEvents TxtTotalOtros As Windows.Forms.TextBox
    Friend WithEvents TxtTotalIva As Windows.Forms.TextBox
    Friend WithEvents TxtTotalRetenIva As Windows.Forms.TextBox
    Friend WithEvents TxtTotalRetenIsr As Windows.Forms.TextBox
    Friend WithEvents TxtTotal As Windows.Forms.TextBox
    Friend WithEvents TxtTotalNeto As Windows.Forms.TextBox
    Friend WithEvents BtnNew As Windows.Forms.Button
    Friend WithEvents BtnF3 As Windows.Forms.Button
    Friend WithEvents GrpBoxAlta As Windows.Forms.GroupBox
    Friend WithEvents Factura As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Otros As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Iva As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetenIVA As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetenISR As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalNeto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProveedor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idReembolso As Windows.Forms.DataGridViewTextBoxColumn
End Class
