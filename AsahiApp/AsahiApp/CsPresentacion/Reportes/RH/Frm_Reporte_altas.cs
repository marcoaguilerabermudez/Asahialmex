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
            // TODO: esta línea de código carga datos en la tabla 'DS_Altas1.FM_LISTADO_ALTAS' Puede moverla o quitarla según sea necesario.
            this.FM_LISTADO_ALTASTableAdapter.Fill(this.DS_Altas1.FM_LISTADO_ALTAS, Var, Año, Mes, Semana, Departamento, Puesto);
            this.reportViewer1.RefreshReport();
        }
    }
}
