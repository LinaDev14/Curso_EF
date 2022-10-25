using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoEntityFramework.Migrations
{
    public partial class RenameTableAndColumnArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Article",
                table: "Article");

            migrationBuilder.RenameTable(
                name: "Article",
                newName: "Tbl_Article");

            migrationBuilder.RenameColumn(
                name: "TitleArticle",
                table: "Tbl_Article",
                newName: "Title");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Article",
                table: "Tbl_Article",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Article",
                table: "Tbl_Article");

            migrationBuilder.RenameTable(
                name: "Tbl_Article",
                newName: "Article");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Article",
                newName: "TitleArticle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Article",
                table: "Article",
                column: "ArticleId");
        }
    }
}
