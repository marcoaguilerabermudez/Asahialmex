<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_CuestionariosPreguntas
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
        Dim Btn_DiseñarCuestionario As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CuestionariosPreguntas))
        Me.Pnl_Azul = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Btn_BuscarElementos = New System.Windows.Forms.Button()
        Me.Cmb_TipoCuestionario = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbc_Principal = New System.Windows.Forms.TabControl()
        Me.Tbp_Cuestionario = New System.Windows.Forms.TabPage()
        Me.Btn_EliminarCuestionario = New System.Windows.Forms.Button()
        Me.Btn_GuardarCuestionario = New System.Windows.Forms.Button()
        Me.Lbl_TipoCuestionario = New System.Windows.Forms.Label()
        Me.Txt_ = New System.Windows.Forms.TextBox()
        Me.Lbl_DescripcionCuest = New System.Windows.Forms.Label()
        Me.Cmb_Frecuencia = New System.Windows.Forms.ComboBox()
        Me.Lbl_Frecuencia = New System.Windows.Forms.Label()
        Me.Txt_NombreCuest = New System.Windows.Forms.TextBox()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Tbp_Preguntas = New System.Windows.Forms.TabPage()
        Me.Pcb_Image = New System.Windows.Forms.PictureBox()
        Me.Txt_Ruta = New System.Windows.Forms.TextBox()
        Me.Btn_Adjuntar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_GuardarPregunta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_TipoPregunta = New System.Windows.Forms.ComboBox()
        Me.Lbl_TipoPregunta = New System.Windows.Forms.Label()
        Me.Lbl_DesarrollarPregunta = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Tbp_Respuestas = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Lbl_Mensaje = New System.Windows.Forms.Label()
        Me.Gpb_Completar = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Txt_CompletaOracion = New System.Windows.Forms.TextBox()
        Me.Gpb_OpcionMultiple = New System.Windows.Forms.GroupBox()
        Me.Dgv_OpcionMultiple = New System.Windows.Forms.DataGridView()
        Me.activo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.respuesta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lbl_TipoRespuesta = New System.Windows.Forms.Label()
        Me.Cmb_TipoRespuesta = New System.Windows.Forms.ComboBox()
        Me.Btn_GuardarRespuesta = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Gpb_Abierta = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Btn_DiseñarCuestionario = New System.Windows.Forms.Button()
        Me.Pnl_Azul.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Tbc_Principal.SuspendLayout()
        Me.Tbp_Cuestionario.SuspendLayout()
        Me.Tbp_Preguntas.SuspendLayout()
        CType(Me.Pcb_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbp_Respuestas.SuspendLayout()
        Me.Gpb_Completar.SuspendLayout()
        Me.Gpb_OpcionMultiple.SuspendLayout()
        CType(Me.Dgv_OpcionMultiple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gpb_Abierta.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_DiseñarCuestionario
        '
        Btn_DiseñarCuestionario.Image = Global.Presentacion.My.Resources.Resources.prueba_de_educacion
        Btn_DiseñarCuestionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Btn_DiseñarCuestionario.Location = New System.Drawing.Point(48, 8)
        Btn_DiseñarCuestionario.Name = "Btn_DiseñarCuestionario"
        Btn_DiseñarCuestionario.Size = New System.Drawing.Size(51, 45)
        Btn_DiseñarCuestionario.TabIndex = 2
        Btn_DiseñarCuestionario.Text = "Diseñar"
        Btn_DiseñarCuestionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Btn_DiseñarCuestionario.UseVisualStyleBackColor = True
        AddHandler Btn_DiseñarCuestionario.Click, AddressOf Me.Btn_DiseñarCuestionario_Click
        '
        'Pnl_Azul
        '
        Me.Pnl_Azul.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_Azul.Controls.Add(Me.Panel6)
        Me.Pnl_Azul.Controls.Add(Me.Btn_BuscarElementos)
        Me.Pnl_Azul.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Azul.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Azul.Name = "Pnl_Azul"
        Me.Pnl_Azul.Size = New System.Drawing.Size(512, 60)
        Me.Pnl_Azul.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Btn_DiseñarCuestionario)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(389, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(123, 60)
        Me.Panel6.TabIndex = 3
        '
        'Btn_BuscarElementos
        '
        Me.Btn_BuscarElementos.Image = Global.Presentacion.My.Resources.Resources.lupa
        Me.Btn_BuscarElementos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_BuscarElementos.Location = New System.Drawing.Point(14, 10)
        Me.Btn_BuscarElementos.Name = "Btn_BuscarElementos"
        Me.Btn_BuscarElementos.Size = New System.Drawing.Size(81, 42)
        Me.Btn_BuscarElementos.TabIndex = 1
        Me.Btn_BuscarElementos.Text = "Search"
        Me.Btn_BuscarElementos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_BuscarElementos.UseVisualStyleBackColor = True
        '
        'Cmb_TipoCuestionario
        '
        Me.Cmb_TipoCuestionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_TipoCuestionario.FormattingEnabled = True
        Me.Cmb_TipoCuestionario.Items.AddRange(New Object() {"EXAMEN", "ENCUESTA"})
        Me.Cmb_TipoCuestionario.Location = New System.Drawing.Point(15, 33)
        Me.Cmb_TipoCuestionario.Name = "Cmb_TipoCuestionario"
        Me.Cmb_TipoCuestionario.Size = New System.Drawing.Size(216, 24)
        Me.Cmb_TipoCuestionario.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Tbc_Principal)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 412)
        Me.Panel1.TabIndex = 1
        '
        'Tbc_Principal
        '
        Me.Tbc_Principal.Controls.Add(Me.Tbp_Cuestionario)
        Me.Tbc_Principal.Controls.Add(Me.Tbp_Preguntas)
        Me.Tbc_Principal.Controls.Add(Me.Tbp_Respuestas)
        Me.Tbc_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbc_Principal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!)
        Me.Tbc_Principal.Location = New System.Drawing.Point(10, 10)
        Me.Tbc_Principal.Name = "Tbc_Principal"
        Me.Tbc_Principal.SelectedIndex = 0
        Me.Tbc_Principal.Size = New System.Drawing.Size(492, 392)
        Me.Tbc_Principal.TabIndex = 1
        '
        'Tbp_Cuestionario
        '
        Me.Tbp_Cuestionario.Controls.Add(Me.Btn_EliminarCuestionario)
        Me.Tbp_Cuestionario.Controls.Add(Me.Btn_GuardarCuestionario)
        Me.Tbp_Cuestionario.Controls.Add(Me.Lbl_TipoCuestionario)
        Me.Tbp_Cuestionario.Controls.Add(Me.Txt_)
        Me.Tbp_Cuestionario.Controls.Add(Me.Lbl_DescripcionCuest)
        Me.Tbp_Cuestionario.Controls.Add(Me.Cmb_TipoCuestionario)
        Me.Tbp_Cuestionario.Controls.Add(Me.Cmb_Frecuencia)
        Me.Tbp_Cuestionario.Controls.Add(Me.Lbl_Frecuencia)
        Me.Tbp_Cuestionario.Controls.Add(Me.Txt_NombreCuest)
        Me.Tbp_Cuestionario.Controls.Add(Me.Lbl_Nombre)
        Me.Tbp_Cuestionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!)
        Me.Tbp_Cuestionario.Location = New System.Drawing.Point(4, 25)
        Me.Tbp_Cuestionario.Name = "Tbp_Cuestionario"
        Me.Tbp_Cuestionario.Size = New System.Drawing.Size(484, 363)
        Me.Tbp_Cuestionario.TabIndex = 0
        Me.Tbp_Cuestionario.Text = "Cuestionario"
        Me.Tbp_Cuestionario.UseVisualStyleBackColor = True
        '
        'Btn_EliminarCuestionario
        '
        Me.Btn_EliminarCuestionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!)
        Me.Btn_EliminarCuestionario.Image = Global.Presentacion.My.Resources.Resources.delete
        Me.Btn_EliminarCuestionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_EliminarCuestionario.Location = New System.Drawing.Point(424, 6)
        Me.Btn_EliminarCuestionario.Name = "Btn_EliminarCuestionario"
        Me.Btn_EliminarCuestionario.Size = New System.Drawing.Size(50, 45)
        Me.Btn_EliminarCuestionario.TabIndex = 8
        Me.Btn_EliminarCuestionario.Text = "Delete"
        Me.Btn_EliminarCuestionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_EliminarCuestionario.UseVisualStyleBackColor = True
        '
        'Btn_GuardarCuestionario
        '
        Me.Btn_GuardarCuestionario.Image = Global.Presentacion.My.Resources.Resources.save
        Me.Btn_GuardarCuestionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_GuardarCuestionario.Location = New System.Drawing.Point(364, 6)
        Me.Btn_GuardarCuestionario.Name = "Btn_GuardarCuestionario"
        Me.Btn_GuardarCuestionario.Size = New System.Drawing.Size(50, 45)
        Me.Btn_GuardarCuestionario.TabIndex = 7
        Me.Btn_GuardarCuestionario.Text = "Save"
        Me.Btn_GuardarCuestionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_GuardarCuestionario.UseVisualStyleBackColor = True
        '
        'Lbl_TipoCuestionario
        '
        Me.Lbl_TipoCuestionario.AutoSize = True
        Me.Lbl_TipoCuestionario.Location = New System.Drawing.Point(12, 15)
        Me.Lbl_TipoCuestionario.Name = "Lbl_TipoCuestionario"
        Me.Lbl_TipoCuestionario.Size = New System.Drawing.Size(131, 16)
        Me.Lbl_TipoCuestionario.TabIndex = 6
        Me.Lbl_TipoCuestionario.Text = "Tipo de cuestionario"
        '
        'Txt_
        '
        Me.Txt_.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Txt_.Location = New System.Drawing.Point(15, 128)
        Me.Txt_.Multiline = True
        Me.Txt_.Name = "Txt_"
        Me.Txt_.Size = New System.Drawing.Size(452, 221)
        Me.Txt_.TabIndex = 5
        '
        'Lbl_DescripcionCuest
        '
        Me.Lbl_DescripcionCuest.AutoSize = True
        Me.Lbl_DescripcionCuest.Location = New System.Drawing.Point(12, 109)
        Me.Lbl_DescripcionCuest.Name = "Lbl_DescripcionCuest"
        Me.Lbl_DescripcionCuest.Size = New System.Drawing.Size(80, 16)
        Me.Lbl_DescripcionCuest.TabIndex = 4
        Me.Lbl_DescripcionCuest.Text = "Descripción"
        '
        'Cmb_Frecuencia
        '
        Me.Cmb_Frecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Frecuencia.FormattingEnabled = True
        Me.Cmb_Frecuencia.Items.AddRange(New Object() {"TRIMESTRAL", "SEMESTRAL", "ANUAL"})
        Me.Cmb_Frecuencia.Location = New System.Drawing.Point(259, 83)
        Me.Cmb_Frecuencia.Name = "Cmb_Frecuencia"
        Me.Cmb_Frecuencia.Size = New System.Drawing.Size(208, 24)
        Me.Cmb_Frecuencia.TabIndex = 3
        '
        'Lbl_Frecuencia
        '
        Me.Lbl_Frecuencia.AutoSize = True
        Me.Lbl_Frecuencia.Location = New System.Drawing.Point(256, 65)
        Me.Lbl_Frecuencia.Name = "Lbl_Frecuencia"
        Me.Lbl_Frecuencia.Size = New System.Drawing.Size(75, 16)
        Me.Lbl_Frecuencia.TabIndex = 2
        Me.Lbl_Frecuencia.Text = "Frecuencia"
        '
        'Txt_NombreCuest
        '
        Me.Txt_NombreCuest.Location = New System.Drawing.Point(15, 85)
        Me.Txt_NombreCuest.Name = "Txt_NombreCuest"
        Me.Txt_NombreCuest.Size = New System.Drawing.Size(216, 22)
        Me.Txt_NombreCuest.TabIndex = 1
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!)
        Me.Lbl_Nombre.Location = New System.Drawing.Point(12, 67)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(57, 16)
        Me.Lbl_Nombre.TabIndex = 0
        Me.Lbl_Nombre.Text = "Nombre"
        '
        'Tbp_Preguntas
        '
        Me.Tbp_Preguntas.Controls.Add(Me.Pcb_Image)
        Me.Tbp_Preguntas.Controls.Add(Me.Txt_Ruta)
        Me.Tbp_Preguntas.Controls.Add(Me.Btn_Adjuntar)
        Me.Tbp_Preguntas.Controls.Add(Me.Button2)
        Me.Tbp_Preguntas.Controls.Add(Me.Btn_GuardarPregunta)
        Me.Tbp_Preguntas.Controls.Add(Me.Label1)
        Me.Tbp_Preguntas.Controls.Add(Me.Cmb_TipoPregunta)
        Me.Tbp_Preguntas.Controls.Add(Me.Lbl_TipoPregunta)
        Me.Tbp_Preguntas.Controls.Add(Me.Lbl_DesarrollarPregunta)
        Me.Tbp_Preguntas.Controls.Add(Me.TextBox3)
        Me.Tbp_Preguntas.Location = New System.Drawing.Point(4, 25)
        Me.Tbp_Preguntas.Name = "Tbp_Preguntas"
        Me.Tbp_Preguntas.Size = New System.Drawing.Size(484, 363)
        Me.Tbp_Preguntas.TabIndex = 1
        Me.Tbp_Preguntas.Text = "Preguntas"
        Me.Tbp_Preguntas.UseVisualStyleBackColor = True
        '
        'Pcb_Image
        '
        Me.Pcb_Image.Location = New System.Drawing.Point(256, 204)
        Me.Pcb_Image.Name = "Pcb_Image"
        Me.Pcb_Image.Size = New System.Drawing.Size(212, 146)
        Me.Pcb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pcb_Image.TabIndex = 11
        Me.Pcb_Image.TabStop = False
        '
        'Txt_Ruta
        '
        Me.Txt_Ruta.Location = New System.Drawing.Point(14, 221)
        Me.Txt_Ruta.Name = "Txt_Ruta"
        Me.Txt_Ruta.Size = New System.Drawing.Size(216, 22)
        Me.Txt_Ruta.TabIndex = 10
        '
        'Btn_Adjuntar
        '
        Me.Btn_Adjuntar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_Adjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Adjuntar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!)
        Me.Btn_Adjuntar.Image = Global.Presentacion.My.Resources.Resources.adjuntar__1_
        Me.Btn_Adjuntar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Adjuntar.Location = New System.Drawing.Point(231, 217)
        Me.Btn_Adjuntar.Name = "Btn_Adjuntar"
        Me.Btn_Adjuntar.Size = New System.Drawing.Size(19, 29)
        Me.Btn_Adjuntar.TabIndex = 9
        Me.Btn_Adjuntar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Adjuntar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!)
        Me.Button2.Image = Global.Presentacion.My.Resources.Resources.delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(424, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 45)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Delete"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btn_GuardarPregunta
        '
        Me.Btn_GuardarPregunta.Image = Global.Presentacion.My.Resources.Resources.save
        Me.Btn_GuardarPregunta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_GuardarPregunta.Location = New System.Drawing.Point(364, 6)
        Me.Btn_GuardarPregunta.Name = "Btn_GuardarPregunta"
        Me.Btn_GuardarPregunta.Size = New System.Drawing.Size(50, 45)
        Me.Btn_GuardarPregunta.TabIndex = 8
        Me.Btn_GuardarPregunta.Text = "Save"
        Me.Btn_GuardarPregunta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_GuardarPregunta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Imágen"
        '
        'Cmb_TipoPregunta
        '
        Me.Cmb_TipoPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_TipoPregunta.FormattingEnabled = True
        Me.Cmb_TipoPregunta.Location = New System.Drawing.Point(14, 286)
        Me.Cmb_TipoPregunta.Name = "Cmb_TipoPregunta"
        Me.Cmb_TipoPregunta.Size = New System.Drawing.Size(216, 24)
        Me.Cmb_TipoPregunta.TabIndex = 3
        '
        'Lbl_TipoPregunta
        '
        Me.Lbl_TipoPregunta.AutoSize = True
        Me.Lbl_TipoPregunta.Location = New System.Drawing.Point(11, 266)
        Me.Lbl_TipoPregunta.Name = "Lbl_TipoPregunta"
        Me.Lbl_TipoPregunta.Size = New System.Drawing.Size(111, 16)
        Me.Lbl_TipoPregunta.TabIndex = 2
        Me.Lbl_TipoPregunta.Text = "Tipo de pregunta"
        '
        'Lbl_DesarrollarPregunta
        '
        Me.Lbl_DesarrollarPregunta.AutoSize = True
        Me.Lbl_DesarrollarPregunta.Location = New System.Drawing.Point(11, 39)
        Me.Lbl_DesarrollarPregunta.Name = "Lbl_DesarrollarPregunta"
        Me.Lbl_DesarrollarPregunta.Size = New System.Drawing.Size(182, 16)
        Me.Lbl_DesarrollarPregunta.TabIndex = 1
        Me.Lbl_DesarrollarPregunta.Text = "Desarrolle su pregunta aquí..."
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(14, 57)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(454, 129)
        Me.TextBox3.TabIndex = 0
        '
        'Tbp_Respuestas
        '
        Me.Tbp_Respuestas.Controls.Add(Me.Gpb_Abierta)
        Me.Tbp_Respuestas.Controls.Add(Me.Button3)
        Me.Tbp_Respuestas.Controls.Add(Me.Lbl_Mensaje)
        Me.Tbp_Respuestas.Controls.Add(Me.Gpb_Completar)
        Me.Tbp_Respuestas.Controls.Add(Me.Gpb_OpcionMultiple)
        Me.Tbp_Respuestas.Controls.Add(Me.Lbl_TipoRespuesta)
        Me.Tbp_Respuestas.Controls.Add(Me.Cmb_TipoRespuesta)
        Me.Tbp_Respuestas.Controls.Add(Me.Btn_GuardarRespuesta)
        Me.Tbp_Respuestas.Location = New System.Drawing.Point(4, 25)
        Me.Tbp_Respuestas.Name = "Tbp_Respuestas"
        Me.Tbp_Respuestas.Padding = New System.Windows.Forms.Padding(3)
        Me.Tbp_Respuestas.Size = New System.Drawing.Size(484, 363)
        Me.Tbp_Respuestas.TabIndex = 2
        Me.Tbp_Respuestas.Text = "Respuestas"
        Me.Tbp_Respuestas.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.2!)
        Me.Button3.Image = Global.Presentacion.My.Resources.Resources.delete
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(424, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 45)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Delete"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Lbl_Mensaje
        '
        Me.Lbl_Mensaje.AutoSize = True
        Me.Lbl_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.4!)
        Me.Lbl_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Mensaje.Location = New System.Drawing.Point(350, 62)
        Me.Lbl_Mensaje.Name = "Lbl_Mensaje"
        Me.Lbl_Mensaje.Size = New System.Drawing.Size(125, 24)
        Me.Lbl_Mensaje.TabIndex = 10
        Me.Lbl_Mensaje.Text = "*Recuerde agregar guión bajo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "donde debe ir la respuesta"
        '
        'Gpb_Completar
        '
        Me.Gpb_Completar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Gpb_Completar.Controls.Add(Me.TextBox4)
        Me.Gpb_Completar.Controls.Add(Me.Txt_CompletaOracion)
        Me.Gpb_Completar.Enabled = False
        Me.Gpb_Completar.Location = New System.Drawing.Point(264, 89)
        Me.Gpb_Completar.Name = "Gpb_Completar"
        Me.Gpb_Completar.Size = New System.Drawing.Size(214, 173)
        Me.Gpb_Completar.TabIndex = 9
        Me.Gpb_Completar.TabStop = False
        Me.Gpb_Completar.Text = "Completar Oración"
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox4.Location = New System.Drawing.Point(3, 101)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(208, 69)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.Visible = False
        '
        'Txt_CompletaOracion
        '
        Me.Txt_CompletaOracion.Dock = System.Windows.Forms.DockStyle.Top
        Me.Txt_CompletaOracion.Location = New System.Drawing.Point(3, 18)
        Me.Txt_CompletaOracion.Multiline = True
        Me.Txt_CompletaOracion.Name = "Txt_CompletaOracion"
        Me.Txt_CompletaOracion.Size = New System.Drawing.Size(208, 63)
        Me.Txt_CompletaOracion.TabIndex = 0
        Me.Txt_CompletaOracion.Visible = False
        '
        'Gpb_OpcionMultiple
        '
        Me.Gpb_OpcionMultiple.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Gpb_OpcionMultiple.Controls.Add(Me.Dgv_OpcionMultiple)
        Me.Gpb_OpcionMultiple.Enabled = False
        Me.Gpb_OpcionMultiple.Location = New System.Drawing.Point(6, 89)
        Me.Gpb_OpcionMultiple.Name = "Gpb_OpcionMultiple"
        Me.Gpb_OpcionMultiple.Size = New System.Drawing.Size(251, 173)
        Me.Gpb_OpcionMultiple.TabIndex = 2
        Me.Gpb_OpcionMultiple.TabStop = False
        Me.Gpb_OpcionMultiple.Text = "Opción Multiple"
        '
        'Dgv_OpcionMultiple
        '
        Me.Dgv_OpcionMultiple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_OpcionMultiple.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.activo, Me.respuesta})
        Me.Dgv_OpcionMultiple.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_OpcionMultiple.Location = New System.Drawing.Point(3, 18)
        Me.Dgv_OpcionMultiple.Name = "Dgv_OpcionMultiple"
        Me.Dgv_OpcionMultiple.RowHeadersVisible = False
        Me.Dgv_OpcionMultiple.Size = New System.Drawing.Size(245, 152)
        Me.Dgv_OpcionMultiple.TabIndex = 0
        Me.Dgv_OpcionMultiple.Visible = False
        '
        'activo
        '
        Me.activo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.activo.Frozen = True
        Me.activo.HeaderText = ""
        Me.activo.Name = "activo"
        Me.activo.Width = 30
        '
        'respuesta
        '
        Me.respuesta.Frozen = True
        Me.respuesta.HeaderText = "Respuesta"
        Me.respuesta.Name = "respuesta"
        Me.respuesta.Width = 220
        '
        'Lbl_TipoRespuesta
        '
        Me.Lbl_TipoRespuesta.AutoSize = True
        Me.Lbl_TipoRespuesta.Location = New System.Drawing.Point(4, 43)
        Me.Lbl_TipoRespuesta.Name = "Lbl_TipoRespuesta"
        Me.Lbl_TipoRespuesta.Size = New System.Drawing.Size(105, 16)
        Me.Lbl_TipoRespuesta.TabIndex = 1
        Me.Lbl_TipoRespuesta.Text = "Tipo Respuesta"
        '
        'Cmb_TipoRespuesta
        '
        Me.Cmb_TipoRespuesta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_TipoRespuesta.FormattingEnabled = True
        Me.Cmb_TipoRespuesta.Items.AddRange(New Object() {"MULTIPLE", "COMPLETAR", "ABIERTA"})
        Me.Cmb_TipoRespuesta.Location = New System.Drawing.Point(7, 62)
        Me.Cmb_TipoRespuesta.Name = "Cmb_TipoRespuesta"
        Me.Cmb_TipoRespuesta.Size = New System.Drawing.Size(203, 24)
        Me.Cmb_TipoRespuesta.TabIndex = 0
        '
        'Btn_GuardarRespuesta
        '
        Me.Btn_GuardarRespuesta.Image = Global.Presentacion.My.Resources.Resources.save
        Me.Btn_GuardarRespuesta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_GuardarRespuesta.Location = New System.Drawing.Point(364, 6)
        Me.Btn_GuardarRespuesta.Name = "Btn_GuardarRespuesta"
        Me.Btn_GuardarRespuesta.Size = New System.Drawing.Size(50, 45)
        Me.Btn_GuardarRespuesta.TabIndex = 8
        Me.Btn_GuardarRespuesta.Text = "Save"
        Me.Btn_GuardarRespuesta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_GuardarRespuesta.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 402)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(492, 10)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(10, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(492, 10)
        Me.Panel5.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(502, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 412)
        Me.Panel3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 412)
        Me.Panel2.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Gpb_Abierta
        '
        Me.Gpb_Abierta.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Gpb_Abierta.Controls.Add(Me.TextBox2)
        Me.Gpb_Abierta.Enabled = False
        Me.Gpb_Abierta.Location = New System.Drawing.Point(6, 265)
        Me.Gpb_Abierta.Name = "Gpb_Abierta"
        Me.Gpb_Abierta.Size = New System.Drawing.Size(472, 92)
        Me.Gpb_Abierta.TabIndex = 12
        Me.Gpb_Abierta.TabStop = False
        Me.Gpb_Abierta.Text = "Abierta"
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox2.Location = New System.Drawing.Point(3, 18)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(466, 68)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Visible = False
        '
        'Frm_CuestionariosPreguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(512, 472)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pnl_Azul)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_CuestionariosPreguntas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Cuestionarios Preguntas"
        Me.Pnl_Azul.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Tbc_Principal.ResumeLayout(False)
        Me.Tbp_Cuestionario.ResumeLayout(False)
        Me.Tbp_Cuestionario.PerformLayout()
        Me.Tbp_Preguntas.ResumeLayout(False)
        Me.Tbp_Preguntas.PerformLayout()
        CType(Me.Pcb_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbp_Respuestas.ResumeLayout(False)
        Me.Tbp_Respuestas.PerformLayout()
        Me.Gpb_Completar.ResumeLayout(False)
        Me.Gpb_Completar.PerformLayout()
        Me.Gpb_OpcionMultiple.ResumeLayout(False)
        CType(Me.Dgv_OpcionMultiple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gpb_Abierta.ResumeLayout(False)
        Me.Gpb_Abierta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_Azul As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tbc_Principal As TabControl
    Friend WithEvents Tbp_Cuestionario As TabPage
    Friend WithEvents Tbp_Preguntas As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_BuscarElementos As Button
    Friend WithEvents Cmb_TipoCuestionario As ComboBox
    Friend WithEvents Lbl_Frecuencia As Label
    Friend WithEvents Txt_NombreCuest As TextBox
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Cmb_Frecuencia As ComboBox
    Friend WithEvents Lbl_TipoCuestionario As Label
    Friend WithEvents Txt_ As TextBox
    Friend WithEvents Lbl_DescripcionCuest As Label
    Friend WithEvents Cmb_TipoPregunta As ComboBox
    Friend WithEvents Lbl_TipoPregunta As Label
    Friend WithEvents Lbl_DesarrollarPregunta As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Tbp_Respuestas As TabPage
    Friend WithEvents Lbl_TipoRespuesta As Label
    Friend WithEvents Cmb_TipoRespuesta As ComboBox
    Friend WithEvents Gpb_OpcionMultiple As GroupBox
    Friend WithEvents Dgv_OpcionMultiple As DataGridView
    Friend WithEvents Btn_GuardarCuestionario As Button
    Friend WithEvents Btn_GuardarPregunta As Button
    Friend WithEvents Lbl_Mensaje As Label
    Friend WithEvents Gpb_Completar As GroupBox
    Friend WithEvents Txt_CompletaOracion As TextBox
    Friend WithEvents Btn_GuardarRespuesta As Button
    Friend WithEvents activo As DataGridViewCheckBoxColumn
    Friend WithEvents respuesta As DataGridViewTextBoxColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btn_EliminarCuestionario As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Txt_Ruta As TextBox
    Friend WithEvents Btn_Adjuntar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Pcb_Image As PictureBox
    Friend WithEvents Gpb_Abierta As GroupBox
    Friend WithEvents TextBox2 As TextBox
End Class
