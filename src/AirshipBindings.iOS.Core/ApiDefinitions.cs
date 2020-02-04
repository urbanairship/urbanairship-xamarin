/*
 Copyright Airship and Contributors
*/
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using System;
using UIKit;
using UserNotifications;
using WebKit;

namespace UrbanAirship {

    [Static]
    partial interface Constants
    {
        // extern NSString *const _Nonnull UAActionMetadataForegroundPresentationKey
        [Field("UAActionMetadataForegroundPresentationKey", "__Internal")]
        NSString UAActionMetadataForegroundPresentationKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataInboxMessageIDKey
        [Field("UAActionMetadataInboxMessageIDKey", "__Internal")]
        NSString UAActionMetadataInboxMessageIDKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataPushPayloadKey
        [Field("UAActionMetadataPushPayloadKey", "__Internal")]
        NSString UAActionMetadataPushPayloadKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataRegisteredName
        [Field("UAActionMetadataRegisteredName", "__Internal")]
        NSString UAActionMetadataRegisteredName { get; }

        // extern NSString *const _Nonnull UAActionMetadataResponseInfoKey
        [Field("UAActionMetadataResponseInfoKey", "__Internal")]
        NSString UAActionMetadataResponseInfoKey { get; }

        // extern NSString *const _Nonnull UAActionMetadataUserNotificationActionIDKey
        [Field("UAActionMetadataUserNotificationActionIDKey", "__Internal")]
        NSString UAActionMetadataUserNotificationActionIDKey { get; }

        // extern NSString *const _Nonnull UAAddCustomEventActionErrorDomain
        [Field("UAAddCustomEventActionErrorDomain", "__Internal")]
        NSString UAAddCustomEventActionErrorDomain { get; }

        // extern const NSUInteger UAAssociatedIdentifiersMaxCharacterCount
        [Field("UAAssociatedIdentifiersMaxCharacterCount", "__Internal")]
        nuint UAAssociatedIdentifiersMaxCharacterCount { get; }

        // extern const NSUInteger UAAssociatedIdentifiersMaxCount
        [Field("UAAssociatedIdentifiersMaxCount", "__Internal")]
        nuint UAAssociatedIdentifiersMaxCount { get; }

        // extern NSString *const UAChannelCreatedEvent
        [Field("UAChannelCreatedEvent", "__Internal")]
        NSString UAChannelCreatedEvent { get; }

        // extern NSString *const UAChannelCreatedEventChannelKey
        [Field("UAChannelCreatedEventChannelKey", "__Internal")]
        NSString UAChannelCreatedEventChannelKey { get; }

        // extern NSString *const UAChannelCreatedEventExistingKey
        [Field("UAChannelCreatedEventExistingKey", "__Internal")]
        NSString UAChannelCreatedEventExistingKey { get; }

        // extern NSString *const UAChannelRegistrationFailedEvent
        [Field("UAChannelRegistrationFailedEvent", "__Internal")]
        NSString UAChannelRegistrationFailedEvent { get; }

        // extern NSString *const UAChannelUpdatedEvent
        [Field("UAChannelUpdatedEvent", "__Internal")]
        NSString UAChannelUpdatedEvent { get; }

        // extern NSString *const UAChannelUpdatedEventChannelKey
        [Field("UAChannelUpdatedEventChannelKey", "__Internal")]
        NSString UAChannelUpdatedEventChannelKey { get; }

        // extern NSString *const UACustomEventAdded
        [Field("UACustomEventAdded", "__Internal")]
        NSString UACustomEventAdded { get; }

        // extern const NSUInteger UACustomEventCharacterLimit
        [Field("UACustomEventCharacterLimit", "__Internal")]
        nuint UACustomEventCharacterLimit { get; }

        // extern NSString *const UACustomEventInteractionIDKey
        [Field("UACustomEventInteractionIDKey", "__Internal")]
        NSString UACustomEventInteractionIDKey { get; }

        // extern NSString *const UACustomEventInteractionTypeKey
        [Field("UACustomEventInteractionTypeKey", "__Internal")]
        NSString UACustomEventInteractionTypeKey { get; }

        // extern const NSUInteger UACustomEventMaxPropertiesCount
        [Field("UACustomEventMaxPropertiesCount", "__Internal")]
        nuint UACustomEventMaxPropertiesCount { get; }

        // extern NSString *const UACustomEventNameKey
        [Field("UACustomEventNameKey", "__Internal")]
        NSString UACustomEventNameKey { get; }

        // extern NSString *const UACustomEventPropertiesKey
        [Field("UACustomEventPropertiesKey", "__Internal")]
        NSString UACustomEventPropertiesKey { get; }

        // extern NSString *const UACustomEventTransactionIDKey
        [Field("UACustomEventTransactionIDKey", "__Internal")]
        NSString UACustomEventTransactionIDKey { get; }

        // extern NSString *const UACustomEventValueKey
        [Field("UACustomEventValueKey", "__Internal")]
        NSString UACustomEventValueKey { get; }

        // extern NSString *const _Nonnull UADeviceIDChangedNotification
        [Field("UADeviceIDChangedNotification", "__Internal")]
        NSString UADeviceIDChangedNotification { get; }

        // extern NSString *const UAEnableBackgroundLocationActionValue
        [Field("UAEnableBackgroundLocationActionValue", "__Internal")]
        NSString UAEnableBackgroundLocationActionValue { get; }

        // extern NSString *const UAEnableLocationActionValue
        [Field("UAEnableLocationActionValue", "__Internal")]
        NSString UAEnableLocationActionValue { get; }

        // extern NSString *const UAEnableUserNotificationsActionValue
        [Field("UAEnableUserNotificationsActionValue", "__Internal")]
        NSString UAEnableUserNotificationsActionValue { get; }

        // extern NSString *const UAEventKey
        [Field("UAEventKey", "__Internal")]
        NSString UAEventKey { get; }

        // extern NSString *const _Nonnull UAJSONMatcherErrorDomain
        [Field("UAJSONMatcherErrorDomain", "__Internal")]
        NSString UAJSONMatcherErrorDomain { get; }

        // extern NSString *const _Nonnull UAJSONPredicateErrorDomain
        [Field("UAJSONPredicateErrorDomain", "__Internal")]
        NSString UAJSONPredicateErrorDomain { get; }

        // extern NSString *const _Nonnull UAJSONValueMatcherErrorDomain
        [Field("UAJSONValueMatcherErrorDomain", "__Internal")]
        NSString UAJSONValueMatcherErrorDomain { get; }

        // extern NSString *const _Nonnull UANativeBridgeUAirshipScheme
        [Field("UANativeBridgeUAirshipScheme", "__Internal")]
        NSString UANativeBridgeUAirshipScheme { get; }

        // extern NSString *const _Nonnull UANotificationDefaultActionIdentifier
        [Field("UANotificationDefaultActionIdentifier", "__Internal")]
        NSString UANotificationDefaultActionIdentifier { get; }

        // extern NSString *const _Nonnull UANotificationDismissActionIdentifier
        [Field("UANotificationDismissActionIdentifier", "__Internal")]
        NSString UANotificationDismissActionIdentifier { get; }

        // static const UANotificationOptions UANotificationOptionNone = 0
        [Field("UANotificationOptionNone", "__Internal")]
        UANotificationOptions UANotificationOptionNone { get; }

        // extern NSString *const _Nonnull UAOpenExternalURLActionErrorDomain
        [Field("UAOpenExternalURLActionErrorDomain", "__Internal")]
        NSString UAOpenExternalURLActionErrorDomain { get; }

        // extern NSString *const _Nonnull UAPaddingBottomKey
        [Field("UAPaddingBottomKey", "__Internal")]
        NSString UAPaddingBottomKey { get; }

        // extern NSString *const _Nonnull UAPaddingLeadingKey
        [Field("UAPaddingLeadingKey", "__Internal")]
        NSString UAPaddingLeadingKey { get; }

        // extern NSString *const _Nonnull UAPaddingTopKey
        [Field("UAPaddingTopKey", "__Internal")]
        NSString UAPaddingTopKey { get; }

        // extern NSString *const _Nonnull UAPaddingTrailingKey
        [Field("UAPaddingTrailingKey", "__Internal")]
        NSString UAPaddingTrailingKey { get; }

        // extern NSString *const _Nonnull UAReceivedBackgroundNotificationEvent
        [Field("UAReceivedBackgroundNotificationEvent", "__Internal")]
        NSString UAReceivedBackgroundNotificationEvent { get; }

        // extern NSString *const _Nonnull UAReceivedForegroundNotificationEvent
        [Field("UAReceivedForegroundNotificationEvent", "__Internal")]
        NSString UAReceivedForegroundNotificationEvent { get; }

        // extern NSString *const _Nonnull UAReceivedNotificationResponseEvent
        [Field("UAReceivedNotificationResponseEvent", "__Internal")]
        NSString UAReceivedNotificationResponseEvent { get; }

        // extern NSString *const UARegionEventAdded
        [Field("UARegionEventAdded", "__Internal")]
        NSString UARegionEventAdded { get; }

        // extern NSString *const UARemoteDataMetadataCountryKey
        [Field("UARemoteDataMetadataCountryKey", "__Internal")]
        NSString UARemoteDataMetadataCountryKey { get; }

        // extern NSString *const _Nonnull UARemoteDataMetadataLanguageKey
        [Field("UARemoteDataMetadataLanguageKey", "__Internal")]
        NSString UARemoteDataMetadataLanguageKey { get; }

        // extern NSString *const UARemoteDataMetadataSDKVersionKey
        [Field("UARemoteDataMetadataSDKVersionKey", "__Internal")]
        NSString UARemoteDataMetadataSDKVersionKey { get; }

        // extern NSString *const UAScreenKey
        [Field("UAScreenKey", "__Internal")]
        NSString UAScreenKey { get; }

        // extern NSString *const UAScreenTracked
        [Field("UAScreenTracked", "__Internal")]
        NSString UAScreenTracked { get; }

        // extern NSString *const _Nonnull UAirshipTakeOffBackgroundThreadException
        [Field("UAirshipTakeOffBackgroundThreadException", "__Internal")]
        NSString UAirshipTakeOffBackgroundThreadException { get; }

        // extern UALogLevel uaLogLevel
        [Field("uaLogLevel", "__Internal")]
        UALogLevel uaLogLevel { get; }

        // extern BOOL uaLoggingEnabled
        [Field("uaLoggingEnabled", "__Internal")]
        nuint uaLoggingEnabled { get; }

        // extern BOOL uaLoudImpErrorLoggingEnabled
        [Field("uaLoudImpErrorLoggingEnabled", "__Internal")]
        nuint uaLoudImpErrorLoggingEnabled { get; }

    }

