using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_Intro.Migrations.MusicPlayerMigrations
{
    /// <inheritdoc />
    public partial class upd3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albumns_Artists_ArtistId",
                table: "Albumns");

            migrationBuilder.DropForeignKey(
                name: "FK_Albumns_Genres_GenreId",
                table: "Albumns");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albumns_AlbumnId",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albumns",
                table: "Albumns");

            migrationBuilder.RenameTable(
                name: "Albumns",
                newName: "Albums");

            migrationBuilder.RenameIndex(
                name: "IX_Albumns_GenreId",
                table: "Albums",
                newName: "IX_Albums_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Albumns_ArtistId",
                table: "Albums",
                newName: "IX_Albums_ArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albums",
                table: "Albums",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Genres_GenreId",
                table: "Albums",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_AlbumnId",
                table: "Tracks",
                column: "AlbumnId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Genres_GenreId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_AlbumnId",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Albums",
                table: "Albums");

            migrationBuilder.RenameTable(
                name: "Albums",
                newName: "Albumns");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_GenreId",
                table: "Albumns",
                newName: "IX_Albumns_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_ArtistId",
                table: "Albumns",
                newName: "IX_Albumns_ArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Albumns",
                table: "Albumns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Albumns_Artists_ArtistId",
                table: "Albumns",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Albumns_Genres_GenreId",
                table: "Albumns",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albumns_AlbumnId",
                table: "Tracks",
                column: "AlbumnId",
                principalTable: "Albumns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
