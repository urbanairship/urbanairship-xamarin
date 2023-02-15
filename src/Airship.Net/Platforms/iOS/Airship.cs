/* Copyright Airship and Contributors */

using Foundation;
using UrbanAirship;
using AirshipDotNet.Analytics;
using AirshipDotNet.Attributes;

namespace AirshipDotNet
{
    /// <summary>
    /// Provides cross-platform access to a common subset of functionality between the iOS and Android SDKs
    /// </summary>
    public class Airship : UADeepLinkDelegate, IAirship, IUAMessageCenterDisplayDelegate
    {
        private static readonly Lazy<Airship> sharedAirship = new(() =>
        {
            Airship instance = new();
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
                var userInfo = notification.UserInfo;
                if (userInfo is not null)
                {
                    var channelID = userInfo[UAChannel.ChannelIdentifierKey].ToString();
                    OnChannelCreation?.Invoke(this, new ChannelEventArgs(channelID));
                }
            });

            NSNotificationCenter.DefaultCenter.AddObserver(aName: (NSString)UAChannel.ChannelUpdatedEvent, (NSNotification notification) =>
            {
                var userInfo = notification.UserInfo;
                if (userInfo is not null)
                {
                    var channelID = userInfo[UAChannel.ChannelIdentifierKey].ToString();
                    OnChannelUpdate?.Invoke(this, new ChannelEventArgs(channelID));
                }
            });

            //Adding Inbox updated Listener
            NSNotificationCenter.DefaultCenter.AddObserver(aName: (NSString)"com.urbanairship.notification.message_list_updated", (notification) =>
            {
                OnMessageCenterUpdated?.Invoke(this, EventArgs.Empty);
            });
        }

        public event EventHandler<ChannelEventArgs>? OnChannelCreation;

        public event EventHandler<ChannelEventArgs>? OnChannelUpdate;

        private EventHandler<DeepLinkEventArgs>? onDeepLinkReceived;
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
        public event EventHandler? OnMessageCenterUpdated;

        private EventHandler<MessageCenterEventArgs>? onMessageCenterDisplay;
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

        public static Airship Instance => sharedAirship.Value;

        public bool UserNotificationsEnabled
        {
            get => UAirship.Push.UserPushNotificationsEnabled;
            set => UAirship.Push.UserPushNotificationsEnabled = value;
        }

        public Features EnabledFeatures
        {
            get => FeaturesFromUAFeatures(UAirship.Shared.PrivacyManager.EnabledFeatures);
            set => UAirship.Shared.PrivacyManager.EnabledFeatures = UaFeaturesFromFeatures(value);
        }

        public void EnableFeatures(Features features) =>
            UAirship.Shared.PrivacyManager.EnableFeatures(UaFeaturesFromFeatures(features));

        public void DisableFeatures(Features features) =>
            UAirship.Shared.PrivacyManager.DisableFeatures(UaFeaturesFromFeatures(features));

        public bool IsFeatureEnabled(Features feature) => EnabledFeatures.HasFlag(feature);
        
        public bool IsAnyFeatureEnabled() => EnabledFeatures != Features.None;

        private static UAFeatures UaFeaturesFromFeatures(Features features)
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
            if (features.HasFlag(Features.Chat))
            {
                uAFeatures |= UAFeatures.Chat;
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
            if (features.HasFlag(Features.Location))
            {
                uAFeatures |= UAFeatures.Location;
            }

            return uAFeatures;
        }

        private static Features FeaturesFromUAFeatures(UAFeatures uAFeatures)
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
            if (uAFeatures.HasFlag(UAFeatures.Chat))
            {
                features |= Features.Chat;
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
            if (uAFeatures.HasFlag(UAFeatures.Location))
            {
                features |= Features.Location;
            }

            return features;
        }

        public IEnumerable<string> Tags => UAirship.Channel.Tags;
           
        public string? ChannelId => UAirship.Channel.Identifier;

        public string? NamedUser
        {
            get => UAirship.Contact.NamedUserID;
            set
            {
                if (value is not null)
                {
                    UAirship.Contact.Identify(value);
                }
                else
                {
                    UAirship.Contact.Reset();
                }
            }
        }

        public Channel.TagEditor EditDeviceTags() => new(DeviceTagHelper);

