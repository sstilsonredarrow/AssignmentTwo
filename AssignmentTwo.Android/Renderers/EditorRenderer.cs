using System;
using Android.Content;
using AssignmentTwo;
using AssignmentTwo.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TextEditor), typeof(AssignmentTwo.Droid.Renderers.EditorRenderer))]
namespace AssignmentTwo.Droid.Renderers
{
    public class EditorRenderer : EditorRenderer
    {
        public EditorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetTextSize(Android.Util.ComplexUnitType.Px, 22);
                Control.SetTextColor(global::Android.Graphics.Color.DarkGray);

            }
        }
    }
}
