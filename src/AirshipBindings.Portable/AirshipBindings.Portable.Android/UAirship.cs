/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;

using UrbanAirship;

namespace UrbanAirship.Portable
{
	public class UAirship : IUAirship
	{
		private static UAirship sharedAirship = new UAirship();

		public static UAirship Shared
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
				return UrbanAirship.UAirship.Shared().PushManager.UserNotificationsEnabled;
			}

			set
			{
				UrbanAirship.UAirship.Shared().PushManager.UserNotificationsEnabled = value;
			}
		}

		public IEnumerable<string> Tags
		{
			get
			{
				return UrbanAirship.UAirship.Shared().PushManager.Tags;
			}
		}

		public string ChannelId
		{
			get
			{
				return UrbanAirship.UAirship.Shared().PushManager.ChannelId;
			}
		}

		public bool LocationEnabled
		{
			get
			{
				return UrbanAirship.UAirship.Shared().LocationManager.LocationUpdatesEnabled;
			}

			set
			{
				UrbanAirship.UAirship.Shared().LocationManager.LocationUpdatesEnabled = value;
			}
		}

		public bool BackgroundLocationAllowed
		{
			get
			{
				return UrbanAirship.UAirship.Shared().LocationManager.BackgroundLocationAllowed;
			}

			set
			{
				UrbanAirship.UAirship.Shared().LocationManager.BackgroundLocationAllowed = value;
			}
		}

		public string Alias
		{
			get
			{
				return UrbanAirship.UAirship.Shared().PushManager.Alias;
			}

			set
			{
				UrbanAirship.UAirship.Shared().PushManager.Alias = value;
			}
		}

		public string NamedUser
		{
			get
			{
				return UrbanAirship.UAirship.Shared().NamedUser.Id;
			}

			set
			{
				UrbanAirship.UAirship.Shared().NamedUser.Id = value;
			}
		}

		public Push.TagEditor EditDeviceTags()
		{
			return new Push.TagEditor(this.DeviceTagHelper);
		}

		private void DeviceTagHelper(List<string> addTags, List<string> removeTags)
		{
			UrbanAirship.UAirship.Shared().PushManager.EditTags()
						.AddTags(addTags)
						.RemoveTags(removeTags)
						.Apply();
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

			UrbanAirship.Analytics.CustomEvent.Builder builder = new UrbanAirship.Analytics.CustomEvent.Builder(eventName)
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

			UrbanAirship.UAirship.Shared().Analytics.AddEvent(builder.Create());
		}

		public void AssociateIdentifier(string key, string identifier)
		{
			if (identifier == null)
			{
				UrbanAirship.UAirship.Shared().Analytics.EditAssociatedIdentifiers().RemoveIdentifier(key).Apply();
			}
			else
			{
				UrbanAirship.UAirship.Shared().Analytics.EditAssociatedIdentifiers().AddIdentifier(key, identifier).Apply();
			}
		}

		public void DisplayMessageCenter()
		{
			UrbanAirship.UAirship.Shared().Inbox.StartInboxActivity();
		}

		public int MessageCenterUnreadCount
		{
			get
			{
				return UrbanAirship.UAirship.Shared().Inbox.UnreadCount;
			}
		}

		public int MessageCenterCount
		{
			get
			{
				return UrbanAirship.UAirship.Shared().Inbox.Count;
			}
		}

		public Push.TagGroupsEditor EditNamedUserTagGroups()
		{
			return new Push.TagGroupsEditor((Dictionary<string, Dictionary<string, List<string>>> payload) =>
			{
				UrbanAirship.Push.TagGroupsEditor editor = UrbanAirship.UAirship.Shared().NamedUser.EditTagGroups();
				TagGroupHelper(payload, editor);
				editor.Apply();
			});
		}

		public Push.TagGroupsEditor EditChannelTagGroups()
		{
			return new Push.TagGroupsEditor((Dictionary<string, Dictionary<string, List<string>>> payload) =>
			{
				UrbanAirship.Push.TagGroupsEditor editor = UrbanAirship.UAirship.Shared().PushManager.EditTagGroups();
				TagGroupHelper(payload, editor);
				editor.Apply();
			});
		}

		private void TagGroupHelper(Dictionary<string, Dictionary<string, List<string>>> payload, UrbanAirship.Push.TagGroupsEditor editor)
		{
			var actions = new Dictionary<string, Action<string, List<string>>>()
			{
				{ Push.TagGroupsEditor.ADD, (g, t) => editor.AddTags(g, t.ToArray()) },
				{ Push.TagGroupsEditor.REMOVE, (g, t) => editor.RemoveTags(g, t.ToArray()) },
				{ Push.TagGroupsEditor.SET, (g, t) => editor.SetTags(g, t.ToArray()) }
			};

			foreach (KeyValuePair<string, Dictionary<string, List<string>>> operation in payload)
			{
				if (!actions.ContainsKey(operation.Key))
				{
					continue;
				}

				foreach (KeyValuePair<string, List<string>> groupTagsPair in operation.Value)
				{
					actions[operation.Key](groupTagsPair.Key, groupTagsPair.Value);
				}
			}
		}
	}
}