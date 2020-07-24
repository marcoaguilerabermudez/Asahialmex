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
    public partial class Frm_Historico_personal : Form
    {
        public Frm_Historico_personal()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataReader dr;
        public DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");


        private void Frm_Historico_personal_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            timer1.Start();

            autocompletar_responsable(txt_nombre);
            txt_clave.Focus();
        }

        private void Llenar_dgv()// Método para llenar DatagridView
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[sp_Historial_personal]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@VAR", 1);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
               dgv_datos.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void autocompletar_responsable(TextBox cajaTexto)//Cargar Nombre de empleado
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(RTRIM(NOMBREN)+ ' '+ RTRIM(NOMBREP)+ ' ' + RTRIM(NOMBREM)) as 'NOMBRE' FROM [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] WHERE NOMBREN  LIKE '%' + " + txt_nombre.Text + " + '%'  order by NOMBRE ASC", con);
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



        private void Diseño_dgv(DataGridView dgv)
        {
            dgv.Columns[0].Width = 50;//No. Empleado
            dgv.Columns[1].Width = 150;//Puesto
            dgv.Columns[2].Width = 60;//sd0
            dgv.Columns[3].Width = 80;//Fecha
            dgv.Columns[4].Width = 130;//tipo
            dgv.Columns[5].Width = 155;//motivo
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
                for (int i = -1; i < dgv_datos.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_datos.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_datos.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_datos.Rows[i].Cells[j].Value.ToString();
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



        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            timer1.Start();
            nuevo();
        }

        private void nuevo()
        {

            Cursor = Cursors.WaitCursor;
            timer1.Start();

            txt_clave.Text = "";
            Llenar_dgv();
            txt_nombre.Text = "";
            txt_nombre.Enabled = true;
            lbl_estado.Text = "ESTADO";
            pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
            txt_clave.Focus();
        }


        private void txt_clave_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cargar_informacion();
                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                Llenar_dgv();
                Diseño_dgv(dgv_datos);
            }
        }
        private void dgv_datos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_datos.Columns[e.ColumnIndex].Name == "TIPO")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    if ((e.Value.ToString().Contains("BAJA")))
                    {
                        e.CellStyle.BackColor = Color.IndianRed;
                    }
                    else if ((e.Value.ToString().Contains("ALTA")))
                    {
                        e.CellStyle.BackColor = Color.ForestGreen;
                    }
                    else if ((e.Value.ToString().Contains("REINGRESO")))
                    {
                        e.CellStyle.BackColor = Color.ForestGreen;
                    }
                }
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            timer1.Start();

            Exportara_Exel();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            timer1.Start();

            //Todo el reporte
            Rep_Historial_empleado rep = new Rep_Historial_empleado();
           rep.VAR = Convert.ToInt32(2);
           rep.CLAVE = Convert.ToInt32(txt_clave.Text);
            rep.ShowDialog();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar))
            { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            cargar_clave();
            Llenar_dgv();
            pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
            txt_nombre.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            Cursor = Cursors.Default;
        }
    }
}
