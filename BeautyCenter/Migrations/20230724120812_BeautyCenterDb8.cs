using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class BeautyCenterDb8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Centers_AspNetUsers_ManagerId",
                table: "Centers");

            migrationBuilder.DropIndex(
                name: "IX_Centers_ManagerId",
                table: "Centers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "011e9e56-c480-4b13-9a86-05e1dbee52e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ba10142-23ff-4905-bf87-297fb2763787");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac56de98-2692-4f32-a27b-12289b8150a4");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Centers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2dd77e0f-d180-49ee-bc86-264355bc74bb", null, "manager", "MANAGER" },
                    { "4e3e16b5-982a-40ec-ae8e-22cdf88ed4c7", null, "employee", "EMPLOYEE" },
                    { "8ce97330-ac40-44c5-aa50-3e3742c16fa0", null, "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dd77e0f-d180-49ee-bc86-264355bc74bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e3e16b5-982a-40ec-ae8e-22cdf88ed4c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ce97330-ac40-44c5-aa50-3e3742c16fa0");

            migrationBuilder.AddColumn<string>(
                name: "ManagerId",
                table: "Centers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "011e9e56-c480-4b13-9a86-05e1dbee52e7", null, "employee", "EMPLOYEE" },
                    { "3ba10142-23ff-4905-bf87-297fb2763787", null, "manager", "MANAGER" },
                    { "ac56de98-2692-4f32-a27b-12289b8150a4", null, "user", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Centers_ManagerId",
                table: "Centers",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Centers_AspNetUsers_ManagerId",
                table: "Centers",
                column: "ManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
