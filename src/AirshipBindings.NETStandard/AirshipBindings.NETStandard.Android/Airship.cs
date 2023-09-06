/*
 Copyright Airship and Contributors
*/

using System.Collections.Generic;
using Java.Util;
using Java.Util.Concurrent;
using UrbanAirship.NETStandard.Attributes;
using UrbanAirship.Actions;
using System;
using UrbanAirship;
using UrbanAirship.MessageCenter;
using UrbanAirship.Automation;
using UrbanAirship.Push;

namespace UrbanAirship.NETStandard
{ 
    public class Airship : Java.Lang.Object, IDeepLinkListener, IAirship, IInboxListener, MessageCenterClass.IOnShowMessageCenterListener, UrbanAirship.Channel.IAirshipChannelListener, IPushNotificationStatusListener
    {
        private static Lazy<Airship> sharedAirship = new Lazy<Airship>(() =>
        {
            Airship instance = new Airship();
            instance.Init();
            return instance;
        });

        private void Init()
        {
            UAirship.Shared().Channel.AddChannelListener(this);

            //Adding Push notification status listener
            UAirship.Shared().PushManager.AddNotificationStatusListener(this);
            
            //Adding Inbox updated listener
            MessageCenterClass.Shared().Inbox.AddListener(this);
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
                UAirship.Shared().DeepLinkListener = this;
            }

