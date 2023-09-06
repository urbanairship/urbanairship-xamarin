/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;


namespace UrbanAirship.NETStandard
{

    /// <summary>
    /// Arguments for Channel creation events.
    /// </summary>
    public class ChannelEventArgs : EventArgs
    {
        public string ChannelId { get; private set; }

        public ChannelEventArgs(string channelId)
        {
            ChannelId = channelId;
        }
    }

    /// <summary>
    /// Arguments for push notification status update events.
    /// </summary>
    public class PushNotificationStatusEventArgs : EventArgs
    {
        /// <summary>
        /// Indicatees whether user notifications are enabled via <c>PushManager</c>.
        /// </summary>
        /// <value>
        /// <c>true</c> if user notifications are enabled, else <c>false</c>.
        /// </value>
        public bool IsUserNotificationsEnabled { get; private set; }

        /// <summary>
        /// Indicates whether notifications are allowed for the application at the system level.
        /// </summary>
        /// <value>
        /// <c>true</c> if notifications are allowed, else <c>false</c>.
        /// </value>
        public bool AreNotificationsAllowed { get; private set; }

        /// <summary>
        /// Indicates whether <c>Features.Push</c> is enabled via <c>PrivacyManager</c>.
        /// </summary>
        /// <value>
        /// <c>true</c> if the push feature is enabled, else <c>false</c>.
        /// </value>
        public bool IsPushPrivacyFeatureEnabled { get; private set; }

        /// <summary>
        /// Indicates whether the application has successfully registered a push token.
        /// </summary>
        /// <value>
        /// <c>true</c> if a token was received and registered, else <c>false</c>.
        /// </value>
        public bool IsPushTokenRegistered { get; private set; }

        /// <summary>
        /// Checks if <c>IsUserNotificationsEnabled</c>, <c>AreNotificationsAllowed</c>, and <c>IsPushPrivacyFeatureEnabled</c> is enabled.
        /// </summary>
        public bool IsUserOptedIn { get; private set; }

        /// <summary>
        /// Checks if <c>IsUserOptedIn</c> and <c>IsPushTokenRegistered</c> is enabled.
        /// </summary>
        public bool IsOptIn { get; private set; }

        /// <summary>
        /// Creates push notification status event args.
        /// </summary>
        public PushNotificationStatusEventArgs(bool isUserNotificationsEnabled, bool areNotificationsAllowed, bool isPushPrivacyFeatureEnabled, bool isPushTokenRegistered, bool isUserOptedIn, bool isOptIn)
        {
            IsUserNotificationsEnabled = isUserNotificationsEnabled;
            AreNotificationsAllowed = areNotificationsAllowed;
            IsPushPrivacyFeatureEnabled = isPushPrivacyFeatureEnabled;
            IsPushTokenRegistered = isPushTokenRegistered;
            IsUserOptedIn = isUserOptedIn;
            IsOptIn = isOptIn;
        }
    }

    /// <summary>
    /// Arguments for deep link events.
    /// </summary>
    public class DeepLinkEventArgs : EventArgs
    {
        public string DeepLink { get; internal set; }
        public DeepLinkEventArgs(string deepLink)
        {
            DeepLink = deepLink;
        }
    }

    /// <summary>
    /// Arguments for message center events.
    /// </summary>
    public class MessageCenterEventArgs : EventArgs
    {
        public string MessageId { get; internal set; }
        public MessageCenterEventArgs(string messageId = null)
        {
            MessageId = messageId;
        }
    }

    /// <summary>
    /// Airship Features.
    /// </summary>
    [Flags]
    public enum Features
    {
        None = 0,
        InAppAutomation = 1 << 0,
        MessageCenter = 1 << 1,
        Push = 1 << 2,
        // RETIRED: Chat = 1 << 3,
        Analytics = 1 << 4,
        TagsAndAttributes = 1 << 5,
        Contacts = 1 << 6,
        // RETIRED: Location = 1 << 7,
        All = InAppAutomation | MessageCenter | Push | Analytics | TagsAndAttributes | Contacts
    }

    public interface IAirship
    {
        bool UserNotificationsEnabled
        {
            get; set;
        }

        Features EnabledFeatures
        {
            get; set;
        }

        void EnableFeatures(Features features);

        void DisableFeatures(Features features);

        bool IsFeatureEnabled(Features feature);

        bool IsAnyFeatureEnabled();

        IEnumerable<string> Tags
        {
            get;
        }

        string ChannelId
        {
            get;
        }

        void GetNamedUser(Action<string> namedUser);
        
        string NamedUser
        {
            set;
        }

        /// <summary>
        /// Add/remove the channel creation listener.
        /// </summary>
        event EventHandler<ChannelEventArgs> OnChannelCreation;

        /// <summary>
        /// Add/remove the push notification status listener.
        /// </summary>
        event EventHandler<PushNotificationStatusEventArgs> OnPushNotificationStatusUpdate;

        /// <summary>
        /// Add/remove the deep link listener.
        /// </summary>
        event EventHandler<DeepLinkEventArgs> OnDeepLinkReceived;

        /// <summary>
        /// Add/remove the message center display listener.
        /// </summary>
        event EventHandler<MessageCenterEventArgs> OnMessageCenterDisplay;

        Channel.TagEditor EditDeviceTags();

        void AddCustomEvent(Analytics.CustomEvent customEvent);

        void TrackScreen(string screen);

        void AssociateIdentifier(string key, string identifier);

        void DisplayMessageCenter();

        void MessageCenterUnreadCount(Action<int> unreadMessageCount);

        void MessageCenterCount(Action<int> messageCount);

        List<MessageCenter.Message> InboxMessages
        {
            get;
        }

        Channel.TagGroupsEditor EditNamedUserTagGroups();

        Channel.TagGroupsEditor EditChannelTagGroups();

        Attributes.AttributeEditor EditAttributes();

        event EventHandler OnMessageCenterUpdated;

        Attributes.AttributeEditor EditChannelAttributes();

        Attributes.AttributeEditor EditNamedUserAttributes();

        bool InAppAutomationPaused
        {
            get; set;
        }

        TimeSpan InAppAutomationDisplayInterval
        {
            get; set;
        }
    }
}
