<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSoporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CombPrograma = New System.Windows.Forms.ComboBox()
        Me.TextId = New System.Windows.Forms.TextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextContraseña = New System.Windows.Forms.TextBox()
        Me.CombConexion = New System.Windows.Forms.ComboBox()
        Me.CombPrioridad = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DgvSoport = New System.Windows.Forms.DataGridView()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.RichTxtDescripción = New System.Windows.Forms.RichTextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.PictPrincipal = New System.Windows.Forms.PictureBox()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictBxCaptura1 = New System.Windows.Forms.PictureBox()
        Me.PictureBxCaptura2 = New System.Windows.Forms.PictureBox()
        Me.PictBxCaptura3 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Rdimagen = New System.Windows.Forms.RadioButton()
        Me.RdImagen2 = New System.Windows.Forms.RadioButton()
        Me.RdImagen3 = New System.Windows.Forms.RadioButton()
        CType(Me.DgvSoport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictBxCaptura1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBxCaptura2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictBxCaptura3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Problema"
        '
        'CombPrograma
        '
        Me.CombPrograma.FormattingEnabled = True
        Me.CombPrograma.Location = New System.Drawing.Point(66, 61)
        Me.CombPrograma.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CombPrograma.Name = "CombPrograma"
        Me.CombPrograma.Size = New System.Drawing.Size(110, 21)
        Me.CombPrograma.TabIndex = 1
        '
        'TextId
        '
        Me.TextId.Location = New System.Drawing.Point(66, 166)
        Me.TextId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextId.Name = "TextId"
        Me.TextId.Size = New System.Drawing.Size(110, 20)
        Me.TextId.TabIndex = 2
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Location = New System.Drawing.Point(7, 10)
        Me.BtnEnviar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(64, 32)
        Me.BtnEnviar.TabIndex = 4
        Me.BtnEnviar.Text = "Eviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prioridad"
        '
        'TextContraseña
        '
        Me.TextContraseña.Location = New System.Drawing.Point(66, 202)
        Me.TextContraseña.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextContraseña.Name = "TextContraseña"
        Me.TextContraseña.Size = New System.Drawing.Size(110, 20)
        Me.TextContraseña.TabIndex = 6
        '
        'CombConexion
        '
        Me.CombConexion.FormattingEnabled = True
        Me.CombConexion.Location = New System.Drawing.Point(66, 128)
        Me.CombConexion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CombConexion.Name = "CombConexion"
        Me.CombConexion.Size = New System.Drawing.Size(110, 21)
        Me.CombConexion.TabIndex = 7
        '
        'CombPrioridad
        '
        Me.CombPrioridad.FormattingEnabled = True
        Me.CombPrioridad.Location = New System.Drawing.Point(66, 85)
        Me.CombPrioridad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CombPrioridad.Name = "CombPrioridad"
        Me.CombPrioridad.Size = New System.Drawing.Size(110, 21)
        Me.CombPrioridad.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 488)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Description del Problema"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Conexion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 168)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-3, 206)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Contraseña"
        '
        'DgvSoport
        '
        Me.DgvSoport.AllowUserToAddRows = False
        Me.DgvSoport.AllowUserToDeleteRows = False
        Me.DgvSoport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSoport.Location = New System.Drawing.Point(7, 353)
        Me.DgvSoport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgvSoport.Name = "DgvSoport"
        Me.DgvSoport.ReadOnly = True
        Me.DgvSoport.RowTemplate.Height = 24
        Me.DgvSoport.Size = New System.Drawing.Size(398, 122)
        Me.DgvSoport.TabIndex = 13
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Location = New System.Drawing.Point(76, 10)
        Me.BtnFinalizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnFinalizar.Size = New System.Drawing.Size(64, 32)
        Me.BtnFinalizar.TabIndex = 15
        Me.BtnFinalizar.Text = "Finalizar"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(7, 229)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(397, 102)
        Me.ListView1.TabIndex = 18
        Me.ListView1.TileSize = New System.Drawing.Size(400, 15)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'RichTxtDescripción
        '
        Me.RichTxtDescripción.Location = New System.Drawing.Point(11, 504)
        Me.RichTxtDescripción.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RichTxtDescripción.Name = "RichTxtDescripción"
        Me.RichTxtDescripción.Size = New System.Drawing.Size(402, 54)
        Me.RichTxtDescripción.TabIndex = 19
        Me.RichTxtDescripción.Text = ""
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(145, 10)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(68, 32)
        Me.BtnLimpiar.TabIndex = 20
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'PictPrincipal
        '
        Me.PictPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictPrincipal.Location = New System.Drawing.Point(212, 60)
        Me.PictPrincipal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictPrincipal.Name = "PictPrincipal"
        Me.PictPrincipal.Size = New System.Drawing.Size(176, 121)
        Me.PictPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictPrincipal.TabIndex = 21
        Me.PictPrincipal.TabStop = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Location = New System.Drawing.Point(212, 186)
        Me.BtnInsertar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(49, 23)
        Me.BtnInsertar.TabIndex = 22
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(317, 187)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(51, 23)
        Me.BtnModificar.TabIndex = 23
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'PictBxCaptura1
        '
        Me.PictBxCaptura1.Location = New System.Drawing.Point(634, 72)
        Me.PictBxCaptura1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictBxCaptura1.Name = "PictBxCaptura1"
        Me.PictBxCaptura1.Size = New System.Drawing.Size(183, 121)
        Me.PictBxCaptura1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictBxCaptura1.TabIndex = 25
        Me.PictBxCaptura1.TabStop = False
        '
        'PictureBxCaptura2
        '
        Me.PictureBxCaptura2.Location = New System.Drawing.Point(474, 186)
        Me.PictureBxCaptura2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBxCaptura2.Name = "PictureBxCaptura2"
        Me.PictureBxCaptura2.Size = New System.Drawing.Size(142, 110)
        Me.PictureBxCaptura2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBxCaptura2.TabIndex = 26
        Me.PictureBxCaptura2.TabStop = False
        '
        'PictBxCaptura3
        '
        Me.PictBxCaptura3.Location = New System.Drawing.Point(474, 18)
        Me.PictBxCaptura3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictBxCaptura3.Name = "PictBxCaptura3"
        Me.PictBxCaptura3.Size = New System.Drawing.Size(133, 98)
        Me.PictBxCaptura3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictBxCaptura3.TabIndex = 27
        Me.PictBxCaptura3.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(256, 256)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(315, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(358, 44)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 29
        '
        'Rdimagen
        '
        Me.Rdimagen.AutoSize = True
        Me.Rdimagen.Location = New System.Drawing.Point(265, 192)
        Me.Rdimagen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Rdimagen.Name = "Rdimagen"
        Me.Rdimagen.Size = New System.Drawing.Size(14, 13)
        Me.Rdimagen.TabIndex = 30
        Me.Rdimagen.TabStop = True
        Me.Rdimagen.UseVisualStyleBackColor = True
        '
        'RdImagen2
        '
        Me.RdImagen2.AutoSize = True
        Me.RdImagen2.Location = New System.Drawing.Point(282, 192)
        Me.RdImagen2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RdImagen2.Name = "RdImagen2"
        Me.RdImagen2.Size = New System.Drawing.Size(14, 13)
        Me.RdImagen2.TabIndex = 31
        Me.RdImagen2.TabStop = True
        Me.RdImagen2.UseVisualStyleBackColor = True
        '
        'RdImagen3
        '
        Me.RdImagen3.AutoSize = True
        Me.RdImagen3.Location = New System.Drawing.Point(299, 192)
        Me.RdImagen3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RdImagen3.Name = "RdImagen3"
        Me.RdImagen3.Size = New System.Drawing.Size(14, 13)
        Me.RdImagen3.TabIndex = 32
        Me.RdImagen3.TabStop = True
        Me.RdImagen3.UseVisualStyleBackColor = True
        '
        'FrmSoporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 598)
        Me.Controls.Add(Me.RdImagen3)
        Me.Controls.Add(Me.RdImagen2)
        Me.Controls.Add(Me.Rdimagen)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictBxCaptura3)
        Me.Controls.Add(Me.PictureBxCaptura2)
        Me.Controls.Add(Me.PictBxCaptura1)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.PictPrincipal)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.RichTxtDescripción)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnFinalizar)
        Me.Controls.Add(Me.DgvSoport)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CombPrioridad)
        Me.Controls.Add(Me.CombConexion)
        Me.Controls.Add(Me.TextContraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.TextId)
        Me.Controls.Add(Me.CombPrograma)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSoporte"
        Me.Text = "Ticket"
        CType(Me.DgvSoport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictBxCaptura1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBxCaptura2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictBxCaptura3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents CombPrograma As Windows.Forms.ComboBox
    Friend WithEvents TextId As Windows.Forms.TextBox
    Friend WithEvents BtnEnviar As Windows.Forms.Button
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TextContraseña As Windows.Forms.TextBox
    Friend WithEvents CombConexion As Windows.Forms.ComboBox
    Friend WithEvents CombPrioridad As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents DgvSoport As Windows.Forms.DataGridView
    Friend WithEvents BtnFinalizar As Windows.Forms.Button
    Friend WithEvents ListView1 As Windows.Forms.ListView
    Friend WithEvents RichTxtDescripción As Windows.Forms.RichTextBox
    Friend WithEvents BtnLimpiar As Windows.Forms.Button
    Friend WithEvents PictPrincipal As Windows.Forms.PictureBox
    Friend WithEvents BtnInsertar As Windows.Forms.Button
    Friend WithEvents BtnModificar As Windows.Forms.Button
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents PictBxCaptura1 As Windows.Forms.PictureBox
    Friend WithEvents PictureBxCaptura2 As Windows.Forms.PictureBox
    Friend WithEvents PictBxCaptura3 As Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As ComponentModel.BackgroundWorker
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Rdimagen As Windows.Forms.RadioButton
    Friend WithEvents RdImagen2 As Windows.Forms.RadioButton
    Friend WithEvents RdImagen3 As Windows.Forms.RadioButton
End Class
