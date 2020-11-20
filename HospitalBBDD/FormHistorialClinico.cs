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
    public partial class frmHistorialClinico : Form
    {
        private ArrayList listaPacientes;

        public frmHistorialClinico()
        {
            InitializeComponent();
        }

        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void frmHistorialClinico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.pacientes' Puede moverla o quitarla según sea necesario.
            //this.pacientesTableAdapter.Fill(this.dsBD.pacientes);
            cargarPacientes();

        }

        private void cargarPacientes()
        {
            this.listaPacientes = new ArrayList();
            this.pacientesTableAdapter.Fill(this.dsBD.pacientes);
            this.nombreComboBox.Text = "";

            foreach (var item in this.dsBD.pacientes)
            {
                listaPacientes.Add(item.idpaciente);
                this.nombreComboBox.Items.Add(item.nombre + " " + item.apellidos);

            }
        }

        private void cargarDGV()
        {
            try
            {
                int id = (int)this.listaPacientes[this.nombreComboBox.SelectedIndex];
                this.historialClinicoTableAdapter.Fill(this.dsBD.historialClinico, id);
                this.dgvHistorial.DataSource = this.dsBD.historialClinico;

                foreach (DataGridViewRow row in dgvHistorial.Rows)
                {
                    row.Cells[0].ReadOnly = true;
                    row.Cells[1].ReadOnly = true;
                    row.Cells[2].ReadOnly = true;
                    row.Cells[3].ReadOnly = true;
                }
            }
            catch
            {

            }
        }

        private void nombreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDGV();
        }

    }
}
