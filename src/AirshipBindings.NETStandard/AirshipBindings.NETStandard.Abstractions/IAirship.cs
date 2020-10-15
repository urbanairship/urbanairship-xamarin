/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;


namespace UrbanAirship.NETStandard
{

    public class ChannelEventArgs : EventArgs
    {
        public string ChannelId { get; private set; }

        public ChannelEventArgs(string channelId)
        {
            ChannelId = channelId;
        }
    }

    public class DeepLinkEventArgs: EventArgs
    {
        public string DeepLink { get; internal set; }
        public DeepLinkEventArgs(string deepLink)
        {
            DeepLink = deepLink;
        }
    }

    public class MessageCenterEventArgs : EventArgs
    {
        public string MessageId { get; internal set; }
        public MessageCenterEventArgs(string messageId = null)
        {
            MessageId = messageId;
        }
    }

    public interface IAirship
    {
        bool UserNotificationsEnabled
        {
            get; set;
        }

        bool DataCollectionEnabled
        {
            get; set;
        }

        bool PushTokenRegistrationEnabled
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

        string NamedUser
        {
            get; set;
        }

        event EventHandler<ChannelEventArgs> OnChannelCreation;

        event EventHandler<ChannelEventArgs> OnChannelUpdate;

        event EventHandler<DeepLinkEventArgs> OnDeepLinkReceived;

        event EventHandler<MessageCenterEventArgs> OnMessageCenterDisplay;

        Channel.TagEditor EditDeviceTags();

        void AddCustomEvent(Analytics.CustomEvent customEvent);

        void TrackScreen(string screen);

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

        bool InAppAutomationEnabled
        {
            get; set;
        }

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
