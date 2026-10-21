using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DeskIU.Datos.Contexto;
using DeskIU.Datos.Entidades;

namespace DeskIU.Negocio
{
    public class UsuarioServicio
    {
        public List<Usuario> ListarTodos()
        {
            using (var ctx = new DeskIUContext())
                return ctx.Usuarios.Where(u => u.Activo).ToList();
        }

        public void Registrar(Usuario u, string creadoPor)
        {
            if (!EsCorreoValido(u.Correo))
                throw new Exception("Correo invalido.");
            if (ExisteCorreo(u.Correo))
                throw new Exception("Ya existe un usuario con ese correo.");

            using (var ctx = new DeskIUContext())
            {
                u.Activo = true;
                u.FechaCreacion = DateTime.Now;
                u.CreadoPor = creadoPor;
                ctx.Usuarios.Add(u);
                ctx.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var ctx = new DeskIUContext())
            {
                var e = ctx.Usuarios.Find(id);
                if (e == null) return;
                if (ctx.Solicitudes.Any(s => s.IdUsuario == id))
                    throw new Exception("No se puede eliminar el usuario porque tiene solicitudes asignadas.");
                ctx.Usuarios.Remove(e);
                ctx.SaveChanges();
            }
        }

        public void Actualizar(Usuario u, string modificadoPor)
        {
            using (var ctx = new DeskIUContext())
            {
                var e = ctx.Usuarios.Find(u.IdUsuario);
                e.Nombre = u.Nombre;
                e.Apellido = u.Apellido;
                e.Correo = u.Correo;
                e.Celular = u.Celular;
                e.TipoUsuario = u.TipoUsuario;
                e.FechaModificacion = DateTime.Now;
                e.ModificadoPor = modificadoPor;
                ctx.SaveChanges();
            }
        }

        public bool ExisteCorreo(string correo)
        {
            using (var ctx = new DeskIUContext())
                return ctx.Usuarios.Any(u => u.Correo == correo && u.Activo);
        }

        public static bool EsSoloLetras(string t) =>
            !string.IsNullOrWhiteSpace(t) &&
            Regex.IsMatch(t, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$");

        public static bool EsCorreoValido(string c) =>
            !string.IsNullOrWhiteSpace(c) &&
            Regex.IsMatch(c, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        public static bool EsCelularValido(string c) =>
            !string.IsNullOrWhiteSpace(c) &&
            Regex.IsMatch(c, @"^[0-9]{9}$");
    }
}
