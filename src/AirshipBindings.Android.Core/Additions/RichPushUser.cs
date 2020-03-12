/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;

namespace UrbanAirship.RichPush
{
	public partial class RichPushUser
	{
		private Dictionary<Action<bool>, Listener> eventHandlers = new Dictionary<Action<bool>, Listener>();
		public event Action<bool> OnUserUpdated
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

		internal class Listener : Java.Lang.Object, IListener
		{
			Action<bool> listener;

			public Listener(Action<bool> listener)
			{
				this.listener = listener;
			}

			public void OnUserUpdated(bool success)
			{
				if (listener != null)
				{
					listener.Invoke(success);
				}
			}
		}

	}
}
