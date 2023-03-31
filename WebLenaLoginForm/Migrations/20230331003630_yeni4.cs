using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLenaLoginForm.Migrations
{
    public partial class yeni4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_Forms_formlarFormId",
                table: "Forms");

            migrationBuilder.DropForeignKey(
                name: "FK_Forms_Logins_LoginUserId",
                table: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Forms_LoginUserId",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "LoginUserId",
                table: "Forms");

            migrationBuilder.RenameColumn(
                name: "formlarFormId",
                table: "Forms",
                newName: "loginlerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Forms_formlarFormId",
                table: "Forms",
                newName: "IX_Forms_loginlerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_Logins_loginlerUserId",
                table: "Forms",
                column: "loginlerUserId",
                principalTable: "Logins",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_Logins_loginlerUserId",
                table: "Forms");

            migrationBuilder.RenameColumn(
                name: "loginlerUserId",
                table: "Forms",
                newName: "formlarFormId");

            migrationBuilder.RenameIndex(
                name: "IX_Forms_loginlerUserId",
                table: "Forms",
                newName: "IX_Forms_formlarFormId");

            migrationBuilder.AddColumn<int>(
                name: "LoginUserId",
                table: "Forms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Forms_LoginUserId",
                table: "Forms",
                column: "LoginUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_Forms_formlarFormId",
                table: "Forms",
                column: "formlarFormId",
                principalTable: "Forms",
                principalColumn: "FormId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Forms_Logins_LoginUserId",
                table: "Forms",
                column: "LoginUserId",
                principalTable: "Logins",
                principalColumn: "UserId");
        }
    }
}
