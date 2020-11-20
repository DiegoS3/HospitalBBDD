namespace HospitalBBDD
{
    partial class frmHistorialClinico
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
            this.dsBD = new HospitalBBDD.dsBD();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new HospitalBBDD.dsBDTableAdapters.pacientesTableAdapter();
            this.tableAdapterManager = new HospitalBBDD.dsBDTableAdapters.TableAdapterManager();
            this.lblhistorial = new System.Windows.Forms.Label();
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            this.historialClinicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialClinicoTableAdapter = new HospitalBBDD.dsBDTableAdapters.historialClinicoTableAdapter();
            this.historialClinicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialClinicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialClinicoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(223, 67);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(61, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Paciente:";
            // 
            // dsBD
            // 
            this.dsBD.DataSetName = "dsBD";
            this.dsBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.dsBD;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.atencsmedicasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.especialidadesTableAdapter = null;
            this.tableAdapterManager.medicosTableAdapter = null;
            this.tableAdapterManager.pacienteDiaTableAdapter = null;
            this.tableAdapterManager.pacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = HospitalBBDD.dsBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblhistorial
            // 
            this.lblhistorial.AutoSize = true;
            this.lblhistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhistorial.Location = new System.Drawing.Point(180, 22);
            this.lblhistorial.Name = "lblhistorial";
            this.lblhistorial.Size = new System.Drawing.Size(323, 24);
            this.lblhistorial.TabIndex = 4;
            this.lblhistorial.Text = "HISTORIAL CLINICO PACIENTES";
            // 
            // nombreComboBox
            // 
            this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "nombre", true));
            this.nombreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(290, 64);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(172, 21);
            this.nombreComboBox.TabIndex = 5;
            this.nombreComboBox.SelectedIndexChanged += new System.EventHandler(this.nombreComboBox_SelectedIndexChanged);
            // 
            // historialClinicoBindingSource
            // 
            this.historialClinicoBindingSource.DataSource = this.dsBD;
            this.historialClinicoBindingSource.Position = 0;
            // 
            // historialClinicoTableAdapter
            // 
            this.historialClinicoTableAdapter.ClearBeforeFill = true;
            // 
            // historialClinicoBindingSource1
            // 
            this.historialClinicoBindingSource1.DataMember = "historialClinico";
            this.historialClinicoBindingSource1.DataSource = this.dsBD;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeColumns = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.AutoGenerateColumns = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvHistorial.DataSource = this.historialClinicoBindingSource1;
            this.dgvHistorial.Location = new System.Drawing.Point(12, 105);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(679, 220);
            this.dgvHistorial.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn6.HeaderText = "apellidos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "especialidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "especialidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn1.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "diagnostico";
            this.dataGridViewTextBoxColumn2.HeaderText = "diagnostico";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmHistorialClinico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 335);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreComboBox);
            this.Controls.Add(this.lblhistorial);
            this.Name = "frmHistorialClinico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial Clinico";
            this.Load += new System.EventHandler(this.frmHistorialClinico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialClinicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialClinicoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBD dsBD;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private dsBDTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private dsBDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblhistorial;
        private System.Windows.Forms.ComboBox nombreComboBox;
        private System.Windows.Forms.BindingSource historialClinicoBindingSource;
        private dsBDTableAdapters.historialClinicoTableAdapter historialClinicoTableAdapter;
        private System.Windows.Forms.BindingSource historialClinicoBindingSource1;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}