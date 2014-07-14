using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace CustomNavSegueUnwindApp
{
	partial class RightViewController : UIViewController
	{
		public RightViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            BackButton.TouchUpInside += (object sender, EventArgs e) => {
                NavigationController.PopViewControllerAnimated(true);
            };
        }
	}
}
