/*
 Copyright 2016 Urban Airship and Contributors
*/

using System;
using Android.Content;
using Android.App;

namespace UrbanAirship
{

	[Android.Runtime.Preserve (AllMembers = true)]
	[BroadcastReceiver (Exported = false)]
	[IntentFilter (new string[]{"com.urbanairship.push.OPENED"}, 
		Categories = new string[]{"@PACKAGE_NAME@"},
		Priority = -999)]
	public partial class CoreReceiver
	{
	}
}

