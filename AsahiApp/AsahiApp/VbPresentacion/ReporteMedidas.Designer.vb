<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteMedidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteMedidas))
        Me.cbx_estado = New System.Windows.Forms.ComboBox()
        Me.cbx_tipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_anteriores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbx_estado
        '
        Me.cbx_estado.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_estado.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbx_estado.FormattingEnabled = True
        Me.cbx_estado.Items.AddRange(New Object() {"Creada", "Aplicada", "Cancelada", "Creada y Aplicada", "Todas"})
        Me.cbx_estado.Location = New System.Drawing.Point(80, 62)
        Me.cbx_estado.Name = "cbx_estado"
        Me.cbx_estado.Size = New System.Drawing.Size(158, 21)
        Me.cbx_estado.TabIndex = 154
        Me.cbx_estado.Text = "Todas"
        '
        'cbx_tipo
        '
        Me.cbx_tipo.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_tipo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbx_tipo.FormattingEnabled = True
        Me.cbx_tipo.Items.AddRange(New Object() {"Por ausentismo", "Varios", "Todos"})
        Me.cbx_tipo.Location = New System.Drawing.Point(80, 19)
        Me.cbx_tipo.Name = "cbx_tipo"
        Me.cbx_tipo.Size = New System.Drawing.Size(158, 21)
        Me.cbx_tipo.TabIndex = 153
        Me.cbx_tipo.Text = "Todos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(31, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Estado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(43, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Tipo:"
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(38, 128)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(100, 20)
        Me.dtp1.TabIndex = 155
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(176, 128)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(100, 20)
        Me.dtp2.TabIndex = 156
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(67, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(203, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "Hasta"
        '
        'btn_anteriores
        '
        Me.btn_anteriores.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_anteriores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anteriores.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_anteriores.Location = New System.Drawing.Point(107, 191)
        Me.btn_anteriores.Name = "btn_anteriores"
        Me.btn_anteriores.Size = New System.Drawing.Size(83, 42)
        Me.btn_anteriores.TabIndex = 181
        Me.btn_anteriores.Text = "Imprimir Reporte"
        Me.btn_anteriores.UseVisualStyleBackColor = False
        '
        'ReporteMedidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 267)
        Me.Controls.Add(Me.btn_anteriores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.cbx_estado)
        Me.Controls.Add(Me.cbx_tipo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReporteMedidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Medidas Disciplinarias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbx_estado As ComboBox
    Friend WithEvents cbx_tipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_anteriores As Button
End Class
