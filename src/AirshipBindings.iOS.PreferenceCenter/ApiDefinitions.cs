/*
 Copyright Airship and Contributors
*/
using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace UrbanAirship
{

	// @protocol UAPreferenceItem
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface UAPreferenceItem
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Abstract]
		[Export("type")]
		string Type { get; }

		// @required @property (readonly, nonatomic) enum UAPreferenceItemType itemType;
		[Abstract]
		[Export("itemType")]
		UAPreferenceItemType ItemType { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Abstract]
		[Export("identifier")]
		string Identifier { get; }

		// @required @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[Abstract]
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }

		// @required @property (readonly, copy, nonatomic) NSArray<id<UAPreferenceConditions>> * _Nullable conditions;
		[Abstract]
		[NullAllowed, Export("conditions", ArgumentSemantic.Copy)]
		IUAPreferenceConditions[] Conditions { get; }
	}

	interface IUAPreferenceItem { };

	// @interface UAPreferenceAlertItem : NSObject <UAPreferenceItem>
	[BaseType(typeof(NSObject))]
	interface UAPreferenceAlertItem : IUAPreferenceItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic) enum UAPreferenceItemType itemType;
		[Export("itemType")]
		UAPreferenceItemType ItemType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }

		// @property (readonly, nonatomic, strong) Button * _Nullable button;
		[NullAllowed, Export("button", ArgumentSemantic.Strong)]
		Button Button { get; }

		// @property (copy, nonatomic) NSArray<id<UAPreferenceConditions>> * _Nullable conditions;
		[NullAllowed, Export("conditions", ArgumentSemantic.Copy)]
		IUAPreferenceConditions[] Conditions { get; set; }
	}

	// @interface Button : NSObject
	[BaseType(typeof(NSObject), Name = "_TtCC23AirshipPreferenceCenter9AlertItem6Button")]
	interface Button
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull text;
		[Export("text")]
		string Text { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable contentDescription;
		[NullAllowed, Export("contentDescription")]
		string ContentDescription { get; }

		// @property (readonly, nonatomic) id _Nullable actions;
		[NullAllowed, Export("actions")]
		NSObject Actions { get; }
	}

	// @interface UAPreferenceChannelSubscriptionItem : NSObject <UAPreferenceItem>
	[BaseType(typeof(NSObject))]
	interface UAPreferenceChannelSubscriptionItem : IUAPreferenceItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic) enum UAPreferenceItemType itemType;
		[Export("itemType")]
		UAPreferenceItemType ItemType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull subscriptionID;
		[Export("subscriptionID")]
		string SubscriptionID { get; }

		// @property (copy, nonatomic) NSArray<id<UAPreferenceConditions>> * _Nullable conditions;
		[NullAllowed, Export("conditions", ArgumentSemantic.Copy)]
		IUAPreferenceConditions[] Conditions { get; set; }
	}

	// @interface UAPreferenceCommonDisplay : NSObject
	[BaseType(typeof(NSObject))]
	interface UAPreferenceCommonDisplay
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable subtitle;
		[NullAllowed, Export("subtitle")]
		string Subtitle { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable iconURL;
		[NullAllowed, Export("iconURL")]
		string IconURL { get; }
	}

	// @protocol UAPreferenceSection
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface UAPreferenceSection
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Abstract]
		[Export("type")]
		string Type { get; }

		// @required @property (readonly, nonatomic) enum UAPreferenceSectionType sectionType;
		[Abstract]
		[Export("sectionType")]
		UAPreferenceSectionType SectionType { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Abstract]
		[Export("identifier")]
		string Identifier { get; }

		// @required @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[Abstract]
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }

		// @required @property (readonly, copy, nonatomic) NSArray<id<UAPreferenceItem>> * _Nonnull items;
		[Abstract]
		[Export("items", ArgumentSemantic.Copy)]
		UAPreferenceItem[] Items { get; }

		// @required @property (readonly, copy, nonatomic) NSArray<id<UAPreferenceConditions>> * _Nullable conditions;
		[Abstract]
		[NullAllowed, Export("conditions", ArgumentSemantic.Copy)]
		IUAPreferenceConditions[] Conditions { get; }
	}

	interface IUAPreferenceSection { };

	// @interface UAPreferenceCommonSection : NSObject <UAPreferenceSection>
	[BaseType(typeof(NSObject))]
	interface UAPreferenceCommonSection : IUAPreferenceSection
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic) enum UAPreferenceSectionType sectionType;
		[Export("sectionType")]
		UAPreferenceSectionType SectionType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }

		// @property (copy, nonatomic) NSArray<id<UAPreferenceConditions>> * _Nullable conditions;
		[NullAllowed, Export("conditions", ArgumentSemantic.Copy)]
		IUAPreferenceConditions[] Conditions { get; set; }

		// @property (copy, nonatomic) NSArray<id<UAPreferenceItem>> * _Nonnull items;
		[Export("items", ArgumentSemantic.Copy)]
		UAPreferenceItem[] Items { get; set; }
	}

	// @protocol UAPreferenceConditions
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface UAPreferenceConditions
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Abstract]
		[Export("type")]
		string Type { get; }

		// @required @property (readonly, nonatomic) enum UAPreferenceConditionType conditionType;
		[Abstract]
		[Export("conditionType")]
		UAPreferenceConditionType ConditionType { get; }
	}

	// @interface UAPreferenceContactSubscriptionGroupItem : NSObject <UAPreferenceItem>
	[BaseType(typeof(NSObject))]
	interface UAPreferenceContactSubscriptionGroupItem : IUAPreferenceItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic) enum UAPreferenceItemType itemType;
		[Export("itemType")]
		UAPreferenceItemType ItemType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull subscriptionID;
		[Export("subscriptionID")]
		string SubscriptionID { get; }

        // @property (readonly, copy, nonatomic) NSArray<UAPreferenceComponent *> * _Nonnull components;
        [Export("components", ArgumentSemantic.Copy)]
        UAPreferenceComponent[] Components { get; }

		// @property (copy, nonatomic) NSArray<id<UAPreferenceConditions>> * _Nullable conditions;
		[NullAllowed, Export("conditions", ArgumentSemantic.Copy)]
		IUAPreferenceConditions[] Conditions { get; set; }
	}

	// @interface Component : NSObject
	[BaseType(typeof(NSObject), Name = "_TtCC23AirshipPreferenceCenter28ContactSubscriptionGroupItem9Component")]
	interface Component
	{
		// @property (readonly, nonatomic, strong) UAChannelScopes * _Nonnull scopes;
		[Export("scopes", ArgumentSemantic.Strong)]
		UAChannelScopes Scopes { get; }

		// @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nonnull display;
		[Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }
	}

	// @interface UAPreferenceContactSubscriptionItem : NSObject <UAPreferenceItem>
	[BaseType(typeof(NSObject))]
	interface UAPreferenceContactSubscriptionItem : IUAPreferenceItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic) enum UAPreferenceItemType itemType;
		[Export("itemType")]
		UAPreferenceItemType ItemType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull subscriptionID;
		[Export("subscriptionID")]
		string SubscriptionID { get; }

		// @property (readonly, nonatomic, strong) UAChannelScopes * _Nonnull scopes;
		[Export("scopes", ArgumentSemantic.Strong)]
		UAChannelScopes Scopes { get; }

		// @property (copy, nonatomic) NSArray<id<UAPreferenceConditions>> * _Nullable conditions;
		[NullAllowed, Export("conditions", ArgumentSemantic.Copy)]
		IUAPreferenceConditions[] Conditions { get; set; }
	}

	// @interface UAPreferenceLabeledSectionBreakSection : NSObject <UAPreferenceSection>
	[BaseType(typeof(NSObject))]
	interface UAPreferenceLabeledSectionBreakSection : IUAPreferenceSection
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic) enum UAPreferenceSectionType sectionType;
		[Export("sectionType")]
		UAPreferenceSectionType SectionType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }

		// @property (readonly, copy, nonatomic) NSArray<id<UAPreferenceItem>> * _Nonnull items;
		[Export("items", ArgumentSemantic.Copy)]
		UAPreferenceItem[] Items { get; }

		// @property (copy, nonatomic) NSArray<id<UAPreferenceConditions>> * _Nullable conditions;
		[NullAllowed, Export("conditions", ArgumentSemantic.Copy)]
		IUAPreferenceConditions[] Conditions { get; set; }
	}

	interface IUAPreferenceConditions { };

	// @interface UAPreferenceNotificationOptInCondition : NSObject <UAPreferenceConditions>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAPreferenceNotificationOptInCondition : IUAPreferenceConditions
	{
		// @property (readonly, nonatomic) enum UAPreferenceConditionType conditionType;
		[Export("conditionType")]
		UAPreferenceConditionType ConditionType { get; }

		// @property (copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; set; }

		// @property (readonly, nonatomic) enum UANotificationOptInConditionStatus optInStatus;
		[Export("optInStatus")]
		UANotificationOptInConditionStatus OptInStatus { get; }
	}

	interface IUAComponent { };

	// @interface UAPreferenceCenter : NSObject <UAComponent>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAPreferenceCenter : IUAComponent
	{
		// @property (readonly, nonatomic, strong, class) UAPreferenceCenter * _Nonnull shared;
		[Static]
		[Export("shared", ArgumentSemantic.Strong)]
		UAPreferenceCenter Shared { get; }

		[Wrap("WeakOpenDelegate")]
		[NullAllowed]
		IUAPreferenceCenterOpenDelegate OpenDelegate { get; set; }

		// @property (nonatomic, weak) id<UAPreferenceCenterOpenDelegate> _Nullable openDelegate;
		[NullAllowed, Export("openDelegate", ArgumentSemantic.Weak)]
		NSObject WeakOpenDelegate { get; set; }

		// @property (nonatomic, strong) UAPreferenceCenterStyle * _Nullable style;
		[NullAllowed, Export("style", ArgumentSemantic.Strong)]
		UAPreferenceCenterStyle Style { get; set; }

		// @property (getter = isComponentEnabled, nonatomic) BOOL componentEnabled;
		[Export("componentEnabled")]
		bool ComponentEnabled { [Bind("isComponentEnabled")] get; set; }

		// -(void)openPreferenceCenter:(NSString * _Nonnull)preferenceCenterID;
		[Export("openPreferenceCenter:")]
		void OpenPreferenceCenter(string preferenceCenterID);

		// -(UADisposable * _Nonnull)configForPreferenceCenterID:(NSString * _Nonnull)preferenceCenterID completionHandler:(void (^ _Nonnull)(UAPreferenceCenterConfig * _Nullable))completionHandler;
		[Export("configForPreferenceCenterID:completionHandler:")]
		UADisposable ConfigForPreferenceCenterID(string preferenceCenterID, Action<UAPreferenceCenterConfig> completionHandler);

		// -(BOOL)deepLink:(NSURL * _Nonnull)deepLink __attribute__((warn_unused_result("")));
		[Export("deepLink:")]
		bool DeepLink(NSUrl deepLink);
	}

	// @interface UAPreferenceCenterAlertCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface UAPreferenceCenterAlertCell
	{
	}

	// @interface UAPreferenceCenterCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface UAPreferenceCenterCell
	{
	}

	// @interface UAPreferenceCenterCheckboxCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface UAPreferenceCenterCheckboxCell
	{
	}

	// @interface UAPreferenceCenterConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface UAPreferenceCenterConfig
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")]
		string Identifier { get; }

		// @property (copy, nonatomic) NSArray<id<UAPreferenceSection>> * _Nonnull sections;
		[Export("sections", ArgumentSemantic.Copy)]
		IUAPreferenceSection[] Sections { get; set; }

		// @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }
	}

	// @protocol UAPreferenceCenterOpenDelegate
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface UAPreferenceCenterOpenDelegate
	{
		// @required -(BOOL)openPreferenceCenter:(NSString * _Nonnull)preferenceCenterID __attribute__((warn_unused_result("")));
		[Abstract]
		[Export("openPreferenceCenter:")]
		bool OpenPreferenceCenter(string preferenceCenterID);
	}

	interface IUAPreferenceCenterOpenDelegate { };

	// @interface PreferenceCenterResources : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC23AirshipPreferenceCenter25PreferenceCenterResources")]
	interface PreferenceCenterResources
	{
		// +(NSBundle * _Nullable)bundle __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export("bundle")]
		NSBundle Bundle { get; }
	}

	// @interface UAPreferenceCenterStyle : NSObject
	[BaseType(typeof(NSObject))]
	interface UAPreferenceCenterStyle
	{
		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export("title")]
		string Title { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable titleFont;
		[NullAllowed, Export("titleFont", ArgumentSemantic.Strong)]
		UIFont TitleFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable titleColor;
		[NullAllowed, Export("titleColor", ArgumentSemantic.Strong)]
		UIColor TitleColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable subtitle;
		[NullAllowed, Export("subtitle")]
		string Subtitle { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable subtitleFont;
		[NullAllowed, Export("subtitleFont", ArgumentSemantic.Strong)]
		UIFont SubtitleFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable subtitleColor;
		[NullAllowed, Export("subtitleColor", ArgumentSemantic.Strong)]
		UIColor SubtitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable sectionTextColor;
		[NullAllowed, Export("sectionTextColor", ArgumentSemantic.Strong)]
		UIColor SectionTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable sectionTextFont;
		[NullAllowed, Export("sectionTextFont", ArgumentSemantic.Strong)]
		UIFont SectionTextFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable sectionTitleTextColor;
		[NullAllowed, Export("sectionTitleTextColor", ArgumentSemantic.Strong)]
		UIColor SectionTitleTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable sectionTitleTextFont;
		[NullAllowed, Export("sectionTitleTextFont", ArgumentSemantic.Strong)]
		UIFont SectionTitleTextFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable sectionSubtitleTextColor;
		[NullAllowed, Export("sectionSubtitleTextColor", ArgumentSemantic.Strong)]
		UIColor SectionSubtitleTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable sectionSubtitleTextFont;
		[NullAllowed, Export("sectionSubtitleTextFont", ArgumentSemantic.Strong)]
		UIFont SectionSubtitleTextFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable sectionBreakTextColor;
		[NullAllowed, Export("sectionBreakTextColor", ArgumentSemantic.Strong)]
		UIColor SectionBreakTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable sectionBreakTextFont;
		[NullAllowed, Export("sectionBreakTextFont", ArgumentSemantic.Strong)]
		UIFont SectionBreakTextFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable sectionBreakBackgroundColor;
		[NullAllowed, Export("sectionBreakBackgroundColor", ArgumentSemantic.Strong)]
		UIColor SectionBreakBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable preferenceTextColor;
		[NullAllowed, Export("preferenceTextColor", ArgumentSemantic.Strong)]
		UIColor PreferenceTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable preferenceTextFont;
		[NullAllowed, Export("preferenceTextFont", ArgumentSemantic.Strong)]
		UIFont PreferenceTextFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable preferenceTitleTextColor;
		[NullAllowed, Export("preferenceTitleTextColor", ArgumentSemantic.Strong)]
		UIColor PreferenceTitleTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable preferenceTitleTextFont;
		[NullAllowed, Export("preferenceTitleTextFont", ArgumentSemantic.Strong)]
		UIFont PreferenceTitleTextFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable preferenceSubtitleTextColor;
		[NullAllowed, Export("preferenceSubtitleTextColor", ArgumentSemantic.Strong)]
		UIColor PreferenceSubtitleTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable preferenceSubtitleTextFont;
		[NullAllowed, Export("preferenceSubtitleTextFont", ArgumentSemantic.Strong)]
		UIFont PreferenceSubtitleTextFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable navigationBarColor;
		[NullAllowed, Export("navigationBarColor", ArgumentSemantic.Strong)]
		UIColor NavigationBarColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable tintColor;
		[NullAllowed, Export("tintColor", ArgumentSemantic.Strong)]
		UIColor TintColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable switchTintColor;
		[NullAllowed, Export("switchTintColor", ArgumentSemantic.Strong)]
		UIColor SwitchTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable switchThumbTintColor;
		[NullAllowed, Export("switchThumbTintColor", ArgumentSemantic.Strong)]
		UIColor SwitchThumbTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable preferenceChipTextColor;
		[NullAllowed, Export("preferenceChipTextColor", ArgumentSemantic.Strong)]
		UIColor PreferenceChipTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable preferenceChipTextFont;
		[NullAllowed, Export("preferenceChipTextFont", ArgumentSemantic.Strong)]
		UIFont PreferenceChipTextFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable preferenceChipCheckmarkColor;
		[NullAllowed, Export("preferenceChipCheckmarkColor", ArgumentSemantic.Strong)]
		UIColor PreferenceChipCheckmarkColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable preferenceChipCheckmarkBackgroundColor;
		[NullAllowed, Export("preferenceChipCheckmarkBackgroundColor", ArgumentSemantic.Strong)]
		UIColor PreferenceChipCheckmarkBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable preferenceChipCheckmarkCheckedBackgroundColor;
		[NullAllowed, Export("preferenceChipCheckmarkCheckedBackgroundColor", ArgumentSemantic.Strong)]
		UIColor PreferenceChipCheckmarkCheckedBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable preferenceChipBorderColor;
		[NullAllowed, Export("preferenceChipBorderColor", ArgumentSemantic.Strong)]
		UIColor PreferenceChipBorderColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable alertTitleColor;
		[NullAllowed, Export("alertTitleColor", ArgumentSemantic.Strong)]
		UIColor AlertTitleColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable alertTitleFont;
		[NullAllowed, Export("alertTitleFont", ArgumentSemantic.Strong)]
		UIFont AlertTitleFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable alertSubtitleColor;
		[NullAllowed, Export("alertSubtitleColor", ArgumentSemantic.Strong)]
		UIColor AlertSubtitleColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable alertSubtitleFont;
		[NullAllowed, Export("alertSubtitleFont", ArgumentSemantic.Strong)]
		UIFont AlertSubtitleFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable alertButtonBackgroundColor;
		[NullAllowed, Export("alertButtonBackgroundColor", ArgumentSemantic.Strong)]
		UIColor AlertButtonBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable alertButtonLabelColor;
		[NullAllowed, Export("alertButtonLabelColor", ArgumentSemantic.Strong)]
		UIColor AlertButtonLabelColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable alertButtonLabelFont;
		[NullAllowed, Export("alertButtonLabelFont", ArgumentSemantic.Strong)]
		UIFont AlertButtonLabelFont { get; set; }

		// -(void)setValue:(id _Nullable)value forUndefinedKey:(NSString * _Nonnull)key;
		[Export("setValue:forUndefinedKey:")]
		void SetValue([NullAllowed] NSObject value, string key);
	}

	// @interface PreferenceCenterViewController : UIViewController <UITableViewDataSource, UITableViewDelegate>
	[BaseType(typeof(UIViewController), Name = "_TtC23AirshipPreferenceCenter30PreferenceCenterViewController")]
	interface PreferenceCenterViewController : IUITableViewDataSource, IUITableViewDelegate
	{
		// @property (nonatomic, strong) UAPreferenceCenterStyle * _Nullable style;
		[NullAllowed, Export("style", ArgumentSemantic.Strong)]
		UAPreferenceCenterStyle Style { get; set; }
	}
}
