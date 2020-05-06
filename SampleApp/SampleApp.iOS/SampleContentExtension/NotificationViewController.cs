/*
 Copyright Airship and Contributors
*/

using System;
using UIKit;
using UserNotifications;
using UserNotificationsUI;
using UrbanAirship;


namespace SampleContentExtension
{
    public partial class NotificationViewController : UAContentExtensionViewController, IUNNotificationContentExtension
    {
        protected NotificationViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any required interface initialization here.
        }

        public void DidReceiveNotification(UNNotification notification)
        {
            label.Text = notification.Request.Content.Body;
        }
    }
}
