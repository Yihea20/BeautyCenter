using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class DB_BeautyCenterr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5ea10d2c-c713-4a28-966f-2a09f9583044", null, "employee", "EMPLOYEE" },
                    { "e4332370-82b4-470a-8d4c-6d8f06b7477b", null, "manager", "MANAGER" },
                    { "f85fbe15-2f4e-4853-be69-88e5b065fa13", null, "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ea10d2c-c713-4a28-966f-2a09f9583044");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4332370-82b4-470a-8d4c-6d8f06b7477b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f85fbe15-2f4e-4853-be69-88e5b065fa13");

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
    }
}
