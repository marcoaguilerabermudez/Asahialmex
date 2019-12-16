namespace CsPresentacion
{
    partial class Frm_Incapacidades_retardos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_inc_exportar = new System.Windows.Forms.Button();
            this.btn_inc_cancelar = new System.Windows.Forms.Button();
            this.btn_inc_guardar = new System.Windows.Forms.Button();
            this.btn_inc_eliminar = new System.Windows.Forms.Button();
            this.btn_inc_insertar = new System.Windows.Forms.Button();
            this.btn_inc_ultimo = new System.Windows.Forms.Button();
            this.btn_inc_siguiente = new System.Windows.Forms.Button();
            this.btn_inc_anterior = new System.Windows.Forms.Button();
            this.btn_inc_primero = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_permisos = new System.Windows.Forms.TabPage();
            this.lbl_inc_tipo = new System.Windows.Forms.Label();
            this.txt_inc_numero = new System.Windows.Forms.MaskedTextBox();
            this.cmb_inc_caso = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtm_inc_fecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtm_inc_termina = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_inc_tipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_inc_duracion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtm_inc_inicia = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_incapacidades = new System.Windows.Forms.DataGridView();
            this.tp_edicion = new System.Windows.Forms.TabPage();
            this.lbl_inc_caso = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incapacidades)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(633, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 111);
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
            // btn_inc_exportar
            // 
            this.btn_inc_exportar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inc_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inc_exportar.FlatAppearance.BorderSize = 0;
            this.btn_inc_exportar.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_inc_exportar.Location = new System.Drawing.Point(347, 6);
            this.btn_inc_exportar.Name = "btn_inc_exportar";
            this.btn_inc_exportar.Size = new System.Drawing.Size(40, 30);
            this.btn_inc_exportar.TabIndex = 152;
            this.btn_inc_exportar.UseVisualStyleBackColor = false;
            this.btn_inc_exportar.Click += new System.EventHandler(this.Btn_inc_exportar_Click);
            // 
            // btn_inc_cancelar
            // 
            this.btn_inc_cancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inc_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inc_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_inc_cancelar.Image = global::CsPresentacion.Properties.Resources.delete_icon;
            this.btn_inc_cancelar.Location = new System.Drawing.Point(305, 6);
            this.btn_inc_cancelar.Name = "btn_inc_cancelar";
            this.btn_inc_cancelar.Size = new System.Drawing.Size(40, 30);
            this.btn_inc_cancelar.TabIndex = 151;
            this.btn_inc_cancelar.UseVisualStyleBackColor = false;
            this.btn_inc_cancelar.Click += new System.EventHandler(this.Btn_inc_cancelar_Click);
            // 
            // btn_inc_guardar
            // 
            this.btn_inc_guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inc_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inc_guardar.FlatAppearance.BorderSize = 0;
            this.btn_inc_guardar.Image = global::CsPresentacion.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btn_inc_guardar.Location = new System.Drawing.Point(264, 6);
            this.btn_inc_guardar.Name = "btn_inc_guardar";
            this.btn_inc_guardar.Size = new System.Drawing.Size(40, 30);
            this.btn_inc_guardar.TabIndex = 150;
            this.btn_inc_guardar.UseVisualStyleBackColor = false;
            // 
            // btn_inc_eliminar
            // 
            this.btn_inc_eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inc_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inc_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_inc_eliminar.Image = global::CsPresentacion.Properties.Resources.math_minus_icon;
            this.btn_inc_eliminar.Location = new System.Drawing.Point(223, 6);
            this.btn_inc_eliminar.Name = "btn_inc_eliminar";
            this.btn_inc_eliminar.Size = new System.Drawing.Size(40, 30);
            this.btn_inc_eliminar.TabIndex = 153;
            this.btn_inc_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_inc_insertar
            // 
            this.btn_inc_insertar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inc_insertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inc_insertar.FlatAppearance.BorderSize = 0;
            this.btn_inc_insertar.Image = global::CsPresentacion.Properties.Resources.math_add_icon2;
            this.btn_inc_insertar.Location = new System.Drawing.Point(183, 6);
            this.btn_inc_insertar.Name = "btn_inc_insertar";
            this.btn_inc_insertar.Size = new System.Drawing.Size(40, 30);
            this.btn_inc_insertar.TabIndex = 154;
            this.btn_inc_insertar.UseVisualStyleBackColor = false;
            // 
            // btn_inc_ultimo
            // 
            this.btn_inc_ultimo.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inc_ultimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inc_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_inc_ultimo.Image = global::CsPresentacion.Properties.Resources.Hide_right_icon;
            this.btn_inc_ultimo.Location = new System.Drawing.Point(142, 6);
            this.btn_inc_ultimo.Name = "btn_inc_ultimo";
            this.btn_inc_ultimo.Size = new System.Drawing.Size(40, 30);
            this.btn_inc_ultimo.TabIndex = 155;
            this.btn_inc_ultimo.UseVisualStyleBackColor = false;
            // 
            // btn_inc_siguiente
            // 
            this.btn_inc_siguiente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inc_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inc_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_inc_siguiente.Image = global::CsPresentacion.Properties.Resources.Next;
            this.btn_inc_siguiente.Location = new System.Drawing.Point(101, 6);
            this.btn_inc_siguiente.Name = "btn_inc_siguiente";
            this.btn_inc_siguiente.Size = new System.Drawing.Size(40, 30);
            this.btn_inc_siguiente.TabIndex = 156;
            this.btn_inc_siguiente.UseVisualStyleBackColor = false;
            // 
            // btn_inc_anterior
            // 
            this.btn_inc_anterior.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inc_anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inc_anterior.FlatAppearance.BorderSize = 0;
            this.btn_inc_anterior.Image = global::CsPresentacion.Properties.Resources.Navigate_left_icon;
            this.btn_inc_anterior.Location = new System.Drawing.Point(60, 6);
            this.btn_inc_anterior.Name = "btn_inc_anterior";
            this.btn_inc_anterior.Size = new System.Drawing.Size(40, 30);
            this.btn_inc_anterior.TabIndex = 157;
            this.btn_inc_anterior.UseVisualStyleBackColor = false;
            // 
            // btn_inc_primero
            // 
            this.btn_inc_primero.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inc_primero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inc_primero.FlatAppearance.BorderSize = 0;
            this.btn_inc_primero.Image = global::CsPresentacion.Properties.Resources.Hide_left_icon;
            this.btn_inc_primero.Location = new System.Drawing.Point(18, 6);
            this.btn_inc_primero.Name = "btn_inc_primero";
            this.btn_inc_primero.Size = new System.Drawing.Size(40, 30);
            this.btn_inc_primero.TabIndex = 158;
            this.btn_inc_primero.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_permisos);
            this.tabControl1.Controls.Add(this.tp_edicion);
            this.tabControl1.Location = new System.Drawing.Point(11, 168);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 436);
            this.tabControl1.TabIndex = 159;
            // 
            // tp_permisos
            // 
            this.tp_permisos.Controls.Add(this.lbl_inc_caso);
            this.tp_permisos.Controls.Add(this.lbl_inc_tipo);
            this.tp_permisos.Controls.Add(this.txt_inc_numero);
            this.tp_permisos.Controls.Add(this.cmb_inc_caso);
            this.tp_permisos.Controls.Add(this.label9);
            this.tp_permisos.Controls.Add(this.dtm_inc_fecha);
            this.tp_permisos.Controls.Add(this.label8);
            this.tp_permisos.Controls.Add(this.dtm_inc_termina);
            this.tp_permisos.Controls.Add(this.label7);
            this.tp_permisos.Controls.Add(this.cmb_inc_tipo);
            this.tp_permisos.Controls.Add(this.label6);
            this.tp_permisos.Controls.Add(this.txt_inc_duracion);
            this.tp_permisos.Controls.Add(this.label5);
            this.tp_permisos.Controls.Add(this.label4);
            this.tp_permisos.Controls.Add(this.dtm_inc_inicia);
            this.tp_permisos.Controls.Add(this.label3);
            this.tp_permisos.Controls.Add(this.dgv_incapacidades);
            this.tp_permisos.Controls.Add(this.btn_inc_exportar);
            this.tp_permisos.Controls.Add(this.btn_inc_primero);
            this.tp_permisos.Controls.Add(this.btn_inc_cancelar);
            this.tp_permisos.Controls.Add(this.btn_inc_anterior);
            this.tp_permisos.Controls.Add(this.btn_inc_guardar);
            this.tp_permisos.Controls.Add(this.btn_inc_siguiente);
            this.tp_permisos.Controls.Add(this.btn_inc_eliminar);
            this.tp_permisos.Controls.Add(this.btn_inc_ultimo);
            this.tp_permisos.Controls.Add(this.btn_inc_insertar);
            this.tp_permisos.Location = new System.Drawing.Point(4, 22);
            this.tp_permisos.Name = "tp_permisos";
            this.tp_permisos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_permisos.Size = new System.Drawing.Size(796, 410);
            this.tp_permisos.TabIndex = 0;
            this.tp_permisos.Text = "1. Incapacidades";
            this.tp_permisos.UseVisualStyleBackColor = true;
            // 
            // lbl_inc_tipo
            // 
            this.lbl_inc_tipo.AutoSize = true;
            this.lbl_inc_tipo.Location = new System.Drawing.Point(241, 143);
            this.lbl_inc_tipo.Name = "lbl_inc_tipo";
            this.lbl_inc_tipo.Size = new System.Drawing.Size(39, 13);
            this.lbl_inc_tipo.TabIndex = 172;
            this.lbl_inc_tipo.Text = "@Tipo";
            // 
            // txt_inc_numero
            // 
            this.txt_inc_numero.Location = new System.Drawing.Point(18, 119);
            this.txt_inc_numero.Name = "txt_inc_numero";
            this.txt_inc_numero.Size = new System.Drawing.Size(135, 20);
            this.txt_inc_numero.TabIndex = 3;
            // 
            // cmb_inc_caso
            // 
            this.cmb_inc_caso.FormattingEnabled = true;
            this.cmb_inc_caso.Items.AddRange(new object[] {
            "Unica",
            "Inicial",
            "Subsecuente",
            "Alta Médica ST2"});
            this.cmb_inc_caso.Location = new System.Drawing.Point(611, 118);
            this.cmb_inc_caso.Name = "cmb_inc_caso";
            this.cmb_inc_caso.Size = new System.Drawing.Size(135, 21);
            this.cmb_inc_caso.TabIndex = 5;
            this.cmb_inc_caso.SelectedIndexChanged += new System.EventHandler(this.Cmb_inc_caso_SelectedIndexChanged);
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
            // dtm_inc_fecha
            // 
            this.dtm_inc_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_inc_fecha.Location = new System.Drawing.Point(611, 75);
            this.dtm_inc_fecha.Name = "dtm_inc_fecha";
            this.dtm_inc_fecha.Size = new System.Drawing.Size(135, 20);
            this.dtm_inc_fecha.TabIndex = 2;
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
            // dtm_inc_termina
            // 
            this.dtm_inc_termina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_inc_termina.Location = new System.Drawing.Point(240, 75);
            this.dtm_inc_termina.Name = "dtm_inc_termina";
            this.dtm_inc_termina.Size = new System.Drawing.Size(135, 20);
            this.dtm_inc_termina.TabIndex = 1;
            this.dtm_inc_termina.ValueChanged += new System.EventHandler(this.Dtm_inc_termina_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 167;
            this.label7.Text = "TERMINA";
            // 
            // cmb_inc_tipo
            // 
            this.cmb_inc_tipo.FormattingEnabled = true;
            this.cmb_inc_tipo.Items.AddRange(new object[] {
            "Enfermermedad General",
            "Accidente de Trabajo",
            "Accidente de Trayecto",
            "Enfermedad Profesional",
            "Pre Maternidad",
            "Maternidad Enlace",
            "Post Maternidad"});
            this.cmb_inc_tipo.Location = new System.Drawing.Point(240, 118);
            this.cmb_inc_tipo.Name = "cmb_inc_tipo";
            this.cmb_inc_tipo.Size = new System.Drawing.Size(135, 21);
            this.cmb_inc_tipo.TabIndex = 4;
            this.cmb_inc_tipo.SelectedIndexChanged += new System.EventHandler(this.Cmb_inc_tipo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 165;
            this.label6.Text = "TIPO";
            // 
            // txt_inc_duracion
            // 
            this.txt_inc_duracion.Location = new System.Drawing.Point(449, 75);
            this.txt_inc_duracion.Name = "txt_inc_duracion";
            this.txt_inc_duracion.Size = new System.Drawing.Size(71, 20);
            this.txt_inc_duracion.TabIndex = 164;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 57);
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
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 161;
            this.label4.Text = "NUMERO";
            // 
            // dtm_inc_inicia
            // 
            this.dtm_inc_inicia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_inc_inicia.Location = new System.Drawing.Point(18, 75);
            this.dtm_inc_inicia.Name = "dtm_inc_inicia";
            this.dtm_inc_inicia.Size = new System.Drawing.Size(135, 20);
            this.dtm_inc_inicia.TabIndex = 0;
            this.dtm_inc_inicia.ValueChanged += new System.EventHandler(this.Dtm_inc_inicia_ValueChanged);
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_incapacidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_incapacidades.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            this.dgv_incapacidades.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_incapacidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_incapacidades.ShowCellErrors = false;
            this.dgv_incapacidades.Size = new System.Drawing.Size(780, 245);
            this.dgv_incapacidades.TabIndex = 23;
            // 
            // tp_edicion
            // 
            this.tp_edicion.Location = new System.Drawing.Point(4, 22);
            this.tp_edicion.Name = "tp_edicion";
            this.tp_edicion.Padding = new System.Windows.Forms.Padding(3);
            this.tp_edicion.Size = new System.Drawing.Size(796, 410);
            this.tp_edicion.TabIndex = 1;
            this.tp_edicion.Text = "2. Retardos";
            this.tp_edicion.UseVisualStyleBackColor = true;
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
            // Frm_Incapacidades_retardos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 626);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Incapacidades_retardos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incapacidades y Retardos";
            this.Load += new System.EventHandler(this.Ausentismo_retardos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tp_permisos.ResumeLayout(false);
            this.tp_permisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incapacidades)).EndInit();
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
        private System.Windows.Forms.Button btn_inc_exportar;
        private System.Windows.Forms.Button btn_inc_cancelar;
        private System.Windows.Forms.Button btn_inc_guardar;
        private System.Windows.Forms.Button btn_inc_eliminar;
        private System.Windows.Forms.Button btn_inc_insertar;
        private System.Windows.Forms.Button btn_inc_ultimo;
        private System.Windows.Forms.Button btn_inc_siguiente;
        private System.Windows.Forms.Button btn_inc_anterior;
        private System.Windows.Forms.Button btn_inc_primero;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_permisos;
        private System.Windows.Forms.DataGridView dgv_incapacidades;
        private System.Windows.Forms.TabPage tp_edicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtm_inc_termina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_inc_tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_inc_duracion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtm_inc_inicia;
        private System.Windows.Forms.ComboBox cmb_inc_caso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtm_inc_fecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txt_inc_numero;
        private System.Windows.Forms.Label lbl_inc_tipo;
        private System.Windows.Forms.Label lbl_inc_caso;
    }
}