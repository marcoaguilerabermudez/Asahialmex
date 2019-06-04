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
    public partial class Frm_Cambio_Depto : Form
    {
        public Frm_Cambio_Depto()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        private void Frm_Cambio_Depto_Load(object sender, EventArgs e)
        {
            cargar_departemento(cmb_departamento);
            l_fecha.Visible = false;
            l_hora.Visible = false;
            lbl_clave.Visible = false;
            btn_aceptar.Enabled = false;
        }


        private void Inserta_depto()
        {
            try
            {
                DataTable dt = new DataTable();
                String str;
                str = "[dbo].[Modifica_depto_fm]";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@CLAVE", lbl_clave.Text);
                da.SelectCommand.Parameters.AddWithValue("@CATALOGO", cmb_departamento.Text);
       
                da.Fill(dt);
                con.Close();
                MessageBox.Show("Se modificó correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            l_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            l_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Cmb_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            Inserta_depto();            
        }

        private void Cmb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_aceptar.Enabled = true;
        }
    }
}
