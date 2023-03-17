/*
 Copyright Airship and Contributors
*/

using System;
using Xamarin.Forms;

using SampleApp.iOS;

using UrbanAirship;

[assembly: Dependency(typeof(BackgroundDependency_iOS))]
namespace SampleApp.iOS
{
	public class BackgroundDependency_iOS: IBackgroundDependency
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

