using System;
using Android.Content;
using AssignmentTwo.Droid.Renderers;
using AssignmentTwo;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AssignmentTwo.BodyEntry), typeof(BodyRenderer))]
namespace AssignmentTwo.Droid.Renderers
{
    public class BodyRenderer : EditorRenderer
    {
        public BodyRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetTextColor(global::Android.Graphics.Color.DarkGray);
                Control.SetTextSize(Android.Util.ComplexUnitType.Pt, 8);
            }
        }
    }
}
