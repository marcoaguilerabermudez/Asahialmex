namespace CsPresentacion
{
    partial class Frm_Rotacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_total = new System.Windows.Forms.DataGridView();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtm_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ant2 = new System.Windows.Forms.ComboBox();
            this.dgv_ant2 = new System.Windows.Forms.DataGridView();
            this.cmb_ant = new System.Windows.Forms.ComboBox();
            this.dgv_ant = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_bajas = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_altas = new System.Windows.Forms.Label();
            this.txt_ab = new System.Windows.Forms.TextBox();
            this.txt_ac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exportar_total = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_total)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ant2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_total
            // 
            this.dgv_total.AllowUserToAddRows = false;
            this.dgv_total.AllowUserToDeleteRows = false;
            this.dgv_total.AllowUserToResizeColumns = false;
            this.dgv_total.AllowUserToResizeRows = false;
            this.dgv_total.BackgroundColor = System.Drawing.Color.White;
            this.dgv_total.CausesValidation = false;
            this.dgv_total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_total.Location = new System.Drawing.Point(8, 79);
            this.dgv_total.MultiSelect = false;
            this.dgv_total.Name = "dgv_total";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_total.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_total.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgv_total.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_total.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_total.ShowCellErrors = false;
            this.dgv_total.Size = new System.Drawing.Size(397, 497);
            this.dgv_total.TabIndex = 138;
            // 
            // btn_reporte
            // 
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Image = global::CsPresentacion.Properties.Resources.Adobe_PDF_Document_icon;
            this.btn_reporte.Location = new System.Drawing.Point(1163, 580);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(42, 34);
            this.btn_reporte.TabIndex = 141;
            this.btn_reporte.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.dtm_fecha);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-1, -22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 69);
            this.panel1.TabIndex = 142;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // dtm_fecha
            // 
            this.dtm_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_fecha.Location = new System.Drawing.Point(11, 42);
            this.dtm_fecha.Name = "dtm_fecha";
            this.dtm_fecha.Size = new System.Drawing.Size(156, 20);
            this.dtm_fecha.TabIndex = 27;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(214, 38);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 26;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Image = global::CsPresentacion.Properties.Resources.Filtro;
            this.btn_buscar.Location = new System.Drawing.Point(175, 34);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(29, 34);
            this.btn_buscar.TabIndex = 25;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "FECHA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 149;
            this.label1.Text = "TOTAL DE ROTACION:";
            // 
            // cmb_ant2
            // 
            this.cmb_ant2.FormattingEnabled = true;
            this.cmb_ant2.Items.AddRange(new object[] {
            "MENOS DE DOS SEMANAS",
            "DOS SEMANAS A UN MES",
            "UN MES A TRES MESES",
            "TRES MESES A SEIS MESES",
            "MENOS DE TRES MESES",
            "MAS DE TRES MESES",
            "SEIS MESES A UN AÑO",
            "UN AÑO A DOS AÑOS",
            "MAS DE DOS AÑOS"});
            this.cmb_ant2.Location = new System.Drawing.Point(815, 53);
            this.cmb_ant2.Name = "cmb_ant2";
            this.cmb_ant2.Size = new System.Drawing.Size(179, 21);
            this.cmb_ant2.TabIndex = 148;
            // 
            // dgv_ant2
            // 
            this.dgv_ant2.AllowUserToAddRows = false;
            this.dgv_ant2.AllowUserToDeleteRows = false;
            this.dgv_ant2.AllowUserToResizeColumns = false;
            this.dgv_ant2.AllowUserToResizeRows = false;
            this.dgv_ant2.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ant2.CausesValidation = false;
            this.dgv_ant2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ant2.Location = new System.Drawing.Point(813, 79);
            this.dgv_ant2.MultiSelect = false;
            this.dgv_ant2.Name = "dgv_ant2";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ant2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_ant2.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgv_ant2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_ant2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ant2.ShowCellErrors = false;
            this.dgv_ant2.Size = new System.Drawing.Size(397, 497);
            this.dgv_ant2.TabIndex = 140;
            // 
            // cmb_ant
            // 
            this.cmb_ant.FormattingEnabled = true;
            this.cmb_ant.Items.AddRange(new object[] {
            "MENOS DE DOS SEMANAS",
            "DOS SEMANAS A UN MES",
            "UN MES A TRES MESES",
            "TRES MESES A SEIS MESES",
            "MENOS DE TRES MESES",
            "MAS DE TRES MESES",
            "SEIS MESES A UN AÑO",
            "UN AÑO A DOS AÑOS",
            "MAS DE DOS AÑOS"});
            this.cmb_ant.Location = new System.Drawing.Point(413, 53);
            this.cmb_ant.Name = "cmb_ant";
            this.cmb_ant.Size = new System.Drawing.Size(179, 21);
            this.cmb_ant.TabIndex = 144;
            // 
            // dgv_ant
            // 
            this.dgv_ant.AllowUserToAddRows = false;
            this.dgv_ant.AllowUserToDeleteRows = false;
            this.dgv_ant.AllowUserToResizeColumns = false;
            this.dgv_ant.AllowUserToResizeRows = false;
            this.dgv_ant.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ant.CausesValidation = false;
            this.dgv_ant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ant.Location = new System.Drawing.Point(410, 79);
            this.dgv_ant.MultiSelect = false;
            this.dgv_ant.Name = "dgv_ant";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ant.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_ant.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgv_ant.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_ant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ant.ShowCellErrors = false;
            this.dgv_ant.Size = new System.Drawing.Size(397, 497);
            this.dgv_ant.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 151;
            this.label2.Text = "ALTAS:";
            // 
            // lbl_bajas
            // 
            this.lbl_bajas.AutoSize = true;
            this.lbl_bajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bajas.Location = new System.Drawing.Point(65, 605);
            this.lbl_bajas.Name = "lbl_bajas";
            this.lbl_bajas.Size = new System.Drawing.Size(13, 13);
            this.lbl_bajas.TabIndex = 152;
            this.lbl_bajas.Text = "0";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(65, 628);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(13, 13);
            this.lbl_total.TabIndex = 153;
            this.lbl_total.Text = "0";
            // 
            // lbl_altas
            // 
            this.lbl_altas.AutoSize = true;
            this.lbl_altas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altas.Location = new System.Drawing.Point(66, 581);
            this.lbl_altas.Name = "lbl_altas";
            this.lbl_altas.Size = new System.Drawing.Size(13, 13);
            this.lbl_altas.TabIndex = 154;
            this.lbl_altas.Text = "0";
            // 
            // txt_ab
            // 
            this.txt_ab.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.txt_ab.BackColor = System.Drawing.Color.White;
            this.txt_ab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ab.Location = new System.Drawing.Point(204, 604);
            this.txt_ab.MaxLength = 3;
            this.txt_ab.Name = "txt_ab";
            this.txt_ab.Size = new System.Drawing.Size(26, 13);
            this.txt_ab.TabIndex = 156;
            this.txt_ab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ac
            // 
            this.txt_ac.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.txt_ac.BackColor = System.Drawing.Color.White;
            this.txt_ac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ac.Location = new System.Drawing.Point(204, 581);
            this.txt_ac.MaxLength = 3;
            this.txt_ac.Name = "txt_ac";
            this.txt_ac.Size = new System.Drawing.Size(26, 13);
            this.txt_ac.TabIndex = 157;
            this.txt_ac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 605);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 158;
            this.label3.Text = "BAJAS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 159;
            this.label4.Text = "TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 160;
            this.label5.Text = "A/C =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 161;
            this.label6.Text = "A/B =";
            // 
            // btn_exportar_total
            // 
            this.btn_exportar_total.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar_total.FlatAppearance.BorderSize = 0;
            this.btn_exportar_total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar_total.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar_total.Location = new System.Drawing.Point(360, 580);
            this.btn_exportar_total.Name = "btn_exportar_total";
            this.btn_exportar_total.Size = new System.Drawing.Size(40, 34);
            this.btn_exportar_total.TabIndex = 162;
            this.btn_exportar_total.UseVisualStyleBackColor = true;
            this.btn_exportar_total.Click += new System.EventHandler(this.Btn_exportar_total_Click);
            // 
            // Frm_Rotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1217, 649);
            this.Controls.Add(this.btn_exportar_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ac);
            this.Controls.Add(this.txt_ab);
            this.Controls.Add(this.lbl_altas);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_bajas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ant2);
            this.Controls.Add(this.cmb_ant);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.dgv_ant2);
            this.Controls.Add(this.dgv_ant);
            this.Controls.Add(this.dgv_total);
            this.Name = "Frm_Rotacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotación";
            this.Load += new System.EventHandler(this.Frm_Rotacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_total)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ant2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_total;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DateTimePicker dtm_fecha;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmb_ant2;
        private System.Windows.Forms.DataGridView dgv_ant2;
        public System.Windows.Forms.ComboBox cmb_ant;
        private System.Windows.Forms.DataGridView dgv_ant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_bajas;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_altas;
        private System.Windows.Forms.TextBox txt_ab;
        private System.Windows.Forms.TextBox txt_ac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_exportar_total;
    }
}