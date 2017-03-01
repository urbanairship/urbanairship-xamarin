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
    [Register ("AddNamedUserTableViewController")]
    partial class AddNamedUserTableViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField addNamedUserTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (addNamedUserTextField != null) {
                addNamedUserTextField.Dispose ();
                addNamedUserTextField = null;
            }
        }
    }
}