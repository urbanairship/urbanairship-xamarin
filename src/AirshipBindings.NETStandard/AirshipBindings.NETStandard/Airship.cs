/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;

namespace UrbanAirship.NETStandard
{
    public delegate void DeepLinkHandler(string deepLink);

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
        /// Indicates whether user notifications are enabled.
        /// </summary>
        /// <value><c>true</c> if notifications are enabled; otherwise, <c>false</c>.</value>
        public bool UserNotificationsEnabled
        {
            get { throw new NotImplementedException(BaitWithoutSwitchMessage); }
            set { throw new NotImplementedException(BaitWithoutSwitchMessage); }
        }

        /// <summary>
        /// Currently enabled features.
        /// </summary>
        /// <value>The currently enabled features</value>
        public Features EnabledFeatures
        {
            get { throw new NotImplementedException(BaitWithoutSwitchMessage); }
            set { throw new NotImplementedException(BaitWithoutSwitchMessage); }
        }

        /// <summary>
        /// Enables particular features.
        /// </summary>
        /// <param name="features">The features.</param>
        public void EnableFeatures(Features features)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);

        }

        /// <summary>
        /// Disables particular features.
        /// </summary>
        /// <param name="features">The features.</param>
        public void DisableFeatures(Features features)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);

        }

        /// <summary>
        /// Indicates whether particular features are enabled.
        /// </summary>
        /// <param name="features">The features.</param>
        /// <value><c>true</c> if the features are enabled; otherwise, <c>false</c>.</value>
        public bool IsFeatureEnabled(Features features)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);

        }

        /// <summary>
        /// Indicates whether any feature is enabled.
        /// </summary>
        /// <value><c>true</c> if any feature is enabled; otherwise, <c>false</c>.</value>
        public bool IsAnyFeatureEnabled()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);

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
        /// Gets the named user.
        /// </summary>
        /// <value>Returns the named user.</value>
        public void GetNamedUser(Action<string> namedUser)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Reset the named user.
        /// </summary>
        public void ResetContact()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Identifiy the named user.
        /// </summary>
        public void IdentifyContact(string namedUserId)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
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
        /// Mark a specific message as read
        /// </summary>
        /// <param name="messageId">The identifier for the message to mark as read.</param>
        public void MarkMessageRead(string messageId)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Delete a specific message
        /// </summary>
        /// <param name="messageId">The identifier for the message to delete.</param>
        public void DeleteMessage(string messageId)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Get the message center unread count.
        /// </summary>
        /// <value>Returns the message center unread count.</value>
        public void MessageCenterUnreadCount(Action<int> count)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Get the total count of message center messages.
        /// </summary>
        /// <value>Returns the message center count.</value>
        public void MessageCenterCount(Action<int> count)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Get the list of messages contained in the messages center.
        /// </summary>
        /// <value>The list of message.</value>
        public void InboxMessages(Action<List<MessageCenter.Message>> messages)
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }
        /// <summary>
        /// Edit channel attributes.
        /// Deprecated : use <see cref="EditChannelAttributes">EditChannelAttributes()</see> instead.
        /// </summary>
        /// <returns>An <see cref="UrbanAirship.NETStandard.Attributes.AttributeEditor">AttributeEditor</see>
        /// for channel attributes.</returns>
        [Obsolete("This method is deprecated, use EditChannelAttributes() instead.")]
        public Attributes.AttributeEditor EditAttributes()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Edit channel attributes.
        /// </summary>
        /// <returns>An <see cref="UrbanAirship.NETStandard.Attributes.AttributeEditor">AttributeEditor</see>
        /// for channel attributes.</returns>
        public Attributes.AttributeEditor EditChannelAttributes()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Edit named user attributes.
        /// </summary>
        /// <returns>An <see cref="UrbanAirship.NETStandard.Attributes.AttributeEditor">AttributeEditor</see>
        /// for named user attributes.</returns>
        public Attributes.AttributeEditor EditContactAttributes()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Returns an editor for named user tag groups.
        /// </summary>
        /// <returns>A <see cref="UrbanAirship.NETStandard.Channel.TagGroupsEditor">TagGroupsEditor</see>
        /// for named user tag groups.</returns>
        public Channel.TagGroupsEditor EditContactTagGroups()
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
        /// Returns an editor for channel subscription lists.
        /// </summary>
        /// <returns>A <see cref="UrbanAirship.NETStandard.Channel.SubscriptionListEditor">SubscriptionListEditor</see>
        /// for channel subscription lists.</returns>
        public Channel.SubscriptionListEditor EditChannelSubscriptionLists()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Returns an editor for contact subscription lists.
        /// </summary>
        /// <returns>A <see cref="UrbanAirship.NETStandard.Channel.SubscriptionListEditor">SubscriptionListEditor</see>
        /// for channel subscription lists.</returns>
        public Contact.SubscriptionListEditor EditContactSubscriptionLists()
        {
            throw new NotImplementedException(BaitWithoutSwitchMessage);
        }

        /// <summary>
        /// Add/remove the deep link event listener.
        /// </summary>
        /// <value>The deep link event listener.</value>
        public event EventHandler<DeepLinkEventArgs> OnDeepLinkReceived
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
        public event EventHandler OnMessageCenterUpdated
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
        /// Add/remove the message center display event listener.
        /// </summary>
        /// <value>The message center display listener.</value>
        public event EventHandler<MessageCenterEventArgs> OnMessageCenterDisplay
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
        /// Add/remove the channel creation event listener.
        /// </summary>
        /// <value>The channel creation event listener.</value>
        public event EventHandler<ChannelEventArgs> OnChannelCreation
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
        /// Add/remote the push notification status listener.
        /// </summary>
        /// <value>The push notification status update event listener.</value>
        public event EventHandler<PushNotificationStatusEventArgs> OnPushNotificationStatusUpdate
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
        /// Gets or sets whether In-App Automation is enabled.
        /// </summary>
        /// <value>Whether In-App Automation is enabled.</value>
        public bool InAppAutomationEnabled
        {
            get
            {
                throw new NotImplementedException(BaitWithoutSwitchMessage);
            }

            set
            {
                throw new NotImplementedException(BaitWithoutSwitchMessage);
            }
        }

        /// <summary>
        /// Gets or sets whether In-App Automation is paused.
        /// </summary>
        /// <value>Whether In-App Automation is paused.</value>
        public bool InAppAutomationPaused
        {
            get
            {
                throw new NotImplementedException(BaitWithoutSwitchMessage);
            }

            set
            {
                throw new NotImplementedException(BaitWithoutSwitchMessage);
            }
        }

        /// <summary>
        /// Gets or sets the In-App Automation display interval.
        /// </summary>
        /// <value>The display interval.</value>
        public TimeSpan InAppAutomationDisplayInterval
        {
            get
            {
                throw new NotImplementedException(BaitWithoutSwitchMessage);
            }

            set
            {
                throw new NotImplementedException(BaitWithoutSwitchMessage);
            }
        }
    }
}
