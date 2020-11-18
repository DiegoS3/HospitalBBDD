using System;
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
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.dsBD.pacientes);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres eliminar la pelicula?", "Eliminar pelicula",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Creamos la consulta para los alquileres
                dsBDTableAdapters.atencsmedicasTableAdapter tbAtencion = new dsBDTableAdapters.atencsmedicasTableAdapter();

                tbAtencion.FillByCitasPaciente(dsBD.atencsmedicas, int.Parse(idpacienteLabel1.Text));

                if (dsBD.atencsmedicas.Count > 0)
                {

                    MessageBox.Show("No se puede borrar el cliente", "El cliente aun tiene citas pendientes",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {

                    int reg = this.pacientesTableAdapter.Delete(int.Parse(idpacienteLabel1.Text));

                    if (reg > 0)
                    {
                        MessageBox.Show("Paciente Eliminado");
                    }
                    //dsBD.Clear();
                    this.pacientesTableAdapter.Fill(dsBD.pacientes);
                }

            }
        }
    }
}
