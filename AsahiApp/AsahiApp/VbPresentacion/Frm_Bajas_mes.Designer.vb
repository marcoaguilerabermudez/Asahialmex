<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Bajas_mes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Bajas_mes))
        Me.cbx_año = New System.Windows.Forms.ComboBox()
        Me.btn_anteriores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbx_año
        '
        Me.cbx_año.BackColor = System.Drawing.Color.White
        Me.cbx_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_año.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbx_año.FormattingEnabled = True
        Me.cbx_año.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023", "2024"})
        Me.cbx_año.Location = New System.Drawing.Point(81, 31)
        Me.cbx_año.Name = "cbx_año"
        Me.cbx_año.Size = New System.Drawing.Size(94, 21)
        Me.cbx_año.TabIndex = 412
        '
        'btn_anteriores
        '
        Me.btn_anteriores.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_anteriores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_anteriores.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_anteriores.Location = New System.Drawing.Point(88, 92)
        Me.btn_anteriores.Name = "btn_anteriores"
        Me.btn_anteriores.Size = New System.Drawing.Size(83, 42)
        Me.btn_anteriores.TabIndex = 413
        Me.btn_anteriores.Text = "Imprimir"
        Me.btn_anteriores.UseVisualStyleBackColor = False
        '
        'Frm_Bajas_mes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 145)
        Me.Controls.Add(Me.btn_anteriores)
        Me.Controls.Add(Me.cbx_año)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Frm_Bajas_mes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bajas por mes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbx_año As ComboBox
    Friend WithEvents btn_anteriores As Button
End Class
