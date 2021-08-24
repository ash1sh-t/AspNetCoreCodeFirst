using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreCodeFirst.Migrations
{
    public partial class AddLanguageColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "language",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "language",
                table: "Books");
        }
    }
}
