/*
 Copyright 2016 Urban Airship and Contributors
*/

using System;

using UIKit;
using UrbanAirship;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		RegistrationDelegate MyRegistrationDelegate;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Create and set a delegate to receive callbacks on channel registration
			this.MyRegistrationDelegate = new RegistrationDelegate ();
			this.MyRegistrationDelegate.ChannelButton = this.ChannelButton;
			UAirship.Push.RegistrationDelegate = this.MyRegistrationDelegate;

			// Display the channel ID if it's already set
			string channelID = UAirship.Push.ChannelID;
			if (channelID != null) {
				this.ChannelButton.SetTitle (channelID, UIControlState.Normal);
			}

			// Copy the channel ID to the clipboard when tapped
			this.ChannelButton.TouchUpInside += delegate {
				if (UAirship.Push.ChannelID != null) {
					UIPasteboard.General.String = UAirship.Push.ChannelID;
					new UIAlertView("Channel copied to clipboard", null, null, "OK", null).Show();
				}
			};
		}

		class RegistrationDelegate : UARegistrationDelegate
		{
			public UIButton ChannelButton { get; set; }
			public override void RegistrationSucceeded (string channelID, string deviceToken)
			{
				this.ChannelButton.SetTitle(UAirship.Push.ChannelID, UIControlState.Normal);
			}
		}
	}
}

