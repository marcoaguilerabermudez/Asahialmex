<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoricoChecadas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoricoChecadas))
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(21, 31)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(34, 13)
        Me.lbl1.TabIndex = 128
        Me.lbl1.Text = "Clave"
        '
        'txt_clave
        '
        Me.txt_clave.BackColor = System.Drawing.SystemColors.Control
        Me.txt_clave.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_clave.Location = New System.Drawing.Point(62, 28)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(98, 20)
        Me.txt_clave.TabIndex = 127
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AllowUserToOrderColumns = True
        Me.dtgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvp.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvp.Location = New System.Drawing.Point(24, 87)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(263, 351)
        Me.dtgvp.TabIndex = 160
        '
        'HistoricoChecadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 450)
        Me.Controls.Add(Me.dtgvp)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txt_clave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HistoricoChecadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico Checadas"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents dtgvp As DataGridView
End Class
