/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;

using UIKit;
using Foundation;
using UrbanAirship;
using System.Linq;

namespace Sample
{
    public partial class PushSettingsViewController : UITableViewController
    {
        public PushSettingsViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Initialize switches
            pushEnabledSwitch.On = UAirship.Push().UserPushNotificationsEnabled;
            locationEnabledSwitch.On = UALocation.Shared().LocationUpdatesEnabled;

            analyticsSwitch.On = UAirship.Analytics().Enabled;

            NSString channelUpdatedNotification = new NSString("channelIDUpdated");
            NSNotificationCenter.DefaultCenter.AddObserver(channelUpdatedNotification, (notification) =>
            {
                RefreshView();
            });

            NSString didBecomeActiveNotification = new NSString("UIApplicationDidBecomeActiveNotification");
            NSNotificationCenter.DefaultCenter.AddObserver(didBecomeActiveNotification, (notification) =>
            {
                RefreshView();
            });
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            RefreshView();
        }

        partial void switchValueChanged(UISwitch sender)
        {
            // Only allow disabling user notifications on iOS 10+
            if (NSProcessInfo.ProcessInfo.IsOperatingSystemAtLeastVersion(new NSOperatingSystemVersion(10, 0, 0)))
            {
                UAirship.Push().UserPushNotificationsEnabled = pushEnabledSwitch.On;
            }
            else if (pushEnabledSwitch.On)
            {
                UAirship.Push().UserPushNotificationsEnabled = true;
            }

            UALocation.Shared().LocationUpdatesEnabled = locationEnabledSwitch.On;

            UAirship.Analytics().Enabled = analyticsSwitch.On;

            RefreshView();
        }

        void RefreshView()
        {
            if (UAirship.Push().UserPushNotificationsEnabled)
            {
                pushSettingsSubtitleLabel.Text = PushTypeString();
            }
            else
            {
                pushSettingsSubtitleLabel.Text = "Enable push notifications";
            }
             
            channelIDSubtitleLabel.Text = UAirship.Channel().Identifier;

            namedUserSubtitleLabel.Text = UAirship.NamedUser().Identifier == null ? "None" : UAirship.NamedUser().Identifier;

            if (UAirship.Channel().Tags.Count() > 0)
            {
                tagsSubtitleLabel.Text = string.Join(",", UAirship.Channel().Tags);
            }
            else
            {
                tagsSubtitleLabel.Text = "None";
            }
        }

        String PushTypeString()
        {
            UAAuthorizedNotificationSettings settings = UAirship.Push().AuthorizedNotificationSettings;

            List<String> settingsList = new List<String>();

            if ((settings & UAAuthorizedNotificationSettings.Alert) > 0)
            {
                settingsList.Add("Alert");
            }
            if ((settings & UAAuthorizedNotificationSettings.Badge) > 0)
            {
                settingsList.Add("Badge");
            }
            if ((settings & UAAuthorizedNotificationSettings.Sound) > 0)
            {
                settingsList.Add("Sound");
            }
            if ((settings & UAAuthorizedNotificationSettings.CarPlay) > 0)
            {
                settingsList.Add("CarPlay");
            }
            if ((settings & UAAuthorizedNotificationSettings.LockScreen) > 0)
            {
                settingsList.Add("LockScreen");
            }
            if ((settings & UAAuthorizedNotificationSettings.NotificationCenter) > 0)
            {
                settingsList.Add("NotificationCenter");
            }
            if ((settings & UAAuthorizedNotificationSettings.CriticalAlert) > 0)
            {
                settingsList.Add("CriticalAlert");
            }
            if (!(settingsList.Count > 0))
            {
                return new String("Pushes Currently Unauthorized");
            }

            return String.Join(", ", settingsList);
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            //base.RowSelected(tableView, indexPath);

            tableView.DeselectRow(indexPath, true);

            // iOS 8 & 9 - redirect push enabled cell to system settings
            if (!NSProcessInfo.ProcessInfo.IsOperatingSystemAtLeastVersion(new NSOperatingSystemVersion(10, 0, 0)) &&
                UAirship.Push().UserPushNotificationsEnabled)
            {
                if (indexPath.Section.Equals(tableView.IndexPathForCell(pushEnabledCell).Section))
                {
                    if (indexPath.Row.Equals(tableView.IndexPathForCell(pushEnabledCell).Row))
                    {
                        NSUrl openSettingsURL = new NSUrl(UIApplication.OpenSettingsUrlString);
                        UIApplication.SharedApplication.OpenUrl(url: openSettingsURL);
                    }
                }
            }

            if (indexPath.Section.Equals(tableView.IndexPathForCell(channelIDCell).Section))
            {
                if (indexPath.Row.Equals(tableView.IndexPathForCell(channelIDCell).Row))
                {
                    if (UAirship.Channel().Identifier != null)
                    {
                        UIPasteboard.General.String = channelIDSubtitleLabel.Text;
                        ShowCopyMessage();
                    }
                }
            }

        }

        void ShowCopyMessage()
        {
            UIAlertController alertController = UIAlertController.Create(null, "Channel copied to clipboard!", UIAlertControllerStyle.Alert);
            alertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

            PresentViewController(alertController, animated: true, completionHandler: null);
        }
    }
}

