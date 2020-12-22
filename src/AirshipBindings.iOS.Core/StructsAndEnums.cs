/*
 Copyright Airship and Contributors
*/
using ObjCRuntime;
using System;
using UIKit;

namespace UrbanAirship {

    [Native]
    public enum UASituation : long
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
    public enum UAAddCustomEventActionErrorCode : long
    {
        InvalidEventName = 0
    }

    [Native]
    public enum UACloudSite : ulong
    {
        US = 0,
        EU = 1
    }

    [Native]
    public enum UALogLevel : long
    {
        Undefined = -1,
        None = 0,
        Error = 1,
        Warn = 2,
        Info = 3,
        Debug = 4,
        Trace = 5
    }

    [Native]
    public enum UAJSONMatcherErrorCode : long
    {
        InvalidJSON = 0
    }

    [Native]
    public enum UAJSONPredicateErrorCode : long
    {
        InvalidJSON = 0
    }

    [Native]
    public enum UAJSONValueMatcherErrorCode : long
    {
        InvalidJSON = 0
    }

    [Native]
    public enum UANotificationActionOptions : ulong
    {
        None = 0,
        AuthenticationRequired = (1 << 0),
        Destructive = (1 << 1),
        Foreground = (1 << 2)
    }

    [Native]
    public enum UANotificationCategoryOptions : ulong
    {
        None = 0,
        CustomDismissAction = (1 << 0),
        AllowInCarPlay = (1 << 1),
        AllowAnnouncement = (1 << 4)
    }

    [Native]
    public enum UAOpenExternalURLActionErrorCode : long
    {
        UrlFailedToOpen = 0
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
        Announcement = (1 << 7)
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
    public enum UABoundaryEvent : long
    {
        Enter = 1,
        Exit = 2
    }

    [Native]
    public enum UAURLAllowListScope : ulong
    {
        JavaScriptInterface = 1 << 0,
        OpenURL = 1 << 1,
        All = JavaScriptInterface | OpenURL
    }
}
