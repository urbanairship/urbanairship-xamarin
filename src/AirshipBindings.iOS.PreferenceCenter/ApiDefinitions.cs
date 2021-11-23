/*
 Copyright Airship and Contributors
*/
using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace UrbanAirship
{
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface UAPreferenceItem
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Abstract]
		[Export("type")]
		string Type { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Abstract]
		[Export("identifier")]
		string Identifier { get; }	

		// @required @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[Abstract]
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }
	}

	interface IUAPreferenceItem { };

	// @interface UAPreferenceChannelSubscriptionItem : NSObject <UAPreferenceItem>
	[BaseType(typeof(NSObject))]
	interface UAPreferenceChannelSubscriptionItem : IUAPreferenceItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull subscriptionID;
		[Export("subscriptionID")]
		string SubscriptionID { get; }
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
	}

	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface UAPreferenceSection
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Abstract]
		[Export("type")]
		string Type { get; }

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
		IUAPreferenceItem[] Items { get; }
	}

	interface IUAPreferenceSection { };

	// @interface UAPreferenceCommonSection : NSObject <UAPreferenceSection>
	[BaseType(typeof(NSObject))]
	interface UAPreferenceCommonSection : IUAPreferenceSection
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic, strong) UAPreferenceCommonDisplay * _Nullable display;
		[NullAllowed, Export("display", ArgumentSemantic.Strong)]
		UAPreferenceCommonDisplay Display { get; }

		// @property (copy, nonatomic) NSArray<id<UAPreferenceItem>> * _Nonnull items;
		[Export("items", ArgumentSemantic.Copy)]
		IUAPreferenceItem[] Items { get; set; }
	}

	// @interface UAPreferenceCenter : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAPreferenceCenter
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

	// @interface UAPreferenceCenterCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface UAPreferenceCenterCell
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

		// @property (nonatomic, strong) UIColor * _Nullable preferenceTextColor;
		[NullAllowed, Export("preferenceTextColor", ArgumentSemantic.Strong)]
		UIColor PreferenceTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable preferenceTextFont;
		[NullAllowed, Export("preferenceTextFont", ArgumentSemantic.Strong)]
		UIFont PreferenceTextFont { get; set; }

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

