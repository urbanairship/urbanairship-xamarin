/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using Android.App;
using Android.Content;

namespace UrbanAirship.Actions
{

	[Android.Runtime.Preserve (AllMembers = true)]
	[Activity(Exported = false, Theme = "@style/UrbanAirship.LandingPageActivity")]
	[IntentFilter (new string[]{"com.urbanairship.actions.SHOW_LANDING_PAGE_INTENT_ACTION"}, 
		Categories = new string[]{Intent.CategoryDefault},
		DataScheme = "http")]
	[IntentFilter (new string[]{"com.urbanairship.actions.SHOW_LANDING_PAGE_INTENT_ACTION"}, 
		Categories = new string[]{Intent.CategoryDefault},
		DataScheme = "https")]
	[IntentFilter (new string[]{"com.urbanairship.actions.SHOW_LANDING_PAGE_INTENT_ACTION"}, 
		Categories = new string[]{Intent.CategoryDefault},
		DataScheme = "message")]
	[MetaData ("com.urbanairship.push.iam.EXCLUDE_FROM_AUTO_SHOW", Value = "true")]
	[MetaData ("com.urbanairship.action.LANDING_PAGE_VIEW", Resource = "@layout/ua_activity_landing_page")]
	public partial class LandingPageActivity
	{
	}
}

