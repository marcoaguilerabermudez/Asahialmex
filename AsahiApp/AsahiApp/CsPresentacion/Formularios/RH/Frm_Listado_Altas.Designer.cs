namespace CsPresentacion
{
    partial class Frm_Listado_Altas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.txt_semana = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_puesto = new System.Windows.Forms.ComboBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_departamento = new System.Windows.Forms.ComboBox();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_año = new System.Windows.Forms.ComboBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.dgv_altas = new System.Windows.Forms.DataGridView();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_altas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.txt_semana);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_puesto);
            this.panel1.Controls.Add(this.lbl_fecha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb_departamento);
            this.panel1.Controls.Add(this.cmb_mes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_año);
            this.panel1.Location = new System.Drawing.Point(-4, -24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 73);
            this.panel1.TabIndex = 1;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(670, 42);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 24;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // txt_semana
            // 
            this.txt_semana.Location = new System.Drawing.Point(214, 48);
            this.txt_semana.MaxLength = 2;
            this.txt_semana.Name = "txt_semana";
            this.txt_semana.Size = new System.Drawing.Size(55, 20);
            this.txt_semana.TabIndex = 16;
            this.txt_semana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_semana_KeyPress);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Image = global::CsPresentacion.Properties.Resources.Filtro;
            this.btn_buscar.Location = new System.Drawing.Point(628, 38);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(29, 34);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(212, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Semana:";
            // 
            // cmb_puesto
            // 
            this.cmb_puesto.FormattingEnabled = true;
            this.cmb_puesto.Location = new System.Drawing.Point(453, 47);
            this.cmb_puesto.Name = "cmb_puesto";
            this.cmb_puesto.Size = new System.Drawing.Size(172, 21);
            this.cmb_puesto.TabIndex = 14;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(955, 42);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 23;
            this.lbl_fecha.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(450, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Puesto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Año:";
            // 
            // cmb_departamento
            // 
            this.cmb_departamento.FormattingEnabled = true;
            this.cmb_departamento.Location = new System.Drawing.Point(275, 47);
            this.cmb_departamento.Name = "cmb_departamento";
            this.cmb_departamento.Size = new System.Drawing.Size(172, 21);
            this.cmb_departamento.TabIndex = 15;
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
            this.cmb_mes.Location = new System.Drawing.Point(96, 47);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(113, 21);
            this.cmb_mes.TabIndex = 13;
            this.cmb_mes.SelectedIndexChanged += new System.EventHandler(this.Cmb_mes_SelectedIndexChanged);
            this.cmb_mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_mes_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(274, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mes:";
            // 
            // cmb_año
            // 
            this.cmb_año.FormattingEnabled = true;
            this.cmb_año.Location = new System.Drawing.Point(14, 47);
            this.cmb_año.Name = "cmb_año";
            this.cmb_año.Size = new System.Drawing.Size(76, 21);
            this.cmb_año.TabIndex = 12;
            this.cmb_año.SelectedIndexChanged += new System.EventHandler(this.Cmb_año_SelectedIndexChanged);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(69, 595);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(17, 17);
            this.lbl_total.TabIndex = 19;
            this.lbl_total.Text = "0";
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.ForeColor = System.Drawing.Color.Black;
            this.lbl_filtro.Location = new System.Drawing.Point(17, 594);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(50, 17);
            this.lbl_filtro.TabIndex = 18;
            this.lbl_filtro.Text = "Total:";
            // 
            // dgv_altas
            // 
            this.dgv_altas.AllowUserToAddRows = false;
            this.dgv_altas.AllowUserToDeleteRows = false;
            this.dgv_altas.AllowUserToResizeColumns = false;
            this.dgv_altas.AllowUserToResizeRows = false;
            this.dgv_altas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_altas.CausesValidation = false;
            this.dgv_altas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_altas.Location = new System.Drawing.Point(13, 56);
            this.dgv_altas.MultiSelect = false;
            this.dgv_altas.Name = "dgv_altas";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_altas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_altas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgv_altas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_altas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_altas.ShowCellErrors = false;
            this.dgv_altas.Size = new System.Drawing.Size(1027, 523);
            this.dgv_altas.TabIndex = 15;
            this.dgv_altas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv_altas_CellFormatting);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_exportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.ForeColor = System.Drawing.Color.White;
            this.btn_exportar.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar.Location = new System.Drawing.Point(986, 585);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(53, 34);
            this.btn_exportar.TabIndex = 17;
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.Btn_exportar_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.ForeColor = System.Drawing.Color.White;
            this.btn_reporte.Image = global::CsPresentacion.Properties.Resources.Adobe_PDF_Document_icon;
            this.btn_reporte.Location = new System.Drawing.Point(923, 584);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(57, 34);
            this.btn_reporte.TabIndex = 16;
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Frm_Listado_Altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 628);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_filtro);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.dgv_altas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Listado_Altas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Altas";
            this.Load += new System.EventHandler(this.Frm_Listado_Altas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_altas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nuevo;
        public System.Windows.Forms.TextBox txt_semana;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmb_puesto;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmb_departamento;
        public System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmb_año;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.DataGridView dgv_altas;
        private System.Windows.Forms.Timer timer1;
    }
}