using System;
using AssignmentTwo;
using AssignmentTwo.iOS.Renderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Title), typeof(TitleRenderer))]
namespace AssignmentTwo.iOS.Renderer
{
    public class TitleRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.TextColor = UIColor.Blue;
                Control.Font = UIFont.FromName("TrebuchetMS", 50);

                Control.BorderStyle = UITextBorderStyle.Line;
                Control.Layer.BorderColor = UIColor.Black.CGColor;
            }
        }
    }
}
