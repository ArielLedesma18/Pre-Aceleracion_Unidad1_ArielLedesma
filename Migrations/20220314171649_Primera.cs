using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pre_Aceleracion_Unidad1_ArielLedesma.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                schema: "Users",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostId",
                schema: "Users",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Posts",
                schema: "Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PostId",
                schema: "Users",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                schema: "Users",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                schema: "Users",
                table: "Posts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                schema: "Users",
                table: "Posts",
                column: "UserId",
                principalSchema: "Users",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                schema: "Users",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserId",
                schema: "Users",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Users",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "Comments",
                schema: "Users",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Posts",
                schema: "Users",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                schema: "Users",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                schema: "Users",
                table: "Comments",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                schema: "Users",
                table: "Comments",
                column: "PostId",
                principalSchema: "Users",
                principalTable: "Posts",
                principalColumn: "Id");
        }
    }
}
