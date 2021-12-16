using System;
using System.Windows.Forms;

namespace Final_IPS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void opcPacientes_Click(object sender, EventArgs e)
        {
            Pacientes pac = new Pacientes();
            pac.Show();
        }

        private void opcMedicos_Click(object sender, EventArgs e)
        {
            Medicos med = new Medicos();
            med.Show();
        }

        private void opcCitas_Click(object sender, EventArgs e)
        {
            Citas cita = new Citas();
            cita.Show();
        }

        private void opcSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
