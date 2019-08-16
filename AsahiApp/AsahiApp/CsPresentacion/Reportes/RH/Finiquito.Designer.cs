namespace CsPresentacion
{
    partial class Rep_Finiquito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rep_Finiquito));
            this.Reporte_Pago_Finiquito_ImprimirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Finiquito = new CsPresentacion.DS_Finiquito();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_Pago_Finiquito_ImprimirTableAdapter = new CsPresentacion.DS_FiniquitoTableAdapters.Reporte_Pago_Finiquito_ImprimirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Pago_Finiquito_ImprimirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Finiquito)).BeginInit();
            this.SuspendLayout();
            // 
            // Reporte_Pago_Finiquito_ImprimirBindingSource
            // 
            this.Reporte_Pago_Finiquito_ImprimirBindingSource.DataMember = "Reporte_Pago_Finiquito_Imprimir";
            this.Reporte_Pago_Finiquito_ImprimirBindingSource.DataSource = this.DS_Finiquito;
            // 
            // DS_Finiquito
            // 
            this.DS_Finiquito.DataSetName = "DS_Finiquito";
            this.DS_Finiquito.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Reporte_Pago_Finiquito_ImprimirBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Finiquito.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 464);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reporte_Pago_Finiquito_ImprimirTableAdapter
            // 
            this.Reporte_Pago_Finiquito_ImprimirTableAdapter.ClearBeforeFill = true;
            // 
            // Rep_Finiquito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 464);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rep_Finiquito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finiquito";
            this.Load += new System.EventHandler(this.Rep_Finiquito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Pago_Finiquito_ImprimirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Finiquito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_Pago_Finiquito_ImprimirBindingSource;
        private DS_Finiquito DS_Finiquito;
        private DS_FiniquitoTableAdapters.Reporte_Pago_Finiquito_ImprimirTableAdapter Reporte_Pago_Finiquito_ImprimirTableAdapter;
    }
}