/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;


namespace UrbanAirship.Portable
{
	public interface IAirship
	{
		bool UserNotificationsEnabled
		{
			get; set;
		}

		IEnumerable<string> Tags
		{
			get;
		}

		string ChannelId
		{
			get;
		}

		bool LocationEnabled
		{
			get; set;
		}

		bool BackgroundLocationAllowed
		{
			get; set;
		}

		string NamedUser
		{
			get; set;
		}

		Push.TagEditor EditDeviceTags();

		void AddCustomEvent(Analytics.CustomEvent customEvent);

		void AssociateIdentifier(string key, string identifier);

		void DisplayMessageCenter();

		int MessageCenterUnreadCount
		{
			get;
		}

		int MessageCenterCount
		{
			get;
		}

		Push.TagGroupsEditor EditNamedUserTagGroups();

		Push.TagGroupsEditor EditChannelTagGroups();
	}
}
