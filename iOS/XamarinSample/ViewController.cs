using System;

using UIKit;
using UrbanAirship;

namespace XamarinSample
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
			this.MyRegistrationDelegate.ChannelLabel = this.ChannelLabel;
			UAirship.Push.RegistrationDelegate = this.MyRegistrationDelegate;

			// Display the channel ID, or "Unregistered" if we are still waiting for one
			string channelID = UAirship.Push.ChannelID;
			channelID = channelID != null ? channelID : "(Unregistered)";
			this.ChannelLabel.Text = channelID;
		}

		class RegistrationDelegate : UARegistrationDelegate
		{
			public UILabel ChannelLabel { get; set; }
			public override void RegistrationSucceeded (string channelID, string deviceToken)
			{
				this.ChannelLabel.Text = UAirship.Push.ChannelID;
			}
		}
	}
}

