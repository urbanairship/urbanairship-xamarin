// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel ChannelLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ChannelLabel != null) {
				ChannelLabel.Dispose ();
				ChannelLabel = null;
			}
		}
	}
}
