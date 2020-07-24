namespace CsPresentacion
{
    partial class Frm_Historico_personal
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
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv_datos.Location = new System.Drawing.Point(12, 175);
            this.dgv_datos.MultiSelect = false;
            this.dgv_datos.Name = "dgv_datos";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_datos.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgv_datos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_datos.ShowCellErrors = false;
            this.dgv_datos.Size = new System.Drawing.Size(699, 228);
            this.dgv_datos.TabIndex = 23;
            this.dgv_datos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_datos_CellFormatting);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar.Location = new System.Drawing.Point(578, 413);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(32, 34);
            this.btn_exportar.TabIndex = 26;
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Image = global::CsPresentacion.Properties.Resources.Adobe_PDF_Document_icon;
            this.btn_reporte.Location = new System.Drawing.Point(643, 412);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(42, 34);
            this.btn_reporte.TabIndex = 25;
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txt_clave);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-5, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 65);
            this.panel1.TabIndex = 27;
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(17, 37);
            this.txt_clave.MaxLength = 6;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(93, 20);
            this.txt_clave.TabIndex = 25;
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave_KeyPress);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(113, 34);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 24;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "CLAVE:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(582, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 150;
            this.label2.Text = "NOMBRE:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(20, 94);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(457, 20);
            this.txt_nombre.TabIndex = 149;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            this.txt_nombre.Leave += new System.EventHandler(this.txt_nombre_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_estado);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 73);
            this.groupBox2.TabIndex = 152;
            this.groupBox2.TabStop = false;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(9, 52);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(57, 13);
            this.lbl_estado.TabIndex = 145;
            this.lbl_estado.Text = "ESTADO";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Historico_personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.dgv_datos);
            this.MaximizeBox = false;
            this.Name = "Frm_Historico_personal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Frm_Historico_personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Timer timer1;
    }
}