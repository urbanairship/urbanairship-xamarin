/*
 Copyright Airship and Contributors
*/

using System;
using ObjCRuntime;

namespace UrbanAirship
{

	[Native]
	public enum UAApplicationState : ulong
	{
		Active = 0,
		Inactive = 1,
		Background = 2
	}

	[Native]
	public enum UAChannelScope : ulong
	{
		App = 0,
		Web = 1,
		Email = 2,
		Sms = 3
	}

	[Native]
	public enum UAChannelType : ulong
	{
		Email = 0,
		Sms = 1,
		Open = 2
	}

	[Native]
	public enum UACloudSite : ulong
	{
		Us = 0,
		Eu = 1
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
		[Obsolete("Use Verbose instead. Trace will be removed in a future release.")]
		Trace = 5,
		Verbose = 5
	}

    [Native]
    public enum UASDKExtension : ulong
    {
        Cordova = 0,
        Xamarin = 1,
        Unity = 2,
        Flutter = 3,
        ReactNative = 4,
        Titanium = 5
    }

	[Native]
	public enum UABoundaryEvent : ulong
	{
		Enter = 1,
		Exit = 2
	}

    [Native]
    public enum URLType : ulong
    {
		Web = 0,
		Video = 1,
		Image = 2
	}

    [Native]
    public enum UrlTypes : ulong
    {
		Image = 0,
		Video = 1,
		Web = 2
	}

    [Native]
    public enum UAPermissionStatus : ulong
    {
		notDetermined = 0,
		granted = 1,
		denied = 2
	}

    [Native]
    public enum UAPermission : ulong
    {
        displayNotifications = 0,
        location = 1
	}
}
