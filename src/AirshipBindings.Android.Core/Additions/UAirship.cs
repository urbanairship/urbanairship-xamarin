/*
 Copyright Airship and Contributors
*/

using System;

using Android.App;
using Android.OS;
using System.Reflection;
using UrbanAirship.Analytics;

[assembly: Permission(Name = "@PACKAGE_NAME@.permission.UA_DATA", ProtectionLevel=Android.Content.PM.Protection.Signature)]
[assembly: UsesPermission(Name = "@PACKAGE_NAME@.permission.UA_DATA")]

[assembly: UsesPermission(Name = "android.permission.INTERNET")]
[assembly: UsesPermission(Name = "android.permission.ACCESS_NETWORK_STATE")]
[assembly: UsesPermission(Name = "android.permission.WAKE_LOCK")]
[assembly: UsesPermission(Name = "android.permission.VIBRATE")]
namespace UrbanAirship
{
	public partial class UAirship
	{
		static UAirship()
		{
			UAirship.Shared(new AirshipReadyCallback((UAirship airship) =>
			{
				Version version = Assembly.GetExecutingAssembly().GetName().Version;
				airship.Analytics.RegisterSDKExtension(AnalyticsClass.ExtensionXamarin, version.ToString());
			}));
		}
		public static void TakeOff(Application application, Action<UAirship> callback)
		{
			TakeOff (application, new AirshipReadyCallback (callback));
		}

		public static void TakeOff(Application application, AirshipConfigOptions configOptions, Action<UAirship> callback)
		{
			TakeOff (application, configOptions, new AirshipReadyCallback (callback));
		}

		public static ICancelable Shared (Action<UAirship> callback, Looper looper)
		{
			return Shared (looper, new AirshipReadyCallback (callback));
		}

		public static ICancelable Shared (Action<UAirship> callback)
		{
			return Shared (new AirshipReadyCallback (callback));
		}

		internal class AirshipReadyCallback : Java.Lang.Object, IOnReadyCallback
		{
			Action<UAirship> callback;
			public AirshipReadyCallback(Action<UAirship> callback)
			{
				this.callback = callback;
			}

			public void OnAirshipReady (UAirship airship) {
				if (callback != null)
				{
					callback.Invoke (airship);
				}
			}
		}
	}
}

