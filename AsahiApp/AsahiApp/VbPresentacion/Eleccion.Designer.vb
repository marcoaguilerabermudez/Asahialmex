<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eleccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eleccion))
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.pbx2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbx
        '
        Me.pbx.ErrorImage = CType(resources.GetObject("pbx.ErrorImage"), System.Drawing.Image)
        Me.pbx.InitialImage = CType(resources.GetObject("pbx.InitialImage"), System.Drawing.Image)
        Me.pbx.Location = New System.Drawing.Point(52, 113)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(132, 138)
        Me.pbx.TabIndex = 195
        Me.pbx.TabStop = False
        '
        'pbx2
        '
        Me.pbx2.ErrorImage = CType(resources.GetObject("pbx2.ErrorImage"), System.Drawing.Image)
        Me.pbx2.InitialImage = CType(resources.GetObject("pbx2.InitialImage"), System.Drawing.Image)
        Me.pbx2.Location = New System.Drawing.Point(345, 113)
        Me.pbx2.Name = "pbx2"
        Me.pbx2.Size = New System.Drawing.Size(132, 138)
        Me.pbx2.TabIndex = 196
        Me.pbx2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(157, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 20)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Elige tu nueva forma de vivir"
        '
        'Eleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Presentacion.My.Resources.Resources.matri1
        Me.ClientSize = New System.Drawing.Size(545, 359)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbx2)
        Me.Controls.Add(Me.pbx)
        Me.Name = "Eleccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elige sabiamente"
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbx As PictureBox
    Friend WithEvents pbx2 As PictureBox
    Friend WithEvents Label1 As Label
End Class
