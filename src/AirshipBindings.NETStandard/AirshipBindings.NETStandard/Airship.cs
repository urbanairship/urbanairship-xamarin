/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;

namespace UrbanAirship.NETStandard
{
    public class Airship : IAirship
    {
        private const string BaitWithoutSwitchMessage = "The empty .NET Standard implementation for Airship was loaded. Check that you have added the urbanairship.netstandard package to each of your platform-specific projects.";   

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
            get { throw new NotImplementedException(BaitWithoutSwitchMessage); }
            set { throw new NotImplementedException(BaitWithoutSwitchMessage); }
        }

        /// <summary>
        /// Indicates whether data collection is enabled.
        /// </summary>
        /// <value><c>true</c> if data collection is enabled; otherwise, <c>false</c>.</value>
        public bool DataCollectionEnabled
        {
            get { throw new NotImplementedException(BaitWithoutSwitchMessage); }
            set { throw new NotImplementedException(BaitWithoutSwitchMessage); }
        }

        /// <summary>
        /// Indicates whether push token registration is enabled.
        /// </summary>
        /// <value><c>true</c> if push token registration is enabled; otherwise, <c>false</c>.</value>
        public bool PushTokenRegistrationEnabled
        {
            get { throw new NotImplementedException(BaitWithoutSwitchMessage); }
            set { throw new NotImplementedException(BaitWithoutSwitchMessage); }
        }

        /// <summary>
        /// Gets the tags currently set for the device.
        /// </summary>
        /// <value>The tags.</value>
        public IEnumerable<string> Tags
        {
            get { throw new NotImplementedException(BaitWithoutSwitchMessage); }
        }

        /// <summary>
        /// Get the channel ID for the device.
        /// </summary>
        /// <value>The channel identifier.</value>
        public string ChannelId
        {
            get { throw new NotImplementedException(BaitWithoutSwitchMessage); }
        }

        /// <summary>
        /// Gets or sets the named user ID.
        /// </summary>
        /// <value>The named user ID.</value>
        public string NamedUser
        {
            get { throw new NotImplementedException(BaitWithoutSwitchMessage); }
            set { throw new NotImplementedException(BaitWithoutSwitchMessage); }
        }

        /// <summary>
        /// Edit the device tags.
        /// </summary>
        /// <returns>A <see cref="UrbanAirship.NETStandard.Channel.TagEditor">TagEditor</see>
        /// for editing device tags.</returns>
        public Channel.TagEditor EditDeviceTags()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Add a custom event
        /// </summary>
        /// <param name="customEvent">The <see cref="UrbanAirship.NETStandard.Analytics.CustomEvent">CustomEvent</see>
        /// to add.</param>
        public void AddCustomEvent(Analytics.CustomEvent customEvent)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// track a screen for a specific app screen
        /// </summary>
        /// <param name="screen">The screen's identifier.
        /// to add.</param>
        public void TrackScreen(string screen)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Associate a custom identifier. Previous identifiers will be replaced by the new identifiers
        /// each time AssociateIdentifier is called. It is a set operation.
        /// </summary>
        /// <param name="key">The custom key for the identifier.</param>
        /// <param name="identifier">The value of the identifier, or `null` to remove the identifier.</param>
        public void AssociateIdentifier(string key, string identifier)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Displays the message center.
        /// </summary>
        public void DisplayMessageCenter()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Displays a specific message.
        /// </summary>
        /// <param name="messageId">The identifier for the message to display.</param>
        public void DisplayMessage(string messageId)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Get the message center unread count.
        /// </summary>
        /// <value>The message center unread count.</value>
        public int MessageCenterUnreadCount
        {
            get { throw new NotImplementedException(BaitWithoutSwitchMessage); }
            private set { throw new NotImplementedException(BaitWithoutSwitchMessage); }
        }

        /// <summary>
        /// Get the total count of message center messages.
        /// </summary>
        /// <value>The message center count.</value>
        public int MessageCenterCount
        {
            get { throw new NotImplementedException(BaitWithoutSwitchMessage); }
            private set { throw new NotImplementedException(BaitWithoutSwitchMessage); }
        }

        /// <summary>
        /// Get the list of messages contained in the messages center.
        /// </summary>
        /// <value>The list of message.</value>
        public List<MessageCenter.Message> InboxMessages
        {
            get { throw new NotImplementedException(BaitWithoutSwitchMessage); }
        }

        /// <summary>
        /// Edit channel attributes.
        /// </summary>
        /// <returns>An <see cref="UrbanAirship.NETStandard.Attributes.AttributeEditor">AttributeEditor</see>
        /// for channel attributes.</returns>
        public Attributes.AttributeEditor EditAttributes()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Returns an editor for named user tag groups.
        /// </summary>
        /// <returns>A <see cref="UrbanAirship.NETStandard.Channel.TagGroupsEditor">TagGroupsEditor</see>
        /// for named user tag groups.</returns>
        public Channel.TagGroupsEditor EditNamedUserTagGroups()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Returns an editor for channel tag groups.
        /// </summary>
        /// <returns>A <see cref="UrbanAirship.NETStandard.Channel.TagGroupsEditor">TagGroupsEditor</see>
        /// for channel tag groups.</returns>
        public Channel.TagGroupsEditor EditChannelTagGroups()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Add/remove the deep link event listener.
        /// </summary>
        /// <value>The deep link event listener.</value>
        public delegate void DeepLinkHandler(string deepLink);

        public event DeepLinkHandler OnDeepLinkReceived
        {
            add
            {
                throw new NotImplementedException(BaitWithoutSwitchMessage);
            }

            remove
            {
                throw new NotImplementedException(BaitWithoutSwitchMessage);
            }
        }

        /// <summary>
        /// Add/remove the Inbox updated event listener.
        /// </summary>
        /// <value>The Inbox updated listener.</value>
        public delegate void InboxHandler();

        public event InboxHandler OnMessageCenterUpdated
        {
            add
            {
                throw new NotImplementedException(BaitWithoutSwitchMessage);
            }

            remove
            {
                throw new NotImplementedException(BaitWithoutSwitchMessage);
            }
        }
    }
}
