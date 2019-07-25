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
    public partial class Contrato_Clave : Form
    {
        public Contrato_Clave()
        {
            InitializeComponent();
        }

        private void Txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (txt_clave.Text == "")
            {
                MessageBox.Show("Es necesario capturar el número de empleado", "Aviso");
                txt_clave.Text = "";
                txt_clave.Focus();
            }
            else
            {
                Frm_Rep_Alta_empleado Rep = new Frm_Rep_Alta_empleado();
                Rep.CLAVE = Convert.ToInt32(txt_clave.Text);
                Rep.ShowDialog();
                txt_clave.Text = "";
                txt_clave.Focus();
            }
        }

        private void Contrato_Clave_Load(object sender, EventArgs e)
        {
            txt_clave.Text = "";
            txt_clave.Focus();
        }
    }
}
