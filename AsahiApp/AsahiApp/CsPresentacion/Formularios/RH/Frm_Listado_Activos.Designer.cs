namespace CsPresentacion
{
    partial class Frm_Listado_Activos
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
            this.dgv_activos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_puesto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_departamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.cmb_ant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Ant1 = new System.Windows.Forms.Label();
            this.lbl_Ant2 = new System.Windows.Forms.Label();
            this.lbl_Var = new System.Windows.Forms.Label();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_activos
            // 
            this.dgv_activos.AllowUserToAddRows = false;
            this.dgv_activos.AllowUserToDeleteRows = false;
            this.dgv_activos.AllowUserToResizeColumns = false;
            this.dgv_activos.AllowUserToResizeRows = false;
            this.dgv_activos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_activos.CausesValidation = false;
            this.dgv_activos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_activos.Location = new System.Drawing.Point(12, 64);
            this.dgv_activos.MultiSelect = false;
            this.dgv_activos.Name = "dgv_activos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_activos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_activos.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgv_activos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_activos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_activos.ShowCellErrors = false;
            this.dgv_activos.Size = new System.Drawing.Size(1055, 523);
            this.dgv_activos.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.cmb_genero);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_ant);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.cmb_puesto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_departamento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, -24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 73);
            this.panel1.TabIndex = 17;
            // 
            // cmb_puesto
            // 
            this.cmb_puesto.FormattingEnabled = true;
            this.cmb_puesto.Location = new System.Drawing.Point(190, 47);
            this.cmb_puesto.Name = "cmb_puesto";
            this.cmb_puesto.Size = new System.Drawing.Size(172, 21);
            this.cmb_puesto.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(187, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Puesto:";
            // 
            // cmb_departamento
            // 
            this.cmb_departamento.FormattingEnabled = true;
            this.cmb_departamento.Location = new System.Drawing.Point(12, 47);
            this.cmb_departamento.Name = "cmb_departamento";
            this.cmb_departamento.Size = new System.Drawing.Size(172, 21);
            this.cmb_departamento.TabIndex = 15;
            this.cmb_departamento.SelectedIndexChanged += new System.EventHandler(this.Cmb_departamento_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Departamento:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(63, 599);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(17, 17);
            this.lbl_total.TabIndex = 23;
            this.lbl_total.Text = "0";
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.ForeColor = System.Drawing.Color.Black;
            this.lbl_filtro.Location = new System.Drawing.Point(11, 599);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(50, 17);
            this.lbl_filtro.TabIndex = 22;
            this.lbl_filtro.Text = "Total:";
            // 
            // cmb_ant
            // 
            this.cmb_ant.FormattingEnabled = true;
            this.cmb_ant.Items.AddRange(new object[] {
            "MENOS DE DOS SEMANAS",
            "DOS SEMANAS A UN MES",
            "UN MES A TRES MESES",
            "TRES MESES A SEIS MESES",
            "SEIS MESES A UN AÑO",
            "UN AÑO A DOS AÑOS",
            "MAS DE DOS AÑOS"});
            this.cmb_ant.Location = new System.Drawing.Point(370, 46);
            this.cmb_ant.Name = "cmb_ant";
            this.cmb_ant.Size = new System.Drawing.Size(172, 21);
            this.cmb_ant.TabIndex = 25;
            this.cmb_ant.SelectedIndexChanged += new System.EventHandler(this.Cmb_ant_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(367, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Antigüedad:";
            // 
            // cmb_genero
            // 
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmb_genero.Location = new System.Drawing.Point(548, 46);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(51, 21);
            this.cmb_genero.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(545, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Genero:";
            // 
            // lbl_Ant1
            // 
            this.lbl_Ant1.AutoSize = true;
            this.lbl_Ant1.Location = new System.Drawing.Point(170, 601);
            this.lbl_Ant1.Name = "lbl_Ant1";
            this.lbl_Ant1.Size = new System.Drawing.Size(39, 13);
            this.lbl_Ant1.TabIndex = 24;
            this.lbl_Ant1.Text = "@ant1";
            // 
            // lbl_Ant2
            // 
            this.lbl_Ant2.AutoSize = true;
            this.lbl_Ant2.Location = new System.Drawing.Point(283, 601);
            this.lbl_Ant2.Name = "lbl_Ant2";
            this.lbl_Ant2.Size = new System.Drawing.Size(39, 13);
            this.lbl_Ant2.TabIndex = 25;
            this.lbl_Ant2.Text = "@ant2";
            // 
            // lbl_Var
            // 
            this.lbl_Var.AutoSize = true;
            this.lbl_Var.Location = new System.Drawing.Point(414, 599);
            this.lbl_Var.Name = "lbl_Var";
            this.lbl_Var.Size = new System.Drawing.Size(34, 13);
            this.lbl_Var.TabIndex = 26;
            this.lbl_Var.Text = "@Var";
            // 
            // btn_exportar
            // 
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar.Location = new System.Drawing.Point(1001, 590);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(53, 34);
            this.btn_exportar.TabIndex = 21;
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.Btn_exportar_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Image = global::CsPresentacion.Properties.Resources.Adobe_PDF_Document_icon;
            this.btn_reporte.Location = new System.Drawing.Point(943, 589);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(57, 34);
            this.btn_reporte.TabIndex = 20;
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(656, 42);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 24;
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
            this.btn_buscar.Location = new System.Drawing.Point(614, 38);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(29, 34);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Frm_Listado_Activos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 625);
            this.Controls.Add(this.lbl_Var);
            this.Controls.Add(this.lbl_Ant2);
            this.Controls.Add(this.lbl_Ant1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_filtro);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_activos);
            this.Name = "Frm_Listado_Activos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Activos";
            this.Load += new System.EventHandler(this.Frm_Listado_Activos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_activos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.ComboBox cmb_puesto;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmb_departamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_reporte;
        public System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmb_ant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Ant1;
        private System.Windows.Forms.Label lbl_Ant2;
        private System.Windows.Forms.Label lbl_Var;
    }
}