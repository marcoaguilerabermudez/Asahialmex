<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCotizaciones
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
        Me.LblSubtotal = New System.Windows.Forms.Label()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.LblDispo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblExist = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtIva = New System.Windows.Forms.TextBox()
        Me.LblIva = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.btnF3 = New System.Windows.Forms.Button()
        Me.LblComenta = New System.Windows.Forms.Label()
        Me.RTxtComenta = New System.Windows.Forms.RichTextBox()
        Me.TxtNombreCte = New System.Windows.Forms.TextBox()
        Me.LblCte = New System.Windows.Forms.Label()
        Me.DgvPedidos = New System.Windows.Forms.DataGridView()
        Me.IdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantSurtida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigoSat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnaIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Utilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCodCte = New System.Windows.Forms.TextBox()
        Me.CmbDiasCred = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblDiasCred = New System.Windows.Forms.Label()
        Me.LblOrdeno = New System.Windows.Forms.Label()
        Me.TxtContacto = New System.Windows.Forms.TextBox()
        Me.LblPedido = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LblFormaPago = New System.Windows.Forms.Label()
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtTipoCte = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnPdf = New System.Windows.Forms.Button()
        Me.LnumLetra = New System.Windows.Forms.Label()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSubtotal
        '
        Me.LblSubtotal.AutoSize = True
        Me.LblSubtotal.Location = New System.Drawing.Point(719, 527)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.LblSubtotal.TabIndex = 108
        Me.LblSubtotal.Text = "Subtotal"
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Location = New System.Drawing.Point(771, 523)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.ReadOnly = True
        Me.TxtSubtotal.Size = New System.Drawing.Size(87, 20)
        Me.TxtSubtotal.TabIndex = 107
        '
        'LblDispo
        '
        Me.LblDispo.AutoSize = True
        Me.LblDispo.Location = New System.Drawing.Point(153, 637)
        Me.LblDispo.Name = "LblDispo"
        Me.LblDispo.Size = New System.Drawing.Size(13, 13)
        Me.LblDispo.TabIndex = 106
        Me.LblDispo.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 637)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Disponible"
        '
        'LblExist
        '
        Me.LblExist.AutoSize = True
        Me.LblExist.Location = New System.Drawing.Point(77, 637)
        Me.LblExist.Name = "LblExist"
        Me.LblExist.Size = New System.Drawing.Size(13, 13)
        Me.LblExist.TabIndex = 104
        Me.LblExist.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 637)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Existencias"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(771, 575)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(87, 20)
        Me.TxtTotal.TabIndex = 102
        '
        'TxtIva
        '
        Me.TxtIva.Location = New System.Drawing.Point(771, 549)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.ReadOnly = True
        Me.TxtIva.Size = New System.Drawing.Size(87, 20)
        Me.TxtIva.TabIndex = 101
        '
        'LblIva
        '
        Me.LblIva.AutoSize = True
        Me.LblIva.Location = New System.Drawing.Point(727, 554)
        Me.LblIva.Name = "LblIva"
        Me.LblIva.Size = New System.Drawing.Size(22, 13)
        Me.LblIva.TabIndex = 91
        Me.LblIva.Text = "Iva"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(724, 575)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(31, 13)
        Me.LblTotal.TabIndex = 90
        Me.LblTotal.Text = "Total"
        '
        'btnF3
        '
        Me.btnF3.Location = New System.Drawing.Point(727, 304)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(28, 21)
        Me.btnF3.TabIndex = 71
        Me.btnF3.Text = "F3"
        Me.btnF3.UseVisualStyleBackColor = True
        Me.btnF3.Visible = False
        '
        'LblComenta
        '
        Me.LblComenta.AutoSize = True
        Me.LblComenta.Location = New System.Drawing.Point(13, 556)
        Me.LblComenta.Name = "LblComenta"
        Me.LblComenta.Size = New System.Drawing.Size(65, 13)
        Me.LblComenta.TabIndex = 89
        Me.LblComenta.Text = "Comentarios"
        '
        'RTxtComenta
        '
        Me.RTxtComenta.Location = New System.Drawing.Point(15, 572)
        Me.RTxtComenta.Name = "RTxtComenta"
        Me.RTxtComenta.Size = New System.Drawing.Size(640, 43)
        Me.RTxtComenta.TabIndex = 88
        Me.RTxtComenta.Text = ""
        '
        'TxtNombreCte
        '
        Me.TxtNombreCte.Location = New System.Drawing.Point(122, 65)
        Me.TxtNombreCte.Name = "TxtNombreCte"
        Me.TxtNombreCte.ReadOnly = True
        Me.TxtNombreCte.Size = New System.Drawing.Size(731, 20)
        Me.TxtNombreCte.TabIndex = 72
        '
        'LblCte
        '
        Me.LblCte.AutoSize = True
        Me.LblCte.Location = New System.Drawing.Point(12, 68)
        Me.LblCte.Name = "LblCte"
        Me.LblCte.Size = New System.Drawing.Size(39, 13)
        Me.LblCte.TabIndex = 69
        Me.LblCte.Text = "Cliente"
        '
        'DgvPedidos
        '
        Me.DgvPedidos.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalle, Me.Cantidad, Me.CantSurtida, Me.Unidad, Me.Codigo, Me.codigoSat, Me.Descripcion, Me.Precio, Me.precioTotal, Me.Costo, Me.Precio2, Me.Precio3, Me.Marca, Me.ColumnaIva, Me.Subtotal, Me.Existencia, Me.Disponible, Me.Utilidad})
        Me.DgvPedidos.Location = New System.Drawing.Point(12, 139)
        Me.DgvPedidos.Name = "DgvPedidos"
        Me.DgvPedidos.Size = New System.Drawing.Size(841, 378)
        Me.DgvPedidos.StandardTab = True
        Me.DgvPedidos.TabIndex = 87
        '
        'IdDetalle
        '
        Me.IdDetalle.HeaderText = "IdDetalle"
        Me.IdDetalle.Name = "IdDetalle"
        Me.IdDetalle.Visible = False
        '
        'Cantidad
        '
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cantidad.HeaderText = "Cant"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 50
        '
        'CantSurtida
        '
        Me.CantSurtida.HeaderText = "CantSurtida"
        Me.CantSurtida.Name = "CantSurtida"
        Me.CantSurtida.Visible = False
        Me.CantSurtida.Width = 70
        '
        'Unidad
        '
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        Me.Unidad.Width = 50
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 60
        '
        'codigoSat
        '
        Me.codigoSat.HeaderText = "CodigoSat"
        Me.codigoSat.Name = "codigoSat"
        Me.codigoSat.ReadOnly = True
        Me.codigoSat.Width = 80
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 230
        '
        'Precio
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle3
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 80
        '
        'precioTotal
        '
        Me.precioTotal.HeaderText = "PrecioTotal"
        Me.precioTotal.Name = "precioTotal"
        Me.precioTotal.ReadOnly = True
        Me.precioTotal.Width = 80
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Visible = False
        Me.Costo.Width = 85
        '
        'Precio2
        '
        Me.Precio2.HeaderText = "Precio2"
        Me.Precio2.Name = "Precio2"
        Me.Precio2.Visible = False
        '
        'Precio3
        '
        Me.Precio3.HeaderText = "Precio3"
        Me.Precio3.Name = "Precio3"
        Me.Precio3.Visible = False
        Me.Precio3.Width = 80
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.Visible = False
        '
        'ColumnaIva
        '
        Me.ColumnaIva.HeaderText = "Iva"
        Me.ColumnaIva.Name = "ColumnaIva"
        Me.ColumnaIva.ReadOnly = True
        Me.ColumnaIva.Width = 80
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 90
        '
        'Existencia
        '
        Me.Existencia.HeaderText = "Exist"
        Me.Existencia.Name = "Existencia"
        Me.Existencia.Visible = False
        '
        'Disponible
        '
        Me.Disponible.HeaderText = "Dispo"
        Me.Disponible.Name = "Disponible"
        Me.Disponible.Visible = False
        '
        'Utilidad
        '
        Me.Utilidad.HeaderText = "Utilidad"
        Me.Utilidad.Name = "Utilidad"
        Me.Utilidad.Visible = False
        Me.Utilidad.Width = 85
        '
        'TxtCodCte
        '
        Me.TxtCodCte.Location = New System.Drawing.Point(57, 65)
        Me.TxtCodCte.Name = "TxtCodCte"
        Me.TxtCodCte.Size = New System.Drawing.Size(59, 20)
        Me.TxtCodCte.TabIndex = 70
        Me.TxtCodCte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbDiasCred
        '
        Me.CmbDiasCred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDiasCred.FormattingEnabled = True
        Me.CmbDiasCred.Location = New System.Drawing.Point(212, 111)
        Me.CmbDiasCred.Name = "CmbDiasCred"
        Me.CmbDiasCred.Size = New System.Drawing.Size(61, 21)
        Me.CmbDiasCred.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Tipo Cte"
        '
        'LblDiasCred
        '
        Me.LblDiasCred.AutoSize = True
        Me.LblDiasCred.Location = New System.Drawing.Point(209, 95)
        Me.LblDiasCred.Name = "LblDiasCred"
        Me.LblDiasCred.Size = New System.Drawing.Size(64, 13)
        Me.LblDiasCred.TabIndex = 81
        Me.LblDiasCred.Text = "Dias Credito"
        '
        'LblOrdeno
        '
        Me.LblOrdeno.AutoSize = True
        Me.LblOrdeno.Location = New System.Drawing.Point(451, 97)
        Me.LblOrdeno.Name = "LblOrdeno"
        Me.LblOrdeno.Size = New System.Drawing.Size(42, 13)
        Me.LblOrdeno.TabIndex = 76
        Me.LblOrdeno.Text = "Ordeno"
        '
        'TxtContacto
        '
        Me.TxtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtContacto.Location = New System.Drawing.Point(454, 112)
        Me.TxtContacto.Name = "TxtContacto"
        Me.TxtContacto.Size = New System.Drawing.Size(173, 20)
        Me.TxtContacto.TabIndex = 77
        '
        'LblPedido
        '
        Me.LblPedido.AutoSize = True
        Me.LblPedido.Location = New System.Drawing.Point(777, 9)
        Me.LblPedido.Name = "LblPedido"
        Me.LblPedido.Size = New System.Drawing.Size(56, 13)
        Me.LblPedido.TabIndex = 116
        Me.LblPedido.Text = "Cotización"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(665, 9)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(37, 13)
        Me.LblFecha.TabIndex = 115
        Me.LblFecha.Text = "Fecha"
        '
        'TxtFolio
        '
        Me.TxtFolio.Location = New System.Drawing.Point(779, 25)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(74, 20)
        Me.TxtFolio.TabIndex = 114
        Me.TxtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(668, 23)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.ReadOnly = True
        Me.TxtFecha.Size = New System.Drawing.Size(87, 20)
        Me.TxtFecha.TabIndex = 113
        Me.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(15, 10)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 30)
        Me.BtnGuardar.TabIndex = 110
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LblFormaPago
        '
        Me.LblFormaPago.AutoSize = True
        Me.LblFormaPago.Location = New System.Drawing.Point(13, 98)
        Me.LblFormaPago.Name = "LblFormaPago"
        Me.LblFormaPago.Size = New System.Drawing.Size(64, 13)
        Me.LblFormaPago.TabIndex = 80
        Me.LblFormaPago.Text = "Forma Pago"
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.BackColor = System.Drawing.Color.White
        Me.CmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Location = New System.Drawing.Point(13, 112)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(178, 21)
        Me.CmbFormaPago.TabIndex = 97
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(532, 8)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(81, 30)
        Me.BtnNuevo.TabIndex = 135
        Me.BtnNuevo.Text = "Prospecto"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'TxtTipoCte
        '
        Me.TxtTipoCte.Location = New System.Drawing.Point(296, 113)
        Me.TxtTipoCte.Name = "TxtTipoCte"
        Me.TxtTipoCte.ReadOnly = True
        Me.TxtTipoCte.Size = New System.Drawing.Size(141, 20)
        Me.TxtTipoCte.TabIndex = 109
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(96, 10)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 30)
        Me.BtnLimpiar.TabIndex = 136
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnPdf
        '
        Me.BtnPdf.Location = New System.Drawing.Point(176, 9)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.Size = New System.Drawing.Size(72, 30)
        Me.BtnPdf.TabIndex = 137
        Me.BtnPdf.Text = "PDF"
        Me.BtnPdf.UseVisualStyleBackColor = True
        Me.BtnPdf.Visible = False
        '
        'LnumLetra
        '
        Me.LnumLetra.AutoSize = True
        Me.LnumLetra.Location = New System.Drawing.Point(13, 520)
        Me.LnumLetra.Name = "LnumLetra"
        Me.LnumLetra.Size = New System.Drawing.Size(39, 13)
        Me.LnumLetra.TabIndex = 138
        Me.LnumLetra.Text = "Label4"
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Location = New System.Drawing.Point(254, 9)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(69, 30)
        Me.BtnEnviar.TabIndex = 139
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        Me.BtnEnviar.Visible = False
        '
        'FrmCotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 666)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.LnumLetra)
        Me.Controls.Add(Me.BtnPdf)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.LblPedido)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.TxtFolio)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtTipoCte)
        Me.Controls.Add(Me.LblSubtotal)
        Me.Controls.Add(Me.TxtSubtotal)
        Me.Controls.Add(Me.LblDispo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblExist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtIva)
        Me.Controls.Add(Me.CmbFormaPago)
        Me.Controls.Add(Me.LblIva)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.btnF3)
        Me.Controls.Add(Me.LblComenta)
        Me.Controls.Add(Me.RTxtComenta)
        Me.Controls.Add(Me.TxtNombreCte)
        Me.Controls.Add(Me.LblCte)
        Me.Controls.Add(Me.DgvPedidos)
        Me.Controls.Add(Me.TxtCodCte)
        Me.Controls.Add(Me.CmbDiasCred)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDiasCred)
        Me.Controls.Add(Me.LblOrdeno)
        Me.Controls.Add(Me.TxtContacto)
        Me.Controls.Add(Me.LblFormaPago)
        Me.Name = "FrmCotizaciones"
        Me.Text = "Cotizaciones"
        CType(Me.DgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSubtotal As Windows.Forms.Label
    Friend WithEvents TxtSubtotal As Windows.Forms.TextBox
    Friend WithEvents LblDispo As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents LblExist As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtTotal As Windows.Forms.TextBox
    Friend WithEvents TxtIva As Windows.Forms.TextBox
    Friend WithEvents LblIva As Windows.Forms.Label
    Friend WithEvents LblTotal As Windows.Forms.Label
    Friend WithEvents btnF3 As Windows.Forms.Button
    Friend WithEvents LblComenta As Windows.Forms.Label
    Friend WithEvents RTxtComenta As Windows.Forms.RichTextBox
    Friend WithEvents TxtNombreCte As Windows.Forms.TextBox
    Friend WithEvents LblCte As Windows.Forms.Label
    Friend WithEvents DgvPedidos As Windows.Forms.DataGridView
    Friend WithEvents IdDetalle As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantSurtida As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigoSat As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioTotal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnaIva As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Existencia As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Disponible As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Utilidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtCodCte As Windows.Forms.TextBox
    Friend WithEvents CmbDiasCred As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents LblDiasCred As Windows.Forms.Label
    Friend WithEvents LblOrdeno As Windows.Forms.Label
    Friend WithEvents TxtContacto As Windows.Forms.TextBox
    Friend WithEvents LblPedido As Windows.Forms.Label
    Friend WithEvents LblFecha As Windows.Forms.Label
    Friend WithEvents TxtFolio As Windows.Forms.TextBox
    Friend WithEvents TxtFecha As Windows.Forms.TextBox
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents LblFormaPago As Windows.Forms.Label
    Friend WithEvents CmbFormaPago As Windows.Forms.ComboBox
    Friend WithEvents BtnNuevo As Windows.Forms.Button
    Friend WithEvents TxtTipoCte As Windows.Forms.TextBox
    Friend WithEvents BtnLimpiar As Windows.Forms.Button
    Friend WithEvents BtnPdf As Windows.Forms.Button
    Friend WithEvents LnumLetra As Windows.Forms.Label
    Friend WithEvents BtnEnviar As Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As Windows.Forms.SaveFileDialog
End Class
