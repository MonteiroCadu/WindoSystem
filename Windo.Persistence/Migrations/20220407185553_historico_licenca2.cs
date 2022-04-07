using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Windo.Persistence.Migrations
{
    public partial class historico_licenca2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LicencaClienteId",
                table: "HISTORICO_LICENCA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HISTORICO_LICENCA_LicencaClienteId",
                table: "HISTORICO_LICENCA",
                column: "LicencaClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_HISTORICO_LICENCA_LICENCA_CLIENTE_LicencaClienteId",
                table: "HISTORICO_LICENCA",
                column: "LicencaClienteId",
                principalTable: "LICENCA_CLIENTE",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HISTORICO_LICENCA_LICENCA_CLIENTE_LicencaClienteId",
                table: "HISTORICO_LICENCA");

            migrationBuilder.DropIndex(
                name: "IX_HISTORICO_LICENCA_LicencaClienteId",
                table: "HISTORICO_LICENCA");

            migrationBuilder.DropColumn(
                name: "LicencaClienteId",
                table: "HISTORICO_LICENCA");
        }
    }
}
