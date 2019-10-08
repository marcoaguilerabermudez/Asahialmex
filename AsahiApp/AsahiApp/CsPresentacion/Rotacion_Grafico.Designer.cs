namespace CsPresentacion
{
    partial class Rotacion_Grafico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rotacion_Grafico));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS_Rotacion_grafica = new CsPresentacion.DS_Rotacion_grafica();
            this.SP_rep_rotacion_graficaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_rep_rotacion_graficaTableAdapter = new CsPresentacion.DS_Rotacion_graficaTableAdapters.SP_rep_rotacion_graficaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Rotacion_grafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_rep_rotacion_graficaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_rep_rotacion_graficaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_grafica_rotacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1270, 649);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_Rotacion_grafica
            // 
            this.DS_Rotacion_grafica.DataSetName = "DS_Rotacion_grafica";
            this.DS_Rotacion_grafica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_rep_rotacion_graficaBindingSource
            // 
            this.SP_rep_rotacion_graficaBindingSource.DataMember = "SP_rep_rotacion_grafica";
            this.SP_rep_rotacion_graficaBindingSource.DataSource = this.DS_Rotacion_grafica;
            // 
            // SP_rep_rotacion_graficaTableAdapter
            // 
            this.SP_rep_rotacion_graficaTableAdapter.ClearBeforeFill = true;
            // 
            // Rotacion_Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 649);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rotacion_Grafico";
            this.Text = "Reporte de Rotación";
            this.Load += new System.EventHandler(this.Rotacion_Grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Rotacion_grafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_rep_rotacion_graficaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_rep_rotacion_graficaBindingSource;
        private DS_Rotacion_grafica DS_Rotacion_grafica;
        private DS_Rotacion_graficaTableAdapters.SP_rep_rotacion_graficaTableAdapter SP_rep_rotacion_graficaTableAdapter;
    }
}