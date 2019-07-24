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
    public partial class Frm_Reporte_Anual_Mejoras : Form
    {
        public Frm_Reporte_Anual_Mejoras()
        {
            InitializeComponent();
        }

        public int variable;
        private void Frm_reporte_anual_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Mejoras_Anual2.Sp_graficaanualmejorase' Puede moverla o quitarla según sea necesario.
            this.Sp_graficaanualmejoraseTableAdapter.Fill(this.DS_Mejoras_Anual2.Sp_graficaanualmejorase, variable);

            this.reportViewer1.RefreshReport();
        }
    }
}
