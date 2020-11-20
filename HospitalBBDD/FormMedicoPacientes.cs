using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalBBDD
{
    public partial class frmMedicoPacientes : Form
    {
        private ArrayList listaMedicos;

        public frmMedicoPacientes()
        {
            InitializeComponent();
        }

        private void medicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void frmMedicoPacientes_Load(object sender, EventArgs e)
        {
            cargarcmbbPMedicos();
        }

        private void cargarcmbbPMedicos()
        {
            this.cmbMedicos.Items.Clear();
            this.listaMedicos = new ArrayList();
            this.medicosTableAdapter.Fill(dsBD.medicos);
            this.cmbMedicos.Text = "";

            foreach (var item in this.dsBD.medicos)
            {

                this.listaMedicos.Add(item.idmedico);
                this.cmbMedicos.Items.Add(item.nombre + " " + item.apellidos);
                
            }
        }

        private void cmbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)listaMedicos[this.cmbMedicos.SelectedIndex];

            this.lblIdMedico.Text = id.ToString();
        }
               

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.cmbMedicos.Text.Equals(string.Empty))
            {
                MessageBox.Show("Selecciona un Médico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erpError.SetError(this.cmbMedicos, "Seleccionar un médico");
            }
            else
            {
                int id = (int)listaMedicos[this.cmbMedicos.SelectedIndex];
                this.pacienteDiaTableAdapter.FillByPacienteDia(this.dsBD.pacienteDia, this.fechaDateTimePicker.Value, id);
                this.dgvPacienteDia.DataSource = this.dsBD.pacienteDia;
            }
            
        }
    }
}
