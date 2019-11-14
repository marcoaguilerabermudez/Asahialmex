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
//using CrystalDecisions.CrystalReports.Engine;

namespace CsPresentacion
{
    public partial class m : Form
    {
        public m()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");
        int Var;
    
        private void Ausentismo_Global_Load(object sender, EventArgs e)
        {
            nuevo();
        }
//Botones
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {  
            nuevo();
        }
        private void Btn_exportar_ant2_Click(object sender, EventArgs e)
        {
            Exportara_Exel();
        }
 //Métodos
        private void Calcula_Total()
        {
            double Plan = 0;
            double Activos = 0;
            double Total = 0;
            double adtvo = 0;
            double turno1 = 0;
            double turno2 = 0;
            double turno3 = 0;
            foreach (DataGridViewRow row in dgv_acumulado.Rows)
            {
                Plan += Convert.ToDouble(row.Cells["PLAN"].Value);
                Activos += Convert.ToDouble(row.Cells["ACTIVOS"].Value);
                Total += Convert.ToDouble(row.Cells["TOTAL"].Value);
                adtvo += Convert.ToDouble(row.Cells["ADTVO."].Value);
                turno1 += Convert.ToDouble(row.Cells["TURNO 1"].Value);
                turno2 += Convert.ToDouble(row.Cells["TURNO 2"].Value);
                turno3 += Convert.ToDouble(row.Cells["TURNO 3"].Value);
            }
            lbl_plan.Text = Convert.ToString(Plan);
            lbl_activos.Text = Convert.ToString(Activos);
            lbl_incidencias.Text = Convert.ToString(Total);
            lbl_adtvo.Text = Convert.ToString(adtvo);
            lbl_turno1.Text = Convert.ToString(turno1);
            lbl_turno2.Text = Convert.ToString(turno2);
            lbl_turno3.Text = Convert.ToString(turno3);
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
        public void Llenar_informacion()// Método para llenar  Total por departamento
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ausentismo_Global]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", 0);
                cmd.Parameters.AddWithValue("@Fecha", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@Depto", txt_depto.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    lbl_falta_injus.Text = dt.Rows[0]["FALTA INJUS."].ToString();
                    lbl_falta_just.Text = dt.Rows[0]["FALTA JUST."].ToString();
                    lbl_pcon_goce.Text = dt.Rows[0]["P. CON GOCE"].ToString();
                    lbl_psin_goce.Text = dt.Rows[0]["P. SIN GOCE"].ToString();
                    lbl_suspension.Text = dt.Rows[0]["SUSP"].ToString();
                    lbl_incapacidades.Text = dt.Rows[0]["INCAP"].ToString();
                    lbl_vacaciones.Text = dt.Rows[0]["VAC"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Llenar_informacion_totales()// Método para llenar  Total incidencias
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Ausentismo_Global]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", 3);
                cmd.Parameters.AddWithValue("@Fecha", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@Depto", txt_depto.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lbl_total_f_injustificadas.Text = dt.Rows[0]["FALTA INJUS."].ToString();
                    lbl_total_f_justificada.Text = dt.Rows[0]["FALTA JUST."].ToString();
                    lbl_total_p_congoce.Text = dt.Rows[0]["P. CON GOCE"].ToString();
                    lbl_total_p_singoce.Text = dt.Rows[0]["P. SIN GOCE"].ToString();
                    lbl_total_suspension.Text = dt.Rows[0]["SUSP"].ToString();
                    lbl_total_incapacidades.Text = dt.Rows[0]["INCAP"].ToString();
                    lbl_total_vacaciones.Text = dt.Rows[0]["VAC"].ToString();
                }
                con.Close();
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
        private void Diseño_dgv(DataGridView dgv)
        {
            dgv.Columns[0].Width = 170;//departamento
            dgv.Columns[1].Width = 50;//plan
            dgv.Columns[2].Width = 60;//activos
            dgv.Columns[3].Width = 60;//adtvo
            dgv.Columns[4].Width = 80;//Matutino
            dgv.Columns[5].Width = 80;//Vespertino
            dgv.Columns[6].Width = 80;//Nocturno
            dgv.Columns[7].Width = 60;//Total
        }
        private void nuevo()
        { //Reporte día de ayer
            var ayer = DateTime.Today.AddDays(-1);
            dtm_fecha.Text = ayer.ToString();
            lbl_reporte.Text = "REPORTE DIA DE AYER";
            Var = 2;
            Llenar_dgv();
            txt_depto.Visible = false;
            Calcula_Total();
            dgv_acumulado.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv_acumulado.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
//Eventos
        private void Dgv_acumulado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_acumulado.Rows[e.RowIndex];
                txt_depto.Text = row.Cells["DEPARTAMENTO"].Value.ToString();
            }
        }
        private void Dgv_acumulado_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_acumulado.Rows[e.RowIndex];
                txt_depto.Text = row.Cells["DEPARTAMENTO"].Value.ToString();
               Llenar_informacion();
                Llenar_informacion_totales();

                groupBox1.Text = txt_depto.Text.ToString();
            }
        }
        private void Dtm_fecha_ValueChanged(object sender, EventArgs e)
        {        
        }
        private void Dtm_fecha_ValueChanged_1(object sender, EventArgs e)
        {
            Var = 1;
            Llenar_dgv();
            Calcula_Total();
            lbl_reporte.Text = "";
        }
        private void Dgv_acumulado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_acumulado.Columns[e.ColumnIndex].Name == "TOTAL")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                }
            }
        }

        private void Dgv_acumulado_DoubleClick(object sender, EventArgs e)
        {
            Detalle_incidencias inc = new Detalle_incidencias();
            inc.lbl_var.Text = "4";
            inc.dtm_fecha.Text = dtm_fecha.Text;
            inc.txt_depto.Text = txt_depto.Text;
            inc.ShowDialog();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Rep_Ausentismo rep = new Rep_Ausentismo();
            rep.Var = Convert.ToInt32("5");
            rep.Fecha = dtm_fecha.Value;
            rep.Depto = txt_depto.Text.ToString();
            rep.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Reporte_test rep = new Reporte_test();
            //rep.Var = Convert.ToInt32("5");
            //rep.Fecha = dtm_fecha.Value;
            //rep.Depto = txt_depto.Text.ToString();
            //rep.ShowDialog();
        }
    }
}
