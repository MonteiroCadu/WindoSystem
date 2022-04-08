using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Windo.Persistence.Migrations
{
    public partial class historico_add_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "HISTORICO_LICENCA",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "HISTORICO_LICENCA");
        }
    }
}
