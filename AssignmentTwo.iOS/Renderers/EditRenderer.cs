using System;
using AssignmentTwo;
using AssignmentTwo.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(TextEditor), typeof(EditRenderer))]
namespace AssignmentTwo.iOS.Renderers
{
    public class EditRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Font = UIFont.FromName("TrebuchetMS", 14);
                Control.TextColor = UIColor.DarkGray;
                Control.Layer.BorderColor = UIColor.Black.CGColor;
            }
        }
    }
}
