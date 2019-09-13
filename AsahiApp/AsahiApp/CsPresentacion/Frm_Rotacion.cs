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
    public partial class Frm_Rotacion : Form
    {
        public Frm_Rotacion()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        private void Frm_Rotacion_Load(object sender, EventArgs e)
        {
            cargar_año(cmb_año);
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

        private void nuevo()
        {
            cmb_año.Text = "";
            cmb_mes.Text = "";
            cmb_ant.Text = "";
            cmb_ant2.Text = "";
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }
    }
}
