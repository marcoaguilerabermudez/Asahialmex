namespace CsPresentacion
{
    partial class Rep_Ausentismo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rep_Ausentismo));
            this.Ausentismo_GlobalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Ausentismo_Global = new CsPresentacion.DS_Ausentismo_Global();
            this.Ausentismo_GlobalTableAdapter = new CsPresentacion.DS_Ausentismo_GlobalTableAdapters.Ausentismo_GlobalTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Ausentismo_GlobalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Ausentismo_Global)).BeginInit();
            this.SuspendLayout();
            // 
            // Ausentismo_GlobalBindingSource
            // 
            this.Ausentismo_GlobalBindingSource.DataMember = "Ausentismo_Global";
            this.Ausentismo_GlobalBindingSource.DataSource = this.DS_Ausentismo_Global;
            // 
            // DS_Ausentismo_Global
            // 
            this.DS_Ausentismo_Global.DataSetName = "DS_Ausentismo_Global";
            this.DS_Ausentismo_Global.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ausentismo_GlobalTableAdapter
            // 
            this.Ausentismo_GlobalTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Ausentismo_GlobalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Ausentismo_dia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1074, 526);
            this.reportViewer1.TabIndex = 0;
            // 
            // Rep_Ausentismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 526);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rep_Ausentismo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ausentismo";
            this.Load += new System.EventHandler(this.Rep_Ausentismo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ausentismo_GlobalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Ausentismo_Global)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Ausentismo_GlobalBindingSource;
        private DS_Ausentismo_Global DS_Ausentismo_Global;
        private DS_Ausentismo_GlobalTableAdapters.Ausentismo_GlobalTableAdapter Ausentismo_GlobalTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}