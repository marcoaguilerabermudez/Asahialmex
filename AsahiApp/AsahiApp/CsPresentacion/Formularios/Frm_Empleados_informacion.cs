using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace CsPresentacion
{
    public partial class Frm_Empleados_Detalle : Form
    {
        public Frm_Empleados_Detalle()
        {
            InitializeComponent();
            timer1.Enabled = true;
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "NUEVA BUSQUEDA");
            tt.SetToolTip(btn_agregar, "AGREGAR");
            tt.SetToolTip(btn_guardar, "GUARDAR");
            tt.SetToolTip(btn_exportar, "EXPORTAR");
       
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
                txt_direccion.Text = dt.Rows[0]["DIRECCION"].ToString();
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
                txt_curp.Text = dt.Rows[0]["CURP"].ToString();
                txt_sueldo.Text = dt.Rows[0]["SUELDO"].ToString();
                txt_motivo.Text = dt.Rows[0]["MOTIVO"].ToString();
                txt_dias.Text = dt.Rows[0]["DIAS"].ToString();
                txt_meses.Text = dt.Rows[0]["MESES"].ToString();
                txt_años.Text = dt.Rows[0]["AÑOS"].ToString();
                btn_guardar.Enabled = true;
                txt_clave.Enabled = false;
            }
            con.Close();
        }
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
        private void insertar()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [asahi16].[dbo].[Consulta_informacion_empleado](CLAVE, NOMBRE, DIRECCION, MUNICIPIO, ESTADO, TELEFONO, DEPARTAMENTO , PUESTO, RFC, AFILIACION, CURP, ALTA, BAJA, REINGRESO, BAJA_2, REINGRESO_2, BAJA_3, SUELDO, E_CIVIL , GENERO,  VIGENCIA, MOTIVO , DIAS, MESES, AÑOS, FECHA) VALUES (" + txt_clave.Text + ", '" + txt_nombre.Text + "', '" + txt_direccion.Text + "', '" + txt_municipio.Text + "', '" + cmb_estado.Text + "', '" + txt_telefono.Text + "', '" + txt_departamento.Text + "' , '" + txt_puesto.Text + "', '" + txt_rfc.Text + "',  '" + txt_afiliacion.Text + "', '" + txt_curp.Text + "'  , '" + txt_alta.Text + "',  '" + txt_baja.Text + "', '" + txt_reingreso.Text + "' , '" + txt_baja_2.Text + "', '" + txt_reingreso_2.Text + "', '" + txt_baja_3.Text + "', " + txt_sueldo.Text + " , '" + cmb_Civil.Text + "' , '" + cmb_genero.Text + "',   '" + txt_vigencia.Text + "', '" + txt_motivo.Text + "' , " + txt_dias.Text + ",  " + txt_meses.Text + ", " + txt_años.Text + " , '" + l_fecha.Text + "' )", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Se agregó correctamento");
            }
            catch (Exception error)
            {
                MessageBox.Show("No se insertó. " + error.ToString());
            }
        }
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

        private void Actualizar()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE  [asahi16].[Supervisor_giro].[Emprh] set ESTADO='"+ cmb_estado.Text + "',  MUNICIPIO = '"+txt_municipio.Text+ "', TELEFONO_CELULAR = '"+txt_telefono.Text + "', ESTADO_CIVIL = '"+ cmb_Civil.Text+ "', SEXO = '"+ cmb_genero.Text+"'  WHERE CLAVE = " + txt_clave.Text+"", con);             
                cmd.Parameters.AddWithValue("@Clave", txt_clave.Text);
                cmd.ExecuteNonQuery();
                con.Close();
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
                SqlCommand cmd = new SqlCommand("UPDATE  [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] set RFC='" + txt_rfc.Text + "',  AFILIACION = '" + txt_afiliacion.Text + "', CURP = '" + txt_curp.Text + "' WHERE CLAVE = " + txt_clave.Text + "", con);
                cmd.Parameters.AddWithValue("@Clave", txt_clave.Text);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se actualizó " + error.ToString());
            }
        }



        private void nuevo()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            txt_clave.Text = "";
            txt_clave.Focus();
            txt_baja.Text = "";
            txt_reingreso.Text = "";
            txt_baja_2.Text = "";
            txt_reingreso_2.Text = "";
            txt_baja_3.Text = "";
            txt_clave.Focus();
            pictureBox1.ImageLocation = "V:/Sistemas/Listado de bajas/LogoFinal" + ".png";
            txt_vigencia.Visible = false;
            lbl_estado.Visible = false;
            dgv_empleado.Visible = false;
            lbl_motivo.Visible = false;
            lbl_dias.Visible = false;
            lbl_años.Visible = false;
            txt_motivo.Visible = false;
            txt_años.Visible = false;
            txt_meses.Visible = false;
            txt_años.Visible = false;
            lbl_meses.Visible = false;
            txt_dias.Visible = false;
            btn_agregar.Enabled = false;
            btn_exportar.Enabled = false;
            btn_guardar.Enabled = false;
            txt_vigencia.Enabled = false;
            txt_nombre.Enabled = false;
            txt_puesto.Enabled = false;
            txt_departamento.Enabled = false;
            txt_alta.Enabled = false;
            txt_baja.Enabled = false;
            txt_reingreso.Enabled = false;
            txt_baja_2.Enabled = false;
            txt_reingreso_2.Enabled = false;
            txt_baja_3.Enabled = false;
            txt_dias.Enabled = false;
            txt_años.Enabled = false;
            txt_meses.Enabled = false;
            txt_sueldo.Enabled = false;
            txt_motivo.Enabled = false;
            cmb_genero.Text = "";
            cmb_Civil.Text = "";
            txt_clave.Enabled = true;
            cmb_estado.Text = "";
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            
        }
        private void Frm_Empleados_Detalle_Load(object sender, EventArgs e)
        {
            nuevo();
            l_fecha.Visible = false;
            l_hora.Visible =  false;
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo(); 
        }
        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            insertar();
            nuevo();
            mostrar_dgv();
            btn_exportar.Enabled = true;
        }
        private void Btn_exportar_Click(object sender, EventArgs e)
        {
            Exportara_Exel();
            eliminar();
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
            Actualizar();
            Actualizar2();
            nuevo();
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
                txt_vigencia.Visible = true;
                lbl_estado.Visible = true;
                btn_agregar.Enabled = true;

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
    }
}
