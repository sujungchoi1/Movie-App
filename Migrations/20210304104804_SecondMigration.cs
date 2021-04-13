using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Starring",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "page",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_pages",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "total_results",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    adult = table.Column<bool>(nullable: false),
                    backdrop_path = table.Column<string>(nullable: true),
                    original_language = table.Column<string>(nullable: true),
                    original_title = table.Column<string>(nullable: true),
                    overview = table.Column<string>(nullable: true),
                    popularity = table.Column<double>(nullable: false),
                    poster_path = table.Column<string>(nullable: true),
                    release_date = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    video = table.Column<bool>(nullable: false),
                    vote_average = table.Column<double>(nullable: false),
                    vote_count = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.id);
                    table.ForeignKey(
                        name: "FK_Results_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_MovieId",
                table: "Results",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropColumn(
                name: "page",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "total_pages",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "total_results",
                table: "Movies");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Movies",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movies",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Starring",
                table: "Movies",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Movies",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Movies",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
