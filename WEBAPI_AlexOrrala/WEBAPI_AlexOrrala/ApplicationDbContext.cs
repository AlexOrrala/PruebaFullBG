using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using WEBAPI_AlexOrrala.Models;

namespace WEBAPI_AlexOrrala
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Envio> Envios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarifas> Tarifas{ get; set; }
        public DbSet<Viaje> Viajes{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Envio>()
            .HasOne(e => e.Tarifa)
            .WithMany(t => t.Envios)
            .HasForeignKey(e => e.TarifaId);

            modelBuilder.Entity<Viaje>()
                .HasOne(v => v.envio)
                .WithMany(u => u.viajes)
                .HasForeignKey(u => u.EnvioId);

            modelBuilder.Entity<Viaje>()
                .HasOne(v => v.usuario)
                .WithMany(u => u.viajes)
                .HasForeignKey(u => u.UsuarioId);

        }
    }
}
