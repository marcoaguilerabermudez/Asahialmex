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
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;


namespace CsPresentacion.Formularios.RH
{
    public partial class Frm_Modifica_Sueldo : Form
    {
        public Frm_Modifica_Sueldo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        double sd1;
        double sd2;

        private void Frm_Modifica_Sueldo_Load(object sender, EventArgs e)
        {
            nuevo();
        }

        //Métodos

        public void nuevo()
        {
            txt_clave.Text = "";
            txt_nombre.Text = "";
            txt_materno.Text = "";
            txt_paterno.Text = "";
            pictureBox1.ImageLocation = "V:/Sistemas/SAAM/LogoFinal" + ".png";
            btn_mod_sueldo.Enabled = false;
            txt_SDO1_2.Enabled = false;
            txt_SDO2_2.Enabled = false;
            txt_SDO3_2.Enabled = false;
            txt_SDO4_2.Enabled = false;
            txt_SDO5_2.Enabled = false;
            txt_SDO1_2.Text = "0.00";
            txt_SDO2_2.Text = "0.00";
            txt_SDO3_2.Text = "0.00";
            txt_SDO4_2.Text = "0.00";
            txt_SDO5_2.Text = "0.00";
            cmb_motivo_sueldo.Text = "";
            cmb_motivo_sueldo.Enabled = false;
            dtm_sueldo.Text = "";
            btn_eliminar_sueldo.Enabled = false;
            lbl_comprueba_sueldo.Text = "";
            lbl_comprueba_sueldo.Visible = false;
            dtm_sueldo.Enabled = false;
            lbl_motivo.Text = "";
            lbl_motivo.Visible = false;
            txt_factor_sueldo.Visible = false;
            txt_factor_sueldo.Text = "1.07808";
            mostrar_dgv_sueldo();
            txt_vigencia.Text = "";
            txt_vigencia.Visible = false;
            txt_clave.Focus();
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
                txt_nombre.Text = dt.Rows[0]["NOMBRE"].ToString();
                txt_paterno.Text = dt.Rows[0]["PATERNO"].ToString();
                txt_materno.Text = dt.Rows[0]["MATERNO"].ToString();
                txt_vigencia.Text = dt.Rows[0]["VIGENCIA"].ToString();
                txt_SDO1_2.Text = dt.Rows[0]["SUELDO"].ToString();
                lbl_comprueba_sueldo.Text = dt.Rows[0]["SUELDO"].ToString();
                txt_SDO2_2.Text = dt.Rows[0]["SD2"].ToString();
                txt_SDO3_2.Text = dt.Rows[0]["SD3"].ToString();
                txt_SDO4_2.Text = dt.Rows[0]["SD4"].ToString();
                txt_SDO5_2.Text = dt.Rows[0]["SD5"].ToString();
                txt_factor_sueldo.Text = dt.Rows[0]["FACTOR"].ToString(); 
            }
            else
            {
                MessageBox.Show("El empleado no existe, favor de verificar", "Aviso".ToString());
                txt_clave.Focus();
            }
            con.Close();
        }

