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
    public partial class Frm_Credenciales : Form
    {
        public Frm_Credenciales()
        {
            InitializeComponent();
            timer1.Enabled = true;
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "NUEVO");
            tt.SetToolTip(btn_agregar, "AGREGA CREDENCIAL");
            tt.SetToolTip(btn_reporte, "GENERA CREDENCIALES");
            tt.SetToolTip(btn_eliminar, "ELIMINAR");
        }


        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        private void Frm_Credenciales_Load(object sender, EventArgs e)
        {
            nuevo();
            btn_eliminar.Enabled = false;
            btn_reporte.Enabled = false;
        }

        private void cargar_informacion()
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[FM_INFORMACION_EMPLEADO]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Emp", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txt_nombre.Text = dt.Rows[0]["NOMBRE_EMPLEADO"].ToString();
                txt_referencia.Text = dt.Rows[0]["CONTACTO"].ToString();
                txt_telefono_referencia.Text = dt.Rows[0]["TEl_CONTACTO"].ToString();
                txt_departamento.Text = dt.Rows[0]["DEPARTAMENTO"].ToString();
                txt_puesto.Text = dt.Rows[0]["PUESTO"].ToString();
                txt_rfc.Text = dt.Rows[0]["RFC"].ToString();
                txt_afiliacion.Text = dt.Rows[0]["AFILIACION"].ToString();
                txt_curp.Text = dt.Rows[0]["CURP"].ToString();
                dtm_nacimiento.Text = dt.Rows[0]["NACIMIENTO"].ToString();
                txt_vigencia.Text = dt.Rows[0]["VIGENCIA"].ToString();

                txt_clave.Enabled = false;
            }
            con.Close();
        }

        private void insertar()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Credencial_Empleados(CLAVE, NOMBRE, REFERENCIA, TEL_REFERENCIA, DEPARTAMENTO, PUESTO, AFILIACION, FECHA_NACIMIENTO, FECHA) VALUES (" + txt_clave.Text + ", '" + txt_nombre.Text + "', '" + txt_referencia.Text + "', '" + txt_telefono_referencia.Text + "',  '" + txt_departamento.Text + "', '" + txt_puesto.Text + "','" + txt_afiliacion.Text + "', '" + dtm_nacimiento.Text + "', '" + lbl_fecha.Text + "')", con); 
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Se agregó correctamente.");
                nuevo();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se insertó. " + error.Message);
            }
        }
        private void Eliminar()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Credencial_Empleados where Id_Credencial = @id", con);
                cmd.Parameters.AddWithValue("@id", lbl_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Se eliminó correctamente.");
                nuevo();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se eliminó" + error.Message);
            }
        }


        private void Mostrar_Grid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [Id_Credencial]AS 'ID'  ,RTRIM(CLAVE)AS 'CLAVE' ,RTRIM(NOMBRE)AS 'NOMBRE' ,RTRIM(REFERENCIA)AS 'REFERENCIA' ,RTRIM(TEL_REFERENCIA)AS 'TELEFONO' ,RTRIM(DEPARTAMENTO)AS 'DEPARTAMENTO' ,RTRIM(PUESTO)AS 'PUESTO' ,RTRIM(AFILIACION) AS 'AFILIACION',[FECHA_NACIMIENTO] AS 'FECHA_NAC' ,[FECHA]  FROM [asahi16].[dbo].[Credencial_Empleados] WHERE FECHA = @Fecha", con);
               // cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha", lbl_fecha.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_credenciales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nuevo()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                    ctrl.Enabled = false;
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.Text = "";
                    ctrl.Enabled = false;
                }
            }
            dtm_nacimiento.Text = "";
            dtm_nacimiento.Enabled = false;
            txt_clave.Text = "";
            txt_clave.Enabled = true;
            txt_clave.Focus();
            btn_agregar.Enabled = false;
            pictureBox1.ImageLocation = "V:/Sistemas/Listado de bajas/LogoFinal" + ".png";
            lbl_fecha.Visible = false;
            lbl_id.Text = "";
            lbl_id.Visible = false;
            lbl_total.Enabled = false;
        }

        private void Diseño_Grid(DataGridView dgv)
        {
            dgv.Columns[0].Width = 00;
            dgv.Columns[1].Width = 50;
            dgv.Columns[2].Width = 200;
            dgv.Columns[3].Width = 200;
            dgv.Columns[4].Width = 100;
            dgv.Columns[5].Width = 100;
            dgv.Columns[6].Width = 100;
            dgv.Columns[7].Width = 80;
            dgv.Columns[8].Width = 80;
            dgv.Columns[9].Width = 80;
        }

        private void Txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cargar_informacion();

                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";

                txt_vigencia.Visible = true;
                lbl_estado.Visible = true;
              

                if (txt_vigencia.Text == "VIGENTE")
                {
                    btn_agregar.Enabled = true;
                }
                else if (txt_vigencia.Text == "BAJA")
                {
                    btn_agregar.Enabled = false;
                }
                else
                {
                  
                    pictureBox1.ImageLocation = "V:/Sistemas/Listado de bajas/LogoFinal" + ".png";
                }
            }
        }



        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void Btn_baja_Click(object sender, EventArgs e)//Botón agregar a reporte
        {
            insertar();
            Mostrar_Grid();
            Diseño_Grid(dgv_credenciales);
            btn_reporte.Enabled = true;
            btn_eliminar.Enabled = true;
            lbl_total.Text = dgv_credenciales.Rows.Count.ToString();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Dgv_credenciales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_credenciales.Rows[e.RowIndex];
                lbl_id.Text = row.Cells["ID"].Value.ToString();
                txt_clave.Text = row.Cells["CLAVE"].Value.ToString();
                txt_nombre.Text = row.Cells["NOMBRE"].Value.ToString();
                txt_referencia.Text = row.Cells["REFERENCIA"].Value.ToString();
                txt_telefono_referencia.Text = row.Cells["TELEFONO"].Value.ToString();
                txt_departamento.Text = row.Cells["DEPARTAMENTO"].Value.ToString();
                txt_puesto.Text = row.Cells["PUESTO"].Value.ToString();
                dtm_nacimiento.Text = row.Cells["FECHA_NAC"].Value.ToString();
                txt_afiliacion.Text = row.Cells["AFILIACION"].Value.ToString();
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            nuevo();
            Mostrar_Grid();
            Diseño_Grid(dgv_credenciales);
            lbl_total.Text = dgv_credenciales.Rows.Count.ToString();

            int x, y;
            x = int.Parse(lbl_total.Text);
            y = int.Parse("1");
            if (x < y)
            {
                btn_eliminar.Enabled = false;
                btn_reporte.Enabled = false;
            }
            else
            {
                btn_eliminar.Enabled = true;
                btn_reporte.Enabled = true;
            }
        }
    }
}
