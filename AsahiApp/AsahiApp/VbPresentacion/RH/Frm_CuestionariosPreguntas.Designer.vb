<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CuestionariosPreguntas
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
        Dim Btn_DiseñarCuestionario As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CuestionariosPreguntas))
        Me.Pnl_Azul = New System.Windows.Forms.Panel()
        Me.Cmb_TipoCuestionario = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbc_Principal = New System.Windows.Forms.TabControl()
        Me.Tpg_Cuestionario = New System.Windows.Forms.TabPage()
        Me.Lbl_Frecuencia = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.Tpg_Preguntas = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cmb_Frecuencia = New System.Windows.Forms.ComboBox()
        Me.Lbl_DescripcionCuest = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Lbl_TipoCuestionario = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Lbl_DesarrollarPregunta = New System.Windows.Forms.Label()
        Me.Lbl_TipoPregunta = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbp_Respuestas = New System.Windows.Forms.TabPage()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Lbl_TipoRespuesta = New System.Windows.Forms.Label()
        Me.Gpb_OpcionMultiple = New System.Windows.Forms.GroupBox()
        Me.Dgv_OpcionMultiple = New System.Windows.Forms.DataGridView()
        Me.Gpb_Completar = New System.Windows.Forms.GroupBox()
        Me.activo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.respuesta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_CompletaOracion = New System.Windows.Forms.TextBox()
        Me.Lbl_Mensaje = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Btn_EliminarCuestionario = New System.Windows.Forms.Button()
        Me.Btn_GuardarCuestionario = New System.Windows.Forms.Button()
        Me.Btn_GuardarPregunta = New System.Windows.Forms.Button()
        Me.Btn_GuardarRespuesta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Btn_DiseñarCuestionario = New System.Windows.Forms.Button()
        Me.Pnl_Azul.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Tbc_Principal.SuspendLayout()
        Me.Tpg_Cuestionario.SuspendLayout()
        Me.Tpg_Preguntas.SuspendLayout()
        Me.Tbp_Respuestas.SuspendLayout()
        Me.Gpb_OpcionMultiple.SuspendLayout()
        CType(Me.Dgv_OpcionMultiple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gpb_Completar.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_Azul
        '
        Me.Pnl_Azul.BackColor = System.Drawing.Color.SteelBlue
        Me.Pnl_Azul.Controls.Add(Me.Panel6)
        Me.Pnl_Azul.Controls.Add(Me.Button1)
        Me.Pnl_Azul.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Azul.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Azul.Name = "Pnl_Azul"
        Me.Pnl_Azul.Size = New System.Drawing.Size(512, 60)
        Me.Pnl_Azul.TabIndex = 0
        '
        'Cmb_TipoCuestionario
        '
        Me.Cmb_TipoCuestionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_TipoCuestionario.FormattingEnabled = True
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
        Me.Panel1.Size = New System.Drawing.Size(512, 294)
        Me.Panel1.TabIndex = 1
        '
        'Tbc_Principal
        '
        Me.Tbc_Principal.Controls.Add(Me.Tpg_Cuestionario)
        Me.Tbc_Principal.Controls.Add(Me.Tpg_Preguntas)
        Me.Tbc_Principal.Controls.Add(Me.Tbp_Respuestas)
        Me.Tbc_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbc_Principal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!)
        Me.Tbc_Principal.Location = New System.Drawing.Point(10, 10)
        Me.Tbc_Principal.Name = "Tbc_Principal"
        Me.Tbc_Principal.SelectedIndex = 0
        Me.Tbc_Principal.Size = New System.Drawing.Size(492, 274)
        Me.Tbc_Principal.TabIndex = 1
        '
        'Tpg_Cuestionario
        '
        Me.Tpg_Cuestionario.Controls.Add(Me.Btn_EliminarCuestionario)
        Me.Tpg_Cuestionario.Controls.Add(Me.Btn_GuardarCuestionario)
        Me.Tpg_Cuestionario.Controls.Add(Me.Lbl_TipoCuestionario)
        Me.Tpg_Cuestionario.Controls.Add(Me.TextBox2)
        Me.Tpg_Cuestionario.Controls.Add(Me.Lbl_DescripcionCuest)
        Me.Tpg_Cuestionario.Controls.Add(Me.Cmb_TipoCuestionario)
        Me.Tpg_Cuestionario.Controls.Add(Me.Cmb_Frecuencia)
        Me.Tpg_Cuestionario.Controls.Add(Me.Lbl_Frecuencia)
        Me.Tpg_Cuestionario.Controls.Add(Me.TextBox1)
        Me.Tpg_Cuestionario.Controls.Add(Me.Lbl_Nombre)
        Me.Tpg_Cuestionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.7!)
        Me.Tpg_Cuestionario.Location = New System.Drawing.Point(4, 25)
        Me.Tpg_Cuestionario.Name = "Tpg_Cuestionario"
        Me.Tpg_Cuestionario.Size = New System.Drawing.Size(484, 242)
        Me.Tpg_Cuestionario.TabIndex = 0
        Me.Tpg_Cuestionario.Text = "Cuestionario"
        Me.Tpg_Cuestionario.UseVisualStyleBackColor = True
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 22)
        Me.TextBox1.TabIndex = 1
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
        'Tpg_Preguntas
        '
        Me.Tpg_Preguntas.Controls.Add(Me.Button2)
        Me.Tpg_Preguntas.Controls.Add(Me.Btn_GuardarPregunta)
        Me.Tpg_Preguntas.Controls.Add(Me.ComboBox1)
        Me.Tpg_Preguntas.Controls.Add(Me.Lbl_TipoPregunta)
        Me.Tpg_Preguntas.Controls.Add(Me.Lbl_DesarrollarPregunta)
        Me.Tpg_Preguntas.Controls.Add(Me.TextBox3)
        Me.Tpg_Preguntas.Location = New System.Drawing.Point(4, 25)
        Me.Tpg_Preguntas.Name = "Tpg_Preguntas"
        Me.Tpg_Preguntas.Size = New System.Drawing.Size(484, 242)
        Me.Tpg_Preguntas.TabIndex = 1
        Me.Tpg_Preguntas.Text = "Preguntas"
        Me.Tpg_Preguntas.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 284)
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
        Me.Panel3.Size = New System.Drawing.Size(10, 294)
        Me.Panel3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 294)
        Me.Panel2.TabIndex = 0
        '
        'Cmb_Frecuencia
        '
        Me.Cmb_Frecuencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Frecuencia.FormattingEnabled = True
        Me.Cmb_Frecuencia.Location = New System.Drawing.Point(259, 83)
        Me.Cmb_Frecuencia.Name = "Cmb_Frecuencia"
        Me.Cmb_Frecuencia.Size = New System.Drawing.Size(208, 24)
        Me.Cmb_Frecuencia.TabIndex = 3
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
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.TextBox2.Location = New System.Drawing.Point(15, 128)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(452, 101)
        Me.TextBox2.TabIndex = 5
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(14, 57)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(454, 101)
        Me.TextBox3.TabIndex = 0
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
        'Lbl_TipoPregunta
        '
        Me.Lbl_TipoPregunta.AutoSize = True
        Me.Lbl_TipoPregunta.Location = New System.Drawing.Point(11, 173)
        Me.Lbl_TipoPregunta.Name = "Lbl_TipoPregunta"
        Me.Lbl_TipoPregunta.Size = New System.Drawing.Size(111, 16)
        Me.Lbl_TipoPregunta.TabIndex = 2
        Me.Lbl_TipoPregunta.Text = "Tipo de pregunta"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(14, 193)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 24)
        Me.ComboBox1.TabIndex = 3
        '
        'Tbp_Respuestas
        '
        Me.Tbp_Respuestas.Controls.Add(Me.Button3)
        Me.Tbp_Respuestas.Controls.Add(Me.Lbl_Mensaje)
        Me.Tbp_Respuestas.Controls.Add(Me.Gpb_Completar)
        Me.Tbp_Respuestas.Controls.Add(Me.Gpb_OpcionMultiple)
        Me.Tbp_Respuestas.Controls.Add(Me.Lbl_TipoRespuesta)
        Me.Tbp_Respuestas.Controls.Add(Me.ComboBox2)
        Me.Tbp_Respuestas.Controls.Add(Me.Btn_GuardarRespuesta)
        Me.Tbp_Respuestas.Location = New System.Drawing.Point(4, 25)
        Me.Tbp_Respuestas.Name = "Tbp_Respuestas"
        Me.Tbp_Respuestas.Padding = New System.Windows.Forms.Padding(3)
        Me.Tbp_Respuestas.Size = New System.Drawing.Size(484, 245)
        Me.Tbp_Respuestas.TabIndex = 2
        Me.Tbp_Respuestas.Text = "Respuestas"
        Me.Tbp_Respuestas.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(14, 62)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(203, 24)
        Me.ComboBox2.TabIndex = 0
        '
        'Lbl_TipoRespuesta
        '
        Me.Lbl_TipoRespuesta.AutoSize = True
        Me.Lbl_TipoRespuesta.Location = New System.Drawing.Point(11, 43)
        Me.Lbl_TipoRespuesta.Name = "Lbl_TipoRespuesta"
        Me.Lbl_TipoRespuesta.Size = New System.Drawing.Size(105, 16)
        Me.Lbl_TipoRespuesta.TabIndex = 1
        Me.Lbl_TipoRespuesta.Text = "Tipo Respuesta"
        '
        'Gpb_OpcionMultiple
        '
        Me.Gpb_OpcionMultiple.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Gpb_OpcionMultiple.Controls.Add(Me.Dgv_OpcionMultiple)
        Me.Gpb_OpcionMultiple.Enabled = False
        Me.Gpb_OpcionMultiple.Location = New System.Drawing.Point(6, 89)
        Me.Gpb_OpcionMultiple.Name = "Gpb_OpcionMultiple"
        Me.Gpb_OpcionMultiple.Size = New System.Drawing.Size(251, 147)
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
        Me.Dgv_OpcionMultiple.Size = New System.Drawing.Size(245, 126)
        Me.Dgv_OpcionMultiple.TabIndex = 0
        Me.Dgv_OpcionMultiple.Visible = False
        '
        'Gpb_Completar
        '
        Me.Gpb_Completar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Gpb_Completar.Controls.Add(Me.Txt_CompletaOracion)
        Me.Gpb_Completar.Enabled = False
        Me.Gpb_Completar.Location = New System.Drawing.Point(264, 89)
        Me.Gpb_Completar.Name = "Gpb_Completar"
        Me.Gpb_Completar.Size = New System.Drawing.Size(214, 147)
        Me.Gpb_Completar.TabIndex = 9
        Me.Gpb_Completar.TabStop = False
        Me.Gpb_Completar.Text = "Completar Oración"
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
        'Txt_CompletaOracion
        '
        Me.Txt_CompletaOracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Txt_CompletaOracion.Location = New System.Drawing.Point(3, 18)
        Me.Txt_CompletaOracion.Multiline = True
        Me.Txt_CompletaOracion.Name = "Txt_CompletaOracion"
        Me.Txt_CompletaOracion.Size = New System.Drawing.Size(208, 126)
        Me.Txt_CompletaOracion.TabIndex = 0
        Me.Txt_CompletaOracion.Visible = False
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
        'Panel6
        '
        Me.Panel6.Controls.Add(Btn_DiseñarCuestionario)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(389, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(123, 60)
        Me.Panel6.TabIndex = 3
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
        '
        'Button1
        '
        Me.Button1.Image = Global.Presentacion.My.Resources.Resources.lupa
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(14, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Search"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
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
        'Frm_CuestionariosPreguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(512, 354)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pnl_Azul)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_CuestionariosPreguntas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Cuestionarios Preguntas"
        Me.Pnl_Azul.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Tbc_Principal.ResumeLayout(False)
        Me.Tpg_Cuestionario.ResumeLayout(False)
        Me.Tpg_Cuestionario.PerformLayout()
        Me.Tpg_Preguntas.ResumeLayout(False)
        Me.Tpg_Preguntas.PerformLayout()
        Me.Tbp_Respuestas.ResumeLayout(False)
        Me.Tbp_Respuestas.PerformLayout()
        Me.Gpb_OpcionMultiple.ResumeLayout(False)
        CType(Me.Dgv_OpcionMultiple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gpb_Completar.ResumeLayout(False)
        Me.Gpb_Completar.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_Azul As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tbc_Principal As TabControl
    Friend WithEvents Tpg_Cuestionario As TabPage
    Friend WithEvents Tpg_Preguntas As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Cmb_TipoCuestionario As ComboBox
    Friend WithEvents Lbl_Frecuencia As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Cmb_Frecuencia As ComboBox
    Friend WithEvents Lbl_TipoCuestionario As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Lbl_DescripcionCuest As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Lbl_TipoPregunta As Label
    Friend WithEvents Lbl_DesarrollarPregunta As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Tbp_Respuestas As TabPage
    Friend WithEvents Lbl_TipoRespuesta As Label
    Friend WithEvents ComboBox2 As ComboBox
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
End Class
