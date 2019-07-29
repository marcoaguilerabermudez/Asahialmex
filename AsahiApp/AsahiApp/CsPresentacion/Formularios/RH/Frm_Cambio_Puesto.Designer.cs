namespace CsPresentacion
{
    partial class Frm_cambio_puesto
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_puesto = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_fecha = new System.Windows.Forms.Label();
            this.l_hora = new System.Windows.Forms.Label();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(97, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Location = new System.Drawing.Point(9, 91);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(71, 28);
            this.btn_aceptar.TabIndex = 16;
            this.btn_aceptar.Text = "ACEPTAR";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "PUESTO:";
            // 
            // cmb_puesto
            // 
            this.cmb_puesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_puesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_puesto.FormattingEnabled = true;
            this.cmb_puesto.Location = new System.Drawing.Point(9, 22);
            this.cmb_puesto.Name = "cmb_puesto";
            this.cmb_puesto.Size = new System.Drawing.Size(170, 21);
            this.cmb_puesto.TabIndex = 14;
            this.cmb_puesto.SelectedIndexChanged += new System.EventHandler(this.Cmb_puesto_SelectedIndexChanged);
            this.cmb_puesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_puesto_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // l_fecha
            // 
            this.l_fecha.AutoSize = true;
            this.l_fecha.Location = new System.Drawing.Point(10, 66);
            this.l_fecha.Name = "l_fecha";
            this.l_fecha.Size = new System.Drawing.Size(40, 13);
            this.l_fecha.TabIndex = 20;
            this.l_fecha.Text = "Fecha:";
            // 
            // l_hora
            // 
            this.l_hora.AutoSize = true;
            this.l_hora.Location = new System.Drawing.Point(64, 66);
            this.l_hora.Name = "l_hora";
            this.l_hora.Size = new System.Drawing.Size(33, 13);
            this.l_hora.TabIndex = 21;
            this.l_hora.Text = "Hora:";
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.Location = new System.Drawing.Point(118, 65);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(37, 13);
            this.lbl_clave.TabIndex = 22;
            this.lbl_clave.Text = "Clave:";
            // 
            // Frm_cambio_puesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(188, 123);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.l_hora);
            this.Controls.Add(this.l_fecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_puesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_cambio_puesto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_cambio_puesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_fecha;
        private System.Windows.Forms.Label l_hora;
        public System.Windows.Forms.ComboBox cmb_puesto;
        public System.Windows.Forms.Label lbl_clave;
    }
}