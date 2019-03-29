using AssignmentTwo;
using AssignmentTwo.iOS.Renderers;
using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TitleEntry), typeof(TitleRenderer))]
namespace AssignmentTwo.iOS.Renderers
{
    public class TitleRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.Line;
                Control.Layer.BorderColor = UIColor.Black.CGColor;
                Control.Layer.BorderWidth = 1;
                Control.TextColor = UIColor.Blue;
                Control.Font = UIFont.FromName("TrebuchetMS", 22);
            }
        }
    }
}
