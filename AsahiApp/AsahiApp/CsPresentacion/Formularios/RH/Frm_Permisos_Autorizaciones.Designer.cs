namespace CsPresentacion
{
    partial class Permisos_Autorizaciones
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tp_edicion = new System.Windows.Forms.TabPage();
            this.lbl_mod = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_f = new System.Windows.Forms.RadioButton();
            this.rdb_dt = new System.Windows.Forms.RadioButton();
            this.rdb_pd = new System.Windows.Forms.RadioButton();
            this.rdb_bh = new System.Windows.Forms.RadioButton();
            this.rdb_p = new System.Windows.Forms.RadioButton();
            this.rdb_r = new System.Windows.Forms.RadioButton();
            this.rdb_h = new System.Windows.Forms.RadioButton();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_tipo_permiso = new System.Windows.Forms.TextBox();
            this.txt_autorizado = new System.Windows.Forms.TextBox();
            this.txt_unidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtm_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tp_permisos = new System.Windows.Forms.TabPage();
            this.dgv_permisos = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tp_edicion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tp_permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_permisos)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLAVE";
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(15, 24);
            this.txt_clave.MaxLength = 8;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(100, 20);
            this.txt_clave.TabIndex = 0;
            this.txt_clave.TextChanged += new System.EventHandler(this.Txt_clave_TextChanged);
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_clave_KeyPress);
            this.txt_clave.Leave += new System.EventHandler(this.Txt_clave_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(-2, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 69);
            this.panel1.TabIndex = 143;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(121, 40);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 27;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "NOMBRE:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(20, 86);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(457, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombre_KeyPress);
            this.txt_nombre.Leave += new System.EventHandler(this.Txt_nombre_Leave);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(20, 113);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(57, 13);
            this.lbl_estado.TabIndex = 144;
            this.lbl_estado.Text = "ESTADO";
            this.lbl_estado.TextChanged += new System.EventHandler(this.Lbl_estado_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 73);
            this.groupBox2.TabIndex = 145;
            this.groupBox2.TabStop = false;
            // 
            // tp_edicion
            // 
            this.tp_edicion.Controls.Add(this.lbl_mod);
            this.tp_edicion.Controls.Add(this.lbl_tipo);
            this.tp_edicion.Controls.Add(this.groupBox1);
            this.tp_edicion.Controls.Add(this.txt_descripcion);
            this.tp_edicion.Controls.Add(this.txt_tipo_permiso);
            this.tp_edicion.Controls.Add(this.txt_autorizado);
            this.tp_edicion.Controls.Add(this.txt_unidad);
            this.tp_edicion.Controls.Add(this.label9);
            this.tp_edicion.Controls.Add(this.label8);
            this.tp_edicion.Controls.Add(this.label7);
            this.tp_edicion.Controls.Add(this.label6);
            this.tp_edicion.Controls.Add(this.label5);
            this.tp_edicion.Controls.Add(this.dtm_fecha);
            this.tp_edicion.Controls.Add(this.label4);
            this.tp_edicion.Location = new System.Drawing.Point(4, 22);
            this.tp_edicion.Name = "tp_edicion";
            this.tp_edicion.Padding = new System.Windows.Forms.Padding(3);
            this.tp_edicion.Size = new System.Drawing.Size(796, 365);
            this.tp_edicion.TabIndex = 1;
            this.tp_edicion.Text = "2. Edición";
            this.tp_edicion.UseVisualStyleBackColor = true;
            // 
            // lbl_mod
            // 
            this.lbl_mod.AutoSize = true;
            this.lbl_mod.Location = new System.Drawing.Point(116, 314);
            this.lbl_mod.Name = "lbl_mod";
            this.lbl_mod.Size = new System.Drawing.Size(39, 13);
            this.lbl_mod.TabIndex = 149;
            this.lbl_mod.Text = "@Mod";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(28, 314);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(39, 13);
            this.lbl_tipo.TabIndex = 148;
            this.lbl_tipo.Text = "@Tipo";
            this.lbl_tipo.TextChanged += new System.EventHandler(this.Lbl_tipo_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_f);
            this.groupBox1.Controls.Add(this.rdb_dt);
            this.groupBox1.Controls.Add(this.rdb_pd);
            this.groupBox1.Controls.Add(this.rdb_bh);
            this.groupBox1.Controls.Add(this.rdb_p);
            this.groupBox1.Controls.Add(this.rdb_r);
            this.groupBox1.Controls.Add(this.rdb_h);
            this.groupBox1.Location = new System.Drawing.Point(307, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 136);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            // 
            // rdb_f
            // 
            this.rdb_f.AutoSize = true;
            this.rdb_f.Location = new System.Drawing.Point(217, 73);
            this.rdb_f.Name = "rdb_f";
            this.rdb_f.Size = new System.Drawing.Size(120, 17);
            this.rdb_f.TabIndex = 20;
            this.rdb_f.TabStop = true;
            this.rdb_f.Text = "Festivos Trabajados";
            this.rdb_f.UseVisualStyleBackColor = true;
            this.rdb_f.CheckedChanged += new System.EventHandler(this.Rdb_f_CheckedChanged);
            // 
            // rdb_dt
            // 
            this.rdb_dt.AutoSize = true;
            this.rdb_dt.Location = new System.Drawing.Point(217, 46);
            this.rdb_dt.Name = "rdb_dt";
            this.rdb_dt.Size = new System.Drawing.Size(134, 17);
            this.rdb_dt.TabIndex = 19;
            this.rdb_dt.TabStop = true;
            this.rdb_dt.Text = "Descansos Trabajados";
            this.rdb_dt.UseVisualStyleBackColor = true;
            this.rdb_dt.CheckedChanged += new System.EventHandler(this.Rdb_dt_CheckedChanged);
            // 
            // rdb_pd
            // 
            this.rdb_pd.AutoSize = true;
            this.rdb_pd.Location = new System.Drawing.Point(217, 18);
            this.rdb_pd.Name = "rdb_pd";
            this.rdb_pd.Size = new System.Drawing.Size(116, 17);
            this.rdb_pd.TabIndex = 18;
            this.rdb_pd.TabStop = true;
            this.rdb_pd.Text = "Primas Dominicales";
            this.rdb_pd.UseVisualStyleBackColor = true;
            this.rdb_pd.CheckedChanged += new System.EventHandler(this.Rdb_pd_CheckedChanged);
            // 
            // rdb_bh
            // 
            this.rdb_bh.AutoSize = true;
            this.rdb_bh.Location = new System.Drawing.Point(14, 102);
            this.rdb_bh.Name = "rdb_bh";
            this.rdb_bh.Size = new System.Drawing.Size(148, 17);
            this.rdb_bh.TabIndex = 17;
            this.rdb_bh.TabStop = true;
            this.rdb_bh.Text = "Permiso (Banco de Horas)";
            this.rdb_bh.UseVisualStyleBackColor = true;
            this.rdb_bh.CheckedChanged += new System.EventHandler(this.Rdb_bh_CheckedChanged);
            // 
            // rdb_p
            // 
            this.rdb_p.AutoSize = true;
            this.rdb_p.Location = new System.Drawing.Point(14, 74);
            this.rdb_p.Name = "rdb_p";
            this.rdb_p.Size = new System.Drawing.Size(153, 17);
            this.rdb_p.TabIndex = 16;
            this.rdb_p.TabStop = true;
            this.rdb_p.Text = "Permiso (Salida Anticipada)";
            this.rdb_p.UseVisualStyleBackColor = true;
            this.rdb_p.CheckedChanged += new System.EventHandler(this.Rdb_p_CheckedChanged);
            // 
            // rdb_r
            // 
            this.rdb_r.AutoSize = true;
            this.rdb_r.Location = new System.Drawing.Point(14, 47);
            this.rdb_r.Name = "rdb_r";
            this.rdb_r.Size = new System.Drawing.Size(68, 17);
            this.rdb_r.TabIndex = 15;
            this.rdb_r.TabStop = true;
            this.rdb_r.Text = "Retardos";
            this.rdb_r.UseVisualStyleBackColor = true;
            this.rdb_r.CheckedChanged += new System.EventHandler(this.Rdb_r_CheckedChanged);
            // 
            // rdb_h
            // 
            this.rdb_h.AutoSize = true;
            this.rdb_h.Location = new System.Drawing.Point(14, 18);
            this.rdb_h.Name = "rdb_h";
            this.rdb_h.Size = new System.Drawing.Size(85, 17);
            this.rdb_h.TabIndex = 5;
            this.rdb_h.TabStop = true;
            this.rdb_h.Text = "Horas Extras";
            this.rdb_h.UseVisualStyleBackColor = true;
            this.rdb_h.CheckedChanged += new System.EventHandler(this.Rdb_h_CheckedChanged);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(216, 236);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(469, 20);
            this.txt_descripcion.TabIndex = 70;
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_descripcion_KeyPress);
            // 
            // txt_tipo_permiso
            // 
            this.txt_tipo_permiso.Location = new System.Drawing.Point(23, 236);
            this.txt_tipo_permiso.MaxLength = 2;
            this.txt_tipo_permiso.Name = "txt_tipo_permiso";
            this.txt_tipo_permiso.Size = new System.Drawing.Size(144, 20);
            this.txt_tipo_permiso.TabIndex = 4;
            this.txt_tipo_permiso.TextChanged += new System.EventHandler(this.Txt_tipo_permiso_TextChanged_1);
            this.txt_tipo_permiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_tipo_permiso_KeyPress_1);
            // 
            // txt_autorizado
            // 
            this.txt_autorizado.Location = new System.Drawing.Point(23, 151);
            this.txt_autorizado.MaxLength = 4;
            this.txt_autorizado.Name = "txt_autorizado";
            this.txt_autorizado.Size = new System.Drawing.Size(144, 20);
            this.txt_autorizado.TabIndex = 3;
            this.txt_autorizado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_autorizado_KeyPress_1);
            this.txt_autorizado.Leave += new System.EventHandler(this.Txt_autorizado_Leave);
            // 
            // txt_unidad
            // 
            this.txt_unidad.Location = new System.Drawing.Point(23, 109);
            this.txt_unidad.MaxLength = 4;
            this.txt_unidad.Name = "txt_unidad";
            this.txt_unidad.Size = new System.Drawing.Size(144, 20);
            this.txt_unidad.TabIndex = 2;
            this.txt_unidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_unidad_KeyPress);
            this.txt_unidad.Leave += new System.EventHandler(this.Txt_unidad_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "TIPO DE PERMISO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Minutos (60 = 1 Hora)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Minutos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "AUTORIZADO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "UNIDAD:";
            // 
            // dtm_fecha
            // 
            this.dtm_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_fecha.Location = new System.Drawing.Point(23, 45);
            this.dtm_fecha.Name = "dtm_fecha";
            this.dtm_fecha.Size = new System.Drawing.Size(144, 20);
            this.dtm_fecha.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "FECHA:";
            // 
            // tp_permisos
            // 
            this.tp_permisos.Controls.Add(this.dgv_permisos);
            this.tp_permisos.Location = new System.Drawing.Point(4, 22);
            this.tp_permisos.Name = "tp_permisos";
            this.tp_permisos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_permisos.Size = new System.Drawing.Size(796, 365);
            this.tp_permisos.TabIndex = 0;
            this.tp_permisos.Text = "1. Permisos y Autorizaciones";
            this.tp_permisos.UseVisualStyleBackColor = true;
            // 
            // dgv_permisos
            // 
            this.dgv_permisos.AllowUserToAddRows = false;
            this.dgv_permisos.AllowUserToDeleteRows = false;
            this.dgv_permisos.AllowUserToResizeColumns = false;
            this.dgv_permisos.AllowUserToResizeRows = false;
            this.dgv_permisos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_permisos.CausesValidation = false;
            this.dgv_permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_permisos.Location = new System.Drawing.Point(6, 20);
            this.dgv_permisos.MultiSelect = false;
            this.dgv_permisos.Name = "dgv_permisos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_permisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_permisos.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgv_permisos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_permisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_permisos.ShowCellErrors = false;
            this.dgv_permisos.Size = new System.Drawing.Size(780, 334);
            this.dgv_permisos.TabIndex = 23;
            this.dgv_permisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_permisos_CellContentClick);
            this.dgv_permisos.CurrentCellChanged += new System.EventHandler(this.Dgv_permisos_CurrentCellChanged);
            this.dgv_permisos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_permisos_RowEnter);
            this.dgv_permisos.DoubleClick += new System.EventHandler(this.Dgv_permisos_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_permisos);
            this.tabControl1.Controls.Add(this.tp_edicion);
            this.tabControl1.Location = new System.Drawing.Point(15, 196);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 391);
            this.tabControl1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(645, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar.Location = new System.Drawing.Point(346, 154);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(40, 30);
            this.btn_exportar.TabIndex = 8;
            this.btn_exportar.UseVisualStyleBackColor = false;
            this.btn_exportar.Click += new System.EventHandler(this.Btn_exportar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.Image = global::CsPresentacion.Properties.Resources.delete_icon;
            this.btn_cancelar.Location = new System.Drawing.Point(304, 154);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(40, 30);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.Image = global::CsPresentacion.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btn_guardar.Location = new System.Drawing.Point(263, 154);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(40, 30);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_gurdar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.Image = global::CsPresentacion.Properties.Resources.math_minus_icon;
            this.btn_eliminar.Location = new System.Drawing.Point(222, 154);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(40, 30);
            this.btn_eliminar.TabIndex = 9;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_insertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insertar.FlatAppearance.BorderSize = 0;
            this.btn_insertar.Image = global::CsPresentacion.Properties.Resources.math_add_icon2;
            this.btn_insertar.Location = new System.Drawing.Point(182, 154);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(40, 30);
            this.btn_insertar.TabIndex = 10;
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.Btn_insertar_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ultimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.Image = global::CsPresentacion.Properties.Resources.Hide_right_icon;
            this.btn_ultimo.Location = new System.Drawing.Point(141, 154);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(40, 30);
            this.btn_ultimo.TabIndex = 11;
            this.btn_ultimo.UseVisualStyleBackColor = false;
            this.btn_ultimo.Click += new System.EventHandler(this.Btn_ultimo_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_siguiente.Image = global::CsPresentacion.Properties.Resources.Next;
            this.btn_siguiente.Location = new System.Drawing.Point(100, 154);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(40, 30);
            this.btn_siguiente.TabIndex = 12;
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Click += new System.EventHandler(this.Btn_siguiente_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.Image = global::CsPresentacion.Properties.Resources.Navigate_left_icon;
            this.btn_anterior.Location = new System.Drawing.Point(59, 154);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(40, 30);
            this.btn_anterior.TabIndex = 13;
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.Btn_anterior_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_primero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_primero.FlatAppearance.BorderSize = 0;
            this.btn_primero.Image = global::CsPresentacion.Properties.Resources.Hide_left_icon;
            this.btn_primero.Location = new System.Drawing.Point(17, 154);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(40, 30);
            this.btn_primero.TabIndex = 14;
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Click += new System.EventHandler(this.Btn_primero_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Permisos_Autorizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_primero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Permisos_Autorizaciones";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos y Autorizaciones";
            this.Load += new System.EventHandler(this.Permisos_Autorizaciones_Load);
            this.panel1.ResumeLayout(false);
            this.tp_edicion.ResumeLayout(false);
            this.tp_edicion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tp_permisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_permisos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.TabPage tp_edicion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_f;
        private System.Windows.Forms.RadioButton rdb_dt;
        private System.Windows.Forms.RadioButton rdb_pd;
        private System.Windows.Forms.RadioButton rdb_bh;
        private System.Windows.Forms.RadioButton rdb_p;
        private System.Windows.Forms.RadioButton rdb_r;
        private System.Windows.Forms.RadioButton rdb_h;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_autorizado;
        private System.Windows.Forms.TextBox txt_unidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tp_permisos;
        private System.Windows.Forms.DataGridView dgv_permisos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_tipo;
        public System.Windows.Forms.TextBox txt_tipo_permiso;
        public System.Windows.Forms.DateTimePicker dtm_fecha;
        public System.Windows.Forms.Label lbl_mod;
        private System.Windows.Forms.Timer timer1;
    }
}