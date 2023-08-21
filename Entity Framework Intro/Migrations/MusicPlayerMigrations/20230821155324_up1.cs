using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_Intro.Migrations.MusicPlayerMigrations
{
    /// <inheritdoc />
    public partial class up1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Surname",
                value: "MoonDeity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Surname",
                value: "MoonDiety");
        }
    }
}
