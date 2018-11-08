using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MotoCalAPI.Models;

namespace MotoCalAPI
{
  public partial class MotoCalAPIContext : DbContext
  {
    public MotoCalAPIContext()
    {
    }

    public MotoCalAPIContext(DbContextOptions<MotoCalAPIContext> options)
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
          new Event { SeriesId = -1, Type = "Free Practice 1", Title = "Australian GP", DateTime = new DateTime(2018, 03, 23, 01, 00, 00) },
          new Event { SeriesId = -1, Type = "Free Practice 2", Title = "Australian GP", DateTime = new DateTime(2019, 03, 23, 05, 00, 00) },
          new Event { SeriesId = -1, Type = "Free Practice 3", Title = "Australian GP", DateTime = new DateTime(2019, 03, 24, 03, 00, 00) },
          new Event { SeriesId = -1, Type = "Qualifying", Title = "Australian GP", DateTime = new DateTime(2019, 03, 24, 06, 00, 00) },
          new Event { SeriesId = -1, Type = "Race", Title = "Australian GP", DateTime = new DateTime(2019, 03, 25, 05, 10, 00) },
          new Event { SeriesId = -1, Type = "Free Practice 1", Title = "Bahrain GP", DateTime = new DateTime(2019, 04, 06, 11, 00, 00) },
          new Event { SeriesId = -1, Type = "Free Practice 2", Title = "Bahrain GP", DateTime = new DateTime(201, 04, 06, 15, 00, 00) },
          new Event { SeriesId = -1, Type = "Free Practice 3", Title = "Bahrain GP", DateTime = new DateTime(2018, 04, 07, 12, 00, 00) },
          new Event { SeriesId = -1, Type = "Qualifying", Title = "Bahrain GP", DateTime = new DateTime(2018, 04, 07, 15, 00, 00) },
          new Event { SeriesId = -1, Type = "Race", Title = "Bahrain GP", DateTime = new DateTime(2018, 04, 08, 15, 10, 00) },
          new Event { SeriesId = -1, Type = "Free Practice 1", Title = "Chinese GP", DateTime = new DateTime(2018, 04, 13, 02, 00, 00) },
          new Event { SeriesId = -1, Type = "Free Practice 2", Title = "Chinese GP", DateTime = new DateTime(2018, 04, 13, 06, 00, 00) },
          new Event { SeriesId = -1, Type = "Free Practice 3", Title = "Chinese GP", DateTime = new DateTime(2018, 04, 14, 03, 00, 00) },
          new Event { SeriesId = -1, Type = "Qualifying", Title = "Chinese GP", DateTime = new DateTime(2018, 04, 14, 06, 00, 00) },
          new Event { SeriesId = -1, Type = "Race", Title = "Chinese GP", DateTime = new DateTime(2018, 04, 15, 06, 10, 00) },
          new Event { SeriesId = -5, Type = "Free Practice 1", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 16, 11, 45, 00) },
          new Event { SeriesId = -5, Type = "Free Practice 2", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 16, 16, 05, 00) },
          new Event { SeriesId = -5, Type = "Free Practice 3", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 17, 11, 35, 00) },
          new Event { SeriesId = -5, Type = "Free Practice 4", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 17, 15, 40, 00) },
          new Event { SeriesId = -5, Type = "Qualifying 1", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 17, 16, 20, 00) },
          new Event { SeriesId = -5, Type = "Qualifying 2", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 17, 16, 45, 00) },
          new Event { SeriesId = -5, Type = "Race", Title = "Qatar GP", DateTime = new DateTime(2018, 03, 18, 16, 00, 00) },
          new Event { SeriesId = -5, Type = "Free Practice 1", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 06, 11, 55, 00) },
          new Event { SeriesId = -5, Type = "Free Practice 2", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 06, 18, 05, 00) },
          new Event { SeriesId = -5, Type = "Free Practice 3", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 07, 13, 55, 00) },
          new Event { SeriesId = -5, Type = "Free Practice 4", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 07, 17, 30, 00) },
          new Event { SeriesId = -5, Type = "Qualifying 1", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 07, 18, 10, 00) },
          new Event { SeriesId = -5, Type = "Qualifying 2", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 07, 18, 35, 00) },
          new Event { SeriesId = -5, Type = "Race", Title = "Argentina GP", DateTime = new DateTime(2018, 04, 08, 18, 20, 00) }



      )
    }

    public DbSet<Series> Series { get; set; }
  }
}
