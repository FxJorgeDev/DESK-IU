using System;
using System.Windows.Forms;
using DeskIU.Negocio;
using DeskIU.Datos.Entidades;

namespace DeskIU.Presentacion.Forms
{
    public partial class FrmUsuario : Form
    {
        UsuarioServicio _svc = new UsuarioServicio();

        public FrmUsuario() { InitializeComponent(); }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            cbTipoUsuario.SelectedIndex = -1;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            var lista = _svc.ListarTodos();
            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = lista;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
                string.IsNullOrWhiteSpace(tbApellido.Text) ||
                string.IsNullOrWhiteSpace(tbCorreo.Text) ||
                string.IsNullOrWhiteSpace(tbCelular.Text) ||
                cbTipoUsuario.SelectedIndex < 0)
            { MessageBox.Show("Complete todos los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!UsuarioServicio.EsSoloLetras(tbNombre.Text.Trim()))
            { MessageBox.Show("El nombre solo puede contener letras."); tbNombre.Focus(); return; }

            if (!UsuarioServicio.EsSoloLetras(tbApellido.Text.Trim()))
            { MessageBox.Show("El apellido solo puede contener letras."); tbApellido.Focus(); return; }

            if (!UsuarioServicio.EsCorreoValido(tbCorreo.Text.Trim()))
            { MessageBox.Show("Ingrese un correo valido (ejemplo@dominio.com)."); tbCorreo.Focus(); return; }

            if (!UsuarioServicio.EsCelularValido(tbCelular.Text.Trim()))
            { MessageBox.Show("El celular debe tener 9 digitos."); tbCelular.Focus(); return; }

            try
            {
                _svc.Registrar(new Usuario
                {
                    Nombre = tbNombre.Text.Trim(),
                    Apellido = tbApellido.Text.Trim(),
                    Correo = tbCorreo.Text.Trim(),
                    Celular = tbCelular.Text.Trim(),
                    TipoUsuario = cbTipoUsuario.SelectedItem.ToString()
                }, "sistema");

                MessageBox.Show("Usuario registrado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.CurrentRow == null) { MessageBox.Show("Seleccione un usuario."); return; }

            if (MessageBox.Show("¿Actualizar este usuario?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var u = (Usuario)dgUsuarios.CurrentRow.DataBoundItem;
            u.Nombre = tbNombre.Text.Trim();
            u.Apellido = tbApellido.Text.Trim();
            u.Correo = tbCorreo.Text.Trim();
            u.Celular = tbCelular.Text.Trim();
            u.TipoUsuario = cbTipoUsuario.SelectedItem?.ToString() ?? u.TipoUsuario;

            _svc.Actualizar(u, "sistema");
            MessageBox.Show("Usuario actualizado correctamente.");
            CargarGrilla();
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var u = (Usuario)dgUsuarios.Rows[e.RowIndex].DataBoundItem;
            tbNombre.Text = u.Nombre;
            tbApellido.Text = u.Apellido;
            tbCorreo.Text = u.Correo;
            tbCelular.Text = u.Celular;
            cbTipoUsuario.SelectedItem = u.TipoUsuario;
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear(); tbApellido.Clear();
            tbCorreo.Clear(); tbCelular.Clear();
            cbTipoUsuario.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.CurrentRow == null) { MessageBox.Show("Seleccione un usuario."); return; }
            var u = (Usuario)dgUsuarios.CurrentRow.DataBoundItem;
            if (MessageBox.Show("¿Eliminar el usuario " + u.Nombre + " " + u.Apellido + "?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try { _svc.Eliminar(u.IdUsuario); MessageBox.Show("Usuario eliminado."); CargarGrilla(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();
        private void btnSalir_Click(object sender, EventArgs e) => Close();
    }
}
