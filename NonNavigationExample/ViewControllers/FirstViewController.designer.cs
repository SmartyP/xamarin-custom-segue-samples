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

namespace CustomSegueUnwindApp
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton Button1 { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Button1 != null) {
				Button1.Dispose ();
				Button1 = null;
			}
		}
	}
}
