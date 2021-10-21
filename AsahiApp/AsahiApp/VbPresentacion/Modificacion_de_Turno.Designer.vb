<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificacion_de_Turno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificacion_de_Turno))
        Me.txt_turno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbox_turno = New System.Windows.Forms.ComboBox()
        Me.lbl_dpto = New System.Windows.Forms.Label()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btn_desma = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txt_turno
        '
        Me.txt_turno.Enabled = False
        Me.txt_turno.Location = New System.Drawing.Point(271, 114)
        Me.txt_turno.Name = "txt_turno"
        Me.txt_turno.Size = New System.Drawing.Size(167, 20)
        Me.txt_turno.TabIndex = 191
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 189
        Me.Label4.Text = "Fecha de inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(268, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 188
        Me.Label3.Text = "Turno Actual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(470, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 187
        Me.Label2.Text = "Nuevo Turno"
        '
        'cbox_turno
        '
        Me.cbox_turno.AutoCompleteCustomSource.AddRange(New String() {"1 Matutino", "2 Vespertino", "3 Nocturno", "4 Mixto", "5", "6", "7", "8"})
        Me.cbox_turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_turno.FormattingEnabled = True
        Me.cbox_turno.Items.AddRange(New Object() {"12 M", "12 N", "Administrativo"})
        Me.cbox_turno.Location = New System.Drawing.Point(472, 114)
        Me.cbox_turno.Name = "cbox_turno"
        Me.cbox_turno.Size = New System.Drawing.Size(140, 21)
        Me.cbox_turno.TabIndex = 186
        '
        'lbl_dpto
        '
        Me.lbl_dpto.AutoSize = True
        Me.lbl_dpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dpto.ForeColor = System.Drawing.Color.Black
        Me.lbl_dpto.Location = New System.Drawing.Point(23, 60)
        Me.lbl_dpto.Name = "lbl_dpto"
        Me.lbl_dpto.Size = New System.Drawing.Size(106, 16)
        Me.lbl_dpto.TabIndex = 185
        Me.lbl_dpto.Text = "Departamento"
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clave.ForeColor = System.Drawing.Color.Black
        Me.lbl_clave.Location = New System.Drawing.Point(23, 41)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(48, 16)
        Me.lbl_clave.TabIndex = 184
        Me.lbl_clave.Text = "Clave"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_nombre.Location = New System.Drawing.Point(23, 21)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(63, 16)
        Me.lbl_nombre.TabIndex = 183
        Me.lbl_nombre.Text = "Nombre"
        '
        'btn_desma
        '
        Me.btn_desma.BackColor = System.Drawing.SystemColors.Control
        Me.btn_desma.ForeColor = System.Drawing.Color.Red
        Me.btn_desma.Location = New System.Drawing.Point(534, 51)
        Me.btn_desma.Name = "btn_desma"
        Me.btn_desma.Size = New System.Drawing.Size(78, 35)
        Me.btn_desma.TabIndex = 193
        Me.btn_desma.Text = "Salir"
        Me.btn_desma.UseVisualStyleBackColor = False
        '
        'btn_mod
        '
        Me.btn_mod.BackColor = System.Drawing.SystemColors.Control
        Me.btn_mod.Enabled = False
        Me.btn_mod.ForeColor = System.Drawing.Color.Purple
        Me.btn_mod.Location = New System.Drawing.Point(534, 10)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(79, 35)
        Me.btn_mod.TabIndex = 192
        Me.btn_mod.Text = "Modificar"
        Me.btn_mod.UseVisualStyleBackColor = False
        '
        'txt_fecha
        '
        Me.txt_fecha.Enabled = False
        Me.txt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha.Location = New System.Drawing.Point(26, 114)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(100, 20)
        Me.txt_fecha.TabIndex = 194
        '
        'Modificacion_de_Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.btn_desma)
        Me.Controls.Add(Me.btn_mod)
        Me.Controls.Add(Me.txt_turno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbox_turno)
        Me.Controls.Add(Me.lbl_dpto)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificacion_de_Turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificación de último turno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_turno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbox_turno As ComboBox
    Friend WithEvents lbl_dpto As Label
    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents btn_desma As Button
    Friend WithEvents btn_mod As Button
    Friend WithEvents txt_fecha As DateTimePicker
End Class
