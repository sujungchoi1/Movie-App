using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class SeventhMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Movies_MovieId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_MovieId",
                table: "Likes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Likes_MovieId",
                table: "Likes",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Movies_MovieId",
                table: "Likes",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
