<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblSucursal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblUsuarios = New System.Windows.Forms.Label()
        Me.CmbSucursal = New System.Windows.Forms.ComboBox()
        Me.CmbAccion = New System.Windows.Forms.ComboBox()
        Me.CmbUsuarios = New System.Windows.Forms.ComboBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.CmbAgente = New System.Windows.Forms.ComboBox()
        Me.LblAgente = New System.Windows.Forms.Label()
        Me.TabPermisos = New System.Windows.Forms.TabControl()
        Me.TabPermiso = New System.Windows.Forms.TabPage()
        Me.ChkTallerPlus = New System.Windows.Forms.CheckBox()
        Me.ChkTraspasosPlus = New System.Windows.Forms.CheckBox()
        Me.ChkCxcPlus = New System.Windows.Forms.CheckBox()
        Me.ChkMostrador = New System.Windows.Forms.CheckBox()
        Me.ChkTaller = New System.Windows.Forms.CheckBox()
        Me.ChkTraspasos = New System.Windows.Forms.CheckBox()
        Me.ChkAlmacen = New System.Windows.Forms.CheckBox()
        Me.ChkCxc = New System.Windows.Forms.CheckBox()
        Me.ChkVtas = New System.Windows.Forms.CheckBox()
        Me.ChkAdmin = New System.Windows.Forms.CheckBox()
        Me.TabReportes = New System.Windows.Forms.TabPage()
        Me.ChkRepVtasPlus = New System.Windows.Forms.CheckBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TabPermisos.SuspendLayout()
        Me.TabPermiso.SuspendLayout()
        Me.TabReportes.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(7, 147)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Usuario"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(81, 147)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(176, 20)
        Me.TxtUsuario.TabIndex = 1
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(81, 169)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(176, 20)
        Me.TxtPassword.TabIndex = 3
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Location = New System.Drawing.Point(7, 172)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(53, 13)
        Me.LblPass.TabIndex = 2
        Me.LblPass.Text = "Password"
        '
        'LblSucursal
        '
        Me.LblSucursal.AutoSize = True
        Me.LblSucursal.Location = New System.Drawing.Point(7, 62)
        Me.LblSucursal.Name = "LblSucursal"
        Me.LblSucursal.Size = New System.Drawing.Size(48, 13)
        Me.LblSucursal.TabIndex = 4
        Me.LblSucursal.Text = "Sucursal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Accion"
        '
        'LblUsuarios
        '
        Me.LblUsuarios.AutoSize = True
        Me.LblUsuarios.Location = New System.Drawing.Point(7, 112)
        Me.LblUsuarios.Name = "LblUsuarios"
        Me.LblUsuarios.Size = New System.Drawing.Size(48, 13)
        Me.LblUsuarios.TabIndex = 6
        Me.LblUsuarios.Text = "Usuarios"
        '
        'CmbSucursal
        '
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(81, 62)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(176, 21)
        Me.CmbSucursal.TabIndex = 7
        '
        'CmbAccion
        '
        Me.CmbAccion.FormattingEnabled = True
        Me.CmbAccion.Location = New System.Drawing.Point(81, 85)
        Me.CmbAccion.Name = "CmbAccion"
        Me.CmbAccion.Size = New System.Drawing.Size(176, 21)
        Me.CmbAccion.TabIndex = 8
        '
        'CmbUsuarios
        '
        Me.CmbUsuarios.FormattingEnabled = True
        Me.CmbUsuarios.Location = New System.Drawing.Point(81, 109)
        Me.CmbUsuarios.Name = "CmbUsuarios"
        Me.CmbUsuarios.Size = New System.Drawing.Size(176, 21)
        Me.CmbUsuarios.TabIndex = 9
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(6, 12)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 35)
        Me.BtnAceptar.TabIndex = 12
        Me.BtnAceptar.Text = "Guardar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'CmbAgente
        '
        Me.CmbAgente.FormattingEnabled = True
        Me.CmbAgente.Location = New System.Drawing.Point(81, 245)
        Me.CmbAgente.Name = "CmbAgente"
        Me.CmbAgente.Size = New System.Drawing.Size(265, 21)
        Me.CmbAgente.TabIndex = 14
        '
        'LblAgente
        '
        Me.LblAgente.AutoSize = True
        Me.LblAgente.Location = New System.Drawing.Point(7, 248)
        Me.LblAgente.Name = "LblAgente"
        Me.LblAgente.Size = New System.Drawing.Size(41, 13)
        Me.LblAgente.TabIndex = 13
        Me.LblAgente.Text = "Agente"
        '
        'TabPermisos
        '
        Me.TabPermisos.Controls.Add(Me.TabPermiso)
        Me.TabPermisos.Controls.Add(Me.TabReportes)
        Me.TabPermisos.Location = New System.Drawing.Point(6, 288)
        Me.TabPermisos.Name = "TabPermisos"
        Me.TabPermisos.SelectedIndex = 0
        Me.TabPermisos.Size = New System.Drawing.Size(348, 148)
        Me.TabPermisos.TabIndex = 15
        '
        'TabPermiso
        '
        Me.TabPermiso.Controls.Add(Me.ChkTallerPlus)
        Me.TabPermiso.Controls.Add(Me.ChkTraspasosPlus)
        Me.TabPermiso.Controls.Add(Me.ChkCxcPlus)
        Me.TabPermiso.Controls.Add(Me.ChkMostrador)
        Me.TabPermiso.Controls.Add(Me.ChkTaller)
        Me.TabPermiso.Controls.Add(Me.ChkTraspasos)
        Me.TabPermiso.Controls.Add(Me.ChkAlmacen)
        Me.TabPermiso.Controls.Add(Me.ChkCxc)
        Me.TabPermiso.Controls.Add(Me.ChkVtas)
        Me.TabPermiso.Controls.Add(Me.ChkAdmin)
        Me.TabPermiso.Location = New System.Drawing.Point(4, 22)
        Me.TabPermiso.Name = "TabPermiso"
        Me.TabPermiso.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPermiso.Size = New System.Drawing.Size(340, 122)
        Me.TabPermiso.TabIndex = 0
        Me.TabPermiso.Text = "Permiso"
        Me.TabPermiso.UseVisualStyleBackColor = True
        '
        'ChkTallerPlus
        '
        Me.ChkTallerPlus.AutoSize = True
        Me.ChkTallerPlus.Location = New System.Drawing.Point(235, 53)
        Me.ChkTallerPlus.Name = "ChkTallerPlus"
        Me.ChkTallerPlus.Size = New System.Drawing.Size(54, 17)
        Me.ChkTallerPlus.TabIndex = 9
        Me.ChkTallerPlus.Text = "taller+"
        Me.ChkTallerPlus.UseVisualStyleBackColor = True
        '
        'ChkTraspasosPlus
        '
        Me.ChkTraspasosPlus.AutoSize = True
        Me.ChkTraspasosPlus.Location = New System.Drawing.Point(235, 30)
        Me.ChkTraspasosPlus.Name = "ChkTraspasosPlus"
        Me.ChkTraspasosPlus.Size = New System.Drawing.Size(77, 17)
        Me.ChkTraspasosPlus.TabIndex = 8
        Me.ChkTraspasosPlus.Text = "traspasos+"
        Me.ChkTraspasosPlus.UseVisualStyleBackColor = True
        '
        'ChkCxcPlus
        '
        Me.ChkCxcPlus.AutoSize = True
        Me.ChkCxcPlus.Location = New System.Drawing.Point(235, 7)
        Me.ChkCxcPlus.Name = "ChkCxcPlus"
        Me.ChkCxcPlus.Size = New System.Drawing.Size(49, 17)
        Me.ChkCxcPlus.TabIndex = 7
        Me.ChkCxcPlus.Text = "cxc+"
        Me.ChkCxcPlus.UseVisualStyleBackColor = True
        '
        'ChkMostrador
        '
        Me.ChkMostrador.AutoSize = True
        Me.ChkMostrador.Location = New System.Drawing.Point(93, 30)
        Me.ChkMostrador.Name = "ChkMostrador"
        Me.ChkMostrador.Size = New System.Drawing.Size(72, 17)
        Me.ChkMostrador.TabIndex = 6
        Me.ChkMostrador.Text = "mostrador"
        Me.ChkMostrador.UseVisualStyleBackColor = True
        '
        'ChkTaller
        '
        Me.ChkTaller.AutoSize = True
        Me.ChkTaller.Location = New System.Drawing.Point(93, 7)
        Me.ChkTaller.Name = "ChkTaller"
        Me.ChkTaller.Size = New System.Drawing.Size(48, 17)
        Me.ChkTaller.TabIndex = 5
        Me.ChkTaller.Text = "taller"
        Me.ChkTaller.UseVisualStyleBackColor = True
        '
        'ChkTraspasos
        '
        Me.ChkTraspasos.AutoSize = True
        Me.ChkTraspasos.Location = New System.Drawing.Point(5, 99)
        Me.ChkTraspasos.Name = "ChkTraspasos"
        Me.ChkTraspasos.Size = New System.Drawing.Size(71, 17)
        Me.ChkTraspasos.TabIndex = 4
        Me.ChkTraspasos.Text = "traspasos"
        Me.ChkTraspasos.UseVisualStyleBackColor = True
        '
        'ChkAlmacen
        '
        Me.ChkAlmacen.AutoSize = True
        Me.ChkAlmacen.Location = New System.Drawing.Point(7, 76)
        Me.ChkAlmacen.Name = "ChkAlmacen"
        Me.ChkAlmacen.Size = New System.Drawing.Size(66, 17)
        Me.ChkAlmacen.TabIndex = 3
        Me.ChkAlmacen.Text = "almacen"
        Me.ChkAlmacen.UseVisualStyleBackColor = True
        '
        'ChkCxc
        '
        Me.ChkCxc.AutoSize = True
        Me.ChkCxc.Location = New System.Drawing.Point(7, 53)
        Me.ChkCxc.Name = "ChkCxc"
        Me.ChkCxc.Size = New System.Drawing.Size(43, 17)
        Me.ChkCxc.TabIndex = 2
        Me.ChkCxc.Text = "cxc"
        Me.ChkCxc.UseVisualStyleBackColor = True
        '
        'ChkVtas
        '
        Me.ChkVtas.AutoSize = True
        Me.ChkVtas.Location = New System.Drawing.Point(7, 30)
        Me.ChkVtas.Name = "ChkVtas"
        Me.ChkVtas.Size = New System.Drawing.Size(46, 17)
        Me.ChkVtas.TabIndex = 1
        Me.ChkVtas.Text = "vtas"
        Me.ChkVtas.UseVisualStyleBackColor = True
        '
        'ChkAdmin
        '
        Me.ChkAdmin.AutoSize = True
        Me.ChkAdmin.Location = New System.Drawing.Point(7, 7)
        Me.ChkAdmin.Name = "ChkAdmin"
        Me.ChkAdmin.Size = New System.Drawing.Size(54, 17)
        Me.ChkAdmin.TabIndex = 0
        Me.ChkAdmin.Text = "admin"
        Me.ChkAdmin.UseVisualStyleBackColor = True
        '
        'TabReportes
        '
        Me.TabReportes.Controls.Add(Me.ChkRepVtasPlus)
        Me.TabReportes.Location = New System.Drawing.Point(4, 22)
        Me.TabReportes.Name = "TabReportes"
        Me.TabReportes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReportes.Size = New System.Drawing.Size(340, 122)
        Me.TabReportes.TabIndex = 1
        Me.TabReportes.Text = "Reportes"
        Me.TabReportes.UseVisualStyleBackColor = True
        '
        'ChkRepVtasPlus
        '
        Me.ChkRepVtasPlus.AutoCheck = False
        Me.ChkRepVtasPlus.AutoSize = True
        Me.ChkRepVtasPlus.Location = New System.Drawing.Point(6, 6)
        Me.ChkRepVtasPlus.Name = "ChkRepVtasPlus"
        Me.ChkRepVtasPlus.Size = New System.Drawing.Size(92, 17)
        Me.ChkRepVtasPlus.TabIndex = 1
        Me.ChkRepVtasPlus.Text = "Ventas Global"
        Me.ChkRepVtasPlus.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(87, 12)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 35)
        Me.BtnLimpiar.TabIndex = 16
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(81, 204)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(265, 20)
        Me.TxtEmail.TabIndex = 18
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(7, 207)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(32, 13)
        Me.LblEmail.TabIndex = 17
        Me.LblEmail.Text = "Email"
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 448)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.TabPermisos)
        Me.Controls.Add(Me.CmbAgente)
        Me.Controls.Add(Me.LblAgente)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.CmbUsuarios)
        Me.Controls.Add(Me.CmbAccion)
        Me.Controls.Add(Me.CmbSucursal)
        Me.Controls.Add(Me.LblUsuarios)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblSucursal)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblUsuario)
        Me.Name = "FrmUsuarios"
        Me.Text = "Usuarios"
        Me.TabPermisos.ResumeLayout(False)
        Me.TabPermiso.ResumeLayout(False)
        Me.TabPermiso.PerformLayout()
        Me.TabReportes.ResumeLayout(False)
        Me.TabReportes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsuario As Windows.Forms.Label
    Friend WithEvents TxtUsuario As Windows.Forms.TextBox
    Friend WithEvents TxtPassword As Windows.Forms.TextBox
    Friend WithEvents LblPass As Windows.Forms.Label
    Friend WithEvents LblSucursal As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents LblUsuarios As Windows.Forms.Label
    Friend WithEvents CmbSucursal As Windows.Forms.ComboBox
    Friend WithEvents CmbAccion As Windows.Forms.ComboBox
    Friend WithEvents CmbUsuarios As Windows.Forms.ComboBox
    Friend WithEvents BtnAceptar As Windows.Forms.Button
    Friend WithEvents CmbAgente As Windows.Forms.ComboBox
    Friend WithEvents LblAgente As Windows.Forms.Label
    Friend WithEvents TabPermisos As Windows.Forms.TabControl
    Friend WithEvents TabPermiso As Windows.Forms.TabPage
    Friend WithEvents ChkTallerPlus As Windows.Forms.CheckBox
    Friend WithEvents ChkTraspasosPlus As Windows.Forms.CheckBox
    Friend WithEvents ChkCxcPlus As Windows.Forms.CheckBox
    Friend WithEvents ChkMostrador As Windows.Forms.CheckBox
    Friend WithEvents ChkTaller As Windows.Forms.CheckBox
    Friend WithEvents ChkTraspasos As Windows.Forms.CheckBox
    Friend WithEvents ChkAlmacen As Windows.Forms.CheckBox
    Friend WithEvents ChkCxc As Windows.Forms.CheckBox
    Friend WithEvents ChkVtas As Windows.Forms.CheckBox
    Friend WithEvents ChkAdmin As Windows.Forms.CheckBox
    Friend WithEvents TabReportes As Windows.Forms.TabPage
    Friend WithEvents ChkRepVtasPlus As Windows.Forms.CheckBox
    Friend WithEvents BtnLimpiar As Windows.Forms.Button
    Friend WithEvents TxtEmail As Windows.Forms.TextBox
    Friend WithEvents LblEmail As Windows.Forms.Label
End Class
