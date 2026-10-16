using Microsoft.EntityFrameworkCore;
using SistemaGastosWeb.Models;

namespace SistemaGastosWeb.Data
{
    public class FinanceiroContext : DbContext
    {
        public FinanceiroContext(DbContextOptions<FinanceiroContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<GanhoDiarioModel> GanhoDiario { get; set; }
        public DbSet<GastoDiarioModel> GastoDiario { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsuarioModel>().ToTable("Usuario");
            modelBuilder.Entity<GanhoDiarioModel>().ToTable("GanhoDiario");
            modelBuilder.Entity<GastoDiarioModel>().ToTable("GastoDiario");


            modelBuilder.Entity<GanhoDiarioModel>()
                .HasOne(g => g.Usuario)
                .WithMany()
                .HasForeignKey(g => g.FKUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GastoDiarioModel>()
                .HasOne(g => g.Usuario)
                .WithMany()
                .HasForeignKey(g => g.FKUsuario)
                .OnDelete(DeleteBehavior.Restrict);

            Console.WriteLine("Teste");

        }

    }
}
