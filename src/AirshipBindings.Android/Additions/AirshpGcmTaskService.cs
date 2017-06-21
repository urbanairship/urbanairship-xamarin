/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using Android.App;
using Android.Content;

namespace UrbanAirship.Job
{
	[Android.Runtime.Preserve(AllMembers = true)]
	[Service]
	[IntentFilter(new string[] { "com.google.android.gms.gcm.ACTION_TASK_READY" })]
	public partial class AirshipGcmTaskService
	{
	}
}

