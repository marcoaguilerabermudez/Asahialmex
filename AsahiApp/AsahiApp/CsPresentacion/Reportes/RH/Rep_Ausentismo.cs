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
    public partial class Rep_Ausentismo : Form
    {
        public Rep_Ausentismo()
        {
            InitializeComponent();
        }
        public int Var;
        public DateTime Fecha { get; set; }
        public string Depto;
        private void Rep_Ausentismo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Ausentismo_Global.Ausentismo_Global' Puede moverla o quitarla según sea necesario.
            this.Ausentismo_GlobalTableAdapter.Fill(this.DS_Ausentismo_Global.Ausentismo_Global, Var, Fecha, Depto) ;         
            this.reportViewer1.RefreshReport();
        }
    }
}
