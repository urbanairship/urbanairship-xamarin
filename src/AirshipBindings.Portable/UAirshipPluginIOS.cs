using System;
using System.Collections.Generic;

#if __IOS__
using UrbanAirship;

namespace UrbanAirship.Portable
{
	public class UAirshipPluginIOS : IUAirshipPlugin
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

		public void EditDeviceTags(List<string> addTags, List<string> removeTags)
		{
			UrbanAirship.UAirship.Push.AddTags(addTags.ToArray());
			UrbanAirship.UAirship.Push.RemoveTags(removeTags.ToArray());
			UrbanAirship.UAirship.Push.UpdateRegistration();
		}

		public void AddCustomEvent(Portable.Analytics.CustomEvent customEvent) {
			if (customEvent == null || customEvent.EventName == null)
			{
				return;
			}

			string eventName = customEvent.EventName;
			double? eventValue = customEvent.EventValue;
			string transactionId = customEvent.TransactionId;
			string interactionType = customEvent.InteractionType;
			string interactionId = customEvent.InteractionId;
			List<Portable.Analytics.CustomEvent.Property> properties = customEvent.PropertyList;

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

			if (properties != null)
			{
				foreach (var property in properties)
				{
					if (string.IsNullOrEmpty(property.name) || string.IsNullOrEmpty(property.type))
					{
						continue;
					}

					if (property.type == "s")
					{
						builder.SetStringProperty(property.stringValue, property.name);
					}
					else if (property.type == "d")
					{
						builder.SetNumberProperty(property.doubleValue, property.name);
					}
					else if (property.type == "b")
					{
						builder.SetBoolProperty(property.boolValue, property.name);
					}
					else if (property.type == "sa")
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

		public void EditNamedUserTagGroups(Dictionary<string, Dictionary<string, List<string>>> payload)
		{
			TagGroupHelper(payload, true);
			UrbanAirship.UAirship.NamedUser.UpdateTags();
		}

		public void EditChannelTagGroups(Dictionary<string, Dictionary<string, List<string>>> payload)
		{
			TagGroupHelper(payload, false);
			UrbanAirship.UAirship.Push.UpdateRegistration();
		}

		private void TagGroupHelper(Dictionary<string, Dictionary<string, List<string>>> operations, bool namedUser)
		{
			var namedUserActions = new Dictionary<string, Action<string, List<string>>>()
			{
				{ Push.TagGroupEditor.ADD, (group, t) => UrbanAirship.UAirship.NamedUser.AddTags(t.ToArray(), group) },
				{ Push.TagGroupEditor.REMOVE, (group, t) => UrbanAirship.UAirship.NamedUser.RemoveTags(t.ToArray(), group) },
				{ Push.TagGroupEditor.SET, (group, t) => UrbanAirship.UAirship.NamedUser.SetTags(t.ToArray(), group) }
			};
			var channelActions = new Dictionary<string, Action<string, List<string>>>()
			{
				{ Push.TagGroupEditor.ADD, (group, t) => UrbanAirship.UAirship.Push.AddTags(t.ToArray(), group) },
				{ Push.TagGroupEditor.REMOVE, (group, t) => UrbanAirship.UAirship.Push.RemoveTags(t.ToArray(), group) },
				{ Push.TagGroupEditor.SET, (group, t) => UrbanAirship.UAirship.Push.SetTags(t.ToArray(), group) }
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
#endif