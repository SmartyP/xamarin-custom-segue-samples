using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace CustomNavSegueUnwindApp
{
	partial class CustomNavigationController : UINavigationController
	{
		public CustomNavigationController (IntPtr handle) : base (handle)
		{
		}

        public override UIStoryboardSegue GetSegueForUnwinding(UIViewController toViewController, UIViewController fromViewController, string identifier)
        {
            Console.WriteLine("CustomNavigationController.GetSegueForUnwinding() returning a new RightToLeftSegue");

            // NOTE:: if identifier is NULL, a crash will occur, so we make sure it is not
            if (identifier == null)
                identifier = string.Empty;

            UIStoryboardSegue segue = null;

            /*
            switch (identifier)
            {
                case "RealBackButtonID":
                    break;
                case "BackButtonID":
                    break;
            }
            */


            segue = new RightToLeftSegue(identifier, fromViewController, toViewController);

            return segue;
        }
	}
}
