using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GPCalAPI.Models;

namespace GPCalAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SeriesController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetSeries()
    {
      var db = new GPCalAPIContext();
      return Ok(db.Series);
    }
  }
}