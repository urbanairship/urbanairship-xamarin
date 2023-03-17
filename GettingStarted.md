# Airship SDK

Here are some examples to help get you started integrating the Airship SDK with your
Xamarin application.

### iOS Setup

1. In the Application's delegate, call `TakeOff` in `FinishedLaunching`:
   ```
   [Register ("AppDelegate")]
       public class AppDelegate : UIApplicationDelegate
       {
           public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
           {
               UAirship.TakeOff ();
               // Configure airship here
               return true;
           }
       }
    ```

    Note that if the TakeOff process fails due to improper or missing configuration, the shared
    UAirship instance will be null. The Airship SDK always logs implementation errors at
    high visibility.

2. Provide `AirshipConfig.plist` file with the application's configuration:
    ```
        <?xml version="1.0" encoding="UTF-8"?>
        <!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
        <plist version="1.0">
        <dict>
          <key>inProduction</key>
          <false/>
          <key>developmentAppKey</key>
          <string>Your Development App Key</string>
          <key>developmentAppSecret</key>
          <string>Your Development App Secret</string>
          <key>productionAppKey</key>
          <string>Your Production App Key</string>
          <key>productionAppSecret</key>
          <string>Your Production App Secret</string>
        </dict>
        </plist>
    ```

    In order for this file to be visible to the SDK during TakeOff, be sure that its BuildAction
    is set to "Bundle Resource" in your app project.

3. Enable user notifications:
    ```
        UAirship.Push().UserPushNotificationsEnabled = true;
    ```
4. Because of some [Xamarin limitations](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/xaml/hot-reload#known-limitations) related to XAML Hot Reload and Linker, you need to set some settings in the iOS Build from the project options: 

    - Enable the Mono interpreter when debugging on a physical device. 
    - Set the linker behavior to: "Don't Link".

### Android Setup

1. Create a class that extends Application and call `TakeOff` in `OnCreate`:
    ```
    [Application]
    public class MainApp : Application
    {
        public MainApp(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

           // Call takeOff
            UAirship.TakeOff(this, (UAirship airship) => {
                // Configure airship here
            });
        }
    }
    ```

2. Provide `airshipconfig.properties` file in the Assets directory with the application's configuration:
    ```
        developmentAppKey = Your Development App Key
        developmentAppSecret = Your Development App Secret

        productionAppKey = Your Production App Key
        productionAppSecret = Your Production Secret

        # Toggles between the development and production app credentials
        # Before submitting your application to an app store set to true
        inProduction = false

        # LogLevel is "VERBOSE", "DEBUG", "INFO", "WARN", "ERROR" or "ASSERT"
        developmentLogLevel = DEBUG
        productionLogLevel = ERROR
    ```

3. Enable user notifications:
    ```
        UAirship.Shared().PushManager.UserNotificationsEnabled = true;
    ```

### Platform Documentation
- iOS: http://docs.airship.com/platform/ios.html
- Android: http://docs.airship.com/platform/android.html
- Topic guides: http://docs.airship.com/topic-guides/index.html

### Support
- https://support.airship.com
