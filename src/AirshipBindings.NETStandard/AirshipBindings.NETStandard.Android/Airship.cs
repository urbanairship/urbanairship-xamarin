/*
 Copyright Airship and Contributors
*/

using System.Collections.Generic;
using Java.Util;
using UrbanAirship.NETStandard.Attributes;
using UrbanAirship.Actions;
using System;
using UrbanAirship.MessageCenter;

namespace UrbanAirship.NETStandard
{
    public delegate void DeepLinkHandler(string deepLink);

    public class Airship : Java.Lang.Object, IDeepLinkListener, IAirship, IInboxListener
    {
        private static Lazy<Airship> sharedAirship = new Lazy<Airship>(() =>
        {
            Airship instance = new Airship();
            instance.Init();
            return instance;
        });

        private void Init()
        {
            //Adding Inbox updated listener
            EventHandler handler = OnMessageCenterUpdated;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
            MessageCenterClass.Shared().Inbox.AddListener(this);
        }

        public event EventHandler OnMessageCenterUpdated;

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

        public bool DataCollectionEnabled
        {
            get
            {
                return UAirship.Shared().DataCollectionEnabled;
            }

            set
            {
                UAirship.Shared().DataCollectionEnabled = value;
            }
        }

        public bool PushTokenRegistrationEnabled
        {
            get
            {
                return UAirship.Shared().PushManager.PushTokenRegistrationEnabled;
            }

            set
            {
                UAirship.Shared().PushManager.PushTokenRegistrationEnabled = value;
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

        private DeepLinkHandler onDeepLinkReceived;
        public event DeepLinkHandler OnDeepLinkReceived
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

        public int MessageCenterUnreadCount
        {
            get
            {
                return MessageCenterClass.Shared().Inbox.UnreadCount;
            }
        }

        public int MessageCenterCount
        {
            get
            {
                return MessageCenterClass.Shared().Inbox.Count;
            }
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

        public AttributeEditor EditNamedUserAttributes()
        {
            return new AttributeEditor((List<AttributeEditor.IAttributeOperation> operations) =>
            {
                var editor = UAirship.Shared().NamedUser.EditAttributes();
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

        public bool OnDeepLink(string deepLink)
        {
            var handler = onDeepLinkReceived;
            handler(deepLink);
            return true;
        }

        public void OnInboxUpdated()
        {
        }
    }
}
