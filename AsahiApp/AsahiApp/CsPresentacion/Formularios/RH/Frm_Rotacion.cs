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
    public partial class Frm_Rotacion : Form
    {
        public Frm_Rotacion()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        int Var;

        private void Frm_Rotacion_Load(object sender, EventArgs e)
        {
            Var = 0;
            Llenar_dgv_total();
            dgv_total.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv_total.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            Calcula_Total();
        }

        private void Calcula_Total()
        {
            double Altas = 0;
            double Bajas = 0;
            double Total = 0;

            foreach (DataGridViewRow row in dgv_total.Rows)
            {
                Altas += Convert.ToDouble(row.Cells["ALTAS"].Value);
                Bajas += Convert.ToDouble(row.Cells["BAJAS"].Value);
                Total += Convert.ToDouble(row.Cells["TOTAL"].Value);
            }
            lbl_altas.Text = Convert.ToString(Altas);
            lbl_bajas.Text = Convert.ToString(Bajas);
            lbl_total.Text = Convert.ToString(Total);
            txt_ac.Text = Convert.ToString(Bajas * 100 / Total);
            txt_ab.Text = Convert.ToString(Bajas * 100 / Altas);
        }

        private void Llenar_dgv_total()// Método para llenar DatagridView Total
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_rotacion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", Var);
                cmd.Parameters.AddWithValue("@Fecha", dtm_fecha.Text);
              
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_total.DataSource = dt;
                Diseño_dgv(dgv_total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Diseño_dgv(DataGridView dgv)
        {
            dgv.Columns[0].Width = 160;//departamento
            dgv.Columns[1].Width = 43;//altas
            dgv.Columns[2].Width = 43;//bajas
            dgv.Columns[3].Width = 43;//total
            dgv.Columns[4].Width = 43;//=a/c
            dgv.Columns[5].Width = 43;//=a/b
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
                for (int i = -1; i < dgv_total.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_total.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_total.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_total.Rows[i].Cells[j].Value.ToString();
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

        private void nuevo()
        {
           dtm_fecha.Text = "";
           cmb_ant.Text = "";
           cmb_ant2.Text = "";
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Var = 1;
            Llenar_dgv_total();
            Calcula_Total();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Btn_exportar_total_Click(object sender, EventArgs e)
        {
            Exportara_Exel();
        }
    }
}
