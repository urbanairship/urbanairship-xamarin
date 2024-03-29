﻿/*
 Copyright Airship and Contributors
*/

using System;
using AirshipBindings.NETStandard.Abstractions;
using Xamarin.Forms;

namespace UrbanAirship.NETStandard.MessageCenter
{
    /// <summary>
    /// ContentPage used for displaying Message Center Messages.
    /// </summary>
    [Preserve(AllMembers = true)]
    public partial class MessagePage : ContentPage
    {
        private string messageId;

        public static readonly BindableProperty MessageIdProperty = BindableProperty.Create(
            propertyName: "MessageId",
            returnType: typeof(string),
            declaringType: typeof(MessagePage),
            defaultValue: null,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: null);

        /// <summary>
        /// Gets and sets the message ID.
        /// </summary>
        /// <value>The message ID.</value>
        public string MessageId
        {
            get { return (string)GetValue(MessageIdProperty); }
            set { SetValue(MessageIdProperty, value); }
        }

        /// <summary>
        /// Event handler invoked when the message starts loading.
        /// </summary>
        public event EventHandler<MessageLoadStartedEventArgs> LoadStarted;

        /// <summary>
        /// Event handler invoked when the message has loaded.
        /// </summary>
        public event EventHandler<MessageLoadedEventArgs> Loaded;

        /// <summary>
        /// Event handler invoked when the message load fails.
        /// </summary>
        public event EventHandler<MessageLoadFailedEventArgs> LoadFailed;

        /// <summary>
        /// Event handler invoked when the message is closed.
        /// </summary>
        public event EventHandler<MessageClosedEventArgs> Closed;

        /// <summary>
        /// MessagePage constructor.
        /// </summary>
        public MessagePage() { }

        //@cond IGNORE
        public void OnRendererLoadStarted(string messageId)
        {
            LoadStarted?.Invoke(this, new MessageLoadStartedEventArgs(messageId));
        }

        public void OnRendererLoaded(string messageId)
        {
            Loaded?.Invoke(this, new MessageLoadedEventArgs(messageId));
        }

        public void OnRendererLoadFailed(string messageId, bool retriable, MessageFailureStatus status)
        {
            LoadFailed?.Invoke(this, new MessageLoadFailedEventArgs(messageId, retriable, status));
        }

        public void OnRendererClosed(string messageId)
        {
            Closed?.Invoke(this, new MessageClosedEventArgs(messageId));
        }
        //@endcond
    }

    /// <summary>
    /// Event handler invoked when the message is closed.
    /// </summary>
    [Preserve(AllMembers = true)]
    public enum MessageFailureStatus
    {
        /// <summary>
        /// The message is unavailable.
        /// </summary>
        Unavailable,

        /// <summary>
        /// The message list could not be fetched.
        /// </summary>
        FetchFailed,

        /// <summary>
        /// The message failed to load.
        /// </summary>
        LoadFailed
    }

    /// <summary>
    /// Arguments for the LoadStarted event.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class MessageLoadStartedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the message ID.
        /// </summary>
        /// <value>The message ID.</value>
        public string MessageId { get; private set; }

        //@cond IGNORE
        public MessageLoadStartedEventArgs(string messageId)
        {
            MessageId = messageId;
        }
        //@endcond
    }

    /// <summary>
    /// Arguments for the LoadFailed event.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class MessageLoadFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the retriable value.
        /// </summary>
        /// <value>Whether the message load is retriable.</value>
        public bool Retriable { get; private set; }

        /// <summary>
        /// Gets the message failure status.
        /// </summary>
        /// <value>The message failure status</value>
        public MessageFailureStatus FailureStatus { get; private set; }

        /// <summary>
        /// Gets the message ID.
        /// </summary>
        /// <value>The message ID.</value>
        public string MessageId { get; private set; }

        //@cond IGNORE
        public MessageLoadFailedEventArgs(string messageId, bool retriable, MessageFailureStatus status)
        {
            MessageId = messageId;
            Retriable = retriable;
            FailureStatus = status;
        }
        //@endcond
    }

    /// <summary>
    /// Arguments for the Loaded event.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class MessageLoadedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the message ID.
        /// </summary>
        /// <value>The message ID.</value>
        public string MessageId { get; private set; }

        //@cond IGNORE
        public MessageLoadedEventArgs(string messageId)
        {
            MessageId = messageId;
        }
        //@endcond
    }

    /// <summary>
    /// Arguments for the Closed event.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class MessageClosedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the message ID.
        /// </summary>
        /// <value>The message ID.</value>
        public string MessageId { get; private set; }

        //@cond IGNORE
        public MessageClosedEventArgs(string messageId)
        {
            MessageId = messageId;
        }
        //@endcond
    }
}
