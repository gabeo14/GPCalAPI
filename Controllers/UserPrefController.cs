using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GPCalAPI.Models;
using GPCalAPI.ViewModels;
using Microsoft.AspNetCore.Authorization;


namespace GPCalAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class UserPrefController : ControllerBase
  {
    [HttpPost]
    public ActionResult<UserPref> Post([FromBody] UserPref followed)
    {
      var db = new GPCalAPIContext();
      var userId = User.Claims.First(f => f.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;
      followed.UserId = userId;
      db.UserPref.Add(followed);
      db.SaveChanges();
      return Ok(followed);

    }

    [HttpDelete("{SeriesId}")]
    public ActionResult<UserPref> Delete([FromRoute] int seriesId)
    {
      var db = new GPCalAPIContext();
      var userId = User.Claims.First(f => f.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;
      var currentPref = db.UserPref.FirstOrDefault(f => f.UserId == userId && f.SeriesId == seriesId);
      db.UserPref.Remove(currentPref);
      db.SaveChanges();
      return Ok(new { currentPref, seriesId });
    }

    [HttpGet]
    public ActionResult GetEventsByUser()
    {
      var db = new GPCalAPIContext();
      var userId = User.Claims.First(f => f.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;

      var userSeriesId = db.UserPref
                .Include(i => i.Series)
                .Where(w => w.UserId == userId)
                .Select(s => s.SeriesId);

      var rv = db.Events
      .Include(i => i.Series)
        .Where(w => userSeriesId.Any(a => a == w.SeriesId))
        .OrderBy(o => o.DateAndTime)
        .Select(s => new UserSeries(s, s.Series));

      return Ok(rv);

      // return Ok(db.UserPref
      //           .Include(i => i.Series)
      //           .Include(i => i.Series.Events)
      //           .Where(w => w.UserId == userId)
      //           .ToList()
      //           .SelectMany(s => s.Series.Events.Select(ent => new UserSeries(ent, s.Series))));


      //.OrderBy(o => o.EventTime));
    }

    [HttpGet("series")]
    public ActionResult GetSeriesByUser()
    {
      var db = new GPCalAPIContext();
      var userId = User.Claims.First(f => f.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;
      return Ok(db.UserPref
                .Where(w => w.UserId == userId)
      );
    }
  }
}