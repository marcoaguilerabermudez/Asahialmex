namespace CsPresentacion
{
    partial class Frm_Registros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtm_termina = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_inicia = new System.Windows.Forms.DateTimePicker();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.lbl_var = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtm_termina);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtm_inicia);
            this.panel1.Controls.Add(this.txt_clave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(-2, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 69);
            this.panel1.TabIndex = 145;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(160, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "TERMINA";
            // 
            // dtm_termina
            // 
            this.dtm_termina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_termina.Location = new System.Drawing.Point(159, 42);
            this.dtm_termina.Name = "dtm_termina";
            this.dtm_termina.Size = new System.Drawing.Size(133, 20);
            this.dtm_termina.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "INICIA";
            // 
            // dtm_inicia
            // 
            this.dtm_inicia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_inicia.Location = new System.Drawing.Point(24, 42);
            this.dtm_inicia.Name = "dtm_inicia";
            this.dtm_inicia.Size = new System.Drawing.Size(129, 20);
            this.dtm_inicia.TabIndex = 30;
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(306, 42);
            this.txt_clave.MaxLength = 8;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(74, 20);
            this.txt_clave.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "CLAVE";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(383, 39);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 27;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // dgv_datos
            // 
            this.dgv_datos.AllowUserToAddRows = false;
            this.dgv_datos.AllowUserToDeleteRows = false;
            this.dgv_datos.AllowUserToResizeColumns = false;
            this.dgv_datos.AllowUserToResizeRows = false;
            this.dgv_datos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_datos.CausesValidation = false;
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Location = new System.Drawing.Point(22, 73);
            this.dgv_datos.MultiSelect = false;
            this.dgv_datos.Name = "dgv_datos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_datos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_datos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datos.ShowCellErrors = false;
            this.dgv_datos.Size = new System.Drawing.Size(780, 487);
            this.dgv_datos.TabIndex = 240;
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
            this.btn_reporte.Location = new System.Drawing.Point(743, 567);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(57, 34);
            this.btn_reporte.TabIndex = 241;
            this.btn_reporte.UseVisualStyleBackColor = true;
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
            this.btn_exportar.Location = new System.Drawing.Point(678, 567);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(53, 34);
            this.btn_exportar.TabIndex = 242;
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // lbl_var
            // 
            this.lbl_var.AutoSize = true;
            this.lbl_var.Location = new System.Drawing.Point(27, 578);
            this.lbl_var.Name = "lbl_var";
            this.lbl_var.Size = new System.Drawing.Size(13, 13);
            this.lbl_var.TabIndex = 243;
            this.lbl_var.Text = "1";
            // 
            // Frm_Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 610);
            this.Controls.Add(this.lbl_var);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.dgv_datos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Registros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Huellas";
            this.Load += new System.EventHandler(this.Frm_Registros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtm_termina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_inicia;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Label lbl_var;
    }
}