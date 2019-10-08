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
    public partial class Rotacion : Form
    {
        public Rotacion()
        {
            InitializeComponent();
        }

        public int Var;
        public DateTime Fecha { get; set; }
        public int Desde;
        public int Hasta;
        public String Filtro;

        private void Rotacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Rotacion.SP_rep_rotacion' Puede moverla o quitarla según sea necesario.
            this.SP_rep_rotacionTableAdapter.Fill(this.DS_Rotacion.SP_rep_rotacion, Var, Fecha, Desde, Hasta, Filtro);
            this.reportViewer1.RefreshReport();
        }
    }
}
