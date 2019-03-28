using System;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using AssignmentTwo;
using AssignmentTwo.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TitleEntry), typeof(TitleRenderer))]
namespace AssignmentTwo.Droid.Renderers
{
    public class TitleRenderer : EntryRenderer
    {
        public TitleRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetTextColor(global::Android.Graphics.Color.Green);
                Control.TextSize = 16;

                var nativeEditText = (global::Android.Widget.EditText)Control;
                var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
                shape.Paint.Color = Xamarin.Forms.Color.Black.ToAndroid();
                shape.Paint.SetStyle(Paint.Style.Stroke);
                nativeEditText.Background = shape;
            }
        }
    }
}
