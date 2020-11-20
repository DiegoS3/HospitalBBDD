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
            
            try
            {
                if (is_valide())
                {
                    this.Validate();
                    this.pacientesBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dsBD);
                    insertar();
                    bindingNavigatorAddNewItem.Enabled = true;//habilita el boton de nuevo registro
                    bindingNavigatorDeleteItem.Enabled = true;
                    bindingNavigatorMoveFirstItem.Enabled = true;
                    bindingNavigatorMovePreviousItem.Enabled = true;
                    DialogResult r = MessageBox.Show("Guardado con éxito \nDesea continuar?", "Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido guardar.\nPor favor, debe rellenar todos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show("No se ha podido guardar, " + ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido guardar, campos obligatorios vacios", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {
                MessageBox.Show("No se ha podido guardar, " + exp.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool is_valide()
        {
            bool valid = true;
            int e = errorTxt(nombreTextBox) + errorTxt(apellidosTextBox) + errorTxt(localidadTextBox) + errorTxt(alergiasTextBox)
                + errorTxt(adestacarTextBox);
            if (e > 0)
            {
                valid = false;
            }
            return valid;

        }

        private int errorTxt(TextBox t)
        {
            int e = 0;
            if (t.Text.Equals("") || t == null)
            {
                e++;
            }
            return e;
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.dsBD.pacientes);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres eliminar al paciente?", "Eliminar paciente",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Creamos la consulta para los alquileres
                dsBDTableAdapters.atencsmedicasTableAdapter tbAtencion = new dsBDTableAdapters.atencsmedicasTableAdapter();

                tbAtencion.FillByCitasPaciente(dsBD.atencsmedicas, int.Parse(idpacienteLabel1.Text));

                if (dsBD.atencsmedicas.Count > 0)
                {

                    MessageBox.Show("No se puede borrar el paciente. El cliente aun tiene citas pendientes", "Error",
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            this.idpacienteLabel1.Text = "";
        }

        private void insertar()
        {
            this.pacientesTableAdapter.Insert(this.nombreTextBox.Text, this.apellidosTextBox.Text, this.localidadTextBox.Text, this.alergiasTextBox.Text, this.adestacarTextBox.Text);
        }

        private void frmPacientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.cerrado = true;
        }
    }
}
