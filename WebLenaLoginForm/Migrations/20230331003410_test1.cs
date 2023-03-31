using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebLenaLoginForm.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoginUserId",
                table: "Forms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "formlarFormId",
                table: "Forms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Forms_formlarFormId",
                table: "Forms",
                column: "formlarFormId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forms_Forms_formlarFormId",
                table: "Forms");

            migrationBuilder.DropForeignKey(
                name: "FK_Forms_Logins_LoginUserId",
                table: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Forms_formlarFormId",
                table: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Forms_LoginUserId",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "LoginUserId",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "formlarFormId",
                table: "Forms");
        }
    }
}
