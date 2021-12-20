using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstTask.Migrations
{
    public partial class AddVideoExtensionPropertyToTipsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoExtension",
                table: "Tips",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoExtension",
                table: "Tips");
        }
    }
}
