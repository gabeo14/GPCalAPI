using System;
using GPCalAPI.Models;

namespace GPCalAPI.ViewModels
{
  public class UserSeries
  {
    public string SeriesName { get; set; }
    public int SeriesId { get; set; }
    public int EventId { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }
    public DateTime EventTime { get; set; }


    public UserSeries(Event events, Series series)
    {
      this.SeriesId = series.Id;
      this.EventId = events.Id;
      this.Type = events.Type;
      this.Title = events.Title;
      this.EventTime = events.DateAndTime;
      this.SeriesName = series.Name;
      //TODO: fill in the rest of the properties 
    }
  }
}