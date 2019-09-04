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
    public partial class Rep_Credenciales : Form
    {
        public Rep_Credenciales()
        {
            InitializeComponent();
        }
        public DateTime Fecha;
        public int Cant;
        public int Var;
        private void Frm_Rep_Cre_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.EnableExternalImages = true;
    
            // TODO: esta línea de código carga datos en la tabla 'DS_Credenciales.SP_Credencial_Empleados' Puede moverla o quitarla según sea necesario.
            this.SP_Credencial_EmpleadosTableAdapter.Fill(this.DS_Credenciales.SP_Credencial_Empleados, Fecha, Cant, Var);

            this.reportViewer1.RefreshReport();
        }
    }
}
