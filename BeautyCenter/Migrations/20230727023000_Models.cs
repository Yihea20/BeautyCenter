using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class Models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0167256a-e89d-451e-8fb9-eddd6e8b7967");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "977b385a-0531-43f3-9b3c-c44a3f0b6e0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfa2d3cd-4316-43fa-9733-4e9f297e3ebf");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0167256a-e89d-451e-8fb9-eddd6e8b7967", null, "employee", "EMPLOYEE" },
                    { "977b385a-0531-43f3-9b3c-c44a3f0b6e0b", null, "user", "USER" },
                    { "bfa2d3cd-4316-43fa-9733-4e9f297e3ebf", null, "manager", "MANAGER" }
                });
        }
    }
}
