namespace CsPresentacion
{
    partial class Frm_Cambio_Depto
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
            this.lbl_clave = new System.Windows.Forms.Label();
            this.l_hora = new System.Windows.Forms.Label();
            this.l_fecha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_departamento = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.Location = new System.Drawing.Point(162, 54);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(37, 13);
            this.lbl_clave.TabIndex = 29;
            this.lbl_clave.Text = "Clave:";
            // 
            // l_hora
            // 
            this.l_hora.AutoSize = true;
            this.l_hora.Location = new System.Drawing.Point(99, 54);
            this.l_hora.Name = "l_hora";
            this.l_hora.Size = new System.Drawing.Size(33, 13);
            this.l_hora.TabIndex = 28;
            this.l_hora.Text = "Hora:";
            // 
            // l_fecha
            // 
            this.l_fecha.AutoSize = true;
            this.l_fecha.Location = new System.Drawing.Point(15, 54);
            this.l_fecha.Name = "l_fecha";
            this.l_fecha.Size = new System.Drawing.Size(40, 13);
            this.l_fecha.TabIndex = 27;
            this.l_fecha.Text = "Fecha:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(131, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Location = new System.Drawing.Point(15, 84);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(71, 28);
            this.btn_aceptar.TabIndex = 25;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "DEPARTAMENTO:";
            // 
            // cmb_departamento
            // 
            this.cmb_departamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_departamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_departamento.FormattingEnabled = true;
            this.cmb_departamento.Location = new System.Drawing.Point(15, 20);
            this.cmb_departamento.Name = "cmb_departamento";
            this.cmb_departamento.Size = new System.Drawing.Size(198, 21);
            this.cmb_departamento.TabIndex = 23;
            this.cmb_departamento.SelectedIndexChanged += new System.EventHandler(this.Cmb_departamento_SelectedIndexChanged);
            this.cmb_departamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_departamento_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Frm_Cambio_Depto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(225, 119);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.l_hora);
            this.Controls.Add(this.l_fecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_departamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Cambio_Depto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Cambio_Depto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.Label l_hora;
        private System.Windows.Forms.Label l_fecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmb_departamento;
        private System.Windows.Forms.Timer timer1;
    }
}