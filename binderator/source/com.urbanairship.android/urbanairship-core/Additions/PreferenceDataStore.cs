/*
 Copyright Airship and Contributors
*/

using System;
using System.Collections.Generic;

namespace UrbanAirship
{
	public partial class PreferenceDataStore
	{
		private Dictionary<Action<String>, PreferenceChangeListener> eventHandlers = new Dictionary<Action<String>, PreferenceChangeListener>();
		public event Action<String> OnPreferenceChange
		{
			add
			{
				PreferenceChangeListener listener = new PreferenceChangeListener(value);
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

		internal class PreferenceChangeListener : Java.Lang.Object, IPreferenceChangeListener
		{
			Action<string> preferenceChangeListener;

			public PreferenceChangeListener(Action<string> preferenceChangeListener)
			{
				this.preferenceChangeListener = preferenceChangeListener;
			}

			public void OnPreferenceChange(string key)
			{
				if (preferenceChangeListener != null)
				{
					preferenceChangeListener.Invoke(key);
				}
			}

		}
	}
}
