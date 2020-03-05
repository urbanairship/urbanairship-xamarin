/*
 Copyright Airship and Contributors
*/

using Android.App;
using Android.OS;
using Android.Runtime;

using AndroidX.AppCompat.App;
using AndroidX.Preference;

namespace Sample
{
    [Register("sample.SettingsActivity")]
    [Activity(Label = "@string/settings", ParentActivity = typeof(MainActivity))]
    [IntentFilter(new string[] { "android.intent.action.MAIN" },
                  Categories = new string[] { "android.intent.category.NOTIFICATION_PREFERENCES" })]
    public class SettingsActivity : AppCompatActivity
    {
        protected override void OnCreate(Android.OS.Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            if (SupportActionBar != null)
            {
                SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            }

            if (savedInstanceState == null)
            {
                SupportFragmentManager.BeginTransaction()
                               .Replace(Android.Resource.Id.Content, new SettingsFragment())
                               .Commit();
            }
        }
    }

    public class SettingsFragment : PreferenceFragmentCompat
    {
        public override void OnCreatePreferences(Bundle bundle, string s)
        {
            AddPreferencesFromResource(Resource.Xml.preferences);
        }

        public override void OnDisplayPreferenceDialog(AndroidX.Preference.Preference preference)
        {
            PreferenceDialogFragmentCompat dialogFragment = null;

            if ("tags" == preference.Key)
            {
                dialogFragment = new Sample.Preference.AddTagsPreferenceDialogFragmentCompat(preference.Key);
            }

            if (dialogFragment == null)
            {
                base.OnDisplayPreferenceDialog(preference);
                return;
            }

            dialogFragment.SetTargetFragment(this, 0);
            dialogFragment.Show(this.FragmentManager,
                    "androidx.preference" +
                    ".PreferenceFragment.DIALOG");
        }
    }
}
