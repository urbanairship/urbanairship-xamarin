/*
 Copyright 2018 Urban Airship and Contributors
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
    public enum UALocationProviderPermissionStatus : ulong
    {
        Disabled = 0,
        Unprompted = 1,
        NotAllowed = 2,
        ForegroundAllowed = 3,
        AlwaysAllowed = 4
    }

    [Native]
    public enum UANotificationActionOptions : ulong
    {
        AuthenticationRequired = (1 << 0),
        Destructive = (1 << 1),
        Foreground = (1 << 2)
    }

    [Native]
    public enum UANotificationCategoryOptions : ulong
    {
        CustomDismissAction = (1 << 0),
        AllowInCarPlay = (2 << 0)
    }

    [Native]
    public enum UAOpenExternalURLActionErrorCode : long
    {
        UrlFailedToOpen = 0
    }

    [Native]
    public enum UANotificationOptions : ulong
    {
        Badge = (1 << 0),
        Sound = (1 << 1),
        Alert = (1 << 2),
        CarPlay = (1 << 3),
        CriticalAlert = (1 << 4),
        ProvidesAppNotificationSettings = (1 << 5),
        Provisional = (1 << 6)
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
        CriticalAlert = (1 << 6)
    }

    [Native]
    public enum UAAuthorizationStatus : long
    {
        NotDetermined = 0,
        Denied = 1,
        Authorized = 2,
        Provisional = 3
    }

    [Native]
    public enum UABoundaryEvent : long
    {
        Enter = 1,
        Exit = 2
    }

    [Native]
    public enum UAScheduleDelayErrorCode : long
    {
        InvalidJSON = 0
    }

    [Native]
    public enum UAScheduleDelayAppState : long
    {
        Any = 0,
        Foreground = 1,
        Background = 2
    }

    [Native]
    public enum UAScheduleTriggerErrorCode : long
    {
        InvalidJSON = 0
    }

    [Native]
    public enum UAScheduleTriggerType : long
    {
        AppForeground = 0,
        AppBackground = 1,
        RegionEnter = 2,
        RegionExit = 3,
        CustomEventCount = 4,
        CustomEventValue = 5,
        Screen = 6,
        AppInit = 7,
        ActiveSession = 8,
        Version = 9
    }

    [Native]
    public enum UAWhitelistScope : ulong
    {
        JavaScriptInterface = 1 << 0,
        OpenURL = 1 << 1,
        All = JavaScriptInterface | OpenURL
    }

    [Native]
    public enum UAInAppMessagePrepareResult : ulong
    {
        Success = 0,
        Retry = 1,
        Cancel = 2,
        Invalidate = 3
    }

    [Native]
    public enum UAInAppMessageAudienceMissBehaviorType : long
    {
        Cancel = 0,
        Skip = 1,
        Penalize = 2
    }

    [Native]
    public enum UAInAppMessageBannerPlacementType : long
    {
        Top = 0,
        Bottom = 1
    }

    [Native]
    public enum UAInAppMessageBannerContentLayoutType : long
    {
        MediaLeft = 0,
        MediaRight = 1
    }

    [Native]
    public enum UAInAppMessageButtonInfoBehaviorType : long
    {
        Dismiss = 0,
        Cancel = 1
    }

    [Native]
    public enum UAInAppMessageDisplayType : long
    {
        Banner = 0,
        FullScreen = 1,
        Modal = 2,
        HTML = 3,
        Custom = 4
    }

    [Native]
    public enum UAInAppMessageButtonLayoutType : long
    {
        Stacked = 0,
        Separate = 1,
        Joined = 2
    }

    [Native]
    public enum UAInAppMessageFullScreenContentLayoutType : long
    {
        HeaderMediaBody = 0,
        MediaHeaderBody = 1,
        HeaderBodyMedia = 2
    }

    [Native]
    public enum UAInAppMessageMediaInfoType : long
    {
        Image = 0,
        Video = 1,
        YouTube = 2
    }

    [Native]
    public enum UAInAppMessageModalContentLayoutType : long
    {
        HeaderMediaBody = 0,
        MediaHeaderBody = 1,
        HeaderBodyMedia = 2
    }

    [Native]
    public enum UAInAppMessageResolutionType : long
    {
        ButtonClick = 0,
        MessageClick = 1,
        UserDismissed = 2,
        TimedOut = 3
    }

    [Native]
    public enum UAInAppMessageTextInfoStyleType : ulong
    {
        Normal = 0,
        Bold = 1 << 0,
        Italic = 1 << 1,
        Underline = 1 << 2
    }

    [Native]
    public enum UAInAppMessageTextInfoAlignmentType : ulong
    {
        None = 0,
        Left = 1,
        Center = 2,
        Right = 3
    }

    [Native]
    public enum UALegacyInAppMessagePosition : long
    {
        Top = 0,
        Bottom = 1
    }

    [Native]
    public enum UALegacyInAppMessageDisplayType : long
    {
        Banner = 0
    }

    [Native]
    public enum UAOverlayInboxMessageActionErrorCode : long
    {
        MessageUnavailable = 0
    }


}
