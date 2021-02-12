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
    public partial class Frm_Ausentismo_Fecha : Form
    {
        public Frm_Ausentismo_Fecha()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");
        int Var;

        private void Frm_Ausentismo_Fecha_Load(object sender, EventArgs e)
        {
            selecciona_Fecha();
            Var = 1;
            Llenar_dgv();
            nuevo();
            dgv_ausentismo.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
           dgv_ausentismo.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            Calcula_Total();
            txt_depto.Visible = false;
        }

//Métodos
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
                for (int i = -1; i < dgv_ausentismo.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_ausentismo.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_ausentismo.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_ausentismo.Rows[i].Cells[j].Value.ToString();
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
        public void Llenar_dgv()// Método para llenar DatagridView Total
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ausentismo_Fecha]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", Var);
                cmd.Parameters.AddWithValue("@Inicia", dtm_inicia.Text);
                cmd.Parameters.AddWithValue("@Termina", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@Depto", dtm_termina.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_ausentismo.DataSource = dt;
               Diseño_dgv(dgv_ausentismo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Diseño_dgv(DataGridView dgv)
        {
            dgv.Columns[0].Width = 170;//departamento
            dgv.Columns[1].Width = 50;//plan
            dgv.Columns[2].Width = 50;//
            dgv.Columns[3].Width = 60;//
            dgv.Columns[4].Width = 70;//
            dgv.Columns[5].Width = 70;//
            dgv.Columns[6].Width = 70;//
            dgv.Columns[7].Width = 70;//
            dgv.Columns[8].Width = 50;//
            dgv.Columns[9].Width = 50;//
            dgv.Columns[10].Width = 50;//
            dgv.Columns[11].Width = 50;//
            dgv.Columns[12].Width = 50;//
            dgv.Columns[13].Width = 50;//
            dgv.Columns[14].Width = 50;//
            dgv.Columns[15].Width = 50;//
        }
        private void nuevo()
        {
            selecciona_Fecha();
            lbl_rep.Text = "REPORTE DEL MES";
            Var = 1;
            Llenar_dgv();
        }
        private void Calcula_Total()
        {
            double Plan = 0;
            double Inicia = 0;
            double Termina = 0;
            double Falta_injus = 0;
            double Falta_just = 0;
            double Permiso_cg = 0;
            double Permiso_sg = 0;
            double Susp = 0;
            double incap = 0;
            double Vac = 0;
            double Admin = 0;
            double T1 = 0;
            double T2 = 0;
            double T3 = 0;
            double Total = 0;

            foreach (DataGridViewRow row in dgv_ausentismo.Rows)
            {
                Plan += Convert.ToDouble(row.Cells["PLAN"].Value);
                Inicia += Convert.ToDouble(row.Cells["INICIA"].Value);
                Termina += Convert.ToDouble(row.Cells["TERMINA"].Value);
                Falta_injus += Convert.ToDouble(row.Cells["FALTA INJUS"].Value);
                Falta_just += Convert.ToDouble(row.Cells["FALTA JUST"].Value);
                Permiso_cg += Convert.ToDouble(row.Cells["PERMISO CON GOCE"].Value);
                Permiso_sg += Convert.ToDouble(row.Cells["PERMISO SIN GOCE"].Value);
                Susp += Convert.ToDouble(row.Cells["SUSP"].Value);
                incap += Convert.ToDouble(row.Cells["INCAP"].Value);
                Vac += Convert.ToDouble(row.Cells["VAC"].Value);
                Admin += Convert.ToDouble(row.Cells["ADMIN"].Value);
                T1 += Convert.ToDouble(row.Cells["T1"].Value);
                T2 += Convert.ToDouble(row.Cells["T2"].Value);
                T3 += Convert.ToDouble(row.Cells["T3"].Value);
                Total += Convert.ToDouble(row.Cells["TOTAL"].Value);
            }
            lbl_plan.Text = Convert.ToString(Plan);
            lbl_inicia.Text = Convert.ToString(Inicia);
            lbl_termina.Text = Convert.ToString(Termina);
            lbl_f_injust.Text = Convert.ToString(Falta_injus);
            lbl_f_just.Text = Convert.ToString(Falta_just);
            lbl_permiso_cg.Text = Convert.ToString(Permiso_cg);
            lbl_permiso_sg.Text = Convert.ToString(Permiso_sg);
            lbl_susp.Text = Convert.ToString(Susp);
            lbl_incap.Text = Convert.ToString(incap);
            lbl_vac.Text = Convert.ToString(Vac);
            lbl_admin.Text = Convert.ToString(Admin);
            lbl_t1.Text = Convert.ToString(T1);
            lbl_t2.Text = Convert.ToString(T2);
            lbl_t3.Text = Convert.ToString(T3);
            lbl_total.Text = Convert.ToString(Total);
        }

        private void selecciona_Fecha()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "(SELECT DATEADD(m, DATEDIFF(m,0, GETDATE()), 0)as 'Inicia')";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
               // da.SelectCommand.Parameters.Add("@Puesto", SqlDbType.VarChar).Value = cmb_puesto.Text;
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    dtm_inicia.Text = dt.Rows[0]["Inicia"].ToString();
                }      
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el sueldo");
            }
        }
        //Botones
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }
        private void Btn_exportar_ant2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            timer1.Start();
            Exportara_Exel();
        }
        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            timer1.Start();
            Ausentismos_Fecha rep = new Ausentismos_Fecha();
            rep.Var = Convert.ToInt32(0);
            rep.Inicia = dtm_inicia.Value;
            rep.Termina = dtm_termina.Value;
            rep.Depto = txt_depto.Text.ToString();
            rep.Show();
        }

