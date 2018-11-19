using System;

namespace GPCalAPI.Models
{
  public class UserPref
  {
    public int Id { get; set; }
    public string UserId { get; set; }
    public int SeriesId { get; set; }

    public Series Series { get; set; }
  }
}