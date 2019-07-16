namespace CsPresentacion
{
    partial class Rep_Credenciales
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SP_Credencial_EmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Credenciales = new CsPresentacion.DS_Credenciales();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_Credencial_EmpleadosTableAdapter = new CsPresentacion.DS_CredencialesTableAdapters.SP_Credencial_EmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Credencial_EmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Credenciales)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_Credencial_EmpleadosBindingSource
            // 
            this.SP_Credencial_EmpleadosBindingSource.DataMember = "SP_Credencial_Empleados";
            this.SP_Credencial_EmpleadosBindingSource.DataSource = this.DS_Credenciales;
            // 
            // DS_Credenciales
            // 
            this.DS_Credenciales.DataSetName = "DS_Credenciales";
            this.DS_Credenciales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_Credencial_EmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Credenciales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(522, 476);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_Credencial_EmpleadosTableAdapter
            // 
            this.SP_Credencial_EmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // Rep_Credenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 476);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rep_Credenciales";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credenciales";
            this.Load += new System.EventHandler(this.Frm_Rep_Cre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_Credencial_EmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Credenciales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Credencial_EmpleadosBindingSource;
        private DS_Credenciales DS_Credenciales;
        private DS_CredencialesTableAdapters.SP_Credencial_EmpleadosTableAdapter SP_Credencial_EmpleadosTableAdapter;
    }
}