using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using System.Data.SqlClient;

namespace CsPresentacion
{
    public partial class Frm_Parametros_rep_prenomina : Form
    {
        public Frm_Parametros_rep_prenomina(Empleado classEmpleado)
        {
            InitializeComponent();
            timer1.Enabled = true;
            var tt = new ToolTip();
            tt.SetToolTip(btn_reporte, "GENERA REPORTE");
            claseEmp = classEmpleado;
        }
        //Variable para seleccionar tipo de reporte
 
        int Tipo;
        Empleado claseEmp;
        
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");



        private void Frm_Fecha_rep_prenomina_Load(object sender, EventArgs e)
        {
            nuevo();
            txt_semana.Enabled = true;
            txt_año.Enabled = true;
            dtm_inicial.Enabled = true;
            txt_clave.Enabled = true;
            cmb_tipo.Visible = false;
            lbl_tipo_aus.Visible = false;
            if (lbl_var.Text == "4")
            {
                cmb_tipo.Visible = true;
                lbl_tipo_aus.Visible = true;
            }

            cargar_ausentismo(cmb_tipo);
        }

        public void cargar_ausentismo(ComboBox inte)//Cargar ausentismos
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT RTRIM(DESCRIPCION)AS 'DESCRIPCION' FROM [asahi16].[Supervisor_giro].[Falta] ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["DESCRIPCION"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo Ausentismos" + Error.ToString());
            }
        }

