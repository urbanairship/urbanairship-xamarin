/*
 Copyright Airship and Contributors
*/

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Android.App;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SampleApp.Android")]
[assembly: AssemblyDescription("Sample Xamarin application")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Airship")]
[assembly: AssemblyProduct("SampleApp.Android")]
[assembly: AssemblyCopyright("Copyright Airship and Contributors")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

[assembly: Application(AllowBackup = true,
                        Icon = "@mipmap/icon",
                        Label = "@string/app_name",
                        SupportsRtl = true,
                        Theme = "@style/AppTheme")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Add some common permissions, these can be removed if not needed
[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]
[assembly: MetaData("com.urbanairship.autopilot", Value = "sample.SampleAutopilot")]

