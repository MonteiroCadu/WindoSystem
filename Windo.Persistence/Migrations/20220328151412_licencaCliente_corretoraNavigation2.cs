using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Windo.Persistence.Migrations
{
    public partial class licencaCliente_corretoraNavigation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LICENCA_CLIENTE_Corretoras_CorretoraId",
                table: "LICENCA_CLIENTE");

            migrationBuilder.AlterColumn<int>(
                name: "CorretoraId",
                table: "LICENCA_CLIENTE",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: false);

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

            migrationBuilder.AlterColumn<int>(
                name: "CorretoraId",
                table: "LICENCA_CLIENTE",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_LICENCA_CLIENTE_Corretoras_CorretoraId",
                table: "LICENCA_CLIENTE",
                column: "CorretoraId",
                principalTable: "Corretoras",
                principalColumn: "Id");
        }
    }
}
