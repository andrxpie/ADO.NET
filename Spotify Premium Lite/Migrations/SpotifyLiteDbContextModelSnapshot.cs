﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spotify_Premium_Lite;

#nullable disable

namespace Spotify_Premium_Lite.Migrations
{
    [DbContext(typeof(SpotifyLiteDbContext))]
    partial class SpotifyLiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.Property<int>("PlaylistsId")
                        .HasColumnType("int");

                    b.Property<int>("TracksId")
                        .HasColumnType("int");

                    b.HasKey("PlaylistsId", "TracksId");

                    b.HasIndex("TracksId");

                    b.ToTable("PlaylistTrack");
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Listens")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            Description = "Single",
                            Listens = 4324156,
                            Name = "Neon Blade",
                            Picture = "https://i.scdn.co/image/ab67616d00001e0233364d6b6fd36894f1a3b506"
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            Listens = 927523,
                            Name = "chaxs thexry",
                            Picture = "https://i.scdn.co/image/ab67616d00001e0287a9495fd25dfa23e68a9e66"
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 2,
                            Listens = 734634,
                            Name = "PSYCHX",
                            Picture = "https://i.scdn.co/image/ab67616d00001e02be40ee61162ba11a45328795"
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 3,
                            Description = "Faster than Light",
                            Listens = 5,
                            Name = "Burst",
                            Picture = "https://th.bing.com/th?id=OSK.HNYBhQCCy91WIww1kvaZoVZmKw7TBLm9c8pWdTBe305ZU5U&w=122&h=122&c=7&o=6&oif=webp&pid=SANGAM"
                        });
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Listens")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Subscriptions")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Description = "UA Phonkmaker",
                            Listens = 312412,
                            Name = "Eduard",
                            Nickname = "MoonDeity",
                            Subscriptions = 0,
                            Surname = "Vodovozyk"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            Description = "DEMOCRATION",
                            Listens = 51523412,
                            Name = "Marius",
                            Nickname = "Scarlxrd",
                            Subscriptions = 0,
                            Surname = "Listhrop"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 3,
                            Listens = 142,
                            Name = "Donkey",
                            Nickname = "Stark",
                            Subscriptions = 0,
                            Surname = "Downey"
                        });
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Category", b =>
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
                            Name = "Instrumental"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Race"
                        });
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Country", b =>
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
                            Name = "UK"
                        });
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatorId");

                    b.ToTable("Playlists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatorId = 1,
                            Description = "For fight",
                            IsPublic = false,
                            Name = "Phonk"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatorId = 1,
                            Description = "Sleep",
                            IsPublic = true,
                            Name = "Good night"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatorId = 2,
                            Description = "Races",
                            IsPublic = true,
                            Name = "FASTER"
                        });
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<int>("Listens")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("UserId");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Duration = new TimeSpan(0, 0, 2, 30, 0),
                            Listens = 15523064,
                            Name = "Neon Blade",
                            Picture = "https://i.scdn.co/image/ab67616d00001e0233364d6b6fd36894f1a3b506"
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 1,
                            Duration = new TimeSpan(0, 0, 1, 45, 0),
                            Listens = 5553236,
                            Name = "Neon Blade 2",
                            Picture = "https://i.scdn.co/image/ab67616d00001e0200c44aebaaa37ef468709f01"
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 2,
                            Duration = new TimeSpan(0, 0, 3, 40, 0),
                            Listens = 35275927,
                            Name = "King, Scar.",
                            Picture = "https://i.scdn.co/image/ab67616d00001e0287a9495fd25dfa23e68a9e66"
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 2,
                            Duration = new TimeSpan(0, 0, 3, 32, 0),
                            Listens = 5835259,
                            Name = "Chain$Aw",
                            Picture = "https://i.scdn.co/image/ab67616d00001e0287a9495fd25dfa23e68a9e66"
                        },
                        new
                        {
                            Id = 5,
                            AlbumId = 3,
                            Duration = new TimeSpan(0, 0, 2, 13, 0),
                            Listens = 734574,
                            Name = "MISS ME?",
                            Picture = "https://i.scdn.co/image/ab67616d00001e02be40ee61162ba11a45328795"
                        });
                });

            modelBuilder.Entity("Spotify_Premium_Lite.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "super@google.com",
                            Login = "login1",
                            Nickname = "greatestGoogleUser",
                            Password = "password1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "repus@elgoog.moc",
                            Login = "1nigol",
                            Nickname = "resUelgooGtsetaerg",
                            Password = "1drowssap"
                        },
                        new
                        {
                            Id = 3,
                            Login = "log",
                            Nickname = "s1mple",
                            Password = "pas"
                        });
                });

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.HasOne("Spotify_Premium_Lite.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify_Premium_Lite.Track", null)
                        .WithMany()
                        .HasForeignKey("TracksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Album", b =>
                {
                    b.HasOne("Spotify_Premium_Lite.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Artist", b =>
                {
                    b.HasOne("Spotify_Premium_Lite.Country", "Country")
                        .WithMany("Artists")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Playlist", b =>
                {
                    b.HasOne("Spotify_Premium_Lite.Category", "Category")
                        .WithMany("Playlists")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify_Premium_Lite.User", "Creator")
                        .WithMany("Playlists")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Track", b =>
                {
                    b.HasOne("Spotify_Premium_Lite.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify_Premium_Lite.User", null)
                        .WithMany("Favourite")
                        .HasForeignKey("UserId");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Category", b =>
                {
                    b.Navigation("Playlists");
                });

            modelBuilder.Entity("Spotify_Premium_Lite.Country", b =>
                {
                    b.Navigation("Artists");
                });

            modelBuilder.Entity("Spotify_Premium_Lite.User", b =>
                {
                    b.Navigation("Favourite");

                    b.Navigation("Playlists");
                });
#pragma warning restore 612, 618
        }
    }
}
