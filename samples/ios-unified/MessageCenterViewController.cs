using System;

using UIKit;
using UrbanAirship;

namespace Sample
{
	public partial class MessageCenterViewController : UADefaultMessageCenterSplitViewController
	{
		public MessageCenterViewController(IntPtr handle)
		{
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			this.Style = UAirship.DefaultMessageCenter.Style;
		}

		public void displayMessage(UAInboxMessage message) {
			ListViewController.DisplayMessage(message);
		}
	}
}
