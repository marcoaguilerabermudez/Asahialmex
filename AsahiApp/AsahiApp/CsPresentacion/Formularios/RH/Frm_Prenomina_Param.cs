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
            dtm_inicial.Enabled = true;
            txt_clave.Enabled = true;
            txt_clave.Focus();
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
            txt_clave.Text = "";
            txt_clave.Focus();
            lbl_tipo.Text = "0";
            timer1.Enabled = true;
            lbl_var.Visible = false;
           lbl_tipo.Visible = false;
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            txt_año.Enabled = true;
            txt_semana.Enabled = true;
            dtm_inicial.Enabled = true;
            txt_clave.Enabled = true;
            txt_clave.Focus();
        }
        private void Txt_semana_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_clave.Text) && string.IsNullOrEmpty(txt_semana.Text))
            {
                dtm_final.Enabled = true;
                dtm_inicial.Enabled = true;
                lbl_tipo.Text = "0";
            }
            else if (string.IsNullOrEmpty(txt_clave.Text))
            {
                dtm_final.Enabled = false;
                dtm_inicial.Enabled = false;
                lbl_tipo.Text = "1";
            }
            else
            {
                dtm_final.Enabled = false;
                dtm_inicial.Enabled = false;
                lbl_tipo.Text = "3";
            }
        }
        private void Frm_Fecha_rep_prenomina_TextChanged(object sender, EventArgs e)
        {     
        }
        private void Dtm_inicial_ValueChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_clave.Text))
            {
                timer1.Enabled = false;
                txt_año.Enabled = false;
                txt_semana.Text = "";
                txt_semana.Enabled = false;
                dtm_final.Enabled = true;
                lbl_tipo.Text = "2";
                txt_clave.Text = "";
                txt_clave.Enabled = false;
            }
            else
            {
                timer1.Enabled = false;
                txt_año.Enabled = false;
                txt_año.Text = "";
                txt_semana.Text = "";
                txt_semana.Enabled = false;
                dtm_final.Enabled = true;
                lbl_tipo.Text = "4";
                txt_clave.Enabled = true;
            }
        }
        private void Dtm_final_ValueChanged(object sender, EventArgs e)
        {
        }
        private void Btn_reporte_Click(object sender, EventArgs e)
        {   
        //Ejecuta reportes individuales
             if (lbl_var.Text == "1")//Reporte de descanso laborado
            {
                if (lbl_tipo.Text == "0")
                {
                    MessageBox.Show("Es necesario seleccionar una opción", "Aviso");
                    txt_clave.Focus();
                }
                else if (lbl_tipo.Text == "3" && string.IsNullOrEmpty(txt_semana.Text))
                {
                    MessageBox.Show("Es necesario capturar número de semana o Fecha", "Aviso");
                    txt_semana.Focus();
                }
                else if (lbl_tipo.Text == "2")//Genera reporte de descanso Laborado por Fecha
                {
                    Rep_Descanso_Laborado dl = new Rep_Descanso_Laborado();
                    dl.Var = Convert.ToInt32(lbl_var.Text);
                    dl.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    dl.Inicia = dtm_inicial.Value;
                    dl.Termina = dtm_final.Value;
                    dl.Show();
                }
                else if (lbl_tipo.Text == "1")// Genera reporte de descanso laborado por Semana
                {
                    Descanso_laborado_Semana dls = new Descanso_laborado_Semana();
                    dls.Var = Convert.ToInt32(lbl_var.Text);
                    dls.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    dls.Año = Convert.ToInt32(txt_año.Text);
                    dls.Semana = Convert.ToInt32(txt_semana.Text);
                    dls.Inicia = dtm_inicial.Value;
                    dls.Termina = dtm_final.Value;
                    dls.Show();
                }
                else if (lbl_tipo.Text == "3")// Genera reporte de descanso laborado por Semana y CLAVE
                {
                    Descanso_laborado_Semana dls = new Descanso_laborado_Semana();
                    dls.Var = Convert.ToInt32(lbl_var.Text);
                    dls.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    dls.Año = Convert.ToInt32(txt_año.Text);
                    dls.Semana = Convert.ToInt32(txt_semana.Text);
                    dls.Inicia = dtm_inicial.Value;
                    dls.Termina = dtm_final.Value;
                    dls.Clave = Convert.ToInt32(txt_clave.Text);
                    dls.Show();
                }
                else if (lbl_tipo.Text == "4")// Genera reporte de descanso laborado por Fecha y CLAVE
                {
                    Rep_Descanso_Laborado dl = new Rep_Descanso_Laborado();
                    dl.Var = Convert.ToInt32(lbl_var.Text);
                    dl.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    dl.Inicia = dtm_inicial.Value;
                    dl.Termina = dtm_final.Value;
                    dl.Clave = Convert.ToInt32(txt_clave.Text);
                    dl.Show();
                }
            }

            else if (lbl_var.Text == "2")//Reporte de Retardos
            {
                if (lbl_tipo.Text == "0")
                {
                    MessageBox.Show("Es necesario seleccionar una opción", "Aviso");
                    txt_clave.Focus();
                }
                else if (lbl_tipo.Text == "3" && string.IsNullOrEmpty(txt_semana.Text))
                {
                    MessageBox.Show("Es necesario capturar número de semana o Fecha", "Aviso");
                    txt_semana.Focus();
                }
                else if (lbl_tipo.Text == "2")//Genera reporte de retardos por Fecha
                {
                    Frm_Rep_Retardos Re = new Frm_Rep_Retardos();
                    Re.Var = Convert.ToInt32(lbl_var.Text);
                    Re.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    Re.Inicia = dtm_inicial.Value;
                    Re.Termina = dtm_final.Value;
                    Re.Show();
                }
                else if (lbl_tipo.Text == "1")//Genera reporte de retardos por Semana
                {
                    Retardos_Semana RS = new Retardos_Semana();
                    RS.Var = Convert.ToInt32(lbl_var.Text);
                    RS.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    RS.Semana = Convert.ToInt32(txt_semana.Text);
                    RS.Año = Convert.ToInt32(txt_año.Text);
                    RS.Inicia = dtm_inicial.Value;
                    RS.Termina = dtm_final.Value;
                    RS.Show();
                }
                else if (lbl_tipo.Text == "3")//Genera reporte de retardos por Semana y CLAVE
                {
                    Retardos_Semana RS = new Retardos_Semana();
                    RS.Var = Convert.ToInt32(lbl_var.Text);
                    RS.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    RS.Semana = Convert.ToInt32(txt_semana.Text);
                    RS.Año = Convert.ToInt32(txt_año.Text);
                    RS.Inicia = dtm_inicial.Value;
                    RS.Termina = dtm_final.Value;
                    RS.Clave = Convert.ToInt32(txt_clave.Text);
                    RS.Show();
                }
                else if (lbl_tipo.Text == "4")//Genera reporte de retardos por Fecha Y CLAVE
                {
                    Frm_Rep_Retardos Re = new Frm_Rep_Retardos();
                    Re.Var = Convert.ToInt32(lbl_var.Text);
                    Re.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    Re.Inicia = dtm_inicial.Value;
                    Re.Termina = dtm_final.Value;
                    Re.Clave = Convert.ToInt32(txt_clave.Text);
                    Re.Show();
                }
            }
            else if (lbl_var.Text == "3")//Permisos de salida anticipada
            {
                if (lbl_tipo.Text == "0")
                {
                    MessageBox.Show("Es necesario seleccionar una opción", "Aviso");
                    txt_clave.Focus();
                }
                else if (lbl_tipo.Text == "3" && string.IsNullOrEmpty(txt_semana.Text))
                {
                    MessageBox.Show("Es necesario capturar número de semana o Fecha", "Aviso");
                    txt_semana.Focus();
                }
                else if (lbl_tipo.Text == "2")//Genera reporte de salida anticipada por Fecha
                {
                    Permiso_Salida sa = new Permiso_Salida();
                    sa.Var = Convert.ToInt32(lbl_var.Text);
                    sa.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    sa.Inicia = dtm_inicial.Value;
                    sa.Termina = dtm_final.Value;
                    sa.Show();
                }
                else if (lbl_tipo.Text == "1")//Genera reporte de salida anticipada por Semana
                {
                    Permiso_Salida_Semana sa = new Permiso_Salida_Semana();
                    sa.Var = Convert.ToInt32(lbl_var.Text);
                    sa.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    sa.Semana = Convert.ToInt32(txt_semana.Text);
                    sa.Año = Convert.ToInt32(txt_año.Text);
                    sa.Inicia = dtm_inicial.Value;
                    sa.Termina = dtm_final.Value;
                    sa.Show();
                }
                else if (lbl_tipo.Text == "3")//Genera reporte de salida anticipada por Semana y CLAVE
                {
                    Permiso_Salida_Semana sa = new Permiso_Salida_Semana();
                    sa.Var = Convert.ToInt32(lbl_var.Text);
                    sa.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    sa.Semana = Convert.ToInt32(txt_semana.Text);
                    sa.Año = Convert.ToInt32(txt_año.Text);
                    sa.Inicia = dtm_inicial.Value;
                    sa.Termina = dtm_final.Value;
                    sa.Clave = Convert.ToInt32(txt_clave.Text);
                    sa.Show();
                }
                else if (lbl_tipo.Text == "4")//Genera reporte de salida anticipada por Fecha  CLAVE
                {
                    Permiso_Salida sa = new Permiso_Salida();
                    sa.Var = Convert.ToInt32(lbl_var.Text);
                    sa.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    sa.Inicia = dtm_inicial.Value;
                    sa.Termina = dtm_final.Value;
                    sa.Clave = Convert.ToInt32(txt_clave.Text);
                    sa.Show();
                }
            }

            else if (lbl_var.Text == "5")//Reporte de incapacidades
            {
                if (lbl_tipo.Text == "0")
                {
                    MessageBox.Show("Es necesario seleccionar una opción", "Aviso");
                    txt_clave.Focus();
                }
                else if (lbl_tipo.Text == "3" && string.IsNullOrEmpty(txt_semana.Text))
                {
                    MessageBox.Show("Es necesario capturar número de semana o Fecha", "Aviso");
                    txt_semana.Focus();
                }
                else if (lbl_tipo.Text == "2")//Genera reporte incapacidades Fecha
                {
                    Incapacidades inc = new Incapacidades();
                    inc.Var = Convert.ToInt32(lbl_var.Text);
                    inc.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    inc.Inicia = dtm_inicial.Value;
                    inc.Termina = dtm_final.Value;
                    inc.Show();
                }
                else if (lbl_tipo.Text == "1")//Genera reporte de incapacidades por Semana
                {
                    Incapacidades inc = new Incapacidades();
                    inc.Var = Convert.ToInt32(lbl_var.Text);
                    inc.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    inc.Semana = Convert.ToInt32(txt_semana.Text);
                    inc.Año = Convert.ToInt32(txt_año.Text);
                    inc.Inicia = dtm_inicial.Value;
                    inc.Termina = dtm_final.Value;
                    inc.Show();
                }
                else if (lbl_tipo.Text == "3")//Genera reporte de incapacidades por Semana y CLAVE
                {
                    Incapacidades inc = new Incapacidades();
                    inc.Var = Convert.ToInt32(lbl_var.Text);
                    inc.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    inc.Semana = Convert.ToInt32(txt_semana.Text);
                    inc.Año = Convert.ToInt32(txt_año.Text);
                    inc.Inicia = dtm_inicial.Value;
                    inc.Termina = dtm_final.Value;
                    inc.Clave = Convert.ToInt32(txt_clave.Text);
                    inc.Show();
                }
                else if (lbl_tipo.Text == "4")//Genera reporte de incapacidades por Fecha  CLAVE
                {
                    Incapacidades inc = new Incapacidades();
                    inc.Var = Convert.ToInt32(lbl_var.Text);
                    inc.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    inc.Inicia = dtm_inicial.Value;
                    inc.Termina = dtm_final.Value;
                    inc.Clave = Convert.ToInt32(txt_clave.Text);
                    inc.Show();
                }
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

        private void Btn_reporte_erik_Click(object sender, EventArgs e)
        {    
        }

        private void Txt_clave_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_clave.Text))
            {
                lbl_tipo.Text = "0";
            }
            else
            {
                lbl_tipo.Text = "3";
            }
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
    }
}
