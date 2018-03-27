/*
 Copyright 2017 Urban Airship and Contributors
*/

using Foundation;
using UIKit;
using UrbanAirship;
using System.Threading.Tasks;
using System;
using ObjCRuntime;

using CoreFoundation;
using GameController;
using System.Linq;
using Xamarin.Forms;
using System.Security.Authentication.ExtendedProtection;
namespace Sample
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate, IUARegistrationDelegate
    {
        private InboxDelegate inboxDelegate;
        private PushHandler pushHandler;

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {

            this.FailIfSimulator();

            Xamarin.Forms.Forms.Init();

            // Set log level for debugging config loading (optional)
            // It will be set to the value in the loaded config upon takeOff
            UAirship.SetLogLevel(UALogLevel.Trace);

            // Populate AirshipConfig.plist with your app's info from https://go.urbanairship.com
            // or set runtime properties here.
            UAConfig config = UAConfig.DefaultConfig();

            if (!config.Validate())
            {
                this.ShowInvalidConfigAlert();
                return true;
            }

            config.MessageCenterStyleConfig = "UAMessageCenterDefaultStyle";

            // Bootstrap the Urban Airship SDK
            UAirship.TakeOff(config);

            Console.WriteLine("Config:{0}", config);

            UAirship.Push().ResetBadge();

            pushHandler = new PushHandler();
            UAirship.Push().PushNotificationDelegate = pushHandler;

            inboxDelegate = new InboxDelegate(Window.RootViewController);
            UAirship.Inbox().Delegate = inboxDelegate;

            UAirship.Push().WeakRegistrationDelegate = this;

            NSString messageListUpdated = new NSString("com.urbanairship.notification.message_list_updated");

            NSNotificationCenter.DefaultCenter.AddObserver(messageListUpdated, (notification) =>
            {
                refreshMessageCenterBadge();
            });

            return true;
        }

        public override void WillEnterForeground(UIApplication application)
        {
            refreshMessageCenterBadge();
        }

        private void FailIfSimulator()
        {

            if (Runtime.Arch != Arch.SIMULATOR)
            {
                return;
            }

            Console.WriteLine("You will not be able to receive push notifications in the simulator.");

            if (NSUserDefaults.StandardUserDefaults.BoolForKey("ua-simulator-warning-disabled"))
            {
                return;
            }

            UIAlertController alertController = UIAlertController.Create(title: "Notice", message: "You will not be able " +
                                                                         "to receive push notifications in the simulator.",
                                                                         preferredStyle: UIAlertControllerStyle.Alert);

            UIAlertAction cancelAction = UIAlertAction.Create(title: "Cancel", style: UIAlertActionStyle.Cancel, handler: null);
            alertController.AddAction(cancelAction);

            DispatchTime delay = new DispatchTime(DispatchTime.Now, 500000000);

            DispatchQueue.MainQueue.DispatchAfter(delay, () =>
            {
                Window.RootViewController.PresentViewController(alertController, true, null);
            });
        }

        private void refreshMessageCenterBadge()
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                if (Window.RootViewController == null)
                {
                    return;
                }

                UITabBarController tabBarController = (UITabBarController)Window.RootViewController;
                UITabBarItem messageCenterTab = tabBarController.TabBar.Items[2];

                if (UAirship.Inbox().MessageList.UnreadCount > 0)
                {
                    messageCenterTab.BadgeValue = UAirship.Inbox().MessageList.UnreadCount.ToString();
                }
                else
                {
                    messageCenterTab.BadgeValue = null;
                }
            });
        }

        private void ShowInvalidConfigAlert()
        {
            UIAlertController alertController = UIAlertController.Create(title: "Invalid AirshipConfig.plist",
                                                                         message: "The AirshipConfig.plist must be a part " +
                                                                         "of the app bundle and include a valid appkey and " +
                                                                         "secret for the selected production level.",
                                                                         preferredStyle: UIAlertControllerStyle.Alert);

            Window.RootViewController.PresentViewController(alertController, true, null);
        }

        [Export("registrationSucceededForChannelID:deviceToken:")]
        public void RegistrationSucceeded(string channelID, string deviceToken)
        {
            NSNotificationCenter.DefaultCenter.PostNotificationName("channelIDUpdated", this);
        }
    }
}
