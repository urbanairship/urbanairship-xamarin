/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;

namespace UrbanAirship.Portable
{
	public interface IUAirshipPlugin
	{
		bool UserNotificationsEnabled
		{
			get; set;
		}

		IEnumerable<string> Tags
		{
			get;
		}

		string Alias
		{
			get; set;
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

		void EditDeviceTags(List<string> addTags, List<string> removeTags);

		void AddCustomEvent(Portable.Analytics.CustomEvent customEvent);

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

		void EditNamedUserTagGroups(Dictionary<string, Dictionary<string, List<string>>> payload);

		void EditChannelTagGroups(Dictionary<string, Dictionary<string, List<string>>> payload);
	}
}
