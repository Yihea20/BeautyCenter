using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class BeautyDb11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
