using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo1.Data.Migrations
{
    /// <inheritdoc />
    public partial class fff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepoID",
                table: "FisDestekler");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepoID",
                table: "FisDestekler",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
