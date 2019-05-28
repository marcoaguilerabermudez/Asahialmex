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
    public partial class Frm_Finiquito : Form
    {
        public Frm_Finiquito()
        {
            InitializeComponent();
            timer1.Enabled = true;
            var tt = new ToolTip();
            tt.SetToolTip(btn_buscar, "BUSCAR");
            tt.SetToolTip(btn_nuevo, "NUEVO");
            tt.SetToolTip(btn_eliminar, "ELIMINAR");
            tt.SetToolTip(btn_reporte, "REPORTE");
            tt.SetToolTip(btn_agregar, "AGREGAR");
        }

        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;User ID=sa;Password=Pa55word");
        SqlConnection con2 = new SqlConnection("data source =GIRO\\SQLEXPRESS ;initial catalog=AsahiSystem;user id=sa;password=Pa55word");

        
        private void Frm_Finiquito_Load(object sender, EventArgs e)
        {
            nuevo();
            cmb_dias.DropDownStyle = ComboBoxStyle.DropDownList;
            btn_reporte.Enabled = false;
            dgv_empleados.Visible = false;
        }

        private void Buscar()
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[Reporte_Pago_Finiquito]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con2);
            con2.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@No_empleado", SqlDbType.VarChar).Value = txt_clave.Text;
            da.Fill(dt);

            try
            {
                if (dt.Rows.Count > 0)
                {
                    txt_nombre.Text = dt.Rows[0]["EMPLEADO"].ToString();
                    txt_ingreso.Text = dt.Rows[0]["FECHA_INGRESO"].ToString();
                    txt_baja.Text = dt.Rows[0]["FECHA_BAJA"].ToString();
                    txt_afiliacion.Text = dt.Rows[0]["AFILIACION"].ToString();
                    txt_motivo.Text = dt.Rows[0]["CAUSA_BAJA"].ToString();
                    txt_departamento.Text = dt.Rows[0]["DEPARTAMENTO"].ToString();
                    txt_puesto.Text = dt.Rows[0]["PUESTO"].ToString();

                    cmb_dias.Enabled = true;
                    try
                    {
                        pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Nó nostró la imagen." + error.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Puede que el empleado no esté dado de baja o no exista, favor de verificar.", "Aviso");
                    pictureBox1.ImageLocation = "V:Sistemas/Sistema_Reporte_Pago_Finiquito/LogoFinal" + ".png";
                    txt_clave.Focus();
                }
                con2.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No mostró correo del responsable." + error.ToString());
            }
        }

        private void insertar()
        {
            try
            {
                con2.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Pago_finiquito(No_empleado, Fecha_ingreso, Fecha_baja, Motivo_baja, Dias_laborados, Fecha_reporte, Estado)VALUES ( " + txt_clave.Text + ", '" + txt_ingreso.Text + "', '" + txt_baja.Text + "', '" + txt_motivo.Text + "',  " + cmb_dias.Text + ", '" + lbl_fecha.Text + "', 'Consulta')", con2);
                cmd.ExecuteNonQuery();
                con2.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se insertó. " + error.Message);
            }
        }

        private void Mostrar_Grid()
        {
            try
            {
                con2.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Reporte_Pago_Finiquito_Agregar]", con2);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fecha_reporte", lbl_fecha.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con2.Close();
                adapter.Fill(dt);
                dgv_empleados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Eliminar()
        {
            try
            {
                con2.Open();
                string sql = "Delete from Pago_finiquito where id_finiquito = @id_finiquito ";
                SqlCommand cmd = new SqlCommand(sql, con2);
                cmd.Parameters.AddWithValue("@id_finiquito", lbl_id.Text);
                cmd.ExecuteNonQuery();
                con2.Close();
                MessageBox.Show("Datos eliminados correctamente. ");
            }
            catch (Exception error)
            {
                MessageBox.Show("No se eliminó " + error.Message);
            }
        }

        private void Diseño_Grid(DataGridView dgv)
        {
            dgv.Columns[0].Width = 00;
            dgv.Columns[1].Width = 50;
            dgv.Columns[2].Width = 170;
            dgv.Columns[3].Width = 75;
            dgv.Columns[4].Width = 75;
            dgv.Columns[5].Width = 75;
            dgv.Columns[6].Width = 100;
            dgv.Columns[7].Width = 80;
            dgv.Columns[8].Width = 140;
            dgv.Columns[9].Width = 60;
            dgv.Columns[10].Width = 00;
        }

        private void nuevo()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }

            txt_nombre.Enabled = false;
            txt_ingreso.Enabled = false;
            txt_baja.Enabled = false;
            txt_afiliacion.Enabled = false;
            txt_motivo.Enabled = false;
            txt_departamento.Enabled = false;
            txt_puesto.Enabled = false;
            cmb_dias.Text = "0";
            btn_agregar.Enabled = false;
            txt_clave.Text = "";
            btn_eliminar.Enabled = false;
            lbl_id.Visible = false;
            lbl_id.Text = "";
            lbl_estado.Visible = false;
            lbl_estado.Text = "";
            cmb_dias.Enabled = false;
            txt_clave.Focus();
            lbl_fecha.Visible = false;
            pictureBox1.ImageLocation = "V:Sistemas/Sistema_Reporte_Pago_Finiquito/LogoFinal" + ".png";
            lbl_total.Visible = false;
           
        }

        private void Cambiar_Estado()
        {
            try
            {
                con2.Open();
                string sql = "UPDATE  Pago_finiquito SET Estado = 'Impreso' WHERE Fecha_Reporte = @Fecha_reporte";
                SqlCommand cmd = new SqlCommand(sql, con2);
                cmd.Parameters.AddWithValue("@Fecha_reporte", lbl_fecha.Text);
                cmd.ExecuteNonQuery();
                con2.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se actualizó. " + error.Message);
            }
        }

        private void cmb_dias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_dias.Text))
            {
                btn_agregar.Enabled = false;
            }
            else
            {
                btn_agregar.Enabled = true;
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            insertar();
            Mostrar_Grid();
            Diseño_Grid(dgv_empleados);
            nuevo();
            dgv_empleados.Visible = true;
            btn_reporte.Enabled = true;
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Dgv_empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_empleados.Rows[e.RowIndex];
                lbl_id.Text = row.Cells["ID"].Value.ToString();
                txt_clave.Text = row.Cells["CLAVE"].Value.ToString();
                txt_nombre.Text = row.Cells["EMPLEADO"].Value.ToString();
                txt_ingreso.Text = row.Cells["F_INGRESO"].Value.ToString();
                txt_baja.Text = row.Cells["F_BAJA"].Value.ToString();
                txt_afiliacion.Text = row.Cells["AFILIACION"].Value.ToString();
                txt_departamento.Text = row.Cells["DEPARTAMENTO"].Value.ToString();
                txt_puesto.Text = row.Cells["PUESTO"].Value.ToString();
                txt_motivo.Text = row.Cells["CAUSA_BAJA"].Value.ToString();
                cmb_dias.Text = row.Cells["DIAS_LAB"].Value.ToString();
                lbl_estado.Text = row.Cells["Estado"].Value.ToString();
                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                cmb_dias.Enabled = false;
                btn_agregar.Enabled = false;
                btn_nuevo.Enabled = true;
                btn_eliminar.Enabled = true;
            }
            //if (this.dgv_datos.Columns[e.ColumnIndex].Name == "Eliminar")
            //{
            //    dgv_datos.Rows.Remove(dgv_datos.CurrentRow);
            //    nuevo();
            //}
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            Mostrar_Grid();
            Diseño_Grid(dgv_empleados);
            btn_eliminar.Enabled = false;
            nuevo();
            txt_clave.Text = "";
            txt_clave.Enabled = true;
            
            lbl_total.Text = dgv_empleados.Rows.Count.ToString();
           if ( lbl_total.Text == ("0"))
            {
                btn_reporte.Enabled = false;
                dgv_empleados.Visible = false;
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void Cmb_dias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btn_agregar.Enabled = true;
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
        }
        private void Txt_clave_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_clave.Text))
            {
                btn_buscar.Enabled = false;
            }
            else
            {
                btn_buscar.Enabled = true;
            }
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Rep_Finiquito rep = new Rep_Finiquito();
            rep.ShowDialog();
            Cambiar_Estado();
            Mostrar_Grid();
            nuevo();
        }
    }
}
