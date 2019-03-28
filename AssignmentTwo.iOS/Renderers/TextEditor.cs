using System;
using AssignmentTwo;
using AssignmentTwo.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TextEditor), typeof(EditorRenderer))]
namespace AssignmentTwo.iOS.Renderers
{
    public class TextEditor : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.DarkGray;
                Control.Font = UIFont.FromName("TrebuchetMS", 22);
                Control.TextColor = UIColor.Blue;
            }
        }
    }
}
