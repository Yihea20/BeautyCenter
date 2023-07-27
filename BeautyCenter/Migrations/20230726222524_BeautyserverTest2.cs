using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class BeautyserverTest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d94e327-4db1-455c-a941-3f1092358a4f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a76108e3-2b09-4650-8cff-78f8b069f370");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db76a8cf-8a30-4a57-9cfc-913c4a6c1365");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d94e327-4db1-455c-a941-3f1092358a4f", null, "employee", "EMPLOYEE" },
                    { "a76108e3-2b09-4650-8cff-78f8b069f370", null, "manager", "MANAGER" },
                    { "db76a8cf-8a30-4a57-9cfc-913c4a6c1365", null, "user", "USER" }
                });
        }
    }
}
