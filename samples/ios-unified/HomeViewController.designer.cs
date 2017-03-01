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

namespace Sample
{
    [Register ("HomeViewController")]
    partial class HomeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton channelIDButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton enablePushButton { get; set; }

        [Action ("buttonTapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void buttonTapped (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (channelIDButton != null) {
                channelIDButton.Dispose ();
                channelIDButton = null;
            }

            if (enablePushButton != null) {
                enablePushButton.Dispose ();
                enablePushButton = null;
            }
        }
    }
}