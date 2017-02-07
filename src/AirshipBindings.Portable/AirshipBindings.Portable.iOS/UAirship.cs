/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using System.Collections.Generic;

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

		public string Alias
		{
			get
			{
				return UrbanAirship.UAirship.Push.Alias;
			}

			set
			{
				UrbanAirship.UAirship.Push.Alias = value;
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

		private void DeviceTagHelper(List<string> addTags, List<string> removeTags)
		{
			UrbanAirship.UAirship.Push.AddTags(addTags.ToArray());
			UrbanAirship.UAirship.Push.RemoveTags(removeTags.ToArray());
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

			UrbanAirship.UACustomEvent builder = UrbanAirship.UACustomEvent.Event(eventName, eventValue);

			if (!string.IsNullOrEmpty(transactionId))
			{
				builder.TransactionID = transactionId;
			}

			if (!string.IsNullOrEmpty(interactionId))
			{
				builder.InteractionID = interactionId;
			}

			if (!string.IsNullOrEmpty(interactionType))
			{
				builder.InteractionType = interactionType;
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
						builder.SetStringProperty(property.stringValue, property.name);
					}
					else if (property.value is double)
					{
						builder.SetNumberProperty(property.doubleValue, property.name);
					}
					else if (property.value is bool)
					{
						builder.SetBoolProperty(property.boolValue, property.name);
					}
					else if (property.value is string[])
					{
						builder.SetStringArrayProperty(property.stringArrayValue, property.name);
					}
				}
			}

			UrbanAirship.UAirship.Shared.Analytics.AddEvent(builder);
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
			return new Push.TagGroupsEditor((Dictionary<string, Dictionary<string, List<string>>> payload) =>
			{
				TagGroupHelper(payload, true);
				UrbanAirship.UAirship.NamedUser.UpdateTags();
			});
		}

		public Push.TagGroupsEditor EditChannelTagGroups()
		{
			return new Push.TagGroupsEditor((Dictionary<string, Dictionary<string, List<string>>> payload) =>
			{
				TagGroupHelper(payload, false);
				UrbanAirship.UAirship.Push.UpdateRegistration();
			});
		}

		private void TagGroupHelper(Dictionary<string, Dictionary<string, List<string>>> operations, bool namedUser)
		{
			var namedUserActions = new Dictionary<string, Action<string, List<string>>>()
			{
				{ Push.TagGroupsEditor.ADD, (group, t) => UrbanAirship.UAirship.NamedUser.AddTags(t.ToArray(), group) },
				{ Push.TagGroupsEditor.REMOVE, (group, t) => UrbanAirship.UAirship.NamedUser.RemoveTags(t.ToArray(), group) },
				{ Push.TagGroupsEditor.SET, (group, t) => UrbanAirship.UAirship.NamedUser.SetTags(t.ToArray(), group) }
			};
			var channelActions = new Dictionary<string, Action<string, List<string>>>()
			{
				{ Push.TagGroupsEditor.ADD, (group, t) => UrbanAirship.UAirship.Push.AddTags(t.ToArray(), group) },
				{ Push.TagGroupsEditor.REMOVE, (group, t) => UrbanAirship.UAirship.Push.RemoveTags(t.ToArray(), group) },
				{ Push.TagGroupsEditor.SET, (group, t) => UrbanAirship.UAirship.Push.SetTags(t.ToArray(), group) }
			};

			var actions = namedUser ? namedUserActions : channelActions;

			foreach (KeyValuePair<string, Dictionary<string, List<string>>> operation in operations)
			{
				if (!actions.ContainsKey(operation.Key))
				{
					continue;
				}

				foreach (KeyValuePair<string, List<string>> g in operation.Value)
				{
					actions[operation.Key](g.Key, g.Value);
				}
			}
		}
	}
}