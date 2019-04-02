using Microsoft.EntityFrameworkCore.Migrations;

namespace Nomina.Web.Migrations
{
    public partial class CreateEmpleoye : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Empleoyes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Empleoyes");
        }
    }
}
