using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final_IPS
{
    public partial class Citas : Form
    {
        private string OpActual = "";
        public Citas()
        {
            InitializeComponent();
            CargarCitas();
        }

        List<string> lstAsistencia = new List<string>();

        public void InicializarcmbAsistencia()
        {
            lstAsistencia.Add("Sí");
            lstAsistencia.Add("No");
            cmbAsistencia.DataSource = lstAsistencia;
        }

        private void CargarGrid()
        {
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.Columns["Id_Paciente"].HeaderText = "Id paciente";
            dgvCitas.Columns["Id_Medico"].HeaderText = "Id medico";
            dgvCitas.Columns["Fec_Cita"].HeaderText = "Fecha cita";
            dgvCitas.Columns["Asistencia"].HeaderText = "Asistencia";

        }
        
        private void CargarCitas()
        {
            EstadoNuevo(true, false);
            dgvCitas.DataSource = opCitas.ListarCitas();
            CargarGrid();
        }

        private void LimpiarCampos()
        {
            txtIdpac.Text = "";
            txtmed.Text = "";
            fechcita.Value = DateTime.Now;

        }

        private void EstadoNuevo(bool soloLectura, bool habilitado)
        {
            txtIdpac.ReadOnly = soloLectura;
            txtmed.ReadOnly = soloLectura;
            fechcita.Enabled = habilitado;
            cmbAsistencia.Enabled = habilitado;

        }

        private void EstadoAsistencia()
        {
            txtIdpac.ReadOnly = true;
            txtmed.ReadOnly = true;
            fechcita.Enabled = false;
            cmbAsistencia.Enabled = true;

        }

        private bool ValidarCampo(string nomCampo, string valor, Type tipo)
        {
            if (valor == "")
            {
                MessageBox.Show(nomCampo + " es un campo obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tipo == typeof(DateTime))
            {
                DateTime verificarFecha;
                if (DateTime.TryParse(valor, out verificarFecha))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Ingrese un dato valido para el campo " + nomCampo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void InsertarCita()
        {
            bool datosValidos = ValidarCampo("Id paciente", txtIdpac.Text, typeof(string)) && ValidarCampo("Id medico", txtmed.Text, typeof(string))
                               && ValidarCampo("Fecha cita", fechcita.Text, typeof(DateTime));

            if (datosValidos)
            {
                string idpac = txtIdpac.Text;
                string idmed = txtmed.Text;
                DateTime fecha = fechcita.Value.Date;

                if (opCitas.RegistrarCita(idpac, idmed, fecha))
                {
                    MessageBox.Show("Registro de la cita exitoso exitoso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpActual = "";
                    CargarCitas();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, no se registrará la cita", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void RegistrarAsistencia()
        {

            string idpac = txtIdpac.Text;
            string idmed = txtmed.Text;
            string asist = cmbAsistencia.SelectedValue.ToString();
            opCitas.Asistencia(idpac, asist, idmed);

            opPacientes.AsignarMulta(idpac);

            OpActual = "";
            CargarCitas();

        }

        private void Guardar()
        {
            switch (OpActual)
            {
                case "N":
                    InsertarCita();
                    btnNuevo.Enabled = true;
                    break;

                case "A":
                    RegistrarAsistencia();
                    btnAsistencia.Enabled = true;
                    break;
            }

        }

        private void Nuevo()
        {
            OpActual = "N";
            btnNuevo.Enabled = false;
            btnAsistencia.Enabled = false;
            EstadoNuevo(false, true);
            cmbAsistencia.Enabled = false;
            LimpiarCampos();
        }

        private void Asistencia()
        {
            OpActual = "A";
            btnNuevo.Enabled = false;
            btnAsistencia.Enabled = false;
            EstadoAsistencia();

        }

        private void Cancelar()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            CargarCitas();
        }

       

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            btnNuevo.Enabled = true;
        }

        private void btnAsistencia_Click_1(object sender, EventArgs e)
        {
            InicializarcmbAsistencia();
            Asistencia();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTodas_Click_1(object sender, EventArgs e)
        {
            CargarCitas();
        }

        private void btnIncumplidas_Click_1(object sender, EventArgs e)
        {
            dgvCitas.DataSource = opCitas.CitasIncumplidas();
        }

        private void dgvCitas_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdpac.Text = dgvCitas.Rows[e.RowIndex].Cells["Id_Paciente"].Value.ToString();
            txtmed.Text = dgvCitas.Rows[e.RowIndex].Cells["Id_Medico"].Value.ToString();
            fechcita.Value = Convert.ToDateTime(dgvCitas.Rows[e.RowIndex].Cells["Fec_Cita"].Value);
            cmbAsistencia.Text = dgvCitas.Rows[e.RowIndex].Cells["Asistencia"].Value.ToString();

            if (cmbAsistencia.Text == "")
            {
                btnAsistencia.Enabled = true;
            }
            else {
                btnAsistencia.Enabled = false;
            }
        }

        private void txtIdpac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtmed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
