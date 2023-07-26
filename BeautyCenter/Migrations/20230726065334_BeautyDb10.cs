using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class BeautyDb10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e7a2126-cf84-4f21-afd3-a12ecdd44879");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c734869-49be-4efc-8c56-96fd984d32d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecee047e-8ea5-42de-b1a3-b5580e3a8943");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Centers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c1d5a075-fe58-438e-b4d4-48e31967e31a", null, "user", "USER" },
                    { "ecbafb88-bf86-488b-832b-68469523b518", null, "employee", "EMPLOYEE" },
                    { "f1cf12ba-231e-4211-8c33-196952976b42", null, "manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1d5a075-fe58-438e-b4d4-48e31967e31a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecbafb88-bf86-488b-832b-68469523b518");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1cf12ba-231e-4211-8c33-196952976b42");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Centers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e7a2126-cf84-4f21-afd3-a12ecdd44879", null, "employee", "EMPLOYEE" },
                    { "6c734869-49be-4efc-8c56-96fd984d32d2", null, "user", "USER" },
                    { "ecee047e-8ea5-42de-b1a3-b5580e3a8943", null, "manager", "MANAGER" }
                });
        }
    }
}
