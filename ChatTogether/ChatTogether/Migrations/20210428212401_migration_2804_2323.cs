using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatTogether.Web.Migrations
{
    public partial class migration_2804_2323 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "AppUsers",
                type: "nvarchar(50)",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "AppUsers");
        }
    }
}
