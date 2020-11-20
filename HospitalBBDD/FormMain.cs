using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalBBDD
{
    public partial class frmMain : Form
    {
        private ArrayList listaMedicos;
        private ArrayList listaMedicosCitas;
        private ArrayList listaPacientes;

        public frmMain()
        {
            InitializeComponent();
        }

        private void atencsmedicasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.atencsmedicasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.diagnosticos' Puede moverla o quitarla según sea necesario.
            
            this.especialidadesTableAdapter.Fill(this.dsBD.especialidades);
            this.cmbEspecialidad.Text = "";
            this.timeNow.Enabled = true;
            cargarMedicos();
            
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {            
            this.listaMedicos = new ArrayList();
            this.listaPacientes = new ArrayList();

            if (this.cmbEspecialidad.SelectedIndex > -1)
            {
                this.cmbMedico.Enabled = true;
                this.cmbMedico.Text = "";
                this.cmbMedico.Items.Clear();
                this.cmbPaciente.Enabled = true;
                this.cmbPaciente.Items.Clear();
                string especialidad = this.cmbEspecialidad.Text;
                this.medicosTableAdapter.FillByEspecialidad(this.dsBD.medicos, especialidad);
                this.pacientesTableAdapter.Fill(this.dsBD.pacientes);

            }
            else
            {
                this.cmbMedico.Enabled = false;
                this.cmbMedico.Text = "";
                this.cmbPaciente.Enabled = false;
                this.cmbPaciente.Text = "";
            }

            foreach (var item in this.dsBD.medicos)
            {
                listaMedicos.Add(item.idmedico);
                this.cmbMedico.Items.Add(item.nombre + " " + item.apellidos);

            }

            foreach (var item in this.dsBD.pacientes)
            {

                listaPacientes.Add(item.idpaciente);
                this.cmbPaciente.Items.Add(item.nombre + " " + item.apellidos);

            }

        }

        private void cmbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)listaMedicos[this.cmbMedico.SelectedIndex];       
            this.medicosTableAdapter.FillById(this.dsBD.medicos, id);

            this.lblIdMedico.Text = id.ToString();
            this.txtNombreMedico.Text = this.dsBD.medicos[0].nombre;
            this.txtApellidosMedico.Text = this.dsBD.medicos[0].apellidos;
            this.txtMovil.Text = this.dsBD.medicos[0].movil;
            this.txtEspecialidad.Text = this.dsBD.medicos[0].especialidad;
            //this.nombreComboBox.Text = this.dsBD.medicos
            cambiarFotoMedico();
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)listaPacientes[this.cmbPaciente.SelectedIndex];
            this.pacientesTableAdapter.FillById(this.dsBD.pacientes, id);

            this.lblIdPaciente.Text = id.ToString();
            this.txtNombrePaciente.Text = this.dsBD.pacientes[0].nombre;
            this.txtApellidosPaciente.Text = this.dsBD.pacientes[0].apellidos;
            this.txtLocalidad.Text = this.dsBD.pacientes[0].localidad;
            this.txtAlergias.Text = this.dsBD.pacientes[0].alergias;
            this.txtDestacar.Text = this.dsBD.pacientes[0].adestacar;
        }

        private void cambiarFotoMedico()
        {
            byte[] myData;
            //Una vez ejecutada la consulta sobre la tabla médicos, y cargado el DataSet correspondiente
            //1º Se comprueba si en esa tabla devuelta con la consulta sobre los médicos hay algún registro
            if (this.dsBD.medicos.Rows.Count > 0)
            {
                //Inicializamos una fila de datos en la cual se almacenaran todos los datos de la fila seleccionada
                //En este ejemplo nos quedamos con la primera
                DataRow myRow = (this.dsBD.medicos.Rows[0]);

                try
                {
                    //Se almacena el campo foto de la tabla en el array de bytes
                    myData = (byte[])myRow["foto"];
                    //Se inicializa un flujo en memoria del array de bytes
                    MemoryStream stream = new MemoryStream(myData);
                    //En el picture box se muestra la imagen que esta almacenada en el flujo en memoria 
                    //el cual contiene el array de bytes
                    this.pcbMedico.Image = Image.FromStream(stream);

                }
                catch (InvalidCastException)
                {

                    this.pcbMedico.Image = Properties.Resources.contact;

                }
            }
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMedicos medicos = new frmMedicos();
            medicos.ShowDialog();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes pacientes = new frmPacientes();
            pacientes.ShowDialog();
        }

        private void timeNow_Tick(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            this.lblDia.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void cargarMedicos()
        {
            this.listaMedicosCitas = new ArrayList();
            this.medicosTableAdapter.Fill(this.dsBD.medicos);
            this.nombreComboBox.Text = "";
            this.lblEspecialidadCita.Text = "";
            this.lblIdMedicoCita.Text = "";

            foreach (var item in this.dsBD.medicos)
            {
                listaMedicosCitas.Add(item.idmedico);
                this.nombreComboBox.Items.Add(item.nombre + " " + item.apellidos);

            }

        }

        private void nombreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.listaMedicosCitas = new ArrayList();
            this.dgvDiagnosticos.Columns[0].ReadOnly = true;
            this.dgvDiagnosticos.Columns[1].ReadOnly = true;
            this.dgvDiagnosticos.Columns[2].ReadOnly = true;
            this.dgvDiagnosticos.Columns[3].ReadOnly = true;

            int id = (int)listaMedicosCitas[this.nombreComboBox.SelectedIndex];            
            this.diagnosticosTableAdapter.FillByIdMedico(this.dsBD.diagnosticos, id);
            if (this.dsBD.diagnosticos.Count > 0)
            {
                this.lblEspecialidadCita.Text = this.dsBD.diagnosticos[0].especialidad;
                this.lblIdMedicoCita.Text = id.ToString();
            }
            else
            {
                this.medicosTableAdapter.FillById(this.dsBD.medicos, id);
                this.lblEspecialidadCita.Text = this.dsBD.medicos[0].especialidad;
                this.lblIdMedicoCita.Text = id.ToString();
            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvDiagnosticos.Rows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                string diag = row.Cells[4].Value.ToString();
                atencsmedicasTableAdapter.UpdateDiagnosticos(diag, id);
            }
            MessageBox.Show("Diagnóstico actualizado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value.Date;
            String medico = lblIdMedico.Text;
            String paciente = lblIdPaciente.Text;
            String diag = "";
            atencsmedicasTableAdapter.Insert(fecha, Convert.ToInt32(medico), Convert.ToInt32(paciente), diag);
            MessageBox.Show("Cita añadida correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //cmbMedico.SelectedItem = cbNombre.SelectedItem.ToString();
            //cargarDataGridView();
        }

        private void btnPacientesMedico_Click(object sender, EventArgs e)
        {
            frmMedicoPacientes listado = new frmMedicoPacientes();
            listado.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

        }
    }
}
