/*
 Copyright Airship and Contributors
*/

using System;
using Xamarin.Forms;

using SampleApp.iOS;

using UrbanAirship;
using Foundation;

[assembly: Dependency(typeof(BackgroundDependency_iOS))]
namespace SampleApp.iOS
{
    [Preserve(AllMembers = true)]
    public class BackgroundDependency_iOS: NSObject, IBackgroundDependency
    {
		public BackgroundDependency_iOS()
		{
		}

        public void OpenAirshipPreferenceCenter()
        {
            UAPreferenceCenter.Shared.OpenPreferenceCenter("neat");
        }

    }
}

