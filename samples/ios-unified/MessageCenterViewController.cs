/*
 Copyright Airship and Contributors
*/

using System;

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

            this.Style = UAMessageCenter.Shared().DefaultUI.Style;
        }

        public void DisplayMessage(string messageID)
        {
            ListViewController.DisplayMessage(messageID);
        }
    }
}
