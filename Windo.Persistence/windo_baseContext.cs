
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Windo.Persistence.Dominio;

namespace Windo.Persistence
{
    public partial class windo_baseContext : IdentityDbContext
    {
        public windo_baseContext()
        {
        }

        public windo_baseContext(DbContextOptions<windo_baseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HistoricoLicenca> HistoricoLicencas { get; set; } = null!;
        public virtual DbSet<Licenca> Licencas { get; set; } = null!;
        public virtual DbSet<LicencaCliente> LicencaClientes { get; set; } = null!;
        public virtual DbSet<Pessoa> Pessoas { get; set; } = null!;
        public virtual DbSet<PlanoVenda> PlanoVendas { get; set; } = null!;
        public virtual DbSet<Plataforma> Plataformas { get; set; } = null!;
        public virtual DbSet<Robo> Robos { get; set; } = null!;
        public virtual DbSet<TempoVencimentoLicenca> TempoVencimentoLicencas { get; set; } = null!;
        public virtual DbSet<TipoHistoricoLicenca> TipoHistoricoLicencas { get; set; } = null!;
        public virtual DbSet<Corretora> Corretoras { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            
            modelBuilder.Entity<HistoricoLicenca>(entity =>
            {
                entity.ToTable("HISTORICO_LICENCA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("valor");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.HistoricoLicencas)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("FK__HISTORICO___tipo__2180FB33");
            });

            modelBuilder.Entity<Licenca>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("licencas");

                entity.Property(e => e.Ativa).HasColumnName("ativa");

                entity.Property(e => e.BrokerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("broker_name");

                entity.Property(e => e.ClienteNome)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("cliente_nome");

                entity.Property(e => e.ContaCorretora).HasColumnName("conta_corretora");

                entity.Property(e => e.DataAbertura)
                    .HasColumnType("datetime")
                    .HasColumnName("data_abertura");

                entity.Property(e => e.DataVencimento)
                    .HasColumnType("datetime")
                    .HasColumnName("data_vencimento");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lote).HasColumnName("lote");

                entity.Property(e => e.Plataforma)
                    .HasColumnName("plataforma")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SetupNome)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("setup_nome");

                entity.HasOne(d => d.PlataformaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Plataforma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__licencas__plataf__1332DBDC");
            });

            modelBuilder.Entity<LicencaCliente>(entity =>
            {
                entity.ToTable("LICENCA_CLIENTE");

                entity.HasIndex(e => new { e.Pessoa, e.Plataforma }, "UN_plataforma_pessoa")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ativa).HasColumnName("ativa");

                entity.Property(e => e.ContaCorretora).HasColumnName("conta_corretora");

                entity.Property(e => e.DataAbertura)
                    .HasColumnType("date")
                    .HasColumnName("data_abertura");

                entity.Property(e => e.DataVencimento)
                    .HasColumnType("date")
                    .HasColumnName("data_vencimento");

                entity.Property(e => e.Pessoa).HasColumnName("pessoa");

                entity.Property(e => e.Plataforma).HasColumnName("plataforma");

                entity.HasOne(d => d.PessoaNavigation)
                    .WithMany(p => p.LicencaClientes)
                    .HasForeignKey(d => d.Pessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LICENCA__pessoa__17036CC0");

                entity.HasOne(d => d.PlataformaNavigation)
                    .WithMany(p => p.LicencaClientes)
                    .HasForeignKey(d => d.Plataforma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LICENCA__platafo__17F790F9");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.ToTable("PESSOA");

                entity.HasIndex(e => e.Documento, "UQ_Documento")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__PESSOA__AB6E6164FC0FC162")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("data_nascimento");

                entity.Property(e => e.Documento)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("documento");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.NomeCompleto)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nome_completo");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<PlanoVenda>(entity =>
            {
                entity.ToTable("PLANO_VENDAS");

                entity.HasIndex(e => e.Nome, "UQ__PLANO_VE__6F71C0DCCF17556E")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Plataforma).HasColumnName("plataforma");

                entity.Property(e => e.ValidadeLicenca).HasColumnName("validade_licenca");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("valor");

                entity.HasOne(d => d.PlataformaNavigation)
                    .WithMany(p => p.PlanoVenda)
                    .HasForeignKey(d => d.Plataforma)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PLANO_VEN__plata__2EDAF651");

                entity.HasOne(d => d.ValidadeLicencaNavigation)
                    .WithMany(p => p.PlanoVenda)
                    .HasForeignKey(d => d.ValidadeLicenca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PLANO_VEN__valid__2FCF1A8A");
            });

            modelBuilder.Entity<Plataforma>(entity =>
            {
                entity.ToTable("PLATAFORMA");

                entity.HasIndex(e => e.Nome, "UQ__PLATAFOR__6F71C0DCAB890DF6")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.HasMany(d => d.Robos)
                    .WithMany(p => p.Plataformas)
                    .UsingEntity<Dictionary<string, object>>(
                        "PlataformaRobo",
                        l => l.HasOne<Robo>().WithMany().HasForeignKey("Robo").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__PLATAFORMA__robo__282DF8C2"),
                        r => r.HasOne<Plataforma>().WithMany().HasForeignKey("Plataforma").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__PLATAFORM__plata__2739D489"),
                        j =>
                        {
                            j.HasKey("Plataforma", "Robo").HasName("PK_plataforma_id");

                            j.ToTable("PLATAFORMA_ROBO");

                            j.IndexerProperty<int>("Plataforma").HasColumnName("plataforma");

                            j.IndexerProperty<int>("Robo").HasColumnName("robo");
                        });
            });

            modelBuilder.Entity<Robo>(entity =>
            {
                entity.ToTable("ROBO");

                entity.HasIndex(e => e.Nome, "UQ__ROBO__6F71C0DC683AA2BA")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricacao)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descricacao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.QtdLote).HasColumnName("qtd_lote");
            });

            modelBuilder.Entity<TempoVencimentoLicenca>(entity =>
            {
                entity.ToTable("TEMPO_VENCIMENTO_LICENCA");

                entity.HasIndex(e => e.Nome, "UQ__TEMPO_VE__6F71C0DC17A8FE7E")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.NumeroDias).HasColumnName("numero_dias");
            });

            modelBuilder.Entity<TipoHistoricoLicenca>(entity =>
            {
                entity.ToTable("TIPO_HISTORICO_LICENCA");

                entity.HasIndex(e => e.Nome, "UQ__TIPO_HIS__6F71C0DCFEA9A500")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            base.OnModelCreating(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
