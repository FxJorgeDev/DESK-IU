using System.Data.Entity;
using DeskIU.Datos.Entidades;

namespace DeskIU.Datos.Contexto
{
    public class DeskIUContext : DbContext
    {
        public DeskIUContext() : base("name=DeskIUConexion") { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<Seguimiento> Seguimientos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Tabla USUARIO
            modelBuilder.Entity<Usuario>().ToTable("USUARIO");
            modelBuilder.Entity<Usuario>().HasKey(u => u.IdUsuario);

            // Tabla TECNICO
            modelBuilder.Entity<Tecnico>().ToTable("TECNICO");
            modelBuilder.Entity<Tecnico>().HasKey(t => t.IdTecnico);

            // Tabla CATEGORIA
            modelBuilder.Entity<Categoria>().ToTable("CATEGORIA");
            modelBuilder.Entity<Categoria>().HasKey(c => c.IdCategoria);

            // Tabla SOLICITUD
            modelBuilder.Entity<Solicitud>().ToTable("SOLICITUD");
            modelBuilder.Entity<Solicitud>().HasKey(s => s.IdSolicitud);
            modelBuilder.Entity<Solicitud>()
                .HasRequired(s => s.Usuario)
                .WithMany().HasForeignKey(s => s.IdUsuario)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Solicitud>()
                .HasRequired(s => s.Tecnico)
                .WithMany().HasForeignKey(s => s.IdTecnico)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Solicitud>()
                .HasRequired(s => s.Categoria)
                .WithMany().HasForeignKey(s => s.IdCategoria)
                .WillCascadeOnDelete(false);

            // Tabla SEGUIMIENTO
            modelBuilder.Entity<Seguimiento>().ToTable("SEGUIMIENTO");
            modelBuilder.Entity<Seguimiento>().HasKey(s => s.IdSeguimiento);
            modelBuilder.Entity<Seguimiento>()
                .HasRequired(s => s.Solicitud)
                .WithMany().HasForeignKey(s => s.IdSolicitud)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Seguimiento>()
                .HasRequired(s => s.Tecnico)
                .WithMany().HasForeignKey(s => s.IdTecnico)
                .WillCascadeOnDelete(false);
        }
    }
}
