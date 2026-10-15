using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudSeguro.Backend; // Asegúrate de tener la referencia al proyecto Backend

namespace Crud_Seguro
{
    public partial class UILogin : Form
    {
        public UILogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Click(object sender, EventArgs e)
        {

        }

        private void FrmPassword_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // 1. Ocultar las etiquetas de error al iniciar
            lblError.Visible = false;
            lblErrorUser.Visible = false;
            lblErrorPassword.Visible = false;

            // 2. Validar llenado de datos
            if (string.IsNullOrWhiteSpace(textUser.Text) && string.IsNullOrWhiteSpace(textPassword.Text))
            {
                MostrarError("Por favor, ingrese su usuario y contraseña.");
                return; // Detiene la ejecución
            }

            if (string.IsNullOrWhiteSpace(textUser.Text))
            {
                lblErrorUser.Text = "Ingrese el Usuario";
                lblErrorUser.Visible = true;
                return; // Detiene la ejecución si falta el usuario
            }

            if (string.IsNullOrWhiteSpace(textPassword.Text))
            {
                lblErrorPassword.Text = "Ingrese la Contraseña";
                lblErrorPassword.Visible = true;
                return; // Detiene la ejecución si falta la contraseña
            }

            // 3. Autenticar con el Backend
            AuthService authService = new AuthService();
            bool loginExitoso = authService.IniciarSesion(textUser.Text.Trim(), textPassword.Text);

            if (loginExitoso)
            {
                // Ocultar el Login y abrir el Menú Principal
                UIMenuPrincipal menu = new UIMenuPrincipal();
                this.Hide();
                menu.ShowDialog();

                // Al cerrar sesión en el menú, limpiar contraseña y volver a mostrar el Login
                textPassword.Clear();
                this.Show();
            }
            else
            {
                MostrarError("Usuario o contraseña incorrectos.");
            }
        }


        // Método auxiliar para no repetir código
        private void MostrarError(string mensaje)
        {
            lblError.Text = mensaje;
            lblError.Visible = true;
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorUser_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorPassword_Click(object sender, EventArgs e)
        {

        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Esto evita que suene el molesto "beep" de error de Windows
                btnIngresar.PerformClick(); // Simula que presionaste el botón Guardar
            }
        }

        private void textUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}"); // Mueve el foco al siguiente control
            }
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            UIRegistroUsuarios frmRegistro = new UIRegistroUsuarios();
            this.Hide();
            frmRegistro.ShowDialog();
            this.Show();
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UIRegistroUsuarios ventanaRegistro = new UIRegistroUsuarios();
            ventanaRegistro.StartPosition = FormStartPosition.CenterScreen;
            ventanaRegistro.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
