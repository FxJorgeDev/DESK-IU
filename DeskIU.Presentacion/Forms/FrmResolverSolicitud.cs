using System;
using System.Linq;
using System.Windows.Forms;
using DeskIU.Negocio;

namespace DeskIU.Presentacion.Forms
{
    public class ItemCombo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public partial class FrmResolverSolicitud : Form
    {
        SolicitudServicio _svcSol = new SolicitudServicio();
        TecnicoServicio _svcTec = new TecnicoServicio();

        public FrmResolverSolicitud() { InitializeComponent(); }

        private void FrmResolverSolicitud_Load(object sender, EventArgs e)
        {
            var tecnicos = _svcTec.ListarTodos()
                .Select(t => new ItemCombo { Id = t.IdTecnico, Nombre = t.Nombre + " " + t.Apellido }).ToList();
            cbTecnico.DisplayMember = "Nombre";
            cbTecnico.ValueMember = "Id";
            cbTecnico.DataSource = tecnicos;
            cbTecnico.SelectedIndex = -1;
        }

        private void cbTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTecnico.SelectedIndex < 0) return;
            int idTecnico = (int)cbTecnico.SelectedValue;
            CargarSolicitudes(idTecnico);
        }

        private void CargarSolicitudes(int idTecnico)
        {
            var lista = _svcSol.ListarPorTecnico(idTecnico);
            dgSolicitudes.DataSource = null;
            dgSolicitudes.DataSource = lista.Select(s => new
            {
                s.IdSolicitud,
                s.Titulo,
                s.Prioridad,
                Categoria = s.Categoria?.Nombre,
                Usuario = s.Usuario != null ? s.Usuario.Nombre + " " + s.Usuario.Apellido : "",
                FechaRegistro = s.FechaRegistro.ToString("dd/MM/yyyy HH:mm")
            }).ToList();

            lblTotal.Text = "Pendientes: " + lista.Count;
        }

        private void dgSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgSolicitudes.Rows[e.RowIndex];
            lblInfo.Text = "Solicitud #" + row.Cells["IdSolicitud"].Value + ": " + row.Cells["Titulo"].Value;
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (dgSolicitudes.CurrentRow == null)
            { MessageBox.Show("Seleccione una solicitud pendiente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrWhiteSpace(tbObservacion.Text))
            { MessageBox.Show("Ingrese una observacion sobre la resolucion.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbObservacion.Focus(); return; }

            int idSolicitud = Convert.ToInt32(dgSolicitudes.CurrentRow.Cells["IdSolicitud"].Value);

            if (MessageBox.Show("¿Marcar la solicitud #" + idSolicitud + " como RESUELTA?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                _svcSol.Resolver(idSolicitud, tbObservacion.Text.Trim(), "sistema");
                MessageBox.Show("Solicitud resuelta correctamente. El tecnico ahora esta disponible.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbObservacion.Clear();
                lblInfo.Text = "Seleccione una solicitud";
                if (cbTecnico.SelectedIndex >= 0)
                    CargarSolicitudes((int)cbTecnico.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) => Close();
    }
}
