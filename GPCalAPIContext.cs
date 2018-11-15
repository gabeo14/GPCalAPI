using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using GPCalAPI.Models;

namespace GPCalAPI
{
  public partial class GPCalAPIContext : DbContext
  {
    public GPCalAPIContext()
    {
    }

    public GPCalAPIContext(DbContextOptions<GPCalAPIContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        optionsBuilder.UseNpgsql("server=localhost;database=MotoCalAPI");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Series>().HasData(
          new Series { Id = -1, Name = "Formula 1" },
          new Series { Id = -2, Name = "Formula E" },
          new Series { Id = -3, Name = "World Endurance Championship" },
          new Series { Id = -4, Name = "Indy Car" },
          new Series { Id = -5, Name = "MotoGP" }
      );
      modelBuilder.Entity<Event>().HasData(
          new Event { Id = -1, SeriesId = -1, Type = "Free Practice 1", Title = "Australian GP", DateTime = new DateTime(2018, 03, 23, 01, 00, 00) },
          new Event { Id = -2, SeriesId = -1, Type = "Free Practice 2", Title = "Australian GP", DateTime = new DateTime(2019, 03, 23, 05, 00, 00) },
          new Event { Id = -3, SeriesId = -1, Type = "Free Practice 3", Title = "Australian GP", DateTime = new DateTime(2019, 03, 24, 03, 00, 00) },
          new Event { Id = -4, SeriesId = -1, Type = "Qualifying", Title = "Australian GP", DateTime = new DateTime(2019, 03, 24, 06, 00, 00) },
          new Event { Id = -5, SeriesId = -1, Type = "Race", Title = "Australian GP", DateTime = new DateTime(2019, 03, 25, 05, 10, 00) },
          new Event { Id = -6, SeriesId = -1, Type = "Free Practice 1", Title = "Bahrain GP", DateTime = new DateTime(2019, 04, 06, 11, 00, 00) },
          new Event { Id = -7, SeriesId = -1, Type = "Free Practice 2", Title = "Bahrain GP", DateTime = new DateTime(201, 04, 06, 15, 00, 00) },
          new Event { Id = -8, SeriesId = -1, Type = "Free Practice 3", Title = "Bahrain GP", DateTime = new DateTime(2018, 04, 07, 12, 00, 00) },
          new Event { Id = -9, SeriesId = -1, Type = "Qualifying", Title = "Bahrain GP", DateTime = new DateTime(2018, 04, 07, 15, 00, 00) },
          new Event { Id = -10, SeriesId = -1, Type = "Race", Title = "Bahrain GP", DateTime = new DateTime(2018, 04, 08, 15, 10, 00) },
          new Event { Id = -11, SeriesId = -1, Type = "Free Practice 1", Title = "Chinese GP", DateTime = new DateTime(2018, 04, 13, 02, 00, 00) },
          new Event { Id = -12, SeriesId = -1, Type = "Free Practice 2", Title = "Chinese GP", DateTime = new DateTime(2018, 04, 13, 06, 00, 00) },
          new Event { Id = -13, SeriesId = -1, Type = "Free Practice 3", Title = "Chinese GP", DateTime = new DateTime(2018, 04, 14, 03, 00, 00) },
          new Event { Id = -14, SeriesId = -1, Type = "Qualifying", Title = "Chinese GP", DateTime = new DateTime(2018, 04, 14, 06, 00, 00) },
          new Event { Id = -15, SeriesId = -1, Type = "Race", Title = "Chinese GP", DateTime = new DateTime(2018, 04, 15, 06, 10, 00) },
          new Event { Id = -16, SeriesId = -5, Type = "Free Practice 1", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 16, 11, 45, 00) },
          new Event { Id = -17, SeriesId = -5, Type = "Free Practice 2", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 16, 16, 05, 00) },
          new Event { Id = -18, SeriesId = -5, Type = "Free Practice 3", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 17, 11, 35, 00) },
          new Event { Id = -19, SeriesId = -5, Type = "Free Practice 4", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 17, 15, 40, 00) },
          new Event { Id = -20, SeriesId = -5, Type = "Qualifying 1", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 17, 16, 20, 00) },
          new Event { Id = -21, SeriesId = -5, Type = "Qualifying 2", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 17, 16, 45, 00) },
          new Event { Id = -22, SeriesId = -5, Type = "Race", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 18, 16, 00, 00) },
          new Event { Id = -23, SeriesId = -5, Type = "Free Practice 1", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 06, 11, 55, 00) },
          new Event { Id = -24, SeriesId = -5, Type = "Free Practice 2", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 06, 18, 05, 00) },
          new Event { Id = -25, SeriesId = -5, Type = "Free Practice 3", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 07, 13, 55, 00) },
          new Event { Id = -26, SeriesId = -5, Type = "Free Practice 4", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 07, 17, 30, 00) },
          new Event { Id = -27, SeriesId = -5, Type = "Qualifying 1", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 07, 18, 10, 00) },
          new Event { Id = -28, SeriesId = -5, Type = "Qualifying 2", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 07, 18, 35, 00) },
          new Event { Id = -29, SeriesId = -5, Type = "Race", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 08, 18, 20, 00) },
          new Event { Id = -30, SeriesId = -5, Type = "Free Practice 1", Title = "American GP", DateTime = new DateTime(2018, 04, 20, 14, 55, 00) },
          new Event { Id = -31, SeriesId = -5, Type = "Free Practice 2", Title = "American GP", DateTime = new DateTime(2018, 04, 20, 19, 05, 00) },
          new Event { Id = -32, SeriesId = -5, Type = "Free Practice 3", Title = "American GP", DateTime = new DateTime(2018, 04, 21, 14, 55, 00) },
          new Event { Id = -33, SeriesId = -5, Type = "Free Practice 4", Title = "American GP", DateTime = new DateTime(2018, 04, 21, 18, 30, 00) },
          new Event { Id = -34, SeriesId = -5, Type = "Qualifying 1", Title = "American GP", DateTime = new DateTime(2018, 04, 21, 19, 10, 00) },
          new Event { Id = -35, SeriesId = -5, Type = "Qualifying 2", Title = "American GP", DateTime = new DateTime(2018, 04, 21, 19, 35, 00) },
          new Event { Id = -36, SeriesId = -5, Type = "Race", Title = "American GP", DateTime = new DateTime(2018, 04, 22, 19, 00, 00) },
          new Event { Id = -37, SeriesId = -4, Type = "Practice 1", Title = "St. Pete GP", DateTime = new DateTime(2018, 03, 09, 15, 20, 00) },
          new Event { Id = -38, SeriesId = -4, Type = "Practice 2", Title = "St. Pete GP", DateTime = new DateTime(2018, 03, 09, 19, 10, 00) },
          new Event { Id = -39, SeriesId = -4, Type = "Practice 3", Title = "St. Pete GP", DateTime = new DateTime(2018, 03, 10, 15, 10, 00) },
          new Event { Id = -40, SeriesId = -4, Type = "Qualifying 1", Title = "St. Pete GP", DateTime = new DateTime(2018, 03, 10, 18, 20, 00) },
          new Event { Id = -41, SeriesId = -4, Type = "Qualifying 2", Title = "St. Pete GP", DateTime = new DateTime(2018, 03, 10, 19, 00, 00) },
          new Event { Id = -42, SeriesId = -4, Type = "Qualifying 3", Title = "St. Pete GP", DateTime = new DateTime(2018, 03, 10, 19, 20, 00) },
          new Event { Id = -43, SeriesId = -4, Type = "Race", Title = "St. Pete GP", DateTime = new DateTime(2018, 03, 11, 16, 30, 00) }



      );
    }

    public DbSet<Series> Series { get; set; }
    public DbSet<Event> Events { get; set; }
  }
}
