/*
 Copyright 2016 Urban Airship and Contributors
*/

using System;
using Android.Content;

namespace UrbanAirship
{

	[Android.Runtime.Preserve (AllMembers = true)]
	[ContentProvider (new[]{"@PACKAGE_NAME@.urbanairship.provider"},
		Exported = true,
		Permission = "@PACKAGE_NAME@.permission.UA_DATA")]		
	public partial class UrbanAirshipProvider
	{
		
	}
}

