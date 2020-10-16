namespace CsPresentacion
{
    partial class Frm_Rep_Cred
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
            this.dtm_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_telefono_referencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_vigencia = new System.Windows.Forms.TextBox();
            this.txt_curp = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_referencia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_puesto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_afiliacion = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dgv_credenciales = new System.Windows.Forms.DataGridView();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credenciales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtm_nacimiento
            // 
            this.dtm_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_nacimiento.Location = new System.Drawing.Point(209, 344);
            this.dtm_nacimiento.Name = "dtm_nacimiento";
            this.dtm_nacimiento.Size = new System.Drawing.Size(168, 20);
            this.dtm_nacimiento.TabIndex = 206;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(207, 327);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 13);
            this.label21.TabIndex = 205;
            this.label21.Text = "FECHA NACIMIENTO:";
            // 
            // txt_telefono_referencia
            // 
            this.txt_telefono_referencia.Location = new System.Drawing.Point(20, 177);
            this.txt_telefono_referencia.MaxLength = 12;
            this.txt_telefono_referencia.Name = "txt_telefono_referencia";
            this.txt_telefono_referencia.Size = new System.Drawing.Size(167, 20);
            this.txt_telefono_referencia.TabIndex = 171;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 202;
            this.label6.Text = "TELEFONO REFERENCIA:";
            // 
            // txt_vigencia
            // 
            this.txt_vigencia.Location = new System.Drawing.Point(431, 209);
            this.txt_vigencia.Name = "txt_vigencia";
            this.txt_vigencia.Size = new System.Drawing.Size(130, 20);
            this.txt_vigencia.TabIndex = 200;
            this.txt_vigencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_vigencia.TextChanged += new System.EventHandler(this.txt_vigencia_TextChanged);
            // 
            // txt_curp
            // 
            this.txt_curp.Location = new System.Drawing.Point(210, 303);
            this.txt_curp.MaxLength = 30;
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(167, 20);
            this.txt_curp.TabIndex = 179;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(469, 192);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(54, 13);
            this.lbl_estado.TabIndex = 199;
            this.lbl_estado.Text = "ESTADO:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(207, 287);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 197;
            this.label18.Text = "CURP:";
            // 
            // txt_departamento
            // 
            this.txt_departamento.Location = new System.Drawing.Point(20, 219);
            this.txt_departamento.MaxLength = 30;
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.Size = new System.Drawing.Size(167, 20);
            this.txt_departamento.TabIndex = 174;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 193;
            this.label15.Text = "DEPARTAMENTO:";
            // 
            // txt_referencia
            // 
            this.txt_referencia.Location = new System.Drawing.Point(20, 136);
            this.txt_referencia.MaxLength = 70;
            this.txt_referencia.Name = "txt_referencia";
            this.txt_referencia.Size = new System.Drawing.Size(326, 20);
            this.txt_referencia.TabIndex = 169;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 191;
            this.label13.Text = "REFERENCIA:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 196;
            this.label16.Text = "PUESTO:";
            // 
            // txt_puesto
            // 
            this.txt_puesto.Location = new System.Drawing.Point(20, 261);
            this.txt_puesto.MaxLength = 30;
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.Size = new System.Drawing.Size(167, 20);
            this.txt_puesto.TabIndex = 178;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 286);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 195;
            this.label17.Text = "RFC:";
            // 
            // txt_afiliacion
            // 
            this.txt_afiliacion.Location = new System.Drawing.Point(20, 343);
            this.txt_afiliacion.MaxLength = 30;
            this.txt_afiliacion.Name = "txt_afiliacion";
            this.txt_afiliacion.Size = new System.Drawing.Size(167, 20);
            this.txt_afiliacion.TabIndex = 180;
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(20, 303);
            this.txt_rfc.MaxLength = 30;
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(167, 20);
            this.txt_rfc.TabIndex = 177;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 186;
            this.label1.Text = "AFILIACION:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(20, 96);
            this.txt_nombre.MaxLength = 70;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(326, 20);
            this.txt_nombre.TabIndex = 168;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(19, 80);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(57, 13);
            this.lbl_nombre.TabIndex = 185;
            this.lbl_nombre.Text = "NOMBRE:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lbl_fecha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_clave);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 55);
            this.panel1.TabIndex = 167;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(470, 23);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(51, 13);
            this.lbl_fecha.TabIndex = 148;
            this.lbl_fecha.Text = "@Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 14);
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
            this.txt_clave.TextChanged += new System.EventHandler(this.Txt_clave_TextChanged);
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_clave_KeyPress);
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
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
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
            this.dgv_credenciales.TabIndex = 207;
            this.dgv_credenciales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_credenciales_CellContentClick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.Location = new System.Drawing.Point(449, 335);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(91, 34);
            this.btn_agregar.TabIndex = 209;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.Btn_baja_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(20, 61);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(32, 13);
            this.lbl_id.TabIndex = 211;
            this.lbl_id.Text = "@ID:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(15, 553);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(42, 13);
            this.lbl_total.TabIndex = 212;
            this.lbl_total.Text = "@Total";
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
            this.btn_eliminar.TabIndex = 210;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
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
            this.btn_reporte.TabIndex = 208;
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(431, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 194;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Rep_Cred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 577);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.dgv_credenciales);
            this.Controls.Add(this.dtm_nacimiento);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txt_telefono_referencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_vigencia);
            this.Controls.Add(this.txt_curp);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_departamento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_referencia);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_puesto);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_afiliacion);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Rep_Cred";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credenciales";
            this.Load += new System.EventHandler(this.Frm_Credenciales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_credenciales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtm_nacimiento;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_telefono_referencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_vigencia;
        private System.Windows.Forms.TextBox txt_curp;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_referencia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_puesto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_afiliacion;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView dgv_credenciales;
        public System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_total;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}