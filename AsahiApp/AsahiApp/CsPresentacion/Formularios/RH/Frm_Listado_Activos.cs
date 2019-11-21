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
    public partial class Frm_Listado_Activos : Form
    {
        public Frm_Listado_Activos()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "NUEVA BUSQUEDA");
            tt.SetToolTip(btn_reporte, "GENERA REPORTE");
            tt.SetToolTip(btn_exportar, "EXPORTAR A EXCEL");
        }

        public DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");
        int Var = 0;

        private void Frm_Listado_Activos_Load(object sender, EventArgs e)
        {
            cargar_departemento(cmb_departamento);
            cargar_puesto(cmb_puesto);
            nuevo();
            Llenar_dgv();
            Diseño_dgv(dgv_activos);
            lbl_total.Text = dgv_activos.Rows.Count.ToString();
            dgv_activos.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv_activos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
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
                for (int i = -1; i < dgv_activos.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_activos.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_activos.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_activos.Rows[i].Cells[j].Value.ToString();
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


        public void cargar_departemento(ComboBox inte)//Cargar departamento en cmb
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT RTRIM(DESCRIPCION)as 'DEPARTAMENTO' FROM  [asahi16].[Supervisor_giro].[DEPTO] WHERE CENTRO_COSTO <>16 and RTRIM(DESCRIPCION) <> 'PRESIDENCIA' ORDER BY DEPARTAMENTO ASC", con);
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

        private void Llenar_dgv()// Método para llenar DatagridView
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[FM_LISTADO_ACTIVOS]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", Var);
                cmd.Parameters.AddWithValue("@Departamento", cmb_departamento.Text);
                cmd.Parameters.AddWithValue("@Puesto", cmb_puesto.Text);
                cmd.Parameters.AddWithValue("@Ant1", lbl_Ant1.Text);
                cmd.Parameters.AddWithValue("@Ant2", lbl_Ant2.Text);
                cmd.Parameters.AddWithValue("@Genero", cmb_genero.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                con.Close();
                adapter.Fill(dt);
                dgv_activos.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void Diseño_dgv(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//No. Empleado
            dgv.Columns[1].Width = 210;//Nombre empleado
            dgv.Columns[2].Width = 160;//Departamento
            dgv.Columns[3].Width = 160;//Puesto
            dgv.Columns[4].Width = 80;//ingreso
            dgv.Columns[5].Width = 160;//Antigüedad
            dgv.Columns[6].Width = 50;//dias
            dgv.Columns[7].Width = 50;//meses
            dgv.Columns[8].Width = 50;//Años
            dgv.Columns[9].Width = 50;//Genero
        }

        private void nuevo()
        {
            cmb_departamento.Text = "";
            cmb_puesto.Text = "";
            cmb_ant.Text = "";
            cmb_genero.Text = "";
            lbl_Ant1.Text = "0";
            lbl_Ant2.Text = "0";
            lbl_Var.Text = "0";
            lbl_Ant1.Visible = false;
            lbl_Ant2.Visible = false;
            lbl_Var.Visible = false; 
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
            }
            else
            {
                nuevo();
                Var = 0;
                lbl_Var.Text = "0";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
        }

        private void Cmb_ant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ant.Text == "MENOS DE DOS SEMANAS")
            {
                lbl_Ant1.Text = "0";
                lbl_Ant2.Text = "15";
            }
            else if (cmb_ant.Text == "DOS SEMANAS A UN MES")
            {
                lbl_Ant1.Text = "16";
                lbl_Ant2.Text = "30";
            }
            else if (cmb_ant.Text == "UN MES A TRES MESES")
            {
                lbl_Ant1.Text = "31";
                lbl_Ant2.Text = "90";
            }
            else if (cmb_ant.Text == "TRES MESES A SEIS MESES")
            {
                lbl_Ant1.Text = "91";
                lbl_Ant2.Text = "180";
            }
            else if (cmb_ant.Text == "SEIS MESES A UN AÑO")
            {
                lbl_Ant1.Text = "181";
                lbl_Ant2.Text = "365";
            }
            else if (cmb_ant.Text == "UN AÑO A DOS AÑOS")
            {
                lbl_Ant1.Text = "366";
                lbl_Ant2.Text = "732";
            }
            else if (cmb_ant.Text == "MAS DE DOS AÑOS")
            {
                lbl_Ant1.Text = "733";
                lbl_Ant2.Text = "1000000000";
            }


            if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 1;
                lbl_Var.Text = "1";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 2;
                lbl_Var.Text = "2";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 3;
                lbl_Var.Text = "3";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 4;
                lbl_Var.Text = "4";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 5;
                lbl_Var.Text = "5";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 6;
                lbl_Var.Text = "6";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }

            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 7;
                lbl_Var.Text = "7";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 8;
                lbl_Var.Text = "8";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 9;
                lbl_Var.Text = "9";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Var = 10;
                lbl_Var.Text = "10";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 11;
                lbl_Var.Text = "11";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 12;
                lbl_Var.Text = "12";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Var = 13;
                lbl_Var.Text = "13";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Var = 14;
                lbl_Var.Text = "14";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else
            {
                Var = 15;
                lbl_Var.Text = "15";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }

        }

        private void Btn_exportar_Click(object sender, EventArgs e)
        {
            Exportara_Exel();
        }

        private void Cmb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 1;
                lbl_Var.Text = "1";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 2;
                lbl_Var.Text = "2";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 3;
                lbl_Var.Text = "3";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 4;
                lbl_Var.Text = "4";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 5;
                lbl_Var.Text = "5";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 6;
                lbl_Var.Text = "6";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }

            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 7;
                lbl_Var.Text = "7";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 8;
                lbl_Var.Text = "8";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 9;
                lbl_Var.Text = "9";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Var = 10;
                lbl_Var.Text = "10";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 11;
                lbl_Var.Text = "11";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 12;
                lbl_Var.Text = "12";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Var = 13;
                lbl_Var.Text = "13";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Var = 14;
                lbl_Var.Text = "14";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else
            {
                Var = 15;
                lbl_Var.Text = "15";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
           
           
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(0);
                rep.Show();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(1);
                rep.Departamento = cmb_departamento.Text;
                rep.Show();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(2);
                rep.Departamento = cmb_departamento.Text;
                rep.Show();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(3);
                rep.Ant1 = Convert.ToInt32(lbl_Ant1.Text);
                rep.Ant2 = Convert.ToInt32(lbl_Ant2.Text);
                rep.Show();

            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(4);
                rep.Genero = cmb_genero.Text;
                rep.Show();
            }
            else if (string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(5);
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.Show();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(6);
                rep.Departamento = cmb_departamento.Text;
                rep.Ant1 = Convert.ToInt32(lbl_Ant1.Text);
                rep.Ant2 = Convert.ToInt32(lbl_Ant2.Text);
                rep.Show();
            }

            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(7);
                rep.Departamento = cmb_departamento.Text;
                rep.Genero = cmb_genero.Text;
                rep.Show();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(8);
                rep.Puesto = cmb_puesto.Text;
                rep.Ant1 = Convert.ToInt32(lbl_Ant1.Text);
                rep.Ant2 = Convert.ToInt32(lbl_Ant2.Text);
                rep.Show();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(9);
                rep.Puesto = cmb_puesto.Text;
                rep.Genero = cmb_genero.Text;
                rep.Show();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(10);
                rep.Ant1 = Convert.ToInt32(lbl_Ant1.Text);
                rep.Ant2 = Convert.ToInt32(lbl_Ant2.Text);
                rep.Genero = cmb_genero.Text;
                rep.Show();
            }
            else if (string.IsNullOrEmpty(cmb_genero.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(11);
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.Ant1 = Convert.ToInt32(lbl_Ant1.Text);
                rep.Ant2 = Convert.ToInt32(lbl_Ant2.Text);
                rep.Show();
            }
            else if (string.IsNullOrEmpty(cmb_ant.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(12);
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.Genero = cmb_genero.Text;
                rep.Show();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(13);
                rep.Departamento = cmb_departamento.Text;
                rep.Ant1 = Convert.ToInt32(lbl_Ant1.Text);
                rep.Ant2 = Convert.ToInt32(lbl_Ant2.Text);
                rep.Genero = cmb_genero.Text;
                rep.Show();
            }

            else if (string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(14);
                rep.Puesto = cmb_puesto.Text;
                rep.Ant1 = Convert.ToInt32(lbl_Ant1.Text);
                rep.Ant2 = Convert.ToInt32(lbl_Ant2.Text);
                rep.Genero = cmb_genero.Text;
                rep.Show();
            }
            else
            {
                Listado_Activos rep = new Listado_Activos();
                rep.Var = Convert.ToInt32(15);
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.Ant1 = Convert.ToInt32(lbl_Ant1.Text);
                rep.Ant2 = Convert.ToInt32(lbl_Ant2.Text);
                rep.Genero = cmb_genero.Text;
                rep.Show();
            }
        }
        private void Dgv_activos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Cmb_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 1;
                lbl_Var.Text = "1";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 2;
                lbl_Var.Text = "2";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 3;
                lbl_Var.Text = "3";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 4;
                lbl_Var.Text = "4";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 5;
                lbl_Var.Text = "5";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 6;
                lbl_Var.Text = "6";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }

            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 7;
                lbl_Var.Text = "7";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 8;
                lbl_Var.Text = "8";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 9;
                lbl_Var.Text = "9";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Var = 10;
                lbl_Var.Text = "10";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 11;
                lbl_Var.Text = "11";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 12;
                lbl_Var.Text = "12";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Var = 13;
                lbl_Var.Text = "13";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Var = 14;
                lbl_Var.Text = "14";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else
            {
                Var = 15;
                lbl_Var.Text = "15";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
        }

        private void Cmb_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 1;
                lbl_Var.Text = "1";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 2;
                lbl_Var.Text = "2";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 3;
                lbl_Var.Text = "3";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 4;
                lbl_Var.Text = "4";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_ant.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 5;
                lbl_Var.Text = "5";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 6;
                lbl_Var.Text = "6";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }

            else if (string.IsNullOrEmpty(cmb_puesto.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 7;
                lbl_Var.Text = "7";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 8;
                lbl_Var.Text = "8";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 9;
                lbl_Var.Text = "9";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Var = 10;
                lbl_Var.Text = "10";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_genero.Text))
            {
                Var = 11;
                lbl_Var.Text = "11";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_ant.Text))
            {
                Var = 12;
                lbl_Var.Text = "12";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Var = 13;
                lbl_Var.Text = "13";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Var = 14;
                lbl_Var.Text = "14";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
            else
            {
                Var = 15;
                lbl_Var.Text = "15";
                Llenar_dgv();
                lbl_total.Text = dgv_activos.Rows.Count.ToString();
            }
        }
    }
}
