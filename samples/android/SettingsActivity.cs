using System;

using Android.App;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Support.V7.App;

namespace Sample
{
	[Register("sample.SettingsActivity")]
	[Activity(Label="@string/settings", ParentActivity=typeof(MainActivity))]
	[IntentFilter(new string[] { "android.intent.action.MAIN" }, 
	              Categories=new string[] { "android.intent.category.NOTIFICATION_PREFERENCES" })]
	public class SettingsActivity : AppCompatActivity
	{
		protected override void OnCreate(Android.OS.Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Todo works??
			if (SupportActionBar != null)
			{
				SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			}

			if (savedInstanceState == null)
			{
				FragmentManager.BeginTransaction()
				               .Replace(Android.Resource.Id.Content, new SettingsFragment())
							   .Commit();
			}
		}
	}

	public class SettingsFragment : PreferenceFragment
	{
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			AddPreferencesFromResource(Resource.Xml.preferences);
		}
	}
}
