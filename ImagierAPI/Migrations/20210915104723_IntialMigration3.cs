using Microsoft.EntityFrameworkCore.Migrations;

namespace ImagierAPI.Migrations
{
    public partial class IntialMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFile",
                table: "ImageAssets",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFile",
                table: "ImageAssets");
        }
    }
}
