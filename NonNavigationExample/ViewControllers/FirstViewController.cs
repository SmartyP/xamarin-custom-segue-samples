using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace CustomSegueUnwindApp
{
	partial class FirstViewController : UIViewController
	{
		public FirstViewController (IntPtr handle) : base (handle)
		{
		}

        [Action ("returned:")]
        void returned (MonoTouch.UIKit.UIStoryboardSegue segue)
        {
            Console.WriteLine("HomeViewController.returned() called");
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.GetType() == typeof(CustomSegue))
            {
                ((CustomSegue)segue).OriginatingPoint = this.Button1.Center;
            }
            base.PrepareForSegue(segue, sender);
        }

        public override UIStoryboardSegue GetSegueForUnwinding(UIViewController toViewController, UIViewController fromViewController, string identifier)
        {
            CustomUnwindSegue segue = new CustomUnwindSegue(identifier, fromViewController, toViewController);
            segue.TargetPoint = Button1.Center;

            return segue;
        }
	}
}
