<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuentaBancaria
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
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.GbpDatos = New System.Windows.Forms.GroupBox()
        Me.RbtPrede = New System.Windows.Forms.RadioButton()
        Me.LblIdbanco = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.TxtReferencia = New System.Windows.Forms.TextBox()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.Lblreferencia = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.TxtCodCliente = New System.Windows.Forms.TextBox()
        Me.TxtClabe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNoCuenta = New System.Windows.Forms.TextBox()
        Me.LblCuenta = New System.Windows.Forms.Label()
        Me.BtnF3Cuenta = New System.Windows.Forms.Button()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.TxtFechaRegistro = New System.Windows.Forms.TextBox()
        Me.GpbBanco = New System.Windows.Forms.GroupBox()
        Me.LblCuentaBanco = New System.Windows.Forms.Label()
        Me.BtnF3Banco = New System.Windows.Forms.Button()
        Me.LblDescripcionBanco = New System.Windows.Forms.Label()
        Me.LblBanco = New System.Windows.Forms.Label()
        Me.TxtRfcBanco = New System.Windows.Forms.TextBox()
        Me.LblRfc = New System.Windows.Forms.Label()
        Me.TxtCodBanco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RbtInactiva = New System.Windows.Forms.RadioButton()
        Me.RbtCuentasBancarias = New System.Windows.Forms.RadioButton()
        Me.RbtCuentaSuc = New System.Windows.Forms.RadioButton()
        Me.RbtCuentaCliente = New System.Windows.Forms.RadioButton()
        Me.RbtVerCuentasClientes = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbtActivar = New System.Windows.Forms.RadioButton()
        Me.txtCodCte = New System.Windows.Forms.TextBox()
        Me.BtnCuentasCliente = New System.Windows.Forms.Button()
        Me.RbtNoPredeterminada = New System.Windows.Forms.RadioButton()
        Me.GbpDatos.SuspendLayout()
        Me.GpbBanco.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 15)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(73, 36)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(89, 15)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 36)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(168, 15)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 36)
        Me.BtnLimpiar.TabIndex = 2
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'GbpDatos
        '
        Me.GbpDatos.Controls.Add(Me.RbtNoPredeterminada)
        Me.GbpDatos.Controls.Add(Me.RbtPrede)
        Me.GbpDatos.Controls.Add(Me.LblIdbanco)
        Me.GbpDatos.Controls.Add(Me.Label2)
        Me.GbpDatos.Controls.Add(Me.BtnCliente)
        Me.GbpDatos.Controls.Add(Me.TxtReferencia)
        Me.GbpDatos.Controls.Add(Me.LblCliente)
        Me.GbpDatos.Controls.Add(Me.Lblreferencia)
        Me.GbpDatos.Controls.Add(Me.TxtCliente)
        Me.GbpDatos.Controls.Add(Me.TxtCodCliente)
        Me.GbpDatos.Controls.Add(Me.TxtClabe)
        Me.GbpDatos.Controls.Add(Me.Label3)
        Me.GbpDatos.Controls.Add(Me.TxtNoCuenta)
        Me.GbpDatos.Controls.Add(Me.LblCuenta)
        Me.GbpDatos.Location = New System.Drawing.Point(12, 125)
        Me.GbpDatos.Name = "GbpDatos"
        Me.GbpDatos.Size = New System.Drawing.Size(673, 130)
        Me.GbpDatos.TabIndex = 3
        Me.GbpDatos.TabStop = False
        Me.GbpDatos.Text = "Datos Generales"
        '
        'RbtPrede
        '
        Me.RbtPrede.AutoSize = True
        Me.RbtPrede.Location = New System.Drawing.Point(347, 12)
        Me.RbtPrede.Name = "RbtPrede"
        Me.RbtPrede.Size = New System.Drawing.Size(99, 17)
        Me.RbtPrede.TabIndex = 21
        Me.RbtPrede.TabStop = True
        Me.RbtPrede.Text = "Predeterminada"
        Me.RbtPrede.UseVisualStyleBackColor = True
        Me.RbtPrede.Visible = False
        '
        'LblIdbanco
        '
        Me.LblIdbanco.AutoSize = True
        Me.LblIdbanco.Location = New System.Drawing.Point(294, 12)
        Me.LblIdbanco.Name = "LblIdbanco"
        Me.LblIdbanco.Size = New System.Drawing.Size(45, 13)
        Me.LblIdbanco.TabIndex = 20
        Me.LblIdbanco.Text = "idbanco"
        Me.LblIdbanco.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "(Transacciones)"
        '
        'BtnCliente
        '
        Me.BtnCliente.Location = New System.Drawing.Point(346, 59)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(30, 21)
        Me.BtnCliente.TabIndex = 18
        Me.BtnCliente.Text = "F3"
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'TxtReferencia
        '
        Me.TxtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtReferencia.Location = New System.Drawing.Point(102, 59)
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(189, 20)
        Me.TxtReferencia.TabIndex = 12
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Location = New System.Drawing.Point(297, 43)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(39, 13)
        Me.LblCliente.TabIndex = 13
        Me.LblCliente.Text = "Cliente"
        '
        'Lblreferencia
        '
        Me.Lblreferencia.AutoSize = True
        Me.Lblreferencia.Location = New System.Drawing.Point(43, 59)
        Me.Lblreferencia.Name = "Lblreferencia"
        Me.Lblreferencia.Size = New System.Drawing.Size(59, 13)
        Me.Lblreferencia.TabIndex = 11
        Me.Lblreferencia.Text = "Referencia"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(347, 59)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(320, 20)
        Me.TxtCliente.TabIndex = 15
        '
        'TxtCodCliente
        '
        Me.TxtCodCliente.Location = New System.Drawing.Point(297, 59)
        Me.TxtCodCliente.Name = "TxtCodCliente"
        Me.TxtCodCliente.Size = New System.Drawing.Size(49, 20)
        Me.TxtCodCliente.TabIndex = 14
        Me.TxtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtClabe
        '
        Me.TxtClabe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtClabe.Location = New System.Drawing.Point(102, 90)
        Me.TxtClabe.Name = "TxtClabe"
        Me.TxtClabe.Size = New System.Drawing.Size(189, 20)
        Me.TxtClabe.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Clabe"
        '
        'TxtNoCuenta
        '
        Me.TxtNoCuenta.Location = New System.Drawing.Point(102, 27)
        Me.TxtNoCuenta.Name = "TxtNoCuenta"
        Me.TxtNoCuenta.Size = New System.Drawing.Size(189, 20)
        Me.TxtNoCuenta.TabIndex = 2
        '
        'LblCuenta
        '
        Me.LblCuenta.AutoSize = True
        Me.LblCuenta.Location = New System.Drawing.Point(6, 27)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(96, 13)
        Me.LblCuenta.TabIndex = 0
        Me.LblCuenta.Text = "Numero de Cuenta"
        '
        'BtnF3Cuenta
        '
        Me.BtnF3Cuenta.Location = New System.Drawing.Point(133, 38)
        Me.BtnF3Cuenta.Name = "BtnF3Cuenta"
        Me.BtnF3Cuenta.Size = New System.Drawing.Size(30, 21)
        Me.BtnF3Cuenta.TabIndex = 7
        Me.BtnF3Cuenta.Text = "F3"
        Me.BtnF3Cuenta.UseVisualStyleBackColor = True
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(9, 84)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(94, 13)
        Me.LblFecha.TabIndex = 4
        Me.LblFecha.Text = "Fecha de Registro"
        '
        'TxtFechaRegistro
        '
        Me.TxtFechaRegistro.Location = New System.Drawing.Point(103, 81)
        Me.TxtFechaRegistro.Name = "TxtFechaRegistro"
        Me.TxtFechaRegistro.ReadOnly = True
        Me.TxtFechaRegistro.Size = New System.Drawing.Size(89, 20)
        Me.TxtFechaRegistro.TabIndex = 5
        Me.TxtFechaRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GpbBanco
        '
        Me.GpbBanco.Controls.Add(Me.LblCuentaBanco)
        Me.GpbBanco.Controls.Add(Me.BtnF3Banco)
        Me.GpbBanco.Controls.Add(Me.LblDescripcionBanco)
        Me.GpbBanco.Controls.Add(Me.LblBanco)
        Me.GpbBanco.Controls.Add(Me.TxtRfcBanco)
        Me.GpbBanco.Controls.Add(Me.LblRfc)
        Me.GpbBanco.Controls.Add(Me.TxtCodBanco)
        Me.GpbBanco.Controls.Add(Me.Label1)
        Me.GpbBanco.Location = New System.Drawing.Point(12, 264)
        Me.GpbBanco.Name = "GpbBanco"
        Me.GpbBanco.Size = New System.Drawing.Size(673, 149)
        Me.GpbBanco.TabIndex = 6
        Me.GpbBanco.TabStop = False
        Me.GpbBanco.Text = "Informacion del Banco"
        '
        'LblCuentaBanco
        '
        Me.LblCuentaBanco.AutoSize = True
        Me.LblCuentaBanco.Location = New System.Drawing.Point(589, 9)
        Me.LblCuentaBanco.Name = "LblCuentaBanco"
        Me.LblCuentaBanco.Size = New System.Drawing.Size(80, 13)
        Me.LblCuentaBanco.TabIndex = 21
        Me.LblCuentaBanco.Text = "idCuentaBanco"
        Me.LblCuentaBanco.Visible = False
        '
        'BtnF3Banco
        '
        Me.BtnF3Banco.Location = New System.Drawing.Point(102, 26)
        Me.BtnF3Banco.Name = "BtnF3Banco"
        Me.BtnF3Banco.Size = New System.Drawing.Size(30, 21)
        Me.BtnF3Banco.TabIndex = 8
        Me.BtnF3Banco.Text = "F3"
        Me.BtnF3Banco.UseVisualStyleBackColor = True
        '
        'LblDescripcionBanco
        '
        Me.LblDescripcionBanco.AutoSize = True
        Me.LblDescripcionBanco.Location = New System.Drawing.Point(52, 114)
        Me.LblDescripcionBanco.Name = "LblDescripcionBanco"
        Me.LblDescripcionBanco.Size = New System.Drawing.Size(63, 13)
        Me.LblDescripcionBanco.TabIndex = 7
        Me.LblDescripcionBanco.Text = "Descripcion"
        '
        'LblBanco
        '
        Me.LblBanco.AutoSize = True
        Me.LblBanco.Location = New System.Drawing.Point(52, 86)
        Me.LblBanco.Name = "LblBanco"
        Me.LblBanco.Size = New System.Drawing.Size(38, 13)
        Me.LblBanco.TabIndex = 6
        Me.LblBanco.Text = "Banco"
        '
        'TxtRfcBanco
        '
        Me.TxtRfcBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRfcBanco.Location = New System.Drawing.Point(50, 58)
        Me.TxtRfcBanco.Name = "TxtRfcBanco"
        Me.TxtRfcBanco.Size = New System.Drawing.Size(174, 20)
        Me.TxtRfcBanco.TabIndex = 5
        Me.TxtRfcBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblRfc
        '
        Me.LblRfc.AutoSize = True
        Me.LblRfc.Location = New System.Drawing.Point(20, 58)
        Me.LblRfc.Name = "LblRfc"
        Me.LblRfc.Size = New System.Drawing.Size(24, 13)
        Me.LblRfc.TabIndex = 4
        Me.LblRfc.Text = "Rfc"
        '
        'TxtCodBanco
        '
        Me.TxtCodBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodBanco.Location = New System.Drawing.Point(50, 27)
        Me.TxtCodBanco.Name = "TxtCodBanco"
        Me.TxtCodBanco.Size = New System.Drawing.Size(52, 20)
        Me.TxtCodBanco.TabIndex = 3
        Me.TxtCodBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco"
        '
        'RbtInactiva
        '
        Me.RbtInactiva.AutoSize = True
        Me.RbtInactiva.Location = New System.Drawing.Point(262, 82)
        Me.RbtInactiva.Name = "RbtInactiva"
        Me.RbtInactiva.Size = New System.Drawing.Size(63, 17)
        Me.RbtInactiva.TabIndex = 8
        Me.RbtInactiva.TabStop = True
        Me.RbtInactiva.Text = "Inactiva"
        Me.RbtInactiva.UseVisualStyleBackColor = True
        '
        'RbtCuentasBancarias
        '
        Me.RbtCuentasBancarias.AutoSize = True
        Me.RbtCuentasBancarias.Location = New System.Drawing.Point(6, 42)
        Me.RbtCuentasBancarias.Name = "RbtCuentasBancarias"
        Me.RbtCuentasBancarias.Size = New System.Drawing.Size(127, 17)
        Me.RbtCuentasBancarias.TabIndex = 9
        Me.RbtCuentasBancarias.TabStop = True
        Me.RbtCuentasBancarias.Text = "Ver Cuentas Sucursal"
        Me.RbtCuentasBancarias.UseVisualStyleBackColor = True
        '
        'RbtCuentaSuc
        '
        Me.RbtCuentaSuc.AutoSize = True
        Me.RbtCuentaSuc.Location = New System.Drawing.Point(6, 19)
        Me.RbtCuentaSuc.Name = "RbtCuentaSuc"
        Me.RbtCuentaSuc.Size = New System.Drawing.Size(124, 17)
        Me.RbtCuentaSuc.TabIndex = 10
        Me.RbtCuentaSuc.TabStop = True
        Me.RbtCuentaSuc.Text = "Alta Cuenta Sucursal"
        Me.RbtCuentaSuc.UseVisualStyleBackColor = True
        '
        'RbtCuentaCliente
        '
        Me.RbtCuentaCliente.AutoSize = True
        Me.RbtCuentaCliente.Location = New System.Drawing.Point(178, 19)
        Me.RbtCuentaCliente.Name = "RbtCuentaCliente"
        Me.RbtCuentaCliente.Size = New System.Drawing.Size(115, 17)
        Me.RbtCuentaCliente.TabIndex = 11
        Me.RbtCuentaCliente.TabStop = True
        Me.RbtCuentaCliente.Text = "Alta Cuenta Cliente"
        Me.RbtCuentaCliente.UseVisualStyleBackColor = True
        '
        'RbtVerCuentasClientes
        '
        Me.RbtVerCuentasClientes.AutoSize = True
        Me.RbtVerCuentasClientes.Location = New System.Drawing.Point(178, 42)
        Me.RbtVerCuentasClientes.Name = "RbtVerCuentasClientes"
        Me.RbtVerCuentasClientes.Size = New System.Drawing.Size(136, 17)
        Me.RbtVerCuentasClientes.TabIndex = 16
        Me.RbtVerCuentasClientes.TabStop = True
        Me.RbtVerCuentasClientes.Text = "Ver Cuentas por Cliente"
        Me.RbtVerCuentasClientes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbtActivar)
        Me.GroupBox1.Controls.Add(Me.txtCodCte)
        Me.GroupBox1.Controls.Add(Me.BtnCuentasCliente)
        Me.GroupBox1.Controls.Add(Me.RbtCuentaCliente)
        Me.GroupBox1.Controls.Add(Me.RbtInactiva)
        Me.GroupBox1.Controls.Add(Me.RbtCuentasBancarias)
        Me.GroupBox1.Controls.Add(Me.BtnF3Cuenta)
        Me.GroupBox1.Controls.Add(Me.RbtCuentaSuc)
        Me.GroupBox1.Controls.Add(Me.RbtVerCuentasClientes)
        Me.GroupBox1.Location = New System.Drawing.Point(279, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 104)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'RbtActivar
        '
        Me.RbtActivar.AutoSize = True
        Me.RbtActivar.Location = New System.Drawing.Point(342, 82)
        Me.RbtActivar.Name = "RbtActivar"
        Me.RbtActivar.Size = New System.Drawing.Size(58, 17)
        Me.RbtActivar.TabIndex = 21
        Me.RbtActivar.TabStop = True
        Me.RbtActivar.Text = "Activar"
        Me.RbtActivar.UseVisualStyleBackColor = True
        '
        'txtCodCte
        '
        Me.txtCodCte.Location = New System.Drawing.Point(310, 42)
        Me.txtCodCte.Name = "txtCodCte"
        Me.txtCodCte.Size = New System.Drawing.Size(41, 20)
        Me.txtCodCte.TabIndex = 18
        Me.txtCodCte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCuentasCliente
        '
        Me.BtnCuentasCliente.Location = New System.Drawing.Point(351, 41)
        Me.BtnCuentasCliente.Name = "BtnCuentasCliente"
        Me.BtnCuentasCliente.Size = New System.Drawing.Size(30, 21)
        Me.BtnCuentasCliente.TabIndex = 17
        Me.BtnCuentasCliente.Text = "F3"
        Me.BtnCuentasCliente.UseVisualStyleBackColor = True
        '
        'RbtNoPredeterminada
        '
        Me.RbtNoPredeterminada.AutoSize = True
        Me.RbtNoPredeterminada.Location = New System.Drawing.Point(448, 12)
        Me.RbtNoPredeterminada.Name = "RbtNoPredeterminada"
        Me.RbtNoPredeterminada.Size = New System.Drawing.Size(116, 17)
        Me.RbtNoPredeterminada.TabIndex = 22
        Me.RbtNoPredeterminada.TabStop = True
        Me.RbtNoPredeterminada.Text = "No Predeterminada"
        Me.RbtNoPredeterminada.UseVisualStyleBackColor = True
        Me.RbtNoPredeterminada.Visible = False
        '
        'FrmCuentaBancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 425)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GpbBanco)
        Me.Controls.Add(Me.GbpDatos)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.TxtFechaRegistro)
        Me.Name = "FrmCuentaBancaria"
        Me.Text = "Cuentas Bancarias"
        Me.GbpDatos.ResumeLayout(False)
        Me.GbpDatos.PerformLayout()
        Me.GpbBanco.ResumeLayout(False)
        Me.GpbBanco.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNuevo As Windows.Forms.Button
    Friend WithEvents BtnModificar As Windows.Forms.Button
    Friend WithEvents BtnLimpiar As Windows.Forms.Button
    Friend WithEvents GbpDatos As Windows.Forms.GroupBox
    Friend WithEvents TxtNoCuenta As Windows.Forms.TextBox
    Friend WithEvents LblCuenta As Windows.Forms.Label
    Friend WithEvents LblFecha As Windows.Forms.Label
    Friend WithEvents TxtFechaRegistro As Windows.Forms.TextBox
    Friend WithEvents GpbBanco As Windows.Forms.GroupBox
    Friend WithEvents TxtRfcBanco As Windows.Forms.TextBox
    Friend WithEvents LblRfc As Windows.Forms.Label
    Friend WithEvents TxtCodBanco As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents LblDescripcionBanco As Windows.Forms.Label
    Friend WithEvents LblBanco As Windows.Forms.Label
    Friend WithEvents BtnF3Cuenta As Windows.Forms.Button
    Friend WithEvents BtnF3Banco As Windows.Forms.Button
    Friend WithEvents RbtInactiva As Windows.Forms.RadioButton
    Friend WithEvents RbtCuentasBancarias As Windows.Forms.RadioButton
    Friend WithEvents TxtReferencia As Windows.Forms.TextBox
    Friend WithEvents Lblreferencia As Windows.Forms.Label
    Friend WithEvents TxtClabe As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents RbtCuentaSuc As Windows.Forms.RadioButton
    Friend WithEvents RbtCuentaCliente As Windows.Forms.RadioButton
    Friend WithEvents TxtCliente As Windows.Forms.TextBox
    Friend WithEvents TxtCodCliente As Windows.Forms.TextBox
    Friend WithEvents LblCliente As Windows.Forms.Label
    Friend WithEvents RbtVerCuentasClientes As Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents BtnCuentasCliente As Windows.Forms.Button
    Friend WithEvents BtnCliente As Windows.Forms.Button
    Friend WithEvents txtCodCte As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents LblIdbanco As Windows.Forms.Label
    Friend WithEvents RbtActivar As Windows.Forms.RadioButton
    Friend WithEvents LblCuentaBanco As Windows.Forms.Label
    Friend WithEvents RbtPrede As Windows.Forms.RadioButton
    Friend WithEvents RbtNoPredeterminada As Windows.Forms.RadioButton
End Class
