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
    public partial class Frm_Vacaciones : Form
    {
        public Frm_Vacaciones()
        {
            InitializeComponent();
        }
        public int Var;
        public int Tipo;
        public int Semana;
        public int Año;
        public DateTime Inicia { get; set; }
        public DateTime Termina { get; set; }
        public int Clave;

        private void Frm_Vacaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Vacaciones.SP_Reportes_Vacaciones' Puede moverla o quitarla según sea necesario.
            this.SP_Reportes_VacacionesTableAdapter.Fill(this.DS_Vacaciones.SP_Reportes_Vacaciones, Var, Tipo, Semana, Año, Inicia, Termina, Clave);

            this.reportViewer1.RefreshReport();
        }
    }
}
