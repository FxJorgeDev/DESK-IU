using System;
using System.Linq;
using System.Windows.Forms;
using DeskIU.Negocio;

namespace DeskIU.Presentacion.Forms
{
    public partial class FrmAsignaciones : Form
    {
        SolicitudServicio _svc = new SolicitudServicio();

        public FrmAsignaciones() { InitializeComponent(); }

        private void FrmAsignaciones_Load(object sender, EventArgs e) => CargarSolicitudes();

        private void CargarSolicitudes()
        {
            var lista = _svc.ListarTodas();
            dgSolicitudes.DataSource = null;
            dgSolicitudes.DataSource = lista.Select(s => new
            {
                s.IdSolicitud,
                s.Titulo,
                s.Estado,
                s.Prioridad,
                Categoria = s.Categoria?.Nombre,
                Usuario = s.Usuario != null ? s.Usuario.Nombre + " " + s.Usuario.Apellido : "",
                TecnicoAsignado = s.Tecnico != null ? s.Tecnico.Nombre + " " + s.Tecnico.Apellido : "",
                Especialidad = s.Tecnico?.Especialidad,
                Disponibilidad = s.Tecnico?.Disponibilidad,
                FechaRegistro = s.FechaRegistro.ToString("dd/MM/yyyy HH:mm")
            }).ToList();
        }

        private void dgSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgSolicitudes.Rows[e.RowIndex];
            lblTecnico.Text = "Tecnico: " + row.Cells["TecnicoAsignado"].Value;
            lblEspecialidad.Text = "Especialidad: " + row.Cells["Especialidad"].Value;
            lblDisponibilidad.Text = "Disponibilidad: " + row.Cells["Disponibilidad"].Value;
        }

        private void btnSalir_Click(object sender, EventArgs e) => Close();
    }
}
