using System;
using System.Collections.Generic;
using System.Linq;
using DeskIU.Datos.Contexto;
using DeskIU.Datos.Entidades;

namespace DeskIU.Negocio
{
    public class TecnicoServicio
    {
        public List<Tecnico> ListarTodos()
        {
            using (var ctx = new DeskIUContext())
                return ctx.Tecnicos.Where(t => t.Activo).ToList();
        }

        public List<Tecnico> ListarDisponibles()
        {
            using (var ctx = new DeskIUContext())
                return ctx.Tecnicos
                    .Where(t => t.Activo && t.Disponibilidad == "Disponible")
                    .ToList();
        }

        public void Registrar(Tecnico t, string creadoPor)
        {
            using (var ctx = new DeskIUContext())
            {
                t.Activo = true;
                t.FechaCreacion = DateTime.Now;
                t.CreadoPor = creadoPor;
                ctx.Tecnicos.Add(t);
                ctx.SaveChanges();
            }
        }

        public void Actualizar(Tecnico t, string modificadoPor)
        {
            using (var ctx = new DeskIUContext())
            {
                var e = ctx.Tecnicos.Find(t.IdTecnico);
                e.Nombre = t.Nombre;
                e.Apellido = t.Apellido;
                e.Correo = t.Correo;
                e.Especialidad = t.Especialidad;
                e.Disponibilidad = t.Disponibilidad;
                e.FechaModificacion = DateTime.Now;
                e.ModificadoPor = modificadoPor;
                ctx.SaveChanges();
            }
        }

        public void CambiarDisponibilidad(int idTecnico, string disponibilidad, string modificadoPor)
        {
            using (var ctx = new DeskIUContext())
            {
                var e = ctx.Tecnicos.Find(idTecnico);
                if (e == null) return;
                e.Disponibilidad = disponibilidad;
                if (disponibilidad == "Disponible")
                    e.FechaDisponibilidad = DateTime.Now;
                e.FechaModificacion = DateTime.Now;
                e.ModificadoPor = modificadoPor;
                ctx.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var ctx = new DeskIUContext())
            {
                var e = ctx.Tecnicos.Find(id);
                if (e == null) return;
                if (ctx.Solicitudes.Any(s => s.IdTecnico == id))
                    throw new Exception("No se puede eliminar el tecnico porque tiene solicitudes asignadas.");
                if (ctx.Seguimientos.Any(s => s.IdTecnico == id))
                    throw new Exception("No se puede eliminar el tecnico porque tiene seguimientos registrados.");
                ctx.Tecnicos.Remove(e);
                ctx.SaveChanges();
            }
        }
    }
}
