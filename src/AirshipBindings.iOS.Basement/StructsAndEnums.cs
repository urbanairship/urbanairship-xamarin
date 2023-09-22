/*
 Copyright Airship and Contributors
*/
using ObjCRuntime;
using System;
using UIKit;

namespace UrbanAirship {

    [Native]
    public enum UAActionSituation : long
    {
        ManualInvocation = 0,
        LaunchedFromPush = 1,
        ForegroundPush = 2,
        BackgroundPush = 3,
        WebViewInvocation = 4,
        ForegroundInteractiveButton = 5,
        BackgroundInteractiveButton = 6,
        Automation = 7
    }

    [Native]
    public enum UAActionFetchResult : ulong
    {
        NoData = UIBackgroundFetchResult.NoData,
        NewData = UIBackgroundFetchResult.NewData,
        Failed = UIBackgroundFetchResult.Failed
    }

    [Native]
    public enum UAActionStatus : long
    {
        Completed = 0,
        ArgumentsRejected = 1,
        ActionNotFound = 2,
        Error = 3
    }

    [Native]
    public enum UAEventPriority : ulong
    {
        Low,
        Normal,
        High
    }

    [Native]
    public enum UAFeatures : ulong
    {
        None = 0,
        InAppAutomation = (1 << 0),
        MessageCenter = (1 << 1),
        Push = (1 << 2),
        Chat = (1 << 3),
        Analytics = (1 << 4),
        TagsAndAttributes = (1 << 5),
        Contacts = (1 << 6),
        Location = (1 << 7),
        All = (InAppAutomation | MessageCenter | Push | Chat | Analytics | TagsAndAttributes | Contacts | Location)
    }

    [Native]
    public enum UANotificationOptions : ulong
    {
        None = 0,
        Badge = (1 << 0),
        Sound = (1 << 1),
        Alert = (1 << 2),
        CarPlay = (1 << 3),
        CriticalAlert = (1 << 4),
        ProvidesAppNotificationSettings = (1 << 5),
        Provisional = (1 << 6),
        Announcement = (1 << 7)
    }
    
    [Native]
    public enum UAAuthorizedNotificationSettings : ulong
    {
        None = 0,
        Badge = (1 << 0),
        Sound = (1 << 1),
        Alert = (1 << 2),
        CarPlay = (1 << 3),
        LockScreen = (1 << 4),
        NotificationCenter = (1 << 5),
        CriticalAlert = (1 << 6),
        Announcement = (1 << 7),
        ScheduledDelivery = (1 << 8),
        TimeSensitive = (1 << 9)
    }

    [Native]
    public enum UAAuthorizationStatus : long
    {
        NotDetermined = 0,
        Denied = 1,
        Authorized = 2,
        Provisional = 3,
        Ephemeral = 4
    }

    [Native]
    public enum UAURLAllowListScope : ulong
    {
        JavaScriptInterface = 1 << 0,
        OpenURL = 1 << 1,
        All = JavaScriptInterface | OpenURL
    }
}
