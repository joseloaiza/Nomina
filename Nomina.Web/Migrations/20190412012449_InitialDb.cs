using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nomina.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocumentType = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    SecondName = table.Column<string>(maxLength: 20, nullable: true),
                    FirstLastName = table.Column<string>(maxLength: 20, nullable: false),
                    SecondLastName = table.Column<string>(maxLength: 20, nullable: true),
                    ImageUrl = table.Column<string>(maxLength: 200, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    AdmissionDate = table.Column<DateTime>(nullable: false),
                    RetirementDate = table.Column<DateTime>(nullable: true),
                    Mail = table.Column<string>(maxLength: 50, nullable: true),
                    Salary = table.Column<double>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
