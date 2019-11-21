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
    public partial class Detalle_incidencias : Form
    {
        public Detalle_incidencias()
        {
            InitializeComponent();
        }

        int Var;
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        private void Detalle_incidencias_Load(object sender, EventArgs e)
        {
            if (lbl_var.Text == "4")
            {
                Llenar_dgv();
            }
            else if (lbl_var.Text == "3")
            {
                Llenar_dgv_fecha();
            }
           
            dtm_fecha.Visible = false;
            txt_depto.Visible = false;
            txt_clave.Enabled = false;
            dtm_inicia.Visible = false;
            dtm_termina.Visible = false;
            lbl_var.Visible = false;
            dgv_detalle.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv_detalle.AlternatingRowsDefaultCellStyle.BackColor = Color.White;  
        }
//Metodos
        public void Llenar_dgv()// Método para llenar DatagridView 
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ausentismo_Global]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", lbl_var.Text);
                cmd.Parameters.AddWithValue("@Fecha", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@Depto", txt_depto.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
               dgv_detalle.DataSource = dt;
               Diseño_dgv(dgv_detalle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Llenar_dgv_fecha()// Método para llenar DatagridView 
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ausentismo_Fecha]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", lbl_var.Text);
                cmd.Parameters.AddWithValue("@Inicia", dtm_inicia.Text);
                cmd.Parameters.AddWithValue("@Termina", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@Depto", txt_depto.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_detalle.DataSource = dt;
                Diseño_dgv(dgv_detalle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Diseño_dgv(DataGridView dgv)
        {
            dgv.Columns[0].Width = 50;//CLAVE
            dgv.Columns[1].Width = 190;//NOMBRE
            dgv.Columns[2].Width = 170;//depto
            dgv.Columns[3].Width = 140;//puesto
            dgv.Columns[4].Width = 80;//inicia
            dgv.Columns[5].Width = 80;//termina
            dgv.Columns[6].Width = 140;//tipo
            dgv.Columns[7].Width = 50;//dur
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
                for (int i = -1; i < dgv_detalle.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_detalle.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_detalle.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_detalle.Rows[i].Cells[j].Value.ToString();
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

//Eventos
        private void Dgv_detalle_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_detalle.Rows[e.RowIndex];
                txt_clave.Text = row.Cells["CLAVE"].Value.ToString();
                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
            }
        }
//Botones
        private void Btn_exportar_Click(object sender, EventArgs e)
        {
            Exportara_Exel();
        }
    }
}
