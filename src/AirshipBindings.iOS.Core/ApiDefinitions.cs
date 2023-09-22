/*
 Copyright Airship and Contributors
*/

using CoreGraphics;
using Foundation;
using ObjCRuntime;
using System;
using System.Collections.Generic;
using UIKit;
using UserNotifications;
using WebKit;

namespace UrbanAirship {
	// @interface UAAccountEventTemplate : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAAccountEventTemplate
	{
		// @property (nonatomic, strong) NSNumber * _Nullable eventValue;
		[NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
		NSNumber EventValue { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable transactionID;
		[NullAllowed, Export("transactionID")]
		string TransactionID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable userID;
		[NullAllowed, Export("userID")]
		string UserID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable category;
		[NullAllowed, Export("category")]
		string Category { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable type;
		[NullAllowed, Export("type")]
		string Type { get; set; }

		// +(UAAccountEventTemplate * _Nonnull)registeredTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("registeredTemplate")]
		UAAccountEventTemplate RegisteredTemplate();

		// +(UAAccountEventTemplate * _Nonnull)registeredTemplateWithValueFromString:(NSString * _Nullable)valueString __attribute__((warn_unused_result("")));
		[Static]
		[Export("registeredTemplateWithValueFromString:")]
		UAAccountEventTemplate RegisteredTemplate([NullAllowed] string valueString);

		// +(UAAccountEventTemplate * _Nonnull)registeredTemplateWithValue:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Static]
		[Export("registeredTemplateWithValue:")]
		UAAccountEventTemplate RegisteredTemplate([NullAllowed] NSNumber value);

		// +(UAAccountEventTemplate * _Nonnull)loggedInTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("loggedInTemplate")]
		UAAccountEventTemplate LoggedInTemplate();

		// +(UAAccountEventTemplate * _Nonnull)loggedInTemplateWithValueFromString:(NSString * _Nullable)valueString __attribute__((warn_unused_result("")));
		[Static]
		[Export("loggedInTemplateWithValueFromString:")]
		UAAccountEventTemplate LoggedInTemplate([NullAllowed] string valueString);

		// +(UAAccountEventTemplate * _Nonnull)loggedInTemplateWithValue:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Static]
		[Export("loggedInTemplateWithValue:")]
		UAAccountEventTemplate LoggedInTemplate([NullAllowed] NSNumber value);

		// +(UAAccountEventTemplate * _Nonnull)loggedOutTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("loggedOutTemplate")]
		UAAccountEventTemplate LoggedOutTemplate();

		// +(UAAccountEventTemplate * _Nonnull)loggedOutTemplateWithValueFromString:(NSString * _Nullable)valueString __attribute__((warn_unused_result("")));
		[Static]
		[Export("loggedOutTemplateWithValueFromString:")]
		UAAccountEventTemplate LoggedOutTemplate([NullAllowed] string valueString);

		// +(UAAccountEventTemplate * _Nonnull)loggedOutTemplateWithValue:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Static]
		[Export("loggedOutTemplateWithValue:")]
		UAAccountEventTemplate LoggedOutTemplate([NullAllowed] NSNumber value);

		// -(UACustomEvent * _Nullable)createEvent __attribute__((warn_unused_result("")));
		[Export("createEvent")]
		[return: NullAllowed]
		UACustomEvent CreateEvent();
	}

    // @interface UAActionRunner : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionRunner
    {
        // +(void)runActions:(NSDictionary)actionsPayload situation:(enum UAActionSituation)situation completionHandler:(void (^ _Nonnull)(void))completionHandler;
        [Static]
        [Export("runActions:situation:completionHandler:")]
        void RunActions(NSDictionary actionsPayload, UAActionSituation situation, Action completionHandler);
    }
    
    // @interface UAActivityViewController : UIActivityViewController <UIPopoverControllerDelegate, UIPopoverPresentationControllerDelegate>
    [BaseType(typeof(NSObject))]
    interface UAActivityViewController : IUIPopoverControllerDelegate, IUIPopoverPresentationControllerDelegate
    {
        // @property (copy, nonatomic) void (^ _Nullable)(void) dismissalBlock;
        [NullAllowed, Export("dismissalBlock", ArgumentSemantic.Copy)]
        Action DismissalBlock { get; set; }

        // -(CGRect)sourceRect __attribute__((warn_unused_result("")));
        [Export("sourceRect")]
        CGRect SourceRect();

        // -(instancetype _Nonnull)initWithActivityItems:(NSArray * _Nonnull)activityItems applicationActivities:(NSArray<UIActivity *> * _Nullable)applicationActivities __attribute__((objc_designated_initializer));
        [Export("initWithActivityItems:applicationActivities:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSObject[] activityItems, [NullAllowed] UIActivity[] applicationActivities);
    }

	// @interface UAirship : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAirship
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull deepLinkScheme;
		[Static]
		[Export("deepLinkScheme")]
		string DeepLinkScheme { get; }

		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull airshipReadyNotification;
		[Static]
		[Export("airshipReadyNotification")]
		string AirshipReadyNotification { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull airshipReadyChannelIdentifier;
		[Static]
		[Export("airshipReadyChannelIdentifier")]
		string AirshipReadyChannelIdentifier { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull airshipReadyAppKey;
		[Static]
		[Export("airshipReadyAppKey")]
		string AirshipReadyAppKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull airshipReadyPayloadVersion;
		[Static]
		[Export("airshipReadyPayloadVersion")]
		string AirshipReadyPayloadVersion { get; }

		// @property (readonly, nonatomic, class) BOOL isFlying;
		[Static]
		[Export("isFlying")]
		bool IsFlying { get; }

		// @property (readonly, nonatomic, strong) UARuntimeConfig * _Nonnull config;
		[Export("config", ArgumentSemantic.Strong)]
		UARuntimeConfig Config { get; }

        // @property (readonly, nonatomic, strong) UAApplicationMetrics * _Nonnull applicationMetrics;
        [Export("applicationMetrics", ArgumentSemantic.Strong)]
		UAApplicationMetrics ApplicationMetrics { get; }

		[Wrap("WeakJavaScriptCommandDelegate")]
		[NullAllowed]
		IUAJavaScriptCommandDelegate JavaScriptCommandDelegate { get; set; }

		// @property (nonatomic, weak) id<UAJavaScriptCommandDelegate> _Nullable javaScriptCommandDelegate;
		[NullAllowed, Export("javaScriptCommandDelegate", ArgumentSemantic.Weak)]
		NSObject WeakJavaScriptCommandDelegate { get; set; }

        // @property (readonly, nonatomic, strong) UAPermissionsManager * _Nonnull permissionsManager;
        [Export("permissionsManager", ArgumentSemantic.Strong)]
        UAPermissionsManager PermissionsManager { get; }
        
        // @property (readonly, nonatomic, strong) UAChannelCapture * _Nonnull channelCapture;
        [Export("channelCapture", ArgumentSemantic.Strong)]
        UAChannelCapture ChannelCapture { get; }

		[Wrap("WeakDeepLinkDelegate")]
		[NullAllowed]
		IUADeepLinkDelegate DeepLinkDelegate { get; set; }

		// @property (nonatomic, weak) id<UADeepLinkDelegate> _Nullable deepLinkDelegate;
		[NullAllowed, Export("deepLinkDelegate", ArgumentSemantic.Weak)]
		NSObject WeakDeepLinkDelegate { get; set; }

		// @property (readonly, nonatomic, strong) UAURLAllowList * _Nonnull URLAllowList;
		[Export("URLAllowList", ArgumentSemantic.Strong)]
		UAURLAllowList URLAllowList { get; }

		// @property (readonly, nonatomic, strong) UALocaleManager * _Nonnull localeManager;
		[Export("localeManager", ArgumentSemantic.Strong)]
		UALocaleManager LocaleManager { get; }

		// @property (readonly, nonatomic, strong) UAPrivacyManager * _Nonnull privacyManager;
		[Export("privacyManager", ArgumentSemantic.Strong)]
		UAPrivacyManager PrivacyManager { get; }

		// @property (readonly, nonatomic, strong, class) UAirship * _Nonnull shared;
		[Static]
		[Export("shared", ArgumentSemantic.Strong)]
		UAirship Shared { get; }

		// @property (readonly, nonatomic, strong, class) UAPush * _Nonnull push;
		[Static]
		[Export("push", ArgumentSemantic.Strong)]
		UAPush Push { get; }

		// @property (readonly, nonatomic, strong, class) UAContact * _Nonnull contact;
		[Static]
		[Export("contact", ArgumentSemantic.Strong)]
		UAContact Contact { get; }

		// @property (readonly, nonatomic, strong, class) UAAnalytics * _Nonnull analytics;
		[Static]
		[Export("analytics", ArgumentSemantic.Strong)]
		UAAnalytics Analytics { get; }

		// @property (readonly, nonatomic, strong, class) UAChannel * _Nonnull channel;
		[Static]
		[Export("channel", ArgumentSemantic.Strong)]
		UAChannel Channel { get; }

		// +(void)takeOffWithLaunchOptions:(NSDictionary<UIApplicationLaunchOptionsKey,id> * _Nullable)launchOptions;
		[Static]
		[Export("takeOffWithLaunchOptions:")]
		void TakeOff([NullAllowed] NSDictionary launchOptions);

		// +(void)takeOff:(UAConfig * _Nullable)config launchOptions:(NSDictionary<UIApplicationLaunchOptionsKey,id> * _Nullable)launchOptions;
		[Static]
		[Export("takeOff:launchOptions:")]
		void TakeOff([NullAllowed] UAConfig config, [NullAllowed] NSDictionary launchOptions);

        // @property (nonatomic, strong, class) id<UAirshipLogHandler> _Nonnull logHandler;
        [Static]
        [Export("logHandler", ArgumentSemantic.Strong)]
        UAirshipLogHandler LogHandler { get; set; }
        
		// @property (nonatomic, class) enum UALogLevel logLevel;
		[Static]
		[Export("logLevel", ArgumentSemantic.Assign)]
		UALogLevel LogLevel { get; set; }

		// +(id<UAComponent> _Nullable)componentForClassName:(NSString * _Nonnull)className __attribute__((warn_unused_result("")));
		[Static]
		[Export("componentForClassName:")]
		[return: NullAllowed]
		IUAComponent ComponentForClassName(string className);

		// -(void)deepLink:(NSURL * _Nonnull)deepLink completionHandler:(void (^ _Nonnull)(BOOL))completionHandler;
		[Export("deepLink:completionHandler:")]
		void DeepLink(NSUrl deepLink, Action<bool> completionHandler);
	}

	// @interface UAirshipCoreResources : NSObject
	[BaseType(typeof(NSObject))]
	interface UAirshipCoreResources
	{
		// @property (readonly, nonatomic, strong, class) NSBundle * _Nonnull bundle;
		[Static]
		[Export("bundle", ArgumentSemantic.Strong)]
		NSBundle Bundle { get; }
	}

	// @interface UAirshipErrors : NSObject
	[BaseType(typeof(NSObject))]
	interface UAirshipErrors
	{
		// +(NSError * _Nonnull)parseError:(NSString * _Nonnull)message __attribute__((warn_unused_result("")));
		[Static]
		[Export("parseError:")]
		NSError ParseError(string message);

		// +(NSError * _Nonnull)error:(NSString * _Nonnull)message __attribute__((warn_unused_result("")));
		[Static]
		[Export("error:")]
		NSError Error(string message);
	}

	// @interface UAirshipVersion : NSObject
	[BaseType(typeof(NSObject))]
	interface UAirshipVersion
	{
		// +(NSString * _Nonnull)get __attribute__((warn_unused_result("")));
		[Static]
		[Export("get")]
        string Get();
	}

	// @interface UAAnalytics : NSObject <UAComponent, UAAnalyticsProtocol, UAEventManagerDelegate>
	[BaseType(typeof(UAComponent))]
	[DisableDefaultCtor]
	interface UAAnalytics : IUAComponent
	{
		// @property (readonly, nonatomic, strong, class) UAAnalytics * _Nonnull shared;
		[Static]
		[Export("shared", ArgumentSemantic.Strong)]
		UAAnalytics Shared { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull screenKey;
		[Static]
		[Export("screenKey")]
		string ScreenKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull eventKey;
		[Static]
		[Export("eventKey")]
		string EventKey { get; }

		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull customEventAdded;
		[Static]
		[Export("customEventAdded")]
		string CustomEventAdded { get; }

		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull regionEventAdded;
		[Static]
		[Export("regionEventAdded")]
		string RegionEventAdded { get; }

		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull screenTracked;
		[Static]
		[Export("screenTracked")]
		string ScreenTracked { get; }

		// @property (copy, nonatomic) NSString * _Nullable conversionSendID;
		[NullAllowed, Export("conversionSendID")]
		string ConversionSendID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable conversionPushMetadata;
		[NullAllowed, Export("conversionPushMetadata")]
		string ConversionPushMetadata { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sessionID;
		[NullAllowed, Export("sessionID")]
		string SessionID { get; }

		// @property (getter = isComponentEnabled, nonatomic) BOOL componentEnabled;
		[Export("componentEnabled")]
		bool ComponentEnabled { [Bind("isComponentEnabled")] get; set; }

		// -(void)addEvent:(id<UAEvent> _Nonnull)event;
		[Export("addEvent:")]
		void AddEvent(IUAEvent @event);

		// -(void)associateDeviceIdentifiers:(UAAssociatedIdentifiers * _Nonnull)associatedIdentifiers;
		[Export("associateDeviceIdentifiers:")]
		void AssociateDeviceIdentifiers(UAAssociatedIdentifiers associatedIdentifiers);

		// -(UAAssociatedIdentifiers * _Nonnull)currentAssociatedDeviceIdentifiers __attribute__((warn_unused_result("")));
		[Export("currentAssociatedDeviceIdentifiers")]
		UAAssociatedIdentifiers CurrentAssociatedDeviceIdentifiers();

		// -(void)trackScreen:(NSString * _Nullable)screen;
		[Export("trackScreen:")]
		void TrackScreen([NullAllowed] string screen);

		// -(void)scheduleUpload;
		[Export("scheduleUpload")]
		void ScheduleUpload();

        // -(void)registerSDKExtension:(enum UASDKExtension)ext version:(NSString * _Nonnull)version;
        [Export("registerSDKExtension:version:")]
        void RegisterSDKExtension(UASDKExtension ext, string version);

        // -(void)airshipReady;
        [Export("airshipReady")]
        void AirshipReady();
	}

	// @interface UAAppIntegration : NSObject
	[BaseType(typeof(NSObject))]
	interface UAAppIntegration
	{
		// @property (nonatomic, strong, class) id<UAAppIntegrationDelegate> _Nullable integrationDelegate;
		[Static]
		[NullAllowed, Export("integrationDelegate", ArgumentSemantic.Strong)]
		NSObject WeakIntegrationDelegate { get; set; }

		// +(void)applicatin:(UIApplication * _Nonnull)application performFetchWithCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler __attribute__((deprecated("Use application(_:performFetchWithCompletionHandler:) instead")));
		[Static]
		[Export("applicatin:performFetchWithCompletionHandler:")]
		void PerformFetch(UIApplication application, Action<UIBackgroundFetchResult> completionHandler);

		// +(void)application:(UIApplication * _Nonnull)application performFetchWithCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler;
		[Static]
		[Export("application:performFetchWithCompletionHandler:")]
		void Application(UIApplication application, Action<UIBackgroundFetchResult> completionHandler);

		// +(void)application:(UIApplication * _Nonnull)application didRegisterForRemoteNotificationsWithDeviceToken:(NSData * _Nonnull)deviceToken;
		[Static]
		[Export("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
		void DidRegisterForRemoteNotifications(UIApplication application, NSData deviceToken);

		// +(void)application:(UIApplication * _Nonnull)application didFailToRegisterForRemoteNotificationsWithError:(NSError * _Nonnull)error;
		[Static]
		[Export("application:didFailToRegisterForRemoteNotificationsWithError:")]
		void DidFailToRegisterForRemoteNotifications(UIApplication application, NSError error);

		// +(void)application:(UIApplication * _Nonnull)application didReceiveRemoteNotification:(NSDictionary * _Nonnull)userInfo fetchCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler;
		[Static]
		[Export("application:didReceiveRemoteNotification:fetchCompletionHandler:")]
		void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler);

		// +(void)userNotificationCenterWithCenter:(UNUserNotificationCenter * _Nonnull)center willPresentNotification:(UNNotification * _Nonnull)notification withCompletionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler __attribute__((deprecated("Use userNotificationCenter(_:willPresent:withCompletionHandler:) instead")));
		[Static]
		[Export("userNotificationCenterWithCenter:willPresentNotification:withCompletionHandler:")]
		void WillPresentNotification(UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);

		// +(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center willPresentNotification:(UNNotification * _Nonnull)notification withCompletionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler;
		[Static]
		[Export("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
		void UserNotificationCenter(UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);

		// +(void)userNotificationCenterWithCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler __attribute__((deprecated("Use userNotificationCenter(_:didReceive:withCompletionHandler:) instead")));
		[Static]
		[Export("userNotificationCenterWithCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler);

		// +(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler;
		[Static]
		[Export("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		void UserNotificationCenter(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler);
	}

	// @interface UAApplicationMetrics : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAApplicationMetrics
	{
		// @property (readonly, nonatomic) BOOL isAppVersionUpdated;
		[Export("isAppVersionUpdated")]
		bool IsAppVersionUpdated { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable lastApplicationOpenDate;
		[NullAllowed, Export("lastApplicationOpenDate", ArgumentSemantic.Copy)]
		NSDate LastApplicationOpenDate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable currentAppVersion;
		[NullAllowed, Export("currentAppVersion")]
		string CurrentAppVersion { get; }
	}

	// @interface UAAssociatedIdentifiers : NSObject
	[BaseType(typeof(NSObject))]
	interface UAAssociatedIdentifiers
	{
		// @property (readonly, nonatomic, class) NSInteger maxCount;
		[Static]
		[Export("maxCount")]
		nint MaxCount { get; }

		// @property (readonly, nonatomic, class) NSInteger maxCharacterCount;
		[Static]
		[Export("maxCharacterCount")]
		nint MaxCharacterCount { get; }

		// @property (copy, nonatomic) NSString * _Nullable advertisingID;
		[NullAllowed, Export("advertisingID")]
		string AdvertisingID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable vendorID;
		[NullAllowed, Export("vendorID")]
		string VendorID { get; set; }

		// @property (nonatomic) BOOL advertisingTrackingEnabled;
		[Export("advertisingTrackingEnabled")]
		bool AdvertisingTrackingEnabled { get; set; }

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull allIDs;
		[Export("allIDs", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> AllIDs { get; }

		// -(instancetype _Nonnull)initWithIdentifiers:(NSDictionary<NSString *,NSString *> * _Nullable)identifiers __attribute__((objc_designated_initializer));
		[Export("initWithIdentifiers:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] NSDictionary<NSString, NSString> identifiers);

		// +(UAAssociatedIdentifiers * _Nonnull)identifiers __attribute__((warn_unused_result("")));
		[Static]
		[Export("identifiers")]
		UAAssociatedIdentifiers Identifiers();

		// +(UAAssociatedIdentifiers * _Nonnull)identifiersWithDictionary:(NSDictionary<NSString *,NSString *> * _Nullable)identifiers __attribute__((warn_unused_result("")));
		[Static]
		[Export("identifiersWithDictionary:")]
		UAAssociatedIdentifiers Identifiers([NullAllowed] NSDictionary<NSString, NSString> identifiers);

		// -(void)setIdentifier:(NSString * _Nullable)identifier forKey:(NSString * _Nonnull)key;
		[Export("setIdentifier:forKey:")]
		void SetIdentifier([NullAllowed] string identifier, string key);
	}

	// @interface UAAttributeMutations : NSObject
	[BaseType(typeof(NSObject))]
	interface UAAttributeMutations
	{
		// -(void)setString:(NSString * _Nonnull)string forAttribute:(NSString * _Nonnull)forAttribute;
		[Export("setString:forAttribute:")]
		void SetString(string @string, string forAttribute);

		// -(void)setNumber:(NSNumber * _Nonnull)number forAttribute:(NSString * _Nonnull)forAttribute;
		[Export("setNumber:forAttribute:")]
		void SetNumber(NSNumber number, string forAttribute);

		// -(void)setDate:(NSDate * _Nonnull)date forAttribute:(NSString * _Nonnull)forAttribute;
		[Export("setDate:forAttribute:")]
		void SetDate(NSDate date, string forAttribute);

		// -(void)removeAttribute:(NSString * _Nonnull)attribute;
		[Export("removeAttribute:")]
		void RemoveAttribute(string attribute);

		// +(UAAttributeMutations * _Nonnull)mutations __attribute__((warn_unused_result("")));
		[Static]
		[Export("mutations")]
		UAAttributeMutations Mutations();
	}

	// @interface UAAttributes : NSObject
	[BaseType(typeof(NSObject))]
	interface UAAttributes
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull title;
		[Static]
		[Export("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull firstName;
		[Static]
		[Export("firstName")]
		string FirstName { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull lastName;
		[Static]
		[Export("lastName")]
		string LastName { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull fullName;
		[Static]
		[Export("fullName")]
		string FullName { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull gender;
		[Static]
		[Export("gender")]
		string Gender { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull zipCode;
		[Static]
		[Export("zipCode")]
		string ZipCode { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull city;
		[Static]
		[Export("city")]
		string City { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull region;
		[Static]
		[Export("region")]
		string Region { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull country;
		[Static]
		[Export("country")]
		string Country { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull birthdate;
		[Static]
		[Export("birthdate")]
		string Birthdate { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull age;
		[Static]
		[Export("age")]
		string Age { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull mobilePhone;
		[Static]
		[Export("mobilePhone")]
		string MobilePhone { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull homePhone;
		[Static]
		[Export("homePhone")]
		string HomePhone { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull workPhone;
		[Static]
		[Export("workPhone")]
		string WorkPhone { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull loyaltyTier;
		[Static]
		[Export("loyaltyTier")]
		string LoyaltyTier { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull company;
		[Static]
		[Export("company")]
		string Company { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull username;
		[Static]
		[Export("username")]
		string Username { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull accountCreation;
		[Static]
		[Export("accountCreation")]
		string AccountCreation { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull email;
		[Static]
		[Export("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull advertisingId;
		[Static]
		[Export("advertisingId")]
		string AdvertisingId { get; }
	}

    // @interface UAAttributesEditor : NSObject
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
	interface UAAttributesEditor
	{
		// -(void)removeAttribute:(NSString * _Nonnull)attribute;
		[Export("removeAttribute:")]
		void RemoveAttribute(string attribute);

		// -(void)setDate:(NSDate * _Nonnull)date attribute:(NSString * _Nonnull)attribute;
		[Export("setDate:attribute:")]
		void SetDate(NSDate date, string attribute);

		// -(void)setNumber:(NSNumber * _Nonnull)number attribute:(NSString * _Nonnull)attribute;
		[Export("setNumber:attribute:")]
		void SetNumber(NSNumber number, string attribute);

		// -(void)setString:(NSString * _Nonnull)string attribute:(NSString * _Nonnull)attribute;
		[Export("setString:attribute:")]
		void SetString(string @string, string attribute);

		// -(void)apply;
		[Export("apply")]
		void Apply();
	}

    // @interface UABeveledLoadingIndicator : UIView
    [BaseType(typeof(NSObject))]
    interface UABeveledLoadingIndicator
    {
        // @property (getter = isHidden, nonatomic) BOOL hidden;
        [Export("hidden")]
        bool Hidden { [Bind("isHidden")] get; set; }

        // -(void)show;
        [Export("show")]
        void Show();

        // -(void)hide;
        [Export("hide")]
        void Hide();
    }

    // @interface UAChannel : NSObject <UAComponent>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UAChannel : IUAComponent
    {
        // @property (readonly, nonatomic, class) NSNotificationName _Nonnull channelCreatedEvent;
        [Static]
        [Export("channelCreatedEvent")]
        string ChannelCreatedEvent { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull channelIdentifierKey;
        [Static]
        [Export("channelIdentifierKey")]
        string ChannelIdentifierKey { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull channelExistingKey;
        [Static]
        [Export("channelExistingKey")]
        string ChannelExistingKey { get; }

        // @property (readonly, nonatomic, class) NSNotificationName _Nonnull channelUpdatedEvent;
        [Static]
        [Export("channelUpdatedEvent")]
        string ChannelUpdatedEvent { get; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull tags;
        [Export("tags", ArgumentSemantic.Copy)]
        string[] Tags { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; }

        // @property (nonatomic) BOOL isChannelTagRegistrationEnabled;
        [Export("isChannelTagRegistrationEnabled")]
        bool IsChannelTagRegistrationEnabled { get; set; }

        // @property (readonly, nonatomic, strong, class) UAChannel * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        UAChannel Shared { get; }

        // -(UATagEditor * _Nonnull)editTags __attribute__((warn_unused_result("")));
        [Export("editTags")]
        UATagEditor EditTags();

        // -(void)editTags:(void (^ _Nonnull)(UATagEditor * _Nonnull))editorBlock;
        [Export("editTags:")]
        void EditTags(Action<UATagEditor> editorBlock);

        // -(UATagGroupsEditor * _Nonnull)editTagGroups __attribute__((warn_unused_result("")));
        [Export("editTagGroups")]
        UATagGroupsEditor EditTagGroups();

        // -(void)editTagGroups:(void (^ _Nonnull)(UATagGroupsEditor * _Nonnull))editorBlock;
        [Export("editTagGroups:")]
        void EditTagGroups(Action<UATagGroupsEditor> editorBlock);

        // -(UASubscriptionListEditor * _Nonnull)editSubscriptionLists __attribute__((warn_unused_result("")));
        [Export("editSubscriptionLists")]
        UASubscriptionListEditor EditSubscriptionLists();

        // -(void)editSubscriptionLists:(void (^ _Nonnull)(UASubscriptionListEditor * _Nonnull))editorBlock;
        [Export("editSubscriptionLists:")]
        void EditSubscriptionLists(Action<UASubscriptionListEditor> editorBlock);

        // -(void)fetchSubscriptionListsWithCompletionHandler:(void (^ _Nonnull)(NSArray<NSString *> * _Nullable, NSError * _Nullable))completionHandler;
        [Export("fetchSubscriptionListsWithCompletionHandler:")]
        void FetchSubscriptionLists(Action<string[]> completionHandler);

        // -(UAAttributesEditor * _Nonnull)editAttributes __attribute__((warn_unused_result("")));
        [Export("editAttributes")]
        UAAttributesEditor EditAttributes();

        // -(void)editAttributes:(void (^ _Nonnull)(UAAttributesEditor * _Nonnull))editorBlock;
        [Export("editAttributes:")]
        void EditAttributes(Action<UAAttributesEditor> editorBlock);

        // -(void)addTag:(NSString * _Nonnull)tag __attribute__((deprecated("Use editTags instead.")));
        [Export("addTag:")]
        void AddTag(string tag);

        // -(void)addTags:(NSArray *)tags __attribute__((deprecated("Use editTags instead.")));
        [Export("addTags:")]
        void AddTags(string[] tags);

        // -(void)removeTag:(NSString * _Nonnull)tag __attribute__((deprecated("Use editTags instead.")));
        [Export("removeTag:")]
        void RemoveTag(string tag);

        // -(void)removeTags:(NSArray<NSString *> * _Nonnull)tags __attribute__((deprecated("Use editTags instead.")));
        [Export("removeTags:")]
        void RemoveTags(string[] tags);

        // -(void)addTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)group __attribute__((deprecated("Use editTagGroups instead.")));
        [Export("addTags:group:")]
        void AddTags(string[] tags, string group);

        // -(void)removeTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)group __attribute__((deprecated("Use editTagGroups instead.")));
        [Export("removeTags:group:")]
        void RemoveTags(string[] tags, string group);

        // -(void)setTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)group __attribute__((deprecated("Use editTagGroups instead.")));
        [Export("setTags:group:")]
        void SetTags(string[] tags, string group);

        // -(void)applyAttributeMutations:(UAAttributeMutations * _Nonnull)mutations __attribute__((deprecated("Use editAttributes instead.")));
        [Export("applyAttributeMutations:")]
        void ApplyAttributeMutations(UAAttributeMutations mutations);

        // -(void)enableChannelCreation;
        [Export("enableChannelCreation")]
        void EnableChannelCreation();
    }

	// @interface UAChannelCapture : NSObject
	[NoTV]
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAChannelCapture
	{
		// @property (nonatomic) BOOL enabled;
		[Export("enabled")]
		bool Enabled { get; set; }
	}

	// @interface UACircularRegion : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UACircularRegion
	{
		// -(instancetype _Nullable)initWithRadius:(double)radius latitude:(double)latitude longitude:(double)longitude __attribute__((objc_designated_initializer));
		[Export("initWithRadius:latitude:longitude:")]
		[DesignatedInitializer]
		IntPtr Constructor(double radius, double latitude, double longitude);

		// +(UACircularRegion * _Nullable)circularRegionWithRadius:(double)radius latitude:(double)latitude longitude:(double)longitude __attribute__((warn_unused_result("")));
		[Static]
		[Export("circularRegionWithRadius:latitude:longitude:")]
		[return: NullAllowed]
		UACircularRegion CircularRegion(double radius, double latitude, double longitude);
	}

	// @interface UAConfig : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface UAConfig : INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nullable developmentAppKey;
		[NullAllowed, Export("developmentAppKey")]
		string DevelopmentAppKey { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable developmentAppSecret;
		[NullAllowed, Export("developmentAppSecret")]
		string DevelopmentAppSecret { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable productionAppKey;
		[NullAllowed, Export("productionAppKey")]
		string ProductionAppKey { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable productionAppSecret;
		[NullAllowed, Export("productionAppSecret")]
		string ProductionAppSecret { get; set; }

		// @property (nonatomic) enum UALogLevel developmentLogLevel;
		[Export("developmentLogLevel", ArgumentSemantic.Assign)]
		UALogLevel DevelopmentLogLevel { get; set; }

		// @property (nonatomic) enum UALogLevel productionLogLevel;
		[Export("productionLogLevel", ArgumentSemantic.Assign)]
		UALogLevel ProductionLogLevel { get; set; }

        // @property (nonatomic) BOOL autoPauseInAppAutomationOnLaunch;
        [Export("autoPauseInAppAutomationOnLaunch")]
        bool AutoPauseInAppAutomationOnLaunch { get; set; }
        
		// @property (nonatomic) enum UACloudSite site;
		[Export("site", ArgumentSemantic.Assign)]
		UACloudSite Site { get; set; }

		// @property (nonatomic) UAFeatures enabledFeatures;
		[Export("enabledFeatures", ArgumentSemantic.Assign)]
		UAFeatures EnabledFeatures { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull defaultAppKey;
		[Export("defaultAppKey")]
		string DefaultAppKey { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull defaultAppSecret;
		[Export("defaultAppSecret")]
		string DefaultAppSecret { get; set; }

		// @property (nonatomic) BOOL inProduction;
		[Export("inProduction")]
		bool InProduction { get; set; }

		// @property (nonatomic) BOOL detectProvisioningMode;
		[Export("detectProvisioningMode")]
		bool DetectProvisioningMode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable profilePath;
		[NullAllowed, Export("profilePath")]
		string ProfilePath { get; set; }

		// @property (nonatomic) BOOL isAutomaticSetupEnabled;
		[Export("isAutomaticSetupEnabled")]
		bool IsAutomaticSetupEnabled { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull URLAllowList;
		[Export("URLAllowList", ArgumentSemantic.Copy)]
		string[] URLAllowList { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull URLAllowListScopeJavaScriptInterface;
		[Export("URLAllowListScopeJavaScriptInterface", ArgumentSemantic.Copy)]
		string[] URLAllowListScopeJavaScriptInterface { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull URLAllowListScopeOpenURL;
		[Export("URLAllowListScopeOpenURL", ArgumentSemantic.Copy)]
		string[] URLAllowListScopeOpenURL { get; set; }

		// @property (nonatomic) BOOL suppressAllowListError;
		[Export("suppressAllowListError")]
		bool SuppressAllowListError { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable itunesID;
		[NullAllowed, Export("itunesID")]
		string ItunesID { get; set; }

		// @property (nonatomic) BOOL isAnalyticsEnabled;
		[Export("isAnalyticsEnabled")]
		bool IsAnalyticsEnabled { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable messageCenterStyleConfig;
		[NullAllowed, Export("messageCenterStyleConfig")]
		string MessageCenterStyleConfig { get; set; }

		// @property (nonatomic) BOOL clearUserOnAppRestore;
		[Export("clearUserOnAppRestore")]
		bool ClearUserOnAppRestore { get; set; }

		// @property (nonatomic) BOOL clearNamedUserOnAppRestore;
		[Export("clearNamedUserOnAppRestore")]
		bool ClearNamedUserOnAppRestore { get; set; }

		// @property (nonatomic) BOOL isChannelCaptureEnabled;
		[Export("isChannelCaptureEnabled")]
		bool IsChannelCaptureEnabled { get; set; }

		// @property (nonatomic) BOOL isChannelCreationDelayEnabled;
		[Export("isChannelCreationDelayEnabled")]
		bool IsChannelCreationDelayEnabled { get; set; }

		// @property (nonatomic) BOOL isExtendedBroadcastsEnabled;
		[Export("isExtendedBroadcastsEnabled")]
		bool IsExtendedBroadcastsEnabled { get; set; }

		// @property (nonatomic) BOOL requestAuthorizationToUseNotifications;
		[Export("requestAuthorizationToUseNotifications")]
		bool RequestAuthorizationToUseNotifications { get; set; }

		// @property (nonatomic) BOOL requireInitialRemoteConfigEnabled;
		[Export("requireInitialRemoteConfigEnabled")]
		bool RequireInitialRemoteConfigEnabled { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable initialConfigURL;
        [NullAllowed, Export("initialConfigURL")]
        string InitialConfigURL { get; set; }
        
		// @property (copy, nonatomic) NSString * _Nullable deviceAPIURL;
		[NullAllowed, Export("deviceAPIURL")]
		string DeviceAPIURL { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable analyticsURL;
		[NullAllowed, Export("analyticsURL")]
		string AnalyticsURL { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable remoteDataAPIURL;
		[NullAllowed, Export("remoteDataAPIURL")]
		string RemoteDataAPIURL { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable chatURL;
		[NullAllowed, Export("chatURL")]
		string ChatURL { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable chatWebSocketURL;
		[NullAllowed, Export("chatWebSocketURL")]
		string ChatWebSocketURL { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appKey;
		[Export("appKey")]
		string AppKey { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appSecret;
		[Export("appSecret")]
		string AppSecret { get; }

		// @property (readonly, nonatomic) enum UALogLevel logLevel;
		[Export("logLevel")]
		UALogLevel LogLevel { get; }

		// +(UAConfig * _Nonnull)defaultConfig __attribute__((warn_unused_result("")));
		[Static]
		[Export("defaultConfig")]
		UAConfig DefaultConfig();

		// +(UAConfig * _Nonnull)configWithContentsOfFile:(NSString * _Nullable)path __attribute__((warn_unused_result("")));
		[Static]
		[Export("configWithContentsOfFile:")]
		UAConfig Config([NullAllowed] string path);

		// +(UAConfig * _Nonnull)config __attribute__((warn_unused_result("")));
		[Static]
		[Export("config")]
		UAConfig Config();

		// -(instancetype _Nonnull)initWithContentsOfFile:(NSString * _Nullable)path;
		[Export("initWithContentsOfFile:")]
		IntPtr Constructor([NullAllowed] string path);

		// -(BOOL)validate __attribute__((warn_unused_result("")));
		[Export("validate")]
		bool Validate ();

		// +(BOOL)isProductionProvisioningProfile:(NSString * _Nonnull)profilePath __attribute__((warn_unused_result("")));
		[Static]
		[Export("isProductionProvisioningProfile:")]
		bool IsProductionProvisioningProfile(string profilePath);
	}

	// @interface UAConnectionType : NSObject
	[BaseType(typeof(NSObject))]
	interface UAConnectionType
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull none;
		[Static]
		[Export("none")]
		string None { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull cell;
		[Static]
		[Export("cell")]
		string Cell { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull wifi;
		[Static]
		[Export("wifi")]
		string Wifi { get; }
	}

	// @interface UAContact : NSObject <UAComponent, UAContactProtocol>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAContact : IUAComponent
	{
        // @property (readonly, nonatomic, class) NSNotificationName _Nonnull contactConflictEvent;
        [Static]
        [Export("contactConflictEvent")]
        string ContactConflictEvent { get; }
        
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull contactConflictEventKey;
        [Static]
        [Export("contactConflictEventKey")]
        string ContactConflictEventKey { get; }
        
        // @property (readonly, nonatomic, class) NSInteger maxNamedUserIDLength;
        [Static]
        [Export("maxNamedUserIDLength")]
        nint MaxNamedUserIDLength { get; }
        
        // -(void)getNamedUserIDWithCompletionHandler:(void (^ _Nonnull)(NSString * _Nullable))completionHandler;
        [Export("getNamedUserIDWithCompletionHandler:")]
        void GetNamedUserID(Action<string> completionHandler);

        // @property (readonly, nonatomic, strong, class) UAContact * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        UAContact Shared { get; }
        
        // -(void)identify:(NSString * _Nonnull)namedUserID;
        [Export("identify:")]
        void Identify(string namedUserID);

        // -(void)reset;
        [Export("reset")]
        void Reset();
        
        // -(UATagGroupsEditor * _Nonnull)editTagGroups __attribute__((warn_unused_result("")));
        [Export("editTagGroups")]
        UATagGroupsEditor EditTagGroups();

        // -(void)editTagGroups:(void (^ _Nonnull)(UATagGroupsEditor * _Nonnull))editorBlock;
        [Export("editTagGroups:")]
        void EditTagGroups(Action<UATagGroupsEditor> editorBlock);

        // -(UAAttributesEditor * _Nonnull)editAttributes __attribute__((warn_unused_result("")));
        [Export("editAttributes")]
        UAAttributesEditor EditAttributes();

        // -(void)editAttributes:(void (^ _Nonnull)(UAAttributesEditor * _Nonnull))editorBlock;
        [Export("editAttributes:")]
        void EditAttributes(Action<UAAttributesEditor> editorBlock);

        // -(void)registerEmail:(NSString * _Nonnull)address options:(UAEmailRegistrationOptions * _Nonnull)options;
        [Export("registerEmail:options:")]
        void RegisterEmail(string address, UAEmailRegistrationOptions options);

        // -(void)registerSMS:(NSString * _Nonnull)msisdn options:(UASMSRegistrationOptions * _Nonnull)options;
        [Export("registerSMS:options:")]
        void RegisterSMS(string msisdn, UASMSRegistrationOptions options);

        // -(void)registerOpen:(NSString * _Nonnull)address options:(UAOpenRegistrationOptions * _Nonnull)options;
        [Export("registerOpen:options:")]
        void RegisterOpen(string address, UAOpenRegistrationOptions options);

        // -(void)associateChannel:(NSString * _Nonnull)channelID type:(enum UAChannelType)type;
        [Export("associateChannel:type:")]
        void AssociateChannel(string channelID, UAChannelType type);

        // -(UAScopedSubscriptionListEditor * _Nonnull)editSubscriptionLists __attribute__((warn_unused_result("")));
        [Export("editSubscriptionLists")]
        UAScopedSubscriptionListEditor EditSubscriptionLists();

        // -(void)editSubscriptionLists:(void (^ _Nonnull)(UAScopedSubscriptionListEditor * _Nonnull))editorBlock;
        [Export("editSubscriptionLists:")]
        void EditSubscriptionLists(Action<UAScopedSubscriptionListEditor> editorBlock);

        // -(void)fetchSubscriptionListsWithCompletionHandler:(void (^ _Nonnull)(NSDictionary *))completionHandler;
        [Export("fetchSubscriptionListsWithCompletionHandler:")]
        void FetchSubscriptionLists(Action< NSDictionary> completionHandler);
    }

	// @interface UACustomEvent : NSObject <UAEvent>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UACustomEvent : IUAEvent
	{
		// @property (readonly, nonatomic, class) NSInteger maxPropertiesSize;
		[Static]
		[Export("maxPropertiesSize")]
		nint MaxPropertiesSize { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull eventNameKey;
		[Static]
		[Export("eventNameKey")]
		string EventNameKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull eventValueKey;
		[Static]
		[Export("eventValueKey")]
		string EventValueKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull eventPropertiesKey;
		[Static]
		[Export("eventPropertiesKey")]
		string EventPropertiesKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull eventTransactionIDKey;
		[Static]
		[Export("eventTransactionIDKey")]
		string EventTransactionIDKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull eventInteractionIDKey;
		[Static]
		[Export("eventInteractionIDKey")]
		string EventInteractionIDKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull eventInteractionTypeKey;
		[Static]
		[Export("eventInteractionTypeKey")]
		string EventInteractionTypeKey { get; }

		// @property (copy, nonatomic) NSString * _Nullable conversionSendID;
		[NullAllowed, Export("conversionSendID")]
		string ConversionSendID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable conversionPushMetadata;
		[NullAllowed, Export("conversionPushMetadata")]
		string ConversionPushMetadata { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable templateType;
		[NullAllowed, Export("templateType")]
		string TemplateType { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable eventValue;
		[NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
		NSNumber EventValue { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable eventName;
		[NullAllowed, Export("eventName")]
		string EventName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable transactionID;
		[NullAllowed, Export("transactionID")]
		string TransactionID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable interactionType;
		[NullAllowed, Export("interactionType")]
		string InteractionType { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable interactionID;
		[NullAllowed, Export("interactionID")]
		string InteractionID { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull properties;
		[Export("properties", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Properties { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull eventType;
		[Export("eventType")]
		string EventType { get; }

        // @property (readonly, nonatomic) UAEventPriority priority;
        //[Export("priority")]
        //UAEventPriority Priority { get; }
        
		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name value:(NSNumber * _Nullable)value __attribute__((objc_designated_initializer));
		[Export("initWithName:value:")]
		[DesignatedInitializer]
		IntPtr Constructor(string name, [NullAllowed] NSNumber value);

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name stringValue:(NSString * _Nullable)stringValue;
		[Export("initWithName:stringValue:")]
		IntPtr Constructor(string name, [NullAllowed] string stringValue);

		// +(UACustomEvent * _Nonnull)eventWithName:(NSString * _Nonnull)name __attribute__((warn_unused_result("")));
		[Static]
		[Export("eventWithName:")]
		UACustomEvent Event(string name);

		// +(UACustomEvent * _Nonnull)eventWithName:(NSString * _Nonnull)name valueFromString:(NSString * _Nullable)string __attribute__((warn_unused_result("")));
		[Static]
		[Export("eventWithName:valueFromString:")]
		UACustomEvent Event(string name, [NullAllowed] string @string);

		// +(UACustomEvent * _Nonnull)eventWithName:(NSString * _Nonnull)name value:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Static]
		[Export("eventWithName:value:")]
		UACustomEvent Event(string name, [NullAllowed] NSNumber value);

		// -(BOOL)isValid __attribute__((warn_unused_result("")));
		[Export("isValid")]
		bool IsValid ();

		// -(void)setInteractionFromMessageCenterMessage:(NSString * _Nullable)messageID;
		[Export("setInteractionFromMessageCenterMessage:")]
		void SetInteractionFromMessageCenterMessage([NullAllowed] string messageID);

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull data;
		[Export("data", ArgumentSemantic.Copy)]
		NSDictionary Data { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull payload;
		[Export("payload", ArgumentSemantic.Copy)]
		NSDictionary Payload { get; }

		// -(void)track;
		[Export("track")]
		void Track();
	}

	// @protocol UADeepLinkDelegate
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface UADeepLinkDelegate
	{
		// @required -(void)receivedDeepLink:(NSURL * _Nonnull)deepLink completionHandler:(void (^ _Nonnull)(void))completionHandler;
		[Abstract]
		[Export("receivedDeepLink:completionHandler:")]
		void ReceivedDeepLink(NSUrl deepLink, Action completionHandler);
	}

	interface IUADeepLinkDelegate { };

    // @interface UAInstallAttributionEvent : NSObject <UAEvent>
    [BaseType(typeof(NSObject))]
	interface UAInstallAttributionEvent : IUAEvent
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull eventType;
		[Export("eventType")]
		string EventType { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull data;
		[Export("data", ArgumentSemantic.Copy)]
		NSDictionary Data { get; }

        // @property (readonly, nonatomic) UAEventPriority priority;
        [Export("priority")]
        UAEventPriority Priority { get; }
        
		// -(instancetype _Nonnull)initWithAppPurchaseDate:(NSDate * _Nonnull)appPurchaseDate iAdImpressionDate:(NSDate * _Nonnull)iAdImpressionDate __attribute__((objc_designated_initializer));
		[Export("initWithAppPurchaseDate:iAdImpressionDate:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSDate appPurchaseDate, NSDate iAdImpressionDate);

		// +(UAInstallAttributionEvent * _Nonnull)eventWithAppPurchaseDate:(NSDate * _Nonnull)appPurchaseDate iAdImpressionDate:(NSDate * _Nonnull)iAdImpressionDate __attribute__((warn_unused_result("")));
		[Static]
		[Export("eventWithAppPurchaseDate:iAdImpressionDate:")]
		UAInstallAttributionEvent Event(NSDate appPurchaseDate, NSDate iAdImpressionDate);

		// +(UAInstallAttributionEvent * _Nonnull)event __attribute__((warn_unused_result("")));
		[Static]
		[Export("event")]
		UAInstallAttributionEvent Event();
	}

	// @interface UAJSONMatcher : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAJSONMatcher
	{
		// -(instancetype _Nonnull)initWithValueMatcher:(UAJSONValueMatcher * _Nonnull)valueMatcher;
		[Export("initWithValueMatcher:")]
		IntPtr Constructor(UAJSONValueMatcher valueMatcher);

		// -(instancetype _Nonnull)initWithValueMatcher:(UAJSONValueMatcher * _Nonnull)valueMatcher scope:(NSArray<NSString *> * _Nonnull)scope;
		[Export("initWithValueMatcher:scope:")]
		IntPtr Constructor(UAJSONValueMatcher valueMatcher, string[] scope);

		// -(instancetype _Nonnull)initWithValueMatcher:(UAJSONValueMatcher * _Nonnull)valueMatcher ignoreCase:(BOOL)ignoreCase;
		[Export("initWithValueMatcher:ignoreCase:")]
		IntPtr Constructor(UAJSONValueMatcher valueMatcher, bool ignoreCase);

		// -(instancetype _Nonnull)initWithValueMatcher:(UAJSONValueMatcher * _Nonnull)valueMatcher key:(NSString * _Nonnull)key;
		[Export("initWithValueMatcher:key:")]
		IntPtr Constructor(UAJSONValueMatcher valueMatcher, string key);

		// -(instancetype _Nonnull)initWithValueMatcher:(UAJSONValueMatcher * _Nonnull)valueMatcher key:(NSString * _Nonnull)key scope:(NSArray<NSString *> * _Nonnull)scope;
		[Export("initWithValueMatcher:key:scope:")]
		IntPtr Constructor(UAJSONValueMatcher valueMatcher, string key, string[] scope);

		// -(instancetype _Nonnull)initWithValueMatcher:(UAJSONValueMatcher * _Nonnull)valueMatcher scope:(NSArray<NSString *> * _Nonnull)scope ignoreCase:(BOOL)ignoreCase;
		[Export("initWithValueMatcher:scope:ignoreCase:")]
		IntPtr Constructor(UAJSONValueMatcher valueMatcher, string[] scope, bool ignoreCase);

		// -(instancetype _Nullable)initWithJSON:(id _Nullable)json error:(NSError * _Nullable * _Nullable)error;
		[Export("initWithJSON:error:")]
		IntPtr Constructor([NullAllowed] NSObject json, [NullAllowed] out NSError error);

		// -(NSDictionary<NSString *,id> * _Nonnull)payload __attribute__((warn_unused_result("")));
		[Export("payload")]
		NSDictionary<NSString, NSObject> Payload { get; }

		// -(BOOL)evaluateObject:(id _Nullable)value __attribute__((warn_unused_result("")));
		[Export("evaluateObject:")]
		bool EvaluateObject([NullAllowed] NSObject value);

		// -(BOOL)evaluateObject:(id _Nullable)value ignoreCase:(BOOL)ignoreCase __attribute__((warn_unused_result("")));
		[Export("evaluateObject:ignoreCase:")]
		bool EvaluateObject([NullAllowed] NSObject value, bool ignoreCase);
	}

	// @interface UAJSONPredicate : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAJSONPredicate
	{
		// -(instancetype _Nullable)initWithJSON:(id _Nullable)json error:(NSError * _Nullable * _Nullable)error;
		[Export("initWithJSON:error:")]
		IntPtr Constructor([NullAllowed] NSObject json, [NullAllowed] out NSError error);

		// -(NSDictionary<NSString *,id> * _Nonnull)payload __attribute__((warn_unused_result("")));
		[Export("payload")]
		NSDictionary<NSString, NSObject> Payload { get; }

		// -(BOOL)evaluateObject:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export("evaluateObject:")]
		bool EvaluateObject([NullAllowed] NSObject @object);

		// -(instancetype _Nonnull)initWithJSONMatcher:(UAJSONMatcher * _Nullable)matcher;
		[Export("initWithJSONMatcher:")]
		IntPtr Constructor([NullAllowed] UAJSONMatcher matcher);

		// +(UAJSONPredicate * _Nonnull)andPredicateWithSubpredicates:(NSArray<UAJSONPredicate *> * _Nullable)subpredicates __attribute__((warn_unused_result("")));
		[Static]
		[Export("andPredicateWithSubpredicates:")]
		UAJSONPredicate AndPredicate([NullAllowed] UAJSONPredicate[] subpredicates);

		// +(UAJSONPredicate * _Nonnull)orPredicateWithSubpredicates:(NSArray<UAJSONPredicate *> * _Nullable)subpredicates __attribute__((warn_unused_result("")));
		[Static]
		[Export("orPredicateWithSubpredicates:")]
		UAJSONPredicate OrPredicate([NullAllowed] UAJSONPredicate[] subpredicates);

		// +(UAJSONPredicate * _Nonnull)notPredicateWithSubpredicate:(UAJSONPredicate * _Nonnull)subpredicate __attribute__((warn_unused_result("")));
		[Static]
		[Export("notPredicateWithSubpredicate:")]
		UAJSONPredicate NotPredicate(UAJSONPredicate subpredicate);
	}

	// @interface UAJSONValueMatcher : NSObject
	[BaseType(typeof(NSObject))]
	interface UAJSONValueMatcher
	{
		// -(NSDictionary<NSString *,id> * _Nonnull)payload __attribute__((warn_unused_result("")));
		[Export("payload")]
		NSDictionary<NSString, NSObject> Payload { get; }

		// -(BOOL)evaluateObject:(id _Nullable)value __attribute__((warn_unused_result("")));
		[Export("evaluateObject:")]
		bool EvaluateObject([NullAllowed] NSObject value);

		// -(BOOL)evaluateObject:(id _Nullable)value ignoreCase:(BOOL)ignoreCase __attribute__((warn_unused_result("")));
		[Export("evaluateObject:ignoreCase:")]
		bool EvaluateObject([NullAllowed] NSObject value, bool ignoreCase);

		// -(BOOL)value:(id _Nullable)valueOne isEqualToValue:(id _Nullable)valueTwo ignoreCase:(BOOL)ignoreCase __attribute__((warn_unused_result("")));
		[Export("value:isEqualToValue:ignoreCase:")]
		bool Value([NullAllowed] NSObject valueOne, [NullAllowed] NSObject valueTwo, bool ignoreCase);

		// +(UAJSONValueMatcher * _Nonnull)matcherWhereNumberAtLeast:(NSNumber * _Nonnull)number __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWhereNumberAtLeast:")]
		UAJSONValueMatcher MatcherWhereNumberAtLeast(NSNumber number);

		// +(UAJSONValueMatcher * _Nonnull)matcherWhereNumberAtLeast:(NSNumber * _Nonnull)lowerNumber atMost:(NSNumber * _Nonnull)higherNumber __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWhereNumberAtLeast:atMost:")]
		UAJSONValueMatcher MatcherWhereNumberAtLeast(NSNumber lowerNumber, NSNumber higherNumber);

		// +(UAJSONValueMatcher * _Nonnull)matcherWhereNumberAtMost:(NSNumber * _Nonnull)number __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWhereNumberAtMost:")]
		UAJSONValueMatcher MatcherWhereNumberAtMost(NSNumber number);

		// +(UAJSONValueMatcher * _Nonnull)matcherWhereNumberEquals:(NSNumber * _Nonnull)number __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWhereNumberEquals:")]
		UAJSONValueMatcher MatcherWhereNumberEquals(NSNumber number);

		// +(UAJSONValueMatcher * _Nonnull)matcherWhereBooleanEquals:(BOOL)boolean __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWhereBooleanEquals:")]
		UAJSONValueMatcher MatcherWhereBooleanEquals(bool boolean);

		// +(UAJSONValueMatcher * _Nonnull)matcherWhereStringEquals:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWhereStringEquals:")]
		UAJSONValueMatcher MatcherWhereStringEquals(string @string);

		// +(UAJSONValueMatcher * _Nonnull)matcherWhereValueIsPresent:(BOOL)present __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWhereValueIsPresent:")]
		UAJSONValueMatcher MatcherWhereValueIsPresent(bool present);

		// +(UAJSONValueMatcher * _Nullable)matcherWithVersionConstraint:(NSString * _Nonnull)versionConstraint __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWithVersionConstraint:")]
		[return: NullAllowed]
		UAJSONValueMatcher Matcher(string versionConstraint);

		// +(UAJSONValueMatcher * _Nullable)matcherWithArrayContainsPredicate:(UAJSONPredicate * _Nonnull)predicate __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWithArrayContainsPredicate:")]
		[return: NullAllowed]
		UAJSONValueMatcher Matcher(UAJSONPredicate predicate);

		// +(UAJSONValueMatcher * _Nullable)matcherWithArrayContainsPredicate:(UAJSONPredicate * _Nonnull)predicate atIndex:(NSInteger)index __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWithArrayContainsPredicate:atIndex:")]
		[return: NullAllowed]
		UAJSONValueMatcher Matcher(UAJSONPredicate predicate, nint index);

		// +(UAJSONValueMatcher * _Nullable)matcherWithJSON:(id _Nullable)json error:(NSError * _Nullable * _Nullable)error __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWithJSON:error:")]
		[return: NullAllowed]
		UAJSONValueMatcher Matcher([NullAllowed] NSObject json, [NullAllowed] out NSError error);
	}

	// @interface UAJavaScriptEnvironment : NSObject <UAJavaScriptEnvironmentProtocol>
	[BaseType(typeof(NSObject))]
	interface UAJavaScriptEnvironment : IUAJavaScriptEnvironmentProtocol
	{
		// -(void)addStringGetter:(NSString * _Nonnull)getter value:(NSString * _Nullable)string __attribute__((swift_name("add(_:string:)")));
		[Export("addStringGetter:value:")]
		new void AddStringGetter(string getter, [NullAllowed] string @string);

		// -(void)addNumberGetter:(NSString * _Nonnull)getter value:(NSNumber * _Nullable)number __attribute__((swift_name("add(_:number:)")));
		[Export("addNumberGetter:value:")]
		new void AddNumberGetter(string getter, [NullAllowed] NSNumber number);

		// -(void)addDictionaryGetter:(NSString * _Nonnull)getter value:(NSDictionary * _Nullable)dictionary __attribute__((swift_name("add(_:dictionary:)")));
		[Export("addDictionaryGetter:value:")]
		new void AddDictionaryGetter(string getter, [NullAllowed] NSDictionary dictionary);

		// -(NSString * _Nonnull)build __attribute__((warn_unused_result("")));
		[Export("build")]
		new string Build ();
	}

	// @interface UALocaleManager : NSObject <LocaleManagerProtocol>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
    interface UALocaleManager : IUALocaleManagerProtocol
	{
		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull localeUpdatedEvent;
		[Static]
		[Export("localeUpdatedEvent")]
		string LocaleUpdatedEvent { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull localeEventKey;
		[Static]
		[Export("localeEventKey")]
		string LocaleEventKey { get; }

		// @property (copy, nonatomic) NSLocale * _Nonnull currentLocale;
		[Export("currentLocale", ArgumentSemantic.Copy)]
		NSLocale CurrentLocale { get; set; }

		// -(void)clearLocale;
		[Export("clearLocale")]
		void ClearLocale();
	}

    interface IUALocaleManagerProtocol { };
    
	// @interface UAMediaEventTemplate : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAMediaEventTemplate
	{
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

		// @property (nonatomic) BOOL isFeature;
		[Export("isFeature")]
		bool IsFeature { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable author;
		[NullAllowed, Export("author")]
		string Author { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable publishedDate;
		[NullAllowed, Export("publishedDate")]
		string PublishedDate { get; set; }

		// +(UAMediaEventTemplate * _Nonnull)browsedTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("browsedTemplate")]
		UAMediaEventTemplate BrowsedTemplate ();

		// +(UAMediaEventTemplate * _Nonnull)starredTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("starredTemplate")]
		UAMediaEventTemplate StarredTemplate ();

		// +(UAMediaEventTemplate * _Nonnull)sharedTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("sharedTemplate")]
		UAMediaEventTemplate SharedTemplate ();

		// +(UAMediaEventTemplate * _Nonnull)sharedTemplateWithSource:(NSString * _Nullable)source withMedium:(NSString * _Nullable)medium __attribute__((warn_unused_result("")));
		[Static]
		[Export("sharedTemplateWithSource:withMedium:")]
		UAMediaEventTemplate SharedTemplate([NullAllowed] string source, [NullAllowed] string medium);

		// +(UAMediaEventTemplate * _Nonnull)consumedTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("consumedTemplate")]
		UAMediaEventTemplate ConsumedTemplate();

		// +(UAMediaEventTemplate * _Nonnull)consumedTemplateWithValueFromString:(NSString * _Nullable)valueString __attribute__((warn_unused_result("")));
		[Static]
		[Export("consumedTemplateWithValueFromString:")]
		UAMediaEventTemplate ConsumedTemplate([NullAllowed] string valueString);

		// +(UAMediaEventTemplate * _Nonnull)consumedTemplateWithValue:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Static]
		[Export("consumedTemplateWithValue:")]
		UAMediaEventTemplate ConsumedTemplate([NullAllowed] NSNumber value);

		// -(UACustomEvent * _Nonnull)createEvent __attribute__((warn_unused_result("")));
		[Export("createEvent")]
		UACustomEvent CreateEvent ();
	}

	// @interface UANativeBridge : NSObject <WKNavigationDelegate>
	[BaseType(typeof(NSObject))]
	interface UANativeBridge : IWKNavigationDelegate
	{
		[Wrap("WeakNativeBridgeDelegate")]
		[NullAllowed]
		IUANativeBridgeDelegate NativeBridgeDelegate { get; set; }

		// @property (nonatomic, weak) id<UANativeBridgeDelegate> _Nullable nativeBridgeDelegate;
		[NullAllowed, Export("nativeBridgeDelegate", ArgumentSemantic.Weak)]
		NSObject WeakNativeBridgeDelegate { get; set; }

		[Wrap("WeakForwardNavigationDelegate")]
		[NullAllowed]
		IUANavigationDelegate ForwardNavigationDelegate { get; set; }

		// @property (nonatomic, weak) id<UANavigationDelegate> _Nullable forwardNavigationDelegate;
		[NullAllowed, Export("forwardNavigationDelegate", ArgumentSemantic.Weak)]
		NSObject WeakForwardNavigationDelegate { get; set; }

		[Wrap("WeakJavaScriptCommandDelegate")]
		[NullAllowed]
		IUAJavaScriptCommandDelegate JavaScriptCommandDelegate { get; set; }

		// @property (nonatomic, weak) id<UAJavaScriptCommandDelegate> _Nullable javaScriptCommandDelegate;
		[NullAllowed, Export("javaScriptCommandDelegate", ArgumentSemantic.Weak)]
		NSObject WeakJavaScriptCommandDelegate { get; set; }

		[Wrap("WeakNativeBridgeExtensionDelegate")]
		[NullAllowed]
		IUANativeBridgeExtensionDelegate NativeBridgeExtensionDelegate { get; set; }

		// @property (nonatomic, weak) id<UANativeBridgeExtensionDelegate> _Nullable nativeBridgeExtensionDelegate;
		[NullAllowed, Export("nativeBridgeExtensionDelegate", ArgumentSemantic.Weak)]
		NSObject WeakNativeBridgeExtensionDelegate { get; set; }
	}

	// @protocol UANativeBridgeDelegate
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface UANativeBridgeDelegate
	{
		// @required -(void)close;
		[Abstract]
		[Export("close")]
		void Close();
	}

	interface IUANativeBridgeDelegate { };

	// @interface UANotificationCategories : NSObject
	[BaseType(typeof(NSObject))]
	interface UANotificationCategories
	{
		// +(NSSet<UNNotificationCategory *> * _Nonnull)defaultCategories __attribute__((warn_unused_result("")));
		[Static]
		[Export("defaultCategories")]
		NSSet<UNNotificationCategory> DefaultCategories ();

		// +(NSSet<UNNotificationCategory *> * _Nonnull)defaultCategoriesWithRequireAuth:(BOOL)requireAuth __attribute__((warn_unused_result("")));
		[Static]
		[Export("defaultCategoriesWithRequireAuth:")]
		NSSet<UNNotificationCategory> DefaultCategories(bool requireAuth);

		// +(NSSet<UNNotificationCategory *> * _Nonnull)createCategoriesFromFile:(NSString * _Nonnull)path __attribute__((warn_unused_result("")));
		[Static]
		[Export("createCategoriesFromFile:")]
		NSSet<UNNotificationCategory> CreateCategoriesFromFile(string path);

		// +(UNNotificationCategory * _Nullable)createCategory:(NSString * _Nonnull)categoryId actions:(NSArray<NSDictionary *> * _Nonnull)actionDefinitions __attribute__((warn_unused_result("")));
		[Static]
		[Export("createCategory:actions:")]
		[return: NullAllowed]
		UNNotificationCategory CreateCategory(string categoryId, NSDictionary[] actionDefinitions);

		// +(UNNotificationCategory * _Nullable)createCategory:(NSString * _Nonnull)categoryId actions:(NSArray<NSDictionary *> * _Nonnull)actionDefinitions hiddenPreviewsBodyPlaceholder:(NSString * _Nonnull)hiddenPreviewsBodyPlaceholder __attribute__((warn_unused_result("")));
		[Static]
		[Export("createCategory:actions:hiddenPreviewsBodyPlaceholder:")]
		[return: NullAllowed]
		UNNotificationCategory CreateCategory(string categoryId, NSDictionary[] actionDefinitions, string hiddenPreviewsBodyPlaceholder);
	}

	// @interface UAPrivacyManager : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAPrivacyManager
	{
		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull changeEvent;
		[Static]
		[Export("changeEvent")]
		string ChangeEvent { get; }

		// @property (nonatomic) UAFeatures enabledFeatures;
		[Export("enabledFeatures", ArgumentSemantic.Assign)]
		UAFeatures EnabledFeatures { get; set; }

		// -(void)enableFeatures:(UAFeatures)features;
		[Export("enableFeatures:")]
		void EnableFeatures(UAFeatures features);

		// -(void)disableFeatures:(UAFeatures)features;
		[Export("disableFeatures:")]
		void DisableFeatures(UAFeatures features);

		// -(BOOL)isEnabled:(UAFeatures)feature __attribute__((warn_unused_result("")));
		[Export("isEnabled:")]
		bool IsEnabled(UAFeatures feature);

		// -(BOOL)isAnyFeatureEnabled __attribute__((warn_unused_result("")));
		[Export("isAnyFeatureEnabled")]
		bool IsAnyFeatureEnabled { get; }
	}

	// @interface UAProximityRegion : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAProximityRegion
	{
		// +(UAProximityRegion * _Nullable)proximityRegionWithID:(NSString * _Nonnull)proximityID major:(double)major minor:(double)minor __attribute__((warn_unused_result("")));
		[Static]
		[Export("proximityRegionWithID:major:minor:")]
		[return: NullAllowed]
		UAProximityRegion ProximityRegion(string proximityID, double major, double minor);

		// +(UAProximityRegion * _Nullable)proximityRegionWithID:(NSString * _Nonnull)proximityID major:(double)major minor:(double)minor rssi:(double)rssi __attribute__((warn_unused_result("")));
		[Static]
		[Export("proximityRegionWithID:major:minor:rssi:")]
		[return: NullAllowed]
		UAProximityRegion ProximityRegion(string proximityID, double major, double minor, double rssi);

		// +(UAProximityRegion * _Nullable)proximityRegionWithID:(NSString * _Nonnull)proximityID major:(double)major minor:(double)minor latitude:(double)latitude longitude:(double)longitude __attribute__((warn_unused_result("")));
		[Static]
		[Export("proximityRegionWithID:major:minor:latitude:longitude:")]
		[return: NullAllowed]
		UAProximityRegion ProximityRegion(string proximityID, double major, double minor, double latitude, double longitude);

		// +(UAProximityRegion * _Nullable)proximityRegionWithID:(NSString * _Nonnull)proximityID major:(double)major minor:(double)minor rssi:(double)rssi latitude:(double)latitude longitude:(double)longitude __attribute__((warn_unused_result("")));
		[Static]
		[Export("proximityRegionWithID:major:minor:rssi:latitude:longitude:")]
		[return: NullAllowed]
		UAProximityRegion ProximityRegion(string proximityID, double major, double minor, double rssi, double latitude, double longitude);
	}

	// @interface UAChannelScopes : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAChannelScopes
	{
		// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull values;
		[Export("values", ArgumentSemantic.Copy)]
		NSNumber[] Values { get; }
	}

	// @interface UAPush : NSObject <UAComponent, UAPushProtocol>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAPush : IUAComponent
	{
        // @property (readonly, nonatomic, strong, class) UAPush * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        UAPush Shared { get; }

        // @property (readonly, nonatomic, class) NSNotificationName _Nonnull receivedNotificationResponseEvent;
        [Static]
        [Export("receivedNotificationResponseEvent")]
        string ReceivedNotificationResponseEvent { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull receivedNotificationResponseEventResponseKey;
        [Static]
        [Export("receivedNotificationResponseEventResponseKey")]
        string ReceivedNotificationResponseEventResponseKey { get; }

        // @property (readonly, nonatomic, class) NSNotificationName _Nonnull receivedForegroundNotificationEvent;
        [Static]
        [Export("receivedForegroundNotificationEvent")]
        string ReceivedForegroundNotificationEvent { get; }

        // @property (readonly, nonatomic, class) NSNotificationName _Nonnull receivedBackgroundNotificationEvent;
        [Static]
        [Export("receivedBackgroundNotificationEvent")]
        string ReceivedBackgroundNotificationEvent { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull quietTimeStartKey;
        [Static]
        [Export("quietTimeStartKey")]
        string QuietTimeStartKey { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull quietTimeEndKey;
        [Static]
        [Export("quietTimeEndKey")]
        string QuietTimeEndKey { get; }

        // @property (getter = isComponentEnabled, nonatomic) BOOL componentEnabled;
        [Export("componentEnabled")]
        bool ComponentEnabled { [Bind("isComponentEnabled")] get; set; }

        // @property (nonatomic) BOOL backgroundPushNotificationsEnabled;
        [Export("backgroundPushNotificationsEnabled")]
        bool BackgroundPushNotificationsEnabled { get; set; }

        // @property (nonatomic) BOOL userPushNotificationsEnabled;
        [Export("userPushNotificationsEnabled")]
        bool UserPushNotificationsEnabled { get; set; }

        // @property (nonatomic) BOOL requestExplicitPermissionWhenEphemeral;
        [Export("requestExplicitPermissionWhenEphemeral")]
        bool RequestExplicitPermissionWhenEphemeral { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable deviceToken;
        [NullAllowed, Export("deviceToken")]
        string DeviceToken { get; }

        // @property (nonatomic) UANotificationOptions notificationOptions;
        [Export("notificationOptions", ArgumentSemantic.Assign)]
        UANotificationOptions NotificationOptions { get; set; }

        // @property (copy, nonatomic) NSSet<UNNotificationCategory *> * _Nonnull customCategories;
        [Export("customCategories", ArgumentSemantic.Copy)]
        NSSet<UNNotificationCategory> CustomCategories { get; set; }

        // @property (readonly, copy, nonatomic) NSSet<UNNotificationCategory *> * _Nonnull combinedCategories;
        [Export("combinedCategories", ArgumentSemantic.Copy)]
        NSSet<UNNotificationCategory> CombinedCategories { get; }
                
        // @property (nonatomic) BOOL requireAuthorizationForDefaultCategories;
        [Export("requireAuthorizationForDefaultCategories")]
        bool RequireAuthorizationForDefaultCategories { get; set; }

        [Wrap("WeakPushNotificationDelegate")]
        [NullAllowed]
        IUAPushNotificationDelegate PushNotificationDelegate { get; set; }

        // @property (nonatomic, weak) id<UAPushNotificationDelegate> _Nullable pushNotificationDelegate;
        [NullAllowed, Export("pushNotificationDelegate", ArgumentSemantic.Weak)]
        NSObject WeakPushNotificationDelegate { get; set; }

        [Wrap("WeakRegistrationDelegate")]
        [NullAllowed]
        IUARegistrationDelegate RegistrationDelegate { get; set; }

        // @property (nonatomic, weak) id<UARegistrationDelegate> _Nullable registrationDelegate;
        [NullAllowed, Export("registrationDelegate", ArgumentSemantic.Weak)]
        NSObject WeakRegistrationDelegate { get; set; }

        // @property (readonly, nonatomic, strong) UNNotificationResponse * _Nullable launchNotificationResponse;
        [NullAllowed, Export("launchNotificationResponse", ArgumentSemantic.Strong)]
        UNNotificationResponse LaunchNotificationResponse { get; }

        // @property (readonly, nonatomic) UAAuthorizedNotificationSettings authorizedNotificationSettings;
        [Export("authorizedNotificationSettings")]
        UAAuthorizedNotificationSettings AuthorizedNotificationSettings { get; }

        // @property (readonly, nonatomic) UAAuthorizationStatus authorizationStatus;
        [Export("authorizationStatus")]
        UAAuthorizationStatus AuthorizationStatus { get; }

        // @property (readonly, nonatomic) BOOL userPromptedForNotifications;
        [Export("userPromptedForNotifications")]
        bool UserPromptedForNotifications { get; }

        // @property (nonatomic) UNNotificationPresentationOptions defaultPresentationOptions;
        [Export("defaultPresentationOptions", ArgumentSemantic.Assign)]
        UNNotificationPresentationOptions DefaultPresentationOptions { get; set; }

        // -(void)enableUserPushNotificationsWithCompletionHandler:(void (^ _Nonnull)(BOOL))completionHandler;
        [Export("enableUserPushNotificationsWithCompletionHandler:")]
        void EnableUserPushNotifications(Action<bool> completionHandler);

        // @property (readonly, nonatomic) BOOL isPushNotificationsOptedIn;
        [Export("isPushNotificationsOptedIn")]
        bool IsPushNotificationsOptedIn { get; }

        // @property (nonatomic) NSInteger badgeNumber;
        [Export("badgeNumber")]
        nint BadgeNumber { get; set; }

        // @property (nonatomic) BOOL autobadgeEnabled;
        [Export("autobadgeEnabled")]
        bool AutobadgeEnabled { get; set; }

        // -(void)resetBadge;
        [Export("resetBadge")]
        void ResetBadge();

        // @property (readonly, copy, nonatomic) NSDictionary * _Nullable quietTime;
        [NullAllowed, Export("quietTime", ArgumentSemantic.Copy)]
        NSDictionary QuietTime { get; }

        // @property (nonatomic, strong) NSTimeZone * _Nullable timeZone;
        [NullAllowed, Export("timeZone", ArgumentSemantic.Strong)]
        NSTimeZone TimeZone { get; set; }

        // @property (nonatomic) BOOL quietTimeEnabled;
        [Export("quietTimeEnabled")]
        bool QuietTimeEnabled { get; set; }

        // -(void)setQuietTimeStartHour:(NSInteger)startHour startMinute:(NSInteger)startMinute endHour:(NSInteger)endHour endMinute:(NSInteger)endMinute;
        [Export("setQuietTimeStartHour:startMinute:endHour:endMinute:")]
        void SetQuietTimeStartHour(nint startHour, nint startMinute, nint endHour, nint endMinute);

        // -(void)updateRegistration;
        [Export("updateRegistration")]
        void UpdateRegistration();
	}

	// @protocol UAPushNotificationDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface UAPushNotificationDelegate
	{
		// @optional -(void)receivedForegroundNotification:(NSDictionary * _Nonnull)userInfo completionHandler:(void (^ _Nonnull)(void))completionHandler;
		[Export("receivedForegroundNotification:completionHandler:")]
		void ReceivedForegroundNotification(NSDictionary userInfo, Action completionHandler);

		// @optional -(void)receivedBackgroundNotification:(NSDictionary * _Nonnull)userInfo completionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler;
		[Export("receivedBackgroundNotification:completionHandler:")]
		void ReceivedBackgroundNotification(NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler);

		// @optional -(void)receivedNotificationResponse:(UNNotificationResponse * _Nonnull)notificationResponse completionHandler:(void (^ _Nonnull)(void))completionHandler;
		[Export("receivedNotificationResponse:completionHandler:")]
		void ReceivedNotificationResponse(UNNotificationResponse notificationResponse, Action completionHandler);

		// @optional -(UNNotificationPresentationOptions)extendPresentationOptions:(UNNotificationPresentationOptions)options notification:(UNNotification * _Nonnull)notification __attribute__((warn_unused_result("")));
		[Export("extendPresentationOptions:notification:")]
		UNNotificationPresentationOptions ExtendPresentationOptions(UNNotificationPresentationOptions options, UNNotification notification);
        
        // @optional -(UNNotificationPresentationOptions)extendPresentationOptions:(UNNotificationPresentationOptions)options notification:(UNNotification * _Nonnull)notification completionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler;
        [Export("extendPresentationOptions:notification:completionHandler:")]
        UNNotificationPresentationOptions ExtendPresentationOptions(UNNotificationPresentationOptions options, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);
	}

	interface IUAPushNotificationDelegate { };

	// @interface UARegionEvent : NSObject <UAEvent>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UARegionEvent : IUAEvent
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull regionIDKey;
		[Static]
		[Export("regionIDKey")]
		string RegionIDKey { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull regionID;
		[Export("regionID")]
		string RegionID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull source;
		[Export("source")]
		string Source { get; }

		// @property (readonly, nonatomic, strong) UACircularRegion * _Nullable circularRegion;
		[NullAllowed, Export("circularRegion", ArgumentSemantic.Strong)]
		UACircularRegion CircularRegion { get; }

		// @property (readonly, nonatomic, strong) UAProximityRegion * _Nullable proximityRegion;
		[NullAllowed, Export("proximityRegion", ArgumentSemantic.Strong)]
		UAProximityRegion ProximityRegion { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull eventType;
		[Export("eventType")]
		string EventType { get; }

        // @property (readonly, nonatomic) UAEventPriority priority;
        [Export("priority")]
        UAEventPriority Priority { get; }
        
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull data;
		[Export("data", ArgumentSemantic.Copy)]
		NSDictionary Data { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull payload;
		[Export("payload", ArgumentSemantic.Copy)]
		NSDictionary Payload { get; }

		// +(UARegionEvent * _Nullable)regionEventWithRegionID:(NSString * _Nonnull)regionID source:(NSString * _Nonnull)source boundaryEvent:(enum UABoundaryEvent)boundaryEvent __attribute__((warn_unused_result("")));
		[Static]
		[Export("regionEventWithRegionID:source:boundaryEvent:")]
		[return: NullAllowed]
		UARegionEvent RegionEvent(string regionID, string source, UABoundaryEvent boundaryEvent);

		// +(UARegionEvent * _Nullable)regionEventWithRegionID:(NSString * _Nonnull)regionID source:(NSString * _Nonnull)source boundaryEvent:(enum UABoundaryEvent)boundaryEvent circularRegion:(UACircularRegion * _Nullable)circularRegion proximityRegion:(UAProximityRegion * _Nullable)proximityRegion __attribute__((warn_unused_result("")));
		[Static]
		[Export("regionEventWithRegionID:source:boundaryEvent:circularRegion:proximityRegion:")]
		[return: NullAllowed]
		UARegionEvent RegionEvent(string regionID, string source, UABoundaryEvent boundaryEvent, [NullAllowed] UACircularRegion circularRegion, [NullAllowed] UAProximityRegion proximityRegion);
	}

	// @protocol UARegistrationDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface UARegistrationDelegate
	{
		// @optional -(void)notificationRegistrationFinishedWithAuthorizedSettings:(UAAuthorizedNotificationSettings)authorizedSettings categories:(NSSet<UNNotificationCategory *> * _Nonnull)categories status:(UAAuthorizationStatus)status;
		[Export("notificationRegistrationFinishedWithAuthorizedSettings:categories:status:")]
		void NotificationRegistrationFinished(UAAuthorizedNotificationSettings authorizedSettings, NSSet<UNNotificationCategory> categories, UAAuthorizationStatus status);

		// @optional -(void)notificationRegistrationFinishedWithAuthorizedSettings:(UAAuthorizedNotificationSettings)authorizedSettings status:(UAAuthorizationStatus)status;
		[Export("notificationRegistrationFinishedWithAuthorizedSettings:status:")]
		void NotificationRegistrationFinished(UAAuthorizedNotificationSettings authorizedSettings, UAAuthorizationStatus status);

		// @optional -(void)notificationAuthorizedSettingsDidChange:(UAAuthorizedNotificationSettings)authorizedSettings;
		[Export("notificationAuthorizedSettingsDidChange:")]
		void NotificationAuthorizedSettingsDidChange(UAAuthorizedNotificationSettings authorizedSettings);

		// @optional -(void)apnsRegistrationSucceededWithDeviceToken:(NSData * _Nonnull)deviceToken;
		[Export("apnsRegistrationSucceededWithDeviceToken:")]
		void ApnsRegistrationSucceeded(NSData deviceToken);

		// @optional -(void)apnsRegistrationFailedWithError:(NSError * _Nonnull)error;
		[Export("apnsRegistrationFailedWithError:")]
		void ApnsRegistrationFailed(NSError error);
	}

	interface IUARegistrationDelegate { };

	// @interface UARetailEventTemplate : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UARetailEventTemplate
	{
		// @property (nonatomic, strong) NSNumber * _Nullable eventValue;
		[NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
		NSNumber EventValue { get; set; }

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

		// @property (nonatomic) BOOL isNewItem;
		[Export("isNewItem")]
		bool IsNewItem { get; set; }

		// +(UARetailEventTemplate * _Nonnull)browsedTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("browsedTemplate")]
		UARetailEventTemplate BrowsedTemplate();

		// +(UARetailEventTemplate * _Nonnull)browsedTemplateWithValueFromString:(NSString * _Nullable)valueString __attribute__((warn_unused_result("")));
		[Static]
		[Export("browsedTemplateWithValueFromString:")]
		UARetailEventTemplate BrowsedTemplate([NullAllowed] string valueString);

		// +(UARetailEventTemplate * _Nonnull)browsedTemplateWithValue:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Static]
		[Export("browsedTemplateWithValue:")]
		UARetailEventTemplate BrowsedTemplate([NullAllowed] NSNumber value);

		// +(UARetailEventTemplate * _Nonnull)addedToCartTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("addedToCartTemplate")]
		UARetailEventTemplate AddedToCartTemplate();

		// +(UARetailEventTemplate * _Nonnull)addedToCartTemplateWithValueFromString:(NSString * _Nullable)valueString __attribute__((warn_unused_result("")));
		[Static]
		[Export("addedToCartTemplateWithValueFromString:")]
		UARetailEventTemplate AddedToCartTemplate([NullAllowed] string valueString);

		// +(UARetailEventTemplate * _Nonnull)addedToCartTemplateWithValue:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Static]
		[Export("addedToCartTemplateWithValue:")]
		UARetailEventTemplate AddedToCartTemplate([NullAllowed] NSNumber value);

		// +(UARetailEventTemplate * _Nonnull)starredProductTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("starredProductTemplate")]
		UARetailEventTemplate StarredProductTemplate();

		// +(UARetailEventTemplate * _Nonnull)starredProductTemplateWithValueFromString:(NSString * _Nullable)valueString __attribute__((warn_unused_result("")));
		[Static]
		[Export("starredProductTemplateWithValueFromString:")]
		UARetailEventTemplate StarredProductTemplate([NullAllowed] string valueString);

		// +(UARetailEventTemplate * _Nonnull)starredProductTemplateWithValue:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Static]
		[Export("starredProductTemplateWithValue:")]
		UARetailEventTemplate StarredProductTemplate([NullAllowed] NSNumber value);

		// +(UARetailEventTemplate * _Nonnull)purchasedTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("purchasedTemplate")]
		UARetailEventTemplate PurchasedTemplate();

		// +(UARetailEventTemplate * _Nonnull)purchasedTemplateWithValueFromString:(NSString * _Nullable)valueString __attribute__((warn_unused_result("")));
		[Static]
		[Export("purchasedTemplateWithValueFromString:")]
		UARetailEventTemplate PurchasedTemplate([NullAllowed] string valueString);

		// +(UARetailEventTemplate * _Nonnull)purchasedTemplateWithValue:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Static]
		[Export("purchasedTemplateWithValue:")]
		UARetailEventTemplate PurchasedTemplate([NullAllowed] NSNumber value);

		// +(UARetailEventTemplate * _Nonnull)sharedProductTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("sharedProductTemplate")]
		UARetailEventTemplate SharedProductTemplate();

		// +(UARetailEventTemplate * _Nonnull)sharedProductTemplateWithValueFromString:(NSString * _Nullable)valueString __attribute__((warn_unused_result("")));
		[Static]
		[Export("sharedProductTemplateWithValueFromString:")]
		UARetailEventTemplate SharedProductTemplate([NullAllowed] string valueString);

		// +(UARetailEventTemplate * _Nonnull)sharedProductTemplateWithValue:(NSNumber * _Nullable)value __attribute__((warn_unused_result("")));
		[Static]
		[Export("sharedProductTemplateWithValue:")]
		UARetailEventTemplate SharedProductTemplate([NullAllowed] NSNumber value);

		// +(UARetailEventTemplate * _Nonnull)sharedProductTemplateWithSource:(NSString * _Nullable)source withMedium:(NSString * _Nullable)medium __attribute__((warn_unused_result("")));
		[Static]
		[Export("sharedProductTemplateWithSource:withMedium:")]
		UARetailEventTemplate SharedProductTemplate([NullAllowed] string source, [NullAllowed] string medium);

		// +(UARetailEventTemplate * _Nonnull)sharedProductTemplateWithValueFromString:(NSString * _Nullable)valueString withSource:(NSString * _Nullable)source withMedium:(NSString * _Nullable)medium __attribute__((warn_unused_result("")));
		[Static]
		[Export("sharedProductTemplateWithValueFromString:withSource:withMedium:")]
		UARetailEventTemplate SharedProductTemplate([NullAllowed] string valueString, [NullAllowed] string source, [NullAllowed] string medium);

		// +(UARetailEventTemplate * _Nonnull)sharedProductTemplateWithValue:(NSNumber * _Nullable)value withSource:(NSString * _Nullable)source withMedium:(NSString * _Nullable)medium __attribute__((warn_unused_result("")));
		[Static]
		[Export("sharedProductTemplateWithValue:withSource:withMedium:")]
		UARetailEventTemplate SharedProductTemplate([NullAllowed] NSNumber value, [NullAllowed] string source, [NullAllowed] string medium);

		// +(UARetailEventTemplate * _Nonnull)wishlistTemplate __attribute__((warn_unused_result("")));
		[Static]
		[Export("wishlistTemplate")]
		UARetailEventTemplate WishlistTemplate();

		// +(UARetailEventTemplate * _Nonnull)wishlistTemplateWithName:(NSString * _Nullable)name wishlistID:(NSString * _Nullable)wishlistID __attribute__((warn_unused_result("")));
		[Static]
		[Export("wishlistTemplateWithName:wishlistID:")]
		UARetailEventTemplate WishlistTemplate([NullAllowed] string name, [NullAllowed] string wishlistID);

		// -(UACustomEvent * _Nonnull)createEvent __attribute__((warn_unused_result("")));
		[Export("createEvent")]
		UACustomEvent CreateEvent();
	}

	// @interface UARuntimeConfig : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UARuntimeConfig
	{
		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull configUpdatedEvent;
		[Static]
		[Export("configUpdatedEvent")]
		string ConfigUpdatedEvent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appKey;
		[Export("appKey")]
		string AppKey { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appSecret;
		[Export("appSecret")]
		string AppSecret { get; }

		// @property (readonly, nonatomic) enum UALogLevel logLevel;
		[Export("logLevel")]
		UALogLevel LogLevel { get; }

		// @property (readonly, nonatomic) BOOL inProduction;
		[Export("inProduction")]
		bool InProduction { get; }

        // @property (readonly, nonatomic) BOOL autoPauseInAppAutomationOnLaunch;
        [Export("autoPauseInAppAutomationOnLaunch")]
        bool AutoPauseInAppAutomationOnLaunch { get; }

		// @property (readonly, nonatomic) BOOL isAutomaticSetupEnabled;
		[Export("isAutomaticSetupEnabled")]
		bool IsAutomaticSetupEnabled { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable URLAllowList;
		[NullAllowed, Export("URLAllowList", ArgumentSemantic.Copy)]
		string[] URLAllowList { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable URLAllowListScopeJavaScriptInterface;
		[NullAllowed, Export("URLAllowListScopeJavaScriptInterface", ArgumentSemantic.Copy)]
		string[] URLAllowListScopeJavaScriptInterface { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable URLAllowListScopeOpenURL;
		[NullAllowed, Export("URLAllowListScopeOpenURL", ArgumentSemantic.Copy)]
		string[] URLAllowListScopeOpenURL { get; }

		// @property (readonly, nonatomic) BOOL suppressAllowListError;
		[Export("suppressAllowListError")]
		bool SuppressAllowListError { get; }

		// @property (readonly, nonatomic) BOOL isAnalyticsEnabled;
		[Export("isAnalyticsEnabled")]
		bool IsAnalyticsEnabled { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable messageCenterStyleConfig;
		[NullAllowed, Export("messageCenterStyleConfig")]
		string MessageCenterStyleConfig { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable itunesID;
		[NullAllowed, Export("itunesID")]
		string ItunesID { get; }

		// @property (readonly, nonatomic) BOOL clearUserOnAppRestore;
		[Export("clearUserOnAppRestore")]
		bool ClearUserOnAppRestore { get; }

		// @property (readonly, nonatomic) BOOL clearNamedUserOnAppRestore;
		[Export("clearNamedUserOnAppRestore")]
		bool ClearNamedUserOnAppRestore { get; }

		// @property (readonly, nonatomic) BOOL isChannelCaptureEnabled;
		[Export("isChannelCaptureEnabled")]
		bool IsChannelCaptureEnabled { get; }

		// @property (readonly, nonatomic) BOOL isChannelCreationDelayEnabled;
		[Export("isChannelCreationDelayEnabled")]
		bool IsChannelCreationDelayEnabled { get; }

		// @property (readonly, nonatomic) BOOL isExtendedBroadcastsEnabled;
		[Export("isExtendedBroadcastsEnabled")]
		bool IsExtendedBroadcastsEnabled { get; }

		// @property (readonly, nonatomic) BOOL requestAuthorizationToUseNotifications;
		[Export("requestAuthorizationToUseNotifications")]
		bool RequestAuthorizationToUseNotifications { get; }

		// @property (readonly, nonatomic) BOOL requireInitialRemoteConfigEnabled;
		[Export("requireInitialRemoteConfigEnabled")]
		bool RequireInitialRemoteConfigEnabled { get; }

		// @property (readonly, nonatomic) UAFeatures enabledFeatures;
		[Export("enabledFeatures")]
		UAFeatures EnabledFeatures { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable deviceAPIURL;
		[NullAllowed, Export("deviceAPIURL")]
		string DeviceAPIURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable remoteDataAPIURL;
		[NullAllowed, Export("remoteDataAPIURL")]
		string RemoteDataAPIURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable analyticsURL;
		[NullAllowed, Export("analyticsURL")]
		string AnalyticsURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable chatURL;
		[NullAllowed, Export("chatURL")]
		string ChatURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable chatWebSocketURL;
		[NullAllowed, Export("chatWebSocketURL")]
		string ChatWebSocketURL { get; }
	}


	// @interface SearchEventTemplate : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SearchEventTemplate
	{
		// @property (nonatomic, strong) NSNumber * _Nullable eventValue;
		[NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
		NSNumber EventValue { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable type;
		[NullAllowed, Export("type")]
		string Type { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable identifier;
		[NullAllowed, Export("identifier")]
		string Identifier { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable category;
		[NullAllowed, Export("category")]
		string Category { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable query;
		[NullAllowed, Export("query")]
		string Query { get; set; }

		// @property (nonatomic) NSInteger totalResults;
		[Export("totalResults")]
		nint TotalResults { get; set; }

		// +(SearchEventTemplate * _Nonnull)templateWithValue:(NSNumber * _Nonnull)value __attribute__((warn_unused_result("")));
		[Static]
		[Export("templateWithValue:")]
		SearchEventTemplate Template(NSNumber value);

		// +(SearchEventTemplate * _Nonnull)template __attribute__((warn_unused_result("")));
		[Static]
		[Export("template")]
		SearchEventTemplate Template();

		// -(UACustomEvent * _Nonnull)createEvent __attribute__((warn_unused_result("")));
		[Export("createEvent")]
		UACustomEvent CreateEvent();
	}

    // @interface UASubscriptionListEditor : NSObject
    [BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UASubscriptionListEditor
	{
		// -(void)subscribe:(NSString * _Nonnull)subscriptionListID;
		[Export("subscribe:")]
		void Subscribe(string subscriptionListID);

		// -(void)unsubscribe:(NSString * _Nonnull)subscriptionListID;
		[Export("unsubscribe:")]
		void Unsubscribe(string subscriptionListID);

		// -(void)apply;
		[Export("apply")]
		void Apply();
	}

	// @interface UATagEditor : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UATagEditor
	{
		// -(void)addTags:(NSArray<NSString *> * _Nonnull)tags;
		[Export("addTags:")]
		void AddTags(string[] tags);

		// -(void)addTag:(NSString * _Nonnull)tag;
		[Export("addTag:")]
		void AddTag(string tag);

		// -(void)removeTags:(NSArray<NSString *> * _Nonnull)tags;
		[Export("removeTags:")]
		void RemoveTags(string[] tags);

		// -(void)removeTag:(NSString * _Nonnull)tag;
		[Export("removeTag:")]
		void RemoveTag(string tag);

		// -(void)setTags:(NSArray<NSString *> * _Nonnull)tags;
		[Export("setTags:")]
		void SetTags(string[] tags);

		// -(void)clearTags;
		[Export("clearTags")]
		void ClearTags();

		// -(void)apply;
		[Export("apply")]
		void Apply();
	}

	// @interface UATagGroupsEditor : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UATagGroupsEditor
	{
		// -(void)addTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)group;
		[Export("addTags:group:")]
		void AddTags(string[] tags, string group);

		// -(void)removeTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)group;
		[Export("removeTags:group:")]
		void RemoveTags(string[] tags, string group);

		// -(void)setTags:(NSArray<NSString *> * _Nonnull)tags group:(NSString * _Nonnull)group;
		[Export("setTags:group:")]
		void SetTags(string[] tags, string group);

		// -(void)apply;
		[Export("apply")]
		void Apply();
	}

    // @protocol UANavigationDelegate <WKNavigationDelegate>
    [Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface UANavigationDelegate : IWKNavigationDelegate
	{
		// @optional -(void)closeWindow:(BOOL)animated;
		[Export("closeWindow:")]
		void CloseWindow(bool animated);
	}

	interface IUANavigationDelegate { };

    // @interface UAURLAllowList : NSObject <UAURLAllowListProtocol>
    [BaseType(typeof(NSObject))]
	interface UAURLAllowList
	{
		// +(UAURLAllowList * _Nonnull)allowListWithConfig:(UARuntimeConfig * _Nonnull)config __attribute__((warn_unused_result("")));
		[Static]
		[Export("allowListWithConfig:")]
		UAURLAllowList AllowList(UARuntimeConfig config);

		[Wrap("WeakDelegate")]
		[NullAllowed]
		IUAURLAllowListDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<UAURLAllowListDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(BOOL)addEntry:(NSString * _Nonnull)patternString __attribute__((warn_unused_result("")));
		[Export("addEntry:")]
		bool AddEntry(string patternString);

		// -(BOOL)addEntry:(NSString * _Nonnull)patternString scope:(UAURLAllowListScope)scope __attribute__((warn_unused_result("")));
		[Export("addEntry:scope:")]
		bool AddEntry(string patternString, UAURLAllowListScope scope);

		// -(BOOL)isAllowed:(NSURL * _Nullable)url __attribute__((warn_unused_result("")));
		[Export("isAllowed:")]
		bool IsAllowed([NullAllowed] NSUrl url);

		// -(BOOL)isAllowed:(NSURL * _Nullable)url scope:(UAURLAllowListScope)scope __attribute__((warn_unused_result("")));
		[Export("isAllowed:scope:")]
		bool IsAllowed([NullAllowed] NSUrl url, UAURLAllowListScope scope);
	}

	// @protocol UAURLAllowListDelegate
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface UAURLAllowListDelegate
	{
		// @required -(BOOL)allowURL:(NSURL * _Nonnull)url scope:(UAURLAllowListScope)scope __attribute__((warn_unused_result("")));
		[Abstract]
		[Export("allowURL:scope:")]
		bool Scope(NSUrl url, UAURLAllowListScope scope);
	}

	interface IUAURLAllowListDelegate { };

	// @interface UAUtils : NSObject
	[BaseType(typeof(NSObject))]
	interface UAUtils
	{
		// +(BOOL)float:(CGFloat)float1 isEqualToFloat:(CGFloat)float2 withAccuracy:(CGFloat)accuracy __attribute__((warn_unused_result("")));
		[Static]
		[Export("float:isEqualToFloat:withAccuracy:")]
		bool Float(nfloat float1, nfloat float2, nfloat accuracy);

		// +(NSString * _Nullable)deviceModelName __attribute__((warn_unused_result("")));
		[Static]
		[Export("deviceModelName")]
		[return: NullAllowed]
		string DeviceModelName();

		// +(NSString * _Nullable)bundleShortVersionString __attribute__((warn_unused_result("")));
		[Static]
		[Export("bundleShortVersionString")]
		[return: NullAllowed]
		string BundleShortVersionString();

		// +(NSString * _Nullable)carrierName __attribute__((warn_unused_result("")));
		[Static]
		[Export("carrierName")]
		[return: NullAllowed]
		string CarrierName();

		// +(NSString * _Nonnull)connectionType __attribute__((warn_unused_result("")));
		[Static]
		[Export("connectionType")]
		string ConnectionType();

		// +(enum NSComparisonResult)compareVersion:(NSString * _Nonnull)fromVersion toVersion:(NSString * _Nonnull)toVersion __attribute__((warn_unused_result("")));
		[Static]
		[Export("compareVersion:toVersion:")]
		NSComparisonResult CompareVersion(string fromVersion, string toVersion);

		// +(NSDateFormatter * _Nonnull)ISODateFormatterUTC __attribute__((warn_unused_result("")));
		[Static]
		[Export("ISODateFormatterUTC")]
		NSDateFormatter ISODateFormatterUTC();

		// +(NSDateFormatter * _Nonnull)ISODateFormatterUTCWithDelimiter __attribute__((warn_unused_result("")));
		[Static]
		[Export("ISODateFormatterUTCWithDelimiter")]
		NSDateFormatter ISODateFormatterUTCWithDelimiter();

		// +(NSDate * _Nullable)parseISO8601DateFromString:(NSString * _Nonnull)from __attribute__((warn_unused_result("")));
		[Static]
		[Export("parseISO8601DateFromString:")]
		[return: NullAllowed]
		NSDate ParseISO8601DateFromString(string from);

		// +(UIWindow * _Nullable)mainWindow __attribute__((warn_unused_result(""))) __attribute__((availability(macos_app_extension, unavailable))) __attribute__((availability(tvos_app_extension, unavailable))) __attribute__((availability(watchos_app_extension, unavailable))) __attribute__((availability(ios_app_extension, unavailable)));
		[Static]
		[Export("mainWindow")]
		[return: NullAllowed]
		UIWindow MainWindow();

		// +(UIWindow * _Nullable)mainWindow:(UIWindowScene * _Nonnull)scene __attribute__((warn_unused_result(""))) __attribute__((availability(tvos_app_extension, unavailable))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(ios, introduced=13)));
		[Static]
		[Export("mainWindow:")]
		[return: NullAllowed]
		UIWindow MainWindow(UIWindowScene scene);

		// +(UIWindow * _Nullable)windowForView:(UIView * _Nonnull)view __attribute__((warn_unused_result("")));
		[Static]
		[Export("windowForView:")]
		[return: NullAllowed]
		UIWindow WindowForView(UIView view);

		// +(UIBackgroundFetchResult)mergeFetchResults:(NSArray<NSNumber *> * _Nonnull)results __attribute__((warn_unused_result("")));
		[Static]
		[Export("mergeFetchResults:")]
		UIBackgroundFetchResult MergeFetchResults(NSNumber[] results);

		// +(BOOL)isSilentPush:(NSDictionary * _Nonnull)notification __attribute__((warn_unused_result("")));
		[Static]
		[Export("isSilentPush:")]
		bool IsSilentPush(NSDictionary notification);

		// +(BOOL)isAlertingPush:(NSDictionary * _Nonnull)notification __attribute__((warn_unused_result("")));
		[Static]
		[Export("isAlertingPush:")]
		bool IsAlertingPush(NSDictionary notification);

		// +(NSString * _Nonnull)deviceTokenStringFromDeviceToken:(NSData * _Nonnull)token __attribute__((warn_unused_result("")));
		[Static]
		[Export("deviceTokenStringFromDeviceToken:")]
		string DeviceTokenStringFromDeviceToken(NSData token);

		// +(NSData * _Nonnull)sha256DigestWithString:(NSString * _Nonnull)input __attribute__((warn_unused_result("")));
		[Static]
		[Export("sha256DigestWithString:")]
		NSData Sha256Digest(string input);

		// +(NSString * _Nonnull)sha256HashWithString:(NSString * _Nonnull)input __attribute__((warn_unused_result("")));
		[Static]
		[Export("sha256HashWithString:")]
		string Sha256Hash(string input);

		// +(NSString * _Nullable)authHeaderStringWithName:(NSString * _Nonnull)username password:(NSString * _Nonnull)password __attribute__((warn_unused_result("")));
		[Static]
		[Export("authHeaderStringWithName:password:")]
		[return: NullAllowed]
		string AuthHeaderString(string username, string password);
        
        // +(NSURL * _Nullable)parseURL:(NSString * _Nonnull)value __attribute__((warn_unused_result("")));
        [Static]
        [Export("parseURL:")]
        [return: NullAllowed]
        NSUrl ParseURL(string value);

        // +(NSString * _Nonnull)permissionString:(enum UAPermission)permission __attribute__((warn_unused_result("")));
        [Static]
        [Export("permissionString:")]
        string PermissionString(UAPermission permission);

        // +(NSString * _Nonnull)permissionStatusString:(enum UAPermissionStatus)status __attribute__((warn_unused_result("")));
        [Static]
        [Export("permissionStatusString:")]
        string PermissionStatusString(UAPermissionStatus status);
	}

	// @interface UAVersionMatcher : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface UAVersionMatcher
	{
		// -(instancetype _Nullable)initWithVersionConstraint:(NSString * _Nonnull)versionConstraint __attribute__((objc_designated_initializer));
		[Export("initWithVersionConstraint:")]
		[DesignatedInitializer]
		IntPtr Constructor(string versionConstraint);

		// +(UAVersionMatcher * _Nullable)matcherWithVersionConstraint:(NSString * _Nonnull)versionConstraint __attribute__((warn_unused_result("")));
		[Static]
		[Export("matcherWithVersionConstraint:")]
		[return: NullAllowed]
		UAVersionMatcher Matcher(string versionConstraint);

		// -(BOOL)evaluateObject:(id _Nullable)value __attribute__((warn_unused_result("")));
		[Export("evaluateObject:")]
		bool EvaluateObject([NullAllowed] NSObject value);

		// +(BOOL)isExactVersion:(NSString * _Nonnull)versionConstraint __attribute__((warn_unused_result("")));
		[Static]
		[Export("isExactVersion:")]
		bool IsExactVersion(string versionConstraint);

		// +(BOOL)isSubVersion:(NSString * _Nonnull)versionConstraint __attribute__((warn_unused_result("")));
		[Static]
		[Export("isSubVersion:")]
		bool IsSubVersion(string versionConstraint);

		// +(BOOL)isVersionRange:(NSString * _Nonnull)versionConstraint __attribute__((warn_unused_result("")));
		[Static]
		[Export("isVersionRange:")]
		bool IsVersionRange(string versionConstraint);
	}


    // @interface UAWebView : WKWebView
        [NoTV]
        [BaseType(typeof(NSObject))]
        interface UAWebView
        {
            // -(WKNavigation * _Nullable)loadRequest:(NSURLRequest * _Nonnull)request;
            [Export("loadRequest:")]
            [return: NullAllowed]
            WKNavigation LoadRequest(NSUrlRequest request);
        }

        // @protocol UAAutomationAudienceCheckerProtocol
        [Protocol, Model]
        [BaseType(typeof(NSObject))]
        interface UAAutomationAudienceCheckerProtocol
        {
            // @required -(void)evaluateWithAudience:(id _Nonnull)audience isNewUserEvaluationDate:(NSDate * _Nonnull)isNewUserEvaluationDate contactID:(NSString * _Nullable)contactID completionHandler:(void (^ _Nonnull)(BOOL))completionHandler;
            [Abstract]
            [Export("evaluateWithAudience:isNewUserEvaluationDate:contactID:completionHandler:")]
            void IsNewUserEvaluationDate(NSObject audience, NSDate isNewUserEvaluationDate, [NullAllowed] string contactID, Action<bool> completionHandler);
        }

        interface IUAAutomationAudienceCheckerProtocol { };

        // @interface UAAutomationAudienceChecker <UAAutomationAudienceCheckerProtocol>
        interface UAAutomationAudienceChecker : IUAAutomationAudienceCheckerProtocol
        {
            // -(void)evaluateWithAudience:(id _Nonnull)audience isNewUserEvaluationDate:(NSDate * _Nonnull)isNewUserEvaluationDate contactID:(NSString * _Nullable)contactID completionHandler:(void (^ _Nonnull)(BOOL))completionHandler;
            [Export("evaluateWithAudience:isNewUserEvaluationDate:contactID:completionHandler:")]
            void Evaluate(NSObject audience, NSDate isNewUserEvaluationDate, [NullAllowed] string contactID, Action<bool> completionHandler);
        }

        // @protocol UAPushableComponent
        [Protocol, Model]
        [BaseType(typeof(NSObject))]
        interface UAPushableComponent
        {
            // @optional -(void)receivedRemoteNotification:(NSDictionary * _Nonnull)notification completionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler;
            [Export("receivedRemoteNotification:completionHandler:")]
            void ReceivedRemoteNotification(NSDictionary notification, Action<UIBackgroundFetchResult> completionHandler);

            // @optional -(void)receivedNotificationResponse:(UNNotificationResponse * _Nonnull)response completionHandler:(void (^ _Nonnull)(void))completionHandler;
            [Export("receivedNotificationResponse:completionHandler:")]
            void ReceivedNotificationResponse(UNNotificationResponse response, Action completionHandler);

            // @optional -(UNNotificationPresentationOptions)presentationOptionsForNotification:(UNNotification * _Nonnull)notification defaultPresentationOptions:(UNNotificationPresentationOptions)options __attribute__((warn_unused_result("")));
            [Export("presentationOptionsForNotification:defaultPresentationOptions:")]
            UNNotificationPresentationOptions PresentationOptionsForNotification(UNNotification notification, UNNotificationPresentationOptions options);
        }

        interface IUAPushableComponent { };

        // @protocol UAirshipLogHandler
        [Protocol, Model]
        [BaseType(typeof(NSObject))]
        interface UAirshipLogHandler
        {
            // @required -(void)logWithLogLevel:(enum UALogLevel)logLevel message:(NSString * _Nonnull)message fileID:(NSString * _Nonnull)fileID line:(NSInterger)line function:(NSString * _Nonnull)function;
            [Abstract]
            [Export("logWithLogLevel:message:fileID:line:function:")]
            void Message(UALogLevel logLevel, string message, string fileID, nint line, string function);
        }

        // @protocol UAAirshipPermissionDelegate
        [Protocol, Model(AutoGeneratedName = true)]
        [BaseType(typeof(NSObject))]
        interface UAAirshipPermissionDelegate
        {
            // @required -(void)checkPermissionStatusWithCompletionHandler:(void (^ _Nonnull)(enum UAPermissionStatus))completionHandler;
            [Abstract]
            [Export("checkPermissionStatusWithCompletionHandler:")]
            void CheckPermissionStatus(Action<UAPermissionStatus> completionHandler);

            // @required -(void)requestPermissionWithCompletionHandler:(void (^ _Nonnull)(enum UAPermissionStatus))completionHandler;
            [Abstract]
            [Export("requestPermissionWithCompletionHandler:")]
            void RequestPermission(Action<UAPermissionStatus> completionHandler);
        }

        // @interface UAPermissionsManager
        [BaseType(typeof(NSObject))]
        interface UAPermissionsManager
        {
            // -(void)permissionStatusMapWithCompletionHandler:(void (^ _Nonnull)(int))completionHandler;
            [Export("permissionStatusMapWithCompletionHandler:")]
            void PermissionStatusMap(Action<int> completionHandler);

            // -(void)setDelegate:(id<UAAirshipPermissionDelegate> _Nullable)delegate permission:(enum UAPermission)permission;
            [Export("setDelegate:permission:")]
            void SetDelegate([NullAllowed] UAAirshipPermissionDelegate @delegate, UAPermission permission);

            // -(void)requestPermission:(enum UAPermission)permission completionHandler:(void (^ _Nonnull)(enum UAPermissionStatus))completionHandler;
            [Export("requestPermission:completionHandler:")]
            void RequestPermission(UAPermission permission, Action<UAPermissionStatus> completionHandler);

            // -(void)requestPermission:(enum UAPermission)permission enableAirshipUsageOnGrant:(BOOL)enableAirshipUsageOnGrant completionHandler:(void (^ _Nonnull)(enum UAPermissionStatus))completionHandler;
            [Export("requestPermission:enableAirshipUsageOnGrant:completionHandler:")]
            void RequestPermission(UAPermission permission, bool enableAirshipUsageOnGrant, Action<UAPermissionStatus> completionHandler);
        }

        // @interface UAAppStateTracker
        [DisableDefaultCtor]
        [BaseType(typeof(NSObject))]
        interface UAAppStateTracker
        {
            // @property (readonly, nonatomic, class) NSNotificationName _Nonnull didBecomeActiveNotification;
            [Static]
            [Export("didBecomeActiveNotification")]
            string DidBecomeActiveNotification { get; }

            // @property (readonly, nonatomic, class) NSNotificationName _Nonnull willEnterForegroundNotification;
            [Static]
            [Export("willEnterForegroundNotification")]
            string WillEnterForegroundNotification { get; }

            // @property (readonly, nonatomic, class) NSNotificationName _Nonnull didEnterBackgroundNotification;
            [Static]
            [Export("didEnterBackgroundNotification")]
            string DidEnterBackgroundNotification { get; }

            // @property (readonly, nonatomic, class) NSNotificationName _Nonnull willResignActiveNotification;
            [Static]
            [Export("willResignActiveNotification")]
            string WillResignActiveNotification { get; }

            // @property (readonly, nonatomic, class) NSNotificationName _Nonnull willTerminateNotification;
            [Static]
            [Export("willTerminateNotification")]
            string WillTerminateNotification { get; }

            // @property (readonly, nonatomic, class) NSNotification _Nonnull didTransitionToBackground;
            [Static]
            [Export("didTransitionToBackground")]
            string DidTransitionToBackground { get; }

            // @property (readonly, nonatomic, class) NSNotificationName _Nonnull didTransitionToForeground;
            [Static]
            [Export("didTransitionToForeground")]
            string DidTransitionToForeground { get; }

            // @property (readonly, nonatomic, strong, class) UAAppStateTracker * _Nonnull shared;
            [Static]
            [Export("shared", ArgumentSemantic.Strong)]
            UAAppStateTracker Shared { get; }

            // @property (readonly, nonatomic) enum UAApplicationState state;
            [Export("state")]
            UAApplicationState State { get; }
        }

        // @interface UAAssociatedChannel
        [DisableDefaultCtor]
        [BaseType(typeof(NSObject))]
        interface UAAssociatedChannel
        {
            // @property (readonly, nonatomic) enum UAChannelType channelType;
            [Export("channelType")]
            UAChannelType ChannelType { get; }

            // @property (readonly, copy, nonatomic) NSString * _Nonnull channelID;
            [Export("channelID")]
            string ChannelID { get; }

            // -(instancetype _Nonnull)initWithChannelType:(enum UAChannelType)channelType channelID:(NSString * _Nonnull)channelID __attribute__((objc_designated_initializer));
            [Export("initWithChannelType:channelID:")]
            [DesignatedInitializer]
            IntPtr Constructor(UAChannelType channelType, string channelID);
        }

        // @protocol UAChannelProtocol
        [Protocol, Model]
        [BaseType(typeof(NSObject))]
        interface UAChannelProtocol
        {
            // @required @property (readonly, copy, nonatomic) NSString * _Nullable identifier;
            [Abstract]
            [NullAllowed, Export("identifier")]
            string Identifier { get; }

            // @required @property (nonatomic) BOOL isChannelTagRegistrationEnabled;
            [Abstract]
            [Export("isChannelTagRegistrationEnabled")]
            bool IsChannelTagRegistrationEnabled { get; set; }

            // @required -(UATagEditor * _Nonnull)editTags __attribute__((warn_unused_result("")));
            [Abstract]
            [Export("editTags")]
            UATagEditor EditTags();

            // @required -(void)editTags:(void (^ _Nonnull)(UATagEditor * _Nonnull))editorBlock;
            [Abstract]
            [Export("editTags:")]
            void EditTags(Action<UATagEditor> editorBlock);

            // @required -(UATagGroupsEditor * _Nonnull)editTagGroups __attribute__((warn_unused_result("")));
            [Abstract]
            [Export("editTagGroups")]
            UATagGroupsEditor EditTagGroups();

            // @required -(void)editTagGroups:(void (^ _Nonnull)(UATagGroupsEditor * _Nonnull))editorBlock;
            [Abstract]
            [Export("editTagGroups:")]
            void EditTagGroups(Action<UATagGroupsEditor> editorBlock);

            // @required -(UASubscriptionListEditor * _Nonnull)editSubscriptionLists __attribute__((warn_unused_result("")));
            [Abstract]
            [Export("editSubscriptionLists")]
            UASubscriptionListEditor EditSubscriptionLists();

            // @required -(void)editSubscriptionLists:(void (^ _Nonnull)(UASubscriptionListEditor * _Nonnull))editorBlock;
            [Abstract]
            [Export("editSubscriptionLists:")]
            void EditSubscriptionLists(Action<UASubscriptionListEditor> editorBlock);

            // @required -(void)fetchSubscriptionListsWithCompletionHandler:(void (^ _Nonnull)(NSArray *))completionHandler;
            [Abstract]
            [Export("fetchSubscriptionListsWithCompletionHandler:")]
            void FetchSubscriptionLists(Action<string[]> completionHandler);

            // @required -(UAAttributesEditor * _Nonnull)editAttributes __attribute__((warn_unused_result("")));
            [Abstract]
            [Export("editAttributes")]
            UAAttributesEditor EditAttributes();

            // @required -(void)editAttributes:(void (^ _Nonnull)(UAAttributesEditor * _Nonnull))editorBlock;
            [Abstract]
            [Export("editAttributes:")]
            void EditAttributes(Action<UAAttributesEditor> editorBlock);

            // @required -(void)enableChannelCreation;
            [Abstract]
            [Export("enableChannelCreation")]
            void EnableChannelCreation();
        }

        // @protocol UAPushProtocol
        [Protocol, Model]
        interface UAPushProtocol
        {
            // @required @property (readonly, nonatomic) BOOL isPushNotificationsOptedIn;
            [Abstract]
            [Export("isPushNotificationsOptedIn")]
            bool IsPushNotificationsOptedIn { get; }

            // @required @property (nonatomic) BOOL backgroundPushNotificationsEnabled;
            [Abstract]
            [Export("backgroundPushNotificationsEnabled")]
            bool BackgroundPushNotificationsEnabled { get; set; }

            // @required @property (nonatomic) BOOL userPushNotificationsEnabled;
            [Abstract]
            [Export("userPushNotificationsEnabled")]
            bool UserPushNotificationsEnabled { get; set; }

            // @required @property (nonatomic) BOOL requestExplicitPermissionWhenEphemeral;
            [Abstract]
            [Export("requestExplicitPermissionWhenEphemeral")]
            bool RequestExplicitPermissionWhenEphemeral { get; set; }

            // @required @property (readonly, copy, nonatomic) NSString * _Nullable deviceToken;
            [Abstract]
            [NullAllowed, Export("deviceToken")]
            string DeviceToken { get; }

            // @required @property (nonatomic) UANotificationOptions notificationOptions;
            [Abstract]
            [Export("notificationOptions")]
            UANotificationOptions NotificationOptions { get; set; }

            // @required @property (nonatomic) BOOL requireAuthorizationForDefaultCategories;
            [Abstract]
            [Export("requireAuthorizationForDefaultCategories")]
            bool RequireAuthorizationForDefaultCategories { get; set; }

            [Wrap("WeakPushNotificationDelegate"), Abstract]
            [NullAllowed]
            UAPushNotificationDelegate PushNotificationDelegate { get; set; }

            // @required @property (nonatomic, weak) id<UAPushNotificationDelegate> _Nullable pushNotificationDelegate;
            [Abstract]
            [NullAllowed, Export("pushNotificationDelegate", ArgumentSemantic.Weak)]
            NSObject WeakPushNotificationDelegate { get; set; }

            [Wrap("WeakRegistrationDelegate"), Abstract]
            [NullAllowed]
            UARegistrationDelegate RegistrationDelegate { get; set; }

            // @required @property (nonatomic, weak) id<UARegistrationDelegate> _Nullable registrationDelegate;
            [Abstract]
            [NullAllowed, Export("registrationDelegate", ArgumentSemantic.Weak)]
            NSObject WeakRegistrationDelegate { get; set; }

            // @required @property (readonly, nonatomic, strong) UNNotificationResponse * _Nullable launchNotificationResponse;
            [Abstract]
            [NullAllowed, Export("launchNotificationResponse", ArgumentSemantic.Strong)]
            UNNotificationResponse LaunchNotificationResponse { get; }

            // @required @property (readonly, nonatomic) UAAuthorizedNotificationSettings authorizedNotificationSettings;
            [Abstract]
            [Export("authorizedNotificationSettings")]
            UAAuthorizedNotificationSettings AuthorizedNotificationSettings { get; }

            // @required @property (readonly, nonatomic) UAAuthorizationStatus authorizationStatus;
            [Abstract]
            [Export("authorizationStatus")]
            UAAuthorizationStatus AuthorizationStatus { get; }

            // @required @property (readonly, nonatomic) BOOL userPromptedForNotifications;
            [Abstract]
            [Export("userPromptedForNotifications")]
            bool UserPromptedForNotifications { get; }

            // @required @property (nonatomic) UNNotificationPresentationOptions defaultPresentationOptions;
            [Abstract]
            [Export("defaultPresentationOptions")]
            UNNotificationPresentationOptions DefaultPresentationOptions { get; set; }

            // @required @property (nonatomic) NSInteger badgeNumber;
            [Abstract]
            [Export("badgeNumber")]
            nint BadgeNumber { get; set; }
        }

        // @interface UAContactConflictEvent
        [DisableDefaultCtor]
        [BaseType(typeof(NSObject))]
        interface UAContactConflictEvent
        {
            // @property (readonly, copy, nonatomic) NSString * _Nullable conflictingNamedUserID;
            [NullAllowed, Export("conflictingNamedUserID")]
            string ConflictingNamedUserID { get; }
        }

        // @interface UAEmailRegistrationOptions
        [DisableDefaultCtor]
        [BaseType(typeof(NSObject))]
        interface UAEmailRegistrationOptions
        {
            // +(UAEmailRegistrationOptions * _Nonnull)commercialOptionsWithTransactionalOptedIn:(NSDate * _Nullable)transactionalOptedIn commercialOptedIn:(NSDate * _Nullable)commercialOptedIn properties:(NSDictionary * _Nullable)properties __attribute__((warn_unused_result("")));
            [Static]
            [Export("commercialOptionsWithTransactionalOptedIn:commercialOptedIn:properties:")]
            UAEmailRegistrationOptions CommercialOptionsWithTransactionalOptedIn([NullAllowed] NSDate transactionalOptedIn, [NullAllowed] NSDate commercialOptedIn, [NullAllowed] NSDictionary properties);

            // +(UAEmailRegistrationOptions * _Nonnull)optionsWithTransactionalOptedIn:(NSDate * _Nullable)transactionalOptedIn properties:(NSDictionary * _Nullable)properties doubleOptIn:(BOOL)doubleOptIn __attribute__((warn_unused_result("")));
            [Static]
            [Export("optionsWithTransactionalOptedIn:properties:doubleOptIn:")]
            UAEmailRegistrationOptions OptionsWithTransactionalOptedIn([NullAllowed] NSDate transactionalOptedIn, [NullAllowed] NSDictionary properties, bool doubleOptIn);

            // +(UAEmailRegistrationOptions * _Nonnull)optionsWithProperties:(NSDictionary * _Nullable)properties doubleOptIn:(BOOL)doubleOptIn __attribute__((warn_unused_result("")));
            [Static]
            [Export("optionsWithProperties:doubleOptIn:")]
            UAEmailRegistrationOptions OptionsWithProperties([NullAllowed] NSDictionary properties, bool doubleOptIn);
        }

        // @interface UAJSONUtils
        [BaseType(typeof(NSObject))]
        interface UAJSONUtils
        {
            // +(NSData * _Nullable)dataWithObject:(id _Nonnull)obj options:(id)options error:(id)error __attribute__((warn_unused_result("")));
            [Static]
            [Export("dataWithObject:options:error:")]
            [return: NullAllowed]
            NSData DataWithObject(NSObject obj, NSObject options, NSObject error);

            // +(NSString * _Nullable)stringWithObject:(id _Nonnull)obj options:(id)options error:(id)error __attribute__((warn_unused_result("")));
            [Static]
            [Export("stringWithObject:options:error:")]
            [return: NullAllowed]
            string StringWithObject(NSObject obj, NSObject options, NSObject error);

            // +(NSString * _Nullable)stringWithObject:(id _Nonnull)obj __attribute__((warn_unused_result("")));
            [Static]
            [Export("stringWithObject:")]
            [return: NullAllowed]
            string StringWithObject(NSObject obj);

            // +(id _Nullable)objectWithString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
            [Static]
            [Export("objectWithString:")]
            [return: NullAllowed]
            NSObject ObjectWithString(string @string);

            // +(id _Nullable)objectWithString:(NSString * _Nonnull)string options:(id)options error:(id)error __attribute__((warn_unused_result("")));
            [Static]
            [Export("objectWithString:options:error:")]
            [return: NullAllowed]
            NSObject ObjectWithString(string @string, NSObject options, NSObject error);
        }

        // @interface UAJavaScriptCommand : NSObject
        [DisableDefaultCtor]
        [BaseType(typeof(NSObject))]
        interface UAJavaScriptCommand
        {
            // @property (readonly, copy, nonatomic) NSString * _Nullable name;
            [NullAllowed, Export("name")]
            string Name { get; }

            // @property (nonatomic, strong, readonly) NSArray<NSString *> *_Nonnull arguments;
            [Export("arguments", ArgumentSemantic.Strong)]
            string[] Arguments { get; }

            // @property (nonatomic, strong, readonly) NSDictionary *_Nonnull options;
            [Export("options", ArgumentSemantic.Strong)]
            NSDictionary Options { get; }

            // @property (readonly, copy, nonatomic) NSURL * _Nonnull URL;
            [Export("URL", ArgumentSemantic.Copy)]
            NSUrl URL { get; }

            // -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)url __attribute__((objc_designated_initializer));
            [Export("initWithURL:")]
            [DesignatedInitializer]
            IntPtr Constructor(NSUrl url);
        }

        // @protocol UAJavaScriptCommandDelegate <NSObject>
        [Protocol, Model(AutoGeneratedName = true)]
        [BaseType(typeof(NSObject))]
        interface UAJavaScriptCommandDelegate
        {
            // @required -(id)performCommand:(UAJavaScriptCommand * _Nonnull)command webView:(WKWebView * _Nonnull)webView __attribute__((warn_unused_result("")));
            [Abstract]
            [Export("performCommand:webView:")]
            NSObject performCommand(UAJavaScriptCommand command, WKWebView webView);
        }

        interface IUAJavaScriptCommandDelegate { }

        // @protocol UAJavaScriptEnvironmentProtocol
        [Protocol, Model]
        [BaseType(typeof(NSObject))]
        interface UAJavaScriptEnvironmentProtocol
        {
            // @required -(void)addStringGetter:(NSString * _Nonnull)getter value:(NSString * _Nullable)string;
            [Abstract]
            [Export("addStringGetter:value:")]
            void AddStringGetter(string getter, [NullAllowed] string @string);

            // @required -(void)addNumberGetter:(NSString * _Nonnull)getter value:(NSNumber * _Nullable)number;
            [Abstract]
            [Export("addNumberGetter:value:")]
            void AddNumberGetter(string getter, [NullAllowed] NSNumber number);

            // @required -(void)addDictionaryGetter:(NSString * _Nonnull)getter value:(id)dictionary;
            [Abstract]
            [Export("addDictionaryGetter:value:")]
            void AddDictionaryGetter(string getter, NSObject dictionary);

            // @required -(void)buildWithCompletionHandler:(void (^ _Nonnull)(NSString * _Nonnull))completionHandler;
            [Abstract]
            [Export("buildWithCompletionHandler:")]
            void Build(Action<string> completionHandler);
        }

        interface IUAJavaScriptEnvironmentProtocol { }

        // @protocol UANativeBridgeExtensionDelegate  <NSObject>
        [Protocol, Model(AutoGeneratedName = true)]
        [BaseType(typeof(NSObject))]
        interface UANativeBridgeExtensionDelegate
        {
			// @required -(NSDictionary<NSString *,NSString *> *)actionsMetadataForCommand:(UAJavaScriptCommand * _Nonnull)command webView:(WKWebView * _Nonnull)webView __attribute__((warn_unused_result("")));
			[Abstract]
            [Export("actionsMetadataForCommand:webView:")]
			NSDictionary<NSString, NSString> ActionsMetadataForCommand(UAJavaScriptCommand command, WKWebView webView);

            // @required -(void)extendJavaScriptEnvironment:(id<UAJavaScriptEnvironmentProtocol> _Nonnull)js webView:(WKWebView * _Nonnull)webView completionHandler:(void (^ _Nonnull)(void))completionHandler;
            [Abstract]
            [Export("extendJavaScriptEnvironment:webView:completionHandler:")]
            void ExtendJavaScriptEnvironment(UAJavaScriptEnvironmentProtocol js, WKWebView webView, Action completionHandler);
        }

        interface IUANativeBridgeExtensionDelegate { };

        // @interface UAOpenRegistrationOptions
        [DisableDefaultCtor]
        [BaseType(typeof(NSObject))]
        interface UAOpenRegistrationOptions
        {
            // +(UAOpenRegistrationOptions * _Nonnull)optInPlatformName:(NSString * _Nonnull)platformName identifiers:(id)identifiers __attribute__((warn_unused_result("")));
            [Static]
            [Export("optInPlatformName:identifiers:")]
            UAOpenRegistrationOptions OptInPlatformName(string platformName, NSObject identifiers);
        }

        // @interface UASMSRegistrationOptions
        [DisableDefaultCtor]
        [BaseType(typeof(NSObject))]
        interface UASMSRegistrationOptions
        {
            // +(UASMSRegistrationOptions * _Nonnull)optInSenderID:(NSString * _Nonnull)senderID __attribute__((warn_unused_result("")));
            [Static]
            [Export("optInSenderID:")]
            UASMSRegistrationOptions OptInSenderID(string senderID);
        }

        // @interface UAScopedSubscriptionListEditor
        [DisableDefaultCtor]
        [BaseType(typeof(NSObject))]
        interface UAScopedSubscriptionListEditor
        {
            // -(void)subscribe:(NSString * _Nonnull)subscriptionListID scope:(enum UAChannelScope)scope;
            [Export("subscribe:scope:")]
            void Subscribe(string subscriptionListID, UAChannelScope scope);

            // -(void)unsubscribe:(NSString * _Nonnull)subscriptionListID scope:(enum UAChannelScope)scope;
            [Export("unsubscribe:scope:")]
            void Unsubscribe(string subscriptionListID, UAChannelScope scope);

            // -(void)apply;
            [Export("apply")]
            void Apply();
        }
}
