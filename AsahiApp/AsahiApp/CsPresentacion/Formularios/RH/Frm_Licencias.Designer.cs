namespace CsPresentacion
{
    partial class Frm_Licencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.dgv_credenciales = new System.Windows.Forms.DataGridView();
            this.txt_imss = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_vigencia = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_puesto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credenciales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_clave);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 55);
            this.panel1.TabIndex = 168;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "EMPLEADO:";
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(22, 29);
            this.txt_clave.MaxLength = 5;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(84, 20);
            this.txt_clave.TabIndex = 0;
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave_KeyPress);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(111, 27);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(18, 23);
            this.btn_nuevo.TabIndex = 147;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(17, 553);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(32, 13);
            this.lbl_id.TabIndex = 238;
            this.lbl_id.Text = "@ID:";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Image = global::CsPresentacion.Properties.Resources.Recycle_Bin_full_icon2;
            this.btn_eliminar.Location = new System.Drawing.Point(463, 545);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(39, 29);
            this.btn_eliminar.TabIndex = 237;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.Location = new System.Drawing.Point(449, 335);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(91, 34);
            this.btn_agregar.TabIndex = 236;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Image = global::CsPresentacion.Properties.Resources.Adobe_PDF_Document_icon;
            this.btn_reporte.Location = new System.Drawing.Point(525, 545);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(39, 29);
            this.btn_reporte.TabIndex = 235;
            this.btn_reporte.UseVisualStyleBackColor = true;
            // 
            // dgv_credenciales
            // 
            this.dgv_credenciales.AllowUserToAddRows = false;
            this.dgv_credenciales.AllowUserToDeleteRows = false;
            this.dgv_credenciales.AllowUserToResizeColumns = false;
            this.dgv_credenciales.AllowUserToResizeRows = false;
            this.dgv_credenciales.BackgroundColor = System.Drawing.Color.White;
            this.dgv_credenciales.CausesValidation = false;
            this.dgv_credenciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_credenciales.Location = new System.Drawing.Point(12, 389);
            this.dgv_credenciales.MultiSelect = false;
            this.dgv_credenciales.Name = "dgv_credenciales";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_credenciales.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_credenciales.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgv_credenciales.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_credenciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_credenciales.ShowCellErrors = false;
            this.dgv_credenciales.Size = new System.Drawing.Size(553, 154);
            this.dgv_credenciales.TabIndex = 234;
            // 
            // txt_imss
            // 
            this.txt_imss.Location = new System.Drawing.Point(20, 178);
            this.txt_imss.MaxLength = 12;
            this.txt_imss.Name = "txt_imss";
            this.txt_imss.Size = new System.Drawing.Size(166, 20);
            this.txt_imss.TabIndex = 215;
            this.txt_imss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_imss_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 231;
            this.label6.Text = "IMSS";
            // 
            // txt_vigencia
            // 
            this.txt_vigencia.Location = new System.Drawing.Point(430, 210);
            this.txt_vigencia.Name = "txt_vigencia";
            this.txt_vigencia.Size = new System.Drawing.Size(130, 20);
            this.txt_vigencia.TabIndex = 230;
            this.txt_vigencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_vigencia.TextChanged += new System.EventHandler(this.txt_vigencia_TextChanged);
            this.txt_vigencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vigencia_KeyPress);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(468, 193);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(54, 13);
            this.lbl_estado.TabIndex = 229;
            this.lbl_estado.Text = "ESTADO:";
            // 
            // txt_departamento
            // 
            this.txt_departamento.Location = new System.Drawing.Point(20, 220);
            this.txt_departamento.MaxLength = 30;
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.Size = new System.Drawing.Size(166, 20);
            this.txt_departamento.TabIndex = 216;
            this.txt_departamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_departamento_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 224;
            this.label15.Text = "DEPARTAMENTO:";
            // 
            // txt_puesto
            // 
            this.txt_puesto.Location = new System.Drawing.Point(20, 137);
            this.txt_puesto.MaxLength = 70;
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.Size = new System.Drawing.Size(325, 20);
            this.txt_puesto.TabIndex = 214;
            this.txt_puesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_puesto_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 223;
            this.label13.Text = "PUESTO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(431, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 225;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(20, 96);
            this.txt_nombre.MaxLength = 70;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(326, 20);
            this.txt_nombre.TabIndex = 213;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(18, 80);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(57, 13);
            this.lbl_nombre.TabIndex = 221;
            this.lbl_nombre.Text = "NOMBRE:";
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(20, 262);
            this.txt_rfc.MaxLength = 30;
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(166, 20);
            this.txt_rfc.TabIndex = 218;
            this.txt_rfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rfc_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 227;
            this.label16.Text = "RFC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 240;
            this.label1.Text = "TIPO:";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "GRÚAS VIAJERAS",
            "POLIPASTOS",
            "GRÚAS TERREST.",
            "MONTACARGAS",
            "AUTOMOVILISTA",
            "TRAB. EN ALTURA",
            "SOLD. AUTÓGENA",
            "SOLD. ELÉCTRICA",
            "SOLD. ESPECIAL",
            "ABRASIVOS",
            "TRAB. ALTA TENS.",
            "TRAB. BAJA TENS.",
            "ÁREAS CONFINAD.",
            "SUST. PELIGROSAS",
            "OPER. DE HORNOS",
            "OPER. CALDERAS",
            "OPER. DE ROBOTS",
            "OPER. DE PRENSAS"});
            this.cmb_tipo.Location = new System.Drawing.Point(20, 304);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(166, 21);
            this.cmb_tipo.TabIndex = 241;
            this.cmb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_tipo_KeyPress);
            // 
            // Frm_Licencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 577);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.dgv_credenciales);
            this.Controls.Add(this.txt_imss);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_vigencia);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_departamento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_puesto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Frm_Licencias";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licencias";
            this.Load += new System.EventHandler(this.Credenciales_Montacargas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credenciales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        public System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.DataGridView dgv_credenciales;
        private System.Windows.Forms.TextBox txt_imss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_vigencia;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_puesto;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tipo;
    }
}