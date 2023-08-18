﻿// <auto-generated />
using System;
using Entity_Framework_Intro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entity_Framework_Intro.Migrations.MusicPlayerMigrations
{
    [DbContext(typeof(MusicPlayer))]
    [Migration("20230818160827_upd4")]
    partial class upd4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity_Framework_Intro.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Entity_Framework_Intro.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Entity_Framework_Intro.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Phonk"
                        },
                        new
                        {
                            Id = 2,
                            Name = "My Favourite"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sleep"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Work"
                        });
                });

            modelBuilder.Entity("Entity_Framework_Intro.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = 2,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Poland"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Switzerland"
                        },
                        new
                        {
                            Id = 5,
                            Name = "German"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Turkey"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Japan"
                        },
                        new
                        {
                            Id = 8,
                            Name = "China"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Greenland"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Iceland"
                        },
                        new
                        {
                            Id = 11,
                            Name = "UK"
                        });
                });

            modelBuilder.Entity("Entity_Framework_Intro.Entities.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("Entity_Framework_Intro.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Phonk"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rock"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hip-Hop & Rap"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Country"
                        },
                        new
                        {
                            Id = 5,
                            Name = "R&B"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Folk"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Jazz"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Heavy Metal"
                        },
                        new
                        {
                            Id = 9,
                            Name = "EDM"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Soul"
                        });
                });

            modelBuilder.Entity("Entity_Framework_Intro.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlbumnId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("Listens")
                        .HasColumnType("int");

                    b.Property<string>("Lyrics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlbumnId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.Property<int>("PlaylistsId")
                        .HasColumnType("int");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("PlaylistsId", "TrackId");

                    b.HasIndex("TrackId");

                    b.ToTable("PlaylistTrack");
                });

            modelBuilder.Entity("Entity_Framework_Intro.Album", b =>
                {
                    b.HasOne("Entity_Framework_Intro.Entities.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity_Framework_Intro.Genre", "Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Entity_Framework_Intro.Entities.Artist", b =>
                {
                    b.HasOne("Entity_Framework_Intro.Entities.Country", "Country")
                        .WithMany("Artists")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Entity_Framework_Intro.Entities.Playlist", b =>
                {
                    b.HasOne("Entity_Framework_Intro.Entities.Category", "Category")
                        .WithMany("Playlists")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entity_Framework_Intro.Track", b =>
                {
                    b.HasOne("Entity_Framework_Intro.Album", "Albumn")
                        .WithMany("Music")
                        .HasForeignKey("AlbumnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Albumn");
                });

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.HasOne("Entity_Framework_Intro.Entities.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity_Framework_Intro.Track", null)
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity_Framework_Intro.Album", b =>
                {
                    b.Navigation("Music");
                });

            modelBuilder.Entity("Entity_Framework_Intro.Entities.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Entity_Framework_Intro.Entities.Category", b =>
                {
                    b.Navigation("Playlists");
                });

            modelBuilder.Entity("Entity_Framework_Intro.Entities.Country", b =>
                {
                    b.Navigation("Artists");
                });

            modelBuilder.Entity("Entity_Framework_Intro.Genre", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
