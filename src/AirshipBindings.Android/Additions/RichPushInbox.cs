/*
 Copyright 2016 Urban Airship and Contributors
*/

using System;
using UrbanAirship;
using Android.OS;
using System.Collections.Generic;

namespace UrbanAirship.RichPush
{
	public partial class RichPushInbox
	{
		public ICancelable FetchMessages(Action<bool> callback)
		{
			return FetchMessages (new FetchMessagesCallback (callback));
		}

		public ICancelable FetchMessages(Action<bool> callback, Looper looper)
		{
			return FetchMessages (new FetchMessagesCallback (callback), looper);
		}

		public IList<RichPushMessage> GetMessages(Func<RichPushMessage, bool> predicate) {
			return GetMessages (new Predicate (predicate));
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
			Func<RichPushMessage, bool> predicate;
			public Predicate(Func<RichPushMessage, bool> predicate)
			{
				this.predicate = predicate;
			}

			public bool Apply (RichPushMessage message) {
				if (predicate != null)
				{
					return predicate.Invoke (message);
				}
				return true;
			}
		}


	}
}

