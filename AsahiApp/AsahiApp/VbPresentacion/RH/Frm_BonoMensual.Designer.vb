<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BonoMensual
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
        Me.Dtp_FechaInicioSemana = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Mostrar = New System.Windows.Forms.Button()
        Me.Dgv_BonoMensual = New System.Windows.Forms.DataGridView()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalBono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv_BonoMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Lbl_año)
        Me.Panel1.Controls.Add(Me.Dtp_FechaInicioSemana)
        Me.Panel1.Controls.Add(Me.Btn_Mostrar)
        Me.Panel1.Location = New System.Drawing.Point(-54, -47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 115)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(82, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 26)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Fecha inicio semana" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lbl_año
        '
        Me.Lbl_año.AutoSize = True
        Me.Lbl_año.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_año.ForeColor = System.Drawing.Color.White
        Me.Lbl_año.Location = New System.Drawing.Point(280, 74)
        Me.Lbl_año.Name = "Lbl_año"
        Me.Lbl_año.Size = New System.Drawing.Size(25, 13)
        Me.Lbl_año.TabIndex = 24
        Me.Lbl_año.Text = "año"
        '
        'Dtp_FechaInicioSemana
        '
        Me.Dtp_FechaInicioSemana.Checked = False
        Me.Dtp_FechaInicioSemana.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaInicioSemana.Location = New System.Drawing.Point(154, 68)
        Me.Dtp_FechaInicioSemana.Name = "Dtp_FechaInicioSemana"
        Me.Dtp_FechaInicioSemana.Size = New System.Drawing.Size(109, 20)
        Me.Dtp_FechaInicioSemana.TabIndex = 26
        '
        'Btn_Mostrar
        '
        Me.Btn_Mostrar.Image = Global.Presentacion.My.Resources.Resources.iconfinder_115_List_183241__2_
        Me.Btn_Mostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Mostrar.Location = New System.Drawing.Point(327, 59)
        Me.Btn_Mostrar.Name = "Btn_Mostrar"
        Me.Btn_Mostrar.Size = New System.Drawing.Size(50, 39)
        Me.Btn_Mostrar.TabIndex = 27
        Me.Btn_Mostrar.Text = "Mostrar"
        Me.Btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Dgv_BonoMensual
        '
        Me.Dgv_BonoMensual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_BonoMensual.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.nombreEmpleado, Me.fechaIngreso, Me.departamento, Me.puesto, Me.totalBono})
        Me.Dgv_BonoMensual.Location = New System.Drawing.Point(4, 95)
        Me.Dgv_BonoMensual.Name = "Dgv_BonoMensual"
        Me.Dgv_BonoMensual.RowHeadersWidth = 20
        Me.Dgv_BonoMensual.Size = New System.Drawing.Size(1209, 423)
        Me.Dgv_BonoMensual.TabIndex = 1
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "Id"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.ReadOnly = True
        Me.idEmpleado.Width = 45
        '
        'nombreEmpleado
        '
        Me.nombreEmpleado.HeaderText = "Nombre"
        Me.nombreEmpleado.Name = "nombreEmpleado"
        Me.nombreEmpleado.ReadOnly = True
        Me.nombreEmpleado.Width = 200
        '
        'fechaIngreso
        '
        Me.fechaIngreso.HeaderText = "Ingreso"
        Me.fechaIngreso.Name = "fechaIngreso"
        Me.fechaIngreso.ReadOnly = True
        Me.fechaIngreso.Width = 70
        '
        'departamento
        '
        Me.departamento.HeaderText = "Depto."
        Me.departamento.Name = "departamento"
        Me.departamento.ReadOnly = True
        Me.departamento.Width = 110
        '
        'puesto
        '
        Me.puesto.HeaderText = "Puesto"
        Me.puesto.Name = "puesto"
        Me.puesto.ReadOnly = True
        Me.puesto.Width = 110
        '
        'totalBono
        '
        Me.totalBono.HeaderText = "Total Bono"
        Me.totalBono.Name = "totalBono"
        Me.totalBono.ReadOnly = True
        Me.totalBono.Width = 45
        '
        'Frm_BonoMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 522)
        Me.Controls.Add(Me.Dgv_BonoMensual)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_BonoMensual"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bono Mensual"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dgv_BonoMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dgv_BonoMensual As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_año As Label
    Friend WithEvents Dtp_FechaInicioSemana As DateTimePicker
    Friend WithEvents Btn_Mostrar As Button
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents nombreEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents fechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents departamento As DataGridViewTextBoxColumn
    Friend WithEvents puesto As DataGridViewTextBoxColumn
    Friend WithEvents totalBono As DataGridViewTextBoxColumn
End Class
