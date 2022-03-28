using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Windo.Persistence.Migrations
{
    public partial class licencaCliente_corretoraNavigation4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LICENCA_CLIENTE_Corretoras_CorretoraNavigationId",
                table: "LICENCA_CLIENTE");

            migrationBuilder.DropColumn(
                name: "Corretora",
                table: "LICENCA_CLIENTE");

            migrationBuilder.RenameColumn(
                name: "CorretoraNavigationId",
                table: "LICENCA_CLIENTE",
                newName: "CorretoraId");

            migrationBuilder.RenameIndex(
                name: "IX_LICENCA_CLIENTE_CorretoraNavigationId",
                table: "LICENCA_CLIENTE",
                newName: "IX_LICENCA_CLIENTE_CorretoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_LICENCA_CLIENTE_Corretoras_CorretoraId",
                table: "LICENCA_CLIENTE",
                column: "CorretoraId",
                principalTable: "Corretoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LICENCA_CLIENTE_Corretoras_CorretoraId",
                table: "LICENCA_CLIENTE");

            migrationBuilder.RenameColumn(
                name: "CorretoraId",
                table: "LICENCA_CLIENTE",
                newName: "CorretoraNavigationId");

            migrationBuilder.RenameIndex(
                name: "IX_LICENCA_CLIENTE_CorretoraId",
                table: "LICENCA_CLIENTE",
                newName: "IX_LICENCA_CLIENTE_CorretoraNavigationId");

            migrationBuilder.AddColumn<int>(
                name: "Corretora",
                table: "LICENCA_CLIENTE",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_LICENCA_CLIENTE_Corretoras_CorretoraNavigationId",
                table: "LICENCA_CLIENTE",
                column: "CorretoraNavigationId",
                principalTable: "Corretoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
