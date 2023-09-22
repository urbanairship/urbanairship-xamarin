/*
 Copyright Airship and Contributors
*/
using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace UrbanAirship
{
    // @interface UAPreferenceCenter
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenter
    {
        // @property (readonly, nonatomic, strong, class) UAPreferenceCenter * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        UAPreferenceCenter Shared { get; }

        [Wrap("WeakOpenDelegate")]
        [NullAllowed]
        UAPreferenceCenterOpenDelegate OpenDelegate { get; set; }

        // @property (nonatomic, weak) id<UAPreferenceCenterOpenDelegate> _Nullable openDelegate;
        [NullAllowed, Export("openDelegate", ArgumentSemantic.Weak)]
        NSObject WeakOpenDelegate { get; set; }

        // -(void)setThemeFromPlist:(NSString * _Nonnull)plist error:(NSError * _Nonnull)error;
        [Export("setThemeFromPlist:error:")]
        void SetThemeFromPlist(string plist, NSError error);

        // @property (getter = isComponentEnabled, nonatomic) BOOL componentEnabled;
        [Export("componentEnabled")]
        bool ComponentEnabled { [Bind("isComponentEnabled")] get; set; }

        // -(void)openPreferenceCenter:(NSString * _Nonnull)preferenceCenterID;
        [Export("openPreferenceCenter:")]
        void OpenPreferenceCenter(string preferenceCenterID);

        // -(void)configWithPreferenceCenterID:(NSString * _Nonnull)preferenceCenterID completionHandler:(void (^ _Nonnull)(UAPreferenceCenterConfig * _Nullable))completionHandler;
        [Export("configWithPreferenceCenterID:completionHandler:")]
        unsafe void ConfigWithPreferenceCenterID(string preferenceCenterID, Action<UAPreferenceCenterConfig> completionHandler);

        // -(void)jsonConfigWithPreferenceCenterID:(NSString * _Nonnull)preferenceCenterID completionHandler:(void (^ _Nonnull)(NSData * _Nullable))completionHandler;
        [Export("jsonConfigWithPreferenceCenterID:completionHandler:")]
        unsafe void JsonConfigWithPreferenceCenterID(string preferenceCenterID, Action<NSData> completionHandler);
    }

    // @interface UAPreferenceCenterConfig
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterConfig
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, nonatomic, strong) UAPreferenceConfigCommonDisplay * _Nullable display;
        [NullAllowed, Export("display", ArgumentSemantic.Strong)]
        UAPreferenceConfigCommonDisplay Display { get; }

        // @property (readonly, nonatomic, strong) UAPreferenceCenterConfigOptions * _Nullable options;
        [NullAllowed, Export("options", ArgumentSemantic.Strong)]
        UAPreferenceCenterConfigOptions Options { get; }
    }

    // @interface UAPreferenceCenterConfigOptions
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterConfigOptions
    {
        // @property (readonly, nonatomic) BOOL mergeChannelDataToContact;
        [Export("mergeChannelDataToContact")]
        bool MergeChannelDataToContact { get; }

        // -(instancetype _Nonnull)initWithMergeChannelDataToContact:(id)mergeChannelDataToContact __attribute__((objc_designated_initializer));
        [Export("initWithMergeChannelDataToContact:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSObject mergeChannelDataToContact);
    }

    // @interface UAPreferenceConfigCommonDisplay
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceConfigCommonDisplay
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable subtitle;
        [NullAllowed, Export("subtitle")]
        string Subtitle { get; }
    }

    // @protocol UAPreferenceConfigCondition
    [BaseType(typeof(NSObject))]
    [Protocol, Model]
    interface UAPreferenceConfigCondition
    {
        // @required @property (readonly, nonatomic) enum UAPreferenceCenterConfigConditionType type;
        [Abstract]
        [Export("type")]
        UAPreferenceCenterConfigConditionType Type { get; }
    }

    interface IUAPreferenceConfigCondition { };

    // @interface UAPreferenceCenterConfigNotificationOptInCondition <UAPreferenceConfigCondition>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterConfigNotificationOptInCondition : IUAPreferenceConfigCondition
    {
        // @property (readonly, nonatomic) enum UAPreferenceCenterConfigConditionType type;
        [Export("type")]
        UAPreferenceCenterConfigConditionType Type { get; }

        // @property (readonly, nonatomic) enum UANotificationOptInConditionStatus optInStatus;
        [Export("optInStatus")]
        UANotificationOptInConditionStatus OptInStatus { get; }
    }

    // @protocol UAPreferenceCenterConfigSection
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterConfigSection
    {
        // @required @property (readonly, nonatomic) enum UAPreferenceCenterConfigSectionType type;
        [Abstract]
        [Export("type")]
        UAPreferenceCenterConfigSectionType Type { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Abstract]
        [Export("identifier")]
        string Identifier { get; }
    }

    interface IUAPreferenceCenterConfigSection { };

    // @interface UAPreferenceCenterConfigCommonSection <UAPreferenceCenterConfigSection>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterConfigCommonSection : IUAPreferenceCenterConfigSection
    {
        // @property (readonly, nonatomic) enum UAPreferenceCenterConfigSectionType type;
        [Export("type")]
        UAPreferenceCenterConfigSectionType Type { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, nonatomic, strong) UAPreferenceConfigCommonDisplay * _Nullable display;
        [NullAllowed, Export("display", ArgumentSemantic.Strong)]
        UAPreferenceConfigCommonDisplay Display { get; }
    }

    // @interface UAPreferenceLabeledSectionBreak <UAPreferenceCenterConfigSection>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceLabeledSectionBreak : IUAPreferenceCenterConfigSection
    {
        // @property (readonly, nonatomic) enum UAPreferenceCenterConfigSectionType type;
        [Export("type")]
        UAPreferenceCenterConfigSectionType Type { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, nonatomic, strong) UAPreferenceConfigCommonDisplay * _Nullable display;
        [NullAllowed, Export("display", ArgumentSemantic.Strong)]
        UAPreferenceConfigCommonDisplay Display { get; }
    }

    // @protocol UAPreferenceCenterConfigItem
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterConfigItem
    {
        // @required @property (readonly, nonatomic) enum UAPreferenceCenterConfigItemType type;
        [Abstract]
        [Export("type")]
        UAPreferenceCenterConfigItemType Type { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Abstract]
        [Export("identifier")]
        string Identifier { get; }
    }

    interface IUAPreferenceCenterConfigItem { };

    // @interface UAPreferenceCenterConfigChannelSubscription <UAPreferenceCenterConfigItem>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterConfigChannelSubscription : IUAPreferenceCenterConfigItem
    {
        // @property (readonly, nonatomic) enum UAPreferenceCenterConfigItemType type;
        [Export("type")]
        UAPreferenceCenterConfigItemType Type { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull subscriptionID;
        [Export("subscriptionID")]
        string SubscriptionID { get; }

        // @property (readonly, nonatomic, strong) UAPreferenceConfigCommonDisplay * _Nullable display;
        [NullAllowed, Export("display", ArgumentSemantic.Strong)]
        UAPreferenceConfigCommonDisplay Display { get; }
    }

    // @interface UAPreferenceCenterConfigContactSubscriptionGroup <UAPreferenceCenterConfigItem>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterConfigContactSubscriptionGroup : IUAPreferenceCenterConfigItem
    {
        // @property (readonly, nonatomic) enum UAPreferenceCenterConfigItemType type;
        [Export("type")]
        UAPreferenceCenterConfigItemType Type { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull subscriptionID;
        [Export("subscriptionID")]
        string SubscriptionID { get; }

        // @property (readonly, nonatomic, strong) UAPreferenceConfigCommonDisplay * _Nullable display;
        [NullAllowed, Export("display", ArgumentSemantic.Strong)]
        UAPreferenceConfigCommonDisplay Display { get; }
    }

    // @interface UAPreferenceContactSubscriptionGroupComponent
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceContactSubscriptionGroupComponent
    {
        // @property (readonly, nonatomic, strong) UAChannelScopes * _Nonnull scopes;
        [Export("scopes", ArgumentSemantic.Strong)]
        UAChannelScopes Scopes { get; }

        // @property (readonly, nonatomic, strong) UAPreferenceConfigCommonDisplay * _Nullable display;
        [NullAllowed, Export("display", ArgumentSemantic.Strong)]
        UAPreferenceConfigCommonDisplay Display { get; }
    }

    // @interface UAPreferenceCenterConfigContactSubscription <UAPreferenceCenterConfigItem>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterConfigContactSubscription : IUAPreferenceCenterConfigItem
    {
        // @property (readonly, nonatomic) enum UAPreferenceCenterConfigItemType type;
        [Export("type")]
        UAPreferenceCenterConfigItemType Type { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, nonatomic, strong) UAPreferenceConfigCommonDisplay * _Nullable display;
        [NullAllowed, Export("display", ArgumentSemantic.Strong)]
        UAPreferenceConfigCommonDisplay Display { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull subscriptionID;
        [Export("subscriptionID")]
        string SubscriptionID { get; }

        // @property (readonly, nonatomic, strong) UAChannelScopes * _Nonnull scopes;
        [Export("scopes", ArgumentSemantic.Strong)]
        UAChannelScopes Scopes { get; }
    }

    // @interface UAPreferenceCenterConfigAlert <UAPreferenceCenterConfigItem>
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterConfigAlert : IUAPreferenceCenterConfigItem
    {
        // @property (readonly, nonatomic) enum UAPreferenceCenterConfigItemType type;
        [Export("type")]
        UAPreferenceCenterConfigItemType Type { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, nonatomic, strong) UAPreferenceConfigAlertDisplay * _Nullable display;
        [NullAllowed, Export("display", ArgumentSemantic.Strong)]
        UAPreferenceConfigAlertDisplay Display { get; }

        // @property (readonly, nonatomic, strong) UAPreferenceCenterConfigAlertButton * _Nullable button;
        [NullAllowed, Export("button", ArgumentSemantic.Strong)]
        UAPreferenceCenterConfigAlertButton Button { get; }
    }

    // @interface UAPreferenceCenterConfigAlertButton
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterConfigAlertButton
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

    // @interface UAPreferenceConfigAlertDisplay
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceConfigAlertDisplay
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

    // @interface UAPreferenceCenterSDKModule
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterSDKModule
    {
    }

    // @interface UAPreferenceCenterViewControllerFactory
    [BaseType(typeof(NSObject))]
    interface UAPreferenceCenterViewControllerFactory
    {
        // +(UIViewController * _Nonnull)makeViewControllerWithPreferenceCenterID:(NSString * _Nonnull)preferenceCenterID dismissAction:(void (^ _Nullable)(void))dismissAction __attribute__((warn_unused_result("")));
        [Static]
        [Export("makeViewControllerWithPreferenceCenterID:dismissAction:")]
        UIViewController MakeViewControllerWithPreferenceCenterID(string preferenceCenterID, [NullAllowed] Action dismissAction);

        // +(UIViewController * _Nullable)makeViewControllerWithPreferenceCenterID:(NSString * _Nonnull)preferenceCenterID preferenceCenterThemePlist:(NSString * _Nonnull)preferenceCenterThemePlist error:(NSError * _Nonnull)error __attribute__((warn_unused_result("")));
        [Static]
        [Export("makeViewControllerWithPreferenceCenterID:preferenceCenterThemePlist:error:")]
        [return: NullAllowed]
        UIViewController MakeViewControllerWithPreferenceCenterID(string preferenceCenterID, string preferenceCenterThemePlist, NSError error);
    }
}

