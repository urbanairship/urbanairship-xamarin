using System;
using Android.Content;
using Android.App;

namespace UrbanAirship
{
	[BroadcastReceiver (Exported = false)]
	[IntentFilter (new string[]{"com.urbanairship.push.OPENED"}, 
		Categories = new string[]{"@PACKAGE_NAME@"},
		Priority = -999)]
	public partial class CoreReceiver
	{
	}
}

