using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CsPresentacion
{
    public partial class Frm_Fecha_Baja : Form
    {
        public Frm_Fecha_Baja()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        private void Frm_Fecha_Baja_Load(object sender, EventArgs e)
        {
            cmb_motivo.DropDownStyle = ComboBoxStyle.DropDownList;
             lbl_clave_empleado.Visible = false;
             lbl_motivo.Visible = false;
            lbl_usuario.Visible = false;
            cargar_motivo(cmb_motivo);   
        }



        private void ejecutar_baja()
        {
            try
            {
                DataTable dt = new DataTable();
                String str;
                str = "[dbo].[FM_BAJA_EMPLEADO]";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Clave", lbl_clave_empleado.Text);
                da.SelectCommand.Parameters.AddWithValue("@Fecha", dtm_fecha.Text);
                da.SelectCommand.Parameters.AddWithValue("@Motivo", lbl_motivo.Text);
                da.Fill(dt);
                con.Close();
                MessageBox.Show("El empleado " + lbl_clave_empleado.Text + " se dió de baja correctamente.");
            }
            catch
            {
            }
        }

        public void cargar_motivo(ComboBox des) //Carga motivo de baja de empleados
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT LTRIM(RTRIM(DESCRIPCION)) AS 'MOTIVO' FROM [asahi16].[Supervisor_giro].[Baja]", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    des.Items.Add(dr["MOTIVO"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó el campo de motivo" + Error.ToString());
            }
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_motivo.Text))
            {
                MessageBox.Show("Favor de seleccionar motivo");
            }
            else
            {
                ejecutar_baja();
                this.Close();
            }
        }

        private void Cmb_motivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_motivo.Text == "TERMINO DE CONTRATO")
            {
                lbl_motivo.Text = "01";
            }
            else if (cmb_motivo.Text == "RENUNCIA VOLUNTARIA")
            {
                lbl_motivo.Text = "02";
            }
            else if (cmb_motivo.Text == "ABANDONO DE TRABAJO")
            {
                lbl_motivo.Text = "03";
            }
            else if (cmb_motivo.Text == "AUSENTISMO")
            {
                lbl_motivo.Text = "07";
            }
            else if (cmb_motivo.Text == "RECISION DE CONTRATO")
            {
                lbl_motivo.Text = "08";
            }
            else if (cmb_motivo.Text == "DEFUNCION")
            {
                lbl_motivo.Text = "09";
            }
            else if (cmb_motivo.Text == "PENSION")
            {
                lbl_motivo.Text = "10";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
