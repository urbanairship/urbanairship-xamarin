/*
 Copyright Airship and Contributors
*/

using System;

using Android.App;
using Android.OS;

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

