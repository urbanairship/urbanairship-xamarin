/*
 Copyright 2016 Urban Airship and Contributors
*/

using System;
using Android.App;

namespace UrbanAirship.Push
{

	[Android.Runtime.Preserve (AllMembers = true)]
	[Service(Exported = false)]
	[IntentFilter (new[]{"com.google.android.gms.iid.InstanceID"})]
	public partial class UAInstanceIDListenerService
	{
		
	}
}

