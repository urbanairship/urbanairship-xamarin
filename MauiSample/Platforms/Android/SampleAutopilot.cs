using System;
using AirshipDotNet;
using Android.Content;
using Android.Runtime;
using Android.Util;
using AndroidX.Core.Content;
using MauiSample;
using UrbanAirship;

namespace MauiSample
{
    [Register("sample.SampleAutopilot")]
    public class SampleAutopilot : Autopilot
    {
        public override void OnAirshipReady(UAirship airship)
        {
            AirshipListener airshipListener = new();
            airship.PushManager.NotificationListener = airshipListener;
            airship.PushManager.AddPushListener(airshipListener);
            airship.PushManager.AddPushTokenListener(airshipListener);
            airship.Channel.AddChannelListener(airshipListener);
        }

        public override AirshipConfigOptions CreateAirshipConfigOptions(Context context)
        {
            /* Optionally set your config at runtime.
            AirshipConfigOptions options = new AirshipConfigOptions.Builder()
                 .SetInProduction(!BuildConfig.DEBUG)
                 .SetDevelopmentAppKey("Your Development App Key")
                 .SetDevelopmentAppSecret("Your Development App Secret")
                 .SetProductionAppKey("Your Production App Key")
                 .SetProductionAppSecret("Your Production App Secret")
                 .SetDevelopmentLogLevel(2)
                 .SetNotificationAccentColor(ContextCompat.getColor(this, MauiSample.Resource.Color.colorAccent))
                 .SetNotificationIcon(MauiSample.Resource.Drawable.ic_notification)
                 .Build();

            return options;
            */

            // Load config from airshipconfig.properties file.
            return base.CreateAirshipConfigOptions(context);
        }
    }
}

