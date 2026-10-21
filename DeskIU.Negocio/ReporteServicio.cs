using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using DeskIU.Datos.Contexto;
using DeskIU.Datos.Entidades;

namespace DeskIU.Negocio
{
    // DTO Reporte General
    public class DtoReporteSolicitud
    {
        public int IdSolicitud { get; set; }
        public string Titulo { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public string Categoria { get; set; }
        public string TipoUsuario { get; set; }
        public string Usuario { get; set; }
        public string Tecnico { get; set; }
        public string Especialidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public int HorasAtencion { get; set; }
    }

    // DTO Rendimiento Tecnico
    public class DtoRendimientoTecnico
    {
        public string Tecnico { get; set; }
        public string Especialidad { get; set; }
        public int TotalAsignadas { get; set; }
        public int Resueltas { get; set; }
        public int Pendientes { get; set; }
        public string PromedioHorasResolucion { get; set; }
    }
    public class DtoTecnico_Categoria
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }

    }
    public class ReporteServicio
    {
        // ============================================================
        // REPORTE 1: Solicitudes por Estado y Rango de Fechas
        // ============================================================
        public List<DtoReporteSolicitud> Reporte1_PorEstadoYFecha(
            string estado, DateTime? desde, DateTime? hasta)
        {
            using (var ctx = new DeskIUContext())
            {
                var q = ctx.Solicitudes
                    .Include(s => s.Usuario)
                    .Include(s => s.Tecnico)
                    .Include(s => s.Categoria)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(estado) && estado != "Todos")
                    q = q.Where(s => s.Estado == estado);
                if (desde.HasValue)
                    q = q.Where(s => s.FechaRegistro >= desde.Value);
                if (hasta.HasValue)
                    q = q.Where(s => s.FechaRegistro <= hasta.Value);

                return q.OrderByDescending(s => s.FechaRegistro).ToList()
                    .Select(s => new DtoReporteSolicitud
                    {
                        IdSolicitud = s.IdSolicitud,
                        Titulo = s.Titulo,
                        Estado = s.Estado,
                        Prioridad = s.Prioridad,
                        Categoria = s.Categoria?.Nombre ?? "",
                        TipoUsuario = s.Usuario?.TipoUsuario ?? "",
                        Usuario = (s.Usuario?.Nombre ?? "") + " " + (s.Usuario?.Apellido ?? ""),
                        Tecnico = (s.Tecnico?.Nombre ?? "") + " " + (s.Tecnico?.Apellido ?? ""),
                        Especialidad = s.Tecnico?.Especialidad ?? "",
                        FechaRegistro = s.FechaRegistro,
                        FechaResolucion = s.FechaResolucion,
                        HorasAtencion = (int)((s.FechaResolucion ?? DateTime.Now) - s.FechaRegistro).TotalHours
                    }).ToList();
            }
        }

        // ============================================================
        // REPORTE 2: Rendimiento por Tecnico
        // ============================================================
        public List<DtoRendimientoTecnico> Reporte2_RendimientoTecnico(
            DateTime? desde, DateTime? hasta)
        {
            using (var ctx = new DeskIUContext())
            {
                var q = ctx.Solicitudes
                    .Include(s => s.Tecnico)
                    .AsQueryable();

                if (desde.HasValue) q = q.Where(s => s.FechaRegistro >= desde.Value);
                if (hasta.HasValue) q = q.Where(s => s.FechaRegistro <= hasta.Value);

                return q.ToList()
                    .GroupBy(s => s.Tecnico)
                    .Select(g =>
                    {
                        var resueltas = g.Where(s => s.Estado == "Resuelto" && s.FechaResolucion.HasValue).ToList();
                        double prom = resueltas.Any()
                            ? resueltas.Average(s => (s.FechaResolucion.Value - s.FechaRegistro).TotalHours)
                            : 0;
                        return new DtoRendimientoTecnico
                        {
                            Tecnico = (g.Key?.Nombre ?? "") + " " + (g.Key?.Apellido ?? ""),
                            Especialidad = g.Key?.Especialidad ?? "",
                            TotalAsignadas = g.Count(),
                            Resueltas = g.Count(s => s.Estado == "Resuelto"),
                            Pendientes = g.Count(s => s.Estado == "Pendiente"),
                            PromedioHorasResolucion = prom > 0 ? Math.Round(prom, 1) + " hrs" : "Sin datos"
                        };
                    })
                    .OrderByDescending(r => r.Resueltas).ToList();
            }
        }

        // ============================================================
        // REPORTE 3: Solicitudes Urgentes (Alta prioridad sin resolver)
        // ============================================================
        public List<DtoReporteSolicitud> Reporte3_Urgentes()
        {
            using (var ctx = new DeskIUContext())
            {
                return ctx.Solicitudes
                    .Include(s => s.Usuario)
                    .Include(s => s.Tecnico)
                    .Include(s => s.Categoria)
                     .Where(s => s.Prioridad == "Alta"
                              && s.Estado == "Pendiente")
                    .OrderBy(s => s.FechaRegistro)
                    .ToList()
                    .Select(s => new DtoReporteSolicitud
                    {
                        IdSolicitud = s.IdSolicitud,
                        Titulo = s.Titulo,
                        Estado = s.Estado,
                        Prioridad = s.Prioridad,
                        Categoria = s.Categoria?.Nombre ?? "",
                        TipoUsuario = s.Usuario?.TipoUsuario ?? "",
                        Usuario = (s.Usuario?.Nombre ?? "") + " " + (s.Usuario?.Apellido ?? ""),
                        Tecnico = (s.Tecnico?.Nombre ?? "") + " " + (s.Tecnico?.Apellido ?? ""),
                        Especialidad = s.Tecnico?.Especialidad ?? "",
                        FechaRegistro = s.FechaRegistro,
                        FechaResolucion = null,
                        HorasAtencion = (int)(DateTime.Now - s.FechaRegistro).TotalHours
                    }).ToList();
            }
        }

        // ============================================================
        // REPORTE 4: Solicitudes por Tipo de Usuario
        // ============================================================
        public List<DtoReporteSolicitud> Reporte4_PorTipoUsuario(string tipoUsuario)
        {
            using (var ctx = new DeskIUContext())
            {
                var q = ctx.Solicitudes
                    .Include(s => s.Usuario)
                    .Include(s => s.Tecnico)
                    .Include(s => s.Categoria)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(tipoUsuario) && tipoUsuario != "Todos")
                    q = q.Where(s => s.Usuario.TipoUsuario == tipoUsuario);

                return q.OrderByDescending(s => s.FechaRegistro).ToList()
                    .Select(s => new DtoReporteSolicitud
                    {
                        IdSolicitud = s.IdSolicitud,
                        Titulo = s.Titulo,
                        Estado = s.Estado,
                        Prioridad = s.Prioridad,
                        Categoria = s.Categoria?.Nombre ?? "",
                        TipoUsuario = s.Usuario?.TipoUsuario ?? "",
                        Usuario = (s.Usuario?.Nombre ?? "") + " " + (s.Usuario?.Apellido ?? ""),
                        Tecnico = (s.Tecnico?.Nombre ?? "") + " " + (s.Tecnico?.Apellido ?? ""),
                        Especialidad = s.Tecnico?.Especialidad ?? "",
                        FechaRegistro = s.FechaRegistro,
                        FechaResolucion = s.FechaResolucion,
                        HorasAtencion = (int)((s.FechaResolucion ?? DateTime.Now) - s.FechaRegistro).TotalHours
                    }).ToList();
            }
        }
        public List<DtoTecnico_Categoria> TecnicoDeUnaCategoria()
        {
            using (var ctx = new DeskIUContext())
            {
                List<DtoTecnico_Categoria> lista = new List<DtoTecnico_Categoria>();
                List<Tecnico> tecnicos = ctx.Tecnicos.Where( t=> t.Activo).ToList();
                    foreach (Tecnico t in tecnicos)
                    {
                        if (t.Especialidad == "Hardware")
                        {
                            DtoTecnico_Categoria dto = new DtoTecnico_Categoria();
                            dto.Nombre = t.Nombre;
                            dto.Categoria = "Hardware";
                            lista.Add(dto);
                        }
                    }
                    return lista;
            }

        }
    }
}
