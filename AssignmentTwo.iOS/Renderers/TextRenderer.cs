using System;
using AssignmentTwo;
using AssignmentTwo.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TextEditor), typeof(TextRenderer))]
namespace AssignmentTwo.iOS.Renderers
{
    public class TextRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Layer.BorderColor = UIColor.Black.CGColor;
                Control.Layer.BorderWidth = 1;
                Control.TextColor = UIColor.DarkGray;
                Control.Font = UIFont.FromName("TrebuchetMS", 12);
            }
        }
    }
}
