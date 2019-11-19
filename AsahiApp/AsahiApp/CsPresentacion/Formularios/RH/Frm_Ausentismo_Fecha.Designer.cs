namespace CsPresentacion
{
    partial class Frm_Ausentismo_Fecha
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
            this.dgv_ausentismo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtm_termina = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_inicia = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_rep = new System.Windows.Forms.Label();
            this.lbl_plan = new System.Windows.Forms.Label();
            this.lbl_inicia = new System.Windows.Forms.Label();
            this.lbl_termina = new System.Windows.Forms.Label();
            this.lbl_f_injust = new System.Windows.Forms.Label();
            this.lbl_f_just = new System.Windows.Forms.Label();
            this.lbl_permiso_cg = new System.Windows.Forms.Label();
            this.lbl_permiso_sg = new System.Windows.Forms.Label();
            this.lbl_susp = new System.Windows.Forms.Label();
            this.lbl_incap = new System.Windows.Forms.Label();
            this.lbl_vac = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.lbl_t1 = new System.Windows.Forms.Label();
            this.lbl_t2 = new System.Windows.Forms.Label();
            this.lbl_t3 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_depto = new System.Windows.Forms.TextBox();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_exportar_ant2 = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ausentismo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ausentismo
            // 
            this.dgv_ausentismo.AllowUserToAddRows = false;
            this.dgv_ausentismo.AllowUserToDeleteRows = false;
            this.dgv_ausentismo.AllowUserToResizeColumns = false;
            this.dgv_ausentismo.AllowUserToResizeRows = false;
            this.dgv_ausentismo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ausentismo.CausesValidation = false;
            this.dgv_ausentismo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ausentismo.Location = new System.Drawing.Point(12, 70);
            this.dgv_ausentismo.MultiSelect = false;
            this.dgv_ausentismo.Name = "dgv_ausentismo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ausentismo.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ausentismo.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgv_ausentismo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ausentismo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ausentismo.ShowCellErrors = false;
            this.dgv_ausentismo.Size = new System.Drawing.Size(1027, 603);
            this.dgv_ausentismo.TabIndex = 1;
            this.dgv_ausentismo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ausentismo_CellContentClick);
            this.dgv_ausentismo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv_ausentismo_CellFormatting);
            this.dgv_ausentismo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ausentismo_RowEnter);
            this.dgv_ausentismo.DoubleClick += new System.EventHandler(this.Dgv_ausentismo_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.dtm_termina);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtm_inicia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(-3, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 69);
            this.panel1.TabIndex = 144;
            // 
            // dtm_termina
            // 
            this.dtm_termina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_termina.Location = new System.Drawing.Point(164, 44);
            this.dtm_termina.Name = "dtm_termina";
            this.dtm_termina.Size = new System.Drawing.Size(125, 20);
            this.dtm_termina.TabIndex = 29;
            this.dtm_termina.ValueChanged += new System.EventHandler(this.Dtm_termina_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "HASTA:";
            // 
            // dtm_inicia
            // 
            this.dtm_inicia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_inicia.Location = new System.Drawing.Point(18, 45);
            this.dtm_inicia.Name = "dtm_inicia";
            this.dtm_inicia.Size = new System.Drawing.Size(125, 20);
            this.dtm_inicia.TabIndex = 20;
            this.dtm_inicia.ValueChanged += new System.EventHandler(this.Dtm_inicia_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "DESDE:";
            // 
            // lbl_rep
            // 
            this.lbl_rep.AutoSize = true;
            this.lbl_rep.Location = new System.Drawing.Point(446, 54);
            this.lbl_rep.Name = "lbl_rep";
            this.lbl_rep.Size = new System.Drawing.Size(112, 13);
            this.lbl_rep.TabIndex = 227;
            this.lbl_rep.Text = "REPORTE DEL MES:";
            // 
            // lbl_plan
            // 
            this.lbl_plan.AutoSize = true;
            this.lbl_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plan.Location = new System.Drawing.Point(183, 681);
            this.lbl_plan.Name = "lbl_plan";
            this.lbl_plan.Size = new System.Drawing.Size(21, 13);
            this.lbl_plan.TabIndex = 228;
            this.lbl_plan.Text = "00";
            // 
            // lbl_inicia
            // 
            this.lbl_inicia.AutoSize = true;
            this.lbl_inicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicia.Location = new System.Drawing.Point(237, 681);
            this.lbl_inicia.Name = "lbl_inicia";
            this.lbl_inicia.Size = new System.Drawing.Size(21, 13);
            this.lbl_inicia.TabIndex = 229;
            this.lbl_inicia.Text = "00";
            // 
            // lbl_termina
            // 
            this.lbl_termina.AutoSize = true;
            this.lbl_termina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_termina.Location = new System.Drawing.Point(288, 681);
            this.lbl_termina.Name = "lbl_termina";
            this.lbl_termina.Size = new System.Drawing.Size(21, 13);
            this.lbl_termina.TabIndex = 230;
            this.lbl_termina.Text = "00";
            // 
            // lbl_f_injust
            // 
            this.lbl_f_injust.AutoSize = true;
            this.lbl_f_injust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_f_injust.Location = new System.Drawing.Point(349, 681);
            this.lbl_f_injust.Name = "lbl_f_injust";
            this.lbl_f_injust.Size = new System.Drawing.Size(21, 13);
            this.lbl_f_injust.TabIndex = 231;
            this.lbl_f_injust.Text = "00";
            // 
            // lbl_f_just
            // 
            this.lbl_f_just.AutoSize = true;
            this.lbl_f_just.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_f_just.Location = new System.Drawing.Point(421, 681);
            this.lbl_f_just.Name = "lbl_f_just";
            this.lbl_f_just.Size = new System.Drawing.Size(21, 13);
            this.lbl_f_just.TabIndex = 232;
            this.lbl_f_just.Text = "00";
            // 
            // lbl_permiso_cg
            // 
            this.lbl_permiso_cg.AutoSize = true;
            this.lbl_permiso_cg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_permiso_cg.Location = new System.Drawing.Point(492, 681);
            this.lbl_permiso_cg.Name = "lbl_permiso_cg";
            this.lbl_permiso_cg.Size = new System.Drawing.Size(21, 13);
            this.lbl_permiso_cg.TabIndex = 233;
            this.lbl_permiso_cg.Text = "00";
            // 
            // lbl_permiso_sg
            // 
            this.lbl_permiso_sg.AutoSize = true;
            this.lbl_permiso_sg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_permiso_sg.Location = new System.Drawing.Point(560, 681);
            this.lbl_permiso_sg.Name = "lbl_permiso_sg";
            this.lbl_permiso_sg.Size = new System.Drawing.Size(21, 13);
            this.lbl_permiso_sg.TabIndex = 234;
            this.lbl_permiso_sg.Text = "00";
            // 
            // lbl_susp
            // 
            this.lbl_susp.AutoSize = true;
            this.lbl_susp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_susp.Location = new System.Drawing.Point(628, 681);
            this.lbl_susp.Name = "lbl_susp";
            this.lbl_susp.Size = new System.Drawing.Size(21, 13);
            this.lbl_susp.TabIndex = 235;
            this.lbl_susp.Text = "00";
            // 
            // lbl_incap
            // 
            this.lbl_incap.AutoSize = true;
            this.lbl_incap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incap.Location = new System.Drawing.Point(680, 681);
            this.lbl_incap.Name = "lbl_incap";
            this.lbl_incap.Size = new System.Drawing.Size(21, 13);
            this.lbl_incap.TabIndex = 236;
            this.lbl_incap.Text = "00";
            // 
            // lbl_vac
            // 
            this.lbl_vac.AutoSize = true;
            this.lbl_vac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vac.Location = new System.Drawing.Point(730, 681);
            this.lbl_vac.Name = "lbl_vac";
            this.lbl_vac.Size = new System.Drawing.Size(21, 13);
            this.lbl_vac.TabIndex = 237;
            this.lbl_vac.Text = "00";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.Location = new System.Drawing.Point(780, 681);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(21, 13);
            this.lbl_admin.TabIndex = 238;
            this.lbl_admin.Text = "00";
            // 
            // lbl_t1
            // 
            this.lbl_t1.AutoSize = true;
            this.lbl_t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t1.Location = new System.Drawing.Point(825, 681);
            this.lbl_t1.Name = "lbl_t1";
            this.lbl_t1.Size = new System.Drawing.Size(21, 13);
            this.lbl_t1.TabIndex = 239;
            this.lbl_t1.Text = "00";
            // 
            // lbl_t2
            // 
            this.lbl_t2.AutoSize = true;
            this.lbl_t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t2.Location = new System.Drawing.Point(878, 681);
            this.lbl_t2.Name = "lbl_t2";
            this.lbl_t2.Size = new System.Drawing.Size(21, 13);
            this.lbl_t2.TabIndex = 240;
            this.lbl_t2.Text = "00";
            // 
            // lbl_t3
            // 
            this.lbl_t3.AutoSize = true;
            this.lbl_t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_t3.Location = new System.Drawing.Point(928, 681);
            this.lbl_t3.Name = "lbl_t3";
            this.lbl_t3.Size = new System.Drawing.Size(21, 13);
            this.lbl_t3.TabIndex = 241;
            this.lbl_t3.Text = "00";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(981, 681);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(21, 13);
            this.lbl_total.TabIndex = 242;
            this.lbl_total.Text = "00";
            // 
            // txt_depto
            // 
            this.txt_depto.Location = new System.Drawing.Point(34, 680);
            this.txt_depto.Name = "txt_depto";
            this.txt_depto.Size = new System.Drawing.Size(100, 20);
            this.txt_depto.TabIndex = 243;
            // 
            // btn_reporte
            // 
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Image = global::CsPresentacion.Properties.Resources.Adobe_PDF_Document_icon;
            this.btn_reporte.Location = new System.Drawing.Point(1060, 569);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(40, 34);
            this.btn_reporte.TabIndex = 226;
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // btn_exportar_ant2
            // 
            this.btn_exportar_ant2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar_ant2.FlatAppearance.BorderSize = 0;
            this.btn_exportar_ant2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar_ant2.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar_ant2.Location = new System.Drawing.Point(1061, 622);
            this.btn_exportar_ant2.Name = "btn_exportar_ant2";
            this.btn_exportar_ant2.Size = new System.Drawing.Size(40, 34);
            this.btn_exportar_ant2.TabIndex = 225;
            this.btn_exportar_ant2.UseVisualStyleBackColor = true;
            this.btn_exportar_ant2.Click += new System.EventHandler(this.Btn_exportar_ant2_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(295, 42);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 26;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Frm_Ausentismo_Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 705);
            this.Controls.Add(this.txt_depto);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_t3);
            this.Controls.Add(this.lbl_t2);
            this.Controls.Add(this.lbl_t1);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.lbl_vac);
            this.Controls.Add(this.lbl_incap);
            this.Controls.Add(this.lbl_susp);
            this.Controls.Add(this.lbl_permiso_sg);
            this.Controls.Add(this.lbl_permiso_cg);
            this.Controls.Add(this.lbl_f_just);
            this.Controls.Add(this.lbl_f_injust);
            this.Controls.Add(this.lbl_termina);
            this.Controls.Add(this.lbl_inicia);
            this.Controls.Add(this.lbl_plan);
            this.Controls.Add(this.lbl_rep);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.btn_exportar_ant2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_ausentismo);
            this.Name = "Frm_Ausentismo_Fecha";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ausentismo Global";
            this.Load += new System.EventHandler(this.Frm_Ausentismo_Fecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ausentismo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ausentismo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_exportar_ant2;
        private System.Windows.Forms.Label lbl_rep;
        private System.Windows.Forms.Label lbl_plan;
        private System.Windows.Forms.Label lbl_inicia;
        private System.Windows.Forms.Label lbl_termina;
        private System.Windows.Forms.Label lbl_f_injust;
        private System.Windows.Forms.Label lbl_f_just;
        private System.Windows.Forms.Label lbl_permiso_cg;
        private System.Windows.Forms.Label lbl_permiso_sg;
        private System.Windows.Forms.Label lbl_susp;
        private System.Windows.Forms.Label lbl_incap;
        private System.Windows.Forms.Label lbl_vac;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label lbl_t1;
        private System.Windows.Forms.Label lbl_t2;
        private System.Windows.Forms.Label lbl_t3;
        private System.Windows.Forms.Label lbl_total;
        public System.Windows.Forms.DateTimePicker dtm_termina;
        public System.Windows.Forms.DateTimePicker dtm_inicia;
        public System.Windows.Forms.TextBox txt_depto;
        private System.Windows.Forms.Timer timer1;
    }
}