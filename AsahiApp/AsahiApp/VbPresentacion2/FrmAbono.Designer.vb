<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAbono
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.lblFolio = New System.Windows.Forms.Label()
        Me.LblFechaAbono = New System.Windows.Forms.Label()
        Me.TxtCuenta = New System.Windows.Forms.TextBox()
        Me.LblCuenta = New System.Windows.Forms.Label()
        Me.btnF3 = New System.Windows.Forms.Button()
        Me.TxtIdCte = New System.Windows.Forms.TextBox()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.TxtNombreCte = New System.Windows.Forms.TextBox()
        Me.TxtCuentaCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblBancoD = New System.Windows.Forms.Label()
        Me.CmbMoneda = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblReferencia = New System.Windows.Forms.Label()
        Me.TxtReferencia = New System.Windows.Forms.TextBox()
        Me.LblObservaciones = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.btnMostrarPDF = New System.Windows.Forms.Button()
        Me.BtnTimbrar = New System.Windows.Forms.Button()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.CmbTipoAbono = New System.Windows.Forms.ComboBox()
        Me.LblTipoAbono = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblNOperacion = New System.Windows.Forms.Label()
        Me.TxtNOperacion = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LblRFCBancoD = New System.Windows.Forms.Label()
        Me.GbBeneficiario = New System.Windows.Forms.GroupBox()
        Me.GbCliente = New System.Windows.Forms.GroupBox()
        Me.LblRFCBancoE = New System.Windows.Forms.Label()
        Me.LblBancoE = New System.Windows.Forms.Label()
        Me.LblTimbrado = New System.Windows.Forms.Label()
        Me.LblUUID = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPrincipal = New System.Windows.Forms.TabPage()
        Me.TabDoctos = New System.Windows.Forms.TabPage()
        Me.GbFacturas = New System.Windows.Forms.GroupBox()
        Me.RbAdminPAQ = New System.Windows.Forms.RadioButton()
        Me.RbArgo = New System.Windows.Forms.RadioButton()
        Me.DgvFacturas = New System.Windows.Forms.DataGridView()
        Me.idAbonoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioFiscal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtPorAplicar = New System.Windows.Forms.TextBox()
        Me.TxtTAbonos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GbSustitucion = New System.Windows.Forms.GroupBox()
        Me.BtnBuscaCancelados = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GbBeneficiario.SuspendLayout()
        Me.GbCliente.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPrincipal.SuspendLayout()
        Me.TabDoctos.SuspendLayout()
        Me.GbFacturas.SuspendLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbSustitucion.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(434, 12)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(57, 30)
        Me.btnLimpiar.TabIndex = 51
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(63, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(57, 30)
        Me.BtnCancelar.TabIndex = 50
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(5, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(57, 30)
        Me.BtnGuardar.TabIndex = 49
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtFolio
        '
        Me.TxtFolio.Location = New System.Drawing.Point(532, 22)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(71, 20)
        Me.TxtFolio.TabIndex = 53
        Me.TxtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(529, 6)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(29, 13)
        Me.lblFolio.TabIndex = 52
        Me.lblFolio.Text = "Folio"
        '
        'LblFechaAbono
        '
        Me.LblFechaAbono.AutoSize = True
        Me.LblFechaAbono.Location = New System.Drawing.Point(365, 44)
        Me.LblFechaAbono.Name = "LblFechaAbono"
        Me.LblFechaAbono.Size = New System.Drawing.Size(71, 13)
        Me.LblFechaAbono.TabIndex = 54
        Me.LblFechaAbono.Text = "Fecha Abono"
        '
        'TxtCuenta
        '
        Me.TxtCuenta.Location = New System.Drawing.Point(6, 36)
        Me.TxtCuenta.MaxLength = 16
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.ReadOnly = True
        Me.TxtCuenta.Size = New System.Drawing.Size(138, 20)
        Me.TxtCuenta.TabIndex = 56
        '
        'LblCuenta
        '
        Me.LblCuenta.AutoSize = True
        Me.LblCuenta.Location = New System.Drawing.Point(5, 20)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(145, 13)
        Me.LblCuenta.TabIndex = 57
        Me.LblCuenta.Text = "Cuenta Bancaria Destinatario"
        '
        'btnF3
        '
        Me.btnF3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnF3.Location = New System.Drawing.Point(65, 32)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(27, 20)
        Me.btnF3.TabIndex = 58
        Me.btnF3.Text = "F3"
        Me.btnF3.UseVisualStyleBackColor = True
        Me.btnF3.Visible = False
        '
        'TxtIdCte
        '
        Me.TxtIdCte.Location = New System.Drawing.Point(7, 33)
        Me.TxtIdCte.Name = "TxtIdCte"
        Me.TxtIdCte.Size = New System.Drawing.Size(59, 20)
        Me.TxtIdCte.TabIndex = 60
        Me.TxtIdCte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(4, 17)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(39, 13)
        Me.LblCliente.TabIndex = 61
        Me.LblCliente.Text = "Cliente"
        '
        'TxtNombreCte
        '
        Me.TxtNombreCte.Location = New System.Drawing.Point(65, 33)
        Me.TxtNombreCte.Name = "TxtNombreCte"
        Me.TxtNombreCte.Size = New System.Drawing.Size(506, 20)
        Me.TxtNombreCte.TabIndex = 62
        '
        'TxtCuentaCliente
        '
        Me.TxtCuentaCliente.Location = New System.Drawing.Point(7, 73)
        Me.TxtCuentaCliente.MaxLength = 16
        Me.TxtCuentaCliente.Name = "TxtCuentaCliente"
        Me.TxtCuentaCliente.ReadOnly = True
        Me.TxtCuentaCliente.Size = New System.Drawing.Size(137, 20)
        Me.TxtCuentaCliente.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Cuenta Bancaria Cliente"
        '
        'LblBancoD
        '
        Me.LblBancoD.AutoSize = True
        Me.LblBancoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBancoD.Location = New System.Drawing.Point(174, 39)
        Me.LblBancoD.Name = "LblBancoD"
        Me.LblBancoD.Size = New System.Drawing.Size(83, 12)
        Me.LblBancoD.TabIndex = 66
        Me.LblBancoD.Text = "NOMBRE BANCO"
        '
        'CmbMoneda
        '
        Me.CmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMoneda.FormattingEnabled = True
        Me.CmbMoneda.Location = New System.Drawing.Point(469, 113)
        Me.CmbMoneda.Name = "CmbMoneda"
        Me.CmbMoneda.Size = New System.Drawing.Size(107, 21)
        Me.CmbMoneda.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(466, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Moneda"
        '
        'LblReferencia
        '
        Me.LblReferencia.AutoSize = True
        Me.LblReferencia.Location = New System.Drawing.Point(428, 57)
        Me.LblReferencia.Name = "LblReferencia"
        Me.LblReferencia.Size = New System.Drawing.Size(59, 13)
        Me.LblReferencia.TabIndex = 70
        Me.LblReferencia.Text = "Referencia"
        '
        'TxtReferencia
        '
        Me.TxtReferencia.Location = New System.Drawing.Point(427, 73)
        Me.TxtReferencia.MaxLength = 16
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(144, 20)
        Me.TxtReferencia.TabIndex = 69
        '
        'LblObservaciones
        '
        Me.LblObservaciones.AutoSize = True
        Me.LblObservaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblObservaciones.Location = New System.Drawing.Point(4, 381)
        Me.LblObservaciones.Name = "LblObservaciones"
        Me.LblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.LblObservaciones.TabIndex = 72
        Me.LblObservaciones.Text = "Observaciones"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(7, 397)
        Me.TxtObservaciones.MaxLength = 300
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(575, 59)
        Me.TxtObservaciones.TabIndex = 71
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Location = New System.Drawing.Point(263, 113)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(200, 21)
        Me.CmbFormaPago.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Forma de Pago"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(483, 60)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 86
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(483, 46)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(100, 13)
        Me.LblCantidad.TabIndex = 85
        Me.LblCantidad.Text = "Cantidad del Abono"
        '
        'btnMostrarPDF
        '
        Me.btnMostrarPDF.Enabled = False
        Me.btnMostrarPDF.Location = New System.Drawing.Point(272, 12)
        Me.btnMostrarPDF.Name = "btnMostrarPDF"
        Me.btnMostrarPDF.Size = New System.Drawing.Size(75, 30)
        Me.btnMostrarPDF.TabIndex = 87
        Me.btnMostrarPDF.Text = "Mostrar PDF"
        Me.btnMostrarPDF.UseVisualStyleBackColor = True
        '
        'BtnTimbrar
        '
        Me.BtnTimbrar.Enabled = False
        Me.BtnTimbrar.Location = New System.Drawing.Point(214, 12)
        Me.BtnTimbrar.Name = "BtnTimbrar"
        Me.BtnTimbrar.Size = New System.Drawing.Size(57, 30)
        Me.BtnTimbrar.TabIndex = 88
        Me.BtnTimbrar.Text = "Timbrar"
        Me.BtnTimbrar.UseVisualStyleBackColor = True
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Enabled = False
        Me.BtnEnviar.Location = New System.Drawing.Point(360, 12)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(57, 30)
        Me.BtnEnviar.TabIndex = 89
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'CmbTipoAbono
        '
        Me.CmbTipoAbono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoAbono.FormattingEnabled = True
        Me.CmbTipoAbono.Location = New System.Drawing.Point(7, 59)
        Me.CmbTipoAbono.Name = "CmbTipoAbono"
        Me.CmbTipoAbono.Size = New System.Drawing.Size(213, 21)
        Me.CmbTipoAbono.TabIndex = 91
        '
        'LblTipoAbono
        '
        Me.LblTipoAbono.AutoSize = True
        Me.LblTipoAbono.Location = New System.Drawing.Point(4, 43)
        Me.LblTipoAbono.Name = "LblTipoAbono"
        Me.LblTipoAbono.Size = New System.Drawing.Size(154, 13)
        Me.LblTipoAbono.TabIndex = 92
        Me.LblTipoAbono.Text = "Concepto de Abono del Cliente"
        '
        'DtpFecha
        '
        Me.DtpFecha.Checked = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(368, 60)
        Me.DtpFecha.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(105, 20)
        Me.DtpFecha.TabIndex = 93
        '
        'LblNOperacion
        '
        Me.LblNOperacion.AutoSize = True
        Me.LblNOperacion.Location = New System.Drawing.Point(4, 98)
        Me.LblNOperacion.Name = "LblNOperacion"
        Me.LblNOperacion.Size = New System.Drawing.Size(111, 13)
        Me.LblNOperacion.TabIndex = 95
        Me.LblNOperacion.Text = "Numero de Operacion"
        '
        'TxtNOperacion
        '
        Me.TxtNOperacion.Location = New System.Drawing.Point(6, 114)
        Me.TxtNOperacion.MaxLength = 16
        Me.TxtNOperacion.Name = "TxtNOperacion"
        Me.TxtNOperacion.Size = New System.Drawing.Size(251, 20)
        Me.TxtNOperacion.TabIndex = 94
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'LblRFCBancoD
        '
        Me.LblRFCBancoD.AutoSize = True
        Me.LblRFCBancoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRFCBancoD.Location = New System.Drawing.Point(308, 39)
        Me.LblRFCBancoD.Name = "LblRFCBancoD"
        Me.LblRFCBancoD.Size = New System.Drawing.Size(61, 12)
        Me.LblRFCBancoD.TabIndex = 96
        Me.LblRFCBancoD.Text = "RFC BANCO"
        Me.LblRFCBancoD.Visible = False
        '
        'GbBeneficiario
        '
        Me.GbBeneficiario.Controls.Add(Me.LblRFCBancoD)
        Me.GbBeneficiario.Controls.Add(Me.TxtCuenta)
        Me.GbBeneficiario.Controls.Add(Me.LblCuenta)
        Me.GbBeneficiario.Controls.Add(Me.LblBancoD)
        Me.GbBeneficiario.Location = New System.Drawing.Point(7, 156)
        Me.GbBeneficiario.Name = "GbBeneficiario"
        Me.GbBeneficiario.Size = New System.Drawing.Size(576, 72)
        Me.GbBeneficiario.TabIndex = 97
        Me.GbBeneficiario.TabStop = False
        Me.GbBeneficiario.Text = "Informacion Bancaria Beneficiario"
        '
        'GbCliente
        '
        Me.GbCliente.Controls.Add(Me.btnF3)
        Me.GbCliente.Controls.Add(Me.LblRFCBancoE)
        Me.GbCliente.Controls.Add(Me.TxtIdCte)
        Me.GbCliente.Controls.Add(Me.LblCliente)
        Me.GbCliente.Controls.Add(Me.TxtCuentaCliente)
        Me.GbCliente.Controls.Add(Me.Label1)
        Me.GbCliente.Controls.Add(Me.TxtReferencia)
        Me.GbCliente.Controls.Add(Me.LblReferencia)
        Me.GbCliente.Controls.Add(Me.TxtNombreCte)
        Me.GbCliente.Controls.Add(Me.LblBancoE)
        Me.GbCliente.Location = New System.Drawing.Point(5, 254)
        Me.GbCliente.Name = "GbCliente"
        Me.GbCliente.Size = New System.Drawing.Size(577, 107)
        Me.GbCliente.TabIndex = 98
        Me.GbCliente.TabStop = False
        Me.GbCliente.Text = "Informacion Bancaria Emisor (Cliente)"
        '
        'LblRFCBancoE
        '
        Me.LblRFCBancoE.AutoSize = True
        Me.LblRFCBancoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRFCBancoE.Location = New System.Drawing.Point(309, 76)
        Me.LblRFCBancoE.Name = "LblRFCBancoE"
        Me.LblRFCBancoE.Size = New System.Drawing.Size(61, 12)
        Me.LblRFCBancoE.TabIndex = 98
        Me.LblRFCBancoE.Text = "RFC BANCO"
        Me.LblRFCBancoE.Visible = False
        '
        'LblBancoE
        '
        Me.LblBancoE.AutoSize = True
        Me.LblBancoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBancoE.Location = New System.Drawing.Point(175, 76)
        Me.LblBancoE.Name = "LblBancoE"
        Me.LblBancoE.Size = New System.Drawing.Size(83, 12)
        Me.LblBancoE.TabIndex = 97
        Me.LblBancoE.Text = "NOMBRE BANCO"
        '
        'LblTimbrado
        '
        Me.LblTimbrado.AutoSize = True
        Me.LblTimbrado.Location = New System.Drawing.Point(503, 9)
        Me.LblTimbrado.Name = "LblTimbrado"
        Me.LblTimbrado.Size = New System.Drawing.Size(0, 13)
        Me.LblTimbrado.TabIndex = 99
        '
        'LblUUID
        '
        Me.LblUUID.AutoSize = True
        Me.LblUUID.Location = New System.Drawing.Point(4, 9)
        Me.LblUUID.Name = "LblUUID"
        Me.LblUUID.Size = New System.Drawing.Size(0, 13)
        Me.LblUUID.TabIndex = 101
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPrincipal)
        Me.TabControl1.Controls.Add(Me.TabDoctos)
        Me.TabControl1.Location = New System.Drawing.Point(5, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(602, 493)
        Me.TabControl1.TabIndex = 102
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Controls.Add(Me.CmbTipoAbono)
        Me.TabPrincipal.Controls.Add(Me.LblUUID)
        Me.TabPrincipal.Controls.Add(Me.LblFechaAbono)
        Me.TabPrincipal.Controls.Add(Me.LblTimbrado)
        Me.TabPrincipal.Controls.Add(Me.GbCliente)
        Me.TabPrincipal.Controls.Add(Me.Label3)
        Me.TabPrincipal.Controls.Add(Me.GbBeneficiario)
        Me.TabPrincipal.Controls.Add(Me.CmbMoneda)
        Me.TabPrincipal.Controls.Add(Me.LblNOperacion)
        Me.TabPrincipal.Controls.Add(Me.TxtObservaciones)
        Me.TabPrincipal.Controls.Add(Me.DtpFecha)
        Me.TabPrincipal.Controls.Add(Me.LblObservaciones)
        Me.TabPrincipal.Controls.Add(Me.LblTipoAbono)
        Me.TabPrincipal.Controls.Add(Me.Label4)
        Me.TabPrincipal.Controls.Add(Me.TxtNOperacion)
        Me.TabPrincipal.Controls.Add(Me.CmbFormaPago)
        Me.TabPrincipal.Controls.Add(Me.TxtCantidad)
        Me.TabPrincipal.Controls.Add(Me.LblCantidad)
        Me.TabPrincipal.Location = New System.Drawing.Point(4, 22)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPrincipal.Size = New System.Drawing.Size(594, 467)
        Me.TabPrincipal.TabIndex = 0
        Me.TabPrincipal.Text = "Principal"
        Me.TabPrincipal.UseVisualStyleBackColor = True
        '
        'TabDoctos
        '
        Me.TabDoctos.Controls.Add(Me.GbFacturas)
        Me.TabDoctos.Controls.Add(Me.GbSustitucion)
        Me.TabDoctos.Location = New System.Drawing.Point(4, 22)
        Me.TabDoctos.Name = "TabDoctos"
        Me.TabDoctos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDoctos.Size = New System.Drawing.Size(594, 467)
        Me.TabDoctos.TabIndex = 1
        Me.TabDoctos.Text = "Documentos Relacionados"
        Me.TabDoctos.UseVisualStyleBackColor = True
        '
        'GbFacturas
        '
        Me.GbFacturas.Controls.Add(Me.RbAdminPAQ)
        Me.GbFacturas.Controls.Add(Me.RbArgo)
        Me.GbFacturas.Controls.Add(Me.DgvFacturas)
        Me.GbFacturas.Controls.Add(Me.Button1)
        Me.GbFacturas.Controls.Add(Me.TxtPorAplicar)
        Me.GbFacturas.Controls.Add(Me.TxtTAbonos)
        Me.GbFacturas.Controls.Add(Me.Label6)
        Me.GbFacturas.Controls.Add(Me.Label5)
        Me.GbFacturas.Location = New System.Drawing.Point(6, 6)
        Me.GbFacturas.Name = "GbFacturas"
        Me.GbFacturas.Size = New System.Drawing.Size(579, 259)
        Me.GbFacturas.TabIndex = 103
        Me.GbFacturas.TabStop = False
        Me.GbFacturas.Text = "Facturas a las que se le aplica el pago"
        '
        'RbAdminPAQ
        '
        Me.RbAdminPAQ.AutoSize = True
        Me.RbAdminPAQ.Location = New System.Drawing.Point(326, 41)
        Me.RbAdminPAQ.Name = "RbAdminPAQ"
        Me.RbAdminPAQ.Size = New System.Drawing.Size(76, 17)
        Me.RbAdminPAQ.TabIndex = 103
        Me.RbAdminPAQ.TabStop = True
        Me.RbAdminPAQ.Text = "AdminPAQ"
        Me.RbAdminPAQ.UseVisualStyleBackColor = True
        '
        'RbArgo
        '
        Me.RbArgo.AutoSize = True
        Me.RbArgo.Location = New System.Drawing.Point(270, 40)
        Me.RbArgo.Name = "RbArgo"
        Me.RbArgo.Size = New System.Drawing.Size(47, 17)
        Me.RbArgo.TabIndex = 102
        Me.RbArgo.TabStop = True
        Me.RbArgo.Text = "Argo"
        Me.RbArgo.UseVisualStyleBackColor = True
        '
        'DgvFacturas
        '
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idAbonoFactura, Me.FolioFiscal, Me.Fecha, Me.idFactura, Me.Total, Me.SaldoAnterior, Me.Abono, Me.SaldoActual})
        Me.DgvFacturas.Location = New System.Drawing.Point(6, 66)
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.Size = New System.Drawing.Size(567, 187)
        Me.DgvFacturas.TabIndex = 95
        '
        'idAbonoFactura
        '
        Me.idAbonoFactura.HeaderText = "idAbonoFactura"
        Me.idAbonoFactura.Name = "idAbonoFactura"
        Me.idAbonoFactura.ReadOnly = True
        Me.idAbonoFactura.Visible = False
        '
        'FolioFiscal
        '
        Me.FolioFiscal.HeaderText = "FolioFiscal"
        Me.FolioFiscal.Name = "FolioFiscal"
        Me.FolioFiscal.ReadOnly = True
        Me.FolioFiscal.Visible = False
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MaxInputLength = 10
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 80
        '
        'idFactura
        '
        Me.idFactura.HeaderText = "Factura"
        Me.idFactura.Name = "idFactura"
        Me.idFactura.Width = 75
        '
        'Total
        '
        DataGridViewCellStyle1.Format = "C2"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle1
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 80
        '
        'SaldoAnterior
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.SaldoAnterior.DefaultCellStyle = DataGridViewCellStyle2
        Me.SaldoAnterior.HeaderText = "Saldo Anterior"
        Me.SaldoAnterior.Name = "SaldoAnterior"
        '
        'Abono
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Abono.DefaultCellStyle = DataGridViewCellStyle3
        Me.Abono.HeaderText = "Abono"
        Me.Abono.Name = "Abono"
        '
        'SaldoActual
        '
        DataGridViewCellStyle4.Format = "C2"
        Me.SaldoActual.DefaultCellStyle = DataGridViewCellStyle4
        Me.SaldoActual.HeaderText = "Saldo Actual"
        Me.SaldoActual.Name = "SaldoActual"
        Me.SaldoActual.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(498, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtPorAplicar
        '
        Me.TxtPorAplicar.Location = New System.Drawing.Point(99, 40)
        Me.TxtPorAplicar.Name = "TxtPorAplicar"
        Me.TxtPorAplicar.Size = New System.Drawing.Size(87, 20)
        Me.TxtPorAplicar.TabIndex = 99
        Me.TxtPorAplicar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTAbonos
        '
        Me.TxtTAbonos.Location = New System.Drawing.Point(6, 40)
        Me.TxtTAbonos.Name = "TxtTAbonos"
        Me.TxtTAbonos.Size = New System.Drawing.Size(87, 20)
        Me.TxtTAbonos.TabIndex = 98
        Me.TxtTAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Por aplicar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Total Abonos"
        '
        'GbSustitucion
        '
        Me.GbSustitucion.Controls.Add(Me.BtnBuscaCancelados)
        Me.GbSustitucion.Controls.Add(Me.DataGridView1)
        Me.GbSustitucion.Location = New System.Drawing.Point(6, 271)
        Me.GbSustitucion.Name = "GbSustitucion"
        Me.GbSustitucion.Size = New System.Drawing.Size(579, 167)
        Me.GbSustitucion.TabIndex = 101
        Me.GbSustitucion.TabStop = False
        Me.GbSustitucion.Text = "Sustitucion de los Pagos Previos"
        '
        'BtnBuscaCancelados
        '
        Me.BtnBuscaCancelados.Location = New System.Drawing.Point(498, 19)
        Me.BtnBuscaCancelados.Name = "BtnBuscaCancelados"
        Me.BtnBuscaCancelados.Size = New System.Drawing.Size(75, 31)
        Me.BtnBuscaCancelados.TabIndex = 101
        Me.BtnBuscaCancelados.Text = "Buscar"
        Me.BtnBuscaCancelados.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(567, 105)
        Me.DataGridView1.TabIndex = 100
        '
        'FrmAbono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 547)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.BtnTimbrar)
        Me.Controls.Add(Me.btnMostrarPDF)
        Me.Controls.Add(Me.TxtFolio)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "FrmAbono"
        Me.Text = "Registro de Abono del Cliente"
        Me.GbBeneficiario.ResumeLayout(False)
        Me.GbBeneficiario.PerformLayout()
        Me.GbCliente.ResumeLayout(False)
        Me.GbCliente.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPrincipal.ResumeLayout(False)
        Me.TabPrincipal.PerformLayout()
        Me.TabDoctos.ResumeLayout(False)
        Me.GbFacturas.ResumeLayout(False)
        Me.GbFacturas.PerformLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbSustitucion.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Windows.Forms.Button
    Friend WithEvents BtnCancelar As Windows.Forms.Button
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents TxtFolio As Windows.Forms.TextBox
    Friend WithEvents lblFolio As Windows.Forms.Label
    Friend WithEvents LblFechaAbono As Windows.Forms.Label
    Friend WithEvents TxtCuenta As Windows.Forms.TextBox
    Friend WithEvents LblCuenta As Windows.Forms.Label
    Friend WithEvents btnF3 As Windows.Forms.Button
    Friend WithEvents TxtIdCte As Windows.Forms.TextBox
    Friend WithEvents LblCliente As Windows.Forms.Label
    Friend WithEvents TxtNombreCte As Windows.Forms.TextBox
    Friend WithEvents TxtCuentaCliente As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents LblBancoD As Windows.Forms.Label
    Friend WithEvents CmbMoneda As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents LblReferencia As Windows.Forms.Label
    Friend WithEvents TxtReferencia As Windows.Forms.TextBox
    Friend WithEvents LblObservaciones As Windows.Forms.Label
    Friend WithEvents TxtObservaciones As Windows.Forms.TextBox
    Friend WithEvents CmbFormaPago As Windows.Forms.ComboBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents TxtCantidad As Windows.Forms.TextBox
    Friend WithEvents LblCantidad As Windows.Forms.Label
    Friend WithEvents btnMostrarPDF As Windows.Forms.Button
    Friend WithEvents BtnTimbrar As Windows.Forms.Button
    Friend WithEvents BtnEnviar As Windows.Forms.Button
    Friend WithEvents CmbTipoAbono As Windows.Forms.ComboBox
    Friend WithEvents LblTipoAbono As Windows.Forms.Label
    Friend WithEvents DtpFecha As Windows.Forms.DateTimePicker
    Friend WithEvents LblNOperacion As Windows.Forms.Label
    Friend WithEvents TxtNOperacion As Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents LblRFCBancoD As Windows.Forms.Label
    Friend WithEvents GbBeneficiario As Windows.Forms.GroupBox
    Friend WithEvents GbCliente As Windows.Forms.GroupBox
    Friend WithEvents LblRFCBancoE As Windows.Forms.Label
    Friend WithEvents LblBancoE As Windows.Forms.Label
    Friend WithEvents LblTimbrado As Windows.Forms.Label
    Friend WithEvents LblUUID As Windows.Forms.Label
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabPrincipal As Windows.Forms.TabPage
    Friend WithEvents TabDoctos As Windows.Forms.TabPage
    Friend WithEvents DgvFacturas As Windows.Forms.DataGridView
    Friend WithEvents idAbonoFactura As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioFiscal As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idFactura As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAnterior As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Abono As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoActual As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents TxtTAbonos As Windows.Forms.TextBox
    Friend WithEvents TxtPorAplicar As Windows.Forms.TextBox
    Friend WithEvents GbFacturas As Windows.Forms.GroupBox
    Friend WithEvents RbAdminPAQ As Windows.Forms.RadioButton
    Friend WithEvents RbArgo As Windows.Forms.RadioButton
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents GbSustitucion As Windows.Forms.GroupBox
    Friend WithEvents BtnBuscaCancelados As Windows.Forms.Button
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
End Class
