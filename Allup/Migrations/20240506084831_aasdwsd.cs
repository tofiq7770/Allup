using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Allup.Migrations
{
    public partial class aasdwsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Sliders");

            migrationBuilder.AddColumn<string>(
                name: "IsMain",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "IsMain",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
