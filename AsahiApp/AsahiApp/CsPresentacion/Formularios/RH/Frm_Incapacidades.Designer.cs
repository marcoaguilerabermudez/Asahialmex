namespace CsPresentacion
{
    partial class Frm_Incapacidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.tp_permisos = new System.Windows.Forms.TabPage();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_inc_caso = new System.Windows.Forms.Label();
            this.lbl_inc_tipo = new System.Windows.Forms.Label();
            this.txt_certificado = new System.Windows.Forms.MaskedTextBox();
            this.cmb_caso = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtm_aplicacion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtm_termina = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_duracion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtm_fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_incapacidades = new System.Windows.Forms.DataGridView();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lbl_tipo_falta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tp_permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incapacidades)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txt_clave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(-2, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 69);
            this.panel1.TabIndex = 144;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(17, 42);
            this.txt_clave.MaxLength = 8;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(100, 20);
            this.txt_clave.TabIndex = 28;
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_clave_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "CLAVE";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(118, 39);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 27;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(633, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_estado);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 73);
            this.groupBox2.TabIndex = 149;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 146;
            this.label2.Text = "NOMBRE:";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(9, 52);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(57, 13);
            this.lbl_estado.TabIndex = 147;
            this.lbl_estado.Text = "ESTADO";
            this.lbl_estado.TextChanged += new System.EventHandler(this.Lbl_estado_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(9, 27);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(457, 20);
            this.txt_nombre.TabIndex = 145;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombre_KeyPress);
            this.txt_nombre.Leave += new System.EventHandler(this.Txt_nombre_Leave);
            // 
            // tp_permisos
            // 
            this.tp_permisos.Controls.Add(this.lbl_tipo_falta);
            this.tp_permisos.Controls.Add(this.lbl_id);
            this.tp_permisos.Controls.Add(this.lbl_inc_caso);
            this.tp_permisos.Controls.Add(this.lbl_inc_tipo);
            this.tp_permisos.Controls.Add(this.txt_certificado);
            this.tp_permisos.Controls.Add(this.cmb_caso);
            this.tp_permisos.Controls.Add(this.label9);
            this.tp_permisos.Controls.Add(this.dtm_aplicacion);
            this.tp_permisos.Controls.Add(this.label8);
            this.tp_permisos.Controls.Add(this.dtm_termina);
            this.tp_permisos.Controls.Add(this.label7);
            this.tp_permisos.Controls.Add(this.cmb_tipo);
            this.tp_permisos.Controls.Add(this.label6);
            this.tp_permisos.Controls.Add(this.txt_duracion);
            this.tp_permisos.Controls.Add(this.label5);
            this.tp_permisos.Controls.Add(this.label4);
            this.tp_permisos.Controls.Add(this.dtm_fecha);
            this.tp_permisos.Controls.Add(this.label3);
            this.tp_permisos.Controls.Add(this.dgv_incapacidades);
            this.tp_permisos.Controls.Add(this.btn_exportar);
            this.tp_permisos.Controls.Add(this.btn_primero);
            this.tp_permisos.Controls.Add(this.btn_cancelar);
            this.tp_permisos.Controls.Add(this.btn_anterior);
            this.tp_permisos.Controls.Add(this.btn_guardar);
            this.tp_permisos.Controls.Add(this.btn_siguiente);
            this.tp_permisos.Controls.Add(this.btn_eliminar);
            this.tp_permisos.Controls.Add(this.btn_ultimo);
            this.tp_permisos.Controls.Add(this.btn_insertar);
            this.tp_permisos.Location = new System.Drawing.Point(4, 22);
            this.tp_permisos.Name = "tp_permisos";
            this.tp_permisos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_permisos.Size = new System.Drawing.Size(796, 410);
            this.tp_permisos.TabIndex = 0;
            this.tp_permisos.Text = "1. Incapacidades";
            this.tp_permisos.UseVisualStyleBackColor = true;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(446, 140);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(13, 13);
            this.lbl_id.TabIndex = 174;
            this.lbl_id.Text = "0";
            // 
            // lbl_inc_caso
            // 
            this.lbl_inc_caso.AutoSize = true;
            this.lbl_inc_caso.Location = new System.Drawing.Point(613, 142);
            this.lbl_inc_caso.Name = "lbl_inc_caso";
            this.lbl_inc_caso.Size = new System.Drawing.Size(42, 13);
            this.lbl_inc_caso.TabIndex = 173;
            this.lbl_inc_caso.Text = "@Caso";
            // 
            // lbl_inc_tipo
            // 
            this.lbl_inc_tipo.AutoSize = true;
            this.lbl_inc_tipo.Location = new System.Drawing.Point(234, 143);
            this.lbl_inc_tipo.Name = "lbl_inc_tipo";
            this.lbl_inc_tipo.Size = new System.Drawing.Size(39, 13);
            this.lbl_inc_tipo.TabIndex = 172;
            this.lbl_inc_tipo.Text = "@Tipo";
            // 
            // txt_certificado
            // 
            this.txt_certificado.Location = new System.Drawing.Point(18, 119);
            this.txt_certificado.Name = "txt_certificado";
            this.txt_certificado.Size = new System.Drawing.Size(135, 20);
            this.txt_certificado.TabIndex = 2;
            this.txt_certificado.Leave += new System.EventHandler(this.Txt_inc_certificado_Leave);
            // 
            // cmb_caso
            // 
            this.cmb_caso.FormattingEnabled = true;
            this.cmb_caso.Items.AddRange(new object[] {
            "Unica",
            "Inicial",
            "Subsecuente",
            "Alta Médica ST2"});
            this.cmb_caso.Location = new System.Drawing.Point(611, 118);
            this.cmb_caso.Name = "cmb_caso";
            this.cmb_caso.Size = new System.Drawing.Size(135, 21);
            this.cmb_caso.TabIndex = 4;
            this.cmb_caso.SelectedIndexChanged += new System.EventHandler(this.Cmb_inc_caso_SelectedIndexChanged);
            this.cmb_caso.TextChanged += new System.EventHandler(this.Cmb_inc_caso_TextChanged);
            this.cmb_caso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_inc_caso_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 171;
            this.label9.Text = "CASO";
            // 
            // dtm_aplicacion
            // 
            this.dtm_aplicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_aplicacion.Location = new System.Drawing.Point(611, 75);
            this.dtm_aplicacion.Name = "dtm_aplicacion";
            this.dtm_aplicacion.Size = new System.Drawing.Size(135, 20);
            this.dtm_aplicacion.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(607, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 169;
            this.label8.Text = "FECHA APLICACION NOMINA";
            // 
            // dtm_termina
            // 
            this.dtm_termina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_termina.Location = new System.Drawing.Point(410, 75);
            this.dtm_termina.Name = "dtm_termina";
            this.dtm_termina.Size = new System.Drawing.Size(135, 20);
            this.dtm_termina.TabIndex = 1;
            this.dtm_termina.ValueChanged += new System.EventHandler(this.Dtm_inc_termina_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 167;
            this.label7.Text = "TERMINA";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Enfermermedad General",
            "Accidente de Trabajo",
            "Accidente de Trayecto",
            "Enfermedad Profesional",
            "Pre Maternidad",
            "Maternidad Enlace",
            "Post Maternidad"});
            this.cmb_tipo.Location = new System.Drawing.Point(233, 118);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(135, 21);
            this.cmb_tipo.TabIndex = 3;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.Cmb_inc_tipo_SelectedIndexChanged);
            this.cmb_tipo.TextChanged += new System.EventHandler(this.Cmb_inc_tipo_TextChanged);
            this.cmb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_inc_tipo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 165;
            this.label6.Text = "TIPO";
            // 
            // txt_duracion
            // 
            this.txt_duracion.Location = new System.Drawing.Point(233, 75);
            this.txt_duracion.MaxLength = 6;
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Size = new System.Drawing.Size(81, 20);
            this.txt_duracion.TabIndex = 1;
            this.txt_duracion.TextChanged += new System.EventHandler(this.Txt_inc_duracion_TextChanged);
            this.txt_duracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_inc_duracion_KeyPress);
            this.txt_duracion.Leave += new System.EventHandler(this.Txt_inc_duracion_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 163;
            this.label5.Text = "DURACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 161;
            this.label4.Text = "CERTIFICADO";
            // 
            // dtm_fecha
            // 
            this.dtm_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_fecha.Location = new System.Drawing.Point(18, 75);
            this.dtm_fecha.Name = "dtm_fecha";
            this.dtm_fecha.Size = new System.Drawing.Size(135, 20);
            this.dtm_fecha.TabIndex = 0;
            this.dtm_fecha.ValueChanged += new System.EventHandler(this.Dtm_inc_inicia_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 159;
            this.label3.Text = "INICIA";
            // 
            // dgv_incapacidades
            // 
            this.dgv_incapacidades.AllowUserToAddRows = false;
            this.dgv_incapacidades.AllowUserToDeleteRows = false;
            this.dgv_incapacidades.AllowUserToResizeColumns = false;
            this.dgv_incapacidades.AllowUserToResizeRows = false;
            this.dgv_incapacidades.BackgroundColor = System.Drawing.Color.White;
            this.dgv_incapacidades.CausesValidation = false;
            this.dgv_incapacidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_incapacidades.Location = new System.Drawing.Point(7, 159);
            this.dgv_incapacidades.MultiSelect = false;
            this.dgv_incapacidades.Name = "dgv_incapacidades";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_incapacidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_incapacidades.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgv_incapacidades.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_incapacidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_incapacidades.ShowCellErrors = false;
            this.dgv_incapacidades.Size = new System.Drawing.Size(780, 245);
            this.dgv_incapacidades.TabIndex = 23;
            this.dgv_incapacidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_incapacidades_CellContentClick);
            this.dgv_incapacidades.CurrentCellChanged += new System.EventHandler(this.Dgv_incapacidades_CurrentCellChanged);
            this.dgv_incapacidades.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_incapacidades_RowEnter);
            this.dgv_incapacidades.DoubleClick += new System.EventHandler(this.Dgv_incapacidades_DoubleClick);
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar.Location = new System.Drawing.Point(347, 6);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(40, 30);
            this.btn_exportar.TabIndex = 152;
            this.btn_exportar.UseVisualStyleBackColor = false;
            this.btn_exportar.Click += new System.EventHandler(this.Btn_inc_exportar_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_primero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_primero.FlatAppearance.BorderSize = 0;
            this.btn_primero.Image = global::CsPresentacion.Properties.Resources.Hide_left_icon;
            this.btn_primero.Location = new System.Drawing.Point(19, 6);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(40, 30);
            this.btn_primero.TabIndex = 158;
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Click += new System.EventHandler(this.Btn_inc_primero_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.Image = global::CsPresentacion.Properties.Resources.delete_icon;
            this.btn_cancelar.Location = new System.Drawing.Point(305, 6);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(40, 30);
            this.btn_cancelar.TabIndex = 151;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_inc_cancelar_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.Image = global::CsPresentacion.Properties.Resources.Navigate_left_icon;
            this.btn_anterior.Location = new System.Drawing.Point(60, 6);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(40, 30);
            this.btn_anterior.TabIndex = 157;
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.Btn_inc_anterior_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.Image = global::CsPresentacion.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btn_guardar.Location = new System.Drawing.Point(264, 6);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(40, 30);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_inc_guardar_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_siguiente.Image = global::CsPresentacion.Properties.Resources.Next;
            this.btn_siguiente.Location = new System.Drawing.Point(101, 6);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(40, 30);
            this.btn_siguiente.TabIndex = 156;
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Click += new System.EventHandler(this.Btn_inc_siguiente_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.Image = global::CsPresentacion.Properties.Resources.math_minus_icon;
            this.btn_eliminar.Location = new System.Drawing.Point(223, 6);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(40, 30);
            this.btn_eliminar.TabIndex = 153;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_inc_eliminar_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ultimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.Image = global::CsPresentacion.Properties.Resources.Hide_right_icon;
            this.btn_ultimo.Location = new System.Drawing.Point(142, 6);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(40, 30);
            this.btn_ultimo.TabIndex = 155;
            this.btn_ultimo.UseVisualStyleBackColor = false;
            this.btn_ultimo.Click += new System.EventHandler(this.Btn_inc_ultimo_Click);
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_insertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insertar.FlatAppearance.BorderSize = 0;
            this.btn_insertar.Image = global::CsPresentacion.Properties.Resources.math_add_icon2;
            this.btn_insertar.Location = new System.Drawing.Point(182, 6);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(40, 30);
            this.btn_insertar.TabIndex = 154;
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.Btn_inc_insertar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_permisos);
            this.tabControl1.Location = new System.Drawing.Point(11, 168);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 436);
            this.tabControl1.TabIndex = 159;
            // 
            // lbl_tipo_falta
            // 
            this.lbl_tipo_falta.AutoSize = true;
            this.lbl_tipo_falta.Location = new System.Drawing.Point(504, 141);
            this.lbl_tipo_falta.Name = "lbl_tipo_falta";
            this.lbl_tipo_falta.Size = new System.Drawing.Size(24, 13);
            this.lbl_tipo_falta.TabIndex = 160;
            this.lbl_tipo_falta.Text = "@F";
            // 
            // Frm_Incapacidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Incapacidades";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incapacidades";
            this.Load += new System.EventHandler(this.Ausentismo_retardos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tp_permisos.ResumeLayout(false);
            this.tp_permisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incapacidades)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nuevo;
        public System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TabPage tp_permisos;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_inc_caso;
        private System.Windows.Forms.Label lbl_inc_tipo;
        private System.Windows.Forms.MaskedTextBox txt_certificado;
        private System.Windows.Forms.ComboBox cmb_caso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtm_aplicacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtm_termina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_duracion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtm_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_incapacidades;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbl_tipo_falta;
    }
}