using System;
using System.Collections.Generic;

namespace UrbanAirship.Portable
{
	public class StubbedPlugin : IUAirshipPlugin
	{
		public bool UserNotificationsEnabled { get; set; }
		public IEnumerable<string> Tags { get { return null; } }
		public string Alias { get; set; }
		public string ChannelId { get { return null; } }
		public bool LocationEnabled { get; set; }
		public bool BackgroundLocationAllowed { get; set; }
		public string NamedUser { get; set; }
		public void EditDeviceTags(List<string> addTags, List<string> removeTags) { }
		public void AddCustomEvent(Portable.Analytics.CustomEvent customEvent) { }
		public void AssociateIdentifier(string key, string identifier) { }
		public void DisplayMessageCenter() { }
		public int MessageCenterUnreadCount { get; private set; }
		public int MessageCenterCount { get; private set; }
		public void EditNamedUserTagGroups(Dictionary<string, Dictionary<string, List<string>>> payload) { }
		public void EditChannelTagGroups(Dictionary<string, Dictionary<string, List<string>>> payload) { }
	}
}