        private void Frm_Fecha_rep_prenomina_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void Txt_semana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void nuevo()
        {
            dtm_inicial.Text = "";
            dtm_final.Text = "";
            dtm_final.Enabled = false;
            txt_semana.Text = "";
            txt_clave.Text = "";
            txt_clave.Focus();
            lbl_tipo.Text = "0";
            timer1.Enabled = true;
            lbl_var.Visible = false;
            lbl_tipo.Visible = false;
            cmb_tipo.Text = "";
            lbl_descripcion.Text = "";
           lbl_descripcion.Visible = false;
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            txt_año.Enabled = true;
            txt_semana.Enabled = true;
            dtm_inicial.Enabled = true;
            txt_clave.Enabled = true;
            txt_clave.Focus();
        }
        private void Txt_semana_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_clave.Text) && string.IsNullOrEmpty(txt_semana.Text))
            {
                dtm_final.Enabled = true;
                dtm_inicial.Enabled = true;
                lbl_tipo.Text = "0";
            }
            else if (string.IsNullOrEmpty(txt_clave.Text))
            {
                dtm_final.Enabled = false;
                dtm_inicial.Enabled = false;
                lbl_tipo.Text = "1";
            }
            else
            {
                dtm_final.Enabled = false;
                dtm_inicial.Enabled = false;
                lbl_tipo.Text = "3";
            }
        }
        private void Frm_Fecha_rep_prenomina_TextChanged(object sender, EventArgs e)
        {     
        }
        private void Dtm_inicial_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_clave.Text))
            {
                timer1.Enabled = false;
                txt_año.Enabled = false;
                txt_semana.Text = "";
                txt_semana.Enabled = false;
                dtm_final.Enabled = true;
                lbl_tipo.Text = "2";
                txt_clave.Text = "";
                txt_clave.Enabled = false;
            }
            else
            {
                timer1.Enabled = false;
                txt_año.Enabled = false;
                txt_año.Text = "";
                txt_semana.Text = "";
                txt_semana.Enabled = false;
                dtm_final.Enabled = true;
                lbl_tipo.Text = "4";
                txt_clave.Enabled = true;
            }
        }
        private void Dtm_final_ValueChanged(object sender, EventArgs e)
        {
        }
        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            //-----------------------------------------------------------------------------------------
            //Ejecuta reportes de descanso laborado
            if (lbl_var.Text == "1")//Reporte de descanso laborado
            {
                if (lbl_tipo.Text == "0")
                {
                    MessageBox.Show("Es necesario seleccionar una opción", "Aviso");
                    txt_clave.Focus();
                }
                else if (lbl_tipo.Text == "3" && string.IsNullOrEmpty(txt_semana.Text))
                {
                    MessageBox.Show("Es necesario capturar número de semana o Fecha", "Aviso");
                    txt_semana.Focus();
                }
                else if (lbl_tipo.Text == "2")//Genera reporte de descanso Laborado por Fecha
                {
                    Rep_Descanso_Laborado dl = new Rep_Descanso_Laborado();
                    dl.Var = Convert.ToInt32(lbl_var.Text);
                    dl.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    dl.Inicia = dtm_inicial.Value;
                    dl.Termina = dtm_final.Value;
                    dl.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    dl.Show();
                }
                else if (lbl_tipo.Text == "1")// Genera reporte de descanso laborado por Semana
                {
                    Descanso_laborado_Semana dls = new Descanso_laborado_Semana();
                    dls.Var = Convert.ToInt32(lbl_var.Text);
                    dls.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    dls.Año = Convert.ToInt32(txt_año.Text);
                    dls.Semana = Convert.ToInt32(txt_semana.Text);
                    dls.Inicia = dtm_inicial.Value;
                    dls.Termina = dtm_final.Value;
                    dls.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    dls.Show();
                }
                else if (lbl_tipo.Text == "3")// Genera reporte de descanso laborado por Semana y CLAVE
                {
                    Descanso_laborado_Semana dls = new Descanso_laborado_Semana();
                    dls.Var = Convert.ToInt32(lbl_var.Text);
                    dls.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    dls.Año = Convert.ToInt32(txt_año.Text);
                    dls.Semana = Convert.ToInt32(txt_semana.Text);
                    dls.Inicia = dtm_inicial.Value;
                    dls.Termina = dtm_final.Value;
                    dls.Clave = Convert.ToInt32(txt_clave.Text);
                    dls.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    dls.Show();
                }
                else if (lbl_tipo.Text == "4")// Genera reporte de descanso laborado por Fecha y CLAVE
                {
                    Rep_Descanso_Laborado dl = new Rep_Descanso_Laborado();
                    dl.Var = Convert.ToInt32(lbl_var.Text);
                    dl.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    dl.Inicia = dtm_inicial.Value;
                    dl.Termina = dtm_final.Value;
                    dl.Clave = Convert.ToInt32(txt_clave.Text);
                    dl.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    dl.Show();
                }
            }
            //-----------------------------------------------------------------------------------------
            //Ejecuta Reportes de Retardos
            else if (lbl_var.Text == "2")//Reporte de Retardos
            {
                if (lbl_tipo.Text == "0")
                {
                    MessageBox.Show("Es necesario seleccionar una opción", "Aviso");
                    txt_clave.Focus();
                }
                else if (lbl_tipo.Text == "3" && string.IsNullOrEmpty(txt_semana.Text))
                {
                    MessageBox.Show("Es necesario capturar número de semana o Fecha", "Aviso");
                    txt_semana.Focus();
                }
                else if (lbl_tipo.Text == "2")//Genera reporte de retardos por Fecha
                {
                    Frm_Rep_Retardos Re = new Frm_Rep_Retardos();
                    Re.Var = Convert.ToInt32(lbl_var.Text);
                    Re.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    Re.Inicia = dtm_inicial.Value;
                    Re.Termina = dtm_final.Value;
                    Re.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    Re.Show();
                }
                else if (lbl_tipo.Text == "1")//Genera reporte de retardos por Semana
                {
                    Retardos_Semana RS = new Retardos_Semana();
                    RS.Var = Convert.ToInt32(lbl_var.Text);
                    RS.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    RS.Semana = Convert.ToInt32(txt_semana.Text);
                    RS.Año = Convert.ToInt32(txt_año.Text);
                    RS.Inicia = dtm_inicial.Value;
                    RS.Termina = dtm_final.Value;
                    RS.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    RS.Show();
                }
                else if (lbl_tipo.Text == "3")//Genera reporte de retardos por Semana y CLAVE
                {
                    Retardos_Semana RS = new Retardos_Semana();
                    RS.Var = Convert.ToInt32(lbl_var.Text);
                    RS.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    RS.Semana = Convert.ToInt32(txt_semana.Text);
                    RS.Año = Convert.ToInt32(txt_año.Text);
                    RS.Inicia = dtm_inicial.Value;
                    RS.Termina = dtm_final.Value;
                    RS.Clave = Convert.ToInt32(txt_clave.Text);
                    RS.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    RS.Show();
                }
                else if (lbl_tipo.Text == "4")//Genera reporte de retardos por Fecha Y CLAVE
                {
                    Frm_Rep_Retardos Re = new Frm_Rep_Retardos();
                    Re.Var = Convert.ToInt32(lbl_var.Text);
                    Re.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    Re.Inicia = dtm_inicial.Value;
                    Re.Termina = dtm_final.Value;
                    Re.Clave = Convert.ToInt32(txt_clave.Text);
                    Re.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    Re.Show();
                }
            }
            //-----------------------------------------------------------------------------------------  
            //Ejecuta Permisos de salida anticipada
            else if (lbl_var.Text == "3")//Permisos de salida anticipada
            {
                if (lbl_tipo.Text == "0")
                {
                    MessageBox.Show("Es necesario seleccionar una opción", "Aviso");
                    txt_clave.Focus();
                }
                else if (lbl_tipo.Text == "3" && string.IsNullOrEmpty(txt_semana.Text))
                {
                    MessageBox.Show("Es necesario capturar número de semana o Fecha", "Aviso");
                    txt_semana.Focus();
                }
                else if (lbl_tipo.Text == "2")//Genera reporte de salida anticipada por Fecha
                {
                    Permiso_Salida sa = new Permiso_Salida();
                    sa.Var = Convert.ToInt32(lbl_var.Text);
                    sa.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    sa.Inicia = dtm_inicial.Value;
                    sa.Termina = dtm_final.Value;
                    sa.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    sa.Show();
                }
                else if (lbl_tipo.Text == "1")//Genera reporte de salida anticipada por Semana
                {
                    Permiso_Salida_Semana sa = new Permiso_Salida_Semana();
                    sa.Var = Convert.ToInt32(lbl_var.Text);
                    sa.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    sa.Semana = Convert.ToInt32(txt_semana.Text);
                    sa.Año = Convert.ToInt32(txt_año.Text);
                    sa.Inicia = dtm_inicial.Value;
                    sa.Termina = dtm_final.Value;
                    sa.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    sa.Show();
                }
                else if (lbl_tipo.Text == "3")//Genera reporte de salida anticipada por Semana y CLAVE
                {
                    Permiso_Salida_Semana sa = new Permiso_Salida_Semana();
                    sa.Var = Convert.ToInt32(lbl_var.Text);
                    sa.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    sa.Semana = Convert.ToInt32(txt_semana.Text);
                    sa.Año = Convert.ToInt32(txt_año.Text);
                    sa.Inicia = dtm_inicial.Value;
                    sa.Termina = dtm_final.Value;
                    sa.Clave = Convert.ToInt32(txt_clave.Text);
                    sa.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    sa.Show();
                }
                else if (lbl_tipo.Text == "4")//Genera reporte de salida anticipada por Fecha  CLAVE
                {
                    Permiso_Salida sa = new Permiso_Salida();
                    sa.Var = Convert.ToInt32(lbl_var.Text);
                    sa.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    sa.Inicia = dtm_inicial.Value;
                    sa.Termina = dtm_final.Value;
                    sa.Clave = Convert.ToInt32(txt_clave.Text);
                    sa.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    sa.Show();
                }
            }
           //--------------------------------------------------------------------------------------------
           //Ejecuta reportes de Ausentismo
            else if (lbl_var.Text == "4")//Reporte de Ausentismos
            {
                if (lbl_tipo.Text == "0")
                {
                    MessageBox.Show("Es necesario seleccionar una opción", "Aviso");
                    txt_clave.Focus();
                }
                else if (lbl_tipo.Text == "3" && string.IsNullOrEmpty(txt_semana.Text))
                {
                    MessageBox.Show("Es necesario capturar número de semana o Fecha", "Aviso");
                    txt_semana.Focus();
                }
                else  if (cmb_tipo.Text == "")
              {
                    MessageBox.Show("Es necesario seleccionar un tipo de Ausentismo", "Aviso");
                    cmb_tipo.Focus();
              }
                else if (lbl_tipo.Text == "2")//Genera reporte de ausentismos por Fecha
                {
                    Ausentismos aus = new Ausentismos();
                    aus.Var = Convert.ToInt32(lbl_var.Text);
                    aus.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    aus.Inicia = dtm_inicial.Value;
                    aus.Termina = dtm_final.Value;
                    aus.Descripcion = lbl_descripcion.Text;
                    aus.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    aus.Show();
                }
                else if (lbl_tipo.Text == "1")//Genera reporte de ausentismos por Semana
                {
                    Ausentismos aus = new Ausentismos();
                    aus.Var = Convert.ToInt32(lbl_var.Text);
                    aus.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    aus.Semana = Convert.ToInt32(txt_semana.Text);
                    aus.Año = Convert.ToInt32(txt_año.Text);
                    aus.Inicia = dtm_inicial.Value;
                    aus.Termina = dtm_final.Value;
                    aus.Descripcion = lbl_descripcion.Text;
                    aus.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    aus.Show();
                }
                else if (lbl_tipo.Text == "3")//Genera reporte de ausentismos por Semana y CLAVE
                {
                    Ausentismos aus = new Ausentismos();
                    aus.Var = Convert.ToInt32(lbl_var.Text);
                    aus.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    aus.Semana = Convert.ToInt32(txt_semana.Text);
                    aus.Año = Convert.ToInt32(txt_año.Text);
                    aus.Inicia = dtm_inicial.Value;
                    aus.Termina = dtm_final.Value;
                    aus.Clave = Convert.ToInt32(txt_clave.Text);
                    aus.Descripcion = lbl_descripcion.Text;
                    aus.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    aus.Show();
                }
                else if (lbl_tipo.Text == "4")//Genera reporte de ausentismos por Fecha  CLAVE
                {
                    Ausentismos aus = new Ausentismos();
                    aus.Var = Convert.ToInt32(lbl_var.Text);
                    aus.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    aus.Inicia = dtm_inicial.Value;
                    aus.Termina = dtm_final.Value;
                    aus.Clave = Convert.ToInt32(txt_clave.Text);
                    aus.Descripcion = lbl_descripcion.Text;
                    aus.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    aus.Show();
                }
            }
            //--------------------------------------------------------------------------------------------

           //Ejecuta reportes de Incapacidades
            else if (lbl_var.Text == "5")//Reporte de incapacidades
            {
                if (lbl_tipo.Text == "0")
                {
                    MessageBox.Show("Es necesario seleccionar una opción", "Aviso");
                    txt_clave.Focus();
                }
                else if (lbl_tipo.Text == "3" && string.IsNullOrEmpty(txt_semana.Text))
                {
                    MessageBox.Show("Es necesario capturar número de semana o Fecha", "Aviso");
                    txt_semana.Focus();
                }
                else if (lbl_tipo.Text == "2")//Genera reporte incapacidades Fecha
                {
                    Incapacidades inc = new Incapacidades();
                    inc.Var = Convert.ToInt32(lbl_var.Text);
                    inc.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    inc.Inicia = dtm_inicial.Value;
                    inc.Termina = dtm_final.Value;
                    inc.Inicia2 = dtm_inicial.Value;
                    inc.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    inc.Show();
                }
                else if (lbl_tipo.Text == "1")//Genera reporte de incapacidades por Semana
                {
                    Incapacidades inc = new Incapacidades();
                    inc.Var = Convert.ToInt32(lbl_var.Text);
                    inc.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    inc.Semana = Convert.ToInt32(txt_semana.Text);
                    inc.Año = Convert.ToInt32(txt_año.Text);
                    inc.Inicia = dtm_inicial.Value;
                    inc.Termina = dtm_final.Value;
                    inc.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    inc.Show();
                }
                else if (lbl_tipo.Text == "3")//Genera reporte de incapacidades por Semana y CLAVE
                {
                    Incapacidades inc = new Incapacidades();
                    inc.Var = Convert.ToInt32(lbl_var.Text);
                    inc.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    inc.Semana = Convert.ToInt32(txt_semana.Text);
                    inc.Año = Convert.ToInt32(txt_año.Text);
                    inc.Inicia = dtm_inicial.Value;
                    inc.Termina = dtm_final.Value;
                    inc.Clave = Convert.ToInt32(txt_clave.Text);
                    inc.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    inc.Show();
                }
                else if (lbl_tipo.Text == "4")//Genera reporte de incapacidades por Fecha  CLAVE
                {
                    Incapacidades inc = new Incapacidades();
                    inc.Var = Convert.ToInt32(lbl_var.Text);
                    inc.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    inc.Inicia = dtm_inicial.Value;
                    inc.Termina = dtm_final.Value;
                    inc.Clave = Convert.ToInt32(txt_clave.Text);
                    inc.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    inc.Show();
                }
            }
            //------------------------------------------------------------------------------------------

            //Ejecuta reportes de vacaciones
            else if (lbl_var.Text == "6")//Reporte de Vacaciones
            {
                if (lbl_tipo.Text == "0")
                {
                    MessageBox.Show("Es necesario seleccionar una opción", "Aviso");
                    txt_clave.Focus();
                }
                else if (lbl_tipo.Text == "3" && string.IsNullOrEmpty(txt_semana.Text))
                {
                    MessageBox.Show("Es necesario capturar número de semana o Fecha", "Aviso");
                    txt_semana.Focus();
                }
                else if (lbl_tipo.Text == "2")//Genera reporte Vacaciones Fecha
                {
                    Frm_Vacaciones vac = new Frm_Vacaciones();
                    vac.Var = Convert.ToInt32(lbl_var.Text);
                    vac.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    vac.Inicia = dtm_inicial.Value;
                    vac.Termina = dtm_final.Value;
                    vac.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    vac.Show();
                }
                else if (lbl_tipo.Text == "1")//Genera reporte de Vacaciones por Semana
                {
                    Frm_Vacaciones vac = new Frm_Vacaciones();
                    vac.Var = Convert.ToInt32(lbl_var.Text);
                    vac.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    vac.Semana = Convert.ToInt32(txt_semana.Text);
                    vac.Año = Convert.ToInt32(txt_año.Text);
                    vac.Inicia = dtm_inicial.Value;
                    vac.Termina = dtm_final.Value;
                    vac.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    vac.Show();
                }
                else if (lbl_tipo.Text == "3")//Genera reporte de Vacaciones por Semana y CLAVE
                {
                    Frm_Vacaciones vac = new Frm_Vacaciones();
                    vac.Var = Convert.ToInt32(lbl_var.Text);
                    vac.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    vac.Semana = Convert.ToInt32(txt_semana.Text);
                    vac.Año = Convert.ToInt32(txt_año.Text);
                    vac.Inicia = dtm_inicial.Value;
                    vac.Termina = dtm_final.Value;
                    vac.Clave = Convert.ToInt32(txt_clave.Text);
                    vac.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    vac.Show();
                }
                else if (lbl_tipo.Text == "4")//Genera reporte de Vacaciones por Fecha  CLAVE
                {
                    Frm_Vacaciones vac = new Frm_Vacaciones();
                    vac.Var = Convert.ToInt32(lbl_var.Text);
                    vac.Tipo = Convert.ToInt32(lbl_tipo.Text);
                    vac.Inicia = dtm_inicial.Value;
                    vac.Termina = dtm_final.Value;
                    vac.Clave = Convert.ToInt32(txt_clave.Text);
                    vac.Usuario = Convert.ToInt32(claseEmp.IdEmpleado);
                    nuevo();
                    txt_año.Enabled = true;
                    txt_semana.Enabled = true;
                    dtm_inicial.Enabled = true;
                    txt_clave.Enabled = true;
                    txt_clave.Focus();
                    vac.Show();
                }
            }
            //---------------------------------------------------------------------------------------------
        }


        private void Txt_año_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                timer1.Enabled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                timer1.Enabled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            txt_año.Text = DateTime.Now.ToString("yyyy");
        }
        private void Btn_reporte_erik_Click(object sender, EventArgs e)
        {    
        }
        private void Txt_clave_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_clave.Text))
            {
                lbl_tipo.Text = "0";
            }
            else
            {
                lbl_tipo.Text = "3";
            }
        }
        private void Txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void Cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_tipo.Text)
            {
                case "ABANDONO DE TRABAJO": lbl_descripcion.Text = "A"; break;
                case "PRESTACION POR MATRIMONIO": lbl_descripcion.Text = "B"; break;
                case "CITA IMSS": lbl_descripcion.Text = "C"; break;
                case "EMPLEADO VULNERABLE": lbl_descripcion.Text = "D"; break;
                case "ENFERMEDAD": lbl_descripcion.Text = "E"; break;
                case "FALTA INJUSTIFICADA": lbl_descripcion.Text = "F"; break;
                case "PERMISO CON GOCE": lbl_descripcion.Text = "G"; break;
                case "HOME OFFICE": lbl_descripcion.Text = "H"; break;
                case "CONFIRMADO": lbl_descripcion.Text = "J"; break;
                case "CONSULTA SOSPECHOSA": lbl_descripcion.Text = "K"; break;
                case "ENFERMEDAD LEVE": lbl_descripcion.Text = "L"; break;
                case "ENFERMEDAD MODERADA": lbl_descripcion.Text = "M"; break;
                case "SUSPENSION": lbl_descripcion.Text = "N"; break;
                case "SOSPECHOSO ENFERMEDAD": lbl_descripcion.Text = "O"; break;
                case "PERMISO SIN GOCE": lbl_descripcion.Text = "P"; break;
                case "FAMILIAR": lbl_descripcion.Text = "R"; break;
                case "ASUNTOS PERSONALES": lbl_descripcion.Text = "S"; break;
                case "TRANSPORTE": lbl_descripcion.Text = "T"; break;
                case "FALTA JUSTIFICADA": lbl_descripcion.Text = "U"; break;
                case "VIAJE": lbl_descripcion.Text = "V"; break;
            }
        }
    }
}
