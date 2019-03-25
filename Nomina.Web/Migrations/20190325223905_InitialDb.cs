using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nomina.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleoyes",
                columns: table => new
                {
                    NumDoc = table.Column<string>(nullable: false),
                    DocumentType = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    FirstLastName = table.Column<string>(nullable: true),
                    SecondLastName = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    AdmissionDate = table.Column<DateTime>(nullable: false),
                    RetirementDate = table.Column<DateTime>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    Salary = table.Column<double>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleoyes", x => x.NumDoc);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleoyes");
        }
    }
}
