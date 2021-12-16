using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_IPS
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
            dgvMultas.Visible = false;
            dgvCitas.Visible = false;
            CargarPacientes();
        }

        private void CargarGrid()
        {
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.Columns["Id_Paciente"].HeaderText = "Id paciente";
            dgvPacientes.Columns["Nombre"].HeaderText = "Nombres";
            dgvPacientes.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvPacientes.Columns["Fech_Nac"].HeaderText = "Fecha nacimiento";
            dgvPacientes.Columns["Direccion"].HeaderText = "Dirección";
            dgvPacientes.Columns["Telefono"].HeaderText = "Teléfono";
            dgvPacientes.Columns["Fech_reg"].HeaderText = "Fecha registro";
            dgvPacientes.Columns["Multas"].HeaderText = "Multa";
        }

        

        private void CargarPacientes()
        {
            dgvPacientes.Visible = true;
            CambiarEstadoCampos(true, false);
            dgvPacientes.DataSource = opPacientes.ListarPacientes();
            CargarGrid();
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtpFechaNac.Value = DateTime.Now;
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dtpFechaReg.Value = DateTime.Now;
        }

        private void CambiarEstadoCampos(bool soloLectura, bool habilitado)
        {
            txtId.ReadOnly = soloLectura;
            txtMulta.ReadOnly = soloLectura;
            txtNombres.ReadOnly = soloLectura;
            txtApellidos.ReadOnly = soloLectura;
            dtpFechaNac.Enabled = habilitado;
            txtDireccion.ReadOnly = soloLectura;
            txtTelefono.ReadOnly = soloLectura;
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

        private void InsertarPaciente()
        {
            bool datosValidos = ValidarCampo("Id", txtId.Text, typeof(string)) && ValidarCampo("Nombres", txtNombres.Text, typeof(string))
                                && ValidarCampo("Apellidos", txtApellidos.Text, typeof(string)) && ValidarCampo("Fecha nacimiento", dtpFechaNac.Text, typeof(DateTime))
                                && ValidarCampo("Dirección", txtDireccion.Text, typeof(string)) && ValidarCampo("Teléfono", txtTelefono.Text, typeof(string));

            if (datosValidos)
            {
                string id = txtId.Text;
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                DateTime fechaNac = dtpFechaNac.Value.Date;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                DateTime fechaReg = DateTime.Today.Date;

                if (opPacientes.RegistrarPaciente(id, nombres, apellidos, fechaNac, direccion, telefono, fechaReg))
                {
                    MessageBox.Show("Registro del paciente exitoso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarPacientes();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, no se registrará el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CitasPaciente()
        {
            bool datosValidos = ValidarCampo("Id paciente", txtidCita.Text, typeof(string));

            if (datosValidos)
            {
                string id = txtidCita.Text;
                dgvPacientes.DataSource = opPacientes.CitasPaciente(id);
                CargarPacientes();
            }
        }


        private void Guardar()
        {

            InsertarPaciente();
            btnNuevo.Enabled = true;
        }

        private void Nuevo()
        {
            btnNuevo.Enabled = false;
            CambiarEstadoCampos(false, true);
            txtMulta.Enabled = false;
            LimpiarCampos();
        }

        private void Cancelar()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            CargarPacientes();
        }

        

        private void btnCitas_Click(object sender, EventArgs e)
        {
            bool datosValidos = ValidarCampo("Id paciente", txtidCita.Text, typeof(string));

            if (datosValidos)
            {
                dgvPacientes.Visible = false;
                dgvMultas.Visible = false;
                dgvCitas.Visible = true;
                string id = txtidCita.Text;
                dgvCitas.DataSource = opPacientes.CitasPaciente(id);

            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dgvCitas.Visible = false;
            dgvMultas.Visible = false;
            dgvPacientes.Visible = true;
            CargarPacientes();
        }

        private void btnMultas_Click(object sender, EventArgs e)
        {

            dgvCitas.Visible = false;
            dgvMultas.Visible = true;
            dgvPacientes.Visible = false;
            dgvMultas.DataSource = opPacientes.MultasPacientes();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            dgvCitas.Visible = false;
            dgvMultas.Visible = false;
            dgvPacientes.Visible = true;
            Guardar();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            dgvCitas.Visible = false;
            dgvMultas.Visible = false;
            dgvPacientes.Visible = true;
            Cancelar();
        }

        private void btnMultas_Click_1(object sender, EventArgs e)
        {
            dgvCitas.Visible = false;
            dgvMultas.Visible = true;
            dgvPacientes.Visible =false;
            dgvMultas.DataSource = opPacientes.MultasPacientes();
        }

        private void btnTodos_Click_1(object sender, EventArgs e)
        {
            dgvCitas.Visible = false;
            dgvMultas.Visible = false;
            dgvPacientes.Visible = true;
            CargarPacientes();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {
            bool datosValidos = ValidarCampo("Id paciente", txtidCita.Text, typeof(string));

            if (datosValidos)
            {
                dgvPacientes.Visible = false;
                dgvMultas.Visible = false;
                dgvCitas.Visible = true;
                string id = txtidCita.Text;
                dgvCitas.DataSource = opPacientes.CitasPaciente(id);
                txtidCita.Text = "";

            }
        }

        private void dgvPacientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvPacientes.Rows[e.RowIndex].Cells["Id_Paciente"].Value.ToString();
            txtNombres.Text = dgvPacientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtApellidos.Text = dgvPacientes.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
            dtpFechaNac.Value = Convert.ToDateTime(dgvPacientes.Rows[e.RowIndex].Cells["Fech_Nac"].Value);
            txtDireccion.Text = dgvPacientes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dgvPacientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            dtpFechaReg.Value = Convert.ToDateTime(dgvPacientes.Rows[e.RowIndex].Cells["Fech_Reg"].Value);
            txtMulta.Text = dgvPacientes.Rows[e.RowIndex].Cells["Multas"].Value.ToString();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtidCita_KeyPress(object sender, KeyPressEventArgs e)
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
