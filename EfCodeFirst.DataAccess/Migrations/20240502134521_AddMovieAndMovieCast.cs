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
                name: "Movie",
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
                    table.PrimaryKey("PK_Movie", x => x.movie_id);
                });

            migrationBuilder.CreateTable(
                name: "Movie_Cast",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int", nullable: false),
                    person_id = table.Column<int>(type: "int", nullable: false),
                    character_name = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    cast_order = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_Cast", x => new { x.movie_id, x.person_id });
                    table.ForeignKey(
                        name: "FK_Movie_Cast_Movie_movie_id",
                        column: x => x.movie_id,
                        principalTable: "Movie",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Cast_Person_person_id",
                        column: x => x.person_id,
                        principalTable: "Person",
                        principalColumn: "person_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Cast_person_id",
                table: "Movie_Cast",
                column: "person_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie_Cast");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
