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
    public partial class Rotacion_Grafico : Form
    {
        public Rotacion_Grafico()
        {
            InitializeComponent();
        }
        public int Var;
        public DateTime Fecha { get; set; }


        private void Rotacion_Grafico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Rotacion_grafica.SP_rep_rotacion_grafica' Puede moverla o quitarla según sea necesario.
            this.SP_rep_rotacion_graficaTableAdapter.Fill(this.DS_Rotacion_grafica.SP_rep_rotacion_grafica, Var, Fecha);

            this.reportViewer1.RefreshReport();
        }
    }
}
