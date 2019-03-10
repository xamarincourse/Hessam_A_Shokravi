using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW2
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();

      BindingContext = new Context
      {
        Flight = new Context.FlightInfo
        {
          BoardingTime = new DateTime(2019, 1, 1, 20, 20, 0),
          BoardingGate = "B79",
          Departure = "SFO",
          Arrival = "LAX",
          Term = 1,
          Gate = "A5",
          Seat = "5A",
          DepartureTime = new DateTime(2019, 1, 1, 13, 0, 0)
        },
        MenuItems = new List<Context.MenuItem>
        {
          new Context.MenuItem
          {
            Title = "FLIGHT DETAILS",
            ImageSource = ImageSource.FromResource("HW2.Images.PlaneIcon.png")
          },
          new Context.MenuItem
          {
            Title = "UPGRADE SEAT",
            ImageSource = ImageSource.FromResource("HW2.Images.ChairIcon.png")
          },
          new Context.MenuItem
          {
            Title = "CHECK BAGS",
            ImageSource = ImageSource.FromResource( "HW2.Images.BagIcon.png")
          },
          new Context.MenuItem
          {
            Title = "ENTERTAINMENT",
            ImageSource = ImageSource.FromResource("HW2.Images.EntertainmentIcon.png")
          },
          new Context.MenuItem
          {
            Title = "WATCH MOVIES",
            ImageSource = ImageSource.FromResource("HW2.Images.FilmIcon.png")
          },
          new Context.MenuItem
          {
            Title = "TICKETS",
            ImageSource = ImageSource.FromResource("HW2.Images.TicketsIcon.png")
          },
        }
      };
    }

    public class Context
    {
      public FlightInfo Flight { get; set; }
      public List<MenuItem> MenuItems { get; set; }

      public class FlightInfo
      {
        public DateTime BoardingTime { get; set; }
        public string BoardingGate { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public int Term { get; set; }
        public string Gate { get; set; }
        public string Seat { get; set; }
        public DateTime DepartureTime { get; set; }
      }
      public class MenuItem
      {
        public string Title { get; set; }
        public ImageSource ImageSource { get; set; }
      }
    }
  }
}
