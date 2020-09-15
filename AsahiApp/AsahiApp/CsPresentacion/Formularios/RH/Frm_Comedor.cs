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
    public partial class Frm_Comedor : Form
    {
        public Frm_Comedor()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "Nuevo");
            tt.SetToolTip(btn_com_primero, "Primero [Inicio]");
            tt.SetToolTip(btn_com_anterior, "Anterior [Re. Pág.]");
            tt.SetToolTip(btn_com_siguiente, "Siguiente [Av. Pág.]");
            tt.SetToolTip(btn_com_ultimo, "Último [Fin]");
            tt.SetToolTip(btn_com_agregar, "Insertar");
            tt.SetToolTip(btn_com_eliminar, "Eliminar");
            tt.SetToolTip(btn_com_guardar, "Guardar");
            tt.SetToolTip(btn_com_cancelar, "Cancelar");
            tt.SetToolTip(btn_com_exportar, "Exportar");
        }


        int indice = 0;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        private void Frm_Comedor_Load(object sender, EventArgs e)
        {
           Nuevo();
            autocompletar_responsable(txt_nombre);
            txt_clave.Focus();
        }

        //Métodos
        private void Nuevo()
        {
            txt_clave.Text = "";
            txt_nombre.Text = "";
            dtm_com_fecha.Text = "";
            lbl_estado.Text = "";
            cmb_tipo.Text = "";
            txt_costo.Text = "";
            txt_hora.Text = "";
            lbl_tipo_falta.Text = "";
            lbl_tipo_falta.Visible = false;
            txt_nombre.Enabled = true;
            txt_hora.Enabled = false;
            txt_costo.Enabled = false;
            btn_com_primero.Enabled = false;
            btn_com_siguiente.Enabled = false;
            btn_com_anterior.Enabled = false;
            btn_com_ultimo.Enabled = false;
            pictureBox1.ImageLocation = "V:/Sistemas/SAAM/Logo.jpg";
            btn_com_agregar.Enabled = false;
            btn_com_guardar.Enabled = false;
            btn_com_eliminar.Enabled = false;
            btn_com_cancelar.Enabled = false;
            btn_com_exportar.Enabled = false;
            txt_clave.Focus();
        }
        private void Mostrar_Grid()//Mostrar grid de incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Registros_comedor]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_com_fecha.Text);
                cmd.Parameters.AddWithValue("@HORA", txt_hora.Text);
                cmd.Parameters.AddWithValue("@TIPO", cmb_tipo.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_comedor.DataSource = dt;
                Diseño_Grid(dgv_comedor);
                dgv_comedor.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dgv_comedor.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Elimina_comedor()//Elimina comedores.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Registros_comedor]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "2");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_com_fecha.Text);
                cmd.Parameters.AddWithValue("@HORA", txt_hora.Text);
                cmd.Parameters.AddWithValue("@TIPO", cmb_tipo.Text);

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
        private void Inserta_comedor()//Inserta comedores.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Registros_comedor]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "3");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_com_fecha.Text);
                cmd.Parameters.AddWithValue("@HORA", txt_hora.Text);
                cmd.Parameters.AddWithValue("@TIPO", cmb_tipo.Text);
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
        private void Verifica_Vacaciones()//Verifica fecha de vacaciones
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[SP_Registros_comedor]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "4";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_com_fecha.Text;
            da.SelectCommand.Parameters.Add("@HORA", SqlDbType.VarChar, 100).Value = txt_hora.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = cmb_tipo.Text;
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("El empleado tiene vacaciones en esta Fecha, Favor de verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_com_fecha.Focus();  
            }
            else
            {
                Verifica_Incapacidad();
            }
        }
        private void Verifica_Incapacidad()//Verifica si hay incapacidad
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[SP_Registros_comedor]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "5";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_com_fecha.Text;
            da.SelectCommand.Parameters.Add("@HORA", SqlDbType.VarChar, 100).Value = txt_hora.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = cmb_tipo.Text;
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("El empleado tiene incapacidad en esta Fecha, Favor de verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_com_fecha.Focus();  
            }
            else
            {
                Inserta_comedor();
                Mostrar_Grid();
                dtm_com_fecha.Text = "";
                txt_hora.Text = "";
                txt_costo.Text = "";
                cmb_tipo.Text = "";
                dtm_com_fecha.Focus();
            }
           
        }
        private void Verifica_Falta()//Verifica si hay una falta
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[SP_Registros_comedor]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "6";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_com_fecha.Text;
            da.SelectCommand.Parameters.Add("@HORA", SqlDbType.VarChar, 100).Value = txt_hora.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = cmb_tipo.Text;
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                lbl_tipo_falta.Text = dt.Rows[0]["TIPO"].ToString();
                dtm_com_fecha.Focus();
            }
            else
            {    
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
                for (int i = -1; i < dgv_comedor.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_comedor.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_comedor.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_comedor.Rows[i].Cells[j].Value.ToString();
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
        private void Diseño_Grid(DataGridView dgv)
        {
            dgv.Columns[0].Width = 70;//Clave
            dgv.Columns[1].Width = 60; //Fecha
            dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].Width = 60;//Hora
            dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].Width = 60;//Costo
            dgv.Columns[4].Width = 120;//tipo
            dgv.Columns[5].Width = 70;//Lector
            dgv.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[6].Width = 120;//Registro
            dgv.Columns[7].Width = 200;//Registro
        }

        //Botones
        private void Btn_com_exportar_Click(object sender, EventArgs e)
        {
            Exportara_Exel();
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            timer1.Start();
            Nuevo();
            Mostrar_Grid();
        }
        private void Btn_com_cancelar_Click(object sender, EventArgs e)
        {
            dtm_com_fecha.Text = "";
            txt_hora.Text = "";
            txt_costo.Text = "";
            cmb_tipo.Text = "";
            dtm_com_fecha.Focus();
        }
        private void Btn_com_insertar_Click(object sender, EventArgs e)
        {
            dtm_com_fecha.Text = "";
            txt_hora.Text = "";
            txt_costo.Text = "";
            cmb_tipo.Text = "";

            txt_hora.Enabled = false;
            txt_costo.Enabled = false;
            btn_com_guardar.Enabled = true;
            btn_com_cancelar.Enabled = true;
            btn_com_eliminar.Enabled = false;
            dtm_com_fecha.Focus();
        }
        private void Btn_com_primero_Click(object sender, EventArgs e)
        {
            dgv_comedor.CurrentCell = dgv_comedor.Rows[0].Cells[dgv_comedor.CurrentCell.ColumnIndex];
            btn_com_anterior.Enabled = false;
            btn_com_primero.Enabled = false;
            btn_com_siguiente.Enabled = true;
            btn_com_ultimo.Enabled = true;
            dtm_com_fecha.Focus();
        }
        private void Btn_com_anterior_Click(object sender, EventArgs e)
        {
            int Anterior = indice - 1;

            try
            {
                dgv_comedor.CurrentCell = dgv_comedor.Rows[Anterior].Cells[dgv_comedor.CurrentCell.ColumnIndex];
                btn_com_siguiente.Enabled = true;
                btn_com_ultimo.Enabled = true;
                dtm_com_fecha.Focus();
            }
            catch
            {
                btn_com_anterior.Enabled = false;
                btn_com_primero.Enabled = false;
                dtm_com_fecha.Focus();
            }
        }
        private void Btn_com_siguiente_Click(object sender, EventArgs e)
        {
            int Siguiente = indice + 1;
            try
            {
                dgv_comedor.CurrentCell = dgv_comedor.Rows[Siguiente].Cells[dgv_comedor.CurrentCell.ColumnIndex];
                btn_com_anterior.Enabled = true;
                btn_com_primero.Enabled = true;
                dtm_com_fecha.Focus();
            }
            catch
            {
                btn_com_siguiente.Enabled = false;
                btn_com_ultimo.Enabled = false;
                MessageBox.Show("Llegó al final!", "Aviso");
                dtm_com_fecha.Focus();
            }
        }
        private void Btn_com_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_comedor.CurrentCell = dgv_comedor.Rows[49].Cells[dgv_comedor.CurrentCell.ColumnIndex];
                btn_com_siguiente.Enabled = false;
                btn_com_ultimo.Enabled = false;
                btn_com_anterior.Enabled = true;
                btn_com_primero.Enabled = true;
                dtm_com_fecha.Focus();
            }
            catch
            {
            }
        }
        private void Btn_com_eliminar_Click(object sender, EventArgs e)
        {
            Elimina_comedor();
            Mostrar_Grid();
            dtm_com_fecha.Text = "";
            txt_hora.Text = "";
            txt_costo.Text = "";
            cmb_tipo.Text = "";
            dtm_com_fecha.Focus();
        }
        private void Btn_com_guardar_Click(object sender, EventArgs e)
        {
            Verifica_Falta();
            if (cmb_tipo.Text == "")
            {
                MessageBox.Show("Es necesario seleccionar tipo de comedor.", "Aviso");
                cmb_tipo.Focus(); }    
          else  if (lbl_tipo_falta.Text == "N")
           {
                MessageBox.Show("El empleado tiene suspensión en esta Fecha, Favor de verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_com_fecha.Focus(); }
            else if (lbl_tipo_falta.Text == "P")
            {
                MessageBox.Show("El empleado tiene permiso sin goce en esta Fecha, Favor de verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_com_fecha.Focus();}
            else if (lbl_tipo_falta.Text == "G")
            {
                MessageBox.Show("El empleado tiene permiso con goce en esta Fecha, Favor de verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_com_fecha.Focus(); }
            else if (lbl_tipo_falta.Text == "U")
            {
                MessageBox.Show("El empleado tiene falta justificada en esta Fecha, Favor de verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_com_fecha.Focus();
            }
            else if (lbl_tipo_falta.Text == "F")
            {
                MessageBox.Show("El empleado tiene falta injustificada en esta Fecha, Favor de verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_com_fecha.Focus(); }
            else
            {
                Verifica_Vacaciones();
            }
        }

        //Eventos
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
                btn_com_exportar.Enabled = true;
                btn_com_siguiente.Enabled = true;
                btn_com_ultimo.Enabled = true;
                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                dtm_com_fecha.Focus();
            }
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
            btn_com_exportar.Enabled = true;
            btn_com_siguiente.Enabled = true;
            btn_com_ultimo.Enabled = true;
            pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
            txt_nombre.Enabled = false;
            dtm_com_fecha.Focus();
        }
        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Dgv_comedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_comedor.Rows[e.RowIndex];
                dtm_com_fecha.Text = row.Cells["FECHA"].Value.ToString();
                txt_hora.Text = row.Cells["HORA"].Value.ToString();
                txt_costo.Text = row.Cells["COSTO"].Value.ToString();
                cmb_tipo.Text = row.Cells["TIPO"].Value.ToString();
                btn_com_eliminar.Enabled = true;
                btn_com_cancelar.Enabled = true;
                btn_com_agregar.Enabled = true;
                btn_com_guardar.Enabled = false;
                dtm_com_fecha.Focus();
            }
        }
        private void Dgv_comedor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_comedor.Rows[e.RowIndex];
                dtm_com_fecha.Text = row.Cells["FECHA"].Value.ToString();
                txt_hora.Text = row.Cells["HORA"].Value.ToString();
                txt_costo.Text = row.Cells["COSTO"].Value.ToString();
                cmb_tipo.Text = row.Cells["TIPO"].Value.ToString();
                dtm_com_fecha.Focus();
            }
        }
        private void Dgv_comedor_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_comedor.CurrentCell != null) { indice = dgv_comedor.CurrentRow.Index; }
        }
        private void Lbl_estado_TextChanged(object sender, EventArgs e)
        {
            if (lbl_estado.Text == "VIGENTE")
            {
                lbl_estado.ForeColor = Color.Black;
                btn_com_agregar.Enabled = true;
            }
            else
            {
                lbl_estado.ForeColor = Color.Red;
                btn_com_agregar.Enabled = false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            Cursor = Cursors.Default;
        }
    }
}
