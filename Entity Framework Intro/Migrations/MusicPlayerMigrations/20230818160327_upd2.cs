using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_Intro.Migrations.MusicPlayerMigrations
{
    /// <inheritdoc />
    public partial class upd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Listens",
                table: "Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Lyrics",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Listens",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Lyrics",
                table: "Tracks");
        }
    }
}
