<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GlobalPrenomina
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_año = New System.Windows.Forms.Label()
        Me.Lbl_Semana = New System.Windows.Forms.Label()
        Me.CmbSemanas = New System.Windows.Forms.ComboBox()
        Me.Dtp_FechaInicioSemana = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Mostrar = New System.Windows.Forms.Button()
        Me.Dgv_Prenomina_Global = New System.Windows.Forms.DataGridView()
        Me.lbl_Dia7 = New System.Windows.Forms.Label()
        Me.lbl_Dia6 = New System.Windows.Forms.Label()
        Me.Lbl_Dia5 = New System.Windows.Forms.Label()
        Me.Lbl_Dia4 = New System.Windows.Forms.Label()
        Me.Lbl_Dia3 = New System.Windows.Forms.Label()
        Me.Lbl_Dia2 = New System.Windows.Forms.Label()
        Me.Lbl_Dia1 = New System.Windows.Forms.Label()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.te = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.com = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spBono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departamentoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.turnoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTurnoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv_Prenomina_Global, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Lbl_año)
        Me.Panel1.Controls.Add(Me.Lbl_Semana)
        Me.Panel1.Controls.Add(Me.CmbSemanas)
        Me.Panel1.Controls.Add(Me.Dtp_FechaInicioSemana)
        Me.Panel1.Controls.Add(Me.Btn_Mostrar)
        Me.Panel1.Location = New System.Drawing.Point(-26, -29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1326, 86)
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(176, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 26)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Fecha inicio semana" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lbl_año
        '
        Me.Lbl_año.AutoSize = True
        Me.Lbl_año.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_año.ForeColor = System.Drawing.Color.White
        Me.Lbl_año.Location = New System.Drawing.Point(134, 51)
        Me.Lbl_año.Name = "Lbl_año"
        Me.Lbl_año.Size = New System.Drawing.Size(25, 13)
        Me.Lbl_año.TabIndex = 18
        Me.Lbl_año.Text = "año"
        '
        'Lbl_Semana
        '
        Me.Lbl_Semana.AutoSize = True
        Me.Lbl_Semana.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_Semana.ForeColor = System.Drawing.Color.White
        Me.Lbl_Semana.Location = New System.Drawing.Point(41, 34)
        Me.Lbl_Semana.Name = "Lbl_Semana"
        Me.Lbl_Semana.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_Semana.TabIndex = 17
        Me.Lbl_Semana.Text = "Semana"
        '
        'CmbSemanas
        '
        Me.CmbSemanas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSemanas.Enabled = False
        Me.CmbSemanas.FormattingEnabled = True
        Me.CmbSemanas.Location = New System.Drawing.Point(40, 50)
        Me.CmbSemanas.Name = "CmbSemanas"
        Me.CmbSemanas.Size = New System.Drawing.Size(87, 21)
        Me.CmbSemanas.TabIndex = 16
        '
        'Dtp_FechaInicioSemana
        '
        Me.Dtp_FechaInicioSemana.Checked = False
        Me.Dtp_FechaInicioSemana.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaInicioSemana.Location = New System.Drawing.Point(248, 47)
        Me.Dtp_FechaInicioSemana.Name = "Dtp_FechaInicioSemana"
        Me.Dtp_FechaInicioSemana.Size = New System.Drawing.Size(109, 20)
        Me.Dtp_FechaInicioSemana.TabIndex = 20
        '
        'Btn_Mostrar
        '
        Me.Btn_Mostrar.Image = Global.Presentacion.My.Resources.Resources.iconfinder_115_List_183241__2_
        Me.Btn_Mostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Mostrar.Location = New System.Drawing.Point(373, 37)
        Me.Btn_Mostrar.Name = "Btn_Mostrar"
        Me.Btn_Mostrar.Size = New System.Drawing.Size(50, 39)
        Me.Btn_Mostrar.TabIndex = 21
        Me.Btn_Mostrar.Text = "Mostrar"
        Me.Btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Dgv_Prenomina_Global
        '
        Me.Dgv_Prenomina_Global.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Prenomina_Global.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.nombreEmpleado, Me.lun, Me.te1, Me.cm1, Me.mar, Me.te2, Me.cm2, Me.mie, Me.te3, Me.cm3, Me.jue, Me.te4, Me.cm4, Me.vie, Me.te5, Me.cm5, Me.sab, Me.te6, Me.cm6, Me.dom, Me.te7, Me.cm7, Me.te, Me.com, Me.cm, Me.sp, Me.spBono, Me.departamentoEmpleado, Me.turnoEmpleado, Me.idTurnoEmpleado})
        Me.Dgv_Prenomina_Global.Enabled = False
        Me.Dgv_Prenomina_Global.GridColor = System.Drawing.Color.SteelBlue
        Me.Dgv_Prenomina_Global.Location = New System.Drawing.Point(4, 84)
        Me.Dgv_Prenomina_Global.Name = "Dgv_Prenomina_Global"
        Me.Dgv_Prenomina_Global.RowHeadersVisible = False
        Me.Dgv_Prenomina_Global.Size = New System.Drawing.Size(1245, 483)
        Me.Dgv_Prenomina_Global.TabIndex = 0
        '
        'lbl_Dia7
        '
        Me.lbl_Dia7.AutoSize = True
        Me.lbl_Dia7.Location = New System.Drawing.Point(912, 68)
        Me.lbl_Dia7.Name = "lbl_Dia7"
        Me.lbl_Dia7.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Dia7.TabIndex = 23
        '
        'lbl_Dia6
        '
        Me.lbl_Dia6.AutoSize = True
        Me.lbl_Dia6.Location = New System.Drawing.Point(806, 68)
        Me.lbl_Dia6.Name = "lbl_Dia6"
        Me.lbl_Dia6.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Dia6.TabIndex = 22
        '
        'Lbl_Dia5
        '
        Me.Lbl_Dia5.AutoSize = True
        Me.Lbl_Dia5.Location = New System.Drawing.Point(703, 68)
        Me.Lbl_Dia5.Name = "Lbl_Dia5"
        Me.Lbl_Dia5.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia5.TabIndex = 21
        '
        'Lbl_Dia4
        '
        Me.Lbl_Dia4.AutoSize = True
        Me.Lbl_Dia4.Location = New System.Drawing.Point(597, 68)
        Me.Lbl_Dia4.Name = "Lbl_Dia4"
        Me.Lbl_Dia4.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia4.TabIndex = 20
        '
        'Lbl_Dia3
        '
        Me.Lbl_Dia3.AutoSize = True
        Me.Lbl_Dia3.Location = New System.Drawing.Point(492, 68)
        Me.Lbl_Dia3.Name = "Lbl_Dia3"
        Me.Lbl_Dia3.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia3.TabIndex = 19
        '
        'Lbl_Dia2
        '
        Me.Lbl_Dia2.AutoSize = True
        Me.Lbl_Dia2.Location = New System.Drawing.Point(387, 68)
        Me.Lbl_Dia2.Name = "Lbl_Dia2"
        Me.Lbl_Dia2.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia2.TabIndex = 18
        '
        'Lbl_Dia1
        '
        Me.Lbl_Dia1.AutoSize = True
        Me.Lbl_Dia1.Location = New System.Drawing.Point(280, 68)
        Me.Lbl_Dia1.Name = "Lbl_Dia1"
        Me.Lbl_Dia1.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia1.TabIndex = 17
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "Id"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        Me.idEmpleado.Width = 40
        '
        'nombreEmpleado
        '
        Me.nombreEmpleado.HeaderText = "Nombre"
        Me.nombreEmpleado.Name = "nombreEmpleado"
        Me.nombreEmpleado.ReadOnly = True
        Me.nombreEmpleado.Width = 200
        '
        'lun
        '
        Me.lun.HeaderText = "Lun"
        Me.lun.Name = "lun"
        Me.lun.ReadOnly = True
        Me.lun.Width = 35
        '
        'te1
        '
        Me.te1.HeaderText = "TE1"
        Me.te1.Name = "te1"
        Me.te1.ReadOnly = True
        Me.te1.Width = 35
        '
        'cm1
        '
        Me.cm1.HeaderText = "CM1"
        Me.cm1.Name = "cm1"
        Me.cm1.ReadOnly = True
        Me.cm1.Width = 35
        '
        'mar
        '
        Me.mar.HeaderText = "Mar"
        Me.mar.Name = "mar"
        Me.mar.ReadOnly = True
        Me.mar.Width = 35
        '
        'te2
        '
        Me.te2.HeaderText = "TE2"
        Me.te2.Name = "te2"
        Me.te2.ReadOnly = True
        Me.te2.Width = 35
        '
        'cm2
        '
        Me.cm2.HeaderText = "CM2"
        Me.cm2.Name = "cm2"
        Me.cm2.ReadOnly = True
        Me.cm2.Width = 35
        '
        'mie
        '
        Me.mie.HeaderText = "Mie"
        Me.mie.Name = "mie"
        Me.mie.ReadOnly = True
        Me.mie.Width = 35
        '
        'te3
        '
        Me.te3.HeaderText = "TE3"
        Me.te3.Name = "te3"
        Me.te3.ReadOnly = True
        Me.te3.Width = 35
        '
        'cm3
        '
        Me.cm3.HeaderText = "CM3"
        Me.cm3.Name = "cm3"
        Me.cm3.ReadOnly = True
        Me.cm3.Width = 35
        '
        'jue
        '
        Me.jue.HeaderText = "Jue"
        Me.jue.Name = "jue"
        Me.jue.ReadOnly = True
        Me.jue.Width = 35
        '
        'te4
        '
        Me.te4.HeaderText = "TE4"
        Me.te4.Name = "te4"
        Me.te4.ReadOnly = True
        Me.te4.Width = 35
        '
        'cm4
        '
        Me.cm4.HeaderText = "CM4"
        Me.cm4.Name = "cm4"
        Me.cm4.ReadOnly = True
        Me.cm4.Width = 35
        '
        'vie
        '
        Me.vie.HeaderText = "Vie"
        Me.vie.Name = "vie"
        Me.vie.ReadOnly = True
        Me.vie.Width = 35
        '
        'te5
        '
        Me.te5.HeaderText = "TE5"
        Me.te5.Name = "te5"
        Me.te5.ReadOnly = True
        Me.te5.Width = 35
        '
        'cm5
        '
        Me.cm5.HeaderText = "CM5"
        Me.cm5.Name = "cm5"
        Me.cm5.ReadOnly = True
        Me.cm5.Width = 35
        '
        'sab
        '
        Me.sab.HeaderText = "Sab"
        Me.sab.Name = "sab"
        Me.sab.ReadOnly = True
        Me.sab.Width = 35
        '
        'te6
        '
        Me.te6.HeaderText = "TE6"
        Me.te6.Name = "te6"
        Me.te6.ReadOnly = True
        Me.te6.Width = 35
        '
        'cm6
        '
        Me.cm6.HeaderText = "CM6"
        Me.cm6.Name = "cm6"
        Me.cm6.ReadOnly = True
        Me.cm6.Width = 35
        '
        'dom
        '
        Me.dom.HeaderText = "Dom"
        Me.dom.Name = "dom"
        Me.dom.ReadOnly = True
        Me.dom.Width = 35
        '
        'te7
        '
        Me.te7.HeaderText = "TE7"
        Me.te7.Name = "te7"
        Me.te7.ReadOnly = True
        Me.te7.Width = 35
        '
        'cm7
        '
        Me.cm7.HeaderText = "CM7"
        Me.cm7.Name = "cm7"
        Me.cm7.ReadOnly = True
        Me.cm7.Width = 35
        '
        'te
        '
        Me.te.HeaderText = "TE"
        Me.te.Name = "te"
        Me.te.ReadOnly = True
        Me.te.Width = 40
        '
        'com
        '
        Me.com.HeaderText = "COM"
        Me.com.Name = "com"
        Me.com.ReadOnly = True
        Me.com.Width = 40
        '
        'cm
        '
        Me.cm.HeaderText = "CM"
        Me.cm.Name = "cm"
        Me.cm.ReadOnly = True
        Me.cm.Width = 40
        '
        'sp
        '
        Me.sp.HeaderText = "$"
        Me.sp.Name = "sp"
        Me.sp.ReadOnly = True
        Me.sp.Width = 40
        '
        'spBono
        '
        Me.spBono.HeaderText = "$ Bono"
        Me.spBono.Name = "spBono"
        Me.spBono.ReadOnly = True
        Me.spBono.Width = 40
        '
        'departamentoEmpleado
        '
        Me.departamentoEmpleado.HeaderText = "Departamento"
        Me.departamentoEmpleado.Name = "departamentoEmpleado"
        Me.departamentoEmpleado.ReadOnly = True
        '
        'turnoEmpleado
        '
        Me.turnoEmpleado.HeaderText = "Turno"
        Me.turnoEmpleado.Name = "turnoEmpleado"
        Me.turnoEmpleado.ReadOnly = True
        '
        'idTurnoEmpleado
        '
        Me.idTurnoEmpleado.HeaderText = "IdTurno"
        Me.idTurnoEmpleado.Name = "idTurnoEmpleado"
        Me.idTurnoEmpleado.ReadOnly = True
        Me.idTurnoEmpleado.Width = 40
        '
        'Frm_GlobalPrenomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 572)
        Me.Controls.Add(Me.lbl_Dia7)
        Me.Controls.Add(Me.lbl_Dia6)
        Me.Controls.Add(Me.Lbl_Dia5)
        Me.Controls.Add(Me.Lbl_Dia4)
        Me.Controls.Add(Me.Lbl_Dia3)
        Me.Controls.Add(Me.Lbl_Dia2)
        Me.Controls.Add(Me.Lbl_Dia1)
        Me.Controls.Add(Me.Dgv_Prenomina_Global)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_GlobalPrenomina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Global Prenomina"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv_Prenomina_Global, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dgv_Prenomina_Global As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_año As Label
    Friend WithEvents Lbl_Semana As Label
    Friend WithEvents CmbSemanas As ComboBox
    Friend WithEvents Dtp_FechaInicioSemana As DateTimePicker
    Friend WithEvents Btn_Mostrar As Button
    Friend WithEvents lbl_Dia7 As Label
    Friend WithEvents lbl_Dia6 As Label
    Friend WithEvents Lbl_Dia5 As Label
    Friend WithEvents Lbl_Dia4 As Label
    Friend WithEvents Lbl_Dia3 As Label
    Friend WithEvents Lbl_Dia2 As Label
    Friend WithEvents Lbl_Dia1 As Label
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents lun As DataGridViewTextBoxColumn
    Friend WithEvents te1 As DataGridViewTextBoxColumn
    Friend WithEvents cm1 As DataGridViewTextBoxColumn
    Friend WithEvents mar As DataGridViewTextBoxColumn
    Friend WithEvents te2 As DataGridViewTextBoxColumn
    Friend WithEvents cm2 As DataGridViewTextBoxColumn
    Friend WithEvents mie As DataGridViewTextBoxColumn
    Friend WithEvents te3 As DataGridViewTextBoxColumn
    Friend WithEvents cm3 As DataGridViewTextBoxColumn
    Friend WithEvents jue As DataGridViewTextBoxColumn
    Friend WithEvents te4 As DataGridViewTextBoxColumn
    Friend WithEvents cm4 As DataGridViewTextBoxColumn
    Friend WithEvents vie As DataGridViewTextBoxColumn
    Friend WithEvents te5 As DataGridViewTextBoxColumn
    Friend WithEvents cm5 As DataGridViewTextBoxColumn
    Friend WithEvents sab As DataGridViewTextBoxColumn
    Friend WithEvents te6 As DataGridViewTextBoxColumn
    Friend WithEvents cm6 As DataGridViewTextBoxColumn
    Friend WithEvents dom As DataGridViewTextBoxColumn
    Friend WithEvents te7 As DataGridViewTextBoxColumn
    Friend WithEvents cm7 As DataGridViewTextBoxColumn
    Friend WithEvents te As DataGridViewTextBoxColumn
    Friend WithEvents com As DataGridViewTextBoxColumn
    Friend WithEvents cm As DataGridViewTextBoxColumn
    Friend WithEvents sp As DataGridViewTextBoxColumn
    Friend WithEvents spBono As DataGridViewTextBoxColumn
    Friend WithEvents departamentoEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents turnoEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents idTurnoEmpleado As DataGridViewTextBoxColumn
End Class
