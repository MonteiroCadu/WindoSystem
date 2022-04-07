﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Windo.Persistence;

#nullable disable

namespace Windo.Persistence.Migrations
{
    [DbContext(typeof(windo_baseContext))]
    partial class windo_baseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PlataformaRobo", b =>
                {
                    b.Property<int>("Plataforma")
                        .HasColumnType("int")
                        .HasColumnName("plataforma");

                    b.Property<int>("Robo")
                        .HasColumnType("int")
                        .HasColumnName("robo");

                    b.HasKey("Plataforma", "Robo")
                        .HasName("PK_plataforma_id");

                    b.HasIndex("Robo");

                    b.ToTable("PLATAFORMA_ROBO", (string)null);
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.Corretora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Corretoras");
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.HistoricoLicenca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LicencaClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("tipo");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("LicencaClienteId");

                    b.HasIndex("Tipo");

                    b.ToTable("HISTORICO_LICENCA", (string)null);
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.Licenca", b =>
                {
                    b.Property<byte>("Ativa")
                        .HasColumnType("tinyint")
                        .HasColumnName("ativa");

                    b.Property<string>("BrokerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("broker_name");

                    b.Property<string>("ClienteNome")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("cliente_nome");

                    b.Property<int>("ContaCorretora")
                        .HasColumnType("int")
                        .HasColumnName("conta_corretora");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime")
                        .HasColumnName("data_abertura");

                    b.Property<DateTime?>("DataVencimento")
                        .HasColumnType("datetime")
                        .HasColumnName("data_vencimento");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Lote")
                        .HasColumnType("int")
                        .HasColumnName("lote");

                    b.Property<int>("Plataforma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("plataforma")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("SetupNome")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("setup_nome");

                    b.HasIndex("Plataforma");

                    b.ToTable("licencas", (string)null);
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.LicencaCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("Ativa")
                        .HasColumnType("tinyint")
                        .HasColumnName("ativa");

                    b.Property<int>("ContaCorretora")
                        .HasColumnType("int")
                        .HasColumnName("conta_corretora");

                    b.Property<int>("CorretoraId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("date")
                        .HasColumnName("data_abertura");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("date")
                        .HasColumnName("data_vencimento");

                    b.Property<int>("Pessoa")
                        .HasColumnType("int")
                        .HasColumnName("pessoa");

                    b.Property<int>("Plataforma")
                        .HasColumnType("int")
                        .HasColumnName("plataforma");

                    b.HasKey("Id");

                    b.HasIndex("CorretoraId");

                    b.HasIndex("Plataforma");

                    b.HasIndex(new[] { "Pessoa", "Plataforma" }, "UN_plataforma_pessoa")
                        .IsUnique();

                    b.ToTable("LICENCA_CLIENTE", (string)null);
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("documento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome_completo");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("telefone");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Documento" }, "UQ_Documento")
                        .IsUnique();

                    b.HasIndex(new[] { "Email" }, "UQ__PESSOA__AB6E6164FC0FC162")
                        .IsUnique();

                    b.ToTable("PESSOA", (string)null);
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.PlanoVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<int>("Plataforma")
                        .HasColumnType("int")
                        .HasColumnName("plataforma");

                    b.Property<int>("ValidadeLicenca")
                        .HasColumnType("int")
                        .HasColumnName("validade_licenca");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.HasIndex("Plataforma");

                    b.HasIndex("ValidadeLicenca");

                    b.HasIndex(new[] { "Nome" }, "UQ__PLANO_VE__6F71C0DCCF17556E")
                        .IsUnique();

                    b.ToTable("PLANO_VENDAS", (string)null);
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.Plataforma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Ativa")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .HasMaxLength(600)
                        .IsUnicode(false)
                        .HasColumnType("varchar(600)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Nome" }, "UQ__PLATAFOR__6F71C0DCAB890DF6")
                        .IsUnique();

                    b.ToTable("PLATAFORMA", (string)null);
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.Robo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricacao")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("descricacao");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<int>("QtdLote")
                        .HasColumnType("int")
                        .HasColumnName("qtd_lote");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Nome" }, "UQ__ROBO__6F71C0DC683AA2BA")
                        .IsUnique()
                        .HasFilter("[nome] IS NOT NULL");

                    b.ToTable("ROBO", (string)null);
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.TempoVencimentoLicenca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.Property<int>("NumeroDias")
                        .HasColumnType("int")
                        .HasColumnName("numero_dias");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Nome" }, "UQ__TEMPO_VE__6F71C0DC17A8FE7E")
                        .IsUnique();

                    b.ToTable("TEMPO_VENCIMENTO_LICENCA", (string)null);
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.TipoHistoricoLicenca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Nome" }, "UQ__TIPO_HIS__6F71C0DCFEA9A500")
                        .IsUnique();

                    b.ToTable("TIPO_HISTORICO_LICENCA", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlataformaRobo", b =>
                {
                    b.HasOne("Windo.Persistence.Dominio.Plataforma", null)
                        .WithMany()
                        .HasForeignKey("Plataforma")
                        .IsRequired()
                        .HasConstraintName("FK__PLATAFORM__plata__2739D489");

                    b.HasOne("Windo.Persistence.Dominio.Robo", null)
                        .WithMany()
                        .HasForeignKey("Robo")
                        .IsRequired()
                        .HasConstraintName("FK__PLATAFORMA__robo__282DF8C2");
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.HistoricoLicenca", b =>
                {
                    b.HasOne("Windo.Persistence.Dominio.LicencaCliente", "LicencaClienteNavigation")
                        .WithMany()
                        .HasForeignKey("LicencaClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Windo.Persistence.Dominio.TipoHistoricoLicenca", "TipoNavigation")
                        .WithMany("HistoricoLicencas")
                        .HasForeignKey("Tipo")
                        .HasConstraintName("FK__HISTORICO___tipo__2180FB33");

                    b.Navigation("LicencaClienteNavigation");

                    b.Navigation("TipoNavigation");
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.Licenca", b =>
                {
                    b.HasOne("Windo.Persistence.Dominio.Plataforma", "PlataformaNavigation")
                        .WithMany()
                        .HasForeignKey("Plataforma")
                        .IsRequired()
                        .HasConstraintName("FK__licencas__plataf__1332DBDC");

                    b.Navigation("PlataformaNavigation");
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.LicencaCliente", b =>
                {
                    b.HasOne("Windo.Persistence.Dominio.Corretora", "CorretoraNavigation")
                        .WithMany("LicencaClientes")
                        .HasForeignKey("CorretoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Windo.Persistence.Dominio.Pessoa", "PessoaNavigation")
                        .WithMany("LicencaClientes")
                        .HasForeignKey("Pessoa")
                        .IsRequired()
                        .HasConstraintName("FK__LICENCA__pessoa__17036CC0");

                    b.HasOne("Windo.Persistence.Dominio.Plataforma", "PlataformaNavigation")
                        .WithMany("LicencaClientes")
                        .HasForeignKey("Plataforma")
                        .IsRequired()
                        .HasConstraintName("FK__LICENCA__platafo__17F790F9");

                    b.Navigation("CorretoraNavigation");

                    b.Navigation("PessoaNavigation");

                    b.Navigation("PlataformaNavigation");
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.PlanoVenda", b =>
                {
                    b.HasOne("Windo.Persistence.Dominio.Plataforma", "PlataformaNavigation")
                        .WithMany("PlanoVenda")
                        .HasForeignKey("Plataforma")
                        .IsRequired()
                        .HasConstraintName("FK__PLANO_VEN__plata__2EDAF651");

                    b.HasOne("Windo.Persistence.Dominio.TempoVencimentoLicenca", "ValidadeLicencaNavigation")
                        .WithMany("PlanoVenda")
                        .HasForeignKey("ValidadeLicenca")
                        .IsRequired()
                        .HasConstraintName("FK__PLANO_VEN__valid__2FCF1A8A");

                    b.Navigation("PlataformaNavigation");

                    b.Navigation("ValidadeLicencaNavigation");
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.Corretora", b =>
                {
                    b.Navigation("LicencaClientes");
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.Pessoa", b =>
                {
                    b.Navigation("LicencaClientes");
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.Plataforma", b =>
                {
                    b.Navigation("LicencaClientes");

                    b.Navigation("PlanoVenda");
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.TempoVencimentoLicenca", b =>
                {
                    b.Navigation("PlanoVenda");
                });

            modelBuilder.Entity("Windo.Persistence.Dominio.TipoHistoricoLicenca", b =>
                {
                    b.Navigation("HistoricoLicencas");
                });
#pragma warning restore 612, 618
        }
    }
}
