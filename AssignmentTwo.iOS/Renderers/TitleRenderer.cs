using System;
using AssignmentTwo;
using AssignmentTwo.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AssignmentTwo.TitleEntry), typeof(TitleRenderer))]
namespace AssignmentTwo.iOS.Renderers
{
    public class TitleRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if ( Control != null)
            {
                Control.TextColor = UIColor.Blue;
                Control.Font = UIFont.FromName("TrebuchetMS", 40);
                Control.BorderStyle = UITextBorderStyle.Line;
                Control.Layer.BorderColor = UIColor.Blue.CGColor;
                Control.Layer.BorderWidth = 2;
            }
        }
    }
}
