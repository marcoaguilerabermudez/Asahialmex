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
    public partial class Frm_Fecha_rep_prenomina : Form
    {
        public Frm_Fecha_rep_prenomina()
        {
            InitializeComponent();
        }
        //Variable para seleccionar tipo de reporte
        int Tipo;

        private void Frm_Fecha_rep_prenomina_Load(object sender, EventArgs e)
        {
            nuevo();
            txt_semana.Enabled = true;
        }

        private void Frm_Fecha_rep_prenomina_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void Txt_semana_KeyPress(object sender, KeyPressEventArgs e)
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
        private void nuevo()
        {
            dtm_inicial.Text = "";
            dtm_final.Text = "";
            dtm_final.Enabled = false;

            txt_semana.Text = "";
            txt_semana.Focus();
            lbl_tipo.Text = "0";
            // lbl_var.Visible = false;
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            txt_semana.Enabled = true;
            txt_semana.Focus();
        }
        private void Txt_semana_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_semana.Text))
            {
                dtm_final.Enabled = true;
                dtm_inicial.Enabled = true;
                lbl_tipo.Text = "0";
            }
            else
            {
                dtm_final.Enabled = false;
                dtm_inicial.Enabled = false;
                lbl_tipo.Text = "1";
            }
        }
        private void Frm_Fecha_rep_prenomina_TextChanged(object sender, EventArgs e)
        {     
        }
        private void Dtm_inicial_ValueChanged(object sender, EventArgs e)
        {
            txt_año.Text = "";
            txt_semana.Text = "";
            txt_año.Text = "";
            txt_semana.Enabled = false;
            dtm_final.Enabled = true;
            lbl_tipo.Text = "2";
        }
        private void Dtm_final_ValueChanged(object sender, EventArgs e)
        {
        }
        private void Btn_reporte_Click(object sender, EventArgs e)
        {
        }
    }
}
