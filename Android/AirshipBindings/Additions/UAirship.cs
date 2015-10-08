using System;
using Android.App;
using Android.Runtime;

[assembly: Permission(Name = "@PACKAGE_NAME@.permission.UA_DATA", ProtectionLevel=Android.Content.PM.Protection.Signature)]
[assembly: UsesPermission(Name = "@PACKAGE_NAME@.permission.UA_DATA")]

[assembly: UsesPermission(Name = "android.permission.INTERNET")]
[assembly: UsesPermission(Name = "android.permission.ACCESS_NETWORK_STATE")]
[assembly: UsesPermission(Name = "android.permission.WAKE_LOCK")]
[assembly: UsesPermission(Name = "android.permission.VIBRATE")]
[assembly: UsesPermission(Name = "android.permission.INTERNET")]
namespace UrbanAirship
{
	public partial class UAirship
	{
	}
}

