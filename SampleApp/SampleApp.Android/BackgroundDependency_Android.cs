/*
 Copyright Airship and Contributors
*/

using System;
using Xamarin.Forms;
using Android.Runtime;

using SampleApp.Droid;

using UrbanAirship.PreferenceCenter;

[assembly: Dependency(typeof(BackgroundDependency_Android))]
namespace SampleApp.Droid
{
    [Preserve(AllMembers = true)]
    public class BackgroundDependency_Android : Java.Lang.Object, IBackgroundDependency
    {
        public void OpenAirshipPreferenceCenter()
        {
            PreferenceCenter.Shared().Open("neat");
        }
    }
}
