namespace CsPresentacion
{
    partial class Bajas_Contabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bajas_Contabilidad));
            this.FM_LISTADO_BAJASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Bajas = new CsPresentacion.DS_Bajas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FM_LISTADO_BAJASTableAdapter = new CsPresentacion.DS_BajasTableAdapters.FM_LISTADO_BAJASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FM_LISTADO_BAJASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Bajas)).BeginInit();
            this.SuspendLayout();
            // 
            // FM_LISTADO_BAJASBindingSource
            // 
            this.FM_LISTADO_BAJASBindingSource.DataMember = "FM_LISTADO_BAJAS";
            this.FM_LISTADO_BAJASBindingSource.DataSource = this.DS_Bajas;
            // 
            // DS_Bajas
            // 
            this.DS_Bajas.DataSetName = "DS_Bajas";
            this.DS_Bajas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FM_LISTADO_BAJASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Bajas_Contabilidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(980, 494);
            this.reportViewer1.TabIndex = 0;
            // 
            // FM_LISTADO_BAJASTableAdapter
            // 
            this.FM_LISTADO_BAJASTableAdapter.ClearBeforeFill = true;
            // 
            // Bajas_Contabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 494);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bajas_Contabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Bajas";
            this.Load += new System.EventHandler(this.Bajas_Contabilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FM_LISTADO_BAJASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Bajas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FM_LISTADO_BAJASBindingSource;
        private DS_Bajas DS_Bajas;
        private DS_BajasTableAdapters.FM_LISTADO_BAJASTableAdapter FM_LISTADO_BAJASTableAdapter;
    }
}