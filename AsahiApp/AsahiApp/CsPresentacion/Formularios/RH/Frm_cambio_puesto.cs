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
    public partial class Frm_cambio_puesto : Form
    {
        public Frm_cambio_puesto()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }


        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        private void Frm_cambio_puesto_Load(object sender, EventArgs e)
        {
            nuevo();
            cargar_puesto(cmb_puesto);
        }

        private void nuevo()
        {
            l_fecha.Visible = false;
            l_hora.Visible = false;
            lbl_clave.Visible = false;
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
        public void cargar_puesto(ComboBox inte)//Cargar puesto CMB
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select distinct DESCRIPCION_PUESTO from [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] order by DESCRIPCION_PUESTO", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["DESCRIPCION_PUESTO"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo departamento" + Error.ToString());
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            l_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            l_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Cmb_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cmb_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