    // @interface UAAccountEventTemplate : NSObject
    [BaseType(typeof(NSObject))]
    interface UAAccountEventTemplate
    {
        // @property (readwrite, strong, nonatomic, nullable) NSDecimalNumber *eventValue;
        [NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
        NSDecimalNumber EventValue { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *transactionID;
        [NullAllowed, Export("transactionID")]
        string TransactionID { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *category;
        [NullAllowed, Export("category")]
        string Category { get; set; }

        // + (nonnull instancetype)registeredTemplate;
        [Static]
        [Export("registeredTemplate")]
        UAAccountEventTemplate RegisteredTemplate ();

        // + (nonnull instancetype)registeredTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("registeredTemplateWithValueFromString:")]
        UAAccountEventTemplate RegisteredTemplate ([NullAllowed] string eventValue);

        // + (nonnull instancetype)registeredTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("registeredTemplateWithValue:")]
        UAAccountEventTemplate RegisteredTemplate ([NullAllowed] NSNumber eventValue);

        // - (nonnull UACustomEvent *)createEvent;
        [Export("createEvent")]
        UACustomEvent CreateEvent ();
    }

    // typedef BOOL (^UAActionPredicate)(UAActionArguments *_Nonnull)
    delegate bool UAActionPredicate (UAActionArguments arg0);

    // typedef void (^UAActionCompletionHandler)(UAActionResult *_Nonnull)
    delegate void UAActionCompletionHandler (UAActionResult arg0);

    // typedef void (^UAActionBlock)(UAActionArguments *_Nonnull, UAActionCompletionHandler _Nonnull)
    delegate void UAActionBlock (UAActionArguments arg0, [BlockCallback] UAActionCompletionHandler arg1);

    // @interface UAAction : NSObject
    [BaseType(typeof(NSObject))]
    interface UAAction
    {

        // - (BOOL)acceptsArguments:(nonnull UAActionArguments *)arguments;
        [Export("acceptsArguments:")]
        bool AcceptsArguments (UAActionArguments arguments);

        // - (void)willPerformWithArguments:(nonnull UAActionArguments *)arguments;
        [Export("willPerformWithArguments:")]
        void WillPerform (UAActionArguments arguments);

        // - (void)didPerformWithArguments:(nonnull UAActionArguments *)arguments withResult:(nonnull UAActionResult *)result;
        [Export("didPerformWithArguments:withResult:")]
        void DidPerform (UAActionArguments arguments, UAActionResult result);

        // - (void)performWithArguments:(nonnull UAActionArguments *)arguments completionHandler: (nonnull UAActionCompletionHandler)completionHandler;
        [Export("performWithArguments:completionHandler:")]
        void Perform (UAActionArguments arguments, UAActionCompletionHandler completionHandler);

        // + (nonnull instancetype)action;
        [Static]
        [Export("action")]
        UAAction Action ();

        // + (nonnull instancetype)actionWithBlock:(nonnull UAActionBlock)actionBlock;
        [Static]
        [Export("actionWithBlock:")]
        UAAction Action (UAActionBlock actionBlock);

        // + (nonnull instancetype)actionWithBlock:(nonnull UAActionBlock)actionBlock acceptingArguments: (nullable UAActionPredicate)predicateBlock;
        [Static]
        [Export("actionWithBlock:acceptingArguments:")]
        UAAction Action (UAActionBlock actionBlock, [NullAllowed] UAActionPredicate predicateBlock);

    }

    // @interface UAActionArguments : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionArguments
    {
        // @property (readonly, assign, nonatomic) UASituation situation;
        [Export("situation", ArgumentSemantic.Assign)]
        UASituation Situation { get; }

        // @property (readonly, strong, nonatomic, nullable) id value;
        [NullAllowed, Export("value", ArgumentSemantic.Strong)]
        NSObject Value { get; }

        // @property (readonly, copy, nonatomic, nullable) NSDictionary *metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary Metadata { get; }

        // + (nonnull instancetype)argumentsWithValue:(nullable id)value withSituation:(UASituation)situation;
        [Static]
        [Export("argumentsWithValue:withSituation:")]
        UAActionArguments Arguments ([NullAllowed] NSObject value, UASituation situation);

        // + (nonnull instancetype)argumentsWithValue:(nullable id)value withSituation:(UASituation)situation metadata:(nullable NSDictionary *)metadata;
        [Static]
        [Export("argumentsWithValue:withSituation:metadata:")]
        UAActionArguments Arguments ([NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata);
    }

    // @protocol UAActionPredicateProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAActionPredicateProtocol
    {

        // - (BOOL)applyActionArguments:(nonnull UAActionArguments *)args;
        [Abstract]
        [Export("applyActionArguments:")]
        bool ApplyActionArguments (NSObject args);

        // + (nonnull instancetype)predicate;
        [Static]
        [Export("predicate")]
        UAActionPredicateProtocol Predicate ();
    }

    interface IUAActionPredicateProtocol { }

    // @interface UAActionRegistry : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionRegistry
    {
        // @property (readonly, nonatomic) NSSet<NSMutableDictionary *> *_Nonnull registeredEntries;
        [Export("registeredEntries")]
        NSSet<NSMutableDictionary> RegisteredEntries { get; }

        // + (nonnull instancetype)defaultRegistry;
        [Static]
        [Export("defaultRegistry")]
        UAActionRegistry DefaultRegistry ();

        // - (BOOL)registerAction:(nonnull UAAction *)action name:(nonnull NSString *)name predicate:(nullable UAActionPredicate)predicate;
        [Export("registerAction:name:predicate:")]
        bool RegisterAction (UAAction action, string name, [NullAllowed] UAActionPredicate predicate);

        // - (BOOL)registerActionClass:(nonnull Class)actionClass name:(nonnull NSString *)name predicate:(nullable UAActionPredicate)predicate;
        [Export("registerActionClass:name:predicate:")]
        bool RegisterActionClass (Class actionClass, string name, [NullAllowed] UAActionPredicate predicate);

        // - (BOOL)registerAction:(nonnull UAAction *)action names:(nonnull NSArray *)names predicate:(nullable UAActionPredicate)predicate;
        [Export("registerAction:names:predicate:")]
        bool RegisterAction (UAAction action, NSObject[] names, [NullAllowed] UAActionPredicate predicate);

        // - (BOOL)registerActionClass:(nonnull Class)actionClass names:(nonnull NSArray *)names predicate:(nullable UAActionPredicate)predicate;
        [Export("registerActionClass:names:predicate:")]
        bool RegisterActionClass (Class actionClass, NSObject[] names, [NullAllowed] UAActionPredicate predicate);

        // - (BOOL)registerAction:(nonnull UAAction *)action name:(nonnull NSString *)name;
        [Export("registerAction:name:")]
        bool RegisterAction (UAAction action, string name);

        // - (BOOL)registerAction:(nonnull UAAction *)action names:(nonnull NSArray *)names;
        [Export("registerAction:names:")]
        bool RegisterAction (UAAction action, NSObject[] names);

        // - (BOOL)registerActionClass:(nonnull Class)actionClass name:(nonnull NSString *)name;
        [Export("registerActionClass:name:")]
        bool RegisterActionClass (Class actionClass, string name);

        // - (BOOL)registerActionClass:(nonnull Class)actionClass names:(nonnull NSArray *)names;
        [Export("registerActionClass:names:")]
        bool RegisterActionClass (Class actionClass, NSObject[] names);

        // - (nullable UAActionRegistryEntry *)registryEntryWithName: (nonnull NSString *)name;
        [Export("registryEntryWithName:")]
        [return: NullAllowed]
        UAActionRegistryEntry RegistryEntry (string name);

        // - (void)registerActionsFromFile:(nonnull NSString *)path;
        [Export("registerActionsFromFile:")]
        void RegisterActions (string path);

        // - (BOOL)addSituationOverride:(UASituation)situation forEntryWithName:(nonnull NSString *)name action:(nullable UAAction *)action;
        [Export("addSituationOverride:forEntryWithName:action:")]
        bool AddSituationOverride (UASituation situation, string name, [NullAllowed] UAAction action);

        // - (BOOL)updatePredicate:(nullable UAActionPredicate)predicate forEntryWithName:(nonnull NSString *)name;
        [Export("updatePredicate:forEntryWithName:")]
        bool UpdatePredicate ([NullAllowed] UAActionPredicate predicate, string name);

        // - (BOOL)updateAction:(nonnull UAAction *)action forEntryWithName:(nonnull NSString *)name;
        [Export("updateAction:forEntryWithName:")]
        bool UpdateAction (UAAction action, string name);

        // - (BOOL)updateActionClass:(nonnull Class)actionClass forEntryWithName:(nonnull NSString *)name;
        [Export("updateActionClass:forEntryWithName:")]
        bool UpdateActionClass (Class actionClass, string name);

        // - (BOOL)removeName:(nonnull NSString *)name;
        [Export("removeName:")]
        bool RemoveName (string name);

        // - (BOOL)removeEntryWithName:(nonnull NSString *)name;
        [Export("removeEntryWithName:")]
        bool RemoveEntry (string name);

        // - (BOOL)addName:(nonnull NSString *)name forEntryWithName:(nonnull NSString *)entryName;
        [Export("addName:forEntryWithName:")]
        bool AddName (string name, string entryName);
    }

    // @interface UAActionRegistryEntry : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionRegistryEntry
    {
        // @property (readwrite, strong, nonatomic) UAAction *_Nonnull action;
        [Export("action", ArgumentSemantic.Strong)]
        UAAction Action { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) UAActionPredicate predicate;
        [NullAllowed, Export("predicate", ArgumentSemantic.Copy)]
        UAActionPredicate Predicate { get; set; }

        // @property (readonly, nonatomic) NSArray<NSString *> *_Nonnull names;
        [Export("names")]
        string[] Names { get; }

        // + (nonnull instancetype)entryForAction:(nonnull UAAction *)action predicate:(nonnull UAActionPredicate)predicate;
        [Static]
        [Export("entryForAction:predicate:")]
        UAActionRegistryEntry Entry (UAAction action, UAActionPredicate predicate);

        // + (nonnull instancetype)entryForActionClass:(nonnull Class)actionClass predicate: (nonnull UAActionPredicate)predicate;
        [Static]
        [Export("entryForActionClass:predicate:")]
        UAActionRegistryEntry Entry (Class actionClass, UAActionPredicate predicate);

        // - (nonnull UAAction *)actionForSituation:(UASituation)situation;
        [Export("actionForSituation:")]
        UAAction ActionForSituation (UASituation situation);
    }

    // @interface UAActionResult : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionResult
    {
        // @property (readonly, strong, nonatomic, nullable) id value;
        [NullAllowed, Export("value", ArgumentSemantic.Strong)]
        NSObject Value { get; }

        // @property (readonly, assign, nonatomic) UAActionFetchResult fetchResult;
        [Export("fetchResult", ArgumentSemantic.Assign)]
        UAActionFetchResult FetchResult { get; }

        // @property (readonly, strong, nonatomic, nullable) NSError *error;
        [NullAllowed, Export("error", ArgumentSemantic.Strong)]
        NSError Error { get; }

        // @property (readonly, assign, nonatomic) UAActionStatus status;
        [Export("status", ArgumentSemantic.Assign)]
        UAActionStatus Status { get; }

        // + (nonnull instancetype)resultWithValue:(nullable id)value;
        [Static]
        [Export("resultWithValue:")]
        UAActionResult Result ([NullAllowed] NSObject value);

        // + (nonnull instancetype)resultWithValue:(nullable id)result withFetchResult:(UAActionFetchResult)fetchResult;
        [Static]
        [Export("resultWithValue:withFetchResult:")]
        UAActionResult Result ([NullAllowed] NSObject result, UAActionFetchResult fetchResult);

        // + (nonnull instancetype)emptyResult;
        [Static]
        [Export("emptyResult")]
        UAActionResult EmptyResult ();

        // + (nonnull instancetype)resultWithError:(nonnull NSError *)error;
        [Static]
        [Export("resultWithError:")]
        UAActionResult Result (NSError error);

        // + (nonnull instancetype)resultWithError:(nonnull NSError *)error withFetchResult:(UAActionFetchResult)fetchResult;
        [Static]
        [Export("resultWithError:withFetchResult:")]
        UAActionResult Result (NSError error, UAActionFetchResult fetchResult);
    }

    // @interface UAActionRunner : NSObject
    [BaseType(typeof(NSObject))]
    interface UAActionRunner
    {

        // + (void)runActionWithName:(nonnull NSString *)actionName value:(nullable id)value situation:(UASituation)situation;
        [Static]
        [Export("runActionWithName:value:situation:")]
        void RunAction (string actionName, [NullAllowed] NSObject value, UASituation situation);

        // + (void)runActionWithName:(nonnull NSString *)actionName value:(nullable id)value situation:(UASituation)situation metadata:(nonnull NSDictionary *)metadata;
        [Static]
        [Export("runActionWithName:value:situation:metadata:")]
        void RunAction (string actionName, [NullAllowed] NSObject value, UASituation situation, NSDictionary metadata);

        // + (void)runActionWithName:(nonnull NSString *)actionName value:(nullable id)value situation:(UASituation)situation completionHandler:(nonnull UAActionCompletionHandler)completionHandler;
        [Static]
        [Export("runActionWithName:value:situation:completionHandler:")]
        void RunAction (string actionName, [NullAllowed] NSObject value, UASituation situation, UAActionCompletionHandler completionHandler);

        // + (void)runActionWithName:(nonnull NSString *)actionName value:(nullable id)value situation:(UASituation)situation metadata:(nullable NSDictionary *)metadata completionHandler:(nullable UAActionCompletionHandler)completionHandler;
        [Static]
        [Export("runActionWithName:value:situation:metadata:completionHandler:")]
        void RunAction (string actionName, [NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata, [NullAllowed] UAActionCompletionHandler completionHandler);

        // + (void)runAction:(nonnull UAAction *)action value:(nullable id)value situation:(UASituation)situation;
        [Static]
        [Export("runAction:value:situation:")]
        void RunAction (UAAction action, [NullAllowed] NSObject value, UASituation situation);

        // + (void)runAction:(nonnull UAAction *)action value:(nullable id)value situation:(UASituation)situation metadata:(nullable NSDictionary *)metadata;
        [Static]
        [Export("runAction:value:situation:metadata:")]
        void RunAction (UAAction action, [NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata);

        // + (void)runAction:(nonnull UAAction *)action value:(nullable id)value situation:(UASituation)situation completionHandler:(nonnull UAActionCompletionHandler)completionHandler;
        [Static]
        [Export("runAction:value:situation:completionHandler:")]
        void RunAction (UAAction action, [NullAllowed] NSObject value, UASituation situation, UAActionCompletionHandler completionHandler);

        // + (void)runAction:(nonnull UAAction *)action value:(nullable id)value situation:(UASituation)situation metadata:(nullable NSDictionary *)metadata completionHandler:(nullable UAActionCompletionHandler)completionHandler;
        [Static]
        [Export("runAction:value:situation:metadata:completionHandler:")]
        void RunAction (UAAction action, [NullAllowed] NSObject value, UASituation situation, [NullAllowed] NSDictionary metadata, [NullAllowed] UAActionCompletionHandler completionHandler);

        // + (void)runActionsWithActionValues:(nonnull NSDictionary *)actionValues situation:(UASituation)situation metadata:(nullable NSDictionary *)metadata completionHandler: (nullable UAActionCompletionHandler)completionHandler;
        [Static]
        [Export("runActionsWithActionValues:situation:metadata:completionHandler:")]
        void RunActions (NSDictionary actionValues, UASituation situation, [NullAllowed] NSDictionary metadata, [NullAllowed] UAActionCompletionHandler completionHandler);
    }

    // @interface UAActivityViewController : UIActivityViewController <UIPopoverPresentationControllerDelegate, UIPopoverControllerDelegate>
    [BaseType(typeof(UIActivityViewController))]
    interface UAActivityViewController : IUIPopoverPresentationControllerDelegate, IUIPopoverControllerDelegate
    {
        // @property (readwrite, copy, nonatomic, nullable) void (^)(void) dismissalBlock;
        [NullAllowed, Export("dismissalBlock", ArgumentSemantic.Copy)]
        Action DismissalBlock { get; set; }

        // - (CGRect)sourceRect;
        [Export("sourceRect")]
        CGRect SourceRect ();
    }

    // @interface UAAddCustomEventAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAAddCustomEventAction
    {

    }

    // @interface UAAddTagsAction : UAModifyTagsAction
    [BaseType(typeof(UAModifyTagsAction))]
    interface UAAddTagsAction
    {

    }

    // @interface UAAggregateActionResult : UAActionResult
    [BaseType(typeof(UAActionResult))]
    interface UAAggregateActionResult
    {

        // - (void)addResult:(nonnull UAActionResult *)result forAction:(nonnull NSString *)actionName;
        [Export("addResult:forAction:")]
        void AddResult (UAActionResult result, string actionName);

        // - (nonnull UAActionResult *)resultForAction:(nonnull NSString *)actionName;
        [Export("resultForAction:")]
        UAActionResult Result (string actionName);
    }

    // @interface UAAnalytics : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UAAnalytics
    {
        // + (null_unspecified instancetype)shared;
        [Static]
        [Export("shared")]
        [New]
        UAAnalytics Shared ();

        // @property (readonly, copy, nonatomic, nullable) NSString *conversionSendID;
        [NullAllowed, Export("conversionSendID")]
        string ConversionSendID { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *conversionPushMetadata;
        [NullAllowed, Export("conversionPushMetadata")]
        string ConversionPushMetadata { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull sessionID;
        [Export("sessionID")]
        string SessionID { get; }

        // @property (readonly, strong, nonatomic) NSDate *_Nonnull lastSendTime;
        [Export("lastSendTime", ArgumentSemantic.Strong)]
        NSDate LastSendTime { get; }

        // @property (getter=isEnabled, assign, readwrite, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // - (void)addEvent:(nonnull UAEvent *)event;
        [Export("addEvent:")]
        void AddEvent (UAEvent @event);

        // - (void)associateDeviceIdentifiers: (nonnull UAAssociatedIdentifiers *)associatedIdentifiers;
        [Export("associateDeviceIdentifiers:")]
        void AssociateDeviceIdentifiers (UAAssociatedIdentifiers associatedIdentifiers);

        // - (nonnull UAAssociatedIdentifiers *)currentAssociatedDeviceIdentifiers;
        [Export("currentAssociatedDeviceIdentifiers")]
        UAAssociatedIdentifiers CurrentAssociatedDeviceIdentifiers ();

        // - (void)trackScreen:(nullable NSString *)screen;
        [Export("trackScreen:")]
        void TrackScreen ([NullAllowed] string screen);

        // - (void)scheduleUpload;
        [Export("scheduleUpload")]
        void ScheduleUpload ();
    }

    // @interface UAAppIntegration : NSObject
    [BaseType(typeof(NSObject))]
    interface UAAppIntegration
    {

        // + (void)userNotificationCenter:(nonnull UNUserNotificationCenter *)center didReceiveNotificationResponse:(nonnull UNNotificationResponse *)response withCompletionHandler:(nonnull void (^)(void))completionHandler;
        [Static]
        [Export("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
        void UserNotificationCenter (UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler);

        // + (void)userNotificationCenter:(nonnull UNUserNotificationCenter *)center willPresentNotification:(nonnull UNNotification *)notification withCompletionHandler: (nonnull void (^)(UNNotificationPresentationOptions)) completionHandler;
        [Static]
        [Export("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
        void UserNotificationCenter (UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);

        // + (void)application:(nonnull UIApplication *)application performFetchWithCompletionHandler: (nonnull void (^)(UIBackgroundFetchResult))completionHandler;
        [Static]
        [Export("application:performFetchWithCompletionHandler:")]
        void Application (UIApplication application, Action<UIBackgroundFetchResult> completionHandler);

        // + (void)application:(nonnull UIApplication *)application didRegisterForRemoteNotificationsWithDeviceToken: (nonnull NSData *)deviceToken;
        [Static]
        [Export("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
        void Application (UIApplication application, NSData deviceToken);

        // + (void)application:(nonnull UIApplication *)application didFailToRegisterForRemoteNotificationsWithError:(nonnull NSError *)error;
        [Static]
        [Export("application:didFailToRegisterForRemoteNotificationsWithError:")]
        void Application (UIApplication application, NSError error);

        // + (void)application:(nonnull UIApplication *)application didReceiveRemoteNotification:(nonnull NSDictionary *)userInfo fetchCompletionHandler: (nonnull void (^)(UIBackgroundFetchResult))completionHandler;
        [Static]
        [Export("application:didReceiveRemoteNotification:fetchCompletionHandler:")]
        void Application (UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler);
    }

    // @interface UAApplicationMetrics : NSObject
    [BaseType(typeof(NSObject))]
    interface UAApplicationMetrics
    {
        // @property (readonly, strong, nonatomic, nullable) NSDate *lastApplicationOpenDate;
        [NullAllowed, Export("lastApplicationOpenDate", ArgumentSemantic.Strong)]
        NSDate LastApplicationOpenDate { get; }

        // @property (readonly, nonatomic) NSString *_Nonnull currentAppVersion;
        [Export("currentAppVersion")]
        string CurrentAppVersion { get; }

        // @property (readonly, nonatomic) BOOL isAppVersionUpdated;
        [Export("isAppVersionUpdated")]
        bool IsAppVersionUpdated { get; }

    }

    // @interface UAAssociatedIdentifiers : NSObject
    [BaseType(typeof(NSObject))]
    interface UAAssociatedIdentifiers
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *advertisingID;
        [NullAllowed, Export("advertisingID")]
        string AdvertisingID { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *vendorID;
        [NullAllowed, Export("vendorID")]
        string VendorID { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL advertisingTrackingEnabled;
        [Export("advertisingTrackingEnabled")]
        bool AdvertisingTrackingEnabled { get; set; }

        // @property (readonly, nonatomic) NSDictionary *_Nonnull allIDs;
        [Export("allIDs")]
        NSDictionary AllIDs { get; }

        // + (nonnull instancetype)identifiers;
        [Static]
        [Export("identifiers")]
        UAAssociatedIdentifiers Identifiers ();

        // + (nonnull instancetype)identifiersWithDictionary: (nonnull NSDictionary<NSString *, NSString *> *)identifiers;
        [Static]
        [Export("identifiersWithDictionary:")]
        UAAssociatedIdentifiers Identifiers (NSDictionary<NSString, NSString> identifiers);

        // - (void)setIdentifier:(nullable NSString *)identifier forKey:(nonnull NSString *)key;
        [Export("setIdentifier:forKey:")]
        void SetIdentifier ([NullAllowed] string identifier, string key);
    }

    // @interface UAAttributeMutations : NSObject
    [BaseType(typeof(NSObject))]
    interface UAAttributeMutations
    {

        // - (void)setString:(nonnull NSString *)string forAttribute:(nonnull NSString *)attribute;
        [Export("setString:forAttribute:")]
        void SetString (string @string, string attribute);

        // - (void)setNumber:(nonnull NSNumber *)number forAttribute:(nonnull NSString *)attribute;
        [Export("setNumber:forAttribute:")]
        void SetNumber (NSNumber number, string attribute);

        // - (void)removeAttribute:(nonnull NSString *)attribute;
        [Export("removeAttribute:")]
        void RemoveAttribute (string attribute);

        // + (instancetype)mutations;
        [Export("mutations")]
        UAAttributeMutations Mutations ();
    }

    // @interface UABespokeCloseView : UIView
    [BaseType(typeof(UIView))]
    interface UABespokeCloseView
    {

    }

    // @interface UABeveledLoadingIndicator : UIView
    [BaseType(typeof(UIView))]
    interface UABeveledLoadingIndicator
    {

        // - (void)show;
        [Export("show")]
        void Show ();

        // - (void)hide;
        [Export("hide")]
        void Hide ();
    }

    // @interface UAChannel : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UAChannel
    {
        // + (null_unspecified instancetype)shared;
        [Static]
        [Export("shared")]
        [New]
        UAChannel Shared ();

        // @property (readonly, nonatomic, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; }

        // @property (readwrite, copy, nonatomic) NSArray<NSString *> *_Nonnull tags;
        [Export("tags", ArgumentSemantic.Copy)]
        string[] Tags { get; set; }

        // @property (getter=isChannelTagRegistrationEnabled, assign, readwrite, nonatomic) BOOL channelTagRegistrationEnabled;
        [Export("channelTagRegistrationEnabled")]
        bool ChannelTagRegistrationEnabled { [Bind("isChannelTagRegistrationEnabled")] get; set; }

        // - (void)addTag:(nonnull NSString *)tag;
        [Export("addTag:")]
        void AddTag (string tag);

        // - (void)addTags:(nonnull NSArray<NSString *> *)tags;
        [Export("addTags:")]
        void AddTags (string[] tags);

        // - (void)removeTag:(nonnull NSString *)tag;
        [Export("removeTag:")]
        void RemoveTag (string tag);

        // - (void)removeTags:(nonnull NSArray<NSString *> *)tags;
        [Export("removeTags:")]
        void RemoveTags (string[] tags);

        // - (void)addTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("addTags:group:")]
        void AddTags (string[] tags, string tagGroupID);

        // - (void)removeTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("removeTags:group:")]
        void RemoveTags (string[] tags, string tagGroupID);

        // - (void)setTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("setTags:group:")]
        void SetTags (string[] tags, string tagGroupID);

        // - (void)applyAttributeMutations:(nonnull UAAttributeMutations *)mutations;
        [Export("applyAttributeMutations:")]
        void ApplyAttributeMutations (UAAttributeMutations mutations);

        // - (void)enableChannelCreation;
        [Export("enableChannelCreation")]
        void EnableChannelCreation ();

        // - (void)updateRegistration;
        [Export("updateRegistration")]
        void UpdateRegistration ();
    }

    // @interface UAChannelCapture : NSObject
    [BaseType(typeof(NSObject))]
    interface UAChannelCapture
    {

        // - (void)enable:(NSTimeInterval)duration;
        [Export("enable:")]
        void Enable (double duration);

        // - (void)disable;
        [Export("disable")]
        void Disable ();
    }

    // @interface UAChannelCaptureAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAChannelCaptureAction
    {

    }

    // @interface UACircularRegion : NSObject
    [BaseType(typeof(NSObject))]
    interface UACircularRegion
    {

        // + (nullable instancetype)circularRegionWithRadius:(nonnull NSNumber *)radius latitude:(nonnull NSNumber *)latitude longitude:(nonnull NSNumber *)longitude;
        [Static]
        [Export("circularRegionWithRadius:latitude:longitude:")]
        [return: NullAllowed]
        UACircularRegion CircularRegion (NSNumber radius, NSNumber latitude, NSNumber longitude);
    }

    // @interface UAColorUtils : NSObject
    [BaseType(typeof(NSObject))]
    interface UAColorUtils
    {

        // + (nullable UIColor *)colorWithHexString:(nonnull NSString *)hexString;
        [Static]
        [Export("colorWithHexString:")]
        [return: NullAllowed]
        UIColor Color (string hexString);

        // + (nullable NSString *)hexStringWithColor:(nonnull UIColor *)color;
        [Static]
        [Export("hexStringWithColor:")]
        [return: NullAllowed]
        string HexString (UIColor color);
    }

    // @interface UAComponent : NSObject
    [BaseType(typeof(NSObject))]
    interface UAComponent
    {
        // + (null_unspecified instancetype)shared;
        [Static]
        [Export("shared")]
        UAComponent Shared ();
    }

    // @interface UAConfig : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface UAConfig : INSCopying
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *developmentAppKey;
        [NullAllowed, Export("developmentAppKey")]
        string DevelopmentAppKey { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *developmentAppSecret;
        [NullAllowed, Export("developmentAppSecret")]
        string DevelopmentAppSecret { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *productionAppKey;
        [NullAllowed, Export("productionAppKey")]
        string ProductionAppKey { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *productionAppSecret;
        [NullAllowed, Export("productionAppSecret")]
        string ProductionAppSecret { get; set; }

        // @property (assign, readwrite, nonatomic) UALogLevel developmentLogLevel;
        [Export("developmentLogLevel", ArgumentSemantic.Assign)]
        UALogLevel DevelopmentLogLevel { get; set; }

        // @property (assign, readwrite, nonatomic) UALogLevel productionLogLevel;
        [Export("productionLogLevel", ArgumentSemantic.Assign)]
        UALogLevel ProductionLogLevel { get; set; }

        // @property (nonatomic, assign) UACloudSite site
        [Export("site", ArgumentSemantic.Assign)]
        UACloudSite Site { get; set; }

        // @property (getter=isDataCollectionOptInEnabled, assign, readwrite, nonatomic) BOOL dataCollectionOptInEnabled;
        [Export("dataCollectionOptInEnabled")]
        bool DataCollectionOptInEnabled { [Bind("isDataCollectionOptInEnabled")] get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *defaultAppKey;
        [NullAllowed, Export("defaultAppKey")]
        string DefaultAppKey { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *defaultAppSecret;
        [NullAllowed, Export("defaultAppSecret")]
        string DefaultAppSecret { get; set; }

        // @property (getter=isInProduction, assign, readwrite, nonatomic) BOOL inProduction;
        [Export("inProduction")]
        bool InProduction { [Bind("isInProduction")] get; set; }

        // @property (getter=isAutomaticSetupEnabled, assign, readwrite, nonatomic) BOOL automaticSetupEnabled;
        [Export("automaticSetupEnabled")]
        bool AutomaticSetupEnabled { [Bind("isAutomaticSetupEnabled")] get; set; }

        // @property (readwrite, strong, nonatomic) NSArray<NSString *> *_Nonnull whitelist;
        [Export("whitelist", ArgumentSemantic.Strong)]
        string[] Whitelist { get; set; }

        // @property (readwrite, copy, nonatomic) NSString *_Nonnull itunesID;
        [Export("itunesID")]
        string ItunesID { get; set; }

        // @property (getter=isAnalyticsEnabled, assign, readwrite, nonatomic) BOOL analyticsEnabled;
        [Export("analyticsEnabled")]
        bool AnalyticsEnabled { [Bind("isAnalyticsEnabled")] get; set; }

        // @property (assign, readwrite, nonatomic) BOOL detectProvisioningMode;
        [Export("detectProvisioningMode")]
        bool DetectProvisioningMode { get; set; }

        // @property (readwrite, copy, nonatomic) NSString *_Nonnull messageCenterStyleConfig;
        [Export("messageCenterStyleConfig")]
        string MessageCenterStyleConfig { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL clearUserOnAppRestore;
        [Export("clearUserOnAppRestore")]
        bool ClearUserOnAppRestore { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL clearNamedUserOnAppRestore;
        [Export("clearNamedUserOnAppRestore")]
        bool ClearNamedUserOnAppRestore { get; set; }

        // @property (getter=isChannelCaptureEnabled, assign, readwrite, nonatomic) BOOL channelCaptureEnabled;
        [Export("channelCaptureEnabled")]
        bool ChannelCaptureEnabled { [Bind("isChannelCaptureEnabled")] get; set; }

        // @property (getter=isOpenURLWhitelistingEnabled, assign, readwrite, nonatomic) BOOL openURLWhitelistingEnabled;
        [Export("openURLWhitelistingEnabled")]
        bool OpenURLWhitelistingEnabled { [Bind("isOpenURLWhitelistingEnabled")] get; set; }

        // @property (getter=isChannelCreationDelayEnabled, assign, readwrite, nonatomic) BOOL channelCreationDelayEnabled;
        [Export("channelCreationDelayEnabled")]
        bool ChannelCreationDelayEnabled { [Bind("isChannelCreationDelayEnabled")] get; set; }

        // @property (readwrite, copy, nonatomic) NSDictionary *_Nonnull customConfig;
        [Export("customConfig", ArgumentSemantic.Copy)]
        NSDictionary CustomConfig { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL requestAuthorizationToUseNotifications;
        [Export("requestAuthorizationToUseNotifications")]
        bool RequestAuthorizationToUseNotifications { get; set; }

        // @property (readonly, atomic, nonnull) NSString *appKey;
        [Export("appKey")]
        string AppKey { get; }

        // @property (readonly, atomic, nonnull) NSString *appSecret;
        [Export("appSecret")]
        string AppSecret { get; }

        // @property (readonly, atomic) UALogLevel logLevel;
        [Export("logLevel")]
        UALogLevel LogLevel { get; }

        // + (UAConfig *)config;
        [Static]
        [Export("config")]
        UAConfig Config ();

        // + (nonnull UAConfig *)defaultConfig;
        [Static]
        [Export("defaultConfig")]
        UAConfig DefaultConfig ();

        // + (nonnull UAConfig *)configWithContentsOfFile:(nonnull NSString *)path;
        [Static]
        [Export("configWithContentsOfFile:")]
        UAConfig Config (string path);

        // - (BOOL)validate;
        [Export("validate")]
        bool Validate ();
    }

    // @interface UACustomEvent : UAEvent
    [BaseType(typeof(UAEvent))]
    interface UACustomEvent
    {
        // @property (readwrite, strong, nonatomic, nullable) NSDecimalNumber *eventValue;
        [NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
        NSDecimalNumber EventValue { get; set; }

        // @property (readwrite, copy, nonatomic) NSString *_Nonnull eventName;
        [Export("eventName")]
        string EventName { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *interactionID;
        [NullAllowed, Export("interactionID")]
        string InteractionID { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *interactionType;
        [NullAllowed, Export("interactionType")]
        string InteractionType { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *transactionID;
        [NullAllowed, Export("transactionID")]
        string TransactionID { get; set; }

        // @property (readonly, copy, nonatomic) NSDictionary *_Nonnull properties;
        [Export("properties", ArgumentSemantic.Copy)]
        NSDictionary Properties { get; }

        // @property (readonly, nonatomic) NSDictionary *_Nonnull payload;
        [Export("payload")]
        NSDictionary Payload { get; }

        // + (nonnull instancetype)eventWithName:(nonnull NSString *)eventName;
        [Static]
        [Export("eventWithName:")]
        UACustomEvent Event (string eventName);

        // + (nonnull instancetype)eventWithName:(nonnull NSString *)eventName valueFromString:(nullable NSString *)eventValue;
        [Static]
        [Export("eventWithName:valueFromString:")]
        UACustomEvent Event (string eventName, [NullAllowed] string eventValue);

        // + (nonnull instancetype)eventWithName:(nonnull NSString *)eventName value:(nullable NSNumber *)eventValue;
        [Static]
        [Export("eventWithName:value:")]
        UACustomEvent Event (string eventName, [NullAllowed] NSNumber eventValue);

        // - (void)setInteractionFromMessageCenterMessage:(nonnull NSString *)messageID;
        [Export("setInteractionFromMessageCenterMessage:")]
        void SetInteraction (string messageID);

        // - (void)setBoolProperty:(BOOL)value forKey:(nonnull NSString *)key;
        [Export("setBoolProperty:forKey:")]
        void SetBoolProperty (bool value, string key);

        // - (void)setStringProperty:(nonnull NSString *)value forKey:(nonnull NSString *)key;
        [Export("setStringProperty:forKey:")]
        void SetStringProperty (string value, string key);

        // - (void)setNumberProperty:(nonnull NSNumber *)value forKey:(nonnull NSString *)key;
        [Export("setNumberProperty:forKey:")]
        void SetNumberProperty (NSNumber value, string key);

        // - (void)track;
        [Export("track")]
        void Track ();

        // - (void)setStringArrayProperty:(nonnull NSArray<NSString *> *)value forKey:(nonnull NSString *)key;
        [Export("setStringArrayProperty:forKey:")]
        void SetStringArrayProperty (string[] value, string key);
    }

    // @interface UADeepLinkAction : UAOpenExternalURLAction
    [BaseType(typeof(UAOpenExternalURLAction))]
    interface UADeepLinkAction
    {

    }

    // typedef void (^UADisposalBlock)(void)
    delegate void UADisposalBlock ();

    // @interface UADisposable : NSObject
    [BaseType(typeof(NSObject))]
    interface UADisposable
    {

        // + (nonnull instancetype)disposableWithBlock: (nonnull UADisposalBlock)disposalBlock;
        [Static]
        [Export("disposableWithBlock:")]
        UADisposable Disposable (UADisposalBlock disposalBlock);

        // - (void)dispose;
        [Export("dispose")]
        [New]
        void Dispose ();
    }

    // @interface UAEnableFeatureAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAEnableFeatureAction
    {

    }

    // @interface UAEvent : NSObject
    [BaseType(typeof(NSObject))]
    interface UAEvent
    {
        // @property (readonly, copy, nonatomic) NSString *_Nonnull time;
        [Export("time")]
        string Time { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull eventID;
        [Export("eventID")]
        string EventID { get; }

        // @property (readonly, strong, nonatomic) NSDictionary *_Nonnull data;
        [Export("data", ArgumentSemantic.Strong)]
        NSDictionary Data { get; }

        // @property (readonly, nonatomic) NSString *_Nonnull eventType;
        [Export("eventType")]
        string EventType { get; }

        // - (BOOL)isValid;
        [Export("isValid")]
        bool IsValid ();
    }

    // typedef NSDictionary<NSString *, NSString *> * _Nullable (^UAAnalyticsHeadersBlock)(void)
    delegate string UAAnalyticsHeadersBlock ();

    // @interface UAFetchDeviceInfoAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAFetchDeviceInfoAction
    {

    }

    // @interface UAInstallAttributionEvent : UAEvent
    [BaseType(typeof(UAEvent))]
    interface UAInstallAttributionEvent
    {
        // + (instancetype)event;
        [Static]
        [Export("event")]
        UAInstallAttributionEvent Event ();

        // + (nonnull instancetype) eventWithAppPurchaseDate:(nonnull NSDate *)appPurchaseDate iAdImpressionDate:(nonnull NSDate *)iAdImpressionDate;
        [Static]
        [Export("eventWithAppPurchaseDate:iAdImpressionDate:")]
        UAInstallAttributionEvent Event (NSDate appPurchaseDate, NSDate iAdImpressionDate);
    }

    // @interface UAJSONMatcher : NSObject
    [BaseType(typeof(NSObject))]
    interface UAJSONMatcher
    {
        // @property (readonly, nonatomic) NSDictionary *_Nonnull payload;
        [Export("payload")]
        NSDictionary Payload { get; }

        // + (nonnull instancetype)matcherWithValueMatcher: (nonnull UAJSONValueMatcher *)valueMatcher;
        [Static]
        [Export("matcherWithValueMatcher:")]
        UAJSONMatcher Matcher (UAJSONValueMatcher valueMatcher);

        // + (nonnull instancetype) matcherWithValueMatcher:(nonnull UAJSONValueMatcher *)valueMatcher scope:(nonnull NSArray<NSString *> *)scope;
        [Static]
        [Export("matcherWithValueMatcher:scope:")]
        UAJSONMatcher Matcher (UAJSONValueMatcher valueMatcher, string[] scope);

        // + (nullable instancetype)matcherWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable)error;
        [Static]
        [Export("matcherWithJSON:error:")]
        [return: NullAllowed]
        UAJSONMatcher Matcher (NSObject json, [NullAllowed] out NSError error);

        // - (BOOL)evaluateObject:(nullable id)object;
        [Export("evaluateObject:")]
        bool EvaluateObject ([NullAllowed] NSObject @object);
    }

    // @interface UAJSONPredicate : NSObject
    [BaseType(typeof(NSObject))]
    interface UAJSONPredicate
    {
        // @property (readonly, nonatomic) NSDictionary *_Nonnull payload;
        [Export("payload")]
        NSDictionary Payload { get; }

        // + (nonnull instancetype)predicateWithJSONMatcher: (nonnull UAJSONMatcher *)matcher;
        [Static]
        [Export("predicateWithJSONMatcher:")]
        UAJSONPredicate Predicate (UAJSONMatcher matcher);

        // + (nonnull instancetype)andPredicateWithSubpredicates: (nonnull NSArray<UAJSONPredicate *> *)subpredicates;
        [Static]
        [Export("andPredicateWithSubpredicates:")]
        UAJSONPredicate AndPredicate (UAJSONPredicate[] subpredicates);

        // + (nonnull instancetype)orPredicateWithSubpredicates: (nonnull NSArray<UAJSONPredicate *> *)subpredicates;
        [Static]
        [Export("orPredicateWithSubpredicates:")]
        UAJSONPredicate OrPredicate (UAJSONPredicate[] subpredicates);

        // + (nonnull instancetype)notPredicateWithSubpredicate: (nonnull UAJSONPredicate *)subpredicate;
        [Static]
        [Export("notPredicateWithSubpredicate:")]
        UAJSONPredicate NotPredicate (UAJSONPredicate subpredicate);

        // + (nullable instancetype)predicateWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable)error;
        [Static]
        [Export("predicateWithJSON:error:")]
        [return: NullAllowed]
        UAJSONPredicate Predicate (NSObject json, [NullAllowed] out NSError error);

        // - (BOOL)evaluateObject:(nullable id)object;
        [Export("evaluateObject:")]
        bool EvaluateObject ([NullAllowed] NSObject @object);
    }

    // @interface UAJSONSerialization : NSObject /** * Wrapper around NSJSONSerialization's dataWithJSONObject:options: that checks if the JSON object is * serializable prior to attempting to serialize. This is to avoid crashing when serialization is attempted * on an invalid JSON object. * * @param obj JSON object to serialize into data. * @param opt NSJSONWritingOptions for serialization. * @param error Error to populate if object validation fails. * @return The serialized data if JSON object is valid, otherwise nil. */ + (nullable NSData *)dataWithJSONObject:(id)obj options:(NSJSONWritingOptions)opt error:(NSError **)error; @end
    [BaseType(typeof(NSObject))]
    interface UAJSONSerialization
    {

        // + (nullable NSData *)dataWithJSONObject:(nonnull id)obj options:(NSJSONWritingOptions)opt error:(NSError *_Nullable *_Nullable)error;
        [Static]
        [Export("dataWithJSONObject:options:error:")]
        NSData Data (NSObject obj, NSJsonWritingOptions opt, [NullAllowed] out NSError error);
    }

    // @interface UAJSONValueMatcher : NSObject
    [BaseType(typeof(NSObject))]
    interface UAJSONValueMatcher
    {
        // @property (readonly, nonatomic) NSDictionary *_Nonnull payload;
        [Export("payload")]
        NSDictionary Payload { get; }

        // + (nonnull instancetype)matcherWhereNumberAtLeast:(nonnull NSNumber *)number;
        [Static]
        [Export("matcherWhereNumberAtLeast:")]
        UAJSONValueMatcher MatcherWhereNumberAtLeast (NSNumber number);

        // + (nonnull instancetype) matcherWhereNumberAtLeast:(nonnull NSNumber *)lowerNumber atMost:(nonnull NSNumber *)higherNumber;
        [Static]
        [Export("matcherWhereNumberAtLeast:atMost:")]
        UAJSONValueMatcher MatcherWhereNumberAtLeast (NSNumber lowerNumber, NSNumber higherNumber);

        // + (nonnull instancetype)matcherWhereNumberAtMost:(nonnull NSNumber *)number;
        [Static]
        [Export("matcherWhereNumberAtMost:")]
        UAJSONValueMatcher MatcherWhereNumberAtMost (NSNumber number);

        // + (nonnull instancetype)matcherWhereNumberEquals:(nonnull NSNumber *)number;
        [Static]
        [Export("matcherWhereNumberEquals:")]
        UAJSONValueMatcher MatcherWhereNumberEquals (NSNumber number);

        // + (nonnull instancetype)matcherWhereBooleanEquals:(BOOL)boolean;
        [Static]
        [Export("matcherWhereBooleanEquals:")]
        UAJSONValueMatcher MatcherWhereBooleanEquals (bool boolean);

        // + (nonnull instancetype)matcherWhereStringEquals:(nonnull NSString *)string;
        [Static]
        [Export("matcherWhereStringEquals:")]
        UAJSONValueMatcher MatcherWhereStringEquals (string @string);

        // + (nonnull instancetype)matcherWhereValueIsPresent:(BOOL)present;
        [Static]
        [Export("matcherWhereValueIsPresent:")]
        UAJSONValueMatcher MatcherWhereValueIsPresent (bool present);

        // + (nullable instancetype)matcherWithVersionConstraint: (nonnull NSString *)versionConstraint;
        [Static]
        [Export("matcherWithVersionConstraint:")]
        [return: NullAllowed]
        UAJSONValueMatcher Matcher (string versionConstraint);

        // + (nullable instancetype)matcherWithArrayContainsPredicate: (nonnull UAJSONPredicate *)predicate;
        [Static]
        [Export("matcherWithArrayContainsPredicate:")]
        [return: NullAllowed]
        UAJSONValueMatcher Matcher (UAJSONPredicate predicate);

        // + (nullable instancetype)matcherWithArrayContainsPredicate: (nonnull UAJSONPredicate *)predicate atIndex:(NSUInteger)index;
        [Static]
        [Export("matcherWithArrayContainsPredicate:atIndex:")]
        [return: NullAllowed]
        UAJSONValueMatcher Matcher (UAJSONPredicate predicate, nuint index);

        // + (nullable instancetype)matcherWithJSON:(nonnull id)json error:(NSError *_Nullable *_Nullable)error;
        [Static]
        [Export("matcherWithJSON:error:")]
        [return: NullAllowed]
        UAJSONValueMatcher Matcher (NSObject json, [NullAllowed] out NSError error);

        // - (BOOL)evaluateObject:(nullable id)object;
        [Export("evaluateObject:")]
        bool EvaluateObject ([NullAllowed] NSObject @object);

        // - (BOOL)evaluateObject:(nullable id)object ignoreCase:(BOOL)ignoreCase;
        [Export("evaluateObject:ignoreCase:")]
        bool EvaluateObject ([NullAllowed] NSObject @object, bool ignoreCase);
    }

    // @interface UAJavaScriptCommand : NSObject
    [BaseType(typeof(NSObject))]
    interface UAJavaScriptCommand
    {
        // @property (readonly, copy, nonatomic, nullable) NSString *name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, strong, nonatomic, nullable) NSArray<NSString *> *arguments;
        [NullAllowed, Export("arguments", ArgumentSemantic.Strong)]
        string[] Arguments { get; }

        // @property (readonly, strong, nonatomic, nullable) NSDictionary *options;
        [NullAllowed, Export("options", ArgumentSemantic.Strong)]
        NSDictionary Options { get; }

        // @property (readonly, strong, nonatomic) NSURL *_Nonnull URL;
        [Export("URL", ArgumentSemantic.Strong)]
        NSUrl URL { get; }

        // + (nonnull instancetype)commandForURL:(nonnull NSURL *)URL;
        [Static]
        [Export("commandForURL:")]
        UAJavaScriptCommand Command (NSUrl URL);
    }

    // @protocol UAJavaScriptCommandDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAJavaScriptCommandDelegate
    {

        // - (BOOL)performCommand:(nonnull UAJavaScriptCommand *)command webView:(nonnull WKWebView *)webView;
        [Abstract]
        [Export("performCommand:webView:")]
        bool PerformCommand (UAJavaScriptCommand command, WKWebView webView);
    }

    interface IUAJavaScriptCommandDelegate { }

    // @interface UAJavaScriptEnvironment : NSObject
    [BaseType(typeof(NSObject))]
    interface UAJavaScriptEnvironment
    {

        // + (nonnull instancetype)defaultEnvironment;
        [Static]
        [Export("defaultEnvironment")]
        UAJavaScriptEnvironment DefaultEnvironment ();

        // - (void)addStringGetter:(nonnull NSString *)methodName value:(nullable NSString *)value;
        [Export("addStringGetter:value:")]
        void AddStringGetter (string methodName, [NullAllowed] string value);

        // - (void)addNumberGetter:(nonnull NSString *)methodName value:(nullable NSNumber *)value;
        [Export("addNumberGetter:value:")]
        void AddNumberGetter (string methodName, [NullAllowed] NSNumber value);

        // - (nonnull NSString *)build;
        [Export("build")]
        string Build ();
    }

    // @interface UAMediaEventTemplate : NSObject
    [BaseType(typeof(NSObject))]
    interface UAMediaEventTemplate
    {
        // @property (readwrite, copy, nonatomic, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *category;
        [NullAllowed, Export("category")]
        string Category { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *type;
        [NullAllowed, Export("type")]
        string Type { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *eventDescription;
        [NullAllowed, Export("eventDescription")]
        string EventDescription { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL isFeature;
        [Export("isFeature")]
        bool IsFeature { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *author;
        [NullAllowed, Export("author")]
        string Author { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *publishedDate;
        [NullAllowed, Export("publishedDate")]
        string PublishedDate { get; set; }

        // + (nonnull instancetype)browsedTemplate;
        [Static]
        [Export("browsedTemplate")]
        UAMediaEventTemplate BrowsedTemplate ();

        // + (nonnull instancetype)starredTemplate;
        [Static]
        [Export("starredTemplate")]
        UAMediaEventTemplate StarredTemplate ();

        // + (nonnull instancetype)sharedTemplate;
        [Static]
        [Export("sharedTemplate")]
        UAMediaEventTemplate SharedTemplate ();

        // + (nonnull instancetype)sharedTemplateWithSource:(nullable NSString *)source withMedium:(nullable NSString *)medium;
        [Static]
        [Export("sharedTemplateWithSource:withMedium:")]
        UAMediaEventTemplate SharedTemplate ([NullAllowed] string source, [NullAllowed] string medium);

        // + (nonnull instancetype)consumedTemplate;
        [Static]
        [Export("consumedTemplate")]
        UAMediaEventTemplate ConsumedTemplate ();

        // + (nonnull instancetype)consumedTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("consumedTemplateWithValueFromString:")]
        UAMediaEventTemplate ConsumedTemplate ([NullAllowed] string eventValue);

        // + (nonnull instancetype)consumedTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("consumedTemplateWithValue:")]
        UAMediaEventTemplate ConsumedTemplate ([NullAllowed] NSNumber eventValue);

        // - (nonnull UACustomEvent *)createEvent;
        [Export("createEvent")]
        UACustomEvent CreateEvent ();
    }

    // @interface UAModifyTagsAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAModifyTagsAction
    {

        // - (void)applyChannelTags:(NSArray *)tags;
        [Export("applyChannelTags:")]
        void ApplyChannelTags (NSObject[] tags);

        // - (void)applyChannelTags:(NSArray *)tags group:(NSString *)group;
        [Export("applyChannelTags:group:")]
        void ApplyChannelTags (NSObject[] tags, string group);

        // - (void)applyNamedUserTags:(NSArray *)tags group:(NSString *)group;
        [Export("applyNamedUserTags:group:")]
        void ApplyNamedUserTags (NSObject[] tags, string group);
    }

    // @interface UANSDictionaryValueTransformer : NSValueTransformer @end
    [BaseType(typeof(NSValueTransformer))]
    interface UANSDictionaryValueTransformer
    {

    }

    // @interface UANSURLValueTransformer : NSValueTransformer @end
    [BaseType(typeof(NSValueTransformer))]
    interface UANSURLValueTransformer
    {

    }

    // @interface UANamedUser : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UANamedUser
    {
        // + (null_unspecified instancetype)shared;
        [Static]
        [Export("shared")]
        [New]
        UANamedUser Shared ();

        // @property (readwrite, copy, nonatomic, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // - (void)forceUpdate;
        [Export("forceUpdate")]
        void ForceUpdate ();

        // - (void)addTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("addTags:group:")]
        void AddTags (string[] tags, string tagGroupID);

        // - (void)removeTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("removeTags:group:")]
        void RemoveTags (string[] tags, string tagGroupID);

        // - (void)setTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("setTags:group:")]
        void SetTags (string[] tags, string tagGroupID);

        // - (void)updateTags;
        [Export("updateTags")]
        void UpdateTags ();
    }

    // @interface UANativeBridge : NSObject <WKNavigationDelegate>
    [BaseType(typeof(NSObject))]
    interface UANativeBridge : IWKNavigationDelegate
    {
        // @property (readwrite, nonatomic, nullable) id<UANativeBridgeDelegate> nativeBridgeDelegate;
        [NullAllowed, Export("nativeBridgeDelegate", ArgumentSemantic.Assign)]
        NSObject WeakNativeBridgeDelegate { get; set; }

        [Wrap("WeakNativeBridgeDelegate")]
        [NullAllowed]
        IUANativeBridgeDelegate NativeBridgeDelegate { get; set; }

        // @property (readwrite, nonatomic, nullable) id<WKNavigationDelegate> forwardNavigationDelegate;
        [NullAllowed, Export("forwardNavigationDelegate", ArgumentSemantic.Assign)]
        NSObject WeakForwardNavigationDelegate { get; set; }

        [Wrap("WeakForwardNavigationDelegate")]
        [NullAllowed]
        IWKNavigationDelegate ForwardNavigationDelegate { get; set; }

        // @property (readwrite, nonatomic, nullable) id<UAJavaScriptCommandDelegate> javaScriptCommandDelegate;
        [NullAllowed, Export("javaScriptCommandDelegate", ArgumentSemantic.Assign)]
        NSObject WeakJavaScriptCommandDelegate { get; set; }

        [Wrap("WeakJavaScriptCommandDelegate")]
        [NullAllowed]
        IUAJavaScriptCommandDelegate JavaScriptCommandDelegate { get; set; }

        // @property (readwrite, nonatomic, nullable) id<UANativeBridgeExtensionDelegate> nativeBridgeExtensionDelegate;
        [NullAllowed, Export("nativeBridgeExtensionDelegate", ArgumentSemantic.Assign)]
        NSObject WeakNativeBridgeExtensionDelegate { get; set; }

        [Wrap("WeakNativeBridgeExtensionDelegate")]
        [NullAllowed]
        IUANativeBridgeExtensionDelegate NativeBridgeExtensionDelegate { get; set; }

        // + (nonnull instancetype)nativeBridge;
        [Static]
        [Export("nativeBridge")]
        UANativeBridge NativeBridge ();
    }

    // @protocol UANativeBridgeDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UANativeBridgeDelegate
    {

        // - (void)close;
        [Abstract]
        [Export("close")]
        void Close ();
    }

    interface IUANativeBridgeDelegate { }

    // @protocol UANativeBridgeExtensionDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UANativeBridgeExtensionDelegate
    {

        // - (nonnull NSDictionary *) actionsMetadataForCommand:(nonnull UAJavaScriptCommand *)command webView:(nonnull WKWebView *)webView;
        [Export("actionsMetadataForCommand:webView:")]
        NSDictionary ActionsMetadata (UAJavaScriptCommand command, WKWebView webView);

        // - (void)extendJavaScriptEnvironment:(nonnull UAJavaScriptEnvironment *)js webView:(nonnull WKWebView *)webView;
        [Export("extendJavaScriptEnvironment:webView:")]
        void ExtendJavaScriptEnvironment (UAJavaScriptEnvironment js, WKWebView webView);
    }

    interface IUANativeBridgeExtensionDelegate { }

    // @interface UANotificationAction : NSObject
    [BaseType(typeof(NSObject))]
    interface UANotificationAction
    {
        // @property (readonly, copy, nonatomic) NSString *_Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, assign, nonatomic) UANotificationActionOptions options;
        [Export("options", ArgumentSemantic.Assign)]
        UANotificationActionOptions Options { get; }

        // - (nonnull instancetype)initWithIdentifier:(nonnull NSString *)identifier title:(nonnull NSString *)title options:(UANotificationActionOptions)options;
        [Export("initWithIdentifier:title:options:")]
        IntPtr Constructor (string identifier, string title, UANotificationActionOptions options);

        // + (instancetype)actionWithIdentifier:(NSString *)identifier title:(NSString*) title options:(UANotificationActionOptions) options;
        [Static]
        [Export("actionWithIdentifier:title:options:")]
        UANotificationAction Action (string identifier, string title, UANotificationActionOptions options);

        // - (nonnull UNNotificationAction *)asUNNotificationAction;
        [Export("asUNNotificationAction")]
        UNNotificationAction AsUNNotificationAction ();

        // - (BOOL)isEqualToUNNotificationAction: (nonnull UNNotificationAction *)notificationAction;
        [Export("isEqualToUNNotificationAction:")]
        bool IsEqualToUNNotificationAction (UNNotificationAction notificationAction);
    }

    // @interface UANotificationCategories : NSObject
    [BaseType(typeof(NSObject))]
    interface UANotificationCategories
    {

        // + (nonnull NSSet *)createCategoriesFromFile:(nonnull NSString *)filePath;
        [Static]
        [Export("createCategoriesFromFile:")]
        NSSet CreateCategories (string filePath);

        // + (nullable UANotificationCategory *) createCategory:(nonnull NSString *)categoryId actions:(nonnull NSArray *)actionDefinitions;
        [Static]
        [Export("createCategory:actions:")]
        [return: NullAllowed]
        UANotificationCategory CreateCategory (string categoryId, NSObject[] actionDefinitions);

        // + (nullable UANotificationCategory *) createCategory:(nonnull NSString *)categoryId actions:(nonnull NSArray *)actionDefinitions hiddenPreviewsBodyPlaceholder: (nonnull NSString *)hiddenPreviewsBodyPlaceholder;
        [Static]
        [Export("createCategory:actions:hiddenPreviewsBodyPlaceholder:")]
        [return: NullAllowed]
        UANotificationCategory CreateCategory (string categoryId, NSObject[] actionDefinitions, string hiddenPreviewsBodyPlaceholder);
    }

    // @interface UANotificationCategory : NSObject
    [BaseType(typeof(NSObject))]
    interface UANotificationCategory
    {
        // @property (readonly, copy, nonatomic) NSString *_Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSArray<UANotificationAction *> *_Nonnull actions;
        [Export("actions", ArgumentSemantic.Copy)]
        UANotificationAction[] Actions { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> *_Nonnull intentIdentifiers;
        [Export("intentIdentifiers", ArgumentSemantic.Copy)]
        string[] IntentIdentifiers { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *hiddenPreviewsBodyPlaceholder;
        [NullAllowed, Export("hiddenPreviewsBodyPlaceholder")]
        string HiddenPreviewsBodyPlaceholder { get; }

        // @property (readonly, nonatomic, nullable) NSString *categorySummaryFormat;
        [NullAllowed, Export("categorySummaryFormat")]
        string CategorySummaryFormat { get; }

        // @property (readonly, assign, nonatomic) UANotificationCategoryOptions options;
        [Export("options", ArgumentSemantic.Assign)]
        UANotificationCategoryOptions Options { get; }

        // + (nonnull instancetype) categoryWithIdentifier:(nonnull NSString *)identifier actions:(nonnull NSArray<UANotificationAction *> *)actions intentIdentifiers:(nonnull NSArray<NSString *> *)intentIdentifiers options:(UANotificationCategoryOptions)options;
        [Static]
        [Export("categoryWithIdentifier:actions:intentIdentifiers:options:")]
        UANotificationCategory Category (string identifier, UANotificationAction[] actions, string[] intentIdentifiers, UANotificationCategoryOptions options);

        // + (nonnull instancetype) categoryWithIdentifier:(nonnull NSString *)identifier actions: (nonnull NSArray<UANotificationAction *> *)actions intentIdentifiers: (nonnull NSArray<NSString *> *)intentIdentifiers hiddenPreviewsBodyPlaceholder: (nullable NSString *)hiddenPreviewsBodyPlaceholder options:(UANotificationCategoryOptions)options;
        [Static]
        [Export("categoryWithIdentifier:actions:intentIdentifiers:hiddenPreviewsBodyPlaceholder:options:")]
        UANotificationCategory Category (string identifier, UANotificationAction[] actions, string[] intentIdentifiers, [NullAllowed] string hiddenPreviewsBodyPlaceholder, UANotificationCategoryOptions options);

        // + (nonnull instancetype) categoryWithIdentifier:(nonnull NSString *)identifier actions: (nonnull NSArray<UANotificationAction *> *)actions intentIdentifiers: (nonnull NSArray<NSString *> *)intentIdentifiers hiddenPreviewsBodyPlaceholder: (nullable NSString *)hiddenPreviewsBodyPlaceholder categorySummaryFormat:(nullable NSString *)format options:(UANotificationCategoryOptions)options;
        [Static]
        [Export("categoryWithIdentifier:actions:intentIdentifiers:hiddenPreviewsBodyPlaceholder:categorySummaryFormat:options:")]
        UANotificationCategory Category (string identifier, UANotificationAction[] actions, string[] intentIdentifiers, [NullAllowed] string hiddenPreviewsBodyPlaceholder, [NullAllowed] string format, UANotificationCategoryOptions options);

        // - (null_unspecified UNNotificationCategory *)asUNNotificationCategory;
        [Export("asUNNotificationCategory")]
        UNNotificationCategory AsUNNotificationCategory ();

        // - (BOOL)isEqualToUNNotificationCategory: (nonnull UNNotificationCategory *)category;
        [Export("isEqualToUNNotificationCategory:")]
        bool IsEqualToUNNotificationCategory (UNNotificationCategory category);
    }

    // @interface UANotificationContent : NSObject
    [BaseType(typeof(NSObject))]
    interface UANotificationContent
    {
        // @property (readonly, copy, nonatomic, nullable) NSString *alertTitle;
        [NullAllowed, Export("alertTitle")]
        string AlertTitle { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *alertBody;
        [NullAllowed, Export("alertBody")]
        string AlertBody { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *sound;
        [NullAllowed, Export("sound")]
        string Sound { get; }

        // @property (readonly, strong, nonatomic, nullable) NSNumber *badge;
        [NullAllowed, Export("badge", ArgumentSemantic.Strong)]
        NSNumber Badge { get; }

        // @property (readonly, strong, nonatomic, nullable) NSNumber *contentAvailable;
        [NullAllowed, Export("contentAvailable", ArgumentSemantic.Strong)]
        NSNumber ContentAvailable { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *summaryArgument;
        [NullAllowed, Export("summaryArgument")]
        string SummaryArgument { get; }

        // @property (readonly, strong, nonatomic, nullable) NSNumber *summaryArgumentCount;
        [NullAllowed, Export("summaryArgumentCount", ArgumentSemantic.Strong)]
        NSNumber SummaryArgumentCount { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *threadIdentifier;
        [NullAllowed, Export("threadIdentifier")]
        string ThreadIdentifier { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *targetContentIdentifier;
        [NullAllowed, Export("targetContentIdentifier")]
        string TargetContentIdentifier { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *categoryIdentifier;
        [NullAllowed, Export("categoryIdentifier")]
        string CategoryIdentifier { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *launchImage;
        [NullAllowed, Export("launchImage")]
        string LaunchImage { get; }

        // @property (readonly, copy, nonatomic, nullable) NSDictionary *localizationKeys;
        [NullAllowed, Export("localizationKeys", ArgumentSemantic.Copy)]
        NSDictionary LocalizationKeys { get; }

        // @property (readonly, copy, nonatomic) NSDictionary *_Nonnull notificationInfo;
        [Export("notificationInfo", ArgumentSemantic.Copy)]
        NSDictionary NotificationInfo { get; }

        // @property (readonly, strong, nonatomic, nullable) UNNotification *notification;
        [NullAllowed, Export("notification", ArgumentSemantic.Strong)]
        UNNotification Notification { get; }

        // + (nonnull instancetype)notificationWithNotificationInfo: (nonnull NSDictionary *)notificationInfo;
        [Static]
        [Export("notificationWithNotificationInfo:")]
        UANotificationContent NotificationWithNotificationInfo (NSDictionary notificationInfo);

        // + (nonnull instancetype)notificationWithUNNotification: (nonnull UNNotification *)notification;
        [Static]
        [Export("notificationWithUNNotification:")]
        UANotificationContent NotificationWithUNNotification (UNNotification notification);
    }

    // @interface UANotificationResponse : NSObject
    [BaseType(typeof(NSObject))]
    interface UANotificationResponse
    {
        // @property (readonly, copy, nonatomic) NSString *_Nonnull actionIdentifier;
        [Export("actionIdentifier")]
        string ActionIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull responseText;
        [Export("responseText")]
        string ResponseText { get; }

        // @property (readonly, strong, nonatomic) UANotificationContent *_Nonnull notificationContent;
        [Export("notificationContent", ArgumentSemantic.Strong)]
        UANotificationContent NotificationContent { get; }

        // @property (readonly, strong, nonatomic, nullable) UNNotificationResponse *response;
        [NullAllowed, Export("response", ArgumentSemantic.Strong)]
        UNNotificationResponse Response { get; }

        // + (nonnull instancetype) notificationResponseWithNotificationInfo: (nonnull NSDictionary *)notificationInfo actionIdentifier: (nonnull NSString *)actionIdentifier responseText:(nullable NSString *)responseText;
        [Static]
        [Export("notificationResponseWithNotificationInfo:actionIdentifier:responseText:")]
        UANotificationResponse NotificationResponse (NSDictionary notificationInfo, string actionIdentifier, [NullAllowed] string responseText);

        // + (nonnull instancetype)notificationResponseWithUNNotificationResponse: (nonnull UNNotificationResponse *)response;
        [Static]
        [Export("notificationResponseWithUNNotificationResponse:")]
        UANotificationResponse NotificationResponse (UNNotificationResponse response);
    }

    // @interface UAOpenExternalURLAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAOpenExternalURLAction
    {

        // + (nullable NSURL *)parseURLFromArguments: (nonnull UAActionArguments *)arguments;
        [Static]
        [Export("parseURLFromArguments:")]
        [return: NullAllowed]
        NSUrl ParseURL (UAActionArguments arguments);
    }

    // @interface UAPadding : NSObject
    [BaseType(typeof(NSObject))]
    interface UAPadding
    {
        // @property (readwrite, strong, nonatomic, nullable) NSNumber *top;
        [NullAllowed, Export("top", ArgumentSemantic.Strong)]
        NSNumber Top { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *bottom;
        [NullAllowed, Export("bottom", ArgumentSemantic.Strong)]
        NSNumber Bottom { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *trailing;
        [NullAllowed, Export("trailing", ArgumentSemantic.Strong)]
        NSNumber Trailing { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *leading;
        [NullAllowed, Export("leading", ArgumentSemantic.Strong)]
        NSNumber Leading { get; set; }

        // + (nonnull instancetype)paddingWithTop:(nullable NSNumber *)top bottom:(nullable NSNumber *)bottom leading:(nullable NSNumber *)leading trailing:(nullable NSNumber *)trailing;
        [Static]
        [Export("paddingWithTop:bottom:leading:trailing:")]
        UAPadding Padding ([NullAllowed] NSNumber top, [NullAllowed] NSNumber bottom, [NullAllowed] NSNumber leading, [NullAllowed] NSNumber trailing);

        // + (nonnull instancetype)paddingWithDictionary: (nullable NSDictionary *)paddingDict;
        [Static]
        [Export("paddingWithDictionary:")]
        UAPadding Padding ([NullAllowed] NSDictionary paddingDict);
    }

    // @interface UAPasteboardAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAPasteboardAction
    {

    }

    // @interface UAProximityRegion : NSObject
    [BaseType(typeof(NSObject))]
    interface UAProximityRegion
    {
        // @property (readwrite, strong, nonatomic, nullable) NSNumber *latitude;
        [NullAllowed, Export("latitude", ArgumentSemantic.Strong)]
        NSNumber Latitude { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *longitude;
        [NullAllowed, Export("longitude", ArgumentSemantic.Strong)]
        NSNumber Longitude { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) NSNumber *RSSI;
        [NullAllowed, Export("RSSI", ArgumentSemantic.Strong)]
        NSNumber RSSI { get; set; }

        // + (nullable instancetype)proximityRegionWithID:(nonnull NSString *)proximityID major:(nonnull NSNumber *)major minor:(nonnull NSNumber *)minor;
        [Static]
        [Export("proximityRegionWithID:major:minor:")]
        [return: NullAllowed]
        UAProximityRegion ProximityRegion (string proximityID, NSNumber major, NSNumber minor);
    }

    // @protocol UARegistrationDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UARegistrationDelegate
    {

        // - (void)registrationSucceededForChannelID:(nonnull NSString *)channelID deviceToken:(nonnull NSString *)deviceToken;
        [Export("registrationSucceededForChannelID:deviceToken:")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the UAChannelUpdatedEvent NSNotification.")]
        void RegistrationSucceeded (string channelID, string deviceToken);

        // - (void)registrationFailed;
        [Export("registrationFailed")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the UAChannelRegistrationFailedEvent NSNotification.")]
        void RegistrationFailed ();

        // - (void) notificationRegistrationFinishedWithAuthorizedSettings: (UAAuthorizedNotificationSettings)authorizedSettings categories: (nonnull NSSet< UANotificationCategory *> *)categories status: (UAAuthorizationStatus) status;
        [Export("notificationRegistrationFinishedWithAuthorizedSettings:categories:status:")]
        void NotificationRegistrationFinished (UAAuthorizedNotificationSettings authorizedSettings, NSSet categories, UAAuthorizationStatus status);

        // - (void) notificationRegistrationFinishedWithAuthorizedSettings: (UAAuthorizedNotificationSettings)authorizedSettings categories: (nonnull NSSet< UANotificationCategory *> *)categories;
        [Export("notificationRegistrationFinishedWithAuthorizedSettings:categories:")]
        void NotificationRegistrationFinished (UAAuthorizedNotificationSettings authorizedSettings, NSSet categories);

        // - (void)notificationAuthorizedSettingsDidChange: (UAAuthorizedNotificationSettings)authorizedSettings;
        [Export("notificationAuthorizedSettingsDidChange:")]
        void NotificationAuthorizedSettingsDidChange (UAAuthorizedNotificationSettings authorizedSettings);

        // - (void)apnsRegistrationSucceededWithDeviceToken:(nonnull NSData *)deviceToken;
        [Export("apnsRegistrationSucceededWithDeviceToken:")]
        void ApnsRegistrationSucceeded (NSData deviceToken);

        // - (void)apnsRegistrationFailedWithError:(nonnull NSError *)error;
        [Export("apnsRegistrationFailedWithError:")]
        void ApnsRegistrationFailed (NSError error);
    }

    interface IUARegistrationDelegate { }

    // @protocol UAPushNotificationDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAPushNotificationDelegate
    {

        // - (void)receivedForegroundNotification: (nonnull UANotificationContent *)notificationContent completionHandler: (nonnull void (^)(void))completionHandler;
        [Export("receivedForegroundNotification:completionHandler:")]
        void ReceivedForegroundNotification (UANotificationContent notificationContent, Action completionHandler);

        // - (void)receivedBackgroundNotification: (nonnull UANotificationContent *)notificationContent completionHandler: (nonnull void (^)(UIBackgroundFetchResult)) completionHandler;
        [Export("receivedBackgroundNotification:completionHandler:")]
        void ReceivedBackgroundNotification (UANotificationContent notificationContent, Action<UIBackgroundFetchResult> completionHandler);

        // - (void)receivedNotificationResponse: (nonnull UANotificationResponse *)notificationResponse completionHandler:(nonnull void (^)(void))completionHandler;
        [Export("receivedNotificationResponse:completionHandler:")]
        void ReceivedNotificationResponse (UANotificationResponse notificationResponse, Action completionHandler);

        // - (UNNotificationPresentationOptions)presentationOptionsForNotification: (nonnull UNNotification *)notification;
        [Export("presentationOptionsForNotification:")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use extendPresentationOptions:notification:")]
        UNNotificationPresentationOptions PresentationOptions (UNNotification notification);

        // - (UNNotificationPresentationOptions) extendPresentationOptions:(UNNotificationPresentationOptions)options notification:(nonnull UNNotification *)notification;
        [Export("extendPresentationOptions:notification:")]
        UNNotificationPresentationOptions ExtendPresentationOptions (UNNotificationPresentationOptions options, UNNotification notification);
    }

    interface IUAPushNotificationDelegate { }

    // @interface UAPush : UAComponent
    [BaseType(typeof(UAComponent))]
    interface UAPush
    {
        // + (null_unspecified instancetype)shared;
        [Static]
        [Export("shared")]
        [New]
        UAPush Shared ();

        // @property (assign, readwrite, nonatomic) BOOL backgroundPushNotificationsEnabled;
        [Export("backgroundPushNotificationsEnabled")]
        bool BackgroundPushNotificationsEnabled { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL backgroundPushNotificationsEnabledByDefault;
        [Export("backgroundPushNotificationsEnabledByDefault")]
        bool BackgroundPushNotificationsEnabledByDefault { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL userPushNotificationsEnabled;
        [Export("userPushNotificationsEnabled")]
        bool UserPushNotificationsEnabled { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL pushTokenRegistrationEnabled;
        [Export("pushTokenRegistrationEnabled")]
        bool PushTokenRegistrationEnabled { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL userPushNotificationsEnabledByDefault;
        [Export("userPushNotificationsEnabledByDefault")]
        bool UserPushNotificationsEnabledByDefault { get; set; }

        // @property (readonly, copy, nonatomic, nullable) NSString *deviceToken;
        [NullAllowed, Export("deviceToken")]
        string DeviceToken { get; }

        // @property (readonly, copy, nonatomic, nullable) NSString *channelID;
        [NullAllowed, Export("channelID")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the identifier property on UAChannel.")]
        string ChannelID { get; }

        // @property (assign, readwrite, nonatomic) UANotificationOptions notificationOptions;
        [Export("notificationOptions", ArgumentSemantic.Assign)]
        UANotificationOptions NotificationOptions { get; set; }

        // @property (readwrite, strong, nonatomic) NSSet<UANotificationCategory *> *_Nonnull customCategories;
        [Export("customCategories", ArgumentSemantic.Strong)]
        NSSet CustomCategories { get; set; }

        // @property (readonly, nonatomic) NSSet<UANotificationCategory *> *_Nonnull combinedCategories;
        [Export("combinedCategories")]
        NSSet CombinedCategories { get; }

        // @property (assign, readwrite, nonatomic) BOOL requireAuthorizationForDefaultCategories;
        [Export("requireAuthorizationForDefaultCategories")]
        bool RequireAuthorizationForDefaultCategories { get; set; }

        // @property (readwrite, nonatomic, nullable) id<UAPushNotificationDelegate> pushNotificationDelegate;
        [NullAllowed, Export("pushNotificationDelegate", ArgumentSemantic.Assign)]
        NSObject WeakPushNotificationDelegate { get; set; }

        [Wrap("WeakPushNotificationDelegate")]
        [NullAllowed]
        IUAPushNotificationDelegate PushNotificationDelegate { get; set; }

        // @property (readwrite, nonatomic, nullable) id<UARegistrationDelegate> registrationDelegate;
        [NullAllowed, Export("registrationDelegate", ArgumentSemantic.Assign)]
        NSObject WeakRegistrationDelegate { get; set; }

        [Wrap("WeakRegistrationDelegate")]
        [NullAllowed]
        IUARegistrationDelegate RegistrationDelegate { get; set; }

        // @property (readonly, strong, nonatomic, nullable) UANotificationResponse *launchNotificationResponse;
        [NullAllowed, Export("launchNotificationResponse", ArgumentSemantic.Strong)]
        UANotificationResponse LaunchNotificationResponse { get; }

        // @property (readonly, nonatomic) UAAuthorizedNotificationSettings authorizedNotificationSettings;
        [Export("authorizedNotificationSettings")]
        UAAuthorizedNotificationSettings AuthorizedNotificationSettings { get; }

        // @property (readonly, nonatomic) UAAuthorizationStatus authorizationStatus;
        [Export("authorizationStatus")]
        UAAuthorizationStatus AuthorizationStatus { get; }

        // @property (readonly, assign, nonatomic) BOOL userPromptedForNotifications;
        [Export("userPromptedForNotifications")]
        bool UserPromptedForNotifications { get; }

        // @property (assign, readwrite, nonatomic) UNNotificationPresentationOptions defaultPresentationOptions;
        [Export("defaultPresentationOptions", ArgumentSemantic.Assign)]
        UNNotificationPresentationOptions DefaultPresentationOptions { get; set; }

        // @property (assign, readwrite, nonatomic) NSInteger badgeNumber;
        [Export("badgeNumber", ArgumentSemantic.Assign)]
        nint BadgeNumber { get; set; }

        // @property (getter=isAutobadgeEnabled, assign, readwrite, nonatomic) BOOL autobadgeEnabled;
        [Export("autobadgeEnabled")]
        bool AutobadgeEnabled { [Bind("isAutobadgeEnabled")] get; set; }

        // @property (readwrite, copy, nonatomic) NSArray<NSString *> *_Nonnull tags;
        [Export("tags", ArgumentSemantic.Copy)]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the equivalent property on UAChannel.")]
        string[] Tags { get; set; }

        // @property (getter=isChannelTagRegistrationEnabled, assign, readwrite, nonatomic) BOOL channelTagRegistrationEnabled;
        [Export("channelTagRegistrationEnabled")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the equivalent property on UAChannel.")]
        bool ChannelTagRegistrationEnabled { [Bind("isChannelTagRegistrationEnabled")] get; set; }

        // @property (readonly, copy, nonatomic, nullable) NSDictionary *quietTime;
        [NullAllowed, Export("quietTime", ArgumentSemantic.Copy)]
        NSDictionary QuietTime { get; }

        // @property (readwrite, strong, nonatomic) NSTimeZone *_Nonnull timeZone;
        [Export("timeZone", ArgumentSemantic.Strong)]
        NSTimeZone TimeZone { get; set; }

        // @property (getter=isQuietTimeEnabled, assign, readwrite, nonatomic) BOOL quietTimeEnabled;
        [Export("quietTimeEnabled")]
        bool QuietTimeEnabled { [Bind("isQuietTimeEnabled")] get; set; }

        // - (void)resetBadge;
        [Export("resetBadge")]
        void ResetBadge ();

        // - (void)enableUserPushNotifications:(nonnull void (^)(BOOL))completionHandler;
        [Export("enableUserPushNotifications:")]
        void EnableUserPushNotifications (Action<bool> completionHandler);

        // - (void)addTag:(nonnull NSString *)tag;
        [Export("addTag:")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the equivalent method on UAChannel.")]
        void AddTag (string tag);

        // - (void)addTags:(nonnull NSArray<NSString *> *)tags;
        [Export("addTags:")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the equivalent method on UAChannel.")]
        void AddTags (string[] tags);

        // - (void)removeTag:(nonnull NSString *)tag;
        [Export("removeTag:")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the equivalent method on UAChannel.")]
        void RemoveTag (string tag);

        // - (void)removeTags:(nonnull NSArray<NSString *> *)tags;
        [Export("removeTags:")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the equivalent method on UAChannel.")]
        void RemoveTags (string[] tags);

        // - (void)addTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("addTags:group:")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the equivalent method on UAChannel.")]
        void AddTags (string[] tags, string tagGroupID);

        // - (void)removeTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("removeTags:group:")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the equivalent method on UAChannel.")]
        void RemoveTags (string[] tags, string tagGroupID);

        // - (void)setTags:(nonnull NSArray<NSString *> *)tags group:(nonnull NSString *)tagGroupID;
        [Export("setTags:group:")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the equivalent method on UAChannel.")]
        void SetTags (string[] tags, string tagGroupID);

        // - (void)setQuietTimeStartHour:(NSUInteger)startHour startMinute:(NSUInteger)startMinute endHour:(NSUInteger)endHour endMinute:(NSUInteger)endMinute;
        [Export("setQuietTimeStartHour:startMinute:endHour:endMinute:")]
        void SetQuietTimeStartHour (nuint startHour, nuint startMinute, nuint endHour, nuint endMinute);

        // - (void)enableChannelCreation;
        [Export("enableChannelCreation")]
        [Obsolete("Deprecated - to be removed in SDK version 14.0. Please use the equivalent method on UAChannel.")]
        void EnableChannelCreation ();

        // - (void)updateRegistration;
        [Export("updateRegistration")]
        void UpdateRegistration ();
    }

    // @protocol UAPushProviderDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAPushProviderDelegate
    {
        // @property (assign, readwrite, nonatomic) BOOL pushTokenRegistrationEnabled;
        [Export("pushTokenRegistrationEnabled")]
        bool PushTokenRegistrationEnabled { get; set; }

        // @property (readonly, nonatomic) BOOL userPushNotificationsAllowed;
        [Export("userPushNotificationsAllowed")]
        bool UserPushNotificationsAllowed { get; }

        // @property (readonly, nonatomic) BOOL backgroundPushNotificationsAllowed;
        [Export("backgroundPushNotificationsAllowed")]
        bool BackgroundPushNotificationsAllowed { get; }

        // @property (getter=isAutobadgeEnabled, assign, readwrite, nonatomic) BOOL autobadgeEnabled;
        [Export("autobadgeEnabled")]
        bool AutobadgeEnabled { [Bind("isAutobadgeEnabled")] get; set; }

        // @property (assign, readwrite, nonatomic) NSInteger badgeNumber;
        [Export("badgeNumber", ArgumentSemantic.Assign)]
        nint BadgeNumber { get; set; }

        // @property (getter=isQuietTimeEnabled, assign, readwrite, nonatomic) BOOL quietTimeEnabled;
        [Export("quietTimeEnabled")]
        bool QuietTimeEnabled { [Bind("isQuietTimeEnabled")] get; set; }

        // @property (readonly, copy, nonatomic, nullable) NSDictionary *quietTime;
        [NullAllowed, Export("quietTime", ArgumentSemantic.Copy)]
        NSDictionary QuietTime { get; }

        // @property (readwrite, strong, nonatomic) NSTimeZone *_Nonnull timeZone;
        [Export("timeZone", ArgumentSemantic.Strong)]
        NSTimeZone TimeZone { get; set; }

        // @property (readonly, copy, nonatomic, nullable) NSString *deviceToken;
        [NullAllowed, Export("deviceToken")]
        string DeviceToken { get; }

    }

    interface IUAPushProviderDelegate { }

    // @interface UARegionEvent : UAEvent
    [BaseType(typeof(UAEvent))]
    interface UARegionEvent
    {
        // @property (readwrite, strong, nonatomic, nullable) UAProximityRegion *proximityRegion;
        [NullAllowed, Export("proximityRegion", ArgumentSemantic.Strong)]
        UAProximityRegion ProximityRegion { get; set; }

        // @property (readwrite, strong, nonatomic, nullable) UACircularRegion *circularRegion;
        [NullAllowed, Export("circularRegion", ArgumentSemantic.Strong)]
        UACircularRegion CircularRegion { get; set; }

        // @property (readonly, nonatomic) UABoundaryEvent boundaryEvent;
        [Export("boundaryEvent")]
        UABoundaryEvent BoundaryEvent { get; }

        // @property (readonly, nonatomic) NSString *_Nonnull source;
        [Export("source")]
        string Source { get; }

        // @property (readonly, nonatomic) NSString *_Nonnull regionID;
        [Export("regionID")]
        string RegionID { get; }

        // @property (readonly, nonatomic) NSDictionary *_Nonnull payload;
        [Export("payload")]
        NSDictionary Payload { get; }

        // + (nullable instancetype)regionEventWithRegionID:(nonnull NSString *)regionID source:(nonnull NSString *)source boundaryEvent:(UABoundaryEvent)boundaryEvent;
        [Static]
        [Export("regionEventWithRegionID:source:boundaryEvent:")]
        [return: NullAllowed]
        UARegionEvent RegionEvent (string regionID, string source, UABoundaryEvent boundaryEvent);
    }

    // @interface UARemoveTagsAction : UAModifyTagsAction
    [BaseType(typeof(UAModifyTagsAction))]
    interface UARemoveTagsAction
    {

    }

    // typedef void (^UARequestCompletionHandler)(NSData * _Nullable data, NSURLResponse * _Nullable response, NSError * _Nullable error)
    delegate void UARequestCompletionHandler ([NullAllowed] NSData arg0, [NullAllowed] NSUrlResponse arg1, [NullAllowed] NSError arg2);

    // typedef BOOL (^UARequestRetryBlock)(NSData * _Nullable data, NSURLResponse * _Nullable response)
    delegate bool UARequestRetryBlock ([NullAllowed] NSData arg0, [NullAllowed] NSUrlResponse arg1);

    // @interface UARetailEventTemplate : NSObject
    [BaseType(typeof(NSObject))]
    interface UARetailEventTemplate
    {
        // @property (readwrite, strong, nonatomic, nullable) NSDecimalNumber *eventValue;
        [NullAllowed, Export("eventValue", ArgumentSemantic.Strong)]
        NSDecimalNumber EventValue { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *transactionID;
        [NullAllowed, Export("transactionID")]
        string TransactionID { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *category;
        [NullAllowed, Export("category")]
        string Category { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *eventDescription;
        [NullAllowed, Export("eventDescription")]
        string EventDescription { get; set; }

        // @property (readwrite, copy, nonatomic, nullable) NSString *brand;
        [NullAllowed, Export("brand")]
        string Brand { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL isNewItem;
        [Export("isNewItem")]
        bool IsNewItem { get; set; }

        // + (nonnull instancetype)browsedTemplate;
        [Static]
        [Export("browsedTemplate")]
        UARetailEventTemplate BrowsedTemplate ();

        // + (nonnull instancetype)browsedTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("browsedTemplateWithValueFromString:")]
        UARetailEventTemplate BrowsedTemplate ([NullAllowed] string eventValue);

        // + (nonnull instancetype)browsedTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("browsedTemplateWithValue:")]
        UARetailEventTemplate BrowsedTemplate ([NullAllowed] NSNumber eventValue);

        // + (nonnull instancetype)addedToCartTemplate;
        [Static]
        [Export("addedToCartTemplate")]
        UARetailEventTemplate AddedToCartTemplate ();

        // + (nonnull instancetype)addedToCartTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("addedToCartTemplateWithValueFromString:")]
        UARetailEventTemplate AddedToCartTemplate ([NullAllowed] string eventValue);

        // + (nonnull instancetype)addedToCartTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("addedToCartTemplateWithValue:")]
        UARetailEventTemplate AddedToCartTemplate ([NullAllowed] NSNumber eventValue);

        // + (nonnull instancetype)starredProductTemplate;
        [Static]
        [Export("starredProductTemplate")]
        UARetailEventTemplate StarredProductTemplate ();

        // + (nonnull instancetype)starredProductTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("starredProductTemplateWithValueFromString:")]
        UARetailEventTemplate StarredProductTemplate ([NullAllowed] string eventValue);

        // + (nonnull instancetype)starredProductTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("starredProductTemplateWithValue:")]
        UARetailEventTemplate StarredProductTemplate ([NullAllowed] NSNumber eventValue);

        // + (nonnull instancetype)purchasedTemplate;
        [Static]
        [Export("purchasedTemplate")]
        UARetailEventTemplate PurchasedTemplate ();

        // + (nonnull instancetype)purchasedTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("purchasedTemplateWithValueFromString:")]
        UARetailEventTemplate PurchasedTemplate ([NullAllowed] string eventValue);

        // + (nonnull instancetype)purchasedTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("purchasedTemplateWithValue:")]
        UARetailEventTemplate PurchasedTemplate ([NullAllowed] NSNumber eventValue);

        // + (nonnull instancetype)sharedProductTemplate;
        [Static]
        [Export("sharedProductTemplate")]
        UARetailEventTemplate SharedProductTemplate ();

        // + (nonnull instancetype)sharedProductTemplateWithValueFromString: (nullable NSString *)eventValue;
        [Static]
        [Export("sharedProductTemplateWithValueFromString:")]
        UARetailEventTemplate SharedProductTemplate ([NullAllowed] string eventValue);

        // + (nonnull instancetype)sharedProductTemplateWithValue: (nullable NSNumber *)eventValue;
        [Static]
        [Export("sharedProductTemplateWithValue:")]
        UARetailEventTemplate SharedProductTemplate ([NullAllowed] NSNumber eventValue);

        // + (nonnull instancetype) sharedProductTemplateWithSource:(nullable NSString *)source withMedium:(nullable NSString *)medium;
        [Static]
        [Export("sharedProductTemplateWithSource:withMedium:")]
        UARetailEventTemplate SharedProductTemplate ([NullAllowed] string source, [NullAllowed] string medium);

        // + (nonnull instancetype) sharedProductTemplateWithValueFromString:(nullable NSString *)eventValue withSource:(nullable NSString *)source withMedium:(nullable NSString *)medium;
        [Static]
        [Export("sharedProductTemplateWithValueFromString:withSource:withMedium:")]
        UARetailEventTemplate SharedProductTemplate ([NullAllowed] string eventValue, [NullAllowed] string source, [NullAllowed] string medium);

        // + (nonnull instancetype) sharedProductTemplateWithValue:(nullable NSNumber *)eventValue withSource:(nullable NSString *)source withMedium:(nullable NSString *)medium;
        [Static]
        [Export("sharedProductTemplateWithValue:withSource:withMedium:")]
        UARetailEventTemplate SharedProductTemplate ([NullAllowed] NSNumber eventValue, [NullAllowed] string source, [NullAllowed] string medium);

        // - (nonnull UACustomEvent *)createEvent;
        [Export("createEvent")]
        UACustomEvent CreateEvent ();
    }

    // @interface UARuntimeConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface UARuntimeConfig
    {
        // @property (readonly, getter=isAutomaticSetupEnabled, atomic) BOOL automaticSetupEnabled;
        [Export("automaticSetupEnabled")]
        bool AutomaticSetupEnabled { get; }

        // @property (readonly, atomic) NSArray<NSString *> *_Nonnull whitelist;
        [Export("whitelist")]
        string[] Whitelist { get; }

        // @property (readonly, getter=isAnalyticsEnabled, atomic) BOOL analyticsEnabled;
        [Export("analyticsEnabled")]
        bool AnalyticsEnabled { get; }

        // @property (readonly, atomic) NSString *_Nonnull messageCenterStyleConfig;
        [Export("messageCenterStyleConfig")]
        string MessageCenterStyleConfig { get; }

        // @property (readonly, atomic) NSString *_Nonnull itunesID;
        [Export("itunesID")]
        string ItunesID { get; }

        // @property (readonly, atomic) BOOL clearUserOnAppRestore;
        [Export("clearUserOnAppRestore")]
        bool ClearUserOnAppRestore { get; }

        // @property (readonly, atomic) BOOL clearNamedUserOnAppRestore;
        [Export("clearNamedUserOnAppRestore")]
        bool ClearNamedUserOnAppRestore { get; }

        // @property (readonly, getter=isChannelCaptureEnabled, atomic) BOOL channelCaptureEnabled;
        [Export("channelCaptureEnabled")]
        bool ChannelCaptureEnabled { get; }

        // @property (readonly, getter=isOpenURLWhitelistingEnabled, atomic) BOOL openURLWhitelistingEnabled;
        [Export("openURLWhitelistingEnabled")]
        bool OpenURLWhitelistingEnabled { get; }

        // @property (readonly, getter=isChannelCreationDelayEnabled, atomic) BOOL channelCreationDelayEnabled;
        [Export("channelCreationDelayEnabled")]
        bool ChannelCreationDelayEnabled { get; }

        // @property (readonly, atomic) BOOL requestAuthorizationToUseNotifications;
        [Export("requestAuthorizationToUseNotifications")]
        bool RequestAuthorizationToUseNotifications { get; }

        // @property (readonly, getter=isDataCollectionOptInEnabled, atomic) BOOL dataCollectionOptInEnabled;
        [Export("dataCollectionOptInEnabled")]
        bool DataCollectionOptInEnabled { get; }

        // @property (readonly, atomic, nonnull) NSString *appKey;
        [Export("appKey")]
        string AppKey { get; }

        // @property (readonly, atomic, nonnull) NSString *appSecret;
        [Export("appSecret")]
        string AppSecret { get; }

        // @property (readonly, atomic) UALogLevel logLevel;
        [Export("logLevel")]
        UALogLevel LogLevel { get; }

        // @property (readonly, getter=isInProduction, atomic) BOOL inProduction;
        [Export("inProduction")]
        bool InProduction { get; }

        // @property (readonly, atomic) NSDictionary *_Nonnull customConfig;
        [Export("customConfig")]
        NSDictionary CustomConfig { get; }

    }

    // @interface UAShareAction : UAAction
    [BaseType(typeof(UAAction))]
    interface UAShareAction
    {

    }

    // @interface UATextInputNotificationAction : UANotificationAction
    [BaseType(typeof(UANotificationAction))]
    interface UATextInputNotificationAction
    {
        // @property (readonly, copy, nonatomic) NSString *_Nonnull textInputButtonTitle;
        [Export("textInputButtonTitle")]
        string TextInputButtonTitle { get; }

        // @property (readonly, copy, nonatomic) NSString *_Nonnull textInputPlaceholder;
        [Export("textInputPlaceholder")]
        string TextInputPlaceholder { get; }

        // - (nonnull instancetype) initWithIdentifier:(nonnull NSString *)identifier title:(nonnull NSString *)title textInputButtonTitle:(nonnull NSString *)textInputButtonTitle textInputPlaceholder:(nonnull NSString *)textInputPlaceholder options:(UANotificationActionOptions)options;
        [Export("initWithIdentifier:title:textInputButtonTitle:textInputPlaceholder:options:")]
        IntPtr Constructor (string identifier, string title, string textInputButtonTitle, string textInputPlaceholder, UANotificationActionOptions options);

        // + (instancetype) actionWithIdentifier:(nonnull NSString *)identifier title:(nonnull NSString *)title textInputButtonTitle:(nonnull NSString *)textInputButtonTitle textInputPlaceholder:(nonnull NSString *)textInputPlaceholder options:(UANotificationActionOptions)options;
        [Static]
        [Export("actionWithIdentifier:title:textInputButtonTitle:textInputPlaceholder:options:")]
        UATextInputNotificationAction Action (string identifier, string title, string textInputButtonTitle, string textInputPlaceholder, UANotificationActionOptions options);
    }

    // @interface UAUtils : NSObject
    [BaseType(typeof(NSObject))]
    interface UAUtils
    {

        // + (BOOL)float:(CGFloat)float1 isEqualToFloat:(CGFloat)float2 withAccuracy:(CGFloat)accuracy;
        [Static]
        [Export("float:isEqualToFloat:withAccuracy:")]
        bool Float (nfloat float1, nfloat float2, nfloat accuracy);

        // + (nullable NSString *)nilIfEmpty:(nullable NSString *)str;
        [Static]
        [Export("nilIfEmpty:")]
        [return: NullAllowed]
        string NilIfEmpty ([NullAllowed] string str);

        // + (nonnull NSString *)deviceModelName;
        [Static]
        [Export("deviceModelName")]
        string DeviceModelName ();

        // + (nonnull NSString *)appAuthHeaderString;
        [Static]
        [Export("appAuthHeaderString")]
        string AppAuthHeaderString ();

        // + (nonnull NSString *)authHeaderStringWithName:(nonnull NSString *)username password:(nonnull NSString *)password;
        [Static]
        [Export("authHeaderStringWithName:password:")]
        string AuthHeaderString (string username, string password);

        // + (nonnull NSString *)pluralize:(int)count singularForm:(nonnull NSString *)singular pluralForm:(nonnull NSString *)plural;
        [Static]
        [Export("pluralize:singularForm:pluralForm:")]
        string Pluralize (nint count, string singular, string plural);

        // + (NSString *)getReadableFileSizeFromBytes:(double)bytes;
        [Static]
        [Export("getReadableFileSizeFromBytes:")]
        string GetReadableFileSize (double bytes);

        // + (nonnull NSDateFormatter *)ISODateFormatterUTC;
        [Static]
        [Export("ISODateFormatterUTC")]
        NSDateFormatter ISODateFormatterUTC ();

        // + (nonnull NSDateFormatter *)ISODateFormatterUTCWithDelimiter;
        [Static]
        [Export("ISODateFormatterUTCWithDelimiter")]
        NSDateFormatter ISODateFormatterUTCWithDelimiter ();

        // + (nullable NSDate *)parseISO8601DateFromString:(nonnull NSString *)timestamp;
        [Static]
        [Export("parseISO8601DateFromString:")]
        [return: NullAllowed]
        NSDate ParseISO8601Date (string timestamp);

        // + (BOOL)addSkipBackupAttributeToItemAtURL:(nonnull NSURL *)url;
        [Static]
        [Export("addSkipBackupAttributeToItemAtURL:")]
        bool AddSkipBackupAttributeToItemAtURL (NSUrl url);

        // + (nullable UIWindow *)mainWindow;
        [Static]
        [Export("mainWindow")]
        [return: NullAllowed]
        UIWindow MainWindow ();

        // + (nullable UIWindow *)mainWindow:(nullable UIWindowScene *)scene;
        [Static]
        [Export("mainWindow:")]
        [return: NullAllowed]
        UIWindow MainWindow ([NullAllowed] UIWindowScene scene);

        // + (nullable UIWindow *)windowForView:(nonnull UIView *)view;
        [Static]
        [Export("windowForView:")]
        [return: NullAllowed]
        UIWindow Window (UIView view);

        // + (nullable UIViewController *)topController;
        [Static]
        [Export("topController")]
        [return: NullAllowed]
        UIViewController TopController ();

        // + (nullable NSString *)carrierName;
        [Static]
        [Export("carrierName")]
        [return: NullAllowed]
        string CarrierName ();

        // + (nonnull NSString *)connectionType;
        [Static]
        [Export("connectionType")]
        string ConnectionType ();

        // + (BOOL)isSilentPush:(nonnull NSDictionary *)notification;
        [Static]
        [Export("isSilentPush:")]
        bool IsSilentPush (NSDictionary notification);

        // + (BOOL)isAlertingPush:(nonnull NSDictionary *)notification;
        [Static]
        [Export("isAlertingPush:")]
        bool IsAlertingPush (NSDictionary notification);

        // + (UIBackgroundFetchResult)mergeFetchResults:(nonnull NSArray *)fetchResults;
        [Static]
        [Export("mergeFetchResults:")]
        UIBackgroundFetchResult MergeFetchResults (NSObject[] fetchResults);

        // + (nonnull NSString *)deviceTokenStringFromDeviceToken: (nonnull NSData *)deviceToken;
        [Static]
        [Export("deviceTokenStringFromDeviceToken:")]
        string DeviceTokenString (NSData deviceToken);

        // + (NSComparisonResult)compareVersion:(nonnull NSString *)version1 toVersion:(nonnull NSString *)version2;
        [Static]
        [Export("compareVersion:toVersion:")]
        NSComparisonResult CompareVersion (string version1, string version2);

        // + (nonnull NSData *)sha256DigestWithString:(nonnull NSString *)input;
        [Static]
        [Export("sha256DigestWithString:")]
        NSData Sha256Digest (string input);

        // + (nonnull NSString *)sha256HashWithString:(nonnull NSString *)input;
        [Static]
        [Export("sha256HashWithString:")]
        string Sha256Hash (string input);
    }

    // @interface UAVersionMatcher : NSObject
    [BaseType(typeof(NSObject))]
    interface UAVersionMatcher
    {
        // @property (readonly, strong, nonatomic) NSString *_Nonnull versionConstraint;
        [Export("versionConstraint")]
        string VersionConstraint { get; }

        // + (nullable instancetype)matcherWithVersionConstraint: (nonnull NSString *)versionConstraint;
        [Static]
        [Export("matcherWithVersionConstraint:")]
        [return: NullAllowed]
        UAVersionMatcher Matcher (string versionConstraint);

        // - (BOOL)evaluateObject:(nullable id)object;
        [Export("evaluateObject:")]
        bool EvaluateObject ([NullAllowed] NSObject @object);

        // + (BOOL)isExactVersion:(nonnull NSString *)versionConstraint;
        [Static]
        [Export("isExactVersion:")]
        bool IsExactVersion (string versionConstraint);

        // + (BOOL)isSubVersion:(nonnull NSString *)versionConstraint;
        [Static]
        [Export("isSubVersion:")]
        bool IsSubVersion (string versionConstraint);

        // + (BOOL)isVersionRange:(nonnull NSString *)versionConstraint;
        [Static]
        [Export("isVersionRange:")]
        bool IsVersionRange (string versionConstraint);
    }

    // @interface UAViewUtils : NSObject /** * Constrains the contained view to the center of the container with equivalent size * * This method has the side effect of setting both views' translatesAutoresizingMasksIntoConstraints parameters to NO. * This is done to ensure that autoresizing mask constraints do not conflict with the centering constraints. * * @param container The container view. * @param contained The contained view. */ + (void)applyContainerConstraintsToContainer:(UIView *)container containedView:(UIView *)contained; @end
    [BaseType(typeof(NSObject))]
    interface UAViewUtils
    {

        // + (void)applyContainerConstraintsToContainer:(UIView *)container containedView:(UIView *)contained;
        [Static]
        [Export("applyContainerConstraintsToContainer:containedView:")]
        void ApplyContainerConstraintsToContainer (UIView container, UIView contained);
    }

    // @interface UAWalletAction : UAOpenExternalURLAction
    [BaseType(typeof(UAOpenExternalURLAction))]
    interface UAWalletAction
    {

    }

    // @interface UAWebView : WKWebView @end
    [BaseType(typeof(WKWebView))]
    interface UAWebView
    {

    }

    // @protocol UAWhitelistDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UAWhitelistDelegate
    {

        // - (BOOL)acceptWhitelisting:(nonnull NSURL *)url scope:(UAWhitelistScope)scope;
        [Export("acceptWhitelisting:scope:")]
        bool AcceptWhitelisting (NSUrl url, UAWhitelistScope scope);
    }

    interface IUAWhitelistDelegate { }

    // @interface UAWhitelist : NSObject
    [BaseType(typeof(NSObject))]
    interface UAWhitelist
    {
        // @property (getter=isOpenURLWhitelistingEnabled, assign, readwrite, nonatomic) BOOL openURLWhitelistingEnabled;
        [Export("openURLWhitelistingEnabled")]
        bool OpenURLWhitelistingEnabled { [Bind("isOpenURLWhitelistingEnabled")] get; set; }

        // @property (readwrite, nonatomic, nullable) id<UAWhitelistDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        IUAWhitelistDelegate Delegate { get; set; }

        // + (nonnull instancetype)whitelistWithConfig:(nonnull UARuntimeConfig *)config;
        [Static]
        [Export("whitelistWithConfig:")]
        UAWhitelist Whitelist (UARuntimeConfig config);

        // - (BOOL)addEntry:(nonnull NSString *)patternString;
        [Export("addEntry:")]
        bool AddEntry (string patternString);

        // - (BOOL)addEntry:(nonnull NSString *)patternString scope:(UAWhitelistScope)scope;
        [Export("addEntry:scope:")]
        bool AddEntry (string patternString, UAWhitelistScope scope);

        // - (BOOL)isWhitelisted:(nonnull NSURL *)url;
        [Export("isWhitelisted:")]
        bool IsWhitelisted (NSUrl url);

        // - (BOOL)isWhitelisted:(nonnull NSURL *)url scope:(UAWhitelistScope)scope;
        [Export("isWhitelisted:scope:")]
        bool IsWhitelisted (NSUrl url, UAWhitelistScope scope);
    }

    // @protocol UADeepLinkDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UADeepLinkDelegate
    {

        // - (void)receivedDeepLink:(nonnull NSURL *)url completionHandler:(nonnull void (^)(void))completionHandler;
        [Export("receivedDeepLink:completionHandler:")]
        void ReceivedDeepLink (NSUrl url, Action completionHandler);
    }

    interface IUADeepLinkDelegate { }

    // @interface UAirship : NSObject
    [BaseType(typeof(NSObject))]
    interface UAirship
    {
        // @property (readonly, strong, nonatomic) UARuntimeConfig *_Nonnull config;
        [Export("config", ArgumentSemantic.Strong)]
        UARuntimeConfig Config { get; }

        // @property (readonly, strong, nonatomic) UAActionRegistry *_Nonnull actionRegistry;
        [Export("actionRegistry", ArgumentSemantic.Strong)]
        UAActionRegistry ActionRegistry { get; }

        // @property (readonly, strong, nonatomic) UAApplicationMetrics *_Nonnull applicationMetrics;
        [Export("applicationMetrics", ArgumentSemantic.Strong)]
        UAApplicationMetrics ApplicationMetrics { get; }

        // @property (readonly, assign, nonatomic) BOOL remoteNotificationBackgroundModeEnabled;
        [Export("remoteNotificationBackgroundModeEnabled")]
        bool RemoteNotificationBackgroundModeEnabled { get; }

        // @property (readwrite, nonatomic, nullable) id<UAJavaScriptCommandDelegate> javaScriptCommandDelegate;
        [NullAllowed, Export("javaScriptCommandDelegate", ArgumentSemantic.Assign)]
        NSObject WeakJavaScriptCommandDelegate { get; set; }

        [Wrap("WeakJavaScriptCommandDelegate")]
        [NullAllowed]
        IUAJavaScriptCommandDelegate JavaScriptCommandDelegate { get; set; }

        // @property (readwrite, nonatomic, nullable) id<UADeepLinkDelegate> deepLinkDelegate;
        [NullAllowed, Export("deepLinkDelegate", ArgumentSemantic.Assign)]
        NSObject WeakDeepLinkDelegate { get; set; }

        [Wrap("WeakDeepLinkDelegate")]
        [NullAllowed]
        IUADeepLinkDelegate DeepLinkDelegate { get; set; }

        // @property (readonly, strong, nonatomic) UAWhitelist *_Nonnull whitelist;
        [Export("whitelist", ArgumentSemantic.Strong)]
        UAWhitelist Whitelist { get; }

        // @property (readonly, strong, nonatomic) UAChannelCapture *_Nonnull channelCapture;
        [Export("channelCapture", ArgumentSemantic.Strong)]
        UAChannelCapture ChannelCapture { get; }

        // @property (getter=isDataCollectionEnabled, assign, readwrite, nonatomic) BOOL dataCollectionEnabled;
        [Export("dataCollectionEnabled")]
        bool DataCollectionEnabled { [Bind("isDataCollectionEnabled")] get; set; }

        // + (void)setLogging:(BOOL)enabled;
        [Static]
        [Export("setLogging:")]
        void SetLogging (bool enabled);

        // + (void)setLogLevel:(UALogLevel)level;
        [Static]
        [Export("setLogLevel:")]
        void SetLogLevel (UALogLevel level);

        // + (void)setLoudImpErrorLogging:(BOOL)enabled;
        [Static]
        [Export("setLoudImpErrorLogging:")]
        void SetLoudImpErrorLogging (bool enabled);

        // + (void)takeOff:(nullable UAConfig *)config;
        [Static]
        [Export("takeOff:")]
        void TakeOff ([NullAllowed] UAConfig config);

        // + (void)takeOff;
        [Static]
        [Export("takeOff")]
        void TakeOff ();

        // + (null_unspecified UAirship *)shared;
        [Static]
        [Export("shared")]
        UAirship Shared ();

        // + (null_unspecified UAChannel *)channel;
        [Static]
        [Export("channel")]
        UAChannel Channel ();

        // + (null_unspecified UAPush *)push;
        [Static]
        [Export("push")]
        UAPush Push ();

        // + (null_unspecified UANamedUser *)namedUser;
        [Static]
        [Export("namedUser")]
        UANamedUser NamedUser ();

        // + (null_unspecified UAAnalytics *)analytics;
        [Static]
        [Export("analytics")]
        UAAnalytics Analytics ();
    }

    // @interface UAirshipCoreResources : NSObject
    [BaseType(typeof(NSObject))]
    interface UAirshipCoreResources
    {

        // + (nonnull NSBundle *)bundle;
        [Static]
        [Export("bundle")]
        NSBundle Bundle ();
    }

    // @interface UAirshipVersion : NSObject
    [BaseType(typeof(NSObject))]
    interface UAirshipVersion
    {

        // + (nonnull NSString *)get;
        [Static]
        [Export("get")]
        string Get ();
    }


}