        private void mostrar_dgv_sueldo()// Método para llenar DatagridView de sueldo
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Modifica_sueldo_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_sueldo.Text);
                cmd.Parameters.AddWithValue("@SD01", txt_SDO1_2.Text);
                cmd.Parameters.AddWithValue("@SD02", txt_SDO3_2.Text);
                cmd.Parameters.AddWithValue("@Motivo", lbl_motivo.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_sueldo.DataSource = dt;
                con.Close();
                Diseño_dgv_sueldo(dgv_sueldo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void inserta_sueldo()// Método para eliminar información
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Modifica_sueldo_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "2");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_sueldo.Text);
                cmd.Parameters.AddWithValue("@SD01", txt_SDO1_2.Text);
                cmd.Parameters.AddWithValue("@SD02", txt_SDO3_2.Text);
                cmd.Parameters.AddWithValue("@Motivo", lbl_motivo.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Diseño_dgv_sueldo(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//No. Empleado
            dgv.Columns[1].Width = 80;//Fecha
            dgv.Columns[2].Width = 60;//Fecha_Mod
            dgv.Columns[3].Width = 60;//sueldo
            dgv.Columns[4].Width = 60;//sueldo2
            dgv.Columns[5].Width = 60;//sueldo3
            dgv.Columns[6].Width = 173;//sueldo4
        }
        private void elimina_sueldo()// Método para eliminar información
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Modifica_sueldo_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "3");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_sueldo.Text);
                cmd.Parameters.AddWithValue("@SD01", txt_SDO1_2.Text);
                cmd.Parameters.AddWithValue("@SD02", txt_SDO3_2.Text);
                cmd.Parameters.AddWithValue("@Motivo", lbl_motivo.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                cmb_motivo_sueldo.Text = "";
                dtm_sueldo.Text = "";
                txt_SDO1_2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void Solo_numeros(object sender, KeyPressEventArgs e, char cSymbol)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != cSymbol)
            {
                e.Handled = true;
            }

            if (e.KeyChar == cSymbol && (sender as TextBox).Text.IndexOf(cSymbol) > -1)
            {
                e.Handled = true;
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

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
                mostrar_dgv_sueldo();
                pictureBox1.ImageLocation = "V:/2. RECURSOS HUMANOS/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";

                if (txt_vigencia.Text == "VIGENTE")
                {
                    txt_SDO1_2.Enabled = true;
                    cmb_motivo_sueldo.Enabled = true;    
                }
                else if (txt_vigencia.Text == "BAJA")
                {
                    txt_SDO1_2.Enabled = false;
                    cmb_motivo_sueldo.Enabled = false;
                }
                else
                {
                    pictureBox1.ImageLocation = "V:/Sistemas/SAAM/LogoFinal" + ".png";
                }
            }
        }

        private void cmb_motivo_sueldo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_motivo_sueldo.Text == "MODIFICACION DE SALARIO") { lbl_motivo.Text = "01"; }
            else if (cmb_motivo_sueldo.Text == "PROMOCION") { lbl_motivo.Text = "02"; }
            else if (cmb_motivo_sueldo.Text == "ANTIGUEDAD") { lbl_motivo.Text = "03"; }
            else if (cmb_motivo_sueldo.Text == "EVALUACION 3 MESES") { lbl_motivo.Text = "04"; }
            else if (cmb_motivo_sueldo.Text == "EVALUACION ANUAL") { lbl_motivo.Text = "05"; }
            dtm_sueldo.Text = "";
            dtm_sueldo.Enabled = true;
            btn_mod_sueldo.Enabled = true;
        }

        private void btn_mod_sueldo_Click(object sender, EventArgs e)
        {
            sd1 = double.Parse(txt_SDO1_2.Text);
            sd2 = double.Parse(lbl_comprueba_sueldo.Text);

            if (sd1 < sd2)
            {
                MessageBox.Show("Debe ser un sueldo mayor, al sueldo actual", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SDO1_2.Focus();
            }
            else if (sd1 == sd2)
            {
                MessageBox.Show("Debe ser un sueldo mayor, al sueldo actual", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SDO1_2.Focus();
            }
            else
            {
                inserta_sueldo();
                mostrar_dgv_sueldo();
            }
        }

        private void btn_eliminar_sueldo_Click_1(object sender, EventArgs e)
        {
            elimina_sueldo();
            mostrar_dgv_sueldo();
            cargar_informacion();
        }

        private void txt_SDO1_2_Leave(object sender, EventArgs e)
        {
            double f, sd, Re;

            f = double.Parse(txt_factor_sueldo.Text);
            sd = double.Parse(txt_SDO1_2.Text);
            Re = f * sd;
            txt_SDO3_2.Text = Re.ToString();
            txt_SDO5_2.Text = Re.ToString();
        }

        private void txt_SDO1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solo_numeros(sender, e, '.');
        }

        private void cmb_motivo_sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgv_sueldo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_sueldo.Rows[e.RowIndex];
                dtm_sueldo.Text = row.Cells["FECHA"].Value.ToString();
                cmb_motivo_sueldo.Text = row.Cells["MOTIVO"].Value.ToString();

                if (txt_vigencia.Text == "VIGENTE")
                {
                    btn_eliminar_sueldo.Enabled = true;
                }
                else if (txt_vigencia.Text == "BAJA")
                {
                    btn_eliminar_sueldo.Enabled = false;
                }
            }
        }
    }
}
