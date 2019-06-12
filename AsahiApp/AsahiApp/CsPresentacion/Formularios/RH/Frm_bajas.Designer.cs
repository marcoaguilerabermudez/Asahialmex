namespace CsPresentacion
{
    partial class Frm_bajas
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.txt_vigencia = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_curp = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_baja_3 = new System.Windows.Forms.TextBox();
            this.cmb_Civil = new System.Windows.Forms.ComboBox();
            this.cmb_genero = new System.Windows.Forms.ComboBox();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_municipio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_afiliacion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_reingreso_2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_puesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.lbl_reingreso = new System.Windows.Forms.Label();
            this.lbl_baja = new System.Windows.Forms.Label();
            this.txt_alta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.l_fecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_baja = new System.Windows.Forms.TextBox();
            this.txt_reingreso = new System.Windows.Forms.TextBox();
            this.l_hora = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_baja_2 = new System.Windows.Forms.TextBox();
            this.lbl_motivo = new System.Windows.Forms.Label();
            this.txt_meses = new System.Windows.Forms.TextBox();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.txt_dias = new System.Windows.Forms.TextBox();
            this.lbl_meses = new System.Windows.Forms.Label();
            this.lbl_años = new System.Windows.Forms.Label();
            this.txt_años = new System.Windows.Forms.TextBox();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_colonia = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.dtm_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_clave);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(-3, -26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 67);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "EMPLEADO:";
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(22, 45);
            this.txt_clave.MaxLength = 5;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(84, 20);
            this.txt_clave.TabIndex = 0;
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_clave_KeyPress);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(112, 42);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(18, 23);
            this.btn_nuevo.TabIndex = 147;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // cmb_estado
            // 
            this.cmb_estado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "AGU",
            "BCN",
            "BCS",
            "CAM",
            "CHP",
            "CHH",
            "CMX",
            "COA",
            "COL",
            "DUR",
            "GUA",
            "GRO",
            "HID",
            "JAL",
            "MEX",
            "MIC",
            "MOR",
            "NAY",
            "NLE",
            "OAX",
            "PUE",
            "QUE",
            "ROO",
            "SLP",
            "SIN",
            "SON",
            "TAB",
            "TAM",
            "TLA",
            "VER",
            "YUC",
            "ZAC"});
            this.cmb_estado.Location = new System.Drawing.Point(196, 188);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(70, 21);
            this.cmb_estado.TabIndex = 6;
            this.cmb_estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_estado_KeyPress);
            // 
            // txt_vigencia
            // 
            this.txt_vigencia.Location = new System.Drawing.Point(430, 232);
            this.txt_vigencia.Name = "txt_vigencia";
            this.txt_vigencia.Size = new System.Drawing.Size(130, 20);
            this.txt_vigencia.TabIndex = 146;
            this.txt_vigencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 372);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 143;
            this.label19.Text = "SUELDO:";
            // 
            // txt_curp
            // 
            this.txt_curp.Location = new System.Drawing.Point(20, 307);
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(150, 20);
            this.txt_curp.TabIndex = 12;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(468, 216);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(54, 13);
            this.lbl_estado.TabIndex = 145;
            this.lbl_estado.Text = "ESTADO:";
            // 
            // txt_baja_3
            // 
            this.txt_baja_3.ForeColor = System.Drawing.Color.Black;
            this.txt_baja_3.Location = new System.Drawing.Point(368, 29);
            this.txt_baja_3.MaxLength = 8;
            this.txt_baja_3.Name = "txt_baja_3";
            this.txt_baja_3.Size = new System.Drawing.Size(68, 20);
            this.txt_baja_3.TabIndex = 21;
            // 
            // cmb_Civil
            // 
            this.cmb_Civil.FormattingEnabled = true;
            this.cmb_Civil.Items.AddRange(new object[] {
            "VIU",
            "SOL",
            "CAS",
            "ULI",
            "DIV"});
            this.cmb_Civil.Location = new System.Drawing.Point(196, 227);
            this.cmb_Civil.Name = "cmb_Civil";
            this.cmb_Civil.Size = new System.Drawing.Size(70, 21);
            this.cmb_Civil.TabIndex = 8;
            this.cmb_Civil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_Civil_KeyPress);
            // 
            // cmb_genero
            // 
            this.cmb_genero.FormattingEnabled = true;
            this.cmb_genero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmb_genero.Location = new System.Drawing.Point(284, 227);
            this.cmb_genero.Name = "cmb_genero";
            this.cmb_genero.Size = new System.Drawing.Size(65, 21);
            this.cmb_genero.TabIndex = 9;
            this.cmb_genero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_genero_KeyPress);
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.Location = new System.Drawing.Point(19, 388);
            this.txt_sueldo.MaxLength = 8;
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.Size = new System.Drawing.Size(70, 20);
            this.txt_sueldo.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 291);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 141;
            this.label18.Text = "CURP:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(20, 227);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(150, 20);
            this.txt_telefono.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 134;
            this.label15.Text = "TELEFONO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(196, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 133;
            this.label14.Text = "ESTADO:";
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(20, 109);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(149, 20);
            this.txt_calle.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 131;
            this.label13.Text = "CALLE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 126;
            this.label10.Text = "MUNICIPIO:";
            // 
            // txt_municipio
            // 
            this.txt_municipio.Location = new System.Drawing.Point(20, 188);
            this.txt_municipio.Name = "txt_municipio";
            this.txt_municipio.Size = new System.Drawing.Size(150, 20);
            this.txt_municipio.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "REINGRESO 2:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(198, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 139;
            this.label16.Text = "AFILIACION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "BAJA 2:";
            // 
            // txt_afiliacion
            // 
            this.txt_afiliacion.Location = new System.Drawing.Point(196, 267);
            this.txt_afiliacion.Name = "txt_afiliacion";
            this.txt_afiliacion.Size = new System.Drawing.Size(152, 20);
            this.txt_afiliacion.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 137;
            this.label17.Text = "RFC:";
            // 
            // txt_reingreso_2
            // 
            this.txt_reingreso_2.ForeColor = System.Drawing.Color.Black;
            this.txt_reingreso_2.Location = new System.Drawing.Point(279, 29);
            this.txt_reingreso_2.MaxLength = 8;
            this.txt_reingreso_2.Name = "txt_reingreso_2";
            this.txt_reingreso_2.Size = new System.Drawing.Size(68, 20);
            this.txt_reingreso_2.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 129;
            this.label12.Text = "GEN:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 128;
            this.label11.Text = "E_CIVIL";
            // 
            // txt_puesto
            // 
            this.txt_puesto.Location = new System.Drawing.Point(196, 348);
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.Size = new System.Drawing.Size(153, 20);
            this.txt_puesto.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "PUESTO:";
            // 
            // txt_departamento
            // 
            this.txt_departamento.Location = new System.Drawing.Point(20, 348);
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.Size = new System.Drawing.Size(150, 20);
            this.txt_departamento.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "BAJA 3:";
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(19, 264);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(151, 20);
            this.txt_rfc.TabIndex = 10;
            // 
            // lbl_reingreso
            // 
            this.lbl_reingreso.AutoSize = true;
            this.lbl_reingreso.Location = new System.Drawing.Point(106, 462);
            this.lbl_reingreso.Name = "lbl_reingreso";
            this.lbl_reingreso.Size = new System.Drawing.Size(74, 13);
            this.lbl_reingreso.TabIndex = 125;
            this.lbl_reingreso.Text = "REINGRESO:";
            // 
            // lbl_baja
            // 
            this.lbl_baja.AutoSize = true;
            this.lbl_baja.Location = new System.Drawing.Point(16, 462);
            this.lbl_baja.Name = "lbl_baja";
            this.lbl_baja.Size = new System.Drawing.Size(74, 13);
            this.lbl_baja.TabIndex = 124;
            this.lbl_baja.Text = "FECHA BAJA:";
            // 
            // txt_alta
            // 
            this.txt_alta.Location = new System.Drawing.Point(19, 429);
            this.txt_alta.MaxLength = 8;
            this.txt_alta.Name = "txt_alta";
            this.txt_alta.Size = new System.Drawing.Size(70, 20);
            this.txt_alta.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "FECHA ALTA:";
            // 
            // l_fecha
            // 
            this.l_fecha.AutoSize = true;
            this.l_fecha.BackColor = System.Drawing.Color.SteelBlue;
            this.l_fecha.ForeColor = System.Drawing.Color.White;
            this.l_fecha.Location = new System.Drawing.Point(456, 16);
            this.l_fecha.Name = "l_fecha";
            this.l_fecha.Size = new System.Drawing.Size(40, 13);
            this.l_fecha.TabIndex = 114;
            this.l_fecha.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "DEPARTAMENTO:";
            // 
            // txt_baja
            // 
            this.txt_baja.ForeColor = System.Drawing.Color.Black;
            this.txt_baja.Location = new System.Drawing.Point(11, 29);
            this.txt_baja.MaxLength = 8;
            this.txt_baja.Name = "txt_baja";
            this.txt_baja.Size = new System.Drawing.Size(70, 20);
            this.txt_baja.TabIndex = 17;
            // 
            // txt_reingreso
            // 
            this.txt_reingreso.ForeColor = System.Drawing.Color.Black;
            this.txt_reingreso.Location = new System.Drawing.Point(100, 29);
            this.txt_reingreso.MaxLength = 8;
            this.txt_reingreso.Name = "txt_reingreso";
            this.txt_reingreso.Size = new System.Drawing.Size(61, 20);
            this.txt_reingreso.TabIndex = 18;
            // 
            // l_hora
            // 
            this.l_hora.AutoSize = true;
            this.l_hora.BackColor = System.Drawing.Color.SteelBlue;
            this.l_hora.ForeColor = System.Drawing.Color.White;
            this.l_hora.Location = new System.Drawing.Point(520, 16);
            this.l_hora.Name = "l_hora";
            this.l_hora.Size = new System.Drawing.Size(40, 13);
            this.l_hora.TabIndex = 115;
            this.l_hora.Text = "Fecha:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(20, 70);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(295, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(19, 54);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(57, 13);
            this.lbl_nombre.TabIndex = 116;
            this.lbl_nombre.Text = "NOMBRE:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_baja);
            this.groupBox1.Controls.Add(this.txt_reingreso_2);
            this.groupBox1.Controls.Add(this.txt_reingreso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_baja_2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_baja_3);
            this.groupBox1.Location = new System.Drawing.Point(8, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 63);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            // 
            // txt_baja_2
            // 
            this.txt_baja_2.ForeColor = System.Drawing.Color.Black;
            this.txt_baja_2.Location = new System.Drawing.Point(190, 29);
            this.txt_baja_2.MaxLength = 8;
            this.txt_baja_2.Name = "txt_baja_2";
            this.txt_baja_2.Size = new System.Drawing.Size(68, 20);
            this.txt_baja_2.TabIndex = 19;
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.AutoSize = true;
            this.lbl_motivo.Location = new System.Drawing.Point(16, 529);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(81, 13);
            this.lbl_motivo.TabIndex = 152;
            this.lbl_motivo.Text = "MOTIVO BAJA:";
            // 
            // txt_meses
            // 
            this.txt_meses.ForeColor = System.Drawing.Color.Black;
            this.txt_meses.Location = new System.Drawing.Point(287, 546);
            this.txt_meses.MaxLength = 8;
            this.txt_meses.Name = "txt_meses";
            this.txt_meses.Size = new System.Drawing.Size(68, 20);
            this.txt_meses.TabIndex = 24;
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Location = new System.Drawing.Point(194, 529);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(35, 13);
            this.lbl_dias.TabIndex = 154;
            this.lbl_dias.Text = "DIAS:";
            // 
            // txt_dias
            // 
            this.txt_dias.ForeColor = System.Drawing.Color.Black;
            this.txt_dias.Location = new System.Drawing.Point(197, 545);
            this.txt_dias.MaxLength = 8;
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(68, 20);
            this.txt_dias.TabIndex = 23;
            // 
            // lbl_meses
            // 
            this.lbl_meses.AutoSize = true;
            this.lbl_meses.Location = new System.Drawing.Point(283, 529);
            this.lbl_meses.Name = "lbl_meses";
            this.lbl_meses.Size = new System.Drawing.Size(47, 13);
            this.lbl_meses.TabIndex = 156;
            this.lbl_meses.Text = "MESES:";
            // 
            // lbl_años
            // 
            this.lbl_años.AutoSize = true;
            this.lbl_años.Location = new System.Drawing.Point(372, 529);
            this.lbl_años.Name = "lbl_años";
            this.lbl_años.Size = new System.Drawing.Size(40, 13);
            this.lbl_años.TabIndex = 158;
            this.lbl_años.Text = "AÑOS:";
            // 
            // txt_años
            // 
            this.txt_años.ForeColor = System.Drawing.Color.Black;
            this.txt_años.Location = new System.Drawing.Point(377, 546);
            this.txt_años.MaxLength = 8;
            this.txt_años.Name = "txt_años";
            this.txt_años.Size = new System.Drawing.Size(67, 20);
            this.txt_años.TabIndex = 25;
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(19, 546);
            this.txt_motivo.MaxLength = 8;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(151, 20);
            this.txt_motivo.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.White;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(510, 455);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(18, 23);
            this.btn_buscar.TabIndex = 148;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_baja.FlatAppearance.BorderSize = 0;
            this.btn_baja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_baja.Location = new System.Drawing.Point(461, 533);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(86, 34);
            this.btn_baja.TabIndex = 151;
            this.btn_baja.Text = "Aplicar Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.Btn_baja_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(430, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(196, 109);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(69, 20);
            this.txt_numero.TabIndex = 3;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_numero_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 161;
            this.label5.Text = "NUMERO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 162;
            this.label6.Text = "COLONIA:";
            // 
            // txt_colonia
            // 
            this.txt_colonia.Location = new System.Drawing.Point(20, 148);
            this.txt_colonia.Name = "txt_colonia";
            this.txt_colonia.Size = new System.Drawing.Size(149, 20);
            this.txt_colonia.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(196, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 164;
            this.label20.Text = "C.P";
            // 
            // txt_cp
            // 
            this.txt_cp.Location = new System.Drawing.Point(196, 148);
            this.txt_cp.MaxLength = 8;
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(69, 20);
            this.txt_cp.TabIndex = 163;
            this.txt_cp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_cp_KeyPress);
            // 
            // dtm_nacimiento
            // 
            this.dtm_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_nacimiento.Location = new System.Drawing.Point(196, 307);
            this.dtm_nacimiento.Name = "dtm_nacimiento";
            this.dtm_nacimiento.Size = new System.Drawing.Size(152, 20);
            this.dtm_nacimiento.TabIndex = 166;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(194, 290);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 13);
            this.label21.TabIndex = 165;
            this.label21.Text = "FECHA NACIMIENTO:";
            // 
            // Frm_bajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 577);
            this.Controls.Add(this.dtm_nacimiento);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(this.txt_colonia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_motivo);
            this.Controls.Add(this.txt_meses);
            this.Controls.Add(this.lbl_dias);
            this.Controls.Add(this.txt_dias);
            this.Controls.Add(this.lbl_meses);
            this.Controls.Add(this.lbl_años);
            this.Controls.Add(this.txt_años);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.txt_vigencia);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_curp);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.cmb_Civil);
            this.Controls.Add(this.cmb_genero);
            this.Controls.Add(this.txt_sueldo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_municipio);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_afiliacion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_puesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_departamento);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_reingreso);
            this.Controls.Add(this.lbl_baja);
            this.Controls.Add(this.txt_alta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l_fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_hora);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_bajas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de Empleado";
            this.Load += new System.EventHandler(this.Frm_bajas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.TextBox txt_vigencia;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_curp;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_baja_3;
        private System.Windows.Forms.ComboBox cmb_Civil;
        private System.Windows.Forms.ComboBox cmb_genero;
        private System.Windows.Forms.TextBox txt_sueldo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_municipio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_afiliacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_reingreso_2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_puesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_reingreso;
        private System.Windows.Forms.Label lbl_baja;
        private System.Windows.Forms.TextBox txt_alta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_baja;
        private System.Windows.Forms.TextBox txt_reingreso;
        private System.Windows.Forms.Label l_hora;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_baja_2;
        private System.Windows.Forms.Button btn_nuevo;
        public System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Label lbl_motivo;
        private System.Windows.Forms.TextBox txt_meses;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.TextBox txt_dias;
        private System.Windows.Forms.Label lbl_meses;
        private System.Windows.Forms.Label lbl_años;
        private System.Windows.Forms.TextBox txt_años;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_colonia;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.DateTimePicker dtm_nacimiento;
        private System.Windows.Forms.Label label21;
    }
}