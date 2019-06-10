namespace CsPresentacion
{
    partial class Frm_Altas
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
            this.Panel_principal = new System.Windows.Forms.Panel();
            this.btn_pp_siguiente = new System.Windows.Forms.Button();
            this.Panel_secundario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ps_anterior = new System.Windows.Forms.Button();
            this.btn_ps_siguiente = new System.Windows.Forms.Button();
            this.panel_final = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pf_finalizar = new System.Windows.Forms.Button();
            this.btn_pf_anterior = new System.Windows.Forms.Button();
            this.Panel_principal.SuspendLayout();
            this.Panel_secundario.SuspendLayout();
            this.panel_final.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_principal
            // 
            this.Panel_principal.Controls.Add(this.btn_pp_siguiente);
            this.Panel_principal.Location = new System.Drawing.Point(-8, -1);
            this.Panel_principal.Name = "Panel_principal";
            this.Panel_principal.Size = new System.Drawing.Size(647, 598);
            this.Panel_principal.TabIndex = 0;
            // 
            // btn_pp_siguiente
            // 
            this.btn_pp_siguiente.Location = new System.Drawing.Point(539, 550);
            this.btn_pp_siguiente.Name = "btn_pp_siguiente";
            this.btn_pp_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_pp_siguiente.TabIndex = 0;
            this.btn_pp_siguiente.Text = "Siguiente";
            this.btn_pp_siguiente.UseVisualStyleBackColor = true;
            this.btn_pp_siguiente.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Panel_secundario
            // 
            this.Panel_secundario.Controls.Add(this.label1);
            this.Panel_secundario.Controls.Add(this.btn_ps_anterior);
            this.Panel_secundario.Controls.Add(this.btn_ps_siguiente);
            this.Panel_secundario.Location = new System.Drawing.Point(645, 22);
            this.Panel_secundario.Name = "Panel_secundario";
            this.Panel_secundario.Size = new System.Drawing.Size(586, 559);
            this.Panel_secundario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Panel_2";
            // 
            // btn_ps_anterior
            // 
            this.btn_ps_anterior.Location = new System.Drawing.Point(31, 510);
            this.btn_ps_anterior.Name = "btn_ps_anterior";
            this.btn_ps_anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_ps_anterior.TabIndex = 2;
            this.btn_ps_anterior.Text = "Anterior";
            this.btn_ps_anterior.UseVisualStyleBackColor = true;
            this.btn_ps_anterior.Click += new System.EventHandler(this.Btn_ps_anterior_Click);
            // 
            // btn_ps_siguiente
            // 
            this.btn_ps_siguiente.Location = new System.Drawing.Point(490, 510);
            this.btn_ps_siguiente.Name = "btn_ps_siguiente";
            this.btn_ps_siguiente.Size = new System.Drawing.Size(75, 23);
            this.btn_ps_siguiente.TabIndex = 1;
            this.btn_ps_siguiente.Text = "Siguiente";
            this.btn_ps_siguiente.UseVisualStyleBackColor = true;
            this.btn_ps_siguiente.Click += new System.EventHandler(this.Btn_ps_siguiente_Click);
            // 
            // panel_final
            // 
            this.panel_final.Controls.Add(this.label2);
            this.panel_final.Controls.Add(this.btn_pf_finalizar);
            this.panel_final.Controls.Add(this.btn_pf_anterior);
            this.panel_final.Location = new System.Drawing.Point(1237, 22);
            this.panel_final.Name = "panel_final";
            this.panel_final.Size = new System.Drawing.Size(541, 559);
            this.panel_final.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Panel_3";
            // 
            // btn_pf_finalizar
            // 
            this.btn_pf_finalizar.Location = new System.Drawing.Point(447, 510);
            this.btn_pf_finalizar.Name = "btn_pf_finalizar";
            this.btn_pf_finalizar.Size = new System.Drawing.Size(75, 23);
            this.btn_pf_finalizar.TabIndex = 3;
            this.btn_pf_finalizar.Text = "Finalizar";
            this.btn_pf_finalizar.UseVisualStyleBackColor = true;
            // 
            // btn_pf_anterior
            // 
            this.btn_pf_anterior.Location = new System.Drawing.Point(17, 510);
            this.btn_pf_anterior.Name = "btn_pf_anterior";
            this.btn_pf_anterior.Size = new System.Drawing.Size(75, 23);
            this.btn_pf_anterior.TabIndex = 3;
            this.btn_pf_anterior.Text = "Anterior";
            this.btn_pf_anterior.UseVisualStyleBackColor = true;
            this.btn_pf_anterior.Click += new System.EventHandler(this.Btn_pf_anterior_Click);
            // 
            // Frm_Altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1851, 824);
            this.Controls.Add(this.Panel_secundario);
            this.Controls.Add(this.panel_final);
            this.Controls.Add(this.Panel_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Altas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Empleados";
            this.Load += new System.EventHandler(this.Frm_Altas_Load);
            this.Panel_principal.ResumeLayout(false);
            this.Panel_secundario.ResumeLayout(false);
            this.Panel_secundario.PerformLayout();
            this.panel_final.ResumeLayout(false);
            this.panel_final.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_principal;
        private System.Windows.Forms.Panel Panel_secundario;
        private System.Windows.Forms.Button btn_pp_siguiente;
        private System.Windows.Forms.Panel panel_final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ps_anterior;
        private System.Windows.Forms.Button btn_ps_siguiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pf_finalizar;
        private System.Windows.Forms.Button btn_pf_anterior;
    }
}