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
using Clases;

namespace CsPresentacion
{
    public partial class Frm_Licencias : Form
    {
        public Frm_Licencias(Empleado classEmpleado)
        {
            InitializeComponent();
            claseEmp = classEmpleado;
        }
        Empleado claseEmp;

        private void Credenciales_Montacargas_Load(object sender, EventArgs e)
        {
            txt_vigencia.Visible = false;
            lbl_estado.Visible = false;
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");


        private void txt_clave_KeyPress(object sender, KeyPressEventArgs e)
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

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cargar_informacion();
                
                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                txt_vigencia.Visible = true;
                lbl_estado.Visible = true;
                txt_vigencia.Visible = true;
                lbl_estado.Visible = true;
                if (txt_vigencia.Text == "VIGENTE")
                {
                    btn_agregar.Enabled = true;
                    cmb_tipo.Focus();
                }
                else if (txt_vigencia.Text == "BAJA")
                {
                    btn_agregar.Enabled = false;
                }
                else
                {
                    pictureBox1.ImageLocation = "V:/Sistemas/SAAM/LogoFinal" + ".png";
                }
            }
        }

        private void cargar_informacion()
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[FM_INFORMACION_EMPLEADO]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Emp", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txt_clave.Enabled = false;
                txt_nombre.Text = dt.Rows[0]["NOMBRE_EMPLEADO"].ToString();
                txt_departamento.Text = dt.Rows[0]["DEPARTAMENTO"].ToString();
                txt_puesto.Text = dt.Rows[0]["PUESTO"].ToString();
                txt_rfc.Text = dt.Rows[0]["RFC"].ToString();
                txt_vigencia.Text = dt.Rows[0]["VIGENCIA"].ToString();
                txt_imss.Text = dt.Rows[0]["AFILIACION"].ToString();
            }
            con.Close();
        }

        private void nuevo()
        {
            txt_clave.Text = "";
            txt_nombre.Text = "";
            txt_departamento.Text = "";
            txt_rfc.Text = "";
            txt_imss.Text = "";
            txt_puesto.Text = "";
            txt_vigencia.Text = "";
            txt_clave.Enabled = true;
            pictureBox1.ImageLocation = "V:/Sistemas/SAAM/LogoFinal" + ".png";
            cmb_tipo.Text = "";
            cmb_tipo.Enabled = true;
            txt_vigencia.Visible = false;
            lbl_estado.Visible = false;
            btn_agregar.Enabled = false;
            txt_clave.Focus();
        }


        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }
        private void cmb_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txt_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txt_imss_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txt_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txt_rfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txt_vigencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txt_vigencia_TextChanged(object sender, EventArgs e)
        {
            if (txt_vigencia.Text == "VIGENTE")
            {
                txt_vigencia.BackColor = Color.Green;
                cmb_tipo.Enabled = true;
            }
            else if (txt_vigencia.Text == "BAJA")
            {
                txt_vigencia.BackColor = Color.IndianRed;
                cmb_tipo.Enabled = false;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cmb_tipo.Text == "")
            {
                MessageBox.Show("Es necesario seleccionar una opción.", "Aviso");
                cmb_tipo.Focus();
            }
        }
    }
}
