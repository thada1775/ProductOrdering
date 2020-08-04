using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductOrdering.Migrations
{
    public partial class AddforeignkeyCancleUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderings_AspNetUsers_UserId",
                table: "Orderings");

            migrationBuilder.DropIndex(
                name: "IX_Orderings_UserId",
                table: "Orderings");

            migrationBuilder.AddColumn<string>(
                name: "CancelUserId",
                table: "Orderings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orderings_CancelUserId",
                table: "Orderings",
                column: "CancelUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderings_AspNetUsers_CancelUserId",
                table: "Orderings",
                column: "CancelUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderings_AspNetUsers_CancelUserId",
                table: "Orderings");

            migrationBuilder.DropIndex(
                name: "IX_Orderings_CancelUserId",
                table: "Orderings");

            migrationBuilder.DropColumn(
                name: "CancelUserId",
                table: "Orderings");

            migrationBuilder.CreateIndex(
                name: "IX_Orderings_UserId",
                table: "Orderings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderings_AspNetUsers_UserId",
                table: "Orderings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
