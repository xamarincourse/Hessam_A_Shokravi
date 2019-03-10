using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW3
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    private async void ChangeTextButtonClicked(object sender, EventArgs e)
    {
      textView.Text = "The text has been changed.";
      await textView.RelRotateTo(67, 500, Easing.BounceOut);
    }

    private async void ChangeViewButtonClicked(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new OtherPage());
    }
  }
}
