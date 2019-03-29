using System;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;
using AssignmentTwo;
using AssignmentTwo.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TextEditor), typeof(TextRenderer))]
namespace AssignmentTwo.Droid.Renderers
{
    public class TextRenderer : EditorRenderer
    {
        public TextRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetTextColor(global::Android.Graphics.Color.DarkGray);
                Control.TextSize = 12;
                GradientDrawable gd = new GradientDrawable();
                gd.SetStroke(1, global::Android.Graphics.Color.Black);
                Control.Background = gd;               
            }
        }
    }
}
