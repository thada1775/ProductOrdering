using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductOrdering.Migrations
{
    public partial class AddForeignkey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderings_AspNetUsers_UserId",
                table: "Orderings");

            migrationBuilder.DropIndex(
                name: "IX_Orderings_UserId",
                table: "Orderings");
        }
    }
}
