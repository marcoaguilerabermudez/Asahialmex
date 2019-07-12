<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PlanHorasExtra
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
        Me.Lbl_Depto = New System.Windows.Forms.Label()
        Me.Cmb_Departamento = New System.Windows.Forms.ComboBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Lbl_año = New System.Windows.Forms.Label()
        Me.Lbl_Semana = New System.Windows.Forms.Label()
        Me.Cmb_Semanas = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbl_Dia3 = New System.Windows.Forms.Label()
        Me.Lbl_Dia4 = New System.Windows.Forms.Label()
        Me.lbl_Dia7 = New System.Windows.Forms.Label()
        Me.Lbl_Dia5 = New System.Windows.Forms.Label()
        Me.Lbl_Dia1 = New System.Windows.Forms.Label()
        Me.lbl_Dia6 = New System.Windows.Forms.Label()
        Me.Lbl_Dia2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Dgv_HorasExtra = New System.Windows.Forms.DataGridView()
        Me.clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sueldoBruto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sueldoNeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lunes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.martes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.miercoles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jueves = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.viernes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sabado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domingo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dobles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.triples = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalDobles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalTriples = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalBruto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalNeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Dgv_HorasExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Lbl_Depto)
        Me.Panel1.Controls.Add(Me.Cmb_Departamento)
        Me.Panel1.Controls.Add(Me.Btn_Guardar)
        Me.Panel1.Controls.Add(Me.Lbl_año)
        Me.Panel1.Controls.Add(Me.Lbl_Semana)
        Me.Panel1.Controls.Add(Me.Cmb_Semanas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1224, 59)
        Me.Panel1.TabIndex = 0
        '
        'Lbl_Depto
        '
        Me.Lbl_Depto.AutoSize = True
        Me.Lbl_Depto.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_Depto.ForeColor = System.Drawing.Color.White
        Me.Lbl_Depto.Location = New System.Drawing.Point(133, 7)
        Me.Lbl_Depto.Name = "Lbl_Depto"
        Me.Lbl_Depto.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Depto.TabIndex = 21
        Me.Lbl_Depto.Text = "Departamento"
        '
        'Cmb_Departamento
        '
        Me.Cmb_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Departamento.FormattingEnabled = True
        Me.Cmb_Departamento.Location = New System.Drawing.Point(136, 23)
        Me.Cmb_Departamento.Name = "Cmb_Departamento"
        Me.Cmb_Departamento.Size = New System.Drawing.Size(190, 21)
        Me.Cmb_Departamento.TabIndex = 20
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Image = Global.Presentacion.My.Resources.Resources.save
        Me.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Guardar.Location = New System.Drawing.Point(332, 7)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(56, 45)
        Me.Btn_Guardar.TabIndex = 19
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        Me.Btn_Guardar.Visible = False
        '
        'Lbl_año
        '
        Me.Lbl_año.AutoSize = True
        Me.Lbl_año.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_año.ForeColor = System.Drawing.Color.White
        Me.Lbl_año.Location = New System.Drawing.Point(101, 23)
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
        Me.Lbl_Semana.Location = New System.Drawing.Point(26, 7)
        Me.Lbl_Semana.Name = "Lbl_Semana"
        Me.Lbl_Semana.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_Semana.TabIndex = 17
        Me.Lbl_Semana.Text = "Semana"
        '
        'Cmb_Semanas
        '
        Me.Cmb_Semanas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Semanas.FormattingEnabled = True
        Me.Cmb_Semanas.Location = New System.Drawing.Point(25, 23)
        Me.Cmb_Semanas.Name = "Cmb_Semanas"
        Me.Cmb_Semanas.Size = New System.Drawing.Size(70, 21)
        Me.Cmb_Semanas.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Lbl_Dia3)
        Me.Panel2.Controls.Add(Me.Lbl_Dia4)
        Me.Panel2.Controls.Add(Me.lbl_Dia7)
        Me.Panel2.Controls.Add(Me.Lbl_Dia5)
        Me.Panel2.Controls.Add(Me.Lbl_Dia1)
        Me.Panel2.Controls.Add(Me.lbl_Dia6)
        Me.Panel2.Controls.Add(Me.Lbl_Dia2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1224, 35)
        Me.Panel2.TabIndex = 1
        '
        'Lbl_Dia3
        '
        Me.Lbl_Dia3.AutoSize = True
        Me.Lbl_Dia3.Location = New System.Drawing.Point(555, 11)
        Me.Lbl_Dia3.Name = "Lbl_Dia3"
        Me.Lbl_Dia3.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia3.TabIndex = 13
        '
        'Lbl_Dia4
        '
        Me.Lbl_Dia4.AutoSize = True
        Me.Lbl_Dia4.Location = New System.Drawing.Point(608, 11)
        Me.Lbl_Dia4.Name = "Lbl_Dia4"
        Me.Lbl_Dia4.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia4.TabIndex = 14
        '
        'lbl_Dia7
        '
        Me.lbl_Dia7.AutoSize = True
        Me.lbl_Dia7.Location = New System.Drawing.Point(773, 11)
        Me.lbl_Dia7.Name = "lbl_Dia7"
        Me.lbl_Dia7.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Dia7.TabIndex = 17
        '
        'Lbl_Dia5
        '
        Me.Lbl_Dia5.AutoSize = True
        Me.Lbl_Dia5.Location = New System.Drawing.Point(664, 11)
        Me.Lbl_Dia5.Name = "Lbl_Dia5"
        Me.Lbl_Dia5.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia5.TabIndex = 15
        '
        'Lbl_Dia1
        '
        Me.Lbl_Dia1.AutoSize = True
        Me.Lbl_Dia1.Location = New System.Drawing.Point(445, 11)
        Me.Lbl_Dia1.Name = "Lbl_Dia1"
        Me.Lbl_Dia1.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia1.TabIndex = 11
        '
        'lbl_Dia6
        '
        Me.lbl_Dia6.AutoSize = True
        Me.lbl_Dia6.Location = New System.Drawing.Point(719, 11)
        Me.lbl_Dia6.Name = "lbl_Dia6"
        Me.lbl_Dia6.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Dia6.TabIndex = 16
        '
        'Lbl_Dia2
        '
        Me.Lbl_Dia2.AutoSize = True
        Me.Lbl_Dia2.Location = New System.Drawing.Point(499, 11)
        Me.Lbl_Dia2.Name = "Lbl_Dia2"
        Me.Lbl_Dia2.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Dia2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Dgv_HorasExtra)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 94)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1224, 482)
        Me.Panel3.TabIndex = 2
        '
        'Dgv_HorasExtra
        '
        Me.Dgv_HorasExtra.AllowUserToAddRows = False
        Me.Dgv_HorasExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_HorasExtra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clave, Me.nombre, Me.departamento, Me.idTurno, Me.sueldoBruto, Me.sueldoNeto, Me.lunes, Me.martes, Me.miercoles, Me.jueves, Me.viernes, Me.sabado, Me.domingo, Me.dobles, Me.triples, Me.totalDobles, Me.totalTriples, Me.totalBruto, Me.TotalNeto})
        Me.Dgv_HorasExtra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_HorasExtra.Enabled = False
        Me.Dgv_HorasExtra.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_HorasExtra.Name = "Dgv_HorasExtra"
        Me.Dgv_HorasExtra.RowHeadersVisible = False
        Me.Dgv_HorasExtra.RowHeadersWidth = 25
        Me.Dgv_HorasExtra.Size = New System.Drawing.Size(1224, 482)
        Me.Dgv_HorasExtra.TabIndex = 0
        '
        'clave
        '
        Me.clave.HeaderText = "Clave"
        Me.clave.Name = "clave"
        Me.clave.ReadOnly = True
        Me.clave.Width = 45
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 200
        '
        'departamento
        '
        Me.departamento.HeaderText = "Departamento"
        Me.departamento.Name = "departamento"
        Me.departamento.ReadOnly = True
        Me.departamento.Width = 185
        '
        'idTurno
        '
        Me.idTurno.HeaderText = "IdTurno"
        Me.idTurno.Name = "idTurno"
        Me.idTurno.ReadOnly = True
        Me.idTurno.Visible = False
        '
        'sueldoBruto
        '
        Me.sueldoBruto.HeaderText = "Sueldo Bruto"
        Me.sueldoBruto.Name = "sueldoBruto"
        Me.sueldoBruto.ReadOnly = True
        Me.sueldoBruto.Visible = False
        '
        'sueldoNeto
        '
        Me.sueldoNeto.HeaderText = "Sueldo Neto"
        Me.sueldoNeto.Name = "sueldoNeto"
        Me.sueldoNeto.ReadOnly = True
        Me.sueldoNeto.Visible = False
        '
        'lunes
        '
        Me.lunes.HeaderText = "Lunes"
        Me.lunes.Name = "lunes"
        Me.lunes.Width = 55
        '
        'martes
        '
        Me.martes.HeaderText = "Martes"
        Me.martes.Name = "martes"
        Me.martes.Width = 55
        '
        'miercoles
        '
        Me.miercoles.HeaderText = "Miércoles"
        Me.miercoles.Name = "miercoles"
        Me.miercoles.Width = 55
        '
        'jueves
        '
        Me.jueves.HeaderText = "Jueves"
        Me.jueves.Name = "jueves"
        Me.jueves.Width = 55
        '
        'viernes
        '
        Me.viernes.HeaderText = "Viernes"
        Me.viernes.Name = "viernes"
        Me.viernes.Width = 55
        '
        'sabado
        '
        Me.sabado.HeaderText = "Sábado"
        Me.sabado.Name = "sabado"
        Me.sabado.Width = 55
        '
        'domingo
        '
        Me.domingo.HeaderText = "Domingo"
        Me.domingo.Name = "domingo"
        Me.domingo.Width = 55
        '
        'dobles
        '
        Me.dobles.HeaderText = "Horas Dobles"
        Me.dobles.Name = "dobles"
        Me.dobles.ReadOnly = True
        Me.dobles.Width = 65
        '
        'triples
        '
        Me.triples.HeaderText = "Horas Triples"
        Me.triples.Name = "triples"
        Me.triples.ReadOnly = True
        Me.triples.Width = 65
        '
        'totalDobles
        '
        Me.totalDobles.HeaderText = "Total Dobles"
        Me.totalDobles.Name = "totalDobles"
        Me.totalDobles.ReadOnly = True
        Me.totalDobles.Width = 65
        '
        'totalTriples
        '
        Me.totalTriples.HeaderText = "Total Triples"
        Me.totalTriples.Name = "totalTriples"
        Me.totalTriples.ReadOnly = True
        Me.totalTriples.Width = 65
        '
        'totalBruto
        '
        Me.totalBruto.HeaderText = "Bruto"
        Me.totalBruto.Name = "totalBruto"
        Me.totalBruto.Width = 65
        '
        'TotalNeto
        '
        Me.TotalNeto.HeaderText = "Neto"
        Me.TotalNeto.Name = "TotalNeto"
        Me.TotalNeto.Width = 65
        '
        'Frm_PlanHorasExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 576)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_PlanHorasExtra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_PlanHorasExtra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Dgv_HorasExtra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Dgv_HorasExtra As DataGridView
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Lbl_año As Label
    Friend WithEvents Lbl_Semana As Label
    Friend WithEvents Cmb_Semanas As ComboBox
    Friend WithEvents Lbl_Depto As Label
    Friend WithEvents Cmb_Departamento As ComboBox
    Friend WithEvents Lbl_Dia3 As Label
    Friend WithEvents Lbl_Dia4 As Label
    Friend WithEvents lbl_Dia7 As Label
    Friend WithEvents Lbl_Dia5 As Label
    Friend WithEvents Lbl_Dia1 As Label
    Friend WithEvents lbl_Dia6 As Label
    Friend WithEvents Lbl_Dia2 As Label
    Friend WithEvents clave As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents departamento As DataGridViewTextBoxColumn
    Friend WithEvents idTurno As DataGridViewTextBoxColumn
    Friend WithEvents sueldoBruto As DataGridViewTextBoxColumn
    Friend WithEvents sueldoNeto As DataGridViewTextBoxColumn
    Friend WithEvents lunes As DataGridViewTextBoxColumn
    Friend WithEvents martes As DataGridViewTextBoxColumn
    Friend WithEvents miercoles As DataGridViewTextBoxColumn
    Friend WithEvents jueves As DataGridViewTextBoxColumn
    Friend WithEvents viernes As DataGridViewTextBoxColumn
    Friend WithEvents sabado As DataGridViewTextBoxColumn
    Friend WithEvents domingo As DataGridViewTextBoxColumn
    Friend WithEvents dobles As DataGridViewTextBoxColumn
    Friend WithEvents triples As DataGridViewTextBoxColumn
    Friend WithEvents totalDobles As DataGridViewTextBoxColumn
    Friend WithEvents totalTriples As DataGridViewTextBoxColumn
    Friend WithEvents totalBruto As DataGridViewTextBoxColumn
    Friend WithEvents TotalNeto As DataGridViewTextBoxColumn
End Class
