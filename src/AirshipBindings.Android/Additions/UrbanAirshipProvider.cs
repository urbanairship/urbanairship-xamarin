using System;
using Android.Content;

namespace UrbanAirship
{

	[Android.Runtime.Preserve (AllMembers = true)]
	[ContentProvider (new[]{"@PACKAGE_NAME@.urbanairship.provider"},
		Exported = true,
		MultiProcess = true,
		Permission = "@PACKAGE_NAME@.permission.UA_DATA")]		
	public partial class UrbanAirshipProvider
	{
		
	}
}

