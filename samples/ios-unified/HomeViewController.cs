/*
 Copyright Airship and Contributors
*/

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

            if (sender == this.channelIDButton & UAirship.Channel().Identifier != null)
            {
                UIPasteboard.General.String = UAirship.Channel().Identifier;

                UIAlertController alertController = UIAlertController.Create(null, "Channel copied to clipboard!", UIAlertControllerStyle.Alert);
                alertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

                PresentViewController(alertController, animated: true, completionHandler: null);
            }
        }

        void refreshView()
        {
            if (UAirship.Push().UserPushNotificationsEnabled)
            {
                this.channelIDButton.SetTitle(UAirship.Channel().Identifier, UIControlState.Normal);
                this.channelIDButton.Hidden = false;
                this.enablePushButton.Hidden = true;
                return;
            }

            this.channelIDButton.Hidden = true;
            this.enablePushButton.Hidden = false;
        }

    }
}

