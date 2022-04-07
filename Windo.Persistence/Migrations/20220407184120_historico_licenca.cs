using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Windo.Persistence.Migrations
{
    public partial class historico_licenca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LicencaClienteNavigationId",
                table: "HISTORICO_LICENCA",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LicencaID",
                table: "HISTORICO_LICENCA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HISTORICO_LICENCA_LicencaClienteNavigationId",
                table: "HISTORICO_LICENCA",
                column: "LicencaClienteNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_HISTORICO_LICENCA_LICENCA_CLIENTE_LicencaClienteNavigationId",
                table: "HISTORICO_LICENCA",
                column: "LicencaClienteNavigationId",
                principalTable: "LICENCA_CLIENTE",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HISTORICO_LICENCA_LICENCA_CLIENTE_LicencaClienteNavigationId",
                table: "HISTORICO_LICENCA");

            migrationBuilder.DropIndex(
                name: "IX_HISTORICO_LICENCA_LicencaClienteNavigationId",
                table: "HISTORICO_LICENCA");

            migrationBuilder.DropColumn(
                name: "LicencaClienteNavigationId",
                table: "HISTORICO_LICENCA");

            migrationBuilder.DropColumn(
                name: "LicencaID",
                table: "HISTORICO_LICENCA");
        }
    }
}
