using System;
using Android.App;

namespace UrbanAirship.Job
{
	[Android.Runtime.Preserve(AllMembers = true)]
	[Service(Exported=true, Permission="com.google.android.gms.permission.BIND_NETWORK_TASK_SERVICE")]
	[IntentFilter(new[] { "com.google.android.gms.gcm.ACTION_TASK_READY" })]
	public partial class AirshipGcmTaskService
	{
	}
}
