using System;

namespace GPCalAPI.Models
{
  public class Event
  {
    public int Id { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }
    public DateTime DateTime { get; set; }
    public int SeriesId { get; set; }
    public Series Series { get; set; }
  }
}