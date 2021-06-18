using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        int Aviso_empleado;

        private void Frm_Altas_Load(object sender, EventArgs e)
        {
            nuevo();
            cargar_puesto(cmb_puesto);
           cargar_departemento(cmb_departamento);
            selecciona_clave();
            txt_curp.Mask = ">LLLL000000LLLLLLCC";
            txt_rfc.Mask = ">LLLL000000CCC";
        }
//Métodos
        public void cargar_departemento(ComboBox inte)//Cargar departamento en cmb
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT RTRIM(DESCRIPCION)as 'DEPARTAMENTO' FROM  [asahi16].[Supervisor_giro].[DEPTO] WHERE CENTRO_COSTO <>16 and RTRIM(DESCRIPCION) <> 'PRESIDENCIA' ORDER BY DEPARTAMENTO ASC", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["DEPARTAMENTO"].ToString());
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
            lbl_var.Visible = false;
            lbl_var.Text = "1";
            lbl_tipo_ingreso.Text = "NUEVO INGRESO";
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
            txt_telefono.Text = "";
            txt_calle.Text = "";
            txt_numero.Text = "";
            txt_colonia.Text = "";
            txt_municipio.Text = "";
            txt_cp.Text = "";
            txt_sector.Text = "";
            cmb_Civil.Text = "";
            cmb_genero.Text = "";
            dtm_nacimiento.Text = "";
            txt_lugar_nac.Text = "";
            cmb_escolaridad.Text = "";
            txt_años.Text = "";
            txt_email.Text = "";
            txt_contacto.Text = "";
            txt_tel_contacto.Text = "";
            cmb_parentesco.Text = "";
            cmb_ruta.Text = "";
            txt_interior.Text = "";
            cmb_estado.Text = "";
            txt_año_graduacion.Text = "";
            txt_contacto.Text = "";
            cmb_estado_nacimiento.Text = "";
            lbl_infonavit.Text = "0";
            lbl_infonavit.Visible = false;
            txt_factor.Visible = false;
            lbl_factor.Visible = false;
            Panel_principal.Visible = true;
            Panel_secundario.Visible = false;
            panel_final.Visible = false;
            groupBox2.Visible = false;
           lbl_tipo_empleado.Visible = false;
           txt_estado.Visible = false;
            txt_SDO1.Enabled = false;
            txt_SDO2.Enabled = false;
           txt_SDO3.Enabled = false;
            txt_SDO4.Enabled = false;
            txt_SDO5.Enabled = false;
            groupBox2.Enabled = false;
            btn_pp_siguiente.Enabled = false;
            btn_comprueba.Enabled = false;
            cmb_estado_nacimiento.Enabled = true;
            Aviso_empleado = 0;
            rdb_nacional.Checked = true;
            txt_infonavit.Text = "";
            txt_curp.Focus();
        }

        private Boolean valida_email(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
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
        private void Registra_empleado()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "[dbo].[sp_Reg_Mod_FM]";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Var", SqlDbType.VarChar).Value = lbl_var.Text;
                da.SelectCommand.Parameters.Add("@Clave", SqlDbType.VarChar).Value = txt_Clave.Text;
                da.SelectCommand.Parameters.Add("@catalogodepartamento", SqlDbType.VarChar).Value = cmb_departamento.Text;
                da.SelectCommand.Parameters.Add("@zona", SqlDbType.VarChar).Value = txt_lugar_nac.Text ;
                da.SelectCommand.Parameters.Add("@ruta", SqlDbType.VarChar).Value = cmb_ruta.Text;
                da.SelectCommand.Parameters.Add("@NOMBREN", SqlDbType.VarChar).Value = txt_nombre.Text;
                da.SelectCommand.Parameters.Add("@NOMBREP", SqlDbType.VarChar).Value = txt_paterno.Text;
                da.SelectCommand.Parameters.Add("@NOMBREM", SqlDbType.VarChar).Value = txt_materno.Text;
                da.SelectCommand.Parameters.Add("@PE", SqlDbType.VarChar).Value = lbl_tipo_empleado.Text;
                da.SelectCommand.Parameters.Add("@RFC", SqlDbType.VarChar).Value = txt_rfc.Text;
                da.SelectCommand.Parameters.Add("@turno", SqlDbType.VarChar).Value = cmb_turno.Text;
                da.SelectCommand.Parameters.Add("@afiliacion", SqlDbType.VarChar).Value = txt_nss.Text;
                da.SelectCommand.Parameters.Add("@curp", SqlDbType.VarChar).Value = txt_curp.Text;
                da.SelectCommand.Parameters.Add("@puesto", SqlDbType.VarChar).Value = cmb_puesto.Text;
                da.SelectCommand.Parameters.Add("@calle", SqlDbType.VarChar).Value = txt_calle.Text;
                da.SelectCommand.Parameters.Add("@numero", SqlDbType.VarChar).Value = txt_numero.Text;
                da.SelectCommand.Parameters.Add("@interior", SqlDbType.VarChar).Value = txt_interior.Text;
                da.SelectCommand.Parameters.Add("@colonia", SqlDbType.VarChar).Value = txt_colonia.Text;
                da.SelectCommand.Parameters.Add("@cp", SqlDbType.VarChar).Value = txt_cp.Text;
                da.SelectCommand.Parameters.Add("@municipio", SqlDbType.VarChar).Value = txt_municipio.Text;
                da.SelectCommand.Parameters.Add("@estado", SqlDbType.VarChar).Value = cmb_estado.Text;
                da.SelectCommand.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txt_telefono.Text;
                da.SelectCommand.Parameters.Add("@fechanacimiento", SqlDbType.VarChar).Value = dtm_nacimiento.Text;
                da.SelectCommand.Parameters.Add("@lugarnacimiento", SqlDbType.VarChar).Value = txt_lugar_nac.Text;
                da.SelectCommand.Parameters.Add("@estadocivil", SqlDbType.VarChar).Value = cmb_Civil.Text;
                da.SelectCommand.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = cmb_escolaridad.Text;
                da.SelectCommand.Parameters.Add("@sexo", SqlDbType.VarChar).Value = cmb_genero.Text;
                da.SelectCommand.Parameters.Add("@graduacion", SqlDbType.VarChar).Value = txt_año_graduacion.Text;
                da.SelectCommand.Parameters.Add("@emergenciacontacto", SqlDbType.VarChar).Value = txt_contacto.Text;
                da.SelectCommand.Parameters.Add("@emergenciaparentesco", SqlDbType.VarChar).Value = cmb_parentesco.Text;
                da.SelectCommand.Parameters.Add("@emergenciatelefono", SqlDbType.VarChar).Value = txt_tel_contacto.Text;
               da.SelectCommand.Parameters.Add("@estadonacimiento", SqlDbType.VarChar).Value = cmb_estado_nacimiento.Text;
                da.SelectCommand.Parameters.Add("@nacionalidad", SqlDbType.VarChar).Value = txt_nacionalidad.Text;
                da.SelectCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = txt_email.Text;
                da.SelectCommand.Parameters.Add("@sdo1", SqlDbType.VarChar).Value = txt_SDO1.Text;
                da.SelectCommand.Parameters.Add("@sdo2", SqlDbType.VarChar).Value = txt_SDO3.Text;
                da.SelectCommand.Parameters.Add("@Aviso", SqlDbType.VarChar).Value = Aviso_empleado;
                da.SelectCommand.Parameters.Add("@Hijos", SqlDbType.VarChar).Value = txt_hijos.Text;
                da.SelectCommand.Parameters.Add("@Infonavit", SqlDbType.VarChar).Value = txt_infonavit.Text;

                da.Fill(dt);
                con.Close();
                MessageBox.Show("El empleado de registró correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.ToString());
            }
        }
        private void Comprueba_Existencia()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SELECT CLAVE, VIGENCIA, RFC, AFILIACION  FROM [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] WHERE CURP = @CURP";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                da.SelectCommand.Parameters.Add("@CURP", SqlDbType.VarChar).Value = txt_curp.Text;
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
                            lbl_tipo_ingreso.Text = "REINGRESO";
                            lbl_var.Text = "2";
                        }
                        else if (txt_estado.Text == "VIGENTE")
                        {
                            MessageBox.Show("EMPLEADO SE ENCUENTRA VIGENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_pp_siguiente.Enabled = false;
                            lbl_tipo_ingreso.Text = "VIGENTE";
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
                    txt_paterno.Focus();
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
                txt_nombre.Text = dt.Rows[0]["NOMBRE"].ToString();
                txt_paterno.Text = dt.Rows[0]["PATERNO"].ToString();
                txt_materno.Text = dt.Rows[0]["MATERNO"].ToString();
                txt_rfc.Text = dt.Rows[0]["RFC"].ToString();
                txt_nacionalidad.Text = dt.Rows[0]["NACIONALIDAD"].ToString();
                txt_telefono.Text = dt.Rows[0]["TELEFONO"].ToString();
                cmb_departamento.Text = dt.Rows[0]["DEPARTAMENTO"].ToString();
                txt_calle.Text = dt.Rows[0]["CALLE"].ToString();
                txt_numero.Text = dt.Rows[0]["NUMERO"].ToString();
                txt_colonia.Text = dt.Rows[0]["COLONIA"].ToString();
                txt_interior.Text = dt.Rows[0]["INTERIOR"].ToString();
                txt_cp.Text = dt.Rows[0]["CP"].ToString();
                txt_municipio.Text = dt.Rows[0]["MUNICIPIO"].ToString();
                cmb_estado.Text = dt.Rows[0]["ESTADO"].ToString();
                txt_baja.Text = dt.Rows[0]["BAJA"].ToString();
                txt_reingreso.Text = dt.Rows[0]["REINGRESO"].ToString();
                txt_baja_2.Text = dt.Rows[0]["BAJA_2"].ToString();
                txt_reingreso_2.Text = dt.Rows[0]["REINGRESO_2"].ToString();
                txt_baja_3.Text = dt.Rows[0]["BAJA_3"].ToString();
                cmb_Civil.Text = dt.Rows[0]["E_CIVIL"].ToString();
                cmb_genero.Text = dt.Rows[0]["GEN"].ToString();
                dtm_nacimiento.Text = dt.Rows[0]["NACIMIENTO"].ToString();
                txt_nss.Text = dt.Rows[0]["AFILIACION"].ToString();
                txt_motivo.Text = dt.Rows[0]["MOTIVO"].ToString();
                txt_dias.Text = dt.Rows[0]["DIAS"].ToString();
                txt_meses.Text = dt.Rows[0]["MESES"].ToString();
                txt_años.Text = dt.Rows[0]["AÑOS"].ToString();
                txt_contacto.Text = dt.Rows[0]["CONTACTO"].ToString();
                cmb_parentesco.Text = dt.Rows[0]["PARENTESCO"].ToString();
                txt_tel_contacto.Text = dt.Rows[0]["TEl_CONTACTO"].ToString();
                txt_lugar_nac.Text = dt.Rows[0]["LUGAR_NAC"].ToString();
                cmb_escolaridad.Text = dt.Rows[0]["ESCOLARIDAD"].ToString();
                txt_año_graduacion.Text = dt.Rows[0]["GRADUACION"].ToString();
                txt_email.Text = dt.Rows[0]["EMAIL"].ToString();
                cmb_estado_nacimiento.Text = dt.Rows[0]["ESTADO_NACIMIENTO"].ToString(); 
                txt_hijos.Text = dt.Rows[0]["HIJOS"].ToString();
                txt_infonavit.Text = dt.Rows[0]["INFONAVIT"].ToString();
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
                SqlCommand cmd = new SqlCommand("select distinct RTRIM(DESCRIPCION)AS 'PUESTO' from [asahi16].[Supervisor_giro].[Puesto]", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["PUESTO"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo departamento" + Error.ToString());
            }
        }

//Botones
        private void Button1_Click(object sender, EventArgs e)//Primer botón siguinte
        {
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Es necesario capturar el nombre de Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
            }
         
            else if (string.IsNullOrEmpty(cmb_departamento.Text))
            {
                MessageBox.Show("Es necesario capturar el Departamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_departamento.Focus();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text))
            {
                MessageBox.Show("Es necesario capturar el Puesto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_puesto.Focus();
            }
            else if (string.IsNullOrEmpty(txt_SDO1 .Text))
            {
                MessageBox.Show("Es necesario capturar el Sueldo diario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SDO1.Focus();
            }
            else if (string.IsNullOrEmpty(txt_SDO3.Text))
            {
                MessageBox.Show("Es necesario capturar el Var. IMMS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SDO1.Focus();
            }
            else
            {
                Panel_secundario.Visible = true;
                Panel_principal.Visible = false;
                txt_calle.Focus();
            }
        }
        private void Btn_ps_siguiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_calle.Text))
            {
                MessageBox.Show("Es necesario capturar información de la calle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_calle.Focus();
            }
            else if (string.IsNullOrEmpty(txt_numero.Text))
            {
                MessageBox.Show("Es necesario capturar información de la dirección completa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_numero.Focus();
            }

            else if (string.IsNullOrEmpty(cmb_genero.Text))
            {
                MessageBox.Show("Es necesario capturar información del genero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_genero.Focus();
            }

            else if (string.IsNullOrEmpty(txt_cp.Text))
            {
                MessageBox.Show("Es necesario capturar información del Código Postal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cp.Focus();
            }
            else if (string.IsNullOrEmpty(txt_colonia.Text))
            {
                MessageBox.Show("Es necesario capturar información de la colonia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_colonia.Focus();
            }

            else if (string.IsNullOrEmpty(txt_hijos.Text))
            {
                MessageBox.Show("Es necesario capturar información de cantidad de Hijos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hijos.Focus();
            }

            else
            {
                panel_final.Visible = true;
                Panel_secundario.Visible = false;
                cmb_escolaridad.Focus();
            }
        }
        private void Btn_ps_anterior_Click(object sender, EventArgs e)
        {
            Panel_secundario.Visible = false;
            Panel_principal.Visible = true;
            cmb_puesto.Focus();
        }
        private void Btn_pf_anterior_Click(object sender, EventArgs e)
        {
            Panel_secundario.Visible = true;
        }
        private void Btn_nuevo2_Click(object sender, EventArgs e)
        {
            nuevo();
            selecciona_clave();
        }
        private void Btn_comprueba_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_curp.Text))
            {
                MessageBox.Show("Es necesario capturar el Curp", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_curp.Focus();
            }
            else
            {
                Comprueba_Existencia();
            }
        }
        private void Button2_Click(object sender, EventArgs e)//Alta de empleado
        {
            if (string.IsNullOrEmpty(cmb_turno.Text))
            {
                MessageBox.Show("Es necesario capturar el turno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_turno.Focus();
            }
            else if (string.IsNullOrEmpty(cmb_ruta.Text))
            {
                MessageBox.Show("Es necesario capturar la ruta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_ruta.Focus();
            }
            else if (string.IsNullOrEmpty(txt_contacto.Text))
            {
                MessageBox.Show("Es necesario capturar información de contacto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_contacto.Focus();
            }
            else if (string.IsNullOrEmpty(txt_tel_contacto.Text))
            {
                MessageBox.Show("Es necesario capturar información de contacto completa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tel_contacto.Focus();
            }
            else if (string.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Es necesario capturar una dirección de correo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_email.Focus();
            }


            else if (string.IsNullOrEmpty(txt_infonavit.Text))
            {
                txt_infonavit.Text = "0";
            }

            else
            {
                Registra_empleado();
                Frm_Rep_Alta_empleado Rep = new Frm_Rep_Alta_empleado();
                Rep.CLAVE = Convert.ToInt32(txt_Clave.Text);
                Rep.ShowDialog();
                Panel_principal.Visible = true;
                nuevo();
                selecciona_clave();
            }
        }
        private void Btn_fin_anterior_Click(object sender, EventArgs e)
        {
            Panel_secundario.Visible = true;
            panel_final.Visible = false;
            txt_lugar_nac.Focus();
        }

//Eventos
        private void Panel_principal_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Cmb_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecciona_sueldo();

            if (cmb_puesto.Text == "DIRECTOR" || cmb_puesto.Text == "GERENTE" || cmb_puesto.Text == "COORDINADOR" || cmb_puesto.Text == "PRESIDENTE")
            {
                txt_SDO1.Enabled = true;
                txt_SDO1.Text = "";
                txt_SDO3.Text = "";
                txt_SDO5.Text = "";
            }
            else if (cmb_puesto.Text == "ASISTENTE DE GERENTE" || cmb_puesto.Text == "SUPERVISOR" || cmb_puesto.Text == "SUPERVISOR ISO" || cmb_puesto.Text == "STAFF" || cmb_puesto.Text == "TRADUCTOR" || cmb_puesto.Text == "LIDER ADMON")
            {
                txt_SDO1.Enabled = true;
            }
            else
            {
                txt_SDO1.Enabled = false;
            }
        }
        private void Cmb_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
        private void Cmb_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true;  }
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
        }
        private void Cmb_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
        private void Cmb_Civil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
        private void Cmb_genero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
        private void Cmb_escolaridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
        private void Cmb_relacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
        private void Cmb_ruta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
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
            else if (Char.IsNumber(e.KeyChar))
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
            else if (Char.IsNumber(e.KeyChar))
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
        private void Txt_contacto_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Txt_lugar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar))
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
        private void Txt_sector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar))
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
        private void Txt_interior_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void Txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        private void Cmb_estado_nacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
        private void Cmb_turno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_expatriado.Checked == true)
            {
                rdb_nacional.Checked =false;
                rdb_otro.Checked = false;
                cmb_estado_nacimiento.Enabled = false;
                Aviso_empleado = 1;
            }
        }
        private void Rdb_nacional_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_nacional.Checked == true)
            {
                rdb_expatriado.Checked = false;
                rdb_otro.Checked = false;
                cmb_estado_nacimiento.Enabled = true;
                Aviso_empleado = 0;
            }
        }
        private void Rdb_otro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_otro.Checked == true)
            {
                rdb_nacional.Checked = false;
                rdb_expatriado.Checked = false;
                cmb_estado_nacimiento.Enabled = true;
                Aviso_empleado = 0;
            }
        }
        private void Panel_final_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Txt_SDO1_TextChanged(object sender, EventArgs e)
        {
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
        private void Txt_SDO1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solo_numeros(sender, e, '.'); 
        }
        private void Txt_SDO1_Validated(object sender, EventArgs e)
        {
        }
        private void Txt_SDO1_Leave(object sender, EventArgs e)
        {
            double n1, n2, r;

            n1 = double.Parse(txt_factor.Text);
            n2 = double.Parse(txt_SDO1.Text);
            r = n1 * n2;
            txt_SDO3.Text = r.ToString();
            txt_SDO5.Text = r.ToString();
        }
        private void Txt_SDO3_TextChanged(object sender, EventArgs e)
        {  
        }
        private void Txt_SDO3_Leave(object sender, EventArgs e)
        {
        }
        private void Txt_SDO1_LocationChanged(object sender, EventArgs e)
        {
           // lbl_sueldo.Text = Letras(txt_SDO1.Text);
        }
        private void Txt_hijos_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Cmb_infonavit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_infonavit_SelectedIndexChanged(object sender, EventArgs e)
        {    
        }
        private void Txt_infonavit_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Txt_curp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_curp.Text))
            {
                btn_comprueba.Enabled = false;
                btn_pp_siguiente.Enabled = false;
            }
            else
            {
                btn_comprueba.Enabled = true;
                btn_comprueba.Enabled = true;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {

            if (valida_email(txt_email.Text))
            {
            }
            else
            {
                MessageBox.Show("Correo Erroneo, Favor de verificar.", "Aviso!");
            }

        }
    }
}
