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
    public partial class Frm_Rep_Descanso_Laborado : Form
    {
        public Frm_Rep_Descanso_Laborado()
        {
            InitializeComponent();
        }

        public int Var;
        public int Tipo;
        public int Año;
        public int Semana;
        public DateTime Inicia { get; set; }
        public DateTime Termina { get; set; }

        private void Frm_Rep_Descanso_Laborado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Reportes_Prenomina.SP_Reportes_Prenomina_FM' Puede moverla o quitarla según sea necesario.
            this.SP_Reportes_Prenomina_FMTableAdapter.Fill(this.DS_Reportes_Prenomina.SP_Reportes_Prenomina_FM, Var, Tipo, Año, Semana, Inicia, Termina);

            this.reportViewer1.RefreshReport();
        }
    }
}
