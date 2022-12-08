using Android.App;
using Android.Runtime;
using UrbanAirship;

namespace MauiSampleApp;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override void OnCreate()
    {
        base.OnCreate();

        UAirship.TakeOff(
           this,
           options: new AirshipConfigOptions.Builder()
               .SetAppKey("Your Development App Key")
               .SetAppSecret("Your Development App Secret")
               .SetInProduction(false)
               .SetLogLevel(2)
               .Build());
    }
}

