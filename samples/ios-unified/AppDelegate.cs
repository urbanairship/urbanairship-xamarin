/*
 Copyright 2016 Urban Airship and Contributors
*/

using Foundation;
using UIKit;
using UrbanAirship;
using System.Threading.Tasks;

namespace Sample
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window {
			get;
			set;
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			// Bootstrap the Urban Airship SDK
			UAirship.TakeOff ();

			// Enable visible push notifications
			UAirship.Push.UserPushNotificationsEnabled = true;

			return true;
		}
	}
}
