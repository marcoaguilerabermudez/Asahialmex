<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReportesPlanHorasExtra
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
        Me.Cmb_Departamento = New System.Windows.Forms.ComboBox()
        Me.Cmb_Meses = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cmb_Año = New System.Windows.Forms.ComboBox()
        Me.Btn_Obtener = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cmb_Departamento
        '
        Me.Cmb_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Departamento.FormattingEnabled = True
        Me.Cmb_Departamento.Location = New System.Drawing.Point(41, 31)
        Me.Cmb_Departamento.Name = "Cmb_Departamento"
        Me.Cmb_Departamento.Size = New System.Drawing.Size(164, 21)
        Me.Cmb_Departamento.TabIndex = 0
        '
        'Cmb_Meses
        '
        Me.Cmb_Meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Meses.FormattingEnabled = True
        Me.Cmb_Meses.Location = New System.Drawing.Point(41, 82)
        Me.Cmb_Meses.Name = "Cmb_Meses"
        Me.Cmb_Meses.Size = New System.Drawing.Size(164, 21)
        Me.Cmb_Meses.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Año"
        '
        'Cmb_Año
        '
        Me.Cmb_Año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Año.FormattingEnabled = True
        Me.Cmb_Año.Location = New System.Drawing.Point(41, 132)
        Me.Cmb_Año.Name = "Cmb_Año"
        Me.Cmb_Año.Size = New System.Drawing.Size(164, 21)
        Me.Cmb_Año.TabIndex = 5
        '
        'Btn_Obtener
        '
        Me.Btn_Obtener.Location = New System.Drawing.Point(95, 176)
        Me.Btn_Obtener.Name = "Btn_Obtener"
        Me.Btn_Obtener.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Obtener.TabIndex = 7
        Me.Btn_Obtener.Text = "Obtener"
        Me.Btn_Obtener.UseVisualStyleBackColor = True
        '
        'Frm_ReportesPlanHorasExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 225)
        Me.Controls.Add(Me.Btn_Obtener)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cmb_Año)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_Meses)
        Me.Controls.Add(Me.Cmb_Departamento)
        Me.MaximizeBox = False
        Me.Name = "Frm_ReportesPlanHorasExtra"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes Plan Horas Extra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmb_Departamento As ComboBox
    Friend WithEvents Cmb_Meses As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Cmb_Año As ComboBox
    Friend WithEvents Btn_Obtener As Button
End Class
