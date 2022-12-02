/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;

using Android.OS;

namespace UrbanAirship.MessageCenter
{
    public partial class Inbox
	{
		private Dictionary<Action, Listener> eventHandlers = new Dictionary<Action, Listener>();
		public event Action OnInboxUpdated
		{
			add
			{
				Listener listener = new Listener(value);
				AddListener(listener);
				eventHandlers.Add(value, listener);
			}

			remove
			{
				if (eventHandlers.ContainsKey(value))
				{
					RemoveListener(eventHandlers[value]);
					eventHandlers.Remove(value);
				}
			}
		}

		public ICancelable FetchMessages(Action<bool> callback)
		{
			return FetchMessages (new FetchMessagesCallback (callback));
		}

		public ICancelable FetchMessages(Action<bool> callback, Looper looper)
		{
			return FetchMessages (looper, new FetchMessagesCallback (callback));
		}

		public IList<Message> GetMessages(Func<Message, bool> predicate) {
			return GetMessages (new Predicate (predicate));
		}

		internal class Listener : Java.Lang.Object, IInboxListener
		{
			Action listener;

			public Listener(Action listener)
			{
				this.listener = listener;
			}

			public void OnInboxUpdated()
			{
				if (listener != null)
				{
					listener.Invoke();
				}
			}
		}

		internal class FetchMessagesCallback : Java.Lang.Object, IFetchMessagesCallback
		{
			Action<bool> callback;
			public FetchMessagesCallback(Action<bool> callback)
			{
				this.callback = callback;
			}

			public void OnFinished (bool success) {
				if (callback != null)
				{
					callback.Invoke (success);
				}
			}
		}

		public class Predicate : Java.Lang.Object, IPredicate
		{
			Func<Message, bool> predicate;

			public Predicate(Func<Message, bool> predicate)
			{
				this.predicate = predicate;
			}

			public bool Apply (Message message) {
				if (predicate != null)
				{
					return predicate.Invoke (message);
				}
				return true;
			}

            public bool Apply(Java.Lang.Object p0)
            {
                throw new NotImplementedException();
            }
        }
	}
}