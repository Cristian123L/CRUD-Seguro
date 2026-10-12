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
            // 1. Ocultar la etiqueta de error al iniciar
            lblError.Visible = false;
            lblErrorUser.Visible = false;
            lblErrorPassword.Visible = false;

            //2.Validar llenado de datos
            if (string.IsNullOrWhiteSpace(textUser.Text) && string.IsNullOrWhiteSpace(textPassword.Text))
            {
                MostrarError("Por favor, ingrese su usuario y contraseña.");
                return; // Detiene la ejecución
            }

            if (string.IsNullOrWhiteSpace(textUser.Text))
            {
                lblErrorUser.Text = "Ingrese el Usuario";
                lblErrorUser.Visible = true;
            }
            if(string.IsNullOrWhiteSpace(textPassword.Text))
            {
                lblErrorPassword.Text = "Ingrese la Contraseña";
                lblErrorPassword.Visible = true;
            }


            AuthService authService = new AuthService();

            bool loginExitoso = authService.IniciarSesion(textUser.Text,textPassword.Text);
            if(loginExitoso)
            {
                MessageBox.Show("Acceso concedido. Preparando el menú principal...", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí luego programaremos el código para ocultar el Login y
                // abrir el menú
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
    }
}
