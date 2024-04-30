using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCodeFirst.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddMovieAndMovieCast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    budget = table.Column<long>(type: "bigint", nullable: true),
                    release_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    revenue = table.Column<long>(type: "bigint", nullable: true),
                    runtime = table.Column<int>(type: "int", nullable: true),
                    votes_avg = table.Column<decimal>(type: "decimal(5,3)", nullable: true),
                    votes_count = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.movie_id);
                });

            migrationBuilder.CreateTable(
                name: "MovieCasts",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int", nullable: false),
                    person_id = table.Column<int>(type: "int", nullable: false),
                    character_name = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    cast_order = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCasts", x => new { x.movie_id, x.person_id });
                    table.ForeignKey(
                        name: "FK_MovieCasts_Movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "Movies",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCasts_Persons_person_id",
                        column: x => x.person_id,
                        principalTable: "Persons",
                        principalColumn: "person_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieCasts_person_id",
                table: "MovieCasts",
                column: "person_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieCasts");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
