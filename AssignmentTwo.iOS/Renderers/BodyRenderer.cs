using System;
using AssignmentTwo;
using AssignmentTwo.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BodyEditor), typeof(BodyRenderer))]
namespace AssignmentTwo.iOS.Renderers
{
    public class BodyRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if ( Control != null)
            {
                Control.TextColor = UIColor.DarkGray;
                Control.Layer.BorderColor = UIColor.Black.CGColor;
                Control.Layer.BorderWidth = 2;

            }
        }
    }
}
