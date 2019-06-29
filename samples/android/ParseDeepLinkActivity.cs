/*
 Copyright Airship and Contributors
*/

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;

using UrbanAirship;

namespace Sample
{
	[Register("sample.ParseDeepLinkActivity")]
	[IntentFilter(new string[] { "android.intent.action.VIEW", }, 
	              DataHost = "deeplink",
				  DataScheme = "vnd.urbanairship.sample", 
	              Categories = new string[] { "android.intent.category.DEFAULT", "android.intent.category.BROWSABLE" })]
	[Activity(Theme="@android:style/Theme.NoDisplay")]
	public class ParseDeepLinkActivity : Activity
	{
		const string TAG = "ParseDeepLinkActivity";

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			if (DeepLink == null)
			{
				StartActivity(new Intent(this, typeof(MainActivity)));
				Finish();
				return;
			}

			switch (DeepLink)
			{
				case "/preferences":
					StartActivity(new Intent(this, typeof(SettingsActivity)));
					break;
				case "/home":
					StartActivity(new Intent(this, typeof(MainActivity)));
					break;
				case "/inbox":
					string messageId = GetDeepLinkQueryParameter("message_id");
					if (messageId != null && messageId.Length > 0)
					{
						UAirship.Shared().MessageCenter.ShowMessageCenter(messageId);
					}
					else
					{
						UAirship.Shared().MessageCenter.ShowMessageCenter();
					}
					break;
				default:
					Log.Error(TAG, "Unknown deep link: " + DeepLink + ". Falling back to main activity.");
					StartActivity(new Intent(this, typeof(MainActivity)));
					break;
			}

			Finish();
		}

		private string DeepLink
		{
			get
			{
				if (Intent != null && Intent.Data != null)
				{
					return Intent.Data.Path;
				}

				return null;
			}
		}

		private string GetDeepLinkQueryParameter(string key)
		{
			if (Intent != null && Intent.Data != null)
			{
				return Intent.Data.GetQueryParameter(key);
			}

			return null;
		}
	}
}
