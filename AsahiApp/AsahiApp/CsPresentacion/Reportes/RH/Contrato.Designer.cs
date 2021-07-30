namespace CsPresentacion
{
    partial class Frm_Rep_Alta_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rep_Alta_empleado));
            this.Sp_Genera_ContratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Contrato_empleado = new CsPresentacion.DS_Contrato_empleado();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_Genera_ContratoTableAdapter = new CsPresentacion.DS_Contrato_empleadoTableAdapters.Sp_Genera_ContratoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Genera_ContratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Contrato_empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_Genera_ContratoBindingSource
            // 
            this.Sp_Genera_ContratoBindingSource.DataMember = "Sp_Genera_Contrato";
            this.Sp_Genera_ContratoBindingSource.DataSource = this.DS_Contrato_empleado;
            // 
            // DS_Contrato_empleado
            // 
            this.DS_Contrato_empleado.DataSetName = "DS_Contrato_empleado";
            this.DS_Contrato_empleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_Genera_ContratoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Contrato_.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(896, 729);
            this.reportViewer1.TabIndex = 0;
            // 
            // Sp_Genera_ContratoTableAdapter
            // 
            this.Sp_Genera_ContratoTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Rep_Alta_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 729);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Rep_Alta_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato de empleado";
            this.Load += new System.EventHandler(this.Frm_Rep_Alta_empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Genera_ContratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Contrato_empleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_Genera_ContratoBindingSource;
        private DS_Contrato_empleado DS_Contrato_empleado;
        private DS_Contrato_empleadoTableAdapters.Sp_Genera_ContratoTableAdapter Sp_Genera_ContratoTableAdapter;
    }
}