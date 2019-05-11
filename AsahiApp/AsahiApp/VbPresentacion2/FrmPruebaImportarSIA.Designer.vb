<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPruebaImportarSIA
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
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.txtFic = New System.Windows.Forms.TextBox()
        Me.txtSelect = New System.Windows.Forms.TextBox()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.dgvDiarios = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(25, 13)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(75, 31)
        Me.btnExaminar.TabIndex = 0
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'txtFic
        '
        Me.txtFic.Location = New System.Drawing.Point(25, 64)
        Me.txtFic.Name = "txtFic"
        Me.txtFic.Size = New System.Drawing.Size(265, 20)
        Me.txtFic.TabIndex = 1
        '
        'txtSelect
        '
        Me.txtSelect.Location = New System.Drawing.Point(25, 90)
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Size = New System.Drawing.Size(265, 20)
        Me.txtSelect.TabIndex = 2
        '
        'btnAbrir
        '
        Me.btnAbrir.Location = New System.Drawing.Point(124, 13)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(75, 31)
        Me.btnAbrir.TabIndex = 3
        Me.btnAbrir.Text = "Abrir"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'dgvDiarios
        '
        Me.dgvDiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiarios.Location = New System.Drawing.Point(25, 117)
        Me.dgvDiarios.Name = "dgvDiarios"
        Me.dgvDiarios.Size = New System.Drawing.Size(763, 321)
        Me.dgvDiarios.TabIndex = 4
        '
        'FrmPruebaImportarSIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvDiarios)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.txtSelect)
        Me.Controls.Add(Me.txtFic)
        Me.Controls.Add(Me.btnExaminar)
        Me.Name = "FrmPruebaImportarSIA"
        Me.Text = "FrmPruebaImportarSIA"
        CType(Me.dgvDiarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExaminar As Windows.Forms.Button
    Friend WithEvents txtFic As Windows.Forms.TextBox
    Friend WithEvents txtSelect As Windows.Forms.TextBox
    Friend WithEvents btnAbrir As Windows.Forms.Button
    Friend WithEvents dgvDiarios As Windows.Forms.DataGridView
End Class
