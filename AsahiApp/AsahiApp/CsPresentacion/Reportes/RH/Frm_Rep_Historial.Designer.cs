namespace CsPresentacion
{
    partial class Frm_Rep_Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rep_Historial));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DS_Historico = new CsPresentacion.DS_Historico();
            this.SP_historico_personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_historico_personalTableAdapter = new CsPresentacion.DS_HistoricoTableAdapters.SP_historico_personalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Historico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_historico_personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_historico_personalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Historico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1035, 572);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_Historico
            // 
            this.DS_Historico.DataSetName = "DS_Historico";
            this.DS_Historico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_historico_personalBindingSource
            // 
            this.SP_historico_personalBindingSource.DataMember = "SP_historico_personal";
            this.SP_historico_personalBindingSource.DataSource = this.DS_Historico;
            // 
            // SP_historico_personalTableAdapter
            // 
            this.SP_historico_personalTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Rep_Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 572);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rep_Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.Frm_Rep_Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Historico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_historico_personalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_historico_personalBindingSource;
        private DS_Historico DS_Historico;
        private DS_HistoricoTableAdapters.SP_historico_personalTableAdapter SP_historico_personalTableAdapter;
    }
}