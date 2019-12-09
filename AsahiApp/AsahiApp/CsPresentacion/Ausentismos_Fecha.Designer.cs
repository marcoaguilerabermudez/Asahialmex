namespace CsPresentacion
{
    partial class Ausentismos_Fecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ausentismos_Fecha));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS_Ausentismos_Fecha = new CsPresentacion.DS_Ausentismos_Fecha();
            this.Ausentismo_FechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ausentismo_FechaTableAdapter = new CsPresentacion.DS_Ausentismos_FechaTableAdapters.Ausentismo_FechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Ausentismos_Fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ausentismo_FechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Ausentismo_FechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Ausentismo_Fecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1134, 568);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_Ausentismos_Fecha
            // 
            this.DS_Ausentismos_Fecha.DataSetName = "DS_Ausentismos_Fecha";
            this.DS_Ausentismos_Fecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ausentismo_FechaBindingSource
            // 
            this.Ausentismo_FechaBindingSource.DataMember = "Ausentismo_Fecha";
            this.Ausentismo_FechaBindingSource.DataSource = this.DS_Ausentismos_Fecha;
            // 
            // Ausentismo_FechaTableAdapter
            // 
            this.Ausentismo_FechaTableAdapter.ClearBeforeFill = true;
            // 
            // Ausentismos_Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 568);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ausentismos_Fecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ausentismos";
            this.Load += new System.EventHandler(this.Ausentismos_Fecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Ausentismos_Fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ausentismo_FechaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Ausentismo_FechaBindingSource;
        private DS_Ausentismos_Fecha DS_Ausentismos_Fecha;
        private DS_Ausentismos_FechaTableAdapters.Ausentismo_FechaTableAdapter Ausentismo_FechaTableAdapter;
    }
}