using System;
using Android.Content;
using Android.Graphics.Drawables;
using AssignmentTwo;
using AssignmentTwo.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Body), typeof(BodyRenderer))]
namespace AssignmentTwo.Droid.Renderer
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
                GradientDrawable border = new GradientDrawable();
                border.SetStroke(1, global::Android.Graphics.Color.Black);
                Control.Background = border;

                Control.SetTextColor(global::Android.Graphics.Color.DarkGray);
                Control.TextSize = 14;
            }
        }
    }
}
