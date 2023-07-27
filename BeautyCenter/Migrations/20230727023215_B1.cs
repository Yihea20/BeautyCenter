using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class B1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41f90e25-8f12-4bad-be4c-b506e4dc0b74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c97cfd0-2e9b-486d-9537-59f88c477c72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e14e22ec-1998-4e95-865c-da3b9dd49137");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "41f90e25-8f12-4bad-be4c-b506e4dc0b74", null, "user", "USER" },
                    { "9c97cfd0-2e9b-486d-9537-59f88c477c72", null, "manager", "MANAGER" },
                    { "e14e22ec-1998-4e95-865c-da3b9dd49137", null, "employee", "EMPLOYEE" }
                });
        }
    }
}
