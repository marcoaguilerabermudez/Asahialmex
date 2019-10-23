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
    public partial class Frm_bajas : Form
    {
        public Frm_bajas()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "NUEVO");
            tt.SetToolTip(btn_baja, "APLICAR BAJA");
        }

        private void Frm_bajas_Load(object sender, EventArgs e)
        {
            nuevo();
            l_fecha.Visible = false;
            l_hora.Visible = false;
       
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");


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
                txt_nombre.Text = dt.Rows[0]["NOMBRE_EMPLEADO"].ToString();
                txt_calle.Text = dt.Rows[0]["CALLE"].ToString();
                txt_numero.Text = dt.Rows[0]["NUMERO"].ToString();
                txt_colonia.Text = dt.Rows[0]["COLONIA"].ToString();
                txt_cp.Text = dt.Rows[0]["CP"].ToString();
                txt_municipio.Text = dt.Rows[0]["MUNICIPIO"].ToString();
                cmb_estado.Text = dt.Rows[0]["ESTADO"].ToString();
                txt_telefono.Text = dt.Rows[0]["TELEFONO"].ToString();
                txt_departamento.Text = dt.Rows[0]["DEPARTAMENTO"].ToString();
                txt_puesto.Text = dt.Rows[0]["PUESTO"].ToString();
                txt_alta.Text = dt.Rows[0]["ALTA"].ToString();
                txt_baja.Text = dt.Rows[0]["BAJA"].ToString();
                txt_reingreso.Text = dt.Rows[0]["REINGRESO"].ToString();
                txt_baja_2.Text = dt.Rows[0]["BAJA_2"].ToString();
                txt_reingreso_2.Text = dt.Rows[0]["REINGRESO_2"].ToString();
                txt_baja_3.Text = dt.Rows[0]["BAJA_3"].ToString();
                cmb_Civil.Text = dt.Rows[0]["E_CIVIL"].ToString();
                cmb_genero.Text = dt.Rows[0]["GEN"].ToString();
                txt_vigencia.Text = dt.Rows[0]["VIGENCIA"].ToString();
                txt_rfc.Text = dt.Rows[0]["RFC"].ToString();
                txt_afiliacion.Text = dt.Rows[0]["AFILIACION"].ToString();
                dtm_nacimiento.Text = dt.Rows[0]["NACIMIENTO"].ToString();

                txt_curp.Text = dt.Rows[0]["CURP"].ToString();
                txt_sueldo.Text = dt.Rows[0]["SUELDO"].ToString();
                txt_motivo.Text = dt.Rows[0]["MOTIVO"].ToString();
                txt_dias.Text = dt.Rows[0]["DIAS"].ToString();
                txt_meses.Text = dt.Rows[0]["MESES"].ToString();
                txt_años.Text = dt.Rows[0]["AÑOS"].ToString();
                txt_clave.Enabled = false;
            }
            con.Close();
        }

        private void nuevo()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                    ctrl.Enabled = false;
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.Text = "";
                    ctrl.Enabled = false;
                }
            }
            txt_baja.Text = "";
            txt_reingreso.Text = "";
            txt_baja_2.Text = "";
            txt_reingreso_2.Text = "";
            txt_baja.Text = "";
            txt_baja_3.Text = "";
            txt_reingreso.Enabled = false;
            txt_baja_2.Enabled = false;
            txt_reingreso_2.Enabled = false;
            txt_baja.Enabled = false;
            txt_baja_3.Enabled = false;
            pictureBox1.ImageLocation = "V:/Sistemas/Listado de bajas/LogoFinal" + ".png";
            btn_baja.Enabled = false;
            lbl_motivo.Visible = false;
            lbl_dias.Visible = false;
            lbl_años.Visible = false;
            txt_motivo.Visible = false;
            txt_años.Visible = false;
            txt_meses.Visible = false;
            lbl_meses.Visible = false;
            txt_dias.Visible = false;
            lbl_baja.Visible = false;
            lbl_reingreso.Visible = false;
            groupBox1.Visible = false;
            txt_baja.Visible = false;
            txt_reingreso.Visible = false;
            txt_baja_2.Visible = false;
            txt_reingreso_2.Visible = false;
            txt_baja_3.Visible = false;

            txt_clave.Text = "";
            txt_clave.Focus();
            txt_clave.Enabled = true;
            dtm_nacimiento.Text = "";
            dtm_nacimiento.Enabled = false;
        }


        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            l_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            l_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Cmb_genero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cmb_Civil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cmb_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Txt_clave_KeyPress(object sender, KeyPressEventArgs e)
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
                btn_baja.Enabled = true;

                if (txt_vigencia.Text == "VIGENTE")
                {
                    btn_baja.Enabled = true;
                    txt_vigencia.Visible = true;
                    lbl_estado.Visible = true;
                    lbl_motivo.Visible = false;
                    lbl_dias.Visible = false;
                    lbl_años.Visible = false;
                    txt_motivo.Visible = false;
                    txt_años.Visible = false;
                    txt_meses.Visible = false;
                    lbl_meses.Visible = false;
                    txt_dias.Visible = false;
                }
                else if (txt_vigencia.Text == "BAJA")
                {
                        btn_baja.Enabled = false;
                        txt_vigencia.Visible = true;
                        lbl_estado.Visible = true;                     
                        lbl_motivo.Visible = true;
                        lbl_dias.Visible = true;
                        lbl_años.Visible = true;
                        txt_motivo.Visible = true;
                        txt_años.Visible = true;
                        txt_meses.Visible = true;
                        lbl_meses.Visible = true;
                        txt_dias.Visible = true;
                    groupBox1.Visible = true;
                    lbl_baja.Visible = true;
                    lbl_reingreso.Visible = true;
                    txt_baja.Visible = true;
                    txt_reingreso.Visible = true;
                    txt_baja_2.Visible = true;
                    txt_reingreso_2.Visible = true;
                    txt_baja_3.Visible = true;
                }
                else
                  {
                        txt_vigencia.Visible = true;
                        lbl_estado.Visible = true;
                        lbl_motivo.Visible = false;
                        lbl_dias.Visible = false;
                        lbl_años.Visible = false;
                        txt_motivo.Visible = false;
                        txt_años.Visible = false;
                        txt_meses.Visible = false;
                        txt_años.Visible = false;
                        lbl_meses.Visible = false;
                        txt_dias.Visible = false;
                        txt_vigencia.Visible = false;
                        lbl_estado.Visible = false;
                        pictureBox1.ImageLocation = "V:/Sistemas/Listado de bajas/LogoFinal" + ".png";
                 }  
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            cargar_informacion();
        }

        private void Btn_baja_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro dar de baja al empleado " + txt_clave.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Frm_Fecha_Baja emp = new Frm_Fecha_Baja();
                emp.lbl_clave_empleado.Text = txt_clave.Text;
                emp.ShowDialog();
                txt_clave.Text = "";
                txt_clave.Focus();
                txt_clave.Enabled = true;
                nuevo();
            }
            else
            {
            }
        }

        private void Txt_cp_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_numero_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
