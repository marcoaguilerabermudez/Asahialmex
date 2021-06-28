
namespace CsPresentacion.Formularios.RH
{
    partial class Frm_Modifica_Sueldo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.dtm_sueldo = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_motivo_sueldo = new System.Windows.Forms.ComboBox();
            this.btn_mod_sueldo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SDO1_2 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txt_SDO2_2 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txt_SDO3_2 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txt_SDO4_2 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txt_SDO5_2 = new System.Windows.Forms.TextBox();
            this.lbl_motivo = new System.Windows.Forms.Label();
            this.lbl_comprueba_sueldo = new System.Windows.Forms.Label();
            this.btn_eliminar_sueldo = new System.Windows.Forms.Button();
            this.dgv_sueldo = new System.Windows.Forms.DataGridView();
            this.txt_factor_sueldo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_materno = new System.Windows.Forms.TextBox();
            this.txt_vigencia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_clave);
            this.panel1.Controls.Add(this.lbl_fecha);
            this.panel1.Location = new System.Drawing.Point(-3, -27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 69);
            this.panel1.TabIndex = 59;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(112, 45);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(18, 23);
            this.btn_nuevo.TabIndex = 105;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "CLAVE:";
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(24, 47);
            this.txt_clave.MaxLength = 5;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(84, 20);
            this.txt_clave.TabIndex = 0;
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave_KeyPress);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(1039, 41);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 28;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(23, 301);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(129, 13);
            this.label32.TabIndex = 262;
            this.label32.Text = "FECHA DE APLICACION:";
            // 
            // dtm_sueldo
            // 
            this.dtm_sueldo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_sueldo.Location = new System.Drawing.Point(23, 318);
            this.dtm_sueldo.Name = "dtm_sueldo";
            this.dtm_sueldo.Size = new System.Drawing.Size(188, 20);
            this.dtm_sueldo.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 260;
            this.label15.Text = "MOTIVO:";
            // 
            // cmb_motivo_sueldo
            // 
            this.cmb_motivo_sueldo.FormattingEnabled = true;
            this.cmb_motivo_sueldo.Items.AddRange(new object[] {
            "MODIFICACION DE SALARIO",
            "PROMOCION",
            "ANTIGUEDAD",
            "EVALUACION 3 MESES",
            "EVALUACION ANUAL"});
            this.cmb_motivo_sueldo.Location = new System.Drawing.Point(23, 274);
            this.cmb_motivo_sueldo.Name = "cmb_motivo_sueldo";
            this.cmb_motivo_sueldo.Size = new System.Drawing.Size(188, 21);
            this.cmb_motivo_sueldo.TabIndex = 2;
            this.cmb_motivo_sueldo.SelectedIndexChanged += new System.EventHandler(this.cmb_motivo_sueldo_SelectedIndexChanged);
            this.cmb_motivo_sueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_motivo_sueldo_KeyPress);
            // 
            // btn_mod_sueldo
            // 
            this.btn_mod_sueldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mod_sueldo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_mod_sueldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_mod_sueldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mod_sueldo.Location = new System.Drawing.Point(227, 310);
            this.btn_mod_sueldo.Name = "btn_mod_sueldo";
            this.btn_mod_sueldo.Size = new System.Drawing.Size(61, 31);
            this.btn_mod_sueldo.TabIndex = 4;
            this.btn_mod_sueldo.Text = "&Aplicar";
            this.btn_mod_sueldo.UseVisualStyleBackColor = true;
            this.btn_mod_sueldo.Click += new System.EventHandler(this.btn_mod_sueldo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_SDO1_2);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.txt_SDO2_2);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.txt_SDO3_2);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.txt_SDO4_2);
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.txt_SDO5_2);
            this.groupBox3.Location = new System.Drawing.Point(17, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 62);
            this.groupBox3.TabIndex = 261;
            this.groupBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "SUELDO DIARIO:";
            // 
            // txt_SDO1_2
            // 
            this.txt_SDO1_2.Location = new System.Drawing.Point(6, 33);
            this.txt_SDO1_2.MaxLength = 10;
            this.txt_SDO1_2.Name = "txt_SDO1_2";
            this.txt_SDO1_2.Size = new System.Drawing.Size(89, 20);
            this.txt_SDO1_2.TabIndex = 1;
            this.txt_SDO1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDO1_2_KeyPress);
            this.txt_SDO1_2.Leave += new System.EventHandler(this.txt_SDO1_2_Leave);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(113, 16);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 13);
            this.label37.TabIndex = 16;
            this.label37.Text = "VAR. IMMS:";
            // 
            // txt_SDO2_2
            // 
            this.txt_SDO2_2.Location = new System.Drawing.Point(114, 33);
            this.txt_SDO2_2.Name = "txt_SDO2_2";
            this.txt_SDO2_2.Size = new System.Drawing.Size(89, 20);
            this.txt_SDO2_2.TabIndex = 17;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(221, 16);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(66, 13);
            this.label38.TabIndex = 18;
            this.label38.Text = "VAR. IMMS:";
            // 
            // txt_SDO3_2
            // 
            this.txt_SDO3_2.Location = new System.Drawing.Point(222, 33);
            this.txt_SDO3_2.Name = "txt_SDO3_2";
            this.txt_SDO3_2.Size = new System.Drawing.Size(89, 20);
            this.txt_SDO3_2.TabIndex = 19;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(334, 16);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 13);
            this.label39.TabIndex = 20;
            this.label39.Text = "VAR. INFONAVIT:";
            // 
            // txt_SDO4_2
            // 
            this.txt_SDO4_2.Location = new System.Drawing.Point(336, 33);
            this.txt_SDO4_2.Name = "txt_SDO4_2";
            this.txt_SDO4_2.Size = new System.Drawing.Size(89, 20);
            this.txt_SDO4_2.TabIndex = 21;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(446, 16);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(95, 13);
            this.label40.TabIndex = 22;
            this.label40.Text = "VAR. INFONAVIT:";
            // 
            // txt_SDO5_2
            // 
            this.txt_SDO5_2.Location = new System.Drawing.Point(448, 33);
            this.txt_SDO5_2.Name = "txt_SDO5_2";
            this.txt_SDO5_2.Size = new System.Drawing.Size(89, 20);
            this.txt_SDO5_2.TabIndex = 23;
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.AutoSize = true;
            this.lbl_motivo.Location = new System.Drawing.Point(153, 575);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(50, 13);
            this.lbl_motivo.TabIndex = 267;
            this.lbl_motivo.Text = "@Motivo";
            // 
            // lbl_comprueba_sueldo
            // 
            this.lbl_comprueba_sueldo.AutoSize = true;
            this.lbl_comprueba_sueldo.Location = new System.Drawing.Point(17, 575);
            this.lbl_comprueba_sueldo.Name = "lbl_comprueba_sueldo";
            this.lbl_comprueba_sueldo.Size = new System.Drawing.Size(111, 13);
            this.lbl_comprueba_sueldo.TabIndex = 266;
            this.lbl_comprueba_sueldo.Text = "@Comprueba_Sueldo";
            // 
            // btn_eliminar_sueldo
            // 
            this.btn_eliminar_sueldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_sueldo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_eliminar_sueldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_eliminar_sueldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_sueldo.Location = new System.Drawing.Point(517, 564);
            this.btn_eliminar_sueldo.Name = "btn_eliminar_sueldo";
            this.btn_eliminar_sueldo.Size = new System.Drawing.Size(61, 31);
            this.btn_eliminar_sueldo.TabIndex = 263;
            this.btn_eliminar_sueldo.Text = "&Eliminar";
            this.btn_eliminar_sueldo.UseVisualStyleBackColor = true;
            this.btn_eliminar_sueldo.Click += new System.EventHandler(this.btn_eliminar_sueldo_Click_1);
            // 
            // dgv_sueldo
            // 
            this.dgv_sueldo.AllowUserToAddRows = false;
            this.dgv_sueldo.AllowUserToDeleteRows = false;
            this.dgv_sueldo.AllowUserToResizeColumns = false;
            this.dgv_sueldo.AllowUserToResizeRows = false;
            this.dgv_sueldo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_sueldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sueldo.Location = new System.Drawing.Point(20, 349);
            this.dgv_sueldo.Name = "dgv_sueldo";
            this.dgv_sueldo.RowHeadersVisible = false;
            this.dgv_sueldo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sueldo.Size = new System.Drawing.Size(558, 209);
            this.dgv_sueldo.TabIndex = 265;
            this.dgv_sueldo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sueldo_CellContentClick);
            // 
            // txt_factor_sueldo
            // 
            this.txt_factor_sueldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_factor_sueldo.Location = new System.Drawing.Point(20, 593);
            this.txt_factor_sueldo.Name = "txt_factor_sueldo";
            this.txt_factor_sueldo.Size = new System.Drawing.Size(65, 20);
            this.txt_factor_sueldo.TabIndex = 264;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(448, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 272;
            this.pictureBox1.TabStop = false;
            // 
            // txt_paterno
            // 
            this.txt_paterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_paterno.Location = new System.Drawing.Point(24, 83);
            this.txt_paterno.MaxLength = 30;
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(217, 20);
            this.txt_paterno.TabIndex = 271;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(23, 66);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(117, 13);
            this.label30.TabIndex = 269;
            this.label30.Text = "APELLIDO PATERNO:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 109);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(119, 13);
            this.label29.TabIndex = 270;
            this.label29.Text = "APELLIDO MATERNO:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(21, 147);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 13);
            this.label28.TabIndex = 273;
            this.label28.Text = "NOMBRE(S):";
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(23, 164);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(218, 20);
            this.txt_nombre.TabIndex = 274;
            // 
            // txt_materno
            // 
            this.txt_materno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_materno.Location = new System.Drawing.Point(23, 124);
            this.txt_materno.MaxLength = 30;
            this.txt_materno.Name = "txt_materno";
            this.txt_materno.Size = new System.Drawing.Size(218, 20);
            this.txt_materno.TabIndex = 275;
            // 
            // txt_vigencia
            // 
            this.txt_vigencia.ForeColor = System.Drawing.Color.White;
            this.txt_vigencia.Location = new System.Drawing.Point(209, 593);
            this.txt_vigencia.Name = "txt_vigencia";
            this.txt_vigencia.Size = new System.Drawing.Size(79, 20);
            this.txt_vigencia.TabIndex = 276;
            this.txt_vigencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Modifica_Sueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 619);
            this.Controls.Add(this.txt_vigencia);
            this.Controls.Add(this.txt_materno);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_paterno);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.lbl_motivo);
            this.Controls.Add(this.lbl_comprueba_sueldo);
            this.Controls.Add(this.btn_eliminar_sueldo);
            this.Controls.Add(this.dgv_sueldo);
            this.Controls.Add(this.txt_factor_sueldo);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.dtm_sueldo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmb_motivo_sueldo);
            this.Controls.Add(this.btn_mod_sueldo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Modifica_Sueldo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica Sueldo";
            this.Load += new System.EventHandler(this.Frm_Modifica_Sueldo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DateTimePicker dtm_sueldo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_motivo_sueldo;
        private System.Windows.Forms.Button btn_mod_sueldo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SDO1_2;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txt_SDO2_2;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txt_SDO3_2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txt_SDO4_2;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txt_SDO5_2;
        private System.Windows.Forms.Label lbl_motivo;
        private System.Windows.Forms.Label lbl_comprueba_sueldo;
        private System.Windows.Forms.Button btn_eliminar_sueldo;
        private System.Windows.Forms.DataGridView dgv_sueldo;
        private System.Windows.Forms.TextBox txt_factor_sueldo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_paterno;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_materno;
        private System.Windows.Forms.TextBox txt_vigencia;
    }
}