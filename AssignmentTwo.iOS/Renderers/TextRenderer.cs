using System;
using AssignmentTwo;
using AssignmentTwo.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TextEntry), typeof(TextRenderer))]
namespace AssignmentTwo.iOS.Renderers
{
    public class TextRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Font = UIFont.FromName("TrebuchetMS", 22);
                Control.TextColor = UIColor.Blue;
                Control.BorderStyle = UITextBorderStyle.Line;
                Control.Layer.BorderColor = UIColor.Black.CGColor;
            }
        }
    }
}
