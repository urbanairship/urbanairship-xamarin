/*
 Copyright Airship and Contributors
*/

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
	public enum UAAttributeUpdateType : ulong
	{
		Remove = 0,
		Set = 1
	}

	[Native]
	public enum UACloudSite : ulong
	{
		Us = 0,
		Eu = 1
	}

	[Native]
	public enum UADispatcherTimeBase : ulong
	{
		Wall = 0,
		System = 1
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
	public enum UATagGroupUpdateType : ulong
	{
		Add = 0,
		Remove = 1,
		Set = 2
	}

	[Native]
	public enum UABoundaryEvent : ulong
	{
		Enter = 1,
		Exit = 2
	}

	[Native]
	public enum UATaskConflictPolicy : ulong
	{
		Keep = 0,
		Replace = 1,
		Append = 2
	}
}
