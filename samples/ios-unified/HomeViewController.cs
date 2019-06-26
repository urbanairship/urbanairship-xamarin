using System;
using UIKit;
using Foundation;

using UrbanAirship;

namespace Sample
{
    public partial class HomeViewController : UIViewController
    {

        public HomeViewController(IntPtr handle) : base(handle)
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
            if (sender == enablePushButton)
            {
                UAirship.Push().UserPushNotificationsEnabled = true;
            }

            if (sender == this.channelIDButton & UAirship.Push().ChannelID != null)
            {
                UIPasteboard.General.String = UAirship.Push().ChannelID;

                UIAlertController alertController = UIAlertController.Create(null, "Channel copied to clipboard!", UIAlertControllerStyle.Alert);
                alertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

                PresentViewController(alertController, animated: true, completionHandler: null);
            }
        }

        void refreshView()
        {
            if (UAirship.Push().UserPushNotificationsEnabled)
            {
                this.channelIDButton.SetTitle(UAirship.Push().ChannelID, UIControlState.Normal);
                this.channelIDButton.Hidden = false;
                this.enablePushButton.Hidden = true;
                return;
            }

            this.channelIDButton.Hidden = true;
            this.enablePushButton.Hidden = false;
        }

    }
}

