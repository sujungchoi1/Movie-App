using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Watches_Movies_MovieId",
                table: "Watches");

            migrationBuilder.DropIndex(
                name: "IX_Watches_MovieId",
                table: "Watches");

            migrationBuilder.AddColumn<int>(
                name: "Resultid",
                table: "Watches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Results",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Watches_Resultid",
                table: "Watches",
                column: "Resultid");

            migrationBuilder.CreateIndex(
                name: "IX_Results_UserId",
                table: "Results",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Users_UserId",
                table: "Results",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Watches_Results_Resultid",
                table: "Watches",
                column: "Resultid",
                principalTable: "Results",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Users_UserId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Watches_Results_Resultid",
                table: "Watches");

            migrationBuilder.DropIndex(
                name: "IX_Watches_Resultid",
                table: "Watches");

            migrationBuilder.DropIndex(
                name: "IX_Results_UserId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "Resultid",
                table: "Watches");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Results");

            migrationBuilder.CreateIndex(
                name: "IX_Watches_MovieId",
                table: "Watches",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Watches_Movies_MovieId",
                table: "Watches",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
