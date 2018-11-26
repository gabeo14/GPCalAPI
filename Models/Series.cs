using System.Collections.Generic;

namespace GPCalAPI.Models
{
  public class Series
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Event> Events { get; set; } = new List<Event>();

    public List<UserPref> UserPrefs { get; set; } = new List<UserPref>();
  }
}