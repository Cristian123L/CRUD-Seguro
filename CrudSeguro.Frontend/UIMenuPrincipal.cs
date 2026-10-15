using System;
using System.Windows.Forms;
using CrudSeguro.Backend;
using CrudSeguro.DTOs;

namespace Crud_Seguro
{
    public partial class UIMenuPrincipal : Form
    {
        private readonly UsuarioService _usuarioService = new UsuarioService();

        public UIMenuPrincipal()
        {
            InitializeComponent();
        }

        // CARGA Y CONFIGURACIÓN INICIAL
        
        private void UIMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Restricción de permisos según el rol
            if (SesionActual.Rol == "Empleado")
            {
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }

            CargarGrid();
        }

        // Metodo vacío dejado por si el diseñador visual lo enlazó accidentalmente
        private void UIMenuPrincipal_Load_1(object sender, EventArgs e) { }

        private void CargarGrid()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = _usuarioService.ObtenerUsuariosParaGrid();

            if (dgvUsuarios.Columns["Password"] != null)
                dgvUsuarios.Columns["Password"].Visible = false;
        }

        // EVENTOS DE BOTONES (CRUD)
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UIRegistroUsuarios formRegistro = new UIRegistroUsuarios();

            this.Hide();
            formRegistro.ShowDialog();

            // Al cerrar el registro, regresamos aquí automáticamente
            this.Show();
            CargarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario de la tabla primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuarioDTO seleccionado = (UsuarioDTO)dgvUsuarios.CurrentRow.DataBoundItem;
            UIRegistroUsuarios formEditar = new UIRegistroUsuarios(seleccionado);

            this.Hide();
            formEditar.ShowDialog();

            this.Show();
            CargarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;

            int idSeleccionado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
            string nombre = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();

            var respuesta = MessageBox.Show($"¿Seguro que deseas eliminar a {nombre}?", "Confirmar Eliminación",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                string res = _usuarioService.EliminarUsuario(idSeleccionado);

                if (res == "OK")
                {
                    MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show("Detalle del error: " + res, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // SALIDA
        private void btnSalir_Click(object sender, EventArgs e)
        {
            UIRegistroUsuarios ventanaLogin = new UIRegistroUsuarios();
            ventanaLogin.Show();
            this.Close();
        }
    }
}