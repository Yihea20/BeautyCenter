using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class BeautyCenterDb7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1134e6d0-fb0a-4b6e-8325-634e1622e35d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a403d63-7b42-40a4-804a-d28d60fd75ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac19b40a-5bb3-4bd4-9350-2e8346cd2801");

            migrationBuilder.AddColumn<DateTime>(
                name: "CloseTime",
                table: "Centers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OpenTime",
                table: "Centers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "011e9e56-c480-4b13-9a86-05e1dbee52e7", null, "employee", "EMPLOYEE" },
                    { "3ba10142-23ff-4905-bf87-297fb2763787", null, "manager", "MANAGER" },
                    { "ac56de98-2692-4f32-a27b-12289b8150a4", null, "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "011e9e56-c480-4b13-9a86-05e1dbee52e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ba10142-23ff-4905-bf87-297fb2763787");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac56de98-2692-4f32-a27b-12289b8150a4");

            migrationBuilder.DropColumn(
                name: "CloseTime",
                table: "Centers");

            migrationBuilder.DropColumn(
                name: "OpenTime",
                table: "Centers");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1134e6d0-fb0a-4b6e-8325-634e1622e35d", null, "user", "USER" },
                    { "1a403d63-7b42-40a4-804a-d28d60fd75ae", null, "employee", "EMPLOYEE" },
                    { "ac19b40a-5bb3-4bd4-9350-2e8346cd2801", null, "manager", "MANAGER" }
                });
        }
    }
}
