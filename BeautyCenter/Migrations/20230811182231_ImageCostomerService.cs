using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class ImageCostomerService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Images_ImageId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_ImageId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Services");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageArray",
                table: "Services",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageArray",
                table: "CostomerDets",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageArray",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ImageArray",
                table: "CostomerDets");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Services",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_ImageId",
                table: "Services",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Images_ImageId",
                table: "Services",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");
        }
    }
}
