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
            txt_estado.Text = "";
            cmb_turno.Text = "";
            lbl_factor.Visible = false;
            Panel_secundario.Visible = false;
            panel_final.Visible = false;
          
            txt_SDO1.Enabled = false;
            txt_SDO2.Enabled = false;
            txt_SDO3.Enabled = false;
            txt_SDO4.Enabled = false;
            txt_SDO5.Enabled = false;
            
            groupBox2.Visible = false;
            groupBox2.Enabled = false;

            btn_pp_siguiente.Enabled = false;
            btn_comprueba.Enabled = false;
           txt_estado.Visible = false;
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

        private void Comprueba_Existencia()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SELECT CLAVE, VIGENCIA, RFC, AFILIACION  FROM [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] WHERE CURP = @CURP OR RFC = @RFC OR AFILIACION = @AFILIACION";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                da.SelectCommand.Parameters.Add("@CURP", SqlDbType.VarChar).Value = txt_curp.Text;
                da.SelectCommand.Parameters.Add("@RFC", SqlDbType.VarChar).Value = txt_rfc.Text;
                da.SelectCommand.Parameters.Add("@AFILIACION", SqlDbType.VarChar).Value = txt_nss.Text;


                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    if (MessageBox.Show("Empleado registrado con anterioridad  ¿Desea Continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        txt_Clave.Text = dt.Rows[0]["CLAVE"].ToString();
                        txt_estado.Text = dt.Rows[0]["VIGENCIA"].ToString();
                        cargar_informacion();
                        btn_pp_siguiente.Enabled = true;

                        if (txt_estado.Text == "BAJA")
                        {
                            groupBox2.Visible = true;
                        }
                        else if (txt_estado.Text == "VIGENTE")
                        {
                            MessageBox.Show("EMPLEADO SE ENCUENTRA VIGENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            btn_pp_siguiente.Enabled = false;
                        }

                    }
                    else
                    {
                        nuevo();
                    }
                }
                else
                {
                    MessageBox.Show("Empleado disponible para registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_estado.Text = "A";
                    btn_pp_siguiente.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("No se pudo comprobar existencia, favor de revisar con el administrador", "Aviso");
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
            da.SelectCommand.Parameters.Add("@Emp", SqlDbType.VarChar, 100).Value = txt_Clave.Text;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txt_calle.Text = dt.Rows[0]["CALLE"].ToString();
                txt_numero.Text = dt.Rows[0]["NUMERO"].ToString();
                txt_colonia.Text = dt.Rows[0]["COLONIA"].ToString();
                txt_cp.Text = dt.Rows[0]["CP"].ToString();
                txt_municipio.Text = dt.Rows[0]["MUNICIPIO"].ToString();
                cmb_estado.Text = dt.Rows[0]["ESTADO"].ToString();
                txt_telefono.Text = dt.Rows[0]["TELEFONO"].ToString();
                txt_baja.Text = dt.Rows[0]["BAJA"].ToString();
                txt_reingreso.Text = dt.Rows[0]["REINGRESO"].ToString();
                txt_baja_2.Text = dt.Rows[0]["BAJA_2"].ToString();
                txt_reingreso_2.Text = dt.Rows[0]["REINGRESO_2"].ToString();
                txt_baja_3.Text = dt.Rows[0]["BAJA_3"].ToString();
                cmb_Civil.Text = dt.Rows[0]["E_CIVIL"].ToString();
                cmb_genero.Text = dt.Rows[0]["GEN"].ToString();
                dtm_nacimiento.Text = dt.Rows[0]["NACIMIENTO"].ToString();
                txt_curp.Text = dt.Rows[0]["CURP"].ToString();
                txt_motivo.Text = dt.Rows[0]["MOTIVO"].ToString();
                txt_dias.Text = dt.Rows[0]["DIAS"].ToString();
                txt_meses.Text = dt.Rows[0]["MESES"].ToString();
                txt_años.Text = dt.Rows[0]["AÑOS"].ToString();
            }
            con.Close();
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
            panel_final.Visible = true;
            Panel_secundario.Visible = false;
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

        private void Btn_comprueba_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nss.Text))
            {
                MessageBox.Show("Es necesario llenar ");
            }
           else if (string.IsNullOrEmpty(txt_rfc.Text))
            {
                MessageBox.Show("Es necesario llenar ");
            }
            else if (string.IsNullOrEmpty(txt_curp.Text))
            {
                MessageBox.Show("Es necesario llenar ");
            }
            else
            {
                Comprueba_Existencia();
            }

            
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro guardado correctamente.");
            Panel_principal.Visible = true;
            nuevo();
            selecciona_clave();
        }
        private void Btn_fin_anterior_Click(object sender, EventArgs e)
        {
            Panel_secundario.Visible = true;
            panel_final.Visible = false;
        }
        private void Panel_secundario_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Lbl_estado_TextChanged(object sender, EventArgs e)
        {         
       }
        private void Txt_estado_KeyPress(object sender, KeyPressEventArgs e)
        {       
        }
        private void Txt_estado_TextChanged(object sender, EventArgs e)
        {
        }
        private void Txt_nss_TextChanged(object sender, EventArgs e)
        {       
        }
        private void Txt_curp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar))
            {
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
        private void Cmb_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_Civil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_genero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_escolaridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_relacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_ruta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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
        private void Txt_cp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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
        private void Txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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
        private void Cmb_año_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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
        private void Txt_nss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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
        private void Txt_rfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar))
            {
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
        private void Txt_calle_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Txt_colonia_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Txt_municipio_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Txt_tel_contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
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
        private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Txt_interior_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Txt_lugar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
