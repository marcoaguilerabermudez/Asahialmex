namespace CsPresentacion
{
    partial class Ausentismo_Global
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtm_fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.dgv_acumulado = new System.Windows.Forms.DataGridView();
            this.btn_exportar_ant2 = new System.Windows.Forms.Button();
            this.txt_depto = new System.Windows.Forms.TextBox();
            this.lbl_plan = new System.Windows.Forms.Label();
            this.lbl_activos = new System.Windows.Forms.Label();
            this.lbl_incidencias = new System.Windows.Forms.Label();
            this.lbl_reporte = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_falta_injus = new System.Windows.Forms.Label();
            this.lbl_falta_just = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_pcon_goce = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_psin_goce = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_suspension = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_incapacidades = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_vacaciones = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_total_incapacidades = new System.Windows.Forms.Label();
            this.lbl_total_suspension = new System.Windows.Forms.Label();
            this.lbl_total_p_singoce = new System.Windows.Forms.Label();
            this.lbl_total_p_congoce = new System.Windows.Forms.Label();
            this.lbl_total_f_justificada = new System.Windows.Forms.Label();
            this.lbl_total_f_injustificadas = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_total_vacaciones = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_turno1 = new System.Windows.Forms.Label();
            this.lbl_adtvo = new System.Windows.Forms.Label();
            this.lbl_turno3 = new System.Windows.Forms.Label();
            this.lbl_turno2 = new System.Windows.Forms.Label();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acumulado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.dtm_fecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(-1, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 69);
            this.panel1.TabIndex = 143;
            // 
            // dtm_fecha
            // 
            this.dtm_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_fecha.Location = new System.Drawing.Point(18, 45);
            this.dtm_fecha.Name = "dtm_fecha";
            this.dtm_fecha.Size = new System.Drawing.Size(125, 20);
            this.dtm_fecha.TabIndex = 20;
            this.dtm_fecha.ValueChanged += new System.EventHandler(this.Dtm_fecha_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "FECHA:";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(148, 42);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 26;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // dgv_acumulado
            // 
            this.dgv_acumulado.AllowUserToAddRows = false;
            this.dgv_acumulado.AllowUserToDeleteRows = false;
            this.dgv_acumulado.AllowUserToResizeColumns = false;
            this.dgv_acumulado.AllowUserToResizeRows = false;
            this.dgv_acumulado.BackgroundColor = System.Drawing.Color.White;
            this.dgv_acumulado.CausesValidation = false;
            this.dgv_acumulado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_acumulado.Location = new System.Drawing.Point(15, 68);
            this.dgv_acumulado.MultiSelect = false;
            this.dgv_acumulado.Name = "dgv_acumulado";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_acumulado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_acumulado.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_acumulado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_acumulado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_acumulado.ShowCellErrors = false;
            this.dgv_acumulado.Size = new System.Drawing.Size(646, 575);
            this.dgv_acumulado.TabIndex = 0;
            this.dgv_acumulado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_acumulado_CellContentClick);
            this.dgv_acumulado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dgv_acumulado_CellFormatting);
            this.dgv_acumulado.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_acumulado_RowEnter);
            this.dgv_acumulado.DoubleClick += new System.EventHandler(this.Dgv_acumulado_DoubleClick);
            // 
            // btn_exportar_ant2
            // 
            this.btn_exportar_ant2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar_ant2.FlatAppearance.BorderSize = 0;
            this.btn_exportar_ant2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar_ant2.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar_ant2.Location = new System.Drawing.Point(670, 600);
            this.btn_exportar_ant2.Name = "btn_exportar_ant2";
            this.btn_exportar_ant2.Size = new System.Drawing.Size(40, 34);
            this.btn_exportar_ant2.TabIndex = 191;
            this.btn_exportar_ant2.UseVisualStyleBackColor = true;
            this.btn_exportar_ant2.Click += new System.EventHandler(this.Btn_exportar_ant2_Click);
            // 
            // txt_depto
            // 
            this.txt_depto.Location = new System.Drawing.Point(21, 650);
            this.txt_depto.Name = "txt_depto";
            this.txt_depto.Size = new System.Drawing.Size(81, 20);
            this.txt_depto.TabIndex = 193;
            // 
            // lbl_plan
            // 
            this.lbl_plan.AutoSize = true;
            this.lbl_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plan.Location = new System.Drawing.Point(190, 656);
            this.lbl_plan.Name = "lbl_plan";
            this.lbl_plan.Size = new System.Drawing.Size(21, 13);
            this.lbl_plan.TabIndex = 194;
            this.lbl_plan.Text = "00";
            // 
            // lbl_activos
            // 
            this.lbl_activos.AutoSize = true;
            this.lbl_activos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activos.Location = new System.Drawing.Point(242, 656);
            this.lbl_activos.Name = "lbl_activos";
            this.lbl_activos.Size = new System.Drawing.Size(21, 13);
            this.lbl_activos.TabIndex = 195;
            this.lbl_activos.Text = "00";
            // 
            // lbl_incidencias
            // 
            this.lbl_incidencias.AutoSize = true;
            this.lbl_incidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incidencias.Location = new System.Drawing.Point(604, 656);
            this.lbl_incidencias.Name = "lbl_incidencias";
            this.lbl_incidencias.Size = new System.Drawing.Size(21, 13);
            this.lbl_incidencias.TabIndex = 196;
            this.lbl_incidencias.Text = "00";
            // 
            // lbl_reporte
            // 
            this.lbl_reporte.AutoSize = true;
            this.lbl_reporte.Location = new System.Drawing.Point(18, 51);
            this.lbl_reporte.Name = "lbl_reporte";
            this.lbl_reporte.Size = new System.Drawing.Size(130, 13);
            this.lbl_reporte.TabIndex = 197;
            this.lbl_reporte.Text = "REPORTE DIA DE AYER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 198;
            this.label2.Text = "FALTA INJUSTIFICADA:";
            // 
            // lbl_falta_injus
            // 
            this.lbl_falta_injus.AutoSize = true;
            this.lbl_falta_injus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_falta_injus.Location = new System.Drawing.Point(826, 103);
            this.lbl_falta_injus.Name = "lbl_falta_injus";
            this.lbl_falta_injus.Size = new System.Drawing.Size(19, 13);
            this.lbl_falta_injus.TabIndex = 199;
            this.lbl_falta_injus.Text = "00";
            // 
            // lbl_falta_just
            // 
            this.lbl_falta_just.AutoSize = true;
            this.lbl_falta_just.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_falta_just.Location = new System.Drawing.Point(826, 130);
            this.lbl_falta_just.Name = "lbl_falta_just";
            this.lbl_falta_just.Size = new System.Drawing.Size(19, 13);
            this.lbl_falta_just.TabIndex = 201;
            this.lbl_falta_just.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 200;
            this.label5.Text = "FALTA JUSTIFICADA:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_pcon_goce
            // 
            this.lbl_pcon_goce.AutoSize = true;
            this.lbl_pcon_goce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pcon_goce.Location = new System.Drawing.Point(826, 159);
            this.lbl_pcon_goce.Name = "lbl_pcon_goce";
            this.lbl_pcon_goce.Size = new System.Drawing.Size(19, 13);
            this.lbl_pcon_goce.TabIndex = 203;
            this.lbl_pcon_goce.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 202;
            this.label7.Text = "PERMISO CON GOCE:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_psin_goce
            // 
            this.lbl_psin_goce.AutoSize = true;
            this.lbl_psin_goce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_psin_goce.Location = new System.Drawing.Point(826, 187);
            this.lbl_psin_goce.Name = "lbl_psin_goce";
            this.lbl_psin_goce.Size = new System.Drawing.Size(19, 13);
            this.lbl_psin_goce.TabIndex = 205;
            this.lbl_psin_goce.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 204;
            this.label9.Text = "PERMISO SIN GOCE:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_suspension
            // 
            this.lbl_suspension.AutoSize = true;
            this.lbl_suspension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suspension.Location = new System.Drawing.Point(826, 215);
            this.lbl_suspension.Name = "lbl_suspension";
            this.lbl_suspension.Size = new System.Drawing.Size(19, 13);
            this.lbl_suspension.TabIndex = 207;
            this.lbl_suspension.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 206;
            this.label11.Text = "SUSPENSIÓN:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_incapacidades
            // 
            this.lbl_incapacidades.AutoSize = true;
            this.lbl_incapacidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_incapacidades.Location = new System.Drawing.Point(826, 241);
            this.lbl_incapacidades.Name = "lbl_incapacidades";
            this.lbl_incapacidades.Size = new System.Drawing.Size(19, 13);
            this.lbl_incapacidades.TabIndex = 209;
            this.lbl_incapacidades.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 208;
            this.label13.Text = "INCAPACIDADES:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_vacaciones);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(678, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 221);
            this.groupBox1.TabIndex = 210;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departamento";
            // 
            // lbl_vacaciones
            // 
            this.lbl_vacaciones.AutoSize = true;
            this.lbl_vacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vacaciones.Location = new System.Drawing.Point(148, 194);
            this.lbl_vacaciones.Name = "lbl_vacaciones";
            this.lbl_vacaciones.Size = new System.Drawing.Size(19, 13);
            this.lbl_vacaciones.TabIndex = 212;
            this.lbl_vacaciones.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 211;
            this.label4.Text = "VACACIONES:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_total_incapacidades
            // 
            this.lbl_total_incapacidades.AutoSize = true;
            this.lbl_total_incapacidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_incapacidades.Location = new System.Drawing.Point(826, 470);
            this.lbl_total_incapacidades.Name = "lbl_total_incapacidades";
            this.lbl_total_incapacidades.Size = new System.Drawing.Size(19, 13);
            this.lbl_total_incapacidades.TabIndex = 218;
            this.lbl_total_incapacidades.Text = "00";
            // 
            // lbl_total_suspension
            // 
            this.lbl_total_suspension.AutoSize = true;
            this.lbl_total_suspension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_suspension.Location = new System.Drawing.Point(826, 444);
            this.lbl_total_suspension.Name = "lbl_total_suspension";
            this.lbl_total_suspension.Size = new System.Drawing.Size(19, 13);
            this.lbl_total_suspension.TabIndex = 217;
            this.lbl_total_suspension.Text = "00";
            // 
            // lbl_total_p_singoce
            // 
            this.lbl_total_p_singoce.AutoSize = true;
            this.lbl_total_p_singoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_p_singoce.Location = new System.Drawing.Point(826, 416);
            this.lbl_total_p_singoce.Name = "lbl_total_p_singoce";
            this.lbl_total_p_singoce.Size = new System.Drawing.Size(19, 13);
            this.lbl_total_p_singoce.TabIndex = 216;
            this.lbl_total_p_singoce.Text = "00";
            // 
            // lbl_total_p_congoce
            // 
            this.lbl_total_p_congoce.AutoSize = true;
            this.lbl_total_p_congoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_p_congoce.Location = new System.Drawing.Point(826, 388);
            this.lbl_total_p_congoce.Name = "lbl_total_p_congoce";
            this.lbl_total_p_congoce.Size = new System.Drawing.Size(19, 13);
            this.lbl_total_p_congoce.TabIndex = 215;
            this.lbl_total_p_congoce.Text = "00";
            // 
            // lbl_total_f_justificada
            // 
            this.lbl_total_f_justificada.AutoSize = true;
            this.lbl_total_f_justificada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_f_justificada.Location = new System.Drawing.Point(826, 359);
            this.lbl_total_f_justificada.Name = "lbl_total_f_justificada";
            this.lbl_total_f_justificada.Size = new System.Drawing.Size(19, 13);
            this.lbl_total_f_justificada.TabIndex = 214;
            this.lbl_total_f_justificada.Text = "00";
            // 
            // lbl_total_f_injustificadas
            // 
            this.lbl_total_f_injustificadas.AutoSize = true;
            this.lbl_total_f_injustificadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_f_injustificadas.Location = new System.Drawing.Point(826, 332);
            this.lbl_total_f_injustificadas.Name = "lbl_total_f_injustificadas";
            this.lbl_total_f_injustificadas.Size = new System.Drawing.Size(19, 13);
            this.lbl_total_f_injustificadas.TabIndex = 213;
            this.lbl_total_f_injustificadas.Text = "00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(685, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 13);
            this.label15.TabIndex = 212;
            this.label15.Text = "FALTA INJUSTIFICADA:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_total_vacaciones);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(678, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 207);
            this.groupBox2.TabIndex = 219;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TOTAL";
            // 
            // lbl_total_vacaciones
            // 
            this.lbl_total_vacaciones.AutoSize = true;
            this.lbl_total_vacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_vacaciones.Location = new System.Drawing.Point(148, 182);
            this.lbl_total_vacaciones.Name = "lbl_total_vacaciones";
            this.lbl_total_vacaciones.Size = new System.Drawing.Size(19, 13);
            this.lbl_total_vacaciones.TabIndex = 212;
            this.lbl_total_vacaciones.Text = "00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(36, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 208;
            this.label17.Text = "INCAPACIDADES:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(54, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 211;
            this.label18.Text = "VACACIONES:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 13);
            this.label19.TabIndex = 200;
            this.label19.Text = "FALTA JUSTIFICADA:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(52, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 13);
            this.label20.TabIndex = 206;
            this.label20.Text = "SUSPENSIÓN:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(14, 76);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 13);
            this.label21.TabIndex = 202;
            this.label21.Text = "PERMISO CON GOCE:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(19, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 13);
            this.label22.TabIndex = 204;
            this.label22.Text = "PERMISO SIN GOCE:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_turno1
            // 
            this.lbl_turno1.AutoSize = true;
            this.lbl_turno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turno1.Location = new System.Drawing.Point(375, 656);
            this.lbl_turno1.Name = "lbl_turno1";
            this.lbl_turno1.Size = new System.Drawing.Size(21, 13);
            this.lbl_turno1.TabIndex = 221;
            this.lbl_turno1.Text = "00";
            // 
            // lbl_adtvo
            // 
            this.lbl_adtvo.AutoSize = true;
            this.lbl_adtvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adtvo.Location = new System.Drawing.Point(313, 656);
            this.lbl_adtvo.Name = "lbl_adtvo";
            this.lbl_adtvo.Size = new System.Drawing.Size(21, 13);
            this.lbl_adtvo.TabIndex = 220;
            this.lbl_adtvo.Text = "00";
            // 
            // lbl_turno3
            // 
            this.lbl_turno3.AutoSize = true;
            this.lbl_turno3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turno3.Location = new System.Drawing.Point(528, 656);
            this.lbl_turno3.Name = "lbl_turno3";
            this.lbl_turno3.Size = new System.Drawing.Size(21, 13);
            this.lbl_turno3.TabIndex = 223;
            this.lbl_turno3.Text = "00";
            // 
            // lbl_turno2
            // 
            this.lbl_turno2.AutoSize = true;
            this.lbl_turno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turno2.Location = new System.Drawing.Point(450, 656);
            this.lbl_turno2.Name = "lbl_turno2";
            this.lbl_turno2.Size = new System.Drawing.Size(21, 13);
            this.lbl_turno2.TabIndex = 222;
            this.lbl_turno2.Text = "00";
            // 
            // btn_reporte
            // 
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.Image = global::CsPresentacion.Properties.Resources.Adobe_PDF_Document_icon;
            this.btn_reporte.Location = new System.Drawing.Point(671, 552);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(40, 34);
            this.btn_reporte.TabIndex = 224;
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Ausentismo_Global
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 684);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.lbl_turno3);
            this.Controls.Add(this.lbl_turno2);
            this.Controls.Add(this.lbl_turno1);
            this.Controls.Add(this.lbl_adtvo);
            this.Controls.Add(this.lbl_total_incapacidades);
            this.Controls.Add(this.lbl_total_suspension);
            this.Controls.Add(this.lbl_total_p_singoce);
            this.Controls.Add(this.lbl_total_p_congoce);
            this.Controls.Add(this.lbl_total_f_justificada);
            this.Controls.Add(this.lbl_total_f_injustificadas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_incapacidades);
            this.Controls.Add(this.lbl_suspension);
            this.Controls.Add(this.lbl_psin_goce);
            this.Controls.Add(this.lbl_pcon_goce);
            this.Controls.Add(this.lbl_falta_just);
            this.Controls.Add(this.lbl_falta_injus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_reporte);
            this.Controls.Add(this.lbl_incidencias);
            this.Controls.Add(this.lbl_activos);
            this.Controls.Add(this.lbl_plan);
            this.Controls.Add(this.txt_depto);
            this.Controls.Add(this.btn_exportar_ant2);
            this.Controls.Add(this.dgv_acumulado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ausentismo_Global";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ausentismo Global";
            this.Load += new System.EventHandler(this.Ausentismo_Global_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_acumulado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_acumulado;
        private System.Windows.Forms.Button btn_exportar_ant2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtm_fecha;
        private System.Windows.Forms.TextBox txt_depto;
        private System.Windows.Forms.Label lbl_plan;
        private System.Windows.Forms.Label lbl_activos;
        private System.Windows.Forms.Label lbl_incidencias;
        private System.Windows.Forms.Label lbl_reporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_falta_injus;
        private System.Windows.Forms.Label lbl_falta_just;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_pcon_goce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_psin_goce;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_suspension;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_incapacidades;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_vacaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_total_incapacidades;
        private System.Windows.Forms.Label lbl_total_suspension;
        private System.Windows.Forms.Label lbl_total_p_singoce;
        private System.Windows.Forms.Label lbl_total_p_congoce;
        private System.Windows.Forms.Label lbl_total_f_justificada;
        private System.Windows.Forms.Label lbl_total_f_injustificadas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_total_vacaciones;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl_turno1;
        private System.Windows.Forms.Label lbl_adtvo;
        private System.Windows.Forms.Label lbl_turno3;
        private System.Windows.Forms.Label lbl_turno2;
        private System.Windows.Forms.Button btn_reporte;
    }
}