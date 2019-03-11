using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HW2
{
  public class GradientBoxView : BoxView
  {
    public Color StartColor { get; set; }
    public Color EndColor { get; set; }
    public GredientBoxViewDirection Direction { get; set; }
  }

  public enum GredientBoxViewDirection
  {
    TopToBottom,
    LeftToRight,
    TopLeftToBottomRight,
    TopRightToBottomLeft
  }
}
