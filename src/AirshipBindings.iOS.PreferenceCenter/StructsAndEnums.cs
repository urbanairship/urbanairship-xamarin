/*
 Copyright Airship and Contributors
*/

using ObjCRuntime;

namespace UrbanAirship {

	[Native]
	public enum UAPreferenceConditionType : ulong
	{
		UAPreferenceConditionTypeNotificationOptIn = 0
	}

	[Native]
	public enum UAPreferenceItemType : ulong
	{
		ChannelSubscription = 0,
		ContactSubscription = 1,
		ContactSubscriptionGroup = 2,
		Alert = 3
	}

	[Native]
	public enum UANotificationOptInConditionStatus : ulong
	{
		In = 0,
		Out = 1
	}

	[Native]
	public enum UAPreferenceSectionType : ulong
	{
		Common = 0,
		LabeledSectionBreak = 1
	}
}
