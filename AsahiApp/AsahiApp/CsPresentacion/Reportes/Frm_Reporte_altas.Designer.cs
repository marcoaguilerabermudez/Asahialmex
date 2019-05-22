namespace CsPresentacion
{
    partial class Frm_Reporte_altas
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
            this.FM_LISTADO_ALTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Altas1 = new CsPresentacion.DS_Altas1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FM_LISTADO_ALTASTableAdapter = new CsPresentacion.DS_Altas1TableAdapters.FM_LISTADO_ALTASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FM_LISTADO_ALTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Altas1)).BeginInit();
            this.SuspendLayout();
            // 
            // FM_LISTADO_ALTASBindingSource
            // 
            this.FM_LISTADO_ALTASBindingSource.DataMember = "FM_LISTADO_ALTAS";
            this.FM_LISTADO_ALTASBindingSource.DataSource = this.DS_Altas1;
            // 
            // DS_Altas1
            // 
            this.DS_Altas1.DataSetName = "DS_Altas1";
            this.DS_Altas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FM_LISTADO_ALTASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Altas1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1133, 634);
            this.reportViewer1.TabIndex = 0;
            // 
            // FM_LISTADO_ALTASTableAdapter
            // 
            this.FM_LISTADO_ALTASTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Reporte_altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1133, 634);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte_altas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Altas de Empleados";
            this.Load += new System.EventHandler(this.Frm_Reporte_altas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FM_LISTADO_ALTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Altas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FM_LISTADO_ALTASBindingSource;
        private DS_Altas1 DS_Altas1;
        private DS_Altas1TableAdapters.FM_LISTADO_ALTASTableAdapter FM_LISTADO_ALTASTableAdapter;
    }
}