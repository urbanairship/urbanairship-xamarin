using Foundation;
using ObjCRuntime;
using UIKit;
using UrbanAirship;

namespace MauiSample;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        // Set log level for debugging config loading (optional)
        // It will be set to the value in the loaded config upon takeOff
        UAirship.LogLevel = UALogLevel.Trace;

        // Populate AirshipConfig.plist with your app's info from https://go.urbanairship.com
        // or set runtime properties here.
        UAConfig config = UAConfig.DefaultConfig();

        if (!config.Validate())
        {
            throw new RuntimeException("The AirshipConfig.plist must be a part of the app bundle and " +
                "include a valid appkey and secret for the selected production level.");
        }

        WarnIfSimulator();

        // Bootstrap the Airship SDK
        UAirship.TakeOff(config, launchOptions);

        //UAMessageCenter.Shared.DisplayMessage("");

        Console.WriteLine("AirshipConfig: {0}", config);

        UAirship.Push.ResetBadge();

        return base.FinishedLaunching(application, launchOptions);
    }

    private void WarnIfSimulator()
    {
        if (Runtime.Arch != Arch.SIMULATOR)
        {
            return;
        }

        Console.WriteLine("WARNING: You will not be able to receive push notifications in the simulator.");
    }
}

