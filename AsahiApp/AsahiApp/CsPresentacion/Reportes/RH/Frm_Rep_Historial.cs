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
    public partial class Frm_Rep_Historial : Form
    {
        public Frm_Rep_Historial()
        {
            InitializeComponent();
        }

        public int Var;
        public DateTime Fecha {get; set;}
        public String Depto;

        private void Frm_Rep_Historial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Historico.SP_historico_personal' Puede moverla o quitarla según sea necesario.
            this.SP_historico_personalTableAdapter.Fill(this.DS_Historico.SP_historico_personal, Var, Fecha, Depto);
            // TODO: esta línea de código carga datos en la tabla 'DS_Historico.SP_historico_personal' Puede moverla o quitarla según sea necesario.
            // this.SP_historico_personalTableAdapter.Fill(this.DS_Historico.SP_historico_personal, Var, Fecha, Depto);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
