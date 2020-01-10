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
    public partial class Frm_Incapacidades : Form
    {
        
        public Frm_Incapacidades(Empleado classEmpleado)
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "Nuevo");
            tt.SetToolTip(btn_primero, "Primero [Inicio]");
            tt.SetToolTip(btn_anterior, "Anterior [Re. Pág.]");
            tt.SetToolTip(btn_siguiente, "Siguiente [Av. Pág.]");
            tt.SetToolTip(btn_ultimo, "Último [Fin]");
            tt.SetToolTip(btn_insertar, "Insertar");
            tt.SetToolTip(btn_eliminar, "Eliminar");
            tt.SetToolTip(btn_guardar, "Guardar");
            tt.SetToolTip(btn_cancelar, "Cancelar");
            tt.SetToolTip(btn_exportar, "Exportar");
            claseEmp = classEmpleado;
        }
        
        int indice = 0;
        SqlCommand cmd;
        SqlDataReader dr;
        Empleado claseEmp;
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");
 
        private void Ausentismo_retardos_Load(object sender, EventArgs e)
        {
            nuevo(); 
            autocompletar_responsable(txt_nombre);
            txt_clave.Focus();
        }

        //Métodos
        private void nuevo()
        {
            txt_clave.Text = "";
            txt_nombre.Text = "";
            dtm_fecha.Text = "";
            dtm_termina.Text = "";
            txt_certificado.Text = "";
            cmb_tipo.Text = "";
            cmb_caso.Text = "";
            txt_duracion.Text = "";
            dtm_aplicacion.Text = "";
            lbl_inc_tipo.Text = "";
            lbl_inc_caso.Text = "";
            txt_certificado.Mask = ">LL000000";
            lbl_inc_tipo.Visible = false;
            lbl_inc_caso.Visible = false;
           lbl_id.Visible = false;
            lbl_id.Text = "0";
            cmb_caso.Enabled = true;
            btn_primero.Enabled = false;
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_insertar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_exportar.Enabled = false;
            txt_nombre.Enabled = true;
            lbl_estado.Text = "";
            dtm_aplicacion.Enabled = false;
            pictureBox1.ImageLocation = "V:/Sistemas/SAAM/Logo.jpg";
            dtm_termina.Enabled = false;
            lbl_tipo_falta.Text = "";
            lbl_tipo_falta.Visible = false;
            dtm_fecha.Enabled = false;
            txt_duracion.Enabled = false;
            txt_certificado.Enabled = false;
            cmb_caso.Enabled = false;
            cmb_tipo.Enabled = false;
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
                txt_nombre.Text = dt.Rows[0]["NOMBRE_EMPLEADO"].ToString();
                lbl_estado.Text = dt.Rows[0]["VIGENCIA"].ToString();
            }
            con.Close();
        }
        private void Verifica_certificado()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SELECT NUMERO FROM [asahi16].[Supervisor_giro].[Empinc] WHERE NUMERO = @Num ";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Num", SqlDbType.VarChar).Value = txt_certificado.Text;
                da.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("El certificado ya existe, Favor de verificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_certificado.Focus();
                }
                else
                {
                    Verifica_Incapacidad();
                }
            }
            catch
            {
                MessageBox.Show("Error al consultar el Certificado.");
            }
        }//verifica existencia de certificado
        private void Verifica_Incapacidad()//Verifica si hay incapacidad
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[Incapacidades_Retardos]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "6";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_fecha.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_duracion.Text;
            da.SelectCommand.Parameters.Add("@NUMERO", SqlDbType.VarChar, 100).Value = txt_certificado.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = cmb_tipo.Text;
            da.SelectCommand.Parameters.Add("@CASO", SqlDbType.VarChar, 100).Value = cmb_caso.Text;
            da.SelectCommand.Parameters.Add("@FECHA_TERMINO", SqlDbType.VarChar, 100).Value = dtm_termina.Text;
            da.SelectCommand.Parameters.Add("@FECHA_APLICACION", SqlDbType.VarChar, 100).Value = dtm_aplicacion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
            da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value = lbl_id.Text;

            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("El empleado tiene incapacidad en esta Fecha, Favor de Verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_fecha.Focus();
            }
            else
            {
                Verifica_vacaciones();
            }
        }
        private void Verifica_vacaciones()//Verifica si hay vacaciones
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[Incapacidades_Retardos]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "7";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_fecha.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_duracion.Text;
            da.SelectCommand.Parameters.Add("@NUMERO", SqlDbType.VarChar, 100).Value = txt_certificado.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = cmb_tipo.Text;
            da.SelectCommand.Parameters.Add("@CASO", SqlDbType.VarChar, 100).Value = cmb_caso.Text;
            da.SelectCommand.Parameters.Add("@FECHA_TERMINO", SqlDbType.VarChar, 100).Value = dtm_termina.Text;
            da.SelectCommand.Parameters.Add("@FECHA_APLICACION", SqlDbType.VarChar, 100).Value = dtm_aplicacion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
            da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value = lbl_id.Text;
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                DialogResult resul = MessageBox.Show("El empleado tiene Vacaciones en esta Fecha, ¿Desea eliminar las Vacaciones?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    Borra_Vacaciones();
                    Verifica_Falta();
                }
                if (resul == DialogResult.No)
                {
                    dtm_fecha.Focus();
                }
            }
            else
            {
                Verifica_Falta();
            }
        }
        private void Verifica_Falta()//Verifica si hay una falta
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[Incapacidades_Retardos]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "5";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_fecha.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_duracion.Text;
            da.SelectCommand.Parameters.Add("@NUMERO", SqlDbType.VarChar, 100).Value = txt_certificado.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = cmb_tipo.Text;
            da.SelectCommand.Parameters.Add("@CASO", SqlDbType.VarChar, 100).Value = cmb_caso.Text;
            da.SelectCommand.Parameters.Add("@FECHA_TERMINO", SqlDbType.VarChar, 100).Value = dtm_termina.Text;
            da.SelectCommand.Parameters.Add("@FECHA_APLICACION", SqlDbType.VarChar, 100).Value = dtm_aplicacion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
            da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value = lbl_id.Text;
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                lbl_tipo_falta.Text = dt.Rows[0]["TIPO"].ToString();

                if (lbl_tipo_falta.Text == "N")
                {
                    DialogResult resul = MessageBox.Show("El empleado tiene Suspensión dentro de esta fecha, ¿Desea eliminar la suspensión? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resul == DialogResult.Yes)
                    {
                        Borra_falta();
                        Inserta_incapacidades();
                        Mostrar_Grid();
                        dtm_fecha.Text = "";
                        txt_duracion.Text = "";
                        dtm_termina.Text = "";
                        txt_certificado.Text = "";
                        cmb_caso.Text = "";
                        cmb_tipo.Text = "";
                        lbl_id.Text = "0";
                        dtm_fecha.Focus();
                    }
                    else if (resul == DialogResult.No)
                    {
                        dtm_fecha.Focus();
                    }
                }
                else if (lbl_tipo_falta.Text == "P")
                {
                    DialogResult resul = MessageBox.Show("El empleado tiene Permiso sin Goce dentro de esta fecha, ¿Desea eliminar el permiso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resul == DialogResult.Yes)
                    {
                        Borra_falta();
                        Inserta_incapacidades();
                        Mostrar_Grid();
                        dtm_fecha.Text = "";
                        txt_duracion.Text = "";
                        dtm_termina.Text = "";
                        txt_certificado.Text = "";
                        cmb_caso.Text = "";
                        cmb_tipo.Text = "";
                        lbl_id.Text = "0";
                        dtm_fecha.Focus();
                    }
                    else if (resul == DialogResult.No)
                    {
                        dtm_fecha.Focus();
                    }
                }
                else if (lbl_tipo_falta.Text == "G")
                {
                    DialogResult resul = MessageBox.Show("El empleado tiene Permiso con Goce dentro de esta fecha, ¿Desea eliminar el permiso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resul == DialogResult.Yes)
                    {
                        Borra_falta();
                        Inserta_incapacidades();
                        Mostrar_Grid();
                        dtm_fecha.Text = "";
                        txt_duracion.Text = "";
                        dtm_termina.Text = "";
                        txt_certificado.Text = "";
                        cmb_caso.Text = "";
                        cmb_tipo.Text = "";
                        lbl_id.Text = "0";
                        dtm_fecha.Focus();
                    }
                    else if (resul == DialogResult.No)
                    {
                        dtm_fecha.Focus();
                    }
                }
                else if (lbl_tipo_falta.Text == "U")
                {
                    DialogResult resul = MessageBox.Show("El empleado tiene Falta Justificada dentro de esta fecha, ¿Desea eliminar la falta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resul == DialogResult.Yes)
                    {
                        Borra_falta();
                        Inserta_incapacidades();
                        Mostrar_Grid();
                        dtm_fecha.Text = "";
                        txt_duracion.Text = "";
                        dtm_termina.Text = "";
                        txt_certificado.Text = "";
                        cmb_caso.Text = "";
                        cmb_tipo.Text = "";
                        lbl_id.Text = "0";
                        dtm_fecha.Focus();
                    }
                    else if (resul == DialogResult.No)
                    {
                        dtm_fecha.Focus();
                    }
                }
                else if (lbl_tipo_falta.Text == "F")
                {
                    DialogResult resul = MessageBox.Show("El empleado tiene Falta Injustificada dentro de esta fecha, ¿Desea eliminar esta falta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resul == DialogResult.Yes)
                    {
                        Borra_falta();
                        Inserta_incapacidades();
                        Mostrar_Grid();
                        dtm_fecha.Text = "";
                        txt_duracion.Text = "";
                        dtm_termina.Text = "";
                        txt_certificado.Text = "";
                        cmb_caso.Text = "";
                        cmb_tipo.Text = "";
                        lbl_id.Text = "0";
                        dtm_fecha.Focus();
                    }
                    else if (resul == DialogResult.No)
                    {
                        dtm_fecha.Focus();
                    }
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void Inserta_incapacidades()//Inserta incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "2");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Borra_Vacaciones()//Borra vacaciones
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "8");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                MessageBox.Show("Vacaciones eliminadas con éxito", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar vacaciones.");
            }
        }
        private void Borra_falta()//Borrar falta dentro de un rango de fechas
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "9");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                MessageBox.Show("Incidencia eliminada con éxito", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar incidencia");
            }
        }
        private void Diseño_Grid(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//Clave
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 80;//Inicio
            dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].Width = 80;//Termino
            dgv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[4].Width = 70;
            dgv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[5].Width = 40;//id
            dgv.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[6].Width = 145;//tipo
            dgv.Columns[7].Width = 100;//caso
            dgv.Columns[8].Width = 84;//aplicacion
            dgv.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Mostrar_Grid()//Mostrar grid de incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION",dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_incapacidades.DataSource = dt;
              Diseño_Grid(dgv_incapacidades);
                dgv_incapacidades.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dgv_incapacidades.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Elimina_incapacidades()//Elimina incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "3");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Modifica_incapacidades()//Modifica incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "4");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Exportara_Exel()// Método para exportar a excel, múdulo incapacidades.
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Libro1";
                int cellRowIndex = 2;//ok
                int cellColumnIndex = 1;//ok
                //Pasa por cada fila y lee el valor de cada columna.
                for (int i = -1; i < dgv_incapacidades.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_incapacidades.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_incapacidades.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_incapacidades.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;//ok
                    cellRowIndex++;
                }
                excel.Visible = true;
            }
            catch (Exception error)
            {
                //MessageBox.Show("No se exportó correctamente" + error.Message);
            }
        }
        public void autocompletar_responsable(TextBox cajaTexto)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(RTRIM(NOMBREN)+ ' '+ RTRIM(NOMBREP)+ ' ' + RTRIM(NOMBREM)) as 'NOMBRE' FROM [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] WHERE VIGENCIA = 'VIGENTE'  AND NOMBREN  LIKE '%' + " + txt_nombre.Text + " + '%'  order by NOMBRE ASC", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(dr["NOMBRE"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudo autcompletar nombre " + error.ToString());
            }
        }
        private void cargar_clave()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SELECT Convert(Int,RTRIM(CLAVE)) AS 'CLAVE', VIGENCIA FROM [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] WHERE RTRIM(RTRIM(NOMBREN)+ ' '+ RTRIM(NOMBREP)+ ' ' + RTRIM(NOMBREM)) = @Nombre";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txt_nombre.Text;
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    txt_clave.Text = dt.Rows[0]["CLAVE"].ToString();
                    lbl_estado.Text = dt.Rows[0]["VIGENCIA"].ToString();
                }
            }
            catch
            {
            }
        }
        
        //Botones
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            Mostrar_Grid();
        }
        private void Btn_inc_cancelar_Click(object sender, EventArgs e)//Cancela incapacidades
        {
            dtm_fecha.Text = "";
            dtm_termina.Text = "";
            txt_duracion.Text = "";
            dtm_aplicacion.Text = "";
            txt_certificado.Text = "";
            cmb_tipo.Text = "";
            cmb_caso.Text = "";
            lbl_inc_caso.Text = "";
            lbl_inc_tipo.Text = "";
            btn_eliminar.Enabled = false;
            lbl_id.Text = "0";
            dtm_fecha.Focus();
        }
        private void Btn_inc_exportar_Click(object sender, EventArgs e)//Botón exportar excel, módulo de incapacidades
        {
            Exportara_Exel();
            dtm_fecha.Focus();
        }
        private void Btn_inc_anterior_Click(object sender, EventArgs e)
        {
            int Anterior = indice - 1;

            try
            {
                dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[Anterior].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
                btn_siguiente.Enabled = true;
                btn_ultimo.Enabled = true;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                dtm_fecha.Focus();
            }
            catch
            {
                btn_anterior.Enabled = false;
                btn_primero.Enabled = false;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                dtm_fecha.Focus();
            }
        }
        private void Btn_inc_primero_Click(object sender, EventArgs e)
        {
            dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[0].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
            btn_anterior.Enabled = false;
            btn_primero.Enabled = false;
            btn_siguiente.Enabled = true;
            btn_ultimo.Enabled = true;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
            dtm_fecha.Focus();
        }
        private void Btn_inc_siguiente_Click(object sender, EventArgs e)
        {
            int Siguiente = indice + 1;
            try
            {
                dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[Siguiente].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
                btn_anterior.Enabled = true;
                btn_primero.Enabled = true;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                dtm_fecha.Focus();
            }
            catch
            {
                btn_siguiente.Enabled = false;
                btn_ultimo.Enabled = false;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                MessageBox.Show("Llegó al final!", "Aviso");
                dtm_fecha.Focus();
            }
        }
        private void Btn_inc_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[50].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
                btn_siguiente.Enabled = false;
                btn_ultimo.Enabled = false;
                btn_anterior.Enabled = true;
                btn_primero.Enabled = true;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                dtm_fecha.Focus();
            }
            catch
            {
            }
        }
        private void Btn_inc_insertar_Click(object sender, EventArgs e)
        {
            dtm_fecha.Text = "";
            dtm_termina.Text = "";
            dtm_aplicacion.Text = "";
            txt_duracion.Text = "";
            cmb_caso.Text = "";
            cmb_tipo.Text = "";
            txt_certificado.Text = "";
            btn_eliminar.Enabled = false;
            lbl_id.Text = "0";
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
            lbl_tipo_falta.Visible = false;
            dtm_fecha.Enabled = true;
            txt_duracion.Enabled = true;
            txt_certificado.Enabled = true;
            cmb_caso.Enabled = true;
            cmb_tipo.Enabled = true;
            dtm_fecha.Focus();
        }//Botón Para crear una nueva incapacidad
        private void Btn_inc_guardar_Click(object sender, EventArgs e)//botón Inserta o modifica incapacidades
        {  
                if (txt_duracion.Text == "")
                {
                    MessageBox.Show("Es necesario capturar la cantidad de días.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_duracion.Focus();
                }
                else if (txt_certificado.Text == "")
                {
                    MessageBox.Show("Es necesario capturar el Certificado de Incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_certificado.Focus();
                }
                else if (cmb_tipo.Text == "")
                {
                    MessageBox.Show("Es necesario capturar el tipo de incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_tipo.Focus();
                }
                else if (cmb_caso.Text == "")
                {
                    MessageBox.Show("Es necesario capturar el caso de incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_caso.Focus();
                }
            else
            {
                if (lbl_id.Text == "0")
                {
                    Verifica_certificado();
                }
                else
                {
                    Modifica_incapacidades();
                }
            }
        }
        private void Btn_inc_eliminar_Click(object sender, EventArgs e)//Botón elimina incapacidades
        {
            Elimina_incapacidades();
            Mostrar_Grid();
            dtm_fecha.Text = "";
            dtm_termina.Text = "";
            txt_duracion.Text = "";
            dtm_aplicacion.Text = "";
            txt_certificado.Text = "";
            cmb_tipo.Text = "";
            cmb_caso.Text = "";
            lbl_inc_caso.Text = "";
            lbl_inc_tipo.Text = "";
            btn_eliminar.Enabled = false;
            lbl_id.Text = "0";
            dtm_fecha.Focus();
        }
        //Eventos
        private void Dtm_inc_termina_ValueChanged(object sender, EventArgs e)
        { 
        }
        private void Cmb_inc_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {    
        }
        private void Txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            else { e.Handled = true; }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cargar_informacion();
                Mostrar_Grid();
                txt_nombre.Enabled = false;
                btn_exportar.Enabled = true;
                btn_siguiente.Enabled = true;
                btn_ultimo.Enabled = true;
                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                dtm_fecha.Focus();
            }
        }
        private void Cmb_inc_caso_SelectedIndexChanged(object sender, EventArgs e)
        {   
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Dtm_inc_inicia_ValueChanged(object sender, EventArgs e)
        {
             dtm_aplicacion.Text = dtm_fecha.Text ;
        }
        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar))
            { e.Handled = false; }
            else { e.Handled = true; }
        }
        private void Txt_nombre_Leave(object sender, EventArgs e)
        {
            cargar_clave();
            Mostrar_Grid();
            btn_exportar.Enabled = true;
            btn_siguiente.Enabled = true;
            btn_ultimo.Enabled = true;
            pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
            txt_nombre.Enabled = false;
            dtm_fecha.Focus();
        }
        private void Lbl_estado_TextChanged(object sender, EventArgs e)
        {
            if (lbl_estado.Text == "VIGENTE")
            {
                lbl_estado.ForeColor = Color.Black;
                btn_insertar.Enabled = true;
            }
            else
            {
                lbl_estado.ForeColor = Color.Red;
                btn_insertar.Enabled = false;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
            }
        }
        private void Dgv_incapacidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_incapacidades.Rows[e.RowIndex];
                dtm_fecha.Text = row.Cells["INICIO"].Value.ToString();
                dtm_termina.Text = row.Cells["TERMINO"].Value.ToString();
                txt_duracion.Text = row.Cells["DURACION"].Value.ToString();
                txt_certificado.Text = row.Cells["CERTIFICADO"].Value.ToString();
                cmb_caso.Text = row.Cells["CASO"].Value.ToString();
                cmb_tipo.Text = row.Cells["TIPO"].Value.ToString();
                lbl_id.Text = row.Cells["ID"].Value.ToString();
                dtm_fecha.Focus();
            }
        }
        private void Dgv_incapacidades_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_incapacidades.Rows[e.RowIndex];
                dtm_fecha.Text = row.Cells["INICIO"].Value.ToString();
                dtm_termina.Text = row.Cells["TERMINO"].Value.ToString();
                txt_duracion.Text = row.Cells["DURACION"].Value.ToString();
                txt_certificado.Text = row.Cells["CERTIFICADO"].Value.ToString();
                cmb_caso.Text = row.Cells["CASO"].Value.ToString();
                cmb_tipo.Text = row.Cells["TIPO"].Value.ToString();
                lbl_id.Text = row.Cells["ID"].Value.ToString();
            }
        }
        private void Dgv_incapacidades_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_incapacidades.CurrentCell != null)   {   indice = dgv_incapacidades.CurrentRow.Index;}
        }
        private void Dgv_incapacidades_DoubleClick(object sender, EventArgs e)
        {
            if (lbl_estado.Text == "VIGENTE")
            {
                DialogResult resul = MessageBox.Show("¿Desea modificar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    btn_guardar.Enabled = true;
                    btn_eliminar.Enabled = true;
                    btn_cancelar.Enabled = true;
                    dtm_fecha.Focus();
                }
                if (resul == DialogResult.No)
                {
                    btn_guardar.Enabled = false;
                    btn_eliminar.Enabled = false;
                    btn_cancelar.Enabled = false;
                    dtm_fecha.Focus();
                }
            }
            else
            {
            }
        }
        private void Txt_inc_duracion_KeyPress(object sender, KeyPressEventArgs e)
        {  
           if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        private void Txt_inc_duracion_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime Inicia = dtm_fecha.Value.Date;
                int dias = Int32.Parse(txt_duracion.Text);
                DateTime Final = Inicia.AddDays(dias - 1);
                dtm_termina.Text = Final.ToString();
            }
            catch
            {
            }   
        }
        private void Txt_inc_duracion_TextChanged(object sender, EventArgs e)
        {
         
        }
        private void Cmb_inc_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_inc_caso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_inc_tipo_TextChanged(object sender, EventArgs e)
        {
            if (cmb_tipo.Text == "Enfermermedad General")
            {
                lbl_inc_tipo.Text = "EG";
                cmb_caso.Enabled = true;
            }
            else if (cmb_tipo.Text == "Accidente de Trabajo")
            {
                lbl_inc_tipo.Text = "RT";
                cmb_caso.Enabled = false;
                cmb_caso.Text = "Ninguna";
            }
            else if (cmb_tipo.Text == "Accidente de Trayecto")
            {
                lbl_inc_tipo.Text = "AT";
                cmb_caso.Enabled = false;
                cmb_caso.Text = "Ninguna";
            }
            else if (cmb_tipo.Text == "Enfermedad Profesional")
            {
                lbl_inc_tipo.Text = "EP";
                cmb_caso.Enabled = true;
            }
            else if (cmb_tipo.Text == "Pre Maternidad")
            {
                lbl_inc_tipo.Text = "PM";
                cmb_caso.Enabled = true;
            }
            else if (cmb_tipo.Text == "Maternidad Enlace")
            {
                lbl_inc_tipo.Text = "ME";
                cmb_caso.Enabled = true;
            }
            else if (cmb_tipo.Text == "Post Maternidad")
            {
                lbl_inc_tipo.Text = "OM";
                cmb_caso.Enabled = true;
            }
        }
        private void Cmb_inc_caso_TextChanged(object sender, EventArgs e)
        {
            if (cmb_caso.Text == "Unica") { lbl_inc_caso.Text = "U"; }
            else if (cmb_caso.Text == "Inicial") { lbl_inc_caso.Text = "I"; }
            else if (cmb_caso.Text == "Subsecuente") { lbl_inc_caso.Text = "S"; }
            else if (cmb_caso.Text == "Alta Médica ST2") { lbl_inc_caso.Text = "2"; }
            else if (cmb_caso.Text == "Ninguna") { lbl_inc_caso.Text = "N"; }
            else { lbl_inc_caso.Text = ""; }
        }
        private void Txt_inc_certificado_Leave(object sender, EventArgs e)
        {
        }
    }  
}
