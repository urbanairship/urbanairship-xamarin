/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;
using UrbanAirship.NETStandard.Analytics;

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
                return UAirship.Push().UserPushNotificationsEnabled;
            }

            set
            {
                UAirship.Push().UserPushNotificationsEnabled = value;
            }
        }

        public IEnumerable<string> Tags
        {
            get
            {
                return UAirship.Channel().Tags;
            }
        }

        public string ChannelId
        {
            get
            {
                return UAirship.Channel().Identifier;
            }
        }

        public string NamedUser
        {
            get
            {
                return UAirship.NamedUser().Identifier;
            }

            set
            {
                UAirship.NamedUser().Identifier = value;
            }
        }

        public Push.TagEditor EditDeviceTags()
        {
            return new Push.TagEditor(this.DeviceTagHelper);
        }

        private void DeviceTagHelper(bool clear, string[] addTags, string[] removeTags)
        {
            if (clear)
            {
                UAirship.Channel().Tags = new string[] { };
            }

            UAirship.Channel().AddTags(addTags);
            UAirship.Channel().RemoveTags(removeTags);
            UAirship.Push().UpdateRegistration();
        }

        public void AddCustomEvent(CustomEvent customEvent)
        {
            if (customEvent == null || string.IsNullOrEmpty(customEvent.EventName))
            {
                return;
            }

            string eventName = customEvent.EventName;
            double eventValue = customEvent.EventValue;
            string transactionId = customEvent.TransactionId;
            string interactionType = customEvent.InteractionType;
            string interactionId = customEvent.InteractionId;

            UACustomEvent uaEvent = UACustomEvent.Event(eventName, eventValue);

            if (!string.IsNullOrEmpty(transactionId))
            {
                uaEvent.TransactionID = transactionId;
            }

            if (!string.IsNullOrEmpty(interactionId))
            {
                uaEvent.InteractionID = interactionId;
            }

            if (!string.IsNullOrEmpty(interactionType))
            {
                uaEvent.InteractionType = interactionType;
            }

            if (customEvent.PropertyList != null)
            {
                foreach (var property in customEvent.PropertyList)
                {
                    if (string.IsNullOrEmpty(property.name))
                    {
                        continue;
                    }

                    if (property is CustomEvent.Property<string> stringProperty)
                    {
                        uaEvent.SetStringProperty(stringProperty.value, stringProperty.name);
                    }
                    else if (property is CustomEvent.Property<double> doubleProperty)
                    {
                        uaEvent.SetNumberProperty(doubleProperty.value, doubleProperty.name);
                    }
                    else if (property is CustomEvent.Property<bool> boolProperty)
                    {
                        uaEvent.SetBoolProperty(boolProperty.value, boolProperty.name);
                    }
                    else if (property is CustomEvent.Property<string[]> stringArrayProperty)
                    {
                        uaEvent.SetStringArrayProperty(stringArrayProperty.value, stringArrayProperty.name);
                    }
                }
            }

            UAirship.Analytics().AddEvent(uaEvent);
        }

        public void AssociateIdentifier(string key, string identifier)
        {
            UAAssociatedIdentifiers identifiers = UAirship.Analytics().CurrentAssociatedDeviceIdentifiers();
            identifiers.SetIdentifier(identifier, key);
            UAirship.Analytics().AssociateDeviceIdentifiers(identifiers);
        }

        public void DisplayMessageCenter()
        {
            UAMessageCenter.Shared().Display();
        }

        public int MessageCenterUnreadCount
        {
            get
            {
                return (int)UAMessageCenter.Shared().MessageList.UnreadCount;
            }
        }

        public int MessageCenterCount
        {
            get
            {
                return (int)UAMessageCenter.Shared().MessageList.MessageCount();
            }
        }

        public Push.TagGroupsEditor EditNamedUserTagGroups()
        {
            return new Push.TagGroupsEditor((List<Push.TagGroupsEditor.TagOperation> payload) =>
            {
                TagGroupHelper(payload, true);
                UAirship.NamedUser().UpdateTags();
            });
        }

        public Push.TagGroupsEditor EditChannelTagGroups()
        {
            return new Push.TagGroupsEditor((List<Push.TagGroupsEditor.TagOperation> payload) =>
            {
                TagGroupHelper(payload, false);
                UAirship.Push().UpdateRegistration();
            });
        }

        private void TagGroupHelper(List<Push.TagGroupsEditor.TagOperation> operations, bool namedUser)
        {
            var namedUserActions = new Dictionary<Push.TagGroupsEditor.OperationType, Action<string, string[]>>()
            {
                { Push.TagGroupsEditor.OperationType.ADD, (group, t) => UAirship.NamedUser().AddTags(t, group) },
                { Push.TagGroupsEditor.OperationType.REMOVE, (group, t) => UAirship.NamedUser().RemoveTags(t, group) },
                { Push.TagGroupsEditor.OperationType.SET, (group, t) => UAirship.NamedUser().SetTags(t, group) }
            };
            var channelActions = new Dictionary<Push.TagGroupsEditor.OperationType, Action<string, string[]>>()
            {
                { Push.TagGroupsEditor.OperationType.ADD, (group, t) => UAirship.Channel().AddTags(t, group) },
                { Push.TagGroupsEditor.OperationType.REMOVE, (group, t) => UAirship.Channel().RemoveTags(t, group) },
                { Push.TagGroupsEditor.OperationType.SET, (group, t) => UAirship.Channel().SetTags(t, group) }
            };

            var actions = namedUser ? namedUserActions : channelActions;

            foreach (Push.TagGroupsEditor.TagOperation operation in operations)
            {
                if (!Enum.IsDefined(typeof(Push.TagGroupsEditor.OperationType), operation.operationType))
                {
                    continue;
                }

                string[] tagArray = new string[operation.tags.Count];
                operation.tags.CopyTo(tagArray, 0);
                actions[operation.operationType](operation.group, tagArray);
            }
        }
    }
}