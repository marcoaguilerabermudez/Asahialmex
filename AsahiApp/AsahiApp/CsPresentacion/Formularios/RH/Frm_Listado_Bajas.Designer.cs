namespace CsPresentacion
{
    partial class Frm_Listado_Bajas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_semana = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_año = new System.Windows.Forms.ComboBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.cmb_puesto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_departamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.dgv_bajas = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_contabilidad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bajas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(53, 616);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(17, 17);
            this.lbl_total.TabIndex = 24;
            this.lbl_total.Text = "0";
            // 
            // btn_exportar
            // 
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_exportar.Location = new System.Drawing.Point(1040, 596);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(81, 48);
            this.btn_exportar.TabIndex = 20;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.Btn_exportar_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Image = global::CsPresentacion.Properties.Resources.Adobe_PDF_Document_icon;
            this.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_reporte.Location = new System.Drawing.Point(956, 597);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(81, 48);
            this.btn_reporte.TabIndex = 18;
            this.btn_reporte.Text = "General";
            this.btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_semana);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmb_mes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmb_año);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.lbl_fecha);
            this.panel1.Controls.Add(this.cmb_puesto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_departamento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-26, -25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 74);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(235, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Semana:";
            // 
            // txt_semana
            // 
            this.txt_semana.Location = new System.Drawing.Point(236, 47);
            this.txt_semana.MaxLength = 2;
            this.txt_semana.Name = "txt_semana";
            this.txt_semana.Size = new System.Drawing.Size(55, 20);
            this.txt_semana.TabIndex = 15;
            this.txt_semana.TextChanged += new System.EventHandler(this.Txt_semana_TextChanged);
            this.txt_semana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_semana2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(117, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mes:";
            // 
            // cmb_mes
            // 
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cmb_mes.Location = new System.Drawing.Point(117, 47);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(113, 21);
            this.cmb_mes.TabIndex = 14;
            this.cmb_mes.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.cmb_mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Año:";
            // 
            // cmb_año
            // 
            this.cmb_año.FormattingEnabled = true;
            this.cmb_año.Location = new System.Drawing.Point(35, 47);
            this.cmb_año.Name = "cmb_año";
            this.cmb_año.Size = new System.Drawing.Size(76, 21);
            this.cmb_año.TabIndex = 13;
            this.cmb_año.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(696, 42);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 11;
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
            this.btn_buscar.Location = new System.Drawing.Point(658, 38);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(29, 34);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(1047, 43);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 9;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // cmb_puesto
            // 
            this.cmb_puesto.FormattingEnabled = true;
            this.cmb_puesto.Location = new System.Drawing.Point(479, 47);
            this.cmb_puesto.Name = "cmb_puesto";
            this.cmb_puesto.Size = new System.Drawing.Size(172, 21);
            this.cmb_puesto.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(479, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puesto:";
            // 
            // cmb_departamento
            // 
            this.cmb_departamento.FormattingEnabled = true;
            this.cmb_departamento.Location = new System.Drawing.Point(299, 47);
            this.cmb_departamento.Name = "cmb_departamento";
            this.cmb_departamento.Size = new System.Drawing.Size(172, 21);
            this.cmb_departamento.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(299, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Departamento:";
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.ForeColor = System.Drawing.Color.Black;
            this.lbl_filtro.Location = new System.Drawing.Point(3, 616);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(50, 17);
            this.lbl_filtro.TabIndex = 23;
            this.lbl_filtro.Text = "Total:";
            // 
            // dgv_bajas
            // 
            this.dgv_bajas.AllowUserToAddRows = false;
            this.dgv_bajas.AllowUserToDeleteRows = false;
            this.dgv_bajas.AllowUserToResizeColumns = false;
            this.dgv_bajas.AllowUserToResizeRows = false;
            this.dgv_bajas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bajas.CausesValidation = false;
            this.dgv_bajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bajas.Location = new System.Drawing.Point(4, 55);
            this.dgv_bajas.MultiSelect = false;
            this.dgv_bajas.Name = "dgv_bajas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bajas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_bajas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_bajas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_bajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bajas.ShowCellErrors = false;
            this.dgv_bajas.Size = new System.Drawing.Size(1123, 537);
            this.dgv_bajas.TabIndex = 14;
            this.dgv_bajas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv_bajas_CellFormatting);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btn_contabilidad
            // 
            this.btn_contabilidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_contabilidad.FlatAppearance.BorderSize = 0;
            this.btn_contabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contabilidad.Image = global::CsPresentacion.Properties.Resources.Adobe_PDF_Document_icon;
            this.btn_contabilidad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_contabilidad.Location = new System.Drawing.Point(861, 598);
            this.btn_contabilidad.Name = "btn_contabilidad";
            this.btn_contabilidad.Size = new System.Drawing.Size(81, 48);
            this.btn_contabilidad.TabIndex = 25;
            this.btn_contabilidad.Text = "Contabilidad";
            this.btn_contabilidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_contabilidad.UseVisualStyleBackColor = true;
            this.btn_contabilidad.Click += new System.EventHandler(this.Btn_contabilidad_Click);
            // 
            // Frm_Listado_Bajas
            // 
            this.AcceptButton = this.btn_buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 655);
            this.Controls.Add(this.btn_contabilidad);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_filtro);
            this.Controls.Add(this.dgv_bajas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_Listado_Bajas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de Empleados";
            this.Load += new System.EventHandler(this.Frm_Listado_Bajas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bajas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.ComboBox cmb_puesto;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmb_departamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.DataGridView dgv_bajas;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_semana;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmb_año;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btn_reporte;
        public System.Windows.Forms.Button btn_contabilidad;
    }
}