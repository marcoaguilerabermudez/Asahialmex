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
    public partial class Frm_Listado_Altas : Form
    {
        public Frm_Listado_Altas()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "NUEVA BUSQUEDA");
            tt.SetToolTip(btn_buscar, "FILTRAR");
            tt.SetToolTip(btn_reporte, "REPORTE");
            tt.SetToolTip(btn_exportar, "EXPORTAR");

            timer1.Enabled = true;
        }

        public DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");
        int Var;

        private void Frm_Listado_Altas_Load(object sender, EventArgs e)
        {
            nuevo();
            Var = 0;
            Llenar_dgv();
            Diseño_dgv(dgv_altas);
            lbl_total.Text = dgv_altas.Rows.Count.ToString();
            dgv_altas.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv_altas.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            cargar_año(cmb_año);
            cargar_puesto(cmb_puesto);
            cargar_departemento(cmb_departamento);
            cmb_año.DropDownStyle = ComboBoxStyle.DropDownList;
            lbl_fecha.Visible = false;
        }
        private void nuevo()
        {
            cmb_año.Text = "";
            cmb_mes.Text = "";
            txt_semana.Text = "";
            cmb_departamento.Text = "";
            cmb_puesto.Text = "";
            cmb_mes.Enabled = false;
            txt_semana.Enabled = false;
            cmb_departamento.Enabled = false;
            cmb_puesto.Enabled = false;
            btn_buscar.Enabled = false;
        }
        public void cargar_departemento(ComboBox inte)//Cargar departamento en cmb
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select distinct DESCRIPCION_DEPTO from [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] order by DESCRIPCION_DEPTO", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["DESCRIPCION_DEPTO"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo departamento" + Error.ToString());
            }
        }
        public void cargar_puesto(ComboBox inte)//Cargar puesto CMB
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select distinct DESCRIPCION_PUESTO from [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] order by DESCRIPCION_PUESTO", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["DESCRIPCION_PUESTO"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo departamento" + Error.ToString());
            }
        }
        private void Diseño_dgv(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//No. Empleado
            dgv.Columns[1].Width = 210;//Nombre empleado
            dgv.Columns[2].Width = 160;//Departamento
            dgv.Columns[3].Width = 160;//Puesto
            dgv.Columns[4].Width = 80;//Fecha
            dgv.Columns[5].Width = 50;//Año
            dgv.Columns[6].Width = 80;//Mes
            dgv.Columns[7].Width = 60;//Semana
            dgv.Columns[8].Width = 50;//Genero
            dgv.Columns[9].Width = 110;//Estado
        }
        public void cargar_año(ComboBox inte)//Cargar año en cmb
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT  DATEPART (YEAR, (SELECT TOP 1 FECHA FROM [asahi16].[Supervisor_giro].[Empsdo] WHERE TIPO = 'A' AND V.CLAVE = CLAVE AND V.VIGENCIA = 'VIGENTE' AND FECHA IS NOT NULL AND TIPO IS NOT NULL  ORDER BY FECHA DESC )) AS 'AÑO'   FROM [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto]v  ORDER BY AÑO DESC", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["AÑO"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo año" + Error.ToString());
            }
        }
        private void Llenar_dgv()// Método para llenar DatagridView
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[FM_LISTADO_ALTAS]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", Var);
                cmd.Parameters.AddWithValue("@Año", cmb_año.Text);
                cmd.Parameters.AddWithValue("@Mes", cmb_mes.Text);
                cmd.Parameters.AddWithValue("@Semana", txt_semana.Text);
                cmd.Parameters.AddWithValue("@Departamento", cmb_departamento.Text);
                cmd.Parameters.AddWithValue("@Puesto", cmb_puesto.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Close();
                adapter.Fill(dt);
                dgv_altas.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
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
                int cellRowIndex = 1;
                int cellColumnIndex = 1;
                //Pasa por cada fila y lee el valor de cada columna.
                for (int i = 0; i < dgv_altas.Rows.Count - 0; i++)
                {
                    for (int j = 0; j < dgv_altas.Columns.Count - 0; j++)
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 0)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_altas.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_altas.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                //Obtener la ubicación y el nombre de archivo de excel para guardar del usuario.
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Libro de Excel (*.xlsx)|*.xlsx";
                saveDialog.FilterIndex = 2;

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
        private void Btn_exportar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_año.Text))
            {
                //Todo el reporte

                DialogResult dialogo = MessageBox.Show("¿Desea exportar todas las bajas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    Exportara_Exel();
                }
                else
                {
                }
            }
            else
            {
                Exportara_Exel();
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            Var = 0;
            Llenar_dgv();
            lbl_total.Text = dgv_altas.Rows.Count.ToString();

        }
        private void Dgv_altas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_altas.Columns[e.ColumnIndex].Name == "ESTADO")
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Txt_semana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Cmb_mes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Cmb_año_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_año.Text))
            {
            }
            else
            {
                btn_buscar.Enabled = true;
                cmb_mes.Enabled = true;
                txt_semana.Enabled = true;
                cmb_departamento.Enabled = true;
                cmb_puesto.Enabled = true;
            }
        }

        private void Cmb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_mes.Text))
            {
            }
            else
            {
                txt_semana.Enabled = false;
                txt_semana.Text = "";
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //  MessageBox.Show("Filtro por año 3");
                Var = 3;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();
       ;
            }

            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //  MessageBox.Show("Filtro por año y mes 1");
                Var = 1;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //  MessageBox.Show("Filtro por año y semana 2");
                Var = 2;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //  MessageBox.Show("Filtro por año y departamento 4");
                Var = 4;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                //MessageBox.Show("Filtro por año y puesto 5");
                Var = 5;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //MessageBox.Show("Filtro por año mes y departamento 6");
                Var = 6;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                //MessageBox.Show("Filtro por año, mes y puesto 7");
                Var = 7;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //MessageBox.Show("Filtro por año, semana y departamento 8");
                Var = 8;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();

            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                // MessageBox.Show("Filtro  por año, semana y puesto 9");
                Var = 9;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text))
            {
                //MessageBox.Show("Filtro  por año, departamento y puesto 10");
                Var = 10;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text))
            {
                //  MessageBox.Show("Filtro  por año, mes, departamento y puesto 11");
                Var = 11;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text))
            {
                //MessageBox.Show("Filtro  por año, semana, departamento  y puesto  12");
                Var = 12;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_altas.Rows.Count.ToString();
            }
        }


        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_año.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //Todo el reporte
                DialogResult dialogo = MessageBox.Show("¿Desea generar reporte de todas las altas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    Frm_Reporte_altas rep = new Frm_Reporte_altas();
                    rep.Var = Convert.ToInt32(0);
                    rep.ShowDialog();
                }
                else
                {
                }
            }

            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //  MessageBox.Show("Filtro por año 3");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(3);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.ShowDialog();
            }

            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //  MessageBox.Show("Filtro por año y mes 1");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(1);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //  MessageBox.Show("Filtro por año y semana 2");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(2);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text);
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //  MessageBox.Show("Filtro por año y departamento 4");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(4);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Departamento = cmb_departamento.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                //MessageBox.Show("Filtro por año y puesto 5");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(5);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //MessageBox.Show("Filtro por año mes y departamento 6");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(6);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.Departamento = cmb_departamento.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                //MessageBox.Show("Filtro por año, mes y puesto 7");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(7);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                //MessageBox.Show("Filtro por año, semana y departamento 8");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(8);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text); ;
                rep.Departamento = cmb_departamento.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                // MessageBox.Show("Filtro  por año, semana y puesto 9");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(9);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text); ;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text))
            {
                //MessageBox.Show("Filtro  por año, departamento y puesto 10");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(10);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text))
            {
                //  MessageBox.Show("Filtro  por año, mes, departamento y puesto 11");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(11);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text))
            {
                //MessageBox.Show("Filtro  por año, semana, departamento  y puesto  12");
                Frm_Reporte_altas rep = new Frm_Reporte_altas();
                rep.Var = Convert.ToInt32(12);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text);
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
        }
    }
}
