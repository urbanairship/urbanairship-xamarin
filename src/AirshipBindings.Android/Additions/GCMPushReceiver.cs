/*
 Copyright 2016 Urban Airship and Contributors
*/

using System;
using Android.Content;
using Android.App;

[assembly: Permission(Name = "@PACKAGE_NAME@.permission.C2D_MESSAGE", ProtectionLevel=Android.Content.PM.Protection.Signature)]
[assembly: UsesPermission(Name = "@PACKAGE_NAME@.permission.C2D_MESSAGE")]
[assembly: UsesPermission(Name = "com.google.android.c2dm.permission.RECEIVE")]

namespace UrbanAirship.Push
{

	[Android.Runtime.Preserve (AllMembers = true)]
	[BroadcastReceiver (Exported = true, Permission = "com.google.android.c2dm.permission.SEND")]
	[IntentFilter (new[]{"com.google.android.c2dm.intent.RECEIVE", "com.google.android.c2dm.intent.REGISTRATION"}, 
		Categories = new[]{"@PACKAGE_NAME@"})]
	public partial class GcmPushReceiver
	{

	}
}

