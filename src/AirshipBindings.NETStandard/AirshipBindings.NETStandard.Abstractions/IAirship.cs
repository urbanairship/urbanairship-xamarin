/*
 Copyright Airship and Contributors
*/

using System;
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

        Push.TagEditor EditDeviceTags();

        void AddCustomEvent(Analytics.CustomEvent customEvent);

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

        Push.TagGroupsEditor EditNamedUserTagGroups();

        Push.TagGroupsEditor EditChannelTagGroups();
    }
}
