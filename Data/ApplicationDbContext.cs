using Microsoft.EntityFrameworkCore;
using ScoutingApi.Models;

namespace ScoutingApi.Data
{
    public class ScoutingDbContext(DbContextOptions<ScoutingDbContext> options) : DbContext(options)
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Clube> Clubes { get; set; }
        public DbSet<HistoricoClube> HistoricoClubes { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<Lesao> Lesoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Enums como string
            modelBuilder
                .Entity<Usuario>()
                .Property(u => u.Perfil)
                .HasConversion<string>();

            modelBuilder
                .Entity<Lesao>()
                .Property(l => l.TipoLesao)
                .HasConversion<string>();

            modelBuilder
                .Entity<Lesao>()
                .Property(l => l.LocalCorpo)
                .HasConversion<string>();
        }
    }
}