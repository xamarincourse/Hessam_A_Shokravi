using HW7.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HW2
{
  public class MainPageViewModel
  {
    public MainPageViewModel()
    {
      BoardingPass = new BoardingPass
      {
        BoardingTime = new DateTime(2019, 1, 1, 0, 0, 0),
        BoardingGate = "?",
        Departure = "???",
        Arrival = "???",
        Term = 0,
        Gate = "?",
        Seat = "?",
        DepartureTime = new DateTime(2019, 1, 1, 0, 0, 0),
        IsDelayed = false
      };

      BoardingPass = BoardingPassService.GetAsync("12345").Result;

      MenuItems = new List<MenuItem>
      {
        new MenuItem
        {
          Title = "FLIGHT DETAILS",
          ImageSource = ImageSource.FromResource("HW2.Images.PlaneIcon.png")
        },
        new MenuItem
        {
          Title = "UPGRADE SEAT",
          ImageSource = ImageSource.FromResource("HW2.Images.ChairIcon.png")
        },
        new MenuItem
        {
          Title = "CHECK BAGS",
          ImageSource = ImageSource.FromResource( "HW2.Images.BagIcon.png")
        },
        new MenuItem
        {
          Title = "ENTERTAINMENT",
          ImageSource = ImageSource.FromResource("HW2.Images.EntertainmentIcon.png")
        },
        new MenuItem
        {
          Title = "WATCH MOVIES",
          ImageSource = ImageSource.FromResource("HW2.Images.FilmIcon.png")
        },
        new MenuItem
        {
          Title = "TICKETS",
          ImageSource = ImageSource.FromResource("HW2.Images.TicketsIcon.png")
        },
      };
    }

    public BoardingPass BoardingPass { get; set; }
    public string BoardingPassIsDelayedText { get { return BoardingPass.IsDelayed ? "DELAYED" : "ON-TIME"; } }
    public Color BoardingPassIsDelayedColor { get { return BoardingPass.IsDelayed ? Color.Red : Color.Green; } }

    public List<MenuItem> MenuItems { get; set; }

    public class MenuItem
    {
      public string Title { get; set; }
      public ImageSource ImageSource { get; set; }
    }
  }
}
