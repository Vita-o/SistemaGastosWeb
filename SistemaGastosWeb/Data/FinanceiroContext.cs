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
        public DbSet<MovimentacoesModel> Movimentacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsuarioModel>().ToTable("Usuario");
            modelBuilder.Entity<MovimentacoesModel>().ToTable("Movimentacoes");


            modelBuilder.Entity<MovimentacoesModel>()
                .HasOne(g => g.Usuario)
                .WithMany()
                .HasForeignKey(g => g.FKUsuario)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }

}