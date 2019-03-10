using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HW2;
using HW2.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(GradientBoxView), typeof(GredientBoxViewRenderer))]

namespace HW2.Droid
{
  class GredientBoxViewRenderer : VisualElementRenderer<BoxView>
  {
    private Color StartColor { get; set; }
    private Color EndColor { get; set; }
    private GredientBoxViewDirection Direction { get; set; }

    public GredientBoxViewRenderer(Context context) : base(context) { }

    protected override void DispatchDraw(Android.Graphics.Canvas canvas)
    {
      var gradient =
        Direction == GredientBoxViewDirection.TopToBottom ?
          new Android.Graphics.LinearGradient(0, 0, 0, Height, StartColor.ToAndroid(), EndColor.ToAndroid(), Android.Graphics.Shader.TileMode.Mirror) :
        Direction == GredientBoxViewDirection.LeftToRight ?
          new Android.Graphics.LinearGradient(0, 0, Width, 0, StartColor.ToAndroid(), EndColor.ToAndroid(), Android.Graphics.Shader.TileMode.Mirror) :
        Direction == GredientBoxViewDirection.TopLeftToBottomRight ?
          new Android.Graphics.LinearGradient(0, 0, Width, Height, StartColor.ToAndroid(), EndColor.ToAndroid(), Android.Graphics.Shader.TileMode.Mirror) :
        Direction == GredientBoxViewDirection.TopRightToBottomLeft ?
          new Android.Graphics.LinearGradient(0, Width, 0, Height, StartColor.ToAndroid(), EndColor.ToAndroid(), Android.Graphics.Shader.TileMode.Mirror) :
        null;
      var paint = new Android.Graphics.Paint { Dither = true };
      paint.SetShader(gradient);
      canvas.DrawPaint(paint);
      base.DispatchDraw(canvas);
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
        }
      }
      catch
      {
        throw;
      }
    }
  }
}