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
    public partial class Permisos_Autorizaciones : Form
    {
        public Permisos_Autorizaciones()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "NUEVO PERMISO");
            tt.SetToolTip(btn_primero, "Primero [Inicio]");
            tt.SetToolTip(btn_anterior, "Anterior [Re. Pág.]");
            tt.SetToolTip(btn_siguiente, "Siguiente [Av. Pág.]");
            tt.SetToolTip(btn_ultimo, "Último [Fin]");
            tt.SetToolTip(btn_insertar, "Insertar [F3]");
            tt.SetToolTip(btn_eliminar, "Eliminar [F4]");
            tt.SetToolTip(btn_guardar, "Guardar [F2]");
            tt.SetToolTip(btn_cancelar, "Cancelar [Esc]");
        }
        //Variables
        int indice = 0;

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");
        //Principal
        private void Permisos_Autorizaciones_Load(object sender, EventArgs e)
        {
            nuevo();
        }
        //Métodos
        private void Diseño_Grid(DataGridView dgv)
        {
            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 50;
            dgv.Columns[2].Width = 110;
            dgv.Columns[3].Width = 110;
            dgv.Columns[4].Width = 110;
            dgv.Columns[5].Width = 160;
            dgv.Columns[6].Width = 140;
        }
        private void Mostrar_Grid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Permisos_autorizaciones]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_tipo.Text);
                cmd.Parameters.AddWithValue("@MONTO", txt_unidad.Text);
                cmd.Parameters.AddWithValue("@AUTORIZADO", txt_autorizado.Text);
                cmd.Parameters.AddWithValue("@TIPO_PERMISO", txt_tipo_permiso.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_permisos.DataSource = dt;
                Diseño_Grid(dgv_permisos);
                dgv_permisos.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dgv_permisos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Eliminar()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Permisos_autorizaciones]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "2");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_tipo.Text);
                cmd.Parameters.AddWithValue("@MONTO", txt_unidad.Text);
                cmd.Parameters.AddWithValue("@AUTORIZADO", txt_autorizado.Text);
                cmd.Parameters.AddWithValue("@TIPO_PERMISO", txt_tipo_permiso.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                MessageBox.Show("Se eliminó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Inserta_informacion()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Permisos_autorizaciones]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "3");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_tipo.Text);
                cmd.Parameters.AddWithValue("@MONTO", txt_unidad.Text);
                cmd.Parameters.AddWithValue("@AUTORIZADO", txt_autorizado.Text);
                cmd.Parameters.AddWithValue("@TIPO_PERMISO", txt_tipo_permiso.Text);
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
        private void Modifica_informacion()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Permisos_autorizaciones]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "4");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_tipo.Text);
                cmd.Parameters.AddWithValue("@MONTO", txt_unidad.Text);
                cmd.Parameters.AddWithValue("@AUTORIZADO", txt_autorizado.Text);
                cmd.Parameters.AddWithValue("@TIPO_PERMISO", txt_tipo_permiso.Text);
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
        private void Exportara_Exel()// Método para exportar a excel.
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
                for (int i = -1; i < dgv_permisos.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_permisos.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_permisos.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_permisos.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;//ok
                    cellRowIndex++;
                }
                //Obtener la ubicación y el nombre de archivo de excel para guardar del usuario.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Libro de Excel (*.xlsx)|*.xlsx";
                saveDialog.FilterIndex = 0;//ok

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Su información se exportó correctamente.");
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
        private void nuevo()
        {
            txt_clave.Focus();
            txt_clave.Text = "";
            txt_nombre.Text = "";
            lbl_estado.Text = "ESTADO";
            dtm_fecha.Text = "";
            txt_unidad.Text = "";
            txt_autorizado.Text = "";
            txt_tipo_permiso.Text = "";
            txt_descripcion.Text = "";
            rdb_bh.Checked = false;
            rdb_dt.Checked = false;
            rdb_f.Checked = false;
            rdb_h.Checked = false;
            rdb_pd.Checked = false;
            rdb_r.Checked = false;
            rdb_p.Checked = false;
            btn_anterior.Enabled = false;
            btn_primero.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_siguiente.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_insertar.Enabled = false;
            btn_exportar.Enabled = false;
            pictureBox1.ImageLocation = "V:/Sistemas/SAAM/LogoFinal" + ".png";
            txt_descripcion.Enabled = false;
            lbl_tipo.Text = "";
            lbl_tipo.Visible = false;
            lbl_mod.Text = "0";
            btn_cancelar.Enabled = false;
            btn_guardar.Enabled = false;
            lbl_mod.Visible = false;
        }

        //Botones
        private void Btn_tipo_permiso_Click(object sender, EventArgs e)
        {
        }
       private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            Mostrar_Grid();
        }
        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            dtm_fecha.Text = "";
            txt_unidad.Text = "";
            txt_autorizado.Text = "";
            txt_tipo_permiso.Text = "";
            txt_descripcion.Text = "";
            lbl_tipo.Text = "";
            rdb_bh.Checked = false;
            rdb_dt.Checked = false;
            rdb_f.Checked = false;
            rdb_h.Checked = false;
            rdb_pd.Checked = false;
            rdb_r.Checked = false;
            rdb_p.Checked = false;
            lbl_mod.Text = "0";
            btn_eliminar.Enabled = false;
            dtm_fecha.Focus();
        }
        private void Btn_tipo_permiso_Click_1(object sender, EventArgs e)
        {
            Tipo_permiso tp = new Tipo_permiso();
            tp.ShowDialog();
        }
        private void Btn_insertar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            dtm_fecha.Text = "";
            txt_unidad.Text = "";
            txt_autorizado.Text = "";
            txt_tipo_permiso.Text = "";
            lbl_tipo.Text = "";
            rdb_bh.Checked = false;
            rdb_dt.Checked = false;
            rdb_f.Checked = false;
            rdb_h.Checked = false;
            rdb_pd.Checked = false;
            rdb_r.Checked = false;
            rdb_p.Checked = false;
            lbl_mod.Text = "0";
            dtm_fecha.Focus();
        }
        private void Btn_siguiente_Click(object sender, EventArgs e)
        {
            int Siguiente = indice + 1;
            try
            {
                dgv_permisos.CurrentCell = dgv_permisos.Rows[Siguiente].Cells[dgv_permisos.CurrentCell.ColumnIndex];
                btn_anterior.Enabled = true;
                btn_primero.Enabled = true;
                dtm_fecha.Focus();
                lbl_mod.Text = "1";
            }
            catch
            {
                btn_siguiente.Enabled = false;
                btn_ultimo.Enabled = false;
                MessageBox.Show("Llegó al final!", "Aviso");
                dtm_fecha.Focus();
            }
        }
        private void Btn_anterior_Click(object sender, EventArgs e)
        {
            int Anterior = indice - 1;

            try
            {
                dgv_permisos.CurrentCell = dgv_permisos.Rows[Anterior].Cells[dgv_permisos.CurrentCell.ColumnIndex];
                btn_siguiente.Enabled = true;
                btn_ultimo.Enabled = true;
                lbl_mod.Text = "1";
                dtm_fecha.Focus();
            }
            catch
            {
                btn_anterior.Enabled = false;
                btn_primero.Enabled = false;
                dtm_fecha.Focus();
            }
        }
        private void Btn_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_permisos.CurrentCell = dgv_permisos.Rows[49].Cells[dgv_permisos.CurrentCell.ColumnIndex];
                btn_siguiente.Enabled = false;
                btn_ultimo.Enabled = false;
                btn_anterior.Enabled = true;
                btn_primero.Enabled = true;
                lbl_mod.Text = "1";
                dtm_fecha.Focus();
            }
            catch
            {
            }   
        }
        private void Btn_primero_Click(object sender, EventArgs e)
        {
            dgv_permisos.CurrentCell = dgv_permisos.Rows[0].Cells[dgv_permisos.CurrentCell.ColumnIndex];
            btn_anterior.Enabled = false;
            btn_primero.Enabled = false;
            btn_siguiente.Enabled = true;
            btn_ultimo.Enabled = true;
            lbl_mod.Text = "1";
            dtm_fecha.Focus();
        }
        private void Btn_exportar_Click(object sender, EventArgs e)
        {
            Exportara_Exel();
        }
        private void Btn_gurdar_Click(object sender, EventArgs e)
        {
            if (lbl_mod.Text == "0")
            {
                Inserta_informacion();
                Mostrar_Grid();
                dtm_fecha.Text = "";
                txt_unidad.Text = "";
                txt_autorizado.Text = "";
                txt_tipo_permiso.Text = "";
                txt_descripcion.Text = "";
                lbl_tipo.Text = "";
                rdb_bh.Checked = false;
                rdb_dt.Checked = false;
                rdb_f.Checked = false;
                rdb_h.Checked = false;
                rdb_pd.Checked = false;
                rdb_r.Checked = false;
                rdb_p.Checked = false;
                btn_siguiente.Enabled = true;
                btn_ultimo.Enabled = true;
                btn_primero.Enabled = false;
                btn_anterior.Enabled = false;
                btn_eliminar.Enabled = false;
                lbl_mod.Text = "0";
                dtm_fecha.Focus();
            }
            else if (lbl_mod.Text == "1")
            {
               Modifica_informacion();
                Mostrar_Grid();
                dtm_fecha.Text = "";
                txt_unidad.Text = "";
                txt_autorizado.Text = "";
                txt_tipo_permiso.Text = "";
                txt_descripcion.Text = "";
                lbl_tipo.Text = "";
                rdb_bh.Checked = false;
                rdb_dt.Checked = false;
                rdb_f.Checked = false;
                rdb_h.Checked = false;
                rdb_pd.Checked = false;
                rdb_r.Checked = false;
                rdb_p.Checked = false;
                btn_siguiente.Enabled = true;
                btn_ultimo.Enabled = true;
                btn_primero.Enabled = false;
                btn_anterior.Enabled = false;
                btn_eliminar.Enabled = false;
                lbl_mod.Text = "0";
                dtm_fecha.Focus();
            }   
        }
        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Mostrar_Grid();
            dtm_fecha.Text = "";
            txt_unidad.Text = "";
            txt_autorizado.Text = "";
            txt_tipo_permiso.Text = "";
            txt_descripcion.Text = "";
            lbl_tipo.Text = "";
            rdb_bh.Checked = false;
            rdb_dt.Checked = false;
            rdb_f.Checked = false;
            rdb_h.Checked = false;
            rdb_pd.Checked = false;
            rdb_r.Checked = false;
            rdb_p.Checked = false;
            btn_eliminar.Enabled = false;
            lbl_mod.Text = "0";
            dtm_fecha.Focus();
        }
        //Eventos
        private void Lbl_estado_TextChanged(object sender, EventArgs e)
        {
            if (lbl_estado.Text == "VIGENTE")
            {
                btn_insertar.Enabled = true;
                btn_cancelar.Enabled = true;
                btn_guardar.Enabled = true;
                btn_eliminar.Enabled = true;
            }
        }
        private void Dgv_permisos_DoubleClick(object sender, EventArgs e)
        {
         tabControl1.SelectedIndex = 1;
         txt_unidad.Focus();

            if (lbl_estado.Text == "VIGENTE")
            {
                btn_eliminar.Enabled = true;
                lbl_mod.Text = "1";
            }
        }
        private void Lbl_tipo_TextChanged(object sender, EventArgs e)
        {
            if (lbl_tipo.Text == "H") { rdb_h.Checked = true; }
            if (lbl_tipo.Text == "F") { rdb_f.Checked = true; }
            if (lbl_tipo.Text == "P") { rdb_p.Checked = true; }
            if (lbl_tipo.Text == "R") { rdb_r.Checked = true; }
            if (lbl_tipo.Text == "DT") { rdb_dt.Checked = true; }
            if (lbl_tipo.Text == "PD") { rdb_pd.Checked = true; }
            if (lbl_tipo.Text == "BH") { rdb_bh.Checked = true; }
            else
            {
            }
        }
        private void Rdb_h_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_h.Checked == true) { lbl_tipo.Text = "H"; }
        }
        private void Rdb_r_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_r.Checked == true) { lbl_tipo.Text = "R"; }
        }
        private void Rdb_p_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_p.Checked == true) { lbl_tipo.Text = "P"; }
        }
        private void Rdb_bh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_bh.Checked == true) { lbl_tipo.Text = "BH"; }
        }
        private void Rdb_pd_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_pd.Checked == true) { lbl_tipo.Text = "PD"; }
        }
        private void Rdb_dt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_dt.Checked == true) { lbl_tipo.Text = "DT"; }
        }
        private void Rdb_f_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_f.Checked == true) { lbl_tipo.Text = "F"; }
        }
        private void Dgv_permisos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_permisos.CurrentCell != null)
            {
                indice = dgv_permisos.CurrentRow.Index;
            }
        }
        private void Txt_tipo_permiso_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_tipo_permiso.Text == "1") { txt_descripcion.Text = "TRABAJAR TIEMPO EXTRA"; }
            else if (txt_tipo_permiso.Text == "2") { txt_descripcion.Text = "SALIR TEMPRANO"; }
            else if (txt_tipo_permiso.Text == "4") { txt_descripcion.Text = "RETARDOS POR TRANSPORTE"; }
            else if (txt_tipo_permiso.Text == "5") { txt_descripcion.Text = "LLEGAR TARDE"; }
            else if (txt_tipo_permiso.Text == "6") { txt_descripcion.Text = "EXTRA PENDIENTE"; }
            else { txt_descripcion.Text = ""; }
        }
        private void Dgv_permisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_permisos.Rows[e.RowIndex];
                dtm_fecha.Text = row.Cells["Fecha"].Value.ToString();
                txt_unidad.Text = row.Cells["Unidad (Minutos)"].Value.ToString();
                txt_autorizado.Text = row.Cells["Autorizado"].Value.ToString();
                txt_tipo_permiso.Text = row.Cells["Tipo de Permiso"].Value.ToString();
                lbl_tipo.Text = row.Cells["Tipo"].Value.ToString();
                txt_unidad.Focus();
            }
        }
        private void Txt_tipo_permiso_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        private void Txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Dgv_permisos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_permisos.Rows[e.RowIndex];
                dtm_fecha.Text = row.Cells["Fecha"].Value.ToString();
                txt_unidad.Text = row.Cells["Unidad (Minutos)"].Value.ToString();
                txt_autorizado.Text = row.Cells["Autorizado"].Value.ToString();
                txt_tipo_permiso.Text = row.Cells["Tipo de Permiso"].Value.ToString();
                lbl_tipo.Text = row.Cells["Tipo"].Value.ToString();
            }
        }
        private void Txt_unidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        private void Txt_autorizado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
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
                btn_exportar.Enabled = true;
                btn_siguiente.Enabled = true;
                btn_ultimo.Enabled = true;
                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                lbl_mod.Text = "1";
                dtm_fecha.Focus();
            }
        }
        private void Txt_unidad_Leave(object sender, EventArgs e)
        {
            if (txt_unidad.Text == "")
            {
                txt_unidad.Text = "0";
            }
        }
        private void Txt_autorizado_Leave(object sender, EventArgs e)
        {
            if (txt_autorizado.Text == "")
            {
                txt_autorizado.Text = "0";
            }
        }

    }
}
