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
			UAirship.Push.Tags = new string[] { };
			return this;
		}
	}
}
