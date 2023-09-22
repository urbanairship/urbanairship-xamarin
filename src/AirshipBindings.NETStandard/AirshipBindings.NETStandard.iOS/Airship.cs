/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UrbanAirship;
using UrbanAirship.NETStandard;
using UrbanAirship.NETStandard.Analytics;
using UrbanAirship.NETStandard.Attributes;
using Xamarin.Forms;

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

            NSNotificationCenter.DefaultCenter.AddObserver(aName: (NSString)UAChannel.ChannelCreatedEvent, (NSNotification notification) =>
            {
                string channelID = notification.UserInfo[UAChannel.ChannelIdentifierKey].ToString();
                OnChannelCreation?.Invoke(this, new ChannelEventArgs(channelID));
            });

            //FIXME: Use UAPush.NotificationStatusUpdateEvent once it's available
            NSNotificationCenter.DefaultCenter.AddObserver(aName: (NSString)"com.urbanairship.notification.status.update", (notification) =>
            {
                OnPushNotificationStatusUpdate?.Invoke(this,
                    new PushNotificationStatusEventArgs(
                        Convert.ToBoolean(notification.UserInfo["isUserNotificationsEnabled"]),
                        Convert.ToBoolean(notification.UserInfo["areNotificationsAllowed"]),
                        Convert.ToBoolean(notification.UserInfo["isPushPrivacyFeatureEnabled"]),
                        Convert.ToBoolean(notification.UserInfo["isPushTokenRegistered"]),
                        Convert.ToBoolean(notification.UserInfo["isUserOptedIn"]),
                        Convert.ToBoolean(notification.UserInfo["isOptIn"])
                    )
                );
            });

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

        public void GetNamedUser(Action<string> namedUser)
        {
            UAirship.Contact.GetNamedUserID(namedUser);
        }

        public void ResetContact()
        {
            UAirship.Contact.Reset();
        }

        public void IdentifyContact(string namedUserId)
        {
            UAirship.Contact.Identify(namedUserId);
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
                    //TODO: 
                    //uaEvent.Properties = new NSDictionary<NSString, NSObject>(propertyDictionary.Keys, propertyDictionary.Values);
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
            UAAssociatedIdentifiers identifiers = UAirship.Analytics.CurrentAssociatedDeviceIdentifiers();
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

        public void DismissMessageCenter()
        {
        }

        public void MarkMessageRead(string messageId)
        {
            string[] toRead = { messageId };
            UAMessageCenter.Shared.Inbox.MarkReadWithMessageIDs(toRead, null);
        }

        public void DeleteMessage(string messageId)
        {
            string[] toDelete = { messageId };
            UAMessageCenter.Shared.Inbox.DeleteWithMessageIDs(toDelete, null);
        }

        public void MessageCenterUnreadCount(Action<int> messageCount)
        {
            UAMessageCenter.Shared.Inbox.GetUnreadCount(messageCount);
        }

        public void MessageCenterCount(Action<int> messageCount)
        {
            UAMessageCenter.Shared.Inbox.GetMessages(messages =>
            {
                messageCount(messages.Length);
            });
        }

        public void InboxMessages(Action<List<MessageCenter.Message>> listMessages)
        {
            var messagesList = new List<MessageCenter.Message>();
            UAMessageCenter.Shared.Inbox.GetMessages(messages =>
            {
                foreach (var message in messages)
                {
                    var extras = new Dictionary<string, string>();
                    foreach (var key in message.Extra.Keys)
                    {
                        extras.Add(key.ToString(), message.Extra[key].ToString());
                    }

                    DateTime? sentDate = FromNSDate(message.SentDate);
                    DateTime? expirationDate = FromNSDate(message.ExpirationDate);

                    string iconUrl = message.ListIcon;

                    var inboxMessage = new MessageCenter.Message(
                        message.Id,
                        message.Title,
                        sentDate,
                        expirationDate,
                        message.Unread,
                        iconUrl,
                        extras);

                    messagesList.Add(inboxMessage);
                }

                listMessages(messagesList);
            });
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


        public Channel.TagGroupsEditor EditChannelTagGroups()
        {
            return new Channel.TagGroupsEditor((List<Channel.TagGroupsEditor.TagOperation> payload) =>
            {
                ChannelTagGroupHelper(payload, () =>
                {
                    UAirship.Push.UpdateRegistration();
                });
            });
        }

        public Channel.TagGroupsEditor EditContactTagGroups()
        {
            return new Channel.TagGroupsEditor((List<Channel.TagGroupsEditor.TagOperation> payload) =>
            {
                ContactTagGroupHelper(payload);
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
                ApplyChannelAttributesOperations(operations);
            });
        }

        public AttributeEditor EditContactAttributes()
        {
            return new AttributeEditor((List<AttributeEditor.IAttributeOperation> operations) =>
            {
                ApplyContactAttributesOperations(operations);
            });
        }


        public Channel.SubscriptionListEditor EditChannelSubscriptionLists()
        {
            return new Channel.SubscriptionListEditor((List<Channel.SubscriptionListEditor.SubscriptionListOperation> payload) =>
            {
                ApplyChannelSubscriptionListHelper(payload);
            });
        }

        public Contact.SubscriptionListEditor EditContactSubscriptionLists()
        {
            return new Contact.SubscriptionListEditor((List<Contact.SubscriptionListEditor.SubscriptionListOperation> payload) =>
            {
                ApplyContactSubscriptionListHelper(payload);
            });
        }

        private void ApplyChannelAttributesOperations(List<AttributeEditor.IAttributeOperation> operations)
        {
            UAirship.Channel.EditAttributes( editor =>
            {
                foreach (var operation in operations)
                {
                    if (operation is AttributeEditor.SetAttributeOperation<string> stringOperation)
                    {
                        editor.SetString(stringOperation.value, stringOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<int> intOperation)
                    {
                        editor.SetNumber(intOperation.value, intOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<long> longOperation)
                    {
                        editor.SetNumber(longOperation.value, longOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<float> floatOperation)
                    {
                        editor.SetNumber(floatOperation.value, floatOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<double> doubleOperation)
                    {
                        editor.SetNumber(doubleOperation.value, doubleOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<DateTime> dateOperation)
                    {
                        NSDate date = FromDateTime(dateOperation.value);
                        editor.SetDate(date, dateOperation.key);
                    }

                    if (operation is AttributeEditor.RemoveAttributeOperation removeOperation)
                    {
                        editor.RemoveAttribute(removeOperation.key);
                    }
                }
                editor.Apply();
            });

        }

        private void ApplyContactAttributesOperations(List<AttributeEditor.IAttributeOperation> operations)
        {
            UAirship.Contact.EditAttributes( editor =>
            {
                foreach (var operation in operations)
                {
                    if (operation is AttributeEditor.SetAttributeOperation<string> stringOperation)
                    {
                        editor.SetString(stringOperation.value, stringOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<int> intOperation)
                    {
                        editor.SetNumber(intOperation.value, intOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<long> longOperation)
                    {
                        editor.SetNumber(longOperation.value, longOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<float> floatOperation)
                    {
                        editor.SetNumber(floatOperation.value, floatOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<double> doubleOperation)
                    {
                        editor.SetNumber(doubleOperation.value, doubleOperation.key);
                    }

                    if (operation is AttributeEditor.SetAttributeOperation<DateTime> dateOperation)
                    {
                        NSDate date = FromDateTime(dateOperation.value);
                        editor.SetDate(date, dateOperation.key);
                    }

                    if (operation is AttributeEditor.RemoveAttributeOperation removeOperation)
                    {
                        editor.RemoveAttribute(removeOperation.key);
                    }
                }
                editor.Apply();
            });

        }

        private void ContactTagGroupHelper(List<Channel.TagGroupsEditor.TagOperation> operations)
        {
            UAirship.Contact.EditTagGroups( editor =>
            {
                var contactActions = new Dictionary<Channel.TagGroupsEditor.OperationType, Action<string, string[]>>()
                {
                    { Channel.TagGroupsEditor.OperationType.ADD, (group, t) => editor.AddTags(t, group) },
                    { Channel.TagGroupsEditor.OperationType.REMOVE, (group, t) => editor.RemoveTags(t, group) },
                    { Channel.TagGroupsEditor.OperationType.SET, (group, t) => editor.SetTags(t, group) }
                };

                foreach (Channel.TagGroupsEditor.TagOperation operation in operations)
                {
                    if (!Enum.IsDefined(typeof(Channel.TagGroupsEditor.OperationType), operation.operationType))
                    {
                        continue;
                    }

                    string[] tagArray = new string[operation.tags.Count];
                    operation.tags.CopyTo(tagArray, 0);
                    contactActions[operation.operationType](operation.group, tagArray);
                }

                editor.Apply();
            });
        }

        private void ChannelTagGroupHelper(List<Channel.TagGroupsEditor.TagOperation> operations, Action finished)
        {
            UAirship.Channel.EditTagGroups(editor =>
            {
                var channelActions = new Dictionary<Channel.TagGroupsEditor.OperationType, Action<string, string[]>>()
                {
                    { Channel.TagGroupsEditor.OperationType.ADD, (group, t) => editor.AddTags(t, group) },
                    { Channel.TagGroupsEditor.OperationType.REMOVE, (group, t) => editor.RemoveTags(t, group) },
                    { Channel.TagGroupsEditor.OperationType.SET, (group, t) => editor.SetTags(t, group) }
                };

                foreach (Channel.TagGroupsEditor.TagOperation operation in operations)
                {
                    if (!Enum.IsDefined(typeof(Channel.TagGroupsEditor.OperationType), operation.operationType))
                    {
                        continue;
                    }

                    string[] tagArray = new string[operation.tags.Count];
                    operation.tags.CopyTo(tagArray, 0);
                    channelActions[operation.operationType](operation.group, tagArray);
                }

                editor.Apply();
                finished();
            });
        }

        private void ApplyChannelSubscriptionListHelper(List<Channel.SubscriptionListEditor.SubscriptionListOperation> operations)
        {
            UAirship.Channel.EditSubscriptionLists( editor =>
            {
                foreach (Channel.SubscriptionListEditor.SubscriptionListOperation operation in operations)
                {
                    if (!Enum.IsDefined(typeof(Channel.SubscriptionListEditor.OperationType), operation.operationType))
                    {
                        continue;
                    }

                    switch (operation.operationType)
                    {
                        case Channel.SubscriptionListEditor.OperationType.SUBSCRIBE:
                            editor.Subscribe(operation.list);
                            break;
                        case Channel.SubscriptionListEditor.OperationType.UNSUBSCRIBE:
                            editor.Unsubscribe(operation.list);
                            break;
                    }
                }

                editor.Apply();
            });
        }

        private void ApplyContactSubscriptionListHelper(List<Contact.SubscriptionListEditor.SubscriptionListOperation> operations)
        {
            UAirship.Contact.EditSubscriptionLists( editor =>
            {

                foreach (Contact.SubscriptionListEditor.SubscriptionListOperation operation in operations)
                {
                    if (!Enum.IsDefined(typeof(Contact.SubscriptionListEditor.OperationType), operation.operationType))
                    {
                        continue;
                    }

                    string scope = operation.scope;
                    string[] scopes = { "app", "web", "email", "sms" };
                    if (scopes.Any(scope.Contains))
                    {
                        UAChannelScope channelScope = UAChannelScope.App;
                        if (operation.scope == "app")
                        {
                            channelScope = UAChannelScope.App;
                        }
                        else if (operation.scope == "web")
                        {
                            channelScope = UAChannelScope.Web;
                        }
                        else if (operation.scope == "email")
                        {
                            channelScope = UAChannelScope.Email;
                        }
                        else if (operation.scope == "sms")
                        {
                            channelScope = UAChannelScope.Sms;
                        }

                        switch (operation.operationType)
                        {
                            case Contact.SubscriptionListEditor.OperationType.SUBSCRIBE:
                                editor.Subscribe(operation.list, channelScope);
                                break;
                            case Contact.SubscriptionListEditor.OperationType.UNSUBSCRIBE:
                                editor.Unsubscribe(operation.list, channelScope);
                                break;
                        }
                    }
                }

                editor.Apply();
            });
        }

        override public void ReceivedDeepLink(NSUrl url, Action completionHandler)
        {
            onDeepLinkReceived?.Invoke(this, new DeepLinkEventArgs(url.AbsoluteString));
            completionHandler();
        }

        public void OnDisplayMessageCenter(string messageID)
        {
            onMessageCenterDisplay?.Invoke(this, new MessageCenterEventArgs(messageID));
        }

        public void OnDisplayMessageCenter()
        {
            onMessageCenterDisplay?.Invoke(this, new MessageCenterEventArgs());
        }

        public void OnDismissMessageCenter()
        {
        }


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
