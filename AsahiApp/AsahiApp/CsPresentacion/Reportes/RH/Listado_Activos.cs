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
    public partial class Listado_Activos : Form
    {
        public Listado_Activos()
        {
            InitializeComponent();
        }
        public int Var;
        public String Departamento;
        public String Puesto;
        public int Ant1;
        public int Ant2;
        public String Genero;

        private void Listado_Activos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Listado_Activos.FM_LISTADO_ACTIVOS' Puede moverla o quitarla según sea necesario.
            this.FM_LISTADO_ACTIVOSTableAdapter.Fill(this.DS_Listado_Activos.FM_LISTADO_ACTIVOS, Var, Departamento, Puesto, Ant1, Ant2, Genero);
            this.reportViewer1.RefreshReport();
        }

    }
}
