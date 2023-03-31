using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLenaLoginForm.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_Logins_loginlerUserId",
                table: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Forms_loginlerUserId",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "FormId",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "loginlerUserId",
                table: "Forms");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Logins",
                type: "Varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Logins",
                type: "Varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(20)");

            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "Logins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "loginlerUserId",
                table: "Forms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Forms_loginlerUserId",
                table: "Forms",
                column: "loginlerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_Logins_loginlerUserId",
                table: "Forms",
                column: "loginlerUserId",
                principalTable: "Logins",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
