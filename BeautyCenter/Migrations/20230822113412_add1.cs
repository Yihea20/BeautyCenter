using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class add1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Managers_ManagerId",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_ManagerId",
                table: "Favorites");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Favorites");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Favorites",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_ManagerId",
                table: "Favorites",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Managers_ManagerId",
                table: "Favorites",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id");
        }
    }
}
