<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProspecto
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
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BttModificar = New System.Windows.Forms.Button()
        Me.BttnEliminar = New System.Windows.Forms.Button()
        Me.BttnLimpiar = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtContacto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtNInterior = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNExt = New System.Windows.Forms.TextBox()
        Me.TxtCP = New System.Windows.Forms.TextBox()
        Me.CmbCiudad = New System.Windows.Forms.ComboBox()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtColonia = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtFechalta = New System.Windows.Forms.Label()
        Me.BtnF3 = New System.Windows.Forms.Button()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.RichTxtObservaciones = New System.Windows.Forms.RichTextBox()
        Me.TxtAlias = New System.Windows.Forms.TextBox()
        Me.TxtGiroComercial = New System.Windows.Forms.TextBox()
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.CmbDiasCred = New System.Windows.Forms.ComboBox()
        Me.LblDiasCred = New System.Windows.Forms.Label()
        Me.LblFormaPago = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbVendedor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TextIDprospecto = New System.Windows.Forms.TextBox()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(12, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 151
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BttModificar
        '
        Me.BttModificar.Location = New System.Drawing.Point(94, 12)
        Me.BttModificar.Name = "BttModificar"
        Me.BttModificar.Size = New System.Drawing.Size(75, 23)
        Me.BttModificar.TabIndex = 165
        Me.BttModificar.Text = "Modificar"
        Me.BttModificar.UseVisualStyleBackColor = True
        '
        'BttnEliminar
        '
        Me.BttnEliminar.Location = New System.Drawing.Point(175, 12)
        Me.BttnEliminar.Name = "BttnEliminar"
        Me.BttnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BttnEliminar.TabIndex = 166
        Me.BttnEliminar.Text = "Eliminar"
        Me.BttnEliminar.UseVisualStyleBackColor = True
        '
        'BttnLimpiar
        '
        Me.BttnLimpiar.Location = New System.Drawing.Point(308, 12)
        Me.BttnLimpiar.Name = "BttnLimpiar"
        Me.BttnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BttnLimpiar.TabIndex = 168
        Me.BttnLimpiar.Text = "Limpiar"
        Me.BttnLimpiar.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(367, 349)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Contacto"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.TxtContacto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtCorreo)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 129)
        Me.GroupBox1.TabIndex = 162
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contacto"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(108, 84)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(210, 20)
        Me.TxtTelefono.TabIndex = 146
        '
        'TxtContacto
        '
        Me.TxtContacto.Location = New System.Drawing.Point(108, 26)
        Me.TxtContacto.Name = "TxtContacto"
        Me.TxtContacto.Size = New System.Drawing.Size(210, 20)
        Me.TxtContacto.TabIndex = 135
        Me.TxtContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "Telefono :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "Contacto "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "Correo :"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(108, 54)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(210, 20)
        Me.TxtCorreo.TabIndex = 145
        Me.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.TxtNInterior)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.TxtNExt)
        Me.TabPage1.Controls.Add(Me.TxtCP)
        Me.TabPage1.Controls.Add(Me.CmbCiudad)
        Me.TabPage1.Controls.Add(Me.CmbEstado)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.TxtDomicilio)
        Me.TabPage1.Controls.Add(Me.TxtColonia)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(367, 349)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Dirección"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "No. Int"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "No. Ext"
        '
        'TxtNInterior
        '
        Me.TxtNInterior.Location = New System.Drawing.Point(173, 62)
        Me.TxtNInterior.Name = "TxtNInterior"
        Me.TxtNInterior.Size = New System.Drawing.Size(42, 20)
        Me.TxtNInterior.TabIndex = 172
        Me.TxtNInterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(239, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "CP"
        '
        'TxtNExt
        '
        Me.TxtNExt.Location = New System.Drawing.Point(64, 62)
        Me.TxtNExt.Name = "TxtNExt"
        Me.TxtNExt.Size = New System.Drawing.Size(42, 20)
        Me.TxtNExt.TabIndex = 171
        Me.TxtNExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCP
        '
        Me.TxtCP.Location = New System.Drawing.Point(266, 61)
        Me.TxtCP.Name = "TxtCP"
        Me.TxtCP.Size = New System.Drawing.Size(65, 20)
        Me.TxtCP.TabIndex = 15
        '
        'CmbCiudad
        '
        Me.CmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCiudad.FormattingEnabled = True
        Me.CmbCiudad.Location = New System.Drawing.Point(64, 155)
        Me.CmbCiudad.Name = "CmbCiudad"
        Me.CmbCiudad.Size = New System.Drawing.Size(181, 21)
        Me.CmbCiudad.TabIndex = 170
        '
        'CmbEstado
        '
        Me.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(64, 119)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(181, 21)
        Me.CmbEstado.TabIndex = 169
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "Estado:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 166
        Me.Label12.Text = "Ciudad:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 156
        Me.Label15.Text = "Calle:"
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDomicilio.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TxtDomicilio.Location = New System.Drawing.Point(64, 32)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(267, 20)
        Me.TxtDomicilio.TabIndex = 157
        Me.TxtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtColonia
        '
        Me.TxtColonia.Location = New System.Drawing.Point(64, 91)
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(267, 20)
        Me.TxtColonia.TabIndex = 158
        Me.TxtColonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 159
        Me.Label16.Text = "Colonia:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextIDprospecto)
        Me.TabPage2.Controls.Add(Me.TxtFechalta)
        Me.TabPage2.Controls.Add(Me.BtnF3)
        Me.TabPage2.Controls.Add(Me.TextNombre)
        Me.TabPage2.Controls.Add(Me.RichTxtObservaciones)
        Me.TabPage2.Controls.Add(Me.TxtAlias)
        Me.TabPage2.Controls.Add(Me.TxtGiroComercial)
        Me.TabPage2.Controls.Add(Me.CmbFormaPago)
        Me.TabPage2.Controls.Add(Me.CmbDiasCred)
        Me.TabPage2.Controls.Add(Me.LblDiasCred)
        Me.TabPage2.Controls.Add(Me.LblFormaPago)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.CmbVendedor)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(367, 349)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Información"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtFechalta
        '
        Me.TxtFechalta.AutoSize = True
        Me.TxtFechalta.Location = New System.Drawing.Point(278, 212)
        Me.TxtFechalta.Name = "TxtFechalta"
        Me.TxtFechalta.Size = New System.Drawing.Size(37, 13)
        Me.TxtFechalta.TabIndex = 179
        Me.TxtFechalta.Text = "Fecha"
        '
        'BtnF3
        '
        Me.BtnF3.Location = New System.Drawing.Point(101, 20)
        Me.BtnF3.Name = "BtnF3"
        Me.BtnF3.Size = New System.Drawing.Size(34, 22)
        Me.BtnF3.TabIndex = 177
        Me.BtnF3.Text = "F3"
        Me.BtnF3.UseVisualStyleBackColor = True
        Me.BtnF3.Visible = False
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(125, 22)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(220, 20)
        Me.TextNombre.TabIndex = 176
        Me.TextNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTxtObservaciones
        '
        Me.RichTxtObservaciones.Location = New System.Drawing.Point(8, 232)
        Me.RichTxtObservaciones.Name = "RichTxtObservaciones"
        Me.RichTxtObservaciones.Size = New System.Drawing.Size(337, 67)
        Me.RichTxtObservaciones.TabIndex = 169
        Me.RichTxtObservaciones.Text = ""
        '
        'TxtAlias
        '
        Me.TxtAlias.Location = New System.Drawing.Point(59, 46)
        Me.TxtAlias.Name = "TxtAlias"
        Me.TxtAlias.Size = New System.Drawing.Size(178, 20)
        Me.TxtAlias.TabIndex = 149
        Me.TxtAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtGiroComercial
        '
        Me.TxtGiroComercial.Location = New System.Drawing.Point(87, 73)
        Me.TxtGiroComercial.Name = "TxtGiroComercial"
        Me.TxtGiroComercial.Size = New System.Drawing.Size(151, 20)
        Me.TxtGiroComercial.TabIndex = 161
        Me.TxtGiroComercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.BackColor = System.Drawing.Color.White
        Me.CmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Location = New System.Drawing.Point(74, 141)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(143, 21)
        Me.CmbFormaPago.TabIndex = 175
        '
        'CmbDiasCred
        '
        Me.CmbDiasCred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDiasCred.FormattingEnabled = True
        Me.CmbDiasCred.Location = New System.Drawing.Point(74, 170)
        Me.CmbDiasCred.Name = "CmbDiasCred"
        Me.CmbDiasCred.Size = New System.Drawing.Size(61, 21)
        Me.CmbDiasCred.TabIndex = 174
        '
        'LblDiasCred
        '
        Me.LblDiasCred.AutoSize = True
        Me.LblDiasCred.Location = New System.Drawing.Point(8, 173)
        Me.LblDiasCred.Name = "LblDiasCred"
        Me.LblDiasCred.Size = New System.Drawing.Size(64, 13)
        Me.LblDiasCred.TabIndex = 173
        Me.LblDiasCred.Text = "Dias Credito"
        '
        'LblFormaPago
        '
        Me.LblFormaPago.AutoSize = True
        Me.LblFormaPago.Location = New System.Drawing.Point(6, 144)
        Me.LblFormaPago.Name = "LblFormaPago"
        Me.LblFormaPago.Size = New System.Drawing.Size(64, 13)
        Me.LblFormaPago.TabIndex = 172
        Me.LblFormaPago.Text = "Forma Pago"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(208, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 171
        Me.Label8.Text = "Fecha Alta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Observaciones"
        '
        'CmbVendedor
        '
        Me.CmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVendedor.FormattingEnabled = True
        Me.CmbVendedor.Location = New System.Drawing.Point(74, 112)
        Me.CmbVendedor.Name = "CmbVendedor"
        Me.CmbVendedor.Size = New System.Drawing.Size(271, 21)
        Me.CmbVendedor.TabIndex = 166
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Vendedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Nombre:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 160
        Me.Label13.Text = "Giro Comercial:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 150
        Me.Label10.Text = "Alias:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(375, 375)
        Me.TabControl1.TabIndex = 167
        '
        'TextIDprospecto
        '
        Me.TextIDprospecto.Location = New System.Drawing.Point(59, 21)
        Me.TextIDprospecto.Name = "TextIDprospecto"
        Me.TextIDprospecto.Size = New System.Drawing.Size(43, 20)
        Me.TextIDprospecto.TabIndex = 180
        Me.TextIDprospecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmProspecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 426)
        Me.Controls.Add(Me.BttnLimpiar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BttnEliminar)
        Me.Controls.Add(Me.BttModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "FrmProspecto"
        Me.Text = "Prospecto"
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents BttModificar As Windows.Forms.Button
    Friend WithEvents BttnEliminar As Windows.Forms.Button
    Friend WithEvents BttnLimpiar As Windows.Forms.Button
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents TxtTelefono As Windows.Forms.TextBox
    Friend WithEvents TxtContacto As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TxtCorreo As Windows.Forms.TextBox
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents CmbCiudad As Windows.Forms.ComboBox
    Friend WithEvents CmbEstado As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents TxtDomicilio As Windows.Forms.TextBox
    Friend WithEvents TxtColonia As Windows.Forms.TextBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents TxtFechalta As Windows.Forms.Label
    Friend WithEvents BtnF3 As Windows.Forms.Button
    Friend WithEvents TextNombre As Windows.Forms.TextBox
    Friend WithEvents RichTxtObservaciones As Windows.Forms.RichTextBox
    Friend WithEvents TxtAlias As Windows.Forms.TextBox
    Friend WithEvents TxtGiroComercial As Windows.Forms.TextBox
    Friend WithEvents CmbFormaPago As Windows.Forms.ComboBox
    Friend WithEvents CmbDiasCred As Windows.Forms.ComboBox
    Friend WithEvents LblDiasCred As Windows.Forms.Label
    Friend WithEvents LblFormaPago As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents CmbVendedor As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TxtNInterior As Windows.Forms.TextBox
    Friend WithEvents TxtNExt As Windows.Forms.TextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents TxtCP As Windows.Forms.TextBox
    Friend WithEvents TextIDprospecto As Windows.Forms.TextBox
End Class
