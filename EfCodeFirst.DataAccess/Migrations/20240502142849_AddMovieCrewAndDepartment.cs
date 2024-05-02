using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EfCodeFirst.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddMovieCrewAndDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    department_id = table.Column<int>(type: "int", nullable: false),
                    department_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.department_id);
                });

            migrationBuilder.CreateTable(
                name: "Movie_Crew",
                columns: table => new
                {
                    movie_id = table.Column<int>(type: "int", nullable: false),
                    person_id = table.Column<int>(type: "int", nullable: false),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    job = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_Crew", x => new { x.movie_id, x.person_id, x.department_id });
                    table.ForeignKey(
                        name: "FK_Movie_Crew_Department_department_id",
                        column: x => x.department_id,
                        principalTable: "Department",
                        principalColumn: "department_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Crew_Movie_movie_id",
                        column: x => x.movie_id,
                        principalTable: "Movie",
                        principalColumn: "movie_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Crew_Person_person_id",
                        column: x => x.person_id,
                        principalTable: "Person",
                        principalColumn: "person_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "department_id", "department_name" },
                values: new object[,]
                {
                    { 1, "Camera" },
                    { 2, "Directing" },
                    { 3, "Production" },
                    { 4, "Writing" },
                    { 5, "Editing" },
                    { 6, "Sound" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Crew_department_id",
                table: "Movie_Crew",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Crew_person_id",
                table: "Movie_Crew",
                column: "person_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie_Crew");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
