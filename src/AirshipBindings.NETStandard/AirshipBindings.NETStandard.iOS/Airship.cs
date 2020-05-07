/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;
using Foundation;
using UrbanAirship.NETStandard.Analytics;
using UrbanAirship.NETStandard.Attributes;

namespace UrbanAirship.NETStandard
{
    public delegate void DeepLinkHandler(string deepLink);

    public class Airship : UADeepLinkDelegate, IAirship
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

        private DeepLinkHandler onDeepLinkReceived;
        public event DeepLinkHandler OnDeepLinkReceived
        {
            add
            {
                onDeepLinkReceived += value;
                UAirship.Shared().WeakDeepLinkDelegate = this;
            }

            remove
            {
                onDeepLinkReceived -= value;
                if (onDeepLinkReceived == null)
                {
                    UAirship.Shared().WeakDeepLinkDelegate = null;
                }
            }
        }

        public Channel.TagEditor EditDeviceTags()
        {
            return new Channel.TagEditor(this.DeviceTagHelper);
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

        public Channel.TagGroupsEditor EditNamedUserTagGroups()
        {
            return new Channel.TagGroupsEditor((List<Channel.TagGroupsEditor.TagOperation> payload) =>
            {
                TagGroupHelper(payload, true);
                UAirship.NamedUser().UpdateTags();
            });
        }

        public Channel.TagGroupsEditor EditChannelTagGroups()
        {
            return new Channel.TagGroupsEditor((List<Channel.TagGroupsEditor.TagOperation> payload) =>
            {
                TagGroupHelper(payload, false);
                UAirship.Push().UpdateRegistration();
            });
        }

        public AttributeEditor EditAttributes()
        {
            return new AttributeEditor((List<AttributeEditor.IAttributeOperation> operations) =>
            {
                var mutations = UAAttributeMutations.Mutations();

                foreach (var operation in operations)
                {
                    if (operation is AttributeEditor.SetAttributeOperation<string> stringOperation)
                    {
                        mutations.SetString(stringOperation.value, stringOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<int> intOperation)
                    {
                        mutations.SetNumber(intOperation.value, intOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<long> longOperation)
                    {
                        mutations.SetNumber(longOperation.value, longOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<float> floatOperation)
                    {
                        mutations.SetNumber(floatOperation.value, floatOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<double> doubleOperation)
                    {
                        mutations.SetNumber(doubleOperation.value, doubleOperation.key);
                    }

                    if (operation is AttributeEditor.RemoveAttributeOperation removeOperation)
                    {
                        mutations.RemoveAttribute(removeOperation.key);
                    }
                }

                UAirship.Channel().ApplyAttributeMutations(mutations);
            });
        }

        private void TagGroupHelper(List<Channel.TagGroupsEditor.TagOperation> operations, bool namedUser)
        {
            var namedUserActions = new Dictionary<Channel.TagGroupsEditor.OperationType, Action<string, string[]>>()
            {
                { Channel.TagGroupsEditor.OperationType.ADD, (group, t) => UAirship.NamedUser().AddTags(t, group) },
                { Channel.TagGroupsEditor.OperationType.REMOVE, (group, t) => UAirship.NamedUser().RemoveTags(t, group) },
                { Channel.TagGroupsEditor.OperationType.SET, (group, t) => UAirship.NamedUser().SetTags(t, group) }
            };
            var channelActions = new Dictionary<Channel.TagGroupsEditor.OperationType, Action<string, string[]>>()
            {
                { Channel.TagGroupsEditor.OperationType.ADD, (group, t) => UAirship.Channel().AddTags(t, group) },
                { Channel.TagGroupsEditor.OperationType.REMOVE, (group, t) => UAirship.Channel().RemoveTags(t, group) },
                { Channel.TagGroupsEditor.OperationType.SET, (group, t) => UAirship.Channel().SetTags(t, group) }
            };

            var actions = namedUser ? namedUserActions : channelActions;

            foreach (Channel.TagGroupsEditor.TagOperation operation in operations)
            {
                if (!Enum.IsDefined(typeof(Channel.TagGroupsEditor.OperationType), operation.operationType))
                {
                    continue;
                }

                string[] tagArray = new string[operation.tags.Count];
                operation.tags.CopyTo(tagArray, 0);
                actions[operation.operationType](operation.group, tagArray);
            }
        }

        override public void ReceivedDeepLink(NSUrl url, Action completionHandler)
        {
            var handler = onDeepLinkReceived;
            handler(url.AbsoluteString);
            completionHandler();
        }
    }
}