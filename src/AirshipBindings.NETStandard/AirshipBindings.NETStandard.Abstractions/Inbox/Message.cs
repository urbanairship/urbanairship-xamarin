/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections;

namespace UrbanAirship.NETStandard.Inbox
{
    public partial class Message
    {
        private string messageId;
        private string title;
        private long sentDateMS;
        private DateTime sentDate;
        private long expirationDateMS;
        private DateTime expirationDate;
        private string iconUrl;
        private Hashtable extras;

        public Message(string messageId, string title, long sentDateMS, long expirationDateMS, string iconUrl, Hashtable extras)
        {
            this.messageId = messageId;
            this.title = title;
            this.sentDateMS = sentDateMS;
            this.expirationDateMS = expirationDateMS;
            this.iconUrl = iconUrl;
            this.extras = extras;
        }

        public string GetMessageId()
        {
            return messageId;
        }

        public string GetTitle()
        {
            return title;
        }

        public long GetSentDateMS()
        {
            return sentDateMS;
        }

        public DateTime GetSentDate()
        {
            return new DateTime(sentDateMS);
        }

        public long GetExpirationDateMS()
        {
            return expirationDateMS;
        }

        public DateTime GetExpirationDate()
        {
            return new DateTime(expirationDateMS);
        }

        public string GetIconUrl()
        {
            return iconUrl;
        }

        public Hashtable GetExtras()
        {
            return extras;
        }
    }
}
