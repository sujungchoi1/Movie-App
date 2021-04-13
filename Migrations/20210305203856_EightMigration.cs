using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class EightMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Users_UserId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_UserId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Results");

            migrationBuilder.AddColumn<int>(
                name: "Resultid",
                table: "Likes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Likes_Resultid",
                table: "Likes",
                column: "Resultid");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Results_Resultid",
                table: "Likes",
                column: "Resultid",
                principalTable: "Results",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Results_Resultid",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_Resultid",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "Resultid",
                table: "Likes");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
