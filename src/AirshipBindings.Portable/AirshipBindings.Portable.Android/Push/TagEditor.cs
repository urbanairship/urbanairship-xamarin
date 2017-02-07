/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using UrbanAirship;

namespace AirshipBindings.Portable.Push
{
	public partial class TagEditor
	{
		public TagEditor Clear()
		{
			UAirship.Shared().PushManager.EditTags().Clear();
			return this;
		}
	}
}
