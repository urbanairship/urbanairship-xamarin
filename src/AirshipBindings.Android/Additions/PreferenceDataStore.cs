using System;

namespace UrbanAirship
{
	public partial class PreferenceDataStore
	{
		public void AddListener(Action<string> listener)
		{
			AddListener(new PreferenceChangeListener(listener));
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
