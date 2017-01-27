/*
 Copyright 2017 Urban Airship and Contributors
*/

using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;

namespace UrbanAirship {

	// typedef void (^UAJavaScriptDelegateCompletionHandler)(NSString * _Nullable);
	delegate void UAJavaScriptDelegateCompletionHandler ([NullAllowed] string arg0);

	// @protocol UAJavaScriptDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UAJavaScriptDelegate
	{
		// @required -(void)callWithData:(UAWebViewCallData * _Nonnull)data withCompletionHandler:(UAJavaScriptDelegateCompletionHandler _Nonnull)completionHandler;
		[Abstract]
		[Export ("callWithData:withCompletionHandler:")]
		void Call (UAWebViewCallData data, UAJavaScriptDelegateCompletionHandler completionHandler);
	}

	// @interface UAWhitelist : NSObject
	[BaseType (typeof(NSObject))]
	interface UAWhitelist
	{
		// +(instancetype _Nonnull)whitelistWithConfig:(UAConfig * _Nonnull)config;
		[Static]
		[Export ("whitelistWithConfig:")]
		UAWhitelist Whitelist (UAConfig config);

		// -(BOOL)addEntry:(NSString * _Nonnull)patternString;
		[Export ("addEntry:")]
		bool AddEntry (string patternString);

		// -(BOOL)isWhitelisted:(NSURL * _Nonnull)url;
		[Export ("isWhitelisted:")]
		bool IsWhitelisted (NSUrl url);
	}
		
	[Static]
	partial interface Constants
	{
		// extern NSString *const _Nonnull UAirshipTakeOffBackgroundThreadException;
		[Field ("UAirshipTakeOffBackgroundThreadException", "__Internal")]
		NSString UAirshipTakeOffBackgroundThreadException { get; }

		// extern NSString *const _Nonnull UAUserCreatedNotification;
		[Field ("UAUserCreatedNotification", "__Internal")]
		NSString UAUserCreatedNotification { get; }

		// extern NSString *const _Nonnull UAInboxMessageListWillUpdateNotification;
		[Field ("UAInboxMessageListWillUpdateNotification", "__Internal")]
		NSString UAInboxMessageListWillUpdateNotification { get; }

		// extern NSString *const _Nonnull UAInboxMessageListUpdatedNotification;
		[Field ("UAInboxMessageListUpdatedNotification", "__Internal")]
		NSString UAInboxMessageListUpdatedNotification { get; }

		// extern NSString *const _Nonnull UAActionMetadataWebViewKey;
		[Field ("UAActionMetadataWebViewKey", "__Internal")]
		NSString UAActionMetadataWebViewKey { get; }

		// extern NSString *const _Nonnull UAActionMetadataPushPayloadKey;
		[Field ("UAActionMetadataPushPayloadKey", "__Internal")]
		NSString UAActionMetadataPushPayloadKey { get; }

		// extern NSString *const _Nonnull UAActionMetadataInboxMessageKey;
		[Field ("UAActionMetadataInboxMessageKey", "__Internal")]
		NSString UAActionMetadataInboxMessageKey { get; }

		// extern NSString *const _Nonnull UAActionMetadataUserNotificationActionIDKey;
		[Field ("UAActionMetadataUserNotificationActionIDKey", "__Internal")]
		NSString UAActionMetadataUserNotificationActionIDKey { get; }

		// extern NSString *const _Nonnull UAActionMetadataResponseInfoKey;
		[Field ("UAActionMetadataResponseInfoKey", "__Internal")]
		NSString UAActionMetadataResponseInfoKey { get; }

		// extern NSString *const _Nonnull UAActionMetadataRegisteredName;
		[Field ("UAActionMetadataRegisteredName", "__Internal")]
		NSString UAActionMetadataRegisteredName { get; }

		// extern NSString *const _Nonnull UAActionOperatorErrorDomain;
		[Field ("UAActionOperatorErrorDomain", "__Internal")]
		NSString UAActionOperatorErrorDomain { get; }

		// extern NSString *const _Nonnull UAAddCustomEventActionErrorDomain;
		[Field ("UAAddCustomEventActionErrorDomain", "__Internal")]
		NSString UAAddCustomEventActionErrorDomain { get; }

		// extern NSString *const _Nonnull UAOpenExternalURLActionErrorDomain;
		[Field ("UAOpenExternalURLActionErrorDomain", "__Internal")]
		NSString UAOpenExternalURLActionErrorDomain { get; }

		// extern NSString *const _Nonnull UAOverlayInboxMessageActionErrorDomain;
		[Field ("UAOverlayInboxMessageActionErrorDomain", "__Internal")]
		NSString UAOverlayInboxMessageActionErrorDomain { get; }

		// extern const NSUInteger UACustomEventCharacterLimit;
		[Field ("UACustomEventCharacterLimit", "__Internal")]
		nuint UACustomEventCharacterLimit { get; }

		// extern const NSUInteger UACustomEventMaxPropertiesCount;
		[Field ("UACustomEventMaxPropertiesCount", "__Internal")]
		nuint UACustomEventMaxPropertiesCount { get; }

		// extern NSString *const _Nonnull UAAnalyticsValueNone;
		[Field ("UAAnalyticsValueNone", "__Internal")]
		NSString UAAnalyticsValueNone { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventForegroundKey;
		[Field("UALocationEventForegroundKey", "__Internal")]
		NSString UALocationEventForegroundKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventLatitudeKey;
		[Field("UALocationEventLatitudeKey", "__Internal")]
		NSString UALocationEventLatitudeKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventLongitudeKey;
		[Field("UALocationEventLongitudeKey", "__Internal")]
		NSString UALocationEventLongitudeKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventDesiredAccuracyKey;
		[Field("UALocationEventDesiredAccuracyKey", "__Internal")]
		NSString UALocationEventDesiredAccuracyKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventUpdateTypeKey;
		[Field("UALocationEventUpdateTypeKey", "__Internal")]
		NSString UALocationEventUpdateTypeKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventProviderKey;
		[Field("UALocationEventProviderKey", "__Internal")]
		NSString UALocationEventProviderKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventDistanceFilterKey;
		[Field("UALocationEventDistanceFilterKey", "__Internal")]
		NSString UALocationEventDistanceFilterKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventHorizontalAccuracyKey;
		[Field("UALocationEventHorizontalAccuracyKey", "__Internal")]
		NSString UALocationEventHorizontalAccuracyKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventVerticalAccuracyKey;
		[Field("UALocationEventVerticalAccuracyKey", "__Internal")]
		NSString UALocationEventVerticalAccuracyKey { get; }


		// extern UALocationEventUpdateType *const _Nonnull UALocationEventAnalyticsType;
		[Field("UALocationEventAnalyticsType", "__Internal")]
		NSString UALocationEventAnalyticsType { get; }

		// extern UALocationEventUpdateType *const _Nonnull UALocationEventUpdateTypeChange;
		[Field("UALocationEventUpdateTypeChange", "__Internal")]
		NSString UALocationEventUpdateTypeChange { get; }

		// extern UALocationEventUpdateType *const _Nonnull UALocationEventUpdateTypeContinuous;
		[Field("UALocationEventUpdateTypeContinuous", "__Internal")]
		NSString UALocationEventUpdateTypeContinuous { get; }

		// extern UALocationEventUpdateType *const _Nonnull UALocationEventUpdateTypeSingle;
		[Field("UALocationEventUpdateTypeSingle", "__Internal")]
		NSString UALocationEventUpdateTypeSingle { get; }

		// extern UALocationEventUpdateType *const _Nonnull UALocationEventUpdateTypeNone;
		[Field("UALocationEventUpdateTypeNone", "__Internal")]
		NSString UALocationEventUpdateTypeNone { get; }

		// extern UALocationServiceProviderType *const _Nonnull UALocationServiceProviderGps;
		[Field("UALocationServiceProviderGps", "__Internal")]
		NSString UALocationServiceProviderGps { get; }

		// extern UALocationServiceProviderType *const _Nonnull UALocationServiceProviderNetwork;
		[Field("UALocationServiceProviderNetwork", "__Internal")]
		NSString UALocationServiceProviderNetwork { get; }

		// extern UALocationServiceProviderType *const _Nonnull UALocationServiceProviderUnknown;
		[Field("UALocationServiceProviderUnknown", "__Internal")]
		NSString UALocationServiceProviderUnknown { get; }

		// extern const NSUInteger UAAssociatedIdentifiersMaxCharacterCount;
		[Field ("UAAssociatedIdentifiersMaxCharacterCount", "__Internal")]
		nuint UAAssociatedIdentifiersMaxCharacterCount { get; }

		// extern const NSUInteger UAAssociatedIdentifiersMaxCount;
		[Field ("UAAssociatedIdentifiersMaxCount", "__Internal")]
		nuint UAAssociatedIdentifiersMaxCount { get; }

		// extern NSString *const UACancelSchedulesActionAll;
		[Field("UACancelSchedulesActionAll", "__Internal")]
		NSString UACancelSchedulesActionAll { get; }

		// extern NSString *const UACancelSchedulesActionIDs;
		[Field("UACancelSchedulesActionIDs", "__Internal")]
		NSString UACancelSchedulesActionIDs { get; }

		// extern NSString *const UACancelSchedulesActionGroups;
		[Field("UACancelSchedulesActionGroups", "__Internal")]
		NSString UACancelSchedulesActionGroups { get; }

		// extern NSString *const _Nonnull UAScheduleTriggerTypeKey;
		[Field("UAScheduleTriggerTypeKey", "__Internal")]
		NSString UAScheduleTriggerTypeKey { get; }

		// extern NSString *const _Nonnull UAScheduleTriggerPredicateKey;
		[Field("UAScheduleTriggerPredicateKey", "__Internal")]
		NSString UAScheduleTriggerPredicateKey { get; }

		// extern NSString *const _Nonnull UAScheduleTriggerGoalKey;
		[Field("UAScheduleTriggerGoalKey", "__Internal")]
		NSString UAScheduleTriggerGoalKey { get; }

		// extern NSString *const _Nonnull UAScheduleTriggerAppForegroundName;
		[Field("UAScheduleTriggerAppForegroundName", "__Internal")]
		NSString UAScheduleTriggerAppForegroundName { get; }

		// extern NSString *const _Nonnull UAScheduleTriggerAppBackgroundName;
		[Field("UAScheduleTriggerAppBackgroundName", "__Internal")]
		NSString UAScheduleTriggerAppBackgroundName { get; }

		// extern NSString *const _Nonnull UAScheduleTriggerRegionEnterName;
		[Field("UAScheduleTriggerRegionEnterName", "__Internal")]
		NSString UAScheduleTriggerRegionEnterName { get; }

		// extern NSString *const _Nonnull UAScheduleTriggerRegionExitName;
		[Field("UAScheduleTriggerRegionExitName", "__Internal")]
		NSString UAScheduleTriggerRegionExitName { get; }

		// extern NSString *const _Nonnull UAScheduleTriggerCustomEventCountName;
		[Field("UAScheduleTriggerCustomEventCountName", "__Internal")]
		NSString UAScheduleTriggerCustomEventCountName { get; }

		// extern NSString *const _Nonnull UAScheduleTriggerCustomEventValueName;
		[Field("UAScheduleTriggerCustomEventValueName", "__Internal")]
		NSString UAScheduleTriggerCustomEventValueName { get; }

		// extern NSString *const _Nonnull UAScheduleTriggerScreenName;
		[Field("UAScheduleTriggerScreenName", "__Internal")]
		NSString UAScheduleTriggerScreenName { get; }

		// extern NSString *const _Nonnull UANotificationDefaultActionIdentifier;
		[Field("UANotificationDefaultActionIdentifier", "__Internal")]
		NSString UANotificationDefaultActionIdentifier { get; }

		// extern NSString *const _Nonnull UANotificationDismissActionIdentifier;
		[Field("UANotificationDismissActionIdentifier", "__Internal")]
		NSString UANotificationDismissActionIdentifier { get; }

		// extern NSString *const _Nonnull UAChannelCreatedEvent;
		[Field("UAChannelCreatedEvent", "__Internal")]
		NSString UAChannelCreatedEvent { get; }

		// extern NSString *const _Nonnull UAChannelCreatedEventChannelKey;
		[Field("UAChannelCreatedEventChannelKey", "__Internal")]
		NSString UAChannelCreatedEventChannelKey { get; }

		// extern NSString *const _Nonnull UAChannelCreatedEventExistingKey;
		[Field("UAChannelCreatedEventExistingKey", "__Internal")]
		NSString UAChannelCreatedEventExistingKey { get; }

		// extern NSString *const _Nonnull UACustomEventNameKey;
		[Field("UACustomEventNameKey", "__Internal")]
		NSString UACustomEventNameKey { get; }

		// extern NSString *const _Nonnull UACustomEventValueKey;
		[Field("UACustomEventValueKey", "__Internal")]
		NSString UACustomEventValueKey { get; }

		// extern NSString *const _Nonnull UACustomEventPropertiesKey;
		[Field("UACustomEventPropertiesKey", "__Internal")]
		NSString UACustomEventPropertiesKey { get; }

		// extern NSString *const _Nonnull UACustomEventTransactionIDKey;
		[Field("UACustomEventTransactionIDKey", "__Internal")]
		NSString UACustomEventTransactionIDKey { get; }

		// extern NSString *const _Nonnull UACustomEventInteractionIDKey;
		[Field("UACustomEventInteractionIDKey", "__Internal")]
		NSString UACustomEventInteractionIDKey { get; }

		// extern NSString *const _Nonnull UACustomEventInteractionTypeKey;
		[Field("UACustomEventInteractionTypeKey", "__Internal")]
		NSString UACustomEventInteractionTypeKey { get; }
	}

	// @interface UAirship : NSObject
	[BaseType (typeof(NSObject))]
	interface UAirship
	{
		// @property (readonly, nonatomic, strong) UAConfig * _Nonnull config;
		[Export ("config", ArgumentSemantic.Strong)]
		UAConfig Config { get; }

		// @property (readonly, nonatomic, strong) UAAnalytics * _Nonnull analytics;
		[Export ("analytics", ArgumentSemantic.Strong)]
		UAAnalytics Analytics { get; }

		// @property (readonly, nonatomic, strong) UAActionRegistry * _Nonnull actionRegistry;
		[Export ("actionRegistry", ArgumentSemantic.Strong)]
		UAActionRegistry ActionRegistry { get; }

		// @property (readonly, assign, nonatomic) BOOL remoteNotificationBackgroundModeEnabled;
		[Export ("remoteNotificationBackgroundModeEnabled")]
		bool RemoteNotificationBackgroundModeEnabled { get; }

		[Wrap ("WeakJsDelegate")]
		[NullAllowed]
		UAJavaScriptDelegate JsDelegate { get; set; }

		// @property (nonatomic, weak) id<UAJavaScriptDelegate> _Nullable jsDelegate;
		[NullAllowed, Export ("jsDelegate", ArgumentSemantic.Weak)]
		NSObject WeakJsDelegate { get; set; }

