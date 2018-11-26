using Microsoft.EntityFrameworkCore.Migrations;

namespace GPCalAPI.Migrations
{
    public partial class ModifiedDateTimeColumnTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Events",
                newName: "DateAndTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateAndTime",
                table: "Events",
                newName: "DateTime");
        }
    }
}
