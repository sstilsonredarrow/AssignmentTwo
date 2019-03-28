using System;
using Android.Content;
using AssignmentTwo;
using AssignmentTwo.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TextEntry), typeof(TextRenderer))]
namespace AssignmentTwo.Droid.Renderers
{
    public class TextRenderer : EntryRenderer
    {
        public TextRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetTextSize(Android.Util.ComplexUnitType.Px, 45);
                Control.SetTextColor(global::Android.Graphics.Color.Green);
            }
        }
    }
}
