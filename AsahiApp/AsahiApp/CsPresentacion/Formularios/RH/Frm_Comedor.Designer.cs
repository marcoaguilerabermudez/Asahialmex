namespace CsPresentacion
{
    partial class Frm_Comedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_permisos = new System.Windows.Forms.TabPage();
            this.lbl_tipo_falta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.dtm_com_fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_comedor = new System.Windows.Forms.DataGridView();
            this.btn_com_exportar = new System.Windows.Forms.Button();
            this.btn_com_primero = new System.Windows.Forms.Button();
            this.btn_com_cancelar = new System.Windows.Forms.Button();
            this.btn_com_anterior = new System.Windows.Forms.Button();
            this.btn_com_guardar = new System.Windows.Forms.Button();
            this.btn_com_siguiente = new System.Windows.Forms.Button();
            this.btn_com_eliminar = new System.Windows.Forms.Button();
            this.btn_com_ultimo = new System.Windows.Forms.Button();
            this.btn_com_agregar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tp_permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comedor)).BeginInit();
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
            this.panel1.TabIndex = 145;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_estado);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 73);
            this.groupBox2.TabIndex = 150;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(633, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 151;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_permisos);
            this.tabControl1.Location = new System.Drawing.Point(11, 168);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 436);
            this.tabControl1.TabIndex = 160;
            // 
            // tp_permisos
            // 
            this.tp_permisos.Controls.Add(this.lbl_tipo_falta);
            this.tp_permisos.Controls.Add(this.label6);
            this.tp_permisos.Controls.Add(this.cmb_tipo);
            this.tp_permisos.Controls.Add(this.label5);
            this.tp_permisos.Controls.Add(this.txt_costo);
            this.tp_permisos.Controls.Add(this.label4);
            this.tp_permisos.Controls.Add(this.txt_hora);
            this.tp_permisos.Controls.Add(this.dtm_com_fecha);
            this.tp_permisos.Controls.Add(this.label3);
            this.tp_permisos.Controls.Add(this.dgv_comedor);
            this.tp_permisos.Controls.Add(this.btn_com_exportar);
            this.tp_permisos.Controls.Add(this.btn_com_primero);
            this.tp_permisos.Controls.Add(this.btn_com_cancelar);
            this.tp_permisos.Controls.Add(this.btn_com_anterior);
            this.tp_permisos.Controls.Add(this.btn_com_guardar);
            this.tp_permisos.Controls.Add(this.btn_com_siguiente);
            this.tp_permisos.Controls.Add(this.btn_com_eliminar);
            this.tp_permisos.Controls.Add(this.btn_com_ultimo);
            this.tp_permisos.Controls.Add(this.btn_com_agregar);
            this.tp_permisos.Location = new System.Drawing.Point(4, 22);
            this.tp_permisos.Name = "tp_permisos";
            this.tp_permisos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_permisos.Size = new System.Drawing.Size(796, 410);
            this.tp_permisos.TabIndex = 0;
            this.tp_permisos.Text = "1. Catálogo";
            this.tp_permisos.UseVisualStyleBackColor = true;
            // 
            // lbl_tipo_falta
            // 
            this.lbl_tipo_falta.AutoSize = true;
            this.lbl_tipo_falta.Location = new System.Drawing.Point(675, 78);
            this.lbl_tipo_falta.Name = "lbl_tipo_falta";
            this.lbl_tipo_falta.Size = new System.Drawing.Size(41, 13);
            this.lbl_tipo_falta.TabIndex = 161;
            this.lbl_tipo_falta.Text = "@Falta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 165;
            this.label6.Text = "TIPO";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "JAPONES",
            "MEXICANO"});
            this.cmb_tipo.Location = new System.Drawing.Point(526, 75);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo.TabIndex = 1;
            this.cmb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 163;
            this.label5.Text = "COSTO";
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(372, 75);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(100, 20);
            this.txt_costo.TabIndex = 162;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 161;
            this.label4.Text = "HORA";
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(215, 75);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(100, 20);
            this.txt_hora.TabIndex = 160;
            // 
            // dtm_com_fecha
            // 
            this.dtm_com_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_com_fecha.Location = new System.Drawing.Point(18, 75);
            this.dtm_com_fecha.Name = "dtm_com_fecha";
            this.dtm_com_fecha.Size = new System.Drawing.Size(135, 20);
            this.dtm_com_fecha.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 159;
            this.label3.Text = "FECHA";
            // 
            // dgv_comedor
            // 
            this.dgv_comedor.AllowUserToAddRows = false;
            this.dgv_comedor.AllowUserToDeleteRows = false;
            this.dgv_comedor.AllowUserToResizeColumns = false;
            this.dgv_comedor.AllowUserToResizeRows = false;
            this.dgv_comedor.BackgroundColor = System.Drawing.Color.White;
            this.dgv_comedor.CausesValidation = false;
            this.dgv_comedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_comedor.Location = new System.Drawing.Point(7, 118);
            this.dgv_comedor.MultiSelect = false;
            this.dgv_comedor.Name = "dgv_comedor";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_comedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_comedor.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgv_comedor.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_comedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_comedor.ShowCellErrors = false;
            this.dgv_comedor.Size = new System.Drawing.Size(780, 286);
            this.dgv_comedor.TabIndex = 23;
            this.dgv_comedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_comedor_CellContentClick);
            this.dgv_comedor.CurrentCellChanged += new System.EventHandler(this.Dgv_comedor_CurrentCellChanged);
            this.dgv_comedor.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_comedor_RowEnter);
            // 
            // btn_com_exportar
            // 
            this.btn_com_exportar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_com_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_com_exportar.FlatAppearance.BorderSize = 0;
            this.btn_com_exportar.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_com_exportar.Location = new System.Drawing.Point(347, 6);
            this.btn_com_exportar.Name = "btn_com_exportar";
            this.btn_com_exportar.Size = new System.Drawing.Size(40, 30);
            this.btn_com_exportar.TabIndex = 152;
            this.btn_com_exportar.UseVisualStyleBackColor = false;
            this.btn_com_exportar.Click += new System.EventHandler(this.Btn_com_exportar_Click);
            // 
            // btn_com_primero
            // 
            this.btn_com_primero.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_com_primero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_com_primero.FlatAppearance.BorderSize = 0;
            this.btn_com_primero.Image = global::CsPresentacion.Properties.Resources.Hide_left_icon;
            this.btn_com_primero.Location = new System.Drawing.Point(19, 6);
            this.btn_com_primero.Name = "btn_com_primero";
            this.btn_com_primero.Size = new System.Drawing.Size(40, 30);
            this.btn_com_primero.TabIndex = 158;
            this.btn_com_primero.UseVisualStyleBackColor = false;
            this.btn_com_primero.Click += new System.EventHandler(this.Btn_com_primero_Click);
            // 
            // btn_com_cancelar
            // 
            this.btn_com_cancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_com_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_com_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_com_cancelar.Image = global::CsPresentacion.Properties.Resources.delete_icon;
            this.btn_com_cancelar.Location = new System.Drawing.Point(305, 6);
            this.btn_com_cancelar.Name = "btn_com_cancelar";
            this.btn_com_cancelar.Size = new System.Drawing.Size(40, 30);
            this.btn_com_cancelar.TabIndex = 151;
            this.btn_com_cancelar.UseVisualStyleBackColor = false;
            this.btn_com_cancelar.Click += new System.EventHandler(this.Btn_com_cancelar_Click);
            // 
            // btn_com_anterior
            // 
            this.btn_com_anterior.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_com_anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_com_anterior.FlatAppearance.BorderSize = 0;
            this.btn_com_anterior.Image = global::CsPresentacion.Properties.Resources.Navigate_left_icon;
            this.btn_com_anterior.Location = new System.Drawing.Point(60, 6);
            this.btn_com_anterior.Name = "btn_com_anterior";
            this.btn_com_anterior.Size = new System.Drawing.Size(40, 30);
            this.btn_com_anterior.TabIndex = 157;
            this.btn_com_anterior.UseVisualStyleBackColor = false;
            this.btn_com_anterior.Click += new System.EventHandler(this.Btn_com_anterior_Click);
            // 
            // btn_com_guardar
            // 
            this.btn_com_guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_com_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_com_guardar.FlatAppearance.BorderSize = 0;
            this.btn_com_guardar.Image = global::CsPresentacion.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btn_com_guardar.Location = new System.Drawing.Point(264, 6);
            this.btn_com_guardar.Name = "btn_com_guardar";
            this.btn_com_guardar.Size = new System.Drawing.Size(40, 30);
            this.btn_com_guardar.TabIndex = 2;
            this.btn_com_guardar.UseVisualStyleBackColor = false;
            this.btn_com_guardar.Click += new System.EventHandler(this.Btn_com_guardar_Click);
            // 
            // btn_com_siguiente
            // 
            this.btn_com_siguiente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_com_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_com_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_com_siguiente.Image = global::CsPresentacion.Properties.Resources.Next;
            this.btn_com_siguiente.Location = new System.Drawing.Point(101, 6);
            this.btn_com_siguiente.Name = "btn_com_siguiente";
            this.btn_com_siguiente.Size = new System.Drawing.Size(40, 30);
            this.btn_com_siguiente.TabIndex = 156;
            this.btn_com_siguiente.UseVisualStyleBackColor = false;
            this.btn_com_siguiente.Click += new System.EventHandler(this.Btn_com_siguiente_Click);
            // 
            // btn_com_eliminar
            // 
            this.btn_com_eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_com_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_com_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_com_eliminar.Image = global::CsPresentacion.Properties.Resources.math_minus_icon;
            this.btn_com_eliminar.Location = new System.Drawing.Point(223, 6);
            this.btn_com_eliminar.Name = "btn_com_eliminar";
            this.btn_com_eliminar.Size = new System.Drawing.Size(40, 30);
            this.btn_com_eliminar.TabIndex = 153;
            this.btn_com_eliminar.UseVisualStyleBackColor = false;
            this.btn_com_eliminar.Click += new System.EventHandler(this.Btn_com_eliminar_Click);
            // 
            // btn_com_ultimo
            // 
            this.btn_com_ultimo.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_com_ultimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_com_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_com_ultimo.Image = global::CsPresentacion.Properties.Resources.Hide_right_icon;
            this.btn_com_ultimo.Location = new System.Drawing.Point(142, 6);
            this.btn_com_ultimo.Name = "btn_com_ultimo";
            this.btn_com_ultimo.Size = new System.Drawing.Size(40, 30);
            this.btn_com_ultimo.TabIndex = 155;
            this.btn_com_ultimo.UseVisualStyleBackColor = false;
            this.btn_com_ultimo.Click += new System.EventHandler(this.Btn_com_ultimo_Click);
            // 
            // btn_com_agregar
            // 
            this.btn_com_agregar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_com_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_com_agregar.FlatAppearance.BorderSize = 0;
            this.btn_com_agregar.Image = global::CsPresentacion.Properties.Resources.math_add_icon2;
            this.btn_com_agregar.Location = new System.Drawing.Point(182, 6);
            this.btn_com_agregar.Name = "btn_com_agregar";
            this.btn_com_agregar.Size = new System.Drawing.Size(40, 30);
            this.btn_com_agregar.TabIndex = 154;
            this.btn_com_agregar.UseVisualStyleBackColor = false;
            this.btn_com_agregar.Click += new System.EventHandler(this.Btn_com_insertar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Frm_Comedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Comedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kardex Comedor";
            this.Load += new System.EventHandler(this.Frm_Comedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tp_permisos.ResumeLayout(false);
            this.tp_permisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_permisos;
        private System.Windows.Forms.DateTimePicker dtm_com_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_comedor;
        private System.Windows.Forms.Button btn_com_exportar;
        private System.Windows.Forms.Button btn_com_primero;
        private System.Windows.Forms.Button btn_com_cancelar;
        private System.Windows.Forms.Button btn_com_anterior;
        private System.Windows.Forms.Button btn_com_guardar;
        private System.Windows.Forms.Button btn_com_siguiente;
        private System.Windows.Forms.Button btn_com_eliminar;
        private System.Windows.Forms.Button btn_com_ultimo;
        private System.Windows.Forms.Button btn_com_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label lbl_tipo_falta;
        private System.Windows.Forms.Timer timer1;
    }
}