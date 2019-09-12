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

namespace CsPresentacion
{
    public partial class Frm_Modificaciones : Form
    {
        public Frm_Modificaciones()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "NUEVA BUSQUEDA");
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");
        double Sueldo;
        double Factor;
        double Resultado;
        double Val1;
        double Val2;
        double sd1;
        double sd2;

        private void Frm_Empleados_Detalle_Load(object sender, EventArgs e)
        {
            nuevo();
            cargar_departemento(cmb_departamento);
            cargar_puesto(cmb_puesto);
            txt_curp.Mask = ">LLLL000000LLLLLL00";
            txt_rfc.Mask = ">LLLL000000CCC";
        }
        private void Modifica_turno()// Método para modificar turno de empleado
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Cambio_turno_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "2");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@TURNO", cmb_turno.Text);
                cmd.Parameters.AddWithValue("@FECHA", "22-08-2019");
                cmd.Parameters.AddWithValue("@CAMBIO", lbl_cambio.Text);
                cmd.Parameters.AddWithValue("@CATALOGO", lbl_Catalogo.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                MessageBox.Show("Turno modificado correctamente", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Eliminar_turno()// Método para modificar turno de empleado
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Cambio_turno_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "3");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@TURNO", cmb_turno.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha_turno.Text);
                cmd.Parameters.AddWithValue("@CAMBIO", lbl_cambio.Text);
                cmd.Parameters.AddWithValue("@CATALOGO", lbl_Catalogo.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                MessageBox.Show("Registro eliminado correctamente", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void mostrar_dgv_turno()// Método para llenar DatagridView de turno
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Cambio_turno_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@TURNO", cmb_turno.Text);
                cmd.Parameters.AddWithValue("@FECHA", "16-08-2019");
                cmd.Parameters.AddWithValue("@CAMBIO", lbl_cambio.Text);
                cmd.Parameters.AddWithValue("@CATALOGO", lbl_Catalogo.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_turno.DataSource = dt;
                con.Close();
                Diseño_dgv_turno(dgv_turno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Diseño_dgv_turno(DataGridView dgv)
        {
            dgv.Columns[0].Width = 55;//No. Empleado
            dgv.Columns[1].Width = 210;//Nombre empleado
            dgv.Columns[2].Width = 120;//Departamento
            dgv.Columns[3].Width = 100;//turno
            dgv.Columns[4].Width = 100;//cambio turno
        }

        private void Modifica_ruta()// Método para modificar ruta de empleado
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Cambio_Ruta_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "2");
                cmd.Parameters.AddWithValue("@RUTA", cmb_ruta.Text);
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                MessageBox.Show("Se modificó correctamente", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void mostrar_dgv_ruta()// Método para llenar DatagridView de Ruta
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Cambio_Ruta_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@RUTA", txt_clave.Text);
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_ruta.DataSource = dt;
                con.Close();
                Diseño_dgv_ruta(dgv_ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Diseño_dgv_ruta(DataGridView dgv)
        {
            dgv.Columns[0].Width = 55;//No. Empleado
            dgv.Columns[1].Width = 220;//Nombre empleado
            dgv.Columns[2].Width = 140;//Departamento
            dgv.Columns[3].Width = 140;//Ruta
        }

        private void Modifica_depto()// Método para modificar departamento de empleado
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Modifica_depto_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@CATALOGO", cmb_departamento.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha_dep.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close(); 
                MessageBox.Show("Se modificó correctamente", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ser una fecha diferente", "Aviso");
            }
        }
        private void Elimina_depto()// Método para modificar departamento de empleado
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Modifica_depto_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "3");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@CATALOGO", cmb_departamento.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha_dep.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                MessageBox.Show("Se Eliminó correctamente", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void mostrar_dgv_departamento()// Método para llenar DatagridView de departamento
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Modifica_depto_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "2");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@CATALOGO", cmb_departamento.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha_dep.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_depto.DataSource = dt;
                con.Close();
                Diseño_dgv_departamento(dgv_depto);
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.ToString());
            }      
        }
        private void Diseño_dgv_departamento(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//No. Empleado
            dgv.Columns[1].Width = 250;//Nombre empleado
            dgv.Columns[2].Width = 150;//Departamento
            dgv.Columns[3].Width = 90;//Fecha_Mod
        }

        private void mostrar_dgv_puesto()// Método para llenar DatagridView de puesto
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Modifica_puesto_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@PUESTO", cmb_puesto.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_puesto.Text);
                cmd.Parameters.AddWithValue("@SD01", txt_SDO1.Text);
                cmd.Parameters.AddWithValue("@SD02", txt_SDO3.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_puesto.DataSource = dt;
                con.Close();
                Diseño_dgv_puesto(dgv_puesto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Diseño_dgv_puesto(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//No. Empleado
            dgv.Columns[1].Width = 250;//Nombre empleado
            dgv.Columns[2].Width = 150;//Puesto
            dgv.Columns[3].Width = 90;//Fecha_Mod
        }//Diseño
        private void Inserta_puesto()// Método para insertar puesto
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Modifica_puesto_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "2");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@PUESTO", lbl_id_puesto.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_puesto.Text);
                cmd.Parameters.AddWithValue("@SD01", txt_SDO1.Text);
                cmd.Parameters.AddWithValue("@SD02", txt_SDO3.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                MessageBox.Show("Se modificó correctamente", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ser una fecha diferente", "Aviso");
            }
        }
        private void Elimina_puesto()// Método para eliminar puesto
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Modifica_puesto_fm]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "3");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@PUESTO", cmb_departamento.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_puesto.Text);
                cmd.Parameters.AddWithValue("@SD01", txt_SDO1.Text);
                cmd.Parameters.AddWithValue("@SD02", txt_SDO3.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                MessageBox.Show("Se eliminó correctamente", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar, contacte al administrador");
            }
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
        private void Diseño_dgv_sueldo(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//No. Empleado
            dgv.Columns[1].Width = 230;//Nombre empleado
            dgv.Columns[2].Width = 80;//Fecha
            dgv.Columns[3].Width = 60;//Fecha_Mod
            dgv.Columns[4].Width = 60;//sueldo
            dgv.Columns[5].Width = 60;//sueldo2
            dgv.Columns[6].Width = 60;//sueldo3
            dgv.Columns[7].Width = 140;//sueldo4
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
                txt_rfc.Text = dt.Rows[0]["RFC"].ToString();
                txt_curp.Text = dt.Rows[0]["CURP"].ToString();
                txt_vigencia.Text = dt.Rows[0]["VIGENCIA"].ToString();
                txt_nacionalidad.Text = dt.Rows[0]["NACIONALIDAD"].ToString();
                txt_telefono.Text = dt.Rows[0]["TELEFONO"].ToString();
                cmb_departamento.Text = dt.Rows[0]["DEPARTAMENTO"].ToString();
                lbl_Comprueba_depto.Text = dt.Rows[0]["DEPARTAMENTO"].ToString();
                cmb_puesto.Text = dt.Rows[0]["PUESTO"].ToString();
                lbl_valida_puesto.Text = dt.Rows[0]["PUESTO"].ToString();
                txt_calle.Text = dt.Rows[0]["CALLE"].ToString();
                txt_numero.Text = dt.Rows[0]["NUMERO"].ToString();
                txt_colonia.Text = dt.Rows[0]["COLONIA"].ToString();
                txt_interior.Text = dt.Rows[0]["INTERIOR"].ToString();
                txt_cp.Text = dt.Rows[0]["CP"].ToString();
                txt_municipio.Text = dt.Rows[0]["MUNICIPIO"].ToString();
                cmb_estado.Text = dt.Rows[0]["ESTADO"].ToString();
                txt_sector.Text = dt.Rows[0]["SECTOR"].ToString();
                cmb_Civil.Text = dt.Rows[0]["E_CIVIL"].ToString();
                cmb_genero.Text = dt.Rows[0]["GEN"].ToString();
                dtm_nacimiento.Text = dt.Rows[0]["NACIMIENTO"].ToString();
                txt_nss.Text = dt.Rows[0]["AFILIACION"].ToString();
                txt_contacto.Text = dt.Rows[0]["CONTACTO"].ToString();
                cmb_parentesco.Text = dt.Rows[0]["PARENTESCO"].ToString();
                txt_tel_contacto.Text = dt.Rows[0]["TEl_CONTACTO"].ToString();
                txt_lugar_nac.Text = dt.Rows[0]["LUGAR_NAC"].ToString();
                cmb_escolaridad.Text = dt.Rows[0]["ESCOLARIDAD"].ToString();
                txt_año_graduacion.Text = dt.Rows[0]["GRADUACION"].ToString();
                txt_email.Text = dt.Rows[0]["EMAIL"].ToString();
                cmb_estado_nacimiento.Text = dt.Rows[0]["ESTADO_NACIMIENTO"].ToString();
                txt_hijos.Text = dt.Rows[0]["HIJOS"].ToString();
                txt_num_infonavit.Text = dt.Rows[0]["INFONAVIT"].ToString();
                txt_compara2.Text = dt.Rows[0]["SUELDO"].ToString();
                txt_compara1.Text = dt.Rows[0]["SUELDO"].ToString();
                txt_SDO1.Text = dt.Rows[0]["SUELDO"].ToString();
                txt_SDO2.Text = dt.Rows[0]["SD2"].ToString();
                txt_SDO3.Text = dt.Rows[0]["SD3"].ToString();
                txt_SDO4.Text = dt.Rows[0]["SD4"].ToString();
                txt_SDO5.Text = dt.Rows[0]["SD5"].ToString();
                txt_SDO1_2.Text = dt.Rows[0]["SUELDO"].ToString();
                lbl_comprueba_sueldo.Text = dt.Rows[0]["SUELDO"].ToString();
                txt_SDO2_2.Text = dt.Rows[0]["SD2"].ToString();
                txt_SDO3_2.Text = dt.Rows[0]["SD3"].ToString();
                txt_SDO4_2.Text = dt.Rows[0]["SD4"].ToString();
                txt_SDO5_2.Text = dt.Rows[0]["SD5"].ToString();
                cmb_ruta.Text = dt.Rows[0]["RUTA"].ToString();
                cmb_turno.Text = dt.Rows[0]["TURNO"].ToString();
                lbl_escolaridad.Text = dt.Rows[0]["ESCOLARIDAD_NUM"].ToString();
                lbl_civil.Text = dt.Rows[0]["ESTADO_CIVIL"].ToString();
               lbl_id_turno.Text = dt.Rows[0]["CATALOGO"].ToString();
                txt_factor_sueldo.Text = dt.Rows[0]["FACTOR"].ToString();
            }
            else
            {
                MessageBox.Show("El empleado no existe, favor de verificar" , "Aviso".ToString());
                txt_clave.Focus();
            }
            con.Close();
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
        public void cargar_departemento(ComboBox inte)//Cargar departamento en cmb
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT RTRIM(DESCRIPCION)as 'DEPARTAMENTO' FROM  [asahi16].[Supervisor_giro].[DEPTO] WHERE CENTRO_COSTO <>16 and RTRIM(DESCRIPCION) <> 'PRESIDENCIA'", con);
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
        private void selecciona_sueldo()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SELECT SUELDO FROM [asahi16].[Supervisor_giro].[Puesto]  WHERE DESCRIPCION = @Puesto";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                da.SelectCommand.Parameters.Add("@Puesto", SqlDbType.VarChar).Value = cmb_puesto.Text;
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    txt_compara1.Text = dt.Rows[0]["SUELDO"].ToString();            
                }
            }
            catch
            { 
            }
        }

        private void Actualizar()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE  [asahi16].[Supervisor_giro].[Emprh] set  CALLE = '"+ txt_calle.Text+"',  NUMERO = "+ txt_numero.Text+ ",  COLONIA = '" + txt_colonia.Text+ "', SECTOR = '" + txt_sector.Text + "', CP = " + txt_cp.Text + ",  MUNICIPIO = '" + txt_municipio.Text+ "',  ESCOLARIDAD = '" + lbl_escolaridad.Text + "',   NACIONALIDAD = '" + txt_nacionalidad.Text + "',  EMAIL = '" + txt_email.Text + "',  EMERGENCIA_CONTACTO = '" + txt_contacto.Text + "', EMERGENCIA_TELEFONO = '" + txt_tel_contacto.Text + "', EMERGENCIA_PARENTESCO = '" + cmb_parentesco.Text + "', GRADUACION = " + txt_año_graduacion.Text + ", ESTADO_CIVIL = '" + lbl_civil.Text + "', TELEFONO_CELULAR = '" + txt_telefono.Text + "', SEXO = '" + cmb_genero.Text + "', FECHA_NACIMIENTO = '" + dtm_nacimiento.Text + "', ESTADO_NACIMIENTO = '" + cmb_estado.Text + "', LUGAR_NACIMIENTO = '" + txt_lugar_nac.Text + "' , ESTADO = '" + cmb_estado.Text + "' WHERE CLAVE = " + txt_clave.Text +"", con);
              SqlCommand cmd2 = new SqlCommand("UPDATE  [asahi16].[Supervisor_giro].[Empprin] set  NOMBREN = '" + txt_nombre.Text + "', NOMBREP = '" + txt_paterno.Text + "', NOMBREM = '" + txt_materno.Text + "', CURP = '" + txt_curp.Text + "', RFC = '" + txt_rfc.Text + "', AFILIACION = '" + txt_nss.Text + "', CREDITO_INFONAVIT = '" + txt_num_infonavit.Text + "'  WHERE CLAVE = " + txt_clave.Text + "", con);
               SqlCommand cmd3 = new SqlCommand("UPDATE  [asahi16].[Supervisor_giro].[EMPEXT] set  HIJOS = " + txt_hijos.Text + "   WHERE CLAVE = " + txt_clave.Text + "", con);
               cmd.Parameters.AddWithValue("@Clave", txt_clave.Text);
              cmd2.Parameters.AddWithValue("@Clave", txt_clave.Text);
               cmd3.Parameters.AddWithValue("@Clave", txt_clave.Text);
               cmd.ExecuteNonQuery();
              cmd2.ExecuteNonQuery();
               cmd3.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se actualizó" + error.ToString());
            }
        }
        public void nuevo()
        {
            txt_clave.Focus();
            txt_paterno.Text = "";
            txt_materno.Text = "";
            txt_nombre.Text = "";
            cmb_departamento.Text = "";
            cmb_puesto.Text = "";
            lbl_valida_puesto.Text = "";
            lbl_valida_puesto.Visible = false;
            txt_nacionalidad.Text = "";
            txt_SDO1.Text = "0.00";
            txt_SDO2.Text = "0.00";
            txt_SDO3.Text = "0.00";
            txt_SDO4.Text = "0.00";
            txt_SDO5.Text = "0.00";
            txt_nss.Text = "";
            txt_rfc.Text = "";
            txt_curp.Text = "";
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
            txt_factor.Visible = false;
            lbl_factor.Visible = false; 
            cmb_estado_nacimiento.Enabled = true;
            txt_clave.Text = "";
            pictureBox1.ImageLocation = "V:/Sistemas/SAAM/LogoFinal" + ".png";
            txt_vigencia.Text = "";
            txt_vigencia.Visible = false;
            lbl_estado.Visible = false;
            txt_compara1.Text = "0.00";
            txt_compara2.Text = "0.00";
            txt_compara1.Visible = false;
            txt_compara2.Visible = false;
            groupBox2.Enabled = false;
            cmb_puesto.Enabled = false;
            btn_mod_departamento.Enabled = false;
            btn_eliminar_depto.Enabled = false;
            lbl_Comprueba_depto.Text = "";
            lbl_Comprueba_depto.Visible = false;
            dtm_fecha_dep.Text = "";
            btn_mod_turno.Enabled = false;
            btn_eliminar_turno.Enabled = false;
            lbl_escolaridad.Text = "";
            lbl_escolaridad.Visible = false;
            lbl_civil.Text = "";
            lbl_civil.Visible = false;
            txt_hijos.Text = "";
            txt_num_infonavit.Text = "";
            dtm_fecha_turno.Text = "";
            lbl_id_turno.Text = "";
           lbl_Catalogo.Text = "";
            lbl_cambio.Text =  "";
            lbl_id_turno.Visible = false;
            lbl_Catalogo.Visible = false;
            lbl_cambio.Visible = false;
            btn_mod_ruta.Enabled = false;
            dtm_puesto.Text = "";
            btn_mod_puesto.Enabled = false;
            btn_eliminar_puesto.Enabled = false;
            dtm_puesto.Enabled = false;
            lbl_id_puesto.Visible = false;
            lbl_id_puesto.Text = "";
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
            cmb_ruta.Enabled = false;
            cmb_turno.Enabled = false;
            cmb_departamento.Enabled = false;
            dtm_fecha_dep.Enabled = false;
            btn_mod_general.Enabled = false;
            btn_mod_fam.Enabled = false;
        }
        private void Btn_buscar_Click(object sender, EventArgs e)
        {      
        }
    
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {

            nuevo();
            mostrar_dgv_departamento();
            mostrar_dgv_turno();
            mostrar_dgv_ruta();
            mostrar_dgv_puesto();
            mostrar_dgv_sueldo();  
        }

        private void Cmb_genero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_Civil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Frm_Empleados_Detalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //Actualizar();
            //Actualizar2();
            //nuevo();
        }
        private void Cmb_Civil_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                mostrar_dgv_departamento();
                mostrar_dgv_turno();
                mostrar_dgv_ruta();
                mostrar_dgv_puesto();
                mostrar_dgv_sueldo();

                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                btn_mod_fam.Enabled = true;
                btn_mod_general.Enabled = true;

                if (txt_vigencia.Text == "VIGENTE")
                {
                    txt_vigencia.Visible = true;
                    lbl_estado.Visible = true;
                    txt_vigencia.BackColor = Color.Green;
                    cmb_puesto.Enabled = true;
                    btn_mod_turno.Visible = true;
                    txt_SDO1_2.Enabled = true;
                    cmb_motivo_sueldo.Enabled = true;
                    cmb_ruta.Enabled = true;
                    cmb_turno.Enabled = true;
                    cmb_departamento.Enabled = true;
                    dtm_fecha_dep.Enabled = true;
                }
                else if (txt_vigencia.Text == "BAJA")
                {
                    txt_vigencia.Visible = true;
                    lbl_estado.Visible = true;
                    txt_vigencia.BackColor = Color.Red;
                    btn_mod_turno.Visible = false;
                    txt_SDO1_2.Enabled = false;
                    cmb_motivo_sueldo.Enabled = false;
                    cmb_ruta.Enabled = false;
                    cmb_turno.Enabled = false;
                    cmb_departamento.Enabled = false;
                    dtm_fecha_dep.Enabled = false;
                }
                else
                {
                    lbl_estado.Visible = false;
                    pictureBox1.ImageLocation = "V:/Sistemas/SAAM/LogoFinal" + ".png";
                } 
            }
        }
        private void Btn_modificar_Click(object sender, EventArgs e)
        {         
        }
        private void Btn_mmodifica_depto_Click(object sender, EventArgs e)
        {         
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
        private void Panel_principal_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Btn_pp_siguiente_Click(object sender, EventArgs e)
        {

            if (txt_clave.Text == "")
            {
                MessageBox.Show("Es necesario seleccionar un número de empleado.", "Aviso");
                txt_clave.Focus();
            }

            else if (txt_cp.Text == "")
            {
                MessageBox.Show("Es necesario capturar el código postal");
                txt_cp.Focus();
            }
            else if (txt_numero.Text == "")
            {
                MessageBox.Show("Es necesario capturar el número de dirección.");
                txt_numero.Focus();
            }
            else if (txt_numero.Text == "")
            {
                MessageBox.Show("Es necesario capturar el año de escolarida");
                txt_año_graduacion.Focus();
            }
            else if (txt_nss.Text == "")
            {
                MessageBox.Show("Es necesario capturar el NSS");
                txt_nss.Focus();
            }
            else if (txt_rfc.Text == "")
            {
                MessageBox.Show("Es necesario capturar el RFC");
                txt_rfc.Focus();
            }
            else if (txt_curp.Text == "")
            {
                MessageBox.Show("Es necesario capturar el CURP");
                txt_curp.Focus();
            }
            else
            {
                Actualizar();
                nuevo();
                mostrar_dgv_departamento();
                mostrar_dgv_turno();
                mostrar_dgv_ruta();
            }
        }
        private void Btn_ps_anterior_Click(object sender, EventArgs e)
        {
        }
        private void Btn_ps_siguiente_Click(object sender, EventArgs e)
        {
        }
        private void Btn_fin_anterior_Click(object sender, EventArgs e)
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
        private void Txt_numero_KeyPress_1(object sender, KeyPressEventArgs e)
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
        private void Txt_interior_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Txt_municipio_TextChanged(object sender, EventArgs e)
        {
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
        private void Cmb_estado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Txt_sector_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Txt_lugar_nac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSymbol(e.KeyChar))
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
        private void Txt_año_graduacion_KeyPress(object sender, KeyPressEventArgs e)
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
            else
            {
                e.Handled = true;
            }
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
        private void Cmb_Civil_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_genero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_estado_nacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_escolaridad_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        private void Cmb_parentesco_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_ruta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_turno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }  
        private void Cmb_escolaridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
        private void Cmb_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_puesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Btn_descargar_Click(object sender, EventArgs e)
        {
        }
        private void Cmb_puesto_SelectedIndexChanged(object sender, EventArgs e)
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
        private void Cmb_departamento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Btn_finalizar_Click(object sender, EventArgs e)
        {
        }
        private void Btn_mod_sueldo_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }
        private void Cmb_puesto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selecciona_sueldo();

            Val1 = double.Parse(txt_compara1.Text);
            Val2 = double.Parse(txt_compara2.Text);

            if (Val1 > Val2)
            {
                txt_SDO1.Text = txt_compara1.Text;
                txt_SDO2.Text = "0.00";
                txt_SDO4.Text = "0.00";
                lbl_factor.Text = "1.07808";
                Sueldo = double.Parse(txt_SDO1.Text);
                Factor = double.Parse(lbl_factor.Text);
                Resultado = Sueldo * Factor;
                txt_SDO3.Text = Resultado.ToString();
                txt_SDO5.Text = Resultado.ToString();
            }

            if (cmb_puesto.Text == "ASISTENTE DE GERENTE"){ lbl_id_puesto.Text = "001"; }
            else if (cmb_puesto.Text == "COORDINADOR")    { lbl_id_puesto.Text = "002"; }
            else if (cmb_puesto.Text == "DIRECTOR")       { lbl_id_puesto.Text = "003"; }
            else if (cmb_puesto.Text == "GERENTE")        { lbl_id_puesto.Text = "004"; }
            else if (cmb_puesto.Text == "LÍDER")          { lbl_id_puesto.Text = "005"; }
            else if (cmb_puesto.Text == "OPERADOR")       { lbl_id_puesto.Text = "006"; }
            else if (cmb_puesto.Text == "PRESIDENTE")     { lbl_id_puesto.Text = "007"; }
            else if (cmb_puesto.Text == "STAFF")          { lbl_id_puesto.Text = "008"; }
            else if (cmb_puesto.Text == "SUPERVISOR")     { lbl_id_puesto.Text = "009"; }
            else if (cmb_puesto.Text == "SUPERVISOR ISO") { lbl_id_puesto.Text = "010"; }
            else if (cmb_puesto.Text == "TRADUCTOR")      { lbl_id_puesto.Text = "011"; }
            else if (cmb_puesto.Text == "AUXILIAR")       { lbl_id_puesto.Text = "012"; }
            else if (cmb_puesto.Text == "CHOFER")         { lbl_id_puesto.Text = "013"; }
            else if (cmb_puesto.Text == "ALAMCENISTA")    { lbl_id_puesto.Text = "014"; }
            else if (cmb_puesto.Text == "LIMPIEZA")       { lbl_id_puesto.Text = "015"; }
            else if (cmb_puesto.Text == "LIDER ADMON")    { lbl_id_puesto.Text = "016"; }

            cmb_puesto.Enabled = false;
            btn_mod_puesto.Enabled = true;
            dtm_puesto.Enabled = true;
            dtm_puesto.Focus();
        }
        private void Btn_mod_turno_Click(object sender, EventArgs e)
        {
            if (txt_clave.Text == "")
            {
                MessageBox.Show("Es necesario seleccionar número de empleado", "Aviso");
                txt_clave.Focus();
            }
            else
            {
                if (lbl_id_turno.Text == "01" & cmb_turno.Text == "ADMINISTRATIVO")
                {
                    lbl_Catalogo.Text = "002";
                    lbl_cambio.Text = "SI";
                }
                else if (lbl_id_turno.Text == "02" & cmb_turno.Text == "MATUTINO")
                {
                    lbl_Catalogo.Text = "001";
                    lbl_cambio.Text = "SI";
                }
                else if (lbl_id_turno.Text == "02" & cmb_turno.Text == "VESPERTINO")
                {
                    lbl_Catalogo.Text = "001";
                    lbl_cambio.Text = "SI";
                }
                else if (lbl_id_turno.Text == "02" & cmb_turno.Text == "NOCTURNO")
                {
                    lbl_Catalogo.Text = "001";
                    lbl_cambio.Text = "SI";
                }
                Modifica_turno();
                mostrar_dgv_turno();
                cmb_turno.Text = "";
                btn_mod_turno.Enabled = false;
                txt_clave.Focus();
            }   
        }

        private void Btn_mod_sueldo_Click_1(object sender, EventArgs e)
        {
            sd1 = double.Parse(txt_SDO1_2.Text);
            sd2 = double.Parse(lbl_comprueba_sueldo.Text);

            if (sd1 < sd2)
            {
                MessageBox.Show("Debe ser un sueldo mayor", "Aviso");
                txt_SDO1_2.Focus();
            }
            else if (sd1 == sd2)
            {
                MessageBox.Show("Debe ser un sueldo diferente", "Aviso");
                txt_SDO1_2.Focus();
            }
            else
            {

                inserta_sueldo();
                mostrar_dgv_sueldo();
            }

        }

        private void Btn_mod_puesto_Click(object sender, EventArgs e)
        {
            if (cmb_puesto.Text == lbl_valida_puesto.Text)
            {
                MessageBox.Show("Es necesario seleccionar un puesto diferente", "Aviso");
                cmb_puesto.Focus();
            }
            else
            {
                Inserta_puesto();
                mostrar_dgv_puesto();
                mostrar_dgv_sueldo();
                cargar_informacion();
                cmb_puesto.Text = "";
                dtm_puesto.Text = "";
                lbl_id_puesto.Text = "";
                btn_mod_puesto.Enabled = false;
                dtm_puesto.Enabled = false;
                cmb_puesto.Focus();
            }
        }

        private void Btn_mod_departamento_Click(object sender, EventArgs e)
        {
            if (cmb_departamento.Text == lbl_Comprueba_depto.Text)
            {
                MessageBox.Show("Debe ser un departamento diferente", "Aviso");
                cmb_departamento.Focus();
            }
            else
            {
                Modifica_depto();
                mostrar_dgv_departamento();
                cmb_departamento.Text = "";
                dtm_fecha_dep.Text = "";
                lbl_Comprueba_depto.Text = "";
                btn_mod_departamento.Enabled = false;
            } 
        }
        private void Btn_mod_familiar_Click(object sender, EventArgs e)
        {
            nuevo();
        }
        private void Cmb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_clave.Text == "")
            {
                btn_mod_departamento.Enabled = false;
            }
            else
            {
                btn_mod_departamento.Enabled = true;
            }
        }
        private void Dgv_depto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_depto.Rows[e.RowIndex];
                txt_clave.Text = row.Cells["CLAVE"].Value.ToString();
                dtm_fecha_dep.Text = row.Cells["MODIFICACION"].Value.ToString();
                cmb_departamento.Text = row.Cells["DEPARTAMENTO"].Value.ToString();

                if (txt_vigencia.Text == "VIGENTE")
                {
                    btn_eliminar_depto.Enabled = true;
                }
                else if (txt_vigencia.Text == "BAJA")
                {
                    btn_eliminar_depto.Enabled = false;
                }
            }
        }
        private void Dgv_turno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_turno.Rows[e.RowIndex];
                txt_clave.Text = row.Cells["CLAVE"].Value.ToString();
                cmb_turno.Text = row.Cells["TURNO"].Value.ToString();
                dtm_fecha_turno.Text = row.Cells["CAMBIO_TURNO"].Value.ToString();
                btn_eliminar_turno.Enabled = true;
            }
        }
        private void Btn_eliminar_turno_Click(object sender, EventArgs e)
        {
            Eliminar_turno();
            mostrar_dgv_turno();
            cmb_turno.Text = "";
            dtm_fecha_turno.Text = "";
            btn_eliminar_turno.Enabled = false;
            txt_clave.Focus();
        }
        private void Cmb_escolaridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_escolaridad.Text == "PRIMARIA")
            {
                lbl_escolaridad.Text = "001";
            }
            else if (cmb_escolaridad.Text == "SECUNDARIA")
            {
                lbl_escolaridad.Text = "002";
            }
            else if (cmb_escolaridad.Text == "PREPARATORIA")
            {
                lbl_escolaridad.Text = "003";
            }
            else if (cmb_escolaridad.Text == "LICENCIATURA")
            {
                lbl_escolaridad.Text = "004";
            }
            else if (cmb_escolaridad.Text == "POSGRADO")
            {
                lbl_escolaridad.Text = "005";
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            if (txt_hijos.Text == "")
            {
                txt_hijos.Text = "0";
            }
            if (txt_telefono.Text == "")
            {
                txt_telefono.Text = "0";
            }

            if (txt_clave.Text == "")
            {
                MessageBox.Show("Es necesario seleccionar un número de empleado", "Aviso");
                txt_clave.Focus();
            }
            else
            {
                Actualizar();
                nuevo();
                mostrar_dgv_departamento();
                mostrar_dgv_turno();
                mostrar_dgv_ruta();
            }
        }
        private void Cmb_Civil_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_Civil.Text == "SOLTERO")
            {
                lbl_civil.Text = "SOL";
            }
            else if (cmb_Civil.Text == "CASADO")
            {
                lbl_civil.Text = "CAS";
            }
            else if (cmb_Civil.Text == "DIVORCIADO")
            {
                lbl_civil.Text = "DIV";
            }
            else if (cmb_Civil.Text == "VIUDO")
            {
                lbl_civil.Text = "VIU";
            }
            else if (cmb_Civil.Text == "UNION LIBRE")
            {
                lbl_civil.Text = "ULI";
            }
        }

        private void Btn_mod_ruta_Click(object sender, EventArgs e)
        {
            Modifica_ruta();
            mostrar_dgv_ruta();
            cmb_ruta.Text = "";
            btn_mod_ruta.Enabled = false;
        }

        private void Btn_eliminar_depto_Click(object sender, EventArgs e)
        {
            Elimina_depto();
            mostrar_dgv_departamento();
            dtm_fecha_dep.Text = "";
            cmb_departamento.Text = "";
            txt_clave.Focus();
            btn_eliminar_depto.Enabled = false;
        }

        private void Cmb_turno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_clave.Text == "")
            {
            }
            else
            {
                btn_mod_turno.Enabled = true;
            }
        }

        private void Cmb_turno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cmb_ruta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_clave.Text == "")
            {
            }
            else
            {
                btn_mod_ruta.Enabled = true;
            }
        }
        private void Dgv_puesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_puesto.Rows[e.RowIndex];
                txt_clave.Text = row.Cells["CLAVE"].Value.ToString();
                dtm_puesto.Text = row.Cells["FECHA"].Value.ToString();
                cmb_puesto.Text = row.Cells["PUESTO"].Value.ToString();

                if (txt_vigencia.Text == "VIGENTE")
                {
                    btn_eliminar_puesto.Enabled = true;
                }
                else if (txt_vigencia.Text == "BAJA")
                {
                    btn_eliminar_puesto.Enabled = false;
                }  
            }
        }
        private void Cmb_puesto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Btn_eliminar_puesto_Click(object sender, EventArgs e)
        {
            Elimina_puesto();
            mostrar_dgv_puesto();
            mostrar_dgv_sueldo();
            cargar_informacion();
            cmb_puesto.Text = "";
            dtm_puesto.Text = "";
            lbl_id_puesto.Text = "";
            btn_mod_puesto.Enabled = false;
            dtm_puesto.Enabled = false;
            txt_clave.Focus();
        }

        private void Cmb_cambio_sueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_cambio_sueldo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_motivo_sueldo.Text == "MODIFICACION DE SALARIO") { lbl_motivo.Text = "01"; }
           else if (cmb_motivo_sueldo.Text == "PROMOCION") { lbl_motivo.Text = "02"; }
            else if (cmb_motivo_sueldo.Text == "ANTIGUEDAD") { lbl_motivo.Text = "03"; }
            else if (cmb_motivo_sueldo.Text == "EVALUACION 3 MESES") { lbl_motivo.Text = "04"; }
            else if (cmb_motivo_sueldo.Text == "EVALUACION ANUAL") { lbl_motivo.Text = "05"; }
            dtm_sueldo.Enabled = true;
            btn_mod_sueldo.Enabled = true;
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

        private void Txt_SDO1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solo_numeros(sender, e, '.');
        }

        private void Dgv_sueldo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_sueldo.Rows[e.RowIndex];
                txt_clave.Text = row.Cells["CLAVE"].Value.ToString();
                dtm_sueldo.Text = row.Cells["FECHA"].Value.ToString();

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

        private void Dtm_sueldo_ValueChanged(object sender, EventArgs e)
        {       
        }
        private void Dtm_sueldo_Validating(object sender, CancelEventArgs e)
        {
        }
        private void Btn_eliminar_sueldo_Click(object sender, EventArgs e)
        {
            elimina_sueldo();
            mostrar_dgv_sueldo();
        }

        private void Txt_SDO1_Leave_1(object sender, EventArgs e)
        {      
        }

        private void Cmb_motivo_sueldo_Leave(object sender, EventArgs e)
        {      
        }

        private void Txt_SDO1_2_Leave(object sender, EventArgs e)
        {
            double f, sd, Re;

            f = double.Parse(txt_factor_sueldo.Text);
            sd = double.Parse(txt_SDO1_2.Text);
            Re = f * sd;
            txt_SDO3_2.Text = Re.ToString();
            txt_SDO5_2.Text = Re.ToString();
        }

        private void Cmb_parentesco_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Cmb_parentesco_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void MaskedTextBox1_TextChanged(object sender, EventArgs e)
        {       
        }
        private void Txt_curp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else{}
        }
        private void Txt_contacto_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}
