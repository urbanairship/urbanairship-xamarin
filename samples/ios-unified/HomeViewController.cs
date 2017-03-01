using System;
using UrbanAirship;

using UIKit;
using System.Runtime.CompilerServices;
using Foundation;

namespace Sample
{
	public partial class HomeViewController : UIViewController
	{

		public HomeViewController (IntPtr handle) : base("HomeViewController", null)
		{
		
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			NSString channelIDNotification = new NSString("channelIDUpdated");

			NSNotificationCenter.DefaultCenter.AddObserver(channelIDNotification, (notification) =>
			{
				refreshView();					
			});
		}


		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			refreshView();
		}

		partial void buttonTapped(UIButton sender)
		{
			if (sender == enablePushButton) {
				UAirship.Push.UserPushNotificationsEnabled = true;
			}

			if (sender == this.channelIDButton & UAirship.Push.ChannelID != null) {
				UIPasteboard.General.String = UAirship.Push.ChannelID;

				UAInAppMessage message = new UAInAppMessage();

				message.Alert = "Copied to clipboard string";
				message.Position = UAInAppMessagePosition.Top;
				message.Duration = 1.5;
				message.PrimaryColor = UIColor.FromRGB(255 / 255, 200 / 255, 40 / 255);
				message.SecondaryColor = UIColor.FromRGB(0 / 255, 105 / 255, 143 / 255);

				UAirship.InAppMessaging.DisplayMessage(message);
			}
		}

		void refreshView()
		{
			if (UAirship.Push.UserPushNotificationsEnabled)
			{
				this.channelIDButton.Hidden = false;
				this.enablePushButton.Hidden = true;
				return;
			}

			this.channelIDButton.Hidden = true;
			this.enablePushButton.Hidden = false;
		}

	}
}

