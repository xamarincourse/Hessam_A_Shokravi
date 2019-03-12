using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HW7.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW7.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [AllowAnonymous]
  public class BoardingPassController : ControllerBase
  {
    [HttpGet("{id}")]
    public ActionResult<BoardingPass> Get(string id)
    {
      Thread.Sleep(4000);
      if (id == "12345") return new BoardingPass
      {
        BoardingTime = new DateTime(2019, 1, 1, 20, 20, 0),
        BoardingGate = "B79",
        Departure = "SFO",
        Arrival = "LAX",
        Term = 1,
        Gate = "A5",
        Seat = "5A",
        DepartureTime = new DateTime(2019, 1, 1, 13, 0, 0),
        IsDelayed = true
      };
      throw new Exception("Boarding pass has not been found.");
    }
  }
}