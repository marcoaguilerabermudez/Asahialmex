namespace CsPresentacion
{
    partial class Incapacidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incapacidades));
            this.SP_Reportes_Prenomina2_FMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Prenomina_2 = new CsPresentacion.DS_Prenomina_2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_Reportes_Prenomina2_FMTableAdapter = new CsPresentacion.DS_Prenomina_2TableAdapters.SP_Reportes_Prenomina2_FMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Reportes_Prenomina2_FMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Prenomina_2)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_Reportes_Prenomina2_FMBindingSource
            // 
            this.SP_Reportes_Prenomina2_FMBindingSource.DataMember = "SP_Reportes_Prenomina2_FM";
            this.SP_Reportes_Prenomina2_FMBindingSource.DataSource = this.DS_Prenomina_2;
            // 
            // DS_Prenomina_2
            // 
            this.DS_Prenomina_2.DataSetName = "DS_Prenomina_2";
            this.DS_Prenomina_2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Incapacidades";
            reportDataSource1.Value = this.SP_Reportes_Prenomina2_FMBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Incapacidades.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1048, 548);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_Reportes_Prenomina2_FMTableAdapter
            // 
            this.SP_Reportes_Prenomina2_FMTableAdapter.ClearBeforeFill = true;
            // 
            // Incapacidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 548);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Incapacidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Incapacidades";
            this.Load += new System.EventHandler(this.Incapacidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_Reportes_Prenomina2_FMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Prenomina_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Reportes_Prenomina2_FMBindingSource;
        private DS_Prenomina_2 DS_Prenomina_2;
        private DS_Prenomina_2TableAdapters.SP_Reportes_Prenomina2_FMTableAdapter SP_Reportes_Prenomina2_FMTableAdapter;
    }
}