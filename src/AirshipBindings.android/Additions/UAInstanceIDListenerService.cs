using System;
using Android.App;

namespace UrbanAirship.Push
{
	[Service(Exported = false)]
	[IntentFilter (new[]{"com.google.android.gms.iid.InstanceID"})]
	public partial class UAInstanceIDListenerService
	{
		
	}
}

