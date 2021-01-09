using Microsoft.EntityFrameworkCore.Migrations;

namespace SchowekWeb.Data.Migrations
{
    public partial class AddUserIdReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_AspNetUsersId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_AspNetUsers_AspNetUsersId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "AspNetUsersId",
                table: "Items",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_AspNetUsersId",
                table: "Items",
                newName: "IX_Items_UserId");

            migrationBuilder.RenameColumn(
                name: "AspNetUsersId",
                table: "Categories",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_AspNetUsersId",
                table: "Categories",
                newName: "IX_Categories_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_UserId",
                table: "Categories",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_AspNetUsers_UserId",
                table: "Items",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_UserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_AspNetUsers_UserId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Items",
                newName: "AspNetUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_UserId",
                table: "Items",
                newName: "IX_Items_AspNetUsersId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Categories",
                newName: "AspNetUsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_UserId",
                table: "Categories",
                newName: "IX_Categories_AspNetUsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_AspNetUsersId",
                table: "Categories",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_AspNetUsers_AspNetUsersId",
                table: "Items",
                column: "AspNetUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
