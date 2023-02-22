﻿using System;
using Xamarin.Forms;

using SampleApp.Droid;

using UrbanAirship.PreferenceCenter;

[assembly: Dependency(typeof(BackgroundDependency_Android))]
namespace SampleApp.Droid
{
    public class BackgroundDependency_Android : Java.Lang.Object, IBackgroundDependency
    {
        public void OpenPreferenceCenter()
        {
            PreferenceCenter.Shared().Open("neat");
        }
    }
}
