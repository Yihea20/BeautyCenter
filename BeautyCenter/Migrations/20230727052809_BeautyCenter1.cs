using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class BeautyCenter1 : Migration
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
                keyValue: "5ea10d2c-c713-4a28-966f-2a09f9583044");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4332370-82b4-470a-8d4c-6d8f06b7477b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f85fbe15-2f4e-4853-be69-88e5b065fa13");

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
                    { "8b0a5bc4-23fc-4ee7-99f9-734e13d97c68", null, "user", "USER" },
                    { "a0fb1cac-cac8-43d3-a2a3-2d6d3df8dea1", null, "employee", "EMPLOYEE" },
                    { "d3fca821-2061-4cfb-9633-5757cdeb9fa9", null, "manager", "MANAGER" }
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
                keyValue: "8b0a5bc4-23fc-4ee7-99f9-734e13d97c68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0fb1cac-cac8-43d3-a2a3-2d6d3df8dea1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3fca821-2061-4cfb-9633-5757cdeb9fa9");

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
                    { "5ea10d2c-c713-4a28-966f-2a09f9583044", null, "employee", "EMPLOYEE" },
                    { "e4332370-82b4-470a-8d4c-6d8f06b7477b", null, "manager", "MANAGER" },
                    { "f85fbe15-2f4e-4853-be69-88e5b065fa13", null, "user", "USER" }
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
