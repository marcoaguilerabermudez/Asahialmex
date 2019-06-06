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
    public partial class Rep_Finiquito : Form
    {
        public Rep_Finiquito()
        {
            InitializeComponent();
        }

        private void Rep_Finiquito_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Finiquito.Reporte_Pago_Finiquito_Imprimir' Puede moverla o quitarla según sea necesario.
            this.Reporte_Pago_Finiquito_ImprimirTableAdapter.Fill(this.DS_Finiquito.Reporte_Pago_Finiquito_Imprimir);

            this.reportViewer1.RefreshReport();
        }
    }
}
