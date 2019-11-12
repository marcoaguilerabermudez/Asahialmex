<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle2oee
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
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_error = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_defecto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(456, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "Proceso"
        '
        'lbl_proceso
        '
        Me.lbl_proceso.AutoSize = True
        Me.lbl_proceso.Location = New System.Drawing.Point(460, 28)
        Me.lbl_proceso.Name = "lbl_proceso"
        Me.lbl_proceso.Size = New System.Drawing.Size(35, 13)
        Me.lbl_proceso.TabIndex = 124
        Me.lbl_proceso.Text = "Turno"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(296, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 123
        Me.Label9.Text = "Cantidad de piezas"
        '
        'lbl_piezas
        '
        Me.lbl_piezas.AutoSize = True
        Me.lbl_piezas.Location = New System.Drawing.Point(324, 28)
        Me.lbl_piezas.Name = "lbl_piezas"
        Me.lbl_piezas.Size = New System.Drawing.Size(35, 13)
        Me.lbl_piezas.TabIndex = 122
        Me.lbl_piezas.Text = "Turno"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(221, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Turno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Hora"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Fecha"
        '
        'lbl_turno
        '
        Me.lbl_turno.AutoSize = True
        Me.lbl_turno.Location = New System.Drawing.Point(221, 28)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(35, 13)
        Me.lbl_turno.TabIndex = 118
        Me.lbl_turno.Text = "Turno"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Location = New System.Drawing.Point(100, 27)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(30, 13)
        Me.lbl_hora.TabIndex = 117
        Me.lbl_hora.Text = "Hora"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(2, 26)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 116
        Me.lbl_fecha.Text = "Fecha"
        '
        'btn_1
        '
        Me.btn_1.Enabled = False
        Me.btn_1.Image = Global.Presentacion.My.Resources.Resources.prenomina
        Me.btn_1.Location = New System.Drawing.Point(131, 213)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(63, 56)
        Me.btn_1.TabIndex = 126
        Me.btn_1.Text = "Guardar"
        Me.btn_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Id de Defecto"
        '
        'txt_error
        '
        Me.txt_error.Location = New System.Drawing.Point(14, 95)
        Me.txt_error.Name = "txt_error"
        Me.txt_error.Size = New System.Drawing.Size(85, 20)
        Me.txt_error.TabIndex = 127
        Me.txt_error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(117, 89)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(63, 29)
        Me.btn_buscar.TabIndex = 129
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lbl_defecto
        '
        Me.lbl_defecto.AutoSize = True
        Me.lbl_defecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_defecto.Location = New System.Drawing.Point(8, 155)
        Me.lbl_defecto.Name = "lbl_defecto"
        Me.lbl_defecto.Size = New System.Drawing.Size(180, 20)
        Me.lbl_defecto.TabIndex = 130
        Me.lbl_defecto.Text = "Debe teclear un defecto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Cantidad"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Enabled = False
        Me.txt_cantidad.Location = New System.Drawing.Point(17, 246)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(85, 20)
        Me.txt_cantidad.TabIndex = 131
        Me.txt_cantidad.Text = "0"
        Me.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Detalle2oee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 282)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.lbl_defecto)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_error)
        Me.Controls.Add(Me.btn_1)
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
        Me.Name = "Detalle2oee"
        Me.Text = "Detalle2oee"
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
    Friend WithEvents btn_1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_error As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_defecto As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cantidad As TextBox
End Class
