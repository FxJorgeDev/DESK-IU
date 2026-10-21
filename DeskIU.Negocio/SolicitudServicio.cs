using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DeskIU.Datos.Contexto;
using DeskIU.Datos.Entidades;

namespace DeskIU.Negocio
{
    public class SolicitudServicio
    {
        TecnicoServicio _svcTec = new TecnicoServicio();

        public List<Solicitud> ListarTodas()
        {
            using (var ctx = new DeskIUContext())
                return ctx.Solicitudes
                    .Include(s => s.Usuario)
                    .Include(s => s.Tecnico)
                    .Include(s => s.Categoria)
                    .ToList();
        }

        public void Registrar(Solicitud s, string creadoPor)
        {
            using (var ctx = new DeskIUContext())
            {
                if (ctx.Solicitudes.Any(x => x.IdTecnico == s.IdTecnico && x.Estado == "Pendiente"))
                    throw new Exception("El tecnico ya tiene una solicitud pendiente. Resuelvala primero.");
                s.Estado = "Pendiente";
                s.FechaCreacion = DateTime.Now;
                s.FechaRegistro = DateTime.Now;
                s.CreadoPor = creadoPor;
                ctx.Solicitudes.Add(s);
                ctx.SaveChanges();
                _svcTec.CambiarDisponibilidad(s.IdTecnico, "Ocupado", creadoPor);
            }
        }

        public void Actualizar(Solicitud s, string modificadoPor)
        {
            using (var ctx = new DeskIUContext())
            {
                var e = ctx.Solicitudes.Find(s.IdSolicitud);
                string estadoAnterior = e.Estado;
                int idTecnico = e.IdTecnico;

                if (s.IdUsuario > 0) e.IdUsuario = s.IdUsuario;
                if (s.IdTecnico > 0) e.IdTecnico = s.IdTecnico;
                if (s.IdCategoria > 0) e.IdCategoria = s.IdCategoria;
                e.Titulo = s.Titulo;
                e.Descripcion = s.Descripcion;
                e.Estado = s.Estado;
                e.Prioridad = s.Prioridad;
                e.Observacion = s.Observacion;
                e.FechaModificacion = DateTime.Now;
                e.ModificadoPor = modificadoPor;

                if (s.Estado == "Resuelto")
                    e.FechaResolucion = DateTime.Now;

                if (estadoAnterior != s.Estado)
                {
                    ctx.Seguimientos.Add(new Seguimiento
                    {
                        IdSolicitud = s.IdSolicitud,
                        IdTecnico = idTecnico,
                        EstadoAnterior = estadoAnterior,
                        EstadoNuevo = s.Estado,
                        Comentario = s.Observacion,
                        FechaCambio = DateTime.Now,
                        CreadoPor = modificadoPor
                    });
                }
                ctx.SaveChanges();

                if (s.Estado == "Resuelto")
                {
                    string nuevaDisp = ctx.Solicitudes.Any(x => x.IdTecnico == idTecnico && x.Estado == "Pendiente")
                        ? "Ocupado" : "Disponible";
                    _svcTec.CambiarDisponibilidad(idTecnico, nuevaDisp, modificadoPor);
                }
            }
        }

        public void Resolver(int idSolicitud, string observacion, string modificadoPor)
        {
            int idTecnico;
            using (var ctx = new DeskIUContext())
            {
                var e = ctx.Solicitudes.Find(idSolicitud);
                if (e == null) return;
                idTecnico = e.IdTecnico;
                string estadoAnterior = e.Estado;

                e.Estado = "Resuelto";
                e.FechaResolucion = DateTime.Now;
                e.Observacion = observacion;
                e.FechaModificacion = DateTime.Now;
                e.ModificadoPor = modificadoPor;

                ctx.Seguimientos.Add(new Seguimiento
                {
                    IdSolicitud = idSolicitud,
                    IdTecnico = idTecnico,
                    EstadoAnterior = estadoAnterior,
                    EstadoNuevo = "Resuelto",
                    Comentario = observacion,
                    FechaCambio = DateTime.Now,
                    CreadoPor = modificadoPor
                });

                ctx.SaveChanges();

                string nuevaDisp = ctx.Solicitudes.Any(s => s.IdTecnico == idTecnico && s.Estado == "Pendiente")
                    ? "Ocupado" : "Disponible";
                _svcTec.CambiarDisponibilidad(idTecnico, nuevaDisp, modificadoPor);
            }
        }

        public List<Solicitud> ListarPorTecnico(int idTecnico)
        {
            using (var ctx = new DeskIUContext())
                return ctx.Solicitudes
                    .Include(s => s.Usuario)
                    .Include(s => s.Tecnico)
                    .Include(s => s.Categoria)
                    .Where(s => s.IdTecnico == idTecnico && s.Estado == "Pendiente")
                    .ToList();
        }

        public void Eliminar(int id)
        {
            using (var ctx = new DeskIUContext())
            {
                var e = ctx.Solicitudes.Find(id);
                if (e == null) return;
                if (ctx.Seguimientos.Any(s => s.IdSolicitud == id))
                    throw new Exception("No se puede eliminar la solicitud porque tiene seguimientos registrados.");
                ctx.Solicitudes.Remove(e);
                ctx.SaveChanges();
            }
        }
    }
}
