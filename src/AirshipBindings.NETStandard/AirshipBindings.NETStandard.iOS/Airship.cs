/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;
using Foundation;
using UrbanAirship;
using UrbanAirship.NETStandard;
using UrbanAirship.NETStandard.Analytics;
using UrbanAirship.NETStandard.Attributes;

namespace UrbanAirship.NETStandard
{
    public class Airship : UADeepLinkDelegate, IUAMessageCenterDisplayDelegate, IAirship
    {
        private static Lazy<Airship> sharedAirship = new Lazy<Airship>(() =>
        {
            Airship instance = new Airship();
            instance.Initialize();
            return instance;
        });

        private void Initialize()
        {
            // Load unreferenced modules
            AirshipAutomation.Init();
            AirshipExtendedActions.Init();

            NSNotificationCenter.DefaultCenter.AddObserver(aName: (NSString)UAChannel.ChannelCreatedEvent, (NSNotification notification) =>
            {
                string channelID = notification.UserInfo[UAChannel.ChannelIdentifierKey].ToString();
                OnChannelCreation?.Invoke(this, new ChannelEventArgs(channelID));
            });

            // TODO(18.0.0): Wire up the push notfication status listener, once the iOS SDK bindings have been bumped to 17.x

            //Adding Inbox updated Listener
            NSNotificationCenter.DefaultCenter.AddObserver(aName: (NSString)"com.urbanairship.notification.message_list_updated", (notification) =>
            {
                EventHandler handler = OnMessageCenterUpdated;
                if (handler != null)
                {
                    handler(this, EventArgs.Empty);
                }
            });
        }

        /// <summary>
        /// Add/remove the channel creation listener.
        /// </summary>
        public event EventHandler<ChannelEventArgs> OnChannelCreation;

        /// <summary>
        /// Add/remove the push notification status listener.
        /// </summary>
        public event EventHandler<PushNotificationStatusEventArgs> OnPushNotificationStatusUpdate;

        private EventHandler<DeepLinkEventArgs> onDeepLinkReceived;

        /// <summary>
        /// Add/remove the deep link listener.
        /// </summary>
        public event EventHandler<DeepLinkEventArgs> OnDeepLinkReceived
        {
            add
            {
                onDeepLinkReceived += value;
                UAirship.Shared.WeakDeepLinkDelegate = this;
            }
            remove
            {
                onDeepLinkReceived -= value;

                if (onDeepLinkReceived == null)
                {
                    UAirship.Shared.WeakDeepLinkDelegate = null;
                }
            }
        }

        /// <summary>
        /// Add/remove the Message Center updated listener.
        /// </summary>
        public event EventHandler OnMessageCenterUpdated;
   
        private EventHandler<MessageCenterEventArgs> onMessageCenterDisplay;

        /// <summary>
        /// Add/remove the Message Center display listener.
        /// </summary>
        public event EventHandler<MessageCenterEventArgs> OnMessageCenterDisplay
        {
            add
            {
                onMessageCenterDisplay += value;
                UAMessageCenter.Shared.WeakDisplayDelegate = this;
            }
            remove
            {
                onMessageCenterDisplay -= value;

                if (onMessageCenterDisplay == null)
                {
                    UAMessageCenter.Shared.WeakDisplayDelegate = null;
                }
            }
        }

        public static Airship Instance
        {
            get
            {
                return sharedAirship.Value;
            }
        }

        public bool UserNotificationsEnabled
        {
            get
            {
                return UAirship.Push.UserPushNotificationsEnabled;
            }

            set
            {
                UAirship.Push.UserPushNotificationsEnabled = value;
            }
        }

        public Features EnabledFeatures
        {
            get
            {
                return featuresFromUAFeatures(UAirship.Shared.PrivacyManager.EnabledFeatures);
            }
            set
            {
                UAirship.Shared.PrivacyManager.EnabledFeatures = uaFeaturesFromFeatures(value);
            }
        }

        public void EnableFeatures(Features features)
        {
            UAirship.Shared.PrivacyManager.EnableFeatures(uaFeaturesFromFeatures(features));
        }

        public void DisableFeatures(Features features)
        {
            UAirship.Shared.PrivacyManager.DisableFeatures(uaFeaturesFromFeatures(features));
        }

        public bool IsFeatureEnabled(Features feature)
        {
            return EnabledFeatures.HasFlag(feature);
        }

        public bool IsAnyFeatureEnabled()
        {
            return EnabledFeatures != Features.None;
        }

        private UAFeatures uaFeaturesFromFeatures(Features features)
        {
            UAFeatures uAFeatures = UAFeatures.None;

            if (features.HasFlag(Features.InAppAutomation))
            {
                uAFeatures |= UAFeatures.InAppAutomation;
            }
            if (features.HasFlag(Features.MessageCenter))
            {
                uAFeatures |= UAFeatures.MessageCenter;
            }
            if (features.HasFlag(Features.Push))
            {
                uAFeatures |= UAFeatures.Push;
            }
            if (features.HasFlag(Features.Analytics))
            {
                uAFeatures |= UAFeatures.Analytics;
            }
            if (features.HasFlag(Features.TagsAndAttributes))
            {
                uAFeatures |= UAFeatures.TagsAndAttributes;
            }
            if (features.HasFlag(Features.Contacts))
            {
                uAFeatures |= UAFeatures.Contacts;
            }

            return uAFeatures;
        }

