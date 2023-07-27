using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_CostomerDets_CostomerDetId",
                table: "Services");

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

            migrationBuilder.AlterColumn<int>(
                name: "CostomerDetId",
                table: "Services",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "107acbbf-786a-4904-9014-00566c36e77e", null, "employee", "EMPLOYEE" },
                    { "1d2c0214-3a9c-4d79-b0ba-99944ed717a6", null, "user", "USER" },
                    { "28e64ba3-6459-4059-8104-92827347849e", null, "manager", "MANAGER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Services_CostomerDets_CostomerDetId",
                table: "Services",
                column: "CostomerDetId",
                principalTable: "CostomerDets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_CostomerDets_CostomerDetId",
                table: "Services");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "107acbbf-786a-4904-9014-00566c36e77e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d2c0214-3a9c-4d79-b0ba-99944ed717a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28e64ba3-6459-4059-8104-92827347849e");

            migrationBuilder.AlterColumn<int>(
                name: "CostomerDetId",
                table: "Services",
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
                    { "776fa1d5-11d1-47f7-88e9-443b73744dc7", null, "manager", "MANAGER" },
                    { "80fc4945-2493-4841-848c-b1aa113477ed", null, "user", "USER" },
                    { "ec39a200-571a-4316-a8aa-499150fffde8", null, "employee", "EMPLOYEE" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Services_CostomerDets_CostomerDetId",
                table: "Services",
                column: "CostomerDetId",
                principalTable: "CostomerDets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
