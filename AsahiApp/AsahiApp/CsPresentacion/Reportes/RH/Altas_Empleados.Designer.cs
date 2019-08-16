namespace CsPresentacion
{
    partial class Altas_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Altas_Empleados));
            this.FM_LISTADO_ALTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Listado_Altas_Empleados = new CsPresentacion.DS_Listado_Altas_Empleados();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FM_LISTADO_ALTASTableAdapter = new CsPresentacion.DS_Listado_Altas_EmpleadosTableAdapters.FM_LISTADO_ALTASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FM_LISTADO_ALTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Listado_Altas_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // FM_LISTADO_ALTASBindingSource
            // 
            this.FM_LISTADO_ALTASBindingSource.DataMember = "FM_LISTADO_ALTAS";
            this.FM_LISTADO_ALTASBindingSource.DataSource = this.DS_Listado_Altas_Empleados;
            // 
            // DS_Listado_Altas_Empleados
            // 
            this.DS_Listado_Altas_Empleados.DataSetName = "DS_Listado_Altas_Empleados";
            this.DS_Listado_Altas_Empleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_ALTAS";
            reportDataSource1.Value = this.FM_LISTADO_ALTASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Listado_Altas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1259, 635);
            this.reportViewer1.TabIndex = 0;
            // 
            // FM_LISTADO_ALTASTableAdapter
            // 
            this.FM_LISTADO_ALTASTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 635);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte_Altas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Altas de Empleados";
            this.Load += new System.EventHandler(this.Reporte_Altas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FM_LISTADO_ALTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Listado_Altas_Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FM_LISTADO_ALTASBindingSource;
        private DS_Listado_Altas_Empleados DS_Listado_Altas_Empleados;
        private DS_Listado_Altas_EmpleadosTableAdapters.FM_LISTADO_ALTASTableAdapter FM_LISTADO_ALTASTableAdapter;
    }
}