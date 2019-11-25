<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MuestradatosOEE
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.cbx_proceso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_maquina = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        Me.btn_guardar = New System.Windows.Forms.Button()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Inicio"
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(430, 28)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(96, 20)
        Me.dtp1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(586, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Fin"
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(559, 28)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(96, 20)
        Me.dtp2.TabIndex = 14
        '
        'cbx_proceso
        '
        Me.cbx_proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_proceso.FormattingEnabled = True
        Me.cbx_proceso.Items.AddRange(New Object() {"FUNDICION", "MAQUINADO", "LEAKTEST", "ENSAMBLE"})
        Me.cbx_proceso.Location = New System.Drawing.Point(15, 25)
        Me.cbx_proceso.Name = "cbx_proceso"
        Me.cbx_proceso.Size = New System.Drawing.Size(118, 21)
        Me.cbx_proceso.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Proceso"
        '
        'cbx_maquina
        '
        Me.cbx_maquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_maquina.FormattingEnabled = True
        Me.cbx_maquina.Items.AddRange(New Object() {"XY", "CV", "NTC 2"})
        Me.cbx_maquina.Location = New System.Drawing.Point(163, 25)
        Me.cbx_maquina.Name = "cbx_maquina"
        Me.cbx_maquina.Size = New System.Drawing.Size(158, 21)
        Me.cbx_maquina.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Máquina"
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToDeleteRows = False
        Me.dtgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvp.Location = New System.Drawing.Point(12, 84)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(670, 359)
        Me.dtgvp.TabIndex = 148
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.Presentacion.My.Resources.Resources.prenomina
        Me.btn_guardar.Location = New System.Drawing.Point(773, 9)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(63, 44)
        Me.btn_guardar.TabIndex = 149
        Me.btn_guardar.Text = "Mostrar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'MuestradatosOEE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 450)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.cbx_proceso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbx_maquina)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp1)
        Me.Name = "MuestradatosOEE"
        Me.Text = "MuestradatosOEE"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents cbx_proceso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_maquina As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgvp As DataGridView
    Friend WithEvents btn_guardar As Button
End Class
