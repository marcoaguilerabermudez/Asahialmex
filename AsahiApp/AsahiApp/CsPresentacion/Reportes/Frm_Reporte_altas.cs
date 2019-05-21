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
    public partial class Frm_Reporte_altas : Form
    {
        public Frm_Reporte_altas()
        {
            InitializeComponent();
        }
        public Int32 Var;
        public Int32 Año;
        public String Mes;
        public Int32 Semana;
        public String Departamento;
        public String Puesto;


        private void Frm_Reporte_altas_Load(object sender, EventArgs e)
        {  
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
