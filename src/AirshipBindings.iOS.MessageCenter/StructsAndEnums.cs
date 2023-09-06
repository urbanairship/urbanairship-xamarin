/*
 Copyright Airship and Contributors
*/
using ObjCRuntime;
using System;
using UIKit;

namespace UrbanAirship {

    [Native]
    public enum UAMessageCenterMessageLoadErrorCode : long
    {
        ListUnavailable = 0,
        FailureStatus = 1,
        MessageExpired = 2
    }

    [Native]
    public enum UANavigationBarStyle : ulong
    {
        Default = 0,
        Black = 1
    }
}