		// @property (readonly, nonatomic, strong) UAWhitelist * _Nonnull whitelist;
		[Export ("whitelist", ArgumentSemantic.Strong)]
		UAWhitelist Whitelist { get; }

		// +(void)setLogging:(BOOL)enabled;
		[Static]
		[Export ("setLogging:")]
		void SetLogging (bool enabled);

		// +(void)setLogLevel:(UALogLevel)level;
		[Static]
		[Export ("setLogLevel:")]
		void SetLogLevel (UALogLevel level);

		// +(void)setLoudImpErrorLogging:(BOOL)enabled;
		[Static]
		[Export ("setLoudImpErrorLogging:")]
		void SetLoudImpErrorLogging (bool enabled);

		// +(void)takeOff:(UAConfig * _Nullable)config;
		[Static]
		[Export ("takeOff:")]
		void TakeOff ([NullAllowed] UAConfig config);

		// +(void)takeOff;
		[Static]
		[Export ("takeOff")]
		void TakeOff ();

		// +(UAirship * _Null_unspecified)shared;
		[Static]
		[Export ("shared")]
		UAirship Shared { get; }

		// +(UAPush * _Null_unspecified)push;
		[Static]
		[Export ("push")]
		UAPush Push { get; }

		// +(UAInbox * _Null_unspecified)inbox;
		[Static]
		[Export ("inbox")]
		UAInbox Inbox { get; }

		// +(UAUser * _Null_unspecified)inboxUser;
		[Static]
		[Export ("inboxUser")]
		UAUser InboxUser { get; }

		// +(UAInAppMessaging * _Null_unspecified)inAppMessaging;
		[Static]
		[Export ("inAppMessaging")]
		UAInAppMessaging InAppMessaging { get; }

		// +(UANamedUser * _Null_unspecified)namedUser;
		[Static]
		[Export("namedUser")]
		UANamedUser NamedUser { get; }

		// +(UADefaultMessageCenter * _Null_unspecified)defaultMessageCenter;
		[Static]
		[ExportAttribute ("defaultMessageCenter")]
		UADefaultMessageCenter DefaultMessageCenter { get;}

		// +(NSBundle * _Null_unspecified)resources;
		[Static]
		[ExportAttribute ("resources")]
		NSBundle Resources { get;}

		// +(UALocation * _Null_unspecified)location;
		[Static]
		[Export("location")]
		UALocation Location { get; }

		// +(UAAutomation * _Null_unspecified)automation;
		[Static]
		[Export("automation")]
		UAAutomation Automation { get; }
	}

