using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spotify_Premium_Lite.Migrations
{
    /// <inheritdoc />
    public partial class _1pw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Picture",
                value: "images\\Neon Blade.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "Picture",
                value: "images\\chaxs thexry.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                column: "Picture",
                value: "images\\psychx.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4,
                column: "Picture",
                value: "images\\spotifyLite.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Picture",
                value: "https://i.scdn.co/image/ab67616d00001e0233364d6b6fd36894f1a3b506");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "Picture",
                value: "https://i.scdn.co/image/ab67616d00001e0287a9495fd25dfa23e68a9e66");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                column: "Picture",
                value: "https://i.scdn.co/image/ab67616d00001e02be40ee61162ba11a45328795");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4,
                column: "Picture",
                value: "https://th.bing.com/th?id=OSK.HNYBhQCCy91WIww1kvaZoVZmKw7TBLm9c8pWdTBe305ZU5U&w=122&h=122&c=7&o=6&oif=webp&pid=SANGAM");
        }
    }
}
