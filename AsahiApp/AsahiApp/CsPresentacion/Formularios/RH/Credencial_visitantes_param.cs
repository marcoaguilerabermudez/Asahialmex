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
    public partial class Credencial_visitantes_param : Form
    {
        public Credencial_visitantes_param()
        {
            InitializeComponent();
        }

        private void Credencial_visitantes_param_Load(object sender, EventArgs e)
        {
            txt_cantidad.Focus();
        }
        private void Txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Btn_eliminar_depto_Click(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("Es necesario capturar una cantidad", "Aviso");
            }
            else
            {
                Credencial_Visitantes Cre = new Credencial_Visitantes();
                Cre.Fecha = Convert.ToDateTime("16-08-2019");
                Cre.Var = Convert.ToInt32("2");
                Cre.Cant = Convert.ToInt32(txt_cantidad.Text);
                Cre.Show();
            }
        }
    }
}
