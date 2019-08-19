<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cargaplanpersonal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cargaplanpersonal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_tra = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_cor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.txt_operador = New System.Windows.Forms.TextBox()
        Me.lbl_operador = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_lad = New System.Windows.Forms.TextBox()
        Me.txt_supervisor = New System.Windows.Forms.TextBox()
        Me.txt_lid = New System.Windows.Forms.TextBox()
        Me.txt_asistente = New System.Windows.Forms.TextBox()
        Me.txt_staff = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_gerente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbx_año = New System.Windows.Forms.ComboBox()
        Me.cbx_mes = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbx_depto = New System.Windows.Forms.ComboBox()
        Me.l3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.l3)
        Me.Panel1.Controls.Add(Me.txt_tra)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txt_cor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_modificar)
        Me.Panel1.Controls.Add(Me.txt_operador)
        Me.Panel1.Controls.Add(Me.lbl_operador)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_lad)
        Me.Panel1.Controls.Add(Me.txt_supervisor)
        Me.Panel1.Controls.Add(Me.txt_lid)
        Me.Panel1.Controls.Add(Me.txt_asistente)
        Me.Panel1.Controls.Add(Me.txt_staff)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_gerente)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Enabled = False
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Location = New System.Drawing.Point(7, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 246)
        Me.Panel1.TabIndex = 457
        '
        'txt_tra
        '
        Me.txt_tra.BackColor = System.Drawing.Color.White
        Me.txt_tra.ForeColor = System.Drawing.Color.Black
        Me.txt_tra.Location = New System.Drawing.Point(395, 28)
        Me.txt_tra.Name = "txt_tra"
        Me.txt_tra.Size = New System.Drawing.Size(91, 20)
        Me.txt_tra.TabIndex = 416
        Me.txt_tra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(413, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 415
        Me.Label11.Text = "Traductor"
        '
        'txt_cor
        '
        Me.txt_cor.BackColor = System.Drawing.Color.White
        Me.txt_cor.ForeColor = System.Drawing.Color.Black
        Me.txt_cor.Location = New System.Drawing.Point(214, 28)
        Me.txt_cor.Name = "txt_cor"
        Me.txt_cor.Size = New System.Drawing.Size(91, 20)
        Me.txt_cor.TabIndex = 414
        Me.txt_cor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(227, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 413
        Me.Label1.Text = "Coordinador"
        '
        'btn_modificar
        '
        Me.btn_modificar.ForeColor = System.Drawing.Color.Black
        Me.btn_modificar.Location = New System.Drawing.Point(188, 201)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(133, 35)
        Me.btn_modificar.TabIndex = 412
        Me.btn_modificar.Text = "Guardar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'txt_operador
        '
        Me.txt_operador.BackColor = System.Drawing.Color.White
        Me.txt_operador.ForeColor = System.Drawing.Color.Black
        Me.txt_operador.Location = New System.Drawing.Point(394, 157)
        Me.txt_operador.Name = "txt_operador"
        Me.txt_operador.Size = New System.Drawing.Size(91, 20)
        Me.txt_operador.TabIndex = 243
        Me.txt_operador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_operador
        '
        Me.lbl_operador.AutoSize = True
        Me.lbl_operador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_operador.ForeColor = System.Drawing.Color.Black
        Me.lbl_operador.Location = New System.Drawing.Point(413, 139)
        Me.lbl_operador.Name = "lbl_operador"
        Me.lbl_operador.Size = New System.Drawing.Size(51, 13)
        Me.lbl_operador.TabIndex = 242
        Me.lbl_operador.Text = "Operador"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(406, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 241
        Me.Label7.Text = "Líder Admin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(227, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 240
        Me.Label6.Text = "Supervisor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 239
        Me.Label5.Text = "Asistente de Gerente"
        '
        'txt_lad
        '
        Me.txt_lad.BackColor = System.Drawing.Color.White
        Me.txt_lad.ForeColor = System.Drawing.Color.Black
        Me.txt_lad.Location = New System.Drawing.Point(394, 87)
        Me.txt_lad.Name = "txt_lad"
        Me.txt_lad.Size = New System.Drawing.Size(91, 20)
        Me.txt_lad.TabIndex = 237
        Me.txt_lad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_supervisor
        '
        Me.txt_supervisor.BackColor = System.Drawing.Color.White
        Me.txt_supervisor.ForeColor = System.Drawing.Color.Black
        Me.txt_supervisor.Location = New System.Drawing.Point(211, 87)
        Me.txt_supervisor.Name = "txt_supervisor"
        Me.txt_supervisor.Size = New System.Drawing.Size(91, 20)
        Me.txt_supervisor.TabIndex = 235
        Me.txt_supervisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_lid
        '
        Me.txt_lid.BackColor = System.Drawing.Color.White
        Me.txt_lid.ForeColor = System.Drawing.Color.Black
        Me.txt_lid.Location = New System.Drawing.Point(211, 157)
        Me.txt_lid.Name = "txt_lid"
        Me.txt_lid.Size = New System.Drawing.Size(91, 20)
        Me.txt_lid.TabIndex = 234
        Me.txt_lid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_asistente
        '
        Me.txt_asistente.BackColor = System.Drawing.Color.White
        Me.txt_asistente.ForeColor = System.Drawing.Color.Black
        Me.txt_asistente.Location = New System.Drawing.Point(14, 87)
        Me.txt_asistente.Name = "txt_asistente"
        Me.txt_asistente.Size = New System.Drawing.Size(91, 20)
        Me.txt_asistente.TabIndex = 233
        Me.txt_asistente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_staff
        '
        Me.txt_staff.BackColor = System.Drawing.Color.White
        Me.txt_staff.ForeColor = System.Drawing.Color.Black
        Me.txt_staff.Location = New System.Drawing.Point(14, 157)
        Me.txt_staff.Name = "txt_staff"
        Me.txt_staff.Size = New System.Drawing.Size(91, 20)
        Me.txt_staff.TabIndex = 232
        Me.txt_staff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(238, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 231
        Me.Label4.Text = "Líder"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 230
        Me.Label3.Text = "Staff"
        '
        'txt_gerente
        '
        Me.txt_gerente.BackColor = System.Drawing.Color.White
        Me.txt_gerente.ForeColor = System.Drawing.Color.Black
        Me.txt_gerente.Location = New System.Drawing.Point(16, 28)
        Me.txt_gerente.Name = "txt_gerente"
        Me.txt_gerente.Size = New System.Drawing.Size(91, 20)
        Me.txt_gerente.TabIndex = 229
        Me.txt_gerente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(40, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 228
        Me.Label2.Text = "Gerente"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cbx_año)
        Me.GroupBox1.Controls.Add(Me.cbx_mes)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbx_depto)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 114)
        Me.GroupBox1.TabIndex = 458
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(389, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 20)
        Me.Label10.TabIndex = 411
        Me.Label10.Text = "Mes"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(343, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 35)
        Me.Button1.TabIndex = 454
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbx_año
        '
        Me.cbx_año.BackColor = System.Drawing.Color.White
        Me.cbx_año.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_año.FormattingEnabled = True
        Me.cbx_año.Location = New System.Drawing.Point(81, 84)
        Me.cbx_año.Name = "cbx_año"
        Me.cbx_año.Size = New System.Drawing.Size(59, 21)
        Me.cbx_año.TabIndex = 451
        Me.cbx_año.Text = "2018"
        '
        'cbx_mes
        '
        Me.cbx_mes.BackColor = System.Drawing.Color.White
        Me.cbx_mes.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbx_mes.FormattingEnabled = True
        Me.cbx_mes.Items.AddRange(New Object() {"ENERO      1 月", "FEBRERO    2 月", "MARZO      3 月", "ABRIL      4 月", "MAYO       5 月", "JUNIO      6 月", "JULIO      7 月", "AGOSTO     8 月", "SEPTIEMBRE 9 月", "OCTUBRE   10 月", "NOVIEMBRE 11 月", "DICIEMBRE 12 月"})
        Me.cbx_mes.Location = New System.Drawing.Point(334, 35)
        Me.cbx_mes.Name = "cbx_mes"
        Me.cbx_mes.Size = New System.Drawing.Size(148, 21)
        Me.cbx_mes.TabIndex = 449
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(86, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 20)
        Me.Label8.TabIndex = 407
        Me.Label8.Text = "Área"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(88, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 20)
        Me.Label9.TabIndex = 409
        Me.Label9.Text = "Año"
        '
        'cbx_depto
        '
        Me.cbx_depto.BackColor = System.Drawing.Color.White
        Me.cbx_depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_depto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_depto.FormattingEnabled = True
        Me.cbx_depto.Items.AddRange(New Object() {"CONTROL DE CLIENTES", "ASEGURAMIENTO DE CALIDAD", "ASUNTOS GENERALES", "ATENCIÓN AL CLIENTE", "COMPRAS", "CONTABILIDAD", "CONTROL DE MANUFACTURA", "CONTROL DE PRODUCCION", "MOLDES", "PRESIDENCIA", "SEGURIDAD", "SISTEMAS IT", "INGENIERÍA-MAQUINADO", "INGENIERÍA-FUNDICIÓN", "INSPECCION PRODUCCION", "FUNDICION 1", "FUNDICION 2", "ACABADO 1", "ACABADO 2", "CONTROL DE CLIENTES", "MANTENIMIENTO DE PLANTA", "MANTENIMIENTO FUNDICION", "MANTENIMIENTO MAQUINADO", "MAQUINADO F2", "INSPECCIÓN FUNDICION", "INSPECCIÓN MAQUINADO", "MAQUINADO F1", "FUSION F1", "FUSION F2"})
        Me.cbx_depto.Location = New System.Drawing.Point(6, 34)
        Me.cbx_depto.Name = "cbx_depto"
        Me.cbx_depto.Size = New System.Drawing.Size(210, 21)
        Me.cbx_depto.TabIndex = 406
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.l3.ForeColor = System.Drawing.Color.Black
        Me.l3.Location = New System.Drawing.Point(6, 226)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(10, 13)
        Me.l3.TabIndex = 417
        Me.l3.Text = "."
        '
        'Frm_cargaplanpersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 373)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_cargaplanpersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de Plan de Personal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_tra As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_cor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_modificar As Button
    Friend WithEvents txt_operador As TextBox
    Friend WithEvents lbl_operador As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_lad As TextBox
    Friend WithEvents txt_supervisor As TextBox
    Friend WithEvents txt_lid As TextBox
    Friend WithEvents txt_asistente As TextBox
    Friend WithEvents txt_staff As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_gerente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cbx_año As ComboBox
    Friend WithEvents cbx_mes As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbx_depto As ComboBox
    Friend WithEvents l3 As Label
End Class
