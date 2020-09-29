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
    public partial class Frm_Registros : Form
    {
        public Frm_Registros()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataReader dr;
        Empleado claseEmp;
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");


        private void Frm_Registros_Load(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now.AddDays(-1);
            dtm_inicia.Text = Date.ToString();
            Mostrar_registros();
        }

        private void Mostrar_registros()//Mostrar grid faltas.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Registro_checador]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", lbl_var.Text); 
                cmd.Parameters.AddWithValue("@INICIA", dtm_inicia.Text);
                cmd.Parameters.AddWithValue("@TERMINA", dtm_inicia.Text);
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_datos.DataSource = dt;
                Diseño_Grid(dgv_datos);
                dgv_datos.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dgv_datos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Diseño_Grid(DataGridView dgv)//Diseño de Grid
        {
            dgv.Columns[0].Width = 60;//Clave
            dgv.Columns[1].Width = 220;//Nombre
            dgv.Columns[2].Width = 150;//Departamento
            dgv.Columns[3].Width = 130;//Fecha
            dgv.Columns[4].Width = 130;//Lector
            dgv.Columns[5].Width = 70;//Tipo
        }

        private void Exportara_f_Excel()// Método para exportar a excel.
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

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            Exportara_f_Excel();
        }
    }
}
