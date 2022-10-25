using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoEntityFramework.Migrations
{
    public partial class AgeFieldNoMapped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "User");
        }
    }
}
