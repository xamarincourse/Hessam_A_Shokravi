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

      BindingContext = new MainPageViewModel();
    }

    private void UpdateBindingContext(Action<MainPageViewModel> updater)
    {
      var clone = ((MainPageViewModel)BindingContext).Clone;
      updater(clone);
      BindingContext = clone;
    }

    private async void LoadButtonClickHandler(object sender, EventArgs e)
    {
      UpdateBindingContext(context => context.IsLoading = true);
      var newBoardingPass = await BoardingPassService.GetAsync("12345");
      UpdateBindingContext(context =>
      {
        context.IsLoading = false;
        context.IsLoaded = true;
        context.BoardingPass = newBoardingPass;
      });
      ((Button)sender).IsVisible = false;
    }
  }
}
