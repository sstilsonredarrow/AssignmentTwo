using System;
using Android.Content;
using Android.Graphics.Drawables;
using AssignmentTwo;
using AssignmentTwo.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Title), typeof(TitleRenderer))]
namespace AssignmentTwo.Droid.Renderer
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
                GradientDrawable border = new GradientDrawable();
                border.SetStroke(1, global::Android.Graphics.Color.Black);
                Control.Background = border;

                Control.SetTextColor(global::Android.Graphics.Color.Green);
                Control.TextSize = 22;
            }
        }
    }
}
