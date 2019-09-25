using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CsPresentacion
{
    public partial class Frm_Historico : Form
    {
        public Frm_Historico()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");
        int Var;

        private void Frm_Historico_Load(object sender, EventArgs e)
        {
            Var = 1;
            cargar_departemento(cmb_depto);
            Llenar_dgv();
            lbl_total.Text = dgv_historico.Rows.Count.ToString();
            dgv_historico.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv_historico.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        public void cargar_departemento(ComboBox inte)//Cargar departamento en cmb
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT RTRIM(DESCRIPCION)as 'DEPARTAMENTO' FROM  [asahi16].[Supervisor_giro].[DEPTO] WHERE CENTRO_COSTO <>16 and RTRIM(DESCRIPCION) <> 'PRESIDENCIA' ORDER BY DEPARTAMENTO ASC ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["DEPARTAMENTO"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo departamento" + Error.ToString());
            }
        }
        private void nuevo()
        {
            dtm_fecha.Text = "";
            cmb_depto.Text = "";
        }
        private void Llenar_dgv()// Método para llenar DatagridView
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_historico_personal]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", Var);
                cmd.Parameters.AddWithValue("@Fecha", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@Depto", cmb_depto.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_historico.DataSource = dt;
                Diseño_dgv(dgv_historico);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Diseño_dgv(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//No. Empleado
            dgv.Columns[1].Width = 200;//Nombre empleado
            dgv.Columns[2].Width = 162;//Departamento
            dgv.Columns[3].Width = 140;//Puesto
            dgv.Columns[4].Width = 75;//ingreso
            dgv.Columns[5].Width = 143;//antigüedad
            dgv.Columns[6].Width = 40;//Genero
            dgv.Columns[7].Width = 100;//estado
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void Dgv_historico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_historico.Columns[e.ColumnIndex].Name == "ESTADO")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    if ((e.Value.ToString().Contains("REINGRESO")))
                    {
                        e.CellStyle.BackColor = Color.IndianRed;
                    }
                    else
                    {
                    }
                }
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
                for (int i = -1; i < dgv_historico.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_historico.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_historico.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_historico.Rows[i].Cells[j].Value.ToString();
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


        private void Btn_buscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmb_depto.Text))
            {
                Var = 2;
                Llenar_dgv();
                lbl_total.Text = dgv_historico.Rows.Count.ToString();
            }
            else
            {
                Var = 3;
                Llenar_dgv();
                lbl_total.Text = dgv_historico.Rows.Count.ToString();
            }
        }

        private void Btn_exportar_Click(object sender, EventArgs e)
        {
            Exportara_Exel();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_depto.Text))
            {
                Frm_Rep_Historial h = new Frm_Rep_Historial();
                h.Var = Convert.ToInt32(2);
                h.Fecha = dtm_fecha.Value;
                h.Depto = cmb_depto.Text;
                h.Show();   
            }
            else
            {
                Frm_Rep_Historial h = new Frm_Rep_Historial();
                h.Var = Convert.ToInt32(3);
               h.Fecha = dtm_fecha.Value;
                h.Depto = cmb_depto.Text;
                h.Show();
            }
        }
    }
}
