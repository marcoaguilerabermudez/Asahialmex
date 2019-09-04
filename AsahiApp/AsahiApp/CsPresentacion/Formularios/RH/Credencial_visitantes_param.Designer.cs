namespace CsPresentacion
{
    partial class Credencial_visitantes_param
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
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reporte.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_Reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reporte.ForeColor = System.Drawing.Color.Black;
            this.btn_Reporte.Location = new System.Drawing.Point(80, 51);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(81, 39);
            this.btn_Reporte.TabIndex = 244;
            this.btn_Reporte.Text = "&Generar";
            this.btn_Reporte.UseVisualStyleBackColor = true;
            this.btn_Reporte.Click += new System.EventHandler(this.Btn_eliminar_depto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 245;
            this.label1.Text = "CANTIDAD:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(16, 20);
            this.txt_cantidad.MaxLength = 3;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(64, 20);
            this.txt_cantidad.TabIndex = 246;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_cantidad_KeyPress);
            // 
            // Credencial_visitantes_param
            // 
            this.AcceptButton = this.btn_Reporte;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(168, 97);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Reporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Credencial_visitantes_param";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Credencial_visitantes_param_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantidad;
    }
}