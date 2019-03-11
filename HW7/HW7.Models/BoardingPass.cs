using System;

namespace HW7.Models
{
  public class BoardingPass
  {
    public DateTime BoardingTime { get; set; }
    public string BoardingGate { get; set; }
    public string Departure { get; set; }
    public string Arrival { get; set; }
    public int Term { get; set; }
    public string Gate { get; set; }
    public string Seat { get; set; }
    public DateTime DepartureTime { get; set; }
    public bool IsDelayed { get; set; }
  }
}
