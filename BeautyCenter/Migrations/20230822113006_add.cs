using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Employees_EmployeeId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Employees_EmployeeId2",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_EmployeeId",
                table: "Favorites");

            migrationBuilder.RenameColumn(
                name: "EmployeeId2",
                table: "Favorites",
                newName: "EmployeeId1");

            migrationBuilder.RenameIndex(
                name: "IX_Favorites_EmployeeId2",
                table: "Favorites",
                newName: "IX_Favorites_EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_EmployeeId",
                table: "Favorites",
                column: "EmployeeId",
                unique: true,
                filter: "[EmployeeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Employees_EmployeeId",
                table: "Favorites",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Employees_EmployeeId1",
                table: "Favorites",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Employees_EmployeeId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Employees_EmployeeId1",
                table: "Favorites");

            migrationBuilder.DropIndex(
                name: "IX_Favorites_EmployeeId",
                table: "Favorites");

            migrationBuilder.RenameColumn(
                name: "EmployeeId1",
                table: "Favorites",
                newName: "EmployeeId2");

            migrationBuilder.RenameIndex(
                name: "IX_Favorites_EmployeeId1",
                table: "Favorites",
                newName: "IX_Favorites_EmployeeId2");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_EmployeeId",
                table: "Favorites",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Employees_EmployeeId",
                table: "Favorites",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Employees_EmployeeId2",
                table: "Favorites",
                column: "EmployeeId2",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
