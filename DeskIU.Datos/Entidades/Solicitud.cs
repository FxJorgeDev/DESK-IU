using System;

namespace DeskIU.Datos.Entidades
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public int IdUsuario { get; set; }
        public int IdTecnico { get; set; }
        public int IdCategoria { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public string Observacion { get; set; }
        // Auditoria
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CreadoPor { get; set; }
        public string ModificadoPor { get; set; }
        // Navegacion EF
        public virtual Usuario Usuario { get; set; }
        public virtual Tecnico Tecnico { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
