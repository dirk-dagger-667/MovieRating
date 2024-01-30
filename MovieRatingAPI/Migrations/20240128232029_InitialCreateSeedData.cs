using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieRatingAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealeaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Starring = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                    table.ForeignKey(
                        name: "FK_Ratings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Image", "Name", "RealeaseDate", "Resume", "Starring", "Tags" },
                values: new object[,]
                {
                    { 1, "https://images.app.goo.gl/qA7EYMCG7sG7XYiw8", "Killers of the flower moon", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resume of Killers of the flower moon", "Leonardo DiCaprio, Robert De Niro, Lily Gladstone", "Crime, History, Drama" },
                    { 2, "https://images.app.goo.gl/wxTabBJgNDvT4UtB9", "Se7en", new DateTime(1995, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resume of Se7en", "Morgan Freeman, Brad Pitt, Kevin Spacey", "Crime, Mystery, Drama" },
                    { 3, "https://images.app.goo.gl/xUf4tSp5Em7deLr79", "The hateful eight", new DateTime(2016, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resume of The hateful eight", "Samuel L. Jackson, Kurt Russell, Jennifer Jason Leigh", "Crime, Mystery, Drama" },
                    { 4, "https://images.app.goo.gl/fgNqN3kejWiYWY916", "Kiss kiss bang bang", new DateTime(2005, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resume for Kiss kiss bang bang", "Robert Downey Jr., Val Kilmer, Michelle Monaghan", "Crime, Comedy, Mystery" },
                    { 5, "", "The killer", new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "After a fateful near-miss, an assassin battles his employers and himself, on an international manhunt he insists isn't personal.", "Michael Fassbender, Tilda Swinton, Charles Parnell", "Crime, Action, Adventure" },
                    { 6, "https://images.app.goo.gl/MB7Ljzz1nDQJjN6X9", "Revolver", new DateTime(2005, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resume of Revolver", "Jason Statham, Ray Liotta, André 3000", "Crime, Action, Drama" },
                    { 7, "https://images.app.goo.gl/jAPdTufZj7YzvDqt5", "Dune", new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resume of Dune", "Timothée Chalamet, Rebecca Ferguson, Zendaya", "Adventure, Action, Drama" },
                    { 8, "https://images.app.goo.gl/c1RsoGhhoPyuCaVt7", "The whale", new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A reclusive, morbidly obese English teacher attempts to reconnect with his estranged teenage daughter.", "Brendan Fraser, Sadie Sink, Ty Simpkins", "Drama" },
                    { 9, "https://images.app.goo.gl/V4K6yzASis1kT83d6", "American psycho", new DateTime(2000, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A reclusive, morbidly obese English teacher attempts to reconnect with his estranged teenage daughter.", "Christian Bale, Justin Theroux, Josh Lucas", "Drama, Crime, Horror" },
                    { 10, "https://images.app.goo.gl/1gt4GrDhj8WjdgWE7", "The Lincoln lawyer", new DateTime(2011, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A reclusive, morbidly obese English teacher attempts to reconnect with his estranged teenage daughter.", "Ryan Phillippe, Marisa Tomei, Matthew McConaughey", "Drama, Crime, Mystery" },
                    { 11, "https://images.app.goo.gl/KdKdJzE6Zu8yuTDbA", "Public enemies", new DateTime(2011, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Feds try to take down notorious American gangsters John Dillinger, Baby Face Nelson, and Pretty Boy Floyd during a booming crime wave in the 1930s.", "Christian Stolte, Johnny Depp, Christian Bale", "Action, Crime, Biography" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "MovieId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 2 },
                    { 4, 1, 5 },
                    { 5, 2, 1 },
                    { 6, 2, 4 },
                    { 7, 2, 4 },
                    { 8, 2, 4 },
                    { 9, 3, 1 },
                    { 10, 4, 2 },
                    { 11, 5, 3 },
                    { 12, 6, 4 },
                    { 13, 7, 5 },
                    { 14, 8, 1 },
                    { 15, 9, 2 },
                    { 16, 10, 2 },
                    { 17, 11, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MovieId",
                table: "Ratings",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
