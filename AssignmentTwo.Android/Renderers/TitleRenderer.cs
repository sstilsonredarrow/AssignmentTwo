using System;
using Android.Content;
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
                Control.TextSize = 22;
                GradientDrawable gd = new GradientDrawable();
                gd.SetStroke(1, global::Android.Graphics.Color.Black);
                Control.Background = gd;
            }
        }
    }
}