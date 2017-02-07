/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;

namespace UrbanAirship.Portable
{
	public class UAirship
	{
		private IUAirshipPlugin plugin;

		private static UAirship sharedAirship = new UAirship();

		/// <summary>
		/// Gets the shared UAirship instance.
		/// </summary>
		/// <value>The shared UAirship instance.</value>
		public static UAirship Shared
		{
			get
			{
				return sharedAirship;
			}
		}

		private UAirship()
		{
#if __IOS__
			plugin = new UAirshipPluginIOS();
#elif __ANDROID__
			plugin = new UAirshipPluginAndroid();
#else
			plugin = new StubbedPlugin();
#endif
		}

		/// <summary>
		/// Indicates whether notifications are enabled.
		/// </summary>
		/// <value><c>true</c> if notifications are enabled; otherwise, <c>false</c>.</value>
		public bool UserNotificationsEnabled
		{
			get
			{
				return plugin.UserNotificationsEnabled;
			}

			set
			{
				plugin.UserNotificationsEnabled = value;
			}
		}

		/// <summary>
		/// Gets the tags currently set for the device.
		/// </summary>
		/// <value>The tags.</value>
		public IEnumerable<string> Tags
		{
			get
			{
				return plugin.Tags;
			}
		}

		/// <summary>
		/// Get or set the alias for the device.
		/// </summary>
		/// <value>The alias.</value>
		public string Alias
		{
			get
			{
				return plugin.Alias;
			}

			set
			{
				plugin.Alias = value;
			}
		}

		/// <summary>
		/// Get the channel ID for the device.
		/// </summary>
		/// <value>The channel identifier.</value>
		public string ChannelId
		{
			get
			{
				return plugin.ChannelId;
			}
		}

		/// <summary>
		/// Indicates whether location is enabled
		/// </summary>
		/// <value><c>true</c> if location is enabled; otherwise, <c>false</c>.</value>
		public bool LocationEnabled
		{
			get
			{
				return plugin.LocationEnabled;
			}

			set
			{
				plugin.LocationEnabled = value;
			}
		}

		/// <summary>
		/// Indicates whether background location updates are allowed.
		/// </summary>
		/// <value><c>true</c> if background location updates are allowed; otherwise, <c>false</c>.</value>
		public bool BackgroundLocationAllowed
		{
			get
			{
				return plugin.BackgroundLocationAllowed;
			}

			set
			{
				plugin.BackgroundLocationAllowed = value;
			}
		}

		/// <summary>
		/// Gets or sets the named user ID.
		/// </summary>
		/// <value>The named user ID.</value>
		public string NamedUserId
		{
			get
			{
				return plugin.NamedUser;
			}

			set
			{
				plugin.NamedUser = value;
			}
		}

		/// <summary>
		/// Edit the device tags.
		/// </summary>
		public Push.TagEditor EditDeviceTags()
		{
			return new Push.TagEditor(plugin.EditDeviceTags);
		}

		/// <summary>
		/// Add a custom event
		/// </summary>
		/// <param name="customEvent">The custom event to add.</param>
		public void AddCustomEvent(Portable.Analytics.CustomEvent customEvent) {
			plugin.AddCustomEvent(customEvent);
		}

		/// <summary>
		/// Associate a custom identifier. Previous identifiers will be replaced by the new identifiers 
		/// each time AssociateIdentifier is called. It is a set operation.
		/// </summary>
		/// <param name="key">The custom key for the identifier.</param>
		/// <param name="identifier">The value of the identifier, or `null` to remove the identifier.</param>
		public void AssociateIdentifier(string key, string identifier) 
		{
			plugin.AssociateIdentifier(key, identifier);
		}

		/// <summary>
		/// Displays the message center.
		/// </summary>
		public void DisplayMessageCenter()
		{
			plugin.DisplayMessageCenter();
		}

		/// <summary>
		/// Get the message center unread count.
		/// </summary>
		/// <value>The message center unread count.</value>
		public int MessageCenterUnreadCount
		{
			get
			{
				return plugin.MessageCenterUnreadCount;
			}
		}

		/// <summary>
		/// Get the total count of message center messages.
		/// </summary>
		/// <value>The message center count.</value>
		public int MessageCenterCount
		{
			get
			{
				return plugin.MessageCenterCount;
			}
		}

		/// <summary>
		/// Returns an editor for named user tag groups.
		/// </summary>
		/// <returns>A TagGroupEditor for named user tag groups.</returns>
		public Push.TagGroupEditor EditNamedUserTagGroup()
		{
			return new Push.TagGroupEditor(plugin.EditNamedUserTagGroups);
		}

		/// <summary>
		/// Returns an editor for channel tag groups.
		/// </summary>
		/// <returns>A TagGroupEditor for channel tag groups.</returns>
		public Push.TagGroupEditor EditChannelTagGroups()
		{
			return new Push.TagGroupEditor(plugin.EditChannelTagGroups);
		}
	}
}
