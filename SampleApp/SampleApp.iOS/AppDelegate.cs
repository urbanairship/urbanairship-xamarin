/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using ObjCRuntime;
using CoreFoundation;

using Sample;

using UrbanAirship;

namespace SampleApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate, IUARegistrationDelegate
    {
        private PushHandler pushHandler;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // Set log level for debugging config loading (optional)
            // It will be set to the value in the loaded config upon takeOff
            UAirship.SetLogLevel(UALogLevel.Trace);

            // Populate AirshipConfig.plist with your app's info from https://go.urbanairship.com
            // or set runtime properties here.
            UAConfig config = UAConfig.DefaultConfig();

            if (!config.Validate())
            {
                throw new RuntimeException("The AirshipConfig.plist must be a part of the app bundle and " +
                    "include a valid appkey and secret for the selected production level.");
            }

            WarnIfSimulator();

            // Bootstrap the Airship SDK
            UAirship.TakeOff(config);

            Console.WriteLine("Config:{0}", config);

            UAirship.Push().ResetBadge();

            pushHandler = new PushHandler();
            UAirship.Push().PushNotificationDelegate = pushHandler;

            UANotificationAction sampleAction = UANotificationAction.Action("sampleAction", title: "Sample Action Title", options: UANotificationActionOptions.Destructive);

            var sampleActions = new UANotificationAction[] { sampleAction };
            var intentIdentifiers = new string[] { };

            // Create category for sample content extension
            UANotificationCategory[] SampleCategoryArray = { UANotificationCategory.Category(identifier: "sample-extension-category", actions: sampleActions, intentIdentifiers: intentIdentifiers, options: UANotificationCategoryOptions.None) };
            NSSet categories = NSSet.MakeNSObjectSet(SampleCategoryArray);

            // Add sample content extension category to Airship custom categories
            UAirship.Push().CustomCategories = categories;

            UAirship.Push().WeakRegistrationDelegate = this;

            NSNotificationCenter.DefaultCenter.AddObserver(new NSString("channelIDUpdated"), (notification) =>
            {
                //FIXME: Find a way to call the refreshView from the HomeViewController
            });

            InitFormsApp();

            return base.FinishedLaunching(app, options);
        }

        private void InitFormsApp ()
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
        }

        private void WarnIfSimulator()
        {
            if (Runtime.Arch != Arch.SIMULATOR)
            {
                return;
            }

            Console.WriteLine("WARNING: You will not be able to receive push notifications in the simulator.");
        }

        [Export("registrationSucceededForChannelID:deviceToken:")]
        public void RegistrationSucceeded(string channelID, string deviceToken)
        {
            NSNotificationCenter.DefaultCenter.PostNotificationName("channelIDUpdated", this);
        }

    }
}
