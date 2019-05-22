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
    public partial class Frm_Reporte_Bajas : Form
    {
        public Frm_Reporte_Bajas()
        {
            InitializeComponent();
        }
        public Int32 Var;
        public Int32 Año;
        public String Mes;
        public Int32 Semana;
        public String Departamento;
        public String Puesto;

        private void Frm_Reporte_Bajas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Bajas.FM_LISTADO_BAJAS' Puede moverla o quitarla según sea necesario.
            this.FM_LISTADO_BAJASTableAdapter.Fill(this.DS_Bajas.FM_LISTADO_BAJAS, Var, Año, Mes, Semana, Departamento, Puesto);
            this.RV_Bajas.RefreshReport();
        }
    }
}
