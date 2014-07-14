using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.CoreAnimation;
using System.Drawing;
using MonoTouch.CoreGraphics;

namespace CustomSegueUnwindApp
{
    // ported from: http://dadabeatnik.wordpress.com/2013/10/13/custom-segues/
    [Register("CustomSegue")]
    public class CustomSegue : UIStoryboardSegue
    {
        public PointF OriginatingPoint { get; set; }

        public CustomSegue(IntPtr ptr) : base(ptr)
        {
        }

        public override void Perform()
        {        
            // Add the destination view as a subview, temporarily
            SourceViewController.View.AddSubview(DestinationViewController.View);

            // Transformation start scale
            DestinationViewController.View.Transform = CGAffineTransform.MakeScale(0.05f, 0.05f);

            // Store original centre point of the destination view
            PointF originalCenter = DestinationViewController.View.Center;

            // Set center to start point of the button
            DestinationViewController.View.Center = this.OriginatingPoint;

            // do animation
            UIView.Animate(0.5f, 0.0f, UIViewAnimationOptions.CurveEaseInOut, 
                () => {
                    DestinationViewController.View.Transform = CGAffineTransform.MakeScale(1.0f, 1.0f);
                    DestinationViewController.View.Center = originalCenter;
                },
                () => { // completed handler
                    DestinationViewController.View.RemoveFromSuperview();                    
                    SourceViewController.PresentViewController(DestinationViewController, false, () => {});
                });
        }
    }
}

