/*
 Copyright Airship and Contributors
*/

using System;
using System.Reflection;
using Foundation;
using ObjCRuntime;
using UrbanAirship.Attributes;

namespace UrbanAirship
{
    public partial class UAirship
    {
        static UAirship()
        {
            NSNotificationCenter.DefaultCenter.AddObserver(new NSString("com.urbanairship.airship_ready"), (notification) =>
            {
                // Register Airship Xamarin component
                Object[] crossPlatformVersions = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(UACrossPlatformVersionAttribute), false);
                if (crossPlatformVersions.Length >= 1)
                {
                    UACrossPlatformVersionAttribute version = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(UACrossPlatformVersionAttribute), false)[0] as UACrossPlatformVersionAttribute;
                    //TODO(maui): what do with this?
                    //UAirship.Analytics.RegisterSDKExtension(UASDKExtension.Xamarin, version.Version.ToString());
                }                
            });
        }
    }
}