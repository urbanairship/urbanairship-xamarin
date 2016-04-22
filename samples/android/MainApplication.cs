/*
 Copyright 2016 Urban Airship and Contributors
*/

using System;
using Android.App;
using UrbanAirship;
using UrbanAirship.Push;
using UrbanAirship.Analytics;

using Android.Runtime;


namespace Sample
{
	[Application]
	public class MainApp : Application
	{

		public MainApp(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
		{
			
		}

		public override void OnCreate()
		{
			base.OnCreate();

			UAirship.TakeOff(this, (UAirship airship) => {
				airship.PushManager.UserNotificationsEnabled = true;
				airship.PushManager.Tags = new String[]{ "android-xamarin" };
			});
		}
	}
}

