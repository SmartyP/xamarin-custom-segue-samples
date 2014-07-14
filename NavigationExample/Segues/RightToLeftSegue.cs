using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;

namespace CustomNavSegueUnwindApp
{
    // NOTE:: Ported from example: http://blog.jambura.com/2012/07/05/custom-segue-animation-left-to-right-using-catransition/

    [Register("RightToLeftSegue")]
    public class RightToLeftSegue : UIStoryboardSegue
    {
        public RightToLeftSegue(IntPtr ptr) : base(ptr)
        {
        }

        public RightToLeftSegue(string identifier, UIViewController source, UIViewController destination) : base(identifier, source, destination)
        {
        }

        public override void Perform()
        {
            CATransition transition = new CATransition();
            transition.Duration = 0.25;
            transition.TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseOut);
            transition.Type = CATransition.TransitionPush;
            transition.Subtype = CATransition.TransitionFromRight;

            SourceViewController.NavigationController.View.Layer.AddAnimation(transition, CALayer.Transition);

            // NOTE:: we are popping with this segue, not pushing
			SourceViewController.NavigationController.PopToRootViewController (true);
        }
    }
}

