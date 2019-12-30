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
            tt.SetToolTip(btn_inc_primero, "Primero [Inicio]");
            tt.SetToolTip(btn_inc_anterior, "Anterior [Re. Pág.]");
            tt.SetToolTip(btn_inc_siguiente, "Siguiente [Av. Pág.]");
            tt.SetToolTip(btn_inc_ultimo, "Último [Fin]");
            tt.SetToolTip(btn_inc_insertar, "Insertar");
            tt.SetToolTip(btn_inc_eliminar, "Eliminar");
            tt.SetToolTip(btn_inc_guardar, "Guardar");
            tt.SetToolTip(btn_inc_cancelar, "Cancelar");
            tt.SetToolTip(btn_inc_exportar, "Exportar");
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
        private void nuevo()
        {
            txt_clave.Text = "";
            txt_nombre.Text = "";
            dtm_inc_fecha.Text = "";
            dtm_inc_termina.Text = "";
            txt_inc_certificado.Text = "";
            cmb_inc_tipo.Text = "";
            cmb_inc_caso.Text = "";
            txt_inc_duracion.Text = "";
            dtm_inc_aplicacion.Text = "";  
            lbl_inc_tipo.Text = "";
            lbl_inc_caso.Text = "";
            txt_inc_certificado.Mask = ">LL000000";
            lbl_inc_tipo.Visible = false;
            lbl_inc_caso.Visible = false;
            lbl_id.Visible = false;
            lbl_id.Text = "0";
            cmb_inc_caso.Enabled = true;
            btn_inc_primero.Enabled = false;
            btn_inc_anterior.Enabled = false;
            btn_inc_siguiente.Enabled = false;
            btn_inc_ultimo.Enabled = false;
            btn_inc_insertar.Enabled = false;
            btn_inc_eliminar.Enabled = false;
            btn_inc_guardar.Enabled = false;
            btn_inc_cancelar.Enabled = false;
            btn_inc_exportar.Enabled = false;
            txt_nombre.Enabled = true;
            lbl_estado.Text = "";
            dtm_inc_aplicacion.Enabled = false;
            pictureBox1.ImageLocation = "V:/Sistemas/SAAM/Logo.jpg";
            dtm_inc_termina.Enabled = false;
            txt_clave.Focus();
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
                cmd.Parameters.AddWithValue("@FECHA", dtm_inc_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_inc_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_inc_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_inc_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION",dtm_inc_aplicacion.Text);
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
        private void Inserta_incapacidades()//Inserta incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "2");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_inc_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_inc_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_inc_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_inc_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_inc_aplicacion.Text);
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
        private void Elimina_incapacidades()//Elimina incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "3");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_inc_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_inc_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_inc_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_inc_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_inc_aplicacion.Text);
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
                cmd.Parameters.AddWithValue("@FECHA", dtm_inc_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_inc_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_inc_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_inc_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_inc_aplicacion.Text);
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
            dgv.Columns[8].Width = 98;//aplicacion
            dgv.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void verifica_certificado()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SELECT NUMERO FROM [asahi16].[Supervisor_giro].[Empinc] WHERE NUMERO = @Num ";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Num", SqlDbType.VarChar).Value = txt_inc_certificado.Text;

                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("El certificado ya existe, favor de verificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_inc_certificado.Focus();
                }
                else
                {
                    Inserta_incapacidades();
                    Mostrar_Grid();
                    dtm_inc_fecha.Text = "";
                    dtm_inc_termina.Text = "";
                    txt_inc_duracion.Text = "";
                    dtm_inc_aplicacion.Text = "";
                    txt_inc_certificado.Text = "";
                    cmb_inc_tipo.Text = "";
                    cmb_inc_caso.Text = "";
                    lbl_inc_caso.Text = "";
                    lbl_inc_tipo.Text = "";
                    lbl_id.Text = "0";
                    dtm_inc_fecha.Focus();
                }    
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el sueldo");
            }
        }//verifica existencia de certificado
       
        public void Verificar_existencia()//Verifica existencia de incapacidad dentro de un rango de fechas 
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT FECHA FROM [asahi16].[Supervisor_giro].[Empinc] WHERE CLAVE = 260 AND FECHA_TERMINO BETWEEN '" + dtm_inc_fecha.Text + "' AND '" + dtm_inc_termina.Text + "' ", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show("Ya hay una incapacidade dentro de esta Fecha, favor de verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtm_inc_fecha.Focus();
                }
                dr.Close();
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudo verifficar existencia" + error.ToString());
            }
        }//Verificar certificado de incapacidad 

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
            Cursor = Cursors.WaitCursor;
            timer1.Start();
            nuevo();
            Mostrar_Grid();
        }
        private void Btn_inc_cancelar_Click(object sender, EventArgs e)//Cancela incapacidades
        {
            dtm_inc_fecha.Text = "";
            dtm_inc_termina.Text = "";
            txt_inc_duracion.Text = "";
            dtm_inc_aplicacion.Text = "";
            txt_inc_certificado.Text = "";
            cmb_inc_tipo.Text = "";
            cmb_inc_caso.Text = "";
            lbl_inc_caso.Text = "";
            lbl_inc_tipo.Text = "";
            btn_inc_cancelar.Enabled = false;
            btn_inc_eliminar.Enabled = false;
            lbl_id.Text = "0";
            dtm_inc_fecha.Focus();
        }
        private void Btn_inc_exportar_Click(object sender, EventArgs e)//Botón exportar excel, módulo de incapacidades
        {
            Exportara_Exel();
            dtm_inc_fecha.Focus();
        }
        private void Btn_inc_anterior_Click(object sender, EventArgs e)
        {
            int Anterior = indice - 1;

            try
            {
                dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[Anterior].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
                btn_inc_siguiente.Enabled = true;
                btn_inc_ultimo.Enabled = true;
                dtm_inc_fecha.Focus();
            }
            catch
            {
                btn_inc_anterior.Enabled = false;
                btn_inc_primero.Enabled = false;
                dtm_inc_fecha.Focus();
            }
        }
        private void Btn_inc_primero_Click(object sender, EventArgs e)
        {
            dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[0].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
            btn_inc_anterior.Enabled = false;
            btn_inc_primero.Enabled = false;
            btn_inc_siguiente.Enabled = true;
            btn_inc_ultimo.Enabled = true;
            dtm_inc_fecha.Focus();
        }
        private void Btn_inc_siguiente_Click(object sender, EventArgs e)
        {
            int Siguiente = indice + 1;
            try
            {
                dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[Siguiente].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
                btn_inc_anterior.Enabled = true;
                btn_inc_primero.Enabled = true;
                dtm_inc_fecha.Focus();
            }
            catch
            {
                btn_inc_siguiente.Enabled = false;
                btn_inc_ultimo.Enabled = false;
                MessageBox.Show("Llegó al final!", "Aviso");
                dtm_inc_fecha.Focus();
            }
        }
        private void Btn_inc_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[50].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
                btn_inc_siguiente.Enabled = false;
                btn_inc_ultimo.Enabled = false;
                btn_inc_anterior.Enabled = true;
                btn_inc_primero.Enabled = true;
                dtm_inc_fecha.Focus();
            }
            catch
            {
            }
        }
        private void Btn_inc_insertar_Click(object sender, EventArgs e)
        {
            dtm_inc_fecha.Text = "";
            dtm_inc_termina.Text = "";
            dtm_inc_aplicacion.Text = "";
            txt_inc_duracion.Text = "";
            cmb_inc_caso.Text = "";
            cmb_inc_tipo.Text = "";
            txt_inc_certificado.Text = "";
            btn_inc_cancelar.Enabled = false;
            btn_inc_eliminar.Enabled = false;
            lbl_id.Text = "0";
            dtm_inc_fecha.Focus();
        }//Botón Para crear una nueva incapacidad
        private void Btn_inc_guardar_Click(object sender, EventArgs e)//botón Inserta o modifica incapacidades
        {
            if (lbl_id.Text == "0")
            {
                if (txt_inc_duracion.Text == "")
                {
                    MessageBox.Show("Es necesario capturar la cantidad de días.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_inc_duracion.Focus();
                }
                else if (txt_inc_certificado.Text == "")
                {
                    MessageBox.Show("Es necesario capturar el Certificado de Incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_inc_certificado.Focus();
                }
                else if (cmb_inc_tipo.Text == "")
                {
                    MessageBox.Show("Es necesario capturar el tipo de incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_inc_tipo.Focus();
                }
                else if (cmb_inc_caso.Text == "")
                {
                    MessageBox.Show("Es necesario capturar el caso de incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_inc_caso.Focus();
                }
                else
                {  verifica_certificado();
                }
            }

            else
            {
                if (txt_inc_duracion.Text == "")
                {
                    MessageBox.Show("Es necesario capturar la cantidad de días.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_inc_duracion.Focus();
                }
                else if (txt_inc_certificado.Text == "")
                {
                    MessageBox.Show("Es necesario capturar el Certificado de Incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_inc_certificado.Focus();
                }
                else if (cmb_inc_tipo.Text == "")
                {
                    MessageBox.Show("Es necesario capturar el tipo de incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_inc_tipo.Focus();
                }
                else if (cmb_inc_caso.Text == "")
                {
                    MessageBox.Show("Es necesario capturar el caso de incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_inc_caso.Focus();
                }
                else
                {
                    Modifica_incapacidades();
                    Mostrar_Grid();
                    dtm_inc_fecha.Text = "";
                    dtm_inc_termina.Text = "";
                    txt_inc_duracion.Text = "";
                    dtm_inc_aplicacion.Text = "";
                    txt_inc_certificado.Text = "";
                    cmb_inc_tipo.Text = "";
                    cmb_inc_caso.Text = "";
                    lbl_inc_caso.Text = "";
                    lbl_inc_tipo.Text = "";
                    lbl_id.Text = "0";
                    dtm_inc_fecha.Focus();
                }
            }
        }


        private void Btn_inc_eliminar_Click(object sender, EventArgs e)//Botón elimina incapacidades
        {
            Elimina_incapacidades();
            Mostrar_Grid();
            dtm_inc_fecha.Text = "";
            dtm_inc_termina.Text = "";
            txt_inc_duracion.Text = "";
            dtm_inc_aplicacion.Text = "";
            txt_inc_certificado.Text = "";
            cmb_inc_tipo.Text = "";
            cmb_inc_caso.Text = "";
            lbl_inc_caso.Text = "";
            lbl_inc_tipo.Text = "";
            btn_inc_eliminar.Enabled = false;
            lbl_id.Text = "0";
            dtm_inc_fecha.Focus();
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
                btn_inc_exportar.Enabled = true;
                btn_inc_siguiente.Enabled = true;
                btn_inc_ultimo.Enabled = true;
                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                dtm_inc_fecha.Focus();
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
             dtm_inc_aplicacion.Text = dtm_inc_fecha.Text ;
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
            btn_inc_exportar.Enabled = true;
            btn_inc_siguiente.Enabled = true;
            btn_inc_ultimo.Enabled = true;
            pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
            txt_nombre.Enabled = false;
            dtm_inc_fecha.Focus();
        }
        private void Lbl_estado_TextChanged(object sender, EventArgs e)
        {
            if (lbl_estado.Text == "VIGENTE")
            {
                lbl_estado.ForeColor = Color.Black;
                btn_inc_insertar.Enabled = true;
                btn_inc_guardar.Enabled = true;
            }
            else
            {
                lbl_estado.ForeColor = Color.Red;
                btn_inc_insertar.Enabled = false;
                btn_inc_guardar.Enabled = false;
            }
        }
        private void Dgv_incapacidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_incapacidades.Rows[e.RowIndex];
                dtm_inc_fecha.Text = row.Cells["INICIO"].Value.ToString();
                dtm_inc_termina.Text = row.Cells["TERMINO"].Value.ToString();
                txt_inc_duracion.Text = row.Cells["DURACION"].Value.ToString();
                txt_inc_certificado.Text = row.Cells["CERTIFICADO"].Value.ToString();
                cmb_inc_caso.Text = row.Cells["CASO"].Value.ToString();
                cmb_inc_tipo.Text = row.Cells["TIPO"].Value.ToString();
                lbl_id.Text = row.Cells["ID"].Value.ToString();
                btn_inc_eliminar.Enabled = true;
                dtm_inc_fecha.Focus();
            }
        }
        private void Dgv_incapacidades_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_incapacidades.Rows[e.RowIndex];
                dtm_inc_fecha.Text = row.Cells["INICIO"].Value.ToString();
                dtm_inc_termina.Text = row.Cells["TERMINO"].Value.ToString();
                txt_inc_duracion.Text = row.Cells["DURACION"].Value.ToString();
                txt_inc_certificado.Text = row.Cells["CERTIFICADO"].Value.ToString();
                cmb_inc_caso.Text = row.Cells["CASO"].Value.ToString();
                cmb_inc_tipo.Text = row.Cells["TIPO"].Value.ToString();
                lbl_id.Text = row.Cells["ID"].Value.ToString();
            }
        }
        private void Dgv_incapacidades_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_incapacidades.CurrentCell != null)   {   indice = dgv_incapacidades.CurrentRow.Index;}
        }
        private void Dgv_incapacidades_DoubleClick(object sender, EventArgs e)
        {
            dtm_inc_fecha.Focus();
            if (lbl_estado.Text == "VIGENTE") { btn_inc_eliminar.Enabled = true;  }
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
                DateTime Inicia = dtm_inc_fecha.Value.Date;
                int dias = Int32.Parse(txt_inc_duracion.Text);
                DateTime Final = Inicia.AddDays(dias - 1);
                dtm_inc_termina.Text = Final.ToString();
                btn_inc_cancelar.Enabled = true;
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
            if (cmb_inc_tipo.Text == "Enfermermedad General")
            {
                lbl_inc_tipo.Text = "EG";
                cmb_inc_caso.Enabled = true;
            }
            else if (cmb_inc_tipo.Text == "Accidente de Trabajo")
            {
                lbl_inc_tipo.Text = "RT";
                cmb_inc_caso.Enabled = false;
                cmb_inc_caso.Text = "Ninguna";
            }
            else if (cmb_inc_tipo.Text == "Accidente de Trayecto")
            {
                lbl_inc_tipo.Text = "AT";
                cmb_inc_caso.Enabled = false;
                cmb_inc_caso.Text = "Ninguna";
            }
            else if (cmb_inc_tipo.Text == "Enfermedad Profesional")
            {
                lbl_inc_tipo.Text = "EP";
                cmb_inc_caso.Enabled = true;
            }
            else if (cmb_inc_tipo.Text == "Pre Maternidad")
            {
                lbl_inc_tipo.Text = "PM";
                cmb_inc_caso.Enabled = true;
            }
            else if (cmb_inc_tipo.Text == "Maternidad Enlace")
            {
                lbl_inc_tipo.Text = "ME";
                cmb_inc_caso.Enabled = true;
            }
            else if (cmb_inc_tipo.Text == "Post Maternidad")
            {
                lbl_inc_tipo.Text = "OM";
                cmb_inc_caso.Enabled = true;
            }
        }
        private void Cmb_inc_caso_TextChanged(object sender, EventArgs e)
        {
            if (cmb_inc_caso.Text == "Unica") { lbl_inc_caso.Text = "U"; }
            else if (cmb_inc_caso.Text == "Inicial") { lbl_inc_caso.Text = "I"; }
            else if (cmb_inc_caso.Text == "Subsecuente") { lbl_inc_caso.Text = "S"; }
            else if (cmb_inc_caso.Text == "Alta Médica ST2") { lbl_inc_caso.Text = "2"; }
            else if (cmb_inc_caso.Text == "Ninguna") { lbl_inc_caso.Text = "N"; }
            else { lbl_inc_caso.Text = ""; }
        }
        private void Txt_inc_certificado_Leave(object sender, EventArgs e)
        {
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            Cursor = Cursors.Default;
        }
    }  
}
