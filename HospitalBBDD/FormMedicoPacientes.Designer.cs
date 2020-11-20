namespace HospitalBBDD
{
    partial class frmMedicoPacientes
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label idmedicoLabel;
            System.Windows.Forms.Label fechaLabel;
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.lblIdMedico = new System.Windows.Forms.Label();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPacienteDia = new System.Windows.Forms.DataGridView();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBD = new HospitalBBDD.dsBD();
            this.atencsmedicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosTableAdapter = new HospitalBBDD.dsBDTableAdapters.medicosTableAdapter();
            this.atencsmedicasTableAdapter = new HospitalBBDD.dsBDTableAdapters.atencsmedicasTableAdapter();
            this.pacienteDiaTableAdapter = new HospitalBBDD.dsBDTableAdapters.pacienteDiaTableAdapter();
            this.tableAdapterManager = new HospitalBBDD.dsBDTableAdapters.TableAdapterManager();
            nombreLabel = new System.Windows.Forms.Label();
            idmedicoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencsmedicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(276, 74);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(54, 13);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // idmedicoLabel
            // 
            idmedicoLabel.AutoSize = true;
            idmedicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idmedicoLabel.Location = new System.Drawing.Point(102, 74);
            idmedicoLabel.Name = "idmedicoLabel";
            idmedicoLabel.Size = new System.Drawing.Size(67, 13);
            idmedicoLabel.TabIndex = 3;
            idmedicoLabel.Text = "Id Médico:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            fechaLabel.Location = new System.Drawing.Point(102, 112);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(46, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "nombre", true));
            this.cmbMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(334, 71);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(121, 21);
            this.cmbMedicos.TabIndex = 2;
            this.cmbMedicos.SelectedIndexChanged += new System.EventHandler(this.cmbMedicos_SelectedIndexChanged);
            // 
            // lblIdMedico
            // 
            this.lblIdMedico.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "idmedico", true));
            this.lblIdMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMedico.Location = new System.Drawing.Point(170, 74);
            this.lblIdMedico.Name = "lblIdMedico";
            this.lblIdMedico.Size = new System.Drawing.Size(100, 23);
            this.lblIdMedico.TabIndex = 4;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.atencsmedicasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(151, 110);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.fechaDateTimePicker.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(302, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "PACIENTES";
            // 
            // dgvPacienteDia
            // 
            this.dgvPacienteDia.AllowUserToAddRows = false;
            this.dgvPacienteDia.AllowUserToDeleteRows = false;
            this.dgvPacienteDia.AllowUserToResizeColumns = false;
            this.dgvPacienteDia.AllowUserToResizeRows = false;
            this.dgvPacienteDia.AutoGenerateColumns = false;
            this.dgvPacienteDia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacienteDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienteDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvPacienteDia.DataSource = this.pacienteDiaBindingSource;
            this.dgvPacienteDia.Location = new System.Drawing.Point(12, 156);
            this.dgvPacienteDia.MultiSelect = false;
            this.dgvPacienteDia.Name = "dgvPacienteDia";
            this.dgvPacienteDia.Size = new System.Drawing.Size(539, 159);
            this.dgvPacienteDia.TabIndex = 9;
            // 
            // erpError
            // 
            this.erpError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpError.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn2.HeaderText = "apellidos";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // pacienteDiaBindingSource
            // 
            this.pacienteDiaBindingSource.DataMember = "pacienteDia";
            this.pacienteDiaBindingSource.DataSource = this.dsBD;
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // atencsmedicasTableAdapter
            // 
            this.atencsmedicasTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteDiaTableAdapter
            // 
            this.pacienteDiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.atencsmedicasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.especialidadesTableAdapter = null;
            this.tableAdapterManager.medicosTableAdapter = null;
            this.tableAdapterManager.pacienteDiaTableAdapter = null;
            this.tableAdapterManager.pacientesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HospitalBBDD.dsBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmMedicoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 328);
            this.Controls.Add(this.dgvPacienteDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idmedicoLabel);
            this.Controls.Add(this.lblIdMedico);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.cmbMedicos);
            this.Name = "frmMedicoPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmMedicoPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atencsmedicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBD dsBD;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private dsBDTableAdapters.medicosTableAdapter medicosTableAdapter;
        private dsBDTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBDTableAdapters.atencsmedicasTableAdapter atencsmedicasTableAdapter;
        private System.Windows.Forms.ComboBox cmbMedicos;
        private System.Windows.Forms.Label lblIdMedico;
        private System.Windows.Forms.BindingSource atencsmedicasBindingSource;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pacienteDiaBindingSource;
        private dsBDTableAdapters.pacienteDiaTableAdapter pacienteDiaTableAdapter;
        private System.Windows.Forms.DataGridView dgvPacienteDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ErrorProvider erpError;
    }
}