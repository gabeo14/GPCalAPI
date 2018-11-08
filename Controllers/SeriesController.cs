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
  public class SeriesController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetSeries()
    {
      var db = new MotoCalAPIContext();
      return Ok(db.Series);
    }
  }
}