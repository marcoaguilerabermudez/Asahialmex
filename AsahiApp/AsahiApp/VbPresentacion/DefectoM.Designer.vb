<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefectoM
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_proceso = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_piezas = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_turno = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_defecto = New System.Windows.Forms.ComboBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.lbl_general = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(475, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Proceso"
        '
        'lbl_proceso
        '
        Me.lbl_proceso.AutoSize = True
        Me.lbl_proceso.Location = New System.Drawing.Point(479, 29)
        Me.lbl_proceso.Name = "lbl_proceso"
        Me.lbl_proceso.Size = New System.Drawing.Size(35, 13)
        Me.lbl_proceso.TabIndex = 134
        Me.lbl_proceso.Text = "Turno"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(315, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 133
        Me.Label9.Text = "Cantidad de piezas"
        '
        'lbl_piezas
        '
        Me.lbl_piezas.AutoSize = True
        Me.lbl_piezas.Location = New System.Drawing.Point(343, 29)
        Me.lbl_piezas.Name = "lbl_piezas"
        Me.lbl_piezas.Size = New System.Drawing.Size(35, 13)
        Me.lbl_piezas.TabIndex = 132
        Me.lbl_piezas.Text = "Turno"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(240, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "Turno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Hora"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Fecha"
        '
        'lbl_turno
        '
        Me.lbl_turno.AutoSize = True
        Me.lbl_turno.Location = New System.Drawing.Point(240, 29)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(35, 13)
        Me.lbl_turno.TabIndex = 128
        Me.lbl_turno.Text = "Turno"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Location = New System.Drawing.Point(119, 28)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(30, 13)
        Me.lbl_hora.TabIndex = 127
        Me.lbl_hora.Text = "Hora"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(21, 27)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 126
        Me.lbl_fecha.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "DEFECTO"
        '
        'cbx_defecto
        '
        Me.cbx_defecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_defecto.FormattingEnabled = True
        Me.cbx_defecto.Items.AddRange(New Object() {"11410-5R7A-0200", "31848-X421A", "31848-X420B", "31848-28X0A", "6H86030100", "6H86030400", "342511-31060", "342515-31020", "342511-32021-04", "342515-32021", "BJS7-39-011", "F2R5-25-740", "PEAR-15-17Z", "PEDD-10-121", "PEDD-10-131", "PEDD-10-141", "PEDD-10-161", "PEDD-14-311", "PEDD-15-17Z", "P54J-10-121", "P54G-10-141", "P54G-14-311", "BJS9-3908Y", "35652-TBG030", "35652-TBG040", "35621-TBG030", "35621-TBG040", "1094-375-032C", "49015-8010", "49015-8011", "11022-0044A", "11022-0045A", "11022-0046A", "11022-0047A", "11022-0048A", "31395-X421A", "6A7A", "6L59", "6L60", "6L61", "6L64", "6L66", "49015-8014", "6H4103000", "6H41030400", "31848-AB50A", "PEP9-10-190", "31395-X425A", "G2R5-25-740-C", "P5PW-10-190", "PEDD-10-190", "P54J-10-190", "P5", "PE", "197954-2220  (G2)"})
        Me.cbx_defecto.Location = New System.Drawing.Point(22, 109)
        Me.cbx_defecto.Name = "cbx_defecto"
        Me.cbx_defecto.Size = New System.Drawing.Size(525, 21)
        Me.cbx_defecto.TabIndex = 138
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(21, 169)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(37, 13)
        Me.lbl_id.TabIndex = 139
        Me.lbl_id.Text = "Fecha"
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Location = New System.Drawing.Point(21, 202)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(37, 13)
        Me.lbl_valor.TabIndex = 140
        Me.lbl_valor.Text = "Fecha"
        '
        'lbl_general
        '
        Me.lbl_general.AutoSize = True
        Me.lbl_general.Location = New System.Drawing.Point(21, 237)
        Me.lbl_general.Name = "lbl_general"
        Me.lbl_general.Size = New System.Drawing.Size(37, 13)
        Me.lbl_general.TabIndex = 141
        Me.lbl_general.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Cantidad"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Enabled = False
        Me.txt_cantidad.Location = New System.Drawing.Point(23, 313)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(85, 20)
        Me.txt_cantidad.TabIndex = 142
        Me.txt_cantidad.Text = "0"
        Me.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_1
        '
        Me.btn_1.Enabled = False
        Me.btn_1.Image = Global.Presentacion.My.Resources.Resources.prenomina
        Me.btn_1.Location = New System.Drawing.Point(178, 289)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(63, 56)
        Me.btn_1.TabIndex = 144
        Me.btn_1.Text = "Guardar"
        Me.btn_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'DefectoM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 366)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.lbl_general)
        Me.Controls.Add(Me.lbl_valor)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.cbx_defecto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_proceso)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_piezas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_turno)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Name = "DefectoM"
        Me.Text = "DefectoM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_proceso As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_piezas As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_turno As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbx_defecto As ComboBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_valor As Label
    Friend WithEvents lbl_general As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents btn_1 As Button
End Class
