namespace CsPresentacion
{
    partial class Frm_Vacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Vacaciones));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS_Vacaciones = new CsPresentacion.DS_Vacaciones();
            this.SP_Reportes_VacacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_Reportes_VacacionesTableAdapter = new CsPresentacion.DS_VacacionesTableAdapters.SP_Reportes_VacacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Vacaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Reportes_VacacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Vacaciones";
            reportDataSource1.Value = this.SP_Reportes_VacacionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Vacaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(871, 546);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_Vacaciones
            // 
            this.DS_Vacaciones.DataSetName = "DS_Vacaciones";
            this.DS_Vacaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_Reportes_VacacionesBindingSource
            // 
            this.SP_Reportes_VacacionesBindingSource.DataMember = "SP_Reportes_Vacaciones";
            this.SP_Reportes_VacacionesBindingSource.DataSource = this.DS_Vacaciones;
            // 
            // SP_Reportes_VacacionesTableAdapter
            // 
            this.SP_Reportes_VacacionesTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Vacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 546);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Vacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Vacaciones";
            this.Load += new System.EventHandler(this.Frm_Vacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Vacaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Reportes_VacacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Reportes_VacacionesBindingSource;
        private DS_Vacaciones DS_Vacaciones;
        private DS_VacacionesTableAdapters.SP_Reportes_VacacionesTableAdapter SP_Reportes_VacacionesTableAdapter;
    }
}