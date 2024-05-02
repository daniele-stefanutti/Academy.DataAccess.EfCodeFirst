using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EfCodeFirst.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddMovieLanguagesAndLanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    language_id = table.Column<int>(type: "int", nullable: false),
                    language_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    language_name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.language_id);
                });

            migrationBuilder.CreateTable(
                name: "Movie_Languages",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int", nullable: false),
                    language_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_Languages", x => new { x.movie_id, x.language_id });
                    table.ForeignKey(
                        name: "FK_Movie_Languages_Language_language_id",
                        column: x => x.language_id,
                        principalTable: "Language",
                        principalColumn: "language_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Languages_Movie_movie_id",
                        column: x => x.movie_id,
                        principalTable: "Movie",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "language_id", "language_code", "language_name" },
                values: new object[,]
                {
                    { 1, "en", "English" },
                    { 2, "es", "Spanish" },
                    { 3, "de", "German" },
                    { 4, "it", "Italian" },
                    { 5, "ja", "Japanese" },
                    { 6, "hi", "Hindi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Languages_language_id",
                table: "Movie_Languages",
                column: "language_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie_Languages");

            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}
