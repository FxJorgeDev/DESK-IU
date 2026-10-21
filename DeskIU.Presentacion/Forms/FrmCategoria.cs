using System;
using System.Windows.Forms;
using DeskIU.Negocio;
using DeskIU.Datos.Entidades;

namespace DeskIU.Presentacion.Forms
{
    public partial class FrmCategoria : Form
    {
        CategoriaServicio _svc = new CategoriaServicio();

        public FrmCategoria() { InitializeComponent(); }

        private void FrmCategoria_Load(object sender, EventArgs e) => CargarGrilla();

        private void CargarGrilla()
        {
            dgCategorias.DataSource = null;
            dgCategorias.DataSource = _svc.ListarTodas();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            { MessageBox.Show("Ingrese el nombre de la categoria."); return; }

            if (tbNombre.Text.Trim().Length < 3)
            { MessageBox.Show("El nombre debe tener al menos 3 caracteres."); tbNombre.Focus(); return; }

            try
            {
                _svc.Registrar(new Categoria
                {
                    Nombre = tbNombre.Text.Trim(),
                    Descripcion = tbDescripcion.Text.Trim()
                }, "sistema");

                MessageBox.Show("Categoria registrada correctamente.");
                LimpiarCampos(); CargarGrilla();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgCategorias.CurrentRow == null) { MessageBox.Show("Seleccione una categoria."); return; }

            if (MessageBox.Show("¿Actualizar esta categoria?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            var c = (Categoria)dgCategorias.CurrentRow.DataBoundItem;
            c.Nombre = tbNombre.Text.Trim();
            c.Descripcion = tbDescripcion.Text.Trim();
            _svc.Actualizar(c, "sistema");
            MessageBox.Show("Categoria actualizada.");
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgCategorias.CurrentRow == null) { MessageBox.Show("Seleccione una categoria."); return; }

            var c = (Categoria)dgCategorias.CurrentRow.DataBoundItem;
            if (MessageBox.Show("¿Eliminar la categoria '" + c.Nombre + "'?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try { _svc.Eliminar(c.IdCategoria); MessageBox.Show("Categoria eliminada."); CargarGrilla(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void dgCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var c = (Categoria)dgCategorias.Rows[e.RowIndex].DataBoundItem;
            tbNombre.Text = c.Nombre;
            tbDescripcion.Text = c.Descripcion;
        }

        private void LimpiarCampos() { tbNombre.Clear(); tbDescripcion.Clear(); }
        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();
        private void btnSalir_Click(object sender, EventArgs e) => Close();
    }
}
