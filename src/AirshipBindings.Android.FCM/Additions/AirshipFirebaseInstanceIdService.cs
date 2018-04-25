﻿/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using Android.Content;
using Android.App;

namespace UrbanAirship.Push.Fcm
{
    [Android.Runtime.Preserve(AllMembers = true)]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" }, Priority = -1)]
    public partial class AirshipFirebaseInstanceIdService
    {
    }
}
