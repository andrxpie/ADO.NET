using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_Intro.Migrations.MusicPlayerMigrations
{
    /// <inheritdoc />
    public partial class upd8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "CountryId", "Surname" },
                values: new object[] { 2, 2, "MrBeast" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "CountryId", "Surname" },
                values: new object[] { 1, 1, "MoonDiety" });
        }
    }
}
