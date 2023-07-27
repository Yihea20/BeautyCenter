using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class BeautyserverTest3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f8201ba-0268-44bb-bcb8-1862bfb64792", null, "employee", "EMPLOYEE" },
                    { "6b14d4f2-59d5-4849-bc19-46c0a140be4c", null, "user", "USER" },
                    { "fce6a0ac-3fb4-4007-9880-879d93899392", null, "manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f8201ba-0268-44bb-bcb8-1862bfb64792");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b14d4f2-59d5-4849-bc19-46c0a140be4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fce6a0ac-3fb4-4007-9880-879d93899392");
        }
    }
}
