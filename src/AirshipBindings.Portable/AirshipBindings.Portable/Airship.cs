/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;


namespace UrbanAirship.Portable
{
	public class Airship : IAirship
	{
		private static Airship sharedAirship = new Airship();

		/// <summary>
		/// Gets the shared UAirship instance.
		/// </summary>
		/// <value>The shared UAirship instance.</value>
		public static Airship Instance
		{
			get
			{
				return sharedAirship;
			}
		}

		/// <summary>
		/// Indicates whether notifications are enabled.
		/// </summary>
		/// <value><c>true</c> if notifications are enabled; otherwise, <c>false</c>.</value>
		public bool UserNotificationsEnabled
		{
			get { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
			set { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
		}

		/// <summary>
		/// Gets the tags currently set for the device.
		/// </summary>
		/// <value>The tags.</value>
		public IEnumerable<string> Tags
		{
			get { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
		}

		/// <summary>
		/// Get the channel ID for the device.
		/// </summary>
		/// <value>The channel identifier.</value>
		public string ChannelId
		{
			get { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
		}

		/// <summary>
		/// Indicates whether location is enabled
		/// </summary>
		/// <value><c>true</c> if location is enabled; otherwise, <c>false</c>.</value>
		public bool LocationEnabled
		{
			get { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
			set { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
		}

		/// <summary>
		/// Indicates whether background location updates are allowed.
		/// </summary>
		/// <value><c>true</c> if background location updates are allowed; otherwise, <c>false</c>.</value>
		public bool BackgroundLocationAllowed
		{
			get { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
			set { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
		}

		/// <summary>
		/// Gets or sets the named user ID.
		/// </summary>
		/// <value>The named user ID.</value>
		public string NamedUser
		{
			get { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
			set { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
		}

		/// <summary>
		/// Edit the device tags.
		/// </summary>
		/// <returns>A <see cref="UrbanAirship.Portable.Push.TagEditor">TagEditor</see>
                /// for editing device tags.</returns>
		public Push.TagEditor EditDeviceTags()
		{
			throw new NotImplementedException(PCL.BaitWithoutSwitchMessage);
		}

		/// <summary>
		/// Add a custom event
		/// </summary>
		/// <param name="customEvent">The <see cref="UrbanAirship.Portable.Analytics.CustomEvent">CustomEvent</see>
                /// to add.</param>
		public void AddCustomEvent(Analytics.CustomEvent customEvent)
		{
			throw new NotImplementedException(PCL.BaitWithoutSwitchMessage);
		}

		/// <summary>
		/// Associate a custom identifier. Previous identifiers will be replaced by the new identifiers
		/// each time AssociateIdentifier is called. It is a set operation.
		/// </summary>
		/// <param name="key">The custom key for the identifier.</param>
		/// <param name="identifier">The value of the identifier, or `null` to remove the identifier.</param>
		public void AssociateIdentifier(string key, string identifier)
		{
			throw new NotImplementedException(PCL.BaitWithoutSwitchMessage);
		}

		/// <summary>
		/// Displays the message center.
		/// </summary>
		public void DisplayMessageCenter()
		{
			throw new NotImplementedException(PCL.BaitWithoutSwitchMessage);
		}

		/// <summary>
		/// Get the message center unread count.
		/// </summary>
		/// <value>The message center unread count.</value>
		public int MessageCenterUnreadCount
		{
			get { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
			private set { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
		}

		/// <summary>
		/// Get the total count of message center messages.
		/// </summary>
		/// <value>The message center count.</value>
		public int MessageCenterCount
		{
			get { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
			private set { throw new NotImplementedException(PCL.BaitWithoutSwitchMessage); }
		}

		/// <summary>
		/// Returns an editor for named user tag groups.
		/// </summary>
		/// <returns>A <see cref="UrbanAirship.Portable.Push.TagGroupsEditor">TagGroupsEditor</see>
                /// for named user tag groups.</returns>
		public Push.TagGroupsEditor EditNamedUserTagGroups()
		{
			throw new NotImplementedException(PCL.BaitWithoutSwitchMessage);
		}

		/// <summary>
		/// Returns an editor for channel tag groups.
		/// </summary>
		/// <returns>A <see cref="UrbanAirship.Portable.Push.TagGroupsEditor">TagGroupsEditor</see>
                /// for channel tag groups.</returns>
		public Push.TagGroupsEditor EditChannelTagGroups()
		{
			throw new NotImplementedException(PCL.BaitWithoutSwitchMessage);
		}
	}
}
