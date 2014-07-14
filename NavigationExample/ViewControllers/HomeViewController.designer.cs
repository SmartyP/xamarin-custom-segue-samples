// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace CustomNavSegueUnwindApp
{
	[Register ("HomeViewController")]
	partial class HomeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton LeftButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton RightButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (LeftButton != null) {
				LeftButton.Dispose ();
				LeftButton = null;
			}
			if (RightButton != null) {
				RightButton.Dispose ();
				RightButton = null;
			}
		}
	}
}
