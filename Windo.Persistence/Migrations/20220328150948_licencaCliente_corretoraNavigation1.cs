using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Windo.Persistence.Migrations
{
    public partial class licencaCliente_corretoraNavigation1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Corretora",
                table: "LICENCA_CLIENTE",
                newName: "CorretoraId");

            migrationBuilder.CreateIndex(
                name: "IX_LICENCA_CLIENTE_CorretoraId",
                table: "LICENCA_CLIENTE",
                column: "CorretoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_LICENCA_CLIENTE_Corretoras_CorretoraId",
                table: "LICENCA_CLIENTE",
                column: "CorretoraId",
                principalTable: "Corretoras",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LICENCA_CLIENTE_Corretoras_CorretoraId",
                table: "LICENCA_CLIENTE");

            migrationBuilder.DropIndex(
                name: "IX_LICENCA_CLIENTE_CorretoraId",
                table: "LICENCA_CLIENTE");

            migrationBuilder.RenameColumn(
                name: "CorretoraId",
                table: "LICENCA_CLIENTE",
                newName: "Corretora");
        }
    }
}
