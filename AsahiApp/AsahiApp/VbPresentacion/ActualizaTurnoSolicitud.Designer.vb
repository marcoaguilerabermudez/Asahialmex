<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizaTurnoSolicitud
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizaTurnoSolicitud))
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_textra = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_turno = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.BackColor = System.Drawing.SystemColors.Control
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Black
        Me.lbl4.Location = New System.Drawing.Point(38, 42)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(63, 16)
        Me.lbl4.TabIndex = 131
        Me.lbl4.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Nuevo Turno"
        '
        'cbx_textra
        '
        Me.cbx_textra.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.cbx_textra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_textra.ForeColor = System.Drawing.SystemColors.Menu
        Me.cbx_textra.FormattingEnabled = True
        Me.cbx_textra.Items.AddRange(New Object() {"Matutino", "Vespertino", "Nocturno", "Administrativo"})
        Me.cbx_textra.Location = New System.Drawing.Point(117, 111)
        Me.cbx_textra.Name = "cbx_textra"
        Me.cbx_textra.Size = New System.Drawing.Size(142, 21)
        Me.cbx_textra.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Clave"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "Turno Extra"
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_clave.ForeColor = System.Drawing.Color.Black
        Me.lbl_clave.Location = New System.Drawing.Point(114, 10)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(70, 13)
        Me.lbl_clave.TabIndex = 154
        Me.lbl_clave.Text = "Nuevo Turno"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Black
        Me.lbl_nombre.Location = New System.Drawing.Point(114, 44)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(70, 13)
        Me.lbl_nombre.TabIndex = 155
        Me.lbl_nombre.Text = "Nuevo Turno"
        '
        'lbl_turno
        '
        Me.lbl_turno.AutoSize = True
        Me.lbl_turno.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_turno.ForeColor = System.Drawing.Color.Black
        Me.lbl_turno.Location = New System.Drawing.Point(114, 77)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(70, 13)
        Me.lbl_turno.TabIndex = 156
        Me.lbl_turno.Text = "Nuevo Turno"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(140, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 35)
        Me.Button1.TabIndex = 166
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ActualizaTurnoSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 221)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_turno)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbx_textra)
        Me.Controls.Add(Me.lbl4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ActualizaTurnoSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualiza turno a laborar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl4 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_textra As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_turno As Label
    Friend WithEvents Button1 As Button
End Class