        private Features featuresFromUAFeatures(UAFeatures uAFeatures)
        {
            Features features = Features.None;

            if (uAFeatures.HasFlag(UAFeatures.InAppAutomation))
            {
                features |= Features.InAppAutomation;
            }
            if (uAFeatures.HasFlag(UAFeatures.MessageCenter))
            {
                features |= Features.MessageCenter;
            }
            if (uAFeatures.HasFlag(UAFeatures.Push))
            {
                features |= Features.Push;
            }
            if (uAFeatures.HasFlag(UAFeatures.Analytics))
            {
                features |= Features.Analytics;
            }
            if (uAFeatures.HasFlag(UAFeatures.TagsAndAttributes))
            {
                features |= Features.TagsAndAttributes;
            }
            if (uAFeatures.HasFlag(UAFeatures.Contacts))
            {
                features |= Features.Contacts;
            }

            return features;
        }

        public IEnumerable<string> Tags
        {
            get
            {
                return UAirship.Channel.Tags;
            }
        }

        public string ChannelId
        {
            get
            {
                return UAirship.Channel.Identifier;
            }
        }

        public string NamedUser
        {
            get
            {
                return UAirship.NamedUser.Identifier;
            }

            set
            {
                UAirship.NamedUser.Identifier = value;
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
                UAirship.Channel.Tags = new string[] { };
            }

            UAirship.Channel.AddTags(addTags);
            UAirship.Channel.RemoveTags(removeTags);
            UAirship.Push.UpdateRegistration();
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
                NSMutableDictionary<NSString, NSObject> propertyDictionary = new NSMutableDictionary<NSString, NSObject>();
                foreach (dynamic property in customEvent.PropertyList)
                {
                    if (string.IsNullOrEmpty(property.name))
                    {
                        continue;
                    }

                    NSString key = (NSString)property.name;
                    NSObject value = NSObject.FromObject(property.value);

                    if (property is CustomEvent.Property<string[]> stringArrayProperty)
                    {
                        value = NSArray.FromObjects(stringArrayProperty.value);
                        propertyDictionary.SetValueForKey(value, key);
                    }
                    if (value != null)
                    {
                        propertyDictionary.SetValueForKey(value, key);
                    }
                    
                }
                if (propertyDictionary.Count > 0)
                {
                    uaEvent.Properties = new NSDictionary<NSString, NSObject>(propertyDictionary.Keys, propertyDictionary.Values);
                }
            }

            UAirship.Analytics.AddEvent(uaEvent);
        }

        public void TrackScreen(string screen)
        {
            UAirship.Analytics.TrackScreen(screen);
        }

        public void AssociateIdentifier(string key, string identifier)
        {
            UAAssociatedIdentifiers identifiers = UAirship.Analytics.CurrentAssociatedDeviceIdentifiers;
            identifiers.SetIdentifier(identifier, key);
            UAirship.Analytics.AssociateDeviceIdentifiers(identifiers);
        }

        public void DisplayMessageCenter()
        {
            UAMessageCenter.Shared.Display();
        }

        public void DisplayMessage(string messageId)
        {
            UAMessageCenter.Shared.DisplayMessage(messageId);
        }

        public void MarkMessageRead(string messageId)
        {
            var toRead = new UAInboxMessage[1];
            toRead[0] = UAMessageCenter.Shared.MessageList.Message(messageId);
            UAMessageCenter.Shared.MessageList.MarkMessagesRead(toRead, null);
        }

        public void DeleteMessage(string messageId)
        {
            var toDelete = new UAInboxMessage[1];
            toDelete[0] = UAMessageCenter.Shared.MessageList.Message(messageId);
            UAMessageCenter.Shared.MessageList.MarkMessagesDeleted(toDelete, null);
        }

        public int MessageCenterUnreadCount
        {
            get
            {
                return (int)UAMessageCenter.Shared.MessageList.UnreadCount;
            }
        }

        public int MessageCenterCount
        {
            get
            {
                return (int)UAMessageCenter.Shared.MessageList.MessageCount();
            }
        }

        public List<MessageCenter.Message> InboxMessages
        {
            get
            {
                var messagesList = new List<MessageCenter.Message>();
                var messages = UAMessageCenter.Shared.MessageList.Messages;
                foreach (var message in messages)
                {
                    var extras = new Dictionary<string, string>();
                    foreach (var key in message.Extra.Keys)
                    {
                        extras.Add(key.ToString(), message.Extra[key].ToString());
                    }

                    DateTime? sentDate = FromNSDate(message.MessageSent);
                    DateTime? expirationDate = FromNSDate(message.MessageExpiration);

                    string iconUrl = null;
                    var icons = (NSDictionary)message.RawMessageObject.ValueForKey(new NSString("icons"));
                    if (icons != null)
                    {
                        iconUrl = icons.ValueForKey(new NSString("list_icon")).ToString();
                    }

                    var inboxMessage = new MessageCenter.Message(
                        message.MessageID,
                        message.Title,
                        sentDate,
                        expirationDate,
                        message.Unread,
                        iconUrl,
                        extras);

                    messagesList.Add(inboxMessage);
                }

                return messagesList;
            }
        }

