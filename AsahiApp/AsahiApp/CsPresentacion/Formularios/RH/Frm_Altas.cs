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
    public partial class Frm_Altas : Form
    {
        public Frm_Altas()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        double Sueldo;
        double Factor;
        double Resultado;

        private void Frm_Altas_Load(object sender, EventArgs e)
        {
            nuevo();
            cargar_puesto(cmb_puesto);
            cargar_departemento(cmb_departamento);
            selecciona_clave();
        }
        public void cargar_departemento(ComboBox inte)//Cargar departamento en cmb
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select distinct DESCRIPCION FROM  [asahi16].[Supervisor_giro].[DEPTO] ORDER BY DESCRIPCION", con);
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

        private void nuevo()
        {
            txt_paterno.Text = "";
            txt_materno.Text = "";
            txt_nombre.Text = "";
            cmb_departamento.Text = "";
            cmb_puesto.Text = "";
            txt_nacionalidad.Text = "";
            txt_SDO1.Text = "";
            txt_SDO2.Text = "";
            txt_SDO3.Text = "";
            txt_SDO4.Text = "";
            txt_SDO5.Text = "";
            txt_nss.Text = "";
            txt_rfc.Text = "";
            txt_curp.Text = "";

            lbl_factor.Visible = false;
            Panel_secundario.Visible = false;
          
            txt_SDO1.Enabled = false;
            txt_SDO2.Enabled = false;
            txt_SDO3.Enabled = false;
            txt_SDO4.Enabled = false;
            txt_SDO5.Enabled = false;
        }

        private void selecciona_sueldo()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SELECT SUELDO FROM [asahi16].[Supervisor_giro].[Puesto]  WHERE DESCRIPCION = @Puesto";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Puesto", SqlDbType.VarChar).Value = cmb_puesto.Text;
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    txt_SDO1.Text = dt.Rows[0]["SUELDO"].ToString();
                }
                txt_SDO2.Text = "0.00";
                txt_SDO4.Text = "0.00";
                lbl_factor.Text = "1.07808";
                Sueldo = double.Parse(txt_SDO1.Text);
                Factor = double.Parse(lbl_factor.Text);
                Resultado = Sueldo * Factor;
                txt_SDO3.Text = Resultado.ToString();
                txt_SDO5.Text = Resultado.ToString();
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el sueldo");
            }
        }

        private void selecciona_clave()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SELECT TOP (1) [CLAVE] + 1 as 'CLAVE'  FROM [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] order by CLAVE desc";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                da.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    txt_Clave.Text = dt.Rows[0]["CLAVE"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la ultima CLAVE");
            }
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

        private void Button1_Click(object sender, EventArgs e)//Primer botón siguinte
        {  
            Panel_secundario.Visible = true;
            Panel_principal.Visible = false;
        }

        private void Btn_ps_siguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro guardado correctamente.");
        }

        private void Btn_ps_anterior_Click(object sender, EventArgs e)
        {
            Panel_secundario.Visible = false;
            Panel_principal.Visible = true;
        }

        private void Btn_pf_anterior_Click(object sender, EventArgs e)
        {
            Panel_secundario.Visible = true;
        }

        private void Panel_principal_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Cmb_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecciona_sueldo();
        }



        private void Cmb_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cmb_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Btn_nuevo2_Click(object sender, EventArgs e)
        {
            nuevo();
            selecciona_clave();
        }

        private void Txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Txt_paterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private void Txt_materno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private void Txt_nacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Txt_nacionalidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
