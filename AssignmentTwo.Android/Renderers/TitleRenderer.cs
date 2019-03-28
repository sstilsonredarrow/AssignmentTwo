using System;
using Android.Content;
using AssignmentTwo.Droid.Renderers;
using AssignmentTwo;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AssignmentTwo.TitleEntry), typeof(TitleRenderer))]
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
            if ( Control != null)
            {
                Control.SetTextColor(global::Android.Graphics.Color.Green);
                Control.SetTextSize(Android.Util.ComplexUnitType.Pt, 12);

            }
        }
    }
}
