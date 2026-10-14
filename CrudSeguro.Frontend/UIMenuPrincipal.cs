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

        private void UIMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (SesionActual.Rol == "Empleado")
            {
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }

            CargarGrid();
        }

        private void CargarGrid()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = _usuarioService.ObtenerUsuariosParaGrid();

            if (dgvUsuarios.Columns["Password"] != null)
                dgvUsuarios.Columns["Password"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UIRegistroUsuarios formRegistro = new UIRegistroUsuarios();

            this.Hide();
            formRegistro.ShowDialog();

            this.Show();
            CargarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;

            UsuarioDTO seleccionado = (UsuarioDTO)dgvUsuarios.CurrentRow.DataBoundItem;

            UIRegistroUsuarios formEditar = new UIRegistroUsuarios();

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

            var r = MessageBox.Show($"¿Seguro que deseas eliminar a {nombre}?", "Confirmar",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                _usuarioService.EliminarUsuario(idSeleccionado);
                CargarGrid();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SesionActual.CerrarSesion();
            this.Close();
        }
    }
}