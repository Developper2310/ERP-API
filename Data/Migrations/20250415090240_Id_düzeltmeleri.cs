using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Demo1.Data.Migrations
{
    /// <inheritdoc />
    public partial class Id_düzeltmeleri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KullaniciRoller",
                table: "KullaniciRoller");

            migrationBuilder.DropIndex(
                name: "IX_KullaniciRoller_RolID",
                table: "KullaniciRoller");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "KullaniciRoller");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KullaniciRoller",
                table: "KullaniciRoller",
                columns: new[] { "RolID", "CalisanID" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KullaniciRoller",
                table: "KullaniciRoller");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "KullaniciRoller",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KullaniciRoller",
                table: "KullaniciRoller",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciRoller_RolID",
                table: "KullaniciRoller",
                column: "RolID");
        }
    }
}
