using System;

namespace DeskIU.Datos.Entidades
{
    public class Seguimiento
    {
        public int IdSeguimiento { get; set; }
        public int IdSolicitud { get; set; }
        public int IdTecnico { get; set; }
        public string EstadoAnterior { get; set; }
        public string EstadoNuevo { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaCambio { get; set; }
        public string CreadoPor { get; set; }
        // Navegacion EF
        public virtual Solicitud Solicitud { get; set; }
        public virtual Tecnico Tecnico { get; set; }
    }
}
