/*
 Copyright Airship and Contributors
*/

using System.Collections.Generic;

namespace UrbanAirship.NETStandard
{
    public class Airship : IAirship
    {
        private static Airship sharedAirship = new Airship();

        public static Airship Instance
        {
            get
            {
                return sharedAirship;
            }
        }

        public bool UserNotificationsEnabled
        {
            get
            {
                return UAirship.Shared().PushManager.UserNotificationsEnabled;
            }

            set
            {
                UAirship.Shared().PushManager.UserNotificationsEnabled = value;
            }
        }

        public IEnumerable<string> Tags
        {
            get
            {
                return UAirship.Shared().Channel.Tags;
            }
        }

        public string ChannelId
        {
            get
            {
                return UAirship.Shared().Channel.Id;
            }
        }

        public string NamedUser
        {
            get
            {
                return UAirship.Shared().NamedUser.Id;
            }

            set
            {
                UAirship.Shared().NamedUser.Id = value;
            }
        }

        public Channel.TagEditor EditDeviceTags()
        {
            return new Channel.TagEditor(this.DeviceTagHelper);
        }

        private void DeviceTagHelper(bool clear, string[] addTags, string[] removeTags)
        {
            var editor = UAirship.Shared().Channel.EditTags();

            if (clear)
            {
                editor = editor.Clear();
            }

            editor.AddTags(addTags).RemoveTags(removeTags).Apply();
        }

        public void AddCustomEvent(NETStandard.Analytics.CustomEvent customEvent)
        {
            if (customEvent == null || customEvent.EventName == null)
            {
                return;
            }

            string eventName = customEvent.EventName;
            double eventValue = customEvent.EventValue;
            string transactionId = customEvent.TransactionId;
            string interactionType = customEvent.InteractionType;
            string interactionId = customEvent.InteractionId;

            var builder = new UrbanAirship.Analytics.CustomEvent.Builder(eventName)
                .SetEventValue(eventValue);

            if (!string.IsNullOrEmpty(transactionId))
            {
                builder.SetTransactionId(transactionId);
            }

            if (!string.IsNullOrEmpty(interactionType) && !string.IsNullOrEmpty(interactionId))
            {
                builder.SetInteraction(interactionType, interactionId);
            }

            if (customEvent.PropertyList != null)
            {
                foreach (dynamic property in customEvent.PropertyList)
                {
                    if (string.IsNullOrEmpty(property.name))
                    {
                        continue;
                    }

                    builder.AddProperty(property.name, property.value);
                }
            }

            UAirship.Shared().Analytics.AddEvent(builder.Build());
        }

        public void AssociateIdentifier(string key, string identifier)
        {
            if (identifier == null)
            {
                UAirship.Shared().Analytics.EditAssociatedIdentifiers().RemoveIdentifier(key).Apply();
            }
            else
            {
                UAirship.Shared().Analytics.EditAssociatedIdentifiers().AddIdentifier(key, identifier).Apply();
            }
        }

        public void DisplayMessageCenter()
        {
            UAirship.Shared().MessageCenter.ShowMessageCenter();
        }

        public int MessageCenterUnreadCount
        {
            get
            {
                return UAirship.Shared().Inbox.UnreadCount;
            }
        }

        public int MessageCenterCount
        {
            get
            {
                return UAirship.Shared().Inbox.Count;
            }
        }

        public Channel.TagGroupsEditor EditNamedUserTagGroups()
        {
            return new Channel.TagGroupsEditor((List<Channel.TagGroupsEditor.TagOperation> payload) =>
            {
                var editor = UAirship.Shared().NamedUser.EditTagGroups();
                TagGroupHelper(payload, editor);
                editor.Apply();
            });
        }

        public Channel.TagGroupsEditor EditChannelTagGroups()
        {
            return new Channel.TagGroupsEditor((List<Channel.TagGroupsEditor.TagOperation> payload) =>
            {
                var editor = UAirship.Shared().Channel.EditTagGroups();
                TagGroupHelper(payload, editor);
                editor.Apply();
            });
        }

        private void TagGroupHelper(List<Channel.TagGroupsEditor.TagOperation> payload, UrbanAirship.Channel.TagGroupsEditor editor)
        {
            foreach (Channel.TagGroupsEditor.TagOperation tagOperation in payload)
            {

                switch (tagOperation.operationType)
                {
                    case Channel.TagGroupsEditor.OperationType.ADD:
                        editor.AddTags(tagOperation.group, tagOperation.tags);
                        break;
                    case Channel.TagGroupsEditor.OperationType.REMOVE:
                        editor.RemoveTags(tagOperation.group, tagOperation.tags);
                        break;
                    case Channel.TagGroupsEditor.OperationType.SET:
                        editor.SetTags(tagOperation.group, tagOperation.tags);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}