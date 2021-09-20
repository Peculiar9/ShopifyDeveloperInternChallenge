using Microsoft.EntityFrameworkCore.Migrations;

namespace ImagierAPI.Migrations
{
    public partial class MainMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageCategory",
                table: "ImageAssets");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ImageAssets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ImageAssets");

            migrationBuilder.AddColumn<string>(
                name: "ImageCategory",
                table: "ImageAssets",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