//Eventos
        private void Dgv_ausentismo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_ausentismo.Columns[e.ColumnIndex].Name == "TOTAL")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                }
            }
            else if (this.dgv_ausentismo.Columns[e.ColumnIndex].Name == "T1")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = Color.AliceBlue;
                }
            }
            else if (this.dgv_ausentismo.Columns[e.ColumnIndex].Name == "T2")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = Color.AliceBlue;
                }
            }
            else if (this.dgv_ausentismo.Columns[e.ColumnIndex].Name == "T3")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = Color.AliceBlue;
                }
            }
            else if (this.dgv_ausentismo.Columns[e.ColumnIndex].Name == "ADMIN")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = Color.AliceBlue;
                }
            }
        }

        private void Dtm_termina_ValueChanged(object sender, EventArgs e)
        {
            //Cursor = Cursors.WaitCursor;
            //timer1.Start();
            //Var = 2;
            //Llenar_dgv();
            //Calcula_Total();
            //lbl_rep.Text = "";
        }

        private void Dgv_ausentismo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_ausentismo.Rows[e.RowIndex];
                txt_depto.Text = row.Cells["DEPARTAMENTO"].Value.ToString();
            }
        }
        private void Dgv_ausentismo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_ausentismo.Rows[e.RowIndex];
                txt_depto.Text = row.Cells["DEPARTAMENTO"].Value.ToString();      
            }
        }

        private void Dgv_ausentismo_DoubleClick(object sender, EventArgs e)
        {
            Detalle_incidencias inc = new Detalle_incidencias();
            inc.lbl_var.Text = "3";
            inc.dtm_inicia.Text = dtm_inicia.Text;
            inc.dtm_termina.Text = dtm_termina.Text;
            inc.txt_depto.Text = txt_depto.Text;
            inc.ShowDialog();
        }
        private void Dtm_inicia_ValueChanged(object sender, EventArgs e)
        {
            //Cursor = Cursors.WaitCursor;
            //timer1.Start();
            //Var = 2;
            //Llenar_dgv();
            //Calcula_Total();
            //lbl_rep.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            Cursor = Cursors.Default;
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            timer1.Start();
            Var = 2;
            Llenar_dgv();
            Calcula_Total();
            lbl_rep.Text = "";
        }
    }
}
