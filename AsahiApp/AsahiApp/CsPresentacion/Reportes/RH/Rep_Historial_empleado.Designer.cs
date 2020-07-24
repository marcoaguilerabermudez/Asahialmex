namespace CsPresentacion
{
    partial class Rep_Historial_empleado
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
            this.DS_Historial_Empleado = new CsPresentacion.DS_Historial_Empleado();
            this.sp_Historial_personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Historial_personalTableAdapter = new CsPresentacion.DS_Historial_EmpleadoTableAdapters.sp_Historial_personalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Historial_Empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Historial_personalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_Historial_personalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CsPresentacion.Rep_Historial_empleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(833, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // DS_Historial_Empleado
            // 
            this.DS_Historial_Empleado.DataSetName = "DS_Historial_Empleado";
            this.DS_Historial_Empleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_Historial_personalBindingSource
            // 
            this.sp_Historial_personalBindingSource.DataMember = "sp_Historial_personal";
            this.sp_Historial_personalBindingSource.DataSource = this.DS_Historial_Empleado;
            // 
            // sp_Historial_personalTableAdapter
            // 
            this.sp_Historial_personalTableAdapter.ClearBeforeFill = true;
            // 
            // Rep_Historial_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 473);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Rep_Historial_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial del Empleado";
            this.Load += new System.EventHandler(this.Rep_Historial_empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Historial_Empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Historial_personalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Historial_personalBindingSource;
        private DS_Historial_Empleado DS_Historial_Empleado;
        private DS_Historial_EmpleadoTableAdapters.sp_Historial_personalTableAdapter sp_Historial_personalTableAdapter;
    }
}