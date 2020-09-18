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
    public partial class Frm_Aussentismos_Retardos : Form
    {

        public Frm_Aussentismos_Retardos(Empleado classEmpleado)
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo, "Nuevo");
            tt.SetToolTip(btn_primero, "Primero [Inicio]");
            tt.SetToolTip(btn_anterior, "Anterior [Re. Pág.]");
            tt.SetToolTip(btn_siguiente, "Siguiente [Av. Pág.]");
            tt.SetToolTip(btn_ultimo, "Último [Fin]");
            tt.SetToolTip(btn_insertar, "Insertar");
            tt.SetToolTip(btn_eliminar, "Eliminar");
            tt.SetToolTip(btn_guardar, "Guardar");
            tt.SetToolTip(btn_cancelar, "Cancelar");
            tt.SetToolTip(btn_exportar, "Exportar");

            tt.SetToolTip(btn_f_primero, "Primero [Inicio]");
            tt.SetToolTip(btn_f_anterior, "Anterior [Re. Pág.]");
            tt.SetToolTip(btn_f_siguiente, "Siguiente [Av. Pág.]");
            tt.SetToolTip(btn_f_ultimo, "Último [Fin]");
            tt.SetToolTip(btn_f_insertar, "Insertar");
            tt.SetToolTip(btn_f_eliminar, "Eliminar");
            tt.SetToolTip(btn_f_guardar, "Guardar");
            tt.SetToolTip(btn_f_cancelar, "Cancelar");
            tt.SetToolTip(btn_f_exportar, "Exportar");

            tt.SetToolTip(btn_v_primero, "Primero [Inicio]");
            tt.SetToolTip(btn_v_anterior, "Anterior [Re. Pág.]");
            tt.SetToolTip(btn_v_siguiente, "Siguiente [Av. Pág.]");
            tt.SetToolTip(btn_v_ultimo, "Último [Fin]");
            tt.SetToolTip(btn_v_insertar, "Insertar");
            tt.SetToolTip(btn_v_eliminar, "Eliminar");
            tt.SetToolTip(btn_v_guardar, "Guardar");
            tt.SetToolTip(btn_v_cancelar, "Cancelar");
            tt.SetToolTip(btn_v_exportar, "Exportar");
            claseEmp = classEmpleado;
        }

        int indice = 0;
        int indicef = 0;
        double Duracion;
        double Prima;
        double Resultado;
        int x, y;

        SqlCommand cmd;
        SqlDataReader dr;
        Empleado claseEmp;
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        private void Ausentismo_retardos_Load(object sender, EventArgs e)
        {
            nuevo();
            autocompletar_responsable(txt_nombre);
            txt_clave.Focus();
            cargar_descripcion_ausentismo(cmb_f_tipo);
            Cargar_clave_ausentismo(txt_f_tipo);
        }
        public void cargar_descripcion_ausentismo(ComboBox inte)//Cargar ausentismos
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
        public void Cargar_clave_ausentismo(TextBox tex)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(CLAVE)AS 'CLAVE' FROM [asahi16].[Supervisor_giro].[Falta]", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tex.AutoCompleteCustomSource.Add(dr["CLAVE"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudo autcompletar nombre " + error.ToString());
            }
        }

        //Métodos Módulo de incapacidades
        private void nuevo()
        {
            txt_clave.Text = "";
            txt_nombre.Text = "";
            txt_nombre.Enabled = true;
            dtm_fecha.Text = "";
            dtm_fecha.Enabled = false;
            dtm_termina.Text = "";
            dtm_termina.Enabled = false;
            txt_certificado.Text = "";
            txt_certificado.Enabled = false;
            cmb_tipo.Text = "";
            cmb_tipo.Enabled = false;
            cmb_caso.Text = "";
            cmb_caso.Enabled = false;
            txt_duracion.Text = "";
            txt_duracion.Enabled = false;
            dtm_aplicacion.Text = "";
            dtm_aplicacion.Enabled = false;
            lbl_inc_tipo.Text = "";
            lbl_inc_tipo.Visible = false;
            lbl_inc_caso.Text = "";
            lbl_inc_caso.Visible = false;
            txt_certificado.Mask = ">LL000000";
            lbl_id.Visible = false;
            lbl_id.Text = "0";
            btn_primero.Enabled = false;
            btn_anterior.Enabled = false;
            btn_siguiente.Enabled = false;
            btn_ultimo.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_exportar.Enabled = false;
            lbl_estado.Text = "";
            pictureBox1.ImageLocation = "V:/Sistemas/SAAM/Logo.jpg";
            //Módulo de Faltas
            btn_f_insertar.Enabled = false;
            dtm_f_termina.Text = "";
            dtm_f_termina.Enabled = false;
            dtm_f_aplicacion.Text = "";
            dtm_f_aplicacion.Enabled = false;
            btn_f_primero.Enabled = false;
            btn_f_siguiente.Enabled = false;
            btn_f_anterior.Enabled = false;
            btn_f_ultimo.Enabled = false;
            btn_f_exportar.Enabled = false;
            dtm_f_fecha.Enabled = false;
            txt_f_duracion.Text = "";
            txt_f_duracion.Enabled = false;
            cmb_f_tipo.Text = "";
            dtm_f_fecha.Text = "";
            lbl_f_id.Text = "0";
            lbl_f_id.Visible = false;
            txt_f_tipo.Text = "";
            cmb_f_tipo.Enabled = false;
            txt_f_tipo.Enabled = false;
            btn_insertar.Enabled = false;
            txt_clave.Focus();
            //Módulo de vacaciones
            txt_v_prima.Text = "";
            dtm_v_inicia.Text = "";
            dtm_v_termina.Text = "";
            txt_v_antiguedad.Text = "";
            txt_v_duracion.Text = "";
            btn_v_primero.Enabled = false;
            btn_v_siguiente.Enabled = false;
            btn_v_anterior.Enabled = false;
            btn_v_ultimo.Enabled = false;
            btn_v_insertar.Enabled = false;
            btn_v_eliminar.Enabled = false;
            btn_v_guardar.Enabled = false;
            btn_v_cancelar.Enabled = false;
            btn_v_exportar.Enabled = false;
            btn_v_insertar.Enabled = false;
            txt_v_prima.Enabled = false;
            dtm_v_inicia.Enabled = false;
            dtm_v_termina.Enabled = false;
            txt_v_antiguedad.Enabled = false;
            txt_v_duracion.Enabled = false;
            lbl_x_pagar.Text = "";
            lbl_x_disfrutar.Text = "";
            lbl_prima.Text = "";
            lbl_v_id.Text = "0";
            lbl_v_id.Visible = false;
            lbl_v_inicia.Text = "0";
            lbl_v_termina.Text = "0";
            lbl_v_inicia.Visible = false;
            lbl_v_termina.Visible = false; 
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
                lbl_estado.Text = dt.Rows[0]["VIGENCIA"].ToString();
                txt_v_antiguedad.Text = dt.Rows[0]["ANTIGUEDAD"].ToString();
            }
            con.Close();
        }
        private void Verifica_certificado()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SELECT NUMERO FROM [asahi16].[Supervisor_giro].[Empinc] WHERE NUMERO = @Num ";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Num", SqlDbType.VarChar).Value = txt_certificado.Text;
                da.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("El certificado ya existe, Favor de verificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_certificado.Focus();
                }
                else
                {
                    Verifica_Incapacidad();
                }
            }
            catch
            {
                MessageBox.Show("Error al consultar el Certificado.");
            }
        }//verifica existencia de certificado
        private void Verifica_Incapacidad()//Verifica si hay incapacidad
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[Incapacidades_Retardos]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "6";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_fecha.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_duracion.Text;
            da.SelectCommand.Parameters.Add("@NUMERO", SqlDbType.VarChar, 100).Value = txt_certificado.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = cmb_tipo.Text;
            da.SelectCommand.Parameters.Add("@CASO", SqlDbType.VarChar, 100).Value = cmb_caso.Text;
            da.SelectCommand.Parameters.Add("@FECHA_TERMINO", SqlDbType.VarChar, 100).Value = dtm_termina.Text;
            da.SelectCommand.Parameters.Add("@FECHA_APLICACION", SqlDbType.VarChar, 100).Value = dtm_aplicacion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
            da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value = lbl_id.Text;

            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("El empleado tiene incapacidad en esta Fecha, Favor de Verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_fecha.Focus();
            }
            else
            {
                Verifica_vacaciones();
            }
        }
        private void Verifica_vacaciones()//Verifica si hay vacaciones
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[Incapacidades_Retardos]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "7";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_fecha.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_duracion.Text;
            da.SelectCommand.Parameters.Add("@NUMERO", SqlDbType.VarChar, 100).Value = txt_certificado.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = cmb_tipo.Text;
            da.SelectCommand.Parameters.Add("@CASO", SqlDbType.VarChar, 100).Value = cmb_caso.Text;
            da.SelectCommand.Parameters.Add("@FECHA_TERMINO", SqlDbType.VarChar, 100).Value = dtm_termina.Text;
            da.SelectCommand.Parameters.Add("@FECHA_APLICACION", SqlDbType.VarChar, 100).Value = dtm_aplicacion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
            da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value = lbl_id.Text;
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                DialogResult resul = MessageBox.Show("El empleado tiene Vacaciones en esta Fecha, ¿Desea eliminar las Vacaciones?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    Borra_Vacaciones();
                    Verifica_Falta();
                }
                if (resul == DialogResult.No)
                {
                    dtm_fecha.Focus();
                }
            }
            else
            {
                Verifica_Falta();
            }
        }
        private void Verifica_Falta()//Verifica si hay una falta
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[Incapacidades_Retardos]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "5";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_fecha.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_duracion.Text;
            da.SelectCommand.Parameters.Add("@NUMERO", SqlDbType.VarChar, 100).Value = txt_certificado.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = cmb_tipo.Text;
            da.SelectCommand.Parameters.Add("@CASO", SqlDbType.VarChar, 100).Value = cmb_caso.Text;
            da.SelectCommand.Parameters.Add("@FECHA_TERMINO", SqlDbType.VarChar, 100).Value = dtm_termina.Text;
            da.SelectCommand.Parameters.Add("@FECHA_APLICACION", SqlDbType.VarChar, 100).Value = dtm_aplicacion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
            da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value = lbl_id.Text;
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows.Count > 0)
                {
                    DialogResult resul = MessageBox.Show("El empleado tiene una incidencia dentro de esta Fecha, ¿Desea eliminar la incidencia?", "¡Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resul == DialogResult.Yes)
                    {
                        Borra_falta();
                        Inserta_incapacidades();
                        Mostrar_Grid_Incapacidades();
                        dtm_fecha.Text = "";
                        txt_duracion.Text = "";
                        dtm_termina.Text = "";
                        txt_certificado.Text = "";
                        cmb_caso.Text = "";
                        cmb_tipo.Text = "";
                        lbl_id.Text = "0";
                        dtm_fecha.Focus();
                    }
                    else if (resul == DialogResult.No)
                    {
                        dtm_fecha.Focus();
                    }
                }
            }
            else
            {
                Inserta_incapacidades();
                Mostrar_Grid_Incapacidades();
                dtm_fecha.Text = "";
                txt_duracion.Text = "";
                dtm_termina.Text = "";
                txt_certificado.Text = "";
                cmb_caso.Text = "";
                cmb_tipo.Text = "";
                lbl_id.Text = "0";
                dtm_fecha.Focus();
            }
        }
        private void Inserta_incapacidades()//Inserta incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "2");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                dtm_fecha.Enabled = false;
                txt_duracion.Enabled = false;
                txt_certificado.Enabled = false;
                cmb_tipo.Enabled = false;
                cmb_caso.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Borra_Vacaciones()//Borra vacaciones
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "8");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar vacaciones.");
            }
        }
        private void Borra_falta()//Borrar falta dentro de un rango de fechas
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "9");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                Mostrar_Grid_Faltas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar incidencia");
            }
        }
        private void Diseño_Grid(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//Clave
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 80;//Inicio
            dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].Width = 80;//Termino
            dgv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[4].Width = 70;
            dgv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[5].Width = 40;//id
            dgv.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[6].Width = 145;//tipo
            dgv.Columns[7].Width = 100;//caso
            dgv.Columns[8].Width = 84;//aplicacion
            dgv.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Mostrar_Grid_Incapacidades()//Mostrar grid de incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_incapacidades.DataSource = dt;
                Diseño_Grid(dgv_incapacidades);
                dgv_incapacidades.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dgv_incapacidades.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Elimina_incapacidades()//Elimina incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "3");
                cmd.Parameters.AddWithValue("@CLAVE", Convert.ToInt32(txt_clave.Text));
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Modifica_incapacidades()//Modifica incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Incapacidades_Retardos]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "4");
                cmd.Parameters.AddWithValue("@CLAVE", Convert.ToInt32(txt_clave.Text));
                cmd.Parameters.AddWithValue("@FECHA", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_duracion.Text);
                cmd.Parameters.AddWithValue("@NUMERO", txt_certificado.Text);
                cmd.Parameters.AddWithValue("@TIPO", lbl_inc_tipo.Text);
                cmd.Parameters.AddWithValue("@CASO", lbl_inc_caso.Text);
                cmd.Parameters.AddWithValue("@FECHA_TERMINO", dtm_termina.Text);
                cmd.Parameters.AddWithValue("@FECHA_APLICACION", dtm_aplicacion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_id.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                dtm_fecha.Enabled = false;
                txt_duracion.Enabled = false;
                txt_certificado.Enabled = false;
                cmb_tipo.Enabled = false;
                cmb_caso.Enabled = false;
                dtm_fecha.Text = "";
                txt_duracion.Text = "";
                dtm_termina.Text = "";
                txt_certificado.Text = "";
                cmb_caso.Text = "";
                cmb_tipo.Text = "";
                lbl_id.Text = "0";
                btn_insertar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Exportara_Exel()// Método para exportar a excel, múdulo incapacidades.
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
                for (int i = -1; i < dgv_incapacidades.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_incapacidades.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_incapacidades.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_incapacidades.Rows[i].Cells[j].Value.ToString();
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

        public void autocompletar_responsable(TextBox tex)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(RTRIM(NOMBREN)+ ' '+ RTRIM(NOMBREP)+ ' ' + RTRIM(NOMBREM)) as 'NOMBRE' FROM [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] WHERE VIGENCIA = 'VIGENTE'  AND NOMBREN  LIKE '%' + " + txt_nombre.Text + " + '%'  order by NOMBRE ASC", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tex.AutoCompleteCustomSource.Add(dr["NOMBRE"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudo autcompletar nombre " + error.ToString());
            }
        }



        private void cargar_clave()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String strSql;
                strSql = "SELECT Convert(Int,RTRIM(CLAVE)) AS 'CLAVE', VIGENCIA FROM [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] WHERE RTRIM(RTRIM(NOMBREN)+ ' '+ RTRIM(NOMBREP)+ ' ' + RTRIM(NOMBREM)) = @Nombre";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txt_nombre.Text;
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    txt_clave.Text = dt.Rows[0]["CLAVE"].ToString();
                    lbl_estado.Text = dt.Rows[0]["VIGENCIA"].ToString();
                }
            }
            catch
            {
            }
        }

        //Botones Módulo de incapacidades
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            Mostrar_Grid_Incapacidades();
            Mostrar_Grid_Faltas();
            Mostrar_Grid_Vacaciones();
        }
        private void Btn_primero_Click_1(object sender, EventArgs e)
        {
            dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[0].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
            btn_anterior.Enabled = false;
            btn_primero.Enabled = false;
            btn_siguiente.Enabled = true;
            btn_ultimo.Enabled = true;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
            dtm_fecha.Focus();
        }
        private void Btn_anterior_Click_1(object sender, EventArgs e)
        {
            int Anterior = indice - 1;

            try
            {
                dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[Anterior].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
                btn_siguiente.Enabled = true;
                btn_ultimo.Enabled = true;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                dtm_fecha.Focus();
            }
            catch
            {
                btn_anterior.Enabled = false;
                btn_primero.Enabled = false;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                dtm_fecha.Focus();
            }
        }
        private void Btn_siguiente_Click_1(object sender, EventArgs e)
        {
            int Siguiente = indice + 1;
            try
            {
                dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[Siguiente].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
                btn_anterior.Enabled = true;
                btn_primero.Enabled = true;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                dtm_fecha.Focus();
            }
            catch
            {
                btn_siguiente.Enabled = false;
                btn_ultimo.Enabled = false;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                MessageBox.Show("Llegó al final!", "Aviso");
                dtm_fecha.Focus();
            }
        }
        private void Btn_ultimo_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgv_incapacidades.CurrentCell = dgv_incapacidades.Rows[50].Cells[dgv_incapacidades.CurrentCell.ColumnIndex];
                btn_siguiente.Enabled = false;
                btn_ultimo.Enabled = false;
                btn_anterior.Enabled = true;
                btn_primero.Enabled = true;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
                dtm_fecha.Focus();
            }
            catch
            {
            }
        }
        private void Btn_insertar_Click_1(object sender, EventArgs e)
        {
            dtm_fecha.Text = "";
            dtm_termina.Text = "";
            dtm_aplicacion.Text = "";
            txt_duracion.Text = "";
            cmb_caso.Text = "";
            cmb_tipo.Text = "";
            txt_certificado.Text = "";
            btn_eliminar.Enabled = false;
            lbl_id.Text = "0";
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
            dtm_fecha.Enabled = true;
            txt_duracion.Enabled = true;
            txt_certificado.Enabled = true;
            cmb_caso.Enabled = true;
            cmb_tipo.Enabled = true;
            dtm_fecha.Focus();
        }
        private void Btn_eliminar_Click_1(object sender, EventArgs e)
        {
            Elimina_incapacidades();
            Mostrar_Grid_Incapacidades();
            dtm_fecha.Text = "";
            dtm_termina.Text = "";
            txt_duracion.Text = "";
            dtm_aplicacion.Text = "";
            txt_certificado.Text = "";
            cmb_tipo.Text = "";
            cmb_caso.Text = "";
            lbl_inc_caso.Text = "";
            lbl_inc_tipo.Text = "";
            lbl_id.Text = "0";
            btn_eliminar.Enabled = false;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
            dtm_fecha.Enabled = false;
            txt_duracion.Enabled = false;
            txt_certificado.Enabled = false;
            cmb_tipo.Enabled = false;
            cmb_caso.Enabled = false;
            dtm_fecha.Focus();
        }
        private void Btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (txt_duracion.Text == "")
            {
                MessageBox.Show("Es necesario capturar la cantidad de días.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_duracion.Focus();
            }
            else if (txt_certificado.Text == "")
            {
                MessageBox.Show("Es necesario capturar el Certificado de Incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_certificado.Focus();
            }
            else if (cmb_tipo.Text == "")
            {
                MessageBox.Show("Es necesario capturar el tipo de incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_tipo.Focus();
            }
            else if (cmb_caso.Text == "")
            {
                MessageBox.Show("Es necesario capturar el caso de incapacidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_caso.Focus();
            }
            else
            {
                if (lbl_id.Text == "0")
                {
                    Verifica_certificado();
                }
                else
                {

                    Modifica_incapacidades();
                    Mostrar_Grid_Incapacidades();
                }
            }
        }
        private void Btn_cancelar_Click_1(object sender, EventArgs e)
        {
            dtm_fecha.Text = "";
            dtm_termina.Text = "";
            txt_duracion.Text = "";
            dtm_aplicacion.Text = "";
            txt_certificado.Text = "";
            cmb_tipo.Text = "";
            cmb_caso.Text = "";
            lbl_inc_caso.Text = "";
            lbl_inc_tipo.Text = "";
            btn_eliminar.Enabled = false;
            lbl_id.Text = "0";
            dtm_fecha.Focus();
        }
        private void Btn_exportar_Click_1(object sender, EventArgs e)
        {
            Exportara_Exel();
            dtm_fecha.Focus();
        }


        //Eventos Módulo de incapacidades
        private void Txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            else { e.Handled = true; }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cargar_informacion();
               Mostrar_Grid_Incapacidades();
                Mostrar_Grid_Faltas();
                Mostrar_Grid_Vacaciones();
                cargar_dias();
                calcula_prima();
                txt_nombre.Enabled = false;
                btn_exportar.Enabled = true;
                btn_f_exportar.Enabled = true;
                btn_siguiente.Enabled = true;
                btn_ultimo.Enabled = true;
                btn_f_siguiente.Enabled = true;
                btn_f_ultimo.Enabled = true;
                btn_v_exportar.Enabled = true;
                btn_v_siguiente.Enabled = true;
                btn_v_ultimo.Enabled = true;
                pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
                dtm_f_fecha.Focus();
            }
        }
        private void Lbl_estado_TextChanged(object sender, EventArgs e)
        {
            if (lbl_estado.Text == "VIGENTE")
            {
                lbl_estado.ForeColor = Color.Black;
                btn_insertar.Enabled = true;
                btn_f_insertar.Enabled = true;
                btn_v_insertar.Enabled = true;
            }
            else
            {
                lbl_estado.ForeColor = Color.Red;
                btn_insertar.Enabled = true;
                btn_f_insertar.Enabled = true;
                btn_v_insertar.Enabled = true;
                btn_guardar.Enabled = false;
                btn_cancelar.Enabled = false;
            
                btn_f_guardar.Enabled = false;
                btn_f_cancelar.Enabled = false;
                btn_f_eliminar.Enabled = false;
               
            }
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void Txt_nombre_Leave(object sender, EventArgs e)
        {
            cargar_clave();
            Mostrar_Grid_Incapacidades();
            Mostrar_Grid_Faltas();
            Mostrar_Grid_Vacaciones();
            cargar_dias();
            calcula_prima();
            btn_exportar.Enabled = true;
            btn_f_exportar.Enabled = true;
            btn_siguiente.Enabled = true;
            btn_ultimo.Enabled = true;
            btn_f_siguiente.Enabled = true;
            btn_f_ultimo.Enabled = true;
            btn_f_insertar.Focus();
            btn_v_exportar.Enabled = true;
            btn_v_siguiente.Enabled = true;
            btn_v_ultimo.Enabled = true;
            pictureBox1.ImageLocation = "V:/Recursos Humanos/CARPETA 2018/RH. FOTOGRAFIAS DEL PERSONAL/" + txt_clave.Text + ".JPG";
            txt_nombre.Enabled = false;
            dtm_f_fecha.Focus();
        }
        private void Dtm_fecha_ValueChanged_1(object sender, EventArgs e)
        {
            dtm_aplicacion.Text = dtm_fecha.Text;
        }
        private void Txt_certificado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar))
            { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar))
            { e.Handled = false; }
            else { e.Handled = true; }
        }
        private void Txt_certificado_Leave_1(object sender, EventArgs e)
        {
        }
        private void Dgv_incapacidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_incapacidades.Rows[e.RowIndex];
                dtm_fecha.Text = row.Cells["INICIO"].Value.ToString();
                dtm_termina.Text = row.Cells["TERMINO"].Value.ToString();
                txt_duracion.Text = row.Cells["DURACION"].Value.ToString();
                txt_certificado.Text = row.Cells["CERTIFICADO"].Value.ToString();
                cmb_caso.Text = row.Cells["CASO"].Value.ToString();
                cmb_tipo.Text = row.Cells["TIPO"].Value.ToString();
                lbl_id.Text = row.Cells["ID"].Value.ToString();
                dtm_fecha.Focus();
            }

        }
        private void Dgv_incapacidades_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_incapacidades.Rows[e.RowIndex];
                dtm_fecha.Text = row.Cells["INICIO"].Value.ToString();
                dtm_termina.Text = row.Cells["TERMINO"].Value.ToString();
                txt_duracion.Text = row.Cells["DURACION"].Value.ToString();
                txt_certificado.Text = row.Cells["CERTIFICADO"].Value.ToString();
                cmb_caso.Text = row.Cells["CASO"].Value.ToString();
                cmb_tipo.Text = row.Cells["TIPO"].Value.ToString();
                lbl_id.Text = row.Cells["ID"].Value.ToString();
            }
        }
        private void Dgv_incapacidades_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_incapacidades.CurrentCell != null) { indice = dgv_incapacidades.CurrentRow.Index; }
        }
        private void Dgv_incapacidades_DoubleClick(object sender, EventArgs e)
        {
            if (lbl_estado.Text == "VIGENTE")
            {
                DialogResult resul = MessageBox.Show("¿Desea modificar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    btn_guardar.Enabled = true;
                    btn_eliminar.Enabled = true;
                    btn_cancelar.Enabled = true;
                    dtm_fecha.Enabled = true;
                    txt_duracion.Enabled = true;
                    txt_certificado.Enabled = true;
                    cmb_tipo.Enabled = true;
                    cmb_caso.Enabled = true;
                    dtm_fecha.Focus();
                }
                if (resul == DialogResult.No)
                {
                    btn_guardar.Enabled = false;
                    btn_eliminar.Enabled = false;
                    btn_cancelar.Enabled = false;
                    dtm_fecha.Enabled = false;
                    txt_duracion.Enabled = false;
                    txt_certificado.Enabled = false;
                    cmb_tipo.Enabled = false;
                    cmb_caso.Enabled = false;
                    dtm_fecha.Focus();
                }
            }
            else
            {
            }
        }
        private void Txt_duracion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        private void Txt_duracion_Leave_1(object sender, EventArgs e)
        {
            try
            {
                DateTime Inicia = dtm_fecha.Value.Date;
                int dias = Int32.Parse(txt_duracion.Text);
                DateTime Final = Inicia.AddDays(dias - 1);
                dtm_termina.Text = Final.ToString();
            }
            catch
            {
            }
        }
        private void Cmb_tipo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_caso_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Cmb_tipo_TextChanged_1(object sender, EventArgs e)
        {
            if (cmb_tipo.Text == "Enfermermedad General")
            {
                lbl_inc_tipo.Text = "EG";
                cmb_caso.Enabled = true;
            }
            else if (cmb_tipo.Text == "Accidente de Trabajo")
            {
                lbl_inc_tipo.Text = "RT";
                cmb_caso.Enabled = false;
                cmb_caso.Text = "Ninguna";
            }
            else if (cmb_tipo.Text == "Accidente de Trayecto")
            {
                lbl_inc_tipo.Text = "AT";
                cmb_caso.Enabled = false;
                cmb_caso.Text = "Ninguna";
            }
            else if (cmb_tipo.Text == "Enfermedad Profesional")
            {
                lbl_inc_tipo.Text = "EP";
                cmb_caso.Enabled = true;
            }
            else if (cmb_tipo.Text == "Pre Maternidad")
            {
                lbl_inc_tipo.Text = "PM";
                cmb_caso.Enabled = true;
            }
            else if (cmb_tipo.Text == "Maternidad Enlace")
            {
                lbl_inc_tipo.Text = "ME";
                cmb_caso.Enabled = true;
            }
            else if (cmb_tipo.Text == "Post Maternidad")
            {
                lbl_inc_tipo.Text = "OM";
                cmb_caso.Enabled = true;
            }
        }
        private void Cmb_caso_TextChanged_1(object sender, EventArgs e)
        {
            if (cmb_caso.Text == "Unica") { lbl_inc_caso.Text = "U"; }
            else if (cmb_caso.Text == "Inicial") { lbl_inc_caso.Text = "I"; }
            else if (cmb_caso.Text == "Subsecuente") { lbl_inc_caso.Text = "S"; }
            else if (cmb_caso.Text == "Alta Médica ST2") { lbl_inc_caso.Text = "2"; }
            else if (cmb_caso.Text == "Ninguna") { lbl_inc_caso.Text = "N"; }
            else { lbl_inc_caso.Text = ""; }
        }


        //Módulo de Faltas

        //Botones Módulo de faltas
        private void Btn_f_insertar_Click(object sender, EventArgs e)
        {
            dtm_f_fecha.Text = "";
            dtm_f_fecha.Enabled = true;
            dtm_f_fecha.Focus();
            txt_f_duracion.Text = "";
            dtm_f_termina.Text = "";
            dtm_f_aplicacion.Text = "";
            cmb_f_tipo.Text = "";
            cmb_f_tipo.Enabled = true;
            btn_f_guardar.Enabled = true;
            btn_f_cancelar.Enabled = true;
            btn_f_eliminar.Enabled = false;
            txt_f_duracion.Enabled = true;
            lbl_f_id.Text = "0";
            txt_f_tipo.Text = "";
            txt_f_tipo.Enabled = true;
        }
        private void Btn_f_cancelar_Click(object sender, EventArgs e)
        {
            dtm_f_fecha.Text = "";
            txt_f_duracion.Text = "";
            dtm_f_termina.Text = "";
            dtm_f_aplicacion.Text = "";
            cmb_f_tipo.Text = "";
            lbl_f_id.Text = "0";
            txt_f_tipo.Text = "";
            dtm_f_fecha.Focus();
        }
        private void Btn_f_primero_Click(object sender, EventArgs e)
        {
            dgv_faltas.CurrentCell = dgv_faltas.Rows[0].Cells[dgv_faltas.CurrentCell.ColumnIndex];
            btn_f_anterior.Enabled = false;
            btn_f_primero.Enabled = false;
            btn_f_siguiente.Enabled = true;
            btn_f_ultimo.Enabled = true;
            btn_f_guardar.Enabled = false;
            btn_f_cancelar.Enabled = false;
            dtm_f_fecha.Focus();
        }
        private void Btn_f_anterior_Click(object sender, EventArgs e)
        {
            int Anterior = indicef - 1;

            try
            {
                dgv_faltas.CurrentCell = dgv_faltas.Rows[Anterior].Cells[dgv_faltas.CurrentCell.ColumnIndex];
                btn_f_siguiente.Enabled = true;
                btn_f_ultimo.Enabled = true;
                btn_f_guardar.Enabled = false;
                btn_f_cancelar.Enabled = false;
                dtm_f_fecha.Focus();
            }
            catch
            {
                btn_f_anterior.Enabled = false;
                btn_f_primero.Enabled = false;
                btn_f_guardar.Enabled = false;
                btn_f_cancelar.Enabled = false;
                dtm_f_fecha.Focus();
            }
        }
        private void Btn_f_siguiente_Click(object sender, EventArgs e)
        {
            int Siguiente = indicef + 1;
            try
            {
                dgv_faltas.CurrentCell = dgv_faltas.Rows[Siguiente].Cells[dgv_faltas.CurrentCell.ColumnIndex];
                btn_f_anterior.Enabled = true;
                btn_f_primero.Enabled = true;
                btn_f_guardar.Enabled = false;
                btn_f_cancelar.Enabled = false;
                dtm_f_fecha.Focus();
            }
            catch
            {
                btn_f_siguiente.Enabled = false;
                btn_f_ultimo.Enabled = false;
                btn_f_guardar.Enabled = false;
                btn_f_cancelar.Enabled = false;
                MessageBox.Show("Llegó al final!", "Aviso");
                dtm_f_fecha.Focus();
            }
        }
        private void Btn_f_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_faltas.CurrentCell = dgv_faltas.Rows[50].Cells[dgv_faltas.CurrentCell.ColumnIndex];
                btn_f_siguiente.Enabled = false;
                btn_f_ultimo.Enabled = false;
                btn_f_anterior.Enabled = true;
                btn_f_primero.Enabled = true;
                btn_f_guardar.Enabled = false;
                btn_f_cancelar.Enabled = false;
                dtm_f_fecha.Focus();
            }
            catch
            {
            }
        }
        private void Btn_f_guardar_Click(object sender, EventArgs e)
        {
            if (txt_f_duracion.Text == "")
            {
                MessageBox.Show("Es necesario seleccionar la Duración de la Falta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_f_duracion.Focus();
            }
            else if (txt_f_tipo.Text == "")
            {
                MessageBox.Show("Es necesario seleccionar Tipo de Falta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_f_tipo.Focus();
            }
            else
            {
                if (lbl_f_id.Text == "0")
                {
                    Verifica_exitencia_Falta();
                }
                else
                {
                    Actualiza_Falta();
                    Mostrar_Grid_Faltas();
                }
            }
        }
        private void Btn_f_eliminar_Click(object sender, EventArgs e)
        {
            Elimina_Faltas();
            Mostrar_Grid_Faltas();
        }
        //Métodos 
        private void Verifica_exitencia_Falta()//Verifica si hay una falta
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[SP_Captura_Faltas]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "4";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar,100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_f_fecha.Text;
            da.SelectCommand.Parameters.Add("@FECHA_FINAL", SqlDbType.VarChar, 100).Value = dtm_f_termina.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = txt_f_tipo.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_f_duracion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
            da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value = lbl_f_id.Text;

            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Ya hay una Incidencia dentro de esta fecha, Favor de verificar.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_f_fecha.Focus();
            }
            else
            {
                Verifica_exitencia_Vacaciones();
            }
        }
        private void Verifica_exitencia_Vacaciones()//Verifica si hay vacaciones
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[SP_Captura_Faltas]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "5";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_f_fecha.Text;
            da.SelectCommand.Parameters.Add("@FECHA_FINAL", SqlDbType.VarChar, 100).Value = dtm_f_termina.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = txt_f_tipo.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_f_duracion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
            da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value = lbl_f_id.Text;

            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("El empleado tiene Vacaciones dentro de esta Fecha, Favor de verificar", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_f_fecha.Focus();
            }
            else
            {
                Verifica_exitencia_incapacidades();
            }
        }
        private void Verifica_exitencia_incapacidades()//Verifica si hay incapacidades
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[SP_Captura_Faltas]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "6";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 100).Value = dtm_f_fecha.Text;
            da.SelectCommand.Parameters.Add("@FECHA_FINAL", SqlDbType.VarChar, 100).Value = dtm_f_termina.Text;
            da.SelectCommand.Parameters.Add("@TIPO", SqlDbType.VarChar, 100).Value = txt_f_tipo.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_f_duracion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
            da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar, 100).Value = lbl_f_id.Text;

            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("El empleado tiene Incapacidad dentro de esta Fecha, Favor de verificar.", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_f_fecha.Focus();
            }
            else
            {
                Inserta_Faltas();
                Mostrar_Grid_Faltas();
            }
        }
        private void Mostrar_Grid_Faltas()//Mostrar grid faltas.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Captura_Faltas]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_f_fecha.Text);
                cmd.Parameters.AddWithValue("@FECHA_FINAL", dtm_f_termina.Text);
                cmd.Parameters.AddWithValue("@TIPO", txt_f_tipo.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_f_duracion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_f_id.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_faltas.DataSource = dt;
                Diseño_Grid_Faltas(dgv_faltas);
                dgv_faltas.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dgv_faltas.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Diseño_Grid_Faltas(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//Clave
            dgv.Columns[1].Width = 80;//Inicio
            dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].Width = 80;//Termino
            dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].Width = 70;//Duración
            dgv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[4].Width = 40;//id
            dgv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[5].Width = 160;//tipo
            dgv.Columns[6].Width = 80;//Aplicación
            dgv.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[7].Width = 190;//Espacio
        }
        private void Inserta_Faltas()//Inserta faltas.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Captura_Faltas]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "2");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_f_fecha.Text);
                cmd.Parameters.AddWithValue("@FECHA_FINAL", dtm_f_termina.Text);
                cmd.Parameters.AddWithValue("@TIPO", txt_f_tipo.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_f_duracion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_f_id.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                btn_f_guardar.Enabled = false;
                btn_f_cancelar.Enabled = false;
                dtm_f_fecha.Enabled = false; ;
                txt_f_duracion.Enabled = false;
                cmb_f_tipo.Enabled = false;
                txt_f_tipo.Enabled = false;
                btn_f_insertar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Elimina_Faltas()//Elimina faltas.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Captura_Faltas]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "3");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_f_fecha.Text);
                cmd.Parameters.AddWithValue("@FECHA_FINAL", dtm_f_termina.Text);
                cmd.Parameters.AddWithValue("@TIPO", txt_f_tipo.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_f_duracion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_f_id.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                btn_f_guardar.Enabled = false;
                btn_f_cancelar.Enabled = false;
                dtm_f_fecha.Enabled = false; ;
                txt_f_duracion.Enabled = false;
                cmb_f_tipo.Enabled = false;
                txt_f_tipo.Enabled = false;
                btn_f_eliminar.Enabled = false;
                dtm_f_fecha.Text = "";
                txt_f_duracion.Text = "";
                txt_f_tipo.Text = "";
                cmb_f_tipo.Text = "";
                btn_f_insertar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Actualiza_Falta()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_Captura_Faltas]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "7");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@FECHA", dtm_f_fecha.Text);
                cmd.Parameters.AddWithValue("@FECHA_FINAL", dtm_f_termina.Text);
                cmd.Parameters.AddWithValue("@TIPO", txt_f_tipo.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_f_duracion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);
                cmd.Parameters.AddWithValue("@ID", lbl_f_id.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                btn_f_guardar.Enabled = false;
                btn_f_cancelar.Enabled = false;
                dtm_f_fecha.Enabled = false; ;
                txt_f_duracion.Enabled = false;
                cmb_f_tipo.Enabled = false;
                txt_f_tipo.Enabled = false;
                btn_f_eliminar.Enabled = false;
                dtm_f_fecha.Text = "";
                txt_f_duracion.Text = "";
                txt_f_tipo.Text = "";
                cmb_f_tipo.Text = "";
                btn_f_insertar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Eventos módulo de faltas
        private void Dtm_f_inicia_ValueChanged(object sender, EventArgs e)
        {
            dtm_f_aplicacion.Text = dtm_f_fecha.Text;
        }
        private void Txt_f_duracion_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime Inicia = dtm_f_fecha.Value.Date;
                int dias = Int32.Parse(txt_f_duracion.Text);
                DateTime Final = Inicia.AddDays(dias - 1);
                dtm_f_termina.Text = Final.ToString();
            }
            catch
            {
            }
        }
        private void Dgv_faltas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_faltas.Rows[e.RowIndex];
                dtm_f_fecha.Text = row.Cells["INICIA"].Value.ToString();
                dtm_f_termina.Text = row.Cells["TERMINA"].Value.ToString();
                txt_f_duracion.Text = row.Cells["DURACION"].Value.ToString();
                lbl_f_id.Text = row.Cells["ID"].Value.ToString();
                cmb_f_tipo.Text = row.Cells["TIPO"].Value.ToString();
                dtm_f_fecha.Focus();
            }
        }
        private void Dgv_faltas_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_faltas.CurrentCell != null) { indicef = dgv_faltas.CurrentRow.Index; }
        }
        private void Dgv_faltas_DoubleClick(object sender, EventArgs e)
        {
            if (lbl_estado.Text == "VIGENTE")
            {
                DialogResult resul = MessageBox.Show("¿Desea modificar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    btn_f_guardar.Enabled = true;
                    btn_f_eliminar.Enabled = true;
                    btn_f_cancelar.Enabled = true;
                    dtm_f_fecha.Enabled = true;
                    txt_f_duracion.Enabled = true;
                    cmb_f_tipo.Enabled = true;
                    txt_f_tipo.Enabled = true;
                    dtm_fecha.Focus();
                }
                if (resul == DialogResult.No)
                {
                    btn_f_guardar.Enabled = false;
                    btn_f_eliminar.Enabled = false;
                    btn_f_cancelar.Enabled = false;
                    dtm_f_fecha.Enabled = false;
                    txt_f_duracion.Enabled = false;
                    cmb_f_tipo.Enabled = false;
                    txt_f_tipo.Enabled = false;
                    btn_f_insertar.Focus();
                }
            }
            else
            {
            }
        }
        private void Dgv_faltas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_faltas.Rows[e.RowIndex];
                dtm_f_fecha.Text = row.Cells["INICIA"].Value.ToString();
                dtm_f_termina.Text = row.Cells["TERMINA"].Value.ToString();
                txt_f_duracion.Text = row.Cells["DURACION"].Value.ToString();
                lbl_f_id.Text = row.Cells["ID"].Value.ToString();
                cmb_f_tipo.Text = row.Cells["TIPO"].Value.ToString();
                dtm_f_fecha.Focus();
            }
        }
        private void Txt_f_duracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        private void Exportara_f_Excel()// Método para exportar a excel, múdulo incapacidades.
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
                for (int i = -1; i < dgv_faltas.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_faltas.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_faltas.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_faltas.Rows[i].Cells[j].Value.ToString();
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
        private void Btn_f_exportar_Click(object sender, EventArgs e)
        {
            Exportara_f_Excel();
            dtm_f_fecha.Focus();
        }
        private void Cmb_f_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_f_tipo.Text)
            {
                case "ABANDONO DE TRABAJO": txt_f_tipo.Text = "A"; break;
                case "PRESTACION POR MATRIMONIO": txt_f_tipo.Text = "B"; break;
                case "CITA IMSS": txt_f_tipo.Text = "C"; break;
                case "EMPLEADO VULNERABLE": txt_f_tipo.Text = "D"; break;
                case "ENFERMEDAD": txt_f_tipo.Text = "E"; break;
                case "FALTA INJUSTIFICADA": txt_f_tipo.Text = "F"; break;
                case "PERMISO CON GOCE": txt_f_tipo.Text = "G"; break;
                case "HOME OFFICE": txt_f_tipo.Text = "H"; break;
                case "CONFIRMADO": txt_f_tipo.Text = "J"; break;
                case "CONSULTA SOSPECHOSA": txt_f_tipo.Text = "K"; break;
                case "ENFERMEDAD LEVE": txt_f_tipo.Text = "L"; break;
                case "ENFERMEDAD MODERADA": txt_f_tipo.Text = "M"; break;
                case "SUSPENSION": txt_f_tipo.Text = "N"; break;
                case "SOSPECHOSO ENFERMEDAD": txt_f_tipo.Text = "O"; break;
                case "PERMISO SIN GOCE": txt_f_tipo.Text = "P"; break;
                case "FAMILIAR": txt_f_tipo.Text = "R"; break;
                case "ASUNTOS PERSONALES": txt_f_tipo.Text = "S"; break;
                case "TRANSPORTE": txt_f_tipo.Text = "T"; break;
                case "FALTA JUSTIFICADA": txt_f_tipo.Text = "U"; break;
                case "VIAJE": txt_f_tipo.Text = "V"; break;
            }
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'A' || e.KeyChar == 'a' ||
                e.KeyChar == 'B' || e.KeyChar == 'b' ||
                e.KeyChar == 'C' || e.KeyChar == 'c' ||
                e.KeyChar == 'D' || e.KeyChar == 'd' ||
                e.KeyChar == 'E' || e.KeyChar == 'e' ||
                e.KeyChar == 'F' || e.KeyChar == 'f' ||
                e.KeyChar == 'G' || e.KeyChar == 'g' ||
                e.KeyChar == 'H' || e.KeyChar == 'h' ||
                e.KeyChar == 'J' || e.KeyChar == 'j' ||
                e.KeyChar == 'K' || e.KeyChar == 'k' ||
                e.KeyChar == 'L' || e.KeyChar == 'l' ||
                e.KeyChar == 'M' || e.KeyChar == 'm' ||
                e.KeyChar == 'N' || e.KeyChar == 'n' ||
                e.KeyChar == 'O' || e.KeyChar == 'o' ||
                e.KeyChar == 'P' || e.KeyChar == 'p' ||
                e.KeyChar == 'R' || e.KeyChar == 'r' ||
                e.KeyChar == 'S' || e.KeyChar == 's' ||
                e.KeyChar == 'T' || e.KeyChar == 't' ||
                e.KeyChar == 'U' || e.KeyChar == 'u' ||
                e.KeyChar == 'V' || e.KeyChar == 'v')
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else
                e.Handled = true;
        }
        private void Txt_f_tipo_TextChanged(object sender, EventArgs e)
        {
            if (txt_f_tipo.Text == "")
            {
                cmb_f_tipo.Text = "";
            }
            else
            {
                switch (txt_f_tipo.Text)
                {
                    case "A": cmb_f_tipo.Text = "ABANDONO DE TRABAJO"; break;
                    case "B": cmb_f_tipo.Text = "PRESTACION POR MATRIMONIO"; break;
                    case "C": cmb_f_tipo.Text = "CITA IMSS"; break;
                    case "D": cmb_f_tipo.Text = "EMPLEADO VULNERABLE"; break;
                    case "E": cmb_f_tipo.Text = "ENFERMEDAD"; break;
                    case "F": cmb_f_tipo.Text = "FALTA INJUSTIFICADA"; break;
                    case "G": cmb_f_tipo.Text = "PERMISO CON GOCE"; break;
                    case "H": cmb_f_tipo.Text = "HOME OFFICE"; break;
                    case "J": cmb_f_tipo.Text = "CONFIRMADO"; break;
                    case "K": cmb_f_tipo.Text = "CONSULTA SOSPECHOSA"; break;
                    case "L": cmb_f_tipo.Text = "ENFERMEDAD LEVE"; break;
                    case "M": cmb_f_tipo.Text = "ENFERMEDAD MODERADA"; break;
                    case "N": cmb_f_tipo.Text = "SUSPENSION"; break;
                    case "O": cmb_f_tipo.Text = "SOSPECHOSO ENFERMEDAD"; break;
                    case "P": cmb_f_tipo.Text = "PERMISO SIN GOCE"; break;
                    case "R": cmb_f_tipo.Text = "FAMILIAR"; break;
                    case "S": cmb_f_tipo.Text = "ASUNTOS PERSONALES"; break;
                    case "T": cmb_f_tipo.Text = "TRANSPORTE"; break;
                    case "U": cmb_f_tipo.Text = "FALTA JUSTIFICADA"; break;
                    case "V": cmb_f_tipo.Text = "VIAJE"; break;
                }
            }
        }
        private void Cmb_f_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }


        //Botones módulo de vacaciones
        private void Btn_v_insertar_Click(object sender, EventArgs e)
        {
            dtm_v_inicia.Text = "";
            txt_v_duracion.Text = "";
            dtm_v_termina.Text = "";
            txt_v_prima.Text = "";
            btn_v_guardar.Enabled = true;
            dtm_v_inicia.Enabled = true;
            txt_v_duracion.Enabled = true;
            txt_v_prima.Enabled = true;
            txt_v_duracion.Enabled = true;
            txt_v_antiguedad.Enabled = true;
            btn_v_cancelar.Enabled = true;
            lbl_v_inicia.Text = "0";
            lbl_v_termina.Text = "0";
            dtm_v_inicia.Focus();
        }
        private void Btn_v_cancelar_Click(object sender, EventArgs e)
        {
            dtm_v_inicia.Text = "";
            dtm_v_termina.Text = "";
            txt_v_duracion.Text = "";
            txt_v_prima.Text = "";
            lbl_v_inicia.Text = "0";
            lbl_v_termina.Text = "0";
            dtm_v_inicia.Focus();
        }
        private void Btn_v_exportar_Click(object sender, EventArgs e)
        {
            Exportara_v_Excel();
        }
        private void Btn_v_primero_Click(object sender, EventArgs e)
        {
            dgv_vacaciones.CurrentCell = dgv_vacaciones.Rows[0].Cells[dgv_vacaciones.CurrentCell.ColumnIndex];
            btn_v_anterior.Enabled = false;
            btn_v_primero.Enabled = false;
            btn_v_siguiente.Enabled = true;
            btn_v_ultimo.Enabled = true;
            btn_v_guardar.Enabled = false;
            btn_v_cancelar.Enabled = false;
            dtm_v_inicia.Focus();
        }
        private void Btn_v_anterior_Click(object sender, EventArgs e)
        {
            int Anterior = indice - 1;

            try
            {
                dgv_vacaciones.CurrentCell = dgv_vacaciones.Rows[Anterior].Cells[dgv_vacaciones.CurrentCell.ColumnIndex];
                btn_v_siguiente.Enabled = true;
                btn_v_ultimo.Enabled = true;
                btn_v_guardar.Enabled = false;
                btn_v_cancelar.Enabled = false;
                dtm_v_inicia.Focus();
            }
            catch
            {
                btn_v_anterior.Enabled = false;
                btn_v_primero.Enabled = false;
                btn_v_guardar.Enabled = false;
                btn_v_cancelar.Enabled = false;
                dtm_v_inicia.Focus();
            }
        }
        private void Btn_v_siguiente_Click(object sender, EventArgs e)
        {
            int Siguiente = indice + 1;
            try
            {
                dgv_vacaciones.CurrentCell = dgv_vacaciones.Rows[Siguiente].Cells[dgv_vacaciones.CurrentCell.ColumnIndex];
                btn_v_anterior.Enabled = true;
                btn_v_primero.Enabled = true;
                btn_v_guardar.Enabled = false;
                btn_v_cancelar.Enabled = false;
                dtm_v_inicia.Focus();
            }
            catch
            {
                btn_v_siguiente.Enabled = false;
                btn_v_ultimo.Enabled = false;
                btn_v_guardar.Enabled = false;
                btn_v_cancelar.Enabled = false;
                MessageBox.Show("Llegó al final!", "Aviso");
                dtm_v_inicia.Focus();
            }
        }
        private void Btn_v_ultimo_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_vacaciones.CurrentCell = dgv_vacaciones.Rows[50].Cells[dgv_vacaciones.CurrentCell.ColumnIndex];
                btn_v_siguiente.Enabled = false;
                btn_v_ultimo.Enabled = false;
                btn_v_anterior.Enabled = true;
                btn_v_primero.Enabled = true;
                btn_v_guardar.Enabled = false;
                btn_v_cancelar.Enabled = false;
                dtm_v_inicia.Focus();
            }
            catch
            {
            }
        }
        private void Btn_v_guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_v_duracion.Text))
            {
                MessageBox.Show("Es necesario capturar la duración", "¡Aviso!");
                txt_v_duracion.Focus();
            }
            else if ((int.Parse(txt_v_duracion.Text)) > (int.Parse(lbl_x_pagar.Text)))
            {
                MessageBox.Show("Días solicitados Insuficientes", "¡Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_v_duracion.Focus();
            }
            else if (lbl_v_id.Text == "0")
            {
                Verifica_v_vacaciones();
            }
            else if (lbl_v_id.Text == "1")
            {
                Actualiza_v_vacaciones();
                Mostrar_Grid_Vacaciones();
                cargar_dias();
                calcula_prima();
                dtm_v_inicia.Text = "";
                dtm_v_termina.Text = "";
                txt_v_duracion.Text = "";
                dtm_v_termina.Text = "";
                lbl_v_id.Text = "0";
                lbl_v_inicia.Text = "0";
                lbl_v_termina.Text = "0";
                dtm_v_inicia.Focus();
            }
            else if (txt_v_duracion.Text == "0")
            {
                MessageBox.Show("Es necesario capturar la duración", "¡Aviso!");
                txt_v_duracion.Focus();
            }
        }
        private void Btn_v_eliminar_Click(object sender, EventArgs e)
        {
            Borra_v_vacaciones();
            Mostrar_Grid_Vacaciones();
            cargar_dias();
            calcula_prima();
            dtm_v_inicia.Text = "";
            dtm_v_termina.Text = "";
            txt_v_duracion.Text = "";
            dtm_v_termina.Text = "";
            lbl_v_id.Text = "0";
            lbl_v_inicia.Text = "0";
            lbl_v_termina.Text = "0";
            dtm_v_inicia.Focus();
        }

        //Métodos módulo de vacaciones
        private void Exportara_v_Excel()// Método para exportar a excel, múdulo vacaciones.
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
                for (int i = -1; i < dgv_vacaciones.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_vacaciones.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_vacaciones.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_vacaciones.Rows[i].Cells[j].Value.ToString();
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
        private void Mostrar_Grid_Vacaciones()//Mostrar grid de incapacidades.
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[Sp_Captura_Vacaciones]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VAR", "1");
                cmd.Parameters.AddWithValue("@CLAVE", txt_clave.Text);
                cmd.Parameters.AddWithValue("@INICIA", dtm_v_inicia.Text);
                cmd.Parameters.AddWithValue("@TERMINA", dtm_v_termina.Text);
                cmd.Parameters.AddWithValue("@DURACION", txt_v_duracion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", claseEmp.IdEmpleado);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_vacaciones.DataSource = dt;
               Diseño_Grid_Vacaciones(dgv_vacaciones);
                dgv_vacaciones.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dgv_vacaciones.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cargar_dias()
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[Sp_Captura_Vacaciones]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "2";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@INICIA", SqlDbType.VarChar, 100).Value = dtm_v_inicia.Text;
            da.SelectCommand.Parameters.Add("@TERMINA", SqlDbType.VarChar, 100).Value = dtm_v_termina.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_v_duracion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
    
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                lbl_x_pagar.Text = dt.Rows[0]["DIAS"].ToString();
                lbl_x_disfrutar.Text = dt.Rows[0]["DIAS"].ToString();
            }
            con.Close();
        }
        private void calcula_prima()
        {
                Duracion = double.Parse(lbl_x_pagar.Text);
                Prima = double.Parse("0.35");
                Resultado = Duracion * Prima;
                lbl_prima.Text = Resultado.ToString();
        }
        private void Diseño_Grid_Vacaciones(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//Clave
            dgv.Columns[1].Width = 80;//Inicio
            dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].Width = 80;//Termino
            dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].Width = 70;//Duracion
            dgv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[4].Width = 50;//Prima
            dgv.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[5].Width = 100;//Pagadas
            dgv.Columns[6].Width = 100;//disfrutadas
            dgv.Columns[7].Width = 220;//espacio
            dgv.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Verifica_v_vacaciones()//Verifica si hay vacaciones
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[Sp_Captura_Vacaciones]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "3";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@INICIA", SqlDbType.VarChar, 100).Value = dtm_v_inicia.Text;
            da.SelectCommand.Parameters.Add("@TERMINA", SqlDbType.VarChar, 100).Value = dtm_v_termina.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_v_duracion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;

            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("El empleado tiene vacaciones en esta Fecha, Favor de Verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_v_inicia.Focus();
            }
            else
            {
              Verifica_v_incapacidad();
            }
        }
        private void Verifica_v_incapacidad()//Verifica si hay incapacidad
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[Sp_Captura_Vacaciones]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "4";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@INICIA", SqlDbType.VarChar, 100).Value = dtm_v_inicia.Text;
            da.SelectCommand.Parameters.Add("@TERMINA", SqlDbType.VarChar, 100).Value = dtm_v_termina.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_v_duracion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("El empleado tiene incapacidad en esta Fecha, Favor de Verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtm_v_inicia.Focus();
            }
            else
            {
                Verifica_v_falta();
            }
        }
        private void Verifica_v_falta()//Verifica si hay falta
        {
            DataTable dt = new DataTable();
            String strSql;
            strSql = "[dbo].[Sp_Captura_Vacaciones]";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            con.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "5";
            da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
            da.SelectCommand.Parameters.Add("@INICIA", SqlDbType.VarChar, 100).Value = dtm_v_inicia.Text;
            da.SelectCommand.Parameters.Add("@TERMINA", SqlDbType.VarChar, 100).Value = dtm_v_termina.Text;
            da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_v_duracion.Text;
            da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                DialogResult resul = MessageBox.Show("El empleado tiene una incidencia dentro de esta Fecha, ¿Desea eliminar la incidencia?", "¡Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    Borra_v_incidencia();
                    Mostrar_Grid_Faltas();
                    Inserta_vacaciones();
                    Mostrar_Grid_Vacaciones();
                    cargar_dias();
                    calcula_prima();
                    dtm_v_inicia.Text = "";
                    dtm_v_termina.Text = "";
                    txt_v_duracion.Text = "";
                    dtm_v_termina.Text = "";
                    lbl_v_id.Text = "0";
                    dtm_v_inicia.Focus();
                }
                else if (resul == DialogResult.No)
                {
                    dtm_v_inicia.Focus();
                }
            }
            else
            {
                Inserta_vacaciones();
                Mostrar_Grid_Vacaciones();
                cargar_dias();
                calcula_prima();
                dtm_v_inicia.Text = "";
                dtm_v_termina.Text = "";
                txt_v_duracion.Text = "";
                dtm_v_termina.Text = "";
                lbl_v_id.Text = "0";
                dtm_v_inicia.Focus();
            }
        }
        private void Inserta_vacaciones()//inserta vacaciones
        {
            try
            {
                DataTable dt = new DataTable();
                String strSql;
                strSql = "[dbo].[Sp_Captura_Vacaciones]";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "7";
                da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
                da.SelectCommand.Parameters.Add("@INICIA", SqlDbType.VarChar, 100).Value = dtm_v_inicia.Text;
                da.SelectCommand.Parameters.Add("@TERMINA", SqlDbType.VarChar, 100).Value = dtm_v_termina.Text;
                da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_v_duracion.Text;
                da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
                da.Fill(dt);
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error al insertar incidencia");
            }
        }
        private void Borra_v_incidencia()//Borra incidencia
        {
            try
            {
                DataTable dt = new DataTable();
                String strSql;
                strSql = "[dbo].[Sp_Captura_Vacaciones]";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "6";
                da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
                da.SelectCommand.Parameters.Add("@INICIA", SqlDbType.VarChar, 100).Value = dtm_v_inicia.Text;
                da.SelectCommand.Parameters.Add("@TERMINA", SqlDbType.VarChar, 100).Value = dtm_v_termina.Text;
                da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_v_duracion.Text;
                da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
                da.Fill(dt);
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error al borrar incidencia");
            }    
        }
        private void Borra_v_vacaciones()//Borra vacaciones
        {
            try
            {
                DataTable dt = new DataTable();
                String strSql;
                strSql = "[dbo].[Sp_Captura_Vacaciones]";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "8";
                da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
                da.SelectCommand.Parameters.Add("@INICIA", SqlDbType.VarChar, 100).Value = dtm_v_inicia.Text;
                da.SelectCommand.Parameters.Add("@TERMINA", SqlDbType.VarChar, 100).Value = dtm_v_termina.Text;
                da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_v_duracion.Text;
                da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
                da.Fill(dt);
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error al borrar vacaciones");
            }
        }
        private void Actualiza_v_vacaciones()//actualiza vacaciones
        {
            try
            {
                DataTable dt = new DataTable();
                String strSql;
                strSql = "[dbo].[Sp_Captura_Vacaciones]";
                SqlDataAdapter da = new SqlDataAdapter(strSql, con);
                con.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@VAR", SqlDbType.VarChar, 100).Value = "9";
                da.SelectCommand.Parameters.Add("@CLAVE", SqlDbType.VarChar, 100).Value = txt_clave.Text;
                da.SelectCommand.Parameters.Add("@INICIA", SqlDbType.VarChar, 100).Value = lbl_v_inicia.Text;
                da.SelectCommand.Parameters.Add("@TERMINA", SqlDbType.VarChar, 100).Value = lbl_v_termina.Text;
                da.SelectCommand.Parameters.Add("@DURACION", SqlDbType.VarChar, 100).Value = txt_v_duracion.Text;
                da.SelectCommand.Parameters.Add("@USUARIO", SqlDbType.VarChar, 100).Value = claseEmp.IdEmpleado;
                da.Fill(dt);
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error al borrar vacaciones");
            }
        }

        //Eventos módulo de vacaciones
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Label3_Click(object sender, EventArgs e)
        {
        }
        private void Label5_Click(object sender, EventArgs e)
        {
        }
        private void Txt_duracion_TextChanged(object sender, EventArgs e)
        {
        }
        private void Dtm_termina_ValueChanged(object sender, EventArgs e)
        {
        }
        private void Label7_Click(object sender, EventArgs e)
        {
        }
        private void Label8_Click(object sender, EventArgs e)
        {
        }
        private void Dtm_aplicacion_ValueChanged(object sender, EventArgs e)
        {
        }
        private void Label9_Click(object sender, EventArgs e)
        {
        }
        private void Cmb_caso_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Label6_Click(object sender, EventArgs e)
        {
        }
        private void Cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Txt_certificado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        private void Label4_Click(object sender, EventArgs e)
        {
        }
        private void Lbl_id_Click(object sender, EventArgs e)
        {
        }
        private void Txt_v_duracion_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime Inicia = dtm_v_inicia.Value.Date;
                int dias = Int32.Parse(txt_v_duracion.Text);
                DateTime Final = Inicia.AddDays(dias - 1);
                dtm_v_termina.Text = Final.ToString();

                Duracion = double.Parse(txt_v_duracion.Text);
                Prima = double.Parse("0.35");
                Resultado = Duracion * Prima;
                txt_v_prima.Text = Resultado.ToString();
            }
            catch
            {
            }
        }
        private void Txt_v_duracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        private void Txt_v_prima_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Txt_v_duracion_TextChanged(object sender, EventArgs e)
        {
            if (txt_v_duracion.Text == "")
            {
                txt_v_prima.Text = "";
            }
        }
        private void Txt_v_antiguedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Dgv_vacaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_vacaciones.Rows[e.RowIndex];
                dtm_v_inicia.Text = row.Cells["INICIA"].Value.ToString();
                txt_v_duracion.Text = row.Cells["DURACION"].Value.ToString();
                txt_v_prima.Text = row.Cells["PRIMA"].Value.ToString();
                dtm_v_termina.Text = row.Cells["TERMINA"].Value.ToString();
                dtm_fecha.Focus();
            }
        }
        private void Dgv_vacaciones_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_vacaciones.CurrentCell != null) { indice = dgv_vacaciones.CurrentRow.Index; }
        }
        private void Dgv_vacaciones_DoubleClick(object sender, EventArgs e)
        {
            if (lbl_estado.Text == "VIGENTE")
            {
                DialogResult resul = MessageBox.Show("¿Desea modificar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    btn_v_guardar.Enabled = true;
                    btn_v_eliminar.Enabled = true;
                    btn_v_cancelar.Enabled = true;
                    dtm_v_inicia.Enabled = true;
                    txt_v_duracion.Enabled = true;
                    txt_v_prima.Enabled = true;
                    lbl_v_id.Text = "1";
                    lbl_v_inicia.Text = dtm_v_inicia.Text;
                    lbl_v_termina.Text = dtm_v_termina.Text;
                    dtm_v_inicia.Focus();

                }
                if (resul == DialogResult.No)
                {
                    btn_v_guardar.Enabled = false;
                    btn_v_eliminar.Enabled = false;
                    btn_v_cancelar.Enabled = false;
                    dtm_v_inicia.Enabled = false;
                    txt_v_duracion.Enabled = false;
                    dtm_v_inicia.Focus();
                    lbl_v_id.Text = "0";
                }
            }
            else
            {
            }
        }
        private void Dgv_vacaciones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_vacaciones.Rows[e.RowIndex];
                dtm_v_inicia.Text = row.Cells["INICIA"].Value.ToString();
                txt_v_duracion.Text = row.Cells["DURACION"].Value.ToString();
                txt_v_prima.Text = row.Cells["PRIMA"].Value.ToString();
                dtm_v_termina.Text = row.Cells["TERMINA"].Value.ToString();
                dtm_fecha.Focus();
            }
        }
        private void TabPage2_Click(object sender, EventArgs e)
        {
            btn_v_insertar.Focus();
        }   
    }  
}
