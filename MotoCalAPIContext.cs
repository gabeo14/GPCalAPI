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
    }
  }
}
