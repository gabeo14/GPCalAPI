using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GPCalAPI.Migrations
{
    public partial class FixedDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateAndTime",
                value: new DateTime(2018, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateAndTime",
                value: new DateTime(2018, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateAndTime",
                value: new DateTime(2018, 3, 25, 5, 10, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateAndTime",
                value: new DateTime(2018, 3, 24, 6, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateAndTime",
                value: new DateTime(2018, 3, 24, 3, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateAndTime",
                value: new DateTime(2018, 3, 23, 5, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateAndTime",
                value: new DateTime(201, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateAndTime",
                value: new DateTime(2019, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateAndTime",
                value: new DateTime(2019, 3, 25, 5, 10, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateAndTime",
                value: new DateTime(2019, 3, 24, 6, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateAndTime",
                value: new DateTime(2019, 3, 24, 3, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateAndTime",
                value: new DateTime(2019, 3, 23, 5, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
