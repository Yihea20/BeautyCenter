using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e0d850e-5cbe-4c7b-8657-8506b325b2c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcb86585-6529-4b2f-8981-04d75d600b0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4d6ff6b-0106-4b64-b366-3c02405cd478");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2e0d850e-5cbe-4c7b-8657-8506b325b2c9", null, "employee", "EMPLOYEE" },
                    { "bcb86585-6529-4b2f-8981-04d75d600b0d", null, "user", "USER" },
                    { "d4d6ff6b-0106-4b64-b366-3c02405cd478", null, "manager", "MANAGER" }
                });
        }
    }
}
