using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DeskIU.Negocio;
using System.Linq;

namespace DeskIU.Presentacion.Forms
{
    public partial class FrmReportes : Form
    {
        ReporteServicio _svc = new ReporteServicio();

        public FrmReportes() { InitializeComponent(); }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            cbEstadoR1.SelectedIndex = 0;
            dtpDesdeR1.Value = DateTime.Now.AddMonths(-1);
            dtpHastaR1.Value = DateTime.Now;
            dtpDesdeR2.Value = DateTime.Now.AddMonths(-1);
            dtpHastaR2.Value = DateTime.Now;
            cbTipoUsuarioR4.SelectedIndex = 0;
        }

        // ====================================================
        // REPORTE 1: Por Estado y Rango de Fechas
        // ====================================================
        private void btnBuscarR1_Click(object sender, EventArgs e)
        {
            try
            {
                var datos = _svc.Reporte1_PorEstadoYFecha(
                    cbEstadoR1.SelectedItem.ToString(),
                    dtpDesdeR1.Value.Date,
                    dtpHastaR1.Value.Date.AddDays(1).AddSeconds(-1));

                dgR1.DataSource = datos;
                lblTotalR1.Text = "Total encontradas: " + datos.Count + " solicitudes";

                // Grafico de barras por estado
                ActualizarGraficoR1(datos);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void ActualizarGraficoR1(System.Collections.Generic.List<DtoReporteSolicitud> datos)
        {
            chartR1.Series.Clear();
            chartR1.Titles.Clear();
            chartR1.Titles.Add("Solicitudes por Estado");

            var serie = new Series("Estados") { ChartType = SeriesChartType.Bar };
            var grupos = datos.GroupBy(d => d.Estado);
            foreach (var g in grupos)
                serie.Points.AddXY(g.Key, g.Count());

            chartR1.Series.Add(serie);
        }

        // ====================================================
        // REPORTE 2: Rendimiento por Tecnico
        // ====================================================
        private void btnBuscarR2_Click(object sender, EventArgs e)
        {
            try
            {
                var datos = _svc.Reporte2_RendimientoTecnico(
                    dtpDesdeR2.Value.Date,
                    dtpHastaR2.Value.Date.AddDays(1).AddSeconds(-1));

                dgR2.DataSource = datos;
                lblTotalR2.Text = "Tecnicos encontrados: " + datos.Count;

                // Grafico de barras: resueltas por tecnico
                chartR2.Series.Clear();
                chartR2.Titles.Clear();
                chartR2.Titles.Add("Solicitudes Resueltas por Tecnico");
                var serie = new Series("Resueltas") { ChartType = SeriesChartType.Bar };
                foreach (var d in datos)
                    serie.Points.AddXY(d.Tecnico, d.Resueltas);
                chartR2.Series.Add(serie);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // ====================================================
        // REPORTE 3: Solicitudes Urgentes sin Resolver
        // ====================================================
        private void btnBuscarR3_Click(object sender, EventArgs e)
        {
            try
            {
                var datos = _svc.Reporte3_Urgentes();
                dgR3.DataSource = datos;
                lblTotalR3.Text = "Total urgentes pendientes: " + datos.Count;

                // Grafico de torta por categoria
                chartR3.Series.Clear();
                chartR3.Titles.Clear();
                chartR3.Titles.Add("Urgentes por Categoria");
                var serie = new Series("Urgentes") { ChartType = SeriesChartType.Pie, IsValueShownAsLabel = true };
                foreach (var g in datos.GroupBy(d => d.Categoria))
                    serie.Points.AddXY(g.Key, g.Count());
                chartR3.Series.Add(serie);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // ====================================================
        // REPORTE 4: Por Tipo de Usuario
        // ====================================================
        private void btnBuscarR4_Click(object sender, EventArgs e)
        {
            try
            {
                var datos = _svc.Reporte4_PorTipoUsuario(
                    cbTipoUsuarioR4.SelectedItem.ToString());

                dgR4.DataSource = datos;
                lblTotalR4.Text = "Total encontradas: " + datos.Count + " solicitudes";

                // Grafico de torta por tipo de usuario
                chartR4.Series.Clear();
                chartR4.Titles.Clear();
                chartR4.Titles.Add("Solicitudes por Tipo de Usuario");
                var serie = new Series("TipoUsuario") { ChartType = SeriesChartType.Pie, IsValueShownAsLabel = true };
                serie.Label = "#PERCENT{P1}";
                foreach (var g in datos.GroupBy(d => d.TipoUsuario))
                    serie.Points.AddXY(g.Key, g.Count());
                chartR4.Series.Add(serie);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSalir_Click(object sender, EventArgs e) => Close();

        private void Tp1_Click(object sender, EventArgs e)
        {

        }

        private void BtnReporteJuan_Click(object sender, EventArgs e)
        {
            DgData5.DataSource = null;
            DgData5.DataSource = _svc.TecnicoDeUnaCategoria();
        }
    }
}
