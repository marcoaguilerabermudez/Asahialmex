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
    public partial class Frm_Parametros_rep_prenomina : Form
    {
        public Frm_Parametros_rep_prenomina()
        {
            InitializeComponent();
            timer1.Enabled = true;
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "NUEVO");
            tt.SetToolTip(btn_reporte, "GENERA REPORTE");

        }
        //Variable para seleccionar tipo de reporte
        int Tipo;
        
        private void Frm_Fecha_rep_prenomina_Load(object sender, EventArgs e)
        {
            nuevo();
            txt_semana.Enabled = true;
            txt_año.Enabled = true;
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
            timer1.Enabled = true;
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            txt_semana.Enabled = true;
            txt_semana.Focus();
            txt_año.Enabled = true;
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
            timer1.Enabled = false;
            txt_año.Enabled = false;
            txt_semana.Text = "";
            txt_semana.Enabled = false;
            dtm_final.Enabled = true;
            lbl_tipo.Text = "2";
        }
        private void Dtm_final_ValueChanged(object sender, EventArgs e)
        {
        }
        private void Btn_reporte_Click(object sender, EventArgs e)
        {

            if (lbl_var.Text == "1")
            {
                if (lbl_tipo.Text == "0")
                {
                    MessageBox.Show("Es necesario seleccionar una Fecha o Número de Semana", "Aviso");
                    txt_semana.Focus();
                }
                else if (lbl_tipo.Text == "2")//Genera reporte de descanso Laborado por Fecha
                {
                    Frm_Rep_Descanso_Laborado dl = new Frm_Rep_Descanso_Laborado();
                    dl.Var = Convert.ToInt32(lbl_var.Text);
                    dl.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    dl.Año = Convert.ToInt32(txt_año.Text);
                    dl.Semana = Convert.ToInt32(txt_semana.Text);
                // dl.Inicia = dtm_inicial;
                 //  dl.Termina = dtm_final;
                    dl.ShowDialog();
                    nuevo();
                    txt_semana.Enabled = true;
                    txt_semana.Focus();
                    txt_año.Enabled = true;
                }
                else if (lbl_tipo.Text == "1")// Genera reporte de descanso laborado por Semana
                {
                    Frm_Rep_Descanso_Laborado dl = new Frm_Rep_Descanso_Laborado();
                    dl.Var = Convert.ToInt32(lbl_var.Text);
                    dl.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    dl.Año = Convert.ToInt32(txt_año.Text);
                    dl.Semana = Convert.ToInt32(txt_semana.Text);
                   // Prenomina.Inicia = Convert.ToDateTime(dtm_inicial.Text);
                    //Prenomina.Termina = Convert.ToDateTime(dtm_final.Text);
                    dl.ShowDialog();
                    nuevo();
                    txt_semana.Enabled = true;
                    txt_semana.Focus();
                    txt_año.Enabled = true;
                }
            }
            else if (lbl_var.Text == "2")
            {


            }
        }

        private void Txt_año_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                timer1.Enabled = false;

            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                timer1.Enabled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txt_año.Text = DateTime.Now.ToString("yyyy");
        }
    }
}
