using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo1.Data.Migrations
{
    /// <inheritdoc />
    public partial class urunmiktarsilindi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StokMiktari",
                table: "Urunler");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StokMiktari",
                table: "Urunler",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
