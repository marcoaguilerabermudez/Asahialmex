namespace CsPresentacion
{
    partial class Ausentismo_Global
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtm_fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dgv_acumulado = new System.Windows.Forms.DataGridView();
            this.btn_exportar_ant2 = new System.Windows.Forms.Button();
            this.dgv_total = new System.Windows.Forms.DataGridView();
            this.txt_depto = new System.Windows.Forms.TextBox();
            this.lbl_plan = new System.Windows.Forms.Label();
            this.lbl_activos = new System.Windows.Forms.Label();
            this.lbl_incidencias = new System.Windows.Forms.Label();
            this.lbl_reporte = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acumulado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_total)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.dtm_fecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(-1, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 69);
            this.panel1.TabIndex = 143;
            // 
            // dtm_fecha
            // 
            this.dtm_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_fecha.Location = new System.Drawing.Point(18, 45);
            this.dtm_fecha.Name = "dtm_fecha";
            this.dtm_fecha.Size = new System.Drawing.Size(125, 20);
            this.dtm_fecha.TabIndex = 29;
            this.dtm_fecha.ValueChanged += new System.EventHandler(this.Dtm_fecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "FECHA:";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(148, 42);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 26;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // dgv_acumulado
            // 
            this.dgv_acumulado.AllowUserToAddRows = false;
            this.dgv_acumulado.AllowUserToDeleteRows = false;
            this.dgv_acumulado.AllowUserToResizeColumns = false;
            this.dgv_acumulado.AllowUserToResizeRows = false;
            this.dgv_acumulado.BackgroundColor = System.Drawing.Color.White;
            this.dgv_acumulado.CausesValidation = false;
            this.dgv_acumulado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_acumulado.Location = new System.Drawing.Point(15, 68);
            this.dgv_acumulado.MultiSelect = false;
            this.dgv_acumulado.Name = "dgv_acumulado";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_acumulado.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_acumulado.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgv_acumulado.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_acumulado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_acumulado.ShowCellErrors = false;
            this.dgv_acumulado.Size = new System.Drawing.Size(380, 581);
            this.dgv_acumulado.TabIndex = 144;
            this.dgv_acumulado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_acumulado_CellContentClick);
            this.dgv_acumulado.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_acumulado_RowEnter);
            // 
            // btn_exportar_ant2
            // 
            this.btn_exportar_ant2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar_ant2.FlatAppearance.BorderSize = 0;
            this.btn_exportar_ant2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar_ant2.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar_ant2.Location = new System.Drawing.Point(401, 612);
            this.btn_exportar_ant2.Name = "btn_exportar_ant2";
            this.btn_exportar_ant2.Size = new System.Drawing.Size(40, 34);
            this.btn_exportar_ant2.TabIndex = 191;
            this.btn_exportar_ant2.UseVisualStyleBackColor = true;
            this.btn_exportar_ant2.Click += new System.EventHandler(this.Btn_exportar_ant2_Click);
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
            this.dgv_total.Location = new System.Drawing.Point(409, 68);
            this.dgv_total.MultiSelect = false;
            this.dgv_total.Name = "dgv_total";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_total.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_total.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgv_total.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_total.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_total.ShowCellErrors = false;
            this.dgv_total.Size = new System.Drawing.Size(589, 67);
            this.dgv_total.TabIndex = 192;
            // 
            // txt_depto
            // 
            this.txt_depto.Location = new System.Drawing.Point(21, 656);
            this.txt_depto.Name = "txt_depto";
            this.txt_depto.Size = new System.Drawing.Size(81, 20);
            this.txt_depto.TabIndex = 193;
            // 
            // lbl_plan
            // 
            this.lbl_plan.AutoSize = true;
            this.lbl_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plan.Location = new System.Drawing.Point(193, 659);
            this.lbl_plan.Name = "lbl_plan";
            this.lbl_plan.Size = new System.Drawing.Size(21, 13);
            this.lbl_plan.TabIndex = 194;
            this.lbl_plan.Text = "00";
            // 
            // lbl_activos
            // 
            this.lbl_activos.AutoSize = true;
            this.lbl_activos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activos.Location = new System.Drawing.Point(247, 660);
            this.lbl_activos.Name = "lbl_activos";
            this.lbl_activos.Size = new System.Drawing.Size(21, 13);
            this.lbl_activos.TabIndex = 195;
            this.lbl_activos.Text = "00";
            // 
            // lbl_incidencias
            // 
            this.lbl_incidencias.AutoSize = true;
            this.lbl_incidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incidencias.Location = new System.Drawing.Point(314, 660);
            this.lbl_incidencias.Name = "lbl_incidencias";
            this.lbl_incidencias.Size = new System.Drawing.Size(21, 13);
            this.lbl_incidencias.TabIndex = 196;
            this.lbl_incidencias.Text = "00";
            // 
            // lbl_reporte
            // 
            this.lbl_reporte.AutoSize = true;
            this.lbl_reporte.Location = new System.Drawing.Point(18, 51);
            this.lbl_reporte.Name = "lbl_reporte";
            this.lbl_reporte.Size = new System.Drawing.Size(130, 13);
            this.lbl_reporte.TabIndex = 197;
            this.lbl_reporte.Text = "REPORTE DIA DE AYER";
            // 
            // Ausentismo_Global
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 686);
            this.Controls.Add(this.lbl_reporte);
            this.Controls.Add(this.lbl_incidencias);
            this.Controls.Add(this.lbl_activos);
            this.Controls.Add(this.lbl_plan);
            this.Controls.Add(this.txt_depto);
            this.Controls.Add(this.dgv_total);
            this.Controls.Add(this.btn_exportar_ant2);
            this.Controls.Add(this.dgv_acumulado);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ausentismo_Global";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ausentismo Global";
            this.Load += new System.EventHandler(this.Ausentismo_Global_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acumulado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_acumulado;
        private System.Windows.Forms.Button btn_exportar_ant2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtm_fecha;
        private System.Windows.Forms.DataGridView dgv_total;
        private System.Windows.Forms.TextBox txt_depto;
        private System.Windows.Forms.Label lbl_plan;
        private System.Windows.Forms.Label lbl_activos;
        private System.Windows.Forms.Label lbl_incidencias;
        private System.Windows.Forms.Label lbl_reporte;
    }
}