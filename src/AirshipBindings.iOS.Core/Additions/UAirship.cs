/*
 Copyright Airship and Contributors
*/

using System;
using System.Reflection;
using Foundation;
using ObjCRuntime;

namespace UrbanAirship
{
    public partial class UAirship
    {
        static UAirship()
        {
            NSNotificationCenter.DefaultCenter.AddObserver(new NSString("com.urbanairship.airship_ready"), (notification) =>
            {
                // Register Airship Xamarin component
                Version version = Assembly.GetExecutingAssembly().GetName().Version;
                UAirship.Analytics().RegisterSDKExtension(UASDKExtension.Xamarin, version.ToString());
            });

        }
    }

    // SDK-private enum and method declarations
    [Native]
    internal enum UASDKExtension : ulong
    {
        Cordova = 0,
        Xamarin = 1,
        Unity = 2,
        Flutter = 3,
        ReactNative = 4
    }

    public unsafe partial class UAAnalytics : UAComponent
    {
        [Export("registerSDKExtension:version:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        internal virtual void RegisterSDKExtension(UASDKExtension extension, string version)
        {
            if (version == null)
                throw new ArgumentNullException("version");
            var nsversion = NSString.CreateNative(version);

            if (IsDirectBinding)
            {
                if (IntPtr.Size == 8)
                {
                    global::ApiDefinitions.Messaging.void_objc_msgSend_UInt64_IntPtr(this.Handle, Selector.GetHandle("registerSDKExtension:version:"), (UInt64)extension, nsversion);
                }
                else
                {
                    global::ApiDefinitions.Messaging.void_objc_msgSend_UInt32_IntPtr(this.Handle, Selector.GetHandle("registerSDKExtension:version:"), (UInt32)extension, nsversion);
                }
            }
            else
            {
                if (IntPtr.Size == 8)
                {
                    global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt64_IntPtr(this.SuperHandle, Selector.GetHandle("registerSDKExtension:version:"), (UInt64)extension, nsversion);
                }
                else
                {
                    global::ApiDefinitions.Messaging.void_objc_msgSendSuper_UInt32_IntPtr(this.SuperHandle, Selector.GetHandle("registerSDKExtension:version:"), (UInt32)extension, nsversion);
                }
            }
            NSString.ReleaseNative(nsversion);
        }
    }
}