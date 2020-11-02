<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormatoSM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormatoSM))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btn_anteriores = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.rbt_nocturno = New System.Windows.Forms.CheckBox()
        Me.Check_entrada = New System.Windows.Forms.RadioButton()
        Me.Check_salida = New System.Windows.Forms.RadioButton()
        Me.gbx_tipo = New System.Windows.Forms.GroupBox()
        Me.rbt_retardo = New System.Windows.Forms.RadioButton()
        Me.rbt_falta = New System.Windows.Forms.RadioButton()
        Me.btn_solicitar = New System.Windows.Forms.Button()
        Me.gb_aviso = New System.Windows.Forms.GroupBox()
        Me.dtp_hora = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtp_cuando = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_quien = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Check_aviso = New System.Windows.Forms.CheckBox()
        Me.dtp_regreso = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtp_checada = New System.Windows.Forms.DateTimePicker()
        Me.lbl_turno = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.hasta_h = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.desde_h = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_motivo = New System.Windows.Forms.ComboBox()
        Me.cbx_tipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_depto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_empleado = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.panel1.SuspendLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_tipo.SuspendLayout()
        Me.gb_aviso.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.Control
        Me.panel1.Controls.Add(Me.btn_anteriores)
        Me.panel1.Controls.Add(Me.Panel3)
        Me.panel1.Controls.Add(Me.dtgvp)
        Me.panel1.Controls.Add(Me.rbt_nocturno)
        Me.panel1.Controls.Add(Me.Check_entrada)
        Me.panel1.Controls.Add(Me.Check_salida)
        Me.panel1.Controls.Add(Me.gbx_tipo)
        Me.panel1.Controls.Add(Me.btn_solicitar)
        Me.panel1.Controls.Add(Me.gb_aviso)
        Me.panel1.Controls.Add(Me.dtp_regreso)
        Me.panel1.Controls.Add(Me.Label10)
        Me.panel1.Controls.Add(Me.dtp_checada)
        Me.panel1.Controls.Add(Me.lbl_turno)
        Me.panel1.Controls.Add(Me.Label11)
        Me.panel1.Controls.Add(Me.hasta_h)
        Me.panel1.Controls.Add(Me.Label8)
        Me.panel1.Controls.Add(Me.desde_h)
        Me.panel1.Controls.Add(Me.Label9)
        Me.panel1.Controls.Add(Me.Panel2)
        Me.panel1.Controls.Add(Me.Label7)
        Me.panel1.Controls.Add(Me.txt_motivo)
        Me.panel1.Controls.Add(Me.dtp2)
        Me.panel1.Controls.Add(Me.Label6)
        Me.panel1.Controls.Add(Me.dtp1)
        Me.panel1.Controls.Add(Me.Label2)
        Me.panel1.Controls.Add(Me.cbx_motivo)
        Me.panel1.Controls.Add(Me.cbx_tipo)
        Me.panel1.Controls.Add(Me.Label5)
        Me.panel1.Controls.Add(Me.Label4)
        Me.panel1.Controls.Add(Me.lbl_depto)
        Me.panel1.Controls.Add(Me.Label3)
        Me.panel1.Controls.Add(Me.lbl_empleado)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Controls.Add(Me.lbl1)
        Me.panel1.Controls.Add(Me.txt_clave)
        Me.panel1.Location = New System.Drawing.Point(1, 1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(903, 521)
        Me.panel1.TabIndex = 145
        '
        'btn_anteriores
        '
        Me.btn_anteriores.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_anteriores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anteriores.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_anteriores.Location = New System.Drawing.Point(771, 445)
        Me.btn_anteriores.Name = "btn_anteriores"
        Me.btn_anteriores.Size = New System.Drawing.Size(120, 35)
        Me.btn_anteriores.TabIndex = 180
        Me.btn_anteriores.Text = "Imprimir"
        Me.btn_anteriores.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(900, 21)
        Me.Panel3.TabIndex = 179
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvp.Location = New System.Drawing.Point(6, 335)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(323, 186)
        Me.dtgvp.TabIndex = 178
        Me.dtgvp.Visible = False
        '
        'rbt_nocturno
        '
        Me.rbt_nocturno.AutoSize = True
        Me.rbt_nocturno.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbt_nocturno.Location = New System.Drawing.Point(809, 202)
        Me.rbt_nocturno.Name = "rbt_nocturno"
        Me.rbt_nocturno.Size = New System.Drawing.Size(82, 17)
        Me.rbt_nocturno.TabIndex = 177
        Me.rbt_nocturno.Text = "¿Nocturno?"
        Me.rbt_nocturno.UseVisualStyleBackColor = True
        Me.rbt_nocturno.Visible = False
        '
        'Check_entrada
        '
        Me.Check_entrada.AutoSize = True
        Me.Check_entrada.Checked = True
        Me.Check_entrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Check_entrada.Location = New System.Drawing.Point(394, 184)
        Me.Check_entrada.Name = "Check_entrada"
        Me.Check_entrada.Size = New System.Drawing.Size(62, 17)
        Me.Check_entrada.TabIndex = 166
        Me.Check_entrada.TabStop = True
        Me.Check_entrada.Text = "Entrada"
        Me.Check_entrada.UseVisualStyleBackColor = True
        Me.Check_entrada.Visible = False
        '
        'Check_salida
        '
        Me.Check_salida.AutoSize = True
        Me.Check_salida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Check_salida.Location = New System.Drawing.Point(394, 207)
        Me.Check_salida.Name = "Check_salida"
        Me.Check_salida.Size = New System.Drawing.Size(54, 17)
        Me.Check_salida.TabIndex = 167
        Me.Check_salida.Text = "Salida"
        Me.Check_salida.UseVisualStyleBackColor = True
        Me.Check_salida.Visible = False
        '
        'gbx_tipo
        '
        Me.gbx_tipo.Controls.Add(Me.rbt_retardo)
        Me.gbx_tipo.Controls.Add(Me.rbt_falta)
        Me.gbx_tipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbx_tipo.Location = New System.Drawing.Point(546, 27)
        Me.gbx_tipo.Name = "gbx_tipo"
        Me.gbx_tipo.Size = New System.Drawing.Size(79, 83)
        Me.gbx_tipo.TabIndex = 176
        Me.gbx_tipo.TabStop = False
        Me.gbx_tipo.Text = "Tipo"
        Me.gbx_tipo.Visible = False
        '
        'rbt_retardo
        '
        Me.rbt_retardo.AutoSize = True
        Me.rbt_retardo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbt_retardo.Location = New System.Drawing.Point(9, 45)
        Me.rbt_retardo.Name = "rbt_retardo"
        Me.rbt_retardo.Size = New System.Drawing.Size(63, 17)
        Me.rbt_retardo.TabIndex = 177
        Me.rbt_retardo.Text = "Retardo"
        Me.rbt_retardo.UseVisualStyleBackColor = True
        '
        'rbt_falta
        '
        Me.rbt_falta.AutoSize = True
        Me.rbt_falta.Checked = True
        Me.rbt_falta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbt_falta.Location = New System.Drawing.Point(9, 22)
        Me.rbt_falta.Name = "rbt_falta"
        Me.rbt_falta.Size = New System.Drawing.Size(48, 17)
        Me.rbt_falta.TabIndex = 176
        Me.rbt_falta.TabStop = True
        Me.rbt_falta.Text = "Falta"
        Me.rbt_falta.UseVisualStyleBackColor = True
        '
        'btn_solicitar
        '
        Me.btn_solicitar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_solicitar.Enabled = False
        Me.btn_solicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_solicitar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_solicitar.Location = New System.Drawing.Point(771, 486)
        Me.btn_solicitar.Name = "btn_solicitar"
        Me.btn_solicitar.Size = New System.Drawing.Size(120, 35)
        Me.btn_solicitar.TabIndex = 173
        Me.btn_solicitar.Text = "Solicitar"
        Me.btn_solicitar.UseVisualStyleBackColor = False
        '
        'gb_aviso
        '
        Me.gb_aviso.Controls.Add(Me.dtp_hora)
        Me.gb_aviso.Controls.Add(Me.Label14)
        Me.gb_aviso.Controls.Add(Me.dtp_cuando)
        Me.gb_aviso.Controls.Add(Me.Label13)
        Me.gb_aviso.Controls.Add(Me.txt_quien)
        Me.gb_aviso.Controls.Add(Me.Label12)
        Me.gb_aviso.Controls.Add(Me.Check_aviso)
        Me.gb_aviso.Location = New System.Drawing.Point(3, 280)
        Me.gb_aviso.Name = "gb_aviso"
        Me.gb_aviso.Size = New System.Drawing.Size(889, 49)
        Me.gb_aviso.TabIndex = 172
        Me.gb_aviso.TabStop = False
        Me.gb_aviso.Visible = False
        '
        'dtp_hora
        '
        Me.dtp_hora.CustomFormat = "HH:mm:ss"
        Me.dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_hora.Location = New System.Drawing.Point(643, 17)
        Me.dtp_hora.Name = "dtp_hora"
        Me.dtp_hora.ShowUpDown = True
        Me.dtp_hora.Size = New System.Drawing.Size(100, 20)
        Me.dtp_hora.TabIndex = 177
        Me.dtp_hora.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(565, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 176
        Me.Label14.Text = "A qué hora:"
        Me.Label14.Visible = False
        '
        'dtp_cuando
        '
        Me.dtp_cuando.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_cuando.Location = New System.Drawing.Point(441, 16)
        Me.dtp_cuando.Name = "dtp_cuando"
        Me.dtp_cuando.Size = New System.Drawing.Size(100, 20)
        Me.dtp_cuando.TabIndex = 175
        Me.dtp_cuando.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(377, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 13)
        Me.Label13.TabIndex = 174
        Me.Label13.Text = "Cuándo:"
        Me.Label13.Visible = False
        '
        'txt_quien
        '
        Me.txt_quien.BackColor = System.Drawing.SystemColors.Control
        Me.txt_quien.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quien.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_quien.Location = New System.Drawing.Point(172, 18)
        Me.txt_quien.MaxLength = 25
        Me.txt_quien.Name = "txt_quien"
        Me.txt_quien.Size = New System.Drawing.Size(187, 18)
        Me.txt_quien.TabIndex = 173
        Me.txt_quien.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(98, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 172
        Me.Label12.Text = "Con quién:"
        Me.Label12.Visible = False
        '
        'Check_aviso
        '
        Me.Check_aviso.AutoSize = True
        Me.Check_aviso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Check_aviso.Location = New System.Drawing.Point(11, 19)
        Me.Check_aviso.Name = "Check_aviso"
        Me.Check_aviso.Size = New System.Drawing.Size(81, 17)
        Me.Check_aviso.TabIndex = 171
        Me.Check_aviso.Text = "Avisó Asahi"
        Me.Check_aviso.UseVisualStyleBackColor = True
        '
        'dtp_regreso
        '
        Me.dtp_regreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_regreso.Location = New System.Drawing.Point(481, 198)
        Me.dtp_regreso.Name = "dtp_regreso"
        Me.dtp_regreso.Size = New System.Drawing.Size(100, 20)
        Me.dtp_regreso.TabIndex = 170
        Me.dtp_regreso.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(401, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 169
        Me.Label10.Text = "Fecha regreso:"
        Me.Label10.Visible = False
        '
        'dtp_checada
        '
        Me.dtp_checada.CustomFormat = "HH:mm:ss"
        Me.dtp_checada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_checada.Location = New System.Drawing.Point(485, 198)
        Me.dtp_checada.Name = "dtp_checada"
        Me.dtp_checada.ShowUpDown = True
        Me.dtp_checada.Size = New System.Drawing.Size(100, 20)
        Me.dtp_checada.TabIndex = 168
        Me.dtp_checada.Visible = False
        '
        'lbl_turno
        '
        Me.lbl_turno.AutoSize = True
        Me.lbl_turno.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_turno.ForeColor = System.Drawing.Color.Black
        Me.lbl_turno.Location = New System.Drawing.Point(635, 161)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(35, 13)
        Me.lbl_turno.TabIndex = 165
        Me.lbl_turno.Text = "Turno"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(634, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 164
        Me.Label11.Text = "Turno:"
        '
        'hasta_h
        '
        Me.hasta_h.CustomFormat = "HH:mm:ss"
        Me.hasta_h.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.hasta_h.Location = New System.Drawing.Point(229, 252)
        Me.hasta_h.Name = "hasta_h"
        Me.hasta_h.ShowUpDown = True
        Me.hasta_h.Size = New System.Drawing.Size(100, 20)
        Me.hasta_h.TabIndex = 163
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(185, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 162
        Me.Label8.Text = "a las:"
        '
        'desde_h
        '
        Me.desde_h.CustomFormat = "HH:mm:ss"
        Me.desde_h.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.desde_h.Location = New System.Drawing.Point(72, 252)
        Me.desde_h.Name = "desde_h"
        Me.desde_h.ShowUpDown = True
        Me.desde_h.Size = New System.Drawing.Size(100, 20)
        Me.desde_h.TabIndex = 161
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Hora de las:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Location = New System.Drawing.Point(0, 233)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(900, 11)
        Me.Panel2.TabIndex = 146
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(30, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Especifique:"
        Me.Label7.Visible = False
        '
        'txt_motivo
        '
        Me.txt_motivo.BackColor = System.Drawing.SystemColors.Control
        Me.txt_motivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_motivo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_motivo.Location = New System.Drawing.Point(101, 123)
        Me.txt_motivo.MaxLength = 60
        Me.txt_motivo.Multiline = True
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(395, 52)
        Me.txt_motivo.TabIndex = 155
        Me.txt_motivo.Visible = False
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(264, 199)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(100, 20)
        Me.dtp2.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(226, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "al:"
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(107, 199)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 152
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(41, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Fecha del:"
        '
        'cbx_motivo
        '
        Me.cbx_motivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbx_motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_motivo.Enabled = False
        Me.cbx_motivo.ForeColor = System.Drawing.SystemColors.Menu
        Me.cbx_motivo.FormattingEnabled = True
        Me.cbx_motivo.Location = New System.Drawing.Point(102, 89)
        Me.cbx_motivo.Name = "cbx_motivo"
        Me.cbx_motivo.Size = New System.Drawing.Size(436, 21)
        Me.cbx_motivo.TabIndex = 150
        '
        'cbx_tipo
        '
        Me.cbx_tipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_tipo.Enabled = False
        Me.cbx_tipo.ForeColor = System.Drawing.SystemColors.Menu
        Me.cbx_tipo.FormattingEnabled = True
        Me.cbx_tipo.Items.AddRange(New Object() {"Permiso con goce de sueldo", "Permiso sin goce de sueldo", "Falta o retardo injustificado y sin goce de sueldo", "Falta o retardo JUSTIFICADO y sin goce de sueldo (No solicitado anticipadamente)", "Vacaciones", "Registro en reloj checador"})
        Me.cbx_tipo.Location = New System.Drawing.Point(101, 57)
        Me.cbx_tipo.Name = "cbx_tipo"
        Me.cbx_tipo.Size = New System.Drawing.Size(437, 21)
        Me.cbx_tipo.TabIndex = 149
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "Motivo de Permiso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Tipo de Permiso:"
        '
        'lbl_depto
        '
        Me.lbl_depto.AutoSize = True
        Me.lbl_depto.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_depto.ForeColor = System.Drawing.Color.Black
        Me.lbl_depto.Location = New System.Drawing.Point(634, 110)
        Me.lbl_depto.Name = "lbl_depto"
        Me.lbl_depto.Size = New System.Drawing.Size(74, 13)
        Me.lbl_depto.TabIndex = 145
        Me.lbl_depto.Text = "Departamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(633, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Departamento:"
        '
        'lbl_empleado
        '
        Me.lbl_empleado.AutoSize = True
        Me.lbl_empleado.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_empleado.ForeColor = System.Drawing.Color.Black
        Me.lbl_empleado.Location = New System.Drawing.Point(632, 59)
        Me.lbl_empleado.Name = "lbl_empleado"
        Me.lbl_empleado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_empleado.TabIndex = 143
        Me.lbl_empleado.Text = "Empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(631, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Permiso Para:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(56, 32)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(34, 13)
        Me.lbl1.TabIndex = 141
        Me.lbl1.Text = "Clave"
        '
        'txt_clave
        '
        Me.txt_clave.BackColor = System.Drawing.SystemColors.Control
        Me.txt_clave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_clave.Location = New System.Drawing.Point(93, 29)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(83, 20)
        Me.txt_clave.TabIndex = 140
        Me.txt_clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormatoSM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 524)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormatoSM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formato de Servicios Multiples"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_tipo.ResumeLayout(False)
        Me.gbx_tipo.PerformLayout()
        Me.gb_aviso.ResumeLayout(False)
        Me.gb_aviso.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_depto As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_empleado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbx_motivo As ComboBox
    Friend WithEvents cbx_tipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_motivo As TextBox
    Private WithEvents Panel2 As Panel
    Friend WithEvents hasta_h As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents desde_h As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_turno As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Check_salida As RadioButton
    Friend WithEvents Check_entrada As RadioButton
    Friend WithEvents dtp_checada As DateTimePicker
    Friend WithEvents dtp_regreso As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents gb_aviso As GroupBox
    Friend WithEvents Check_aviso As CheckBox
    Friend WithEvents dtp_hora As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents dtp_cuando As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_quien As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_solicitar As Button
    Friend WithEvents gbx_tipo As GroupBox
    Friend WithEvents rbt_retardo As RadioButton
    Friend WithEvents rbt_falta As RadioButton
    Friend WithEvents rbt_nocturno As CheckBox
    Friend WithEvents dtgvp As DataGridView
    Private WithEvents Panel3 As Panel
    Friend WithEvents btn_anteriores As Button
End Class
