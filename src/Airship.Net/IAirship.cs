/* Copyright Airship and Contributors */

using Airship.Net.Attributes;
using Airship.Net.Channel;

namespace Airship.Net
{

    public class ChannelEventArgs : EventArgs
    {
        public string ChannelId { get; private set; }

        public ChannelEventArgs(string channelId)
        {
            ChannelId = channelId;
        }
    }

    public class DeepLinkEventArgs : EventArgs
    {
        public string DeepLink { get; internal set; }
        public DeepLinkEventArgs(string deepLink)
        {
            DeepLink = deepLink;
        }
    }

    public class MessageCenterEventArgs : EventArgs
    {
        public string? MessageId { get; internal set; }
        public MessageCenterEventArgs(string? messageId = null)
        {
            MessageId = messageId;
        }
    }

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

    public interface IAirship
    {
        bool UserNotificationsEnabled { get; set; }

        Features EnabledFeatures { get; set; }

        void EnableFeatures(Features features);

        void DisableFeatures(Features features);

        bool IsFeatureEnabled(Features feature);

        bool IsAnyFeatureEnabled();

        IEnumerable<string> Tags { get; }

        string? ChannelId { get; }

        string? NamedUser { get; set; }

        event EventHandler<ChannelEventArgs> OnChannelCreation;

        event EventHandler<ChannelEventArgs> OnChannelUpdate;

        event EventHandler<DeepLinkEventArgs> OnDeepLinkReceived;

        event EventHandler<MessageCenterEventArgs> OnMessageCenterDisplay;

        TagEditor EditDeviceTags();

        void AddCustomEvent(Analytics.CustomEvent customEvent);

        void TrackScreen(string screen);

        void AssociateIdentifier(string key, string identifier);

        void DisplayMessageCenter();

        int MessageCenterUnreadCount { get; }

        int MessageCenterCount { get; }

        List<MessageCenter.Message> InboxMessages { get; }

        TagGroupsEditor EditNamedUserTagGroups();

        TagGroupsEditor EditChannelTagGroups();

        AttributeEditor EditAttributes();

        event EventHandler OnMessageCenterUpdated;

        AttributeEditor EditChannelAttributes();

        AttributeEditor EditNamedUserAttributes();

        bool InAppAutomationPaused { get; set; }

        TimeSpan InAppAutomationDisplayInterval { get; set; }
    }
}
