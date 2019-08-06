namespace CsPresentacion
{
    partial class Listado_Activos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_Activos));
            this.FM_LISTADO_ACTIVOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Listado_Activos = new CsPresentacion.DS_Listado_Activos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FM_LISTADO_ACTIVOSTableAdapter = new CsPresentacion.DS_Listado_ActivosTableAdapters.FM_LISTADO_ACTIVOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FM_LISTADO_ACTIVOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Listado_Activos)).BeginInit();
            this.SuspendLayout();
            // 
            // FM_LISTADO_ACTIVOSBindingSource
            // 
            this.FM_LISTADO_ACTIVOSBindingSource.DataMember = "FM_LISTADO_ACTIVOS";
            this.FM_LISTADO_ACTIVOSBindingSource.DataSource = this.DS_Listado_Activos;
            // 
            // DS_Listado_Activos
            // 
            this.DS_Listado_Activos.DataSetName = "DS_Listado_Activos";
            this.DS_Listado_Activos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FM_LISTADO_ACTIVOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Listado_Activos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1080, 625);
            this.reportViewer1.TabIndex = 0;
            // 
            // FM_LISTADO_ACTIVOSTableAdapter
            // 
            this.FM_LISTADO_ACTIVOSTableAdapter.ClearBeforeFill = true;
            // 
            // Listado_Activos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 625);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listado_Activos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Activos";
            this.Load += new System.EventHandler(this.Listado_Activos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FM_LISTADO_ACTIVOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Listado_Activos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FM_LISTADO_ACTIVOSBindingSource;
        private DS_Listado_Activos DS_Listado_Activos;
        private DS_Listado_ActivosTableAdapters.FM_LISTADO_ACTIVOSTableAdapter FM_LISTADO_ACTIVOSTableAdapter;
    }
}