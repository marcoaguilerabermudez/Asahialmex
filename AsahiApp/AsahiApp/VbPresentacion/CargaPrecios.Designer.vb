<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaPrecios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargaPrecios))
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.btn_ajustar = New System.Windows.Forms.Button()
        Me.btn_archivo = New System.Windows.Forms.Button()
        Me.dtgvp = New System.Windows.Forms.DataGridView()
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_ruta
        '
        Me.txt_ruta.BackColor = System.Drawing.SystemColors.Control
        Me.txt_ruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ruta.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_ruta.Location = New System.Drawing.Point(9, 514)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(79, 18)
        Me.txt_ruta.TabIndex = 160
        '
        'btn_ajustar
        '
        Me.btn_ajustar.FlatAppearance.BorderSize = 0
        Me.btn_ajustar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_ajustar.Image = Global.Presentacion.My.Resources.Resources.go_back256_24856
        Me.btn_ajustar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ajustar.Location = New System.Drawing.Point(551, 445)
        Me.btn_ajustar.Name = "btn_ajustar"
        Me.btn_ajustar.Size = New System.Drawing.Size(77, 88)
        Me.btn_ajustar.TabIndex = 159
        Me.btn_ajustar.Text = "Ajustar Precios"
        Me.btn_ajustar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ajustar.UseVisualStyleBackColor = True
        '
        'btn_archivo
        '
        Me.btn_archivo.FlatAppearance.BorderSize = 0
        Me.btn_archivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_archivo.Image = Global.Presentacion.My.Resources.Resources.Excel1
        Me.btn_archivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_archivo.Location = New System.Drawing.Point(564, 18)
        Me.btn_archivo.Name = "btn_archivo"
        Me.btn_archivo.Size = New System.Drawing.Size(64, 58)
        Me.btn_archivo.TabIndex = 158
        Me.btn_archivo.Text = "Cargar Archivo"
        Me.btn_archivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_archivo.UseVisualStyleBackColor = True
        '
        'dtgvp
        '
        Me.dtgvp.AllowUserToAddRows = False
        Me.dtgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgvp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgvp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvp.Location = New System.Drawing.Point(9, 18)
        Me.dtgvp.Name = "dtgvp"
        Me.dtgvp.RowHeadersVisible = False
        Me.dtgvp.Size = New System.Drawing.Size(456, 468)
        Me.dtgvp.TabIndex = 157
        '
        'CargaPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 551)
        Me.Controls.Add(Me.txt_ruta)
        Me.Controls.Add(Me.btn_ajustar)
        Me.Controls.Add(Me.btn_archivo)
        Me.Controls.Add(Me.dtgvp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CargaPrecios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste de precios para productos de almacén"
        CType(Me.dtgvp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_ruta As TextBox
    Friend WithEvents btn_ajustar As Button
    Friend WithEvents btn_archivo As Button
    Friend WithEvents dtgvp As DataGridView
End Class
