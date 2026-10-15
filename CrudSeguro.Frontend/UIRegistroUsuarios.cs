using System;
using System.Windows.Forms;
using CrudSeguro.Backend;
using CrudSeguro.DTOs;

namespace Crud_Seguro
{
    public partial class UIRegistroUsuarios : Form
    {
        // VARIABLES GLOBALES
        private readonly UsuarioService _usuarioService = new UsuarioService();
        private UsuarioDTO _usuarioEdicion = null;

        // CONSTRUCTOR Y CARGA INICIAL
        public UIRegistroUsuarios(UsuarioDTO usuarioAEditar = null)
        {
            InitializeComponent();
            _usuarioEdicion = usuarioAEditar;
        }

        private void UIRegistroUsuarios_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();

            if (_usuarioEdicion != null)
            {
                txtNombre.Text = _usuarioEdicion.Nombre;
                txtPrimerApellido.Text = _usuarioEdicion.PrimerApellido;
                txtSegundoApellido.Text = _usuarioEdicion.SegundoApellido;
                txtEmail.Text = _usuarioEdicion.Email;
                txtTelefono.Text = _usuarioEdicion.Telefono;
                cmbRol.SelectedItem = _usuarioEdicion.Rol;
                cmbCiudad.SelectedItem = _usuarioEdicion.Ciudad;
                txtEstado.Text = _usuarioEdicion.Estado;
                txtDireccion.Text = _usuarioEdicion.Direccion;
                txtCodigoPostal.Text = _usuarioEdicion.CodigoPostal;
                txtSalario.Text = _usuarioEdicion.Salario.ToString();

                // Campos sensibles
                txtPassword.Text = ""; // Por seguridad se limpia
                txtRFC.Text = _usuarioEdicion.RFC;
                txtNSS.Text = _usuarioEdicion.NSS;
                txtClabe.Text = _usuarioEdicion.ClabeInterbancaria;

                btnGuardar.Text = "Actualizar Cuenta";
            }
        }

        // EVENTO PRINCIPAL: GUARDAR / ACTUALIZAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validación de llenado (Password opcional si es edición)
            bool faltaPassword = (_usuarioEdicion == null) && string.IsNullOrWhiteSpace(txtPassword.Text);

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(txtSegundoApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                faltaPassword ||
                string.IsNullOrWhiteSpace(txtEstado.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoPostal.Text))
            {
                MostrarError("Todos los campos de texto principales son obligatorios.");
                return;
            }

            // 2. Validación de Listas Desplegables
            if (cmbRol.SelectedIndex == -1)
            {
                MostrarError("Debe seleccionar si el rol es Administrador o Empleado.");
                return;
            }

            if (cmbCiudad.SelectedIndex == -1)
            {
                MostrarError("Debe seleccionar una ciudad válida de la lista.");
                return;
            }

            // 3. Validación de Longitudes y Formatos
            if ((_usuarioEdicion == null || !string.IsNullOrWhiteSpace(txtPassword.Text)) && txtPassword.Text.Length < 6)
            {
                MostrarError("La contraseña debe tener al menos 6 caracteres.");
                return;
            }

            if (txtTelefono.Text.Length != 10)
            {
                MostrarError("El teléfono debe contener exactamente 10 dígitos.");
                return;
            }

            if (!decimal.TryParse(txtSalario.Text.Trim(), out decimal salarioValido) || salarioValido <= 0)
            {
                MostrarError("Ingrese un salario numérico mayor a 0.");
                return;
            }

            // 4. Validación estricta de campos cifrados (Haciéndolo insensible a mayúsculas)
            bool rfcModificado = !txtRFC.Text.ToUpper().Contains("(CIFRADO)") && !txtRFC.Text.Contains("•");
            bool nssModificado = !txtNSS.Text.ToUpper().Contains("(CIFRADO)") && !txtNSS.Text.Contains("•");
            bool clabeModificada = !txtClabe.Text.ToUpper().Contains("(CIFRADO)") && !txtClabe.Text.Contains("•");

            if (_usuarioEdicion == null || rfcModificado)
            {
                if (txtRFC.Text.Length < 12 || txtRFC.Text.Length > 13)
                {
                    MostrarError("El RFC debe contener entre 12 y 13 caracteres.");
                    return;
                }
            }

            if (_usuarioEdicion == null || nssModificado)
            {
                if (string.IsNullOrWhiteSpace(txtNSS.Text) || txtNSS.Text.Length != 11)
                {
                    MostrarError("El NSS debe ser exactamente de 11 dígitos.");
                    return;
                }
            }

            if (_usuarioEdicion == null || clabeModificada)
            {
                if (string.IsNullOrWhiteSpace(txtClabe.Text) || txtClabe.Text.Length != 18)
                {
                    MostrarError("La Clabe Interbancaria debe contener exactamente 18 dígitos.");
                    return;
                }
            }

            // 5. Empaquetar en el DTO
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
                // Si no se modificaron, mantenemos el valor original oculto
                RFC = (_usuarioEdicion != null && !rfcModificado) ? _usuarioEdicion.RFC : txtRFC.Text.Trim().ToUpper(),
                NSS = (_usuarioEdicion != null && !nssModificado) ? _usuarioEdicion.NSS : txtNSS.Text.Trim(),
                ClabeInterbancaria = (_usuarioEdicion != null && !clabeModificada) ? _usuarioEdicion.ClabeInterbancaria : txtClabe.Text.Trim()
            };

            // 6. Enviar a Base de Datos
            string resultado;

            if (_usuarioEdicion == null)
            {
                resultado = _usuarioService.RegistrarUsuario(nuevoUsuario);
            }
            else
            {
                nuevoUsuario.IdUsuario = _usuarioEdicion.IdUsuario;
                resultado = _usuarioService.ActualizarUsuario(nuevoUsuario);
            }

            // 7. Evaluar Respuesta
            if (resultado == "OK")
            {
                string accion = _usuarioEdicion == null ? "registrado" : "actualizado";
                MessageBox.Show($"¡Usuario {accion} exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Con esto es suficiente, el UIMenuPrincipal original sigue esperando atrás
                this.Close();
            }
            else
            {
                MostrarError(resultado);
            }
        }

        // METODOS AUXILIARES Y EVENTOS DE UI
        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            UILogin ventanaLogin = new UILogin();
            ventanaLogin.Show();
            this.Close();

        }

        private void txtClabe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnGuardar.PerformClick();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void NuevoUsuario_Click(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged_2(object sender, EventArgs e) { }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e) { }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e) { }
        private void txtDireccion_TextChanged(object sender, EventArgs e) { }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UIMenuPrincipal menu = new UIMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}