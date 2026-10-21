using System;

namespace DeskIU.Datos.Entidades
{
    public class Tecnico
    {
        public int IdTecnico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Especialidad { get; set; }
        public string Disponibilidad { get; set; }
        public DateTime? FechaDisponibilidad { get; set; }
        public bool Activo { get; set; }
        // Auditoria
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string CreadoPor { get; set; }
        public string ModificadoPor { get; set; }

        public override string ToString() => Nombre + " " + Apellido;
    }
}
