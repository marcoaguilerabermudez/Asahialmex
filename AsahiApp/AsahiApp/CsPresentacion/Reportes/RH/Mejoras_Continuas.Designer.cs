namespace CsPresentacion
{
    partial class Frm_Rep_Mejoras3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rep_Mejoras3));
            this.Reporte_Mejoras_ContinuasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Mejoras3 = new CsPresentacion.DS_Mejoras3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_Mejoras_ContinuasTableAdapter = new CsPresentacion.DS_Mejoras3TableAdapters.Reporte_Mejoras_ContinuasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Mejoras_ContinuasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Mejoras3)).BeginInit();
            this.SuspendLayout();
            // 
            // Reporte_Mejoras_ContinuasBindingSource
            // 
            this.Reporte_Mejoras_ContinuasBindingSource.DataMember = "Reporte_Mejoras_Continuas";
            this.Reporte_Mejoras_ContinuasBindingSource.DataSource = this.DS_Mejoras3;
            // 
            // DS_Mejoras3
            // 
            this.DS_Mejoras3.DataSetName = "DS_Mejoras3";
            this.DS_Mejoras3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Reporte_Mejoras_ContinuasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Mejoras3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1128, 644);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reporte_Mejoras_ContinuasTableAdapter
            // 
            this.Reporte_Mejoras_ContinuasTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Rep_Mejoras3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 644);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rep_Mejoras3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Mejoras Continuas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Mejoras_ContinuasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Mejoras3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_Mejoras_ContinuasBindingSource;
        private DS_Mejoras3 DS_Mejoras3;
        private DS_Mejoras3TableAdapters.Reporte_Mejoras_ContinuasTableAdapter Reporte_Mejoras_ContinuasTableAdapter;
    }
}