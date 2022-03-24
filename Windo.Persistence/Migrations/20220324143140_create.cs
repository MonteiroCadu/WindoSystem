using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Windo.Persistence.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PESSOA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_completo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    telefone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    data_nascimento = table.Column<DateTime>(type: "date", nullable: true),
                    documento = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PLATAFORMA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    descricao = table.Column<string>(type: "varchar(600)", unicode: false, maxLength: 600, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLATAFORMA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ROBO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    descricacao = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    qtd_lote = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROBO", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TEMPO_VENCIMENTO_LICENCA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    descricao = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    numero_dias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEMPO_VENCIMENTO_LICENCA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TIPO_HISTORICO_LICENCA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    descricao = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_HISTORICO_LICENCA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LICENCA_CLIENTE",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pessoa = table.Column<int>(type: "int", nullable: false),
                    plataforma = table.Column<int>(type: "int", nullable: false),
                    conta_corretora = table.Column<int>(type: "int", nullable: false),
                    data_abertura = table.Column<DateTime>(type: "date", nullable: false),
                    data_vencimento = table.Column<DateTime>(type: "date", nullable: false),
                    ativa = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LICENCA_CLIENTE", x => x.id);
                    table.ForeignKey(
                        name: "FK__LICENCA__pessoa__17036CC0",
                        column: x => x.pessoa,
                        principalTable: "PESSOA",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__LICENCA__platafo__17F790F9",
                        column: x => x.plataforma,
                        principalTable: "PLATAFORMA",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "licencas",
                columns: table => new
                {
                    conta_corretora = table.Column<int>(type: "int", nullable: false),
                    broker_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    cliente_nome = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    setup_nome = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: false),
                    data_abertura = table.Column<DateTime>(type: "datetime", nullable: false),
                    data_vencimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    ativa = table.Column<byte>(type: "tinyint", nullable: false),
                    lote = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plataforma = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__licencas__plataf__1332DBDC",
                        column: x => x.plataforma,
                        principalTable: "PLATAFORMA",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "PLATAFORMA_ROBO",
                columns: table => new
                {
                    plataforma = table.Column<int>(type: "int", nullable: false),
                    robo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plataforma_id", x => new { x.plataforma, x.robo });
                    table.ForeignKey(
                        name: "FK__PLATAFORM__plata__2739D489",
                        column: x => x.plataforma,
                        principalTable: "PLATAFORMA",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__PLATAFORMA__robo__282DF8C2",
                        column: x => x.robo,
                        principalTable: "ROBO",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "PLANO_VENDAS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    descricao = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    plataforma = table.Column<int>(type: "int", nullable: false),
                    validade_licenca = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLANO_VENDAS", x => x.id);
                    table.ForeignKey(
                        name: "FK__PLANO_VEN__plata__2EDAF651",
                        column: x => x.plataforma,
                        principalTable: "PLATAFORMA",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__PLANO_VEN__valid__2FCF1A8A",
                        column: x => x.validade_licenca,
                        principalTable: "TEMPO_VENCIMENTO_LICENCA",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "HISTORICO_LICENCA",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<int>(type: "int", nullable: true),
                    valor = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HISTORICO_LICENCA", x => x.id);
                    table.ForeignKey(
                        name: "FK__HISTORICO___tipo__2180FB33",
                        column: x => x.tipo,
                        principalTable: "TIPO_HISTORICO_LICENCA",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HISTORICO_LICENCA_tipo",
                table: "HISTORICO_LICENCA",
                column: "tipo");

            migrationBuilder.CreateIndex(
                name: "IX_LICENCA_CLIENTE_plataforma",
                table: "LICENCA_CLIENTE",
                column: "plataforma");

            migrationBuilder.CreateIndex(
                name: "UN_plataforma_pessoa",
                table: "LICENCA_CLIENTE",
                columns: new[] { "pessoa", "plataforma" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_licencas_plataforma",
                table: "licencas",
                column: "plataforma");

            migrationBuilder.CreateIndex(
                name: "UQ__PESSOA__AB6E6164FC0FC162",
                table: "PESSOA",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_Documento",
                table: "PESSOA",
                column: "documento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PLANO_VENDAS_plataforma",
                table: "PLANO_VENDAS",
                column: "plataforma");

            migrationBuilder.CreateIndex(
                name: "IX_PLANO_VENDAS_validade_licenca",
                table: "PLANO_VENDAS",
                column: "validade_licenca");

            migrationBuilder.CreateIndex(
                name: "UQ__PLANO_VE__6F71C0DCCF17556E",
                table: "PLANO_VENDAS",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__PLATAFOR__6F71C0DCAB890DF6",
                table: "PLATAFORMA",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PLATAFORMA_ROBO_robo",
                table: "PLATAFORMA_ROBO",
                column: "robo");

            migrationBuilder.CreateIndex(
                name: "UQ__ROBO__6F71C0DC683AA2BA",
                table: "ROBO",
                column: "nome",
                unique: true,
                filter: "[nome] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__TEMPO_VE__6F71C0DC17A8FE7E",
                table: "TEMPO_VENCIMENTO_LICENCA",
                column: "nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__TIPO_HIS__6F71C0DCFEA9A500",
                table: "TIPO_HISTORICO_LICENCA",
                column: "nome",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "HISTORICO_LICENCA");

            migrationBuilder.DropTable(
                name: "LICENCA_CLIENTE");

            migrationBuilder.DropTable(
                name: "licencas");

            migrationBuilder.DropTable(
                name: "PLANO_VENDAS");

            migrationBuilder.DropTable(
                name: "PLATAFORMA_ROBO");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TIPO_HISTORICO_LICENCA");

            migrationBuilder.DropTable(
                name: "PESSOA");

            migrationBuilder.DropTable(
                name: "TEMPO_VENCIMENTO_LICENCA");

            migrationBuilder.DropTable(
                name: "PLATAFORMA");

            migrationBuilder.DropTable(
                name: "ROBO");
        }
    }
}
