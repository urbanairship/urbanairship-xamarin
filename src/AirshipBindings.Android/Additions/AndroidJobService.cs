/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using Android.App;
using Android.Content;

[assembly: UsesPermission(Name = "android.permission.BIND_JOB_SERVICE")]
namespace UrbanAirship.Job
{

	[Android.Runtime.Preserve(AllMembers = true)]
	[Service()]
	public partial class AndroidJobService
	{
	}
}

