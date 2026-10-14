using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudSeguro.Backend;
using CrudSeguro.DTOs;

namespace Crud_Seguro
{
    public partial class UIRegistroUsuarios : Form
    {
        public UIRegistroUsuarios()
        {
            InitializeComponent();
        }

        private void UIRegistroUsuarios_Load(object sender, EventArgs e)
        {
           
        }

        private void NuevoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y la tecla de borrar (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otra tecla
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private readonly UsuarioService _usuarioService = new UsuarioService();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //lblError.Visible = false;

            // 1. Validación de llenado (Campos vacíos generales)
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEstado.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoPostal.Text))
            {
                MostrarError("Todos los campos de texto principales son obligatorios.");
                return;
            }

            // 2. Validación de Listas Desplegables (ComboBox)
            if (cmbRol.SelectedIndex == -1) // Roles obligatorios
            {
                MostrarError("Debe seleccionar si el rol es Administrador o Empleado.");
                return;
            }

            if (cmbCiudad.SelectedIndex <= 0) // Validar que no se quede en el texto guía "-- Ciudad --"
            {
                MostrarError("Debe seleccionar una ciudad válida de la lista.");
                return;
            }

            // 3. Validación de Longitudes Mínimas, Exactas y Salario numérico
            if (txtPassword.Text.Length < 6)
            {
                MostrarError("La contraseña debe tener al menos 6 caracteres.");
                return;
            }

            if (txtTelefono.Text.Length != 10)
            {
                MostrarError("El teléfono debe tener exactamente 10 dígitos.");
                return;
            }

            if (!decimal.TryParse(txtSalario.Text.Trim(), out decimal salarioValido) || salarioValido <= 0)
            {
                MostrarError("Ingrese un salario numérico válido mayor a 0.");
                return;
            }

            // 4. Validación estricta de los 3 datos que serán encriptados en Azure
            if (txtRFC.Text.Length < 12 || txtRFC.Text.Length > 13)
            {
                MostrarError("El RFC debe tener 12 o 13 caracteres.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNSS.Text) || txtNSS.Text.Length != 11)
            {
                MostrarError("El Número de Seguridad Social (NSS) debe tener exactamente 11 dígitos.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClabe.Text) || txtClabe.Text.Length != 18)
            {
                MostrarError("La Clabe interbancaria debe tener exactamente 18 dígitos.");
                return;
            }

            // 5. Empaquetar en el DTO y llamar al Backend
            UsuarioDTO nuevoUsuario = new UsuarioDTO
            {
                Nombre = txtNombre.Text.Trim(),
                PrimerApellido = txtPrimerApellido.Text.Trim(),
                SegundoApellido = txtSegundoApellido.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Password = txtPassword.Text,
                Telefono = txtTelefono.Text.Trim(),
                Rol = cmbRol.SelectedItem.ToString(),
                Ciudad = cmbCiudad.SelectedItem.ToString(),
                Estado = txtEstado.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                CodigoPostal = txtCodigoPostal.Text.Trim(),
                Salario = salarioValido,
                RFC = txtRFC.Text.Trim().ToUpper(),
                NSS = txtNSS.Text.Trim(),
                ClabeInterbancaria = txtClabe.Text.Trim()
            };

            string resultado = _usuarioService.RegistrarUsuario(nuevoUsuario);

            if (resultado == "OK")
            {
                MessageBox.Show("¡Usuario registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // O llama a tu método para limpiar cajas de texto
            }
            else
            {
                MostrarError(resultado);
            }
        }

        private void MostrarError(string mensaje)
        {
            lblError.Text = mensaje;
            lblError.Visible = true;
        }

        private void guna2TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
