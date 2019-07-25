namespace CsPresentacion
{
    partial class Frm_Reporte_Anual_Mejoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reporte_Anual_Mejoras));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS_Mejoras_Anual2 = new CsPresentacion.DS_Mejoras_Anual2();
            this.Sp_graficaanualmejoraseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_graficaanualmejoraseTableAdapter = new CsPresentacion.DS_Mejoras_Anual2TableAdapters.Sp_graficaanualmejoraseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Mejoras_Anual2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_graficaanualmejoraseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_BUENO";
            reportDataSource1.Value = this.Sp_graficaanualmejoraseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Mejoras_anual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1123, 708);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_Mejoras_Anual2
            // 
            this.DS_Mejoras_Anual2.DataSetName = "DS_Mejoras_Anual2";
            this.DS_Mejoras_Anual2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_graficaanualmejoraseBindingSource
            // 
            this.Sp_graficaanualmejoraseBindingSource.DataMember = "Sp_graficaanualmejorase";
            this.Sp_graficaanualmejoraseBindingSource.DataSource = this.DS_Mejoras_Anual2;
            // 
            // Sp_graficaanualmejoraseTableAdapter
            // 
            this.Sp_graficaanualmejoraseTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_reporte_anual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 708);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_reporte_anual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Anual de Mejoras Continuas";
            this.Load += new System.EventHandler(this.Frm_reporte_anual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Mejoras_Anual2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_graficaanualmejoraseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_graficaanualmejoraseBindingSource;
        private DS_Mejoras_Anual2 DS_Mejoras_Anual2;
        private DS_Mejoras_Anual2TableAdapters.Sp_graficaanualmejoraseTableAdapter Sp_graficaanualmejoraseTableAdapter;
    }
}