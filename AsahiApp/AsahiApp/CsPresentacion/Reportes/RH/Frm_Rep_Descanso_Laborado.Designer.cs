namespace CsPresentacion
{
    partial class Frm_Rep_Descanso_Laborado
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS_Reportes_Prenomina = new CsPresentacion.DS_Reportes_Prenomina();
            this.SP_Reportes_Prenomina_FMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_Reportes_Prenomina_FMTableAdapter = new CsPresentacion.DS_Reportes_PrenominaTableAdapters.SP_Reportes_Prenomina_FMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes_Prenomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Reportes_Prenomina_FMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_Reportes_Prenomina_FMBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Descanso_Laborado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(928, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_Reportes_Prenomina
            // 
            this.DS_Reportes_Prenomina.DataSetName = "DS_Reportes_Prenomina";
            this.DS_Reportes_Prenomina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_Reportes_Prenomina_FMBindingSource
            // 
            this.SP_Reportes_Prenomina_FMBindingSource.DataMember = "SP_Reportes_Prenomina_FM";
            this.SP_Reportes_Prenomina_FMBindingSource.DataSource = this.DS_Reportes_Prenomina;
            // 
            // SP_Reportes_Prenomina_FMTableAdapter
            // 
            this.SP_Reportes_Prenomina_FMTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Rep_Descanso_Laborado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Rep_Descanso_Laborado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Descanso Laborado";
            this.Load += new System.EventHandler(this.Frm_Rep_Descanso_Laborado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Reportes_Prenomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Reportes_Prenomina_FMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Reportes_Prenomina_FMBindingSource;
        private DS_Reportes_Prenomina DS_Reportes_Prenomina;
        private DS_Reportes_PrenominaTableAdapters.SP_Reportes_Prenomina_FMTableAdapter SP_Reportes_Prenomina_FMTableAdapter;
    }
}