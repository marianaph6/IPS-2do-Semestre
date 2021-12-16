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
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
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

        private void Ingresar()
        {
            bool datosValidos = ValidarCampo("ID", txtId.Text, typeof(string)) && ValidarCampo("Contraseña", txtPassword.Text, typeof(string));

            if (datosValidos)
            {
                string id = txtId.Text;
                string password = txtPassword.Text;

                if (opEmpleados.PermitirIngreso(id, password))
                {

                    var frmMen = new Menu();
                    frmMen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalidos, verifique la información ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
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
    }
}
