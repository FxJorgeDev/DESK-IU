using System;
using System.Linq;
using System.Windows.Forms;
using DeskIU.Negocio;
using DeskIU.Datos.Entidades;

namespace DeskIU.Presentacion.Forms
{
    public partial class FrmSolicitud : Form
    {
        SolicitudServicio _svcSol = new SolicitudServicio();
        UsuarioServicio _svcUsu = new UsuarioServicio();
        TecnicoServicio _svcTec = new TecnicoServicio();
        CategoriaServicio _svcCat = new CategoriaServicio();

        public FrmSolicitud() { InitializeComponent(); }

        private void FrmSolicitud_Load(object sender, EventArgs e)
        {
            cbPrioridad.SelectedIndex = 1;
            CargarCombos();
            CargarGrilla();
        }

        private void CargarCombos()
        {
            var usuarios = _svcUsu.ListarTodos()
                .Select(u => new { u.IdUsuario, NombreCompleto = u.Nombre + " " + u.Apellido }).ToList();
            cbUsuario.DataSource = usuarios;
            cbUsuario.DisplayMember = "NombreCompleto";
            cbUsuario.ValueMember = "IdUsuario";
            cbUsuario.SelectedIndex = -1;

            var tecnicos = _svcTec.ListarDisponibles()
                .Select(t => new { t.IdTecnico, NombreCompleto = t.Nombre + " " + t.Apellido }).ToList();
            cbTecnico.DataSource = tecnicos;
            cbTecnico.DisplayMember = "NombreCompleto";
            cbTecnico.ValueMember = "IdTecnico";
            cbTecnico.SelectedIndex = -1;

            cbCategoria.DataSource = _svcCat.ListarTodas();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "IdCategoria";
            cbCategoria.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {
            var lista = _svcSol.ListarTodas();
            dgSolicitudes.DataSource = null;
            dgSolicitudes.DataSource = lista.Select(s => new
            {
                s.IdSolicitud,
                s.Titulo,
                s.Estado,
                s.Prioridad,
                Categoria = s.Categoria?.Nombre,
                Usuario = s.Usuario != null ? s.Usuario.Nombre + " " + s.Usuario.Apellido : "",
                Tecnico = s.Tecnico != null ? s.Tecnico.Nombre + " " + s.Tecnico.Apellido : "",
                FechaRegistro = s.FechaRegistro.ToString("dd/MM/yyyy HH:mm"),
                s.CreadoPor,
                s.FechaCreacion
            }).ToList();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitulo.Text) ||
                string.IsNullOrWhiteSpace(tbDescripcion.Text) ||
                cbUsuario.SelectedIndex < 0 ||
                cbTecnico.SelectedIndex < 0 ||
                cbCategoria.SelectedIndex < 0 ||
                cbPrioridad.SelectedIndex < 0)
            { MessageBox.Show("Complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (tbTitulo.Text.Trim().Length < 3)
            { MessageBox.Show("El titulo debe tener al menos 3 caracteres."); tbTitulo.Focus(); return; }

            try
            {
                _svcSol.Registrar(new Solicitud
                {
                    IdUsuario = Convert.ToInt32(cbUsuario.SelectedValue),
                    IdTecnico = Convert.ToInt32(cbTecnico.SelectedValue),
                    IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue),
                    Titulo = tbTitulo.Text.Trim(),
                    Descripcion = tbDescripcion.Text.Trim(),
                    Prioridad = cbPrioridad.SelectedItem.ToString()
                }, "sistema");

                MessageBox.Show("Solicitud registrada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgSolicitudes.CurrentRow == null)
            { MessageBox.Show("Seleccione una solicitud."); return; }

            if (MessageBox.Show("¿Actualizar esta solicitud?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            int id = Convert.ToInt32(dgSolicitudes.CurrentRow.Cells["IdSolicitud"].Value);
            string estadoActual = dgSolicitudes.CurrentRow.Cells["Estado"].Value?.ToString() ?? "Pendiente";
            _svcSol.Actualizar(new Solicitud
            {
                IdSolicitud = id,
                Titulo = tbTitulo.Text.Trim(),
                Descripcion = tbDescripcion.Text.Trim(),
                Estado = estadoActual,
                Prioridad = cbPrioridad.SelectedItem?.ToString() ?? "Media",
                Observacion = tbObservacion.Text.Trim()
            }, "sistema");

            MessageBox.Show("Solicitud actualizada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgSolicitudes.CurrentRow == null) { MessageBox.Show("Seleccione una solicitud."); return; }

            int id = Convert.ToInt32(dgSolicitudes.CurrentRow.Cells["IdSolicitud"].Value);
            if (MessageBox.Show("¿Eliminar la solicitud " + id + "?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try { _svcSol.Eliminar(id); MessageBox.Show("Solicitud eliminada."); CargarGrilla(); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void dgSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgSolicitudes.Rows[e.RowIndex];
            tbTitulo.Text = row.Cells["Titulo"].Value?.ToString();
            cbPrioridad.SelectedItem = row.Cells["Prioridad"].Value?.ToString();
        }

        private void LimpiarCampos()
        {
            tbTitulo.Clear(); tbDescripcion.Clear(); tbObservacion.Clear();
            cbPrioridad.SelectedIndex = 1;
            cbUsuario.SelectedIndex = -1; cbTecnico.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e) => Close();
    }
}
