using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CsPresentacion
{
    public partial class Frm_Mejora_Param : Form
    {
        public Frm_Mejora_Param()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");


        int Var;
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargar_departemento(ComboBox inte)//Cargar departamento en cmb
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select distinct DESCRIPCION_DEPTO from [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] order by DESCRIPCION_DEPTO", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["DESCRIPCION_DEPTO"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo departamento" + Error.ToString());
            }
        }

        private void Nuevo()
        {
            txt_clave.Text = "";
            cmb_departamento.Text = "";
            cmb_mes.Text = "";
            btn_aceptar.Enabled = false;
            lbl_var.Text = "0";
            cmb_departamento.Enabled = true;
        }

        private void Frm_Mejora_Param_Load(object sender, EventArgs e)
        {
            Var = 0;
            lbl_var.Text = "0";
            cargar_departemento(cmb_departamento);
            Nuevo();
            
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {

            if (lbl_var.Text == ("1"))
            {
                Frm_Rep_Mejoras3 Mejora = new Frm_Rep_Mejoras3();
                Mejora.VAR = Convert.ToInt32(lbl_var.Text);
                Mejora.CLAVE = Convert.ToInt32(txt_clave.Text);
                Mejora.MES = cmb_mes.Text;
                Mejora.ShowDialog();
                Nuevo();
            }
            else if (lbl_var.Text == ("2"))
            {
                Frm_Rep_Mejoras3 Mejora = new Frm_Rep_Mejoras3();
                Mejora.VAR = Convert.ToInt32(lbl_var.Text);
                Mejora.MES = cmb_mes.Text;
                Mejora.DEPARTAMENTO = cmb_departamento.Text;
                Mejora.ShowDialog();
                Nuevo();
            }           
        }

        private void Cmb_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cmb_mes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cmb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_clave.Text = "";
            if (string.IsNullOrEmpty(txt_clave.Text) && string.IsNullOrEmpty(cmb_mes.Text))
            {

                btn_aceptar.Enabled = false;
            }

            else if (string.IsNullOrEmpty(cmb_mes.Text))
            {
                txt_clave.Text = "";
                lbl_var.Text = "0";
                btn_aceptar.Enabled = false;
            }
            else
            {
                lbl_var.Text = "2";
                btn_aceptar.Enabled = true;
            }
        }

        private void Cmb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_clave.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {

                btn_aceptar.Enabled = false;
            }

            else if (string.IsNullOrEmpty(txt_clave.Text)) //  && string.is(cmb_departamento.Text))
            {
                lbl_var.Text = "2";
                btn_aceptar.Enabled = true;
            }

            else
            {
                lbl_var.Text = "1";
                btn_aceptar.Enabled = true;
                cmb_departamento.Enabled = false;
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Txt_clave_TextChanged(object sender, EventArgs e)
        {
            cmb_departamento.Text = "";
            if (string.IsNullOrEmpty(cmb_mes.Text))
            {

                btn_aceptar.Enabled = false;
            }
            else
            {
                lbl_var.Text = "1";
                btn_aceptar.Enabled = true;
                cmb_departamento.Enabled = false;
            }
        }
    }
}
