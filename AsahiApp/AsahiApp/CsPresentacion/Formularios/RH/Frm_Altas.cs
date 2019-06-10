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
    public partial class Frm_Altas : Form
    {
        public Frm_Altas()
        {
            InitializeComponent();
        }

        private void Frm_Altas_Load(object sender, EventArgs e)
        {
            Panel_secundario.Visible = false;
            panel_final.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)//Primer botón siguinte
        {
           
            Panel_secundario.Visible = true;
            Panel_principal.Visible = false;
        }

        private void Btn_ps_siguiente_Click(object sender, EventArgs e)
        {
           
            panel_final.Visible = true;
            Panel_secundario.Visible = false;
        }

        private void Btn_ps_anterior_Click(object sender, EventArgs e)
        {
            Panel_secundario.Visible = false;
            Panel_principal.Visible = true;
        }

        private void Btn_pf_anterior_Click(object sender, EventArgs e)
        {
            panel_final.Visible = false;
            Panel_secundario.Visible = true;
        }
    }
}
