using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoAdvWeb.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_AspNetUsers_OwnerId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_OwnerId",
                table: "Todos");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "TodoUserId",
                table: "Todos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Todos_TodoUserId",
                table: "Todos",
                column: "TodoUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_AspNetUsers_TodoUserId",
                table: "Todos",
                column: "TodoUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_AspNetUsers_TodoUserId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_TodoUserId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "TodoUserId",
                table: "Todos");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Todos",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_OwnerId",
                table: "Todos",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_AspNetUsers_OwnerId",
                table: "Todos",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
