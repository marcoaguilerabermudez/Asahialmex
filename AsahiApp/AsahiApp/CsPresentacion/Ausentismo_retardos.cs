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
    public partial class Frm_Incapacidades_retardos : Form
    {
        public Frm_Incapacidades_retardos()
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
        }

        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");
 
        private void Ausentismo_retardos_Load(object sender, EventArgs e)
        {
            nuevo();
            txt_clave.Focus();
            autocompletar_responsable(txt_nombre);
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
            txt_clave.Focus();
            txt_clave.Text = "";
            txt_nombre.Text = "";
            dtm_inc_inicia.Text = "";
            dtm_inc_termina.Text = "";
            txt_inc_numero.Text = "";
            cmb_inc_tipo.Text = "";
            txt_inc_duracion.Text = "";
            dtm_inc_fecha.Text = "";
            cmb_inc_caso.Text = "";
            lbl_inc_tipo.Text = "";
            lbl_inc_caso.Text = "";
            txt_inc_numero.Mask = ">LL000000";
            txt_inc_duracion.Enabled = false;
            lbl_inc_tipo.Visible = false;
            lbl_inc_caso.Visible = false;
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
            pictureBox1.ImageLocation = "V:/Sistemas/SAAM/Logo.jpg";

        }
        private void Mostrar_Grid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                //cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                //cmd.Parameters.AddWithValue("@TIPO", lbl_tipo.Text);
                //cmd.Parameters.AddWithValue("@MONTO", txt_unidad.Text);
                //cmd.Parameters.AddWithValue("@AUTORIZADO", txt_autorizado.Text);
                //cmd.Parameters.AddWithValue("@TIPO_PERMISO", txt_tipo_permiso.Text);
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
            dgv.Columns[4].Width = 80;
            dgv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[5].Width = 150;//Tipo
            dgv.Columns[6].Width = 145;//Caso
            dgv.Columns[7].Width = 80;//Aplicacion
            dgv.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        //Botones
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            Mostrar_Grid();
        }
        private void Btn_inc_cancelar_Click(object sender, EventArgs e)//Boton cancelar modulo de incapacidades
        {
            dtm_inc_inicia.Text = "";
            dtm_inc_termina.Text = "";
            txt_inc_duracion.Text = "";
            dtm_inc_fecha.Text = "";
            txt_inc_numero.Text = "";
            cmb_inc_tipo.Text = "";
            cmb_inc_caso.Text = "";
            lbl_inc_caso.Text = "";
            lbl_inc_tipo.Text = "";
            btn_inc_cancelar.Enabled = false;
            dtm_inc_inicia.Focus();
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
        private void Btn_inc_exportar_Click(object sender, EventArgs e)//Botón exportar excel, módulo de incapacidades
        {
            Exportara_Exel();
        }
        //Eventos
        private void Dtm_inc_termina_ValueChanged(object sender, EventArgs e)
        {
            DateTime Inicia = dtm_inc_inicia.Value.Date;
            DateTime Termina = dtm_inc_termina.Value.Date;
            TimeSpan Res = Termina - Inicia;
            int dias = Res.Days + 1;
            if (Termina < Inicia)
            {
                MessageBox.Show("Debe ser una fecha mayor a la inicial", "Aviso");
                txt_inc_duracion.Text = "";
                dtm_inc_termina.Focus();
            }
            else
            {
                txt_inc_duracion.Text = dias.ToString();
            }
        }
        private void Cmb_inc_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_inc_tipo.Text == "Enfermermedad General")
            {
                lbl_inc_tipo.Text = "EG";
                cmb_inc_caso.Enabled = true;
                cmb_inc_caso.Text = "";
                lbl_inc_caso.Text = "";
                cmb_inc_caso.Focus();
            }
            else if (cmb_inc_tipo.Text == "Accidente de Trabajo")
            {
                lbl_inc_tipo.Text = "RT";
                cmb_inc_caso.Enabled = false;
                cmb_inc_caso.Text = "Ninguna";
                lbl_inc_caso.Text = "N";
            }
            else if (cmb_inc_tipo.Text == "Accidente de Trayecto")
            {
                lbl_inc_tipo.Text = "AT";
                cmb_inc_caso.Enabled = false;
                cmb_inc_caso.Text = "Ninguna";
                lbl_inc_caso.Text = "N";
            }
            else if (cmb_inc_tipo.Text == "Enfermedad Profesional")
            {
                lbl_inc_tipo.Text = "EP";
                cmb_inc_caso.Enabled = true;
                cmb_inc_caso.Text = "";
                lbl_inc_caso.Text = "";
                cmb_inc_caso.Focus();
            }
            else if (cmb_inc_tipo.Text == "Pre Maternidad")
            {
                lbl_inc_tipo.Text = "PM";
                cmb_inc_caso.Enabled = true;
                cmb_inc_caso.Text = "";
                lbl_inc_caso.Text = "";
                cmb_inc_caso.Focus();
            }
            else if (cmb_inc_tipo.Text == "Maternidad Enlace")
            {
                lbl_inc_tipo.Text = "ME";
                cmb_inc_caso.Enabled = true;
                cmb_inc_caso.Text = "";
                lbl_inc_caso.Text = "";
                cmb_inc_caso.Focus();
            }
            else if (cmb_inc_tipo.Text == "Post Maternidad")
            {
                lbl_inc_tipo.Text = "OM";
                cmb_inc_caso.Enabled = true;
                cmb_inc_caso.Text = "";
                lbl_inc_caso.Text = "";
                cmb_inc_caso.Focus();
            }
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
                btn_inc_exportar.Enabled = true;
                btn_inc_siguiente.Enabled = true;
                btn_inc_ultimo.Enabled = true;
                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                dtm_inc_inicia.Focus();
            }
        }
        private void Cmb_inc_caso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_inc_caso.Text == "Unica"){lbl_inc_caso.Text = "U";}
            else if (cmb_inc_caso.Text == "Inicia"){lbl_inc_caso.Text = "I";}
            else if (cmb_inc_caso.Text == "Subsecuente"){   lbl_inc_caso.Text = "S";}
            else if (cmb_inc_caso.Text == "Alta Médica ST2"){  lbl_inc_caso.Text = "2";}
            else if (cmb_inc_caso.Text == "Ninguna") { lbl_inc_caso.Text = "N"; }
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Dtm_inc_inicia_ValueChanged(object sender, EventArgs e)
        {
            btn_inc_cancelar.Enabled = true;
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
            btn_inc_exportar.Enabled = true;
            btn_inc_siguiente.Enabled = true;
            btn_inc_ultimo.Enabled = true;
            pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
            txt_nombre.Enabled = false;
            Mostrar_Grid();
            dtm_inc_inicia.Focus();     
        }
        private void Lbl_estado_TextChanged(object sender, EventArgs e)
        {
            if (lbl_estado.Text == "BAJA")
            {
                lbl_estado.ForeColor = Color.Red; 
            }
            else
            {
                lbl_estado.ForeColor = Color.Black;
            }
        }
    }
}
