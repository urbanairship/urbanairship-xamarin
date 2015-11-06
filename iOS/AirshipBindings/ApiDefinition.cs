using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

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
		void CallWithData (UAWebViewCallData data, UAJavaScriptDelegateCompletionHandler completionHandler);
	}

	// @interface UAWhitelist : NSObject
	[BaseType (typeof(NSObject))]
	interface UAWhitelist
	{
		// +(instancetype _Nonnull)whitelistWithConfig:(UAConfig * _Nonnull)config;
		[Static]
		[Export ("whitelistWithConfig:")]
		UAWhitelist WhitelistWithConfig (UAConfig config);

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

		// extern UALocationServiceProviderType *const _Nonnull UALocationServiceProviderGps;
		[Field ("UALocationServiceProviderGps", "__Internal")]
		NSString UALocationServiceProviderGps { get; }

		// extern UALocationServiceProviderType *const _Nonnull UALocationServiceProviderNetwork;
		[Field ("UALocationServiceProviderNetwork", "__Internal")]
		NSString UALocationServiceProviderNetwork { get; }

		// extern UALocationServiceProviderType *const _Nonnull UALocationServiceProviderUnknown;
		[Field ("UALocationServiceProviderUnknown", "__Internal")]
		NSString UALocationServiceProviderUnknown { get; }

		// extern UALocationServiceNSDefaultsKey *const _Nonnull UALocationServiceAllowedKey;
		[Field ("UALocationServiceAllowedKey", "__Internal")]
		NSString UALocationServiceAllowedKey { get; }

		// extern UALocationServiceNSDefaultsKey *const _Nonnull UALocationServiceEnabledKey;
		[Field ("UALocationServiceEnabledKey", "__Internal")]
		NSString UALocationServiceEnabledKey { get; }

		// extern UALocationServiceNSDefaultsKey *const _Nonnull UAStandardLocationServiceRestartKey;
		[Field ("UAStandardLocationServiceRestartKey", "__Internal")]
		NSString UAStandardLocationServiceRestartKey { get; }

		// extern UALocationServiceNSDefaultsKey *const _Nonnull UASignificantChangeServiceRestartKey;
		[Field ("UASignificantChangeServiceRestartKey", "__Internal")]
		NSString UASignificantChangeServiceRestartKey { get; }

		// extern UALocationServiceNSDefaultsKey *const _Nonnull UAStandardLocationDistanceFilterKey;
		[Field ("UAStandardLocationDistanceFilterKey", "__Internal")]
		NSString UAStandardLocationDistanceFilterKey { get; }

		// extern UALocationServiceNSDefaultsKey *const _Nonnull UAStandardLocationDesiredAccuracyKey;
		[Field ("UAStandardLocationDesiredAccuracyKey", "__Internal")]
		NSString UAStandardLocationDesiredAccuracyKey { get; }

		// extern UALocationServiceNSDefaultsKey *const _Nonnull UASingleLocationDesiredAccuracyKey;
		[Field ("UASingleLocationDesiredAccuracyKey", "__Internal")]
		NSString UASingleLocationDesiredAccuracyKey { get; }

		// extern UALocationServiceNSDefaultsKey *const _Nonnull UASingleLocationTimeoutKey;
		[Field ("UASingleLocationTimeoutKey", "__Internal")]
		NSString UASingleLocationTimeoutKey { get; }

		// extern UALocationServiceErrorDomain *const _Nonnull UALocationServiceTimeoutError;
		[Field ("UALocationServiceTimeoutError", "__Internal")]
		NSString UALocationServiceTimeoutError { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventForegroundKey;
		[Field ("UALocationEventForegroundKey", "__Internal")]
		NSString UALocationEventForegroundKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventLatitudeKey;
		[Field ("UALocationEventLatitudeKey", "__Internal")]
		NSString UALocationEventLatitudeKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventLongitudeKey;
		[Field ("UALocationEventLongitudeKey", "__Internal")]
		NSString UALocationEventLongitudeKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventDesiredAccuracyKey;
		[Field ("UALocationEventDesiredAccuracyKey", "__Internal")]
		NSString UALocationEventDesiredAccuracyKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventUpdateTypeKey;
		[Field ("UALocationEventUpdateTypeKey", "__Internal")]
		NSString UALocationEventUpdateTypeKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventProviderKey;
		[Field ("UALocationEventProviderKey", "__Internal")]
		NSString UALocationEventProviderKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventDistanceFilterKey;
		[Field ("UALocationEventDistanceFilterKey", "__Internal")]
		NSString UALocationEventDistanceFilterKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventHorizontalAccuracyKey;
		[Field ("UALocationEventHorizontalAccuracyKey", "__Internal")]
		NSString UALocationEventHorizontalAccuracyKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventVerticalAccuracyKey;
		[Field ("UALocationEventVerticalAccuracyKey", "__Internal")]
		NSString UALocationEventVerticalAccuracyKey { get; }

		// extern UALocationEventAnalyticsKey *const _Nonnull UALocationEventSessionIDKey;
		[Field ("UALocationEventSessionIDKey", "__Internal")]
		NSString UALocationEventSessionIDKey { get; }

		// extern UALocationEventUpdateType *const _Nonnull UALocationEventAnalyticsType;
		[Field ("UALocationEventAnalyticsType", "__Internal")]
		NSString UALocationEventAnalyticsType { get; }

		// extern UALocationEventUpdateType *const _Nonnull UALocationEventUpdateTypeChange;
		[Field ("UALocationEventUpdateTypeChange", "__Internal")]
		NSString UALocationEventUpdateTypeChange { get; }

		// extern UALocationEventUpdateType *const _Nonnull UALocationEventUpdateTypeContinuous;
		[Field ("UALocationEventUpdateTypeContinuous", "__Internal")]
		NSString UALocationEventUpdateTypeContinuous { get; }

		// extern UALocationEventUpdateType *const _Nonnull UALocationEventUpdateTypeSingle;
		[Field ("UALocationEventUpdateTypeSingle", "__Internal")]
		NSString UALocationEventUpdateTypeSingle { get; }

		// extern UALocationEventUpdateType *const _Nonnull UALocationEventUpdateTypeNone;
		[Field ("UALocationEventUpdateTypeNone", "__Internal")]
		NSString UALocationEventUpdateTypeNone { get; }

		// extern NSString *const _Nonnull UAAnalyticsValueNone;
		[Field ("UAAnalyticsValueNone", "__Internal")]
		NSString UAAnalyticsValueNone { get; }

		// extern NSString *const _Nonnull UALocationServiceBestAvailableSingleLocationKey;
		[Field ("UALocationServiceBestAvailableSingleLocationKey", "__Internal")]
		NSString UALocationServiceBestAvailableSingleLocationKey { get; }
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

		// @property (readonly, nonatomic, strong) UALocationService * _Nonnull locationService;
		[Export ("locationService", ArgumentSemantic.Strong)]
		UALocationService LocationService { get; }

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
		UADisposable DisposableWithBlock (UADisposalBlock disposalBlock);

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
		UADisposable MarkMessageReadWithCompletionHandler ([NullAllowed] UAInboxMessageCallbackBlock completionHandler);

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
		UADisposable RetrieveMessageListWithSuccessBlock ([NullAllowed] UAInboxMessageListCallbackBlock successBlock, [NullAllowed] UAInboxMessageListCallbackBlock failureBlock);

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

	// @interface UAChannel : NSObject
	[BaseType (typeof(NSObject))]
	interface UAChannel
	{
		// @property (readonly, copy, nonatomic) NSString * identifier;
		[Export ("identifier")]
		string Identifier { get; }

		// @property (readonly, copy, nonatomic) NSString * location;
		[Export ("location")]
		string Location { get; }
	}

	// @protocol UAChannelRegistrarDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UAChannelRegistrarDelegate
	{
		// @optional -(void)registrationFailedWithPayload:(UAChannelRegistrationPayload * _Nonnull)payload;
		[Export ("registrationFailedWithPayload:")]
		void RegistrationFailedWithPayload (UAChannelRegistrationPayload payload);

		// @optional -(void)registrationSucceededWithPayload:(UAChannelRegistrationPayload * _Nonnull)payload;
		[Export ("registrationSucceededWithPayload:")]
		void RegistrationSucceededWithPayload (UAChannelRegistrationPayload payload);

		// @optional -(void)channelCreated:(NSString * _Nonnull)channelID channelLocation:(NSString * _Nonnull)channelLocation existing:(BOOL)existing;
		[Export ("channelCreated:channelLocation:existing:")]
		void ChannelCreated (string channelID, string channelLocation, bool existing);
	}

	// @interface UAChannelRegistrar : NSObject
	[BaseType (typeof(NSObject))]
	interface UAChannelRegistrar
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		UAChannelRegistrarDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<UAChannelRegistrarDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)registerWithChannelID:(NSString * _Nullable)channelID channelLocation:(NSString * _Nullable)channelLocation withPayload:(UAChannelRegistrationPayload * _Nonnull)payload forcefully:(BOOL)forcefully;
		[Export ("registerWithChannelID:channelLocation:withPayload:forcefully:")]
		void RegisterWithChannelID ([NullAllowed] string channelID, [NullAllowed] string channelLocation, UAChannelRegistrationPayload payload, bool forcefully);

		// -(void)cancelAllRequests;
		[Export ("cancelAllRequests")]
		void CancelAllRequests ();
	}

	// @interface UAChannelRegistrationPayload : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface UAChannelRegistrationPayload : INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nullable userID;
		[NullAllowed, Export ("userID")]
		string UserID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable deviceID;
		[NullAllowed, Export ("deviceID")]
		string DeviceID { get; set; }

		// @property (getter = isOptedIn, assign, nonatomic) BOOL optedIn;
		[Export ("optedIn")]
		bool OptedIn { [Bind ("isOptedIn")] get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull pushAddress;
		[Export ("pushAddress")]
		string PushAddress { get; set; }

		// @property (assign, nonatomic) BOOL setTags;
		[Export ("setTags")]
		bool SetTags { get; set; }

		// @property (nonatomic, strong) NSArray<NSString *> * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		string[] Tags { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable alias;
		[NullAllowed, Export ("alias")]
		string Alias { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nullable quietTime;
		[NullAllowed, Export ("quietTime", ArgumentSemantic.Strong)]
		NSDictionary QuietTime { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable timeZone;
		[NullAllowed, Export ("timeZone")]
		string TimeZone { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable badge;
		[NullAllowed, Export ("badge", ArgumentSemantic.Strong)]
		NSNumber Badge { get; set; }

		// @property (getter = isBackgroundEnabled, assign, nonatomic) BOOL backgroundEnabled;
		[Export ("backgroundEnabled")]
		bool BackgroundEnabled { [Bind ("isBackgroundEnabled")] get; set; }

		// -(NSData * _Nonnull)asJSONData;
		[Export ("asJSONData")]
		NSData AsJSONData { get; }

		// -(BOOL)isEqualToPayload:(UAChannelRegistrationPayload * _Nullable)payload;
		[Export ("isEqualToPayload:")]
		bool IsEqualToPayload ([NullAllowed] UAChannelRegistrationPayload payload);
	}

	// typedef void (^UAHTTPConnectionSuccessBlock)(UAHTTPRequest * _Nonnull);
	delegate void UAHTTPConnectionSuccessBlock (UAHTTPRequest arg0);

	// typedef void (^UAHTTPConnectionFailureBlock)(UAHTTPRequest * _Nonnull);
	delegate void UAHTTPConnectionFailureBlock (UAHTTPRequest arg0);

	// @interface UAHTTPRequest : NSObject
	[BaseType (typeof(NSObject))]
	interface UAHTTPRequest
	{
		// @property (readonly, nonatomic, strong) NSURL * _Nonnull url;
		[Export ("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; }

		// @property (nonatomic, strong) NSDictionary * _Nonnull headers;
		[Export ("headers", ArgumentSemantic.Strong)]
		NSDictionary Headers { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull HTTPMethod;
		[Export ("HTTPMethod")]
		string HTTPMethod { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable username;
		[NullAllowed, Export ("username")]
		string Username { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable password;
		[NullAllowed, Export ("password")]
		string Password { get; set; }

		// @property (nonatomic, strong) NSURL * _Nullable mainDocumentURL;
		[NullAllowed, Export ("mainDocumentURL", ArgumentSemantic.Strong)]
		NSUrl MainDocumentURL { get; set; }

		// @property (nonatomic, strong) NSMutableData * _Nullable body;
		[NullAllowed, Export ("body", ArgumentSemantic.Strong)]
		NSMutableData Body { get; set; }

		// @property (assign, nonatomic) BOOL compressBody;
		[Export ("compressBody")]
		bool CompressBody { get; set; }

		// @property (nonatomic, strong) id _Nullable userInfo;
		[NullAllowed, Export ("userInfo", ArgumentSemantic.Strong)]
		NSObject UserInfo { get; set; }

		// @property (readonly, nonatomic, strong) NSHTTPURLResponse * _Nullable response;
		[NullAllowed, Export ("response", ArgumentSemantic.Strong)]
		NSHttpUrlResponse Response { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable responseString;
		[NullAllowed, Export ("responseString")]
		string ResponseString { get; }

		// @property (readonly, nonatomic, strong) NSData * _Nullable responseData;
		[NullAllowed, Export ("responseData", ArgumentSemantic.Strong)]
		NSData ResponseData { get; }

		// @property (readonly, nonatomic, strong) NSError * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Strong)]
		NSError Error { get; }

		// +(instancetype _Nonnull)requestWithURLString:(NSString * _Nonnull)urlString;
		[Static]
		[Export ("requestWithURLString:")]
		UAHTTPRequest RequestWithURLString (string urlString);

		// +(instancetype _Nonnull)requestWithURL:(NSURL * _Nonnull)url;
		[Static]
		[Export ("requestWithURL:")]
		UAHTTPRequest RequestWithURL (NSUrl url);

		// +(void)setDefaultUserAgentString:(NSString * _Nonnull)userAgent;
		[Static]
		[Export ("setDefaultUserAgentString:")]
		void SetDefaultUserAgentString (string userAgent);

		// -(instancetype _Nonnull)initWithURLString:(NSString * _Nonnull)urlString;
		[Export ("initWithURLString:")]
		IntPtr Constructor (string urlString);

		// -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)url;
		[Export ("initWithURL:")]
		IntPtr Constructor (NSUrl url);

		// -(void)addRequestHeader:(NSString * _Nonnull)header value:(NSString * _Nonnull)value;
		[Export ("addRequestHeader:value:")]
		void AddRequestHeader (string header, string value);

		// -(void)appendBodyData:(NSData * _Nonnull)data;
		[Export ("appendBodyData:")]
		void AppendBodyData (NSData data);
	}

	// @interface UAHTTPConnection : NSObject <NSURLConnectionDelegate>
	[BaseType (typeof(NSObject))]
	interface UAHTTPConnection : INSUrlConnectionDelegate
	{
		// @property (readonly, nonatomic, strong) NSURLConnection * _Nonnull urlConnection;
		[Export ("urlConnection", ArgumentSemantic.Strong)]
		NSUrlConnection UrlConnection { get; }

		// @property (readonly, nonatomic, strong) UAHTTPRequest * _Nonnull request;
		[Export ("request", ArgumentSemantic.Strong)]
		UAHTTPRequest Request { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		NSObject Delegate { get; set; }

		// @property (nonatomic, weak) id _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) SEL _Nullable successSelector;
		[NullAllowed, Export ("successSelector", ArgumentSemantic.Assign)]
		Selector SuccessSelector { get; set; }

		// @property (assign, nonatomic) SEL _Nullable failureSelector;
		[NullAllowed, Export ("failureSelector", ArgumentSemantic.Assign)]
		Selector FailureSelector { get; set; }

		// @property (copy, nonatomic) UAHTTPConnectionSuccessBlock _Nullable successBlock;
		[NullAllowed, Export ("successBlock", ArgumentSemantic.Copy)]
		UAHTTPConnectionSuccessBlock SuccessBlock { get; set; }

		// @property (copy, nonatomic) UAHTTPConnectionFailureBlock _Nullable failureBlock;
		[NullAllowed, Export ("failureBlock", ArgumentSemantic.Copy)]
		UAHTTPConnectionFailureBlock FailureBlock { get; set; }

		// @property (nonatomic, strong) NSOperationQueue * _Nullable delegateQueue;
		[NullAllowed, Export ("delegateQueue", ArgumentSemantic.Strong)]
		NSOperationQueue DelegateQueue { get; set; }

		// +(instancetype _Nonnull)connectionWithRequest:(UAHTTPRequest * _Nonnull)httpRequest;
		[Static]
		[Export ("connectionWithRequest:")]
		UAHTTPConnection ConnectionWithRequest (UAHTTPRequest httpRequest);

		// +(instancetype _Nonnull)connectionWithRequest:(UAHTTPRequest * _Nonnull)httpRequest delegate:(id _Nonnull)delegate success:(SEL _Nonnull)successSelector failure:(SEL _Nonnull)failureSelector;
		[Static]
		[Export ("connectionWithRequest:delegate:success:failure:")]
		UAHTTPConnection ConnectionWithRequest (UAHTTPRequest httpRequest, NSObject @delegate, Selector successSelector, Selector failureSelector);

		// +(instancetype _Nonnull)connectionWithRequest:(UAHTTPRequest * _Nonnull)httpRequest successBlock:(UAHTTPConnectionSuccessBlock _Nonnull)successBlock failureBlock:(UAHTTPConnectionFailureBlock _Nonnull)failureBlock;
		[Static]
		[Export ("connectionWithRequest:successBlock:failureBlock:")]
		UAHTTPConnection ConnectionWithRequest (UAHTTPRequest httpRequest, UAHTTPConnectionSuccessBlock successBlock, UAHTTPConnectionFailureBlock failureBlock);

		// -(instancetype _Nonnull)initWithRequest:(UAHTTPRequest * _Nonnull)httpRequest;
		[Export ("initWithRequest:")]
		IntPtr Constructor (UAHTTPRequest httpRequest);

		// -(BOOL)start;
		[Export ("start")]
		bool Start ();

		// -(BOOL)startSynchronous;
		[Export ("startSynchronous")]
		bool StartSynchronous ();

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// -(void)connection:(NSURLConnection * _Nonnull)connection didReceiveResponse:(NSHTTPURLResponse * _Nonnull)response;
		[Export ("connection:didReceiveResponse:")]
		void Connection (NSUrlConnection connection, NSHttpUrlResponse response);

		// -(void)connection:(NSURLConnection * _Nonnull)connection didReceiveData:(NSData * _Nonnull)data;
		[Export ("connection:didReceiveData:")]
		void Connection (NSUrlConnection connection, NSData data);

		// -(void)connection:(NSURLConnection * _Nonnull)connection didFailWithError:(NSError * _Nonnull)error;
		[Export ("connection:didFailWithError:")]
		void Connection (NSUrlConnection connection, NSError error);

		// -(void)connectionDidFinishLoading:(NSURLConnection * _Nonnull)connection;
		[Export ("connectionDidFinishLoading:")]
		void ConnectionDidFinishLoading (NSUrlConnection connection);
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
		void RegistrationSucceededForChannelID (string channelID, string deviceToken);

		// @optional -(void)registrationFailed;
		[Export ("registrationFailed")]
		void RegistrationFailed ();
	}

	// @protocol UAPushNotificationDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UAPushNotificationDelegate
	{
		// @optional -(void)displayNotificationAlert:(NSString * _Nonnull)alertMessage;
		[Export ("displayNotificationAlert:")]
		void DisplayNotificationAlert (string alertMessage);

		// @optional -(void)displayLocalizedNotificationAlert:(NSDictionary * _Nonnull)alertDict;
		[Export ("displayLocalizedNotificationAlert:")]
		void DisplayLocalizedNotificationAlert (NSDictionary alertDict);

		// @optional -(void)playNotificationSound:(NSString * _Nonnull)soundFilename;
		[Export ("playNotificationSound:")]
		void PlayNotificationSound (string soundFilename);

		// @optional -(void)handleBadgeUpdate:(NSInteger)badgeNumber;
		[Export ("handleBadgeUpdate:")]
		void HandleBadgeUpdate (nint badgeNumber);

		// @optional -(void)receivedForegroundNotification:(NSDictionary * _Nonnull)notification;
		[Export ("receivedForegroundNotification:")]
		void ReceivedForegroundNotification (NSDictionary notification);

		// @optional -(void)receivedForegroundNotification:(NSDictionary * _Nonnull)notification fetchCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler;
		[Export ("receivedForegroundNotification:fetchCompletionHandler:")]
		void ReceivedForegroundNotification (NSDictionary notification, Action<UIBackgroundFetchResult> completionHandler);

		// @optional -(void)receivedBackgroundNotification:(NSDictionary * _Nonnull)notification;
		[Export ("receivedBackgroundNotification:")]
		void ReceivedBackgroundNotification (NSDictionary notification);

		// @optional -(void)receivedBackgroundNotification:(NSDictionary * _Nonnull)notification fetchCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler;
		[Export ("receivedBackgroundNotification:fetchCompletionHandler:")]
		void ReceivedBackgroundNotification (NSDictionary notification, Action<UIBackgroundFetchResult> completionHandler);

		// @optional -(void)launchedFromNotification:(NSDictionary * _Nonnull)notification;
		[Export ("launchedFromNotification:")]
		void LaunchedFromNotification (NSDictionary notification);

		// @optional -(void)launchedFromNotification:(NSDictionary * _Nonnull)notification fetchCompletionHandler:(void (^ _Nonnull)(UIBackgroundFetchResult))completionHandler;
		[Export ("launchedFromNotification:fetchCompletionHandler:")]
		void LaunchedFromNotification (NSDictionary notification, Action<UIBackgroundFetchResult> completionHandler);

		// @optional -(void)launchedFromNotification:(NSDictionary * _Nonnull)notification actionIdentifier:(NSString * _Nonnull)identifier completionHandler:(void (^ _Nonnull)())completionHandler;
		[Export ("launchedFromNotification:actionIdentifier:completionHandler:")]
		void LaunchedFromNotification (NSDictionary notification, string identifier, Action completionHandler);

		// @optional -(void)receivedBackgroundNotification:(NSDictionary * _Nonnull)notification actionIdentifier:(NSString * _Nonnull)identifier completionHandler:(void (^ _Nonnull)())completionHandler;
		[Export ("receivedBackgroundNotification:actionIdentifier:completionHandler:")]
		void ReceivedBackgroundNotification (NSDictionary notification, string identifier, Action completionHandler);
	}

	// @interface UAPush : NSObject <UAChannelRegistrarDelegate>
	[BaseType (typeof(NSObject))]
	interface UAPush : UAChannelRegistrarDelegate
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
		[NullAllowed, Export ("channelID")]
		string ChannelID { get; }

		// @property (assign, nonatomic) UIUserNotificationType userNotificationTypes;
		[Export ("userNotificationTypes", ArgumentSemantic.Assign)]
		UIUserNotificationType UserNotificationTypes { get; set; }

		// @property (nonatomic, strong) NSSet * _Nonnull userNotificationCategories;
		[Export ("userNotificationCategories", ArgumentSemantic.Strong)]
		NSSet UserNotificationCategories { get; set; }

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

		// @property (readonly, nonatomic, strong) NSDictionary * _Nullable launchNotification;
		[NullAllowed, Export ("launchNotification", ArgumentSemantic.Strong)]
		NSDictionary LaunchNotification { get; }

		// @property (getter = isAutobadgeEnabled, assign, nonatomic) BOOL autobadgeEnabled;
		[Export ("autobadgeEnabled")]
		bool AutobadgeEnabled { [Bind ("isAutobadgeEnabled")] get; set; }

		// -(void)setBadgeNumber:(NSInteger)badgeNumber;
		[Export ("setBadgeNumber:")]
		void SetBadgeNumber (nint badgeNumber);

		// -(void)resetBadge;
		[Export ("resetBadge")]
		void ResetBadge ();

		// -(UIUserNotificationType)currentEnabledNotificationTypes;
		[Export ("currentEnabledNotificationTypes")]
		UIUserNotificationType CurrentEnabledNotificationTypes { get; }

		// @property (copy, nonatomic) NSString * _Nullable alias;
		[NullAllowed, Export ("alias")]
		string Alias { get; set; }

		// @property (nonatomic, strong) UANamedUser * _Nonnull namedUser;
		[Export ("namedUser", ArgumentSemantic.Strong)]
		UANamedUser NamedUser { get; set; }

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
		void SetQuietTimeStartHour (nuint startHour, nuint startMinute, nuint endHour, nuint endMinute);

		// -(void)enableChannelCreation;
		[Export ("enableChannelCreation")]
		void EnableChannelCreation ();

		// -(void)updateRegistration;
		[Export ("updateRegistration")]
		void UpdateRegistration ();

		// -(void)appReceivedRemoteNotification:(NSDictionary * _Nonnull)notification applicationState:(UIApplicationState)state;
		[Export ("appReceivedRemoteNotification:applicationState:")]
		void AppReceivedRemoteNotification (NSDictionary notification, UIApplicationState state);

		// -(void)appReceivedRemoteNotification:(NSDictionary * _Nonnull)notification applicationState:(UIApplicationState)state fetchCompletionHandler:(void (^ _Nullable)(UIBackgroundFetchResult))completionHandler;
		[Export ("appReceivedRemoteNotification:applicationState:fetchCompletionHandler:")]
		void AppReceivedRemoteNotification (NSDictionary notification, UIApplicationState state, [NullAllowed] Action<UIBackgroundFetchResult> completionHandler);

		// -(void)appRegisteredForRemoteNotificationsWithDeviceToken:(NSData * _Nonnull)token;
		[Export ("appRegisteredForRemoteNotificationsWithDeviceToken:")]
		void AppRegisteredForRemoteNotificationsWithDeviceToken (NSData token);

		// -(void)appRegisteredUserNotificationSettings;
		[Export ("appRegisteredUserNotificationSettings")]
		void AppRegisteredUserNotificationSettings ();

		// -(void)appReceivedActionWithIdentifier:(NSString * _Nonnull)identifier notification:(NSDictionary * _Nonnull)notification applicationState:(UIApplicationState)state completionHandler:(void (^ _Nonnull)())completionHandler;
		[Export ("appReceivedActionWithIdentifier:notification:applicationState:completionHandler:")]
		void AppReceivedActionWithIdentifier (string identifier, NSDictionary notification, UIApplicationState state, Action completionHandler);

		// -(void)appReceivedActionWithIdentifier:(NSString * _Nonnull)identifier notification:(NSDictionary * _Nonnull)notification responseInfo:(NSDictionary * _Nullable)responseInfo applicationState:(UIApplicationState)state completionHandler:(void (^ _Nonnull)())completionHandler;
		[Export ("appReceivedActionWithIdentifier:notification:responseInfo:applicationState:completionHandler:")]
		void AppReceivedActionWithIdentifier (string identifier, NSDictionary notification, [NullAllowed] NSDictionary responseInfo, UIApplicationState state, Action completionHandler);
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
		UAWebViewCallData CallDataForURL (NSUrl url, UIWebView webView);

		// +(UAWebViewCallData * _Nonnull)callDataForURL:(NSURL * _Nonnull)url webView:(UIWebView * _Nonnull)webView message:(UAInboxMessage * _Nullable)message;
		[Static]
		[Export ("callDataForURL:webView:message:")]
		UAWebViewCallData CallDataForURL (NSUrl url, UIWebView webView, [NullAllowed] UAInboxMessage message);

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
		void CloseWebView (UIWebView webView, bool animated);
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
		UAActionResult ResultWithValue ([NullAllowed] NSObject value);

		// +(instancetype _Nonnull)resultWithValue:(id _Nullable)result withFetchResult:(UAActionFetchResult)fetchResult;
		[Static]
		[Export ("resultWithValue:withFetchResult:")]
		UAActionResult ResultWithValue ([NullAllowed] NSObject result, UAActionFetchResult fetchResult);

		// +(instancetype _Nonnull)emptyResult;
		[Static]
		[Export ("emptyResult")]
		UAActionResult EmptyResult ();

		// +(instancetype _Nonnull)resultWithError:(NSError * _Nonnull)error;
		[Static]
		[Export ("resultWithError:")]
		UAActionResult ResultWithError (NSError error);

		// +(instancetype _Nonnull)resultWithError:(NSError * _Nonnull)error withFetchResult:(UAActionFetchResult)fetchResult;
		[Static]
		[Export ("resultWithError:withFetchResult:")]
		UAActionResult ResultWithError (NSError error, UAActionFetchResult fetchResult);
	}

	// @interface UAActionArguments : NSObject
	[BaseType (typeof(NSObject))]
	interface UAActionArguments
	{
		// +(instancetype _Nonnull)argumentsWithValue:(id _Nullable)value withSituation:(UASituation)situation;
		[Static]
		[Export ("argumentsWithValue:withSituation:")]
		UAActionArguments ArgumentsWithValue ([NullAllowed] NSObject value, UASituation situation);

		// +(instancetype _Nonnull)argumentsWithValue:(id _Nullable)value withSituation:(UASituation)situation metadata:(NSDictionary * _Nullable)metadata;
		[Static]
		[Export ("argumentsWithValue:withSituation:metadata:")]
		UAActionArguments ArgumentsWithValue ([NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata);

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
		void WillPerformWithArguments (UAActionArguments arguments);

		// -(void)didPerformWithArguments:(UAActionArguments * _Nonnull)arguments withResult:(UAActionResult * _Nonnull)result;
		[Export ("didPerformWithArguments:withResult:")]
		void DidPerformWithArguments (UAActionArguments arguments, UAActionResult result);

		// -(void)performWithArguments:(UAActionArguments * _Nonnull)arguments completionHandler:(UAActionCompletionHandler _Nonnull)completionHandler;
		[Export ("performWithArguments:completionHandler:")]
		void PerformWithArguments (UAActionArguments arguments, UAActionCompletionHandler completionHandler);

		// +(instancetype _Nonnull)actionWithBlock:(UAActionBlock _Nonnull)actionBlock;
		[Static]
		[Export ("actionWithBlock:")]
		UAAction ActionWithBlock (UAActionBlock actionBlock);

		// +(instancetype _Nonnull)actionWithBlock:(UAActionBlock _Nonnull)actionBlock acceptingArguments:(UAActionPredicate _Nullable)predicateBlock;
		[Static]
		[Export ("actionWithBlock:acceptingArguments:")]
		UAAction ActionWithBlock (UAActionBlock actionBlock, [NullAllowed] UAActionPredicate predicateBlock);
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
		void RunActionWithName (string actionName, [NullAllowed] NSObject value, UASituation situation);

		// +(void)runActionWithName:(NSString * _Nonnull)actionName value:(id _Nullable)value situation:(UASituation)situation metadata:(NSDictionary * _Nonnull)metadata;
		[Static]
		[Export ("runActionWithName:value:situation:metadata:")]
		void RunActionWithName (string actionName, [NullAllowed] NSObject value, UASituation situation, NSDictionary metadata);

		// +(void)runActionWithName:(NSString * _Nonnull)actionName value:(id _Nullable)value situation:(UASituation)situation completionHandler:(UAActionCompletionHandler _Nonnull)completionHandler;
		[Static]
		[Export ("runActionWithName:value:situation:completionHandler:")]
		void RunActionWithName (string actionName, [NullAllowed] NSObject value, UASituation situation, UAActionCompletionHandler completionHandler);

		// +(void)runActionWithName:(NSString * _Nonnull)actionName value:(id _Nullable)value situation:(UASituation)situation metadata:(NSDictionary * _Nullable)metadata completionHandler:(UAActionCompletionHandler _Nullable)completionHandler;
		[Static]
		[Export ("runActionWithName:value:situation:metadata:completionHandler:")]
		void RunActionWithName (string actionName, [NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata, [NullAllowed] UAActionCompletionHandler completionHandler);

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
		// -(void)displayInboxMessage:(UAInboxMessage * _Nonnull)message situation:(UASituation)situation;
		[Export ("displayInboxMessage:situation:")]
		void DisplayInboxMessage (UAInboxMessage message, UASituation situation);

		// -(void)displayInboxWithSituation:(UASituation)situation;
		[Export ("displayInboxWithSituation:")]
		void DisplayInboxWithSituation (UASituation situation);
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

	// @interface UAWalletAction : UAAction
	[BaseType (typeof(UAAction))]
	interface UAWalletAction
	{
	}

	// @interface UAAnalytics : NSObject
	[BaseType (typeof(NSObject))]
	interface UAAnalytics
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable conversionSendID;
		[NullAllowed, Export ("conversionSendID")]
		string ConversionSendID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable conversionRichPushID;
		[NullAllowed, Export ("conversionRichPushID")]
		string ConversionRichPushID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sessionID;
		[NullAllowed, Export ("sessionID")]
		string SessionID { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval oldestEventTime;
		[Export ("oldestEventTime")]
		double OldestEventTime { get; }

		// @property (getter = isEnabled, assign, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// -(void)addEvent:(UAEvent * _Nonnull)event;
		[Export ("addEvent:")]
		void AddEvent (UAEvent @event);

		// -(void)associateDeviceIdentifiers:(UAAssociatedIdentifiers * _Nonnull)associatedIdentifiers;
		[Export ("associateDeviceIdentifiers:")]
		void AssociateDeviceIdentifiers (UAAssociatedIdentifiers associatedIdentifiers);

		// -(void)handleNotification:(NSDictionary * _Nonnull)userInfo inApplicationState:(UIApplicationState)applicationState;
		[Export ("handleNotification:inApplicationState:")]
		void HandleNotification (NSDictionary userInfo, UIApplicationState applicationState);

		// -(NSDate * _Nonnull)lastSendTime;
		[Export ("lastSendTime")]
		NSDate LastSendTime { get; }

		// -(void)trackScreen:(NSString * _Nullable)screen;
		[Export ("trackScreen:")]
		void TrackScreen ([NullAllowed] string screen);
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
		UAAssociatedIdentifiers IdentifiersWithDictionary (NSDictionary<NSString, NSString> identifiers);

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
		UACustomEvent EventWithName (string eventName);

		// +(instancetype _Nonnull)eventWithName:(NSString * _Nonnull)eventName valueFromString:(NSString * _Nullable)eventValue;
		[Static]
		[Export ("eventWithName:valueFromString:")]
		UACustomEvent EventWithName (string eventName, [NullAllowed] string eventValue);

		// +(instancetype _Nonnull)eventWithName:(NSString * _Nonnull)eventName value:(NSNumber * _Nullable)eventValue;
		[Static]
		[Export ("eventWithName:value:")]
		UACustomEvent EventWithName (string eventName, [NullAllowed] NSNumber eventValue);

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
	}

	// @interface UALocationEvent : UAEvent
	[BaseType (typeof(UAEvent))]
	interface UALocationEvent
	{
		// +(UALocationEvent * _Nonnull)locationEventWithLocation:(CLLocation * _Nonnull)location providerType:(UALocationServiceProviderType * _Nullable)providerType desiredAccuracy:(NSNumber * _Nullable)desiredAccuracy distanceFilter:(NSNumber * _Nullable)distanceFilter;
		[Static]
		[Export ("locationEventWithLocation:providerType:desiredAccuracy:distanceFilter:")]
		UALocationEvent LocationEventWithLocation (CLLocation location, [NullAllowed] string providerType, [NullAllowed] NSNumber desiredAccuracy, [NullAllowed] NSNumber distanceFilter);

		// +(UALocationEvent * _Nonnull)singleLocationEventWithLocation:(CLLocation * _Nonnull)location providerType:(UALocationServiceProviderType * _Nullable)providerType desiredAccuracy:(NSNumber * _Nullable)desiredAccuracy distanceFilter:(NSNumber * _Nullable)distanceFilter;
		[Static]
		[Export ("singleLocationEventWithLocation:providerType:desiredAccuracy:distanceFilter:")]
		UALocationEvent SingleLocationEventWithLocation (CLLocation location, [NullAllowed] string providerType, [NullAllowed] NSNumber desiredAccuracy, [NullAllowed] NSNumber distanceFilter);

		// +(UALocationEvent * _Nonnull)significantChangeLocationEventWithLocation:(CLLocation * _Nonnull)location providerType:(UALocationServiceProviderType * _Nullable)providerType;
		[Static]
		[Export ("significantChangeLocationEventWithLocation:providerType:")]
		UALocationEvent SignificantChangeLocationEventWithLocation (CLLocation location, [NullAllowed] string providerType);

		// +(UALocationEvent * _Nonnull)standardLocationEventWithLocation:(CLLocation * _Nonnull)location providerType:(UALocationServiceProviderType * _Nullable)providerType desiredAccuracy:(NSNumber * _Nullable)desiredAccuracy distanceFilter:(NSNumber * _Nullable)distanceFilter;
		[Static]
		[Export ("standardLocationEventWithLocation:providerType:desiredAccuracy:distanceFilter:")]
		UALocationEvent StandardLocationEventWithLocation (CLLocation location, [NullAllowed] string providerType, [NullAllowed] NSNumber desiredAccuracy, [NullAllowed] NSNumber distanceFilter);
	}

	// @protocol UALocationServiceDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UALocationServiceDelegate
	{
		// @optional -(void)locationService:(UALocationService * _Nonnull)service didFailWithError:(NSError * _Nonnull)error;
		[Export ("locationService:didFailWithError:")]
		void DidFailWithError (UALocationService service, NSError error);

		// @optional -(void)locationService:(UALocationService * _Nonnull)service didChangeAuthorizationStatus:(CLAuthorizationStatus)status;
		[Export ("locationService:didChangeAuthorizationStatus:")]
		void DidChangeAuthorizationStatus (UALocationService service, CLAuthorizationStatus status);

		// @optional -(void)locationService:(UALocationService * _Nonnull)service didUpdateLocations:(NSArray * _Nonnull)locations;
		[Export ("locationService:didUpdateLocations:")]
		void DidUpdateLocations (UALocationService service, CLLocation[] locations);
	}

	// @interface UALocationService : NSObject <UALocationProviderDelegate>
	[BaseType (typeof(NSObject))]
	interface UALocationService
	{
		// -(CLLocationDistance)standardLocationDistanceFilter;
		// -(void)setStandardLocationDistanceFilter:(CLLocationDistance)distanceFilter;
		[Export ("standardLocationDistanceFilter")]
		double StandardLocationDistanceFilter { get; set; }

		// -(CLLocationAccuracy)standardLocationDesiredAccuracy;
		// -(void)setStandardLocationDesiredAccuracy:(CLLocationDistance)desiredAccuracy;
		[Export ("standardLocationDesiredAccuracy")]
		double StandardLocationDesiredAccuracy { get; set; }

		// -(void)setStandardLocationDesiredAccuracy:(CLLocationAccuracy)desiredAccuracy;
		[Export ("setStandardLocationDesiredAccuracy:")]
		void SetStandardLocationDesiredAccuracy (double desiredAccuracy);

		// +(BOOL)airshipLocationServiceEnabled;
		[Static]
		[Export ("airshipLocationServiceEnabled")]
		bool AirshipLocationServiceEnabled ();

		// +(void)setAirshipLocationServiceEnabled:(BOOL)airshipLocationServiceEnabled;
		[Static]
		[Export ("setAirshipLocationServiceEnabled:")]
		void SetAirshipLocationServiceEnabled (bool airshipLocationServiceEnabled);

		// +(BOOL)locationServicesEnabled;
		[Static]
		[Export ("locationServicesEnabled")]
		bool LocationServicesEnabled ();

		// +(BOOL)locationServiceAuthorized;
		[Static]
		[Export ("locationServiceAuthorized")]
		bool LocationServiceAuthorized ();

		// +(BOOL)coreLocationWillPromptUserForPermissionToRun;
		[Static]
		[Export ("coreLocationWillPromptUserForPermissionToRun")]
		bool CoreLocationWillPromptUserForPermissionToRun ();

		// -(CLLocation * _Nullable)location;
		[Export ("location")]
		[return: NullAllowed]
		CLLocation Location ();

		// @property (readonly, nonatomic, strong) CLLocation * _Nullable lastReportedLocation;
		[NullAllowed, Export ("lastReportedLocation", ArgumentSemantic.Strong)]
		CLLocation LastReportedLocation { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable dateOfLastLocation;
		[NullAllowed, Export ("dateOfLastLocation", ArgumentSemantic.Strong)]
		NSDate DateOfLastLocation { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		UALocationServiceDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<UALocationServiceDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic, setter = setAutomaticLocationOnForegroundEnabled:) BOOL automaticLocationOnForegroundEnabled;
		[Export ("automaticLocationOnForegroundEnabled")]
		bool AutomaticLocationOnForegroundEnabled { get; [Bind ("setAutomaticLocationOnForegroundEnabled:")] set; }

		// @property (assign, nonatomic) BOOL requestAlwaysAuthorization;
		[Export ("requestAlwaysAuthorization")]
		bool RequestAlwaysAuthorization { get; set; }

		// @property (getter = isBackgroundLocationServiceEnabled, assign, nonatomic) BOOL backgroundLocationServiceEnabled;
		[Export ("backgroundLocationServiceEnabled")]
		bool BackgroundLocationServiceEnabled { [Bind ("isBackgroundLocationServiceEnabled")] get; set; }

		// @property (assign, nonatomic) NSTimeInterval minimumTimeBetweenForegroundUpdates;
		[Export ("minimumTimeBetweenForegroundUpdates")]
		double MinimumTimeBetweenForegroundUpdates { get; set; }

		// @property (readonly, assign, nonatomic) UALocationProviderStatus standardLocationServiceStatus;
		[Export ("standardLocationServiceStatus", ArgumentSemantic.Assign)]
		UALocationProviderStatus StandardLocationServiceStatus { get; }

		// @property (readonly, assign, nonatomic) UALocationProviderStatus significantChangeServiceStatus;
		[Export ("significantChangeServiceStatus", ArgumentSemantic.Assign)]
		UALocationProviderStatus SignificantChangeServiceStatus { get; }

		// @property (readonly, assign, nonatomic) UALocationProviderStatus singleLocationServiceStatus;
		[Export ("singleLocationServiceStatus", ArgumentSemantic.Assign)]
		UALocationProviderStatus SingleLocationServiceStatus { get; }

		// -(NSString * _Nullable)purpose;
		[Export ("purpose")]
		[return: NullAllowed]
		string Purpose ();

		// -(void)startReportingStandardLocation;
		[Export ("startReportingStandardLocation")]
		void StartReportingStandardLocation ();

		// -(void)stopReportingStandardLocation;
		[Export ("stopReportingStandardLocation")]
		void StopReportingStandardLocation ();

		// -(void)startReportingSignificantLocationChanges;
		[Export ("startReportingSignificantLocationChanges")]
		void StartReportingSignificantLocationChanges ();

		// -(void)stopReportingSignificantLocationChanges;
		[Export ("stopReportingSignificantLocationChanges")]
		void StopReportingSignificantLocationChanges ();

		// -(NSTimeInterval)timeoutForSingleLocationService;
		[Export ("timeoutForSingleLocationService")]
		double TimeoutForSingleLocationService ();

		// -(void)setTimeoutForSingleLocationService:(NSTimeInterval)timeoutForSingleLocationService;
		[Export ("setTimeoutForSingleLocationService:")]
		void SetTimeoutForSingleLocationService (double timeoutForSingleLocationService);

		// -(CLLocationAccuracy)singleLocationDesiredAccuracy;
		[Export ("singleLocationDesiredAccuracy")]
		double SingleLocationDesiredAccuracy ();

		// -(void)setSingleLocationDesiredAccuracy:(CLLocationAccuracy)desiredAccuracy;
		[Export ("setSingleLocationDesiredAccuracy:")]
		void SetSingleLocationDesiredAccuracy (double desiredAccuracy);

		// -(void)reportCurrentLocation;
		[Export ("reportCurrentLocation")]
		void ReportCurrentLocation ();
	}

	// @protocol UAInAppMessageControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UAInAppMessageControllerDelegate
	{
		// @required -(UIView * _Nonnull)viewForMessage:(UAInAppMessage * _Nonnull)message parentView:(UIView * _Nonnull)parentView;
		[Abstract]
		[Export ("viewForMessage:parentView:")]
		UIView ViewForMessage (UAInAppMessage message, UIView parentView);

		// @required -(UIControl * _Nonnull)messageView:(UIView * _Nonnull)messageView buttonAtIndex:(NSUInteger)index;
		[Abstract]
		[Export ("messageView:buttonAtIndex:")]
		UIControl ButtonAtIndex (UIView messageView, nuint index);

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
		UAInAppMessage MessageWithPayload (NSDictionary payload);

		// -(BOOL)isEqualToMessage:(UAInAppMessage * _Nullable)message;
		[Export ("isEqualToMessage:")]
		bool IsEqualToMessage ([NullAllowed] UAInAppMessage message);

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
		UAUserNotificationAction[] NotificationActions { get; }

		// @property (readonly, nonatomic) UAUserNotificationCategory * _Nullable buttonCategory;
		[NullAllowed, Export ("buttonCategory")]
		UAUserNotificationCategory ButtonCategory { get; }

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

	// @interface UAUserNotificationAction : NSObject
	[BaseType (typeof(NSObject))]
	interface UAUserNotificationAction
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable identifier;
		[NullAllowed, Export ("identifier")]
		string Identifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; }

		// @property (readonly, assign, nonatomic) UIUserNotificationActivationMode activationMode;
		[Export ("activationMode", ArgumentSemantic.Assign)]
		UIUserNotificationActivationMode ActivationMode { get; }

		// @property (readonly, getter = isAuthenticationRequired, assign, nonatomic) BOOL authenticationRequired;
		[Export ("authenticationRequired")]
		bool AuthenticationRequired { [Bind ("isAuthenticationRequired")] get; }

		// @property (readonly, getter = isDestructive, assign, nonatomic) BOOL destructive;
		[Export ("destructive")]
		bool Destructive { [Bind ("isDestructive")] get; }

		// -(BOOL)isEqualToAction:(UAUserNotificationAction * _Nullable)notificationAction;
		[Export ("isEqualToAction:")]
		bool IsEqualToAction ([NullAllowed] UAUserNotificationAction notificationAction);
	}

	// @interface UAMutableUserNotificationAction : UAUserNotificationAction
	[BaseType (typeof(UAUserNotificationAction))]
	interface UAMutableUserNotificationAction
	{
		// +(instancetype _Nonnull)actionWithUIUserNotificationAction:(UIUserNotificationAction * _Nonnull)uiAction;
		[Static]
		[Export ("actionWithUIUserNotificationAction:")]
		UAMutableUserNotificationAction ActionWithUIUserNotificationAction (UIUserNotificationAction uiAction);

		// @property (copy, nonatomic) NSString * _Nullable identifier;
		[NullAllowed, Export ("identifier")]
		string Identifier { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (assign, nonatomic) UIUserNotificationActivationMode activationMode;
		[Export ("activationMode", ArgumentSemantic.Assign)]
		UIUserNotificationActivationMode ActivationMode { get; set; }

		// @property (getter = isAuthenticationRequired, assign, nonatomic) BOOL authenticationRequired;
		[Export ("authenticationRequired")]
		bool AuthenticationRequired { [Bind ("isAuthenticationRequired")] get; set; }

		// @property (getter = isDestructive, assign, nonatomic) BOOL destructive;
		[Export ("destructive")]
		bool Destructive { [Bind ("isDestructive")] get; set; }
	}

	// @interface UAUserNotificationCategory : NSObject
	[BaseType (typeof(NSObject))]
	interface UAUserNotificationCategory
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable identifier;
		[NullAllowed, Export ("identifier")]
		string Identifier { get; }

		// -(NSArray * _Nullable)actionsForContext:(UIUserNotificationActionContext)context;
		[Export ("actionsForContext:")]
		[return: NullAllowed]
		UAUserNotificationAction[] ActionsForContext (UIUserNotificationActionContext context);

		// -(BOOL)isEqualToCategory:(UAUserNotificationCategory * _Nullable)category;
		[Export ("isEqualToCategory:")]
		bool IsEqualToCategory ([NullAllowed] UAUserNotificationCategory category);
	}

	// @interface UAMutableUserNotificationCategory : UAUserNotificationCategory
	[BaseType (typeof(UAUserNotificationCategory))]
	interface UAMutableUserNotificationCategory
	{
		// +(instancetype _Nonnull)categoryWithUIUserNotificationCategory:(UIUserNotificationCategory * _Nonnull)uiCategory;
		[Static]
		[Export ("categoryWithUIUserNotificationCategory:")]
		UAMutableUserNotificationCategory CategoryWithUIUserNotificationCategory (UIUserNotificationCategory uiCategory);

		// -(void)setActions:(NSArray * _Nullable)actions forContext:(UIUserNotificationActionContext)context;
		[Export ("setActions:forContext:")]
		void SetActions ([NullAllowed] UAUserNotificationAction[] actions, UIUserNotificationActionContext context);

		// @property (copy, nonatomic) NSString * _Nullable identifier;
		[NullAllowed, Export ("identifier")]
		string Identifier { get; set; }
	}

	// @interface UAUserNotificationCategories : NSObject
	[BaseType (typeof(NSObject))]
	interface UAUserNotificationCategories
	{
		// +(NSSet * _Nonnull)createCategoriesFromFile:(NSString * _Nonnull)filePath;
		[Static]
		[Export ("createCategoriesFromFile:")]
		NSSet CreateCategoriesFromFile (string filePath);

		// +(UAUserNotificationCategory * _Nonnull)createCategory:(NSString * _Nonnull)categoryId actions:(NSArray * _Nonnull)actionDefinitions;
		[Static]
		[Export ("createCategory:actions:")]
		UAUserNotificationCategory CreateCategory (string categoryId, NSDictionary[] actionDefinitions);
	}

}
