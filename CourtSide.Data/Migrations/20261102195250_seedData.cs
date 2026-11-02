using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourtSide.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Qizhong Forest Sports City Arena   (Shanghai Masters)");

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Sportpaleis Antwerp / Lotto Arena    (European Open)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Qizhong Forest Sports City Arena   ( Shanghai Masters)");

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Sportpaleis Antwerp / Lotto Arena    ( European Open)");
        }
    }
}
