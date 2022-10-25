using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoEntityFramework.Migrations
{
    public partial class ScoreFieldAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "User",
                newName: "Address");

            migrationBuilder.AddColumn<double>(
                name: "Score",
                table: "Tbl_Article",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Tbl_Article");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "User",
                newName: "Adress");
        }
    }
}
