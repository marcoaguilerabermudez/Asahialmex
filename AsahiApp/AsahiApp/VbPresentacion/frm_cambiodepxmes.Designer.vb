<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cambiodepxmes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cambiodepxmes))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_año = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbx_mes = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 190
        Me.Label4.Text = "Año"
        '
        'cbx_año
        '
        Me.cbx_año.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_año.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbx_año.FormattingEnabled = True
        Me.cbx_año.Items.AddRange(New Object() {"2020", "2021", "2022", "2023"})
        Me.cbx_año.Location = New System.Drawing.Point(49, 119)
        Me.cbx_año.Name = "cbx_año"
        Me.cbx_año.Size = New System.Drawing.Size(77, 21)
        Me.cbx_año.TabIndex = 189
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(16, 95)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(27, 13)
        Me.Label32.TabIndex = 188
        Me.Label32.Text = "Mes"
        '
        'cbx_mes
        '
        Me.cbx_mes.BackColor = System.Drawing.SystemColors.Control
        Me.cbx_mes.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbx_mes.FormattingEnabled = True
        Me.cbx_mes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbx_mes.Location = New System.Drawing.Point(48, 92)
        Me.cbx_mes.Name = "cbx_mes"
        Me.cbx_mes.Size = New System.Drawing.Size(103, 21)
        Me.cbx_mes.TabIndex = 187
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btn_buscar.Location = New System.Drawing.Point(188, 17)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(166, 82)
        Me.btn_buscar.TabIndex = 191
        Me.btn_buscar.Text = "Cambio de Departamento"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Button1.Location = New System.Drawing.Point(188, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 82)
        Me.Button1.TabIndex = 192
        Me.Button1.Text = "Cambio de Puesto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_cambiodepxmes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 248)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbx_año)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cbx_mes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_cambiodepxmes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir reporte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_año As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents cbx_mes As ComboBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents Button1 As Button
End Class
