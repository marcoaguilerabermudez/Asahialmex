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
            timer1.Enabled = true;
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "NUEVA BUSQUEDA");
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");
        double Sueldo;
        double Factor;
        double Resultado;
        double Val1;
        double Val2;


        private void mostrar_dgv()// Método para llenar DatagridView
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT *  FROM [asahi16].[dbo].[Consulta_informacion_empleado] where FECHA = @FECHA", con);
                // cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FECHA", l_fecha.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Close();
                adapter.Fill(dt);
                dgv_empleado.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //private void insertar()
        //{
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("INSERT INTO [asahi16].[dbo].[Consulta_informacion_empleado](CLAVE, NOMBRE, DIRECCION, MUNICIPIO, ESTADO, TELEFONO, DEPARTAMENTO , PUESTO, RFC, AFILIACION, CURP, ALTA, BAJA, REINGRESO, BAJA_2, REINGRESO_2, BAJA_3, SUELDO, E_CIVIL , GENERO,  VIGENCIA, MOTIVO , DIAS, MESES, AÑOS, FECHA) VALUES (" + txt_clave.Text + ", '" + txt_nombre.Text + "', '" + txt_calle.Text + "', '" + txt_municipio.Text + "', '" + cmb_estado.Text + "', '" + txt_telefono.Text + "', '" + txt_departamento.Text + "' , '" + txt_puesto.Text + "', '" + txt_rfc.Text + "',  '" + txt_afiliacion.Text + "', '" + txt_curp.Text + "'  , '" + txt_alta.Text + "',  '" + txt_baja.Text + "', '" + txt_reingreso.Text + "' , '" + txt_baja_2.Text + "', '" + txt_reingreso_2.Text + "', '" + txt_baja_3.Text + "', " + txt_sueldo.Text + " , '" + cmb_Civil.Text + "' , '" + cmb_genero.Text + "',   '" + txt_vigencia.Text + "', '" + txt_motivo.Text + "' , " + txt_dias.Text + ",  " + txt_meses.Text + ", " + txt_años.Text + " , '" + l_fecha.Text + "' )", con);
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        MessageBox.Show("Se agregó correctamento");
        //        nuevo();
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show("No se insertó. " + error.ToString());
        //    }
        //}
        private void Exportara_Exel()// Método para exportar a excel.
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Libro1";
                int cellRowIndex = 1;
                int cellColumnIndex = 1;
                //Pasa por cada fila y lee el valor de cada columna.
                for (int i = 0; i < dgv_empleado.Rows.Count - 0; i++)
                {
                    for (int j = 0; j < dgv_empleado.Columns.Count - 0; j++)
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 0)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_empleado.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_empleado.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                //Obtener la ubicación y el nombre de archivo de excel para guardar del usuario.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Libro de Excel (*.xlsx)|*.xlsx";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Su documento se exportó correctamente.");
                }
            }
            catch (Exception error)
            {
                //MessageBox.Show("No se exportó correctamente" + error.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
        private void eliminar()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TRUNCATE TABLE [asahi16].[dbo].[Consulta_informacion_empleado] ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se eliminó " + error.ToString());
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
                cmb_puesto.Text = dt.Rows[0]["PUESTO"].ToString();
                txt_calle.Text = dt.Rows[0]["CALLE"].ToString();
                txt_numero.Text = dt.Rows[0]["NUMERO"].ToString();
                txt_colonia.Text = dt.Rows[0]["COLONIA"].ToString();
                txt_interior.Text = dt.Rows[0]["INTERIOR"].ToString();
                txt_cp.Text = dt.Rows[0]["CP"].ToString();
                txt_municipio.Text = dt.Rows[0]["MUNICIPIO"].ToString();
                cmb_estado.Text = dt.Rows[0]["ESTADO"].ToString();
                txt_sector.Text = dt.Rows[0]["SECTOR"].ToString();
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
                txt_SDO1.Text = dt.Rows[0]["SUELDO"].ToString();
                txt_compara2.Text = dt.Rows[0]["SUELDO"].ToString();
                txt_compara1.Text = dt.Rows[0]["SUELDO"].ToString();
                txt_SDO2.Text = dt.Rows[0]["SD2"].ToString();
                txt_SDO3.Text = dt.Rows[0]["SD3"].ToString();
                txt_SDO4.Text = dt.Rows[0]["SD4"].ToString();
                txt_SDO5.Text = dt.Rows[0]["SD5"].ToString();
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
                SqlCommand cmd = new SqlCommand("UPDATE  [asahi16].[Supervisor_giro].[Emprh] set ESTADO='"+ cmb_estado.Text + "', CALLE = '"+ txt_calle.Text+"',  NUMERO = "+ txt_numero.Text+", COLONIA = '"+txt_colonia.Text+"',  CP = " +txt_cp.Text +",  MUNICIPIO = '"+txt_municipio.Text+ "', FECHA_NACIMIENTO = '"+ dtm_nacimiento.Text +"',  TELEFONO_CELULAR = '" + txt_telefono.Text + "', ESTADO_CIVIL = '"+ cmb_Civil.Text+ "', SEXO = '"+ cmb_genero.Text+"'  WHERE CLAVE = " + txt_clave.Text+"", con);             
                cmd.Parameters.AddWithValue("@Clave", txt_clave.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("La información se actualizó correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("No se actualizó " + error.ToString());
            }
        }
        private void Actualizar2()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] set RFC='" + txt_rfc.Text + "',  AFILIACION = '" + txt_nss.Text + "', CURP = '" + txt_curp.Text + "' WHERE CLAVE = " + txt_clave.Text + "", con);
                cmd.Parameters.AddWithValue("@Clave", txt_clave.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se actualizó " + error.ToString());
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
            txt_nacionalidad.Text = "";
            txt_SDO1.Text = "";
            txt_SDO2.Text = "";
            txt_SDO3.Text = "";
            txt_SDO4.Text = "";
            txt_SDO5.Text = "";
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
            txt_factor.Visible = false;
            lbl_factor.Visible = false; 
            cmb_estado_nacimiento.Enabled = true;
            txt_clave.Text = "";
            dgv_empleado.Visible = false;
            pictureBox1.ImageLocation = "V:/Sistemas/SAAM/LogoFinal" + ".png";
            txt_baja.Text = "";
            txt_vigencia.Text = "";
            txt_motivo.Text = "";
            txt_dias.Text = "";
            txt_meses.Text = "";
            txt_años.Text = "";
            txt_vigencia.Visible = false;
            lbl_estado.Visible = false;
            txt_reingreso.Text = "";
            txt_baja_2.Text = "";
            txt_reingreso_2.Text = "";
            txt_baja_3.Text = "";
            txt_compara1.Text = "0.00";
            txt_compara2.Text = "0.00";
            txt_compara1.Visible = false;
            txt_compara2.Visible = false;
            groupBox2.Enabled = false;
            btn_mod_puesto.Enabled = false;
            cmb_puesto.Enabled = false;
            groupBox1.Visible = false;
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {      
        }
        private void Frm_Empleados_Detalle_Load(object sender, EventArgs e)
        {
            nuevo();
            l_fecha.Visible = false;
            l_hora.Visible =  false;
            cargar_departemento(cmb_departamento);
            cargar_puesto(cmb_puesto);
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
                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                lbl_estado.Visible = true;
                if (txt_vigencia.Text == "VIGENTE")
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
                    txt_vigencia.BackColor = Color.Green;
                    btn_mod_puesto.Enabled = true;
                    cmb_puesto.Enabled = true;
                }
                else if (txt_vigencia.Text == "BAJA")
                {
                   txt_vigencia.Visible = true;
                    lbl_estado.Visible = true;
                    dgv_empleado.Visible = false;
                    lbl_motivo.Visible = true;
                    lbl_dias.Visible = true;
                    lbl_años.Visible = true;
                    txt_motivo.Visible = true;
                    txt_años.Visible = true;
                    txt_meses.Visible = true;
                    txt_años.Visible = true;
                    lbl_meses.Visible = true;
                    txt_dias.Visible = true;
                    txt_vigencia.BackColor = Color.Red;
                    groupBox1.Visible = true;
                    lbl_baja.Visible = true;
                    lbl_reingreso.Visible = true;
                  
                    
                }
                else
                {
                    lbl_estado.Visible = false;
                    groupBox1.Visible = false;
                   pictureBox1.ImageLocation = "V:/Sistemas/SAAM/LogoFinal" + ".png";
                }

                if (string.IsNullOrEmpty(txt_dias.Text))
                {
                    txt_dias.Text = "0";
                }
                if (string.IsNullOrEmpty(txt_meses.Text))
                {
                    txt_meses.Text = "0";
                }
                if (string.IsNullOrEmpty(txt_años.Text))
                {
                    txt_años.Text = "0";
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
            nuevo();
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
        private void Cmb_infonavit_KeyPress(object sender, KeyPressEventArgs e)
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
            //insertar();
            mostrar_dgv();

            Exportara_Exel();
            eliminar();
            nuevo();
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
            cmb_puesto.Enabled = false;
        }

        private void Btn_mod_turno_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void Btn_mod_sueldo_Click_1(object sender, EventArgs e)
        {
            nuevo();
        }

        private void Btn_mod_puesto_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void Btn_mod_departamento_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void Btn_mod_familiar_Click(object sender, EventArgs e)
        {
            nuevo();
        }
    }
}
