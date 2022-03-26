using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Windo.Persistence.Migrations
{
    public partial class plano_ativo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "PLANO_VENDAS",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "PLANO_VENDAS");
        }
    }
}
