/* Copyright Airship and Contributors */

using AirshipDotNet.Attributes;
using AirshipDotNet.Channel;

namespace AirshipDotNet
{

    /// <summary>
    /// Arguments for Channel creation and update events.
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
    /// Arguments for Message Center events.
    /// </summary>
    public class MessageCenterEventArgs : EventArgs
    {
        public string? MessageId { get; internal set; }
        public MessageCenterEventArgs(string? messageId = null)
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
        Chat = 1 << 3,
        Analytics = 1 << 4,
        TagsAndAttributes = 1 << 5,
        Contacts = 1 << 6,
        Location = 1 << 7,
        All = InAppAutomation | MessageCenter | Push | Chat | Analytics | TagsAndAttributes | Contacts | Location
    }

    /// <summary>
    /// Common Airship Interface.
    /// </summary>
    public interface IAirship
    {
        /// <summary>
        /// Indicates whether user notifications are enabled.
        /// </summary>
        /// <value><c>true</c> if notifications are enabled; otherwise, <c>false</c>.</value>
        bool UserNotificationsEnabled { get; set; }

        /// <summary>
        /// Currently enabled features.
        /// </summary>
        /// <value>The currently enabled features</value>
        Features EnabledFeatures { get; set; }

        /// <summary>
        /// Enables particular features.
        /// </summary>
        /// <param name="features">The features.</param>
        void EnableFeatures(Features features);

        /// <summary>
        /// Disables particular features.
        /// </summary>
        /// <param name="features">The features.</param>
        void DisableFeatures(Features features);

        /// <summary>
        /// Indicates whether particular features are enabled.
        /// </summary>
        /// <param name="features">The features.</param>
        /// <value><c>true</c> if the features are enabled; otherwise, <c>false</c>.</value>
        bool IsFeatureEnabled(Features feature);

        /// <summary>
        /// Indicates whether any feature is enabled.
        /// </summary>
        /// <value><c>true</c> if any feature is enabled; otherwise, <c>false</c>.</value>
        bool IsAnyFeatureEnabled();

        /// <summary>
        /// Gets the tags currently set for the device.
        /// </summary>
        /// <value>The tags.</value>
        IEnumerable<string> Tags { get; }

        /// <summary>
        /// Get the channel ID for the device.
        /// </summary>
        /// <value>The channel identifier.</value>
        string? ChannelId { get; }

        /// <summary>
        /// Gets or sets the named user ID.
        /// </summary>
        /// <value>The named user ID.</value>
        string? NamedUser { get; set; }

        /// <summary>
        /// Add/remove the channel creation event listener.
        /// </summary>
        /// <value>The channel creation event listener.</value>
        event EventHandler<ChannelEventArgs> OnChannelCreation;

        /// <summary>
        /// Add/remove the channel update event listener.
        /// </summary>
        /// <value>The channel update event listener.</value>
        event EventHandler<ChannelEventArgs> OnChannelUpdate;

        /// <summary>
        /// Add/remove the deep link event listener.
        /// </summary>
        /// <value>The deep link event listener.</value>
        event EventHandler<DeepLinkEventArgs> OnDeepLinkReceived;

        /// <summary>
        /// Add/remove the message center display event listener.
        /// </summary>
        /// <value>The message center display listener.</value>
        event EventHandler<MessageCenterEventArgs> OnMessageCenterDisplay;

        /// <summary>
        /// Add/remove the Inbox updated event listener.
        /// </summary>
        /// <value>The Inbox updated listener.</value>
        event EventHandler OnMessageCenterUpdated;

        /// <summary>
        /// Edit the device tags.
        /// </summary>
        /// <returns>A <see cref="AirshipDotNet.Channel.TagEditor">TagEditor</see>
        /// for editing device tags.</returns>
        TagEditor EditDeviceTags();

        /// <summary>
        /// Add a custom event
        /// </summary>
        /// <param name="customEvent">The <see cref="AirshipDotNet.Analytics.CustomEvent">CustomEvent</see>
        /// to add.</param>
        void AddCustomEvent(Analytics.CustomEvent customEvent);

        /// <summary>
        /// track a screen for a specific app screen
        /// </summary>
        /// <param name="screen">The screen's identifier.
        /// to add.</param>
        void TrackScreen(string screen);

        /// <summary>
        /// Associate a custom identifier. Previous identifiers will be replaced by the new identifiers
        /// each time AssociateIdentifier is called. It is a set operation.
        /// </summary>
        /// <param name="key">The custom key for the identifier.</param>
        /// <param name="identifier">The value of the identifier, or `null` to remove the identifier.</param>
        void AssociateIdentifier(string key, string identifier);

        /// <summary>
        /// Displays the message center.
        /// </summary>
        void DisplayMessageCenter();

        /// <summary>
        /// Displays a specific message.
        /// </summary>
        /// <param name="messageId">The identifier for the message to display.</param>
        void DisplayMessage(string messageId);

        /// <summary>
        /// Mark a specific message as read
        /// </summary>
        /// <param name="messageId">The identifier for the message to mark as read.</param>
        void MarkMessageRead(string messageId);

        /// <summary>
        /// Delete a specific message
        /// </summary>
        /// <param name="messageId">The identifier for the message to delete.</param>
        void DeleteMessage(string messageId);

        /// <summary>
        /// Get the message center unread count.
        /// </summary>
        /// <value>The message center unread count.</value>
        int MessageCenterUnreadCount { get; }

        /// <summary>
        /// Get the total count of message center messages.
        /// </summary>
        /// <value>The message center count.</value>
        int MessageCenterCount { get; }

        /// <summary>
        /// Get the list of messages contained in the messages center.
        /// </summary>
        /// <value>The list of message.</value>
        List<MessageCenter.Message> InboxMessages { get; }

        /// <summary>
        /// Displays a specific message.
        /// </summary>
        /// <param name="onComplete">Action that will be called on completion, with a boolean flag indicating success.</param>
        void FetchInboxMessages(Action<bool> onComplete);

        /// <summary>
        /// Returns an editor for named user tag groups.
        /// </summary>
        /// <returns>A <see cref="AirshipDotNet.Channel.TagGroupsEditor">TagGroupsEditor</see>
        /// for named user tag groups.</returns>
        TagGroupsEditor EditNamedUserTagGroups();

        /// <summary>
        /// Returns an editor for channel tag groups.
        /// </summary>
        /// <returns>A <see cref="AirshipDotNet.Channel.TagGroupsEditor">TagGroupsEditor</see>
        /// for channel tag groups.</returns>
        TagGroupsEditor EditChannelTagGroups();

        /// <summary>
        /// Edit channel attributes.
        /// </summary>
        /// <returns>An <see cref="AirshipDotNet.Attributes.AttributeEditor">AttributeEditor</see>
        /// for channel attributes.</returns>
        AttributeEditor EditChannelAttributes();

        /// <summary>
        /// Edit named user attributes.
        /// </summary>
        /// <returns>An <see cref="AirshipDotNet.Attributes.AttributeEditor">AttributeEditor</see>
        /// for named user attributes.</returns>
        AttributeEditor EditNamedUserAttributes();

        /// <summary>
        /// Gets or sets whether In-App Automation is paused.
        /// </summary>
        /// <value>Whether In-App Automation is paused.</value>
        bool InAppAutomationPaused { get; set; }

        /// <summary>
        /// Gets or sets the In-App Automation display interval.
        /// </summary>
        /// <value>The display interval.</value>
        TimeSpan InAppAutomationDisplayInterval { get; set; }
    }
}
