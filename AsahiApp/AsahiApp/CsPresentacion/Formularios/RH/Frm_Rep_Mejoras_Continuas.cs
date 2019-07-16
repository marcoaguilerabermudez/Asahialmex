using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsPresentacion
{
    public partial class Frm_Rep_Mejoras3 : Form
    {
        public Frm_Rep_Mejoras3()
        {
            InitializeComponent();
        }

        public Int32 VAR;
        public Int32 CLAVE;
        public String MES;
        public String DEPARTAMENTO;
     

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Mejoras3.Reporte_Mejoras_Continuas' Puede moverla o quitarla según sea necesario.
            this.Reporte_Mejoras_ContinuasTableAdapter.Fill(this.DS_Mejoras3.Reporte_Mejoras_Continuas, VAR, CLAVE, MES, DEPARTAMENTO);
            this.reportViewer1.RefreshReport();
        }
    }
}
