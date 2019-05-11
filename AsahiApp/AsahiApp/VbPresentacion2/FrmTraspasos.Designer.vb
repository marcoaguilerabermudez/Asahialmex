<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraspasos
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
        Me.LblSucursalLocal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbSucSolicitar = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdTraspaso = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPrincipal = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.BtnF3 = New System.Windows.Forms.Button()
        Me.DgvTraspaso = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExisDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vta12m = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantEnviada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MciaVta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MciaStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MciaTaller = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantSol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantRecib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vta6m = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotVta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtilMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtilidadPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExisOrig = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDetalleSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCteSuc = New System.Windows.Forms.TextBox()
        Me.TxtCodCteSuc = New System.Windows.Forms.TextBox()
        Me.LblCteSuc = New System.Windows.Forms.Label()
        Me.TabCondEnvio = New System.Windows.Forms.TabPage()
        Me.LblIdCondEnv = New System.Windows.Forms.Label()
        Me.CmbCiudad = New System.Windows.Forms.ComboBox()
        Me.CmbEdo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtNoInt = New System.Windows.Forms.TextBox()
        Me.TxtNoExt = New System.Windows.Forms.TextBox()
        Me.TxtMontoAsegurado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblAlias = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbFormaEntrega = New System.Windows.Forms.ComboBox()
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.TxtContacto = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCp = New System.Windows.Forms.TextBox()
        Me.CmbAlias = New System.Windows.Forms.ComboBox()
        Me.TxtColonia = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.CmbPaqueteria = New System.Windows.Forms.ComboBox()
        Me.TabInfoAdicional = New System.Windows.Forms.TabPage()
        Me.TxtFolioEntradaSia = New System.Windows.Forms.TextBox()
        Me.TxtFolioSalidaSia = New System.Windows.Forms.TextBox()
        Me.BtnFolioEntradaSia = New System.Windows.Forms.Button()
        Me.BtnFolioSalidaSia = New System.Windows.Forms.Button()
        Me.LblRecibeComentario = New System.Windows.Forms.Label()
        Me.LblRecibeUsuario = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.LblSurteComentario = New System.Windows.Forms.Label()
        Me.LblSurteUsuario = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.LblAutorizaEnvioComentario = New System.Windows.Forms.Label()
        Me.LblAutorizaEnvioUsuario = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LblCreaModificaComentario = New System.Windows.Forms.Label()
        Me.LblCreaModificaUsuario = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCrearModificar = New System.Windows.Forms.Button()
        Me.RbnACliente = New System.Windows.Forms.RadioButton()
        Me.RbnASucursal = New System.Windows.Forms.RadioButton()
        Me.TxtAtencion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnRecibirTrasp = New System.Windows.Forms.Button()
        Me.BtnAutorizar = New System.Windows.Forms.Button()
        Me.BtnSurtir = New System.Windows.Forms.Button()
        Me.BtnBackOrder = New System.Windows.Forms.Button()
        Me.LblIdTraspasoSalida = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TabControl.SuspendLayout()
        Me.TabPrincipal.SuspendLayout()
        CType(Me.DgvTraspaso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCondEnvio.SuspendLayout()
        Me.TabInfoAdicional.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sucursal:"
        '
        'LblSucursalLocal
        '
        Me.LblSucursalLocal.AutoSize = True
        Me.LblSucursalLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSucursalLocal.Location = New System.Drawing.Point(85, 55)
        Me.LblSucursalLocal.Name = "LblSucursalLocal"
        Me.LblSucursalLocal.Size = New System.Drawing.Size(0, 17)
        Me.LblSucursalLocal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Solicitar a:"
        '
        'CmbSucSolicitar
        '
        Me.CmbSucSolicitar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSucSolicitar.FormattingEnabled = True
        Me.CmbSucSolicitar.Location = New System.Drawing.Point(316, 54)
        Me.CmbSucSolicitar.Name = "CmbSucSolicitar"
        Me.CmbSucSolicitar.Size = New System.Drawing.Size(142, 21)
        Me.CmbSucSolicitar.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1090, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Traspaso"
        '
        'TxtIdTraspaso
        '
        Me.TxtIdTraspaso.Location = New System.Drawing.Point(1154, 16)
        Me.TxtIdTraspaso.Name = "TxtIdTraspaso"
        Me.TxtIdTraspaso.Size = New System.Drawing.Size(88, 20)
        Me.TxtIdTraspaso.TabIndex = 5
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(999, 18)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.ReadOnly = True
        Me.TxtFecha.Size = New System.Drawing.Size(77, 20)
        Me.TxtFecha.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(952, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPrincipal)
        Me.TabControl.Controls.Add(Me.TabCondEnvio)
        Me.TabControl.Controls.Add(Me.TabInfoAdicional)
        Me.TabControl.Location = New System.Drawing.Point(6, 84)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1275, 553)
        Me.TabControl.TabIndex = 8
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Controls.Add(Me.Label24)
        Me.TabPrincipal.Controls.Add(Me.Label23)
        Me.TabPrincipal.Controls.Add(Me.Label22)
        Me.TabPrincipal.Controls.Add(Me.BtnF3)
        Me.TabPrincipal.Controls.Add(Me.DgvTraspaso)
        Me.TabPrincipal.Controls.Add(Me.TxtCteSuc)
        Me.TabPrincipal.Controls.Add(Me.TxtCodCteSuc)
        Me.TabPrincipal.Controls.Add(Me.LblCteSuc)
        Me.TabPrincipal.Location = New System.Drawing.Point(4, 22)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPrincipal.Size = New System.Drawing.Size(1267, 527)
        Me.TabPrincipal.TabIndex = 0
        Me.TabPrincipal.Text = "Principal"
        Me.TabPrincipal.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.DarkBlue
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(37, 46)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(73, 31)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Sucursal Solicita"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.DarkBlue
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label23.Location = New System.Drawing.Point(532, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(729, 14)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Sucursal Solicita"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Red
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Location = New System.Drawing.Point(112, 63)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(416, 14)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Sucursal Surte"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnF3
        '
        Me.BtnF3.Location = New System.Drawing.Point(852, 194)
        Me.BtnF3.Name = "BtnF3"
        Me.BtnF3.Size = New System.Drawing.Size(29, 23)
        Me.BtnF3.TabIndex = 11
        Me.BtnF3.Text = "F3"
        Me.BtnF3.UseVisualStyleBackColor = True
        Me.BtnF3.Visible = False
        '
        'DgvTraspaso
        '
        Me.DgvTraspaso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTraspaso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.ExisDestino, Me.Descripcion, Me.Ubicacion, Me.vta12m, Me.CantEnviada, Me.MciaVta, Me.MciaStock, Me.MciaTaller, Me.CantSol, Me.CantRecib, Me.Vta6m, Me.Costo, Me.PrecioUnit, Me.TotVta, Me.UtilMoneda, Me.UtilidadPorcentaje, Me.Vendedor, Me.ExisOrig, Me.TotalCosto, Me.idDetalle, Me.IdDetalleSalida})
        Me.DgvTraspaso.Location = New System.Drawing.Point(4, 80)
        Me.DgvTraspaso.Name = "DgvTraspaso"
        Me.DgvTraspaso.RowHeadersWidth = 30
        Me.DgvTraspaso.Size = New System.Drawing.Size(1258, 441)
        Me.DgvTraspaso.TabIndex = 10
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 80
        '
        'ExisDestino
        '
        Me.ExisDestino.HeaderText = "Exis"
        Me.ExisDestino.Name = "ExisDestino"
        Me.ExisDestino.ReadOnly = True
        Me.ExisDestino.Width = 55
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 190
        '
        'Ubicacion
        '
        Me.Ubicacion.HeaderText = "Ubicación"
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.ReadOnly = True
        Me.Ubicacion.Width = 60
        '
        'vta12m
        '
        Me.vta12m.HeaderText = "Vta-12 Meses"
        Me.vta12m.Name = "vta12m"
        Me.vta12m.ReadOnly = True
        Me.vta12m.Width = 55
        '
        'CantEnviada
        '
        Me.CantEnviada.HeaderText = "Cant Enviada"
        Me.CantEnviada.Name = "CantEnviada"
        Me.CantEnviada.Width = 55
        '
        'MciaVta
        '
        Me.MciaVta.HeaderText = "Mcia P/Vta"
        Me.MciaVta.Name = "MciaVta"
        Me.MciaVta.Width = 50
        '
        'MciaStock
        '
        Me.MciaStock.HeaderText = "Mcia P/Stock"
        Me.MciaStock.Name = "MciaStock"
        Me.MciaStock.Width = 50
        '
        'MciaTaller
        '
        Me.MciaTaller.HeaderText = "Mcia P/Taller"
        Me.MciaTaller.Name = "MciaTaller"
        Me.MciaTaller.Width = 50
        '
        'CantSol
        '
        Me.CantSol.HeaderText = "Cant Solicitada"
        Me.CantSol.Name = "CantSol"
        Me.CantSol.ReadOnly = True
        Me.CantSol.Width = 55
        '
        'CantRecib
        '
        Me.CantRecib.HeaderText = "Cant Recibida"
        Me.CantRecib.Name = "CantRecib"
        Me.CantRecib.Width = 55
        '
        'Vta6m
        '
        Me.Vta6m.HeaderText = "Vta-6 Meses"
        Me.Vta6m.Name = "Vta6m"
        Me.Vta6m.ReadOnly = True
        Me.Vta6m.Width = 55
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Width = 60
        '
        'PrecioUnit
        '
        Me.PrecioUnit.HeaderText = "Precio Unitario"
        Me.PrecioUnit.Name = "PrecioUnit"
        Me.PrecioUnit.Width = 60
        '
        'TotVta
        '
        Me.TotVta.HeaderText = "Total Venta"
        Me.TotVta.Name = "TotVta"
        Me.TotVta.ReadOnly = True
        Me.TotVta.Width = 60
        '
        'UtilMoneda
        '
        Me.UtilMoneda.HeaderText = "Utilidad $"
        Me.UtilMoneda.Name = "UtilMoneda"
        Me.UtilMoneda.ReadOnly = True
        Me.UtilMoneda.Width = 60
        '
        'UtilidadPorcentaje
        '
        Me.UtilidadPorcentaje.HeaderText = "Utilidad %"
        Me.UtilidadPorcentaje.Name = "UtilidadPorcentaje"
        Me.UtilidadPorcentaje.ReadOnly = True
        Me.UtilidadPorcentaje.Width = 60
        '
        'Vendedor
        '
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Width = 60
        '
        'ExisOrig
        '
        Me.ExisOrig.HeaderText = "Exis"
        Me.ExisOrig.Name = "ExisOrig"
        Me.ExisOrig.ReadOnly = True
        Me.ExisOrig.Width = 55
        '
        'TotalCosto
        '
        Me.TotalCosto.HeaderText = "Total Costo"
        Me.TotalCosto.Name = "TotalCosto"
        Me.TotalCosto.Visible = False
        '
        'idDetalle
        '
        Me.idDetalle.HeaderText = "Id Detalle"
        Me.idDetalle.Name = "idDetalle"
        Me.idDetalle.ReadOnly = True
        Me.idDetalle.Visible = False
        '
        'IdDetalleSalida
        '
        Me.IdDetalleSalida.HeaderText = "Id Detalle Salida"
        Me.IdDetalleSalida.Name = "IdDetalleSalida"
        Me.IdDetalleSalida.Visible = False
        '
        'TxtCteSuc
        '
        Me.TxtCteSuc.Location = New System.Drawing.Point(113, 14)
        Me.TxtCteSuc.Name = "TxtCteSuc"
        Me.TxtCteSuc.ReadOnly = True
        Me.TxtCteSuc.Size = New System.Drawing.Size(387, 20)
        Me.TxtCteSuc.TabIndex = 9
        '
        'TxtCodCteSuc
        '
        Me.TxtCodCteSuc.Location = New System.Drawing.Point(57, 14)
        Me.TxtCodCteSuc.Name = "TxtCodCteSuc"
        Me.TxtCodCteSuc.ReadOnly = True
        Me.TxtCodCteSuc.Size = New System.Drawing.Size(55, 20)
        Me.TxtCodCteSuc.TabIndex = 8
        '
        'LblCteSuc
        '
        Me.LblCteSuc.AutoSize = True
        Me.LblCteSuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCteSuc.Location = New System.Drawing.Point(0, 14)
        Me.LblCteSuc.Name = "LblCteSuc"
        Me.LblCteSuc.Size = New System.Drawing.Size(45, 15)
        Me.LblCteSuc.TabIndex = 7
        Me.LblCteSuc.Text = "Cliente"
        '
        'TabCondEnvio
        '
        Me.TabCondEnvio.Controls.Add(Me.LblIdCondEnv)
        Me.TabCondEnvio.Controls.Add(Me.CmbCiudad)
        Me.TabCondEnvio.Controls.Add(Me.CmbEdo)
        Me.TabCondEnvio.Controls.Add(Me.Label8)
        Me.TabCondEnvio.Controls.Add(Me.Label19)
        Me.TabCondEnvio.Controls.Add(Me.TxtNoInt)
        Me.TabCondEnvio.Controls.Add(Me.TxtNoExt)
        Me.TabCondEnvio.Controls.Add(Me.TxtMontoAsegurado)
        Me.TabCondEnvio.Controls.Add(Me.Label13)
        Me.TabCondEnvio.Controls.Add(Me.Label14)
        Me.TabCondEnvio.Controls.Add(Me.Label15)
        Me.TabCondEnvio.Controls.Add(Me.Label16)
        Me.TabCondEnvio.Controls.Add(Me.Label17)
        Me.TabCondEnvio.Controls.Add(Me.Label18)
        Me.TabCondEnvio.Controls.Add(Me.Label11)
        Me.TabCondEnvio.Controls.Add(Me.Label12)
        Me.TabCondEnvio.Controls.Add(Me.Label9)
        Me.TabCondEnvio.Controls.Add(Me.Label10)
        Me.TabCondEnvio.Controls.Add(Me.LblAlias)
        Me.TabCondEnvio.Controls.Add(Me.Label7)
        Me.TabCondEnvio.Controls.Add(Me.CmbFormaEntrega)
        Me.TabCondEnvio.Controls.Add(Me.CmbFormaPago)
        Me.TabCondEnvio.Controls.Add(Me.TxtContacto)
        Me.TabCondEnvio.Controls.Add(Me.TxtTelefono)
        Me.TabCondEnvio.Controls.Add(Me.TxtCp)
        Me.TabCondEnvio.Controls.Add(Me.CmbAlias)
        Me.TabCondEnvio.Controls.Add(Me.TxtColonia)
        Me.TabCondEnvio.Controls.Add(Me.TxtDireccion)
        Me.TabCondEnvio.Controls.Add(Me.CmbPaqueteria)
        Me.TabCondEnvio.Location = New System.Drawing.Point(4, 22)
        Me.TabCondEnvio.Name = "TabCondEnvio"
        Me.TabCondEnvio.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCondEnvio.Size = New System.Drawing.Size(1267, 527)
        Me.TabCondEnvio.TabIndex = 1
        Me.TabCondEnvio.Text = "Condiciones Envio"
        Me.TabCondEnvio.UseVisualStyleBackColor = True
        '
        'LblIdCondEnv
        '
        Me.LblIdCondEnv.AutoSize = True
        Me.LblIdCondEnv.Location = New System.Drawing.Point(31, 7)
        Me.LblIdCondEnv.Name = "LblIdCondEnv"
        Me.LblIdCondEnv.Size = New System.Drawing.Size(0, 13)
        Me.LblIdCondEnv.TabIndex = 30
        Me.LblIdCondEnv.Visible = False
        '
        'CmbCiudad
        '
        Me.CmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCiudad.Enabled = False
        Me.CmbCiudad.FormattingEnabled = True
        Me.CmbCiudad.Location = New System.Drawing.Point(92, 189)
        Me.CmbCiudad.Name = "CmbCiudad"
        Me.CmbCiudad.Size = New System.Drawing.Size(218, 21)
        Me.CmbCiudad.TabIndex = 29
        '
        'CmbEdo
        '
        Me.CmbEdo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEdo.Enabled = False
        Me.CmbEdo.FormattingEnabled = True
        Me.CmbEdo.Location = New System.Drawing.Point(92, 162)
        Me.CmbEdo.Name = "CmbEdo"
        Me.CmbEdo.Size = New System.Drawing.Size(218, 21)
        Me.CmbEdo.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "No Ext"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(194, 107)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "No Int"
        '
        'TxtNoInt
        '
        Me.TxtNoInt.Location = New System.Drawing.Point(236, 104)
        Me.TxtNoInt.Name = "TxtNoInt"
        Me.TxtNoInt.ReadOnly = True
        Me.TxtNoInt.Size = New System.Drawing.Size(74, 20)
        Me.TxtNoInt.TabIndex = 25
        '
        'TxtNoExt
        '
        Me.TxtNoExt.Location = New System.Drawing.Point(92, 104)
        Me.TxtNoExt.Name = "TxtNoExt"
        Me.TxtNoExt.ReadOnly = True
        Me.TxtNoExt.Size = New System.Drawing.Size(74, 20)
        Me.TxtNoExt.TabIndex = 24
        '
        'TxtMontoAsegurado
        '
        Me.TxtMontoAsegurado.Location = New System.Drawing.Point(475, 75)
        Me.TxtMontoAsegurado.Name = "TxtMontoAsegurado"
        Me.TxtMontoAsegurado.Size = New System.Drawing.Size(123, 20)
        Me.TxtMontoAsegurado.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(405, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Forma Pago"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(393, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Forma Entrega"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(449, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "CP"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(420, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Teléfono"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(419, 187)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Contacto"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(378, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Monto Asegurado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(41, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Ciudad"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Dirección"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Colonia"
        '
        'LblAlias
        '
        Me.LblAlias.AutoSize = True
        Me.LblAlias.Location = New System.Drawing.Point(57, 54)
        Me.LblAlias.Name = "LblAlias"
        Me.LblAlias.Size = New System.Drawing.Size(29, 13)
        Me.LblAlias.TabIndex = 12
        Me.LblAlias.Text = "Alias"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Paqueteria"
        '
        'CmbFormaEntrega
        '
        Me.CmbFormaEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFormaEntrega.FormattingEnabled = True
        Me.CmbFormaEntrega.Location = New System.Drawing.Point(475, 48)
        Me.CmbFormaEntrega.Name = "CmbFormaEntrega"
        Me.CmbFormaEntrega.Size = New System.Drawing.Size(218, 21)
        Me.CmbFormaEntrega.TabIndex = 10
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Location = New System.Drawing.Point(475, 21)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(218, 21)
        Me.CmbFormaPago.TabIndex = 9
        '
        'TxtContacto
        '
        Me.TxtContacto.Location = New System.Drawing.Point(475, 184)
        Me.TxtContacto.Name = "TxtContacto"
        Me.TxtContacto.ReadOnly = True
        Me.TxtContacto.Size = New System.Drawing.Size(218, 20)
        Me.TxtContacto.TabIndex = 8
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(475, 158)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.ReadOnly = True
        Me.TxtTelefono.Size = New System.Drawing.Size(218, 20)
        Me.TxtTelefono.TabIndex = 7
        '
        'TxtCp
        '
        Me.TxtCp.Location = New System.Drawing.Point(475, 132)
        Me.TxtCp.Name = "TxtCp"
        Me.TxtCp.ReadOnly = True
        Me.TxtCp.Size = New System.Drawing.Size(218, 20)
        Me.TxtCp.TabIndex = 6
        '
        'CmbAlias
        '
        Me.CmbAlias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAlias.FormattingEnabled = True
        Me.CmbAlias.Location = New System.Drawing.Point(92, 51)
        Me.CmbAlias.Name = "CmbAlias"
        Me.CmbAlias.Size = New System.Drawing.Size(248, 21)
        Me.CmbAlias.TabIndex = 3
        '
        'TxtColonia
        '
        Me.TxtColonia.Location = New System.Drawing.Point(92, 133)
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.ReadOnly = True
        Me.TxtColonia.Size = New System.Drawing.Size(248, 20)
        Me.TxtColonia.TabIndex = 2
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(92, 78)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ReadOnly = True
        Me.TxtDireccion.Size = New System.Drawing.Size(248, 20)
        Me.TxtDireccion.TabIndex = 1
        '
        'CmbPaqueteria
        '
        Me.CmbPaqueteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPaqueteria.FormattingEnabled = True
        Me.CmbPaqueteria.Location = New System.Drawing.Point(92, 21)
        Me.CmbPaqueteria.Name = "CmbPaqueteria"
        Me.CmbPaqueteria.Size = New System.Drawing.Size(248, 21)
        Me.CmbPaqueteria.TabIndex = 0
        '
        'TabInfoAdicional
        '
        Me.TabInfoAdicional.Controls.Add(Me.TxtFolioEntradaSia)
        Me.TabInfoAdicional.Controls.Add(Me.TxtFolioSalidaSia)
        Me.TabInfoAdicional.Controls.Add(Me.BtnFolioEntradaSia)
        Me.TabInfoAdicional.Controls.Add(Me.BtnFolioSalidaSia)
        Me.TabInfoAdicional.Controls.Add(Me.LblRecibeComentario)
        Me.TabInfoAdicional.Controls.Add(Me.LblRecibeUsuario)
        Me.TabInfoAdicional.Controls.Add(Me.Label32)
        Me.TabInfoAdicional.Controls.Add(Me.LblSurteComentario)
        Me.TabInfoAdicional.Controls.Add(Me.LblSurteUsuario)
        Me.TabInfoAdicional.Controls.Add(Me.Label29)
        Me.TabInfoAdicional.Controls.Add(Me.LblAutorizaEnvioComentario)
        Me.TabInfoAdicional.Controls.Add(Me.LblAutorizaEnvioUsuario)
        Me.TabInfoAdicional.Controls.Add(Me.Label26)
        Me.TabInfoAdicional.Controls.Add(Me.LblCreaModificaComentario)
        Me.TabInfoAdicional.Controls.Add(Me.LblCreaModificaUsuario)
        Me.TabInfoAdicional.Controls.Add(Me.Label21)
        Me.TabInfoAdicional.Controls.Add(Me.Label20)
        Me.TabInfoAdicional.Controls.Add(Me.Label5)
        Me.TabInfoAdicional.Location = New System.Drawing.Point(4, 22)
        Me.TabInfoAdicional.Name = "TabInfoAdicional"
        Me.TabInfoAdicional.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInfoAdicional.Size = New System.Drawing.Size(1267, 527)
        Me.TabInfoAdicional.TabIndex = 2
        Me.TabInfoAdicional.Text = "Información Adicional"
        Me.TabInfoAdicional.UseVisualStyleBackColor = True
        '
        'TxtFolioEntradaSia
        '
        Me.TxtFolioEntradaSia.Location = New System.Drawing.Point(640, 83)
        Me.TxtFolioEntradaSia.Name = "TxtFolioEntradaSia"
        Me.TxtFolioEntradaSia.Size = New System.Drawing.Size(100, 20)
        Me.TxtFolioEntradaSia.TabIndex = 17
        '
        'TxtFolioSalidaSia
        '
        Me.TxtFolioSalidaSia.Location = New System.Drawing.Point(640, 49)
        Me.TxtFolioSalidaSia.Name = "TxtFolioSalidaSia"
        Me.TxtFolioSalidaSia.Size = New System.Drawing.Size(100, 20)
        Me.TxtFolioSalidaSia.TabIndex = 16
        Me.TxtFolioSalidaSia.Visible = False
        '
        'BtnFolioEntradaSia
        '
        Me.BtnFolioEntradaSia.Location = New System.Drawing.Point(496, 78)
        Me.BtnFolioEntradaSia.Name = "BtnFolioEntradaSia"
        Me.BtnFolioEntradaSia.Size = New System.Drawing.Size(111, 28)
        Me.BtnFolioEntradaSia.TabIndex = 15
        Me.BtnFolioEntradaSia.Text = "Folio Entrada SIA"
        Me.BtnFolioEntradaSia.UseVisualStyleBackColor = True
        '
        'BtnFolioSalidaSia
        '
        Me.BtnFolioSalidaSia.Location = New System.Drawing.Point(496, 44)
        Me.BtnFolioSalidaSia.Name = "BtnFolioSalidaSia"
        Me.BtnFolioSalidaSia.Size = New System.Drawing.Size(111, 28)
        Me.BtnFolioSalidaSia.TabIndex = 14
        Me.BtnFolioSalidaSia.Text = "Folio Salida SIA"
        Me.BtnFolioSalidaSia.UseVisualStyleBackColor = True
        Me.BtnFolioSalidaSia.Visible = False
        '
        'LblRecibeComentario
        '
        Me.LblRecibeComentario.AutoSize = True
        Me.LblRecibeComentario.Location = New System.Drawing.Point(255, 237)
        Me.LblRecibeComentario.Name = "LblRecibeComentario"
        Me.LblRecibeComentario.Size = New System.Drawing.Size(0, 13)
        Me.LblRecibeComentario.TabIndex = 13
        '
        'LblRecibeUsuario
        '
        Me.LblRecibeUsuario.AutoSize = True
        Me.LblRecibeUsuario.Location = New System.Drawing.Point(117, 237)
        Me.LblRecibeUsuario.Name = "LblRecibeUsuario"
        Me.LblRecibeUsuario.Size = New System.Drawing.Size(0, 13)
        Me.LblRecibeUsuario.TabIndex = 12
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(16, 237)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(46, 13)
        Me.Label32.TabIndex = 11
        Me.Label32.Text = "RECIBE"
        '
        'LblSurteComentario
        '
        Me.LblSurteComentario.AutoSize = True
        Me.LblSurteComentario.Location = New System.Drawing.Point(255, 173)
        Me.LblSurteComentario.Name = "LblSurteComentario"
        Me.LblSurteComentario.Size = New System.Drawing.Size(0, 13)
        Me.LblSurteComentario.TabIndex = 10
        '
        'LblSurteUsuario
        '
        Me.LblSurteUsuario.AutoSize = True
        Me.LblSurteUsuario.Location = New System.Drawing.Point(117, 173)
        Me.LblSurteUsuario.Name = "LblSurteUsuario"
        Me.LblSurteUsuario.Size = New System.Drawing.Size(0, 13)
        Me.LblSurteUsuario.TabIndex = 9
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 173)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 13)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "SURTE"
        '
        'LblAutorizaEnvioComentario
        '
        Me.LblAutorizaEnvioComentario.AutoSize = True
        Me.LblAutorizaEnvioComentario.Location = New System.Drawing.Point(255, 110)
        Me.LblAutorizaEnvioComentario.Name = "LblAutorizaEnvioComentario"
        Me.LblAutorizaEnvioComentario.Size = New System.Drawing.Size(0, 13)
        Me.LblAutorizaEnvioComentario.TabIndex = 7
        '
        'LblAutorizaEnvioUsuario
        '
        Me.LblAutorizaEnvioUsuario.AutoSize = True
        Me.LblAutorizaEnvioUsuario.Location = New System.Drawing.Point(117, 110)
        Me.LblAutorizaEnvioUsuario.Name = "LblAutorizaEnvioUsuario"
        Me.LblAutorizaEnvioUsuario.Size = New System.Drawing.Size(0, 13)
        Me.LblAutorizaEnvioUsuario.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(16, 106)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 28)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "AUTORIZAR ENVÍO"
        '
        'LblCreaModificaComentario
        '
        Me.LblCreaModificaComentario.AutoSize = True
        Me.LblCreaModificaComentario.Location = New System.Drawing.Point(255, 52)
        Me.LblCreaModificaComentario.Name = "LblCreaModificaComentario"
        Me.LblCreaModificaComentario.Size = New System.Drawing.Size(0, 13)
        Me.LblCreaModificaComentario.TabIndex = 4
        '
        'LblCreaModificaUsuario
        '
        Me.LblCreaModificaUsuario.AutoSize = True
        Me.LblCreaModificaUsuario.Location = New System.Drawing.Point(117, 52)
        Me.LblCreaModificaUsuario.Name = "LblCreaModificaUsuario"
        Me.LblCreaModificaUsuario.Size = New System.Drawing.Size(0, 13)
        Me.LblCreaModificaUsuario.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(255, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "COMENTARIO"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(117, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "USUARIO"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 34)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CREACION/ MODIFICACION"
        '
        'BtnCrearModificar
        '
        Me.BtnCrearModificar.Location = New System.Drawing.Point(16, 6)
        Me.BtnCrearModificar.Name = "BtnCrearModificar"
        Me.BtnCrearModificar.Size = New System.Drawing.Size(88, 34)
        Me.BtnCrearModificar.TabIndex = 9
        Me.BtnCrearModificar.Text = "Crear/Modificar"
        Me.BtnCrearModificar.UseVisualStyleBackColor = True
        '
        'RbnACliente
        '
        Me.RbnACliente.AutoSize = True
        Me.RbnACliente.Checked = True
        Me.RbnACliente.Location = New System.Drawing.Point(485, 58)
        Me.RbnACliente.Name = "RbnACliente"
        Me.RbnACliente.Size = New System.Drawing.Size(66, 17)
        Me.RbnACliente.TabIndex = 10
        Me.RbnACliente.TabStop = True
        Me.RbnACliente.Text = "A cliente"
        Me.RbnACliente.UseVisualStyleBackColor = True
        '
        'RbnASucursal
        '
        Me.RbnASucursal.AutoSize = True
        Me.RbnASucursal.Location = New System.Drawing.Point(594, 58)
        Me.RbnASucursal.Name = "RbnASucursal"
        Me.RbnASucursal.Size = New System.Drawing.Size(74, 17)
        Me.RbnASucursal.TabIndex = 11
        Me.RbnASucursal.Text = "A sucursal"
        Me.RbnASucursal.UseVisualStyleBackColor = True
        '
        'TxtAtencion
        '
        Me.TxtAtencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAtencion.Location = New System.Drawing.Point(756, 55)
        Me.TxtAtencion.Name = "TxtAtencion"
        Me.TxtAtencion.Size = New System.Drawing.Size(142, 20)
        Me.TxtAtencion.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(683, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Atención a:"
        '
        'BtnRecibirTrasp
        '
        Me.BtnRecibirTrasp.Location = New System.Drawing.Point(110, 6)
        Me.BtnRecibirTrasp.Name = "BtnRecibirTrasp"
        Me.BtnRecibirTrasp.Size = New System.Drawing.Size(88, 34)
        Me.BtnRecibirTrasp.TabIndex = 14
        Me.BtnRecibirTrasp.Text = "Recibir Traspaso"
        Me.BtnRecibirTrasp.UseVisualStyleBackColor = True
        '
        'BtnAutorizar
        '
        Me.BtnAutorizar.Location = New System.Drawing.Point(298, 8)
        Me.BtnAutorizar.Name = "BtnAutorizar"
        Me.BtnAutorizar.Size = New System.Drawing.Size(88, 34)
        Me.BtnAutorizar.TabIndex = 16
        Me.BtnAutorizar.Text = "Autorizar envio del traspaso"
        Me.BtnAutorizar.UseVisualStyleBackColor = True
        '
        'BtnSurtir
        '
        Me.BtnSurtir.Location = New System.Drawing.Point(392, 8)
        Me.BtnSurtir.Name = "BtnSurtir"
        Me.BtnSurtir.Size = New System.Drawing.Size(88, 34)
        Me.BtnSurtir.TabIndex = 15
        Me.BtnSurtir.Text = "Surtir Traspaso"
        Me.BtnSurtir.UseVisualStyleBackColor = True
        '
        'BtnBackOrder
        '
        Me.BtnBackOrder.Location = New System.Drawing.Point(535, 8)
        Me.BtnBackOrder.Name = "BtnBackOrder"
        Me.BtnBackOrder.Size = New System.Drawing.Size(88, 34)
        Me.BtnBackOrder.TabIndex = 17
        Me.BtnBackOrder.Text = "Back-Order"
        Me.BtnBackOrder.UseVisualStyleBackColor = True
        Me.BtnBackOrder.Visible = False
        '
        'LblIdTraspasoSalida
        '
        Me.LblIdTraspasoSalida.AutoSize = True
        Me.LblIdTraspasoSalida.Location = New System.Drawing.Point(1151, 54)
        Me.LblIdTraspasoSalida.Name = "LblIdTraspasoSalida"
        Me.LblIdTraspasoSalida.Size = New System.Drawing.Size(0, 13)
        Me.LblIdTraspasoSalida.TabIndex = 18
        Me.LblIdTraspasoSalida.Visible = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(756, 8)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(72, 34)
        Me.BtnLimpiar.TabIndex = 19
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'FrmTraspasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 642)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.LblIdTraspasoSalida)
        Me.Controls.Add(Me.BtnBackOrder)
        Me.Controls.Add(Me.BtnAutorizar)
        Me.Controls.Add(Me.BtnRecibirTrasp)
        Me.Controls.Add(Me.TxtAtencion)
        Me.Controls.Add(Me.BtnSurtir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RbnASucursal)
        Me.Controls.Add(Me.RbnACliente)
        Me.Controls.Add(Me.BtnCrearModificar)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtIdTraspaso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbSucSolicitar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblSucursalLocal)
        Me.Name = "FrmTraspasos"
        Me.Text = "Traspasos"
        Me.TabControl.ResumeLayout(False)
        Me.TabPrincipal.ResumeLayout(False)
        Me.TabPrincipal.PerformLayout()
        CType(Me.DgvTraspaso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCondEnvio.ResumeLayout(False)
        Me.TabCondEnvio.PerformLayout()
        Me.TabInfoAdicional.ResumeLayout(False)
        Me.TabInfoAdicional.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents LblSucursalLocal As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents CmbSucSolicitar As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtIdTraspaso As Windows.Forms.TextBox
    Friend WithEvents TxtFecha As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents TabControl As Windows.Forms.TabControl
    Friend WithEvents TabPrincipal As Windows.Forms.TabPage
    Friend WithEvents BtnCrearModificar As Windows.Forms.Button
    Friend WithEvents TxtCodCteSuc As Windows.Forms.TextBox
    Friend WithEvents LblCteSuc As Windows.Forms.Label
    Friend WithEvents TxtCteSuc As Windows.Forms.TextBox
    Friend WithEvents RbnACliente As Windows.Forms.RadioButton
    Friend WithEvents RbnASucursal As Windows.Forms.RadioButton
    Friend WithEvents TxtAtencion As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents DgvTraspaso As Windows.Forms.DataGridView
    Friend WithEvents BtnRecibirTrasp As Windows.Forms.Button
    Friend WithEvents BtnAutorizar As Windows.Forms.Button
    Friend WithEvents BtnSurtir As Windows.Forms.Button
    Friend WithEvents BtnF3 As Windows.Forms.Button
    Friend WithEvents BtnBackOrder As Windows.Forms.Button
    Friend WithEvents TabCondEnvio As Windows.Forms.TabPage
    Friend WithEvents CmbCiudad As Windows.Forms.ComboBox
    Friend WithEvents CmbEdo As Windows.Forms.ComboBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents TxtNoInt As Windows.Forms.TextBox
    Friend WithEvents TxtNoExt As Windows.Forms.TextBox
    Friend WithEvents TxtMontoAsegurado As Windows.Forms.TextBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents LblAlias As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents CmbFormaEntrega As Windows.Forms.ComboBox
    Friend WithEvents CmbFormaPago As Windows.Forms.ComboBox
    Friend WithEvents TxtContacto As Windows.Forms.TextBox
    Friend WithEvents TxtTelefono As Windows.Forms.TextBox
    Friend WithEvents TxtCp As Windows.Forms.TextBox
    Friend WithEvents CmbAlias As Windows.Forms.ComboBox
    Friend WithEvents TxtColonia As Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As Windows.Forms.TextBox
    Friend WithEvents CmbPaqueteria As Windows.Forms.ComboBox
    Friend WithEvents LblIdTraspasoSalida As Windows.Forms.Label
    Friend WithEvents BtnLimpiar As Windows.Forms.Button
    Friend WithEvents LblIdCondEnv As Windows.Forms.Label
    Friend WithEvents TabInfoAdicional As Windows.Forms.TabPage
    Friend WithEvents TxtFolioEntradaSia As Windows.Forms.TextBox
    Friend WithEvents TxtFolioSalidaSia As Windows.Forms.TextBox
    Friend WithEvents BtnFolioEntradaSia As Windows.Forms.Button
    Friend WithEvents BtnFolioSalidaSia As Windows.Forms.Button
    Friend WithEvents LblRecibeComentario As Windows.Forms.Label
    Friend WithEvents LblRecibeUsuario As Windows.Forms.Label
    Friend WithEvents Label32 As Windows.Forms.Label
    Friend WithEvents LblSurteComentario As Windows.Forms.Label
    Friend WithEvents LblSurteUsuario As Windows.Forms.Label
    Friend WithEvents Label29 As Windows.Forms.Label
    Friend WithEvents LblAutorizaEnvioComentario As Windows.Forms.Label
    Friend WithEvents LblAutorizaEnvioUsuario As Windows.Forms.Label
    Friend WithEvents Label26 As Windows.Forms.Label
    Friend WithEvents LblCreaModificaComentario As Windows.Forms.Label
    Friend WithEvents LblCreaModificaUsuario As Windows.Forms.Label
    Friend WithEvents Label21 As Windows.Forms.Label
    Friend WithEvents Label20 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Codigo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExisDestino As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vta12m As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantEnviada As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MciaVta As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MciaStock As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MciaTaller As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantSol As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantRecib As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vta6m As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnit As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotVta As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilMoneda As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilidadPorcentaje As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExisOrig As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCosto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idDetalle As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDetalleSalida As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label24 As Windows.Forms.Label
    Friend WithEvents Label23 As Windows.Forms.Label
    Friend WithEvents Label22 As Windows.Forms.Label
End Class