	// @interface UAAppIntegration : NSObject
	[BaseType(typeof(NSObject))]
	interface UAAppIntegration
	{
		// +(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)())completionHandler;
		[Static]
		[Export("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		void UserNotificationCenterDidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler);

		// +(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center willPresentNotification:(UNNotification * _Nonnull)notification withCompletionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler;
		[Static]
		[Export("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
		void UserNotificationCenterWillPresentNotification(UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);

		// +(void)application:(UIApplication * _Nonnull)application didRegisterForRemoteNotificationsWithDeviceToken:(NSData * _Nonnull)deviceToken;
		[Static]
		[Export("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
		void ApplicationDidRegisterForRemoteNotifications(UIApplication application, NSData deviceToken);

		// +(void)application:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)userInfo fetchCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler;
		[Static]
		[Export("application:didReceiveRemoteNotification:fetchCompletionHandler:")]
		void ApplicationDidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler);

		// +(void)application:(UIApplication * _Nonnull)application didRegisterUserNotificationSettings:(UIUserNotificationSettings * _Nonnull)notificationSettings;
		[Static]
		[Export("application:didRegisterUserNotificationSettings:")]
		void ApplicationDidRegisterUserNotificationSettings(UIApplication application, UIUserNotificationSettings notificationSettings);

		// +(void)application:(UIApplication * _Nonnull)application handleActionWithIdentifier:(NSString * _Nonnull)identifier forRemoteNotification:(NSDictionary * _Nonnull)userInfo completionHandler:(void (^ _Nonnull)())handler;
		[Static]
		[Export("application:handleActionWithIdentifier:forRemoteNotification:completionHandler:")]
		void HandleAction(UIApplication application, string identifier, NSDictionary userInfo, Action handler);

		// +(void)application:(UIApplication * _Nonnull)application handleActionWithIdentifier:(NSString * _Nonnull)identifier forRemoteNotification:(NSDictionary * _Nonnull)userInfo withResponseInfo:(NSDictionary * _Nullable)responseInfo completionHandler:(void (^ _Nonnull)())handler;
		[Static]
		[Export("application:handleActionWithIdentifier:forRemoteNotification:withResponseInfo:completionHandler:")]
		void HandleAction(UIApplication application, string identifier, NSDictionary userInfo, [NullAllowed] NSDictionary responseInfo, Action handler);
	}

   // @interface UANotificationAction : NSObject
   [BaseType (typeof(NSObject))]
   interface UANotificationAction
   {
      // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
      [Export ("identifier")]
      string Identifier { get; }

      // @property (readonly, copy, nonatomic) NSString * _Nonnull title;
      [Export ("title")]
      string Title { get; }

      // @property (readonly, assign, nonatomic) UANotificationActionOptions options;
      [Export ("options", ArgumentSemantic.Assign)]
      UANotificationActionOptions Options { get; }

      // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier title:(NSString * _Nonnull)title options:(UANotificationActionOptions)options;
      [Export ("initWithIdentifier:title:options:")]
      IntPtr Constructor (string identifier, string title, UANotificationActionOptions options);

      // +(instancetype _Nonnull)actionWithIdentifier:(NSString * _Nonnull)identifier title:(NSString * _Nonnull)title options:(UANotificationActionOptions)options;
      [Static]
      [Export ("actionWithIdentifier:title:options:")]
      UANotificationAction ActionWithIdentifier (string identifier, string title, UANotificationActionOptions options);

      // -(UIUserNotificationAction * _Nullable)asUIUserNotificationAction;
      [NullAllowed, Export ("asUIUserNotificationAction")]
      UIUserNotificationAction AsUIUserNotificationAction { get; }

      // -(UNNotificationAction * _Nullable)asUNNotificationAction __attribute__((availability(ios, introduced=10.0)));
      [NullAllowed, Export ("asUNNotificationAction")]
      UNNotificationAction AsUNNotificationAction { get; }
   }

	// @interface UANotificationCategories : NSObject
	[BaseType(typeof(NSObject))]
	interface UANotificationCategories
	{
		// +(NSSet * _Nonnull)createCategoriesFromFile:(NSString * _Nonnull)filePath;
		[Static]
		[Export("createCategoriesFromFile:")]
		NSSet CreateCategories(string filePath);

		// +(UANotificationCategory * _Nullable)createCategory:(NSString * _Nonnull)categoryId actions:(NSArray * _Nonnull)actionDefinitions;
		[Static]
		[Export("createCategory:actions:")]
		[return: NullAllowed]
		UANotificationCategory CreateCategory(string categoryId, NSObject[] actionDefinitions);
	}

   // @interface UANotificationCategory : NSObject
   [BaseType (typeof(NSObject))]
   interface UANotificationCategory
   {
      // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
      [Export ("identifier")]
      string Identifier { get; }

      // @property (readonly, copy, nonatomic) NSArray<UANotificationAction *> * _Nonnull actions;
      [Export ("actions", ArgumentSemantic.Copy)]
      UANotificationAction[] Actions { get; }

      // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull intentIdentifiers;
      [Export ("intentIdentifiers", ArgumentSemantic.Copy)]
      string[] IntentIdentifiers { get; }

      // @property (readonly, assign, nonatomic) UANotificationCategoryOptions options;
      [Export ("options", ArgumentSemantic.Assign)]
      UANotificationCategoryOptions Options { get; }

      // +(instancetype _Nonnull)categoryWithIdentifier:(NSString * _Nonnull)identifier actions:(NSArray<UANotificationAction *> * _Nonnull)actions intentIdentifiers:(NSArray<NSString *> * _Nonnull)intentIdentifiers options:(UANotificationCategoryOptions)options;
      [Static]
      [Export ("categoryWithIdentifier:actions:intentIdentifiers:options:")]
      UANotificationCategory CategoryWithIdentifier (string identifier, UANotificationAction[] actions, string[] intentIdentifiers, UANotificationCategoryOptions options);
   }

	// @interface UANotificationContent : NSObject
	[BaseType(typeof(NSObject))]
	interface UANotificationContent
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable alertTitle;
		[NullAllowed, Export("alertTitle")]
		string AlertTitle { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable alertBody;
		[NullAllowed, Export("alertBody")]
		string AlertBody { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sound;
		[NullAllowed, Export("sound")]
		string Sound { get; }

		// @property (readonly, assign, nonatomic) NSNumber * _Nullable badge;
		[NullAllowed, Export("badge", ArgumentSemantic.Assign)]
		NSNumber Badge { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable contentAvailable;
		[NullAllowed, Export("contentAvailable", ArgumentSemantic.Strong)]
		NSNumber ContentAvailable { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable categoryIdentifier;
		[NullAllowed, Export("categoryIdentifier")]
		string CategoryIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable launchImage;
		[NullAllowed, Export("launchImage")]
		string LaunchImage { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nullable localizationKeys;
		[NullAllowed, Export("localizationKeys", ArgumentSemantic.Copy)]
		NSDictionary LocalizationKeys { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull notificationInfo;
		[Export("notificationInfo", ArgumentSemantic.Copy)]
		NSDictionary NotificationInfo { get; }

		// @property (readonly, nonatomic, strong) UNNotification * _Nullable notification;
		[NullAllowed, Export("notification", ArgumentSemantic.Strong)]
		UNNotification UNNotification { get; }

		// +(instancetype _Nonnull)notificationWithNotificationInfo:(NSDictionary * _Nonnull)notificationInfo;
		[Static]
		[Export("notificationWithNotificationInfo:")]
		UANotificationContent Notification(NSDictionary notificationInfo);

		// +(instancetype _Nonnull)notificationWithUNNotification:(UNNotification * _Nonnull)notification;
		[Static]
		[Export("notificationWithUNNotification:")]
		UANotificationContent Notification(UNNotification notification);
	}

	// @interface UANotificationResponse : NSObject
	[BaseType(typeof(NSObject))]
	interface UANotificationResponse
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull actionIdentifier;
		[Export("actionIdentifier")]
		string ActionIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull responseText;
		[Export("responseText")]
		string ResponseText { get; }

		// @property (readonly, nonatomic, strong) UANotificationContent * _Nonnull notificationContent;
		[Export("notificationContent", ArgumentSemantic.Strong)]
		UANotificationContent NotificationContent { get; }

		// @property (readonly, nonatomic, strong) UNNotificationResponse * _Nullable response;
		[NullAllowed, Export("response", ArgumentSemantic.Strong)]
		UNNotificationResponse Response { get; }

		// +(instancetype _Nonnull)notificationResponseWithNotificationInfo:(NSDictionary * _Nonnull)notificationInfo actionIdentifier:(NSString * _Nonnull)actionIdentifier responseText:(NSString * _Nullable)responseText;
		[Static]
		[Export("notificationResponseWithNotificationInfo:actionIdentifier:responseText:")]
		UANotificationResponse NotificationResponse(NSDictionary notificationInfo, string actionIdentifier, [NullAllowed] string responseText);

		// +(instancetype _Nonnull)notificationResponseWithUNNotificationResponse:(UNNotificationResponse * _Nonnull)response;
		[Static]
		[Export("notificationResponseWithUNNotificationResponse:")]
		UANotificationResponse NotificationResponse(UNNotificationResponse response);
	}

	// @protocol UALocationDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface UALocationDelegate
	{
		// @optional -(void)locationUpdatesStarted;
		[Export("locationUpdatesStarted")]
		void LocationUpdatesStarted();

		// @optional -(void)locationUpdatesStopped;
		[Export("locationUpdatesStopped")]
		void LocationUpdatesStopped();

		// @optional -(void)receivedLocationUpdates:(NSArray * _Nonnull)locations;
		[Export("receivedLocationUpdates:")]
		void ReceivedLocationUpdates(NSObject[] locations);
	}

	// @interface UALocation : NSObject
	[BaseType(typeof(NSObject))]
	interface UALocation
	{
		// @property (getter = isAutoRequestAuthorizationEnabled, assign, nonatomic) BOOL autoRequestAuthorizationEnabled;
		[Export("autoRequestAuthorizationEnabled")]
		bool AutoRequestAuthorizationEnabled { [Bind("isAutoRequestAuthorizationEnabled")] get; set; }

		// @property (getter = isLocationUpdatesEnabled, assign, nonatomic) BOOL locationUpdatesEnabled;
		[Export("locationUpdatesEnabled")]
		bool LocationUpdatesEnabled { [Bind("isLocationUpdatesEnabled")] get; set; }

		// @property (getter = isBackgroundLocationUpdatesAllowed, assign, nonatomic) BOOL backgroundLocationUpdatesAllowed;
		[Export("backgroundLocationUpdatesAllowed")]
		bool BackgroundLocationUpdatesAllowed { [Bind("isBackgroundLocationUpdatesAllowed")] get; set; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		UALocationDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<UALocationDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) CLLocation * _Nullable lastLocation;
		[NullAllowed, Export("lastLocation")]
		CLLocation LastLocation { get; }
	}


	// @interface UAUser : NSObject
	[BaseType (typeof(NSObject))]
	interface UAUser
	{
		// @property (readonly, getter = isCreated, nonatomic) BOOL created;
		[Export ("created")]
		bool Created { [Bind ("isCreated")] get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable username;
		[NullAllowed, Export ("username")]
		string Username { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable password;
		[NullAllowed, Export ("password")]
		string Password { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable url;
		[NullAllowed, Export ("url")]
		string Url { get; }
	}

	// @protocol UAInboxDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UAInboxDelegate
	{
		// @optional -(void)richPushMessageAvailable:(UAInboxMessage * _Nonnull)richPushMessage;
		[Export ("richPushMessageAvailable:")]
		void RichPushMessageAvailable (UAInboxMessage richPushMessage);

		// @optional -(void)showInboxMessage:(UAInboxMessage * _Nonnull)message;
		[Export ("showInboxMessage:")]
		void ShowInboxMessage (UAInboxMessage message);

		// @required -(void)showInbox;
		[Abstract]
		[Export ("showInbox")]
		void ShowInbox ();
	}

	// @interface UAInbox : NSObject
	[BaseType (typeof(NSObject))]
	interface UAInbox
	{
		// @property (nonatomic, strong) UAInboxMessageList * _Nonnull messageList;
		[Export ("messageList", ArgumentSemantic.Strong)]
		UAInboxMessageList MessageList { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		UAInboxDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<UAInboxDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// typedef void (^UADisposalBlock)();
	delegate void UADisposalBlock ();

	// @interface UADisposable : NSObject
	[BaseType (typeof(NSObject))]
	interface UADisposable
	{
		// +(instancetype _Nonnull)disposableWithBlock:(UADisposalBlock _Nonnull)disposalBlock;
		[Static]
		[Export ("disposableWithBlock:")]
		UADisposable Disposable (UADisposalBlock disposalBlock);

		// -(void)dispose;
		[Export ("dispose")]
		void Dispose ();
	}

	// typedef void (^UAInboxMessageCallbackBlock)(UAInboxMessage * _Nonnull);
	delegate void UAInboxMessageCallbackBlock (UAInboxMessage arg0);

	// @interface UAInboxMessage : NSObject
	[BaseType (typeof(NSObject))]
	interface UAInboxMessage
	{
		// @property (readonly, nonatomic) NSString * _Nonnull messageID;
		[Export ("messageID")]
		string MessageID { get; }

		// @property (readonly, nonatomic) NSURL * _Nonnull messageBodyURL;
		[Export ("messageBodyURL")]
		NSUrl MessageBodyURL { get; }

		// @property (readonly, nonatomic) NSURL * _Nonnull messageURL;
		[Export ("messageURL")]
		NSUrl MessageURL { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull contentType;
		[Export ("contentType")]
		string ContentType { get; }

		// @property (readonly, nonatomic) BOOL unread;
		[Export ("unread")]
		bool Unread { get; }

		// @property (readonly, nonatomic) BOOL deleted;
		[Export ("deleted")]
		bool Deleted { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull messageSent;
		[Export ("messageSent")]
		NSDate MessageSent { get; }

		// @property (readonly, nonatomic) NSDate * _Nullable messageExpiration;
		[NullAllowed, Export ("messageExpiration")]
		NSDate MessageExpiration { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; }

		// @property (readonly, nonatomic) NSDictionary * _Nonnull extra;
		[Export ("extra")]
		NSDictionary Extra { get; }

		// @property (readonly, nonatomic) NSDictionary * _Nonnull rawMessageObject;
		[Export ("rawMessageObject")]
		NSDictionary RawMessageObject { get; }

		// @property (readonly, nonatomic, weak) UAInboxMessageList * _Nullable inbox;
		[NullAllowed, Export ("inbox", ArgumentSemantic.Weak)]
		UAInboxMessageList Inbox { get; }

		// -(UADisposable * _Nullable)markMessageReadWithCompletionHandler:(UAInboxMessageCallbackBlock _Nullable)completionHandler;
		[Export ("markMessageReadWithCompletionHandler:")]
		[return: NullAllowed]
		UADisposable MarkMessageRead ([NullAllowed] UAInboxMessageCallbackBlock completionHandler);

		// -(BOOL)isExpired;
		[Export ("isExpired")]
		bool IsExpired { get; }
	}

	// typedef void (^UAInboxMessageListCallbackBlock)();
	delegate void UAInboxMessageListCallbackBlock ();

	// @interface UAInboxMessageList : NSObject
	[BaseType (typeof(NSObject))]
	interface UAInboxMessageList
	{
		// -(UADisposable * _Nullable)markMessagesRead:(NSArray * _Nonnull)messages completionHandler:(UAInboxMessageListCallbackBlock _Nullable)completionHandler;
		[Export ("markMessagesRead:completionHandler:")]
		[return: NullAllowed]
		UADisposable MarkMessagesRead (UAInboxMessage[] messages, [NullAllowed] UAInboxMessageListCallbackBlock completionHandler);

		// -(UADisposable * _Nullable)markMessagesDeleted:(NSArray * _Nonnull)messages completionHandler:(UAInboxMessageListCallbackBlock _Nullable)completionHandler;
		[Export ("markMessagesDeleted:completionHandler:")]
		[return: NullAllowed]
		UADisposable MarkMessagesDeleted (UAInboxMessage[] messages, [NullAllowed] UAInboxMessageListCallbackBlock completionHandler);

		// -(UADisposable * _Nullable)retrieveMessageListWithSuccessBlock:(UAInboxMessageListCallbackBlock _Nullable)successBlock withFailureBlock:(UAInboxMessageListCallbackBlock _Nullable)failureBlock;
		[Export ("retrieveMessageListWithSuccessBlock:withFailureBlock:")]
		[return: NullAllowed]
		UADisposable RetrieveMessageList ([NullAllowed] UAInboxMessageListCallbackBlock successBlock, [NullAllowed] UAInboxMessageListCallbackBlock failureBlock);

		// -(NSUInteger)messageCount;
		[Export ("messageCount")]
		nuint MessageCount { get; }

		// -(UAInboxMessage * _Nullable)messageForBodyURL:(NSURL * _Nonnull)url;
		[Export ("messageForBodyURL:")]
		[return: NullAllowed]
		UAInboxMessage MessageForBodyURL (NSUrl url);

		// -(UAInboxMessage * _Nullable)messageForID:(NSString * _Nonnull)messageID;
		[Export ("messageForID:")]
		[return: NullAllowed]
		UAInboxMessage MessageForID (string messageID);

		// @property (readonly, atomic, strong) NSArray<UAInboxMessage *> * _Nonnull messages;
		[Export ("messages", ArgumentSemantic.Strong)]
		UAInboxMessage[] Messages { get; }

		// @property (assign) NSInteger unreadCount;
		[Export ("unreadCount")]
		nint UnreadCount { get; set; }

		// @property (readonly) BOOL isRetrieving;
		[Export ("isRetrieving")]
		bool IsRetrieving { get; }

		// @property (readonly) BOOL isBatchUpdating;
		[Export ("isBatchUpdating")]
		bool IsBatchUpdating { get; }
	}

	// @interface UANamedUser : NSObject
	[BaseType (typeof(NSObject))]
	interface UANamedUser
	{
		// @property (copy, nonatomic) NSString * _Nullable identifier;
		[NullAllowed, Export ("identifier")]
		string Identifier { get; set; }

		// -(void)forceUpdate;
		[Export ("forceUpdate")]
		void ForceUpdate ();

		// -(void)addTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)tagGroupID;
		[Export ("addTags:group:")]
		void AddTags (string[] tags, string tagGroupID);

		// -(void)removeTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)tagGroupID;
		[Export ("removeTags:group:")]
		void RemoveTags (string[] tags, string tagGroupID);

      // -(void)setTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)tagGroupID;
      [Export ("setTags:group:")]
      void SetTags (string[] tags, string tagGroupID);

		// -(void)updateTags;
		[Export ("updateTags")]
		void UpdateTags ();
	}

	// @protocol UARegistrationDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UARegistrationDelegate
	{
		// @optional -(void)registrationSucceededForChannelID:(NSString * _Nonnull)channelID deviceToken:(NSString * _Nonnull)deviceToken;
		[Export ("registrationSucceededForChannelID:deviceToken:")]
		void RegistrationSucceeded (string channelID, string deviceToken);

		// @optional -(void)registrationFailed;
		[Export ("registrationFailed")]
   	void RegistrationFailed ();

      // @optional -(void)notificationRegistrationFinishedWithOptions:(UANotificationOptions)options categories:(NSSet * _Nonnull)categories;
      [Export ("notificationRegistrationFinishedWithOptions:categories:")]
      void NotificationRegistrationFinishedWithOptions (UANotificationOptions options, NSSet categories);

      // @optional -(void)notificationAuthorizedOptionsDidChange:(UANotificationOptions)options;
      [Export ("notificationAuthorizedOptionsDidChange:")]
      void NotificationAuthorizedOptionsDidChange (UANotificationOptions options);
	}

	// @protocol UAPushNotificationDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface UAPushNotificationDelegate
	{
		// @optional -(void)receivedForegroundNotification:(UANotificationContent * _Nonnull)notificationContent completionHandler:(void (^ _Nonnull)())completionHandler;
		[Export("receivedForegroundNotification:completionHandler:")]
		void ReceivedForegroundNotification(UANotificationContent notificationContent, Action completionHandler);

		// @optional -(void)receivedBackgroundNotification:(UANotificationContent * _Nonnull)notificationContent completionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler;
		[Export("receivedBackgroundNotification:completionHandler:")]
		void ReceivedBackgroundNotification(UANotificationContent notificationContent, Action<UIBackgroundFetchResult> completionHandler);

		// @optional -(void)receivedNotificationResponse:(UANotificationResponse * _Nonnull)notificationResponse completionHandler:(void (^ _Nonnull)())completionHandler;
		[Export("receivedNotificationResponse:completionHandler:")]
		void ReceivedNotificationResponse(UANotificationResponse notificationResponse, Action completionHandler);

		// @optional -(UNNotificationPresentationOptions)presentationOptionsForNotification:(UNNotification * _Nonnull)notification;
		[Export("presentationOptionsForNotification:")]
		UNNotificationPresentationOptions PresentationOptions(UNNotification notification);
	}

	// @interface UAPush : NSObject <UAChannelRegistrarDelegate>
	[BaseType (typeof(NSObject))]
	interface UAPush
	{
		// @property (assign, nonatomic) BOOL backgroundPushNotificationsEnabled;
		[Export ("backgroundPushNotificationsEnabled")]
		bool BackgroundPushNotificationsEnabled { get; set; }

		// @property (assign, nonatomic) BOOL backgroundPushNotificationsEnabledByDefault;
		[Export ("backgroundPushNotificationsEnabledByDefault")]
		bool BackgroundPushNotificationsEnabledByDefault { get; set; }

		// @property (assign, nonatomic) BOOL userPushNotificationsEnabled;
		[Export ("userPushNotificationsEnabled")]
		bool UserPushNotificationsEnabled { get; set; }

		// @property (assign, nonatomic) BOOL pushTokenRegistrationEnabled;
		[Export ("pushTokenRegistrationEnabled")]
		bool PushTokenRegistrationEnabled { get; set; }

		// @property (assign, nonatomic) BOOL allowUnregisteringUserNotificationTypes;
		[Export ("allowUnregisteringUserNotificationTypes")]
		bool AllowUnregisteringUserNotificationTypes { get; set; }

		// @property (assign, nonatomic) BOOL requireSettingsAppToDisableUserNotifications;
		[Export ("requireSettingsAppToDisableUserNotifications")]
		bool RequireSettingsAppToDisableUserNotifications { get; set; }

		// @property (assign, nonatomic) BOOL userPushNotificationsEnabledByDefault;
		[Export ("userPushNotificationsEnabledByDefault")]
		bool UserPushNotificationsEnabledByDefault { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable deviceToken;
		[NullAllowed, Export ("deviceToken")]
		string DeviceToken { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable channelID;
		[NullAllowed, Export("channelID")]
		string ChannelID { get; }

		// @property (assign, nonatomic) BOOL requireAuthorizationForDefaultCategories;
		[Export ("requireAuthorizationForDefaultCategories")]
		bool RequireAuthorizationForDefaultCategories { get; set; }

		[Wrap ("WeakPushNotificationDelegate")]
		[NullAllowed]
		UAPushNotificationDelegate PushNotificationDelegate { get; set; }

		// @property (nonatomic, weak) id<UAPushNotificationDelegate> _Nullable pushNotificationDelegate;
		[NullAllowed, Export ("pushNotificationDelegate", ArgumentSemantic.Weak)]
		NSObject WeakPushNotificationDelegate { get; set; }

		[Wrap ("WeakRegistrationDelegate")]
		[NullAllowed]
		UARegistrationDelegate RegistrationDelegate { get; set; }

		// @property (nonatomic, weak) id<UARegistrationDelegate> _Nullable registrationDelegate;
		[NullAllowed, Export ("registrationDelegate", ArgumentSemantic.Weak)]
		NSObject WeakRegistrationDelegate { get; set; }

		// @property (getter = isAutobadgeEnabled, assign, nonatomic) BOOL autobadgeEnabled;
		[Export ("autobadgeEnabled")]
		bool AutobadgeEnabled { [Bind ("isAutobadgeEnabled")] get; set; }

		// -(void)setBadgeNumber:(NSInteger)badgeNumber;
		[Export ("setBadgeNumber:")]
		void SetBadgeNumber (nint badgeNumber);

		// -(void)resetBadge;
		[Export ("resetBadge")]
		void ResetBadge ();

		// @property (copy, nonatomic) NSString * _Nullable alias;
		[NullAllowed, Export ("alias")]
		string Alias { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull tags;
		[Export ("tags", ArgumentSemantic.Copy)]
		string[] Tags { get; set; }

		// @property (getter = isChannelTagRegistrationEnabled, assign, nonatomic) BOOL channelTagRegistrationEnabled;
		[Export ("channelTagRegistrationEnabled")]
		bool ChannelTagRegistrationEnabled { [Bind ("isChannelTagRegistrationEnabled")] get; set; }

		// -(void)addTag:(NSString * _Nonnull)tag;
		[Export ("addTag:")]
		void AddTag (string tag);

		// -(void)addTags:(NSArray<NSString *> * _Nonnull)tags;
		[Export ("addTags:")]
		void AddTags (string[] tags);

		// -(void)removeTag:(NSString * _Nonnull)tag;
		[Export ("removeTag:")]
		void RemoveTag (string tag);

		// -(void)removeTags:(NSArray<NSString *> * _Nonnull)tags;
		[Export ("removeTags:")]
		void RemoveTags (string[] tags);

		// -(void)addTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)tagGroupID;
		[Export ("addTags:group:")]
		void AddTags (string[] tags, string tagGroupID);

		// -(void)removeTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)tagGroupID;
		[Export ("removeTags:group:")]
		void RemoveTags (string[] tags, string tagGroupID);

      // -(void)setTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)tagGroupID;
      [Export ("setTags:group:")]
      void SetTags (string[] tags, string tagGroupID);

		// @property (readonly, copy, nonatomic) NSDictionary * _Nullable quietTime;
		[NullAllowed, Export ("quietTime", ArgumentSemantic.Copy)]
		NSDictionary QuietTime { get; }

		// @property (nonatomic, strong) NSTimeZone * _Nonnull timeZone;
		[Export ("timeZone", ArgumentSemantic.Strong)]
		NSTimeZone TimeZone { get; set; }

		// @property (getter = isQuietTimeEnabled, assign, nonatomic) BOOL quietTimeEnabled;
		[Export ("quietTimeEnabled")]
		bool QuietTimeEnabled { [Bind ("isQuietTimeEnabled")] get; set; }

		// -(void)setQuietTimeStartHour:(NSUInteger)startHour startMinute:(NSUInteger)startMinute endHour:(NSUInteger)endHour endMinute:(NSUInteger)endMinute;
		[Export ("setQuietTimeStartHour:startMinute:endHour:endMinute:")]
		void SetQuietTime (nuint startHour, nuint startMinute, nuint endHour, nuint endMinute);

		// -(void)enableChannelCreation;
		[Export ("enableChannelCreation")]
		void EnableChannelCreation ();

		// -(void)updateRegistration;
		[Export ("updateRegistration")]
		void UpdateRegistration ();

		// @property (assign, nonatomic) UANotificationOptions notificationOptions;
		[Export("notificationOptions", ArgumentSemantic.Assign)]
		UANotificationOptions NotificationOptions { get; set; }

		// @property (readonly, assign, nonatomic) UANotificationOptions authorizedNotificationOptions;
		[Export("authorizedNotificationOptions", ArgumentSemantic.Assign)]
		UANotificationOptions AuthorizedNotificationOptions { get; }

		// @property (nonatomic, strong) NSSet<UANotificationCategory *> * _Nonnull customCategories;
		[Export("customCategories", ArgumentSemantic.Strong)]
		NSSet CustomCategories { get; set; }

		// @property (readonly, nonatomic, strong) UANotificationResponse * _Nullable launchNotificationResponse;
		[NullAllowed, Export("launchNotificationResponse", ArgumentSemantic.Strong)]
		UANotificationResponse LaunchNotificationResponse { get; }

		// @property (assign, nonatomic) UNNotificationPresentationOptions defaultPresentationOptions;
		[Export("defaultPresentationOptions", ArgumentSemantic.Assign)]
		UNNotificationPresentationOptions DefaultPresentationOptions { get; set; }
	}

	// @interface UAConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface UAConfig
	{
		// @property (readonly, nonatomic) NSString * _Nullable appKey;
		[NullAllowed, Export ("appKey")]
		string AppKey { get; }

		// @property (readonly, nonatomic) NSString * _Nullable appSecret;
		[NullAllowed, Export ("appSecret")]
		string AppSecret { get; }

		// @property (readonly, nonatomic) UALogLevel logLevel;
		[Export ("logLevel")]
		UALogLevel LogLevel { get; }

		// @property (getter = isInProduction, assign, nonatomic) BOOL inProduction;
		[Export ("inProduction")]
		bool InProduction { [Bind ("isInProduction")] get; set; }

		// @property (getter = isAnalyticsEnabled, assign, nonatomic) BOOL analyticsEnabled;
		[Export ("analyticsEnabled")]
		bool AnalyticsEnabled { [Bind ("isAnalyticsEnabled")] get; set; }

		// @property (copy, nonatomic) NSString * _Nullable developmentAppKey;
		[NullAllowed, Export ("developmentAppKey")]
		string DevelopmentAppKey { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable developmentAppSecret;
		[NullAllowed, Export ("developmentAppSecret")]
		string DevelopmentAppSecret { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable productionAppKey;
		[NullAllowed, Export ("productionAppKey")]
		string ProductionAppKey { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable productionAppSecret;
		[NullAllowed, Export ("productionAppSecret")]
		string ProductionAppSecret { get; set; }

		// @property (assign, nonatomic) UALogLevel developmentLogLevel;
		[Export ("developmentLogLevel", ArgumentSemantic.Assign)]
		UALogLevel DevelopmentLogLevel { get; set; }

		// @property (assign, nonatomic) UALogLevel productionLogLevel;
		[Export ("productionLogLevel", ArgumentSemantic.Assign)]
		UALogLevel ProductionLogLevel { get; set; }

		// @property (assign, nonatomic) NSUInteger cacheDiskSizeInMB;
		[Export ("cacheDiskSizeInMB")]
		nuint CacheDiskSizeInMB { get; set; }

		// @property (getter = isAutomaticSetupEnabled, assign, nonatomic) BOOL automaticSetupEnabled;
		[Export ("automaticSetupEnabled")]
		bool AutomaticSetupEnabled { [Bind ("isAutomaticSetupEnabled")] get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nonnull whitelist;
		[Export ("whitelist", ArgumentSemantic.Strong)]
		string[] Whitelist { get; set; }

		// @property (assign, nonatomic) BOOL detectProvisioningMode;
		[Export ("detectProvisioningMode")]
		bool DetectProvisioningMode { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull deviceAPIURL;
		[Export ("deviceAPIURL")]
		string DeviceAPIURL { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull analyticsURL;
		[Export ("analyticsURL")]
		string AnalyticsURL { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull landingPageContentURL;
		[Export ("landingPageContentURL")]
		string LandingPageContentURL { get; set; }

		// @property (assign, nonatomic) BOOL clearUserOnAppRestore;
		[Export ("clearUserOnAppRestore")]
		bool ClearUserOnAppRestore { get; set; }

		// @property (assign, nonatomic) BOOL clearNamedUserOnAppRestore;
		[Export ("clearNamedUserOnAppRestore")]
		bool ClearNamedUserOnAppRestore { get; set; }

		// @property (getter = isChannelCaptureEnabled, assign, nonatomic) BOOL channelCaptureEnabled;
		[Export ("channelCaptureEnabled")]
		bool ChannelCaptureEnabled { [Bind ("isChannelCaptureEnabled")] get; set; }

		// @property (getter = isChannelCreationDelayEnabled, assign, nonatomic) BOOL channelCreationDelayEnabled;
		[Export ("channelCreationDelayEnabled")]
		bool ChannelCreationDelayEnabled { [Bind ("isChannelCreationDelayEnabled")] get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull customConfig;
		[Export ("customConfig", ArgumentSemantic.Copy)]
		NSDictionary CustomConfig { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull messageCenterStyleConfig;
		[Export ("messageCenterStyleConfig")]
		string MessageCenterStyleConfig { get; set; }

		// +(UAConfig * _Nonnull)defaultConfig;
		[Static]
		[Export ("defaultConfig")]
		UAConfig DefaultConfig ();

		// +(UAConfig * _Nonnull)configWithContentsOfFile:(NSString * _Nonnull)path;
		[Static]
		[Export ("configWithContentsOfFile:")]
		UAConfig ConfigWithContentsOfFile (string path);

		// +(UAConfig * _Nonnull)config;
		[Static]
		[Export ("config")]
		UAConfig Config ();

		// -(BOOL)validate;
		[Export ("validate")]
		bool Validate ();
	}

	// @interface UAWebViewCallData : NSObject
	[BaseType (typeof(NSObject))]
	interface UAWebViewCallData
	{
		// +(UAWebViewCallData * _Nonnull)callDataForURL:(NSURL * _Nonnull)url webView:(UIWebView * _Nonnull)webView;
		[Static]
		[Export ("callDataForURL:webView:")]
		UAWebViewCallData CallData (NSUrl url, UIWebView webView);

		// +(UAWebViewCallData * _Nonnull)callDataForURL:(NSURL * _Nonnull)url webView:(UIWebView * _Nonnull)webView message:(UAInboxMessage * _Nullable)message;
		[Static]
		[Export ("callDataForURL:webView:message:")]
		UAWebViewCallData CallData (NSUrl url, UIWebView webView, [NullAllowed] UAInboxMessage message);

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable arguments;
		[NullAllowed, Export ("arguments", ArgumentSemantic.Strong)]
		string[] Arguments { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nullable options;
		[NullAllowed, Export ("options", ArgumentSemantic.Strong)]
		NSDictionary Options { get; set; }

		// @property (nonatomic, strong) UIWebView * _Nonnull webView;
		[Export ("webView", ArgumentSemantic.Strong)]
		UIWebView WebView { get; set; }

		// @property (nonatomic, strong) NSURL * _Nonnull url;
		[Export ("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; set; }

		// @property (nonatomic, strong) UAInboxMessage * _Nullable message;
		[NullAllowed, Export ("message", ArgumentSemantic.Strong)]
		UAInboxMessage Message { get; set; }
	}

	// @protocol UARichContentWindow <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UARichContentWindow
	{
		// @optional -(void)closeWebView:(UIWebView * _Nonnull)webView animated:(BOOL)animated;
		[Export ("closeWebView:animated:")]
		void Close (UIWebView webView, bool animated);
	}

	// @interface UAWebViewDelegate : NSObject <UIWebViewDelegate, UARichContentWindow>
	[BaseType (typeof(NSObject))]
	interface UAWebViewDelegate : IUIWebViewDelegate, UARichContentWindow
	{
		[Wrap ("WeakForwardDelegate")]
		[NullAllowed]
		UIWebViewDelegate ForwardDelegate { get; set; }

		// @property (nonatomic, weak) id<UIWebViewDelegate> _Nullable forwardDelegate;
		[NullAllowed, Export ("forwardDelegate", ArgumentSemantic.Weak)]
		NSObject WeakForwardDelegate { get; set; }

		// @property (nonatomic, weak) id<UARichContentWindow> _Nullable richContentWindow;
		[NullAllowed, Export ("richContentWindow", ArgumentSemantic.Weak)]
		UARichContentWindow RichContentWindow { get; set; }
	}

	// @interface UAActionResult : NSObject
	[BaseType (typeof(NSObject))]
	interface UAActionResult
	{
		// @property (readonly, nonatomic, strong) id _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		NSObject Value { get; }

		// @property (readonly, assign, nonatomic) UAActionFetchResult fetchResult;
		[Export ("fetchResult", ArgumentSemantic.Assign)]
		UAActionFetchResult FetchResult { get; }

		// @property (readonly, nonatomic, strong) NSError * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Strong)]
		NSError Error { get; }

		// @property (readonly, assign, nonatomic) UAActionStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		UAActionStatus Status { get; }

		// +(instancetype _Nonnull)resultWithValue:(id _Nullable)value;
		[Static]
		[Export ("resultWithValue:")]
		UAActionResult Result ([NullAllowed] NSObject value);

		// +(instancetype _Nonnull)resultWithValue:(id _Nullable)result withFetchResult:(UAActionFetchResult)fetchResult;
		[Static]
		[Export ("resultWithValue:withFetchResult:")]
		UAActionResult Result ([NullAllowed] NSObject result, UAActionFetchResult fetchResult);

		// +(instancetype _Nonnull)emptyResult;
		[Static]
		[Export ("emptyResult")]
		UAActionResult EmptyResult ();

		// +(instancetype _Nonnull)resultWithError:(NSError * _Nonnull)error;
		[Static]
		[Export ("resultWithError:")]
		UAActionResult Result (NSError error);

		// +(instancetype _Nonnull)resultWithError:(NSError * _Nonnull)error withFetchResult:(UAActionFetchResult)fetchResult;
		[Static]
		[Export ("resultWithError:withFetchResult:")]
		UAActionResult Result (NSError error, UAActionFetchResult fetchResult);
	}

	// @interface UAActionArguments : NSObject
	[BaseType (typeof(NSObject))]
	interface UAActionArguments
	{
		// +(instancetype _Nonnull)argumentsWithValue:(id _Nullable)value withSituation:(UASituation)situation;
		[Static]
		[Export ("argumentsWithValue:withSituation:")]
		UAActionArguments Arguments ([NullAllowed] NSObject value, UASituation situation);

		// +(instancetype _Nonnull)argumentsWithValue:(id _Nullable)value withSituation:(UASituation)situation metadata:(NSDictionary * _Nullable)metadata;
		[Static]
		[Export ("argumentsWithValue:withSituation:metadata:")]
		UAActionArguments Arguments ([NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata);

		// @property (readonly, assign, nonatomic) UASituation situation;
		[Export ("situation", ArgumentSemantic.Assign)]
		UASituation Situation { get; }

		// @property (readonly, nonatomic, strong) id _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Strong)]
		NSObject Value { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nullable metadata;
		[NullAllowed, Export ("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; }
	}

	// typedef BOOL (^UAActionPredicate)(UAActionArguments * _Nonnull);
	delegate bool UAActionPredicate (UAActionArguments arg0);

	// typedef void (^UAActionCompletionHandler)(UAActionResult * _Nonnull);
	delegate void UAActionCompletionHandler (UAActionResult arg0);

	// typedef void (^UAActionBlock)(UAActionArguments * _Nonnull, UAActionCompletionHandler _Nonnull);
	delegate void UAActionBlock (UAActionArguments arg0, UAActionCompletionHandler arg1);

	// @interface UAAction : NSObject
	[BaseType (typeof(NSObject))]
	interface UAAction
	{
		// -(BOOL)acceptsArguments:(UAActionArguments * _Nonnull)arguments;
		[Export ("acceptsArguments:")]
		bool AcceptsArguments (UAActionArguments arguments);

		// -(void)willPerformWithArguments:(UAActionArguments * _Nonnull)arguments;
		[Export ("willPerformWithArguments:")]
		void WillPerform (UAActionArguments arguments);

		// -(void)didPerformWithArguments:(UAActionArguments * _Nonnull)arguments withResult:(UAActionResult * _Nonnull)result;
		[Export ("didPerformWithArguments:withResult:")]
		void DidPerform (UAActionArguments arguments, UAActionResult result);

		// -(void)performWithArguments:(UAActionArguments * _Nonnull)arguments completionHandler:(UAActionCompletionHandler _Nonnull)completionHandler;
		[Export ("performWithArguments:completionHandler:")]
		void Perform (UAActionArguments arguments, UAActionCompletionHandler completionHandler);

		// +(instancetype _Nonnull)actionWithBlock:(UAActionBlock _Nonnull)actionBlock;
		[Static]
		[Export ("actionWithBlock:")]
		UAAction Action (UAActionBlock actionBlock);

		// +(instancetype _Nonnull)actionWithBlock:(UAActionBlock _Nonnull)actionBlock acceptingArguments:(UAActionPredicate _Nullable)predicateBlock;
		[Static]
		[Export ("actionWithBlock:acceptingArguments:")]
		UAAction Action (UAActionBlock actionBlock, [NullAllowed] UAActionPredicate predicateBlock);
	}

	// @interface UALandingPageAction : UAAction
	[BaseType (typeof(UAAction))]
	interface UALandingPageAction
	{
	}

	// @interface UAActionRegistryEntry : NSObject
	[BaseType (typeof(NSObject))]
	interface UAActionRegistryEntry
	{
		// @property (nonatomic, strong) UAAction * _Nonnull action;
		[Export ("action", ArgumentSemantic.Strong)]
		UAAction Action { get; set; }

		// @property (copy, nonatomic) UAActionPredicate _Nullable predicate;
		[NullAllowed, Export ("predicate", ArgumentSemantic.Copy)]
		UAActionPredicate Predicate { get; set; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull names;
		[Export ("names")]
		string[] Names { get; }

		// -(UAAction * _Nonnull)actionForSituation:(UASituation)situation;
		[Export ("actionForSituation:")]
		UAAction ActionForSituation (UASituation situation);

		// +(instancetype _Nonnull)entryForAction:(UAAction * _Nonnull)action predicate:(UAActionPredicate _Nonnull)predicate;
		[Static]
		[Export ("entryForAction:predicate:")]
		UAActionRegistryEntry EntryForAction (UAAction action, UAActionPredicate predicate);
	}

	// @interface UAActionRegistry : NSObject
	[BaseType (typeof(NSObject))]
	interface UAActionRegistry
	{
		// @property (readonly, nonatomic) NSSet<NSMutableDictionary *> * _Nonnull registeredEntries;
		[Export ("registeredEntries")]
		NSSet<NSMutableDictionary> RegisteredEntries { get; }

		// +(instancetype _Nonnull)defaultRegistry;
		[Static]
		[Export ("defaultRegistry")]
		UAActionRegistry DefaultRegistry ();

		// -(BOOL)registerAction:(UAAction * _Nonnull)action name:(NSString * _Nonnull)name predicate:(UAActionPredicate _Nullable)predicate;
		[Export ("registerAction:name:predicate:")]
		bool RegisterAction (UAAction action, string name, [NullAllowed] UAActionPredicate predicate);

		// -(BOOL)registerAction:(UAAction * _Nonnull)action names:(NSArray * _Nonnull)names predicate:(UAActionPredicate _Nullable)predicate;
		[Export ("registerAction:names:predicate:")]
		bool RegisterAction (UAAction action, NSString[] names, [NullAllowed] UAActionPredicate predicate);

		// -(BOOL)registerAction:(UAAction * _Nonnull)action name:(NSString * _Nonnull)name;
		[Export ("registerAction:name:")]
		bool RegisterAction (UAAction action, string name);

		// -(BOOL)registerAction:(UAAction * _Nonnull)action names:(NSArray * _Nonnull)names;
		[Export ("registerAction:names:")]
		bool RegisterAction (UAAction action, NSString[] names);

		// -(UAActionRegistryEntry * _Nullable)registryEntryWithName:(NSString * _Nonnull)name;
		[Export ("registryEntryWithName:")]
		[return: NullAllowed]
		UAActionRegistryEntry RegistryEntryWithName (string name);

		// -(BOOL)addSituationOverride:(UASituation)situation forEntryWithName:(NSString * _Nonnull)name action:(UAAction * _Nullable)action;
		[Export ("addSituationOverride:forEntryWithName:action:")]
		bool AddSituationOverride (UASituation situation, string name, [NullAllowed] UAAction action);

		// -(BOOL)updatePredicate:(UAActionPredicate _Nullable)predicate forEntryWithName:(NSString * _Nonnull)name;
		[Export ("updatePredicate:forEntryWithName:")]
		bool UpdatePredicate ([NullAllowed] UAActionPredicate predicate, string name);

		// -(BOOL)updateAction:(UAAction * _Nonnull)action forEntryWithName:(NSString * _Nonnull)name;
		[Export ("updateAction:forEntryWithName:")]
		bool UpdateAction (UAAction action, string name);

		// -(BOOL)removeName:(NSString * _Nonnull)name;
		[Export ("removeName:")]
		bool RemoveName (string name);

		// -(BOOL)removeEntryWithName:(NSString * _Nonnull)name;
		[Export ("removeEntryWithName:")]
		bool RemoveEntryWithName (string name);

		// -(BOOL)addName:(NSString * _Nonnull)name forEntryWithName:(NSString * _Nonnull)entryName;
		[Export ("addName:forEntryWithName:")]
		bool AddName (string name, string entryName);
	}

	// @interface UAAggregateActionResult : UAActionResult
	[BaseType (typeof(UAActionResult))]
	interface UAAggregateActionResult
	{
		// -(void)addResult:(UAActionResult * _Nonnull)result forAction:(NSString * _Nonnull)actionName;
		[Export ("addResult:forAction:")]
		void AddResult (UAActionResult result, string actionName);

		// -(UAActionResult * _Nonnull)resultForAction:(NSString * _Nonnull)actionName;
		[Export ("resultForAction:")]
		UAActionResult ResultForAction (string actionName);
	}

	// @interface UAActionRunner : NSObject
	[BaseType (typeof(NSObject))]
	interface UAActionRunner
	{
		// +(void)runActionWithName:(NSString * _Nonnull)actionName value:(id _Nullable)value situation:(UASituation)situation;
		[Static]
		[Export ("runActionWithName:value:situation:")]
		void RunAction (string actionName, [NullAllowed] NSObject value, UASituation situation);

		// +(void)runActionWithName:(NSString * _Nonnull)actionName value:(id _Nullable)value situation:(UASituation)situation metadata:(NSDictionary * _Nonnull)metadata;
		[Static]
		[Export ("runActionWithName:value:situation:metadata:")]
		void RunAction (string actionName, [NullAllowed] NSObject value, UASituation situation, NSDictionary metadata);

		// +(void)runActionWithName:(NSString * _Nonnull)actionName value:(id _Nullable)value situation:(UASituation)situation completionHandler:(UAActionCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export ("runActionWithName:value:situation:completionHandler:")]
		void RunAction (string actionName, [NullAllowed] NSObject value, UASituation situation, UAActionCompletionHandler completionHandler);

		// +(void)runActionWithName:(NSString * _Nonnull)actionName value:(id _Nullable)value situation:(UASituation)situation metadata:(NSDictionary * _Nullable)metadata completionHandler:(UAActionCompletionHandler _Nullable)completionHandler;
		[Static]
		[Export ("runActionWithName:value:situation:metadata:completionHandler:")]
		void RunAction (string actionName, [NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata, [NullAllowed] UAActionCompletionHandler completionHandler);

		// +(void)runAction:(UAAction * _Nonnull)action value:(id _Nullable)value situation:(UASituation)situation;
		[Static]
		[Export ("runAction:value:situation:")]
		void RunAction (UAAction action, [NullAllowed] NSObject value, UASituation situation);

		// +(void)runAction:(UAAction * _Nonnull)action value:(id _Nullable)value situation:(UASituation)situation metadata:(NSDictionary * _Nullable)metadata;
		[Static]
		[Export ("runAction:value:situation:metadata:")]
		void RunAction (UAAction action, [NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata);

		// +(void)runAction:(UAAction * _Nonnull)action value:(id _Nullable)value situation:(UASituation)situation completionHandler:(UAActionCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export ("runAction:value:situation:completionHandler:")]
		void RunAction (UAAction action, [NullAllowed] NSObject value, UASituation situation, UAActionCompletionHandler completionHandler);

		// +(void)runAction:(UAAction * _Nonnull)action value:(id _Nullable)value situation:(UASituation)situation metadata:(NSDictionary * _Nullable)metadata completionHandler:(UAActionCompletionHandler _Nullable)completionHandler;
		[Static]
		[Export ("runAction:value:situation:metadata:completionHandler:")]
		void RunAction (UAAction action, [NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata, [NullAllowed] UAActionCompletionHandler completionHandler);
	}

	// @interface UAAddCustomEventAction : UAAction
	[BaseType (typeof(UAAction))]
	interface UAAddCustomEventAction
	{
	}

	// @interface UAModifyTagsAction : UAAction
	[BaseType (typeof(UAAction))]
	interface UAModifyTagsAction
	{
      // -(void)applyChannelTags:(NSArray *)tags;
      [Export ("applyChannelTags:")]
      void ApplyChannelTags (string[] tags);

      // -(void)applyChannelTags:(NSArray *)tags group:(NSString *)group;
      [Export ("applyChannelTags:group:")]
      void ApplyChannelTags (string[] tags, string group);

      // -(void)applyNamedUserTags:(NSArray *)tags group:(NSString *)group;
      [Export ("applyNamedUserTags:group:")]
      void ApplyNamedUserTags (string[] tags, string group);
	}

	// @interface UAAddTagsAction : UAModifyTagsAction
	[BaseType (typeof(UAModifyTagsAction))]
	interface UAAddTagsAction
	{
	}

	// @interface UACloseWindowAction : UAAction
	[BaseType (typeof(UAAction))]
	interface UACloseWindowAction
	{
	}

	// @interface UADisplayInboxAction : UAAction
	[BaseType (typeof(UAAction))]
	interface UADisplayInboxAction
	{
	}

	// @interface UAOpenExternalURLAction : UAAction
	[BaseType (typeof(UAAction))]
	interface UAOpenExternalURLAction
	{
	}

	// @interface UAOverlayInboxMessageAction : UAAction
	[BaseType (typeof(UAAction))]
	interface UAOverlayInboxMessageAction
	{
	}

	// @interface UAPasteboardAction : UAAction
	[BaseType (typeof(UAAction))]
	interface UAPasteboardAction
	{
	}

	// @interface UARemoveTagsAction : UAModifyTagsAction
	[BaseType (typeof(UAModifyTagsAction))]
	interface UARemoveTagsAction
	{
	}

	// @interface UAShareAction : UAAction
	[BaseType (typeof(UAAction))]
	interface UAShareAction
	{
	}

	// @interface UACancelSchedulesAction : UAAction
	[BaseType(typeof(UAAction))]
	interface UACancelSchedulesAction
	{
	}

	// @interface UAActionSchedule : NSObject
	[BaseType(typeof(NSObject))]
	interface UAActionSchedule
	{
		// @property (readonly, nonatomic) NSString * _Nonnull identifier;
		[Export("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic) UAActionScheduleInfo * _Nonnull info;
		[Export("info")]
		UAActionScheduleInfo Info { get; }

		// -(BOOL)isEqualToSchedule:(UAActionSchedule * _Nullable)schedule;
		[Export("isEqualToSchedule:")]
		bool IsEqual([NullAllowed] UAActionSchedule schedule);
	}

	// @interface UAActionScheduleInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface UAActionScheduleInfo
	{
		// @property (readonly, nonatomic) NSDictionary * _Nonnull actions;
		[Export("actions")]
		NSDictionary Actions { get; }

		// @property (readonly, nonatomic) NSArray<UAScheduleTrigger *> * _Nonnull triggers;
		[Export("triggers")]
		UAScheduleTrigger[] Triggers { get; }

		// @property (readonly, nonatomic) NSUInteger limit;
		[Export("limit")]
		nuint Limit { get; }

		// @property (readonly, nonatomic) NSString * _Nullable group;
		[NullAllowed, Export("group")]
		string Group { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull start;
		[Export("start")]
		NSDate Start { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull end;
		[Export("end")]
		NSDate End { get; }

		// @property (readonly, nonatomic) BOOL isValid;
		[Export("isValid")]
		bool IsValid { get; }

		// +(instancetype _Nonnull)actionScheduleInfoWithBuilderBlock:(void (^ _Nonnull)(UAActionScheduleInfoBuilder * _Nonnull))builderBlock;
		[Static]
		[Export("actionScheduleInfoWithBuilderBlock:")]
		UAActionScheduleInfo ActionScheduleInfo(Action<UAActionScheduleInfoBuilder> builderBlock);

		// -(BOOL)isEqualToScheduleInfo:(UAActionScheduleInfo * _Nullable)scheduleInfo;
		[Export("isEqualToScheduleInfo:")]
		bool IsEqual([NullAllowed] UAActionScheduleInfo scheduleInfo);

		// +(instancetype _Nullable)actionScheduleInfoWithJSON:(id _Nonnull)json error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("actionScheduleInfoWithJSON:error:")]
		[return: NullAllowed]
		UAActionScheduleInfo ActionScheduleInfo(NSObject json, [NullAllowed] out NSError error);
	}

	// @interface UAActionScheduleInfoBuilder : NSObject
	[BaseType(typeof(NSObject))]
	interface UAActionScheduleInfoBuilder
	{
		// @property (nonatomic, strong) NSDictionary * _Nullable actions;
		[NullAllowed, Export("actions", ArgumentSemantic.Strong)]
		NSDictionary Actions { get; set; }

		// @property (assign, nonatomic) NSUInteger limit;
		[Export("limit")]
		nuint Limit { get; set; }

		// @property (nonatomic, strong) NSArray<UAScheduleTrigger *> * _Nullable triggers;
		[NullAllowed, Export("triggers", ArgumentSemantic.Strong)]
		UAScheduleTrigger[] Triggers { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable group;
		[NullAllowed, Export("group")]
		string Group { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable start;
		[NullAllowed, Export("start", ArgumentSemantic.Strong)]
		NSDate Start { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable end;
		[NullAllowed, Export("end", ArgumentSemantic.Strong)]
		NSDate End { get; set; }
	}

	// @interface UAScheduleTrigger : NSObject
	[BaseType(typeof(NSObject))]
	interface UAScheduleTrigger
	{
		// @property (readonly, nonatomic) UAScheduleTriggerType type;
		[Export("type")]
		UAScheduleTriggerType Type { get; }

		// @property (readonly, nonatomic) NSNumber * _Nonnull goal;
		[Export("goal")]
		NSNumber Goal { get; }

		// +(instancetype _Nonnull)foregroundTriggerWithCount:(NSUInteger)count;
		[Static]
		[Export("foregroundTriggerWithCount:")]
		UAScheduleTrigger ForegroundTrigger(nuint count);

		// +(instancetype _Nonnull)backgroundTriggerWithCount:(NSUInteger)count;
		[Static]
		[Export("backgroundTriggerWithCount:")]
		UAScheduleTrigger BackgroundTrigger(nuint count);

		// +(instancetype _Nonnull)regionEnterTriggerForRegionID:(NSString * _Nonnull)regionID count:(NSUInteger)count;
		[Static]
		[Export("regionEnterTriggerForRegionID:count:")]
		UAScheduleTrigger RegionEnterTrigger(string regionID, nuint count);

		// +(instancetype _Nonnull)regionExitTriggerForRegionID:(NSString * _Nonnull)regionID count:(NSUInteger)count;
		[Static]
		[Export("regionExitTriggerForRegionID:count:")]
		UAScheduleTrigger RegionExitTrigger(string regionID, nuint count);

		// +(instancetype _Nonnull)screenTriggerForScreenName:(NSString * _Nonnull)screenName count:(NSUInteger)count;
		[Static]
		[Export("screenTriggerForScreenName:count:")]
		UAScheduleTrigger ScreenTrigger(string screenName, nuint count);

		// +(instancetype _Nonnull)customEventTriggerWithPredicate:(UAJSONPredicate * _Nonnull)predicate count:(NSUInteger)count;
		[Static]
		[Export("customEventTriggerWithPredicate:count:")]
		UAScheduleTrigger CustomEventTrigger(UAJSONPredicate predicate, nuint count);

		// +(instancetype _Nonnull)customEventTriggerWithPredicate:(UAJSONPredicate * _Nonnull)predicate value:(NSNumber * _Nonnull)value;
		[Static]
		[Export("customEventTriggerWithPredicate:value:")]
		UAScheduleTrigger CustomEventTrigger(UAJSONPredicate predicate, NSNumber value);

		// -(BOOL)isEqualToTrigger:(UAScheduleTrigger * _Nullable)trigger;
		[Export("isEqualToTrigger:")]
		bool IsEqual([NullAllowed] UAScheduleTrigger trigger);

		// +(instancetype _Nullable)triggerWithJSON:(id _Nonnull)json error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("triggerWithJSON:error:")]
		[return: NullAllowed]
		UAScheduleTrigger Trigger(NSObject json, [NullAllowed] out NSError error);
	}

	// @interface UAJSONMatcher : NSObject
	[BaseType(typeof(NSObject))]
	interface UAJSONMatcher
	{
		// @property (readonly, nonatomic) NSDictionary * _Nonnull payload;
		[Export("payload")]
		NSDictionary Payload { get; }

		// -(BOOL)evaluateObject:(id _Nullable)object;
		[Export("evaluateObject:")]
		bool EvaluateObject([NullAllowed] NSObject @object);

		// +(instancetype _Nonnull)matcherWithValueMatcher:(UAJSONValueMatcher * _Nonnull)valueMatcher;
		[Static]
		[Export("matcherWithValueMatcher:")]
		UAJSONMatcher Matcher(UAJSONValueMatcher valueMatcher);

		// +(instancetype _Nonnull)matcherWithValueMatcher:(UAJSONValueMatcher * _Nonnull)valueMatcher key:(NSString * _Nonnull)key;
		[Static]
		[Export("matcherWithValueMatcher:key:")]
		UAJSONMatcher Matcher(UAJSONValueMatcher valueMatcher, string key);

		// +(instancetype _Nonnull)matcherWithValueMatcher:(UAJSONValueMatcher * _Nonnull)valueMatcher key:(NSString * _Nonnull)key scope:(NSArray<NSString *> * _Nonnull)scope;
		[Static]
		[Export("matcherWithValueMatcher:key:scope:")]
		UAJSONMatcher Matcher(UAJSONValueMatcher valueMatcher, string key, string[] scope);

		// +(instancetype _Nullable)matcherWithJSON:(id _Nonnull)json error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("matcherWithJSON:error:")]
		[return: NullAllowed]
		UAJSONMatcher Matcher(NSObject json, [NullAllowed] out NSError error);
	}

	// @interface UAJSONValueMatcher : NSObject
	[BaseType(typeof(NSObject))]
	interface UAJSONValueMatcher
	{
		// @property (readonly, nonatomic) NSDictionary * _Nonnull payload;
		[Export("payload")]
		NSDictionary Payload { get; }

		// -(BOOL)evaluateObject:(id _Nullable)object;
		[Export("evaluateObject:")]
		bool EvaluateObject([NullAllowed] NSObject @object);

		// +(instancetype _Nonnull)matcherWhereNumberAtLeast:(NSNumber * _Nonnull)number;
		[Static]
		[Export("matcherWhereNumberAtLeast:")]
		UAJSONValueMatcher MatcherWhereNumberAtLeast(NSNumber number);

		// +(instancetype _Nonnull)matcherWhereNumberAtLeast:(NSNumber * _Nonnull)lowerNumber atMost:(NSNumber * _Nonnull)higherNumber;
		[Static]
		[Export("matcherWhereNumberAtLeast:atMost:")]
		UAJSONValueMatcher MatcherWhereNumberAtLeast(NSNumber lowerNumber, NSNumber higherNumber);

		// +(instancetype _Nonnull)matcherWhereNumberAtMost:(NSNumber * _Nonnull)number;
		[Static]
		[Export("matcherWhereNumberAtMost:")]
		UAJSONValueMatcher MatcherWhereNumberAtMost(NSNumber number);

		// +(instancetype _Nonnull)matcherWhereNumberEquals:(NSNumber * _Nonnull)number;
		[Static]
		[Export("matcherWhereNumberEquals:")]
		UAJSONValueMatcher MatcherWhereNumberEquals(NSNumber number);

		// +(instancetype _Nonnull)matcherWhereStringEquals:(NSString * _Nonnull)string;
		[Static]
		[Export("matcherWhereStringEquals:")]
		UAJSONValueMatcher MatcherWhereStringEquals(string @string);

		// +(instancetype _Nonnull)matcherWhereValueIsPresent:(BOOL)present;
		[Static]
		[Export("matcherWhereValueIsPresent:")]
		UAJSONValueMatcher MatcherWhereValueIsPresent(bool present);

		// +(instancetype _Nullable)matcherWithJSON:(id _Nonnull)json error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("matcherWithJSON:error:")]
		[return: NullAllowed]
		UAJSONValueMatcher Matcher(NSObject json, [NullAllowed] out NSError error);
	}

	// @interface UAJSONPredicate : NSObject
	[BaseType(typeof(NSObject))]
	interface UAJSONPredicate
	{
		// @property (readonly, nonatomic) NSDictionary * _Nonnull payload;
		[Export("payload")]
		NSDictionary Payload { get; }

		// -(BOOL)evaluateObject:(id _Nullable)object;
		[Export("evaluateObject:")]
		bool EvaluateObject([NullAllowed] NSObject @object);

		// +(instancetype _Nonnull)predicateWithJSONMatcher:(UAJSONMatcher * _Nonnull)matcher;
		[Static]
		[Export("predicateWithJSONMatcher:")]
		UAJSONPredicate Predicate(UAJSONMatcher matcher);

		// +(instancetype _Nonnull)andPredicateWithSubpredicates:(NSArray<UAJSONPredicate *> * _Nonnull)subpredicates;
		[Static]
		[Export("andPredicateWithSubpredicates:")]
		UAJSONPredicate AndPredicate(UAJSONPredicate[] subpredicates);

		// +(instancetype _Nonnull)orPredicateWithSubpredicates:(NSArray<UAJSONPredicate *> * _Nonnull)subpredicates;
		[Static]
		[Export("orPredicateWithSubpredicates:")]
		UAJSONPredicate OrPredicate(UAJSONPredicate[] subpredicates);

		// +(instancetype _Nonnull)notPredicateWithSubpredicate:(UAJSONPredicate * _Nonnull)subpredicate;
		[Static]
		[Export("notPredicateWithSubpredicate:")]
		UAJSONPredicate NotPredicate(UAJSONPredicate subpredicate);

		// +(instancetype _Nullable)predicateWithJSON:(id _Nonnull)json error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("predicateWithJSON:error:")]
		[return: NullAllowed]
		UAJSONPredicate Predicate(NSObject json, [NullAllowed] out NSError error);
	}

	// @interface UAAutomation : NSObject
	[BaseType(typeof(NSObject))]
	interface UAAutomation
	{
		// -(void)scheduleActions:(UAActionScheduleInfo * _Nonnull)scheduleInfo completionHandler:(void (^ _Nullable)(UAActionSchedule * _Nullable))completionHandler;
		[Export("scheduleActions:completionHandler:")]
		void ScheduleActions(UAActionScheduleInfo scheduleInfo, [NullAllowed] Action<UAActionSchedule> completionHandler);

		// -(void)cancelScheduleWithIdentifier:(NSString * _Nonnull)identifier;
		[Export("cancelScheduleWithIdentifier:")]
		void CancelSchedule(string identifier);

		// -(void)cancelSchedulesWithGroup:(NSString * _Nonnull)group;
		[Export("cancelSchedulesWithGroup:")]
		void CancelSchedules(string group);

		// -(void)cancelAll;
		[Export("cancelAll")]
		void CancelAll();

		// -(void)getScheduleWithIdentifier:(NSString * _Nonnull)identifier completionHandler:(void (^ _Nonnull)(UAActionSchedule * _Nullable))completionHandler;
		[Export("getScheduleWithIdentifier:completionHandler:")]
		void GetSchedule(string identifier, Action<UAActionSchedule> completionHandler);

		// -(void)getSchedules:(void (^ _Nonnull)(NSArray<UAActionSchedule *> * _Nonnull))completionHandler;
		[Export("getSchedules:")]
		void GetSchedules(Action<NSArray> completionHandler);

		// -(void)getSchedulesWithGroup:(NSString * _Nonnull)group completionHandler:(void (^ _Nonnull)(NSArray<UAActionSchedule *> * _Nonnull))completionHandler;
		[Export("getSchedulesWithGroup:completionHandler:")]
		void GetSchedules(string group, Action<NSArray> completionHandler);
	}

	// @interface UAEvent : NSObject
	[BaseType (typeof(NSObject))]
	interface UAEvent
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull time;
		[Export ("time")]
		string Time { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull eventID;
		[Export ("eventID")]
		string EventID { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nonnull data;
		[Export ("data", ArgumentSemantic.Strong)]
		NSDictionary Data { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull eventType;
		[Export ("eventType")]
		string EventType { get; }

		// -(BOOL)isValid;
		[Export ("isValid")]
		bool IsValid { get; }
	}

	// @interface UACustomEvent : UAEvent
	[BaseType (typeof(UAEvent))]
	interface UACustomEvent
	{
		// +(instancetype _Nonnull)eventWithName:(NSString * _Nonnull)eventName;
		[Static]
		[Export ("eventWithName:")]
		UACustomEvent Event (string eventName);

		// +(instancetype _Nonnull)eventWithName:(NSString * _Nonnull)eventName valueFromString:(NSString * _Nullable)eventValue;
		[Static]
		[Export ("eventWithName:valueFromString:")]
		UACustomEvent Event (string eventName, [NullAllowed] string eventValue);

		// +(instancetype _Nonnull)eventWithName:(NSString * _Nonnull)eventName value:(NSNumber * _Nullable)eventValue;
		[Static]
		[Export ("eventWithName:value:")]
		UACustomEvent Event (string eventName, [NullAllowed] NSNumber eventValue);

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable eventValue;
		[NullAllowed, Export ("eventValue", ArgumentSemantic.Strong)]
		NSDecimalNumber EventValue { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull eventName;
		[Export ("eventName")]
		string EventName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable interactionID;
		[NullAllowed, Export ("interactionID")]
		string InteractionID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable interactionType;
		[NullAllowed, Export ("interactionType")]
		string InteractionType { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable transactionID;
		[NullAllowed, Export ("transactionID")]
		string TransactionID { get; set; }

		// -(void)setInteractionFromMessage:(UAInboxMessage * _Nonnull)message;
		[Export ("setInteractionFromMessage:")]
		void SetInteractionFromMessage (UAInboxMessage message);

		// -(void)setBoolProperty:(BOOL)value forKey:(NSString * _Nonnull)key;
		[Export ("setBoolProperty:forKey:")]
		void SetBoolProperty (bool value, string key);

		// -(void)setStringProperty:(NSString * _Nonnull)value forKey:(NSString * _Nonnull)key;
		[Export ("setStringProperty:forKey:")]
		void SetStringProperty (string value, string key);

		// -(void)setNumberProperty:(NSNumber * _Nonnull)value forKey:(NSString * _Nonnull)key;
		[Export ("setNumberProperty:forKey:")]
		void SetNumberProperty (NSNumber value, string key);

		// -(void)setStringArrayProperty:(NSArray<NSString *> * _Nonnull)value forKey:(NSString * _Nonnull)key;
		[Export ("setStringArrayProperty:forKey:")]
		void SetStringArrayProperty (string[] value, string key);

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull properties;
		[Export("properties", ArgumentSemantic.Copy)]
		NSDictionary Properties { get; }

		// -(void)track;
		[Export("track")]
		void Track();
	}

	// @interface UAAccountEventTemplate : NSObject
	[BaseType(typeof(NSObject))]
	interface UAAccountEventTemplate
	{
		// +(instancetype _Nonnull)registeredTemplate;
		[Static]
		[Export("registeredTemplate")]
		UAAccountEventTemplate RegisteredTemplate();

		// +(instancetype _Nonnull)registeredTemplateWithValueFromString:(NSString * _Nullable)eventValue;
		[Static]
		[Export("registeredTemplateWithValueFromString:")]
		UAAccountEventTemplate RegisteredTemplate([NullAllowed] string eventValue);

		// +(instancetype _Nonnull)registeredTemplateWithValue:(NSNumber * _Nullable)eventValue;
		[Static]
		[Export("registeredTemplateWithValue:")]
		UAAccountEventTemplate RegisteredTemplate([NullAllowed] NSNumber eventValue);

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable eventValue;
		[NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
		NSDecimalNumber EventValue { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable transactionID;
		[NullAllowed, Export("transactionID")]
		string TransactionID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable category;
		[NullAllowed, Export("category")]
		string Category { get; set; }

		// -(UACustomEvent * _Nonnull)createEvent;
		[Export("createEvent")]
		UACustomEvent CreateEvent ();
	}

	// @interface UAMediaEventTemplate : NSObject
	[BaseType(typeof(NSObject))]
	interface UAMediaEventTemplate
	{
		// +(instancetype _Nonnull)browsedTemplate;
		[Static]
		[Export("browsedTemplate")]
		UAMediaEventTemplate BrowsedTemplate();

		// +(instancetype _Nonnull)starredTemplate;
		[Static]
		[Export("starredTemplate")]
		UAMediaEventTemplate StarredTemplate();

		// +(instancetype _Nonnull)sharedTemplate;
		[Static]
		[Export("sharedTemplate")]
		UAMediaEventTemplate SharedTemplate();

		// +(instancetype _Nonnull)sharedTemplateWithSource:(NSString * _Nullable)source withMedium:(NSString * _Nullable)medium;
		[Static]
		[Export("sharedTemplateWithSource:withMedium:")]
		UAMediaEventTemplate SharedTemplate([NullAllowed] string source, [NullAllowed] string medium);

		// +(instancetype _Nonnull)consumedTemplate;
		[Static]
		[Export("consumedTemplate")]
		UAMediaEventTemplate ConsumedTemplate();

		// +(instancetype _Nonnull)consumedTemplateWithValueFromString:(NSString * _Nullable)eventValue;
		[Static]
		[Export("consumedTemplateWithValueFromString:")]
		UAMediaEventTemplate ConsumedTemplate([NullAllowed] string eventValue);

		// +(instancetype _Nonnull)consumedTemplateWithValue:(NSNumber * _Nullable)eventValue;
		[Static]
		[Export("consumedTemplateWithValue:")]
		UAMediaEventTemplate ConsumedTemplate([NullAllowed] NSNumber eventValue);

		// @property (copy, nonatomic) NSString * _Nullable identifier;
		[NullAllowed, Export("identifier")]
		string Identifier { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable category;
		[NullAllowed, Export("category")]
		string Category { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable type;
		[NullAllowed, Export("type")]
		string Type { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable eventDescription;
		[NullAllowed, Export("eventDescription")]
		string EventDescription { get; set; }

		// @property (assign, nonatomic) BOOL isFeature;
		[Export("isFeature")]
		bool IsFeature { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable author;
		[NullAllowed, Export("author")]
		string Author { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable publishedDate;
		[NullAllowed, Export("publishedDate")]
		string PublishedDate { get; set; }

		// -(UACustomEvent * _Nonnull)createEvent;
		[Export("createEvent")]
		UACustomEvent CreateEvent ();
	}

	// @interface UARetailEventTemplate : NSObject
	[BaseType(typeof(NSObject))]
	interface UARetailEventTemplate
	{
		// +(instancetype _Nonnull)browsedTemplate;
		[Static]
		[Export("browsedTemplate")]
		UARetailEventTemplate BrowsedTemplate();

		// +(instancetype _Nonnull)browsedTemplateWithValueFromString:(NSString * _Nullable)eventValue;
		[Static]
		[Export("browsedTemplateWithValueFromString:")]
		UARetailEventTemplate BrowsedTemplate([NullAllowed] string eventValue);

		// +(instancetype _Nonnull)browsedTemplateWithValue:(NSNumber * _Nullable)eventValue;
		[Static]
		[Export("browsedTemplateWithValue:")]
		UARetailEventTemplate BrowsedTemplate([NullAllowed] NSNumber eventValue);

		// +(instancetype _Nonnull)addedToCartTemplate;
		[Static]
		[Export("addedToCartTemplate")]
		UARetailEventTemplate AddedToCartTemplate();

		// +(instancetype _Nonnull)addedToCartTemplateWithValueFromString:(NSString * _Nullable)eventValue;
		[Static]
		[Export("addedToCartTemplateWithValueFromString:")]
		UARetailEventTemplate AddedToCartTemplate([NullAllowed] string eventValue);

		// +(instancetype _Nonnull)addedToCartTemplateWithValue:(NSNumber * _Nullable)eventValue;
		[Static]
		[Export("addedToCartTemplateWithValue:")]
		UARetailEventTemplate AddedToCartTemplate([NullAllowed] NSNumber eventValue);

		// +(instancetype _Nonnull)starredProductTemplate;
		[Static]
		[Export("starredProductTemplate")]
		UARetailEventTemplate StarredProductTemplate();

		// +(instancetype _Nonnull)starredProductTemplateWithValueFromString:(NSString * _Nullable)eventValue;
		[Static]
		[Export("starredProductTemplateWithValueFromString:")]
		UARetailEventTemplate StarredProductTemplate([NullAllowed] string eventValue);

		// +(instancetype _Nonnull)starredProductTemplateWithValue:(NSNumber * _Nullable)eventValue;
		[Static]
		[Export("starredProductTemplateWithValue:")]
		UARetailEventTemplate StarredProductTemplate([NullAllowed] NSNumber eventValue);

		// +(instancetype _Nonnull)purchasedTemplate;
		[Static]
		[Export("purchasedTemplate")]
		UARetailEventTemplate PurchasedTemplate();

		// +(instancetype _Nonnull)purchasedTemplateWithValueFromString:(NSString * _Nullable)eventValue;
		[Static]
		[Export("purchasedTemplateWithValueFromString:")]
		UARetailEventTemplate PurchasedTemplate([NullAllowed] string eventValue);

		// +(instancetype _Nonnull)purchasedTemplateWithValue:(NSNumber * _Nullable)eventValue;
		[Static]
		[Export("purchasedTemplateWithValue:")]
		UARetailEventTemplate PurchasedTemplate([NullAllowed] NSNumber eventValue);

		// +(instancetype _Nonnull)sharedProductTemplate;
		[Static]
		[Export("sharedProductTemplate")]
		UARetailEventTemplate SharedProductTemplate();

		// +(instancetype _Nonnull)sharedProductTemplateWithValueFromString:(NSString * _Nullable)eventValue;
		[Static]
		[Export("sharedProductTemplateWithValueFromString:")]
		UARetailEventTemplate SharedProductTemplate([NullAllowed] string eventValue);

		// +(instancetype _Nonnull)sharedProductTemplateWithValue:(NSNumber * _Nullable)eventValue;
		[Static]
		[Export("sharedProductTemplateWithValue:")]
		UARetailEventTemplate SharedProductTemplate([NullAllowed] NSNumber eventValue);

		// +(instancetype _Nonnull)sharedProductTemplateWithSource:(NSString * _Nullable)source withMedium:(NSString * _Nullable)medium;
		[Static]
		[Export("sharedProductTemplateWithSource:withMedium:")]
		UARetailEventTemplate SharedProductTemplate([NullAllowed] string source, [NullAllowed] string medium);

		// +(instancetype _Nonnull)sharedProductTemplateWithValueFromString:(NSString * _Nullable)eventValue withSource:(NSString * _Nullable)source withMedium:(NSString * _Nullable)medium;
		[Static]
		[Export("sharedProductTemplateWithValueFromString:withSource:withMedium:")]
		UARetailEventTemplate SharedProductTemplate([NullAllowed] string eventValue, [NullAllowed] string source, [NullAllowed] string medium);

		// +(instancetype _Nonnull)sharedProductTemplateWithValue:(NSNumber * _Nullable)eventValue withSource:(NSString * _Nullable)source withMedium:(NSString * _Nullable)medium;
		[Static]
		[Export("sharedProductTemplateWithValue:withSource:withMedium:")]
		UARetailEventTemplate SharedProductTemplate([NullAllowed] NSNumber eventValue, [NullAllowed] string source, [NullAllowed] string medium);

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable eventValue;
		[NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
		NSDecimalNumber EventValue { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable transactionID;
		[NullAllowed, Export("transactionID")]
		string TransactionID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable identifier;
		[NullAllowed, Export("identifier")]
		string Identifier { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable category;
		[NullAllowed, Export("category")]
		string Category { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable eventDescription;
		[NullAllowed, Export("eventDescription")]
		string EventDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable brand;
		[NullAllowed, Export("brand")]
		string Brand { get; set; }

		// @property (assign, nonatomic) BOOL isNewItem;
		[Export("isNewItem")]
		bool IsNewItem { get; set; }

		// -(UACustomEvent * _Nonnull)createEvent;
		[Export("createEvent")]
		UACustomEvent CreateEvent();
	}

	// @interface UARegionEvent : UAEvent
	[BaseType (typeof(UAEvent))]
	interface UARegionEvent
	{
		// @property (nonatomic, strong) UAProximityRegion * _Nullable proximityRegion;
		[NullAllowed, Export ("proximityRegion", ArgumentSemantic.Strong)]
		UAProximityRegion ProximityRegion { get; set; }

		// @property (nonatomic, strong) UACircularRegion * _Nullable circularRegion;
		[NullAllowed, Export ("circularRegion", ArgumentSemantic.Strong)]
		UACircularRegion CircularRegion { get; set; }

		// +(instancetype _Nullable)regionEventWithRegionID:(NSString * _Nonnull)regionID source:(NSString * _Nonnull)source boundaryEvent:(UABoundaryEvent)boundaryEvent;
		[Static]
		[Export ("regionEventWithRegionID:source:boundaryEvent:")]
		[return: NullAllowed]
		UARegionEvent RegionEvent (string regionID, string source, UABoundaryEvent boundaryEvent);
	}

	// @interface UACircularRegion : NSObject
	[BaseType (typeof(NSObject))]
	interface UACircularRegion
	{
		// +(instancetype _Nonnull)circularRegionWithRadius:(NSNumber * _Nonnull)radius latitude:(NSNumber * _Nonnull)latitude longitude:(NSNumber * _Nonnull)longitude;
		[Static]
		[Export ("circularRegionWithRadius:latitude:longitude:")]
		UACircularRegion CircularRegion (NSNumber radius, NSNumber latitude, NSNumber longitude);
	}

	// @interface UAProximityRegion : NSObject
	[BaseType (typeof(NSObject))]
	interface UAProximityRegion
	{
		// @property (nonatomic, strong) NSNumber * _Nullable latitude;
		[NullAllowed, Export ("latitude", ArgumentSemantic.Strong)]
		NSNumber Latitude { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable longitude;
		[NullAllowed, Export ("longitude", ArgumentSemantic.Strong)]
		NSNumber Longitude { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable RSSI;
		[NullAllowed, Export ("RSSI", ArgumentSemantic.Strong)]
		NSNumber RSSI { get; set; }

		// +(instancetype _Nullable)proximityRegionWithID:(NSString * _Nonnull)proximityID major:(NSNumber * _Nonnull)major minor:(NSNumber * _Nonnull)minor;
		[Static]
		[Export ("proximityRegionWithID:major:minor:")]
		[return: NullAllowed]
		UAProximityRegion ProximityRegion (string proximityID, NSNumber major, NSNumber minor);
	}

	// @interface UAAnalytics : NSObject
	[BaseType (typeof(NSObject))]
	interface UAAnalytics
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable conversionSendID;
		[NullAllowed, Export ("conversionSendID")]
		string ConversionSendID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable conversionPushMetadata;
		[NullAllowed, Export ("conversionPushMetadata")]
		string ConversionPushMetadata { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable conversionRichPushID;
		[NullAllowed, Export ("conversionRichPushID")]
		string ConversionRichPushID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sessionID;
		[NullAllowed, Export ("sessionID")]
		string SessionID { get; }

      // @property (readonly, nonatomic, strong) NSDate * _Nonnull lastSendTime;
      [Export ("lastSendTime", ArgumentSemantic.Strong)]
      NSDate LastSendTime { get; }

		// @property (getter = isEnabled, assign, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// -(void)addEvent:(UAEvent * _Nonnull)event;
		[Export ("addEvent:")]
		void AddEvent (UAEvent @event);

		// -(void)associateDeviceIdentifiers:(UAAssociatedIdentifiers * _Nonnull)associatedIdentifiers;
		[Export ("associateDeviceIdentifiers:")]
		void AssociateDeviceIdentifiers (UAAssociatedIdentifiers associatedIdentifiers);

		// -(UAAssociatedIdentifiers * _Nonnull)currentAssociatedDeviceIdentifiers;
		[Export ("currentAssociatedDeviceIdentifiers")]
		UAAssociatedIdentifiers CurrentAssociatedDeviceIdentifiers ();

		// -(void)trackScreen:(NSString * _Nullable)screen;
		[Export ("trackScreen:")]
		void TrackScreen ([NullAllowed] string screen);

      // -(void)scheduleUpload;
      [Export ("scheduleUpload")]
      void ScheduleUpload ();
	}

	// @interface UAAssociatedIdentifiers : NSObject
	[BaseType (typeof(NSObject))]
	interface UAAssociatedIdentifiers
	{
		// +(instancetype _Nonnull)identifiers;
		[Static]
		[Export ("identifiers")]
		UAAssociatedIdentifiers Identifiers ();

		// +(instancetype _Nonnull)identifiersWithDictionary:(NSDictionary<NSString *,NSString *> * _Nonnull)identifiers;
		[Static]
		[Export ("identifiersWithDictionary:")]
		UAAssociatedIdentifiers Identifiers (NSDictionary<NSString, NSString> identifiers);

		// @property (copy, nonatomic) NSString * _Nullable advertisingID;
		[NullAllowed, Export ("advertisingID")]
		string AdvertisingID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable vendorID;
		[NullAllowed, Export ("vendorID")]
		string VendorID { get; set; }

		// @property (readonly, nonatomic) NSDictionary * _Nonnull allIDs;
		[Export ("allIDs")]
		NSDictionary AllIDs { get; }

		// -(void)setIdentifier:(NSString * _Nullable)identifier forKey:(NSString * _Nonnull)key;
		[Export ("setIdentifier:forKey:")]
		void SetIdentifier ([NullAllowed] string identifier, string key);

		// @property (assign, nonatomic) BOOL advertisingTrackingEnabled;
		[Export ("advertisingTrackingEnabled")]
		bool AdvertisingTrackingEnabled { get; set; }
	}

	// @interface UADefaultMessageCenter : NSObject
	[BaseType (typeof(NSObject))]
	interface UADefaultMessageCenter
	{
		// @property (nonatomic, strong) NSString * title;
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) UADefaultMessageCenterStyle * style;
		[Export ("style", ArgumentSemantic.Strong)]
		UADefaultMessageCenterStyle Style { get; set; }

		// -(void)display:(BOOL)animated;
		[Export ("display:")]
		void Display (bool animated);

		// -(void)display;
		[Export ("display")]
		void Display ();

		// -(void)displayMessage:(UAInboxMessage *)message animated:(BOOL)animated;
		[Export ("displayMessage:animated:")]
		void DisplayMessage (UAInboxMessage message, bool animated);

		// -(void)displayMessage:(UAInboxMessage *)message;
		[Export ("displayMessage:")]
		void DisplayMessage (UAInboxMessage message);

		// -(void)dismiss:(BOOL)animated;
		[Export ("dismiss:")]
		void Dismiss (bool animated);

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();

		// @property (nonatomic, strong) NSPredicate * filter;
		[Export ("filter", ArgumentSemantic.Strong)]
		NSPredicate Filter { get; set; }
	}

	// @interface UADefaultMessageCenterListCell : UITableViewCell
	[BaseType (typeof(UITableViewCell))]
	interface UADefaultMessageCenterListCell
	{
		// @property (nonatomic, strong) UADefaultMessageCenterStyle * style;
		[Export ("style", ArgumentSemantic.Strong)]
		UADefaultMessageCenterStyle Style { get; set; }

		// @property (nonatomic, weak) UILabel * _Nullable date __attribute__((iboutlet));
		[NullAllowed, Export ("date", ArgumentSemantic.Weak)]
		UILabel Date { get; set; }

		// @property (nonatomic, weak) UILabel * _Nullable title __attribute__((iboutlet));
		[NullAllowed, Export ("title", ArgumentSemantic.Weak)]
		UILabel Title { get; set; }

		// @property (nonatomic, weak) UIView * _Nullable unreadIndicator __attribute__((iboutlet));
		[NullAllowed, Export ("unreadIndicator", ArgumentSemantic.Weak)]
		UIView UnreadIndicator { get; set; }

		// @property (nonatomic, weak) UIImageView * _Nullable listIconView __attribute__((iboutlet));
		[NullAllowed, Export ("listIconView", ArgumentSemantic.Weak)]
		UIImageView ListIconView { get; set; }

		// -(void)setData:(UAInboxMessage *)message;
		[Export ("setData:")]
		void SetData (UAInboxMessage message);
	}

	// @interface UADefaultMessageCenterListViewController : UIViewController <UITableViewDelegate, UITableViewDataSource, UIScrollViewDelegate, UISplitViewControllerDelegate>
	[BaseType (typeof(UIViewController))]
	interface UADefaultMessageCenterListViewController : IUITableViewDelegate, IUITableViewDataSource, IUIScrollViewDelegate, IUISplitViewControllerDelegate
	{
		// @property (nonatomic, strong) UADefaultMessageCenterStyle * style;
		[Export ("style", ArgumentSemantic.Strong)]
		UADefaultMessageCenterStyle Style { get; set; }

		// @property (copy, nonatomic) void (^closeBlock)(BOOL);
		[Export ("closeBlock", ArgumentSemantic.Copy)]
		Action<bool> CloseBlock { get; set; }

		// -(void)displayMessage:(UAInboxMessage *)message;
		[Export ("displayMessage:")]
		void DisplayMessage (UAInboxMessage message);

		// @property (nonatomic, strong) NSPredicate * filter;
		[Export ("filter", ArgumentSemantic.Strong)]
		NSPredicate Filter { get; set; }
	}

	// @interface UADefaultMessageCenterMessageViewController : UIViewController <UIWebViewDelegate, UARichContentWindow>
	[BaseType (typeof(UIViewController))]
	interface UADefaultMessageCenterMessageViewController : IUIWebViewDelegate, UARichContentWindow
	{
		// @property (nonatomic, strong) UAInboxMessage * message;
		[Export ("message", ArgumentSemantic.Strong)]
		UAInboxMessage Message { get; set; }

		// @property (copy, nonatomic) void (^closeBlock)(BOOL);
		[Export ("closeBlock", ArgumentSemantic.Copy)]
		Action<bool> CloseBlock { get; set; }

		// -(void)loadMessageAtIndex:(NSUInteger)index;
		[Export ("loadMessageAtIndex:")]
		void LoadMessageAtIndex (nuint index);

		// -(void)loadMessageForID:(NSString *)mid;
		[Export ("loadMessageForID:")]
		void LoadMessageForID (string mid);

		// @property (nonatomic, strong) NSPredicate * filter;
		[Export ("filter", ArgumentSemantic.Strong)]
		NSPredicate Filter { get; set; }
	}

	// @interface UADefaultMessageCenterSplitViewController : UISplitViewController
	[BaseType (typeof(UISplitViewController))]
	interface UADefaultMessageCenterSplitViewController
	{
		// @property (nonatomic, strong) UADefaultMessageCenterStyle * style;
		[Export ("style", ArgumentSemantic.Strong)]
		UADefaultMessageCenterStyle Style { get; set; }

		// @property (readonly, nonatomic) UADefaultMessageCenterListViewController * listViewController;
		[Export ("listViewController")]
		UADefaultMessageCenterListViewController ListViewController { get; }

		// @property (nonatomic, strong) NSPredicate * filter;
		[Export ("filter", ArgumentSemantic.Strong)]
		NSPredicate Filter { get; set; }
	}

	// @interface UADefaultMessageCenterStyle : NSObject
	[BaseType (typeof(NSObject))]
	interface UADefaultMessageCenterStyle
	{
		// @property (nonatomic, strong) UIFont * titleFont;
		[Export ("titleFont", ArgumentSemantic.Strong)]
		UIFont TitleFont { get; set; }

		// @property (nonatomic, strong) UIColor * titleColor;
		[Export ("titleColor", ArgumentSemantic.Strong)]
		UIColor TitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * tintColor;
		[Export ("tintColor", ArgumentSemantic.Strong)]
		UIColor TintColor { get; set; }

		// @property (nonatomic, strong) UIColor * navigationBarColor;
		[Export ("navigationBarColor", ArgumentSemantic.Strong)]
		UIColor NavigationBarColor { get; set; }

		// @property (assign, nonatomic) BOOL navigationBarOpaque;
		[Export ("navigationBarOpaque")]
		bool NavigationBarOpaque { get; set; }

		// @property (nonatomic, strong) UIColor * listColor;
		[Export ("listColor", ArgumentSemantic.Strong)]
		UIColor ListColor { get; set; }

		// @property (nonatomic, strong) UIColor * refreshTintColor;
		[Export ("refreshTintColor", ArgumentSemantic.Strong)]
		UIColor RefreshTintColor { get; set; }

		// @property (assign, nonatomic) BOOL iconsEnabled;
		[Export ("iconsEnabled")]
		bool IconsEnabled { get; set; }

		// @property (nonatomic, strong) UIImage * placeholderIcon;
		[Export ("placeholderIcon", ArgumentSemantic.Strong)]
		UIImage PlaceholderIcon { get; set; }

		// @property (nonatomic, strong) UIFont * cellTitleFont;
		[Export ("cellTitleFont", ArgumentSemantic.Strong)]
		UIFont CellTitleFont { get; set; }

		// @property (nonatomic, strong) UIFont * cellDateFont;
		[Export ("cellDateFont", ArgumentSemantic.Strong)]
		UIFont CellDateFont { get; set; }

		// @property (nonatomic, strong) UIColor * cellColor;
		[Export ("cellColor", ArgumentSemantic.Strong)]
		UIColor CellColor { get; set; }

		// @property (nonatomic, strong) UIColor * cellHighlightedColor;
		[Export ("cellHighlightedColor", ArgumentSemantic.Strong)]
		UIColor CellHighlightedColor { get; set; }

		// @property (nonatomic, strong) UIColor * cellTitleColor;
		[Export ("cellTitleColor", ArgumentSemantic.Strong)]
		UIColor CellTitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * cellTitleHighlightedColor;
		[Export ("cellTitleHighlightedColor", ArgumentSemantic.Strong)]
		UIColor CellTitleHighlightedColor { get; set; }

		// @property (nonatomic, strong) UIColor * cellDateColor;
		[Export ("cellDateColor", ArgumentSemantic.Strong)]
		UIColor CellDateColor { get; set; }

		// @property (nonatomic, strong) UIColor * cellDateHighlightedColor;
		[Export ("cellDateHighlightedColor", ArgumentSemantic.Strong)]
		UIColor CellDateHighlightedColor { get; set; }

		// @property (nonatomic, strong) UIColor * cellSeparatorColor;
		[Export ("cellSeparatorColor", ArgumentSemantic.Strong)]
		UIColor CellSeparatorColor { get; set; }

		// @property (nonatomic, strong) UIColor * cellTintColor;
		[Export ("cellTintColor", ArgumentSemantic.Strong)]
		UIColor CellTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * unreadIndicatorColor;
		[Export ("unreadIndicatorColor", ArgumentSemantic.Strong)]
		UIColor UnreadIndicatorColor { get; set; }


		// +(instancetype)style;
		[Static]
		[Export ("style")]
		UADefaultMessageCenterStyle Style ();

		// +(instancetype)styleWithContentsOfFile:(NSString *)path;
		[Static]
		[Export ("styleWithContentsOfFile:")]
		UADefaultMessageCenterStyle StyleWithContentsOfFile (string path);
	}


	// @protocol UAInAppMessageControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UAInAppMessageControllerDelegate
	{
		// @required -(UIView * _Nonnull)viewForMessage:(UAInAppMessage * _Nonnull)message parentView:(UIView * _Nonnull)parentView;
		[Abstract]
		[Export ("viewForMessage:parentView:")]
		UIView View (UAInAppMessage message, UIView parentView);

		// @required -(UIControl * _Nonnull)messageView:(UIView * _Nonnull)messageView buttonAtIndex:(NSUInteger)index;
		[Abstract]
		[Export ("messageView:buttonAtIndex:")]
		UIControl Button (UIView messageView, nuint index);

		// @optional -(void)messageView:(UIView * _Nonnull)messageView didChangeTouchState:(BOOL)touchDown;
		[Export ("messageView:didChangeTouchState:")]
		void DidChangeTouchState (UIView messageView, bool touchDown);

		// @optional -(void)messageView:(UIView * _Nonnull)messageView animateInWithParentView:(UIView * _Nonnull)parentView completionHandler:(void (^ _Nonnull)(void))completionHandler;
		[Export ("messageView:animateInWithParentView:completionHandler:")]
		void AnimateIn (UIView messageView, UIView parentView, Action completionHandler);

		// @optional -(void)messageView:(UIView * _Nonnull)messageView animateOutWithParentView:(UIView * _Nonnull)parentView completionHandler:(void (^ _Nonnull)(void))completionHandler;
		[Export ("messageView:animateOutWithParentView:completionHandler:")]
		void AnimateOut (UIView messageView, UIView parentView, Action completionHandler);
	}

	// @protocol UAInAppMessagingDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UAInAppMessagingDelegate
	{
		// @optional -(void)pendingMessageAvailable:(UAInAppMessage * _Nonnull)message;
		[Export ("pendingMessageAvailable:")]
		void PendingMessageAvailable (UAInAppMessage message);

		// @optional -(void)messageWillBeDisplayed:(UAInAppMessage * _Nonnull)message;
		[Export ("messageWillBeDisplayed:")]
		void MessageWillBeDisplayed (UAInAppMessage message);
	}

	// @interface UAInAppMessaging : NSObject
	[BaseType (typeof(NSObject))]
	interface UAInAppMessaging
	{
		// -(void)deletePendingMessage:(UAInAppMessage * _Nonnull)message;
		[Export ("deletePendingMessage:")]
		void DeletePendingMessage (UAInAppMessage message);

		// -(void)displayMessage:(UAInAppMessage * _Nonnull)message;
		[Export ("displayMessage:")]
		void DisplayMessage (UAInAppMessage message);

		// -(void)displayPendingMessage;
		[Export ("displayPendingMessage")]
		void DisplayPendingMessage ();

		// @property (copy, nonatomic) UAInAppMessage * _Nullable pendingMessage;
		[NullAllowed, Export ("pendingMessage", ArgumentSemantic.Copy)]
		UAInAppMessage PendingMessage { get; set; }

		// @property (getter = isAutoDisplayEnabled, assign, nonatomic) BOOL autoDisplayEnabled;
		[Export ("autoDisplayEnabled")]
		bool AutoDisplayEnabled { [Bind ("isAutoDisplayEnabled")] get; set; }

		// @property (nonatomic, strong) UIFont * _Nonnull font;
		[Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull defaultPrimaryColor;
		[Export ("defaultPrimaryColor", ArgumentSemantic.Strong)]
		UIColor DefaultPrimaryColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull defaultSecondaryColor;
		[Export ("defaultSecondaryColor", ArgumentSemantic.Strong)]
		UIColor DefaultSecondaryColor { get; set; }

		// @property (assign, nonatomic) NSTimeInterval displayDelay;
		[Export ("displayDelay")]
		double DisplayDelay { get; set; }

		// @property (getter = isDisplayASAPEnabled, assign, nonatomic) BOOL displayASAPEnabled;
		[Export ("displayASAPEnabled")]
		bool DisplayASAPEnabled { [Bind ("isDisplayASAPEnabled")] get; set; }

		[Wrap ("WeakMessagingDelegate")]
		[NullAllowed]
		UAInAppMessagingDelegate MessagingDelegate { get; set; }

		// @property (nonatomic, weak) id<UAInAppMessagingDelegate> _Nullable messagingDelegate;
		[NullAllowed, Export ("messagingDelegate", ArgumentSemantic.Weak)]
		NSObject WeakMessagingDelegate { get; set; }

		[Wrap ("WeakMessageControllerDelegate")]
		[NullAllowed]
		UAInAppMessageControllerDelegate MessageControllerDelegate { get; set; }

		// @property (nonatomic, weak) id<UAInAppMessageControllerDelegate> _Nullable messageControllerDelegate;
		[NullAllowed, Export ("messageControllerDelegate", ArgumentSemantic.Weak)]
		NSObject WeakMessageControllerDelegate { get; set; }
	}

	// @interface UAInAppMessage : NSObject
	[BaseType (typeof(NSObject))]
	interface UAInAppMessage
	{
		// +(instancetype _Nonnull)message;
		[Static]
		[Export ("message")]
		UAInAppMessage Message ();

		// +(instancetype _Nonnull)messageWithPayload:(NSDictionary * _Nonnull)payload;
		[Static]
		[Export ("messageWithPayload:")]
		UAInAppMessage Message (NSDictionary payload);

		// -(BOOL)isEqualToMessage:(UAInAppMessage * _Nullable)message;
		[Export ("isEqualToMessage:")]
		bool IsEqual ([NullAllowed] UAInAppMessage message);

		// @property (readonly, nonatomic) NSDictionary * _Nonnull payload;
		[Export ("payload")]
		NSDictionary Payload { get; }

		// @property (copy, nonatomic) NSString * _Nullable identifier;
		[NullAllowed, Export ("identifier")]
		string Identifier { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull expiry;
		[Export ("expiry", ArgumentSemantic.Strong)]
		NSDate Expiry { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nullable extra;
		[NullAllowed, Export ("extra", ArgumentSemantic.Copy)]
		NSDictionary Extra { get; set; }

		// @property (assign, nonatomic) UAInAppMessageDisplayType displayType;
		[Export ("displayType", ArgumentSemantic.Assign)]
		UAInAppMessageDisplayType DisplayType { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable alert;
		[NullAllowed, Export ("alert")]
		string Alert { get; set; }

		// @property (assign, nonatomic) UAInAppMessagePosition position;
		[Export ("position", ArgumentSemantic.Assign)]
		UAInAppMessagePosition Position { get; set; }

		// @property (assign, nonatomic) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable primaryColor;
		[NullAllowed, Export ("primaryColor", ArgumentSemantic.Strong)]
		UIColor PrimaryColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable secondaryColor;
		[NullAllowed, Export ("secondaryColor", ArgumentSemantic.Strong)]
		UIColor SecondaryColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable buttonGroup;
		[NullAllowed, Export ("buttonGroup")]
		string ButtonGroup { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nullable buttonActions;
		[NullAllowed, Export ("buttonActions", ArgumentSemantic.Copy)]
		NSDictionary ButtonActions { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nullable onClick;
		[NullAllowed, Export ("onClick", ArgumentSemantic.Copy)]
		NSDictionary OnClick { get; set; }

		// @property (readonly, nonatomic) UIUserNotificationActionContext notificationActionContext;
		[Export ("notificationActionContext")]
		UIUserNotificationActionContext NotificationActionContext { get; }

		// @property (readonly, nonatomic) NSArray * _Nullable notificationActions;
		[NullAllowed, Export ("notificationActions")]
		UANotificationAction[] NotificationActions { get; }

		// @property (readonly, nonatomic) UANotificationCategory * _Nullable buttonCategory;
		[NullAllowed, Export ("buttonCategory")]
		UANotificationCategory ButtonCategory { get; }

		// @property (readonly, nonatomic) NSArray * _Nullable buttonActionBindings;
		[NullAllowed, Export ("buttonActionBindings")]
		UAInAppMessageButtonActionBinding[] ButtonActionBindings { get; }
	}

	// @interface UAInAppMessageButtonActionBinding : NSObject
	[BaseType (typeof(NSObject))]
	interface UAInAppMessageButtonActionBinding
	{
		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable identifier;
		[NullAllowed, Export ("identifier")]
		string Identifier { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nullable actions;
		[NullAllowed, Export ("actions", ArgumentSemantic.Copy)]
		NSDictionary Actions { get; set; }

		// @property (assign, nonatomic) UASituation situation;
		[Export ("situation", ArgumentSemantic.Assign)]
		UASituation Situation { get; set; }
	}

	// @interface UALandingPageOverlayController : NSObject <UIWebViewDelegate, UARichContentWindow>
	[BaseType (typeof(NSObject))]
	interface UALandingPageOverlayController : IUIWebViewDelegate, UARichContentWindow
	{
		// +(void)showURL:(NSURL * _Nonnull)url withHeaders:(NSDictionary * _Nullable)headers;
		[Static]
		[Export ("showURL:withHeaders:")]
		void ShowURL (NSUrl url, [NullAllowed] NSDictionary headers);

		// +(void)showMessage:(UAInboxMessage * _Nonnull)message withHeaders:(NSDictionary * _Nullable)headers;
		[Static]
		[Export ("showMessage:withHeaders:")]
		void ShowMessage (UAInboxMessage message, [NullAllowed] NSDictionary headers);

		// +(void)showMessage:(UAInboxMessage * _Nonnull)message;
		[Static]
		[Export ("showMessage:")]
		void ShowMessage (UAInboxMessage message);

		// +(void)closeAll:(BOOL)animated;
		[Static]
		[Export ("closeAll:")]
		void CloseAll (bool animated);
	}
}