            remove
            {
                onDeepLinkReceived -= value;

                if (onDeepLinkReceived == null)
                {
                    UAirship.Shared().DeepLinkListener = null;
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
                MessageCenterClass.Shared().SetOnShowMessageCenterListener(this);
            }

            remove
            {
                onMessageCenterDisplay -= value;

                if (onMessageCenterDisplay == null)
                {
                    MessageCenterClass.Shared().SetOnShowMessageCenterListener(null);
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
                return UAirship.Shared().PushManager.UserNotificationsEnabled;
            }

            set
            {
                UAirship.Shared().PushManager.UserNotificationsEnabled = value;
            }
        }

        public Features EnabledFeatures
        {
            get
            {
                return featuresFromUAFeatures(UAirship.Shared().PrivacyManager.EnabledFeatures);
            }
            set
            {
                UAirship.Shared().PrivacyManager.SetEnabledFeatures(uaFeaturesFromFeatures(value));
            }
        }

        public void EnableFeatures(Features features)
        {
            UAirship.Shared().PrivacyManager.Enable(uaFeaturesFromFeatures(features));
        }

        public void DisableFeatures(Features features)
        {
            UAirship.Shared().PrivacyManager.Disable(uaFeaturesFromFeatures(features));
        }

        public bool IsFeatureEnabled(Features feature)
        {
            return EnabledFeatures.HasFlag(feature);
        }

        public bool IsAnyFeatureEnabled()
        {
            return EnabledFeatures != Features.None;
        }

        private int[]  uaFeaturesFromFeatures(Features features)
        {
            List<int> uAFeatures = new List<int>();

            if (features.HasFlag(Features.InAppAutomation))
            {
                uAFeatures.Add(PrivacyManager.FeatureInAppAutomation);
            }
            if (features.HasFlag(Features.MessageCenter))
            {
                uAFeatures.Add(PrivacyManager.FeatureMessageCenter);
            }
            if (features.HasFlag(Features.Push))
            {
                uAFeatures.Add(PrivacyManager.FeaturePush);
            }
            if (features.HasFlag(Features.Analytics))
            {
                uAFeatures.Add(PrivacyManager.FeatureAnalytics);
            }
            if (features.HasFlag(Features.TagsAndAttributes))
            {
                uAFeatures.Add(PrivacyManager.FeatureTagsAndAttributes);
            }
            if (features.HasFlag(Features.Contacts))
            {
                uAFeatures.Add(PrivacyManager.FeatureContacts);
            }

            return uAFeatures.ToArray();
        }

        private Features featuresFromUAFeatures(int uAFeatures)
        {
            Features features = Features.None;

            if ((uAFeatures & PrivacyManager.FeatureInAppAutomation) == PrivacyManager.FeatureInAppAutomation)
            {
                features |= Features.InAppAutomation;
            }

            if ((uAFeatures & PrivacyManager.FeatureMessageCenter) == PrivacyManager.FeatureMessageCenter)
            {
                features |= Features.MessageCenter;
            }

            if ((uAFeatures & PrivacyManager.FeaturePush) == PrivacyManager.FeaturePush)
            {
                features |= Features.Push;
            }

            if ((uAFeatures & PrivacyManager.FeatureAnalytics) == PrivacyManager.FeatureAnalytics)
            {
                features |= Features.Analytics;
            }

            if ((uAFeatures & PrivacyManager.FeatureTagsAndAttributes) == PrivacyManager.FeatureTagsAndAttributes)
            {
                features |= Features.TagsAndAttributes;
            }

            if ((uAFeatures & PrivacyManager.FeatureContacts) == PrivacyManager.FeatureContacts)
            {
                features |= Features.Contacts;
            }

            return features;
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

        public void GetNamedUser(Action<string> namedUser)
        {
            string NamedUserId = UAirship.Shared().Contact.NamedUserId;
            namedUser(NamedUserId);
        }

        public string NamedUser
        {
            set
            {
                if (value == null)
                {
                    UAirship.Shared().Contact.Reset();
                } else
                {
                    UAirship.Shared().Contact.Identify(value);
                }
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

        public void AddCustomEvent(Analytics.CustomEvent customEvent)
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

        public void TrackScreen(string screen)
        {
            UAirship.Shared().Analytics.TrackScreen(screen);
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
            MessageCenterClass.Shared().ShowMessageCenter();
        }

        public void DisplayMessage(string messageId)
        {
            MessageCenterClass.Shared().ShowMessageCenter(messageId);
        }

        public void MarkMessageRead(string messageId)
        {
            var toRead = new List<String>
            {
                messageId
            };
            MessageCenterClass.Shared().Inbox.MarkMessagesRead(toRead);
        }

        public void DeleteMessage(string messageId)
        {
            var toDelete = new List<String>
            {
                messageId
            };
            MessageCenterClass.Shared().Inbox.DeleteMessages(toDelete);
        }

        public void MessageCenterUnreadCount(Action<int> messageCount)
        {
            int count = MessageCenterClass.Shared().Inbox.UnreadCount;
            messageCount(count);
        }

        public void MessageCenterCount(Action<int> messageCount)
        {
           int count = MessageCenterClass.Shared().Inbox.Count;
            messageCount(count);
        }

        public List<MessageCenter.Message> InboxMessages
        {
            get
            {
                var messagesList = new List<MessageCenter.Message>();
                var messages = MessageCenterClass.Shared().Inbox.Messages;
                foreach (var message in messages)
                {
                    var extras = new Dictionary<string, string>();
                    foreach (var key in message.Extras.KeySet())
                    {
                        extras.Add(key, message.Extras.Get(key).ToString());
                    }

                    DateTime? sentDate = FromDate(message.SentDate);
                    DateTime? expirationDate = FromDate(message.ExpirationDate);

                    var inboxMessage = new MessageCenter.Message(
                        message.MessageId,
                        message.Title,
                        sentDate,
                        expirationDate,
                        message.IsRead,
                        message.ListIconUrl,
                        extras);

                    messagesList.Add(inboxMessage);
                }

                return messagesList;
            }
        }

        private Date FromDateTime(DateTime dateTime)
        {
            if (dateTime == null)
            {
                return null;
            }

            long epochSeconds = new DateTimeOffset(dateTime).ToUnixTimeSeconds();
            return new Date(epochSeconds * 1000);
        }

        private DateTime? FromDate(Date date)
        {
            if (date == null)
            {
                return null;
            }
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddMilliseconds(date.Time);
        }

        public Channel.TagGroupsEditor EditNamedUserTagGroups()
        {
            return new Channel.TagGroupsEditor((List<Channel.TagGroupsEditor.TagOperation> payload) =>
            {
                var editor = UAirship.Shared().Contact.EditTagGroups();
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
            return EditChannelAttributes();
        }

        public AttributeEditor EditChannelAttributes()
        {
            return new AttributeEditor((List<AttributeEditor.IAttributeOperation> operations) =>
            {
                var editor = UAirship.Shared().Channel.EditAttributes();
                ApplyAttributesOperations(editor, operations);
                editor.Apply();
            });
        }

        /// <summary>
        public AttributeEditor EditNamedUserAttributes()
        {
            return new AttributeEditor((List<AttributeEditor.IAttributeOperation> operations) =>
            {
                var editor = UAirship.Shared().Contact.EditAttributes();
                ApplyAttributesOperations(editor, operations);
                editor.Apply();
            });
        }

        private void ApplyAttributesOperations(UrbanAirship.Channel.AttributeEditor editor, List<AttributeEditor.IAttributeOperation> operations)
        {
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
                    
                if (operation is AttributeEditor.SetAttributeOperation<DateTime> dateOperation)
                {
                    Date date = FromDateTime(dateOperation.value);
                    editor.SetAttribute(dateOperation.key, date);
                }

                if (operation is AttributeEditor.RemoveAttributeOperation removeOperation)
                {
                    editor.RemoveAttribute(removeOperation.key);
                }
            }
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

        public bool InAppAutomationEnabled
        {
            get
            {
                return InAppAutomation.Shared().Enabled;
            }

            set
            {
                InAppAutomation.Shared().Enabled = value;
            }
        }

        public bool InAppAutomationPaused
        {
            get
            {
                return InAppAutomation.Shared().Paused;
            }

            set
            {
                InAppAutomation.Shared().Paused = value;
            }
        }

        public TimeSpan InAppAutomationDisplayInterval
        {
            get
            {
                return TimeSpan.FromMilliseconds(InAppAutomation.Shared().InAppMessageManager.DisplayInterval);
            }

            set
            {
                InAppAutomation.Shared().InAppMessageManager.SetDisplayInterval((long)value.TotalMilliseconds, TimeUnit.Milliseconds);
            }
        }

        public bool OnDeepLink(string deepLink)
        {
            if (onDeepLinkReceived != null) {
                onDeepLinkReceived(this, new DeepLinkEventArgs(deepLink));
                return true;
            }

            return false;
        }

        public bool OnShowMessageCenter(string messageId)
        {
            if (onMessageCenterDisplay != null)
            {
                onMessageCenterDisplay(this, new MessageCenterEventArgs(messageId));
                return true;
            }

            return false;
        }

        public void OnInboxUpdated()
        {
            //Adding Inbox updated listener
            OnMessageCenterUpdated?.Invoke(this, EventArgs.Empty);
        }

        public void OnChannelCreated(string channelId)
        {
            OnChannelCreation?.Invoke(this, new ChannelEventArgs(channelId));
        }

        public void OnChange(PushNotificationStatus status) => OnPushNotificationStatusUpdate?.Invoke(this,
            new PushNotificationStatusEventArgs(
                status.IsUserNotificationsEnabled,
                status.AreNotificationsAllowed,
                status.IsPushPrivacyFeatureEnabled,
                status.IsPushTokenRegistered,
                status.IsUserOptedIn,
                status.IsOptIn)
            );
    }
}
