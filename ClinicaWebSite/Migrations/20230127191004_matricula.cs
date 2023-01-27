using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaWebSite.Migrations
{
    public partial class matricula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Matricula",
                table: "Medico",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Matricula",
                table: "Medico");
        }
    }
}