        private void DeviceTagHelper(bool clear, string[] addTags, string[] removeTags)
        {
            if (clear)
            {
                UAirship.Channel.Tags = Array.Empty<string>();
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

            var eventName = customEvent.EventName;
            var eventValue = customEvent.EventValue;
            var transactionId = customEvent.TransactionId;
            var interactionType = customEvent.InteractionType;
            var interactionId = customEvent.InteractionId;

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
                NSMutableDictionary<NSString, NSObject> propertyDictionary = new();
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
                        value = NSArray.FromObjects(stringArrayProperty.Value);
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

        public void TrackScreen(string screen) => UAirship.Analytics.TrackScreen(screen);

        public void AssociateIdentifier(string key, string identifier)
        {
            UAAssociatedIdentifiers identifiers = UAirship.Analytics.CurrentAssociatedDeviceIdentifiers;
            identifiers.SetIdentifier(identifier, key);
            UAirship.Analytics.AssociateDeviceIdentifiers(identifiers);
        }

        public void DisplayMessageCenter() => UAMessageCenter.Shared.Display();

        public void DisplayMessage(string messageId) => UAMessageCenter.Shared.DisplayMessage(messageId);

        public void MarkMessageRead(string messageId)
        {
            var message = UAMessageCenter.Shared.MessageList.Message(messageId);
            if (message is not null)
            {
                var toRead = new UAInboxMessage[1];
                toRead[0] = message;
                UAMessageCenter.Shared.MessageList.MarkMessagesRead(toRead, null);
            }
         
        }

        public void DeleteMessage(string messageId)
        {
            var message = UAMessageCenter.Shared.MessageList.Message(messageId);
            if (message is not null)
            {
                var toDelete = new UAInboxMessage[1];
                toDelete[0] = message;
                UAMessageCenter.Shared.MessageList.MarkMessagesDeleted(toDelete, null);
            }
        }

        public int MessageCenterUnreadCount => (int)UAMessageCenter.Shared.MessageList.UnreadCount;

        public int MessageCenterCount => (int)UAMessageCenter.Shared.MessageList.MessageCount();

        public List<MessageCenter.Message> InboxMessages
        {
            get
            {
                var messagesList = new List<MessageCenter.Message>();
                var messages = UAMessageCenter.Shared.MessageList.Messages;
                foreach (var message in messages)
                {
                    var extras = new Dictionary<string, string?>();
                    foreach (var key in message.Extra.Keys)
                    {
                        extras.Add(key.ToString(), message.Extra[key].ToString());
                    }

                    DateTime? sentDate = FromNSDate(message.MessageSent);
                    DateTime? expirationDate = FromNSDate(message.MessageExpiration);

                    string? iconUrl = null;
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

        public void FetchInboxMessages(Action<bool> onComplete)
        {
            UAMessageCenter.Shared.MessageList.RetrieveMessageList(
                () => onComplete.Invoke(true),
                () => onComplete.Invoke(false)
            );
        }

        private static NSDate? FromDateTime(DateTime? dateTime)
        {
            if (dateTime is null)
            {
                return null;
            }

            if (dateTime.Value.Kind == DateTimeKind.Unspecified)
            {
                dateTime = DateTime.SpecifyKind((DateTime)dateTime, DateTimeKind.Utc);
            }

            return (NSDate)dateTime;
        }

        private static DateTime? FromNSDate(NSDate? date)
        {
            if (date == null)
            {
                return null;
            }
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(date.SecondsSince1970);
        }

        public Channel.TagGroupsEditor EditNamedUserTagGroups() =>
            new((List<Channel.TagGroupsEditor.TagOperation> payload) =>
            {
                TagGroupHelper(payload, true);
                UAirship.NamedUser.UpdateTags();
            });

        public Channel.TagGroupsEditor EditChannelTagGroups() =>
            new((List<Channel.TagGroupsEditor.TagOperation> payload) =>
            {
                TagGroupHelper(payload, false);
                UAirship.Push.UpdateRegistration();
            });

        public AttributeEditor EditAttributes() => EditChannelAttributes();

        public AttributeEditor EditChannelAttributes() =>
            new((List<AttributeEditor.IAttributeOperation> operations) =>
            {
                var mutations = UAAttributeMutations.Mutations;
                ApplyAttributesOperations(mutations, operations);
                UAirship.Channel.ApplyAttributeMutations(mutations);
            });

        public AttributeEditor EditNamedUserAttributes() =>
            new((List<AttributeEditor.IAttributeOperation> operations) =>
            {
                var mutations = UAAttributeMutations.Mutations;
                ApplyAttributesOperations(mutations, operations);
                UAirship.NamedUser.ApplyAttributeMutations(mutations);
            });

        private static void ApplyAttributesOperations(UAAttributeMutations mutations, List<AttributeEditor.IAttributeOperation> operations)
        {
            foreach (var operation in operations)
            {
                if (operation is AttributeEditor.SetAttributeOperation<string> stringOperation)
                {
                    mutations.SetString(stringOperation.Value, stringOperation.Key);
                }

                if (operation is AttributeEditor.SetAttributeOperation<int> intOperation)
                {
                    mutations.SetNumber(intOperation.Value, intOperation.Key);
                }

                if (operation is AttributeEditor.SetAttributeOperation<long> longOperation)
                {
                    mutations.SetNumber(longOperation.Value, longOperation.Key);
                }

                if (operation is AttributeEditor.SetAttributeOperation<float> floatOperation)
                {
                    mutations.SetNumber(floatOperation.Value, floatOperation.Key);
                }

                if (operation is AttributeEditor.SetAttributeOperation<double> doubleOperation)
                {
                    mutations.SetNumber(doubleOperation.Value, doubleOperation.Key);
                }

                if (operation is AttributeEditor.SetAttributeOperation<DateTime> dateOperation)
                {
                    var date = FromDateTime(dateOperation.Value);
                    mutations.SetDate(date, dateOperation.Key);
                }

                if (operation is AttributeEditor.RemoveAttributeOperation removeOperation)
                {
                    mutations.RemoveAttribute(removeOperation.Key);
                }
            }
        }

        private static void TagGroupHelper(List<Channel.TagGroupsEditor.TagOperation> operations, bool namedUser)
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
            onDeepLinkReceived?.Invoke(this, new DeepLinkEventArgs(url.AbsoluteString!));
            completionHandler();
        }

        public void DisplayMessageCenter(string messageID, bool animated) =>
            onMessageCenterDisplay?.Invoke(this, new MessageCenterEventArgs(messageID));
        

        public void DisplayMessageCenterAnimated(bool animated) =>
            onMessageCenterDisplay?.Invoke(this, new MessageCenterEventArgs());

        public void DismissMessageCenterAnimated(bool animated) {
        }

        public bool InAppAutomationPaused
        {
            get => UAInAppAutomation.Shared.Paused;
            set => UAInAppAutomation.Shared.Paused = value;
        }

        public TimeSpan InAppAutomationDisplayInterval
        {
            get => TimeSpan.FromSeconds(UAInAppAutomation.Shared.InAppMessageManager.DisplayInterval);
            set => UAInAppAutomation.Shared.InAppMessageManager.DisplayInterval = value.TotalSeconds;
        }

    }
}
