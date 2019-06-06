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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS_Finiquito = new CsPresentacion.DS_Finiquito();
            this.Reporte_Pago_Finiquito_ImprimirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_Pago_Finiquito_ImprimirTableAdapter = new CsPresentacion.DS_FiniquitoTableAdapters.Reporte_Pago_Finiquito_ImprimirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Finiquito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Pago_Finiquito_ImprimirBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // DS_Finiquito
            // 
            this.DS_Finiquito.DataSetName = "DS_Finiquito";
            this.DS_Finiquito.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_Pago_Finiquito_ImprimirBindingSource
            // 
            this.Reporte_Pago_Finiquito_ImprimirBindingSource.DataMember = "Reporte_Pago_Finiquito_Imprimir";
            this.Reporte_Pago_Finiquito_ImprimirBindingSource.DataSource = this.DS_Finiquito;
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
            this.MinimizeBox = false;
            this.Name = "Rep_Finiquito";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Rep_Finiquito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Finiquito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Pago_Finiquito_ImprimirBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_Pago_Finiquito_ImprimirBindingSource;
        private DS_Finiquito DS_Finiquito;
        private DS_FiniquitoTableAdapters.Reporte_Pago_Finiquito_ImprimirTableAdapter Reporte_Pago_Finiquito_ImprimirTableAdapter;
    }
}