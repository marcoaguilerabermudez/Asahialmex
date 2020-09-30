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
            lbl_total.Text = dgv_datos.Rows.Count.ToString();
            lbl_var.Visible = false;
            lbl_lector.Visible = false;
        }

 
        public void Mostrar_registros()// Mostrar registros checador
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Registro_checador]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", lbl_var.Text);
                cmd.Parameters.AddWithValue("@INICIA", dtm_inicia.Text);
                cmd.Parameters.AddWithValue("@TERMINA", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@LECTOR", lbl_lector.Text);

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
            Cursor = Cursors.WaitCursor;
            timer1.Start();
            Exportara_f_Excel();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {  
            DateTime Date = DateTime.Now.AddDays(-1);
            dtm_inicia.Text = Date.ToString();
            dtm_termina.Text = "";
            txt_clave.Text = "";
            lbl_var.Text = "1";
            Mostrar_registros();
            cmb_lector.Text = "";
            lbl_lector.Text = "000";
            lbl_total.Text = dgv_datos.Rows.Count.ToString();
            txt_clave.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            Cursor = Cursors.Default;
        }

        private void dtm_inicia_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            timer1.Start();
            lbl_var.Text = "2";
            Mostrar_registros();
            lbl_total.Text = dgv_datos.Rows.Count.ToString();

            if (cmb_lector.Text != "")
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                lbl_var.Text = "3";
                Mostrar_registros();
                lbl_total.Text = dgv_datos.Rows.Count.ToString();
            }
            if (cmb_lector.Text != "" || txt_clave.Text != "")
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                lbl_var.Text = "5";
                Mostrar_registros();
                lbl_total.Text = dgv_datos.Rows.Count.ToString();
            }
        }
        private void dtm_termina_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            timer1.Start();
            lbl_var.Text = "2";
            Mostrar_registros();
            lbl_total.Text = dgv_datos.Rows.Count.ToString();

            if (cmb_lector.Text != "")
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                lbl_var.Text = "3";
                Mostrar_registros();
                lbl_total.Text = dgv_datos.Rows.Count.ToString();
            }
            if (cmb_lector.Text != "" || txt_clave.Text != "")
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                lbl_var.Text = "5";
                Mostrar_registros();
                lbl_total.Text = dgv_datos.Rows.Count.ToString();
            }
        }

        private void cmb_lector_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_var.Text = "3";

            switch (cmb_lector.Text)
            {
                case "COMEDOR": lbl_lector.Text = "003"; break;
                case "FUNDICION 1": lbl_lector.Text = "006"; break;
                case "MAQUINADO 1": lbl_lector.Text = "007"; break;
                case "ENTRADA PERSONAL 1": lbl_lector.Text = "008"; break;
                case "ENTRADA PERSONAL 2": lbl_lector.Text = "009"; break;
            }
            Mostrar_registros();
            lbl_total.Text = dgv_datos.Rows.Count.ToString();

            if (txt_clave.Text != "")
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                lbl_var.Text = "5";
                Mostrar_registros();
                lbl_total.Text = dgv_datos.Rows.Count.ToString();
            }
        }

        private void cmb_lector_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            else { e.Handled = true; }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                lbl_var.Text = "4";
                Mostrar_registros();
                lbl_total.Text = dgv_datos.Rows.Count.ToString();

                if (cmb_lector.Text != "")
                {
                    Cursor = Cursors.WaitCursor;
                    timer1.Start();
                    lbl_var.Text = "5";
                    Mostrar_registros();
                    lbl_total.Text = dgv_datos.Rows.Count.ToString();
                }
            }
        }
    }
}
