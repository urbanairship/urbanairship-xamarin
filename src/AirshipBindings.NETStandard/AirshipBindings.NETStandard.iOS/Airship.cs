/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
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
                return UAirship.Push().Tags;
            }
        }

        public string ChannelId
        {
            get
            {
                return UAirship.Push().ChannelID;
            }
        }

        public bool LocationEnabled
        {
            get
            {
                return UAirship.Shared().LocationProviderDelegate.LocationUpdatesEnabled;
            }

            set
            {
                UAirship.Shared().LocationProviderDelegate.LocationUpdatesEnabled = value;
            }
        }

        public bool BackgroundLocationAllowed
        {
            get
            {
                return UAirship.Shared().LocationProviderDelegate.BackgroundLocationUpdatesAllowed;
            }

            set
            {
                UAirship.Shared().LocationProviderDelegate.BackgroundLocationUpdatesAllowed = value;
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
                UAirship.Push().Tags = new string[] { };
            }

            UAirship.Push().AddTags(addTags);
            UAirship.Push().RemoveTags(removeTags);
            UAirship.Push().UpdateRegistration();
        }

        public void AddCustomEvent(NETStandard.Analytics.CustomEvent customEvent)
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
                foreach (dynamic property in customEvent.PropertyList)
                {
                    if (string.IsNullOrEmpty(property.name))
                    {
                        continue;
                    }

                    if (property.value is string)
                    {
                        uaEvent.SetStringProperty(property.stringValue, property.name);
                    }
                    else if (property.value is double)
                    {
                        uaEvent.SetNumberProperty(property.doubleValue, property.name);
                    }
                    else if (property.value is bool)
                    {
                        uaEvent.SetBoolProperty(property.boolValue, property.name);
                    }
                    else if (property.value is string[])
                    {
                        uaEvent.SetStringArrayProperty(property.stringArrayValue, property.name);
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
            UAirship.MessageCenter().Display();
        }

        public int MessageCenterUnreadCount
        {
            get
            {
                return (int)UAirship.Inbox().MessageList.UnreadCount;
            }
        }

        public int MessageCenterCount
        {
            get
            {
                return (int)UAirship.Inbox().MessageList.MessageCount();
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
                { Push.TagGroupsEditor.OperationType.ADD, (group, t) => UAirship.Push().AddTags(t, group) },
                { Push.TagGroupsEditor.OperationType.REMOVE, (group, t) => UAirship.Push().RemoveTags(t, group) },
                { Push.TagGroupsEditor.OperationType.SET, (group, t) => UAirship.Push().SetTags(t, group) }
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