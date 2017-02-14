/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;

namespace UrbanAirship.Portable
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
				return UAirship.Shared().PushManager.Tags;
			}
		}

		public string ChannelId
		{
			get
			{
				return UAirship.Shared().PushManager.ChannelId;
			}
		}

		public bool LocationEnabled
		{
			get
			{
				return UAirship.Shared().LocationManager.LocationUpdatesEnabled;
			}

			set
			{
				UAirship.Shared().LocationManager.LocationUpdatesEnabled = value;
			}
		}

		public bool BackgroundLocationAllowed
		{
			get
			{
				return UAirship.Shared().LocationManager.BackgroundLocationAllowed;
			}

			set
			{
				UAirship.Shared().LocationManager.BackgroundLocationAllowed = value;
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

		public Push.TagEditor EditDeviceTags()
		{
			return new Push.TagEditor(this.DeviceTagHelper);
		}

		private void DeviceTagHelper(bool clear, string[] addTags, string[] removeTags)
		{
			var editor = UAirship.Shared().PushManager.EditTags();

			if (clear)
			{
				editor = editor.Clear();
			}

			editor.AddTags(addTags).RemoveTags(removeTags).Apply();
		}

		public void AddCustomEvent(Portable.Analytics.CustomEvent customEvent)
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

			UAirship.Shared().Analytics.AddEvent(builder.Create());
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
			UAirship.Shared().Inbox.StartInboxActivity();
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

		public Push.TagGroupsEditor EditNamedUserTagGroups()
		{
			return new Push.TagGroupsEditor((List<Push.TagGroupsEditor.TagOperation> payload) =>
			{
				var editor = UAirship.Shared().NamedUser.EditTagGroups();
				TagGroupHelper(payload, editor);
				editor.Apply();
			});
		}

		public Push.TagGroupsEditor EditChannelTagGroups()
		{
			return new Push.TagGroupsEditor((List<Push.TagGroupsEditor.TagOperation> payload) =>
			{
				var editor = UAirship.Shared().PushManager.EditTagGroups();
				TagGroupHelper(payload, editor);
				editor.Apply();
			});
		}

		private void TagGroupHelper(List<Push.TagGroupsEditor.TagOperation> payload, UrbanAirship.Push.TagGroupsEditor editor)
		{
			foreach (Push.TagGroupsEditor.TagOperation tagOperation in payload)
			{

				switch (tagOperation.operationType)
				{
					case Push.TagGroupsEditor.OperationType.ADD:
						editor.AddTags(tagOperation.group, tagOperation.tags);
						break;
					case Push.TagGroupsEditor.OperationType.REMOVE:
						editor.RemoveTags(tagOperation.group, tagOperation.tags);
						break;
					case Push.TagGroupsEditor.OperationType.SET:
						editor.SetTags(tagOperation.group, tagOperation.tags);
						break;
					default:
						break;
				}
			}
		}
	}
}