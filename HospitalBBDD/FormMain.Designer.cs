namespace HospitalBBDD
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idatencLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label medicoLabel;
            System.Windows.Forms.Label lblPaciente;
            System.Windows.Forms.Label especialidadLabel;
            System.Windows.Forms.Label idmedicoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label movilLabel;
            System.Windows.Forms.Label especialidadLabel1;
            System.Windows.Forms.Label idpacienteLabel;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label apellidosLabel1;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label alergiasLabel;
            System.Windows.Forms.Label adestacarLabel;
            System.Windows.Forms.Label idmedicoLabel2;
            System.Windows.Forms.Label nombreLabel2;
            System.Windows.Forms.Label especialidadLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlInformativo = new System.Windows.Forms.Panel();
            this.lblCif = new System.Windows.Forms.Label();
            this.lblTlfn = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.lblDatosHospital = new System.Windows.Forms.Label();
            this.pcbLogoHospital = new System.Windows.Forms.PictureBox();
            this.pnlAtencion = new System.Windows.Forms.Panel();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.cmbMedico = new System.Windows.Forms.ComboBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new HospitalBBDD.dsBD();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblIdAtencion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNueva = new System.Windows.Forms.Label();
            this.especialidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.atencsmedicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.atencsmedicasTableAdapter = new HospitalBBDD.dsBDTableAdapters.atencsmedicasTableAdapter();
            this.tableAdapterManager = new HospitalBBDD.dsBDTableAdapters.TableAdapterManager();
            this.especialidadesTableAdapter = new HospitalBBDD.dsBDTableAdapters.especialidadesTableAdapter();
            this.medicosTableAdapter = new HospitalBBDD.dsBDTableAdapters.medicosTableAdapter();
            this.pacientesTableAdapter = new HospitalBBDD.dsBDTableAdapters.pacientesTableAdapter();
            this.pnlMedicos = new System.Windows.Forms.Panel();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.txtApellidosMedico = new System.Windows.Forms.TextBox();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.lblIdMedico = new System.Windows.Forms.Label();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.pcbMedico = new System.Windows.Forms.PictureBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.pnlPacientes = new System.Windows.Forms.Panel();
            this.txtDestacar = new System.Windows.Forms.TextBox();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtApellidosPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.pcbPaciente = new System.Windows.Forms.PictureBox();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.especialidadLabel3 = new System.Windows.Forms.Label();
            this.idmedicoLabel3 = new System.Windows.Forms.Label();
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            this.pcbCitas = new System.Windows.Forms.PictureBox();
            this.lblCitas = new System.Windows.Forms.Label();
            this.pnlHoraDia = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.btnPacientesMedico = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.timeNow = new System.Windows.Forms.Timer(this.components);
            idatencLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            medicoLabel = new System.Windows.Forms.Label();
            lblPaciente = new System.Windows.Forms.Label();
            especialidadLabel = new System.Windows.Forms.Label();
            idmedicoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            movilLabel = new System.Windows.Forms.Label();
            especialidadLabel1 = new System.Windows.Forms.Label();
            idpacienteLabel = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            apellidosLabel1 = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            alergiasLabel = new System.Windows.Forms.Label();
            adestacarLabel = new System.Windows.Forms.Label();
            idmedicoLabel2 = new System.Windows.Forms.Label();
            nombreLabel2 = new System.Windows.Forms.Label();
            especialidadLabel2 = new System.Windows.Forms.Label();
            this.pnlInformativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoHospital)).BeginInit();
            this.pnlAtencion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencsmedicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.pnlMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMedico)).BeginInit();
            this.pnlPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaciente)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCitas)).BeginInit();
            this.pnlHoraDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // idatencLabel
            // 
            idatencLabel.AutoSize = true;
            idatencLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idatencLabel.Location = new System.Drawing.Point(201, 29);
            idatencLabel.Name = "idatencLabel";
            idatencLabel.Size = new System.Drawing.Size(59, 13);
            idatencLabel.TabIndex = 1;
            idatencLabel.Text = "Id Atenc:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(201, 64);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(46, 13);
            fechaLabel.TabIndex = 3;
            fechaLabel.Text = "Fecha:";
            // 
            // medicoLabel
            // 
            medicoLabel.AutoSize = true;
            medicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medicoLabel.Location = new System.Drawing.Point(201, 132);
            medicoLabel.Name = "medicoLabel";
            medicoLabel.Size = new System.Drawing.Size(52, 13);
            medicoLabel.TabIndex = 5;
            medicoLabel.Text = "Médico:";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPaciente.Location = new System.Drawing.Point(201, 168);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new System.Drawing.Size(61, 13);
            lblPaciente.TabIndex = 7;
            lblPaciente.Text = "Paciente:";
            // 
            // especialidadLabel
            // 
            especialidadLabel.AutoSize = true;
            especialidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            especialidadLabel.Location = new System.Drawing.Point(201, 95);
            especialidadLabel.Name = "especialidadLabel";
            especialidadLabel.Size = new System.Drawing.Size(83, 13);
            especialidadLabel.TabIndex = 9;
            especialidadLabel.Text = "Especialidad:";
            // 
            // idmedicoLabel
            // 
            idmedicoLabel.AutoSize = true;
            idmedicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idmedicoLabel.Location = new System.Drawing.Point(127, 33);
            idmedicoLabel.Name = "idmedicoLabel";
            idmedicoLabel.Size = new System.Drawing.Size(67, 13);
            idmedicoLabel.TabIndex = 1;
            idmedicoLabel.Text = "Id Médico:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(127, 62);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(54, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidosLabel.Location = new System.Drawing.Point(127, 88);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(62, 13);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "Apellidos:";
            // 
            // movilLabel
            // 
            movilLabel.AutoSize = true;
            movilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            movilLabel.Location = new System.Drawing.Point(127, 114);
            movilLabel.Name = "movilLabel";
            movilLabel.Size = new System.Drawing.Size(41, 13);
            movilLabel.TabIndex = 7;
            movilLabel.Text = "Móvil:";
            // 
            // especialidadLabel1
            // 
            especialidadLabel1.AutoSize = true;
            especialidadLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            especialidadLabel1.Location = new System.Drawing.Point(127, 140);
            especialidadLabel1.Name = "especialidadLabel1";
            especialidadLabel1.Size = new System.Drawing.Size(83, 13);
            especialidadLabel1.TabIndex = 9;
            especialidadLabel1.Text = "Especialidad:";
            // 
            // idpacienteLabel
            // 
            idpacienteLabel.AutoSize = true;
            idpacienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idpacienteLabel.Location = new System.Drawing.Point(127, 35);
            idpacienteLabel.Name = "idpacienteLabel";
            idpacienteLabel.Size = new System.Drawing.Size(76, 13);
            idpacienteLabel.TabIndex = 0;
            idpacienteLabel.Text = "Id Paciente:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel1.Location = new System.Drawing.Point(127, 64);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(54, 13);
            nombreLabel1.TabIndex = 2;
            nombreLabel1.Text = "Nombre:";
            // 
            // apellidosLabel1
            // 
            apellidosLabel1.AutoSize = true;
            apellidosLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidosLabel1.Location = new System.Drawing.Point(127, 90);
            apellidosLabel1.Name = "apellidosLabel1";
            apellidosLabel1.Size = new System.Drawing.Size(62, 13);
            apellidosLabel1.TabIndex = 4;
            apellidosLabel1.Text = "Apellidos:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localidadLabel.Location = new System.Drawing.Point(127, 116);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(66, 13);
            localidadLabel.TabIndex = 6;
            localidadLabel.Text = "Localidad:";
            // 
            // alergiasLabel
            // 
            alergiasLabel.AutoSize = true;
            alergiasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alergiasLabel.Location = new System.Drawing.Point(127, 142);
            alergiasLabel.Name = "alergiasLabel";
            alergiasLabel.Size = new System.Drawing.Size(56, 13);
            alergiasLabel.TabIndex = 8;
            alergiasLabel.Text = "Alergias:";
            // 
            // adestacarLabel
            // 
            adestacarLabel.AutoSize = true;
            adestacarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adestacarLabel.Location = new System.Drawing.Point(127, 200);
            adestacarLabel.Name = "adestacarLabel";
            adestacarLabel.Size = new System.Drawing.Size(74, 13);
            adestacarLabel.TabIndex = 10;
            adestacarLabel.Text = "A Destacar:";
            // 
            // idmedicoLabel2
            // 
            idmedicoLabel2.AutoSize = true;
            idmedicoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idmedicoLabel2.Location = new System.Drawing.Point(137, 94);
            idmedicoLabel2.Name = "idmedicoLabel2";
            idmedicoLabel2.Size = new System.Drawing.Size(63, 13);
            idmedicoLabel2.TabIndex = 2;
            idmedicoLabel2.Text = "Id Médico";
            // 
            // nombreLabel2
            // 
            nombreLabel2.AutoSize = true;
            nombreLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel2.Location = new System.Drawing.Point(137, 35);
            nombreLabel2.Name = "nombreLabel2";
            nombreLabel2.Size = new System.Drawing.Size(52, 13);
            nombreLabel2.TabIndex = 4;
            nombreLabel2.Text = "Médico:";
            // 
            // especialidadLabel2
            // 
            especialidadLabel2.AutoSize = true;
            especialidadLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            especialidadLabel2.Location = new System.Drawing.Point(137, 64);
            especialidadLabel2.Name = "especialidadLabel2";
            especialidadLabel2.Size = new System.Drawing.Size(83, 13);
            especialidadLabel2.TabIndex = 6;
            especialidadLabel2.Text = "Especialidad:";
            // 
            // pnlInformativo
            // 
            this.pnlInformativo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlInformativo.Controls.Add(this.lblCif);
            this.pnlInformativo.Controls.Add(this.lblTlfn);
            this.pnlInformativo.Controls.Add(this.lblCalle);
            this.pnlInformativo.Controls.Add(this.lblHospital);
            this.pnlInformativo.Controls.Add(this.lblDatosHospital);
            this.pnlInformativo.Controls.Add(this.pcbLogoHospital);
            this.pnlInformativo.Location = new System.Drawing.Point(13, 12);
            this.pnlInformativo.Name = "pnlInformativo";
            this.pnlInformativo.Size = new System.Drawing.Size(355, 148);
            this.pnlInformativo.TabIndex = 0;
            // 
            // lblCif
            // 
            this.lblCif.AutoSize = true;
            this.lblCif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCif.Location = new System.Drawing.Point(161, 123);
            this.lblCif.Name = "lblCif";
            this.lblCif.Size = new System.Drawing.Size(111, 13);
            this.lblCif.TabIndex = 5;
            this.lblCif.Text = "CIF - A13131313Q";
            // 
            // lblTlfn
            // 
            this.lblTlfn.AutoSize = true;
            this.lblTlfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTlfn.Location = new System.Drawing.Point(161, 89);
            this.lblTlfn.Name = "lblTlfn";
            this.lblTlfn.Size = new System.Drawing.Size(144, 13);
            this.lblTlfn.TabIndex = 4;
            this.lblTlfn.Text = "Teléfono.- 926 20 00 00";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(161, 58);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(184, 13);
            this.lblCalle.TabIndex = 3;
            this.lblCalle.Text = "C/ La Salud Nº 7 - 13005 -C.R.";
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospital.Location = new System.Drawing.Point(161, 29);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(130, 13);
            this.lblHospital.TabIndex = 2;
            this.lblHospital.Text = "HOSPITAL GENERAL";
            // 
            // lblDatosHospital
            // 
            this.lblDatosHospital.AutoSize = true;
            this.lblDatosHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosHospital.Location = new System.Drawing.Point(15, 10);
            this.lblDatosHospital.Name = "lblDatosHospital";
            this.lblDatosHospital.Size = new System.Drawing.Size(111, 13);
            this.lblDatosHospital.TabIndex = 1;
            this.lblDatosHospital.Text = "Datos del Hospital";
            // 
            // pcbLogoHospital
            // 
            this.pcbLogoHospital.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogoHospital.Image")));
            this.pcbLogoHospital.Location = new System.Drawing.Point(15, 29);
            this.pcbLogoHospital.Name = "pcbLogoHospital";
            this.pcbLogoHospital.Size = new System.Drawing.Size(111, 107);
            this.pcbLogoHospital.TabIndex = 0;
            this.pcbLogoHospital.TabStop = false;
            // 
            // pnlAtencion
            // 
            this.pnlAtencion.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlAtencion.Controls.Add(this.cmbPaciente);
            this.pnlAtencion.Controls.Add(this.cmbMedico);
            this.pnlAtencion.Controls.Add(this.cmbEspecialidad);
            this.pnlAtencion.Controls.Add(this.dtpFecha);
            this.pnlAtencion.Controls.Add(this.lblIdAtencion);
            this.pnlAtencion.Controls.Add(this.pictureBox1);
            this.pnlAtencion.Controls.Add(this.btnAdd);
            this.pnlAtencion.Controls.Add(especialidadLabel);
            this.pnlAtencion.Controls.Add(idatencLabel);
            this.pnlAtencion.Controls.Add(fechaLabel);
            this.pnlAtencion.Controls.Add(medicoLabel);
            this.pnlAtencion.Controls.Add(lblPaciente);
            this.pnlAtencion.Controls.Add(this.lblNueva);
            this.pnlAtencion.Location = new System.Drawing.Point(441, 12);
            this.pnlAtencion.Name = "pnlAtencion";
            this.pnlAtencion.Size = new System.Drawing.Size(668, 247);
            this.pnlAtencion.TabIndex = 1;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.Enabled = false;
            this.cmbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(295, 165);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(200, 21);
            this.cmbPaciente.TabIndex = 17;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // cmbMedico
            // 
            this.cmbMedico.Enabled = false;
            this.cmbMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedico.FormattingEnabled = true;
            this.cmbMedico.Location = new System.Drawing.Point(295, 129);
            this.cmbMedico.Name = "cmbMedico";
            this.cmbMedico.Size = new System.Drawing.Size(200, 21);
            this.cmbMedico.TabIndex = 16;
            this.cmbMedico.SelectedIndexChanged += new System.EventHandler(this.cmbMedico_SelectedIndexChanged);
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DataSource = this.especialidadesBindingSource;
            this.cmbEspecialidad.DisplayMember = "especialidad";
            this.cmbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(295, 92);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(200, 21);
            this.cmbEspecialidad.TabIndex = 15;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "especialidades";
            this.especialidadesBindingSource.DataSource = this.dsBD;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(295, 58);
            this.dtpFecha.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2020, 11, 20, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 14;
            this.dtpFecha.Value = new System.DateTime(2020, 11, 20, 0, 0, 0, 0);
            // 
            // lblIdAtencion
            // 
            this.lblIdAtencion.AutoSize = true;
            this.lblIdAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAtencion.Location = new System.Drawing.Point(292, 29);
            this.lblIdAtencion.Name = "lblIdAtencion";
            this.lblIdAtencion.Size = new System.Drawing.Size(41, 13);
            this.lblIdAtencion.TabIndex = 13;
            this.lblIdAtencion.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 159);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(171, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(211, 40);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Añadir Cita";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblNueva
            // 
            this.lblNueva.AutoSize = true;
            this.lblNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.Location = new System.Drawing.Point(22, 13);
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Size = new System.Drawing.Size(143, 13);
            this.lblNueva.TabIndex = 0;
            this.lblNueva.Text = "Nueva Atención Médica";
            // 
            // especialidadesBindingSource1
            // 
            this.especialidadesBindingSource1.DataMember = "especialidades";
            this.especialidadesBindingSource1.DataSource = this.dsBD;
            // 
            // atencsmedicasBindingSource
            // 
            this.atencsmedicasBindingSource.DataMember = "atencsmedicas";
            this.atencsmedicasBindingSource.DataSource = this.dsBD;
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "medicos";
            this.medicosBindingSource.DataSource = this.dsBD;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.dsBD;
            // 
            // atencsmedicasTableAdapter
            // 
            this.atencsmedicasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.atencsmedicasTableAdapter = this.atencsmedicasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.especialidadesTableAdapter = this.especialidadesTableAdapter;
            this.tableAdapterManager.medicosTableAdapter = this.medicosTableAdapter;
            this.tableAdapterManager.pacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = HospitalBBDD.dsBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // pnlMedicos
            // 
            this.pnlMedicos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMedicos.Controls.Add(this.txtEspecialidad);
            this.pnlMedicos.Controls.Add(this.txtMovil);
            this.pnlMedicos.Controls.Add(this.txtApellidosMedico);
            this.pnlMedicos.Controls.Add(this.txtNombreMedico);
            this.pnlMedicos.Controls.Add(this.lblIdMedico);
            this.pnlMedicos.Controls.Add(this.btnMedicos);
            this.pnlMedicos.Controls.Add(this.pcbMedico);
            this.pnlMedicos.Controls.Add(idmedicoLabel);
            this.pnlMedicos.Controls.Add(nombreLabel);
            this.pnlMedicos.Controls.Add(apellidosLabel);
            this.pnlMedicos.Controls.Add(movilLabel);
            this.pnlMedicos.Controls.Add(especialidadLabel1);
            this.pnlMedicos.Controls.Add(this.lblMedico);
            this.pnlMedicos.Location = new System.Drawing.Point(13, 180);
            this.pnlMedicos.Name = "pnlMedicos";
            this.pnlMedicos.Size = new System.Drawing.Size(355, 209);
            this.pnlMedicos.TabIndex = 2;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.Location = new System.Drawing.Point(214, 137);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(128, 20);
            this.txtEspecialidad.TabIndex = 17;
            // 
            // txtMovil
            // 
            this.txtMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovil.Location = new System.Drawing.Point(214, 111);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.ReadOnly = true;
            this.txtMovil.Size = new System.Drawing.Size(128, 20);
            this.txtMovil.TabIndex = 16;
            // 
            // txtApellidosMedico
            // 
            this.txtApellidosMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosMedico.Location = new System.Drawing.Point(214, 85);
            this.txtApellidosMedico.Name = "txtApellidosMedico";
            this.txtApellidosMedico.ReadOnly = true;
            this.txtApellidosMedico.Size = new System.Drawing.Size(128, 20);
            this.txtApellidosMedico.TabIndex = 15;
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMedico.Location = new System.Drawing.Point(214, 59);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.ReadOnly = true;
            this.txtNombreMedico.Size = new System.Drawing.Size(128, 20);
            this.txtNombreMedico.TabIndex = 14;
            // 
            // lblIdMedico
            // 
            this.lblIdMedico.AutoSize = true;
            this.lblIdMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMedico.Location = new System.Drawing.Point(214, 33);
            this.lblIdMedico.Name = "lblIdMedico";
            this.lblIdMedico.Size = new System.Drawing.Size(0, 13);
            this.lblIdMedico.TabIndex = 13;
            // 
            // btnMedicos
            // 
            this.btnMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.Location = new System.Drawing.Point(99, 163);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(153, 33);
            this.btnMedicos.TabIndex = 12;
            this.btnMedicos.Text = "Gestión de Médicos";
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // pcbMedico
            // 
            this.pcbMedico.Location = new System.Drawing.Point(21, 33);
            this.pcbMedico.Name = "pcbMedico";
            this.pcbMedico.Size = new System.Drawing.Size(100, 124);
            this.pcbMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMedico.TabIndex = 11;
            this.pcbMedico.TabStop = false;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(49, 16);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(48, 13);
            this.lblMedico.TabIndex = 0;
            this.lblMedico.Text = "Médico";
            // 
            // pnlPacientes
            // 
            this.pnlPacientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPacientes.Controls.Add(this.txtDestacar);
            this.pnlPacientes.Controls.Add(this.txtAlergias);
            this.pnlPacientes.Controls.Add(this.txtLocalidad);
            this.pnlPacientes.Controls.Add(this.txtApellidosPaciente);
            this.pnlPacientes.Controls.Add(this.txtNombrePaciente);
            this.pnlPacientes.Controls.Add(this.lblIdPaciente);
            this.pnlPacientes.Controls.Add(this.btnPacientes);
            this.pnlPacientes.Controls.Add(this.pcbPaciente);
            this.pnlPacientes.Controls.Add(this.lblPacientes);
            this.pnlPacientes.Controls.Add(idpacienteLabel);
            this.pnlPacientes.Controls.Add(nombreLabel1);
            this.pnlPacientes.Controls.Add(apellidosLabel1);
            this.pnlPacientes.Controls.Add(localidadLabel);
            this.pnlPacientes.Controls.Add(alergiasLabel);
            this.pnlPacientes.Controls.Add(adestacarLabel);
            this.pnlPacientes.Location = new System.Drawing.Point(13, 412);
            this.pnlPacientes.Name = "pnlPacientes";
            this.pnlPacientes.Size = new System.Drawing.Size(355, 266);
            this.pnlPacientes.TabIndex = 3;
            // 
            // txtDestacar
            // 
            this.txtDestacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestacar.Location = new System.Drawing.Point(214, 197);
            this.txtDestacar.Multiline = true;
            this.txtDestacar.Name = "txtDestacar";
            this.txtDestacar.ReadOnly = true;
            this.txtDestacar.Size = new System.Drawing.Size(128, 53);
            this.txtDestacar.TabIndex = 20;
            // 
            // txtAlergias
            // 
            this.txtAlergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlergias.Location = new System.Drawing.Point(214, 139);
            this.txtAlergias.Multiline = true;
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.ReadOnly = true;
            this.txtAlergias.Size = new System.Drawing.Size(128, 52);
            this.txtAlergias.TabIndex = 19;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidad.Location = new System.Drawing.Point(214, 113);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(128, 20);
            this.txtLocalidad.TabIndex = 18;
            // 
            // txtApellidosPaciente
            // 
            this.txtApellidosPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosPaciente.Location = new System.Drawing.Point(214, 87);
            this.txtApellidosPaciente.Name = "txtApellidosPaciente";
            this.txtApellidosPaciente.ReadOnly = true;
            this.txtApellidosPaciente.Size = new System.Drawing.Size(128, 20);
            this.txtApellidosPaciente.TabIndex = 17;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.Location = new System.Drawing.Point(214, 61);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.ReadOnly = true;
            this.txtNombrePaciente.Size = new System.Drawing.Size(128, 20);
            this.txtNombrePaciente.TabIndex = 16;
            // 
            // lblIdPaciente
            // 
            this.lblIdPaciente.AutoSize = true;
            this.lblIdPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPaciente.Location = new System.Drawing.Point(214, 35);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(0, 13);
            this.lblIdPaciente.TabIndex = 15;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Location = new System.Drawing.Point(21, 190);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(100, 60);
            this.btnPacientes.TabIndex = 14;
            this.btnPacientes.Text = "Gestión de Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // pcbPaciente
            // 
            this.pcbPaciente.Image = ((System.Drawing.Image)(resources.GetObject("pcbPaciente.Image")));
            this.pcbPaciente.Location = new System.Drawing.Point(21, 35);
            this.pcbPaciente.Name = "pcbPaciente";
            this.pcbPaciente.Size = new System.Drawing.Size(100, 135);
            this.pcbPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPaciente.TabIndex = 13;
            this.pcbPaciente.TabStop = false;
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.Location = new System.Drawing.Point(40, 18);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(57, 13);
            this.lblPacientes.TabIndex = 12;
            this.lblPacientes.Text = "Paciente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(especialidadLabel2);
            this.panel1.Controls.Add(this.especialidadLabel3);
            this.panel1.Controls.Add(idmedicoLabel2);
            this.panel1.Controls.Add(this.idmedicoLabel3);
            this.panel1.Controls.Add(nombreLabel2);
            this.panel1.Controls.Add(this.nombreComboBox);
            this.panel1.Controls.Add(this.pcbCitas);
            this.panel1.Controls.Add(this.lblCitas);
            this.panel1.Location = new System.Drawing.Point(441, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 350);
            this.panel1.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(377, 64);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(274, 39);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar Diagnóstico";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // especialidadLabel3
            // 
            this.especialidadLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "especialidad", true));
            this.especialidadLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especialidadLabel3.Location = new System.Drawing.Point(227, 64);
            this.especialidadLabel3.Name = "especialidadLabel3";
            this.especialidadLabel3.Size = new System.Drawing.Size(100, 23);
            this.especialidadLabel3.TabIndex = 7;
            // 
            // idmedicoLabel3
            // 
            this.idmedicoLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "idmedico", true));
            this.idmedicoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idmedicoLabel3.Location = new System.Drawing.Point(227, 94);
            this.idmedicoLabel3.Name = "idmedicoLabel3";
            this.idmedicoLabel3.Size = new System.Drawing.Size(121, 23);
            this.idmedicoLabel3.TabIndex = 3;
            // 
            // nombreComboBox
            // 
            this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "nombre", true));
            this.nombreComboBox.DataSource = this.medicosBindingSource;
            this.nombreComboBox.DisplayMember = "nombre";
            this.nombreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(227, 32);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(198, 21);
            this.nombreComboBox.TabIndex = 5;
            // 
            // pcbCitas
            // 
            this.pcbCitas.Image = ((System.Drawing.Image)(resources.GetObject("pcbCitas.Image")));
            this.pcbCitas.Location = new System.Drawing.Point(28, 35);
            this.pcbCitas.Name = "pcbCitas";
            this.pcbCitas.Size = new System.Drawing.Size(100, 94);
            this.pcbCitas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCitas.TabIndex = 1;
            this.pcbCitas.TabStop = false;
            // 
            // lblCitas
            // 
            this.lblCitas.AutoSize = true;
            this.lblCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitas.Location = new System.Drawing.Point(25, 18);
            this.lblCitas.Name = "lblCitas";
            this.lblCitas.Size = new System.Drawing.Size(101, 13);
            this.lblCitas.TabIndex = 0;
            this.lblCitas.Text = "Citas del Médico";
            // 
            // pnlHoraDia
            // 
            this.pnlHoraDia.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlHoraDia.Controls.Add(this.lblHora);
            this.pnlHoraDia.Controls.Add(this.lblDia);
            this.pnlHoraDia.Location = new System.Drawing.Point(441, 283);
            this.pnlHoraDia.Name = "pnlHoraDia";
            this.pnlHoraDia.Size = new System.Drawing.Size(200, 100);
            this.pnlHoraDia.TabIndex = 5;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(41, 60);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(86, 31);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label1";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDia.Location = new System.Drawing.Point(25, 11);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(86, 31);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "label1";
            // 
            // btnPacientesMedico
            // 
            this.btnPacientesMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientesMedico.Location = new System.Drawing.Point(705, 294);
            this.btnPacientesMedico.Name = "btnPacientesMedico";
            this.btnPacientesMedico.Size = new System.Drawing.Size(203, 23);
            this.btnPacientesMedico.TabIndex = 6;
            this.btnPacientesMedico.Text = "Pacientes Médico";
            this.btnPacientesMedico.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(705, 343);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(203, 23);
            this.btnHistorial.TabIndex = 7;
            this.btnHistorial.Text = "Historial Clínico";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // timeNow
            // 
            this.timeNow.Tick += new System.EventHandler(this.timeNow_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 749);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnPacientesMedico);
            this.Controls.Add(this.pnlHoraDia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPacientes);
            this.Controls.Add(this.pnlMedicos);
            this.Controls.Add(this.pnlAtencion);
            this.Controls.Add(this.pnlInformativo);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlInformativo.ResumeLayout(false);
            this.pnlInformativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoHospital)).EndInit();
            this.pnlAtencion.ResumeLayout(false);
            this.pnlAtencion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencsmedicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.pnlMedicos.ResumeLayout(false);
            this.pnlMedicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMedico)).EndInit();
            this.pnlPacientes.ResumeLayout(false);
            this.pnlPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaciente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCitas)).EndInit();
            this.pnlHoraDia.ResumeLayout(false);
            this.pnlHoraDia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformativo;
        private System.Windows.Forms.Label lblCif;
        private System.Windows.Forms.Label lblTlfn;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.Label lblDatosHospital;
        private System.Windows.Forms.PictureBox pcbLogoHospital;
        private System.Windows.Forms.Panel pnlAtencion;
        private System.Windows.Forms.Label lblNueva;
        private dsBD dsBD;
        private System.Windows.Forms.BindingSource atencsmedicasBindingSource;
        private dsBDTableAdapters.atencsmedicasTableAdapter atencsmedicasTableAdapter;
        private dsBDTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBDTableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource especialidadesBindingSource1;
        private dsBDTableAdapters.medicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private dsBDTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private System.Windows.Forms.Panel pnlMedicos;
        private System.Windows.Forms.Button btnMedicos;
        private System.Windows.Forms.PictureBox pcbMedico;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Panel pnlPacientes;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.PictureBox pcbPaciente;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label especialidadLabel3;
        private System.Windows.Forms.Label idmedicoLabel3;
        private System.Windows.Forms.ComboBox nombreComboBox;
        private System.Windows.Forms.PictureBox pcbCitas;
        private System.Windows.Forms.Label lblCitas;
        private System.Windows.Forms.Panel pnlHoraDia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Button btnPacientesMedico;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.ComboBox cmbMedico;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblIdAtencion;
        private System.Windows.Forms.Label lblIdMedico;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.TextBox txtApellidosMedico;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.TextBox txtDestacar;
        private System.Windows.Forms.TextBox txtAlergias;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtApellidosPaciente;
        private System.Windows.Forms.Timer timeNow;
    }
}

