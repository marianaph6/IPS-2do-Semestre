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
    public partial class Medicos : Form
    {
        public Medicos()
        {
            InitializeComponent();
            CargarMedicos();
        }


        private void CargarGrid()
        {
            dgvMedico.AllowUserToAddRows = false;
            dgvMedico.Columns["Id_Medico"].HeaderText = "Id medico";
            dgvMedico.Columns["Nombre"].HeaderText = "Nombres";
            dgvMedico.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvMedico.Columns["Especializacion"].HeaderText = "Especialización";
            dgvMedico.Columns["Salario"].HeaderText = "Salario";
            dgvMedico.Columns["Años_Exp"].HeaderText = "Años de experiencia";

        }

        private void dgvMedico_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvMedico.Rows[e.RowIndex].Cells["Id_Medico"].Value.ToString();
            txtNombres.Text = dgvMedico.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtApellidos.Text = dgvMedico.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
            txtEspecializacion.Text = dgvMedico.Rows[e.RowIndex].Cells["Especializacion"].Value.ToString();
            txtsalario.Text = dgvMedico.Rows[e.RowIndex].Cells["Salario"].Value.ToString();
            txtaños.Text = dgvMedico.Rows[e.RowIndex].Cells["Años_Exp"].Value.ToString();
        }

        private void CargarMedicos()
        {
            dgvMedico.Visible = true;
            CambiarEstadoCampos(true, false);
            dgvMedico.DataSource = opMedicos.ListarMedicos();
            CargarGrid();
        }

        private bool ValidarCampo(string nomCampo, string valor, Type tipo)
        {
            if (valor == "")
            {
                MessageBox.Show(nomCampo + " es un campo obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void CambiarEstadoCampos(bool soloLectura, bool habilitado)
        {
            txtId.ReadOnly = soloLectura;
            txtNombres.ReadOnly = soloLectura;
            txtApellidos.ReadOnly = soloLectura;
            txtEspecializacion.ReadOnly = soloLectura;
            txtsalario.ReadOnly = soloLectura;
            txtaños.ReadOnly = soloLectura;
        }

        private void Actualizar()
        {

            btnActualizar.Enabled = false;
            btnTodos.Enabled = false;
            txtsalario.ReadOnly = false;
            txtaños.ReadOnly = false;
        }

        private void Guardar()
        {
            Actualizar();
            btnTodos.Enabled = true;
            btnActualizar.Enabled = true;
            
        }

        private void Cancelar()
        {

            btnActualizar.Enabled = true;
            btnCancelar.Enabled = true;
            btnTodos.Enabled = true;
            CargarMedicos();
        }

        private void txtaños_TextChanged(object sender, EventArgs e)
        {

            txtsalario.ReadOnly = true;

        }

        private void txtsalario_TextChanged(object sender, EventArgs e)
        {
            txtaños.ReadOnly = true;

        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Guardar();
            bool datosValidos = ValidarCampo("Salario", txtsalario.Text, typeof(string)) && ValidarCampo("Años", txtaños.Text, typeof(string));

            if (datosValidos)
            {
                string id = txtId.Text;
                int salario = Convert.ToInt32(txtsalario.Text);
                string años = txtaños.Text;
                opMedicos.Actualizar(id, salario, años);
                CargarMedicos();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            CargarMedicos();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool datosValidos = ValidarCampo("Id medico", txtsalario.Text, typeof(string));

            if (datosValidos)
            {
                string id = txtBSalario.Text;
                
                MessageBox.Show("El sueldo del medico es de: " + opMedicos.Sueldo(id)+" pesos");
            }
            txtBSalario.Text = "";

        }

        private void txtaños_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsalario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBSalario_KeyPress(object sender, KeyPressEventArgs e)
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
