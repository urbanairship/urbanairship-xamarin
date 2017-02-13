using System;

using Android.Content;
using Android.Runtime;

using UrbanAirship;

namespace Sample
{
	[Register("sample.SampleAutopilot")]
	public class SampleAutopilot : Autopilot
	{
		private static readonly String NoBackupPreferences = "com.urbanairship.sample.no_backup";
   		private static readonly String FirstRunKey = "first_run";

		public override void OnAirshipReady(UAirship airship)
		{
			ISharedPreferences sharedPreferences = UAirship.ApplicationContext.GetSharedPreferences(NoBackupPreferences, FileCreationMode.Private);
			bool isFirstRun = sharedPreferences.GetBoolean(FirstRunKey, true);

			if (isFirstRun)
			{
				sharedPreferences.Edit().PutBoolean(FirstRunKey, false).Apply();

				airship.PushManager.UserNotificationsEnabled = true;
			}
		}

		public override AirshipConfigOptions CreateAirshipConfigOptions(Context context)
		{
			/* Optionally set your config at runtime 
			AirshipConfigOptions options = new AirshipConfigOptions.Builder()
				   .setInProduction(!BuildConfig.DEBUG)
				   .setDevelopmentAppKey("Your Development App Key")
				   .setDevelopmentAppSecret("Your Development App Secret")
				   .setProductionAppKey("Your Production App Key")
				   .setProductionAppSecret("Your Production App Secret")
				   .setNotificationAccentColor(ContextCompat.getColor(this, R.color.color_accent))
				   .setNotificationIcon(R.drawable.ic_notification)
				   .build();

			return options;
			*/

			return base.CreateAirshipConfigOptions(context);
		}
	}
}
