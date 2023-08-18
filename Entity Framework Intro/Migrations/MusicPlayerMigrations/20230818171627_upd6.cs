using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entity_Framework_Intro.Migrations.MusicPlayerMigrations
{
    /// <inheritdoc />
    public partial class upd6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumnId",
                table: "Tracks");

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "GenreId", "Name", "Rating", "Year" },
                values: new object[] { 1, 1, 1, "Debuti of Soul", 10, 2023 });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "Duration", "Listens", "Lyrics", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, 1, new TimeSpan(0, 0, 2, 30, 0), 15, null, "MOVEMENT", 10 },
                    { 2, 1, new TimeSpan(0, 0, 1, 10, 0), 1, null, "POOR", 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "AlbumnId",
                table: "Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
