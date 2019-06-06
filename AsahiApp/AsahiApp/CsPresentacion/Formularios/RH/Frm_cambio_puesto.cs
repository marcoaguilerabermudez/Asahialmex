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
            btn_aceptar.Enabled = false;
        }
     
        public void cargar_puesto(ComboBox inte)//Cargar puesto CMB
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select distinct DESCRIPCION from [asahi16].[Supervisor_giro].[Puesto]  order by DESCRIPCION", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["DESCRIPCION"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo departamento" + Error.ToString());
            }
        }

        private void Inserta_puesto()
        {
            try
            {
                DataTable dt = new DataTable();
                String str;
                str = "[dbo].[Modifica_puesto_fm]";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@CLAVE", lbl_clave.Text);
                da.SelectCommand.Parameters.AddWithValue("@PUESTO", cmb_puesto.Text);

                da.Fill(dt);
                con.Close();
                MessageBox.Show("Se modificó el puesto correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            l_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            l_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
          Inserta_puesto();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Cmb_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_aceptar.Enabled = true;
        }
    }
}
