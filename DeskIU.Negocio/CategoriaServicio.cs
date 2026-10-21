using System;
using System.Collections.Generic;
using System.Linq;
using DeskIU.Datos.Contexto;
using DeskIU.Datos.Entidades;

namespace DeskIU.Negocio
{
    public class CategoriaServicio
    {
        public List<Categoria> ListarTodas()
        {
            using (var ctx = new DeskIUContext())
                return ctx.Categorias.Where(c => c.Activo).ToList();
        }

        public void Registrar(Categoria c, string creadoPor)
        {
            using (var ctx = new DeskIUContext())
            {
                c.Activo = true;
                c.FechaCreacion = DateTime.Now;
                c.CreadoPor = creadoPor;
                ctx.Categorias.Add(c);
                ctx.SaveChanges();
            }
        }

        public void Actualizar(Categoria c, string modificadoPor)
        {
            using (var ctx = new DeskIUContext())
            {
                var e = ctx.Categorias.Find(c.IdCategoria);
                e.Nombre = c.Nombre;
                e.Descripcion = c.Descripcion;
                e.FechaModificacion = DateTime.Now;
                e.ModificadoPor = modificadoPor;
                ctx.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var ctx = new DeskIUContext())
            {
                var e = ctx.Categorias.Find(id);
                if (e == null) return;
                if (ctx.Solicitudes.Any(s => s.IdCategoria == id))
                    throw new Exception("No se puede eliminar la categoria porque tiene solicitudes asignadas.");
                ctx.Categorias.Remove(e);
                ctx.SaveChanges();
            }
        }
    }
}
