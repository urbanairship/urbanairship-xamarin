/*
 Copyright Airship and Contributors
*/
using ObjCRuntime;
using System;
using UIKit;

namespace UrbanAirship {

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


}
