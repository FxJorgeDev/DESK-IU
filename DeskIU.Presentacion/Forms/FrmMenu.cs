using System;
using System.Windows.Forms;

namespace DeskIU.Presentacion.Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.Text = "DeskIU - Sistema de Soporte Tecnico";
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            new FrmTecnico().ShowDialog();
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            new FrmSolicitud().ShowDialog();
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            new FrmAsignaciones().ShowDialog();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            new FrmResolverSolicitud().ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            new FrmCategoria().ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            new FrmReportes().ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