        private NSDate FromDateTime(DateTime dateTime)
        {
            if (dateTime == null)
            {
                return null;
            }

            if (dateTime.Kind == DateTimeKind.Unspecified)
            {
                dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
            }

            return (NSDate)dateTime;
        }

        private DateTime? FromNSDate(NSDate date)
        {
            if (date == null)
            {
                return null;
            }
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(date.SecondsSince1970);
        }

        public Channel.TagGroupsEditor EditNamedUserTagGroups()
        {
            return new Channel.TagGroupsEditor((List<Channel.TagGroupsEditor.TagOperation> payload) =>
            {
                TagGroupHelper(payload, true);
                UAirship.NamedUser.UpdateTags();
            });
        }

        public Channel.TagGroupsEditor EditChannelTagGroups()
        {
            return new Channel.TagGroupsEditor((List<Channel.TagGroupsEditor.TagOperation> payload) =>
            {
                TagGroupHelper(payload, false);
                UAirship.Push.UpdateRegistration();
            });
        }

        public AttributeEditor EditAttributes()
        {
            return EditChannelAttributes();
        }

        public AttributeEditor EditChannelAttributes()
        {
            return new AttributeEditor((List<AttributeEditor.IAttributeOperation> operations) =>
            {
                var mutations = UAAttributeMutations.Mutations;
                ApplyAttributesOperations(mutations, operations);
                UAirship.Channel.ApplyAttributeMutations(mutations);
            });
        }

        public AttributeEditor EditNamedUserAttributes()
        {
            return new AttributeEditor((List<AttributeEditor.IAttributeOperation> operations) =>
            {
                var mutations = UAAttributeMutations.Mutations;
                ApplyAttributesOperations(mutations, operations);
                UAirship.NamedUser.ApplyAttributeMutations(mutations);
            });
        }

        private void ApplyAttributesOperations(UAAttributeMutations mutations, List<AttributeEditor.IAttributeOperation> operations)
        {
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

                if (operation is AttributeEditor.SetAttributeOperation<DateTime> dateOperation)
                {
                    NSDate date = FromDateTime(dateOperation.value);
                    mutations.SetDate(date, dateOperation.key);
                }

                if (operation is AttributeEditor.RemoveAttributeOperation removeOperation)
                {
                    mutations.RemoveAttribute(removeOperation.key);
                }
            }
        }

        private void TagGroupHelper(List<Channel.TagGroupsEditor.TagOperation> operations, bool namedUser)
        {
            var namedUserActions = new Dictionary<Channel.TagGroupsEditor.OperationType, Action<string, string[]>>()
            {
                { Channel.TagGroupsEditor.OperationType.ADD, (group, t) => UAirship.NamedUser.AddTags(t, group) },
                { Channel.TagGroupsEditor.OperationType.REMOVE, (group, t) => UAirship.NamedUser.RemoveTags(t, group) },
                { Channel.TagGroupsEditor.OperationType.SET, (group, t) => UAirship.NamedUser.SetTags(t, group) }
            };
            var channelActions = new Dictionary<Channel.TagGroupsEditor.OperationType, Action<string, string[]>>()
            {
                { Channel.TagGroupsEditor.OperationType.ADD, (group, t) => UAirship.Channel.AddTags(t, group) },
                { Channel.TagGroupsEditor.OperationType.REMOVE, (group, t) => UAirship.Channel.RemoveTags(t, group) },
                { Channel.TagGroupsEditor.OperationType.SET, (group, t) => UAirship.Channel.SetTags(t, group) }
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
            onDeepLinkReceived?.Invoke(this, new DeepLinkEventArgs(url.AbsoluteString));
            completionHandler();
        }

        public void DisplayMessageCenter(string messageID, bool animated)
        {
            onMessageCenterDisplay?.Invoke(this, new MessageCenterEventArgs(messageID));
        }

        public void DisplayMessageCenterAnimated(bool animated)
        {
            onMessageCenterDisplay?.Invoke(this, new MessageCenterEventArgs());
        }

        public void DismissMessageCenterAnimated(bool animated)
        { }


        public bool InAppAutomationPaused
        {
            get
            {
                return UAInAppAutomation.Shared.Paused;
            }

            set
            {
                UAInAppAutomation.Shared.Paused = value;
            }
        }

        public TimeSpan InAppAutomationDisplayInterval
        {
            get
            {
                return TimeSpan.FromSeconds(UAInAppAutomation.Shared.InAppMessageManager.DisplayInterval);
            }

            set
            {
                UAInAppAutomation.Shared.InAppMessageManager.DisplayInterval = value.TotalSeconds;
            }
        }
    }
}
