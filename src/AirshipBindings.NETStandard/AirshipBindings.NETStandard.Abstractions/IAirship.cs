/*
 Copyright Airship and Contributors
*/

using System.Collections.Generic;


namespace UrbanAirship.NETStandard
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

        string NamedUser
        {
            get; set;
        }

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

        Channel.TagGroupsEditor EditNamedUserTagGroups();

        Channel.TagGroupsEditor EditChannelTagGroups();
        
        Attributes.AttributeEditor EditAttributes();
    }
}
