using System;

using UIKit;
using UrbanAirship;

namespace Sample
{
	public partial class MessageCenterViewController : UADefaultMessageCenterSplitViewController
	{
		public MessageCenterViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			this.Style = UAirship.DefaultMessageCenter.Style;
		}

		public void DisplayMessage(UAInboxMessage message) {
			ListViewController.DisplayMessage(message);
		}
	}
}
