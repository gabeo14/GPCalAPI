using System.Collections.Generic;

namespace MotoCalAPI.Models
{
  public class Series
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Event> Events { get; set; } = new List<Event>();
  }
}