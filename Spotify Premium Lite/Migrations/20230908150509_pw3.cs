using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spotify_Premium_Lite.Migrations
{
    /// <inheritdoc />
    public partial class pw3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light. Faster than Light.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Faster than Light");
        }
    }
}
