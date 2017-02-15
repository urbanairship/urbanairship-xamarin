using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Android.App;

[assembly: Application(AllowBackup = true,
                       Icon = "@mipmap/ic_launcher",
                       Label = "@string/app_name",
                       SupportsRtl = true,
                       Theme = "@style/AppTheme")]

[assembly: MetaData("com.urbanairship.autopilot", Value = "sample.SampleAutopilot")]
[assembly: UsesPermission("android.permission.ACCESS_FINE_LOCATION")]