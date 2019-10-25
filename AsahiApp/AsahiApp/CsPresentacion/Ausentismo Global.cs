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
    public partial class Ausentismo_Global : Form
    {
        public Ausentismo_Global()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");
        int Var;
    

        private void Ausentismo_Global_Load(object sender, EventArgs e)
        {
            Var = 2;
            Llenar_dgv();
            dgv_acumulado.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv_acumulado.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            Calcula_Total();
            txt_depto.Visible = false;
            DateTime ayer = DateTime.Now.AddDays(-1);
            dtm_fecha.Text = ayer.ToString();
            lbl_reporte.Text = "REPORTE DIA DE AYER";
        }
        private void Calcula_Total()
        {
            double Plan = 0;
            double Activos = 0;
            double Incidencias = 0;

            foreach (DataGridViewRow row in dgv_acumulado.Rows)
            {
                Plan += Convert.ToDouble(row.Cells["PLAN"].Value);
                Activos += Convert.ToDouble(row.Cells["ACTIVOS"].Value);
                Incidencias += Convert.ToDouble(row.Cells["INCIDENCIAS"].Value);
            }
            lbl_plan.Text = Convert.ToString(Plan);
            lbl_activos.Text = Convert.ToString(Activos);
            lbl_incidencias.Text = Convert.ToString(Incidencias);
        }

        public void Llenar_dgv()// Método para llenar DatagridView Total
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ausentismo_Global]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", Var);
                cmd.Parameters.AddWithValue("@Fecha", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@Depto", txt_depto.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_acumulado.DataSource = dt;
                Diseño_dgv(dgv_acumulado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Llenar_dgv_secundario()// Método para llenar DatagridView secundario
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ausentismo_Global]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", Var);
                cmd.Parameters.AddWithValue("@Fecha", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@Depto", txt_depto.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_total.DataSource = dt;
                Diseño_dgv_secundario(dgv_total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                int cellRowIndex = 2;//ok
                int cellColumnIndex = 1;//ok
                //Pasa por cada fila y lee el valor de cada columna.
                for (int i = -1; i < dgv_acumulado.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_acumulado.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_acumulado.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_acumulado.Rows[i].Cells[j].Value.ToString();
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
        private void Diseño_dgv_secundario(DataGridView dgv)
        {
            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 100;
            dgv.Columns[3].Width = 100;
            dgv.Columns[4].Width = 60;
            dgv.Columns[5].Width = 60;
            dgv.Columns[6].Width = 60;
        }
        private void Diseño_dgv(DataGridView dgv)
        {
            dgv.Columns[0].Width = 170;//departamento
            dgv.Columns[1].Width = 50;//
            dgv.Columns[2].Width = 60;//
            dgv.Columns[3].Width = 80;//
        }
        private void Dgv_acumulado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_acumulado.Rows[e.RowIndex];
                txt_depto.Text = row.Cells["DEPARTAMENTO"].Value.ToString();
            }
        }
        private void Dtm_fecha_ValueChanged(object sender, EventArgs e)
        {
            Var = 1;
            Llenar_dgv();
            Calcula_Total();
            lbl_reporte.Text = "";
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            var ayer = DateTime.Today.AddDays(-1);
            dtm_fecha.Text = ayer.ToString();
            lbl_reporte.Text = "REPORTE DIA DE AYER";
            Var = 2;
            Llenar_dgv();    
        }
        private void Dgv_acumulado_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_acumulado.Rows[e.RowIndex];
                txt_depto.Text = row.Cells["DEPARTAMENTO"].Value.ToString();
                Var = 0;
                Llenar_dgv_secundario();
            }
        }
        private void Btn_exportar_ant2_Click(object sender, EventArgs e)
        {
            Exportara_Exel();
        }
    }
}
