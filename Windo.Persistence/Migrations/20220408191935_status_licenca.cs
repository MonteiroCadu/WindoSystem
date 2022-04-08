using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Windo.Persistence.Migrations
{
    public partial class status_licenca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ativa",
                table: "LICENCA_CLIENTE");

            migrationBuilder.AddColumn<int>(
                name: "StatusLicencaId",
                table: "LICENCA_CLIENTE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StatusLicenca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusLicenca", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LICENCA_CLIENTE_StatusLicencaId",
                table: "LICENCA_CLIENTE",
                column: "StatusLicencaId");

            migrationBuilder.AddForeignKey(
                name: "FK_LICENCA_CLIENTE_StatusLicenca_StatusLicencaId",
                table: "LICENCA_CLIENTE",
                column: "StatusLicencaId",
                principalTable: "StatusLicenca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LICENCA_CLIENTE_StatusLicenca_StatusLicencaId",
                table: "LICENCA_CLIENTE");

            migrationBuilder.DropTable(
                name: "StatusLicenca");

            migrationBuilder.DropIndex(
                name: "IX_LICENCA_CLIENTE_StatusLicencaId",
                table: "LICENCA_CLIENTE");

            migrationBuilder.DropColumn(
                name: "StatusLicencaId",
                table: "LICENCA_CLIENTE");

            migrationBuilder.AddColumn<byte>(
                name: "ativa",
                table: "LICENCA_CLIENTE",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
