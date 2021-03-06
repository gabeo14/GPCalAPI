﻿// <auto-generated />
using System;
using GPCalAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GPCalAPI.Migrations
{
    [DbContext(typeof(GPCalAPIContext))]
    [Migration("20181119215109_Baseline")]
    partial class Baseline
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GPCalAPI.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("SeriesId");

                    b.Property<string>("Title");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("SeriesId");

                    b.ToTable("Events");

                    b.HasData(
                        new { Id = -1, DateTime = new DateTime(2018, 3, 23, 1, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Australian GP", Type = "Free Practice 1" },
                        new { Id = -2, DateTime = new DateTime(2019, 3, 23, 5, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Australian GP", Type = "Free Practice 2" },
                        new { Id = -3, DateTime = new DateTime(2019, 3, 24, 3, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Australian GP", Type = "Free Practice 3" },
                        new { Id = -4, DateTime = new DateTime(2019, 3, 24, 6, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Australian GP", Type = "Qualifying" },
                        new { Id = -5, DateTime = new DateTime(2019, 3, 25, 5, 10, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Australian GP", Type = "Race" },
                        new { Id = -6, DateTime = new DateTime(2019, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Bahrain GP", Type = "Free Practice 1" },
                        new { Id = -7, DateTime = new DateTime(201, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Bahrain GP", Type = "Free Practice 2" },
                        new { Id = -8, DateTime = new DateTime(2018, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Bahrain GP", Type = "Free Practice 3" },
                        new { Id = -9, DateTime = new DateTime(2018, 4, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Bahrain GP", Type = "Qualifying" },
                        new { Id = -10, DateTime = new DateTime(2018, 4, 8, 15, 10, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Bahrain GP", Type = "Race" },
                        new { Id = -11, DateTime = new DateTime(2018, 4, 13, 2, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Chinese GP", Type = "Free Practice 1" },
                        new { Id = -12, DateTime = new DateTime(2018, 4, 13, 6, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Chinese GP", Type = "Free Practice 2" },
                        new { Id = -13, DateTime = new DateTime(2018, 4, 14, 3, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Chinese GP", Type = "Free Practice 3" },
                        new { Id = -14, DateTime = new DateTime(2018, 4, 14, 6, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Chinese GP", Type = "Qualifying" },
                        new { Id = -15, DateTime = new DateTime(2018, 4, 15, 6, 10, 0, 0, DateTimeKind.Unspecified), SeriesId = -1, Title = "Chinese GP", Type = "Race" },
                        new { Id = -16, DateTime = new DateTime(2018, 3, 16, 11, 45, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Qatar GP", Type = "Free Practice 1" },
                        new { Id = -17, DateTime = new DateTime(2018, 3, 16, 16, 5, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Qatar GP", Type = "Free Practice 2" },
                        new { Id = -18, DateTime = new DateTime(2018, 3, 17, 11, 35, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Qatar GP", Type = "Free Practice 3" },
                        new { Id = -19, DateTime = new DateTime(2018, 3, 17, 15, 40, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Qatar GP", Type = "Free Practice 4" },
                        new { Id = -20, DateTime = new DateTime(2018, 3, 17, 16, 20, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Qatar GP", Type = "Qualifying 1" },
                        new { Id = -21, DateTime = new DateTime(2018, 3, 17, 16, 45, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Qatar GP", Type = "Qualifying 2" },
                        new { Id = -22, DateTime = new DateTime(2018, 3, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Qatar GP", Type = "Race" },
                        new { Id = -23, DateTime = new DateTime(2018, 4, 6, 11, 55, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Argentina GP", Type = "Free Practice 1" },
                        new { Id = -24, DateTime = new DateTime(2018, 4, 6, 18, 5, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Argentina GP", Type = "Free Practice 2" },
                        new { Id = -25, DateTime = new DateTime(2018, 4, 7, 13, 55, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Argentina GP", Type = "Free Practice 3" },
                        new { Id = -26, DateTime = new DateTime(2018, 4, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Argentina GP", Type = "Free Practice 4" },
                        new { Id = -27, DateTime = new DateTime(2018, 4, 7, 18, 10, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Argentina GP", Type = "Qualifying 1" },
                        new { Id = -28, DateTime = new DateTime(2018, 4, 7, 18, 35, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Argentina GP", Type = "Qualifying 2" },
                        new { Id = -29, DateTime = new DateTime(2018, 4, 8, 18, 20, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "Argentina GP", Type = "Race" },
                        new { Id = -30, DateTime = new DateTime(2018, 4, 20, 14, 55, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "American GP", Type = "Free Practice 1" },
                        new { Id = -31, DateTime = new DateTime(2018, 4, 20, 19, 5, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "American GP", Type = "Free Practice 2" },
                        new { Id = -32, DateTime = new DateTime(2018, 4, 21, 14, 55, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "American GP", Type = "Free Practice 3" },
                        new { Id = -33, DateTime = new DateTime(2018, 4, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "American GP", Type = "Free Practice 4" },
                        new { Id = -34, DateTime = new DateTime(2018, 4, 21, 19, 10, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "American GP", Type = "Qualifying 1" },
                        new { Id = -35, DateTime = new DateTime(2018, 4, 21, 19, 35, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "American GP", Type = "Qualifying 2" },
                        new { Id = -36, DateTime = new DateTime(2018, 4, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -5, Title = "American GP", Type = "Race" },
                        new { Id = -37, DateTime = new DateTime(2018, 3, 9, 15, 20, 0, 0, DateTimeKind.Unspecified), SeriesId = -4, Title = "St. Pete GP", Type = "Practice 1" },
                        new { Id = -38, DateTime = new DateTime(2018, 3, 9, 19, 10, 0, 0, DateTimeKind.Unspecified), SeriesId = -4, Title = "St. Pete GP", Type = "Practice 2" },
                        new { Id = -39, DateTime = new DateTime(2018, 3, 10, 15, 10, 0, 0, DateTimeKind.Unspecified), SeriesId = -4, Title = "St. Pete GP", Type = "Practice 3" },
                        new { Id = -40, DateTime = new DateTime(2018, 3, 10, 18, 20, 0, 0, DateTimeKind.Unspecified), SeriesId = -4, Title = "St. Pete GP", Type = "Qualifying 1" },
                        new { Id = -41, DateTime = new DateTime(2018, 3, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), SeriesId = -4, Title = "St. Pete GP", Type = "Qualifying 2" },
                        new { Id = -42, DateTime = new DateTime(2018, 3, 10, 19, 20, 0, 0, DateTimeKind.Unspecified), SeriesId = -4, Title = "St. Pete GP", Type = "Qualifying 3" },
                        new { Id = -43, DateTime = new DateTime(2018, 3, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), SeriesId = -4, Title = "St. Pete GP", Type = "Race" }
                    );
                });

            modelBuilder.Entity("GPCalAPI.Models.Series", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Series");

                    b.HasData(
                        new { Id = -1, Name = "Formula 1" },
                        new { Id = -2, Name = "Formula E" },
                        new { Id = -3, Name = "World Endurance Championship" },
                        new { Id = -4, Name = "Indy Car" },
                        new { Id = -5, Name = "MotoGP" }
                    );
                });

            modelBuilder.Entity("GPCalAPI.Models.UserPref", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SeriesId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("SeriesId");

                    b.ToTable("UserPref");
                });

            modelBuilder.Entity("GPCalAPI.Models.Event", b =>
                {
                    b.HasOne("GPCalAPI.Models.Series", "Series")
                        .WithMany()
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GPCalAPI.Models.UserPref", b =>
                {
                    b.HasOne("GPCalAPI.Models.Series", "Series")
                        .WithMany()
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
