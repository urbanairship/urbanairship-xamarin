/*
 Copyright 2017 Urban Airship and Contributors
*/

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

            UrbanAirshipListener airshipListener = new UrbanAirshipListener();
            airship.PushManager.SetNotificationListener(airshipListener);
            airship.PushManager.AddPushListener(airshipListener);
            airship.PushManager.AddRegistrationListener(airshipListener);
        }

        public override AirshipConfigOptions CreateAirshipConfigOptions(Context context)
        {
            /* Optionally set your config at runtime 
			AirshipConfigOptions options = new AirshipConfigOptions.Builder()
				   .SetInProduction(!BuildConfig.DEBUG)
				   .SetDevelopmentAppKey("Your Development App Key")
				   .SetDevelopmentAppSecret("Your Development App Secret")
				   .SetProductionAppKey("Your Production App Key")
				   .SetProductionAppSecret("Your Production App Secret")
				   .SetNotificationAccentColor(ContextCompat.getColor(this, R.color.color_accent))
				   .SetNotificationIcon(R.drawable.ic_notification)
				   .Build();

			return options;
			*/

            return base.CreateAirshipConfigOptions(context);
        }
    }
}
