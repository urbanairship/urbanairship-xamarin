/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;
using UrbanAirship.NETStandard.Attributes;
using UrbanAirship.Actions;
using UrbanAirship.NETStandard.Analytics;

namespace UrbanAirship.NETStandard
{
    public class Airship : IAirship
    {
        private static Airship sharedAirship = new Airship();
        private DeepLinkListener deepLinkListener = new DeepLinkListener();

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

        public AttributeEditor EditAttributes()
        {
            return new AttributeEditor((List<AttributeEditor.IAttributeOperation> operations) =>
            {
                var editor = UAirship.Shared().Channel.EditAttributes();

                foreach (var operation in operations)
                {
                    if (operation is AttributeEditor.SetAttributeOperation<string> stringOperation)
                    {
                        editor.SetAttribute(stringOperation.key, stringOperation.value);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<int> intOperation)
                    {
                        editor.SetAttribute(intOperation.key, intOperation.value);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<long> longOperation)
                    {
                        editor.SetAttribute(longOperation.key, longOperation.value);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<float> floatOperation)
                    {
                        editor.SetAttribute(floatOperation.key, floatOperation.value);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<double> doubleOperation)
                    {
                        editor.SetAttribute(doubleOperation.key, doubleOperation.value);
                    }

                    if (operation is AttributeEditor.RemoveAttributeOperation removeOperation)
                    {
                        editor.RemoveAttribute(removeOperation.key);
                    }
                }

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

        public void RegisterEventListener(Action<string, Dictionary<string, string>> onEventReceived)
        {
            UAirship.Shared().DeepLinkListener = deepLinkListener;
            deepLinkListener.onEventReceived = onEventReceived;
        }
    }

    public class DeepLinkListener : Java.Lang.Object, IDeepLinkListener

    {
        public Action<string, Dictionary<string, string>> onEventReceived;

        public bool OnDeepLink(string deepLink)
        {
            DeepLinkEvent deepLinkEvent = new DeepLinkEvent(deepLink);
            onEventReceived(deepLinkEvent.EventType, deepLinkEvent.EventData);

            return true;
        }    
    }
}