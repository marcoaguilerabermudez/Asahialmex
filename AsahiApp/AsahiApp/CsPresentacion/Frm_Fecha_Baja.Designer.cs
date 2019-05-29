namespace CsPresentacion
{
    partial class Frm_Fecha_Baja
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
            this.lbl_clave_empleado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_motivo = new System.Windows.Forms.ComboBox();
            this.dtm_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_motivo = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_clave_empleado
            // 
            this.lbl_clave_empleado.AutoSize = true;
            this.lbl_clave_empleado.Location = new System.Drawing.Point(11, 170);
            this.lbl_clave_empleado.Name = "lbl_clave_empleado";
            this.lbl_clave_empleado.Size = new System.Drawing.Size(34, 13);
            this.lbl_clave_empleado.TabIndex = 14;
            this.lbl_clave_empleado.Text = "Clave";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(98, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Location = new System.Drawing.Point(10, 135);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(71, 28);
            this.btn_aceptar.TabIndex = 12;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "MOTIVO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "FECHA:";
            // 
            // cmb_motivo
            // 
            this.cmb_motivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_motivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_motivo.FormattingEnabled = true;
            this.cmb_motivo.Location = new System.Drawing.Point(10, 71);
            this.cmb_motivo.Name = "cmb_motivo";
            this.cmb_motivo.Size = new System.Drawing.Size(170, 21);
            this.cmb_motivo.TabIndex = 9;
            this.cmb_motivo.SelectedIndexChanged += new System.EventHandler(this.Cmb_motivo_SelectedIndexChanged);
            // 
            // dtm_fecha
            // 
            this.dtm_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_fecha.Location = new System.Drawing.Point(10, 26);
            this.dtm_fecha.Name = "dtm_fecha";
            this.dtm_fecha.Size = new System.Drawing.Size(170, 20);
            this.dtm_fecha.TabIndex = 8;
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.AutoSize = true;
            this.lbl_motivo.Location = new System.Drawing.Point(61, 170);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(39, 13);
            this.lbl_motivo.TabIndex = 15;
            this.lbl_motivo.Text = "Motivo";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(117, 170);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 16;
            this.lbl_usuario.Text = "Usuario";
            // 
            // Frm_Fecha_Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(195, 189);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_motivo);
            this.Controls.Add(this.lbl_clave_empleado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_motivo);
            this.Controls.Add(this.dtm_fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Fecha_Baja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Fecha_Baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_clave_empleado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_motivo;
        private System.Windows.Forms.DateTimePicker dtm_fecha;
        public System.Windows.Forms.Label lbl_motivo;
        public System.Windows.Forms.Label lbl_usuario;
    }
}