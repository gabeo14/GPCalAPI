using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GPCalAPI.Migrations
{
    public partial class ChangedNamesAndStuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Type = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    SeriesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -1, "Formula 1" },
                    { -2, "Formula E" },
                    { -3, "World Endurance Championship" },
                    { -4, "Indy Car" },
                    { -5, "MotoGP" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "DateTime", "SeriesId", "Title", "Type" },
                values: new object[,]
                {
                    { -1, new DateTime(2018, 3, 23, 1, 0, 0, 0, DateTimeKind.Unspecified), -1, "Australian GP", "Free Practice 1" },
                    { -17, new DateTime(2018, 3, 16, 16, 5, 0, 0, DateTimeKind.Unspecified), -5, "Qatar GP", "Free Practice 2" },
                    { -18, new DateTime(2018, 3, 17, 11, 35, 0, 0, DateTimeKind.Unspecified), -5, "Qatar GP", "Free Practice 3" },
                    { -19, new DateTime(2018, 3, 17, 15, 40, 0, 0, DateTimeKind.Unspecified), -5, "Qatar GP", "Free Practice 4" },
                    { -20, new DateTime(2018, 3, 17, 16, 20, 0, 0, DateTimeKind.Unspecified), -5, "Qatar GP", "Qualifying 1" },
                    { -21, new DateTime(2018, 3, 17, 16, 45, 0, 0, DateTimeKind.Unspecified), -5, "Qatar GP", "Qualifying 2" },
                    { -22, new DateTime(2018, 3, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), -5, "Qatar GP", "Race" },
                    { -23, new DateTime(2018, 4, 6, 11, 55, 0, 0, DateTimeKind.Unspecified), -5, "Argentina GP", "Free Practice 1" },
                    { -24, new DateTime(2018, 4, 6, 18, 5, 0, 0, DateTimeKind.Unspecified), -5, "Argentina GP", "Free Practice 2" },
                    { -16, new DateTime(2018, 3, 16, 11, 45, 0, 0, DateTimeKind.Unspecified), -5, "Qatar GP", "Free Practice 1" },
                    { -25, new DateTime(2018, 4, 7, 13, 55, 0, 0, DateTimeKind.Unspecified), -5, "Argentina GP", "Free Practice 3" },
                    { -27, new DateTime(2018, 4, 7, 18, 10, 0, 0, DateTimeKind.Unspecified), -5, "Argentina GP", "Qualifying 1" },
                    { -28, new DateTime(2018, 4, 7, 18, 35, 0, 0, DateTimeKind.Unspecified), -5, "Argentina GP", "Qualifying 2" },
                    { -29, new DateTime(2018, 4, 8, 18, 20, 0, 0, DateTimeKind.Unspecified), -5, "Argentina GP", "Race" },
                    { -30, new DateTime(2018, 4, 20, 14, 55, 0, 0, DateTimeKind.Unspecified), -5, "American GP", "Free Practice 1" },
                    { -31, new DateTime(2018, 4, 20, 19, 5, 0, 0, DateTimeKind.Unspecified), -5, "American GP", "Free Practice 2" },
                    { -32, new DateTime(2018, 4, 21, 14, 55, 0, 0, DateTimeKind.Unspecified), -5, "American GP", "Free Practice 3" },
                    { -33, new DateTime(2018, 4, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), -5, "American GP", "Free Practice 4" },
                    { -34, new DateTime(2018, 4, 21, 19, 10, 0, 0, DateTimeKind.Unspecified), -5, "American GP", "Qualifying 1" },
                    { -26, new DateTime(2018, 4, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), -5, "Argentina GP", "Free Practice 4" },
                    { -35, new DateTime(2018, 4, 21, 19, 35, 0, 0, DateTimeKind.Unspecified), -5, "American GP", "Qualifying 2" },
                    { -43, new DateTime(2018, 3, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), -4, "St. Pete GP", "Race" },
                    { -41, new DateTime(2018, 3, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), -4, "St. Pete GP", "Qualifying 2" },
                    { -2, new DateTime(2019, 3, 23, 5, 0, 0, 0, DateTimeKind.Unspecified), -1, "Australian GP", "Free Practice 2" },
                    { -3, new DateTime(2019, 3, 24, 3, 0, 0, 0, DateTimeKind.Unspecified), -1, "Australian GP", "Free Practice 3" },
                    { -4, new DateTime(2019, 3, 24, 6, 0, 0, 0, DateTimeKind.Unspecified), -1, "Australian GP", "Qualifying" },
                    { -5, new DateTime(2019, 3, 25, 5, 10, 0, 0, DateTimeKind.Unspecified), -1, "Australian GP", "Race" },
                    { -6, new DateTime(2019, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), -1, "Bahrain GP", "Free Practice 1" },
                    { -7, new DateTime(201, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), -1, "Bahrain GP", "Free Practice 2" },
                    { -8, new DateTime(2018, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), -1, "Bahrain GP", "Free Practice 3" },
                    { -9, new DateTime(2018, 4, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), -1, "Bahrain GP", "Qualifying" },
                    { -42, new DateTime(2018, 3, 10, 19, 20, 0, 0, DateTimeKind.Unspecified), -4, "St. Pete GP", "Qualifying 3" },
                    { -10, new DateTime(2018, 4, 8, 15, 10, 0, 0, DateTimeKind.Unspecified), -1, "Bahrain GP", "Race" },
                    { -12, new DateTime(2018, 4, 13, 6, 0, 0, 0, DateTimeKind.Unspecified), -1, "Chinese GP", "Free Practice 2" },
                    { -13, new DateTime(2018, 4, 14, 3, 0, 0, 0, DateTimeKind.Unspecified), -1, "Chinese GP", "Free Practice 3" },
                    { -14, new DateTime(2018, 4, 14, 6, 0, 0, 0, DateTimeKind.Unspecified), -1, "Chinese GP", "Qualifying" },
                    { -15, new DateTime(2018, 4, 15, 6, 10, 0, 0, DateTimeKind.Unspecified), -1, "Chinese GP", "Race" },
                    { -37, new DateTime(2018, 3, 9, 15, 20, 0, 0, DateTimeKind.Unspecified), -4, "St. Pete GP", "Practice 1" },
                    { -38, new DateTime(2018, 3, 9, 19, 10, 0, 0, DateTimeKind.Unspecified), -4, "St. Pete GP", "Practice 2" },
                    { -39, new DateTime(2018, 3, 10, 15, 10, 0, 0, DateTimeKind.Unspecified), -4, "St. Pete GP", "Practice 3" },
                    { -40, new DateTime(2018, 3, 10, 18, 20, 0, 0, DateTimeKind.Unspecified), -4, "St. Pete GP", "Qualifying 1" },
                    { -11, new DateTime(2018, 4, 13, 2, 0, 0, 0, DateTimeKind.Unspecified), -1, "Chinese GP", "Free Practice 1" },
                    { -36, new DateTime(2018, 4, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), -5, "American GP", "Race" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_SeriesId",
                table: "Events",
                column: "SeriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Series");
        }
    }
}
