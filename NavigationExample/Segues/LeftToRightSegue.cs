using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;

namespace CustomNavSegueUnwindApp
{
    // NOTE:: Ported from example: http://blog.jambura.com/2012/07/05/custom-segue-animation-left-to-right-using-catransition/
    // Used to transition from HomeViewController to BrowseCarsViewController
    [Register("LeftToRightSegue")]
    public class LeftToRightSegue : UIStoryboardSegue
    {
        public LeftToRightSegue(IntPtr ptr) : base(ptr)
        {
        }

        public override void Perform()
        {
            CATransition transition = new CATransition();
            transition.Duration = 0.25;
            transition.TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseOut);
            transition.Type = CATransition.TransitionPush;
            transition.Subtype = CATransition.TransitionFromLeft;

            SourceViewController.NavigationController.View.Layer.AddAnimation(transition, CALayer.Transition);
            SourceViewController.NavigationController.PushViewController(DestinationViewController, false);
        }
    }
}

