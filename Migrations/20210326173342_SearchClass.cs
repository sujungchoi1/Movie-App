using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class SearchClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "search_title",
                table: "Movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "search_title",
                table: "Movies",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
