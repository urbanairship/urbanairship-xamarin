/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;

namespace UrbanAirship.Portable
{
	public class UAirship : IUAirship
	{
		public bool UserNotificationsEnabled
		{
			get
			{
				return UrbanAirship.UAirship.Push.UserPushNotificationsEnabled;
			}

			set
			{
				UrbanAirship.UAirship.Push.UserPushNotificationsEnabled = value;
			}
		}

		public IEnumerable<string> Tags
		{
			get
			{
				return UrbanAirship.UAirship.Push.Tags;
			}
		}

		public string ChannelId
		{
			get
			{
				return UrbanAirship.UAirship.Push.ChannelID;
			}
		}

		public bool LocationEnabled
		{
			get
			{
				return UrbanAirship.UAirship.Location.LocationUpdatesEnabled;
			}

			set
			{
				UrbanAirship.UAirship.Location.LocationUpdatesEnabled = value;
			}
		}

		public bool BackgroundLocationAllowed
		{
			get
			{
				return UrbanAirship.UAirship.Location.BackgroundLocationUpdatesAllowed;
			}

			set
			{
				UrbanAirship.UAirship.Location.BackgroundLocationUpdatesAllowed = value;
			}
		}

		public string NamedUser
		{
			get
			{
				return UrbanAirship.UAirship.NamedUser.Identifier;
			}

			set
			{
				UrbanAirship.UAirship.NamedUser.Identifier = value;
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
				UrbanAirship.UAirship.Push.Tags = new string[] { };
			}

			UrbanAirship.UAirship.Push.AddTags(addTags);
			UrbanAirship.UAirship.Push.RemoveTags(removeTags);
			UrbanAirship.UAirship.Push.UpdateRegistration();
		}

		public void AddCustomEvent(Portable.Analytics.CustomEvent customEvent)
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

			UrbanAirship.UAirship.Shared.Analytics.AddEvent(uaEvent);
		}

		public void AssociateIdentifier(string key, string identifier)
		{
			UAAssociatedIdentifiers identifiers = UrbanAirship.UAirship.Shared.Analytics.CurrentAssociatedDeviceIdentifiers();
			identifiers.SetIdentifier(identifier, key);
			UrbanAirship.UAirship.Shared.Analytics.AssociateDeviceIdentifiers(identifiers);
		}

		public void DisplayMessageCenter()
		{
			UrbanAirship.UAirship.DefaultMessageCenter.Display();
		}

		public int MessageCenterUnreadCount
		{
			get
			{
				return (int)UrbanAirship.UAirship.Inbox.MessageList.UnreadCount;
			}
		}

		public int MessageCenterCount
		{
			get
			{
				return (int)UrbanAirship.UAirship.Inbox.MessageList.MessageCount;
			}
		}

		public Push.TagGroupsEditor EditNamedUserTagGroups()
		{
			return new Push.TagGroupsEditor((List<Push.TagGroupsEditor.TagOperation> payload) =>
			{
				TagGroupHelper(payload, true);
				UrbanAirship.UAirship.NamedUser.UpdateTags();
			});
		}

		public Push.TagGroupsEditor EditChannelTagGroups()
		{
			return new Push.TagGroupsEditor((List<Push.TagGroupsEditor.TagOperation> payload) =>
			{
				TagGroupHelper(payload, false);
				UrbanAirship.UAirship.Push.UpdateRegistration();
			});
		}

		private void TagGroupHelper(List<Push.TagGroupsEditor.TagOperation> operations, bool namedUser)
		{
			var namedUserActions = new Dictionary<Push.TagGroupsEditor.OperationType, Action<string, string[]>>()
			{
				{ Push.TagGroupsEditor.OperationType.ADD, (group, t) => UrbanAirship.UAirship.NamedUser.AddTags(t, group) },
				{ Push.TagGroupsEditor.OperationType.REMOVE, (group, t) => UrbanAirship.UAirship.NamedUser.RemoveTags(t, group) },
				{ Push.TagGroupsEditor.OperationType.SET, (group, t) => UrbanAirship.UAirship.NamedUser.SetTags(t, group) }
			};
			var channelActions = new Dictionary<Push.TagGroupsEditor.OperationType, Action<string, string[]>>()
			{
				{ Push.TagGroupsEditor.OperationType.ADD, (group, t) => UrbanAirship.UAirship.Push.AddTags(t, group) },
				{ Push.TagGroupsEditor.OperationType.REMOVE, (group, t) => UrbanAirship.UAirship.Push.RemoveTags(t, group) },
				{ Push.TagGroupsEditor.OperationType.SET, (group, t) => UrbanAirship.UAirship.Push.SetTags(t, group) }
			};

			var actions = namedUser ? namedUserActions : channelActions;

			foreach (Push.TagGroupsEditor.TagOperation operation in operations)
			{
				if (!Enum.IsDefined(typeof(Push.TagGroupsEditor.OperationType), operation.operationType))
				{
					continue;
				}

				actions[operation.operationType](operation.group, operation.tags);
			}
		}
	}
}