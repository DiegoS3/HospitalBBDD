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
    public partial class frmMain : Form
    {
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
            // TODO: esta línea de código carga datos en la tabla 'dsBD.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.dsBD.pacientes);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.dsBD.medicos);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.dsBD.especialidades);
            // TODO: esta línea de código carga datos en la tabla 'dsBD.atencsmedicas' Puede moverla o quitarla según sea necesario.
            //this.atencsmedicasTableAdapter.Fill(this.dsBD.atencsmedicas);
            
        }
    }
}
