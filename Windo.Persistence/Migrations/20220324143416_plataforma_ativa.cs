using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Windo.Persistence.Migrations
{
    public partial class plataforma_ativa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativa",
                table: "PLATAFORMA",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativa",
                table: "PLATAFORMA");
        }
    }
}
