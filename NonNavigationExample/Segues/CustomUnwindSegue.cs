using System;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using System.Drawing;

namespace CustomSegueUnwindApp
{
    public class CustomUnwindSegue : UIStoryboardSegue
    {
        public PointF TargetPoint { get; set; }

        public CustomUnwindSegue(string identifier, UIViewController source, UIViewController destination) : base(identifier, source, destination)
        {
            // NOTE:: Identifier cannot be null when calling base constructor. You can set an ID in XCode's storyboard
            // editor, but not yet within XS. Be sure to select the 'Unwind segue from Back to Exit' in XCode and give it
            // an identifier under 'Storyboard Unwind Segue' properties.
        }

        public override void Perform()
        {
            // Add view to super view temporarily
            SourceViewController.View.Superview.InsertSubview(DestinationViewController.View, 0);

            UIView.Animate(0.5f, 0.0f, UIViewAnimationOptions.CurveEaseInOut, 
                () => {
                    SourceViewController.View.Transform = CGAffineTransform.MakeScale(0.05f, 0.05f);
                    SourceViewController.View.Center = this.TargetPoint;
                },
                () => {
                    DestinationViewController.View.RemoveFromSuperview();
                    SourceViewController.DismissViewController(false, null);                    
                });
        }
    }
}   