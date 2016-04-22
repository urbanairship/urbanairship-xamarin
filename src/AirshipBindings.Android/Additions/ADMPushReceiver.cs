/*
 Copyright 2016 Urban Airship and Contributors
*/

using System;
using Android.Content;
using Android.App;

[assembly: Permission(Name = "@PACKAGE_NAME@.permission.RECEIVE_ADM_MESSAGE", ProtectionLevel=Android.Content.PM.Protection.Signature)]
[assembly: UsesPermission(Name = "@PACKAGE_NAME@.permission.RECEIVE_ADM_MESSAGE")]
[assembly: UsesPermission(Name = "com.amazon.device.messaging.permission.RECEIVE")]

namespace UrbanAirship.Push
{

	[Android.Runtime.Preserve (AllMembers = true)]
	[BroadcastReceiver (Permission = "com.amazon.device.messaging.permission.SEND")]
	[IntentFilter (new string[]{"com.amazon.device.messaging.intent.REGISTRATION", "com.amazon.device.messaging.intent.RECEIVE"}, 
		Categories = new string[]{"@PACKAGE_NAME@"})]
	public partial class AdmPushReceiver
	{
	}
}

