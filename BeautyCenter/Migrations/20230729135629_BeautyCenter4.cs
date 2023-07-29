using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyCenter.Migrations
{
    /// <inheritdoc />
    public partial class BeautyCenter4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Dis",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dis",
                table: "Images");
        }
    }
}
