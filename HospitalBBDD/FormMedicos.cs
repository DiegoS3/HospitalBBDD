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
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        private void medicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsBD);

        }

        private void FormMedicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsBD.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.dsBD.especialidades);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.dsBD.medicos);

        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            //Suponemos que ofdExaminar es un OpenFileDialog incorporado al formuylario
            ofdCargarFoto.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";

            DialogResult dres = ofdCargarFoto.ShowDialog();

            if (dres == DialogResult.Abort)
                return;
            if (dres == DialogResult.Cancel)
                return;

            //para guardar la ruta al fichero con la imagen en un TextBox (por si se quiere mostrar)
            //txtRutaFichero.Text = ofdCargarFoto.FileName;

            //Se muestra la imagen en el PictureBox directamente de la ruta devuelta por el OpenFileDialog
            fotoPictureBox.Image = Image.FromFile(ofdCargarFoto.FileName);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres eliminar la pelicula?", "Eliminar pelicula",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Creamos la consulta para los alquileres
                dsBDTableAdapters.atencsmedicasTableAdapter tbAtencion = new dsBDTableAdapters.atencsmedicasTableAdapter();

                tbAtencion.FillByCitasMedico(dsBD.atencsmedicas, int.Parse(idmedicoLabel1.Text));

                if (dsBD.atencsmedicas.Count > 0)
                {

                    MessageBox.Show("No se puede borrar al médico", "El médico tiene citas pendientes",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {

                    int reg = this.medicosTableAdapter.Delete(int.Parse(idmedicoLabel1.Text));

                    if (reg > 0)
                    {
                        MessageBox.Show("Médico Eliminado");
                    }
                    //dsBD.Clear();
                    this.medicosTableAdapter.Fill(dsBD.medicos);
                }

            }
        }
    }
}
