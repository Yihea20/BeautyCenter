using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class BeautyserverTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Services_IdSerivce",
                table: "Offers");

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
                name: "IdSerivce",
                table: "Offers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d94e327-4db1-455c-a941-3f1092358a4f", null, "employee", "EMPLOYEE" },
                    { "a76108e3-2b09-4650-8cff-78f8b069f370", null, "manager", "MANAGER" },
                    { "db76a8cf-8a30-4a57-9cfc-913c4a6c1365", null, "user", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Services_IdSerivce",
                table: "Offers",
                column: "IdSerivce",
                principalTable: "Services",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Services_IdSerivce",
                table: "Offers");

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

            migrationBuilder.AlterColumn<int>(
                name: "IdSerivce",
                table: "Offers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0167256a-e89d-451e-8fb9-eddd6e8b7967", null, "employee", "EMPLOYEE" },
                    { "977b385a-0531-43f3-9b3c-c44a3f0b6e0b", null, "user", "USER" },
                    { "bfa2d3cd-4316-43fa-9733-4e9f297e3ebf", null, "manager", "MANAGER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Services_IdSerivce",
                table: "Offers",
                column: "IdSerivce",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
