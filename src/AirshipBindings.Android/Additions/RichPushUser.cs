using System;
using UrbanAirship;

namespace UrbanAirship.RichPush
{
	public partial class RichPushUser
	{
		public void AddListener(Action<bool> listener)
		{
			AddListener(new Listener(listener));
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
