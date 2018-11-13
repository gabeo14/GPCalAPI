using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotoCalAPI.Models;

namespace MotoCalAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EventsController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetEvents()
    {
      var db = new MotoCalAPIContext();

      return Ok(db.Events.Include(i => i.Series));
    }
    [HttpGet("{id}")]
    public ActionResult GetEventsBySeries([FromRoute] int id)
    {
      var db = new MotoCalAPIContext();
      return Ok(db.Events
      .Include(i => i.Series).Where(w => w.SeriesId == id));
    }
  }
}