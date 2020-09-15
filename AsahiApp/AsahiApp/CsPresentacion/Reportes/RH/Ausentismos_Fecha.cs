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
    public partial class Ausentismos_Fecha : Form
    {
        public Ausentismos_Fecha()
        {
            InitializeComponent();
        }

        public int Var;
        public DateTime Inicia { get; set; }
        public DateTime Termina { get; set; }
        public String Depto;

        private void Ausentismos_Fecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Ausentismos_Fecha.Ausentismo_Fecha' Puede moverla o quitarla según sea necesario.
            this.Ausentismo_FechaTableAdapter.Fill(this.DS_Ausentismos_Fecha.Ausentismo_Fecha, Var, Inicia, Termina, Depto);
            // TODO: esta línea de código carga datos en la tabla 'DS_Ausentismos_Fecha.Ausentismo_Fecha' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
        }
    }
}
