namespace CsPresentacion
{
    partial class Rotacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rotacion));
            this.SP_rep_rotacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Rotacion = new CsPresentacion.DS_Rotacion();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_rep_rotacionTableAdapter = new CsPresentacion.DS_RotacionTableAdapters.SP_rep_rotacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_rep_rotacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Rotacion)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_rep_rotacionBindingSource
            // 
            this.SP_rep_rotacionBindingSource.DataMember = "SP_rep_rotacion";
            this.SP_rep_rotacionBindingSource.DataSource = this.DS_Rotacion;
            // 
            // DS_Rotacion
            // 
            this.DS_Rotacion.DataSetName = "DS_Rotacion";
            this.DS_Rotacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_rep_rotacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_total_rotacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(835, 613);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_rep_rotacionTableAdapter
            // 
            this.SP_rep_rotacionTableAdapter.ClearBeforeFill = true;
            // 
            // Rotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 613);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rotacion";
            this.Text = "Rotación";
            this.Load += new System.EventHandler(this.Rotacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_rep_rotacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Rotacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_rep_rotacionBindingSource;
        private DS_Rotacion DS_Rotacion;
        private DS_RotacionTableAdapters.SP_rep_rotacionTableAdapter SP_rep_rotacionTableAdapter;
    }
}