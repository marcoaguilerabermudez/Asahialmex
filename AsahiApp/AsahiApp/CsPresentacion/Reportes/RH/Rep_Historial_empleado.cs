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
    public partial class Rep_Historial_empleado : Form
    {
        public Rep_Historial_empleado()
        {
            InitializeComponent();
        }
        public Int32 VAR;
        public Int32 CLAVE;

        private void Rep_Historial_empleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Historial_Empleado.sp_Historial_personal' Puede moverla o quitarla según sea necesario.
            this.sp_Historial_personalTableAdapter.Fill(this.DS_Historial_Empleado.sp_Historial_personal, VAR, CLAVE);

            this.reportViewer1.RefreshReport();
        }
    }
}
