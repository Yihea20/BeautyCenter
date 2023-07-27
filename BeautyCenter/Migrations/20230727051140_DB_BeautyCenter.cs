using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class DB_BeautyCenter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53e18132-11df-4e94-a073-488ce964ba74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6924977-480d-4494-aa3f-4520786a030f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d02d36c9-011e-4d87-a811-c255d30978fb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16a6e95f-20f8-4915-b7c0-843285487836", null, "manager", "MANAGER" },
                    { "1d515205-6ac6-4c1c-a02a-cdc8a6433bb9", null, "user", "USER" },
                    { "3cba077d-b349-4699-8ffc-185467d24f27", null, "employee", "EMPLOYEE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16a6e95f-20f8-4915-b7c0-843285487836");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d515205-6ac6-4c1c-a02a-cdc8a6433bb9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cba077d-b349-4699-8ffc-185467d24f27");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "53e18132-11df-4e94-a073-488ce964ba74", null, "manager", "MANAGER" },
                    { "a6924977-480d-4494-aa3f-4520786a030f", null, "employee", "EMPLOYEE" },
                    { "d02d36c9-011e-4d87-a811-c255d30978fb", null, "user", "USER" }
                });
        }
    }
}
