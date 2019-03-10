using HW2;
using HW2.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(GradientBoxView), typeof(GradientBoxViewRenderer))]

namespace HW2.UWP
{
  public class GradientBoxViewRenderer : VisualElementRenderer<BoxView, Panel>
  {
    private Color StartColor { get; set; }
    private Color EndColor { get; set; }
    private GredientBoxViewDirection Direction { get; set; }

    protected override void UpdateBackgroundColor()
    {
      base.UpdateBackgroundColor();

      var stopCollections = new GradientStopCollection
      {
        new GradientStop
        {
          Color = Windows.UI.Color.FromArgb((byte)(StartColor.A * byte.MaxValue), (byte)(StartColor.R * byte.MaxValue), (byte)(StartColor.G * byte.MaxValue), (byte)(StartColor.B * byte.MaxValue)),
          Offset = 0
        },
        new GradientStop
        {
          Color = Windows.UI.Color.FromArgb((byte)(EndColor.A * byte.MaxValue), (byte)(EndColor.R * byte.MaxValue), (byte)(EndColor.G * byte.MaxValue), (byte)(EndColor.B * byte.MaxValue)),
          Offset = 1
        }
      };

      var gradient =
        Direction == GredientBoxViewDirection.TopToBottom ?
          new LinearGradientBrush
          {
            StartPoint = new Windows.Foundation.Point(0.5, 0),
            EndPoint = new Windows.Foundation.Point(0.5, 1),
            GradientStops = stopCollections
          } :
        Direction == GredientBoxViewDirection.LeftToRight ?
          new LinearGradientBrush
          {
            StartPoint = new Windows.Foundation.Point(0, 0.5),
            EndPoint = new Windows.Foundation.Point(1, 0.5),
            GradientStops = stopCollections
          } :
        Direction == GredientBoxViewDirection.TopLeftToBottomRight ?
          new LinearGradientBrush
          {
            StartPoint = new Windows.Foundation.Point(0, 0),
            EndPoint = new Windows.Foundation.Point(1, 1),
            GradientStops = stopCollections
          } :
        Direction == GredientBoxViewDirection.TopRightToBottomLeft ?
          new LinearGradientBrush
          {
            StartPoint = new Windows.Foundation.Point(1, 0),
            EndPoint = new Windows.Foundation.Point(0, 1),
            GradientStops = stopCollections
          } :
        null;

      Background = gradient;
    }

    protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
    {
      base.OnElementChanged(e);

      try
      {
        if (e.NewElement is GradientBoxView element)
        {
          StartColor = element.StartColor;
          EndColor = element.EndColor;
          Direction = element.Direction;

          UpdateBackgroundColor();
        }
      }
      catch
      {
        throw;
      }
    }
  }
}
