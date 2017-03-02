using System;

using UIKit;
using Foundation;
using UrbanAirship;
using System.Linq;

namespace Sample
{
	public partial class PushSettingsViewController : UITableViewController
	{
		public PushSettingsViewController(IntPtr handle) : base (handle)
		{
		
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Initialize switches
			this.pushEnabledSwitch.On = UAirship.Push.UserPushNotificationsEnabled;
			locationEnabledSwitch.On = UAirship.Location.LocationUpdatesEnabled;
			analyticsSwitch.On = UAirship.Shared.Analytics.Enabled;

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

			locationEnabledLabel.Text = "Location Enabled label";
			locationEnabledSubtitleLabel.Text = "Enable GPS and WIFI Based Location detail label";
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			RefreshView();
		}

		partial void switchValueChanged(UISwitch sender)
		{
			// Only allow disabling user notifications on iOS 10+
			if (!NSProcessInfo.ProcessInfo.IsOperatingSystemAtLeastVersion(new NSOperatingSystemVersion(10, 0, 0)) &&
			UAirship.Push.UserPushNotificationsEnabled)
			{
				UAirship.Push.UserPushNotificationsEnabled = pushEnabledSwitch.On;
			}
			else if (pushEnabledSwitch.On) {
				UAirship.Push.UserPushNotificationsEnabled = true;
			}

			UAirship.Location.LocationUpdatesEnabled = locationEnabledSwitch.On;

			UAirship.Shared.Analytics.Enabled = analyticsSwitch.On;
		}

		void RefreshView() 
		{
			channelIDSubtitleLabel.Text = UAirship.Push.ChannelID;

			namedUserSubtitleLabel.Text = UAirship.NamedUser.Identifier == null ? "None" : UAirship.NamedUser.Identifier;

			if (UAirship.Push.Tags.Count() > 0) {
				tagsSubtitleLabel.Text = string.Join(",", UAirship.Push.Tags);
			}
			else {
				tagsSubtitleLabel.Text = "None";
			}
		}

		NSString PushTypeString() 
		{

			UANotificationOptions options = UAirship.Push.AuthorizedNotificationOptions;

			NSMutableArray typeArray = new NSMutableArray(3);

			if ((options & UANotificationOptions.Alert) > 0) {
				typeArray.Add(new NSString("Alert"));
			}
			if ((options & UANotificationOptions.Badge) > 0) {
				typeArray.Add(new NSString("Badge"));
			}
			if ((options & UANotificationOptions.Sound) > 0) {
				typeArray.Add(new NSString("Sound"));
			}

			if (!(typeArray.Count > 0)) {
				return new NSString("Pushes Currently Disabled"); 
			}

			return new NSString(string.Join(",", typeArray));
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			//base.RowSelected(tableView, indexPath);

			tableView.DeselectRow(indexPath, true);

			// iOS 8 & 9 - redirect push enabled cell to system settings
			if (!NSProcessInfo.ProcessInfo.IsOperatingSystemAtLeastVersion(new NSOperatingSystemVersion(10, 0, 0)) && 
			    UAirship.Push.UserPushNotificationsEnabled)
			{
				if (indexPath.Section.Equals(tableView.IndexPathForCell(pushEnabledCell).Section)) { 
					if (indexPath.Row.Equals(tableView.IndexPathForCell(pushEnabledCell).Row)) {
						NSUrl openSettingsURL = new NSUrl(UIApplication.OpenSettingsUrlString);
						UIApplication.SharedApplication.OpenUrl(url: openSettingsURL);
					}
				}
			}

			if (indexPath.Section.Equals(tableView.IndexPathForCell(channelIDCell).Section))
			{
				if (indexPath.Row.Equals(tableView.IndexPathForCell(channelIDCell).Row))
				{
					if (UAirship.Push.ChannelID != null) {
						UIPasteboard.General.String = channelIDSubtitleLabel.Text;
						ShowCopyMessage();
					}
				}
			}
		
		}

		void ShowCopyMessage() {
			UAInAppMessage message = new UAInAppMessage();
			message.Alert = "Copied to clipboard string";
			message.Position = UAInAppMessagePosition.Top;
			message.Duration = 1.5;
			message.PrimaryColor = UIColor.FromRGB(255 / 255, 200 / 255, 40 / 255);
			message.SecondaryColor = UIColor.FromRGB(0 / 255, 105 / 255, 143 / 255);

			UAirship.InAppMessaging.DisplayMessage(message);
		}
	}
}

