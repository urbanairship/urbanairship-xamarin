/*
 Copyright Airship and Contributors
*/

using System.Collections.Generic;

namespace UrbanAirship.NETStandard.Analytics
{
    /// <summary>
    /// A DeepLink Event model object.
    /// </summary>
    public class DeepLinkEvent
    {
        private const string EventDeepLink = "airship.deep_link";
        private const string DeepLinkKey = "deepLink";

        /// <summary>
        /// Initializes a new instance of the <see cref="DeepLinkEvent"/> class.
        /// </summary>
        public DeepLinkEvent(string url)
        {
            EventData = new Dictionary<string, string>();
            EventData.Add(DeepLinkKey, url);
            EventType = EventDeepLink;
        }

        /// <summary>
        /// Gets or sets the type of the event.
        /// </summary>
        /// <value>The type of the event.</value>
        public string EventType { get; set; }

        /// <summary>
        /// Gets or sets the data of the event.
        /// </summary>
        /// <value>The data of the event.</value>
        public Dictionary<string, string> EventData { get; set; }
    }
}
