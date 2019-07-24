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
    public partial class Reporte_Altas : Form
    {
        public Reporte_Altas()
        {
            InitializeComponent();
        }
        public int Var;
        public int Año;
        public String Mes;
        public int Semana;
        public String Departamento;
        public String Puesto;

        private void Reporte_Altas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Listado_Altas_Empleados.FM_LISTADO_ALTAS' Puede moverla o quitarla según sea necesario.
            this.FM_LISTADO_ALTASTableAdapter.Fill(this.DS_Listado_Altas_Empleados.FM_LISTADO_ALTAS, Var, Año, Mes, Semana, Departamento, Puesto);

            this.reportViewer1.RefreshReport();
        }
    }
}
