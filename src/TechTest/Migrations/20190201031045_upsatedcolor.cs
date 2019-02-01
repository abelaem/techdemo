using Microsoft.EntityFrameworkCore.Migrations;

namespace TechTest.Migrations
{
    public partial class upsatedcolor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColoursId",
                table: "Persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColoursId",
                table: "Persons",
                nullable: false,
                defaultValue: 0);
        }
    }
}
