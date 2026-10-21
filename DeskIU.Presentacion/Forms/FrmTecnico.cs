using System;
using System.Windows.Forms;
using DeskIU.Negocio;
using DeskIU.Datos.Entidades;

namespace DeskIU.Presentacion.Forms
{
    public partial class FrmTecnico : Form
    {
        TecnicoServicio _svc = new TecnicoServicio();

        public FrmTecnico() { InitializeComponent(); }

        private void FrmTecnico_Load(object sender, EventArgs e)
        {
            cbEspecialidad.SelectedIndex = -1;
            cbDisponibilidad.SelectedIndex = 0;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dgTecnicos.DataSource = null;
            dgTecnicos.DataSource = _svc.ListarTodos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
                string.IsNullOrWhiteSpace(tbApellido.Text) ||
                string.IsNullOrWhiteSpace(tbCorreo.Text) ||
                cbEspecialidad.SelectedIndex < 0)
            { MessageBox.Show("Complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!UsuarioServicio.EsSoloLetras(tbNombre.Text.Trim()))
            { MessageBox.Show("El nombre solo puede contener letras."); tbNombre.Focus(); return; }

            if (!UsuarioServicio.EsSoloLetras(tbApellido.Text.Trim()))
            { MessageBox.Show("El apellido solo puede contener letras."); tbApellido.Focus(); return; }

            if (!UsuarioServicio.EsCorreoValido(tbCorreo.Text.Trim()))
            { MessageBox.Show("Ingrese un correo valido (ejemplo@dominio.com)."); tbCorreo.Focus(); return; }

            try
            {
                _svc.Registrar(new Tecnico
                {
                    Nombre = tbNombre.Text.Trim(),
                    Apellido = tbApellido.Text.Trim(),
                    Correo = tbCorreo.Text.Trim(),
                    Especialidad = cbEspecialidad.SelectedItem.ToString(),
                    Disponibilidad = cbDisponibilidad.SelectedItem.ToString()
                }, "sistema");

                MessageBox.Show("Tecnico registrado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgTecnicos.CurrentRow == null) { MessageBox.Show("Seleccione un tecnico."); return; }

            if (MessageBox.Show("¿Actualizar este tecnico?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var t = (Tecnico)dgTecnicos.CurrentRow.DataBoundItem;
            t.Nombre = tbNombre.Text.Trim();
            t.Apellido = tbApellido.Text.Trim();
            t.Correo = tbCorreo.Text.Trim();
            t.Especialidad = cbEspecialidad.SelectedItem?.ToString() ?? t.Especialidad;
            t.Disponibilidad = cbDisponibilidad.SelectedItem?.ToString() ?? t.Disponibilidad;

            _svc.Actualizar(t, "sistema");
            MessageBox.Show("Tecnico actualizado correctamente.");
            CargarGrilla();
        }

        private void dgTecnicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var t = (Tecnico)dgTecnicos.Rows[e.RowIndex].DataBoundItem;
            tbNombre.Text = t.Nombre;
            tbApellido.Text = t.Apellido;
            tbCorreo.Text = t.Correo;
            cbEspecialidad.SelectedItem = t.Especialidad;
            cbDisponibilidad.SelectedItem = t.Disponibilidad;
        }

        private void LimpiarCampos()
        {
            tbNombre.Clear(); tbApellido.Clear(); tbCorreo.Clear();
            cbEspecialidad.SelectedIndex = -1;
            cbDisponibilidad.SelectedIndex = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgTecnicos.CurrentRow == null) { MessageBox.Show("Seleccione un tecnico."); return; }
            var t = (Tecnico)dgTecnicos.CurrentRow.DataBoundItem;
            if (MessageBox.Show("¿Eliminar el tecnico " + t.Nombre + " " + t.Apellido + "?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try { _svc.Eliminar(t.IdTecnico); MessageBox.Show("Tecnico eliminado."); CargarGrilla(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();
        private void btnSalir_Click(object sender, EventArgs e) => Close();
    }
}
