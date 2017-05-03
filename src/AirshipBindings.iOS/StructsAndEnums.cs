/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using ObjCRuntime;
using UIKit;

namespace UrbanAirship {

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
	public enum UAActionFetchResult : ulong
	{
		NoData = UIBackgroundFetchResult.NoData,
		NewData = UIBackgroundFetchResult.NewData,
		Failed = UIBackgroundFetchResult.Failed
	}

	[Native]
	public enum UAActionStatus : ulong
	{
		Completed,
		ArgumentsRejected,
		ActionNotFound,
		Error
	}
		
	[Native]
	public enum UASituation : ulong
	{
		ManualInvocation,
		LaunchedFromPush,
		ForegroundPush,
		BackgroundPush,
		WebViewInvocation,
		ForegroundInteractiveButton,
		BackgroundInteractiveButton
	}

	[Native]
	public enum UAActionOperatorErrorCode : ulong
	{
		UAActionOperatorErrorCodeChildActionRejectedArgs
	}

	[Native]
	public enum UAAddCustomEventActionErrorCode : ulong
	{
		UAAddCustomEventActionErrorCodeInvalidEventName
	}

	[Native]
	public enum UAOpenExternalURLActionErrorCode : ulong
	{
		UAOpenExternalURLActionErrorCodeURLFailedToOpen
	}

	[Native]
	public enum UAOverlayInboxMessageActionErrorCode : ulong
	{
		UAOverlayInboxMessageActionErrorCodeMessageUnavailable
	}

	[Native]
	public enum UAScheduleTriggerErrorCode : ulong
	{
		UAScheduleTriggerErrorCodeInvalidJSON
	}

	[Native]
	public enum UAScheduleTriggerType : ulong
	{
		AppForeground,
		AppBackground,
		RegionEnter,
		RegionExit,
		CustomEventCount,
		CustomEventValue,
		Screen,
		AppInit
	}

	[Native]
	public enum UAInAppMessagePosition : ulong
	{
		Top,
		Bottom
	}

	[Native]
	public enum UAInAppMessageDisplayType : ulong
	{
		Unknown,
		Banner
	}

	[Native]
	public enum UABoundaryEvent : ulong
	{
		Enter = 1,
		Exit = 2
	}

	[Native]
	public enum UANotificationOptions : ulong
	{
		Badge = (1 << 0),
		Sound = (1 << 1),
		Alert = (1 << 2),
		CarPlay = (1 << 3)
	}

   [Native]
   public enum UANotificationCategoryOptions : ulong
   {
      None = (0),
      CustomDismissAction = (1 << 0),
      AllowInCarPlay = (2 << 0)
   }

   [Native]
   public enum UANotificationActionOptions : ulong
   {
      AuthenticationRequired = (1 << 0),
      Destructive = (1 << 1),
      Foreground = (1 << 2)
   }

   [Native]
   public enum UAScheduleDelayErrorCode : ulong
   {
 	  UAScheduleDelayErrorCodeInvalidJSON
   }

   [Native]
   public enum UAScheduleDelayAppState : ulong
   {
 	  Any,
 	  Foreground,
 	  Background
   }
}