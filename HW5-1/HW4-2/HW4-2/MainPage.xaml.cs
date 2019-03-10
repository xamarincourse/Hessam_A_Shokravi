using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW4_2
{
  public partial class MainPage : ContentPage
  {
    Context ContextData = new Context
    {
      Flights = new[] {
        new Context.Flight
        {
          AirlineLogoImageSource = ImageSource.FromResource("HW4-2.Images.MahanLogo.png"),
          ArrivalStation = "London",
          Ata = new TimeSpan(22, 55, 0),
          Eta = new TimeSpan(22, 50, 0),
          Terminal = "T3",
          Delayed = false
        },
        new Context.Flight
        {
          AirlineLogoImageSource = ImageSource.FromResource("HW4-2.Images.MalasyaLogo.png"),
          ArrivalStation = "Bankok",
          Ata = new TimeSpan(10, 5, 0),
          Eta = new TimeSpan(10, 20, 0),
          Terminal = "T1",
          Delayed = false
        },
        new Context.Flight
        {
          AirlineLogoImageSource = ImageSource.FromResource("HW4-2.Images.EagleLogo.png"),
          ArrivalStation = "California",
          Ata = new TimeSpan(3, 30, 0),
          Eta = new TimeSpan(3, 45, 0),
          Terminal = "T4",
          Delayed = true
        },
        new Context.Flight
        {
          AirlineLogoImageSource = ImageSource.FromResource("HW4-2.Images.MahanLogo.png"),
          ArrivalStation = "Imam Khomeini",
          Ata = new TimeSpan(17, 10, 0),
          Eta = new TimeSpan(17, 10, 0),
          Terminal = "T6",
          Delayed = false
        },
        new Context.Flight
        {
          AirlineLogoImageSource = ImageSource.FromResource("HW4-2.Images.MalasyaLogo.png"),
          ArrivalStation = "Shanghai",
          Ata = new TimeSpan(21, 55, 0),
          Eta = new TimeSpan(22, 20, 0),
          Terminal = "T2",
          Delayed = true
        },
        new Context.Flight
        {
          AirlineLogoImageSource = ImageSource.FromResource("HW4-2.Images.EagleLogo.png"),
          ArrivalStation = "Washington DC",
          Ata = new TimeSpan(6, 40, 0),
          Eta = new TimeSpan(6, 50, 0),
          Terminal = "T5",
          Delayed = false
        },
      }
    };



    public MainPage()
    {
      InitializeComponent();

      BindingContext = ContextData;
    }




    public class Context
    {
      public Flight[] Flights { get; set; }

      public class Flight
      {
        public ImageSource AirlineLogoImageSource { get; set; }
        public string ArrivalStation { get; set; }
        public TimeSpan Ata { get; set; }
        public TimeSpan Eta { get; set; }
        public string Terminal { get; set; }
        public bool Delayed { get; set; }

        public string StatusText { get { return Delayed ? "Delayed" : "Arrived"; } }
        //public Color StatusColor { get { return Delayed ? Color.Red : Color.Green; } }
      }
    }
  }
}
