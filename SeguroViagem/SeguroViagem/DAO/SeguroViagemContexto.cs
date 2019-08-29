using Microsoft.EntityFrameworkCore;
using SeguroViagem.Models;


namespace SeguroViagem.DAO
{
    public class SeguroViagemContexto : DbContext
    {
        public virtual DbSet<Seguradora> Seguradoras { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Cotacao> Cotacoes { get; set; }
        public virtual DbSet<AcrescimoTipoViagem> AcrescimosTipoViagem { get; set; }
        public virtual DbSet<AcrescimoMeioTransporte> AcrescimosMeioTransporte { get; set; }
        public virtual DbSet<AcrescimoMotivoViagem> AcrescimosMotivoViagem { get; set; }
        public virtual DbSet<DadosViajante> DadosViajantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SeguroViagem;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento da chave estrangeira - Tabela cotações com Estados (criação qndo uso Migration)
            modelBuilder.Entity<Cotacao>()
                .HasOne(c => c.Origem)
                .WithMany(c => c.CotacaoOrigem)
                .HasForeignKey(c => c.OrigemId);
            modelBuilder.Entity<Cotacao>()
                .HasOne(c => c.Destino)
                .WithMany(c => c.CotacaoDestino)
                .HasForeignKey(c => c.DestinoId);

            // Mapeamento da chave estrangeira - Tabela Seguradora com AcrescimoViagens (criação qndo uso Migration)
            modelBuilder.Entity<AcrescimoTipoViagem>()
                .HasOne(c => c.Seguradora)
                .WithMany(c => c.AcrescimosViagens)
                .HasForeignKey(c => c.SegId);

            // Mapeamento da chave estrangeira - Tabela Seguradora com AcrescimoViagens (criação qndo uso Migration)
            modelBuilder.Entity<AcrescimoMeioTransporte>()
                .HasOne(c => c.Seguradora)
                .WithMany(c => c.AcrescimosTransportes)
                .HasForeignKey(c => c.SegId) ;

            // Mapeamento da chave estrangeira - Tabela Seguradora com AcrescimoViagens (criação qndo uso Migration)
            modelBuilder.Entity<AcrescimoMotivoViagem>()
                .HasOne(c => c.Seguradora)
                .WithMany(c => c.AcrescimosMotivos)
                .HasForeignKey(c => c.SegId);




            // Mapeamento da chave estrangeira - Tabela cotações com Estados (criação qndo uso Migration)
            modelBuilder.Entity<AcrescimoTipoViagem>()
                .HasOne(c => c.Seguradora)
                .WithMany(c => c.AcrescimosViagens)
                .HasForeignKey(c => c.SegId);
        }

    }

}
