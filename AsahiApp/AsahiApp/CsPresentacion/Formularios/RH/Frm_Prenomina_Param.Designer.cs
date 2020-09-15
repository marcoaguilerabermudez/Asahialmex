namespace CsPresentacion
{
    partial class Frm_Parametros_rep_prenomina
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_semana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_inicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtm_final = new System.Windows.Forms.DateTimePicker();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.lbl_var = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.txt_año = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tipo_aus = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEMANA:";
            // 
            // txt_semana
            // 
            this.txt_semana.Location = new System.Drawing.Point(97, 58);
            this.txt_semana.MaxLength = 2;
            this.txt_semana.Name = "txt_semana";
            this.txt_semana.Size = new System.Drawing.Size(57, 20);
            this.txt_semana.TabIndex = 2;
            this.txt_semana.TextChanged += new System.EventHandler(this.Txt_semana_TextChanged);
            this.txt_semana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_semana_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FECHA INICIAL:";
            // 
            // dtm_inicial
            // 
            this.dtm_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_inicial.Location = new System.Drawing.Point(17, 100);
            this.dtm_inicial.Name = "dtm_inicial";
            this.dtm_inicial.Size = new System.Drawing.Size(168, 20);
            this.dtm_inicial.TabIndex = 3;
            this.dtm_inicial.ValueChanged += new System.EventHandler(this.Dtm_inicial_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "FECHA FINAL:";
            // 
            // dtm_final
            // 
            this.dtm_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_final.Location = new System.Drawing.Point(17, 143);
            this.dtm_final.Name = "dtm_final";
            this.dtm_final.Size = new System.Drawing.Size(168, 20);
            this.dtm_final.TabIndex = 4;
            this.dtm_final.ValueChanged += new System.EventHandler(this.Dtm_final_ValueChanged);
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.White;
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Location = new System.Drawing.Point(97, 216);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(88, 35);
            this.btn_reporte.TabIndex = 5;
            this.btn_reporte.Text = "&Generar";
            this.btn_reporte.UseVisualStyleBackColor = false;
            this.btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // lbl_var
            // 
            this.lbl_var.AutoSize = true;
            this.lbl_var.Location = new System.Drawing.Point(3, 222);
            this.lbl_var.Name = "lbl_var";
            this.lbl_var.Size = new System.Drawing.Size(34, 13);
            this.lbl_var.TabIndex = 149;
            this.lbl_var.Text = "@Var";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(3, 239);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(39, 13);
            this.lbl_tipo.TabIndex = 150;
            this.lbl_tipo.Text = "@Tipo";
            // 
            // txt_año
            // 
            this.txt_año.Location = new System.Drawing.Point(17, 58);
            this.txt_año.MaxLength = 4;
            this.txt_año.Name = "txt_año";
            this.txt_año.Size = new System.Drawing.Size(57, 20);
            this.txt_año.TabIndex = 1;
            this.txt_año.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_año_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 151;
            this.label4.Text = "AÑO:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(18, 17);
            this.txt_clave.MaxLength = 7;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(56, 20);
            this.txt_clave.TabIndex = 0;
            this.txt_clave.TextChanged += new System.EventHandler(this.Txt_clave_TextChanged);
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_clave_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 153;
            this.label5.Text = "CLAVE";
            // 
            // lbl_tipo_aus
            // 
            this.lbl_tipo_aus.AutoSize = true;
            this.lbl_tipo_aus.Location = new System.Drawing.Point(16, 169);
            this.lbl_tipo_aus.Name = "lbl_tipo_aus";
            this.lbl_tipo_aus.Size = new System.Drawing.Size(35, 13);
            this.lbl_tipo_aus.TabIndex = 154;
            this.lbl_tipo_aus.Text = "TIPO:";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(17, 186);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(168, 21);
            this.cmb_tipo.TabIndex = 155;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.Cmb_tipo_SelectedIndexChanged);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(50, 224);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(43, 13);
            this.lbl_descripcion.TabIndex = 156;
            this.lbl_descripcion.Text = "@Desc";
            // 
            // Frm_Parametros_rep_prenomina
            // 
            this.AcceptButton = this.btn_reporte;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(198, 259);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.lbl_tipo_aus);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_año);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_var);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.dtm_final);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtm_inicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_semana);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Parametros_rep_prenomina";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Fecha_rep_prenomina_Load);
            this.TextChanged += new System.EventHandler(this.Frm_Fecha_rep_prenomina_TextChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Fecha_rep_prenomina_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_semana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_inicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtm_final;
        private System.Windows.Forms.Button btn_reporte;
        public System.Windows.Forms.Label lbl_var;
        public System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.TextBox txt_año;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_tipo_aus;
        private System.Windows.Forms.ComboBox cmb_tipo;
        public System.Windows.Forms.Label lbl_descripcion;
    }
}