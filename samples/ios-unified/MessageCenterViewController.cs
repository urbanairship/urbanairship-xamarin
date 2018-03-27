using System;

using UIKit;
using UrbanAirship;

namespace Sample
{
    public partial class MessageCenterViewController : UAMessageCenterSplitViewController
    {
        public MessageCenterViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            this.Style = UAirship.MessageCenter().Style;
        }

        public void DisplayMessage(UAInboxMessage message)
        {
            ListViewController.DisplayMessage(message.MessageID);
        }
    }
}
