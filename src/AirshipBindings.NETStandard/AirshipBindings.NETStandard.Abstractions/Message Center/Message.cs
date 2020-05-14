/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections;

namespace UrbanAirship.NETStandard.MessageCenter
{
    public partial class Message
    {
        public string messageId
        {
            get;
        }

        public string title
        {
            get;
        }
       
        public DateTime? sentDate
        {
            get;
        }

        public DateTime? expirationDate
        {
            get;
        }

        public string iconUrl
        {
            get;
        }

        public Hashtable extras
        {
            get;
        }

        public Message(string messageId, string title, DateTime? sentDate, DateTime? expirationDate, string iconUrl, Hashtable extras)
        {
            this.messageId = messageId;
            this.title = title;
            this.sentDate = sentDate;
            this.expirationDate = expirationDate;
            this.iconUrl = iconUrl;
            this.extras = extras;
        }

    }
}
