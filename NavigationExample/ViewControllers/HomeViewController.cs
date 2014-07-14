using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace CustomNavSegueUnwindApp
{
	partial class HomeViewController : UIViewController
	{
		public HomeViewController (IntPtr handle) : base (handle)
		{
		}

        [Action ("returned:")]
        void returned (MonoTouch.UIKit.UIStoryboardSegue segue)
        {
            Console.WriteLine("HomeViewController.returned() called");
        }
	}
}
