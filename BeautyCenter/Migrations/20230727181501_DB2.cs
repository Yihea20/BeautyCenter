using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class DB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b0a5bc4-23fc-4ee7-99f9-734e13d97c68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0fb1cac-cac8-43d3-a2a3-2d6d3df8dea1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3fca821-2061-4cfb-9633-5757cdeb9fa9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "776fa1d5-11d1-47f7-88e9-443b73744dc7", null, "manager", "MANAGER" },
                    { "80fc4945-2493-4841-848c-b1aa113477ed", null, "user", "USER" },
                    { "ec39a200-571a-4316-a8aa-499150fffde8", null, "employee", "EMPLOYEE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "776fa1d5-11d1-47f7-88e9-443b73744dc7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80fc4945-2493-4841-848c-b1aa113477ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec39a200-571a-4316-a8aa-499150fffde8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b0a5bc4-23fc-4ee7-99f9-734e13d97c68", null, "user", "USER" },
                    { "a0fb1cac-cac8-43d3-a2a3-2d6d3df8dea1", null, "employee", "EMPLOYEE" },
                    { "d3fca821-2061-4cfb-9633-5757cdeb9fa9", null, "manager", "MANAGER" }
                });
        }
    }
}
