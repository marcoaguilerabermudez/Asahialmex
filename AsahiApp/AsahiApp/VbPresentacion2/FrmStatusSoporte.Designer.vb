<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStatusSoporte
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
        Me.components = New System.ComponentModel.Container()
        Me.DgvStatuSoporte = New System.Windows.Forms.DataGridView()
        Me.BtnMessenger = New System.Windows.Forms.Button()
        Me.ListMessenger = New System.Windows.Forms.ListView()
        Me.LblMessenger = New System.Windows.Forms.Label()
        Me.RichTxtMessenger = New System.Windows.Forms.RichTextBox()
        Me.PictEstatusSoporte = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.RadImagen = New System.Windows.Forms.RadioButton()
        Me.RadImagen2 = New System.Windows.Forms.RadioButton()
        Me.RadiImagen3 = New System.Windows.Forms.RadioButton()
        CType(Me.DgvStatuSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictEstatusSoporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvStatuSoporte
        '
        Me.DgvStatuSoporte.AllowUserToAddRows = False
        Me.DgvStatuSoporte.AllowUserToDeleteRows = False
        Me.DgvStatuSoporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvStatuSoporte.Location = New System.Drawing.Point(13, 210)
        Me.DgvStatuSoporte.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvStatuSoporte.Name = "DgvStatuSoporte"
        Me.DgvStatuSoporte.ReadOnly = True
        Me.DgvStatuSoporte.RowTemplate.Height = 24
        Me.DgvStatuSoporte.Size = New System.Drawing.Size(884, 171)
        Me.DgvStatuSoporte.TabIndex = 0
        '
        'BtnMessenger
        '
        Me.BtnMessenger.Location = New System.Drawing.Point(9, 10)
        Me.BtnMessenger.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMessenger.Name = "BtnMessenger"
        Me.BtnMessenger.Size = New System.Drawing.Size(76, 45)
        Me.BtnMessenger.TabIndex = 1
        Me.BtnMessenger.Text = "Enviar"
        Me.BtnMessenger.UseVisualStyleBackColor = True
        '
        'ListMessenger
        '
        Me.ListMessenger.Location = New System.Drawing.Point(12, 76)
        Me.ListMessenger.Margin = New System.Windows.Forms.Padding(2)
        Me.ListMessenger.Name = "ListMessenger"
        Me.ListMessenger.Size = New System.Drawing.Size(885, 120)
        Me.ListMessenger.TabIndex = 2
        Me.ListMessenger.TileSize = New System.Drawing.Size(700, 20)
        Me.ListMessenger.UseCompatibleStateImageBehavior = False
        Me.ListMessenger.View = System.Windows.Forms.View.Tile
        '
        'LblMessenger
        '
        Me.LblMessenger.AutoSize = True
        Me.LblMessenger.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessenger.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblMessenger.Location = New System.Drawing.Point(9, 392)
        Me.LblMessenger.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMessenger.Name = "LblMessenger"
        Me.LblMessenger.Size = New System.Drawing.Size(64, 18)
        Me.LblMessenger.TabIndex = 5
        Me.LblMessenger.Text = "Mensaje"
        '
        'RichTxtMessenger
        '
        Me.RichTxtMessenger.Location = New System.Drawing.Point(12, 414)
        Me.RichTxtMessenger.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTxtMessenger.Name = "RichTxtMessenger"
        Me.RichTxtMessenger.Size = New System.Drawing.Size(885, 71)
        Me.RichTxtMessenger.TabIndex = 6
        Me.RichTxtMessenger.Text = ""
        '
        'PictEstatusSoporte
        '
        Me.PictEstatusSoporte.Location = New System.Drawing.Point(920, 76)
        Me.PictEstatusSoporte.Name = "PictEstatusSoporte"
        Me.PictEstatusSoporte.Size = New System.Drawing.Size(303, 236)
        Me.PictEstatusSoporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictEstatusSoporte.TabIndex = 7
        Me.PictEstatusSoporte.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'RadImagen
        '
        Me.RadImagen.AutoSize = True
        Me.RadImagen.Location = New System.Drawing.Point(1044, 332)
        Me.RadImagen.Name = "RadImagen"
        Me.RadImagen.Size = New System.Drawing.Size(14, 13)
        Me.RadImagen.TabIndex = 8
        Me.RadImagen.TabStop = True
        Me.RadImagen.UseVisualStyleBackColor = True
        '
        'RadImagen2
        '
        Me.RadImagen2.AutoSize = True
        Me.RadImagen2.Location = New System.Drawing.Point(1075, 332)
        Me.RadImagen2.Name = "RadImagen2"
        Me.RadImagen2.Size = New System.Drawing.Size(14, 13)
        Me.RadImagen2.TabIndex = 9
        Me.RadImagen2.TabStop = True
        Me.RadImagen2.UseVisualStyleBackColor = True
        '
        'RadiImagen3
        '
        Me.RadiImagen3.AutoSize = True
        Me.RadiImagen3.Location = New System.Drawing.Point(1105, 332)
        Me.RadiImagen3.Name = "RadiImagen3"
        Me.RadiImagen3.Size = New System.Drawing.Size(14, 13)
        Me.RadiImagen3.TabIndex = 10
        Me.RadiImagen3.TabStop = True
        Me.RadiImagen3.UseVisualStyleBackColor = True
        '
        'FrmStatusSoporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 546)
        Me.Controls.Add(Me.RadiImagen3)
        Me.Controls.Add(Me.RadImagen2)
        Me.Controls.Add(Me.RadImagen)
        Me.Controls.Add(Me.PictEstatusSoporte)
        Me.Controls.Add(Me.RichTxtMessenger)
        Me.Controls.Add(Me.LblMessenger)
        Me.Controls.Add(Me.ListMessenger)
        Me.Controls.Add(Me.BtnMessenger)
        Me.Controls.Add(Me.DgvStatuSoporte)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmStatusSoporte"
        Me.Text = "FrmStatusSoporte"
        CType(Me.DgvStatuSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictEstatusSoporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvStatuSoporte As Windows.Forms.DataGridView
    Friend WithEvents BtnMessenger As Windows.Forms.Button
    Friend WithEvents ListMessenger As Windows.Forms.ListView
    Friend WithEvents LblMessenger As Windows.Forms.Label
    Friend WithEvents RichTxtMessenger As Windows.Forms.RichTextBox
    Friend WithEvents PictEstatusSoporte As Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
    Friend WithEvents RadImagen As Windows.Forms.RadioButton
    Friend WithEvents RadImagen2 As Windows.Forms.RadioButton
    Friend WithEvents RadiImagen3 As Windows.Forms.RadioButton
End Class
