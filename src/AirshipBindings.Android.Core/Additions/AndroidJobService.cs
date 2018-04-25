/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using Android.App;
using Android.Content;

namespace UrbanAirship.Job
{

	[Android.Runtime.Preserve(AllMembers = true)]
    [Service(Exported = false, Permission = "android.permission.BIND_JOB_SERVICE")]
	public partial class AndroidJobService
	{
	}
}

