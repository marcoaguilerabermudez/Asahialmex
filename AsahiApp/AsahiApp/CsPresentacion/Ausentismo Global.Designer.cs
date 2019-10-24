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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtm_Termina = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ausentismo = new System.Windows.Forms.DataGridView();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_exportar_ant2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ausentismo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(148, 39);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 26;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.dtm_Termina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(-1, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 69);
            this.panel1.TabIndex = 143;
            // 
            // dtm_Termina
            // 
            this.dtm_Termina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_Termina.Location = new System.Drawing.Point(18, 42);
            this.dtm_Termina.Name = "dtm_Termina";
            this.dtm_Termina.Size = new System.Drawing.Size(125, 20);
            this.dtm_Termina.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "FECHA:";
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
            this.dgv_ausentismo.Location = new System.Drawing.Point(15, 82);
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
            this.dgv_ausentismo.Size = new System.Drawing.Size(467, 527);
            this.dgv_ausentismo.TabIndex = 144;
            // 
            // btn_reporte
            // 
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Image = global::CsPresentacion.Properties.Resources.Adobe_PDF_Document_icon;
            this.btn_reporte.Location = new System.Drawing.Point(1065, 620);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(57, 34);
            this.btn_reporte.TabIndex = 192;
            this.btn_reporte.UseVisualStyleBackColor = true;
            // 
            // btn_exportar_ant2
            // 
            this.btn_exportar_ant2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar_ant2.FlatAppearance.BorderSize = 0;
            this.btn_exportar_ant2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar_ant2.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar_ant2.Location = new System.Drawing.Point(1022, 620);
            this.btn_exportar_ant2.Name = "btn_exportar_ant2";
            this.btn_exportar_ant2.Size = new System.Drawing.Size(40, 34);
            this.btn_exportar_ant2.TabIndex = 191;
            this.btn_exportar_ant2.UseVisualStyleBackColor = true;
            // 
            // Ausentismo_Global
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 658);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.btn_exportar_ant2);
            this.Controls.Add(this.dgv_ausentismo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ausentismo_Global";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ausentismo Global";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ausentismo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_ausentismo;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_exportar_ant2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtm_Termina;
    }
}