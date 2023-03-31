using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLenaLoginForm.Migrations
{
    public partial class yeni5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "Logins",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormId",
                table: "Logins");
        }
    }
}
