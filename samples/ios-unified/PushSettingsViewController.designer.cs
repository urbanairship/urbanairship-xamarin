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
    [Register ("PushSettingsViewController")]
    partial class PushSettingsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch analyticsSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableViewCell channelIDCell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel channelIDSubtitleLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableViewCell locationEnabledCell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel locationEnabledLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel locationEnabledSubtitleLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch locationEnabledSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableViewCell namedUserCell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel namedUserSubtitleLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableViewCell pushEnabledCell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch pushEnabledSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel pushSettingsLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel pushSettingsSubtitleLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableViewCell tagsCell { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tagsSubtitleLabel { get; set; }

        [Action ("switchValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void switchValueChanged (UIKit.UISwitch sender);

        void ReleaseDesignerOutlets ()
        {
            if (analyticsSwitch != null) {
                analyticsSwitch.Dispose ();
                analyticsSwitch = null;
            }

            if (channelIDCell != null) {
                channelIDCell.Dispose ();
                channelIDCell = null;
            }

            if (channelIDSubtitleLabel != null) {
                channelIDSubtitleLabel.Dispose ();
                channelIDSubtitleLabel = null;
            }

            if (locationEnabledCell != null) {
                locationEnabledCell.Dispose ();
                locationEnabledCell = null;
            }

            if (locationEnabledLabel != null) {
                locationEnabledLabel.Dispose ();
                locationEnabledLabel = null;
            }

            if (locationEnabledSubtitleLabel != null) {
                locationEnabledSubtitleLabel.Dispose ();
                locationEnabledSubtitleLabel = null;
            }

            if (locationEnabledSwitch != null) {
                locationEnabledSwitch.Dispose ();
                locationEnabledSwitch = null;
            }

            if (namedUserCell != null) {
                namedUserCell.Dispose ();
                namedUserCell = null;
            }

            if (namedUserSubtitleLabel != null) {
                namedUserSubtitleLabel.Dispose ();
                namedUserSubtitleLabel = null;
            }

            if (pushEnabledCell != null) {
                pushEnabledCell.Dispose ();
                pushEnabledCell = null;
            }

            if (pushEnabledSwitch != null) {
                pushEnabledSwitch.Dispose ();
                pushEnabledSwitch = null;
            }

            if (pushSettingsLabel != null) {
                pushSettingsLabel.Dispose ();
                pushSettingsLabel = null;
            }

            if (pushSettingsSubtitleLabel != null) {
                pushSettingsSubtitleLabel.Dispose ();
                pushSettingsSubtitleLabel = null;
            }

            if (tagsCell != null) {
                tagsCell.Dispose ();
                tagsCell = null;
            }

            if (tagsSubtitleLabel != null) {
                tagsSubtitleLabel.Dispose ();
                tagsSubtitleLabel = null;
            }
        }
    }
}